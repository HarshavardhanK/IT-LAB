using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Database imports

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace IT_LAB_WEEK6_Q1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        DataSet dataset = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=it_lab_hvk;Integrated Security=True";

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT DISTINCT StaffID from Emplopyee", connection);

                    SqlDataReader dataReader = command.ExecuteReader();


                    while(dataReader.Read())
                    {
                        employeeDDL.Items.Add(dataReader["StaffID"].ToString());
                        System.Diagnostics.Debug.WriteLine(dataReader["StaffID"].ToString());
                    }

                } catch(Exception ex)
                {
                    detailsLabel.Text = ex.Message;

                } finally
                {
                    connection.Close();
                }

                cityDDL.Items.Add("Melbourne");
                cityDDL.Items.Add("Bangalore");
                cityDDL.Items.Add("Delhi");
            }

        }

        protected void update_City(object sender, EventArgs args)
        {

            using(SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=it_lab_hvk;Integrated Security=True"))
            {

                using(SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "UPDATE Emplopyee SET City=@c WHERE StaffID=@s";
                    command.Parameters.AddWithValue("@c", cityDDL.SelectedValue);
                    command.Parameters.AddWithValue("@s", employeeDDL.SelectedValue);

                    command.Connection = connection;
                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }

        protected void employee_Selected(object sender, EventArgs args)
        {
            detailsLabel.Text = String.Empty;

            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "SELECT * from Emplopyee WHERE StaffID = @s";
                    command.Parameters.AddWithValue("@s", employeeDDL.SelectedValue);
                    command.Connection = connection;

                    connection.ConnectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=it_lab_hvk;Integrated Security=True";
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataset, "Emplopyee");

                    foreach(DataRow row in dataset.Tables["Emplopyee"].Rows)
                    {
                        detailsLabel.Text = row["StaffID"] + " " + row["FirstName"] + " " + row["LastName"] + " " + row["City"];
                    }
                }
            }
        }
    }
}