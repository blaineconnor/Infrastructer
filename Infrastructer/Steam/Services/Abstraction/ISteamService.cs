using Infrastructer.Steam.CustomTypes;
using Infrastructer.Steam.Enumerations;

namespace Infrastructer.Steam.Services.Abstraction
{
    public interface ISteamService
    {

        List<Listing> GetListings(string game, Culture culture);
    }
}
