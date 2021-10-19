Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class test
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Marca",
                Function(c) New With
                    {
                        .MarcaId = c.Int(nullable := False, identity := True),
                        .DescripcionCorta = c.String(),
                        .DescripcionLarga = c.String(),
                        .VisibilidadPrecio = c.Boolean(nullable := False),
                        .Margen = c.Decimal(nullable := False, precision := 18, scale := 2),
                        .Slogan = c.String()
                    }) _
                .PrimaryKey(Function(t) t.MarcaId)
            
        End Sub
        
        Public Overrides Sub Down()
            DropTable("dbo.Marca")
        End Sub
    End Class
End Namespace
