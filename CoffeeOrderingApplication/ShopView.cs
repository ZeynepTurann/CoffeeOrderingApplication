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
    public partial class ShopView : Form
    {
        public ShopView()
        {
            InitializeComponent();
        }

        int min1=0,min2=0,min3=0,min4=0,min5=0,min6=0;
        int sec1=0,sec2=0,sec3=0,sec4=0,sec5=0,sec6=0;

        private void timer5_Tick(object sender, EventArgs e)
        {
            sec5++;
            lblSecond5.Text = sec5.ToString();
            if (sec5 == 60)
            {
                min5++;
                lblMinute5.Text = min5.ToString();
                sec5 = 0;
                if (min5 == Convert.ToInt16(lblTime5.Text))
                {
                    timer5.Stop();
                    listBarista3.Items.RemoveAt(0);
                }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            sec6++;
            lblSecond6.Text = sec6.ToString();
            if (sec6 == 60)
            {
                min6++;
                lblMinute6.Text = min6.ToString();
                sec6 = 0;
                if (min6 == Convert.ToInt16(lblTime6.Text))
                {
                    timer6.Stop();
                    listBarista3.Items.RemoveAt(0);
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            sec4++;
            lblSecond4.Text = sec4.ToString();
            if (sec4 == 60)
            {
                min4++;
                lblMinute4.Text = min4.ToString();
                sec4 = 0;
                if (min4 == Convert.ToInt16(lblTime4.Text))
                {
                    timer4.Stop();
                    listBarista2.Items.RemoveAt(0);
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sec3++;
            lblSecond3.Text = sec3.ToString();
            if (sec3 == 60)
            {
                min3++;
                lblMinute3.Text = min3.ToString();
                sec3 = 0;
                if (min3 == Convert.ToInt16(lblTime3.Text))
                {
                    timer3.Stop();
                    listBarista2.Items.RemoveAt(0);
                }
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sec2++;
            lblSecond2.Text = sec2.ToString();
            if (sec2==60)
            {
                min2++;
                lblMinute2.Text = min2.ToString();
                sec2 = 0;
                if (min2==Convert.ToInt16(lblTime2.Text))
                {
                    timer2.Stop();
                    listBarista1.Items.RemoveAt(0);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec1++;
            lblSecond1.Text = sec1.ToString();
            if (sec1==60)
            {
                min1++;
                lblMinute1.Text = min1.ToString();
                sec1 = 0;
                if (min1==Convert.ToInt16(lblTime1.Text))
                {
                    timer1.Stop();
                    listBarista1.Items.Remove(0);
                }
            }
        }

        private void btnback3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
            
        }

        private void ShopView_Load(object sender, EventArgs e)
        {
            using (ProjectContext db = new ProjectContext())
            {
                foreach (Customer cus in db.Customers.ToList())
                    listCustomerLine.Items.Add(cus);
            }
        }

        private void btnYourTurn_Click(object sender, EventArgs e)
        {
            //The first customer in line arrives at the cashier to order
            listCashier.Items.Add(listCustomerLine.SelectedItem);
            listCustomerLine.Items.Remove(listCustomerLine.SelectedItem);
        }
        private int BringCus()
        {
            int index = 0;
            for (int i = 0; i < listCashier.Items.Count; i++)
            {
                Customer gelen = (Customer)listCashier.Items[i];
                index = gelen.Id;
            }
            return index;
        }

        private void btnContinueOrder_Click(object sender, EventArgs e)
        {
             txtTotalCost.Clear();
             int customerIndex = BringCus();
             lblCusId.Text=customerIndex.ToString();
             GiveOrder giveOrder = new GiveOrder(customerIndex);
             giveOrder.Show();
            
        }

        private void btnPaynBar_Click(object sender, EventArgs e)
        {
            double totalTime = 0;
            decimal totalAmount = 0;
            foreach (Order item in GiveOrder.activeOrders)
            {
                totalTime += item.OrderTime;
                totalAmount += item.OrderPrice;
            }
            lblTotalTime.Text = totalTime.ToString();
            txtTotalCost.Text=totalAmount.ToString();

            GiveOrder.activeOrders.Clear();

            decimal amount = Convert.ToDecimal(txtTotalCost.Text);
            Payment payment = new Payment(amount);
            if (rdbApp.Checked)
            {
                payment.PaymentType = PaymentType.AppWallet;
            }
            else if (rdbCash.Checked)
            {
                payment.PaymentType = PaymentType.Cash;
            }
            else
            {
                payment.PaymentType = PaymentType.CreditCard;
            }
            payment.CustomerId = Convert.ToInt16(lblCusId.Text);
            using (ProjectContext db = new ProjectContext())
            {
                Customer activeCustomer = db.Customers.Find(Convert.ToInt32(lblCusId.Text));
                activeCustomer.Payments.Add(payment);
                //db.Payments.Add(payment);
                db.SaveChanges();
                MessageBox.Show("Payment Completed Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            //After payment we will transfer the order to the available barista

            if (listBarista1.Items.Count==2 && listBarista2.Items.Count==2 &&listBarista3.Items.Count==2)
            {
                MessageBox.Show("All employees are BUSY, kindly wait.");
                btnPaynBar.Enabled = false;
            }
            else
            {
                btnPaynBar.Enabled = true;
            }

            string[] baristalist = { "Barista 1", "Barista 2", "Barista 3" };
            Random employee = new Random();

            string result;

            result = baristalist[employee.Next(baristalist.Length)];
            if (result == "Barista 1")
            {
                if (listBarista1.Items.Count == 0)
                {
                    timer1.Start();
                    lblTime1.Text = lblTotalTime.Text;
                    listBarista1.Items.Add(listCashier.SelectedItem);
                    listCashier.Items.Remove(listCashier.SelectedItem);
                }
                else if (listBarista1.Items.Count == 1)
                {
                    if (timer1.Enabled == true)
                    {
                        timer2.Start();
                        lblTime2.Text = lblTotalTime.Text;
                        listBarista1.Items.Add(listCashier.SelectedItem);
                        listCashier.Items.Remove(listCashier.SelectedItem);
                    }
                    else
                    {
                        timer1.Start();
                        lblTime1.Text = lblTotalTime.Text;
                        listBarista1.Items.Add(listCashier.SelectedItem);
                        listCashier.Items.Remove(listCashier.SelectedItem);
                    }

                }
                else if (listBarista1.Items.Count == 2)
                {
                    MessageBox.Show("A barista can take a maximum of two orders. Please try again.!");
                    
                }

            }
            else if (result == "Barista 2")
            {
                if (listBarista2.Items.Count==0)
                {
                    timer3.Start();
                    lblTime3.Text = lblTotalTime.Text;
                    listBarista2.Items.Add(listCashier.SelectedItem);
                    listCashier.Items.Remove(listCashier.SelectedItem);
                }
                else if (listBarista2.Items.Count==1)
                {
                    if (timer3.Enabled==true)
                    {
                        timer4.Start();
                        lblTime4.Text = lblTotalTime.Text;
                        listBarista2.Items.Add(listCashier.SelectedItem);
                        listCashier.Items.Remove(listCashier.SelectedItem);
                    }
                    else
                    {
                        timer3.Start();
                        lblTime3.Text= lblTotalTime.Text;
                        listBarista2.Items.Add(listCashier.SelectedItem);
                        listCashier.Items.Remove(listCashier.SelectedItem);
                    }


                }
                else if (listBarista2.Items.Count==2)
                {
                    MessageBox.Show("A barista can take a maximum of two orders.Please try again.");
                }

            }
            else if (result=="Barista 3")
            {
                if (listBarista3.Items.Count == 0)
                {
                    timer5.Start();
                    lblTime5.Text = lblTotalTime.Text;
                    listBarista3.Items.Add(listCashier.SelectedItem);
                    listCashier.Items.Remove(listCashier.SelectedItem);
                }
                else if (listBarista3.Items.Count==1)
                {
                    if (timer5.Enabled==true)
                    {
                        timer6.Start();
                        lblTime6.Text = lblTotalTime.Text;
                        listBarista3.Items.Add(listCashier.SelectedItem);
                        listCashier.Items.Remove(listCashier.SelectedItem);
                    }
                    else
                    {
                        timer5.Start();
                        lblTime5.Text = lblTotalTime.Text;
                        listBarista3.Items.Add(listCashier.SelectedItem);
                        listCashier.Items.Remove(listCashier.SelectedItem);
                    }
                }
                else if (listBarista3.Items.Count==2)
                {
                    MessageBox.Show("A barista can take a maximum of two orders.Please try again.");
                }

            }




        }
    }
}
