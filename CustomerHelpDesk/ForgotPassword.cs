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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            /*BOClass oreset = new BOClass();
            BALClass breset = new BALClass();
            oreset.Email = tbuser.Text;
            oreset.Password = tbpass.Text;
            oreset.RePassword = tbrepass.Text;
            breset.UpdatePassWord(oreset);
            if (oreset.Password != oreset.RePassword)
            {
                MessageBox.Show("Password Do not Match");
            }
            else
            {
                MessageBox.Show("Password Reset Successfully");
                ForgotPassword fpform = new ForgotPassword();
                fpform.Hide();
                Login loginform = new Login();
                loginform.Show();
            }*/
        }
    }
}
