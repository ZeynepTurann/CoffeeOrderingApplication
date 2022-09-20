using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeOrderingApplication.Entities
{
    public class Cashier:ActiveEmployee
    {
        public Cashier()
        {
            Orders = new List<Order>();
        }

       
        [Key]
        public int Id { get; set; }

        //NavigationProp Begin
        public List<Order> Orders { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
