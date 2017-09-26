using System;
using System.Collections.Generic;
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

        }
    }
}
