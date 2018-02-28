using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using Juliet.Web.Models;
using MySql.Data.MySqlClient;
using System.Configuration;


namespace Juliet.Web.Repository
{
    public class SoloRepository
    {
        private static MySqlConnection GetConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["pubgTrackerDB"].ToString();
            var conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }
        public static IEnumerable<PubgSoloTrackerModel> GetSoloHistory()
        {
            using (var dbConnection = GetConnection())
            {
                var results = dbConnection.Query<PubgSoloTrackerModel>(@"SELECT * FROM solo_history;");
                return results;
            }
        }
    }
}