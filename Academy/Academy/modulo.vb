Imports System.IO
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


    Public showNotifyIcon = 0

    Public Sub mostrar_ayuda()
        Try
            Process.Start("ayuda.chm")
        Catch ex As Exception
            idiomasDLL.Errores.INSERT_IN_ERROR_LOG(ex)
            MsgBox("No se ha encontrado la ayuda", 64, "Navegador no encontrado")
        End Try
    End Sub

    Public Sub ShowLink(URL As String)
        Try
            Process.Start("firefox.exe", URL)
        Catch ex As System.ComponentModel.Win32Exception
            Try
                Process.Start("chrome.exe", Path.Combine(Application.StartupPath, URL))
            Catch exce As Exception
                idiomasDLL.INSERT_IN_ERROR_LOG(exce)
                MsgBox("No se ha encontrado un navegador web para mostrar[ " & URL & " ], navegadores aceptado: MOZILLA, CHROME, IEXPLORE", 64, "Navegador no encontrado")
            End Try
        Catch ex As Exception
            idiomasDLL.INSERT_IN_ERROR_LOG(ex)
            MsgBox("No se ha encontrado un navegador web para mostrar[ " & URL & " ], navegadores aceptado: MOZILLA, CHROME, IEXPLORE", 64, "Navegador no encontrado")
        End Try
    End Sub

End Module
