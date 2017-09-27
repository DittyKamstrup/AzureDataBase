using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AzureDataBase
{
    class Program
    {
        private const string ConnectionString = "Data Source = dittessqlserver.database.windows.net;Initial Catalog = SchoolDB;Persist Security Info = False;User ID = ditteak; Password = Ditte1234;MultipleActiveResultSets = False;Encrypt = True;TrustServerCertificate = False;Connection Timeout = 30";
        private const string SelectAllStudents = "select * from Students";
        private const string InsertStudent = "insert into student (Name, Subject) values (@Name, @Subject)";

        static void Main(string[] args)
        {
            string conString = ConnectionString;

            using (SqlConnection databaseConnection = new SqlConnection(conString))
            {
                databaseConnection.Open();
                //IList<Students> allStudents = GetAllStudents(databaseConnection);
                //Console.WriteLine(string.Join("\n", allStudents));
                //InsertStudents(databaseConnection);
                //allStudents = GetAllStudents(databaseConnection);        Skal først lave metoderne
                //Console.WriteLine(string.Join("\n", allStudents)); 
            }

            //private static string GetConnectionStringFromAppConfig()
            //{


            //    ConnectionStringSettingsCollection connectionStringSettingsCollection = ConfigurationManager.ConnectionStrings;
            //    ConnectionStringSettings connStringSettings = connectionStringSettingsCollection["anbo1databaseAzure"];
            //    string connString = connStringSettings.ConnectionString;
            //    return connString;
            //}
















            // Fra eksemplet fra tavlen

            //        using (SqlConnection connection = new SqlConnection(con))
            //        {
            //            connection.Open();
            //            using (SqlCommand selectCommand = new SqlCommand(SelectAllStudents, connection))
            //            {
            //                using (SqlDataReader reader = selectCommand.ExecuteReader())
            //                {

            //                    while (reader.Read())
            //                    {
            //                        int ID = reader.GetInt32(0);
            //string Name = reader.GetString(1);
            //DateTime DateOfBirth = reader.GetDateTime(2);
            //string Subject = reader.GetString(3);

            //Console.WriteLine(ID + " " + Name + " " + DateOfBirth + " " + Subject);

            //                    }

            //                }
            //            }

            //        }
            //        Console.ReadLine();
            // }
        }
    }
}
