using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pd2TradeApi.Server.Models.DTOs.ItemStat.Request;
using Pd2TradeApi.Server.Models.DTOs.Shared;
using Pd2TradeApi.Server.Services.Interfaces;

namespace ChicksGold.Server.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemStatController : ControllerBase
    {
        private readonly IItemStatService _itemStatService;

        public ItemStatController(IItemStatService itemStatService)
        {
            _itemStatService = itemStatService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(ItemStatResponse), 200)]
        [Authorize(Policy = nameof(AuthorizationPolicyType.CreateItemStat))]
        public async Task<IActionResult> CreateItemStat(CreateItemStatRequest itemStat)
        {
            await _itemStatService.CreateItemStat(itemStat);

            return Ok(itemStat);
        }

        [HttpPost("Bulk")]
        [ProducesResponseType(typeof(List<ItemStatResponse>), 200)]
        [Authorize(Policy = nameof(AuthorizationPolicyType.CreateItemStat))]
        public async Task<IActionResult> CreateItemStats(List<CreateItemStatRequest> itemStats)
        {
            await _itemStatService.CreateOrUpdateItemStats(itemStats);

            return Ok(itemStats);
        }

        [HttpPut]
        [ProducesResponseType(typeof(ItemStatResponse), 200)]
        [Authorize(Policy = nameof(AuthorizationPolicyType.EditItemStat))]
        public async Task<IActionResult> UpdateItemStat(UpdateItemStatRequest itemStat)
        {
            await _itemStatService.UpdateItemStat(itemStat);

            return Ok(itemStat);
        }


        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ItemStatResponse), 200)]
        public async Task<IActionResult> GetById(long id)
        {
            var post = await _itemStatService.GetById(id);

            return Ok(post);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ItemStatResponse>), 200)]
        public async Task<IActionResult> ListItemStats()
        {
            return Ok(await _itemStatService.GetItemStats());
        }

        [HttpGet("Find")]
        [ProducesResponseType(typeof(ItemStatResponse), 200)]
        public async Task<IActionResult> FindItemStat(string expression)
        {
            return Ok(await _itemStatService.FindItemStat(expression));
        }

        [HttpGet("Search")]
        [ProducesResponseType(typeof(List<ItemStatResponse>), 200)]
        public async Task<IActionResult> SearchItemStats(string expression, string orderByExpression)
        {
            return Ok(await _itemStatService.SearchItemStats(expression, orderByExpression));
        }
    }
}
