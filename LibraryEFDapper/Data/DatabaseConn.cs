using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
//Додав додатковий клас для з'єднання з базою даних
namespace LibraryEFDapper.Data
{
    internal class DatabaseConn
    {
        private static string connectionString =
    "Data Source=NIGHTFURY\\LEVMSSQLSERVER;Initial Catalog=LibraryDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";

        public static IDbConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
