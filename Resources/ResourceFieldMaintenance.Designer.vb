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
    Friend Class ResourceFieldMaintenance
        
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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Truck_Out_Order.ResourceFieldMaintenance", GetType(ResourceFieldMaintenance).Assembly)
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
        '''  Looks up a localized string similar to New.
        '''</summary>
        Friend Shared ReadOnly Property btnNew() As String
            Get
                Return ResourceManager.GetString("btnNew", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Save.
        '''</summary>
        Friend Shared ReadOnly Property btnSave() As String
            Get
                Return ResourceManager.GetString("btnSave", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Active:.
        '''</summary>
        Friend Shared ReadOnly Property lblActive() As String
            Get
                Return ResourceManager.GetString("lblActive", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please Enter The Long Name:.
        '''</summary>
        Friend Shared ReadOnly Property lblEnterLongName() As String
            Get
                Return ResourceManager.GetString("lblEnterLongName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please Enter The Short Name:.
        '''</summary>
        Friend Shared ReadOnly Property lblEnterShortName() As String
            Get
                Return ResourceManager.GetString("lblEnterShortName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please Select The Field:.
        '''</summary>
        Friend Shared ReadOnly Property lblSelectField() As String
            Get
                Return ResourceManager.GetString("lblSelectField", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Field Maintenance.
        '''</summary>
        Friend Shared ReadOnly Property lblTitle() As String
            Get
                Return ResourceManager.GetString("lblTitle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Authentication.
        '''</summary>
        Friend Shared ReadOnly Property stringAuthentification() As String
            Get
                Return ResourceManager.GetString("stringAuthentification", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Update Complete.
        '''</summary>
        Friend Shared ReadOnly Property stringComplete() As String
            Get
                Return ResourceManager.GetString("stringComplete", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Error.
        '''</summary>
        Friend Shared ReadOnly Property stringError() As String
            Get
                Return ResourceManager.GetString("stringError", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Please fill the required field.
        '''</summary>
        Friend Shared ReadOnly Property stringFillRequired() As String
            Get
                Return ResourceManager.GetString("stringFillRequired", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
