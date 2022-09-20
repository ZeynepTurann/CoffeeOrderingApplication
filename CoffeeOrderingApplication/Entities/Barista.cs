using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeOrderingApplication.Entities
{
    public class Barista:ActiveEmployee
    {
        [Key]
        public int Id { get; set; }
    }
}
