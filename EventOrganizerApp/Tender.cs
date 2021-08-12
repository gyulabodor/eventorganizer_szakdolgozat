using System;
using System.Collections.Generic;

namespace EventOrganizerApp
{
    //Az árajánlat teljes adatkezelését végző osztály.
    class Tender
    {
        private int id;                     //Adatbázis azonosító.
        private string clientName;          //Ügyfél neve.
        private string clientPhone;         //Ügyfél telefonszáma.
        private string clientEmail;         //Ügyfél emailcíme.
        private string eventType;           //Rendezvény típusa
        private int numberOfGuests;         //Vendégek száma.
        private DateTime eventDate;         //Rendezvény dátuma.
        private MealMenu mealMenu;          //Ételmenü.
        private DrinkMenu drinkMenu;        //Italmenü.
        private Menu menu;                  //Menü objektum.
        private EmployeeList employeeList;  //Alkalmazottak listája.
        private Place place;                //Hely.
        private int totalSalePrice;         //A rendezvény teljes ára(kiajánlott ára).
        private int totalDevPrice;          //Teljes költség.
        private int profit;                 //Nyereség.
        //Segéd adattag
        private DataBase db;                //Adatbázis objektum.

        //Alapértelmezett tender objektumot hoz létre.
        public Tender() {
            this.totalSalePrice = 0;
            this.id = 0;
            this.clientName = "";
            this.clientPhone = "";
            this.clientEmail = "";
            this.eventType = "";
            this.numberOfGuests = 0;
            this.eventDate = new DateTime();
            this.mealMenu = new MealMenu(this.numberOfGuests);
            this.drinkMenu = new DrinkMenu(this.numberOfGuests);
            this.menu = new Menu(this.numberOfGuests);
            this.employeeList = new EmployeeList(this.numberOfGuests);
            this.place = new Place();
        }
        //Ez a konstruktor id alapján adatbázisból berendeli az árajánlat adatait így hozva létre a Tender objektumot.
        public Tender(int id) {
            db = new DataBase();
            this.id = id;
            db.setQuery($"SELECT * FROM tenders WHERE id={this.id}");
            db.commandExecute(db.getQuery());
            this.clientName = db.getDataFromDataSet("tenders", 0,"client_name").ToString();
            this.clientPhone = db.getDataFromDataSet("tenders", 0, "client_phone").ToString();
            this.clientEmail = db.getDataFromDataSet("tenders", 0, "client_email").ToString();
            this.eventType = db.getDataFromDataSet("tenders",0,"event_type").ToString();
            this.numberOfGuests = int.Parse(db.getDataFromDataSet("tenders", 0, "guests_number").ToString());
            this.eventDate = DateTime.Parse(db.getDataFromDataSet("tenders", 0, "event_date").ToString());

            this.mealMenu = new MealMenu(this.numberOfGuests);
            this.drinkMenu = new DrinkMenu(this.numberOfGuests);
            this.menu = new Menu(this.numberOfGuests);
            this.employeeList = new EmployeeList(this.numberOfGuests);
            this.employeeList.setFinalPayment(int.Parse(db.getDataFromDataSet("tenders",0, "employees_payment").ToString()));
            this.place = new Place();

            this.place.setRentingPrice(int.Parse(db.getDataFromDataSet("tenders", 0, "place_rentingprice").ToString()));
            this.mealMenu.setDevPricePerPerson(int.Parse(db.getDataFromDataSet("tenders", 0, "mealmenu_devprice_person").ToString()));
            this.mealMenu.setSalePricePerPerson(int.Parse(db.getDataFromDataSet("tenders", 0, "mealmenu_saleprice_person").ToString()));
            this.mealMenu.setTotalDevPrice(int.Parse(db.getDataFromDataSet("tenders", 0, "mealmenu_devprice").ToString()));
            this.mealMenu.setTotalSalePrice(int.Parse(db.getDataFromDataSet("tenders", 0, "mealmenu_saleprice").ToString()));
            this.drinkMenu.setDevPricePerPerson(int.Parse(db.getDataFromDataSet("tenders", 0, "drinkmenu_devprice_person").ToString()));
            this.drinkMenu.setSalePricePerPerson(int.Parse(db.getDataFromDataSet("tenders", 0, "drinkmenu_saleprice_person").ToString()));
            this.drinkMenu.setTotalDevPrice(int.Parse(db.getDataFromDataSet("tenders", 0, "drinkmenu_devprice").ToString()));
            this.drinkMenu.setTotalSalePrice(int.Parse(db.getDataFromDataSet("tenders", 0, "drinkmenu_saleprice").ToString()));
            this.menu.setDevPricePerPerson(int.Parse(db.getDataFromDataSet("tenders", 0, "totalmenu_devprice_person").ToString()));
            this.menu.setSalePricePerPerson(int.Parse(db.getDataFromDataSet("tenders", 0, "totalmenu_saleprice_person").ToString()));
            this.menu.setTotalDevPrice(int.Parse(db.getDataFromDataSet("tenders",0,"totalmenu_devprice").ToString()));
            this.menu.setTotalSalePrice(int.Parse(db.getDataFromDataSet("tenders",0,"totalmenu_saleprice").ToString()));
            this.employeeList.setFinalPayment(int.Parse(db.getDataFromDataSet("tenders",0, "employees_payment").ToString()));
            setTotalSalePrice(int.Parse(db.getDataFromDataSet("tenders",0,"event_totalsaleprice").ToString()));
            setTotalDevPrice(int.Parse(db.getDataFromDataSet("tenders", 0, "event_totaldevprice").ToString()));
            this.profit = int.Parse(db.getDataFromDataSet("tenders", 0, "profit").ToString());

            db.setQuery($"SELECT meals.name, portions.portions FROM tenders_meals_portions INNER JOIN meals ON meals.id = tenders_meals_portions.meal_id INNER JOIN portions ON portions.id = portion_id WHERE tenders_meals_portions.tender_id = {this.id}; ");
            db.commandExecute(db.getQuery());
            int length=db.getRowsLength();
            for (int i = 0; i < length; i++)
            {
                string name = db.getDataFromDataSet("tenders_meals_portions", i, "name").ToString();
                int portion = int.Parse(db.getDataFromDataSet("tenders_meals_portions", i, "portions").ToString());
                mealMenu.addMeal(new Meal(name,portion));
            }
            db.setQuery($"SELECT drinkmenus.name FROM tenders_drinkmenus INNER JOIN drinkmenus ON drinkmenus.id= tenders_drinkmenus.drinkmenu_id WHERE tenders_drinkmenus.tender_id={this.id};");
            db.commandExecute(db.getQuery());
            drinkMenu.setByName(db.getDataFromDataSet("tenders_drinkmenus",0,"name").ToString());


        }

