using System.IO;

namespace Lab5
{
    public static class MortgageLoggerCSV
    {

        public static string LOGPATH = "~/App_Data/mortgage.log.csv";
        // Log a mortgage.
        public static void LogMortgage(MortgageLogEntry m, string filepath)
        {
            using (var f = new StreamWriter(path: filepath, append: true))
            {
                f.Write(m.Time + "," + m.Principle + "," + m.Rate + "," + m.Years + "\r\n");
            }
        }

        // Generate a blank MortgageLog file.
        // It just makes some CSV headers.
        public static void GenerateMortgageLogfile(string filepath)
        {
            string[] header = { "time", "principle", "rate", "years" };

            // Delete file if exists.
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
            }

            using (var f = new StreamWriter(filepath))
            {
                for (int i = 0; i < header.Length; i++)
                {
                    f.Write(header[i]);

                    if (i < (header.Length - 1))
                    {
                        f.Write(",");
                    }
                }
                f.Write("\r\n");
            }
        }

    }
}