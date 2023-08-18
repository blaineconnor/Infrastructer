using Infrastructer.Steam.CustomTypes;
using Infrastructer.Steam.Enumerations;

namespace Infrastructer.Steam.Services.Abstraction
{
    public interface ICultureService
    {
        CultureValue GetCultureValue(Culture culture);
    }
}
