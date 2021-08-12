using MySql.Data.MySqlClient;
using System.Data;

namespace EventOrganizerApp
{   //Adatábzis műveletekek végző osztály
    class DataBase
    {   
        //Adattagok
        private MySqlConnection conn;   //MySql kapcsolat objektum.
        private MySqlDataAdapter da;    //Adabázisba való beírást szolgáló osztály.
        private DataSet ds;             //A lekérdezés eredményének tárolására szolgál.
        private string conString;       //A connection string tárolására szolgál.   
        private string query;           //adatbázis lekérdezés.

        //Az adatábzis konstruktora bekéri a Properties.Settingsben létrehozott connection stringet, majd ezt beállítja a MysqlConnection objektumnak.
        public DataBase()
        {
            this.conString = Properties.Settings.Default.eventorganizerConnectionString;
            this.conn = new MySqlConnection(conString);
        }
        //Végrehajtja a lekérdezést majd feltölti A ds(DataSet) objektumot az eredménnyel.
        public void commandExecute(string query) {
            this.ds = new DataSet();
            this.da = new MySqlDataAdapter(query, conn);
            da.Fill(this.ds);
        }
        //Vissza adja az adattábal sorainak számát.
        public int getRowsLength() {
            int numberOfRows=this.ds.Tables[0].Rows.Count;
            return numberOfRows;
        }
        //A táblanév a sor indexe és az oszlop neve alapján tér vissza a tárolt értékkel.
        public object getDataFromDataSet(string tableName,int rowIndex,string colName) {
            object var = new object();
            var = this.ds.Tables[0].Rows[rowIndex][colName];
            return var;
        }
        //Getterek és setterek.
        public void setQuery(string query) { this.query = query; }
        public string getQuery() { return this.query; }
        public DataSet getDataSet() { return this.ds; }


    }
}
