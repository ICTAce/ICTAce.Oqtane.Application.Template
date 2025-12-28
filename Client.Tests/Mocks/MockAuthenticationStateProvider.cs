using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;

namespace SampleCompany.SampleModule.Client.Tests.Mocks;

public class MockAuthenticationStateProvider : AuthenticationStateProvider
{
    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var identity = new ClaimsIdentity(new[]
        {
            new Claim(ClaimTypes.Name, "Test User"),
        }, "Test");
        var user = new ClaimsPrincipal(identity);
        return Task.FromResult(new AuthenticationState(user));
    }
}
