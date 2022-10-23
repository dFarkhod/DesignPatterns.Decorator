namespace Virtualdars.DesignPatterns.Decorator
{
    public class Order
    {
        public List<Product> Products { get; set; } = new();

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public virtual double CalculateTotalPrice()
        {
            return Products.Sum(p => p.Price);
        }

    }
}
