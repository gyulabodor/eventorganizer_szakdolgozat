using System;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace EventOrganizerApp
{   //Az elkészült árajánlatok megjelenítésére és pdf generálásra szolgáló From
    public partial class frm_CheckTender : Form
    {
        private frm_MainMenu frmMainMenu;               //Főmenü form
        private frm_NewEventTender frmNewEventTender;   //Új árajánlat form
        private frm_Tenders frmTenders;                 //Árajánlatok megtekintése form;
        private Tender tender;                          //Árajánlat

        //A form alapvetően az árajánlat azonosítója(tenderID) alapján jöhet/jön létre, és egyből beállítja 
        //az alapján a tender objektum értékeit, majd megjeleníti.
        public frm_CheckTender(int tenderID)
        {
            InitializeComponent();
            try
            {
                tender = new Tender(tenderID);

                lbl_EventTypeResult.Text = tender.getEventType();
                lbl_NumberOfGuestsResult.Text = tender.getNumberOfGuests().ToString();
                lbl_EventDateResult.Text = tender.getEventDate().ToString("yyyy-MM-dd");
                lbl_ClientNameResult.Text = tender.getClientName();
                lbl_ClientPhoneResult.Text = tender.getClientPhone();

                if (tender.getClientEmail() != "")
                {
                    lbl_ClientEmail.Visible = true;
                    lbl_ClientEmailResult.Visible = true;
                    lbl_ClientEmailResult.Text = tender.getClientEmail();
                }

                foreach (Meal meal in tender.getMealMenu().getMenu())
                {
                    int n = dtgv_Meals.Rows.Add();
                    dtgv_Meals.Rows[n].Cells[0].Value = meal.getName();
                    dtgv_Meals.Rows[n].Cells[1].Value = meal.getPortion();
                }

                foreach (Employee employee in tender.getEmployeeList().getList())
                {
                    int n = dtgv_Employees.Rows.Add();
                    dtgv_Employees.Rows[n].Cells[0].Value = employee.getEmployeeType();
                    dtgv_Employees.Rows[n].Cells[1].Value = employee.getNumberOfEmployees();
                }
                lbl_DrinksResult.Text = $"{tender.getDrinkMenu().getName()} - {tender.getDrinkMenu().getDescription()}";

                lbl_MealMenuSalePricePerPersonResult.Text = $"{tender.getMealMenu().getSalePricePerPerson()}.- Ft";
                lbl_MealMenuDevPricePerPersonResult.Text = $"{tender.getMealMenu().getDevPricePerPerson()}.- Ft";
                lbl_MealMenuTotalSalePriceResult.Text = $"{tender.getMealMenu().getTotalSalePrice()}.- Ft";
                lbl_MealMenuTotalDevPriceResult.Text = $"{tender.getMealMenu().getTotalDevPrice()}.- Ft";

                lbl_DrinkMenuSalePricePerPersonResult.Text = $"{tender.getDrinkMenu().getSalePricePerPerson()}.- Ft";
                lbl_DrinkMenuDevPricePerPersonResult.Text = $"{tender.getDrinkMenu().getDevPricePerPerson()}.- Ft";
                lbl_DrinkMenuTotalSalePriceResult.Text = $"{tender.getDrinkMenu().getTotalSalePrice()}.- Ft";
                lbl_DrinkMenuTotalDevPriceResult.Text = $"{tender.getDrinkMenu().getTotalDevPrice()}.- Ft";

                lbl_MenuSalePricePerPersonResult.Text = $"{tender.getMenu().getSalePricePerPerson()}.- Ft";
                lbl_MenuDevPricePerPersonResult.Text = $"{tender.getMenu().getDevPricePerPerson()}.- Ft";
                lbl_MenuTotalSalePriceResult.Text = $"{tender.getMenu().getTotalSalePrice()}.- Ft";
                lbl_MenuTotalDevPriceResult.Text = $"{tender.getMenu().getTotalDevPrice()}.- Ft";

                lbl_EmployeePriceResult.Text = $"{tender.getEmployeeList().getFinalPayment()}.- Ft";
                lbl_PlaceRentingPriceResult.Text = $"{tender.getPlace().getRentingPrice()}.- Ft";
                lbl_ProfitResult.Text = $"{tender.getProfit()}.- Ft";
                lbl_TotalPriceEventResult.Text = $"{tender.getTotalSalePrice()}.- Ft";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hibatörtént az adatbázissal kapcsolatban! Hívja az adminisztrátort! \n\n Hibaüzenet:\n{ex} ", "Hiba!", MessageBoxButtons.OK);
            }
        }

        //Pdf állomány összeállítását és mentését végzi.
        private void btn_CreateClientPDF_Click(object sender, EventArgs e)
        {
            sfd_SavePDF.Filter = "PDF dokumentum (*.pdf)|*.pdf";
            
            if (DialogResult.OK== sfd_SavePDF.ShowDialog())
            {
                string dest = sfd_SavePDF.FileName;
                createPDFForClient(dest);
                MessageBox.Show("Az árajánlat sikeresen mentve!", "Információ", MessageBoxButtons.OK);
            }
            
        }
        //A konkrét PDF állományt állítja össze.
        private void createPDFForClient(string dest) {
            PdfWriter writer = new PdfWriter(dest);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN, "Windows-1250");
            document.SetFont(font);
            document.Add(new Paragraph("Árajánlat").SetTextAlignment(TextAlignment.CENTER).SetFontSize(24));
            document.Add(new Paragraph($"Megrendnelő neve: {tender.getClientName()}"));
            document.Add(new Paragraph($"Megrendnelő telefonszáma: {tender.getClientPhone()}"));
            if (tender.getClientEmail()!="")
            {
                document.Add(new Paragraph($"Megrendnelő emailcíme: {tender.getClientEmail()}"));
            }
            document.Add(new Paragraph($"Rendezvény típusa: {tender.getEventType()}"));
            document.Add(new Paragraph($"Rendezvény időpontja: {tender.getEventDate().ToString("yyyy-MM-dd")}"));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph("Ételek listája:").SetFontSize(16));
            List list = new List().SetSymbolIndent(12).SetListSymbol("\u2022");

            foreach (Meal meal in tender.getMealMenu().getMenu())
            {
                list.Add(new ListItem($"{meal.getPortion()} adag -- {meal.getName()}"));
            }
            document.Add(list);
            document.Add(new Paragraph(""));
            document.Add(new Paragraph($"Italcsomag: {tender.getDrinkMenu().getName()}").SetFontSize(16));
            document.Add(new Paragraph($"- {tender.getDrinkMenu().getDescription()}"));

            document.Add(new Paragraph($"Ételek ára 1 főre: {tender.getMealMenu().getSalePricePerPerson()}.- Ft"));
            document.Add(new Paragraph($"Ételek ára teljes létszámra: {tender.getMealMenu().getTotalSalePrice()}.- Ft"));
            document.Add(new Paragraph($"Italok ára 1 főre: {tender.getDrinkMenu().getSalePricePerPerson()}.- Ft"));
            document.Add(new Paragraph($"Italok ára teljes létszámra: {tender.getDrinkMenu().getTotalSalePrice()}.- Ft"));
            document.Add(new Paragraph($"Ételek és italok ára 1 főre: {tender.getMenu().getSalePricePerPerson()}.- Ft"));
            document.Add(new Paragraph($"Ételek és italok ára ára teljes létszámra: {tender.getMenu().getTotalSalePrice()}.- Ft"));
            document.Add(new Paragraph($"Munkaerő bére: {tender.getEmployeeList().getFinalPayment()}.- Ft"));
            document.Add(new Paragraph($"Rendezvényház bérleti díja: {tender.getPlace().getRentingPrice()}.- Ft"));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph($"A rendezvény teljes megajánlott ára: {tender.getTotalSalePrice()}.- Ft").SetFontSize(16));

            document.Close();
        }

        //Főmenü gomb
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
        //Új árajánlat gomb
        private void btn_NewTender_Click(object sender, EventArgs e)
        {
            frmNewEventTender = new frm_NewEventTender();
            this.Hide();
            frmNewEventTender.ShowDialog();
            this.Close();
        }
        //Árajánlatok megtekintése gomb
        private void btn_AllTenders_Click(object sender, EventArgs e)
        {
            frmTenders = new frm_Tenders();
            this.Hide();
            frmTenders.ShowDialog();
            this.Close();
        }
    }
}
