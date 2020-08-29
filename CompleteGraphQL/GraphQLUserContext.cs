
using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace CompleteGraphQL
{

[ExcludeFromCodeCoverage]
    public class GraphQLUserContext : IProvideClaimsPrincipal
    {
        /// <summary>
    /// Gets/sets a claims principal user associated to the request.
    /// </summary>
    public ClaimsPrincipal User { get; set; }

    /// <summary>
    /// Gets/sets the current Http Request.
    /// </summary>
    public HttpRequest Request { get; set; }
    }

}