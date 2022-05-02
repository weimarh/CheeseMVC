namespace CheeseMVC.Models
{
    public class Cheese
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public CheeseType Type { get; set; }

        private static int nextId = 1;

        public Cheese()
        {
            Id = nextId;
            nextId++;
        }

       
    }
}
