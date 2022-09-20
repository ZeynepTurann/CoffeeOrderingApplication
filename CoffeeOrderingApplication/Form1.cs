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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //using (ProjectContext db = new ProjectContext())
            //{
            //    db.Coffees.Add(new Coffee { Name = "Americano", Price = 18.25m, IsOnSale = true, ProductionTime = 2, AddedDate = DateTime.Now });
            //    db.Coffees.Add(new Coffee { Name = "Latte", Price = 20.00m, IsOnSale = true, ProductionTime = 2, AddedDate = DateTime.Now });
            //    db.Coffees.Add(new Coffee { Name = "Frappucino", Price = 21.25m, IsOnSale = true, ProductionTime = 3, AddedDate = DateTime.Now });
            //    db.Coffees.Add(new Coffee { Name = "Mocha", Price = 19.75m, IsOnSale = true, ProductionTime = 2, AddedDate = DateTime.Now });
            //    db.Coffees.Add(new Coffee { Name = "Filtre", Price = 15.25m, IsOnSale = true, ProductionTime = 2, AddedDate = DateTime.Now });
            //    db.Coffees.Add(new Coffee { Name = "Macchiato", Price = 18.25m, IsOnSale = true, ProductionTime = 2, AddedDate = DateTime.Now });
            //    db.Coffees.Add(new Coffee { Name = "FlatWhite", Price = 18.25m, IsOnSale = true, ProductionTime = 2, AddedDate = DateTime.Now });

            //    db.Extras.Add(new Extra { Name = "Caramel Syrup", Price = 1.25m, IsOnSale = true, ProductionTime = 1, AddedDate = DateTime.Now });
            //    db.Extras.Add(new Extra { Name = "Raspberry Syrup", Price = 1.15m, IsOnSale = true, ProductionTime = 1, AddedDate = DateTime.Now });
            //    db.Extras.Add(new Extra { Name = "Extra Shot", Price = 0.75m, IsOnSale = true, ProductionTime = 1, AddedDate = DateTime.Now });
            //    db.Extras.Add(new Extra { Name = "Extra Crema", Price = 1.15m, IsOnSale = true, ProductionTime = 1, AddedDate = DateTime.Now });
            //    db.Extras.Add(new Extra { Name = "Ice", Price = 2.00m, IsOnSale = true, ProductionTime = 1, AddedDate = DateTime.Now });
            //    db.Cashiers.Add(new Cashier { FirstName = "Micheal", LastName = "Scofield", HireDate = DateTime.Now, Duty = "Kasiyer 1" });
            //    db.SaveChanges();
           // }
        }
        private void btnRepCus_Click(object sender, EventArgs e)
        {
            ReportingCus repCus = new ReportingCus();
            repCus.Show();
            this.Hide();
        }

        private void btnShopView_Click(object sender, EventArgs e)
        {
            ShopView shopView = new ShopView();
            shopView.Show();
            this.Hide();
        }

        private void btnRepPay_Click(object sender, EventArgs e)
        {
            ReportingPayment reportingPayment = new ReportingPayment();
            reportingPayment.Show();
            this.Hide();
        }

        private void btnRepOrder_Click(object sender, EventArgs e)
        {
            ReportingOrder repOrder = new ReportingOrder();
            repOrder.Show();
            this.Hide();
        }

        private void btnCoffeeCrud_Click(object sender, EventArgs e)
        {
            CoffeeCRUD coffeeCrud = new CoffeeCRUD();
            coffeeCrud.Show();
            this.Hide();
        }

        private void btnExtraCrud_Click(object sender, EventArgs e)
        {
            ExtraCRUD extraCrud=new ExtraCRUD();
            extraCrud.Show();
            this.Hide();

        }
    }
}
