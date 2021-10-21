
Imports System.ComponentModel.DataAnnotations
Imports System.Runtime.Serialization

<DataContract()>
Public Class Marca



    Private Id As Integer
    <Key>
    <DataMember(Name:="Id", IsRequired:=True)>'El atributo DataMember se puede omitir y aun asi funjciona pero tienes menos control para personalizarlo.
    Public Property MarcaId() As Integer
        Get
            Return Id
        End Get
        Set(ByVal value As Integer)
            Id = value
        End Set
    End Property


    Private P_DescripcionCorta As String
    <DataMember(Name:="DescripcionCorta", IsRequired:=True)>
    Public Property DescripcionCorta() As String
        Get
            Return P_DescripcionCorta
        End Get
        Set(ByVal value As String)
            P_DescripcionCorta = value
        End Set
    End Property



    Private P_DescripcionLarga As String
    <DataMember(Name:="DescripcionLarga", IsRequired:=True)>
    Public Property DescripcionLarga() As String
        Get
            Return P_DescripcionLarga
        End Get
        Set(ByVal value As String)
            P_DescripcionLarga = value
        End Set
    End Property


    Private P_VisibilidadPrecio As Boolean
    <DataMember(Name:="VisibilidadPrecio", IsRequired:=True)>
    Public Property VisibilidadPrecio() As Boolean
        Get
            Return P_VisibilidadPrecio
        End Get
        Set(ByVal value As Boolean)
            P_VisibilidadPrecio = value
        End Set
    End Property

    Private P_Margen As Decimal
    <DataMember(Name:="Margen")>
    Public Property Margen() As Decimal
        Get
            Return P_Margen
        End Get
        Set(ByVal value As Decimal)
            P_Margen = value
        End Set
    End Property

    Private P_Slogan As String
    <DataMember(Name:="Slogan")>
    Public Property Slogan() As String
        Get
            Return P_Slogan
        End Get
        Set(ByVal value As String)
            P_Slogan = value
        End Set
    End Property

End Class
