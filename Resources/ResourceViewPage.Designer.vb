﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class ResourceViewPage
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Truck_Out_Order.ResourceViewPage", GetType(ResourceViewPage).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Cancel.
        '''</summary>
        Friend Shared ReadOnly Property btnCancel() As String
            Get
                Return ResourceManager.GetString("btnCancel", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Export To Excel.
        '''</summary>
        Friend Shared ReadOnly Property btnExport() As String
            Get
                Return ResourceManager.GetString("btnExport", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Search.
        '''</summary>
        Friend Shared ReadOnly Property btnSearch() As String
            Get
                Return ResourceManager.GetString("btnSearch", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Cargo Weight Checking.
        '''</summary>
        Friend Shared ReadOnly Property itemCargo() As String
            Get
                Return ResourceManager.GetString("itemCargo", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ISO Tank.
        '''</summary>
        Friend Shared ReadOnly Property itemISO() As String
            Get
                Return ResourceManager.GetString("itemISO", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Security Post Completed.
        '''</summary>
        Friend Shared ReadOnly Property itemSecurity() As String
            Get
                Return ResourceManager.GetString("itemSecurity", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Shipping Post Completed.
        '''</summary>
        Friend Shared ReadOnly Property itemShipping() As String
            Get
                Return ResourceManager.GetString("itemShipping", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Warehouse Post Completed.
        '''</summary>
        Friend Shared ReadOnly Property itemWarehouse() As String
            Get
                Return ResourceManager.GetString("itemWarehouse", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Completed Post Between.
        '''</summary>
        Friend Shared ReadOnly Property stringCompletedPostBetween() As String
            Get
                Return ResourceManager.GetString("stringCompletedPostBetween", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Net Cargo Weight Checking Post Between.
        '''</summary>
        Friend Shared ReadOnly Property stringNetCargoBetween() As String
            Get
                Return ResourceManager.GetString("stringNetCargoBetween", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please Select The Post Option.
        '''</summary>
        Friend Shared ReadOnly Property stringPleaseSelect() As String
            Get
                Return ResourceManager.GetString("stringPleaseSelect", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to You Have No Privilege To View This Number.
        '''</summary>
        Friend Shared ReadOnly Property stringPrivilege() As String
            Get
                Return ResourceManager.GetString("stringPrivilege", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Search Error.
        '''</summary>
        Friend Shared ReadOnly Property stringSearchError() As String
            Get
                Return ResourceManager.GetString("stringSearchError", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to SELECT ID as &apos;Truck Out Number&apos;,ORIGIN as &apos;Company&apos;,INVOICE as &apos;Invoice&apos;,CONTAINER_NO as &apos;Container No&apos;, warehouse.ES_SEAL_NO as &apos;Es Seal No&apos;,LINER_SEA_NO as &apos;Liner Seal No&apos;, INTERNAL_SEAL_NO as &apos;Internal Seal No&apos;, TEMPORARY_SEAL_NO as &apos;Temporary Seal No&apos;, shipping.COMPANY as &apos;Send To Company&apos;,Container_Size as &apos;Container Size&apos;,Shipping.Net_Cargo_Weight as &apos;Net Cargo Weight&apos; , Security.Cargo_Weight_Check_Value as &apos;Net Cargo Weight Checking Value&apos;, CASE WHEN Cargo_Weight_Check = 1 Then &apos;Pass&apos; else &apos;Failed&apos; E [rest of string was truncated]&quot;;.
        '''</summary>
        Friend Shared ReadOnly Property stringSelectString() As String
            Get
                Return ResourceManager.GetString("stringSelectString", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to SELECT ID as &apos;Truck Out Number&apos;,ORIGIN as &apos;Company&apos;,INVOICE as &apos;Invoice&apos;,CONTAINER_NO as &apos;Container No&apos;, warehouse.ES_SEAL_NO as &apos;Es Seal No&apos;,LINER_SEA_NO as &apos;Liner Seal No&apos;, INTERNAL_SEAL_NO as &apos;Internal Seal No&apos;, TEMPORARY_SEAL_NO as &apos;Temporary Seal No&apos;, shipping.COMPANY as &apos;Send To Company&apos;,Container_Size as &apos;Container Size&apos;, LOADING_PORT as &apos;Loading Port&apos;,HAULIER as &apos;Haulier&apos;,PRODUCT as &apos;Product&apos;,SHIPMENT_CLOSING_DATE as &apos;Shipment Closing Date&apos;,SHIPMENT_CLOSING_TIME as &apos;Shipment Closing Time&apos;,DDB,.
        '''</summary>
        Friend Shared ReadOnly Property stringSelectStringNormal() As String
            Get
                Return ResourceManager.GetString("stringSelectStringNormal", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Save File Successfully.
        '''</summary>
        Friend Shared ReadOnly Property stringSuccess() As String
            Get
                Return ResourceManager.GetString("stringSuccess", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to There Are.
        '''</summary>
        Friend Shared ReadOnly Property stringThereAre() As String
            Get
                Return ResourceManager.GetString("stringThereAre", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
