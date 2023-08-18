using Infrastructer.Steam.CustomTypes;
using Infrastructer.Steam.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;
using SteamAPI.Models;

namespace SteamAPI.Controllers
{
    [ApiController]
    [Route("steam")]
    public class SteamController : ControllerBase
    {
        private readonly ISteamService _steamService;

        public SteamController(ISteamService steamService)
        {
            _steamService = steamService;
        }


        [HttpPost(Name = "steamGameInfo")]
        public IEnumerable<Listing> GetByCulture([FromBody] GetSteamGameInfoRequestModel request)
        {
            var result = _steamService.GetListings(request.Game, request.Culture);
            return result;
        }
    }
}