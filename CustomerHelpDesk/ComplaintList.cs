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
    public partial class ComplaintList : Form
    {
        BOClass taskcomplaint = new BOClass();
        public ComplaintList()
        {
            InitializeComponent();
        }

        

        private void ComplaintList_Load(object sender, EventArgs e)
        {
            //ComboBox cb = this.Controls.Find("grvcomplaints", true).FirstOrDefault() as ComboBox;
            //cb.Text = "New Task";
            
            BALClass bregister = new BALClass();
            DataSet ds=bregister.getComplaints();
            grvcomplaints.DataSource = ds.Tables[0];
            
        }

        private void grvcomplaints_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row=e.RowIndex;
            if(row>=0)
            {
                taskcomplaint.Task = grvcomplaints.Rows[row].Cells["ddltask"].Value.ToString();
                taskcomplaint.Product_Id = grvcomplaints.Rows[row].Cells["Column3"].Value.ToString();
                taskcomplaint.Complaint = grvcomplaints.Rows[row].Cells["Column4"].Value.ToString();
                if(taskcomplaint.Task.ToLower()=="assign")
                {
                    BALClass btechid=new BALClass();
                    List<string> lstechid=btechid.GetTechId();
                    grvcomplaints.Columns["Column6"].Visible = true;
                    Column6.DataSource = lstechid;
                    /*BALClass btask = new BALClass();
                    string names=btask.GetNameOfTech(taskcomplaint);
                    string[] product_name = names.Split('-');
                    taskcomplaint.Tech_Name=product_name[0];
                    taskcomplaint.Product_Id=product_name[1];
                    btask.InsertTechComplaints(taskcomplaint);*/
                }
            }
        }

        

    }
}
