1. Create Console App

dotnet new sln
dotnet new console -o SimpleGraphQL

2. Add Nuget Package:
cd SimpleGraphQL
dotnet add package GraphQL -s https://www.myget.org/F/graphql-dotnet/api/v3/index.json -v 3.0.0-preview-1621
dotnet add package GraphQL.NewtonsoftJson -s https://www.myget.org/F/graphql-dotnet/api/v3/index.json -v 3.0.0-preview-1621
dotnet restore


3. There are two ways you can build your schema:
- One is with a Schema first approach using the GraphQL schema language. 
- The other is a GraphType or code-first approach by writing GraphType classes.

3.1 Selecting The Schema first approach relies upon the GraphQL schema language.
we will query for a 'hello' property to the server and it will return a 'world' string. So, the property hello will be a string type:

-> See project SimpleGraphQL.
dotnet run

3.2 Selecting The Schema first approach relies upon the GraphQL schema language.
This is a different approach in which we will use classes and decorate them, the idea is that the classes will contain methods that will serve as resolvers when we make a query.

To do it this way we need to do the following:
1. Update the schema, new custom type and expose it in the Query
2. Create classes to support Type, Query and also an in-memory database


dotnet new console -o SchemaFirstGraphQL
cd SchemaFirstGraphQL
dotnet add package GraphQL -s https://www.myget.org/F/graphql-dotnet/api/v3/index.json -v 3.0.0-preview-1621
dotnet add package GraphQL.NewtonsoftJson -s https://www.myget.org/F/graphql-dotnet/api/v3/index.json -v 3.0.0-preview-1621
dotnet restore


Code:
Program.cs contains the code to handle querys.
Query.cs Class handle querys.

dotnet run

4.  Other Example:
https://github.com/graphql-dotnet/server

dotnet new console -o CompleteGraphQL

cd CompleteGraphQL
dotnet add package GraphQL -s https://www.myget.org/F/graphql-dotnet/api/v3/index.json -v 3.0.0-preview-1621
dotnet add package GraphQL.Server.Transports.AspNetCore --version 3.5.0-alpha0073
dotnet add package GraphQL.Server.Transports.AspNetCore.SystemTextJson --version 3.5.0-alpha0073

Documentacion parecida a Swagger:
dotnet add package GraphQL.Server.Ui.Playground --version 3.5.0-alpha0073

Add Entity Framework:
dotnet add package Microsoft.EntityFrameworkCore --version 3.1.7
dotnet add package Microsoft.EntityFrameworkCore.Relational --version 3.1.7
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 3.1.7
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.1.7
dotnet ef migrations add InitialCreate
dotnet ef database update

Open URL:  (this is playground, which is the swagger of GraphQL)
http://localhost:5000/ui/playground


https://dhalgara.com/2019/03/20/graphq-role-based-authorization-field-level/

