using System.Collections.Generic;
using System.Threading.Tasks;
using Pd2TradeApi.Server.Models.DTOs.Runeword.Request;

namespace Pd2TradeApi.Server.Services.Interfaces
{
    public interface IRunewordService
    {
        Task<List<RunewordResponse>> GetRunewords();
        Task<List<RunewordResponse>> SearchRunewords(string expression, string orderByExpression);
        Task<RunewordResponse> FindRuneword(string expression);
        Task<RunewordResponse> GetById(long id);
        Task<RunewordResponse> CreateRuneword(CreateRunewordRequest item);
        Task<RunewordResponse> UpdateRuneword(UpdateRunewordRequest item);
        Task<List<RunewordResponse>> CreateOrUpdateRunewords(List<CreateRunewordRequest> createRunewordsRequest);
        Task<bool> DeleteRuneword(long id);
    }
}