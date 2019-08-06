namespace DataAccess.Context
{
    using Microsoft.EntityFrameworkCore;
   

   public class UserAPIContext : DbContext
    {
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
