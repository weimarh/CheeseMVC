using CheeseMVC.Models;

namespace CheeseMVC.Data
{
    public class CheeseData
    {
        static private List<Cheese> cheeses = new List<Cheese>();


        //Get All
        public static List<Cheese> GetAll()
        {
            return cheeses;
        }


        //Get by Id
        public static Cheese GetById(int id)
        {
            return cheeses.Single(c => c.Id == id);            
        }

        //Add
        public static void Add(Cheese newCheese)
        {
            cheeses.Add(newCheese);
        }


        //Revome
        public static void Remove(int id)
        {
            cheeses.Remove(GetById(id));
        }

    }
}
