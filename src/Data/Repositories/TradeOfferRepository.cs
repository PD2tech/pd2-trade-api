using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Pd2TradeApi.Server.Data.Interfaces;
using Pd2TradeApi.Server.Data.Repositories.Base;
using Pd2TradeApi.Server.Models.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Pd2TradeApi.Server.Models.DTOs.Item.Request;
using Pd2TradeApi.Server.Models.DTOs.ItemStat.Request;
using AutoMapper.QueryableExtensions;

namespace Pd2TradeApi.Server.Data.Repositories
{
    public class TradeOfferRepository : BaseRepository<TradeOffer>, ITradeOfferRepository {
        private readonly IMapper _mapper;
        public TradeOfferRepository(Pd2TradeApiDbContext db, IMapper mapper) : base(db, mapper) {
            EntityName = "TradeOffer";
            _mapper = mapper;
        }

        public async Task<List<TradeOffer>> GetLatestTradeOffers()
        {
            return await Table.OrderByDescending(x => x.UpdatedDate).Take(30).ToListAsync();
        }

        public async Task<List<TradeOffer>> FilterTradeOffers(FilterTradeOffersRequest filterRequest)
        {
            var query = Table;

            var statIds = new List<long>();
            foreach (ItemStatFilter filter in filterRequest.ItemStats)
            {
               statIds.Add(filter.Id);
            }

            if (statIds.Any())
            {
                query.Include(x => x.ItemStats.Where(x => statIds.Contains(x.ItemStatId)));
            }

            if (filterRequest.AccountName != null)
            {
                query.Where(x => x.AccountName == filterRequest.AccountName);
            }

            query.Skip(filterRequest.Page * 30).Take(30);
            query.ProjectTo<TradeOfferResponse>(_mapper.ConfigurationProvider);

            return await query.ToListAsync();
        }
    }
}
