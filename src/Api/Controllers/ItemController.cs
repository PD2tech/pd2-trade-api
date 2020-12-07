using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pd2TradeApi.Server.Models.DatabaseModels;
using Pd2TradeApi.Server.Models.DTOs.Item.Request;
using Pd2TradeApi.Server.Models.DTOs.ItemStat.Request;
using Pd2TradeApi.Server.Models.DTOs.Shared;
using Pd2TradeApi.Server.Services.Interfaces;

namespace ChicksGold.Server.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet("Categories")]
        [ProducesResponseType(typeof(List<string>), 200)]
        public async Task<IActionResult> GetItemCategories()
        {
            return Ok(Enum.GetNames(typeof(ItemCategoryList)));
        }

        [HttpGet("SubCategory")]
        [ProducesResponseType(typeof(List<string>), 200)]
        public async Task<IActionResult> GetItemCategories(string category)
        {
            if (category == null)
            {
                return BadRequest("Category is required");
            }
            var enumValue = (ItemCategoryList) Enum.Parse(typeof(ItemCategoryList), category);
            return Ok(ItemSubcategoryList.ItemSubCategoryList[enumValue]);
        }

        [HttpGet("Rarities")]
        [ProducesResponseType(typeof(List<string>), 200)]
        public async Task<IActionResult> GetItemRarities()
        {
            return Ok(Enum.GetNames(typeof(ItemRarityList)));
        }

        [HttpPost]
        [ProducesResponseType(typeof(ItemResponse), 200)]
        [Authorize(Policy = nameof(AuthorizationPolicyType.CreateItem))]
        public async Task<IActionResult> CreateItem(CreateItemRequest item)
        {
            await _itemService.CreateItem(item);

            return Ok(item);
        }

        [HttpPost("Bulk")]
        [ProducesResponseType(typeof(List<ItemResponse>), 200)]
        [Authorize(Policy = nameof(AuthorizationPolicyType.CreateItem))]
        public async Task<IActionResult> CreateItemStats(List<CreateItemRequest> items)
        {
            await _itemService.CreateOrUpdateItems(items);

            return Ok(items);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Item), 200)]
        [Authorize(Policy = nameof(AuthorizationPolicyType.EditItem))]
        public async Task<IActionResult> UpdateItem(UpdateItemRequest item)
        {
            await _itemService.UpdateItem(item);

            return Ok(item);
        }


        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Item), 200)]
        public async Task<IActionResult> GetById(long id)
        {
            var post = await _itemService.GetById(id);

            return Ok(post);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Item>), 200)]
        public async Task<IActionResult> ListItems()
        {
            return Ok(await _itemService.GetItems());
        }

        [HttpGet("Find")]
        [ProducesResponseType(typeof(Item), 200)]
        public async Task<IActionResult> FindItem(string expression)
        {
            return Ok(await _itemService.FindItem(expression));
        }

        [HttpGet("Search")]
        [ProducesResponseType(typeof(List<Item>), 200)]
        public async Task<IActionResult> SearchItems(string expression, string orderByExpression)
        {
            return Ok(await _itemService.SearchItems(expression, orderByExpression));
        }
    }
}
