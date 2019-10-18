namespace CustomerHelpDesk
{
    partial class Technician
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grvcomplaints = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvcomplaints)).BeginInit();
            this.SuspendLayout();
            // 
            // grvcomplaints
            // 
            this.grvcomplaints.AllowUserToAddRows = false;
            this.grvcomplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvcomplaints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.grvcomplaints.Location = new System.Drawing.Point(32, 54);
            this.grvcomplaints.Name = "grvcomplaints";
            this.grvcomplaints.Size = new System.Drawing.Size(345, 150);
            this.grvcomplaints.TabIndex = 0;
            this.grvcomplaints.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvcomplaints_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tech_name";
            this.Column1.HeaderText = "Tech_Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "product_id";
            this.Column2.HeaderText = "Product_id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Complaint";
            this.Column3.HeaderText = "Complaint";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NoDays";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cost";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            dataGridViewCellStyle1.NullValue = "In Progress";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column6.HeaderText = "Status";
            this.Column6.Items.AddRange(new object[] {
            "Solved",
            "In Progress"});
            this.Column6.Name = "Column6";
            // 
            // Technician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 299);
            this.Controls.Add(this.grvcomplaints);
            this.Name = "Technician";
            this.Text = "Technician";
            this.Load += new System.EventHandler(this.Technician_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvcomplaints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvcomplaints;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column6;
    }
}