using System;
using System.Windows.Forms;

namespace EventOrganizerApp
{
    //Főmenü form
    public partial class frm_MainMenu : Form
    {
        //Adattagok
        private frm_NewEventTender newTenderForm;  //Új árajánlat készítése form
        private frm_Tenders frmTenders;            //Árajánlatok megtekintése form
        private frm_Login frmLogin;                //Bejelentkezés form

        public frm_MainMenu()
        {
            InitializeComponent();
        }

        //Új árajánlat készítése form megnyitása
        private void btn_NewEvent_Click(object sender, EventArgs e)
        {
            newTenderForm = new frm_NewEventTender();
            this.Hide();
            newTenderForm.ShowDialog();
            this.Close();
        }

        //Már létező árajánlatok megtekintése 
        private void btn_Tenders_Click(object sender, EventArgs e)
        {
            frmTenders = new frm_Tenders();
            this.Hide();
            frmTenders.ShowDialog();
           
        }
        //Kijelentkezés gomb
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frmLogin = new frm_Login();
            this.Hide();
            frmLogin.ShowDialog();
            this.Close();
        }
        //Kilépés gomb
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }


    }
}
