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
    Friend Class rSmoothing
        
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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SpectroscopyManager.rSmoothing", GetType(rSmoothing).Assembly)
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
        '''  Looks up a localized string similar to Takes the simple average value between the given number of adjacent datapoints.
        '''This filter often flattens the height and width of sharp features. E.g., for Kondo-resonances you should chose a different method..
        '''</summary>
        Friend Shared ReadOnly Property Description_AdjacentAverage() As String
            Get
                Return ResourceManager.GetString("Description_AdjacentAverage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to uses the raw data without smoothing.
        '''</summary>
        Friend Shared ReadOnly Property Description_NoSmooth() As String
            Get
                Return ResourceManager.GetString("Description_NoSmooth", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to The Savitzky–Golay smoothing filter is a type of filter first described in 1964 by Abraham Savitzky and Marcel J. E. Golay.
        '''
        '''The Savitzky–Golay method performs a local polynomial regression on a series of values to determine the smoothed value for each point.
        '''
        '''Its main advantage is that it preserve sharp features of the source data, such as relative maxima, minima and the width of these features..
        '''</summary>
        Friend Shared ReadOnly Property Description_SavitzkyGolay() As String
            Get
                Return ResourceManager.GetString("Description_SavitzkyGolay", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Adjacent Average.
        '''</summary>
        Friend Shared ReadOnly Property Name_AdjacentAverage() As String
            Get
                Return ResourceManager.GetString("Name_AdjacentAverage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to no smoothing.
        '''</summary>
        Friend Shared ReadOnly Property Name_NoSmooth() As String
            Get
                Return ResourceManager.GetString("Name_NoSmooth", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Savitzky Golay.
        '''</summary>
        Friend Shared ReadOnly Property Name_SavitzkyGolay() As String
            Get
                Return ResourceManager.GetString("Name_SavitzkyGolay", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
