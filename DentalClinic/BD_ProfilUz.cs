using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinic
{
    internal class BD_ProfilUz
    {
        public class SQLiteDatabaseConnection
        {
            private string connectionString = @"Data Source=C:\Users\halin\Desktop\DentalClinic\DataBase\DentalClinic.db;Version=3;";

            public SQLiteConnection GetConnection()
            {
                return new SQLiteConnection(connectionString);
            }
        }
    }
}
