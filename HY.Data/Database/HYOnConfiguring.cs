using Microsoft.EntityFrameworkCore;

namespace HY.Data.Database
{
    public static class HYOnConfiguring
    {
        public static void Configure(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.EnableDetailedErrors();
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=HellYeah;Trusted_Connection=True;ConnectRetryCount=0");
        }
    }
}