        /*Kalkuláció és adatbázisműveletek*/
        //Kiszámolja a profitot és beállítja a teljes eladási és beszerzési árakat. 
        public void calculateProfit() {
            int totalSalePrice = 0;
            int totalDevPrice = 0;
            int profit = 0;

            totalSalePrice = menu.getTotalSalePrice() + employeeList.getFinalPayment() + place.getRentingPrice();
            totalDevPrice = menu.getTotalDevPrice();
            profit = totalSalePrice - totalDevPrice;

            this.totalSalePrice = totalSalePrice;
            this.totalDevPrice = totalDevPrice;
            this.profit = profit;
        }
        //az árajánlat összes számolandó értékét kalkulálja ki.
        public void calculateTenderValues(int numberOfGuests)
        {
           setNumberOfGuests(numberOfGuests);
           getMealMenu().calculateSalePricePerPerson();
           getMealMenu().calculateDevPricePerPerson();
           getMealMenu().calculateTotalSalePrice();
           getMealMenu().calculateTotalDevPrice();
           getDrinkMenu().calculateTotalSalePrice();
           getDrinkMenu().calculateTotalDevPrice();
           getMenu().calculateTotalSalePrice(getMealMenu().getTotalSalePrice(), getDrinkMenu().getTotalSalePrice());
           getMenu().calculateSalePricePerPerson(getMealMenu().getTotalSalePrice(), getDrinkMenu().getTotalSalePrice());
           getMenu().calculateDevPricePerPerson(getMenu().getTotalDevPrice());
           getMenu().calculateTotalDevPrice(getMealMenu().getTotalDevPrice(), getDrinkMenu().getTotalDevPrice());
           calculateProfit();
        }
        //Az árajánlat adatbázisba való mentését végzi.
        public void save()
        {
            db = new DataBase();
            db.setQuery($"INSERT INTO tenders(event_type,client_name,client_phone,client_email,event_date,guests_number,mealmenu_devprice_person,mealmenu_saleprice_person,mealmenu_devprice,mealmenu_saleprice,drinkmenu_devprice_person,drinkmenu_saleprice_person,drinkmenu_devprice,drinkmenu_saleprice,totalmenu_devprice_person,totalmenu_saleprice_person,totalmenu_devprice,totalmenu_saleprice,place_rentingprice,employees_payment,event_totalsaleprice,event_totaldevprice,profit) VALUE('{this.eventType}','{this.clientName}','{this.clientPhone}','{this.clientEmail}','{this.eventDate.ToString("yyyy-MM-dd")}',{this.numberOfGuests},{this.mealMenu.getDevPricePerPerson()},{this.mealMenu.getSalePricePerPerson()},{this.mealMenu.getTotalDevPrice()},{this.mealMenu.getTotalSalePrice()},{this.drinkMenu.getDevPricePerPerson()},{this.drinkMenu.getSalePricePerPerson()},{this.drinkMenu.getTotalDevPrice()},{this.drinkMenu.getTotalSalePrice()},{this.menu.getDevPricePerPerson()},{this.menu.getSalePricePerPerson()},{this.menu.getTotalDevPrice()},{this.menu.getTotalSalePrice()},{this.place.getRentingPrice()},{this.employeeList.getFinalPayment()},{this.totalSalePrice},{this.totalDevPrice},{this.profit})");
            db.commandExecute(db.getQuery());
            db.setQuery($"SELECT id FROM tenders ORDER BY id DESC LIMIT 1");
            db.commandExecute(db.getQuery());
            this.id = int.Parse(db.getDataFromDataSet("tenders",0,"id").ToString());

            db.setQuery($"INSERT INTO tenders_drinkmenus(tender_id,drinkmenu_id) VALUE({this.id},{this.drinkMenu.getID()})");
            db.commandExecute(db.getQuery());
            int helpID = 0;
            foreach (Meal meal in this.mealMenu.getMenu())
            {
                
                db.setQuery($"INSERT INTO portions(portions) VALUE('{meal.getPortion()}')");
                db.commandExecute(db.getQuery());
                db.setQuery($"SELECT id FROM portions ORDER BY id DESC LIMIT 1");
                db.commandExecute(db.getQuery());
                helpID = int.Parse(db.getDataFromDataSet("portions", 0, "id").ToString());
                db.setQuery($"INSERT INTO tenders_meals_portions(tender_id,meal_id,portion_id) VALUES({this.id},{meal.getID()},{helpID})");
                db.commandExecute(db.getQuery());
            }
        }
        //Az árajánlat adatbázisból való törlését végzi.
        public void delete() {
            db = new DataBase();
            db.setQuery($"DELETE FROM tenders_drinkmenus WHERE tender_id={this.id};");
            db.commandExecute(db.getQuery());

            List<int> portionIDs = new List<int>();
            db.setQuery($"SELECT portion_id FROM tenders_meals_portions WHERE tender_id={this.id}");
            db.commandExecute(db.getQuery());
            int length = db.getRowsLength();
            for (int i = 0; i < length; i++)
            {
                portionIDs.Add(int.Parse(db.getDataFromDataSet("tenders_meals_portions",i,"portion_id").ToString()));
            }

            db.setQuery($"DELETE FROM tenders_meals_portions WHERE tender_id ={ this.id}");
            db.commandExecute(db.getQuery());
            foreach (int portionID in portionIDs)
            {
                db.setQuery($"DELETE FROM portions WHERE id={portionID}");
                db.commandExecute(db.getQuery());
            }
            db.setQuery($"DELETE FROM tenders WHERE id={this.id}");
            db.commandExecute(db.getQuery());
        }
        //Getterek és setterek
        public int getID() { return this.id; }
        public void setID(int id) { this.id = id; }
        public string getEventType() { return this.eventType; }
        public void setEventType(string eventType) { this.eventType = eventType; }

