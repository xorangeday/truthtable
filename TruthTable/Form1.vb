﻿Public Class Fandm1


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
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (Label1.Text.Substring(Label1.Text.Length - 1) <> "P" And Label1.Text.Substring(Label1.Text.Length - 1) <> "Q" And Label1.Text.Substring(Label1.Text.Length - 1) <> "R") Then
            Label1.Text += "R"
            ctr += 1
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (Label1.Text.Substring(Label1.Text.Length - 1) <> "^" And Label1.Text.Substring(Label1.Text.Length - 1) <> "v" And Label1.Text.Substring(Label1.Text.Length - 1) <> "!" And Label1.Text.Substring(Label1.Text.Length - 1) <> " ") Then
            ctr += 1
            If (ctr > 20) Then

            Else
                Label1.Text += "^"
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (Label1.Text.Substring(Label1.Text.Length - 1) <> "^" And Label1.Text.Substring(Label1.Text.Length - 1) <> "v" And Label1.Text.Substring(Label1.Text.Length - 1) <> "!" And Label1.Text.Substring(Label1.Text.Length - 1) <> " ") Then
            ctr += 1
            If (ctr > 20) Then

            Else
                Label1.Text += "v"
            End If
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (Label1.Text.Substring(Label1.Text.Length - 1) <> "P" And Label1.Text.Substring(Label1.Text.Length - 1) <> "Q" And Label1.Text.Substring(Label1.Text.Length - 1) <> "R" And Label1.Text.Substring(Label1.Text.Length - 1) <> "~") Then
            ctr += 1
            If (ctr > 20) Then

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
            Dim nctr As Integer = CountCharacter(Label1.Text, "~")
            If nctr = 1 Then
                If Label1.Text.IndexOf("~") = 1 Then
                    Label2.Text = stringval(2)
                    Label3.Text = stringval(4)
                    Label9.Text = stringval(6)
                    Label10.Text = stringval.Substring(0, 5)
                    Label11.Text = stringval
                    If stringval(3) = "^" Then
                        SetFourthCol("F", "F", "F", "F", "F", "F", "T", "T")
                        If stringval(5) = "^" Then
                            SetFifthCol("F", "F", "F", "F", "F", "F", "F", "T")
                        Else
                            SetFifthCol("T", "F", "T", "F", "F", "T", "T", "T")
                        End If
                    Else
                        SetFourthCol("T", "T", "F", "F", "T", "T", "T", "T")
                        If stringval(5) = "^" Then
                            SetFifthCol("T", "F", "F", "F", "F", "T", "F", "T")
                        Else
                            SetFifthCol("T", "T", "T", "F", "T", "T", "T", "T")
                        End If
                    End If
                ElseIf Label1.Text.IndexOf("~") = 3 Then
                    Label2.Text = stringval(1)
                    Label3.Text = stringval(4)
                    Label9.Text = stringval(6)
                    Label10.Text = stringval.Substring(0, 5)
                    Label11.Text = stringval
                    If stringval(2) = "^" Then
                        SetFourthCol("F", "F", "F", "T", "F", "F", "F", "F")
                        If stringval(5) = "^" Then
                            SetFifthCol("F", "F", "F", "F", "F", "F", "F", "F")
                        Else
                            SetFifthCol("T", "F", "T", "T", "F", "T", "F", "T")
                        End If
                    Else
                        SetFourthCol("T", "T", "T", "T", "T", "T", "F", "F")
                        If stringval(5) = "^" Then
                            SetFifthCol("T", "F", "T", "F", "F", "T", "F", "F")
                        Else
                            SetFifthCol("T", "T", "T", "T", "T", "T", "F", "T")
                        End If
                    End If
                Else
                    Label2.Text = stringval(1)
                    Label3.Text = stringval(3)
                    Label9.Text = stringval(6)
                    Label10.Text = stringval.Substring(0, 4)
                    Label11.Text = stringval
                    If stringval(2) = "^" Then
                        SetFourthCol("T", "T", "F", "F", "F", "F", "F", "F")
                        If stringval(4) = "^" Then
                            SetFifthCol("F", "T", "F", "F", "F", "F", "F", "F")
                        Else
                            SetFifthCol("T", "T", "F", "T", "T", "F", "T", "F")
                        End If
                    Else
                        SetFourthCol("T", "T", "T", "T", "T", "T", "F", "F")
                        If stringval(4) = "^" Then
                            SetFifthCol("F", "T", "F", "T", "T", "F", "F", "F")
                        Else
                            SetFifthCol("T", "T", "T", "T", "T", "T", "T", "F")
                        End If
                    End If
                End If
            ElseIf nctr = 2 Then
                If Label1.Text.IndexOf("~") = 1 Then
                    If Label1.Text.Substring(2, Label1.Text.Length - 2).IndexOf("~") = 2 Then '1st and 2nd negation
                        Label2.Text = stringval(2)
                        Label3.Text = stringval(5)
                        Label9.Text = stringval(7)
                        Label10.Text = stringval.Substring(0, 6)
                        Label11.Text = stringval
                        If stringval(3) = "^" Then
                            SetFourthCol("F", "F", "F", "F", "T", "T", "F", "F")
                            If stringval(6) = "^" Then
                                SetFifthCol("F", "F", "F", "F", "F", "T", "F", "F")
                            Else
                                SetFifthCol("F", "T", "F", "T", "T", "T", "F", "T")
                            End If
                        Else
                            SetFourthCol("F", "F", "T", "T", "T", "T", "T", "T")
                            If stringval(6) = "^" Then
                                SetFifthCol("F", "F", "T", "F", "F", "T", "F", "T")
                            Else
                                SetFifthCol("T", "F", "T", "T", "T", "T", "T", "T")
                            End If
                        End If
                    Else '1st and 3rd negation
                        Label2.Text = stringval(2)
                        Label3.Text = stringval(4)
                        Label9.Text = stringval(7)
                        Label10.Text = stringval.Substring(0, 5)
                        Label11.Text = stringval
                        If stringval(3) = "^" Then
                            SetFourthCol("F", "F", "F", "F", "F", "F", "T", "T")
                            If stringval(5) = "^" Then
                                SetFifthCol("F", "F", "F", "F", "F", "F", "T", "F")
                            Else
                                SetFifthCol("F", "T", "F", "T", "T", "F", "T", "T")
                            End If
                        Else
                            SetFourthCol("T", "T", "F", "F", "T", "T", "T", "T")
                            If stringval(5) = "^" Then
                                SetFifthCol("F", "T", "F", "F", "T", "F", "T", "F")
                            Else
                                SetFifthCol("T", "T", "F", "F", "T", "T", "T", "T")
                            End If
                        End If
                    End If
                Else '2nd and 3rd negation
                    Label2.Text = stringval(1)
                    Label3.Text = stringval(4)
                    Label9.Text = stringval(7)
                    Label10.Text = stringval.Substring(0, 5)
                    Label11.Text = stringval
                    If stringval(2) = "^" Then
                        SetFourthCol("F", "F", "F", "T", "F", "F", "F", "F")
                        If stringval(5) = "^" Then
                            SetFifthCol("F", "F", "F", "T", "F", "F", "F", "F")
                        Else
                            SetFifthCol("F", "T", "F", "T", "T", "F", "T", "F")
                        End If
                    Else
                        SetFourthCol("T", "T", "T", "T", "T", "T", "F", "F")
                        If stringval(5) = "^" Then
                            SetFifthCol("F", "T", "F", "T", "T", "F", "F", "F")
                        Else
                            SetFifthCol("T", "T", "T", "T", "T", "T", "T", "F")
                        End If
                    End If
                End If
            ElseIf nctr = 3 Then
                Label2.Text = stringval(2)
                Label3.Text = stringval(5)
                Label9.Text = stringval(8)
                Label10.Text = stringval.Substring(0, 6)
                Label11.Text = stringval
                If stringval(3) = "^" Then
                    SetFourthCol("F", "F", "F", "F", "T", "T", "F", "F")
                    If stringval(6) = "^" Then
                        SetFifthCol("F", "F", "F", "F", "T", "F", "F", "F")
                    Else
                        SetFifthCol("F", "T", "F", "T", "T", "T", "T", "F")
                    End If
                Else
                    SetFourthCol("F", "F", "T", "T", "T", "T", "T", "T")
                    If stringval(6) = "^" Then
                        SetFifthCol("F", "F", "F", "T", "T", "F", "T", "F")
                    Else
                        SetFifthCol("F", "T", "T", "T", "T", "T", "T", "T")
                    End If
                End If
            Else
                Label2.Text = stringval(1)
                Label3.Text = stringval(3)
                Label9.Text = stringval(5)
                Label10.Text = stringval.Substring(0, 4)
                Label11.Text = stringval
                If stringval(2) = "^" Then
                    SetFourthCol("T", "T", "F", "F", "F", "F", "F", "F")
                    If stringval(4) = "^" Then
                        SetFifthCol("T", "F", "F", "F", "F", "F", "F", "F")
                    Else
                        SetFifthCol("T", "T", "T", "F", "T", "F", "T", "T")
                    End If
                Else
                    SetFourthCol("T", "T", "T", "T", "T", "T", "F", "F")
                    If stringval(4) = "^" Then
                        SetFifthCol("T", "F", "T", "F", "F", "T", "F", "F")
                    Else
                        SetFifthCol("T", "T", "T", "T", "T", "T", "F", "T")
                    End If
                End If
            End If
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

    Private Sub SetFourthCol(first As String, second As String, third As String, fourth As String, fifth As String, sixth As String, seventh As String, eighth As String)
        TB4_1.Text = first
        TB4_2.Text = second
        TB4_3.Text = third
        TB4_4.Text = fourth
        TB4_5.Text = fifth
        TB4_6.Text = sixth
        TB4_7.Text = seventh
        TB4_8.Text = eighth
    End Sub

    Private Sub SetFifthCol(first As String, second As String, third As String, fourth As String, fifth As String, sixth As String, seventh As String, eighth As String)
        TB5_1.Text = first
        TB5_2.Text = second
        TB5_3.Text = third
        TB5_4.Text = fourth
        TB5_5.Text = fifth
        TB5_6.Text = sixth
        TB5_7.Text = seventh
        TB5_8.Text = eighth
    End Sub
End Class
