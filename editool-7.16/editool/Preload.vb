Public NotInheritable Class Preload

    'TODO: ce formulaire peut facilement être configuré comme écran de démarrage de l'application en accédant à l'onglet "Application"
    '  du Concepteur de projets ("Propriétés" sous le menu "Projet").

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Configurez le texte de la boîte de dialogue au moment de l'exécution en fonction des informations d'assembly de l'application.  

        'TODO: personnalisez les informations d'assembly de l'application dans le volet "Application" de la 
        '  boîte de dialogue Propriétés du projet (sous le menu "Projet").

        'Titre de l'application
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'Si le titre de l'application est absent, utilisez le nom de l'application, sans l'extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Mettez en forme les informations de version à l'aide du texte défini dans la gestion de version au moment du design en tant que
        '  chaîne de mise en forme.  Ceci permet une localisation efficace si besoin est.
        '  Les informations de génération et de révision peuvent être incluses en utilisant le code suivant et en remplaçant le 
        '  texte de la gestion de version par "Version {0}.{1:00}.{2}.{3}" ou un équivalent. Consultez
        '  String.Format() dans l'aide pour plus d'informations.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Informations de copyright
        'Copyright.Text = My.Application.Info.Copyright

        ' Load TopSolid information
        Dim topSolidVersion As String = GetVersion()
        Dim topSolidPath As String = GetTopSolidPath()

        If Not String.IsNullOrEmpty(topSolidPath) Then
            path_label.Text = topSolidPath
            version_label.Text = topSolidVersion
            output.Text = "libs loaded"
            output.Visible = True
        Else
            path_label.Text = "TS path not found"
        End If



    End Sub
    Public Sub ToolCount()
        If toolCountLabel.InvokeRequired Then
            toolCountLabel.BeginInvoke(Sub() ToolCount())
            Return
        End If

        toolCountLabel.Text = 10
        toolCountLabel.Refresh()
    End Sub

    Private Sub Preload_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.DialogResult = DialogResult.None Then
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub Preload_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Hide()
    End Sub

    Private Sub Panel1_Click(sender As Object, e As EventArgs) Handles Panel1.Click
        Me.Hide()

    End Sub

    Private Sub Preload_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'FileImports.GetOrderTools()
        'ToolCount()
    End Sub

End Class
