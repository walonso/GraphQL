
using GraphQL.Types;

namespace CompleteGraphQL
{
public class CaducidadInputType: InputObjectGraphType
{
    public CaducidadInputType()
    {
        Name = "CaducidadInput";
        Field<NonNullGraphType<IntGraphType>>("Id");
        Field<NonNullGraphType<IntGraphType>>("Cantidad");
        Field<NonNullGraphType<IntGraphType>>("ProductoId");
        Field<NonNullGraphType<IntGraphType>>("ClienteId");
        Field<NonNullGraphType<DateGraphType>>("Fecha");
    }
}
}