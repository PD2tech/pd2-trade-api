using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pd2TradeApi.Server.Models;
using Pd2TradeApi.Server.Models.DatabaseModels;

namespace Pd2TradeApi.Server.Data.Configurations
{
    public class ItemItemStatConfiguration : IEntityTypeConfiguration<ItemItemStat>
    {
        public void Configure(EntityTypeBuilder<ItemItemStat> builder)
        {
            builder
                .HasKey(x => new { x.ItemId, x.ItemStatId });
            builder
                .HasOne(x => x.Item)
                .WithMany(x => x.ItemStats)
                .HasForeignKey(x => x.ItemId);
            builder
                .HasOne(x => x.ItemStat)
                .WithMany(x => x.Items)
                .HasForeignKey(x => x.ItemStatId);
        }
    }
}
