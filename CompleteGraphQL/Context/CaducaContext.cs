using Microsoft.EntityFrameworkCore;

namespace CompleteGraphQL
{
public class CaducaContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Otras configuraciones
        modelBuilder.ApplyConfiguration(new CaducidadConfiguration());
     }
     public virtual DbSet<Caducidad> Caducidad { get; set; }
}
}