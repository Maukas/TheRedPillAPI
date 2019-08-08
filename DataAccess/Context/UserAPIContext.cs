namespace DataAccess.Context
{
    using Entities;
    using Microsoft.EntityFrameworkCore;
   

   public class UserAPIContext : DbContext
    {
        public UserAPIContext()
        {

        }

        public UserAPIContext(DbContextOptions<UserAPIContext> options)
       : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.HasPostgresExtension("uuid-ossp")
                        .Entity<User>()
                        .Property(e => e.UserId)
                        .HasDefaultValueSql("uuid_generate_v4()");           
        }
    }
}
