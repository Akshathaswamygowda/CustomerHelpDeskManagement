namespace CustomerHelpDesk
{
    partial class Login
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
            this.lbmail = new System.Windows.Forms.Label();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.lbpass = new System.Windows.Forms.Label();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lbforgot = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlroles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbmail
            // 
            this.lbmail.AutoSize = true;
            this.lbmail.Location = new System.Drawing.Point(22, 156);
            this.lbmail.Name = "lbmail";
            this.lbmail.Size = new System.Drawing.Size(46, 15);
            this.lbmail.TabIndex = 0;
            this.lbmail.Text = "User Id";
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(113, 223);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(116, 22);
            this.tbpass.TabIndex = 1;
            this.tbpass.UseSystemPasswordChar = true;
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Location = new System.Drawing.Point(22, 223);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(59, 15);
            this.lbpass.TabIndex = 2;
            this.lbpass.Text = "Password";
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(113, 152);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(116, 22);
            this.tbuser.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnlogin.Location = new System.Drawing.Point(113, 319);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(87, 27);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lbforgot
            // 
            this.lbforgot.AutoSize = true;
            this.lbforgot.Location = new System.Drawing.Point(110, 282);
            this.lbforgot.Name = "lbforgot";
            this.lbforgot.Size = new System.Drawing.Size(95, 15);
            this.lbforgot.TabIndex = 6;
            this.lbforgot.TabStop = true;
            this.lbforgot.Text = "ForgotPassword";
            this.lbforgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbforgot_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login Page";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ddlroles
            // 
            this.ddlroles.AutoCompleteCustomSource.AddRange(new string[] {
            "Customer",
            "Manager",
            "Technician"});
            this.ddlroles.FormattingEnabled = true;
            this.ddlroles.Items.AddRange(new object[] {
            "Customer",
            "Manager",
            "Technician"});
            this.ddlroles.Location = new System.Drawing.Point(113, 81);
            this.ddlroles.Name = "ddlroles";
            this.ddlroles.Size = new System.Drawing.Size(140, 23);
            this.ddlroles.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Roles";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(716, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlroles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbforgot);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.lbmail);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbmail;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel lbforgot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlroles;
        private System.Windows.Forms.Label label1;
    }
}