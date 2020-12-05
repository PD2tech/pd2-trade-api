using Pd2TradeApi.Server.Models.Abstracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pd2TradeApi.Server.Data.Interfaces.Base {
    public interface IBaseRepository<Entity> where Entity : BaseEntity {
        Task<List<Entity>> AllAsync();
        Task<List<Dto>> AllAsync<Dto>();
        Task<long> AddAsync(Entity entity);
        Task AddMultipleAsync(List<Entity> entities);
        Task UpdateAsync(long id, Entity entity, long? adminId = null);
        Task<bool> DeleteAsync(long id);
        Task<bool> HardDeleteAllInTable();
        Task<Entity> GetByIdAsync(long id);
        Task<List<Entity>> GetByIdsAsync(long[] ids);
        Task<Dto> GetByIdAsync<Dto>(long id);
        Task<List<Dto>> GetByIdsAsync<Dto>(long[] ids);
        Task<Entity> SearchAsync(string expression);
        Task<List<Entity>> SearchAllAsync(string expression, string orderByExpression = "");
        Task<Dto> SearchAsync<Dto>(string expression);
        Task<List<Dto>> SearchAllAsync<Dto>(string expression);
        Task BulkUpdate(List<Entity> listOfEntitesToUpdateToo);
    }
}
