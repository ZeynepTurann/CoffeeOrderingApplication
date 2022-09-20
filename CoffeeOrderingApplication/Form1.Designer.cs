namespace CoffeeOrderingApplication
{
    partial class MainForm
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
            this.btnRepPay = new System.Windows.Forms.Button();
            this.btnShopView = new System.Windows.Forms.Button();
            this.btnRepOrder = new System.Windows.Forms.Button();
            this.btnRepCus = new System.Windows.Forms.Button();
            this.btnCoffeeCrud = new System.Windows.Forms.Button();
            this.btnExtraCrud = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRepPay
            // 
            this.btnRepPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRepPay.Font = new System.Drawing.Font("Forte", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRepPay.Location = new System.Drawing.Point(260, 147);
            this.btnRepPay.Name = "btnRepPay";
            this.btnRepPay.Size = new System.Drawing.Size(225, 137);
            this.btnRepPay.TabIndex = 17;
            this.btnRepPay.Text = "Reporting Payments";
            this.btnRepPay.UseVisualStyleBackColor = false;
            this.btnRepPay.Click += new System.EventHandler(this.btnRepPay_Click);
            // 
            // btnShopView
            // 
            this.btnShopView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShopView.Font = new System.Drawing.Font("Forte", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShopView.Location = new System.Drawing.Point(12, 12);
            this.btnShopView.Name = "btnShopView";
            this.btnShopView.Size = new System.Drawing.Size(232, 129);
            this.btnShopView.TabIndex = 16;
            this.btnShopView.Text = "Shop View";
            this.btnShopView.UseVisualStyleBackColor = false;
            this.btnShopView.Click += new System.EventHandler(this.btnShopView_Click);
            // 
            // btnRepOrder
            // 
            this.btnRepOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRepOrder.Font = new System.Drawing.Font("Forte", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRepOrder.Location = new System.Drawing.Point(12, 147);
            this.btnRepOrder.Name = "btnRepOrder";
            this.btnRepOrder.Size = new System.Drawing.Size(232, 137);
            this.btnRepOrder.TabIndex = 15;
            this.btnRepOrder.Text = "Reporting Orders";
            this.btnRepOrder.UseVisualStyleBackColor = false;
            this.btnRepOrder.Click += new System.EventHandler(this.btnRepOrder_Click);
            // 
            // btnRepCus
            // 
            this.btnRepCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRepCus.Font = new System.Drawing.Font("Forte", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRepCus.Location = new System.Drawing.Point(260, 12);
            this.btnRepCus.Name = "btnRepCus";
            this.btnRepCus.Size = new System.Drawing.Size(225, 129);
            this.btnRepCus.TabIndex = 14;
            this.btnRepCus.Text = "Reporting Customers";
            this.btnRepCus.UseVisualStyleBackColor = false;
            this.btnRepCus.Click += new System.EventHandler(this.btnRepCus_Click);
            // 
            // btnCoffeeCrud
            // 
            this.btnCoffeeCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCoffeeCrud.Font = new System.Drawing.Font("Forte", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCoffeeCrud.Location = new System.Drawing.Point(12, 290);
            this.btnCoffeeCrud.Name = "btnCoffeeCrud";
            this.btnCoffeeCrud.Size = new System.Drawing.Size(232, 137);
            this.btnCoffeeCrud.TabIndex = 18;
            this.btnCoffeeCrud.Text = "Coffee Crud Operations";
            this.btnCoffeeCrud.UseVisualStyleBackColor = false;
            this.btnCoffeeCrud.Click += new System.EventHandler(this.btnCoffeeCrud_Click);
            // 
            // btnExtraCrud
            // 
            this.btnExtraCrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExtraCrud.Font = new System.Drawing.Font("Forte", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExtraCrud.Location = new System.Drawing.Point(260, 290);
            this.btnExtraCrud.Name = "btnExtraCrud";
            this.btnExtraCrud.Size = new System.Drawing.Size(225, 137);
            this.btnExtraCrud.TabIndex = 19;
            this.btnExtraCrud.Text = "Extra Crud Operations";
            this.btnExtraCrud.UseVisualStyleBackColor = false;
            this.btnExtraCrud.Click += new System.EventHandler(this.btnExtraCrud_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(498, 434);
            this.Controls.Add(this.btnExtraCrud);
            this.Controls.Add(this.btnCoffeeCrud);
            this.Controls.Add(this.btnRepPay);
            this.Controls.Add(this.btnShopView);
            this.Controls.Add(this.btnRepOrder);
            this.Controls.Add(this.btnRepCus);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRepPay;
        private System.Windows.Forms.Button btnShopView;
        private System.Windows.Forms.Button btnRepOrder;
        private System.Windows.Forms.Button btnRepCus;
        private System.Windows.Forms.Button btnCoffeeCrud;
        private System.Windows.Forms.Button btnExtraCrud;
    }
}

