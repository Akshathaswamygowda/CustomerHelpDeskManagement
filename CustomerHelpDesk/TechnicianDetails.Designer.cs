namespace CustomerHelpDesk
{
    partial class TechnicianDetails
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
            this.lbname = new System.Windows.Forms.Label();
            this.lbproduct = new System.Windows.Forms.Label();
            this.tbproducts = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(85, 101);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(35, 13);
            this.lbname.TabIndex = 0;
            this.lbname.Text = "Name";
            // 
            // lbproduct
            // 
            this.lbproduct.AutoSize = true;
            this.lbproduct.Location = new System.Drawing.Point(85, 179);
            this.lbproduct.Name = "lbproduct";
            this.lbproduct.Size = new System.Drawing.Size(78, 13);
            this.lbproduct.TabIndex = 1;
            this.lbproduct.Text = "Product_Name";
            // 
            // tbproducts
            // 
            this.tbproducts.Location = new System.Drawing.Point(185, 172);
            this.tbproducts.Name = "tbproducts";
            this.tbproducts.Size = new System.Drawing.Size(100, 20);
            this.tbproducts.TabIndex = 2;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(185, 101);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 20);
            this.tbname.TabIndex = 3;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(158, 228);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 4;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Technician Details";
            // 
            // TechnicianDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 390);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbproducts);
            this.Controls.Add(this.lbproduct);
            this.Controls.Add(this.lbname);
            this.Name = "TechnicianDetails";
            this.Text = "TechnicianDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbproduct;
        private System.Windows.Forms.TextBox tbproducts;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label label3;
    }
}