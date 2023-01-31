Public Class Form1
    'het ziet ernaar uit dat je je load functien en je design verwijderd hebt waardoor dit document ook geen solution meer is en niet gebruikt kan worden.

    Dim CheckGebruikersnaam As Double = InputBox("Wat is uw Gebruikersnaam?")
    Dim CheckWachtwoord As Double = InputBox("Wat is uw wachtwoord?")
    Private attempts As Integer = 0
    Dim txtGebruikersnaam As Object
    Dim txtWachtwoord As Object
    Dim chkWachtwoordZichtbaar As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'je hebt gebruikersnaam en wachtwoord als boolean gedeclareerd maar een string proberen te initialiseren
        'Deze kun je ook niet als boolean gebruiken daarna in een selectie
        If CheckGebruikersnaam And CheckWachtwoord Then
            MessageBox.Show("Login successvol!")
        Else
            attempts += 1
            If attempts >= 3 Then
                MessageBox.Show("Teveel foutieve pogingen. Login geblokkeerd.")
                Me.Close()
            Else
                ' je doet twee keer hetzelfde alleen bij de TRUE sluit je het hele programma af 
                MessageBox.Show("Gebruikersnaam/Wachtwoord incorrect. Login geblokkeerd.")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        txtGebruikersnaam.Text = ""
        txtWachtwoord.Text = ""
        chkWachtwoordZichtbaar.Checked = False

    End Sub
    'als het enkel een spatie moet bevatten dan zal een spatie voor de naam ook werken
    'volgende 2 functies zijjn vrij juist enkel nooit gebruikt
    'Je wil hier niet een object controleren maar een string, username en password zouden dus een string moeten zijn
    Private Function CheckUsername(txtUsername As Object) As Boolean
        If txtUsername.Text.Contains(" ") Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function CheckPassword() As Boolean
        If txtWachtwoord.Text.Length >= 8 And txtWachtwoord.Text.Any(Function(c) Char.IsDigit(c)) And txtWachtwoord.Text.Any(Function(c) Not Char.IsLetterOrDigit(c)) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
