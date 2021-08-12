using System;
using System.Windows.Forms;

namespace EventOrganizerApp
{
    //Mentett árajánlatok megjelenítése
    public partial class frm_Tenders : Form
    {
        private frm_CheckTender frmCheckTender; //Konkrét árajánlat megjelnítése form
        private frm_MainMenu frmMainMenu;       //Főmenü form
        private DataBase db;                    //Adatbázis

        public frm_Tenders()    
        {
            InitializeComponent();
            db = new DataBase();
        }

        //A kiválasztott árajánlat megjelenítését végző gomb
        private void btn_CheckTender_Click(object sender, EventArgs e)
        {
            int id=(int)dtgv_Tenders.Rows[dtgv_Tenders.CurrentRow.Index].Cells[0].Value;
            frmCheckTender = new frm_CheckTender(id);
            this.Hide();
            frmCheckTender.ShowDialog();
            this.Close();
        }

        //A form betöltődésekor lekérdezi az eddig összes mentésre került árajánlatot.
        private void frm_Tenders_Load(object sender, EventArgs e)
        {
            generateDataGridView();
        }
        //Választott árajánlat törlése gomb.
        private void btn_DeleteTender_Click(object sender, EventArgs e)
        {
            if (dtgv_Tenders.Rows[dtgv_Tenders.CurrentRow.Index].Cells[0].Value != null)
            {
                int id = (int)dtgv_Tenders.Rows[dtgv_Tenders.CurrentRow.Index].Cells[0].Value;
                if (DialogResult.Yes == MessageBox.Show($"Biztosan törölni szeretné az  | {id}. | azonosítójú árajánlatot?", "Törlés", MessageBoxButtons.YesNo))
                {
                    Tender tender = new Tender();
                    tender.setID(id);
                    tender.delete();
                    generateDataGridView();
                    MessageBox.Show($"Sikeresen törölve lett  az  | {id}. | azonosítójú árajánlat","Törlés elvégezve!",MessageBoxButtons.OK);
                }  
            }
            else
            {
                MessageBox.Show($"Rossz sor lett kiválasztva!");
            }
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
        //Az árajánlatokat DataGridViewba megjelenítő metódus 
        private void generateDataGridView() {

            try
            {
                db.setQuery("SELECT id,client_name,event_type,guests_number,client_phone,client_email,event_totalsaleprice FROM tenders");
                db.commandExecute(db.getQuery());
                int length = db.getRowsLength();
                dtgv_Tenders.Rows.Clear();
                int n = 0;
                for (int i = 0; i < length; i++)
                {
                    n = dtgv_Tenders.Rows.Add();
                    dtgv_Tenders.Rows[i].Cells[0].Value = db.getDataFromDataSet("tenders", i, "id");
                    dtgv_Tenders.Rows[i].Cells[1].Value = db.getDataFromDataSet("tenders", i, "client_name");
                    dtgv_Tenders.Rows[i].Cells[2].Value = db.getDataFromDataSet("tenders", i, "event_type");
                    dtgv_Tenders.Rows[i].Cells[3].Value = db.getDataFromDataSet("tenders", i, "event_totalsaleprice");
                    dtgv_Tenders.Rows[i].Cells[4].Value = db.getDataFromDataSet("tenders", i, "guests_number");
                    dtgv_Tenders.Rows[i].Cells[5].Value = db.getDataFromDataSet("tenders", i, "client_phone");
                    dtgv_Tenders.Rows[i].Cells[6].Value = db.getDataFromDataSet("tenders", i, "client_email");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hibatörtént az adatbázissal kapcsolatban! Hívja az adminisztrátort! \n\n Hibaüzenet:\n{ex} ", "Hiba!", MessageBoxButtons.OK);
            }

        }

    }
}
