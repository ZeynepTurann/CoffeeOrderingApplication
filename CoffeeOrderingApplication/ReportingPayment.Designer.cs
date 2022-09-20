namespace CoffeeOrderingApplication
{
    partial class ReportingPayment
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
            this.btnShowList = new System.Windows.Forms.Button();
            this.lstViewPayment = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PaymentType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnback4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowList
            // 
            this.btnShowList.BackColor = System.Drawing.Color.Gray;
            this.btnShowList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowList.Location = new System.Drawing.Point(435, 21);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(133, 101);
            this.btnShowList.TabIndex = 6;
            this.btnShowList.Text = "Show Payment List";
            this.btnShowList.UseVisualStyleBackColor = false;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // lstViewPayment
            // 
            this.lstViewPayment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.PaymentType,
            this.TotalCost,
            this.CustomerId});
            this.lstViewPayment.FullRowSelect = true;
            this.lstViewPayment.GridLines = true;
            this.lstViewPayment.HideSelection = false;
            this.lstViewPayment.Location = new System.Drawing.Point(1, 42);
            this.lstViewPayment.Name = "lstViewPayment";
            this.lstViewPayment.Size = new System.Drawing.Size(396, 408);
            this.lstViewPayment.TabIndex = 5;
            this.lstViewPayment.UseCompatibleStateImageBehavior = false;
            this.lstViewPayment.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 85;
            // 
            // PaymentType
            // 
            this.PaymentType.Text = "Payment Type";
            this.PaymentType.Width = 103;
            // 
            // TotalCost
            // 
            this.TotalCost.Text = "Income";
            this.TotalCost.Width = 92;
            // 
            // CustomerId
            // 
            this.CustomerId.Text = "CustomerId";
            this.CustomerId.Width = 111;
            // 
            // btnback4
            // 
            this.btnback4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnback4.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnback4.ForeColor = System.Drawing.Color.Black;
            this.btnback4.Location = new System.Drawing.Point(1, 7);
            this.btnback4.Name = "btnback4";
            this.btnback4.Size = new System.Drawing.Size(55, 29);
            this.btnback4.TabIndex = 75;
            this.btnback4.Text = "Back ";
            this.btnback4.UseVisualStyleBackColor = false;
            this.btnback4.Click += new System.EventHandler(this.btnback4_Click);
            // 
            // ReportingPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(589, 456);
            this.Controls.Add(this.btnback4);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.lstViewPayment);
            this.Name = "ReportingPayment";
            this.Text = "ReportingPayment";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.ListView lstViewPayment;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader PaymentType;
        private System.Windows.Forms.ColumnHeader TotalCost;
        private System.Windows.Forms.ColumnHeader CustomerId;
        private System.Windows.Forms.Button btnback4;
    }
}