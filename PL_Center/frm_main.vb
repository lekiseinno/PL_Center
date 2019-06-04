Public Class frm_main

    Private Sub FactorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FactorToolStripMenuItem1.Click
        frm_factor.Show()
    End Sub

    Private Sub PAPERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PAPERToolStripMenuItem.Click
        frm_paper.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PAPERCostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PAPERCostToolStripMenuItem.Click
        frm_paper_cost.Show()
    End Sub

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
