using Lab7.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Lab7

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

            var cmd = new SqlCommand($"TRUNCATE TABLE {TableName}", connection);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public static readonly string TableCreationString =
            $@"CREATE TABLE {TableName}(
                principle       FLOAT,
                time		    BIGINT,
                rate            FLOAT,
                years           FLOAT,
                monthlyPayment  FLOAT)";

        public static SqlConnection Connect()
        {
            SqlConnection c = new SqlConnection(ConnectionString);

            c.Open();

            return c;
        }

        public static void CreateTables()
        {
            SqlConnection connection = Connect();

            SqlCommand command = new SqlCommand(TableCreationString, connection);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public static void TryCreateTables()
        {
            try
            {
                CreateTables();
            }
            catch (Exception)
            {
                ;
            }
        }

        public static void Log(MortgageInfo mortgageInfo, MortgageResult mortgageResult)
        {
            SqlConnection connection = Connect();

            SqlCommand cmd = new SqlCommand($"INSERT INTO {TableName} VALUES(@principle, @time, @rate, @years, @monthlyPayment)",
                connection);

            cmd.Parameters.AddWithValue("principle", mortgageInfo.Principle);
            cmd.Parameters.AddWithValue("time", DateTime.Now.Ticks);
            cmd.Parameters.AddWithValue("rate", mortgageInfo.InterestRate);
            cmd.Parameters.AddWithValue("years", mortgageInfo.DurationYears);

            cmd.Parameters.AddWithValue("monthlyPayment", mortgageResult.MonthlyPayment);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public static DataTable GetDataTable()
        {
            var table = new DataTable();

            var connection = Connect();

            using (var dataAdapter = new SqlDataAdapter($"SELECT * FROM {TableName}", connection))
            {
                dataAdapter.Fill(table);
            }

            connection.Close();

            return table;
        }
    }
}