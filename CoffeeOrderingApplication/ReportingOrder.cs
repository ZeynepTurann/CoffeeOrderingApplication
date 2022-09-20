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
    public partial class ReportingOrder : Form
    {
        public ReportingOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ProjectContext db = new ProjectContext())
            {
                foreach (Order item in db.Orders.ToList())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.Id.ToString();
                    lvi.SubItems.Add(item.CustomerId.ToString());
                    lvi.SubItems.Add(item.CashierId.ToString());
                    lvi.SubItems.Add(item.OrderPrice.ToString());
                    lvi.SubItems.Add(item.OrderTime.ToString());
                    lvi.SubItems.Add(item.Size.ToString());
                    lvi.SubItems.Add(item.Count.ToString());
                    lvi.SubItems.Add(item.OrderDate.ToString());
                    lvi.Tag = item.Id;
                    lvOrderList.Items.Add(lvi);
                }
            }
        }

        private void btnback4_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
