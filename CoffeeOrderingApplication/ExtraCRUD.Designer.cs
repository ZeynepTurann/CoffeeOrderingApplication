namespace CoffeeOrderingApplication
{
    partial class ExtraCRUD
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbYes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExDel = new System.Windows.Forms.Button();
            this.btnExUp = new System.Windows.Forms.Button();
            this.btnExAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExTime = new System.Windows.Forms.TextBox();
            this.txtExPrice = new System.Windows.Forms.TextBox();
            this.txtExName = new System.Windows.Forms.TextBox();
            this.lvProduct = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductionTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddedDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IsOnSale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExtraList = new System.Windows.Forms.Button();
            this.btnback4 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox2.Controls.Add(this.rdbNo);
            this.groupBox2.Controls.Add(this.rdbYes);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnExDel);
            this.groupBox2.Controls.Add(this.btnExUp);
            this.groupBox2.Controls.Add(this.btnExAdd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtExTime);
            this.groupBox2.Controls.Add(this.txtExPrice);
            this.groupBox2.Controls.Add(this.txtExName);
            this.groupBox2.Location = new System.Drawing.Point(142, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 151);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Is On Sale:";
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(206, 107);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(39, 17);
            this.rdbNo.TabIndex = 17;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbYes
            // 
            this.rdbYes.AutoSize = true;
            this.rdbYes.Location = new System.Drawing.Point(147, 106);
            this.rdbYes.Name = "rdbYes";
            this.rdbYes.Size = new System.Drawing.Size(43, 17);
            this.rdbYes.TabIndex = 16;
            this.rdbYes.TabStop = true;
            this.rdbYes.Text = "Yes";
            this.rdbYes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(40, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Is On Sale:";
            // 
            // btnExDel
            // 
            this.btnExDel.BackColor = System.Drawing.Color.Gray;
            this.btnExDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExDel.Location = new System.Drawing.Point(330, 92);
            this.btnExDel.Name = "btnExDel";
            this.btnExDel.Size = new System.Drawing.Size(98, 32);
            this.btnExDel.TabIndex = 14;
            this.btnExDel.Text = "REMOVE";
            this.btnExDel.UseVisualStyleBackColor = false;
            this.btnExDel.Click += new System.EventHandler(this.btnExDel_Click);
            // 
            // btnExUp
            // 
            this.btnExUp.BackColor = System.Drawing.Color.Gray;
            this.btnExUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExUp.Location = new System.Drawing.Point(330, 54);
            this.btnExUp.Name = "btnExUp";
            this.btnExUp.Size = new System.Drawing.Size(98, 32);
            this.btnExUp.TabIndex = 13;
            this.btnExUp.Text = "UPDATE";
            this.btnExUp.UseVisualStyleBackColor = false;
            this.btnExUp.Click += new System.EventHandler(this.btnExUp_Click);
            // 
            // btnExAdd
            // 
            this.btnExAdd.BackColor = System.Drawing.Color.Gray;
            this.btnExAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExAdd.Location = new System.Drawing.Point(330, 16);
            this.btnExAdd.Name = "btnExAdd";
            this.btnExAdd.Size = new System.Drawing.Size(98, 32);
            this.btnExAdd.TabIndex = 12;
            this.btnExAdd.Text = "ADD";
            this.btnExAdd.UseVisualStyleBackColor = false;
            this.btnExAdd.Click += new System.EventHandler(this.btnExAdd_Click);
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
            // txtExTime
            // 
            this.txtExTime.Location = new System.Drawing.Point(146, 71);
            this.txtExTime.Name = "txtExTime";
            this.txtExTime.Size = new System.Drawing.Size(178, 20);
            this.txtExTime.TabIndex = 8;
            // 
            // txtExPrice
            // 
            this.txtExPrice.Location = new System.Drawing.Point(146, 42);
            this.txtExPrice.Name = "txtExPrice";
            this.txtExPrice.Size = new System.Drawing.Size(178, 20);
            this.txtExPrice.TabIndex = 7;
            // 
            // txtExName
            // 
            this.txtExName.Location = new System.Drawing.Point(146, 16);
            this.txtExName.Name = "txtExName";
            this.txtExName.Size = new System.Drawing.Size(178, 20);
            this.txtExName.TabIndex = 6;
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
            this.lvProduct.Location = new System.Drawing.Point(42, 169);
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
            // btnExtraList
            // 
            this.btnExtraList.BackColor = System.Drawing.Color.Gray;
            this.btnExtraList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExtraList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExtraList.Location = new System.Drawing.Point(42, 96);
            this.btnExtraList.Name = "btnExtraList";
            this.btnExtraList.Size = new System.Drawing.Size(75, 67);
            this.btnExtraList.TabIndex = 5;
            this.btnExtraList.Text = "Show Extra List";
            this.btnExtraList.UseVisualStyleBackColor = false;
            this.btnExtraList.Click += new System.EventHandler(this.btnExtraList_Click);
            // 
            // btnback4
            // 
            this.btnback4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnback4.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnback4.ForeColor = System.Drawing.Color.Black;
            this.btnback4.Location = new System.Drawing.Point(0, 3);
            this.btnback4.Name = "btnback4";
            this.btnback4.Size = new System.Drawing.Size(57, 29);
            this.btnback4.TabIndex = 74;
            this.btnback4.Text = "Back ";
            this.btnback4.UseVisualStyleBackColor = false;
            this.btnback4.Click += new System.EventHandler(this.btnback4_Click);
            // 
            // ExtraCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(613, 439);
            this.Controls.Add(this.btnback4);
            this.Controls.Add(this.btnExtraList);
            this.Controls.Add(this.lvProduct);
            this.Controls.Add(this.groupBox2);
            this.Name = "ExtraCRUD";
            this.Text = "ExtraCRUD";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExDel;
        private System.Windows.Forms.Button btnExUp;
        private System.Windows.Forms.Button btnExAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExTime;
        private System.Windows.Forms.TextBox txtExPrice;
        private System.Windows.Forms.TextBox txtExName;
        private System.Windows.Forms.ListView lvProduct;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductPrice;
        private System.Windows.Forms.ColumnHeader ProductionTime;
        private System.Windows.Forms.ColumnHeader AddedDate;
        private System.Windows.Forms.ColumnHeader IsOnSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExtraList;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbYes;
        private System.Windows.Forms.Button btnback4;
    }
}