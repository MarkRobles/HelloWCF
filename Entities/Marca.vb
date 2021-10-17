
Imports System.ComponentModel.DataAnnotations
Imports System.Runtime.Serialization

<DataContract()>
Public Class Marca



    Private MarcaId As Integer
    <Key>
    <DataMember(Name:="Id", IsRequired:=True)>'El atributo DataMember se puede omitir y aun asi funjciona pero tienes menos control para personalizarlo.
    Public Property P_MarcaId() As Integer
        Get
            Return MarcaId
        End Get
        Set(ByVal value As Integer)
            MarcaId = value
        End Set
    End Property


    Private DescripcionCorta As String
    <DataMember(Name:="DescripcionCorta", IsRequired:=True)>
    Public Property P_DescripcionCorta() As String
        Get
            Return DescripcionCorta
        End Get
        Set(ByVal value As String)
            DescripcionCorta = value
        End Set
    End Property



    Private DescripcionLarga As String
    <DataMember(Name:="DescripcionLarga", IsRequired:=True)>
    Public Property P_DescripcionLarga() As String
        Get
            Return DescripcionLarga
        End Get
        Set(ByVal value As String)
            DescripcionLarga = value
        End Set
    End Property


    Private VisibilidadPrecio As Boolean
    <DataMember(Name:="VisibilidadPrecio", IsRequired:=True)>
    Public Property P_VisibilidadPrecio() As Boolean
        Get
            Return VisibilidadPrecio
        End Get
        Set(ByVal value As Boolean)
            VisibilidadPrecio = value
        End Set
    End Property

    Private Margen As Decimal
    <DataMember(Name:="Margen")>
    Public Property P_Margen() As Decimal
        Get
            Return Margen
        End Get
        Set(ByVal value As Decimal)
            Margen = value
        End Set
    End Property

    Private Slogan As String
    <DataMember(Name:="Slogan")>
    Public Property P_Slogan() As String
        Get
            Return Slogan
        End Get
        Set(ByVal value As String)
            Slogan = value
        End Set
    End Property

End Class
