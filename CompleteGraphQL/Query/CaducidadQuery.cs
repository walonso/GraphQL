
using GraphQL.Types;

namespace CompleteGraphQL
{
public class CaducidadQuery: ObjectGraphType
{
    public CaducidadQuery(CaducaContext caducaContext, 
                          LocService locService)
    {
        CaducidadDAO caducidadDAO = new CaducidadDAO(caducaContext, 
                                                         locService);

        Field<ListGraphType<CaducidadType>>(
           "caducidades",
           resolve: context => caducidadDAO.ObtenerTodoAsync());
    }
}
}