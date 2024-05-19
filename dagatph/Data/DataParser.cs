using System;

namespace dagatph
{
    internal class DataParser   
    {
        public DataModel Parse(string rawData)
        {
            var dataModel = new DataModel();

            string[] parts = rawData.Split(new string[] { "," }, StringSplitOptions.None);

            // Extract pH
            string phPart = parts[0].Split(':')[1];
            dataModel.PH = float.Parse(phPart);

            // Extract GPS
            //dataModel.Location = parts[1].Split(':')[1];
            dataModel.Location = "";

            // Set Date
            dataModel.DateTime = DateTime.Now;

            // Set Description
            if (dataModel.PH <= 6.5)
            {
                dataModel.Description = "Acidic";
            }
            else dataModel.Description = "Okay";
            
            return dataModel;
        }

    }
}