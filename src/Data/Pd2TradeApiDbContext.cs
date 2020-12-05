using System.Linq.Expressions;
using Pd2TradeApi.Server.Data.Configurations;
using Pd2TradeApi.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pd2TradeApi.Server.Models.DatabaseModels;

namespace Pd2TradeApi.Server.Data
{
    public class Pd2TradeApiDbContext : IdentityDbContext<User, IdentityRole<long>, long, IdentityUserClaim<long>, IdentityUserRole<long>, IdentityUserLogin<long>, IdentityRoleClaim<long>, IdentityUserToken<long>>
    {
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<TradeOffer> TradeOffers { get; set; }
        public DbSet<ItemStat> ItemStats { get; set; }
        public DbSet<ItemStatTradeOffer> ItemStatsTradeOffers { get; set; }
        public DbSet<Runeword> Runewords { get; set; }
        public DbSet<ItemSocket> ItemSockets { get; set; }

        public Pd2TradeApiDbContext(DbContextOptions options) : base(options)
        {
            // no-op
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole<long>>().ToTable("Role");
            modelBuilder.Entity<IdentityUserClaim<long>>().ToTable("UserClaim");
            modelBuilder.Entity<IdentityUserLogin<long>>().ToTable("UserLogin");
            modelBuilder.Entity<IdentityRoleClaim<long>>().ToTable("RoleClaim");
            modelBuilder.Entity<IdentityUserToken<long>>().ToTable("UserToken");
            modelBuilder.Entity<IdentityUserRole<long>>().ToTable("UserRole");

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ItemStatTradeOffersConfiguration());

            //modelBuilder.Entity<UserNote>().HasQueryFilter(e => !e.IsDeleted);

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var isDeletedProperty = entityType.FindProperty("IsDeleted");
                if (isDeletedProperty != null && isDeletedProperty.ClrType == typeof(bool))
                {
                    var parameter = Expression.Parameter(entityType.ClrType);
                    var filter = Expression.Lambda(Expression.Not(Expression.Property(parameter, isDeletedProperty.PropertyInfo)), parameter);
                    entityType.SetQueryFilter(filter);
                }
            }
        }
    }
}
