using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JobOffers.Web
{
    public  static class ConnectionString
    {
        public static string Connection()
        {
            var builder = new SqlConnectionStringBuilder()

            {
                DataSource = @".\SQLEXPRESS",
                InitialCatalog = "JobOffersDB",
                UserID = "sa",
                Password = "WikiUX@01000"

            };

            return builder.ConnectionString;

        }
    }
}