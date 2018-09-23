using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Lab2
{
    public partial class WebFormDisconnectedMode : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string connectionString = @"
                                Data Source=(localdb)\MSSQLLocalDB;
                                Initial Catalog=AdventureWorks;
                                Integrated Security=True;
                                Connect Timeout=30;
                                Encrypt=False;
                                TrustServerCertificate=True;
                                ApplicationIntent=ReadWrite;
                                MultiSubnetFailover=False;
                                Type System Version=SQL Server 2012;
                                ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM [Production].[Document]", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataset = new DataSet();

                    connection.Open();
                    adapter.Fill(dataset);
                    connection.Close();

                    gridView.DataSource = dataset;
                    gridView.DataBind();
                }


            }
        }
    }
}