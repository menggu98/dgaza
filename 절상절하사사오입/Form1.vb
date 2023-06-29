Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        choose.Items.Add("사사오입")
        choose.Items.Add("절상")
        choose.Items.Add("버림")
    End Sub

    Private Sub round_Click(sender As Object, e As EventArgs) Handles round.Click
        Dim tmp1 As Double
        Dim opt As Char
        Dim cnt As Integer
        tmp1 = Val(input.Text)
        opt = choose.Text
        cnt = value.Text
        output.Text = cjround(tmp1, opt, cnt)
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        input.Text = ""
        value.Text = ""
        output.Text = ""
    End Sub

    Private Function cjround(pValue As Double, pOpt As Char, pDigit As Integer) As Single

        Dim i As Integer
        Dim t_s As String, t_u As Single

        t_u = 10 ^ (pDigit * -1) ' pDigit은 처리할 자리 수

        Select Case pOpt ' pOpt는 절상, 절사, 사사오입 중 옵션 선택
            Case "사사오입"
                t_u = Int((pValue + (t_u / 2)) / t_u) * t_u ' 사사오입
            Case "절상"
                t_u = Int((pValue + (t_u - 10 ^ (-1 * (15 - Len(Format(Int(pValue))))))) / t_u) * t_u
                ' 절상
            Case "버림"
                t_u = Int(pValue) ' 절사   Int(pValue / t_u) * t_u
            Case Else
                t_u = pValue
        End Select

        If pDigit > 0 Then ' 처리할 값이 0보다 크다면
            t_s = "0."
            For i = 1 To pDigit
                t_s = t_s + "0"

            Next i
            cjround = Format(t_u, t_s)
        Else
            cjround = t_u
        End If
        cjround = t_u
    End Function

    Private Sub choose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles choose.SelectedIndexChanged

    End Sub
End Class
