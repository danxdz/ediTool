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

Imports System

Namespace My.Resources
    
    'Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    'à l'aide d'un outil, tel que ResGen ou Visual Studio.
    'Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    'avec l'option /str ou régénérez votre projet VS.
    '''<summary>
    '''  Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("editool.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Remplace la propriété CurrentUICulture du thread actuel pour toutes
        '''  les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à File
        '''- Open
        '''- Save
        '''- Exit
        '''Tools
        '''- Mills
        '''-- End Mill
        '''-- Toroidal Mill
        '''-- Ball Nose Mill
        '''- Drilling
        '''-- Spotting Drill
        '''-- Twist Drill
        '''-- Carbide Twist Drill
        '''-- Flat Drill
        '''- Tarauds
        '''-- Tap
        '''-- Thread Milling Cutter
        '''- Alesoirs
        '''-- Constant Reamer
        '''Setup
        '''- Library source
        '''-- Default#
        '''-- Editool#
        '''- Destination library
        '''-- {customToolLib}#
        '''-- Add.
        '''</summary>
        Friend ReadOnly Property mainMenu_en() As String
            Get
                Return ResourceManager.GetString("mainMenu_en", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Fichier
        '''- Ouvrir@
        '''- Enregistrer@
        '''- Quitter@
        '''Outils
        '''- Fraises
        '''-- Fraise 2 tailles
        '''-- Fraise torique
        '''-- Fraise hémisphérique
        '''- Forets
        '''-- Foret à centrer
        '''-- Foret à pointer
        '''-- Foret hélicoïdal
        '''-- Foret hélicoïdal carbure
        '''-- Forêt à fond plat
        '''- Tarauds
        '''-- Taraud
        '''-- Fraise a fileter
        '''- Alésoirs
        '''-- Alésoir fixe
        '''Configuration
        '''- Bibliothèque source
        '''-- Default#
        '''-- Editool#
        '''- Bibliothèque de destination
        '''-- {customToolLib}#
        '''-- Ajouter.
        '''</summary>
        Friend ReadOnly Property mainMenu_fr() As String
            Get
                Return ResourceManager.GetString("mainMenu_fr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Ficheiro
        '''- Abrir
        '''- Guardar
        '''- Sair
        '''Ferramentas
        '''- Fresas
        '''-- Fresa de topo
        '''-- Fresa raionada
        '''-- Fresa esférica
        '''- Brocas
        '''-- Broca de centrar
        '''-- Broca de ponto
        '''-- Broca helicoidal
        '''-- Broca helicoidal de carboneto
        '''-- Broca fundo pla
        '''- Roscas
        '''-- Macho
        '''-- Fresa para roscas
        '''- Mandril
        '''-- Mandril fixo
        '''Configuração
        '''- Biblioteca fonte
        '''-- Default#
        '''-- Editool#
        '''- Biblioteca de destino
        '''-- {customToolLib}#
        '''-- Adicionar .
        '''</summary>
        Friend ReadOnly Property mainMenu_pt() As String
            Get
                Return ResourceManager.GetString("mainMenu_pt", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à tool name
        '''rayon
        '''angle
        '''teeth num
        '''cutting diameter
        '''clearance diameter
        '''body diameter
        '''cutting length
        '''clearance length
        '''overall length
        '''force name
        '''open tool
        '''create tool
        '''config
        '''reference
        '''cutting diameter
        '''check-in.
        '''</summary>
        Friend ReadOnly Property menu_en() As String
            Get
                Return ResourceManager.GetString("menu_en", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à 1;FR2T;Fraise 2 tailles;Side Mill D20 L35 SD20
        '''2;FRTO;Fraise torique;Radiused Mill D16 L40 r3 SD16
        '''3;FRHE;Fraise hémisphérique;Ball Nose Mill D8 L30 SD8
        '''4;FOP9;Foret a pointer;Spotting Drill D10 SD10
        '''5;FOCA;Foret hélicoïdal;Twisted Drill D10 L35 SD10
        '''6;ALFI;Alesoir fixe;Constant Reamer D10 L20 SD9
        '''7;TAR;Taraud
        '''8;FRTB;Fraise à tourbillonner.
        '''</summary>
        Friend ReadOnly Property menu_en_tooltypes() As String
            Get
                Return ResourceManager.GetString("menu_en_tooltypes", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à nom outil
        '''rayon
        '''angle
        '''n. de dents
        '''diamètre de coupe
        '''diamètre détalonné
        '''diamètre corps
        '''longueur de coupe
        '''longueur détalonné
        '''longueur total
        '''force nom
        '''ouvrir outil
        '''créer outil
        '''config
        '''référence
        '''diamètre de coupe
        '''mettre au coffre.
        '''</summary>
        Friend ReadOnly Property menu_fr() As String
            Get
                Return ResourceManager.GetString("menu_fr", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à 15232120;1.5;6;0;38;3;0;11.5;3
        '''15232140;2;6;0;38;3;0;11;3
        '''15232160;2.5;6;0;38;3;0;10;3
        '''15232180;3;6;0;38;4;0;8;3
        '''15232200;3.5;6;0;38;4;0;7;3
        '''15232220;4;6;0;38;5;0;5.5;3
        '''15232240;4.5;6;0;38;5;0;4.5;3
        '''15232260;5;6;0;38;6;0;3;3
        '''15232300;6;6;0;38;7;0;0;3
        '''15232391;8;8;0;41;9;0;0;3
        '''15232450;10;10;0;48;11;0;0;3
        '''15520140;2;6;1.9;57;7;10;7;2
        '''15520180;3;6;2.8;57;8;14;4.5;2
        '''15520220;4;6;3.7;57;11;16;3;2
        '''15520260;5;6;4.6;57;13;18;1.5;2
        '''15520300;6;6;5.5;57;13;20;0;2
        '''15520391;8;8;7.4;63;19;26;0;2
        '''1552045 [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property outils() As String
            Get
                Return ResourceManager.GetString("outils", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à FR Ø8 3z Lc9
        '''FR Ø10 2z Lc22 Lu31
        '''FR Ø5 2z Lc13 Lu18
        '''FR Ø4 2z Lc11 Lu16
        '''.
        '''</summary>
        Friend ReadOnly Property reg() As String
            Get
                Return ResourceManager.GetString("reg", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à FR2T Ø[D] [NoTT]z Lc[L] Lu[CTS_AL]
        '''FT Ø[D] r[r] [NoTT]z Lc[L] Lu[CTS_AL]
        '''FB Ø[D] [NoTT]z Lc[L] Lu[CTS_AL]
        '''FP Ø[D] [NoTT]z Lc[L]
        '''FB Ø[D] [NoTT]z Lc[L] Lu[CTS_AL]
        '''FP Ø[D] [NoTT]z Lc[L].
        '''</summary>
        Friend ReadOnly Property tooltypes() As String
            Get
                Return ResourceManager.GetString("tooltypes", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
