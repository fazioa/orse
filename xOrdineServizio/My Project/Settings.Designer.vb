﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.4961
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
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
         Global.System.Configuration.DefaultSettingValueAttribute("IL COMANDANTE")>  _
        Public Property GruppoFirmaRiga1() As String
            Get
                Return CType(Me("GruppoFirmaRiga1"),String)
            End Get
            Set
                Me("GruppoFirmaRiga1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("(Mar.Ca.Xxxxx Xxxxx)")>  _
        Public Property GruppoFirmaRiga2() As String
            Get
                Return CType(Me("GruppoFirmaRiga2"),String)
            End Get
            Set
                Me("GruppoFirmaRiga2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Stazione Carabinieri di Xxxxxxxxxx")>  _
        Public Property comando() As String
            Get
                Return CType(Me("comando"),String)
            End Get
            Set
                Me("comando") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Santa Maria a Monte (PI)")>  _
        Public Property comune() As String
            Get
                Return CType(Me("comune"),String)
            End Get
            Set
                Me("comune") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dbAlegatoA.mdb")>  _
        Public ReadOnly Property dbAlegatoAConnectionString() As String
            Get
                Return CType(Me("dbAlegatoAConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("IL COMANDANTE int.")>  _
        Public Property GruppoFirmaInterinaleRiga1() As String
            Get
                Return CType(Me("GruppoFirmaInterinaleRiga1"),String)
            End Get
            Set
                Me("GruppoFirmaInterinaleRiga1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("(Mar.Xxxxx Xxxxx)")>  _
        Public Property GruppoFirmaInterinaleRiga2() As String
            Get
                Return CType(Me("GruppoFirmaInterinaleRiga2"),String)
            End Get
            Set
                Me("GruppoFirmaInterinaleRiga2") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property protocolloOP85() As String
            Get
                Return CType(Me("protocolloOP85"),String)
            End Get
            Set
                Me("protocolloOP85") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("AL COMANDO STAZIONE CARABINIERI")>  _
        Public Property prefissoIndirizzoStazioneCC() As String
            Get
                Return CType(Me("prefissoIndirizzoStazioneCC"),String)
            End Get
            Set
                Me("prefissoIndirizzoStazioneCC") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("LEGIONE CARABINIERI TOSCANA")>  _
        Public Property regione() As String
            Get
                Return CType(Me("regione"),String)
            End Get
            Set
                Me("regione") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2.51")>  _
        Public Property versioneDB() As String
            Get
                Return CType(Me("versioneDB"),String)
            End Get
            Set
                Me("versioneDB") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://www.toppolino.it/listing/orse")>  _
        Public Property urlAggiornamenti() As String
            Get
                Return CType(Me("urlAggiornamenti"),String)
            End Get
            Set
                Me("urlAggiornamenti") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("http://www.toppolino.it/orse/wp-content/plugins/download-monitor/download.php?id="& _ 
            "5")>  _
        Public Property linkDownloadNuovaVersione() As String
            Get
                Return CType(Me("linkDownloadNuovaVersione"),String)
            End Get
            Set
                Me("linkDownloadNuovaVersione") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Paragrafo 9 - Interventi")>  _
        Public Property descrizioneParagrafoInterventi() As String
            Get
                Return CType(Me("descrizioneParagrafoInterventi"),String)
            End Get
            Set
                Me("descrizioneParagrafoInterventi") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Paragrafo 6 - Informazioni")>  _
        Public Property descrizioneParagrafoInformazioni() As String
            Get
                Return CType(Me("descrizioneParagrafoInformazioni"),String)
            End Get
            Set
                Me("descrizioneParagrafoInformazioni") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property display_reportPrimaPagina() As Boolean
            Get
                Return CType(Me("display_reportPrimaPagina"),Boolean)
            End Get
            Set
                Me("display_reportPrimaPagina") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property ComandanteTitolare() As Boolean
            Get
                Return CType(Me("ComandanteTitolare"),Boolean)
            End Get
            Set
                Me("ComandanteTitolare") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public ReadOnly Property altezzaRigaDivisioneRigheDataGrigInterventi_IntervalliLiberi() As Integer
            Get
                Return CType(Me("altezzaRigaDivisioneRigheDataGrigInterventi_IntervalliLiberi"),Integer)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property dataUltimaEsportazioneDati() As Date
            Get
                Return CType(Me("dataUltimaEsportazioneDati"),Date)
            End Get
            Set
                Me("dataUltimaEsportazioneDati") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("5")>  _
        Public Property intervalloSalvataggioAutomatico() As String
            Get
                Return CType(Me("intervalloSalvataggioAutomatico"),String)
            End Get
            Set
                Me("intervalloSalvataggioAutomatico") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("576")>  _
        Public Property formHeight() As String
            Get
                Return CType(Me("formHeight"),String)
            End Get
            Set
                Me("formHeight") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("1040")>  _
        Public Property formWidth() As String
            Get
                Return CType(Me("formWidth"),String)
            End Get
            Set
                Me("formWidth") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.OrSe.My.MySettings
            Get
                Return Global.OrSe.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
