using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerHelpDesk
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        Home hform;
        Login lform;
        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hform == null)
            {
                hform = new Home();
                hform.MdiParent = this;
                hform.FormClosed += hform_FormClosed;
                hform.Show();
            }
            else
                hform.Activate();
        }

        private void hform_FormClosed(object sender, FormClosedEventArgs e)
        {
            hform = null;
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void HomePage_Load(object sender, EventArgs e)
        {
            
        }

        

     }
}


        

        
    

