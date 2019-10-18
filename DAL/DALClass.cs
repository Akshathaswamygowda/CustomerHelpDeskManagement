using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DALClass
    {
        string scn = ConnectionStringUtilities.getConnectionString();
        public void register(BOClass oregister)
        {
            using (SqlConnection cn = new SqlConnection(scn))
            {
                using (SqlCommand cmd = new SqlCommand("insertcustomer", cn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cn.Open();
                        cmd.Parameters.AddWithValue("@name", oregister.UserName);
                        cmd.Parameters.AddWithValue("@pass", oregister.Password);
                        cmd.Parameters.AddWithValue("@role_id", DbType.Int32);
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if (cn.State == ConnectionState.Open)
                        {
                            cn.Close();
                        }
                    }
                }
            }
        }
        public int Login(BOClass ologin)
        {
            using (SqlConnection cn = new SqlConnection(scn))
            {
                using (SqlCommand cmd = new SqlCommand("login", cn))
                {
                    try
                    {
                        cn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@user_id", ologin.UserName);
                        cmd.Parameters.AddWithValue("@pass", ologin.Password);
                        cmd.Parameters.AddWithValue("@role_name", ologin.Role);
                        object role = cmd.ExecuteScalar();
                        int role_id = Convert.ToInt32(role);
                        return role_id;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if (cn.State == ConnectionState.Open)
                        {
                            cn.Close();
                        }
                    }


                }
            }
        }
        public void Customer_Submit(BOClass ocustomer)
        {
            using (SqlConnection cn = new SqlConnection(scn))
            {
                using (SqlCommand cmd = new SqlCommand("Complaint_deatils", cn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@customerid", ocustomer.User_id);
                        cmd.Parameters.AddWithValue("@customer_name", ocustomer.Customer_Name);
                        cmd.Parameters.AddWithValue("@customer_ph", ocustomer.Customer_ph);
                        cmd.Parameters.AddWithValue("@product_id", ocustomer.Product_Details);
                        cmd.Parameters.AddWithValue("@complain", ocustomer.Complaint);
                        cmd.Parameters.AddWithValue("@complaindate", ocustomer.Complaint_date);
                        cmd.Parameters.AddWithValue("@id", DbType.Int32);
                        cmd.Parameters.AddWithValue("@pid", DbType.Int32);
                        cmd.Parameters.AddWithValue("@status", DbType.String);
                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }
        public List<string> Display_Products()
        {
            List<string> lsproducts = new List<string>();
            using (SqlConnection cn = new SqlConnection(scn))
            {
                using (SqlCommand cmd = new SqlCommand("product_details", cn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            lsproducts.Add(dr["product_id"] + "-" + dr["product_name"] + "-" + dr["product_brand"]);

                        }
                        dr.Close();
                    }
                    catch (Exception)
                    {
                        throw;

                    }
                    finally
                    {
                        if (cn.State == ConnectionState.Open)
                        {
                            cn.Close();
                        }
                    }
                    return lsproducts;
                }
            }
        }
        public DataSet Display_products_manager()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection cn = new SqlConnection(scn))
            {
                using (SqlCommand cmd = new SqlCommand("product_details", cn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                        return ds;

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if (cn.State == ConnectionState.Open)
                        {
                            cn.Close();

                        }
                    }
                }
            }
        }
        public void UpdatePassWord(BOClass oreset)
        {
            /*using(SqlConnection cn=new SqlConnection(scn))
            {
                using(SqlCommand cmd=new SqlCommand("resetpass",cn))
                {
                    try
                    {
                        cn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@email", oreset.Email);
                        cmd.Parameters.AddWithValue("@pass", oreset.Password);
                        cmd.Parameters.AddWithValue("@repass", oreset.RePassword);
                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if(cn.State==ConnectionState.Open)
                        {
                            cn.Close();
                        }
                    }
                }
            }*/
        }
        public void InsertProduct(BOClass oinsert)
        {
            using(SqlConnection cn=new SqlConnection(scn))
            {
                using (SqlCommand cmd = new SqlCommand("insertproduct", cn))
                {
                    try
                    {
                        cn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@product_name", oinsert.Product_Name);
                        cmd.Parameters.AddWithValue("@product_brand", oinsert.Product_Brand);
                        cmd.Parameters.AddWithValue("@product_des", oinsert.Product_Description);
                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if(cn.State==ConnectionState.Open)
                        {
                            cn.Close();
                        }
                    }
                }
            }
        }
        public void InsertTechnician(BOClass oregister)
        {
            using(SqlConnection cn=new SqlConnection(scn))
            {
                using (SqlCommand cmd = new SqlCommand("inserttechnician", cn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cn.Open();
                        cmd.Parameters.AddWithValue("@name", oregister.UserName);
                        cmd.Parameters.AddWithValue("@pass", oregister.Password);
                        cmd.Parameters.AddWithValue("@role_id", DbType.Int32);
                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if(cn.State==ConnectionState.Open)
                        {
                            cn.Close();
                        }
                    }
                }
            }
        }
        public DataSet getComplaints()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            using (SqlConnection cn = new SqlConnection(scn))
            {
                using (SqlCommand cmd = new SqlCommand("complaint_details_display", cn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                        return ds;

                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if (cn.State == ConnectionState.Open)
                        {
                            cn.Close();

                        }
                    }
                }
            }
        }
       /* public string GetNameOfTech(BOClass taskcomplaint)
        {
            string name=null;
            using(SqlConnection cn=new SqlConnection(scn))
            {
                using (SqlCommand cmd = new SqlCommand("GetTechName",cn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@product_id", taskcomplaint.Product_Id);
                        cn.Open();
                        SqlDataReader dr=cmd.ExecuteReader();
                        while(dr.Read())
                        {
                            name=dr["Tech_Name"].ToString() + "-" + dr["product_id"].ToString();
                            
                        }

                    }
                    catch(Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if(cn.State==ConnectionState.Open)
                        {
                            cn.Close();
                        }
                    }
                }
            }
            return name;
        }
        public void InsertTechComplaints(BOClass inserttech)
        {
            using(SqlConnection cn=new SqlConnection(scn))
            {
                using (SqlCommand cmd = new SqlCommand("insertcomplaints", cn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@tech_name", inserttech.Tech_Name);
                        cmd.Parameters.AddWithValue("@product_id", inserttech.Product_Id);
                        cmd.Parameters.AddWithValue("@complain", inserttech.Complaint);
                        cn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch(Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if(cn.State==ConnectionState.Open)
                        {
                            cn.Close();
                        }
                    }
                }
            }
        }*/
        public string GetUserNameByid(BOClass omail)
        {
            //string name=null;
            using(SqlConnection cn=new SqlConnection(scn))
            {
                using (SqlCommand cmd = new SqlCommand("GetUserName", cn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@user_id", omail.UserName);
                        cn.Open();
                        object name = cmd.ExecuteScalar();
                        string customer_name= name.ToString();
                        return customer_name;
                    }
                    catch(Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if(cn.State==ConnectionState.Open)
                        {
                            cn.Close();
                        }
                    }
                }
            }
            return null;
        }
       /* public DataSet GetComplaintDetails(BOClass oname)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            using(SqlConnection cn=new SqlConnection(scn))
            {
                using (SqlCommand cmd = new SqlCommand("complaintlist", cn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@tech_name", oname.Tech_Name);
                        da.SelectCommand = cmd;
                        da.Fill(ds);
                        return ds;
                        
                    }
                    catch(Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if(cn.State==ConnectionState.Open)
                        {
                            cn.Close();
                        }
                    }
                }
            }
        }
        public string GetUserId(BOClass ouserid)
        {
            using(SqlConnection cn=new SqlConnection(scn))
            {
                using (SqlCommand cmd = new SqlCommand("getcustomerid", cn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@product_id", ouserid.Product_Id);
                        cn.Open();
                        object id=cmd.ExecuteScalar();
                        string userid = id.ToString();
                        return userid;
                    }
                    catch(Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if(cn.State==ConnectionState.Open)
                        {
                            cn.Close();
                        }
                    }
                }
            }
            return null;
        }
        public void DeleteComplaints(BOClass odelete)
        {
            using(SqlConnection cn=new SqlConnection(scn))
            {
                using(SqlCommand cmd=new SqlCommand("deletecomplaint",cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userid", odelete.User_id);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
        }*/
        public List<string> GetTechId()
        {
            List<string> lstechid = new List<string>();
            using(SqlConnection cn=new SqlConnection(scn))
            {
                using (SqlCommand cmd = new SqlCommand("technician_id", cn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while(dr.Read())
                        {
                            lstechid.Add(dr["techid"].ToString());
                        }
                        dr.Close();
                    }
                    catch(Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if(cn.State==ConnectionState.Open)
                        {
                            cn.Close();
                        }
                    }
                }
            }
            return lstechid;
        }
        public string GetAutoGenId()
        {
            using(SqlConnection cn=new SqlConnection(scn))
            {
                using (SqlCommand cmd = new SqlCommand("autogencomplid", cn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cn.Open();
                        string complaintid=Convert.ToString(cmd.ExecuteScalar());
                        return complaintid;
                    }
                    catch(Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if(cn.State==ConnectionState.Open)
                        {
                            cn.Close();
                        }
                    }
                }
            }
            return null;
        }
    }
}
