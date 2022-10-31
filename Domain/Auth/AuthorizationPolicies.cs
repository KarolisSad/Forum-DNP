using System.Security.Claims;
using Microsoft.Extensions.DependencyInjection;


namespace Domain.Auth;

public static class AuthorizationPolicies
{
    
    public static void AddPolicies(IServiceCollection services)
    {
        services.AddAuthorizationCore(options =>
        {
            options.AddPolicy("owner", a =>
                a.RequireAuthenticatedUser().RequireClaim("Owner", "post","subPost"));
            
        });
    }
    
    
    
}