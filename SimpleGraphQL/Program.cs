using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using GraphQL.NewtonsoftJson;

namespace SimpleGraphQL
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //1. Declaring our schema
            //The string that we feed into Schema.For contains GQL or GraphQL Query Language. It defines three things generally:
            /*
            1. Query: this is what we can query for
            2. Types: we don't have any types yet but we will later on in the article.
            3. Mutation: this is what we can call that semantically means that we will change something
            */
            //we have the type Query and what it says is that we can query for hello and that the response is of type string, hello: string
            var schema = Schema.For(@"
                type Query {
                    hello: String
                }"
            );

            //2 Resolving our query
            //This piece of code is what actually handles an incoming request. In our case the resolver code looks like this:
            //As we can see it maps something inside of our query hello and says that - if the user asks for hello, then we will answer with World (_.Root = new { hello = "world" };)
            //3. Executing the query
            //we execute our query { hello } by assigning it to the property _.Query in the lambda expression we provide to schema.Execute().
            var json = await schema.ExecuteAsync(_ =>
            {
                _.Query = "{ hello }";
                _.Root = new { hello = "world" };
            });

            //Then the result of our query is assigned to our variable json and we can easily print that to the terminal:
            Console.WriteLine(json);
        }

        /*static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }*/
    }
}
