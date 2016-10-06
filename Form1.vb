Public Class Form1
    Dim login As String
    Dim pass As String
    Dim name As String
    Dim bday As Date
    Dim datBirthdate As Date

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        login = InputBox("Username")
        pass = InputBox("Password")


        Form2.Show()








    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        Dim Signup As Object = Nothing
        Signup.Show()







    End Sub
End Class
