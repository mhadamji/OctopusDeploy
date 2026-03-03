using OctopusDeploy.DemoApi.Services;
using Xunit;

namespace OctopusDeploy.DemoApi.Tests;

public sealed class GreetingServiceTests
{
    [Fact]
    public void GetGreeting_WhenNameProvided_ReturnsPersonalizedGreeting()
    {
        var svc = new GreetingService();

        var result = svc.GetGreeting("Octopus");

        Assert.Equal("Hello, Octopus!", result);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void GetGreeting_WhenNameMissing_ReturnsDefaultGreeting(string? name)
    {
        var svc = new GreetingService();

        var result = svc.GetGreeting(name);

        Assert.Equal("Hello, world!", result);
    }
}