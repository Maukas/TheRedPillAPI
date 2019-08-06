namespace DataAccess.Context
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Options;
    using DataModels.Settings;
    public class DataAPIContext: DbContext
    {
        IOptions<AppSettings> settings;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        //    modelBuilder.HasPostgresExtension("uuid-ossp")
        //            .Entity<Account>()
        //            .Property(e => e.AccountId)
        //            .HasDefaultValueSql("uuid_generate_v4()");
        //    modelBuilder.HasPostgresExtension("uuid-ossp")
        //          .Entity<Bill>()
        //          .Property(e => e.BillId)
        //          .HasDefaultValueSql("uuid_generate_v4()");
        }
    }
}
