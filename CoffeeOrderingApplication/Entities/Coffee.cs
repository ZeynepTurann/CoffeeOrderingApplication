using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeOrderingApplication.Entities
{
    public class Coffee:BaseProduct
    {
        private decimal _price;
        private double _time;

        [Required]
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Price of product cannot be smaller than 0");
                }
            }
        }
        public double ProductionTime
        {
            get { return _time; }
            set
            {
                if (value > 0)
                {
                    _time = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Price of product cannot be smaller than 0");
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
