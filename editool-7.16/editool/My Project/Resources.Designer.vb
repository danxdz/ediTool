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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("EdiTool.Resources", GetType(Resources).Assembly)
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
        '''  Recherche une chaîne localisée semblable à .
        '''</summary>
        Friend ReadOnly Property customLibraryData() As String
            Get
                Return ResourceManager.GetString("customLibraryData", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à NSM;Numéro standard Caractéristique
        '''BLD;Classification par image
        '''A1;Diamètre de coupe 1 (diamètre nominal);mm
        '''A5;Diamètre extension;mm
        '''A11;Diamètre de coupe min. ou nominal
        '''B2;Longueur d&apos;arête de coupe, max.;mm
        '''B3;Longueur de porte-à-faux;mm
        '''B5;Longueur totale;mm
        '''B6;Longueur de la goujure
        '''B9;Longueur util;mm
        '''B71;Longueur fonctionnelle;mm
        '''C3;Diamètre d&apos;attachement du côté de la machine;mm
        '''C4;Longueur de queue;mm
        '''C11;Type d&apos;attachement de base, du côté de machine
        '''C11;ZYL;Attachement cylindrique        ''' [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property DIN400_tool_params() As String
            Get
                Return ResourceManager.GetString("DIN400_tool_params", resourceCulture)
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
        '''  Recherche une chaîne localisée semblable à Index;File;Parent;EN;FR;PT
        '''1;file;1;File;Fichier;Ficheiro
        '''2;open;1;Open;Ouvrir;Abrir
        '''3;xml;2;XML;XML;XML@
        '''4;excel;2;Excel ( model );Excel ( modèle );Excel ( modelo )@
        '''5;topsolid;2;TopSolid 6;TopSolid 6;TopSolid 6@
        '''6;save;1;Save;Enregistrer;Guardar@
        '''7;exit;1;Exit;Quitter;Sair@
        '''8;tools;8;Tool;Outils;Ferramentas
        '''9;mills;8;Mills;Fraises;Fresas
        '''10;endMill;9;End Mill;Fraise 2 tailles;Fresa de topo@
        '''11;toroidalMill;9;Toroidal Mill;Fraise toroïdale;Fresa toroidal
        '''12;ballNoseMill;9;Ball Nose Mill;Fraise  [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property textMainMenu() As String
            Get
                Return ResourceManager.GetString("textMainMenu", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à ID;Key;en;fr;pt
        '''1;toolName;Tool Name;Nom de l&apos;outil;Nome da ferramenta
        '''2;rayon;Radius;Rayon;Raio
        '''3;angle;Angle;Angle;Ângulo
        '''4;teethNum;N. of teeth;Nb. de dents;N. de dentes
        '''5;cuttingDiameter;Cutting Diameter;Diamètre de coupe;Diâmetro de corte
        '''6;clearanceDiameter;Clearance Diameter;Diamètre de dégagement;Diâmetro de folga
        '''7;bodyDiameter;Body Diameter;Diamètre du corps;Diâmetro do corpo
        '''8;cuttingLength;Cutting Length;Longueur de coupe;Comprimento de corte
        '''9;clearanceLength;Clearance Length;Longueur  [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property textUI() As String
            Get
                Return ResourceManager.GetString("textUI", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à FR2T Ø[D] [NoTT]z Lc[L] Lu[CTS_AL]
        '''FRTO Ø[D] r[r] [NoTT]z Lc[L] Lu[CTS_AL]
        '''FRHE Ø[D] [NoTT]z Lc[L] Lu[CTS_AL]
        '''FOP9 Ø[D] [NoTT]z Lc[L] Lu[CTS_AL]
        '''FOCA Ø[D] [NoTT]z Lc[L]
        '''ALFI Ø[D] [NoTT]z Lc[L].
        '''</summary>
        Friend ReadOnly Property tooltypes() As String
            Get
                Return ResourceManager.GetString("tooltypes", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
