Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Data.Entity.ModelConfiguration.Conventions
Imports System.Linq
Imports Entities


Namespace Data
    Public Class AliveIdeaDbContext
        Inherits DbContext
        Public Sub New()
            MyBase.New("name=AliveIdeaDbContext")
            Database.SetInitializer(Of AliveIdeaDbContext)(Nothing)
        End Sub

        Public Property Marcas As DbSet(Of Marca)


        Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
            modelBuilder.Conventions.Remove(Of PluralizingTableNameConvention)()
            modelBuilder.Conventions.Remove(Of OneToManyCascadeDeleteConvention)()


        End Sub
    End Class
End Namespace
