using AutoMapper;
using Pd2TradeApi.Server.Data.Interfaces;
using Pd2TradeApi.Server.Data.Repositories.Base;
using Pd2TradeApi.Server.Models.DatabaseModels;

namespace Pd2TradeApi.Server.Data.Repositories
{
    public class SeasonRepository : BaseRepository<Season>, ISeasonRepository {
        public SeasonRepository(Pd2TradeApiDbContext db, IMapper mapper) : base(db, mapper) {
            EntityName = "Item";
        }
    }
}
