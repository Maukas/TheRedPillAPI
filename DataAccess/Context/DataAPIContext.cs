namespace DataAccess.Context
{
    using Microsoft.EntityFrameworkCore;
    using Entities;

    public class DataAPIContext: DbContext
    {
        public DataAPIContext() { }

        public DbSet<Data> Datas { get; set; }
        public DataAPIContext(DbContextOptions<DataAPIContext> options)
        : base(options)
        {
          
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        
        }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Data>().Property(p => p.DataJson).HasColumnType("json");
            modelBuilder.HasPostgresExtension("uuid-ossp")
                .Entity<Data>()
                .Property(e => e.DataId)
                .HasDefaultValueSql("uuid_generate_v4()");
        }
    }
}
