using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeOrderingApplication.Entities
{
    public class Customer
    {
        public Customer()
        {
            Orders = new List<Order>();
            Payments = new List<Payment>();
            //To avoid null reference exception error
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "CustomerName cannot be left blank!")]
        [MaxLength(50)]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "CustomerSurname cannot be left blank!")]
        [MaxLength(50)]
        public string CustomerSurname { get; set; }

        public string CallNumber { get; set; }

        [MaxLength(150)]
        public string Address { get; set; }

        //[NotMapped]
        public virtual Cashier Cashier { get; set; }

        //Navigation Props Begin
        public List<Order> Orders { get; set; }   //One to Many relationship
        public List<Payment> Payments { get; set; }

        public override string ToString()
        {
            return CustomerName;
        }
    }
}
