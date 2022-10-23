using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualdars.DesignPatterns.Decorator
{
    public class Product
    {
       public string Name { get; set; }
       public double Price { get; set; }
       public DateTime MfgDate { get; set; }
       public DateTime ExpDate { get; set; }
    }
}
