using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pd2TradeApi.Server.Data.Interfaces;
using Pd2TradeApi.Server.Data.Repositories.Base;
using Pd2TradeApi.Server.Models.DatabaseModels;

namespace Pd2TradeApi.Server.Data.Repositories
{
    public class ItemRepository : BaseRepository<Item>, IItemRepository {
        public ItemRepository(Pd2TradeApiDbContext db, IMapper mapper) : base(db, mapper) {
            EntityName = "Item";
        }

        public async Task<Item> GetByCode(string code)
        {
            return await Table.Where(x => x.Code == code).FirstOrDefaultAsync();
        }
    }
}
