using Microsoft.VisualBasic.FileIO;
using System;
using System.Data;

namespace Lab5
{
    public static class CSVHelper

    {
        // from https://stackoverflow.com/questions/25358001/import-csv-to-gridview
        public static DataTable GetDataTableFromCSVFile(string path)
        {
            DataTable csvData = new DataTable();

            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(path))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();

                    foreach (string column in colFields)
                    {
                        DataColumn serialno = new DataColumn(column);
                        serialno.AllowDBNull = true;
                        csvData.Columns.Add(serialno);
                    }

                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        DataRow dr = csvData.NewRow();
                        //Making empty value as empty
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == null)
                                fieldData[i] = string.Empty;

                            dr[i] = fieldData[i];
                        }
                        csvData.Rows.Add(dr);
                    }

                }
            }
            catch (Exception ex)
            {
            }
            return csvData;
        }

    }
}