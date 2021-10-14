Public Class Form4
    Private Sub MenuUtamaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUtamaToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub AngkaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AngkaToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub KataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KataToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class