using Microsoft.EntityFrameworkCore;
using Systemsnow.Study.DummyAPI.Entity;
namespace Systemsnow.Study.DummyAPI.Data
{
    /// <summary>
    /// メモリ内データベース
    /// </summary>
    public class AccountSqliteDbContext : DbContext
    {
        public AccountSqliteDbContext(DbContextOptions options) : base(options) { }

        public DbSet<AccountEntity> Account { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
          optionsBuilder.UseSqlite("Data Source=account.db");
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AccountEntity>()
                .HasIndex(m => m.UserId)
                .IsUnique();
        }
    }
}
