using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeOrderingApplication.Entities
{
    public abstract class BaseProduct
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }

        [MaxLength(50)]
        [Column(Order = 2)]
        [Required]
        public string Name { get; set; }

        public DateTime? AddedDate { get; set; }
        public bool IsOnSale { get; set; } = true;
    }
}
