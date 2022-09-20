using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeOrderingApplication.Entities
{
    public class Extra:BaseProduct
    {
        public decimal Price { get; set; }
        public double ProductionTime { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
