using CoffeeOrderingApplication.Entities;
using CoffeeOrderingApplication.Functions;
using CoffeeOrderingApplication.ORM.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeOrderingApplication
{
    public partial class GiveOrder : Form
    {
        public int CustomerIndex { get; set; }
        public GiveOrder(int index)
        {
            InitializeComponent();
            CustomerIndex = index;
            lblCusId2.Text = CustomerIndex.ToString();

        }
        public GiveOrder()
        {
            InitializeComponent();
        }
        //Collection
        public static List<Order> activeOrders = new List<Order>();

        #region Calculation Methods
      public decimal CalculateTotalCost()
        {
            decimal totalCost = 0;
            for (int i = 0; i < listOrders.Items.Count; i++)
            {
                Order newOrder = (Order)listOrders.Items[i];
                totalCost += newOrder.OrderPrice;
            }
            lblTotalCost.Text = totalCost.ToString("C2");
            return totalCost;
        }
      public double CalculateTotalTime()
        {
            double totalTime = 0;
            for (int j = 0; j < listOrders.Items.Count; j++)
            {
                Order newOrder = (Order)listOrders.Items[j];
                totalTime += newOrder.OrderTime;
            }
            lblTotalProductiontime.Text = totalTime.ToString();
            return totalTime;
        }
        #endregion

        private void GiveOrder_Load(object sender, EventArgs e)
        {
            using (ProjectContext db = new ProjectContext())
            {
                //Adding coffees to the combobox
                foreach (Coffee coffee in db.Coffees.ToList())
                {
                    cmbChooseCoffee.Items.Add(coffee);
                }

                //Adding extras as checkbox
                foreach (Extra ex in db.Extras.ToList())
                    flowLayoutPanel1.Controls.Add(new CheckBox() { Text = ex.Name, Tag = ex });
            }
            cmbChooseCoffee.SelectedIndex = 0;
        }

        private void btnSeeOrders_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.CashierId = 1;
            order.SelectedCoffee = (Coffee)cmbChooseCoffee.SelectedItem;
            order.OrderTime = order.SelectedCoffee.ProductionTime;

            //Select Size
            if (rdbTall.Checked)
            {
                order.Size = Entities.Size.Tall;

            }
            else if (rdbGrande.Checked)
            {
                order.Size = Entities.Size.Grande;
            }
            else
            {
                order.Size = Entities.Size.Venti;
            }

            //Select Extras
            order.Extras = new List<Extra>();
            foreach (CheckBox item in flowLayoutPanel1.Controls)
            {
                if (item.Checked)
                {
                    order.Extras.Add((Extra)item.Tag);
                }
            }

            //Select Count
            order.Count = Convert.ToInt32(nmrCount.Value);
            order.OrderDate = DateTime.Now;

            order.CalculateOrderAmount();
            order.CalculateOrderTime();

            activeOrders.Add(order);
            listOrders.Items.Add(order);
            CalculateTotalCost();
            CalculateTotalTime();
            using (ProjectContext db = new ProjectContext())
            {
                Customer gelen = db.Customers.Find(CustomerIndex);
                gelen.Orders.Add(order);
                db.SaveChanges();

            }

            CleaningFunction.ClearControls(this.Controls);
        }

        private void btnGetOrder_Click(object sender, EventArgs e)
        {
            listOrders.Items.Clear();
            this.Hide();
            
           
        }

        private void btnback4_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
