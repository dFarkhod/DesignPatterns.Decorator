namespace Virtualdars.DesignPatterns.Decorator
{
    public class DiscountedOrderDecorator : Order
    {
        protected Order _order = null;
        public DiscountedOrderDecorator(Order order)
        {
            _order = order;
            this.Products = order.Products;
            this.OrderDate = order.OrderDate;
        }
        public override double CalculateTotalPrice()
        {
            double totalPrice = _order.CalculateTotalPrice();
            return totalPrice;
        }

    }
}
