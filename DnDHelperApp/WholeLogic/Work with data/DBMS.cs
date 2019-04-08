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
    // Database Managment System
    public class DBMS<T>
    {
        Dictionary<string, T> database = new Dictionary<string, T>();
        XmlSerializer formatter = new XmlSerializer(typeof(Dictionary<string, T>));
        private string databasePath = $@"Database\{typeof(T).Name}.xml";

        public DBMS()
        {
            if (!File.Exists(databasePath))
            {
                SaveData();
            }
            LoadData();
        }

        public void AddNewData(string dataName, T dataValue)
        {
            database.Add(dataName, dataValue);
        }

        public void DeleteData(string dataName)
        {
            database.Remove(dataName);
        }

        public Dictionary<string,T> GetData()
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
                Dictionary<string, T> database = (Dictionary<string, T>)formatter.Deserialize(xmlReader);
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


        public void ChangeUserData(string dataName,T newData)
        {
            database[dataName] = newData;
        }
    }
}
