Public Class Form1
    Private Sub cmdMittel_Click(sender As Object, e As EventArgs) Handles cmdMittel.Click
        Dim mM As Single, mZahl As Single, mS As Single, mA As Integer
        mZahl = InputBox("mZahl (0=Ende)?")
        Do While mZahl <> "0"
            mA = mA + 1
            mS = mS + (mZahl)
            MsgBox(mA, mZahl, mS)

            mZahl = InputBox("mZahl (0=Ende)?")
        Loop
        If mA <> 0 Then
            mM = mS / mA
            MsgBox(mM)
        End If

    End Sub
End Class
