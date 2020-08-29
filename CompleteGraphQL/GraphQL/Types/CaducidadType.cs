

using GraphQL.Types;


namespace CompleteGraphQL
{
public class CaducidadType : ObjectGraphType<Caducidad>
{
    public CaducidadType(CaducaContext caducaContext,
                         LocService locService)
    {
        ProductoDAO productoDAO = new ProductoDAO(caducaContext, 
                                                         locService);
        ClienteDAO clienteDAO = new ClienteDAO(caducaContext,
                                                         locService);

        Name = "Caducidad";

        Field(c => c.Id).Description("Id");
        Field(c => c.ProductoId).Description("Id del producto");
        Field(c => c.ClienteId).Description("Id del cliente");
        Field(c => c.Cantidad).Description("Cantidad");
        Field(c => c.Fecha).Description("Fecha");
        Field<ProductoType>("Producto", 
            arguments: new QueryArguments(
                   new QueryArgument<IntGraphType> { Name = "Id" }),
            resolve: context => 
                    productoDAO.ObtenerPorIdAsync(context.Source.Id)
                          .Result, description: "Datos del producto");

            Field<ClienteType>("Cliente", 
                arguments: new QueryArguments(
                    new QueryArgument<IntGraphType> { Name = "Id" }),
                resolve: context => 
                    clienteDAO.ObtenerPorIdAsync(context.Source.Id)
                         .Result, description: "Datos del cliente");
    }
}
}