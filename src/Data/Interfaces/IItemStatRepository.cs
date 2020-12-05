using System.Threading.Tasks;
using Pd2TradeApi.Server.Data.Interfaces.Base;
using Pd2TradeApi.Server.Models.DatabaseModels;

namespace Pd2TradeApi.Server.Data.Interfaces
{
    public interface IItemStatRepository : IBaseRepository<ItemStat> {
        Task<ItemStat> GetByCode(string code);
    }
}
