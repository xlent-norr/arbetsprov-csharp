
using System.Threading;
using System.Threading.Tasks;
using Arbetsprov.CSharp.Web.Models;

namespace Arbetsprov.CSharp.Web.Contracts;

public interface IWeatherService
{
    Task<WeatherData> GetWeatherDataAsync(double latitude, double longitude, CancellationToken cancellationToken);
}