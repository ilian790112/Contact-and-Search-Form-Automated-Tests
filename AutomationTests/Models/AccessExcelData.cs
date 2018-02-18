using Configuration;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AccessExcelData
    {
        public static string TestDataFileConnection()
        {
            var path = ConfigurationManager.AppSettings["TestDataSheetPath"];
            var filename = "UserData.xlsx";
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
		                              Data Source = {0}; 
		                              Extended Properties=Excel 12.0;", path + filename );
            return con;
        }

        public static User GetUserTestData(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [UserDataSet$] where key = '{0}'", keyName);
                var value = connection.Query<User>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }

        public static Search GetSearchTestData(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [SearchDataSet$] where key = '{0}'", keyName);
                var value = connection.Query<Search>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }
    }
}
