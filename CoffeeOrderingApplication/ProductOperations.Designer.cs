namespace CoffeeOrderingApplication
{
    partial class ProductOperations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvProduct = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductionTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsOnSale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCoffeeName = new System.Windows.Forms.TextBox();
            this.txtCofPrice = new System.Windows.Forms.TextBox();
            this.txtCofTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnCoffeeAdd = new System.Windows.Forms.Button();
            this.btnCoffeeUp = new System.Windows.Forms.Button();
            this.btnCoffeeDel = new System.Windows.Forms.Button();
            this.btnExDel = new System.Windows.Forms.Button();
            this.btnExUp = new System.Windows.Forms.Button();
            this.btnExAdd = new System.Windows.Forms.Button();
            this.btnCoffeeList = new System.Windows.Forms.Button();
            this.btnExtraList = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCoffeeDel);
            this.groupBox1.Controls.Add(this.btnCoffeeUp);
            this.groupBox1.Controls.Add(this.btnCoffeeAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCofTime);
            this.groupBox1.Controls.Add(this.txtCofPrice);
            this.groupBox1.Controls.Add(this.txtCoffeeName);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coffees";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExDel);
            this.groupBox2.Controls.Add(this.btnExUp);
            this.groupBox2.Controls.Add(this.btnExAdd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Location = new System.Drawing.Point(393, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 151);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras";
            // 
            // lvProduct
            // 
            this.lvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.ProductName,
            this.ProductPrice,
            this.ProductionTime,
            this.AddedDate,
            this.IsOnSale});
            this.lvProduct.FullRowSelect = true;
            this.lvProduct.GridLines = true;
            this.lvProduct.HideSelection = false;
            this.lvProduct.Location = new System.Drawing.Point(105, 179);
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(532, 243);
            this.lvProduct.TabIndex = 2;
            this.lvProduct.UseCompatibleStateImageBehavior = false;
            this.lvProduct.View = System.Windows.Forms.View.Details;
            this.lvProduct.DoubleClick += new System.EventHandler(this.lvProduct_DoubleClick);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // ProductName
            // 
            this.ProductName.Text = "Product Name";
            this.ProductName.Width = 99;
            // 
            // ProductPrice
            // 
            this.ProductPrice.Text = "Product Price";
            this.ProductPrice.Width = 97;
            // 
            // ProductionTime
            // 
            this.ProductionTime.Text = "Production Time";
            this.ProductionTime.Width = 101;
            // 
            // AddedDate
            // 
            this.AddedDate.Text = "Added Date";
            this.AddedDate.Width = 100;
            // 
            // IsOnSale
            // 
            this.IsOnSale.Text = "Is On Sale";
            this.IsOnSale.Width = 103;
            // 
            // txtCoffeeName
            // 
            this.txtCoffeeName.Location = new System.Drawing.Point(133, 19);
            this.txtCoffeeName.Name = "txtCoffeeName";
            this.txtCoffeeName.Size = new System.Drawing.Size(178, 20);
            this.txtCoffeeName.TabIndex = 0;
            // 
            // txtCofPrice
            // 
            this.txtCofPrice.Location = new System.Drawing.Point(133, 45);
            this.txtCofPrice.Name = "txtCofPrice";
            this.txtCofPrice.Size = new System.Drawing.Size(178, 20);
            this.txtCofPrice.TabIndex = 1;
            // 
            // txtCofTime
            // 
            this.txtCofTime.Location = new System.Drawing.Point(133, 71);
            this.txtCofTime.Name = "txtCofTime";
            this.txtCofTime.Size = new System.Drawing.Size(178, 20);
            this.txtCofTime.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coffee Name:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coffee (Tall) Price:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(27, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Coffee Production \r\nTime:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(40, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Extra Production \r\nTime:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(40, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Extra Price:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(40, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Extra Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(178, 20);
            this.textBox3.TabIndex = 6;
            // 
            // btnCoffeeAdd
            // 
            this.btnCoffeeAdd.Location = new System.Drawing.Point(17, 102);
            this.btnCoffeeAdd.Name = "btnCoffeeAdd";
            this.btnCoffeeAdd.Size = new System.Drawing.Size(98, 32);
            this.btnCoffeeAdd.TabIndex = 6;
            this.btnCoffeeAdd.Text = "ADD";
            this.btnCoffeeAdd.UseVisualStyleBackColor = true;
            this.btnCoffeeAdd.Click += new System.EventHandler(this.btnCoffeeAdd_Click);
            // 
            // btnCoffeeUp
            // 
            this.btnCoffeeUp.Location = new System.Drawing.Point(133, 102);
            this.btnCoffeeUp.Name = "btnCoffeeUp";
            this.btnCoffeeUp.Size = new System.Drawing.Size(98, 32);
            this.btnCoffeeUp.TabIndex = 7;
            this.btnCoffeeUp.Text = "UPDATE";
            this.btnCoffeeUp.UseVisualStyleBackColor = true;
            this.btnCoffeeUp.Click += new System.EventHandler(this.btnCoffeeUp_Click);
            // 
            // btnCoffeeDel
            // 
            this.btnCoffeeDel.Location = new System.Drawing.Point(249, 102);
            this.btnCoffeeDel.Name = "btnCoffeeDel";
            this.btnCoffeeDel.Size = new System.Drawing.Size(98, 32);
            this.btnCoffeeDel.TabIndex = 8;
            this.btnCoffeeDel.Text = "REMOVE";
            this.btnCoffeeDel.UseVisualStyleBackColor = true;
            // 
            // btnExDel
            // 
            this.btnExDel.Location = new System.Drawing.Point(245, 105);
            this.btnExDel.Name = "btnExDel";
            this.btnExDel.Size = new System.Drawing.Size(98, 32);
            this.btnExDel.TabIndex = 14;
            this.btnExDel.Text = "REMOVE";
            this.btnExDel.UseVisualStyleBackColor = true;
            // 
            // btnExUp
            // 
            this.btnExUp.Location = new System.Drawing.Point(129, 105);
            this.btnExUp.Name = "btnExUp";
            this.btnExUp.Size = new System.Drawing.Size(98, 32);
            this.btnExUp.TabIndex = 13;
            this.btnExUp.Text = "UPDATE";
            this.btnExUp.UseVisualStyleBackColor = true;
            // 
            // btnExAdd
            // 
            this.btnExAdd.Location = new System.Drawing.Point(13, 105);
            this.btnExAdd.Name = "btnExAdd";
            this.btnExAdd.Size = new System.Drawing.Size(98, 32);
            this.btnExAdd.TabIndex = 12;
            this.btnExAdd.Text = "ADD";
            this.btnExAdd.UseVisualStyleBackColor = true;
            // 
            // btnCoffeeList
            // 
            this.btnCoffeeList.Location = new System.Drawing.Point(13, 191);
            this.btnCoffeeList.Name = "btnCoffeeList";
            this.btnCoffeeList.Size = new System.Drawing.Size(75, 44);
            this.btnCoffeeList.TabIndex = 3;
            this.btnCoffeeList.Text = "Show Coffee List";
            this.btnCoffeeList.UseVisualStyleBackColor = true;
            this.btnCoffeeList.Click += new System.EventHandler(this.btnCoffeeList_Click);
            // 
            // btnExtraList
            // 
            this.btnExtraList.Location = new System.Drawing.Point(12, 241);
            this.btnExtraList.Name = "btnExtraList";
            this.btnExtraList.Size = new System.Drawing.Size(75, 44);
            this.btnExtraList.TabIndex = 4;
            this.btnExtraList.Text = "Show Extra List";
            this.btnExtraList.UseVisualStyleBackColor = true;
            this.btnExtraList.Click += new System.EventHandler(this.btnExtraList_Click);
            // 
            // ProductOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExtraList);
            this.Controls.Add(this.btnCoffeeList);
            this.Controls.Add(this.lvProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductOperations";
            this.Text = "ProductOperations";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductPrice;
        private System.Windows.Forms.Button btnCoffeeDel;
        private System.Windows.Forms.Button btnCoffeeUp;
        private System.Windows.Forms.Button btnCoffeeAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCofTime;
        private System.Windows.Forms.TextBox txtCofPrice;
        private System.Windows.Forms.TextBox txtCoffeeName;
        private System.Windows.Forms.Button btnExDel;
        private System.Windows.Forms.Button btnExUp;
        private System.Windows.Forms.Button btnExAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ColumnHeader ProductionTime;
        private System.Windows.Forms.ColumnHeader AddedDate;
        private System.Windows.Forms.ColumnHeader IsOnSale;
        private System.Windows.Forms.Button btnCoffeeList;
        private System.Windows.Forms.Button btnExtraList;
    }
}