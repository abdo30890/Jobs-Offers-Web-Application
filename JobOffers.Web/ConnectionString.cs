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
                DataSource = @"ABDELRAHMAN\SQLEXPRESS",
                InitialCatalog = "JobOffersDB",
                UserID = "sa",
                Password = "72031997"

            };

            return builder.ConnectionString;

        }
        //public static string Development()
        //{
        //    var builder = new SqlConnectionStringBuilder()

        //    {
        //        DataSource = @".\SQLEXPRESS",
        //        InitialCatalog = "JobsDb",
        //        UserID = "sa",
        //      //  Password = "Eslam@01000727540"

        //    };

        //    return builder.ConnectionString;

        //}
    }
}