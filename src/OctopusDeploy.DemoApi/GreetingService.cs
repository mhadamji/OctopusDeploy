namespace OctopusDeploy.DemoApi.Services;

public sealed class GreetingService
{
    public string GetGreeting(string? name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return "Hello, world!";

        return $"Hello, {name.Trim()}!";
    }
}