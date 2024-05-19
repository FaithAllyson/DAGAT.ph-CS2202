using System.Data;
using System.IO;

namespace dagatph
{
    internal class CSVManager
    {
        private string filePath;

        public CSVManager(string filePath)
        {
            this.filePath = filePath;
            CreateFileIfNotExists();
        }

        private void CreateFileIfNotExists()
        {
            if (!File.Exists(filePath))
            {
                using (var sw = File.CreateText(filePath))
                {
                    sw.WriteLine("DateTime,pH,Location, Description"); 
                }
            }
        }

        public void AppendDataToCsv(DataModel data)
        {
            using (var entry = File.AppendText(filePath))
            {
                entry.WriteLine(data.ToCsvString());
            }
        }

        public DataTable ReadDataFromCsv()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("DateTime");
            dataTable.Columns.Add("pH");
            dataTable.Columns.Add("Location");
            dataTable.Columns.Add("Description");

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    dataTable.Rows.Add(values[0], values[1], values[2], values[3]);
                }
            }

            return dataTable;
        }
    }
}