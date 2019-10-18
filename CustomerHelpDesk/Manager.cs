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
    public partial class Manager : Form
    {
        BOClass oinsert = new BOClass();
        ComplaintList clform;
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            BALClass bproduct = new BALClass();
            DataSet ds=bproduct.Display_products_manager();
            grvproducts.DataSource = ds.Tables[0];

        }

        
        private void grvproducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                oinsert.Product_Name = grvproducts.Rows[e.RowIndex].Cells["product_name"].Value.ToString();
                oinsert.Product_Brand = grvproducts.Rows[e.RowIndex].Cells["product_brand"].Value.ToString();
                oinsert.Product_Description = grvproducts.Rows[e.RowIndex].Cells["product_description"].Value.ToString();
                if (oinsert.Product_Name != "" && oinsert.Product_Brand != "")
                {
                    BALClass binsert = new BALClass();
                    binsert.InsertProduct(oinsert);
                    DataSet ds = binsert.Display_products_manager();
                    grvproducts.DataSource = ds.Tables[0];
                }
            }
           

        }

        private void lbuser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddUserTech autform = new AddUserTech();
            autform.Show();
            this.Close();
        }

        private void lbcomplaints_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (clform == null)
            {
                clform = new ComplaintList();
                clform.MdiParent = HomePage.ActiveForm;
                clform.FormClosed += clform_FormClosed;
                clform.Show();
            }
            else
                clform.Activate();
        }

        private void clform_FormClosed(object sender, FormClosedEventArgs e)
        {
            clform = null;
        }

        private void grvproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
