namespace CoffeeOrderingApplication
{
    partial class CoffeeCRUD
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
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbYes = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCoffeeDel = new System.Windows.Forms.Button();
            this.btnCoffeeUp = new System.Windows.Forms.Button();
            this.btnCoffeeAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCofTime = new System.Windows.Forms.TextBox();
            this.txtCofPrice = new System.Windows.Forms.TextBox();
            this.txtCoffeeName = new System.Windows.Forms.TextBox();
            this.lvProduct = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductionTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsOnSale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCoffeeList = new System.Windows.Forms.Button();
            this.btnback4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox1.Controls.Add(this.rdbNo);
            this.groupBox1.Controls.Add(this.rdbYes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCoffeeDel);
            this.groupBox1.Controls.Add(this.btnCoffeeUp);
            this.groupBox1.Controls.Add(this.btnCoffeeAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCofTime);
            this.groupBox1.Controls.Add(this.txtCofPrice);
            this.groupBox1.Controls.Add(this.txtCoffeeName);
            this.groupBox1.Location = new System.Drawing.Point(98, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coffees";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(182, 105);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(39, 17);
            this.rdbNo.TabIndex = 11;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbYes
            // 
            this.rdbYes.AutoSize = true;
            this.rdbYes.Location = new System.Drawing.Point(133, 104);
            this.rdbYes.Name = "rdbYes";
            this.rdbYes.Size = new System.Drawing.Size(43, 17);
            this.rdbYes.TabIndex = 10;
            this.rdbYes.TabStop = true;
            this.rdbYes.Text = "Yes";
            this.rdbYes.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(27, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Is On Sale?";
            // 
            // btnCoffeeDel
            // 
            this.btnCoffeeDel.BackColor = System.Drawing.Color.Gray;
            this.btnCoffeeDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCoffeeDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCoffeeDel.Location = new System.Drawing.Point(356, 96);
            this.btnCoffeeDel.Name = "btnCoffeeDel";
            this.btnCoffeeDel.Size = new System.Drawing.Size(98, 32);
            this.btnCoffeeDel.TabIndex = 8;
            this.btnCoffeeDel.Text = "REMOVE";
            this.btnCoffeeDel.UseVisualStyleBackColor = false;
            this.btnCoffeeDel.Click += new System.EventHandler(this.btnCoffeeDel_Click);
            // 
            // btnCoffeeUp
            // 
            this.btnCoffeeUp.BackColor = System.Drawing.Color.Gray;
            this.btnCoffeeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCoffeeUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCoffeeUp.Location = new System.Drawing.Point(356, 58);
            this.btnCoffeeUp.Name = "btnCoffeeUp";
            this.btnCoffeeUp.Size = new System.Drawing.Size(98, 32);
            this.btnCoffeeUp.TabIndex = 7;
            this.btnCoffeeUp.Text = "UPDATE";
            this.btnCoffeeUp.UseVisualStyleBackColor = false;
            this.btnCoffeeUp.Click += new System.EventHandler(this.btnCoffeeUp_Click);
            // 
            // btnCoffeeAdd
            // 
            this.btnCoffeeAdd.BackColor = System.Drawing.Color.Gray;
            this.btnCoffeeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCoffeeAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCoffeeAdd.Location = new System.Drawing.Point(356, 19);
            this.btnCoffeeAdd.Name = "btnCoffeeAdd";
            this.btnCoffeeAdd.Size = new System.Drawing.Size(98, 32);
            this.btnCoffeeAdd.TabIndex = 6;
            this.btnCoffeeAdd.Text = "ADD";
            this.btnCoffeeAdd.UseVisualStyleBackColor = false;
            this.btnCoffeeAdd.Click += new System.EventHandler(this.btnCoffeeAdd_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(27, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Coffee Production \r\nTime:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coffee (Tall) Price:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coffee Name:";
            // 
            // txtCofTime
            // 
            this.txtCofTime.Location = new System.Drawing.Point(133, 71);
            this.txtCofTime.Name = "txtCofTime";
            this.txtCofTime.Size = new System.Drawing.Size(178, 20);
            this.txtCofTime.TabIndex = 2;
            // 
            // txtCofPrice
            // 
            this.txtCofPrice.Location = new System.Drawing.Point(133, 45);
            this.txtCofPrice.Name = "txtCofPrice";
            this.txtCofPrice.Size = new System.Drawing.Size(178, 20);
            this.txtCofPrice.TabIndex = 1;
            // 
            // txtCoffeeName
            // 
            this.txtCoffeeName.Location = new System.Drawing.Point(133, 19);
            this.txtCoffeeName.Name = "txtCoffeeName";
            this.txtCoffeeName.Size = new System.Drawing.Size(178, 20);
            this.txtCoffeeName.TabIndex = 0;
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
            this.lvProduct.Location = new System.Drawing.Point(26, 169);
            this.lvProduct.Name = "lvProduct";
            this.lvProduct.Size = new System.Drawing.Size(532, 243);
            this.lvProduct.TabIndex = 3;
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
            // btnCoffeeList
            // 
            this.btnCoffeeList.BackColor = System.Drawing.Color.Gray;
            this.btnCoffeeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCoffeeList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCoffeeList.Location = new System.Drawing.Point(12, 90);
            this.btnCoffeeList.Name = "btnCoffeeList";
            this.btnCoffeeList.Size = new System.Drawing.Size(75, 66);
            this.btnCoffeeList.TabIndex = 4;
            this.btnCoffeeList.Text = "Show Coffee List";
            this.btnCoffeeList.UseVisualStyleBackColor = false;
            this.btnCoffeeList.Click += new System.EventHandler(this.btnCoffeeList_Click);
            // 
            // btnback4
            // 
            this.btnback4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnback4.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnback4.ForeColor = System.Drawing.Color.Black;
            this.btnback4.Location = new System.Drawing.Point(0, 3);
            this.btnback4.Name = "btnback4";
            this.btnback4.Size = new System.Drawing.Size(55, 29);
            this.btnback4.TabIndex = 74;
            this.btnback4.Text = "Back ";
            this.btnback4.UseVisualStyleBackColor = false;
            this.btnback4.Click += new System.EventHandler(this.btnback4_Click);
            // 
            // CoffeeCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.btnback4);
            this.Controls.Add(this.btnCoffeeList);
            this.Controls.Add(this.lvProduct);
            this.Controls.Add(this.groupBox1);
            this.Name = "CoffeeCRUD";
            this.Text = "CoffeeCRUD";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCoffeeDel;
        private System.Windows.Forms.Button btnCoffeeUp;
        private System.Windows.Forms.Button btnCoffeeAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCofTime;
        private System.Windows.Forms.TextBox txtCofPrice;
        private System.Windows.Forms.TextBox txtCoffeeName;
        private System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductPrice;
        private System.Windows.Forms.ColumnHeader ProductionTime;
        private System.Windows.Forms.ColumnHeader AddedDate;
        private System.Windows.Forms.ColumnHeader IsOnSale;
        private System.Windows.Forms.Button btnCoffeeList;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbYes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnback4;
    }
}