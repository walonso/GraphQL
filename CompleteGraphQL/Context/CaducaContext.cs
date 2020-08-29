using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CompleteGraphQL
{

    public class CaducaFactory : IDesignTimeDbContextFactory<CaducaContext>
    {
        public CaducaContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CaducaContext>();
            optionsBuilder.UseSqlServer("Server=(local)\\SQLEXPRESS;Database=Graphdb;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new CaducaContext(optionsBuilder.Options);
        }
    }

public class CaducaContext : DbContext
{
    public CaducaContext(DbContextOptions<CaducaContext> options) : base(options)
        {
        }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Otras configuraciones
        modelBuilder.ApplyConfiguration(new CaducidadConfiguration());
     }
     public virtual DbSet<Caducidad> Caducidad { get; set; }
     public virtual DbSet<Producto> Producto { get; set; }
     public virtual DbSet<Cliente> Cliente { get; set; }
}
}