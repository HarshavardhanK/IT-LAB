using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Lab8Q1
{
    public partial class index : System.Web.UI.Page
    {
        static string ConStr = @"Data Source=localhost;Initial Catalog=test;Integrated Security=True;Pooling=False";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = ConStr;
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT StaffID FROM Staff", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ddl_staffID.Items.Add(reader["StaffID"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        protected void ddl_staffID_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            int stID = Convert.ToInt32(ddl_staffID.SelectedItem.Text);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConStr;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT FirstName, LastName, DNo, Street, City, State, ZipCode FROM Staff where StaffID=@staff_id", con);
                cmd.Parameters.AddWithValue("@staff_id", stID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "staff_details");
                staffGrid.DataSource = ds;
                staffGrid.DataBind();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        protected void btn_Update_OnClick(object sender, EventArgs e)
        {
            string selected_city = list_cities.SelectedItem.Text;
            int stID = Convert.ToInt32(ddl_staffID.SelectedItem.Text);
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConStr;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Staff SET City = @city WHERE StaffID = @staffID", con);
                cmd.Parameters.AddWithValue("@city", selected_city);
                cmd.Parameters.AddWithValue("@staffID", stID);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}