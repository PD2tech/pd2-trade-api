using AutoMapper;
using Pd2TradeApi.Server.Data.Interfaces;
using Pd2TradeApi.Server.Models.DatabaseModels;
using Pd2TradeApi.Server.Models.DTOs.ItemStat.Request;
using Pd2TradeApi.Server.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pd2TradeApi.Server.Services
{
    public class RunewordService : IRunewordService
    {
         private readonly IRunewordRepository _runewordRespository;
        private readonly IMapper _mapper;

        public RunewordService(IRunewordRepository runewordRespository, IMapper mapper)
        {
            _runewordRespository = runewordRespository;
            _mapper = mapper;
        }

        public async Task<RunewordResponse> FindRuneword(string expression)
        {
            var response = await _runewordRespository.SearchAsync(expression);
            return _mapper.Map<RunewordResponse>(response);
        }

        public async Task<List<RunewordResponse>> SearchRunewords(string expression, string orderByExpression)
        {
            var response = await _runewordRespository.SearchAllAsync(expression, orderByExpression);
            return _mapper.Map<List<RunewordResponse>>(response);
        }

        public async Task<List<RunewordResponse>> GetRunewords()
        {
            var response = await _runewordRespository.AllAsync();
            return _mapper.Map<List<RunewordResponse>>(response);
        }

        public async Task<RunewordResponse> GetById(long id)
        {
            var response = await _runewordRespository.GetByIdAsync(id);
            return _mapper.Map<RunewordResponse>(response);
        }

        public async Task<RunewordResponse> CreateRuneword(CreateRunewordRequest runeword)
        {
            await _runewordRespository.AddAsync(_mapper.Map<Runeword>(runeword));
            return _mapper.Map<RunewordResponse>(runeword);
        }

        public async Task<RunewordResponse> UpdateRuneword(UpdateRunewordRequest runeword)
        {
            await _runewordRespository.UpdateAsync(runeword.Id, _mapper.Map<Runeword>(runeword));
            return _mapper.Map<RunewordResponse>(runeword);
        }

        public async Task<bool> DeleteRuneword(long id)
        {
            return await _runewordRespository.DeleteAsync(id);
        }
    }
}
