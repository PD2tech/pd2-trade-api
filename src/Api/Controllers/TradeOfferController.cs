using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pd2TradeApi.Server.Models.DatabaseModels;
using Pd2TradeApi.Server.Services.Interfaces;

namespace ChicksGold.Server.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TradeOfferController : ControllerBase
    {
        private readonly ITradeOfferService _tradeOfferService;

        public TradeOfferController(ITradeOfferService tradeOfferService)
        {
            _tradeOfferService = tradeOfferService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(TradeOffer), 200)]
        [Authorize]
        public async Task<IActionResult> CreateTradeOffer(CreateTradeOfferRequest tradeOffer)
        {
            await _tradeOfferService.CreateTradeOffer(tradeOffer);

            return Ok(tradeOffer);
        }

        [HttpPut]
        [ProducesResponseType(typeof(TradeOffer), 200)]
        [Authorize]
        public async Task<IActionResult> UpdateTradeOffer(UpdateTradeOfferRequest tradeOffer)
        {
            await _tradeOfferService.UpdateTradeOffer(tradeOffer);
            return Ok(tradeOffer);
        }


        [HttpGet("{id}")]
        [ProducesResponseType(typeof(TradeOffer), 200)]
        public async Task<IActionResult> GetById(long id)
        {
            var post = await _tradeOfferService.GetById(id);

            return Ok(post);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<TradeOffer>), 200)]
        public async Task<IActionResult> ListTradeOffers()
        {
            return Ok(await _tradeOfferService.GetTradeOffers());
        }

        [HttpGet("Find")]
        [ProducesResponseType(typeof(TradeOffer), 200)]
        public async Task<IActionResult> FindTradeOffer(string expression)
        {
            return Ok(await _tradeOfferService.FindTradeOffer(expression));
        }

        [HttpGet("Search")]
        [ProducesResponseType(typeof(List<TradeOffer>), 200)]
        public async Task<IActionResult> SearchTradeOffers(string expression, string orderByExpression)
        {
            return Ok(await _tradeOfferService.SearchTradeOffers(expression, orderByExpression));
        }
    }
}
