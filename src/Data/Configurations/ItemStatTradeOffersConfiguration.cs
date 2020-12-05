using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pd2TradeApi.Server.Models;
using Pd2TradeApi.Server.Models.DatabaseModels;

namespace Pd2TradeApi.Server.Data.Configurations
{
    public class ItemStatTradeOffersConfiguration : IEntityTypeConfiguration<ItemStatTradeOffer>
    {
        public void Configure(EntityTypeBuilder<ItemStatTradeOffer> builder)
        {
            builder
                .HasKey(x => new { x.TradeOfferId, x.ItemStatId });
            builder
                .HasOne(x => x.TradeOffer)
                .WithMany(x => x.ItemStats)
                .HasForeignKey(x => x.TradeOfferId);
            builder
                .HasOne(x => x.ItemStat)
                .WithMany(x => x.TradeOffers)
                .HasForeignKey(x => x.ItemStatId);
        }
    }
}
