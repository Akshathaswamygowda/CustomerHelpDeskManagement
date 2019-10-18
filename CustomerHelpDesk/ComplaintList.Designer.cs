namespace CustomerHelpDesk
{
    partial class ComplaintList
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
            this.ddltask = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grvcomplaints)).BeginInit();
            this.SuspendLayout();
            // 
            // grvcomplaints
            // 
            this.grvcomplaints.AllowUserToAddRows = false;
            this.grvcomplaints.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grvcomplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvcomplaints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.ddltask,
            this.Column6});
            this.grvcomplaints.Location = new System.Drawing.Point(12, 63);
            this.grvcomplaints.Name = "grvcomplaints";
            this.grvcomplaints.Size = new System.Drawing.Size(697, 223);
            this.grvcomplaints.TabIndex = 4;
            this.grvcomplaints.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvcomplaints_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "customer_name";
            this.Column1.HeaderText = "Customer_Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "customer_ph";
            this.Column2.HeaderText = "Customer_Phone";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "product_id";
            this.Column3.HeaderText = "product_id";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Complaint_Box";
            this.Column4.HeaderText = "Complaint";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "complaint_date";
            this.Column5.HeaderText = "Complaint_Date";
            this.Column5.Name = "Column5";
            // 
            // ddltask
            // 
            dataGridViewCellStyle1.NullValue = "New Task";
            this.ddltask.DefaultCellStyle = dataGridViewCellStyle1;
            this.ddltask.HeaderText = "Status";
            this.ddltask.Items.AddRange(new object[] {
            "New Task",
            "Assign",
            "Delete"});
            this.ddltask.Name = "ddltask";
            this.ddltask.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ddltask.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Avialable Technician";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(310, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Complaint List";
            // 
            // ComplaintList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(747, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvcomplaints);
            this.Name = "ComplaintList";
            this.Text = "ComplaintList";
            this.Load += new System.EventHandler(this.ComplaintList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvcomplaints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvcomplaints;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn ddltask;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column6;
        private System.Windows.Forms.Label label1;
    }
}