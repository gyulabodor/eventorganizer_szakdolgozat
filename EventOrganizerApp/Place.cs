namespace EventOrganizerApp
{   
    //A rendezvény helyszinének adatkezelésére szolgáló osztály.
    class Place
    {
        //Fő adattagok
        private string name;        //Helyszín neve.
        private int rentingPrice;   //Bérleti díj.
        //Segéd adattag
        private DataBase db;        //Adatbázis objektum.

        //A konstruktor adatbázis lekérdezéssel beállítja az adattagok értékét.
        public Place() {
            db = new DataBase();
            db.setQuery("Select * From locations");
            db.commandExecute(db.getQuery());
            this.name =db.getDataFromDataSet("locations", 0,"name").ToString();
            this.rentingPrice =int.Parse(db.getDataFromDataSet("locations",0,"renting_price").ToString());
        }

        //Getterek és setterek
        public string getName() { return this.name; }
        public int getRentingPrice() { return this.rentingPrice; }
        public void setRentingPrice(int rentingPrice) { this.rentingPrice = rentingPrice; }
    }
}
