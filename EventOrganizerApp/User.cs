using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace EventOrganizerApp
{
    class User
    {   
        //Adattagok
        private string email;   //Emailcím
        private string password;//jelszó    
        private bool isValid;   //érvényesek-e a bejelentkezési adatok
        //Segédadattag
        private DataBase db;

        //Csak a már létező emailcímmel rendelkező User objektum jöhet létre ezt a vizsgálatot a Form végzi.
        public User(string email,string password) {
            this.db = new DataBase();
            this.db.setQuery($"SELECT password FROM users WHERE email_address='{email}'");
            this.db.commandExecute(db.getQuery());
            this.email = email;
            this.password = db.getDataFromDataSet("users",0,"password").ToString();
            this.isValid = validateUser(password); 
        }
        public User(string email) {
            this.db = new DataBase();
            this.db.setQuery($"SELECT password FROM users WHERE email_address='{email}'");
            this.db.commandExecute(db.getQuery());
            this.email = email;
            
        }
        //A kapott jelszó titkosítását és az adatbázisból érkezett titkosított jelszó összehasonlítását végző függvény.
        private bool validateUser(string password) {
            bool isValid = false;

            var md5 = MD5.Create();
            byte[] inputBytes = Encoding.ASCII.GetBytes(password);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("x2"));
            }

            if (this.password == sb.ToString()){ isValid = true; }
            else { isValid=false; }
            return isValid;
        }

        //Getterek
        public string getEmail() { return this.email; }
        public bool getIsValid() { return this.isValid; }
        
    }
}
