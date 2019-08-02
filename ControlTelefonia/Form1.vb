Imports System
Imports System.IO
Imports System.Collections
Imports System.Data.SqlClient
Imports System.Data.Odbc
Imports System.Data


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        'TODO: esta línea de código carga datos en la tabla 'IntranetDataSet.TL_CONTROL_TELEFONIA' Puede moverla o quitarla según sea necesario.
        'Me.TL_CONTROL_TELEFONIATableAdapter.Fill(Me.IntranetDataSet.TL_CONTROL_TELEFONIA)

    End Sub

    Private Sub btnCargarFichero_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cargar.Click

        Dim objReader As New StreamReader("C:\Users\RPOS\BT\bt.txt")
        Dim sLine As String = ""
        Dim arrText As New ArrayList()

        Dim factura As String
        Dim tipoLinea As String
        Dim centroGasto As String
        Dim concepto As String
        Dim linea As String
        Dim tarifa As String
        Dim importe As String
        Dim fecha As Date
        Dim division As String
        Dim usuario As String
        Dim ubicacion As String


        Dim totalMovil As Decimal
        Dim totalFijo As Decimal

        Dim totalConsumoMovil As Decimal
        Dim totalConsumoFijo As Decimal


        Dim myConnection As OdbcConnection = New OdbcConnection()
        myConnection.ConnectionString = "DSN=INTRANET;UID=glpi;Pwd=glpi"

        myConnection.Open()


        Dim SqlCommand As String
        Dim myCommand As New OdbcCommand()


        myCommand.Connection = myConnection
        Dim myAdapter As New OdbcDataAdapter



        Dim row() As String

        Do
            sLine = Replace(objReader.ReadLine(), "�", "o")
            If Not sLine Is Nothing Then
                'arrText.Add(sLine)
                row = Split(sLine, "	")

                usuario = ""
                ubicacion = ""
                tarifa = ""
                importe = 0
                tipoLinea = ""
                centroGasto = ""
                concepto = ""
                linea = ""


                'recupera el numero de factura
                If row(0).Substring(0, 3) = "120" Then
                    factura = row(2)
                End If

                'recupera la division
                If row(0).Substring(0, 3) = "190" Then
                    division = row(4)
                End If

                'consumo de telefonia fija y movil
                If row(0).Substring(0, 3) = "230" Then
                    centroGasto = row(3)
                    tipoLinea = row(5)
                    concepto = row(7)
                    importe = row(9)

                    If importe <> "0,0000" Then
                        importe = Replace(importe, ",", ".")
                        importe = Convert.ToDecimal(importe)

                        Select Case centroGasto
                            Case "S285877"
                                centroGasto = "100"
                            Case "S264425"
                                centroGasto = "100"
                            Case "S374792"
                                centroGasto = "300"
                            Case "S648334"
                                centroGasto = "420"
                            Case "S648375"
                                centroGasto = "400"
                            Case "S650275"
                                centroGasto = "200"

                            Case "S650276"
                                centroGasto = "200"
                            Case "S654549"
                                centroGasto = "420"
                        End Select

                        DataGridView1.Rows.Add(division, factura, tipoLinea, centroGasto, concepto, linea, fecha, importe)

                        If tipoLinea = "BT Movil" Then
                            totalConsumoMovil += importe
                        Else
                            totalConsumoFijo += importe
                        End If
                    End If
                End If


                'ajustes: 010 
                If (row(0).Substring(0, 3) = "010") Then
                    centroGasto = row(3)
                    tipoLinea = row(5)
                    concepto = row(1) + " - " + row(11)
                    importe = row(9)
                    linea = row(24).TrimStart("0").Trim


                    If importe <> "0,0000" Then

                        importe = Replace(importe, ",", ".")
                        importe = Convert.ToDecimal(importe)

                        Select Case centroGasto
                            Case "S285877"
                                centroGasto = "100"
                            Case "S264425"
                                centroGasto = "100"
                            Case "S374792"
                                centroGasto = "300"
                            Case "S648334"
                                centroGasto = "420"
                            Case "S648375"
                                centroGasto = "400"
                            Case "S650275"
                                centroGasto = "200"

                            Case "S650276"
                                centroGasto = "200"
                            Case "S654549"
                                centroGasto = "420"
                        End Select
                        DataGridView1.Rows.Add(division, factura, tipoLinea, centroGasto, concepto, linea, fecha, importe, usuario, ubicacion, tarifa)
                    End If
                End If

                'descuentos: 060 
                If (row(0).Substring(0, 3) = "060") Then

                    tipoLinea = row(5)
                    concepto = row(7)
                    importe = row(9)


                    If importe <> "0,0000" Then

                        importe = Replace(importe, ",", ".")
                        importe = Convert.ToDecimal(importe)
                        Select Case centroGasto
                            Case "S285877"
                                centroGasto = "100"
                            Case "S264425"
                                centroGasto = "100"
                            Case "S374792"
                                centroGasto = "300"
                            Case "S648334"
                                centroGasto = "420"
                            Case "S648375"
                                centroGasto = "400"
                            Case "S650275"
                                centroGasto = "200"

                            Case "S650276"
                                centroGasto = "200"
                            Case "S654549"
                                centroGasto = "420"
                        End Select
                        DataGridView1.Rows.Add(division, factura, tipoLinea, centroGasto, concepto, linea, fecha, importe, usuario, ubicacion, tarifa)
                    End If
                End If

                'tarifas configuradas: 030 
                If (row(0).Substring(0, 3) = "030") Then
                    centroGasto = row(3)
                    tipoLinea = row(5)
                    linea = row(6).TrimStart("0").Trim

                    concepto = row(7)
                    importe = row(9)
                    fecha = row(11)

                    If importe <> "0,0000" Then

                        importe = Replace(importe, ",", ".")
                        importe = Convert.ToDecimal(importe)

                        'recuperar los datos de los usuarios

                        SqlCommand = "SELECT T1.name as usuario, T2.name as ubicacion, T3.name as tarifa FROM glpi.glpi_plugin_simcard_simcards T1 LEFT OUTER JOIN glpi.glpi_locations T2 ON T2.id = T1.locations_id LEFT OUTER JOIN  glpi.glpi_plugin_simcard_simcardtypes T3 ON T1.plugin_simcard_simcardtypes_id = T3.id where phonenumber ='" + linea + "'"

                        myCommand.CommandText = SqlCommand 'start query
                        myAdapter.SelectCommand = myCommand
                        Dim moddata As OdbcDataReader
                        moddata = myCommand.ExecuteReader()
                        While moddata.Read = True
                            Try
                                usuario = (moddata("usuario"))
                                ubicacion = (moddata("ubicacion"))
                                tarifa = (moddata("tarifa"))
                            Catch ex As Exception
                                'usuario = "ERROR"
                                'ubicacion = "ERROR"
                                tarifa = ""
                            End Try
                        End While

                        moddata.Close()

                        ' fin recuperar los datos de los usuarios
                        Select Case centroGasto
                            Case "S285877"
                                centroGasto = "100"
                            Case "S264425"
                                centroGasto = "100"
                            Case "S374792"
                                centroGasto = "300"
                            Case "S648334"
                                centroGasto = "420"
                            Case "S648375"
                                centroGasto = "400"
                            Case "S650275"
                                centroGasto = "200"

                            Case "S650276"
                                centroGasto = "410"
                            Case "S654549"
                                centroGasto = "420"
                        End Select

                        DataGridView1.Rows.Add(division, factura, tipoLinea, centroGasto, concepto, linea, fecha, importe, usuario, ubicacion, tarifa)
                        If tipoLinea = "BT Movil" Then
                            totalMovil += importe
                        End If

                        If (tipoLinea = "BT iComms") Or (tipoLinea = "BT VOZ IP") Then
                            totalFijo += importe
                        End If




                    End If
                End If
            End If





        Loop Until sLine Is Nothing
        objReader.Close()

        txtTotalMovil.Text = totalMovil
        txtTotalFijo.Text = totalFijo
        txtImporteConsumoMovil.Text = totalConsumoMovil
        txtImporteConsumoFijo.Text = totalConsumoFijo

        'For Each sLine In arrText
        ' Console.WriteLine(sLine)
        ' Siguiente
        'Console.ReadLine()


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fichero As String
        Dim dlAbrir As New System.Windows.Forms.OpenFileDialog

        dlAbrir.Filter = "Archivos de Texto (*.txt)|*.txt|" &
            "Archivos de log (*.log)|*.log|" &
            "Todos los archivos (*.*)|*.*"
        dlAbrir.Multiselect = False
        dlAbrir.CheckFileExists = False
        dlAbrir.Title = "Selección de fichero"
        dlAbrir.ShowDialog()
        If dlAbrir.FileName <> "" Then
            fichero = dlAbrir.FileName
            txtFichero.Text = fichero
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtFichero.TextChanged

    End Sub
End Class
