using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            string SelectAllStudents = "select * from Students";

            string con = "Data Source = dittessqlserver.database.windows.net;Initial Catalog = SchoolDB;Persist Security Info = False;User ID = ditteak; Password = Ditte1234;MultipleActiveResultSets = False;Encrypt = True;TrustServerCertificate = False;Connection Timeout = 30";


            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(SelectAllStudents, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            int ID = reader.GetInt32(0);
                            string Name = reader.GetString(1);
                            DateTime DateOfBirth = reader.GetDateTime(2);
                            string Subject = reader.GetString(3);

                            Console.WriteLine(ID + " " + Name + " " + DateOfBirth + " " + Subject);
                            
                        }

                    }
                }

            }
            Console.ReadLine();
        }
    }
}
