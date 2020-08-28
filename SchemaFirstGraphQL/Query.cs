using GraphQL;
using System.Collections.Generic;
using System.Linq;

//class Query. It now has the responsibility to handle anything inside of Query in our schema, which means it needs to handle hello and jedis. 
namespace SchemaFirstGraphQL
{
public class Query 
{
    [GraphQLMetadata("jedi")]
    public Jedi GetJedi(int id)
    {
        return StarWarsDB.GetJedis().SingleOrDefault(j => j.Id == id);
    }

    [GraphQLMetadata("jedis")]
    public IEnumerable<Jedi> GetJedis() 
    {
        return StarWarsDB.GetJedis();
    }

    [GraphQLMetadata("hello")]
    public string GetHello() 
    {
        return "Hello Query class";
    }
}
}