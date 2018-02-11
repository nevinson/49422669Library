﻿Public Class frmUserDashboard

    Private Sub frmUserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        '' show the reserve book form
        frmReserve.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        '' logout and show the login form
        frmLogIn.Show()
        Me.Hide()
    End Sub

#Region "MenuStrip"
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        ''
        frmLogIn.Show()
        Me.Hide()
    End Sub

    Private Sub RefreshPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshPageToolStripMenuItem.Click
        ''

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ''
        Constants.ExitProgram(True)
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        ''
        frmProfile.Show()
        Me.Hide()
    End Sub

    Private Sub ReserveBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReserveBookToolStripMenuItem.Click
        ''
        frmReserve.Show()
        Me.Hide()
    End Sub

    Private Sub BorrowBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowBookToolStripMenuItem.Click
        ''
        frmBorrow.Show()
        Me.Hide()
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click

    End Sub

    Private Sub HowToUseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToUseToolStripMenuItem.Click
        ''
        MessageBox.Show("Please refer to the user manual supplied with the product.", "How To Use", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ''
        MessageBox.Show("49422669 Library is a VB.Net project created for the UNISA Module ICT3714 Assessment Project.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
#End Region
End Class
