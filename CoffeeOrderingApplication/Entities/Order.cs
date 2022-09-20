using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeOrderingApplication.Entities
{
    public class Order
    {
        private int _count;

        [Key]
        public int Id { get; set; }

        [NotMapped]
        public Coffee SelectedCoffee { get; set; }

        public List<Extra> Extras { get; set; }

        public Size Size { get; set; }
        public decimal OrderPrice { get; set; }
        public double OrderTime { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [ForeignKey("Cashier")]
        public int CashierId { get; set; }


        public int Count
        {
            get => _count;
            set => _count = value;
        }
        public DateTime? OrderDate { get; set; }

        //Relational Properties Begin

        public virtual Customer Customer { get; set; }
        public virtual Cashier Cashier { get; set; }

        public void CalculateOrderAmount()
        {
            OrderPrice = 0;
            OrderPrice += SelectedCoffee.Price;

            switch (Size)
            {
                case Size.Tall:
                    OrderPrice += 0;
                    break;
                case Size.Grande:
                    OrderPrice += 2;
                    break;
                case Size.Venti:
                    OrderPrice += 5;
                    break;
            }
            foreach (Extra ex in Extras)
            {
                OrderPrice += ex.Price;
            }
            OrderPrice = OrderPrice * Count;
        }
        public void CalculateOrderTime()
        {
            OrderTime = 0;
            OrderTime += SelectedCoffee.ProductionTime;
            foreach (Extra ex in Extras)
            {
                OrderTime += ex.ProductionTime;
            }
            OrderTime = OrderTime * Count;
        }

        public override string ToString()
        {

            if (Extras.Count < 1)
            {
                return string.Format("{0}, x{1} Count, {2} Size, {3}: Amount, {4} Time", SelectedCoffee.Name, Count.ToString(), Size.ToString(), OrderPrice.ToString("C2"), OrderTime.ToString());
            }
            else
            {
                string extraproducts = null;
                foreach (Extra ex in Extras)
                {
                    extraproducts += ex.Name + ",";
                    extraproducts.Trim(',');
                }
                return string.Format("{0}, x{1} Count, {2} Size, ({3}) Extras, Amount: {4}," +
                       " {5} Minutes ", SelectedCoffee.Name, Count.ToString(), Size.ToString(), extraproducts, OrderPrice.ToString("C2"), OrderTime.ToString());



            }

        }
    }
}
