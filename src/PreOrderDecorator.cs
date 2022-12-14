using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualdars.DesignPatterns.Decorator
{
    public class PreOrderDecorator : DiscountedOrderDecorator
    {
        public PreOrderDecorator(Order order) : base(order)
        {
        }

        public override double CalculateTotalPrice()
        {
            double totalPrice = _order.CalculateTotalPrice() * 0.90;
            return totalPrice;
        }
    }
}
