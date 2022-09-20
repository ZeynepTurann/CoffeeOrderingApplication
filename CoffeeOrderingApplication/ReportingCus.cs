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
    public partial class ReportingCus : Form
    {
        public ReportingCus()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        #region Methods
        void CustomerList()
        {
            lvCustomerList.Items.Clear();
            foreach (Customer item in db.Customers.ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.Id.ToString();
                lvi.SubItems.Add(item.CustomerName);
                lvi.SubItems.Add(item.CustomerSurname);
                lvi.SubItems.Add(item.CallNumber);
                lvi.SubItems.Add(item.Address);
                lvi.Tag = item.Id;
                lvCustomerList.Items.Add(lvi);
            }
        }

        #endregion
        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            db.Customers.Add(new Entities.Customer
            {
                CustomerName = txtName.Text,
                CustomerSurname = txtSurname.Text,
                CallNumber = mskTextPhone.Text,
                Address = txtAddress.Text,
            });

            db.SaveChanges();
            MessageBox.Show("Completed Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleaningFunction.ClearControls(this.Controls);
            CustomerList();
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            CustomerList();
        }

        private void btnback4_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
