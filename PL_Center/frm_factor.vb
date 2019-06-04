Imports System
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Globalization
Imports System.Configuration
Public Class frm_factor

    Dim objCmd As SqlCommand
    Dim objadap As SqlDataAdapter
    Dim objConn As SqlConnection

    Dim dtbLFB_PL_LonFactor As DataTable
    Dim countrow As Integer
    Dim sql As String
    Dim Ds As DataSet

    Private Sub frm_factor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_LFB_ITEM_DataSet._LFB_PL_Lon_Factor' table. You can move, or remove it, as needed.


        dtbLFB_PL_LonFactor = _LFB_ITEM_DataSet._LFB_PL_Lon_Factor

        Me.LFB_PL_Lon_FactorTableAdapter.Fill(Me.dtbLFB_PL_LonFactor)




    End Sub

    'Private Sub AllmoveData()

    '    Dim iorder As String = ""


    '    If _LFB_ITEM_DataSet._LFB_PL_Lon_Factor.Select("").Length > 0 Then
    '        Dim rows() As DataRow = _LFB_ITEM_DataSet._LFB_PL_Lon_Factor.Select("", "[ID] ASC")
    '        If rows.Count > 0 Then
    '            countrow = rows.Count
    '            movdata(rows)
    '        End If
    '    End If


    'End Sub
    'Private Sub movdata(ByVal vrows() As DataRow)

    '    'dgv_salesorder.Rows.Clear()
    '    dgv_factor.Rows.Add(countrow)

    '    'irowsdetcount()
    '    If vrows.Count > 0 Then
    '        For i As Integer = 0 To vrows.Count - 1


    '            If IsDBNull(vrows(i).Item("ID")) = False Then
    '                dgv_factor.Rows(i).Cells(0).Value = vrows(i).Item("ID")
    '            End If
    '            'รหัสสินค้า
    '            If IsDBNull(vrows(i).Item("lon")) = False Then
    '                dgv_factor.Rows(i).Cells(1).Value = vrows(i).Item("lon")
    '            End If

    '            'รายละเอียดสินค้า
    '            If IsDBNull(vrows(i).Item("C")) = False Then
    '                dgv_factor.Rows(i).Cells(2).Value = vrows(i).Item("C")
    '            End If

    '            'location
    '            If IsDBNull(vrows(i).Item("D")) = False Then
    '                dgv_factor.Rows(i).Cells(3).Value = vrows(i).Item("D")
    '            End If

    '            'location
    '            If IsDBNull(vrows(i).Item("E")) = False Then
    '                dgv_factor.Rows(i).Cells(3).Value = vrows(i).Item("D")
    '            End If

    '            'location
    '            If IsDBNull(vrows(i).Item("F")) = False Then
    '                dgv_factor.Rows(i).Cells(3).Value = vrows(i).Item("F")
    '            End If



    '            'หน่วย
    '            If IsDBNull(vrows(i).Item("G")) = False Then
    '                dgv_factor.Rows(i).Cells(6).Value = vrows(i).Item("G")
    '            End If



    '        Next

    '    End If


    'End Sub


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        savefactor()
        Me.LFB_PL_Lon_FactorTableAdapter.Fill(Me.dtbLFB_PL_LonFactor)

    End Sub

    Private Sub savefactor()


        Dim ilon As String = ""
        Dim ixC As Double = 0
        Dim ixD As Double = 0
        Dim ixE As Double = 0
        Dim ixF As String = ""
        Dim ixG As String = ""



        objConn = New SqlConnection(_connetion)
        objConn.Open()


        Dim isqldel As String = ""
        Dim isqlcount As String = ""
        Dim isqlcomman As String = ""


        isqldel = "Delete [LFB_PL$Lon Factor] "
        objCmd = New SqlCommand(isqldel, objConn)


        Try
            objCmd.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("มีข้อผิดพลาดในการลบ Factor")

        End Try

        objCmd = Nothing





        For i As Integer = 0 To dgv_factor.RowCount - 1

            If dgv_factor.Rows(0).Cells(1).Value = "" Then
                MsgBox("ไม่พบรายการายละเอียดสินค้า")
                Exit Sub
            End If

            If dgv_factor.Rows(i).Cells(1).Value = "" Then
                Exit For
            Else

                ilon = dgv_factor.Rows(i).Cells(1).Value
                ixC = dgv_factor.Rows(i).Cells(2).Value
                ixD = dgv_factor.Rows(i).Cells(3).Value
                ixE = dgv_factor.Rows(i).Cells(4).Value
                ixF = dgv_factor.Rows(i).Cells(5).Value
                ixG = dgv_factor.Rows(i).Cells(6).Value





                isqlcomman = "INSERT INTO [LFB_PL$Lon Factor]" &
                                  "([ID]" &
                                  ",[Lon]" &
                                  ",[C]" &
                                  ",[D]" &
                                  ",[E]" &
                                  ",[F]" &
                                  ",[G])" &
                                      " VALUES ('" & i + 1 & "','" & ilon & "','" & ixC & "','" & ixD & "','" & ixE & "','" & ixF & "','" & ixG & "')"







            End If


            objCmd = New SqlCommand(isqlcomman, objConn)

            Try
                objCmd.ExecuteNonQuery()

            Catch ex As Exception

                MsgBox("มีข้อผิดพลาดในการบันทึก Factor")

            End Try


        Next



        RemovDet()


        For i As Integer = 0 To dgv_factor.RowCount - 1

            If dgv_factor.Rows(i).Cells(1).Value = "" Then
                Exit For
            Else


                ilon = dgv_factor.Rows(i).Cells(1).Value

                ixC = dgv_factor.Rows(i).Cells(2).Value
                ixD = dgv_factor.Rows(i).Cells(3).Value
                ixE = dgv_factor.Rows(i).Cells(4).Value
                ixF = dgv_factor.Rows(i).Cells(5).Value
                ixG = dgv_factor.Rows(i).Cells(6).Value



                Dim newDRows As DataRow = dtbLFB_PL_LonFactor.NewRow()
                With newDRows
                    .Item("ID") = i + 1
                    .Item("Lon") = ilon
                    .Item("C") = ixC
                    .Item("D") = ixD
                    .Item("E") = ixE
                    .Item("F") = ixF
                    .Item("G") = ixG

                End With

                dtbLFB_PL_LonFactor.Rows.Add(newDRows)
            End If


        Next


        objCmd = Nothing
        objConn.Close()
        objConn = Nothing
        MsgBox("บันทึกสำเร็จ")

    End Sub


    Private Sub RemovDet()

        Dim irows() As DataRow = dtbLFB_PL_LonFactor.Select("")
        If irows.Count > 0 Then
            For i As Integer = 0 To irows.Count - 1
                dtbLFB_PL_LonFactor.Rows.Remove(irows(i))
            Next
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Me.LFB_PL_Lon_FactorTableAdapter.Fill(dtbLFB_PL_LonFactor)
    End Sub
End Class