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
    public partial class ReportingPayment : Form
    {
        public ReportingPayment()
        {
            InitializeComponent();
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            using (ProjectContext db = new ProjectContext())
            {
                
                
                    lstViewPayment.Items.Clear();
                    foreach (Payment item in db.Payments.ToList())
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = item.Id.ToString();
                        lvi.SubItems.Add(item.PaymentType.ToString());
                        lvi.SubItems.Add(item.PayableAmount.ToString());
                        lvi.SubItems.Add(item.CustomerId.ToString());
                        lvi.Tag = item.Id;
                        lstViewPayment.Items.Add(lvi);
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
