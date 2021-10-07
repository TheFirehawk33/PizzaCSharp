namespace PizzaAPI.Repositories
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        public Pizza(int Id, string Name, string Ingredients, double Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Ingredients = Ingredients;
            this.Price = Price;
        }
    }
}