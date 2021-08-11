
using System.Threading.Tasks;
using Arbetsprov.CSharp.Web.Contracts;
using Arbetsprov.CSharp.Web.Models;

namespace Arbetsprov.CSharp.Web.Services
{
    public class WeatherService : IWeatherService
    {
        public async Task<WeatherData> GetWeatherDataAsync(double latitude, double longitude)
        {
            return new WeatherData();
        }
    }
}