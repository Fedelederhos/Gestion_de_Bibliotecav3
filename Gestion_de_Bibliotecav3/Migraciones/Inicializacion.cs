using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_de_Bibliotecav3.Migraciones
{
    public partial class Inicializacion// : DbMigration
    {
        /*
        public override void Up()
        {
            CreateTable(
                "dbo.Prestamo",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    FechaEntrega = c.DateTime(nullable: false),
                    FechaVencimiento = c.DateTime(nullable: false),
                    FechaDevolucion = c.DateTime(nullable: true),
                    UsuarioID = c.Int(nullable: false),
                    EjemplarID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Usuario", t => t.UsuarioID, cascadeDelete: true)
                .ForeignKey("dbo.Ejemplar", t => t.EjemplarID, cascadeDelete: true)
                .Index(t => t.UsuarioID)
                .Index(t => t.EjemplarID);

            CreateTable(
                "dbo.Usuario",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    DNI = c.Int(nullable: false),
                    Nombre = c.String(nullable: false, maxLength: 50),
                    Score = c.Int(nullable: false),
                    Direccion = c.String(nullable: false, maxLength: 100),
                    Telefono = c.Int(nullable: false),
                    Email = c.String(nullable: false, maxLength: 50),
                    LibrosPrestados = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Ejemplar",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Codigo = c.Int(nullable: false),
                    FechaAlta = c.DateTime(nullable: false),
                    FechaBaja = c.DateTime(nullable: true),
                    Disponibilidad = c.Boolean(nullable: false),
                    LibroID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Libro", t => t.LibroID, cascadeDelete: true)
                .Index(t => t.LibroID);

            CreateTable(
                "dbo.Editorial",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Nombre = c.String(nullable: false),
                    Direccion = c.String(nullable: false),
                    Telefono = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Libro",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    ISBN = c.String(nullable: false),
                    Nombre = c.String(nullable: false),
                    FechaPublicacion = c.DateTime(nullable: false),
                    EditorialID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Editorial", t => t.EditorialID, cascadeDelete: true)
                .Index(t => t.EditorialID);

            CreateTable(
                "dbo.Autor",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Nombre = c.String(nullable: false),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Categoria",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    Nombre = c.String(nullable: false),
                })
                .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.Libro_Autor",
                c => new
                {
                    LibroID = c.Int(nullable: false),
                    AutorID = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.LibroID, t.AutorID })
                .ForeignKey("dbo.Libro", t => t.LibroID, cascadeDelete: true)
                .ForeignKey("dbo.Autor", t => t.AutorID, cascadeDelete: true)
                .Index(t => t.LibroID)
                .Index(t => t.AutorID);

            CreateTable(
                "dbo.Libro_Categoria",
                c => new
                {
                    LibroID = c.Int(nullable: false),
                    CategoriaID = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.LibroID, t.CategoriaID })
                .ForeignKey("dbo.Libro", t => t.LibroID, cascadeDelete: true)
                .ForeignKey("dbo.Categoria", t => t.CategoriaID, cascadeDelete: true)
                .Index(t => t.LibroID)
                .Index(t => t.CategoriaID);

            CreateTable(
                "dbo.Notificacion",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    FechaHoraEnvio = c.DateTime(nullable: false),
                    PrestamoID = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Prestamo", t => t.PrestamoID, cascadeDelete: true)
                .Index(t => t.PrestamoID);
        }

        
        public override void Down()
        {
            DropForeignKey("dbo.Notificacion", "PrestamoID", "dbo.Prestamo");
            DropForeignKey("dbo.Libro_Categoria", "CategoriaID", "dbo.Categoria");
            DropForeignKey("dbo.Libro_Categoria", "LibroID", "dbo.Libro");
            DropForeignKey("dbo.Libro_Autor", "AutorID", "dbo.Autor");
            DropForeignKey("dbo.Libro_Autor", "LibroID", "dbo.Libro");
            DropForeignKey("dbo.Libro", "EditorialID", "dbo.Editorial");
            DropForeignKey("dbo.Ejemplar", "LibroID", "dbo.Libro");
            DropForeignKey("dbo.Prestamo", "UsuarioID", "dbo.Usuario");
            DropIndex("dbo.Notificacion", new[] { "PrestamoID" });
            DropIndex("dbo.Libro_Categoria", new[] { "CategoriaID" });
            DropIndex("dbo.Libro_Categoria", new[] { "LibroID" });
            DropIndex("dbo.Libro_Autor", new[] { "AutorID" });
            DropIndex("dbo.Libro_Autor", new[] { "LibroID" });
            DropIndex("dbo.Libro", new[] { "EditorialID" });
            DropIndex("dbo.Ejemplar", new[] { "LibroID" });
            DropIndex("dbo.Prestamo", new[] { "UsuarioID" });
            DropTable("dbo.Notificacion");
            DropTable("dbo.Libro_Categoria");
            DropTable("dbo.Libro_Autor");
            DropTable("dbo.Categoria");
            DropTable("dbo.Autor");
            DropTable("dbo.Libro");
            DropTable("dbo.Editorial");
            DropTable("dbo.Ejemplar");
            DropTable("dbo.Usuario");
            DropTable("dbo.Prestamo");
        }
    */
    }
}
