using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDHelperApp.WholeLogic.Work_with_data
{
    public class User
    {
        public string UserName { get; set; }

        public string UserType { get; set; }

        public string DataPath { get; set; }

        Dictionary<string, DBMS> Databases { get; set; }

        public User(string userName, string userType)
        {
            UserName = userName;
            UserType = userType;
            DataPath = $@"Database\Base";
            Databases.Add("Skills", new DBMS<Skill>(DataPath));
            Databases.Add("MagicSchools", new DBMS<MagicSchool>(DataPath));
            Databases.Add("Items", new DBMS<Item>(DataPath));
            Databases.Add("Bestiary", new DBMS<Skill>(DataPath));
            Databases.Add("Alchemy", new DBMS<Alchemy>(DataPath));
        }

        //public void AddNewDataBase()
        //{
        //    if (UserType == "master")
        //    {

        //    }
        //    else
        //    {
        //        DataPath = $@"Database\{UserName}";
        //    }
        //}
        
    }
}
