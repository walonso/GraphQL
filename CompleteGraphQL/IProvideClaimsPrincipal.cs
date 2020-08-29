using System.Security.Claims;

namespace CompleteGraphQL
{
    public interface IProvideClaimsPrincipal
    {
        ClaimsPrincipal User { get; }
    }
}