        public void setClientName(string clientName) {
            this.clientName = clientName;
        }
        public string getClientName() { return this.clientName; }
        public void setClientPhone(string clientPhone)
        {
            this.clientPhone = clientPhone;
        }
        public string getClientPhone() { return this.clientPhone; }
        public void setClientEmail(string clientEmail) {
            this.clientEmail = clientEmail;
        }
        public string getClientEmail() { return this.clientEmail; }

        public DateTime getEventDate() { return this.eventDate; }
        public void setEventDate(DateTime eventDate) {
            this.eventDate = eventDate;
        }

        public void setNumberOfGuests(int numberOfGuests)
        {
            this.numberOfGuests = numberOfGuests;
            this.mealMenu.setNumberOfGuests(numberOfGuests);
            this.drinkMenu.setNumberOfGuests(numberOfGuests);
            this.menu.setNumberOfGuests(numberOfGuests);
        }
        public int getNumberOfGuests() { return this.numberOfGuests; }

        public MealMenu getMealMenu() { return this.mealMenu; }
        public DrinkMenu getDrinkMenu() { return this.drinkMenu; }
        public Menu getMenu() { return this.menu; }

        public EmployeeList getEmployeeList() { return this.employeeList; }
        public void setEmployeeList(EmployeeList employeeList)
        {
            this.employeeList = employeeList;
        }

        public Place getPlace() { return this.place; }

        public void setTotalSalePrice(int totalSalePrice) { this.totalSalePrice = totalSalePrice; }
        public int getTotalSalePrice() { return this.totalSalePrice; }
        public void setTotalDevPrice(int totalDevPrice) { this.totalDevPrice = totalDevPrice; }
        public int getTotalDevPrice() { return this.totalDevPrice; }
        public int getProfit() { return this.profit; }

    }
}
