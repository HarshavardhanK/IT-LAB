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

namespace IT_LAB_WEEK_Q2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        DataSet dataset = new DataSet();
        string connectionString = @"Data Source=(localdb)\MSSQLlocalDB;Initial Catalog=it_lab_hvk;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = connectionString;

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT DISTINCT Genre from Legenda", connection);
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    genreDDL.Items.Add(reader["Genre"].ToString());
                }

            } catch(Exception ex)
            {
                actorDetails.Text = ex.Message;
            }
        }

        protected void choose_Actor(object sender, EventArgs args)
        {

            //actorLB.Items.Clear();

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "SELECT Age, Name from Legenda WHERE Name=@n";
                    command.Parameters.AddWithValue("@n", actorLB.SelectedValue);
                    command.Connection = connection;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    connection.Open();
                    adapter.Fill(dataset, "Legenda");

                    foreach(DataRow row in dataset.Tables["Legenda"].Rows)
                    {
                        actorDetails.Text = "Name: " + row["Name"] + " Age: " + row["Age"];
                    }
                }
            }
        }

        protected void choose_Genre(object sender, EventArgs args)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand command = new SqlCommand())
                {
                    command.CommandText = "SELECT Name from Legenda WHERE Genre=@g";
                    command.Parameters.AddWithValue("@g", genreDDL.SelectedValue);
                    command.Connection = connection;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    connection.Open();

                    adapter.Fill(dataset, "Legenda");

                    foreach(DataRow row in dataset.Tables["Legenda"].Rows)
                    {
                        actorLB.Items.Add(row["Name"].ToString());
                    }
                }
            }
        }
    }
}