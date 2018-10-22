using System;
using System.Data;
using System.Data.SqlClient;

namespace Lab5

{
    public static class MortgageLoggerSQL
    {
        public static readonly string TableName = @"mortgages";

        public static readonly string ConnectionString = @"
            Data Source=(localdb)\MSSQLLocalDB;
            Integrated Security=True;
            Connect Timeout=30;
            Encrypt=False;
            TrustServerCertificate=True;
            ApplicationIntent=ReadWrite;
            MultiSubnetFailover=False";

        public static void DeleteAllRows()
        {
            var connection = Connect();

            var cmd = new SqlCommand("TRUNCATE TABLE "+TableName, connection);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public static readonly string TableCreationString =
            @"CREATE TABLE " + TableName + @"(
                principle   FLOAT,
                time		BIGINT,
                rate        FLOAT,
                years       FLOAT)";

        public static SqlConnection Connect()
        {
            SqlConnection c = new SqlConnection(ConnectionString);
            c.Open();

            return c;
        }

        public static void CreateTables()
        {
            SqlConnection connection = Connect();

            connection.Open();

            SqlCommand command = new SqlCommand(TableCreationString, connection);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public static void TryCreateTables()
        {
            SqlConnection connection = Connect();

            try
            {
                CreateTables();
            }
            catch (Exception)
            {
                ;
            }

            connection.Close();
        }

        public static void Log(MortgageLogEntry m)
        {
            SqlConnection connection = Connect();

            SqlCommand cmd = new SqlCommand("INSERT INTO " + TableName + " VALUES(@principle, @time, @rate, @years)",
                connection);

            cmd.Parameters.AddWithValue("principle", m.Principle);
            cmd.Parameters.AddWithValue("time", m.Time);
            cmd.Parameters.AddWithValue("rate", m.Rate);
            cmd.Parameters.AddWithValue("years", m.Years);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public static DataTable GetDataTable()
        {
            var table = new DataTable();

            var connection = Connect();

            using (var dataAdapter = new SqlDataAdapter("SELECT * FROM " + TableName, connection))
            {
                dataAdapter.Fill(table);
            }

            connection.Close();

            return table;
        }
    }
}