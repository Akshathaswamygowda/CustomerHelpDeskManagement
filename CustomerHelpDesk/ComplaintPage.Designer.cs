namespace CustomerHelpDesk
{
    partial class ComplaintPage
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
            this.lbname = new System.Windows.Forms.Label();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.ddlproducts = new System.Windows.Forms.ComboBox();
            this.tbcomplaint = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.lbproducts = new System.Windows.Forms.Label();
            this.lbcomplaint = new System.Windows.Forms.Label();
            this.lbph = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(149, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Report Page";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.Color.Black;
            this.lbname.Location = new System.Drawing.Point(25, 123);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(95, 15);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "Customer Name";
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(161, 167);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(100, 20);
            this.tbphone.TabIndex = 2;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(161, 118);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 20);
            this.tbname.TabIndex = 3;
            // 
            // ddlproducts
            // 
            this.ddlproducts.FormattingEnabled = true;
            this.ddlproducts.Location = new System.Drawing.Point(161, 213);
            this.ddlproducts.Name = "ddlproducts";
            this.ddlproducts.Size = new System.Drawing.Size(249, 21);
            this.ddlproducts.TabIndex = 4;
            // 
            // tbcomplaint
            // 
            this.tbcomplaint.Location = new System.Drawing.Point(161, 266);
            this.tbcomplaint.Multiline = true;
            this.tbcomplaint.Name = "tbcomplaint";
            this.tbcomplaint.Size = new System.Drawing.Size(249, 20);
            this.tbcomplaint.TabIndex = 5;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.Color.Black;
            this.btnsubmit.Location = new System.Drawing.Point(161, 379);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(111, 35);
            this.btnsubmit.TabIndex = 6;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lbproducts
            // 
            this.lbproducts.AutoSize = true;
            this.lbproducts.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbproducts.ForeColor = System.Drawing.Color.Black;
            this.lbproducts.Location = new System.Drawing.Point(25, 219);
            this.lbproducts.Name = "lbproducts";
            this.lbproducts.Size = new System.Drawing.Size(96, 15);
            this.lbproducts.TabIndex = 7;
            this.lbproducts.Text = "Product_Details";
            // 
            // lbcomplaint
            // 
            this.lbcomplaint.AutoSize = true;
            this.lbcomplaint.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcomplaint.ForeColor = System.Drawing.Color.Black;
            this.lbcomplaint.Location = new System.Drawing.Point(25, 271);
            this.lbcomplaint.Name = "lbcomplaint";
            this.lbcomplaint.Size = new System.Drawing.Size(130, 15);
            this.lbcomplaint.TabIndex = 8;
            this.lbcomplaint.Text = "Complaint Description";
            // 
            // lbph
            // 
            this.lbph.AutoSize = true;
            this.lbph.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbph.ForeColor = System.Drawing.Color.Black;
            this.lbph.Location = new System.Drawing.Point(25, 167);
            this.lbph.Name = "lbph";
            this.lbph.Size = new System.Drawing.Size(92, 15);
            this.lbph.TabIndex = 9;
            this.lbph.Text = "Phone_Number";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(161, 312);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTime.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(276, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Complaint Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(161, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 15;
            // 
            // ComplaintPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(514, 460);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.lbph);
            this.Controls.Add(this.lbcomplaint);
            this.Controls.Add(this.lbproducts);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.tbcomplaint);
            this.Controls.Add(this.ddlproducts);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbphone);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.label1);
            this.Name = "ComplaintPage";
            this.Text = "Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.ComboBox ddlproducts;
        private System.Windows.Forms.TextBox tbcomplaint;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label lbproducts;
        private System.Windows.Forms.Label lbcomplaint;
        private System.Windows.Forms.Label lbph;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}