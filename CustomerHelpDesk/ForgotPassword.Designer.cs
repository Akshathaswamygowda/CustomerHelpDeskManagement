namespace CustomerHelpDesk
{
    partial class ForgotPassword
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
            this.lbuser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbrepass = new System.Windows.Forms.Label();
            this.tbrepass = new System.Windows.Forms.TextBox();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.lbreset = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Location = new System.Drawing.Point(33, 55);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(60, 13);
            this.lbuser.TabIndex = 0;
            this.lbuser.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // lbrepass
            // 
            this.lbrepass.AutoSize = true;
            this.lbrepass.Location = new System.Drawing.Point(33, 144);
            this.lbrepass.Name = "lbrepass";
            this.lbrepass.Size = new System.Drawing.Size(90, 13);
            this.lbrepass.TabIndex = 2;
            this.lbrepass.Text = "Retype Password";
            // 
            // tbrepass
            // 
            this.tbrepass.Location = new System.Drawing.Point(141, 144);
            this.tbrepass.Name = "tbrepass";
            this.tbrepass.Size = new System.Drawing.Size(100, 20);
            this.tbrepass.TabIndex = 3;
            this.tbrepass.UseSystemPasswordChar = true;
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(141, 55);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(100, 20);
            this.tbuser.TabIndex = 4;
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(141, 95);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(100, 20);
            this.tbpass.TabIndex = 5;
            this.tbpass.UseSystemPasswordChar = true;
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(90, 226);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 6;
            this.btnreset.Text = "RESET";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // lbreset
            // 
            this.lbreset.AutoSize = true;
            this.lbreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbreset.Location = new System.Drawing.Point(80, 9);
            this.lbreset.Name = "lbreset";
            this.lbreset.Size = new System.Drawing.Size(121, 16);
            this.lbreset.TabIndex = 7;
            this.lbreset.Text = "Reset Password";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 327);
            this.Controls.Add(this.lbreset);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.tbrepass);
            this.Controls.Add(this.lbrepass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbuser);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbrepass;
        private System.Windows.Forms.TextBox tbrepass;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Label lbreset;
    }
}