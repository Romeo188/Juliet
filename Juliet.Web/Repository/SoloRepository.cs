using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using Juliet.Web.Models;
using MySql.Data.MySqlClient;


namespace Juliet.Web.Repository
{
    public class SoloRepository
    {
        private static MySqlConnection GetConnection()
        {
            var connectionString = ConfigurationManager
        }
    }
}