namespace Project_Login
{
    partial class EmployeeDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnBBM = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmployeeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Delete Employee";
            // 
            // tbSearchID
            // 
            this.tbSearchID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbSearchID.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchID.Location = new System.Drawing.Point(195, 231);
            this.tbSearchID.Name = "tbSearchID";
            this.tbSearchID.Size = new System.Drawing.Size(197, 29);
            this.tbSearchID.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(195, 296);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 47);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtEmployeeDetails
            // 
            this.dtEmployeeDetails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEmployeeDetails.Location = new System.Drawing.Point(424, 148);
            this.dtEmployeeDetails.Name = "dtEmployeeDetails";
            this.dtEmployeeDetails.Size = new System.Drawing.Size(468, 280);
            this.dtEmployeeDetails.TabIndex = 6;
            this.dtEmployeeDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLoad.Location = new System.Drawing.Point(765, 95);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(127, 47);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load All";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnBBM
            // 
            this.btnBBM.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnBBM.Location = new System.Drawing.Point(765, 35);
            this.btnBBM.Name = "btnBBM";
            this.btnBBM.Size = new System.Drawing.Size(127, 47);
            this.btnBBM.TabIndex = 8;
            this.btnBBM.Text = "Back to Menu";
            this.btnBBM.UseVisualStyleBackColor = true;
            this.btnBBM.Click += new System.EventHandler(this.btnBBM_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Employee ID";
            // 
            // EmployeeDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(904, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBBM);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtEmployeeDetails);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbSearchID);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeDelete";
            this.Text = "EmployeeDelete";
            ((System.ComponentModel.ISupportInitialize)(this.dtEmployeeDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dtEmployeeDetails;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnBBM;
        private System.Windows.Forms.Label label2;
    }
}