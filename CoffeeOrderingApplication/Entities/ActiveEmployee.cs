using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeOrderingApplication.Entities
{
    public abstract class ActiveEmployee
    {
        [Required(ErrorMessage = "First Name cannot be left blank!")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "First Name cannot be left blank!")]
        [MaxLength(50)]
        public string LastName { get; set; }

        public DateTime? HireDate { get; set; }

        public string Duty { get; set; }
    }
}
