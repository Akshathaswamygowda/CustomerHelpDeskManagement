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

namespace CustomerHelpDesk
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            BOClass ologin = new BOClass();
            BALClass blogin = new BALClass();
            ologin.UserName = tbuser.Text;
            ologin.Password = tbpass.Text;
            string role=ddlroles.Text;
            ologin.Role = role;
            int role_id=Convert.ToInt32(blogin.Login(ologin));
            if(role_id==1)
            {
                this.Close();
                ComplaintPage cp = new ComplaintPage(ologin.UserName);
                cp.MdiParent = HomePage.ActiveForm;
                cp.Show();
            }
            else if(role_id==2)
            {
                this.Close();
                Manager m = new Manager();
                m.MdiParent = HomePage.ActiveForm;
                m.Show();
            }
            else if(role_id==3)
            {
                this.Close();
                //Technician t = new Technician();
                //t.Show();
            }
        }

        private void lbforgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ForgotPassword fpform = new ForgotPassword();
            fpform.Show();
        }

        

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
