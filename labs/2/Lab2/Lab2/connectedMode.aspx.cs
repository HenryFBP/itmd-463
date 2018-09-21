using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Lab2
{
    public partial class WebFormConnectedMode : System.Web.UI.Page
    {
        public class QueryResult
        {
            public string Title { get; set; }

            public string Filename { get; set; }

        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                Initial Catalog=AdventureWorks;
                                Integrated Security=True;
                                Connect Timeout=30;
                                Encrypt=False;
                                TrustServerCertificate=True;
                                ApplicationIntent=ReadWrite;
                                MultiSubnetFailover=False";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    SqlCommand command = new SqlCommand("SELECT * FROM [Production].[Document]");

                    connection.Open();

                    command.Connection = connection;

                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        List<QueryResult> queryResults = new List<QueryResult>();

                        while (dataReader.Read())
                        {
                            queryResults.Add(new QueryResult()
                            {
                                Filename = dataReader["Filename"] as string,
                                Title = dataReader["Title"] as string,
                            });
                        }

                        gridView.DataSource = queryResults;
                        gridView.DataBind();

                    }
                }


            }
        }
    }
}