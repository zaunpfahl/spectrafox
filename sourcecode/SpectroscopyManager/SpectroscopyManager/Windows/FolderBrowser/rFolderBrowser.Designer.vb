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
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class rFolderBrowser
        
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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SpectroscopyManager.rFolderBrowser", GetType(rFolderBrowser).Assembly)
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
        '''  Looks up a localized string similar to The path you entered is invalid!
        '''Please check and try again..
        '''</summary>
        Friend Shared ReadOnly Property Error_PathInvalid() As String
            Get
                Return ResourceManager.GetString("Error_PathInvalid", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to invalid path.
        '''</summary>
        Friend Shared ReadOnly Property Error_PathInvalid_Title() As String
            Get
                Return ResourceManager.GetString("Error_PathInvalid_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to no items in current folder.
        '''</summary>
        Friend Shared ReadOnly Property FolderCount_FolderEmpty() As String
            Get
                Return ResourceManager.GetString("FolderCount_FolderEmpty", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to %d Directories, %f Files.
        '''</summary>
        Friend Shared ReadOnly Property FolderCount_Status() As String
            Get
                Return ResourceManager.GetString("FolderCount_Status", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to open data-browser for ALL files in the current folder.
        '''</summary>
        Friend Shared ReadOnly Property OpenButton_CurrentFolder() As String
            Get
                Return ResourceManager.GetString("OpenButton_CurrentFolder", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to open data-browser only for SELECTED %c file/s.
        '''</summary>
        Friend Shared ReadOnly Property OpenButton_CurrentSelection() As String
            Get
                Return ResourceManager.GetString("OpenButton_CurrentSelection", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Ready.
        '''</summary>
        Friend Shared ReadOnly Property Status_Ready() As String
            Get
                Return ResourceManager.GetString("Status_Ready", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Click here to open the data browser for the current folder.
        '''
        '''You can select files if you want to open the data browser only for them.
        '''Unselect all files to scan the whole folder content for compatible files (for this just click on a blank area)..
        '''</summary>
        Friend Shared ReadOnly Property ToolTip_OpenButton() As String
            Get
                Return ResourceManager.GetString("ToolTip_OpenButton", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to loading folder contents ....
        '''</summary>
        Friend Shared ReadOnly Property UpdateNode_Status() As String
            Get
                Return ResourceManager.GetString("UpdateNode_Status", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Folder Browser - .
        '''</summary>
        Friend Shared ReadOnly Property WindowTitle_Addon() As String
            Get
                Return ResourceManager.GetString("WindowTitle_Addon", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
