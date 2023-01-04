Public Class Practise
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'End application
        End

    End Sub

    Private Sub chkMarried_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMarried.CheckedChanged

        If chkMarried.CheckState = CheckState.Checked Then

        End If

    End Sub

    Private Sub cboAgerange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAgerange.SelectedIndexChanged

    End Sub
End Class
