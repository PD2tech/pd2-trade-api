using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pd2TradeApi.Server.Models.DatabaseModels;
using Pd2TradeApi.Server.Models.DTOs.ItemStat.Request;
using Pd2TradeApi.Server.Models.DTOs.Runeword.Request;
using Pd2TradeApi.Server.Models.DTOs.Shared;
using Pd2TradeApi.Server.Services.Interfaces;

namespace ChicksGold.Server.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RunewordController : ControllerBase
    {
        private readonly IRunewordService _runewordService;

        public RunewordController(IRunewordService runewordService)
        {
            _runewordService = runewordService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(RunewordResponse), 200)]
        [Authorize(Policy = nameof(AuthorizationPolicyType.CreateItem))]
        public async Task<IActionResult> CreateRuneword(CreateRunewordRequest item)
        {
            await _runewordService.CreateRuneword(item);

            return Ok(item);
        }

        [HttpPost("Bulk")]
        [ProducesResponseType(typeof(List<RunewordResponse>), 200)]
        [Authorize(Policy = nameof(AuthorizationPolicyType.CreateItem))]
        public async Task<IActionResult> CreateRunewords(List<CreateRunewordRequest> items)
        {
            await _runewordService.CreateOrUpdateRunewords(items);

            return Ok(items);
        }

        [HttpPut]
        [ProducesResponseType(typeof(RunewordResponse), 200)]
        [Authorize(Policy = nameof(AuthorizationPolicyType.EditItem))]
        public async Task<IActionResult> UpdateRuneword(UpdateRunewordRequest runeword)
        {
            await _runewordService.UpdateRuneword(runeword);

            return Ok(runeword);
        }


        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Runeword), 200)]
        public async Task<IActionResult> GetById(long id)
        {
            var post = await _runewordService.GetById(id);

            return Ok(post);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Runeword>), 200)]
        public async Task<IActionResult> ListRunewords()
        {
            return Ok(await _runewordService.GetRunewords());
        }

        [HttpGet("Find")]
        [ProducesResponseType(typeof(Runeword), 200)]
        public async Task<IActionResult> FindRuneword(string expression)
        {
            return Ok(await _runewordService.FindRuneword(expression));
        }

        [HttpGet("Search")]
        [ProducesResponseType(typeof(List<Runeword>), 200)]
        public async Task<IActionResult> SearchRunewords(string expression, string orderByExpression)
        {
            return Ok(await _runewordService.SearchRunewords(expression, orderByExpression));
        }
    }
}
