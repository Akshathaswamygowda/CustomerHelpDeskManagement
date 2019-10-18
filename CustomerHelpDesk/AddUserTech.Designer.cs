namespace CustomerHelpDesk
{
    partial class AddUserTech
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
            this.tbname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.ddlroles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(124, 114);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 20);
            this.tbname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(124, 161);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(100, 20);
            this.tbpass.TabIndex = 3;
            this.tbpass.UseSystemPasswordChar = true;
            this.tbpass.Click += new System.EventHandler(this.tbpass_Click);
            // 
            // ddlroles
            // 
            this.ddlroles.FormattingEnabled = true;
            this.ddlroles.Items.AddRange(new object[] {
            "Customer",
            "Technician"});
            this.ddlroles.Location = new System.Drawing.Point(124, 64);
            this.ddlroles.Name = "ddlroles";
            this.ddlroles.Size = new System.Drawing.Size(121, 21);
            this.ddlroles.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Role";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(124, 213);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 6;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // AddUserTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlroles);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label1);
            this.Name = "AddUserTech";
            this.Text = "AddUserTech";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.ComboBox ddlroles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsubmit;
    }
}