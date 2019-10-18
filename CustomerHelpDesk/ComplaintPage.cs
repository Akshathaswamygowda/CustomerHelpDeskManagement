using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BO;
using System.Text.RegularExpressions;

namespace CustomerHelpDesk
{
     
    public partial class ComplaintPage : Form
    {
        string id;
        BOClass oname = new BOClass();
        BALClass bname = new BALClass();
        public ComplaintPage(string userid)
        {
            id = userid;
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            BALClass bproducts = new BALClass();
            List<string> lsproducts=bproducts.Display_Products();
            ddlproducts.DataSource = lsproducts;
            oname.UserName = id;
            string cutomer_name=bname.GetUserNameByid(oname);
            tbname.Text = cutomer_name;
            //label5.Text = "Complaint"+visitorcount.ToString();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            BOClass ocomplaints = new BOClass();
            BALClass bcomplaints = new BALClass();
            ocomplaints.Customer_Name = tbname.Text;
            ocomplaints.Customer_ph = tbphone.Text;
            string products=ddlproducts.Text;
            string[] productid = products.Split('-');
            ocomplaints.Product_Details = productid[0];
            ocomplaints.Complaint = tbcomplaint.Text;
            string thedate=dateTime.Value.ToShortDateString();
            ocomplaints.Complaint_date=Convert.ToDateTime(thedate);
            ocomplaints.User_id = id;
            bool phone = Regexp("^[0-9]{10}$", tbphone, label6, "Phone Number is ");
            if (phone == true)
            {
                bcomplaints.Customer_Submit(ocomplaints);
                MessageBox.Show("Complaint Successfully Submitted");
                ComplaintPage customerform = new ComplaintPage(ocomplaints.User_id);
                customerform.Close();
            }
        }
        public bool Regexp(string re, TextBox tb, Label lbl, string s)
        {
            Regex regexp = new Regex(re);
            if (regexp.IsMatch(tb.Text))
            {

                lbl.ForeColor = Color.Green;
                lbl.Text = s + "valid";
                return true;
            }
            else
            {

                lbl.ForeColor = Color.Red;
                lbl.Text = s + "Not Valid";
                return false;
            }
        }

        
    }
}
