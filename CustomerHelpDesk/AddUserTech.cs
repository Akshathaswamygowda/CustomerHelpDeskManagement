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
    public partial class AddUserTech : Form
    {
        public AddUserTech()
        {
            InitializeComponent();
        }
        private static string CreateRandomPassword(int passwordlength)
        {
            string allowedchars = "abcdefghijklmnopqrstuvwxyz1234567890!@#$%^&*";
            char[] chars = new char[passwordlength];
            Random rd = new Random();
            for (int i = 0; i < passwordlength;i++ )
            {
                chars[i]=allowedchars[rd.Next(0,allowedchars.Length)];
            }
                return new string(chars);
        }

        private void tbpass_Click(object sender, EventArgs e)
        {
            tbpass.Text = CreateRandomPassword(7);
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            BOClass oaddtechuser=new BOClass();
            BALClass baddusertech = new BALClass();
            oaddtechuser.UserName=tbname.Text;
            oaddtechuser.Password = tbpass.Text;
            oaddtechuser.Role = ddlroles.Text;
            if(oaddtechuser.Role=="Customer")
            {
                baddusertech.register(oaddtechuser);
                this.Close();
                Manager mform = new Manager();
                mform.Show();
            }
            else if(oaddtechuser.Role=="Technician")
            {
                baddusertech.InsertTechnician(oaddtechuser);
                this.Close();
                Manager mform = new Manager();
                mform.Show();
            }
        }

        
    }
}
