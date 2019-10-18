namespace CustomerHelpDesk
{
    partial class Home
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
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbrepass = new System.Windows.Forms.TextBox();
            this.btnregister = new System.Windows.Forms.Button();
            this.lbrepass = new System.Windows.Forms.Label();
            this.lbpass = new System.Windows.Forms.Label();
            this.lblogin = new System.Windows.Forms.LinkLabel();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuser.ForeColor = System.Drawing.Color.Black;
            this.lbuser.Location = new System.Drawing.Point(22, 88);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(67, 15);
            this.lbuser.TabIndex = 2;
            this.lbuser.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(126, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registeration Page";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(127, 136);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(100, 20);
            this.tbpass.TabIndex = 5;
            this.tbpass.UseSystemPasswordChar = true;
            // 
            // tbrepass
            // 
            this.tbrepass.Location = new System.Drawing.Point(127, 179);
            this.tbrepass.Name = "tbrepass";
            this.tbrepass.Size = new System.Drawing.Size(100, 20);
            this.tbrepass.TabIndex = 6;
            this.tbrepass.UseSystemPasswordChar = true;
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnregister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnregister.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.Color.Black;
            this.btnregister.Location = new System.Drawing.Point(127, 235);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(100, 38);
            this.btnregister.TabIndex = 8;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // lbrepass
            // 
            this.lbrepass.AutoSize = true;
            this.lbrepass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrepass.ForeColor = System.Drawing.Color.Black;
            this.lbrepass.Location = new System.Drawing.Point(22, 184);
            this.lbrepass.Name = "lbrepass";
            this.lbrepass.Size = new System.Drawing.Size(99, 15);
            this.lbrepass.TabIndex = 9;
            this.lbrepass.Text = "ReTypePassword";
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass.ForeColor = System.Drawing.Color.Black;
            this.lbpass.Location = new System.Drawing.Point(22, 136);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(59, 15);
            this.lbpass.TabIndex = 11;
            this.lbpass.Text = "Password";
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogin.Location = new System.Drawing.Point(116, 297);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(113, 15);
            this.lblogin.TabIndex = 12;
            this.lblogin.TabStop = true;
            this.lblogin.Text = "Already Registered";
            this.lblogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblogin_LinkClicked);
            // 
            // tbname
            // 
            this.tbname.HideSelection = false;
            this.tbname.Location = new System.Drawing.Point(127, 88);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 20);
            this.tbname.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 20;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(515, 482);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lblogin);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.lbrepass);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.tbrepass);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbuser);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbrepass;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Label lbrepass;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.LinkLabel lblogin;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

