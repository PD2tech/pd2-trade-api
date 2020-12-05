using AutoMapper;
using AutoMapper.QueryableExtensions;
using Pd2TradeApi.Server.Data.Interfaces.Base;
using Pd2TradeApi.Server.Models.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using Z.EntityFramework.Extensions;

namespace Pd2TradeApi.Server.Data.Repositories.Base {
    public class BaseRepository<Entity> : IBaseRepository<Entity> where Entity : BaseEntity {
        private readonly IMapper _mapper;

        protected readonly Pd2TradeApiDbContext Db;
        protected DbSet<Entity> Table => Db.Set<Entity>();
        public string EntityName { get; protected set; }

        public BaseRepository(Pd2TradeApiDbContext db, IMapper mapper) {
            Db = db;
            EntityFrameworkManager.ContextFactory = context => Db;
            _mapper = mapper;
        }

        public virtual async Task BulkUpdate(List<Entity> listOfEntitesToUpdateToo)
        {
            foreach (Entity entity in listOfEntitesToUpdateToo)
            {
                entity.UpdatedDate = DateTime.UtcNow;
            }
            await Table.BulkUpdateAsync(listOfEntitesToUpdateToo);
        }

        public virtual async Task<List<Entity>> AllAsync() {
            return await Table.ToListAsync();
        }

        public virtual async Task<List<Dto>> AllAsync<Dto>() {
            return await Table.ProjectTo<Dto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public virtual async Task<long> AddAsync(Entity entity) {
            entity.CreatedDate = DateTime.UtcNow;
            entity.UpdatedDate = entity.CreatedDate;
            CreatePropertyIgnore(entity);
            await Db.AddAsync(entity);
            await Db.SaveChangesAsync();
            return entity.Id;
        }

        public virtual async Task AddMultipleAsync(List<Entity> entities) {
            foreach (Entity entity in entities)
            {
                entity.CreatedDate = DateTime.UtcNow;
                entity.UpdatedDate = entity.CreatedDate;
                CreatePropertyIgnore(entity);
                await Db.AddAsync(entity);
            }
            await Db.SaveChangesAsync();
            return;
        }

        public virtual async Task<bool> DeleteAsync(long id) {
            var entity = await GetByIdAsync(id);
            if (entity == null || entity.IsDeleted)
            {
                return false;
                //throw new EntityNotFoundException($"{EntityName} not found with the id: {id}");
            }

            entity.IsDeleted = true;
            await UpdateAsync(id, entity);
            return true;
        }

        public virtual async Task<bool> HardDeleteAllInTable()
        {
            var all = await AllAsync();
            await Db.BulkDeleteAsync(all);
            return true;
        }

        public virtual async Task<Entity> GetByIdAsync(long id) {
            return await Table.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public virtual async Task<List<Entity>> GetByIdsAsync(long[] ids)
        {
            return await Table.Where(x => ids.Contains(x.Id)).ToListAsync();
        }

        public virtual async Task<List<Dto>> GetByIdsAsync<Dto>(long[] ids)
        {
            return await Table.Where(x => ids.Contains(x.Id)).ProjectTo<Dto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public virtual async Task<Dto> GetByIdAsync<Dto>(long id) {
            return await Table.Where(x => x.Id == id).ProjectTo<Dto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }

        public virtual async Task UpdateAsync(long id, Entity entity, long? adminId = null) {
            var oldEntity = await GetByIdAsync(id);
            if (oldEntity == null) {
                return;
                //throw new EntityNotFoundException($"{EntityName} not found with the id: {id}");
            }

            entity.UpdatedDate = DateTime.UtcNow;
            entity.Id = id;
            Db.Entry(oldEntity).CurrentValues.SetValues(entity);
            Db.Entry(oldEntity).Property(x => x.CreatedDate).IsModified = false;
            UpdatePropertyIgnore(entity);
            await Db.SaveChangesAsync();
        }

        public virtual async Task<Entity> SearchAsync(string expression)
        {
            return await Table.Where(expression).FirstOrDefaultAsync();
        }

        public virtual async Task<List<Entity>> SearchAllAsync(string expression, string orderByExpression = "")
        {
            var query = Table.Where(expression);
            if (!string.IsNullOrWhiteSpace(orderByExpression))
            {
                query = query.OrderBy(orderByExpression);
            }
            return await query.ToListAsync();
        }

        public virtual async Task<Dto> SearchAsync<Dto>(string expression)
        {
            return await Table.Where(expression).ProjectTo<Dto>(_mapper.ConfigurationProvider).FirstOrDefaultAsync();
        }

        public virtual async Task<List<Dto>> SearchAllAsync<Dto>(string expression)
        {
            return await Table.Where(expression).ProjectTo<Dto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        protected void UpdateValues(Entity currentEntity, Entity newEntity) {
            Db.Entry(currentEntity).CurrentValues.SetValues(newEntity);
            UpdatePropertyIgnore(currentEntity);
        }

        protected virtual void UpdatePropertyIgnore(Entity entity) { }
        protected virtual void CreatePropertyIgnore(Entity entity) { }

        protected async Task ExecuteSqlAsync(string sql, params object[] sqlParams) {
            await Db.Database.ExecuteSqlRawAsync(sql, sqlParams);
        }
    }
}
