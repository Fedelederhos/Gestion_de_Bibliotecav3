using Gestion_de_Bibliotecav3.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav3.DAL.EntityFramework.Mapeo
{
    public class AutorMap
    {
        private ModelBuilder modelBuilder;
        public AutorMap(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void MapClass()
        {

            modelBuilder.Entity<Autor>(entity =>
            {
                entity.HasKey(autor => autor.ID);
                entity.Property(autor => autor.ID)
                      .ValueGeneratedOnAdd();
                entity.Property(autor => autor.Nombre)
                      .IsRequired();
            });


            /*this.HasKey(autor => autor.ID);

            this.Property(autor => autor.ID)
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(autor => autor.Nombre)
                .IsRequired();*/

            /* this.HasMany(autor => autor.Libro_Autor)
                 .WithMany()
                 .Map(m =>
                 {
                     m.MapLeftKey("AutorID");
                     m.MapRightKey("LibroID");
                     m.ToTable("Libro_Autor");
                 });*/
        }
    }
}
