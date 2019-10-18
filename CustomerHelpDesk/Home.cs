using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using BAL;
using System.Text.RegularExpressions;

namespace CustomerHelpDesk
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        Login lform;
        private void btnregister_Click(object sender, EventArgs e)
        {
            BOClass oregister = new BOClass();
            BALClass boregister = new BALClass();
            bool username=Regexp("^[A-Za-z]+$", tbname, label1, "User Name is ");
            bool pass=Regexp("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$", tbpass, label3, "Password is ");
            bool repass=Regexp("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$", tbrepass, label4, "Password is ");
            oregister.UserName = tbname.Text;
            oregister.Password = tbpass.Text;
            if (username == true && pass == true)
            {
                if (oregister.Password != tbrepass.Text)
                {
                    MessageBox.Show("PassWord DO NOT Match");
                    oregister.Password = " ";
                    tbrepass.Text = "";
                }
                else
                {
                    boregister.register(oregister);
                    MessageBox.Show("Successfully regestired please Login");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Entered values are not valid please try again");
                tbname.Text = "";
                tbpass.Text = "";
                tbrepass.Text = "";
                this.Show();
            }
        }
        public bool Regexp(string re,TextBox tb,Label lbl,string s)
        {
            Regex regexp = new Regex(re);
            if(regexp.IsMatch(tb.Text))
            {
               
                lbl.ForeColor = Color.Green;
                lbl.Text = s+"valid";
                return true;
            }
            else
            {
                
                lbl.ForeColor = Color.Red;
                lbl.Text = s + "Not Valid";
                return false;
            }
        }
        private void lblogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lform == null)
            {
                lform = new Login();
                lform.MdiParent = this;
                lform.FormClosed += lform_FormClosed;
                lform.Show();
            }
            else
                lform.Activate();
        }

        private void lform_FormClosed(object sender, FormClosedEventArgs e)
        {
            lform = null;
        }

        
    }
}
