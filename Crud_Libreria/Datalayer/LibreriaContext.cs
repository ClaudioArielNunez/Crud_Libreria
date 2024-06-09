using Crud_Libreria.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Crud_Libreria.Datalayer
{
    public class LibreriaContext : DbContext
    {
        public LibreriaContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        //Este metodo se utiliza para configurar el modelo de datos mediante el ModelBuilder
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Llama al método OnModelCreating de la clase base
            base.OnModelCreating(modelBuilder);

            // Configura la entidad Categoria para que tenga un índice único en la columna Nombre, lo que significa que no puede haber dos registros en la tabla Categoria con el mismo valor en la columna Nombre.
            modelBuilder.Entity<Categoria>().HasIndex(c => c.Nombre).IsUnique();
        }
    }
}
