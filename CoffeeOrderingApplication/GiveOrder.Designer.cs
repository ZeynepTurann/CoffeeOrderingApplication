namespace CoffeeOrderingApplication
{
    partial class GiveOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiveOrder));
            this.lblCusId2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnback4 = new System.Windows.Forms.Button();
            this.btnGetOrder = new System.Windows.Forms.Button();
            this.lblTotalProductiontime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listOrders = new System.Windows.Forms.ListBox();
            this.btnSeeOrders = new System.Windows.Forms.Button();
            this.nmrCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbVenti = new System.Windows.Forms.RadioButton();
            this.rdbGrande = new System.Windows.Forms.RadioButton();
            this.rdbTall = new System.Windows.Forms.RadioButton();
            this.cmbChooseCoffee = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCusId2
            // 
            this.lblCusId2.AutoSize = true;
            this.lblCusId2.Location = new System.Drawing.Point(234, 535);
            this.lblCusId2.Name = "lblCusId2";
            this.lblCusId2.Size = new System.Drawing.Size(19, 13);
            this.lblCusId2.TabIndex = 101;
            this.lblCusId2.Text = "00";
            this.lblCusId2.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(5, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 100;
            this.label5.Text = "Choose Quantity";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Location = new System.Drawing.Point(8, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 99;
            this.label3.Text = "Extras";
            // 
            // btnback4
            // 
            this.btnback4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnback4.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnback4.ForeColor = System.Drawing.Color.Black;
            this.btnback4.Location = new System.Drawing.Point(8, 4);
            this.btnback4.Name = "btnback4";
            this.btnback4.Size = new System.Drawing.Size(67, 27);
            this.btnback4.TabIndex = 98;
            this.btnback4.Text = "Back";
            this.btnback4.UseVisualStyleBackColor = false;
            this.btnback4.Click += new System.EventHandler(this.btnback4_Click);
            // 
            // btnGetOrder
            // 
            this.btnGetOrder.BackColor = System.Drawing.Color.Sienna;
            this.btnGetOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGetOrder.Location = new System.Drawing.Point(579, 432);
            this.btnGetOrder.Name = "btnGetOrder";
            this.btnGetOrder.Size = new System.Drawing.Size(200, 61);
            this.btnGetOrder.TabIndex = 97;
            this.btnGetOrder.Text = "Tell Your Order To Cashier";
            this.btnGetOrder.UseVisualStyleBackColor = false;
            this.btnGetOrder.Click += new System.EventHandler(this.btnGetOrder_Click);
            // 
            // lblTotalProductiontime
            // 
            this.lblTotalProductiontime.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProductiontime.Location = new System.Drawing.Point(115, 462);
            this.lblTotalProductiontime.Name = "lblTotalProductiontime";
            this.lblTotalProductiontime.Size = new System.Drawing.Size(84, 19);
            this.lblTotalProductiontime.TabIndex = 96;
            this.lblTotalProductiontime.Text = "Total Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 95;
            this.label4.Text = "Total Time:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(115, 432);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(84, 19);
            this.lblTotalCost.TabIndex = 94;
            this.lblTotalCost.Text = "Total Cost ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 93;
            this.label2.Text = "Total Cost :";
            // 
            // listOrders
            // 
            this.listOrders.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listOrders.FormattingEnabled = true;
            this.listOrders.Location = new System.Drawing.Point(291, 33);
            this.listOrders.Name = "listOrders";
            this.listOrders.Size = new System.Drawing.Size(504, 355);
            this.listOrders.TabIndex = 92;
            // 
            // btnSeeOrders
            // 
            this.btnSeeOrders.BackColor = System.Drawing.Color.Sienna;
            this.btnSeeOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeeOrders.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSeeOrders.Location = new System.Drawing.Point(8, 494);
            this.btnSeeOrders.Name = "btnSeeOrders";
            this.btnSeeOrders.Size = new System.Drawing.Size(200, 41);
            this.btnSeeOrders.TabIndex = 91;
            this.btnSeeOrders.Text = "See Order List ";
            this.btnSeeOrders.UseVisualStyleBackColor = false;
            this.btnSeeOrders.Click += new System.EventHandler(this.btnSeeOrders_Click);
            // 
            // nmrCount
            // 
            this.nmrCount.Location = new System.Drawing.Point(114, 349);
            this.nmrCount.Name = "nmrCount";
            this.nmrCount.Size = new System.Drawing.Size(154, 20);
            this.nmrCount.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Choose Your coffe From List ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Bisque;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 166);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 172);
            this.flowLayoutPanel1.TabIndex = 87;
            this.flowLayoutPanel1.Tag = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.rdbVenti);
            this.groupBox1.Controls.Add(this.rdbGrande);
            this.groupBox1.Controls.Add(this.rdbTall);
            this.groupBox1.Location = new System.Drawing.Point(8, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 64);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Size";
            // 
            // rdbVenti
            // 
            this.rdbVenti.AutoSize = true;
            this.rdbVenti.Location = new System.Drawing.Point(142, 29);
            this.rdbVenti.Name = "rdbVenti";
            this.rdbVenti.Size = new System.Drawing.Size(49, 17);
            this.rdbVenti.TabIndex = 2;
            this.rdbVenti.TabStop = true;
            this.rdbVenti.Text = "Venti";
            this.rdbVenti.UseVisualStyleBackColor = true;
            // 
            // rdbGrande
            // 
            this.rdbGrande.AutoSize = true;
            this.rdbGrande.Location = new System.Drawing.Point(74, 29);
            this.rdbGrande.Name = "rdbGrande";
            this.rdbGrande.Size = new System.Drawing.Size(60, 17);
            this.rdbGrande.TabIndex = 1;
            this.rdbGrande.TabStop = true;
            this.rdbGrande.Text = "Grande";
            this.rdbGrande.UseVisualStyleBackColor = true;
            // 
            // rdbTall
            // 
            this.rdbTall.AutoSize = true;
            this.rdbTall.Location = new System.Drawing.Point(6, 29);
            this.rdbTall.Name = "rdbTall";
            this.rdbTall.Size = new System.Drawing.Size(42, 17);
            this.rdbTall.TabIndex = 0;
            this.rdbTall.TabStop = true;
            this.rdbTall.Text = "Tall";
            this.rdbTall.UseVisualStyleBackColor = true;
            // 
            // cmbChooseCoffee
            // 
            this.cmbChooseCoffee.FormattingEnabled = true;
            this.cmbChooseCoffee.Location = new System.Drawing.Point(8, 50);
            this.cmbChooseCoffee.Name = "cmbChooseCoffee";
            this.cmbChooseCoffee.Size = new System.Drawing.Size(200, 21);
            this.cmbChooseCoffee.TabIndex = 88;
            // 
            // GiveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.lblCusId2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnback4);
            this.Controls.Add(this.btnGetOrder);
            this.Controls.Add(this.lblTotalProductiontime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listOrders);
            this.Controls.Add(this.btnSeeOrders);
            this.Controls.Add(this.nmrCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbChooseCoffee);
            this.DoubleBuffered = true;
            this.Name = "GiveOrder";
            this.Text = "GiveOrder";
            this.Load += new System.EventHandler(this.GiveOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblCusId2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnback4;
        private System.Windows.Forms.Button btnGetOrder;
        private System.Windows.Forms.Label lblTotalProductiontime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listOrders;
        private System.Windows.Forms.Button btnSeeOrders;
        private System.Windows.Forms.NumericUpDown nmrCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbVenti;
        private System.Windows.Forms.RadioButton rdbGrande;
        private System.Windows.Forms.RadioButton rdbTall;
        public System.Windows.Forms.ComboBox cmbChooseCoffee;
    }
}