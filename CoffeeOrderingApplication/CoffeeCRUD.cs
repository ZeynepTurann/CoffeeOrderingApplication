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
    public partial class CoffeeCRUD : Form
    {
        public CoffeeCRUD()
        {
            InitializeComponent();
        }
        ProjectContext db=new ProjectContext();
        #region Methods
        void CoffeeList()
        {
            lvProduct.Items.Clear();
            foreach (Coffee coffee in db.Coffees.ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = coffee.Id.ToString();
                lvi.SubItems.Add(coffee.Name);
                lvi.SubItems.Add(coffee.Price.ToString("C2"));
                lvi.SubItems.Add(coffee.ProductionTime.ToString());
                lvi.SubItems.Add(coffee.AddedDate.ToString());
                lvi.SubItems.Add(coffee.IsOnSale.ToString());
                lvi.Tag = coffee.Id;
                lvProduct.Items.Add(lvi);
            }
        }

        #endregion

        private void btnCoffeeList_Click(object sender, EventArgs e)
        {
            CoffeeList();
        }

        private void btnCoffeeAdd_Click(object sender, EventArgs e)
        {
            Coffee cof = new Coffee();
            cof.Name = txtCoffeeName.Text;
            cof.Price = Convert.ToDecimal(txtCofPrice.Text);
            cof.ProductionTime = Convert.ToInt16(txtCofTime.Text);
            cof.AddedDate = DateTime.Now;
            db.Coffees.Add(cof);
            db.SaveChanges();
            MessageBox.Show("Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleaningFunction.ClearControls(this.Controls);
            CoffeeList();
        }
        Coffee updated;
        private void btnCoffeeUp_Click(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count <= 0 && updated == null) return;
            updated.Name = txtCoffeeName.Text;
            updated.Price= Convert.ToDecimal(txtCofPrice.Text); 
            updated.ProductionTime = Convert.ToInt16(txtCofTime.Text);
            if (rdbYes.Checked)
            {
                updated.IsOnSale = true;
            }
            else
            {
                updated.IsOnSale = false;
            }
            db.Entry(db.Coffees.Find(updated.Id)).CurrentValues.SetValues(updated);
            db.SaveChanges();
            MessageBox.Show("Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleaningFunction.ClearControls(this.Controls);
            CoffeeList();

        }

        private void lvProduct_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lvProduct.SelectedItems[0].Tag);
            updated = db.Coffees.Find(id);
            txtCoffeeName.Text = updated.Name;
            txtCofPrice.Text = updated.Price.ToString();
            txtCofTime.Text = updated.ProductionTime.ToString();
        }   
                
            
        private void btnCoffeeDel_Click(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count <= 0) return;
            Coffee deletedCof = db.Coffees.Find(lvProduct.SelectedItems[0].Tag);
            db.Coffees.Remove(deletedCof);
            db.SaveChanges();
            MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleaningFunction.ClearControls(this.Controls);
            CoffeeList();


        }

        private void btnback4_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
