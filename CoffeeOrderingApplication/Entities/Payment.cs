using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeOrderingApplication.Entities
{
    public class Payment
    {
        public Payment()
        {

        }
        [Key]
        public int Id { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [Required]
        public PaymentType PaymentType { get; set; }

        [Required]
        public decimal PayableAmount { get; set; }

        //Relational Properties Begin
        public virtual Customer Customer { get; set; }


        public Payment(decimal totalCost)
        {
            PayableAmount = totalCost;
        }
    }
}
