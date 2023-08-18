using Infrastructer.Steam.Enumerations;

namespace SteamAPI.Models
{
    public class GetSteamGameInfoRequestModel
    {
        public string Game { get; set; }
        public Culture Culture { get; set; }
    }
}
