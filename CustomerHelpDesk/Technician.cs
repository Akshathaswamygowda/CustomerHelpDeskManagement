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
    public partial class Technician : Form
    {
        BOClass oname = new BOClass();
        BALClass bname = new BALClass();
        public Technician(string name)
        {
            InitializeComponent();
            /*oname.Tech_Name = name;
            DataSet ds = bname.GetComplaintDetails(oname);
            grvcomplaints.DataSource = ds.Tables[0];*/
        }

        public void Technician_Load(object sender, EventArgs e)
        {
            
        }

        private void grvcomplaints_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if(row>=0)
            {
                string status=grvcomplaints.Rows[row].Cells["Column6"].Value.ToString();
                string product_id = grvcomplaints.Rows[row].Cells["Column2"].Value.ToString();
                if(status.ToLower()=="solved")
                {
                    /*oname.Product_Id = product_id;
                    oname.User_id=bname.GetUserId(oname);
                    bname.DeleteComplaints(oname);*/
                }
            }
        }
    }
}
