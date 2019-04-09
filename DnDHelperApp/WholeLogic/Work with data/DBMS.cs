using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace DnDHelperApp.WholeLogic.Work_with_data
{
    public class DBMS
    {

    }
    // Database Managment System
    public class DBMS<DataType>: DBMS
    {
        private Dictionary<string, DataType> database = new Dictionary<string, DataType>();

        private XmlSerializer formatter = new XmlSerializer(typeof(Dictionary<string, DataType>));

        private string databasePath = string.Empty;

        public DBMS(string databasePath)
        {
            this.databasePath = $@"{databasePath}\{typeof(DataType).Name}s.xml";
            if (!File.Exists(databasePath))
            {
                SaveData();
            }
            LoadData();
        }

        public void AddNewData(string dataName, DataType dataValue)
        {
            database.Add(dataName, dataValue);
        }

        public void DeleteData(string dataName)
        {
            database.Remove(dataName);
        }

        public Dictionary<string, DataType> GetAllData()
        {
            return database;
        }

        public void SaveData()
        {
            using (var xmlWriter = XmlWriter.Create(databasePath))
            {
                formatter.Serialize(xmlWriter, database);
                xmlWriter.Close();
            }
        }

        public void LoadData()
        {
            using (var xmlReader = XmlReader.Create(databasePath))
            {
                Dictionary<string, DataType> database = (Dictionary<string, DataType>)formatter.Deserialize(xmlReader);
                xmlReader.Close();
            }
        }

        public bool DataExists(string dataName)
        {
            if (!database.Any())
            {
                LoadData();
            }
            return database.ContainsKey(dataName);
        }


        public void ChangeData(string dataName, DataType newData)
        {
            database[dataName] = newData;
        }
    }
}
