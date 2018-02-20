﻿Public Class FormManagement

    Public Property Mode As Byte

    Private Sub FormManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tcModos.TabPages.Remove(tabProfesores)
        '0 = jefe, 1 = profesor
        If Mode = 0 Then
            'soy jefe y muesro las dos pestañas, profesor y alumnos
            tcModos.TabPages.Insert(0, tabProfesores)
        End If
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        FormModify.Modo = 0
        FormModify.ShowDialog()
    End Sub

    Private Sub bMod_Click(sender As Object, e As EventArgs) Handles bMod.Click
        FormModify.Modo = 1
        FormModify.ShowDialog()
    End Sub

    Private Sub bLogout_Click(sender As Object, e As EventArgs) Handles bLogout.Click
        FormLogin.Show()
        Me.Close()
    End Sub
End Class