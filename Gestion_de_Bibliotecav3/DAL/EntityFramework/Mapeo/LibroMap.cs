using Gestion_de_Bibliotecav3.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework.Mapeo
{
    public class LibroMap
    {
        private ModelBuilder modelBuilder;

        public DbSet<Libro> libros { get; set; }
        public DbSet<Autor> autores { get; set; }

        public LibroMap(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void MapClass()
        {
            modelBuilder.Entity<Libro>(entity =>
            {
                entity.HasKey(libro => libro.ID);
                entity.Property(libro => libro.ID)
                      .ValueGeneratedOnAdd();
                entity.Property(libro => libro.ISBN)
                      .IsRequired();
                entity.Property(libro => libro.Nombre)
                      .IsRequired();
                entity.Property(libro => libro.FechaPublicacion)
                      .IsRequired();
                entity.HasMany(libro => libro.Autores)
                      .WithMany(autor => autor.Libros)
                      .UsingEntity<Dictionary<string, object>>( //ManyToMany
                        "Libro_Autor",
                        j => j.HasOne<Autor>().WithMany().HasForeignKey("AutorID"),
                        j => j.HasOne<Libro>().WithMany().HasForeignKey("LibroID"),
                        j =>
                        {
                            j.Property<int>("Libro_AutorID");
                            j.HasKey("Libro_AutorID");
                            j.HasIndex("LibroID", "AutorID").IsUnique();
                            j.ToTable("Libro_Autor");
                        }
                        );
                entity.HasMany(libro => libro.Categorias)
                      .WithMany(categoria => categoria.Libros)
                      .UsingEntity<Dictionary<string, object>>(
                        "Libro_Categoria",
                        j => j.HasOne<Categoria>().WithMany().HasForeignKey("CategoriaID"),
                        j => j.HasOne<Libro>().WithMany().HasForeignKey("LibroID"),
                        j =>
                        {
                            j.Property<int>("Libro_CategoriaID");
                            j.HasKey("Libro_CategoriaID");
                            j.HasIndex("LibroID", "CategoriaID").IsUnique();
                            j.ToTable("Libro_Categoria");
                        }
                      );
            });



            /*
            this.HasKey(libro => libro.ID);

            this.Property(libro => libro.ID)
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(libro => libro.ISBN)
                .IsRequired();

            this.Property(libro => libro.Nombre)
                .IsRequired();

            this.Property(libro => libro.FechaPublicacion)
                .IsRequired();

            this.HasRequired(libro => libro.Editorial)
                .WithMany()
                .HasForeignKey(libro => libro.Editorial.ID);

            this.HasMany(libro => libro.Libro_Autor)
                .WithMany()
                .Map(m =>
                {
                    m.MapLeftKey("LibroID");
                    m.MapRightKey("AutorID");
                    m.ToTable("Libro_Autor");
                });
            */
        }
    }
}

