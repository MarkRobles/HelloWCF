﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace AliveIdeaService
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="AliveIdeaService.IAliveIdeaService")>  _
    Public Interface IAliveIdeaService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IAliveIdeaService/ObtenerMarcas", ReplyAction:="http://tempuri.org/IAliveIdeaService/ObtenerMarcasResponse")>  _
        Function ObtenerMarcas() As System.Collections.ObjectModel.ObservableCollection(Of Contracts.Marca)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IAliveIdeaService/ObtenerMarcas", ReplyAction:="http://tempuri.org/IAliveIdeaService/ObtenerMarcasResponse")>  _
        Function ObtenerMarcasAsync() As System.Threading.Tasks.Task(Of System.Collections.ObjectModel.ObservableCollection(Of Contracts.Marca))
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IAliveIdeaService/CrearMarca", ReplyAction:="http://tempuri.org/IAliveIdeaService/CrearMarcaResponse")>  _
        Function CrearMarca(ByVal marca As Contracts.Marca) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IAliveIdeaService/CrearMarca", ReplyAction:="http://tempuri.org/IAliveIdeaService/CrearMarcaResponse")>  _
        Function CrearMarcaAsync(ByVal marca As Contracts.Marca) As System.Threading.Tasks.Task(Of Integer)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IAliveIdeaServiceChannel
        Inherits AliveIdeaService.IAliveIdeaService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class AliveIdeaServiceClient
        Inherits System.ServiceModel.ClientBase(Of AliveIdeaService.IAliveIdeaService)
        Implements AliveIdeaService.IAliveIdeaService
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function ObtenerMarcas() As System.Collections.ObjectModel.ObservableCollection(Of Contracts.Marca) Implements AliveIdeaService.IAliveIdeaService.ObtenerMarcas
            Return MyBase.Channel.ObtenerMarcas
        End Function
        
        Public Function ObtenerMarcasAsync() As System.Threading.Tasks.Task(Of System.Collections.ObjectModel.ObservableCollection(Of Contracts.Marca)) Implements AliveIdeaService.IAliveIdeaService.ObtenerMarcasAsync
            Return MyBase.Channel.ObtenerMarcasAsync
        End Function
        
        Public Function CrearMarca(ByVal marca As Contracts.Marca) As Integer Implements AliveIdeaService.IAliveIdeaService.CrearMarca
            Return MyBase.Channel.CrearMarca(marca)
        End Function
        
        Public Function CrearMarcaAsync(ByVal marca As Contracts.Marca) As System.Threading.Tasks.Task(Of Integer) Implements AliveIdeaService.IAliveIdeaService.CrearMarcaAsync
            Return MyBase.Channel.CrearMarcaAsync(marca)
        End Function
    End Class
End Namespace
