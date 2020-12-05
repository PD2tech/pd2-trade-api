using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pd2TradeApi.Server.Models.DatabaseModels;
using Pd2TradeApi.Server.Models.DTOs.Shared;

namespace ChicksGold.Server.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeasonController : ControllerBase
    {

        public SeasonController()
        {

        }

        [HttpGet]
        [ProducesResponseType(typeof(List<string>), 200)]
        public async Task<IActionResult> GetSeasons()
        {
            return Ok(Enum.GetNames(typeof(Pd2SeasonList)));
        }
    }
}
