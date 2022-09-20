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
    public partial class ExtraCRUD : Form
    {
        public ExtraCRUD()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        #region Methods
       void  ExtraList()
        {
            lvProduct.Items.Clear();
            foreach (Extra extra in db.Extras.ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = extra.Id.ToString();
                lvi.SubItems.Add(extra.Name);
                lvi.SubItems.Add(extra.Price.ToString("C2"));
                lvi.SubItems.Add(extra.ProductionTime.ToString());
                lvi.SubItems.Add(extra.AddedDate.ToString());
                lvi.SubItems.Add(extra.IsOnSale.ToString());
                lvi.Tag = extra.Id;
                lvProduct.Items.Add(lvi);
            }

        }
        #endregion

        private void btnExtraList_Click(object sender, EventArgs e)
        {
            ExtraList();
        }

        private void btnExAdd_Click(object sender, EventArgs e)
        {
            Extra ex = new Extra();
            ex.Name =txtExName.Text;
            ex.Price = Convert.ToDecimal(txtExPrice.Text);
            ex.ProductionTime = Convert.ToInt16(txtExTime.Text);
            ex.AddedDate = DateTime.Now;
            db.Extras.Add(ex);
            db.SaveChanges();
            MessageBox.Show("Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleaningFunction.ClearControls(this.Controls);
            ExtraList();
        }

        private void btnExUp_Click(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count <= 0 && updated == null) return;
            updated.Name = txtExName.Text;
            updated.Price = Convert.ToDecimal(txtExPrice.Text);
            updated.ProductionTime = Convert.ToInt16(txtExTime.Text);
            if (rdbYes.Checked)
            {
                updated.IsOnSale = true;
            }
            else
            {
                updated.IsOnSale = false;
            }
            db.Entry(db.Extras.Find(updated.Id)).CurrentValues.SetValues(updated);
            db.SaveChanges();
            MessageBox.Show("Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleaningFunction.ClearControls(this.Controls);
            ExtraList();


        }
        Extra updated;
        private void lvProduct_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lvProduct.SelectedItems[0].Tag);
            updated = db.Extras.Find(id);
            txtExName.Text = updated.Name;
            txtExPrice.Text = updated.Price.ToString();
            txtExTime.Text = updated.ProductionTime.ToString();
        }

        private void btnExDel_Click(object sender, EventArgs e)
        {
            if (lvProduct.SelectedItems.Count <= 0) return;
            Extra deletedEx = db.Extras.Find(lvProduct.SelectedItems[0].Tag);
            db.Extras.Remove(deletedEx);
            db.SaveChanges();
            MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CleaningFunction.ClearControls(this.Controls);
            ExtraList();
        }

        private void btnback4_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
    
}
