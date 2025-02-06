using Arbetsprov.CSharp.Web.Services;
using Xunit;

namespace Arbetsprov.CSharp.Web.Tests.Services;

public class WeatherServiceTests
{
    [Fact]
    public void CanConstruct()
    {
        var service = new WeatherService();
        Assert.NotNull(service);
    }
}