
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace CompleteGraphQL
{

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {


        services.AddDbContext<CaducaContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

services.AddScoped<LocService>();
        services.AddScoped<CaducidadSchema>();
        services.AddScoped<CaducidadInputType>();
        services.AddScoped<CaducidadMutation>();
        services.AddGraphQL(x =>
        {
            x.EnableMetrics = true;
            x.ExposeExceptions = true; //Cambiar a false para producción
        })
        .AddSystemTextJson(deserializerSettings => { }, serializerSettings => { }) // For .NET Core 3+
        .AddGraphTypes(ServiceLifetime.Scoped)
        /*.AddUserContextBuilder(httpContext =>
            {
                return new GraphQLUserContext { User = httpContext.User };
            })*/
        .AddDataLoader();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseGraphQL<CaducidadSchema>();          
        app.UseGraphQLPlayground(options: new GraphQLPlaygroundOptions());
    }
}
}