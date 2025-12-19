namespace FitHubManagement.DataAccess
{
    // PHILLIP
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
