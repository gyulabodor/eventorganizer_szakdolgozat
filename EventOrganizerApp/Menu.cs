namespace EventOrganizerApp
{
    //A Menu osztály önmagában a rendezvény létszáma alapján teszi lehetővé az Eladási/beszerzési árak kalkulációit és adatkezelését.
    class Menu
    {
        //Adattagok
        private int numberOfGuests; //Vendégek létszáma. 
        private int devPricePerPerson; //Delivered price per person - Beszerzési ár/fő.
        private int salePricePerPerson;//Eladási  ár/fő.
        private int totalDevPrice;//Összesített beszerzési ár.
        private int totalSalePrice;//Összesített eladási ár.

        //A konstruktor a létszám alapján hozhatja létre az objektumot, a többi adattagot alapértelmezetten 0-ra inicializálja.
        public Menu(int numberOfGuests)
        {
            this.numberOfGuests = numberOfGuests;
            this.devPricePerPerson = 0;
            this.salePricePerPerson = 0;
            this.totalDevPrice = 0;
            this.totalSalePrice = 0;
        }

        /*Kalkulációk*/
        //Kiszámolja és beállítja a teljes beszerzési ár adattagot, majd ennek értékével tér vissza.
        public int calculateTotalDevPrice(int a, int b) {
            int totalDevPrice = a + b;
            setTotalDevPrice(totalDevPrice);
            return getTotalDevPrice();
        }
        //Kiszámolja és beállítja a beszerzési ár egy főre jutó részét a teljes beszerzési ár és vendégek létszáma alapján, majd ennek értékével tér vissza.
        public int calculateDevPricePerPerson(int totalDevPrice) {
            int devPricePerPerson = totalDevPrice / getNumberOfGuests();
            setDevPricePerPerson(devPricePerPerson);
            return getDevPricePerPerson();
        }
        //Kiszámolja és beállítja a teljes eladási ár adattagot, majd ennek értékével tér vissza.
        public int calculateTotalSalePrice(int a, int b) {
            int totalSalePrice = a + b;
            setTotalSalePrice(totalSalePrice);
            return getTotalSalePrice();
        }
        //Kiszámolja és beállítja a az eladási ár egy főre jutó részét a teljes beszerzési ár és a vendégek létszáma alapján, majd ennek értékével tér vissza.
        public int calculateSalePricePerPerson(int a, int b) {
            int salePricePerPerson = (a + b) / getNumberOfGuests();
            setSalePricePerPerson(salePricePerPerson);
            return getSalePricePerPerson();
        }

        //Getterek és setterek
        public int getDevPricePerPerson() { return this.devPricePerPerson; }
        public void setDevPricePerPerson(int devPricePerPerson) { this.devPricePerPerson = devPricePerPerson; }

        public int getSalePricePerPerson() { return this.salePricePerPerson; }
        public void setSalePricePerPerson(int salePricePerPerson) { this.salePricePerPerson = salePricePerPerson; }

        public int getTotalDevPrice() { return this.totalDevPrice; }
        public void setTotalDevPrice(int totalDevPrice) { this.totalDevPrice = totalDevPrice; }

        public int getTotalSalePrice() { return this.totalSalePrice; }
        public void setTotalSalePrice(int totalSalePrice) { this.totalSalePrice = totalSalePrice; }

        public int getNumberOfGuests() { return this.numberOfGuests; }
        public void setNumberOfGuests(int numberOfGuests) { this.numberOfGuests = numberOfGuests; }

    }
}
