using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FitHubManagement.DataAccess.DatabaseConnectionDAL;

namespace FitHubManagement.DataAccess
{
    internal class DatabaseConnectionDAL
    {
        public static class DatabaseConfig
        {
            // Connection string gemmes her
            public static readonly string ConnectionString = "Server=.;Database=FitHubDB;" +
                "Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True;";

        }
    }
}
