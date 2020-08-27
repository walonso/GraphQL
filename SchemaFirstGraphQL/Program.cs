using System;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using GraphQL.NewtonsoftJson;

namespace SchemaFirstGraphQL
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Adding Jedi as a type by writing type Jedi and also define its properties within {}. 
            //Then add jedis to the Query and say it's of type [Jedi] which means it's an array of Jedi. Lastly, we give our Schema.For() a second argument:
            //_.Types.Include<Query>();
            //This means we are pointing out a class Query that will handle all incoming requests.
            var schema = Schema.For(@"
            type Jedi {
                name: String,
                side: String
            }

            type Query {
                hello: String,
                jedis: [Jedi]
            }
            ", _ =>
            {
            _.Types.Include<Query>();
            });

            var json = await schema.ExecuteAsync(_ =>
            {
                _.Query = "{ jedis { name, side } }";
            });

            Console.WriteLine(json);

        }

        /*static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }*/
    }
}
