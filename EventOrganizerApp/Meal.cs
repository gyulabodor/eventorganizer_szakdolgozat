namespace EventOrganizerApp
{
    //Egy étel adatkezelését végző osztály
    class Meal
    {
        //Fő adattagok
        private int id;        //Adatbázisból érkező azonosító.
        private string name;   //Étel neve.
        private char course;   //Hozzáadásnál lesz rá szükség.
        private int dev_price; //Egy adag beszerzési ára.
        private int sale_price;//Egy adag eladási ára.
        private int portion;   //Az adott ételből hány adag.
        //segéd adattag
        private DataBase db;   //Adatbázis objektum.

        //A konstruktor a név alapján összeállítja az adatbázis lekérdezést és beállítja az objektum adattagjainak értékeit a lekérdezés eredményéből.  
        public Meal(string name) {
           
            db = new DataBase();
            db.setQuery($"Select * FROM meals WHERE name = '{name}'");
            db.commandExecute(db.getQuery());
            this.name = name;
            this.id = int.Parse(db.getDataFromDataSet("meals",0,"id").ToString());
            this.course=char.Parse(db.getDataFromDataSet("meals", 0, "course").ToString());
            this.dev_price=int.Parse(db.getDataFromDataSet("meals", 0, "dev_price").ToString());
            this.sale_price=int.Parse(db.getDataFromDataSet("meals", 0, "sale_price").ToString());
            this.portion=0;
        }
        //A konstruktor hívási lánc elvén alapulva létrejöhet az adag(portion) megadásával is az objektum.
        public Meal(string name, int portion):this(name)
        {
            this.portion = portion;
        }
        //Getterek és setterek
        public int getID() { return this.id; }
        public string getName() { return this.name; }
        public int getDevPrice() { return this.dev_price; }
        public int getSalePrice() { return this.sale_price; }
        public void setPortion(int portion) { this.portion = portion; }
        public int getPortion() { return this.portion; }
        

        


    }
}
