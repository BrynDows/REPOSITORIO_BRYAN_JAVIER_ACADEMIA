Module modulo
    Public crudEmployes As New CRUD_employes
    Public login As New Login

    Public Const EMPLEADOS As Integer = 1
    Public Const ALUMNOS As Integer = 0

    Public Const INSERTAR As Integer = 0
    Public Const ACTUALIZAR As Integer = 1

    Public Const INSERTAR_EMPLEADO = 0
    Public Const INSERTAR_PROFESOR = 1

    Public Const str_EMPLEADOS = "Empleados"
    Public Const str_ALUMNOS = "Alumnos"

    Public Const INVIERNO = True
    Public Const VERANO = False

    Public Sub ExitToAPP(form As Form)
        Dim r = MsgBox("¿Está seguro de que desea salir?", 48 + 4, "Salir")
        If r = vbYes Then
            form.Close()
        End If
    End Sub

    Public showNotifyIcon = 0

End Module
