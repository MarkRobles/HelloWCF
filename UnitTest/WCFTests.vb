Imports Data
Imports Entities
Imports HelloWCF
Imports Moq
Imports NUnit.Framework

Namespace UnitTest

    Public Class WCFTests



        <SetUp>
        Public Sub Setup()
        End Sub

        <Test>
        Public Sub ProbarObtenerMarcas()
            Dim mockMarcaRepositorio As New Mock(Of IMarcasRepositorio)  'Crear una version testeable de IMarcaRepository

            'Crear fake entities
            Dim marcas As New List(Of Marca)
            Dim marca As New Marca
            marca.DescripcionCorta = "d"
            marca.DescripcionLarga = "dell"
            marca.Margen = 0.16
            marca.VisibilidadPrecio = True
            marca.Slogan = "come on"
            marcas.Add(marca)

            marca.DescripcionCorta = "b"
            marca.DescripcionLarga = "benq"
            marca.Margen = 0.1
            marca.VisibilidadPrecio = False
            marca.Slogan = "come in"
            marcas.Add(marca)

            'Configurar mock para que cuando se invoque ObtenerMarcas, retorne la lista harcodeada de marcas
            mockMarcaRepositorio.Setup(Function(obj) obj.ObtenerMarcas()).Returns(marcas)

            Dim AliveIdeaService As IAliveIdeaService = New AliveIdeaService(mockMarcaRepositorio.Object)

            Dim marcasResult = AliveIdeaService.ObtenerMarcas()

            Assert.IsTrue(marcasResult.Count > 0)

        End Sub

    End Class

End Namespace