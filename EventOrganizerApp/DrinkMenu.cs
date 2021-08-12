namespace EventOrganizerApp
{   
    //Az italszerviz/italmenü adatkezelését végző osztály.
    class DrinkMenu : Menu
    {
        //Fő adattagok
        private int id;             //Adatbázis azonosító.
        private string name;        //Italmenü neve.
        private string description; //Italmenü ismertetője.
        
        //Segéd adattag
        private DataBase db;
        //A konstruktor a konstruktor hívási láncnak megfelelően beállítja a menü számára fontos vendégek létszámát.
        public DrinkMenu(int numberOfGuests):base(numberOfGuests) {}

        //Név alapján összeállítja az adatbázis lekérdezést és beállítja az objektum adattagjainak értékeit a lekérdezés eredményéből
        public void setByName(string name) {
            db = new DataBase();
            db.setQuery($"SELECT * FROM drinkmenus WHERE name='{name}'");
            db.commandExecute(db.getQuery());
            this.name = name;
            this.id = int.Parse(db.getDataFromDataSet("drinkmenus",0,"id").ToString());
            this.description = db.getDataFromDataSet("drinkmenus", 0, "description").ToString();
            setDevPricePerPerson(int.Parse(db.getDataFromDataSet("drinkmenus", 0, "devprice_per_person").ToString()));
            setSalePricePerPerson(int.Parse(db.getDataFromDataSet("drinkmenus", 0, "saleprice_per_person").ToString()));
        }

        //Kiszámolja és beállítja az italmenü eladási ár adattagját a vendégek száma alapján, majd vissza tér annak értékével.
        public int calculateTotalSalePrice() {
            int totalSalePrice = getSalePricePerPerson() * getNumberOfGuests();
            setTotalSalePrice(totalSalePrice);
            return getTotalSalePrice();
        }
        //Kiszámolja és beállítja az italmenü beszerzési ár adattagját a vendégek száma alapján, majd vissza tér annak értékével.
        public int calculateTotalDevPrice() {
            int totalDevPrice = getDevPricePerPerson() * getNumberOfGuests();
            setTotalDevPrice(totalDevPrice);
            return getTotalDevPrice();
        }

        //Getterek
        public int getID() { return this.id; }
        public string getName() { return this.name; }
        public string getDescription() { return this.description; }

    }
}
