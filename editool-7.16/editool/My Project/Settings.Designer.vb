﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.42000
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Fonctionnalité Enregistrement automatique My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("123456789987")>  _
        Public Property testP() As String
            Get
                Return CType(Me("testP"),String)
            End Get
            Set
                Me("testP") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("fr")>  _
        Public Property PrefLang() As String
            Get
                Return CType(Me("PrefLang"),String)
            End Get
            Set
                Me("PrefLang") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("FR Ø[D] [NoTT]z Lc[L] Lu[CTS_AL]")>  _
        Public Property NameMask() As String
            Get
                Return CType(Me("NameMask"),String)
            End Get
            Set
                Me("NameMask") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property ToolType() As String
            Get
                Return CType(Me("ToolType"),String)
            End Get
            Set
                Me("ToolType") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("FR Ø[D] [NoTT]z Lc[L] Lu[CTS_AL]")>  _
        Public Property MaskTT_FR() As String
            Get
                Return CType(Me("MaskTT_FR"),String)
            End Get
            Set
                Me("MaskTT_FR") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("FT Ø[D] r[r] [NoTT]z Lc[L] Lu[CTS_AL]")>  _
        Public Property MaskTT_FT() As String
            Get
                Return CType(Me("MaskTT_FT"),String)
            End Get
            Set
                Me("MaskTT_FT") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("FB Ø[D] [NoTT]z Lc[L] Lu[CTS_AL]")>  _
        Public Property MaskTT_FB() As String
            Get
                Return CType(Me("MaskTT_FB"),String)
            End Get
            Set
                Me("MaskTT_FB") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("FP Ø[D] [NoTT]z Lc[L]")>  _
        Public Property MaskTT_FOC9() As String
            Get
                Return CType(Me("MaskTT_FOC9"), String)
            End Get
            Set
                Me("MaskTT_FP") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("FO Ø[D] [NoTT]z Lc[L]")>  _
        Public Property MaskTT_FOCA() As String
            Get
                Return CType(Me("MaskTT_FOCA"), String)
            End Get
            Set
                Me("MaskTT_FO") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MaskTT_AL() As String
            Get
                Return CType(Me("MaskTT_AL"),String)
            End Get
            Set
                Me("MaskTT_AL") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("")>
        Public Property lastPath() As String
            Get
                Return CType(Me("lastPath"),String)
            End Get
            Set
                Me("lastPath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("c:/missler/config/database/tools/")>  _
        Public Property V6_default_path() As String
            Get
                Return CType(Me("V6_default_path"),String)
            End Get
            Set
                Me("V6_default_path") = value
            End Set
        End Property

        Public Property DefManuf As Object
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.editool.My.MySettings
            Get
                Return Global.editool.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
