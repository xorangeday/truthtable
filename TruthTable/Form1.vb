Public Class Fandm1


    Dim ctr As Integer = 0
    Dim vctr As Integer = 0

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Label1.Text.Substring(Label1.Text.Length - 1) <> "P" And Label1.Text.Substring(Label1.Text.Length - 1) <> "Q" And Label1.Text.Substring(Label1.Text.Length - 1) <> "R") Then
            ctr += 1
            If (ctr > 5) Then

            Else
                Label1.Text += "P"
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (Label1.Text.Substring(Label1.Text.Length - 1) <> "P" And Label1.Text.Substring(Label1.Text.Length - 1) <> "Q" And Label1.Text.Substring(Label1.Text.Length - 1) <> "R") Then
            Label1.Text += "Q"
            ctr += 1
        End If

        If (ctr > 5) Then
            Label1.Text = Label1.Text.Substring(0, Label1.Text.Length - 2)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (Label1.Text.Substring(Label1.Text.Length - 1) <> "P" And Label1.Text.Substring(Label1.Text.Length - 1) <> "Q" And Label1.Text.Substring(Label1.Text.Length - 1) <> "R") Then
            Label1.Text += "R"
            ctr += 1
        End If

        If (ctr > 5) Then
            Label1.Text = Label1.Text.Substring(0, Label1.Text.Length - 2)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (Label1.Text.Substring(Label1.Text.Length - 1) <> "^" And Label1.Text.Substring(Label1.Text.Length - 1) <> "v" And Label1.Text.Substring(Label1.Text.Length - 1) <> "!" And Label1.Text.Substring(Label1.Text.Length - 1) <> " ") Then
            ctr += 1
            If (ctr > 5) Then

            Else
                Label1.Text += "^"
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (Label1.Text.Substring(Label1.Text.Length - 1) <> "^" And Label1.Text.Substring(Label1.Text.Length - 1) <> "v" And Label1.Text.Substring(Label1.Text.Length - 1) <> "!" And Label1.Text.Substring(Label1.Text.Length - 1) <> " ") Then
            ctr += 1
            If (ctr > 5) Then

            Else
                Label1.Text += "v"
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (Label1.Text.Substring(Label1.Text.Length - 1) <> "P" And Label1.Text.Substring(Label1.Text.Length - 1) <> "Q" And Label1.Text.Substring(Label1.Text.Length - 1) <> "R" And Label1.Text.Substring(Label1.Text.Length - 1) <> "~") Then
            ctr += 1
            If (ctr > 5) Then

            Else
                Label1.Text += "~"
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vctr = CountCharacter(Label1.Text, "P") + CountCharacter(Label1.Text, "Q") + CountCharacter(Label1.Text, "R")
        Dim stringval As String = Label1.Text



        If vctr = 2 Then
            Dim nctr As Integer = CountCharacter(Label1.Text, "~")

            If nctr = 1 Then
                PanelTwoVarFourthCol.Visible = True
                If Label1.Text.IndexOf("~") = 1 Then
                    Label4.Text = stringval(2)
                    Label6.Text = stringval.Substring(1, 2)
                    TextBox3_1.Text = "F"
                    TextBox3_2.Text = "F"
                    TextBox3_3.Text = "T"
                    TextBox3_4.Text = "T"
                    If stringval(3) = "^" Then
                        TextBox4_1.Text = "F"
                        TextBox4_2.Text = "F"
                        TextBox4_3.Text = "T"
                        TextBox4_4.Text = "F"
                    ElseIf stringval(3) = "v" Then
                        TextBox4_1.Text = "T"
                        TextBox4_2.Text = "F"
                        TextBox4_3.Text = "T"
                        TextBox4_4.Text = "T"
                    End If
                Else
                    Label4.Text = stringval(1)
                    Label6.Text = stringval.Substring(3, 2)
                    TextBox3_1.Text = "F"
                    TextBox3_2.Text = "T"
                    TextBox3_3.Text = "F"
                    TextBox3_4.Text = "T"
                    If stringval(2) = "^" Then
                        TextBox4_1.Text = "F"
                        TextBox4_2.Text = "T"
                        TextBox4_3.Text = "F"
                        TextBox4_4.Text = "F"
                    ElseIf stringval(2) = "v" Then
                        TextBox4_1.Text = "T"
                        TextBox4_2.Text = "T"
                        TextBox4_3.Text = "F"
                        TextBox4_4.Text = "T"
                    End If
                End If
                Label5.Text = stringval(4)
                Label7.Text = stringval
            ElseIf nctr = 2 Then
                Label4.Text = stringval(2)
                Label5.Text = stringval(5)
                Label6.Text = stringval.Substring(1, 2)
                Label7.Text = stringval.Substring(4, 2)
                Label8.Text = stringval
                TextBox3_1.Text = "F"
                TextBox3_2.Text = "F"
                TextBox3_3.Text = "T"
                TextBox3_4.Text = "T"
                TextBox4_1.Text = "F"
                TextBox4_2.Text = "T"
                TextBox4_3.Text = "F"
                TextBox4_4.Text = "T"
                If stringval(3) = "^" Then
                    TextBox5_1.Text = "F"
                    TextBox5_2.Text = "F"
                    TextBox5_3.Text = "F"
                    TextBox5_4.Text = "T"
                ElseIf stringval(3) = "v" Then
                    TextBox5_1.Text = "F"
                    TextBox5_2.Text = "T"
                    TextBox5_3.Text = "T"
                    TextBox5_4.Text = "T"
                End If
                PanelTwoVarFourthCol.Visible = True
                PanelTwoFifthColumn.Visible = True
            Else
                Label4.Text = stringval(1)
                Label5.Text = stringval.Substring(3)
                Label6.Text = stringval
                If stringval(2) = "^" Then
                    TextBox3_1.Text = "T"
                    TextBox3_2.Text = "F"
                    TextBox3_3.Text = "F"
                    TextBox3_4.Text = "F"

                ElseIf stringval(2) = "v" Then
                    TextBox3_1.Text = "T"
                    TextBox3_2.Text = "T"
                    TextBox3_3.Text = "T"
                    TextBox3_4.Text = "F"
                End If
            End If
            PanelTwoVar.Visible = True
        ElseIf vctr = 3 Then

            '&& Variants'
            If stringval(2) = "^" Then
                If stringval(7) = "^" Then
                    Label2.Text = stringval(1)
                    Label3.Text = stringval.Substring(2, 4)
                    Label4.Text = stringval(6)
                    Label5.Text = stringval.Substring(7, 4)
                    Label6.Text = stringval(11)

                    TextBox3_1.Text = "T"
                    TextBox3_2.Text = "F"
                    TextBox3_3.Text = "F"
                    TextBox3_4.Text = "F"
                    TextBox20.Text = "F"
                    TextBox24.Text = "F"
                    TextBox28.Text = "F"
                    TextBox32.Text = "F"
                ElseIf stringval(7) = "v" Then
                    Label2.Text = stringval(1)
                    Label3.Text = stringval.Substring(2, 4)
                    Label4.Text = stringval(6)
                    Label5.Text = stringval.Substring(7, 2)
                    Label6.Text = stringval(9)

                    TextBox3_1.Text = "T"
                    TextBox3_2.Text = "T"
                    TextBox3_3.Text = "T"
                    TextBox3_4.Text = "F"
                    TextBox20.Text = "F"
                    TextBox24.Text = "T"
                    TextBox28.Text = "F"
                    TextBox32.Text = "T"
                ElseIf stringval(7) = "!" Then
                    Label2.Text = stringval(1)
                    Label3.Text = stringval.Substring(2, 4)
                    Label4.Text = stringval(6)
                    Label5.Text = stringval.Substring(7, 1)
                    Label6.Text = stringval(8)

                    TextBox3_1.Text = "T"
                    TextBox3_2.Text = "F"
                    TextBox3_3.Text = "T"
                    TextBox3_4.Text = "T"
                    TextBox20.Text = "T"
                    TextBox24.Text = "T"
                    TextBox28.Text = "T"
                    TextBox32.Text = "T"
                End If

                '|| Variants'
            ElseIf stringval(2) = "v" Then
                If stringval(5) = "^" Then
                    Label2.Text = stringval(1)
                    Label3.Text = stringval.Substring(2, 2)
                    Label4.Text = stringval(4)
                    Label5.Text = stringval.Substring(5, 4)
                    Label6.Text = stringval(9)

                    TextBox3_1.Text = "T"
                    TextBox3_2.Text = "T"
                    TextBox3_3.Text = "T"
                    TextBox3_4.Text = "T"
                    TextBox20.Text = "F"
                    TextBox24.Text = "F"
                    TextBox28.Text = "F"
                    TextBox32.Text = "T"
                ElseIf stringval(5) = "v" Then
                    Label2.Text = stringval(1)
                    Label3.Text = stringval.Substring(2, 2)
                    Label4.Text = stringval(4)
                    Label5.Text = stringval.Substring(5, 2)
                    Label6.Text = stringval(7)

                    TextBox3_1.Text = "T"
                    TextBox3_2.Text = "T"
                    TextBox3_3.Text = "T"
                    TextBox3_4.Text = "T"
                    TextBox20.Text = "F"
                    TextBox24.Text = "T"
                    TextBox28.Text = "T"
                    TextBox32.Text = "T"
                ElseIf stringval(5) = "!" Then
                    Label2.Text = stringval(1)
                    Label3.Text = stringval.Substring(2, 2)
                    Label4.Text = stringval(4)
                    Label5.Text = stringval.Substring(5, 1)
                    Label6.Text = stringval(6)

                    TextBox3_1.Text = "F"
                    TextBox3_2.Text = "T"
                    TextBox3_3.Text = "F"
                    TextBox3_4.Text = "T"
                    TextBox20.Text = "T"
                    TextBox24.Text = "T"
                    TextBox28.Text = "T"
                    TextBox32.Text = "F"
                End If


                '! Variant'
            ElseIf stringval(2) = "!" Then
                If stringval(4) = "^" Then
                    Label2.Text = stringval(1)
                    Label3.Text = stringval.Substring(2, 1)
                    Label4.Text = stringval(3)
                    Label5.Text = stringval.Substring(4, 4)
                    Label6.Text = stringval(8)

                    TextBox3_1.Text = "F"
                    TextBox3_2.Text = "F"
                    TextBox3_3.Text = "T"
                    TextBox3_4.Text = "F"
                    TextBox20.Text = "T"
                    TextBox24.Text = "T"
                    TextBox28.Text = "T"
                    TextBox32.Text = "T"
                ElseIf stringval(4) = "v" Then
                    Label2.Text = stringval(1)
                    Label3.Text = stringval.Substring(2, 1)
                    Label4.Text = stringval(3)
                    Label5.Text = stringval.Substring(4, 2)
                    Label6.Text = stringval(6)

                    TextBox3_1.Text = "T"
                    TextBox3_2.Text = "F"
                    TextBox3_3.Text = "T"
                    TextBox3_4.Text = "T"
                    TextBox20.Text = "T"
                    TextBox24.Text = "T"
                    TextBox28.Text = "T"
                    TextBox32.Text = "T"
                ElseIf stringval(4) = "!" Then
                    Label2.Text = stringval(1)
                    Label3.Text = stringval.Substring(2, 1)
                    Label4.Text = stringval(3)
                    Label5.Text = stringval.Substring(4, 1)
                    Label6.Text = stringval(5)

                    TextBox3_1.Text = "T"
                    TextBox3_2.Text = "T"
                    TextBox3_3.Text = "F"
                    TextBox3_4.Text = "T"
                    TextBox20.Text = "T"
                    TextBox24.Text = "T"
                    TextBox28.Text = "T"
                    TextBox32.Text = "T"
                End If
            End If
            PanelTwoVarFourthCol.Visible = True
            Panel2.Visible = True
        End If


    End Sub

    Public Function CountCharacter(ByVal value As String, ByVal ch As Char) As Integer
        Dim cnt As Integer = 0
        For Each c As Char In value
            If c = ch Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label1.Text = " "
        Panel2.Visible = False
        PanelTwoVar.Visible = False
        PanelTwoVarFourthCol.Visible = False
        PanelTwoFifthColumn.Visible = False
        ctr = 0
        vctr = 0
    End Sub
End Class
