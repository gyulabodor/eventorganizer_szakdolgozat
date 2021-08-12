namespace EventOrganizerApp
{   //Egy adott tipusú alkmazottak adatkezelését végző osztály 
    class Employee
    {
        //Fő Adattagok
        private int id;                 //Adatbázis azonosító
        private string type;            //Alkalmazott tipusa.
        private int paymentPerPerson;   //Alkamazott Fizetése 1 főre.
        private int needPerPerson;      //Egy alkalmazott hány embert tud kiszolgálni.
        private int numberOfEmployees;  //Hány alkalmazott van adott tipusból.
        private int totalPayment;       //Ugyan azon tipusú alkalmazottak összesített fizetését jelöli. 
        //Segéd adattag
        private DataBase db;

        //A konstruktor a tipus alapján összeállítja az adatbázis lekérdezést és beállítja az objektum adattagjainak értékeit a lekérdezés eredménye és a vendégek száma alapján.  
        public Employee(string type,int numberOfGuests) {
            db = new DataBase();
            db.setQuery($"Select * From employees where type='{type}';");
            db.commandExecute(db.getQuery());
            this.type = type;
            this.id = int.Parse(db.getDataFromDataSet("employees",0,"id").ToString());
            this.paymentPerPerson = int.Parse(db.getDataFromDataSet("employees", 0, "payment_per_person").ToString());
            this.needPerPerson= int.Parse(db.getDataFromDataSet("employees", 0, "need_per_person").ToString());
            this.numberOfEmployees = calculateNumberOfEmployees(numberOfGuests);
            this.totalPayment = calculateTotalPayment(numberOfGuests);
        }
        //Kiszámolja hány alkalmazott kell az adaott tipusból a vendégek száma alapján.
        private int calculateNumberOfEmployees(int numberOfGuests) {
            int number = 0;
            double result = 0;
            double quotient = 0;
            result = (double)numberOfGuests / needPerPerson;
            quotient = result % 1;
            number = (int)(result);
            if (quotient > 0) { number++; }
            return number;
        }

        //Kiszámolja ugyan azon tipusú alkalmazottak teljes fizetését.
        private int calculateTotalPayment(int numberOfGuests) {
            int totalPayment = 0;
            int numberOfEmployees = calculateNumberOfEmployees(numberOfGuests);
            totalPayment = numberOfEmployees * this.paymentPerPerson;
            return totalPayment;
        }

        //Getterek
        public int getID() { return this.id; }
        public string getEmployeeType() { return this.type; }
        public int getNumberOfEmployees() { return this.numberOfEmployees; }
        public int getTotalPayment() { return this.totalPayment; }
        public void setNumberOfEmployees(int numberOfEmployees) { this.numberOfEmployees = numberOfEmployees; }





    }
}
