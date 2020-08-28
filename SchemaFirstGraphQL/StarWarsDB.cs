
//bd 
using System.Collections.Generic;

namespace SchemaFirstGraphQL
{
public class StarWarsDB 
{
    /*public static IEnumerable<Jedi> GetJedis() {
        return new List<Jedi>() {
            new Jedi(){ Name ="Luke", Side="Light"},
            new Jedi(){ Name ="Yoda", Side="Light"},
            new Jedi(){ Name ="Darth Vader", Side="Dark"}
        };
    }*/

    public static IEnumerable<Jedi> GetJedis() {
        return new List<Jedi>() {
            new Jedi(){ Id=1, Name ="Luke", Side="Light"},
            new Jedi(){ Id=2,Name ="Yoda", Side="Light"},
            new Jedi(){ Id=3,Name ="Darth Vader", Side="Dark"}
        };
    }
}
}