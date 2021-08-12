using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Web;
namespace EventOrganizerApp
{
    //Bejelntkezés form
    public partial class frm_Login : Form
    {
        //Adattagok
        private frm_MainMenu mainMenu;  //Főmenü form
        private User user;              //Felhasználó tárolására szolgáló objektum
        private DataBase db;            //Adatbázis objektum.

        public frm_Login()
        {
            InitializeComponent();    
        }
        // Az adatok ellenőrzését és a főmenübe léptetést végző gomb
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Email.Text!="")
            {
                try
                {
                    MailAddress mail = new MailAddress(txt_Email.Text);
                    try
                    {
                        db = new DataBase();
                        db.setQuery($"SELECT COUNT(*) FROM users WHERE email_address='{txt_Email.Text}'");
                        db.commandExecute(db.getQuery());
                        int userExist = int.Parse(db.getDataFromDataSet("users", 0, "COUNT(*)").ToString());
                        if (userExist != 0)
                        {
                            user = new User(txt_Email.Text, txt_Password.Text);

                            if (user.getIsValid())
                            {
                                mainMenu = new frm_MainMenu();
                                this.Hide();
                                mainMenu.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Helytelen jelszó!", "Hiba!", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nincs regisztrálva ilyen emailcím", "Hiba!", MessageBoxButtons.OK);
                        }
                    }
                    catch (Exception ex)
                    {
                      
                        MessageBox.Show($"Hibatörtént az adatbázissal kapcsolatban! Hívja az adminisztrátort! \n\n Hibaüzenet:\n{ex}", "Hiba!", MessageBoxButtons.OK);
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Az emailcím nem helyes!", "Hiba!", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Töltse ki az emailcím mezőt!", "Hiba!", MessageBoxButtons.OK);
            }
        }
    }
}
