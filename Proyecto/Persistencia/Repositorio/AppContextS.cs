using Microsoft.EntityFrameworkCore;
using Proyecto.Dominio;

namespace Proyecto.Persistencia
{
    public class AppContextS : DbContext
    {
        //Es un objeto que le pertenece al context que me permite modelar la base de datos

        //<establecimiento> es el nombre de la tabla que tengo en dominio
        //Establecimientos= es el nuevo nombre que va a tener mi tabla en la base de datos

        public DbSet<Establecimientos> Establecimientos {get;set;}
        public DbSet<Manzanas> Manzanas{get;set;}
        public DbSet<UsuarioMujeres> UsuarioMujeres {get;set;}
        public DbSet<Municipios> Municipios {get;set;}
        public DbSet<Registro_Cuidadora> Registro_Cuidadoras {get;set;}
        public DbSet<Servicios> Servicios {get;set;}

    // el void es un metodo vacío que sirve para la conexion a la base de datos.
        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.
                UseSqlServer("Data source=(localdb)\\MSSQLLocalDB; Initial Catalog=AppS");
            }

        }

    }

}