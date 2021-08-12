using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Mail;
namespace EventOrganizerApp
{   //Új árajánlat készítését végző form.
    public partial class frm_NewEventTender : Form
    {
        private frm_CheckTender frmCheckTender; //A kész árajánlat formja.
        private frm_MainMenu frmMainMenu;       //Főmenü form
        private Tender newTender;               //Árajánlat.
        private DataBase db;                    //Adatbázis.
        private string query;                   //Adatbázis lekérdezésre használandó adattag.

        //Létrehozza az alapértelmezett adatbázis(DataBase) és árajánlat(Tender) objektumokat. 
        public frm_NewEventTender()
        {
            InitializeComponent();
            db = new DataBase();
            newTender = new Tender();
        }

        //A form betöltése alatt lekérdezi és feltölti a  cbx_EventType és cbx_DrinkServiceType comboboxokat az adatbázisból.
        private void frm_NewEventTender_Load(object sender, EventArgs e)
        {
            try
            {
                query = "SELECT name FROM events";
                fillCombox(query, cbx_EventType, "name", "name");
                query = "SELECT name FROM drinkmenus";
                fillCombox(query, cbx_DrinkServiceType, "name", "name");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hibatörtént az adatbázissal kapcsolatban! Hívja az adminisztrátort! \n\n Hibaüzenet:\n{ex} ", "Hiba!", MessageBoxButtons.OK);
            }

        }
        //Használhatóvá teszik a rendezvény további adatainak regisztrálási lehetőségeit a létszám kitöltése után.
        //Ha már történt előzetes számítás, és megváltozott a létszám értéke, akkor törli az előzetes számítás által megjelnített értékeket és
        //a dtgv_Employees sorait törli majd újra kitölti és kiszámítja.
        private void txt_NumberOfGuests_TextChanged(object sender, EventArgs e)
        {

            int numberOfGuests = 0;
            if ((int.TryParse(txt_NumberOfGuests.Text, out numberOfGuests) && !txt_NumberOfGuests.Text.Contains("-")) && cbx_EventType.Text != "")
            {
                if (gbx_PreCalculationBox.Visible)
                {
                    lbl_MealMenuPricePerPersonResult.Text = "";
                    lbl_MealMenuTotalPriceResult.Text = "";
                    lbl_DrinkMenuPricePerPersonResult.Text = "";
                    lbl_DrinkMenuTotalPriceResult.Text = "";
                    lbl_MenuPricePerPersonResult.Text = "";
                    lbl_TotalMenuPriceResult.Text = "";
                    lbl_EmployeePriceResult.Text = "";
                }

                txt_NumberOfGuests.BackColor = Color.LightGreen;
                newTender.setNumberOfGuests(numberOfGuests);
                gbx_Meal.Enabled = true;
                gbx_Drinks.Enabled = true;
                btn_PreCalculation.Enabled = true;
                btn_SaveTender.Enabled = true;
                gbx_Employees.Enabled = true;

                try
                {
                    EmployeeList employeeList = new EmployeeList(numberOfGuests);
                    newTender.setEmployeeList(employeeList);

                    int n = 0;
                    dtgv_Employees.Rows.Clear();
                    foreach (Employee employee in newTender.getEmployeeList().getList())
                    {
                        n = dtgv_Employees.Rows.Add();
                        dtgv_Employees.Rows[n].Cells[0].Value = employee.getEmployeeType();
                        dtgv_Employees.Rows[n].Cells[1].Value = employee.getNumberOfEmployees();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hibatörtént az adatbázissal kapcsolatban! Hívja az adminisztrátort! \n\n Hibaüzenet:\n{ex} ", "Hiba!", MessageBoxButtons.OK);
                }
            }
            else
            {
                btn_PreCalculation.Enabled = false;
                btn_SaveTender.Enabled = false;
                txt_NumberOfGuests.BackColor = Color.IndianRed;
                MessageBox.Show("Ki kell tölteni a Vendégek száma mezőt!", "Hiba", MessageBoxButtons.OK);
            }
        }
        //A rendezvénytípus változásának hatására feltölti a gbx_Meal-ben szereplő comboboxok tartalmát.
        private void cbx_EventType_SelectedValueChanged(object sender, EventArgs e)
        {
            newTender.setEventType(cbx_EventType.Text);
            //Itt kell összeállítani az innerjoinos queryt az events_meals join tableből
            try
            {
                query = "SELECT name FROM meals WHERE course='e'";
                fillCombox(query, cbx_Starters, "name", "name");
                query = "SELECT name FROM meals WHERE course='f'";
                fillCombox(query, cbx_MainCourses, "name", "name");
                query = "SELECT name FROM meals WHERE course='k'";
                fillCombox(query, cbx_SideDishes, "name", "name");
                query = "SELECT name FROM meals WHERE course='t'";
                fillCombox(query, cbx_Platters, "name", "name");
                query = "SELECT name FROM meals WHERE course='s'";
                fillCombox(query, cbx_Pickles, "name", "name");
                query = "SELECT name FROM meals WHERE course='d'";
                fillCombox(query, cbx_Desserts, "name", "name");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hibatörtént az adatbázissal kapcsolatban! Hívja az adminisztrátort! \n\n Hibaüzenet:\n{ex} ", "Hiba!", MessageBoxButtons.OK);
            }
            
        }

        //A választott italszervizcsomag megjelnítését végzi.
        private void cbx_DrinkServiceType_SelectedValueChanged(object sender, EventArgs e)
        {
            //az elágazás frm_NewEventTender_Load esemény adatbázisból való feltöltése közben elkapott hibás Data.DLL exception miatt szükséges
            if (!cbx_DrinkServiceType.Text.Contains("Data"))
            {
                try
                {
                    newTender.getDrinkMenu().setByName(cbx_DrinkServiceType.Text);
                    lbl_DrinkMenuInfo.Visible = true;
                    lbl_DrinkMenuInfo.Text = $"- {newTender.getDrinkMenu().getDescription()} \n {newTender.getDrinkMenu().getSalePricePerPerson()} Ft/fő";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hibatörtént az adatbázissal kapcsolatban! Hívja az adminisztrátort! \n\n Hibaüzenet:\n{ex} ", "Hiba!", MessageBoxButtons.OK);
                }
            }
        }

        //Ez az esemény végezi el a szükséges számításokat(étel és ital menü beeszerzési/eladási teljes/1 főre  vonatkozó ár kalkulációkat)
        //és jeleníti meg az előzetes számítás eredményeinek kialakított "gbx_PreCalculationBox"-ot.
        private void btn_PreCalculation_Click(object sender, EventArgs e)
        {
            gbx_PreCalculationBox.Visible = true;
            newTender.calculateTenderValues(int.Parse(txt_NumberOfGuests.Text));

            lbl_MealMenuPricePerPersonResult.Text =$"{newTender.getMealMenu().getSalePricePerPerson()}.- Ft/fő" ;
            lbl_MealMenuTotalPriceResult.Text = $"{newTender.getMealMenu().getTotalSalePrice()}.- Ft";
            lbl_DrinkMenuPricePerPersonResult.Text = $"{newTender.getDrinkMenu().getSalePricePerPerson()}.- Ft/fő";
            lbl_DrinkMenuTotalPriceResult.Text = $"{newTender.getDrinkMenu().getTotalSalePrice()}.- Ft";
            lbl_MenuPricePerPersonResult.Text = $"{newTender.getMenu().getSalePricePerPerson()}.- Ft";
            lbl_TotalMenuPriceResult.Text = $"{newTender.getMenu().getTotalSalePrice()}.- Ft";
            lbl_EmployeePriceResult.Text =$"{newTender.getEmployeeList().getFinalPayment()}.- Ft";
            lbl_PlaceRentingPriceResult.Text = $"{newTender.getPlace().getRentingPrice()}.- Ft";
            lbl_TotalPriceEventResult.Text = $"{newTender.getTotalSalePrice()}.- Ft";
            lbl_ProfitResult.Text = $"{newTender.getProfit()}.- Ft";
        }

        //az ételek hozzáadására és törlésére használandó _Click események.
        private void btn_AddStarter_Click(object sender, EventArgs e)
        {
            addMealOnClickEvent(txt_StarterProtion,cbx_Starters);
        }
        private void btn_RemoveStarter_Click(object sender, EventArgs e)
        {
            removeMealOnClickEvent(txt_StarterProtion, cbx_Starters);
        }
        private void btn_AddMainCourse_Click(object sender, EventArgs e)
        {
            addMealOnClickEvent(txt_MainCoursePortion,cbx_MainCourses);
        }
        private void btn_RemoveMainCourse_Click(object sender, EventArgs e)
        {
            removeMealOnClickEvent(txt_MainCoursePortion, cbx_MainCourses);
        }
        private void btn_AddSideDishes_Click(object sender, EventArgs e)
        {
            addMealOnClickEvent(txt_SideDishPortion,cbx_SideDishes);
        }
        private void btn_RemoveSideDish_Click(object sender, EventArgs e)
        {
            removeMealOnClickEvent(txt_SideDishPortion,cbx_SideDishes);
        }
        private void btn_AddPickles_Click(object sender, EventArgs e)
        {
            addMealOnClickEvent(txt_PicklesPortion,cbx_Pickles);
        }
        private void btn_RemovePickles_Click(object sender, EventArgs e)
        {
            removeMealOnClickEvent(txt_PicklesPortion,cbx_Pickles);
        }
        private void btn_AddDessert_Click(object sender, EventArgs e)
        {
            addMealOnClickEvent(txt_DessertPortion,cbx_Desserts);
        }
        private void btn_RemoveDessert_Click(object sender, EventArgs e)
        {
            removeMealOnClickEvent(txt_DessertPortion, cbx_Desserts);
        }
        private void btn_AddPlatters_Click(object sender, EventArgs e)
        {
            addMealOnClickEvent(txt_PlattersPortion, cbx_Platters);
        }
        private void btn_RemovePlatters_Click(object sender, EventArgs e)
        {
            removeMealOnClickEvent(txt_PlattersPortion, cbx_Platters);
        }

        //Az új árajánlat mentését (adatbázisba való feltöltését) végzi és ellenőrzi az ügyféladatokat és a dátumot.
        private void btn_SavePreTender_Click(object sender, EventArgs e)
        {

            if (txt_ClientName.Text.Length >= 5 && txt_ClientPhone.Text.Length >= 11)
            {
                newTender.setClientName(txt_ClientName.Text);
                newTender.setClientPhone(txt_ClientPhone.Text);

                if (txt_ClientEmail.Text.Length != 0)
                {
                    try
                    {
                        MailAddress mail = new MailAddress(txt_ClientEmail.Text);
                        newTender.setClientEmail(txt_ClientEmail.Text);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Az emailcím nem helyes!", "Hiba!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    newTender.setClientEmail("");
                }
                DateTime selectedDay = dtp_EventDate.Value;
                int dateCompareResult = DateTime.Compare(selectedDay, DateTime.Now);
                if (dateCompareResult < 0)
                {
                    MessageBox.Show("Korábbi vagy Mai dátum lett megadva az rendezvény dátumának!", "Hiba!", MessageBoxButtons.OK);
                }
                else if (dateCompareResult == 0)
                {
                    MessageBox.Show("A mai dátum van megadva a rendezvény dátumának!", "Hiba!", MessageBoxButtons.OK);
                }
                else
                {
                    newTender.setEventDate(dtp_EventDate.Value);
                    newTender.calculateTenderValues(int.Parse(txt_NumberOfGuests.Text));
                    try
                    {
                        newTender.save();
                        frmCheckTender = new frm_CheckTender(newTender.getID());
                        this.Hide();
                        frmCheckTender.ShowDialog();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Hibatörtént az adatbázissal kapcsolatban! Hívja az adminisztrátort! \n\n Hibaüzenet:\n{ex} ", "Hiba!", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nem lett helyesen kitöltve a Megrendelő neve vagy telefonszáma!");
            }
        }

        //Főmenübe való visszatérés gomb
        private void btn_MainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu = new frm_MainMenu();
            this.Hide();
            frmMainMenu.ShowDialog();
            this.Close();
        }
        //Kilépés gomb
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        //Az ételek menühöz való hozzáadását végző metódus.
        private void addMealOnClickEvent(TextBox txt, ComboBox cbx)
        {
            int portion;
            if ((txt.Text != "" && int.TryParse(txt.Text, out portion)) && !txt.Text.Contains("-"))
            {
                try
                {
                    dtgv_Menu.Rows.Clear();
                    Meal newMeal = new Meal(cbx.Text, portion);

                    //Eldöntöm hogy a menüben szerepel-e a hozzáadni kívánt tétel
                    int menuLength = newTender.getMealMenu().getMenuLength();
                    int i = 0;
                    while (i < menuLength && newMeal.getName() != newTender.getMealMenu().getMenu()[i].getName()) { i++; }
                    //Ha szerepel a listában, hozzáadom az extra adagot a már meglévő adagokhoz--> a Meal "portion" adattagjához
                    if (i < menuLength)
                    {
                        int newPortion = newTender.getMealMenu().getMenu()[i].getPortion();
                        newTender.getMealMenu().getMenu()[i].setPortion(newMeal.getPortion() + newPortion);
                    }
                    //ha nem szerepel hozzáadom a menühöz az új ételt. 
                    else
                    {
                        newTender.getMealMenu().addMeal(newMeal);
                    }
                    generateMealDataGridView(newTender.getMealMenu(), dtgv_Menu);
                    txt.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hibatörtént az adatbázissal kapcsolatban! Hívja az adminisztrátort! \n\n Hibaüzenet:\n{ex} ", "Hiba!", MessageBoxButtons.OK);
                }
            }
            else
            {
                txt.Text = "";
                MessageBox.Show("Nem jó számot adtál meg!", "Hiba!", MessageBoxButtons.OK);
            }
        }

        //Az ételek menüből való törlését végző metódus.
        private void removeMealOnClickEvent(TextBox txt, ComboBox cbx)
        {
            int portion;
            if ((txt.Text != "" && int.TryParse(txt.Text, out portion)) && !txt.Text.Contains("-"))
            {
                try
                {
                    dtgv_Menu.Rows.Clear();
                    Meal newMeal = new Meal(cbx.Text, portion);

                    //Eldöntöm hogy a menüben törölni kívánt tétel
                    int menuLength = newTender.getMealMenu().getMenuLength();
                    int i = 0;
                    while (i < menuLength && newMeal.getName() != newTender.getMealMenu().getMenu()[i].getName()) { i++; }
                    //Ha szerepel a listában, levonom az a bekért adagok számát a Meal "portion" adattagjából
                    if (i < menuLength)
                    {
                        if (newMeal.getPortion() == newTender.getMealMenu().getMenu()[i].getPortion() || newMeal.getPortion() > newTender.getMealMenu().getMenu()[i].getPortion())
                        {
                            newTender.getMealMenu().removeMeal(i);
                        }
                        else
                        {
                            int newPortion = newTender.getMealMenu().getMenu()[i].getPortion() - newMeal.getPortion();
                            newTender.getMealMenu().getMenu()[i].setPortion(newPortion);
                        }
                    }
                    //ha nem szerepel jelzem a felhasználónak hogy nincs tétel amiből le lehetne vonni
                    else
                    {
                        MessageBox.Show("Nem található a listába megadott étel", "Hiba!", MessageBoxButtons.OK);
                    }

                    //Ez után legenerálom a menü lista alapján DataGridView-t 
                    generateMealDataGridView(newTender.getMealMenu(), dtgv_Menu);
                    //Ez után kitörlöm az előzőleg bevitt szöveget a szövegmezőből
                    txt.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hibatörtént az adatbázissal kapcsolatban! Hívja az adminisztrátort! \n\n Hibaüzenet:\n{ex} ", "Hiba!", MessageBoxButtons.OK);
                }

            }
            else
            {
                txt.Text = "";
                MessageBox.Show("Nem jó számot adtál meg!", "Hiba!", MessageBoxButtons.OK);
            }
        }

        //Legenerálja az összeállított ételmenünek szánt datagridview-t.
        private void generateMealDataGridView(MealMenu menu, DataGridView dtgv)
        {
            //legenerálja a menü lista alapján DataGridView-t 
            foreach (Meal meal in menu.getMenu())
            {
                int n = dtgv.Rows.Add();
                dtgv.Rows[n].Cells[0].Value = meal.getName();
                dtgv.Rows[n].Cells[1].Value = meal.getSalePrice();
                dtgv.Rows[n].Cells[2].Value = meal.getPortion();
            }
        }

        //Feltölti a kívánt comboboxot, adatbázis lekérdezés alapján.
        private void fillCombox(string query, ComboBox cbx, string displayMember, string valueMember)
        {
            db.setQuery(query);
            db.commandExecute(db.getQuery());
            cbx.DataSource = db.getDataSet().Tables[0];
            cbx.DisplayMember = "name";
            cbx.ValueMember = "name";
        }
    }
}

