using System;
using GraphQL;
using GraphQL.Types;
using GraphQL.Utilities;

namespace CompleteGraphQL
{
public class CaducidadSchema : Schema
{
    public CaducidadSchema(IServiceProvider provider)
        : base(provider)
    {
        Query = provider.GetRequiredService<CaducidadQuery>();
        Mutation = provider.GetRequiredService<CaducidadMutation>();
    }

}
}