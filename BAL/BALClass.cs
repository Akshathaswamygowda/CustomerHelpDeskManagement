using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;
using System.Data;

namespace BAL
{
    public class BALClass
    {
        public void register(BOClass oregister)
        {
            DALClass dregister = new DALClass();
            dregister.register(oregister);
        }
        public int Login(BOClass ologin)
        {
            DALClass dlogin = new DALClass();
            int role = dlogin.Login(ologin);
            return role;
        }
        public List<string> Display_Products()
        {
            DALClass dproducts = new DALClass();
            List<string> lsproducts = dproducts.Display_Products();
            return lsproducts;
        }
        public void Customer_Submit(BOClass ocustomer)
        {
            DALClass dcustomer = new DALClass();
            dcustomer.Customer_Submit(ocustomer);
        }
        public DataSet Display_products_manager()
        {
            DALClass dmanager = new DALClass();
            DataSet ds = dmanager.Display_products_manager();
            return ds;
        }
        public void UpdatePassWord(BOClass oreset)
        {
            DALClass dreset = new DALClass();
            dreset.UpdatePassWord(oreset);
        }
        public void InsertProduct(BOClass oinsert)
        {
            DALClass dinsert = new DALClass();
            dinsert.InsertProduct(oinsert);
        }
        public void InsertTechnician(BOClass oregister)
        {
            DALClass dregister = new DALClass();
            dregister.InsertTechnician(oregister);
        }
        public DataSet getComplaints()
        {
            DALClass dcomplaints = new DALClass();
            DataSet ds = dcomplaints.getComplaints();
            return ds;
        }
        /*public string GetNameOfTech(BOClass taskcomplaint)
        {
            DALClass dtask = new DALClass();
            string names=dtask.GetNameOfTech(taskcomplaint);
            return names;

        }
        public void InsertTechComplaints(BOClass inserttech)
        {
            DALClass dinsertech = new DALClass();
            dinsertech.InsertTechComplaints(inserttech);
        }*/
        public string GetUserNameByid(BOClass oname)
        {
            DALClass dname = new DALClass();
            string name = dname.GetUserNameByid(oname);
            return name;
        }
        /*public DataSet GetComplaintDetails(BOClass oname)
        {
            DALClass dname = new DALClass();
            DataSet ds=dname.GetComplaintDetails(oname);
            return ds;
        }
        public string GetUserId(BOClass ouserid)
        {
            DALClass duserid = new DALClass();
            string userid=duserid.GetUserId(ouserid);
            return userid;
        }
        public void DeleteComplaints(BOClass odelete)
        {
            DALClass ddelete = new DALClass();
            ddelete.DeleteComplaints(odelete);
        }*/
        public List<string> GetTechId()
        {
            DALClass dtechid=new DALClass();
            List<string> lstechid=dtechid.GetTechId();
            return lstechid;
        }
        public string GetAutoGenId()
        {
            DALClass did = new DALClass();
            string complaint_id=did.GetAutoGenId();
            return complaint_id;
        }

    }
}
