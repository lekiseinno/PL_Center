Imports System
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Globalization
Imports System.Configuration
Public Class frm_paper_cost

    Dim objCmd As SqlCommand
    Dim objadap As SqlDataAdapter
    Dim objConn As SqlConnection

    Dim dtbLFB_PL_PAPER_Base_Cost As DataTable
    Dim countrow As Integer
    Dim sql As String
    Dim Ds As DataSet


    Private Sub frm_paper_cost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_LFB_ITEM_DataSet._LFB_PL_PAPER_Base_Cost' table. You can move, or remove it, as needed.

        dtbLFB_PL_PAPER_Base_Cost = Me._LFB_ITEM_DataSet._LFB_PL_PAPER_Base_Cost
        Me.LFB_PL_PAPER_Base_CostTableAdapter.Fill(dtbLFB_PL_PAPER_Base_Cost)




    End Sub



    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        savePaperCost()

        Me.LFB_PL_PAPER_Base_CostTableAdapter.Fill(dtbLFB_PL_PAPER_Base_Cost)

    End Sub

    Private Sub savePaperCost()



        Dim iGrade As String = ""
        Dim iLFB_Code As String = ""
        Dim icost As String = ""
        Dim iGSM As String = ""
        Dim iEFFPLKG As String = ""
        Dim iEFFPLSQM As String = ""
        Dim iDiscount As String = ""
        Dim iEFFDSSQM As String = ""
        Dim iMIN As String = ""
        Dim iFight As String = ""
        Dim iSQMFigthing As String = ""
        Dim iSUP_CODE As String = ""
        Dim iCODE As String = ""




        objConn = New SqlConnection(_connetion)
        objConn.Open()


        Dim isqldel As String = ""
        Dim isqlcount As String = ""
        Dim isqlcomman As String = ""


        isqldel = "Delete [LFB_PL$PAPER Base Cost] "
        objCmd = New SqlCommand(isqldel, objConn)


        Try
            objCmd.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("มีข้อผิดพลาดในการลบ LFB_PL$PAPER Base Cost")

        End Try

        objCmd = Nothing





        For i As Integer = 0 To dgv_paperCost.RowCount - 1

            If dgv_paperCost.Rows(0).Cells(1).Value = "" Then
                MsgBox("ไม่พบรายการายละเอียดสินค้า")
                Exit Sub
            End If

            If dgv_paperCost.Rows(i).Cells(1).Value = "" Then
                Exit For
            Else

                iGrade = dgv_paperCost.Rows(i).Cells(1).Value
                iLFB_Code = dgv_paperCost.Rows(i).Cells(2).Value
                icost = dgv_paperCost.Rows(i).Cells(3).Value
                iGSM = dgv_paperCost.Rows(i).Cells(4).Value
                iEFFPLKG = dgv_paperCost.Rows(i).Cells(5).Value
                iEFFPLSQM = dgv_paperCost.Rows(i).Cells(6).Value
                iDiscount = dgv_paperCost.Rows(i).Cells(7).Value
                iEFFDSSQM = dgv_paperCost.Rows(i).Cells(8).Value
                iMIN = dgv_paperCost.Rows(i).Cells(9).Value
                iFight = dgv_paperCost.Rows(i).Cells(10).Value
                iSQMFigthing = dgv_paperCost.Rows(i).Cells(11).Value
                iSUP_CODE = dgv_paperCost.Rows(i).Cells(12).Value
                iCODE = dgv_paperCost.Rows(i).Cells(13).Value



                isqlcomman = "INSERT INTO [LFB_PL$PAPER Base Cost]" &
                                  "([ID]" &
                                  ",[Grade]" &
                                  ",[LFB_Code]" &
                                  ",[cost]" &
                                  ",[GSM]" &
                                  ",[EFF.PL$KG]" &
                                  ",[EFF.PL$SQM]" &
                                  ",[Discount]" &
                                  ",[EFF.DS$SQM]" &
                                  ",[MIN]" &
                                  ",[Fight]" &
                                  ",[SQM.Figthing]" &
                                  ",[SUP_CODE]" &
                                  ",[CODE])" &
                                      " VALUES ('" & i + 1 & "','" & iGrade & "','" & iLFB_Code & "','" & icost & "','" & iGSM & "','" & iEFFPLKG & "','" & iEFFPLSQM & "','" &
                                     iDiscount & "','" & iEFFDSSQM & "','" & iMIN & "','" & iFight & "','" & iSQMFigthing & "','" & iSUP_CODE & "','" & iCODE & "')"







            End If


            objCmd = New SqlCommand(isqlcomman, objConn)

            Try
                objCmd.ExecuteNonQuery()

            Catch ex As Exception

                MsgBox("มีข้อผิดพลาดในการบันทึก LFB_PL$PAPER Base Cost")

            End Try


        Next



        RemovDet()


        For i As Integer = 0 To dgv_paperCost.RowCount - 1

            If dgv_paperCost.Rows(i).Cells(1).Value = "" Then
                Exit For
            Else


                iGrade = dgv_paperCost.Rows(i).Cells(1).Value
                iLFB_Code = dgv_paperCost.Rows(i).Cells(2).Value
                icost = dgv_paperCost.Rows(i).Cells(3).Value
                iGSM = dgv_paperCost.Rows(i).Cells(4).Value
                iEFFPLKG = dgv_paperCost.Rows(i).Cells(5).Value
                iEFFPLSQM = dgv_paperCost.Rows(i).Cells(6).Value
                iDiscount = dgv_paperCost.Rows(i).Cells(7).Value
                iEFFDSSQM = dgv_paperCost.Rows(i).Cells(8).Value
                iMIN = dgv_paperCost.Rows(i).Cells(9).Value
                iFight = dgv_paperCost.Rows(i).Cells(10).Value
                iSQMFigthing = dgv_paperCost.Rows(i).Cells(11).Value
                iSUP_CODE = dgv_paperCost.Rows(i).Cells(12).Value
                iCODE = dgv_paperCost.Rows(i).Cells(13).Value



                Dim newDRows As DataRow = dtbLFB_PL_PAPER_Base_Cost.NewRow()
                With newDRows
                    .Item("ID") = i + 1
                    .Item("Grade") = iGrade
                    .Item("LFB_Code") = iLFB_Code
                    .Item("cost") = icost
                    .Item("GSM") = iGSM
                    .Item("EFF.PL$KG") = iEFFPLKG
                    .Item("EFF.PL$SQM") = iEFFPLSQM
                    .Item("Discount") = iDiscount
                    .Item("EFF.DS$SQM") = iEFFDSSQM
                    .Item("MIN") = iMIN
                    .Item("Fight") = iFight
                    .Item("SQM.Figthing") = iSQMFigthing
                    .Item("SUP_CODE") = iSUP_CODE
                    .Item("CODE") = iCODE

                End With

                dtbLFB_PL_PAPER_Base_Cost.Rows.Add(newDRows)
            End If


        Next


        objCmd = Nothing
        objConn.Close()
        objConn = Nothing
        MsgBox("บันทึกสำเร็จ")
    End Sub


    Private Sub RemovDet()

        Dim irows() As DataRow = dtbLFB_PL_PAPER_Base_Cost.Select("")
        If irows.Count > 0 Then
            For i As Integer = 0 To irows.Count - 1
                dtbLFB_PL_PAPER_Base_Cost.Rows.Remove(irows(i))
            Next
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        LFB_PL_PAPER_Base_CostTableAdapter.Fill(dtbLFB_PL_PAPER_Base_Cost)
    End Sub





End Class