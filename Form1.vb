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
___________________________________________________________________________________________________________________________________
Public Class Form2

    Private Sub radioBars_CheckedChanged(sender As Object, e As EventArgs) Handles radioBars.CheckedChanged

        cboList.Items.Clear()

        If radioBars.Checked Then
            cboList.Items.Add("Peabodies")
            cboList.Items.Add("Monopole")
            cboList.Items.Add("Green Room")
            cboList.Items.Add("five1eight")
            cboList.Items.Add("Olive Ridleys")
            cboList.Items.Add("Fourth Ward")
            cboList.Items.Add("Brunners")

        ElseIf radioRest.Checked Then
            cboList.Items.Add("Unos")
            cboList.Items.Add("Olive Ridleys")
            cboList.Items.Add("AppleBees")
            cboList.Items.Add("Friendlys")
            cboList.Items.Add("Blue Collar Bistro")
            cboList.Items.Add("Arnies")
            cboList.Items.Add("The Pepper")
        End If

    End Sub

    Private Sub cboList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboList.SelectedIndexChanged
        If cboList.SelectedItem = "Peabodies" Then
            lblDesc.Text = "Peabodies is in downtown Plattsburgh"
        ElseIf cboList.SelectedItem = "Monopole" Then
            lblDesc.Text = "Monopole is in downtown Plattsburgh. "
        ElseIf cboList.SelectedItem = "Green Room" Then
            lblDesc.Text = "Green Room is in downtown Plattsburgh. Popular for Djs and dancing"
        ElseIf cboList.SelectedItem = "five1eight" Then
            lblDesc.Text = "Downtown Plattsburgh. Open Thursday, Fridays and Saturdays ONLY. College Kids, Dancing, Music"
        ElseIf cboList.SelectedItem = "Fourth Ward" Then
            lblDesc.Text = "Downtown Plattsburgh."
        ElseIf cboList.SelectedItem = "Brunners" Then
            lblDesc.Text = "DownTown Plattsburgh"
        ElseIf cboList.SelectedItem = "Unos" Then
            lblDesc.Text = "Uptown- Price Range $$$ - Bar "
        ElseIf cboList.SelectedItem = "Olive Ridleys" Then
            lblDesc.Text = "DownTown Plattsburgh - Resturant by day, Bar at night"
        ElseIf cboList.SelectedItem = "Applebees" Then
            lblDesc.Text = "Uptown - Price Range $$ - Bar"
        ElseIf cboList.SelectedItem = "Friendlys" Then
            lblDesc.Text = "Uptown - Price Range $$ - No Bar - Kid Friendly"
        ElseIf cboList.SelectedItem = "Blue Collar Bistro" Then
            lblDesc.Text = "DownTown Plattsburgh - Price Range $$$ - Bar"
        ElseIf cboList.SelectedItem = "Arnnies" Then
            lblDesc.Text = "DownTown Plattsburgh - Price Range $$ - Bar - Old People"
        ElseIf cboList.SelectedItem = "The Pepper" Then
            lblDesc.Text = "DownTown Plattsburgh - Price Range $$ - Bar - Mexican"

        End If

    End Sub
End Class

_________________________________________________________________________________________________________________________________
Public Class Form4

    Dim fName As String
    Dim lName As String
    Dim userName As String
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        While (txtFirst.Text = "")
            fName = InputBox(" Enter a Valid First Name.")
        End While

        While (txtLast.Text = "")
            lName = InputBox("Enter a Valid Last Name. ")
        End While

        While (txtUsername.Text = "")
            userName = InputBox("Please Enter a Valid UserName.")
        End While



    End Sub
End Class
_______________________________________________________________________________________________________________________________________

