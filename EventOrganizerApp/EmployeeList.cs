using System.Collections.Generic;

namespace EventOrganizerApp
{
    //A különbőző tipusú alkalmazottak listába rendezését és költségének meghatározását végző osztály.
    class EmployeeList
    {
        //Fő adattag
        private List<Employee> employeeList;    //Alkalmazottak listája.
        private int finalPayment;               //Az alkalmazottak teljes költsége.
        //Segéd adattag
        private DataBase db;                    //Adatbázis objektum.

        //A konstruktor a rendezvény létszáma alapján feltölti a listát a  szükséges alkalmazott objektumokkal.
        //Ez a konstruktor használatos új rendezvény létrehozásánál
        public EmployeeList(int numberOfGuests) {
            db = new DataBase();
            db.setQuery("SELECT * FROM employees");
            db.commandExecute(db.getQuery());

            employeeList = new List<Employee>();
            int length = db.getRowsLength();
            for (int i = 0; i < length; i++)
            {
                string type = db.getDataFromDataSet("employees", i, "type").ToString();
                employeeList.Add(new Employee(type,numberOfGuests));
            }
            this.finalPayment = calculateFinalPayment();
        }

        /*Kalkuláció*/
        //Kiszámolja az alkalmazottak teljes költségét, és az eredménnyel visszatér.
        private int calculateFinalPayment() {
            int finalPayment=0;
            foreach (Employee employee in employeeList)
            {
                finalPayment = finalPayment + employee.getTotalPayment();
            }
            return finalPayment;
        }

        //Getterek és setterek
        public void setList(List<Employee> list){ this.employeeList = list; }
        public List<Employee> getList() { return this.employeeList; }
        public int getFinalPayment() { return this.finalPayment; }
        public void setFinalPayment(int finalPayment) { this.finalPayment = finalPayment; }
    }
}
