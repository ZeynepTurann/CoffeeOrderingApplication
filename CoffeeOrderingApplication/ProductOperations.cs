using CoffeeOrderingApplication.Entities;
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
    public partial class ProductOperations : Form
    {
        public ProductOperations()
        {
            InitializeComponent();
        }
        

        private void btnCoffeeAdd_Click(object sender, EventArgs e)
        {
            Coffee cof = new Coffee();
            cof.Name = txtCoffeeName.Text;
            cof.Price = Convert.ToDecimal(txtCofPrice.Text);
            cof.ProductionTime = Convert.ToInt16(txtCofTime.Text);
            cof.AddedDate = DateTime.Now;
             using(ProjectContext db=new ProjectContext())
            {
                db.Coffees.Add(cof);
                db.SaveChanges();
            }

        }

        private void btnCoffeeList_Click(object sender, EventArgs e)
        {
            using(ProjectContext db=new ProjectContext())
            {
                lvProduct.Items.Clear();
                foreach (Coffee coffee in db.Coffees.ToList())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text=coffee.Id.ToString();  
                    lvi.SubItems.Add(coffee.Name);
                    lvi.SubItems.Add(coffee.Price.ToString("C2"));
                    lvi.SubItems.Add(coffee.ProductionTime.ToString());
                    lvi.SubItems.Add(coffee.AddedDate.ToString());
                    lvi.SubItems.Add(coffee.IsOnSale.ToString());
                    lvi.Tag = coffee.Id;
                    lvProduct.Items.Add(lvi);
                }
            }
        }
        private void btnExtraList_Click(object sender, EventArgs e)
        {
            
           

            

        }

        private void btnCoffeeUp_Click(object sender, EventArgs e)
        {

        }

        private void lvProduct_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
