Public Class Form2
    Dim A, B, C As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Try
                A = Integer.Parse(TextBox1.Text)
            Catch ex As Exception
                MsgBox("Введите целое число А")
                Throw ex
            End Try
            Try
                B = Integer.Parse(TextBox2.Text)
            Catch ex As Exception
                MsgBox("Введите целое число B")
                Throw ex
            End Try
        Catch ex As Exception
            Return
        End Try
        Form2()
        TextBox3.Text = C.ToString
    End Sub

    Private Sub Form2()
        A = Val(TextBox1.Text)
        B = Val(TextBox2.Text)
        Do While A <> 0 And B <> 0
            If A > B Then
                A = A Mod B
            Else
                B = B Mod A
            End If
        Loop
        C = A + B
    End Sub
End Class