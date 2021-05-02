namespace Project_Login
{
    partial class Customer_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Details));
            this.dtCustomerDetails = new System.Windows.Forms.DataGridView();
            this.btnBBM = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtCustomerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCustomerDetails
            // 
            this.dtCustomerDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCustomerDetails.Location = new System.Drawing.Point(114, 84);
            this.dtCustomerDetails.Name = "dtCustomerDetails";
            this.dtCustomerDetails.Size = new System.Drawing.Size(687, 288);
            this.dtCustomerDetails.TabIndex = 4;
            // 
            // btnBBM
            // 
            this.btnBBM.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnBBM.BackgroundImage = global::Project_Login.Properties.Resources.return_button;
            this.btnBBM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBBM.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBBM.Location = new System.Drawing.Point(410, 414);
            this.btnBBM.Name = "btnBBM";
            this.btnBBM.Size = new System.Drawing.Size(80, 55);
            this.btnBBM.TabIndex = 13;
            this.btnBBM.UseVisualStyleBackColor = false;
            this.btnBBM.Click += new System.EventHandler(this.btnBBM_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label9.Location = new System.Drawing.Point(283, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(326, 40);
            this.label9.TabIndex = 74;
            this.label9.Text = "Customer Details";
            // 
            // Customer_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Project_Login.Properties.Resources.manuel_moreno_DGa0LQ0yDPc_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 511);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBBM);
            this.Controls.Add(this.dtCustomerDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Customer_Details";
            this.Text = "Customer_Details";
            this.Load += new System.EventHandler(this.Customer_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCustomerDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtCustomerDetails;
        private System.Windows.Forms.Button btnBBM;
        private System.Windows.Forms.Label label9;
    }
}