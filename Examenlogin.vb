Public Class Form1

    Dim CheckGebruikersnaam As Double = InputBox("Wat is uw Gebruikersnaam?")
    Dim CheckWachtwoord As Double = InputBox("Wat is uw wachtwoord?")
    Private attempts As Integer = 0
    Dim txtGebruikersnaam As Object
    Dim txtWachtwoord As Object
    Dim chkWachtwoordZichtbaar As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckGebruikersnaam And CheckWachtwoord Then
            MessageBox.Show("Login successvol!")
        Else
            attempts += 1
            If attempts >= 3 Then
                MessageBox.Show("Teveel foutieve pogingen. Login geblokkeerd.")
                Me.Close()
            Else
                MessageBox.Show("Gebruikersnaam/Wachtwoord incorrect. Login geblokkeerd.")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        txtGebruikersnaam.Text = ""
        txtWachtwoord.Text = ""
        chkWachtwoordZichtbaar.Checked = False

    End Sub

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
