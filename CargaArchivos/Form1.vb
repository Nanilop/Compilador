Imports System.IO

Public Class Form1
    Dim token As String
    Dim estado
    Dim posicion
    Dim Matriz(16, 25)
    Dim PR = False
    Dim Direc = 0
    Dim DirPR = 0
    Dim caracter As String
    Dim errores As Boolean
    Dim OpenFileDialog1 As OpenFileDialog
    Dim VectorPalabrasReservadas()
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        OpenFileDialog1 = New OpenFileDialog()
        LeeMatrizEstados("C:\Users\LOPEZ\Desktop\López Rodríguez Daniela\8vo semestre\MatrizESTADOS.csv")
        btnExportar.Image = Image.FromFile("file_export_icon_138621.png")
        DGVSalida.Columns.Add("Token", "Token")
        DGVSalida.Columns.Add("Tipo", "Tipo")
        DGVSalida.Columns.Add("Directorio", "Directorio")
        ListBox3.Items.Clear()

        LeePalabrasReservadas("C:\Users\LOPEZ\Desktop\López Rodríguez Daniela\7MO SEMESTRE\PR.txt")
        For i = 0 To VectorPalabrasReservadas.Length - 1
            ListBox3.Items.Add(VectorPalabrasReservadas(i) + "")
        Next
        ''Se cambia el ListBox3 en todo por el vector
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'PictureImage,Image=Image.FromFile("Ruta de Imagen")
    End Sub

    Private Sub btnCarga_Click(sender As Object, e As EventArgs) Handles btnCarga.Click
        btnExportar.Enabled = False
        lbEnter.Items.Clear()
        DGVSalida.Rows.Clear()
        lbIden.Items.Clear()
        lbStr.Items.Clear()
        lbReal.Items.Clear()
        lbEntra.Items.Clear()
        Dim archivo
        If (OpenFileDialog1.ShowDialog() = DialogResult.Cancel) Then
            Return
        End If
        'Abre el explorador de archivos

        archivo = OpenFileDialog1.FileName 'Obtiene Nombre del archivo

        Dim read As System.IO.StreamReader 'Lector de archivos
        read = My.Computer.FileSystem.OpenTextFileReader(archivo) 'Abre el archivo
        Dim StringRead As String

        While Not (read.EndOfStream) 'Mientras no se acabe de leer el archivo
            StringRead = read.ReadLine() 'Lee una linea
            'MsgBox(StringRead)
            lbEntra.Items.Add(StringRead) 'Agrega la linea al Listbox
        End While
    End Sub

    Private Sub btnCompila_Click(sender As Object, e As EventArgs) Handles btnCompila.Click
        btnExportar.Enabled = True
        lbEnter.Items.Clear()
        DGVSalida.Rows.Clear()
        lbIden.Items.Clear()
        lbStr.Items.Clear()
        lbReal.Items.Clear()
        token = ""
        estado = 0
        posicion = 1
        Dim renglon = 0
        Dim items As String
        While (renglon < lbEntra.Items.Count)
            lbEntra.SelectedIndex = renglon
            items = lbEntra.SelectedItem.ToString()
            Dim longitud = Len(items)
            posicion = 1
            While (posicion <= longitud)
                caracter = Mid(items, posicion, 1) 'MID - Regresa una cadena de caracteres a partir de la posicion, 1 caracter
                estado = Matriz(estado, Columnas(caracter))
                If estado >= 100 Then
                    ReconoceToken()
                    estado = 0
                    token = ""
                ElseIf estado = 0 Then

                Else
                    token = token + caracter
                End If
                '*---
                posicion = posicion + 1
                '*---
                If errores Then
                    posicion = longitud
                    renglon = lbEntra.Items.Count
                End If
            End While
            If estado <> 4 Then
                estado = Matriz(estado, Columnas(" "))
                ReconoceToken()
                estado = 0
                token = ""
            End If
            renglon = renglon + 1
        End While
        If estado = 4 Then
            DGVSalida.Rows.Clear()
            MessageBox.Show("Constante String invalida, se esperaba un '.")
        End If
    End Sub
    Private Sub LeeMatrizEstados(archivo As String)
        Dim renglon As String
        Dim datosRenglon As String()
        Dim Lector As StreamReader = New StreamReader(archivo)
        Dim r As Integer = 0
        While Not Lector.EndOfStream
            renglon = Lector.ReadLine()
            datosRenglon = renglon.Split(",")
            For c = 0 To datosRenglon.Length - 1
                Matriz(r, c) = datosRenglon(c)
            Next
            r += 1
        End While
    End Sub
    Private Sub LeePalabrasReservadas(archivo As String)
        'Dim read As System.IO.StreamReader 'Lector de archivos
        'read = My.Computer.FileSystem.OpenTextFileReader(archivo) 'Abre el archivo
        'Dim StringRead As String

        'While Not (read.EndOfStream) 'Mientras no se acabe de leer el archivo
        '    StringRead = read.ReadLine() 'Lee una linea
        '    'MsgBox(StringRead)
        '    ListBox3.Items.Add(StringRead) 'Agrega la linea al Listbox
        'End While


        'Ctrl+RR cambia de todas partes la palabra que escribas

        Dim renglon As String

        Dim Lector As StreamReader = New StreamReader(archivo)
        renglon = Lector.ReadLine()
        VectorPalabrasReservadas = renglon.Split(",")


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Matriz(0, 0) = 13
        'Matriz(0, 1) = 12
        'Matriz(0, 2) = 4
        'Matriz(0, 3) = 5
        'Matriz(0, 4) = 102
        'Matriz(0, 5) = 103
        'Matriz(0, 6) = 104
        'Matriz(0, 7) = 105
        'Matriz(0, 8) = 1
        'Matriz(0, 9) = 3
        'Matriz(0, 10) = 112
        'Matriz(0, 11) = 110
        'Matriz(0, 12) = 2
        'Matriz(0, 13) = 113
        'Matriz(0, 14) = 10
        'Matriz(0, 15) = 114
        'Matriz(0, 16) = 115
        'Matriz(0, 17) = 116
        'Matriz(0, 18) = 117
        'Matriz(0, 19) = 7
        'Matriz(0, 20) = 8
        'Matriz(0, 21) = 9
        'Matriz(0, 22) = 301
        'Matriz(0, 23) = 0
        'Matriz(0, 24) = 302
        '''
        'Matriz(1, 0) = 108
        'Matriz(1, 1) = 108
        'Matriz(1, 2) = 108
        'Matriz(1, 3) = 108
        'Matriz(1, 4) = 108
        'Matriz(1, 5) = 108
        'Matriz(1, 6) = 108
        'Matriz(1, 7) = 107
        'Matriz(1, 8) = 108
        'Matriz(1, 9) = 106
        'Matriz(1, 10) = 108
        'Matriz(1, 11) = 108
        'Matriz(1, 12) = 108
        'Matriz(1, 13) = 108
        'Matriz(1, 14) = 108
        'Matriz(1, 15) = 108
        'Matriz(1, 16) = 108
        'Matriz(1, 17) = 108
        'Matriz(1, 18) = 108
        'Matriz(1, 19) = 108
        'Matriz(1, 20) = 108
        'Matriz(1, 21) = 108
        'Matriz(1, 22) = 108
        'Matriz(1, 23) = 108
        'Matriz(1, 24) = 108
        '''
        'Matriz(2, 0) = 300
        'Matriz(2, 1) = 300
        'Matriz(2, 2) = 300
        'Matriz(2, 3) = 300
        'Matriz(2, 4) = 300
        'Matriz(2, 5) = 300
        'Matriz(2, 6) = 300
        'Matriz(2, 7) = 300
        'Matriz(2, 8) = 300
        'Matriz(2, 9) = 300
        'Matriz(2, 10) = 300
        'Matriz(2, 11) = 300
        'Matriz(2, 12) = 111
        'Matriz(2, 13) = 300
        'Matriz(2, 14) = 300
        'Matriz(2, 15) = 300
        'Matriz(2, 16) = 300
        'Matriz(2, 17) = 300
        'Matriz(2, 18) = 300
        'Matriz(2, 19) = 300
        'Matriz(2, 20) = 300
        'Matriz(2, 21) = 300
        'Matriz(2, 22) = 300
        'Matriz(2, 23) = 300
        'Matriz(2, 24) = 300
        '''
        'Matriz(3, 0) = 119
        'Matriz(3, 1) = 119
        'Matriz(3, 2) = 119
        'Matriz(3, 3) = 119
        'Matriz(3, 4) = 119
        'Matriz(3, 5) = 119
        'Matriz(3, 6) = 119
        'Matriz(3, 7) = 118
        'Matriz(3, 8) = 119
        'Matriz(3, 9) = 119
        'Matriz(3, 10) = 119
        'Matriz(3, 11) = 119
        'Matriz(3, 12) = 119
        'Matriz(3, 13) = 119
        'Matriz(3, 14) = 119
        'Matriz(3, 15) = 119
        'Matriz(3, 16) = 119
        'Matriz(3, 17) = 119
        'Matriz(3, 18) = 119
        'Matriz(3, 19) = 119
        'Matriz(3, 20) = 119
        'Matriz(3, 21) = 119
        'Matriz(3, 22) = 119
        'Matriz(3, 23) = 119
        'Matriz(3, 24) = 119
        '''
        'Matriz(4, 0) = 4
        'Matriz(4, 1) = 4
        'Matriz(4, 2) = 100
        'Matriz(4, 3) = 4
        'Matriz(4, 4) = 4
        'Matriz(4, 5) = 4
        'Matriz(4, 6) = 4
        'Matriz(4, 7) = 4
        'Matriz(4, 8) = 4
        'Matriz(4, 9) = 4
        'Matriz(4, 10) = 4
        'Matriz(4, 11) = 4
        'Matriz(4, 12) = 4
        'Matriz(4, 13) = 4
        'Matriz(4, 14) = 4
        'Matriz(4, 15) = 4
        'Matriz(4, 16) = 4
        'Matriz(4, 17) = 4
        'Matriz(4, 18) = 4
        'Matriz(4, 19) = 4
        'Matriz(4, 20) = 4
        'Matriz(4, 21) = 4
        'Matriz(4, 22) = 4
        'Matriz(4, 23) = 4
        'Matriz(4, 24) = 4
        '''
        'Matriz(5, 0) = 109
        'Matriz(5, 1) = 109
        'Matriz(5, 2) = 109
        'Matriz(5, 3) = 6
        'Matriz(5, 4) = 109
        'Matriz(5, 5) = 109
        'Matriz(5, 6) = 109
        'Matriz(5, 7) = 109
        'Matriz(5, 8) = 109
        'Matriz(5, 9) = 109
        'Matriz(5, 10) = 109
        'Matriz(5, 11) = 109
        'Matriz(5, 12) = 109
        'Matriz(5, 13) = 109
        'Matriz(5, 14) = 109
        'Matriz(5, 15) = 109
        'Matriz(5, 16) = 109
        'Matriz(5, 17) = 109
        'Matriz(5, 18) = 109
        'Matriz(5, 19) = 109
        'Matriz(5, 20) = 109
        'Matriz(5, 21) = 109
        'Matriz(5, 22) = 109
        'Matriz(5, 23) = 109
        'Matriz(5, 24) = 109
        '''
        'Matriz(6, 0) = 6
        'Matriz(6, 1) = 6
        'Matriz(6, 2) = 6
        'Matriz(6, 3) = 15
        'Matriz(6, 4) = 6
        'Matriz(6, 5) = 6
        'Matriz(6, 6) = 6
        'Matriz(6, 7) = 6
        'Matriz(6, 8) = 6
        'Matriz(6, 9) = 6
        'Matriz(6, 10) = 6
        'Matriz(6, 11) = 6
        'Matriz(6, 12) = 6
        'Matriz(6, 13) = 6
        'Matriz(6, 14) = 6
        'Matriz(6, 15) = 6
        'Matriz(6, 16) = 6
        'Matriz(6, 17) = 6
        'Matriz(6, 18) = 6
        'Matriz(6, 19) = 6
        'Matriz(6, 20) = 6
        'Matriz(6, 21) = 6
        'Matriz(6, 22) = 6
        'Matriz(6, 23) = 6
        'Matriz(6, 24) = 6
        '''
        'Matriz(7, 0) = 303
        'Matriz(7, 1) = 303
        'Matriz(7, 2) = 303
        'Matriz(7, 3) = 303
        'Matriz(7, 4) = 303
        'Matriz(7, 5) = 303
        'Matriz(7, 6) = 303
        'Matriz(7, 7) = 303
        'Matriz(7, 8) = 303
        'Matriz(7, 9) = 303
        'Matriz(7, 10) = 303
        'Matriz(7, 11) = 303
        'Matriz(7, 12) = 303
        'Matriz(7, 13) = 303
        'Matriz(7, 14) = 303
        'Matriz(7, 15) = 303
        'Matriz(7, 16) = 303
        'Matriz(7, 17) = 303
        'Matriz(7, 18) = 606
        'Matriz(7, 19) = 120
        'Matriz(7, 20) = 303
        'Matriz(7, 21) = 303
        'Matriz(7, 22) = 303
        'Matriz(7, 23) = 303
        'Matriz(7, 24) = 303
        '''
        'Matriz(8, 0) = 304
        'Matriz(8, 1) = 304
        'Matriz(8, 2) = 304
        'Matriz(8, 3) = 304
        'Matriz(8, 4) = 304
        'Matriz(8, 5) = 304
        'Matriz(8, 6) = 304
        'Matriz(8, 7) = 121
        'Matriz(8, 8) = 304
        'Matriz(8, 9) = 304
        'Matriz(8, 10) = 304
        'Matriz(8, 11) = 304
        'Matriz(8, 12) = 304
        'Matriz(8, 13) = 304
        'Matriz(8, 14) = 304
        'Matriz(8, 15) = 304
        'Matriz(8, 16) = 304
        'Matriz(8, 17) = 304
        'Matriz(8, 18) = 304
        'Matriz(8, 19) = 304
        'Matriz(8, 20) = 304
        'Matriz(8, 21) = 304
        'Matriz(8, 22) = 304
        'Matriz(8, 23) = 304
        'Matriz(8, 24) = 304
        ''       '
        'Matriz(9, 0) = 122
        'Matriz(9, 1) = 122
        'Matriz(9, 2) = 122
        'Matriz(9, 3) = 122
        'Matriz(9, 4) = 122
        'Matriz(9, 5) = 122
        'Matriz(9, 6) = 122
        'Matriz(9, 7) = 122
        'Matriz(9, 8) = 122
        'Matriz(9, 9) = 122
        'Matriz(9, 10) = 122
        'Matriz(9, 11) = 122
        'Matriz(9, 12) = 122
        'Matriz(9, 13) = 122
        'Matriz(9, 14) = 122
        'Matriz(9, 15) = 122
        'Matriz(9, 16) = 122
        'Matriz(9, 17) = 122
        'Matriz(9, 18) = 122
        'Matriz(9, 19) = 122
        'Matriz(9, 20) = 122
        'Matriz(9, 21) = 123
        'Matriz(9, 22) = 122
        'Matriz(9, 23) = 122
        'Matriz(9, 24) = 122
        '''
        'Matriz(10, 0) = 305
        'Matriz(10, 1) = 11
        'Matriz(10, 2) = 305
        'Matriz(10, 3) = 305
        'Matriz(10, 4) = 305
        'Matriz(10, 5) = 305
        'Matriz(10, 6) = 305
        'Matriz(10, 7) = 305
        'Matriz(10, 8) = 305
        'Matriz(10, 9) = 305
        'Matriz(10, 10) = 305
        'Matriz(10, 11) = 305
        'Matriz(10, 12) = 305
        'Matriz(10, 13) = 305
        'Matriz(10, 14) = 305
        'Matriz(10, 15) = 305
        'Matriz(10, 16) = 305
        'Matriz(10, 17) = 305
        'Matriz(10, 18) = 305
        'Matriz(10, 19) = 305
        'Matriz(10, 20) = 305
        'Matriz(10, 21) = 305
        'Matriz(10, 22) = 305
        'Matriz(10, 23) = 305
        'Matriz(10, 24) = 305
        '''
        'Matriz(11, 0) = 124
        'Matriz(11, 1) = 11
        'Matriz(11, 2) = 124
        'Matriz(11, 3) = 124
        'Matriz(11, 4) = 124
        'Matriz(11, 5) = 124
        'Matriz(11, 6) = 124
        'Matriz(11, 7) = 124
        'Matriz(11, 8) = 124
        'Matriz(11, 9) = 124
        'Matriz(11, 10) = 124
        'Matriz(11, 11) = 124
        'Matriz(11, 12) = 124
        'Matriz(11, 13) = 124
        'Matriz(11, 14) = 124
        'Matriz(11, 15) = 124
        'Matriz(11, 16) = 124
        'Matriz(11, 17) = 124
        'Matriz(11, 18) = 124
        'Matriz(11, 19) = 124
        'Matriz(11, 20) = 124
        'Matriz(11, 21) = 124
        'Matriz(11, 22) = 124
        'Matriz(11, 23) = 124
        'Matriz(11, 24) = 124
        '''
        'Matriz(12, 0) = 125
        'Matriz(12, 1) = 12
        'Matriz(12, 2) = 125
        'Matriz(12, 3) = 125
        'Matriz(12, 4) = 125
        'Matriz(12, 5) = 125
        'Matriz(12, 6) = 125
        'Matriz(12, 7) = 125
        'Matriz(12, 8) = 125
        'Matriz(12, 9) = 125
        'Matriz(12, 10) = 125
        'Matriz(12, 11) = 125
        'Matriz(12, 12) = 125
        'Matriz(12, 13) = 125
        'Matriz(12, 14) = 10
        'Matriz(12, 15) = 125
        'Matriz(12, 16) = 125
        'Matriz(12, 17) = 125
        'Matriz(12, 18) = 125
        'Matriz(12, 19) = 125
        'Matriz(12, 20) = 125
        'Matriz(12, 21) = 125
        'Matriz(12, 22) = 125
        'Matriz(12, 23) = 125
        'Matriz(12, 24) = 125

        'Matriz(13, 0) = 13
        'Matriz(13, 1) = 13
        'Matriz(13, 2) = 126
        'Matriz(13, 3) = 126
        'Matriz(13, 4) = 126
        'Matriz(13, 5) = 126
        'Matriz(13, 6) = 126
        'Matriz(13, 7) = 126
        'Matriz(13, 8) = 126
        'Matriz(13, 9) = 126
        'Matriz(13, 10) = 126
        'Matriz(13, 11) = 126
        'Matriz(13, 12) = 126
        'Matriz(13, 13) = 126
        'Matriz(13, 14) = 126
        'Matriz(13, 15) = 126
        'Matriz(13, 16) = 126
        'Matriz(13, 17) = 126
        'Matriz(13, 18) = 126
        'Matriz(13, 19) = 126
        'Matriz(13, 20) = 126
        'Matriz(13, 21) = 14
        'Matriz(13, 22) = 126
        'Matriz(13, 23) = 126
        'Matriz(13, 24) = 126


        'Matriz(14, 0) = 13
        'Matriz(14, 1) = 13
        'Matriz(14, 2) = 306
        'Matriz(14, 3) = 306
        'Matriz(14, 4) = 306
        'Matriz(12, 5) = 306
        'Matriz(14, 6) = 306
        'Matriz(14, 7) = 306
        'Matriz(14, 8) = 306
        'Matriz(14, 9) = 306
        'Matriz(14, 10) = 306
        'Matriz(14, 11) = 306
        'Matriz(14, 12) = 306
        'Matriz(14, 13) = 306
        'Matriz(14, 14) = 306
        'Matriz(14, 15) = 306
        'Matriz(14, 16) = 306
        'Matriz(14, 17) = 306
        'Matriz(14, 18) = 306
        'Matriz(14, 19) = 306
        'Matriz(14, 20) = 306
        'Matriz(14, 21) = 306
        'Matriz(14, 22) = 306
        'Matriz(14, 23) = 306
        'Matriz(14, 24) = 306

        'Matriz(15, 0) = 6
        'Matriz(15, 1) = 6
        'Matriz(15, 2) = 6
        'Matriz(15, 3) = 101
        'Matriz(15, 4) = 6
        'Matriz(15, 5) = 6
        'Matriz(15, 6) = 6
        'Matriz(15, 7) = 6
        'Matriz(15, 8) = 6
        'Matriz(15, 9) = 6
        'Matriz(15, 10) = 6
        'Matriz(15, 11) = 6
        'Matriz(15, 12) = 6
        'Matriz(15, 13) = 6
        'Matriz(15, 14) = 6
        'Matriz(15, 15) = 6
        'Matriz(15, 16) = 6
        'Matriz(15, 17) = 6
        'Matriz(15, 18) = 6
        'Matriz(15, 19) = 6
        'Matriz(15, 20) = 6
        'Matriz(15, 21) = 6
        'Matriz(15, 22) = 6
        'Matriz(15, 23) = 6
        'Matriz(15, 24) = 6

    End Sub
    Private Function Columnas(cara As String) As Integer
        Dim col As Integer

        If (Asc(cara) >= 65 And Asc(cara) <= 90) Or (Asc(cara) >= 97 And Asc(cara) <= 122) Then
            col = 0
        ElseIf (Asc(cara) >= 48 And Asc(cara) <= 57) Then
            col = 1
        ElseIf cara = "'" Then
            col = 2
        ElseIf cara = "/" Then
            col = 3
        ElseIf cara = "+" Then
            col = 4
        ElseIf cara = "-" Then
            col = 5
        ElseIf cara = "#" Then
            col = 6
        ElseIf cara = "=" Then
            col = 7
        ElseIf cara = "<" Then
            col = 8
        ElseIf cara = ">" Then
            col = 9
        ElseIf cara = "\" Then
            col = 10
        ElseIf cara = "$" Then
            col = 11
        ElseIf cara = "&" Then
            col = 12
        ElseIf cara = ";" Then
            col = 13
        ElseIf cara = "." Then
            col = 14
        ElseIf cara = "(" Then
            col = 15
        ElseIf cara = ")" Then
            col = 16
        ElseIf cara = "," Then
            col = 17
        ElseIf cara = "^" Then
            col = 18
        ElseIf cara = "|" Then
            col = 19
        ElseIf cara = "!" Then
            col = 20
        ElseIf cara = "*" Then
            col = 21
        ElseIf cara = "_" Then
            col = 22
        ElseIf cara = " " Then
            col = 23
        Else
            col = 24
        End If
        Return col
    End Function
    Private Sub BuscaPalabraReservada()
        Dim linea = 0
        Dim palres
        While (linea < VectorPalabrasReservadas.Length)
            palres = VectorPalabrasReservadas(linea).ToString()
            If UCase(palres) = UCase(token) Then
                PR = True
                DirPR = linea + 1
            End If
            linea += 1
        End While
    End Sub
    Private Sub BuscaUnicas(txtU As ListBox)
        Dim encontro
        Dim renglon2
        encontro = False 'False - No la a encontrado, Verdadero - Ya la encontro
        renglon2 = 0
        '*-
        'while (verdadera)  and (verdadera)
        While (Not (encontro)) And (renglon2 < txtU.Items.Count)
            txtU.SelectedIndex = renglon2
            If (UCase(token) = UCase(txtU.Text)) Then 'compara las varables en modo mayusculas
                encontro = True
                Direc = renglon2 + 1
            End If
            renglon2 = renglon2 + 1
        End While
        If (Not (encontro)) Then
            txtU.Items.Add(token)
            Direc = renglon2 + 1
        End If
    End Sub
    Private Sub ReconoceToken()
        If estado = 100 Then
            errores = False
            token = token + caracter
            BuscaUnicas(lbStr)
            DGVSalida.Rows.Add(token, "Cte. String", Direc.ToString)
        ElseIf estado = 101 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " Comentario ", "")
        ElseIf estado = 102 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 103 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 104 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 105 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 106 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 107 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 108 Then
            errores = False
            DGVSalida.Rows.Add(token, " C. Especial ", "")
            posicion = posicion - 1
        ElseIf estado = 109 Then
            errores = False
            DGVSalida.Rows.Add(token, " C. Especial ", "")
            posicion = posicion - 1
        ElseIf estado = 110 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 111 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 112 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 113 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 114 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 115 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 116 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 117 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 118 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 119 Then
            errores = False
            DGVSalida.Rows.Add(token, " C. Especial ", "")
            posicion = posicion - 1
        ElseIf estado = 120 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 121 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 122 Then
            errores = False
            DGVSalida.Rows.Add(token, " C. Especial ", "")
            posicion = posicion - 1
        ElseIf estado = 123 Then
            errores = False
            token = token + caracter
            DGVSalida.Rows.Add(token, " C. Especial ", "")
        ElseIf estado = 124 Then
            errores = False
            BuscaUnicas(lbReal)
            DGVSalida.Rows.Add(token, " Cte. Real ", Direc.ToString())
            posicion = posicion - 1
        ElseIf estado = 125 Then
            errores = False
            BuscaUnicas(lbEnter)
            DGVSalida.Rows.Add(token, " Cte. Entera ", Direc.ToString())
            posicion = posicion - 1
        ElseIf estado = 126 Then
            errores = False
            posicion = posicion - 1
            PR = False
            BuscaPalabraReservada()
            If PR = False Then
                'No es palabra reservada
                BuscaUnicas(lbIden)
                DGVSalida.Rows.Add(token, "Ident.", Direc.ToString)
            Else
                'Es palabra reservada
                DGVSalida.Rows.Add(token, " PR. ", DirPR.ToString())
            End If
        ElseIf estado = 300 Then
            errores = True
            DGVSalida.Rows.Clear()
            MessageBox.Show("Expresión lógica erronea, se esperaba un &.")
        ElseIf estado = 301 Then
            errores = True
            DGVSalida.Rows.Clear()
            MessageBox.Show("Identificador invalido, no puede iniciar con guión bajo.")
        ElseIf estado = 302 Then
            errores = True
            DGVSalida.Rows.Clear()
            MessageBox.Show("Identificador invalido, puede iniciar solamente con una letra.")
        ElseIf estado = 303 Then
            errores = True
            DGVSalida.Rows.Clear()
            MessageBox.Show("Expresión lógica invalida, se esperaba |.")
        ElseIf estado = 304 Then
            errores = True
            DGVSalida.Rows.Clear()
            MessageBox.Show("Expresión lógica invalida, se esperaba =.")
        ElseIf estado = 305 Then
            errores = True
            DGVSalida.Rows.Clear()
            MessageBox.Show("Identificador invalido, no puede iniciar con punto.")
        ElseIf estado = 306 Then
            errores = True
            DGVSalida.Rows.Clear()
            MessageBox.Show("Identificador invalido, no puede terminar en guión bajo.")
        End If
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim dialogoGuardar As New SaveFileDialog

        If (dialogoGuardar.ShowDialog() = DialogResult.Cancel) Then
            Return
        End If
        Dim archivo As String = dialogoGuardar.FileName
        Dim sw As StreamWriter = New StreamWriter(archivo)
        If DGVSalida.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DGVSalida.Rows
                If Fila.Cells("Token").Value <> "" Then
                    sw.WriteLine(Fila.Cells("Token").Value + ", " + Fila.Cells("Tipo").Value + ", " + Fila.Cells("Directorio").Value)
                End If
            Next
        End If

        sw.Close()
    End Sub
End Class
