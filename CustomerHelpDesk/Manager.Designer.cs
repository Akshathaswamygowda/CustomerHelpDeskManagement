namespace CustomerHelpDesk
{
    partial class Manager
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
            this.grvproducts = new System.Windows.Forms.DataGridView();
            this.lbproducts = new System.Windows.Forms.Label();
            this.lbusertech = new System.Windows.Forms.LinkLabel();
            this.lbcomplaints = new System.Windows.Forms.LinkLabel();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvproducts)).BeginInit();
            this.SuspendLayout();
            // 
            // grvproducts
            // 
            this.grvproducts.AllowDrop = true;
            this.grvproducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grvproducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grvproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvproducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Name,
            this.Product_Brand,
            this.Product_id,
            this.product_des});
            this.grvproducts.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.grvproducts.Location = new System.Drawing.Point(24, 54);
            this.grvproducts.Name = "grvproducts";
            this.grvproducts.ShowCellErrors = false;
            this.grvproducts.Size = new System.Drawing.Size(639, 171);
            this.grvproducts.TabIndex = 0;
            this.grvproducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvproducts_CellContentClick);
            this.grvproducts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvproducts_CellValueChanged);
            // 
            // lbproducts
            // 
            this.lbproducts.AutoSize = true;
            this.lbproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproducts.ForeColor = System.Drawing.Color.Black;
            this.lbproducts.Location = new System.Drawing.Point(109, 9);
            this.lbproducts.Name = "lbproducts";
            this.lbproducts.Size = new System.Drawing.Size(158, 18);
            this.lbproducts.TabIndex = 1;
            this.lbproducts.Text = "Product Description";
            // 
            // lbusertech
            // 
            this.lbusertech.AutoSize = true;
            this.lbusertech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusertech.Location = new System.Drawing.Point(428, 290);
            this.lbusertech.Name = "lbusertech";
            this.lbusertech.Size = new System.Drawing.Size(192, 16);
            this.lbusertech.TabIndex = 2;
            this.lbusertech.TabStop = true;
            this.lbusertech.Text = "ADD USERS/TECHNICIAN";
            this.lbusertech.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbuser_LinkClicked);
            // 
            // lbcomplaints
            // 
            this.lbcomplaints.AutoSize = true;
            this.lbcomplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcomplaints.Location = new System.Drawing.Point(40, 290);
            this.lbcomplaints.Name = "lbcomplaints";
            this.lbcomplaints.Size = new System.Drawing.Size(104, 16);
            this.lbcomplaints.TabIndex = 4;
            this.lbcomplaints.TabStop = true;
            this.lbcomplaints.Text = "COMPLAINTS";
            this.lbcomplaints.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbcomplaints_LinkClicked);
            // 
            // Product_Name
            // 
            this.Product_Name.DataPropertyName = "product_name";
            this.Product_Name.HeaderText = "Product_Name";
            this.Product_Name.Name = "Product_Name";
            // 
            // Product_Brand
            // 
            this.Product_Brand.DataPropertyName = "product_brand";
            this.Product_Brand.HeaderText = "Product_Brand";
            this.Product_Brand.Name = "Product_Brand";
            // 
            // Product_id
            // 
            this.Product_id.DataPropertyName = "product_id";
            this.Product_id.HeaderText = "Product_Id";
            this.Product_id.Name = "Product_id";
            this.Product_id.ReadOnly = true;
            this.Product_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // product_des
            // 
            this.product_des.DataPropertyName = "product_description";
            this.product_des.HeaderText = "Product_Description";
            this.product_des.Name = "product_des";
            this.product_des.Width = 400;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(690, 507);
            this.Controls.Add(this.lbcomplaints);
            this.Controls.Add(this.lbusertech);
            this.Controls.Add(this.lbproducts);
            this.Controls.Add(this.grvproducts);
            this.MinimizeBox = false;
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvproducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbproducts;
        private System.Windows.Forms.DataGridView grvproducts;
        private System.Windows.Forms.LinkLabel lbusertech;
        private System.Windows.Forms.LinkLabel lbcomplaints;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_des;
    }
}