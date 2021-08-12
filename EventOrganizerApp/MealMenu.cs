using System.Collections.Generic;

namespace EventOrganizerApp
{
    //Az ételek menüberendezését végző osztály.
    class MealMenu:Menu
    {
        //Adattag
        private List<Meal> meals;//Az ételeket tároló lista.

        //A konstruktor a konstruktor hívási láncnak megfelelően beállítja a menü számára fontos vendégek létszámát és létrehozza az étel lista objektumot
        public MealMenu(int numberOfGuests):base(numberOfGuests)
        {
            this.meals = new List<Meal>();
        }

        //Egy étel hozzáadása a listához
        public void addMeal(Meal meal)
        {
            this.meals.Add(meal);
        }

        //Egy étel törlése megadott indexen a listából
        public void removeMeal(int i)
        {
            this.meals.RemoveAt(i);
        }

        //Lista hosszának/méretének lekérdezése
        public int getMenuLength()
        {
            return this.meals.Count;
        }

        /*Kalkulációk*/

        //Kiszámolja és beállítja az étel lista teljes beszerzési árát, majd annak értékével tér vissza. 
        public int calculateTotalDevPrice() {
            int totalDevPrice = 0;
            foreach (Meal meal in meals)
            {
                totalDevPrice += meal.getPortion() * meal.getDevPrice();
            }
            setTotalDevPrice(totalDevPrice);
            return getTotalDevPrice();
        }
        //Kiszámolja és beállítja az étel menü egy főre jutó beszerzési árát, majd annak értékével tér vissza.
        public int calculateDevPricePerPerson()
        {
            int devPricePerPerson = calculateTotalDevPrice() / getNumberOfGuests();
            setDevPricePerPerson(devPricePerPerson);
            return getDevPricePerPerson();
        }
        //Kiszámolja és beállítja az étel lista teljes elaádsi árát, majd annak értékével tér vissza.
        public int calculateTotalSalePrice() {
            int totalSalePrice = 0;
            foreach (Meal meal in meals)
            {
                totalSalePrice += meal.getPortion() * meal.getSalePrice();
            }
            setTotalSalePrice(totalSalePrice);
            return getTotalSalePrice();
        }
        //Kiszámolja és beállítja az étel menü egy főre jutó beszerzési árát, majd annak értékével tér vissza.
        public int calculateSalePricePerPerson() {
            
            int totalSalePrice = 0;
            foreach (Meal meal in meals)
            {
                totalSalePrice += meal.getPortion() * meal.getSalePrice();
            }
            int salePricePerPerson = totalSalePrice / getNumberOfGuests();

            setSalePricePerPerson(salePricePerPerson);
            return getSalePricePerPerson();
        }

        //Getter
        public List<Meal> getMenu() { return this.meals; }

    }
}
