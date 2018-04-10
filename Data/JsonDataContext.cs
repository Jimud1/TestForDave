using System;
using System.IO;

namespace DataLayer
{
    public class JsonDataContext
    {
        public string GetJsonFromFile(string filePath)
        {
            try
            {
                return File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occured trying to read all text from {filePath}", ex);
            }
        }
    }
}
