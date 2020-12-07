using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Lab8Q2
{
    public partial class index : System.Web.UI.Page
    {
        private static string conStr = @"Data Source=localhost; Initial Catalog=test; Integrated Security=True; Pooling=False";
        SqlConnection con = new SqlConnection(conStr);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT DISTINCT category FROM Legends", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ddl_genre.Items.Add(reader["category"].ToString());
                    }
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

        protected void ddl_genre_change(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                SqlCommand cmd = new SqlCommand("SELECT name FROM Legends WHERE category=@Category", con);
                cmd.Parameters.AddWithValue("@Category", ddl_genre.SelectedValue);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list_actors.Items.Add(reader["name"].ToString());
                }
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

        protected void list_actors_change(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT name, age FROM LEGENDS WHERE name = @name", con);
                cmd.Parameters.AddWithValue("@name", list_actors.SelectedValue);
                SqlDataReader reader = cmd.ExecuteReader();
                lbl.Text = "Name: " + reader["name"].ToString() + "<br/>Age: " + reader["age"].ToString();
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
}