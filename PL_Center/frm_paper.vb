Imports System
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Globalization
Imports System.Configuration

Public Class frm_paper

    Dim objCmd As SqlCommand
    Dim objadap As SqlDataAdapter
    Dim objConn As SqlConnection

    Dim dtbLFB_PL_PaperGrade As DataTable
    Dim countrow As Integer
    Dim sql As String
    Dim Ds As DataSet
    Dim dtp As DateTimePicker

    Private Sub frm_paper_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO: This line of code loads data into the '_LFB_ITEM_DataSet._LFB_PL_PAPER_Grade___Cost' table. You can move, or remove it, as needed.


        'dtbLFB_PL_PaperGrade = Me._LFB_ITEM_DataSet._LFB_PL_PAPER_Grade___Cost

        'Me.LFB_PL_PAPER_Grade___CostTableAdapter.Fill(dtbLFB_PL_PaperGrade)

        connectSQL()

        AllmoveData()

        'dtp = New DateTimePicker
        'dtp.Format = DateTimePickerFormat.Short
        'dtp.Visible = False
        'dtp.Width = 150
        'dgv_paper.Controls.Add(dtp)



        '   dtbLFB_PL_PaperGrade.Columns.Add("lastupdate", GetType(DateTime))


        'dtbLFB_PL_PaperGrade.Rows.Add(dtbLFB_PL_PaperGrade.Rows(0).Item("lastupdate").ToString("yyyy-MM-dd HH:mm:ss"))
        'dtbLFB_PL_PaperGrade.Rows.Add(DateTime.Now)


        'dtbLFB_PL_PaperGrade.Rows.Add(DateTime.Now).ToString().Format("yyyy-MM-dd HH:mm:ss")


        ''Dim col As New CalendarColumn() With {.HeaderText = "Date time"}
        ''DataGridView1.Columns.Insert(5, col)

        '' Dim column = New CalendarColumn()

        'Dim column As New CalendarColumn() With {.HeaderText = "lastupdate"}
        'column.DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"
        'column.DataPropertyName = "lastupdate"
        'column.Width = 150
        'Me.dgv_paper.Columns.Add(column)
        'Me.dgv_paper.DataSource = dtbLFB_PL_PaperGrade







        'Dim dt = New DataTable()

        'dtbLFB_PL_PaperGrade.Columns.Add("lastdate", GetType(DateTime)).ToString("yyyy-MM-dd HH:mm:ss")
        'dtbLFB_PL_PaperGrade.Rows.Add(Now)

        'Dim column = New CalendarColumn()
        'column.DataPropertyName = "lastdate"
        'Me.dgv_paper.Columns.Add(column).ToString("yyyy-MM-dd HH:mm:ss")
        'Me.dgv_paper.DataSource = dtbLFB_PL_PaperGrade





    End Sub

    Private Sub ddgv_paper_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) _
  Handles dgv_paper.RowPostPaint
        'สร้างเลขบรรทัด
        Using b As SolidBrush = New SolidBrush(dgv_paper.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(System.Globalization.CultureInfo.CurrentUICulture),
                  sender.DefaultCellStyle.Font,
                  b,
                  e.RowBounds.Location.X + 40,
                  e.RowBounds.Location.Y + 3,
                  New StringFormat(StringFormatFlags.DirectionRightToLeft))
        End Using
        'Me.dgv_salesorder("Index", e.RowIndex).Value = e.RowIndex
    End Sub

    Private Sub connectSQL()

        'สร้าง instance objConn  เพื่อติดต่อกับ MySQL ด้วย MySqlConnection
        objConn = New SqlConnection(_connetion)
        objConn.ConnectionString = _connetion
        objConn.Open()



        objadap = New SqlDataAdapter("SELECT * FROM [LFB_PL$PAPER Grade & Cost] order by ID ASC", objConn)
        Ds = New DataSet()
        objadap.Fill(Ds)

        'เปลี่ยนจาก Dataset เป็น Datatale
        dtbLFB_PL_PaperGrade = Ds.Tables(0)

        objadap = Nothing
        Ds = Nothing
        objConn.Close()
        objConn = Nothing


    End Sub

    Private Sub AllmoveData()

        Dim iorder As String = ""


        If dtbLFB_PL_PaperGrade.Select("").Length > 0 Then
            Dim rows() As DataRow = dtbLFB_PL_PaperGrade.Select("", "[ID] ASC")
            If rows.Count > 0 Then
                ' countrow = rows.Count
                movdata(rows)
            End If
        End If


    End Sub

    Private Sub movdata(ByVal vrows() As DataRow)

        Dim lastdate As Date

        dgv_paper.Rows.Add(vrows.Count)


        If vrows.Count > 0 Then
            For i As Integer = 0 To vrows.Count - 1


                If IsDBNull(vrows(i).Item("CODE")) = False Then
                    dgv_paper.Rows(i).Cells(0).Value = vrows(i).Item("CODE")
                End If


                If IsDBNull(vrows(i).Item("ETc")) = False Then
                    dgv_paper.Rows(i).Cells(1).Value = vrows(i).Item("ETc")
                End If

                If IsDBNull(vrows(i).Item("PUR")) = False Then
                    dgv_paper.Rows(i).Cells(2).Value = vrows(i).Item("PUR")
                End If


                If IsDBNull(vrows(i).Item("GRADE")) = False Then
                    dgv_paper.Rows(i).Cells(3).Value = vrows(i).Item("GRADE")
                End If

                lastdate = Now

                If IsDBNull(vrows(i).Item("lastupdate")) = False Then
                    lastdate = vrows(i).Item("lastupdate")
                    '  dgv_paper.Rows(i).Cells(4).Value = Format(dgv_paper.Rows(i).Cells(4).Value, "dd/MM/yyyy")
                    dgv_paper.Rows(i).Cells(4).Value = lastdate.ToString("dd/MM/yyyy")
                End If


            Next

        End If


    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        saveperperGrade()
        AllmoveData()
        '  Me.LFB_PL_PAPER_Grade___CostTableAdapter.Fill(dtbLFB_PL_PaperGrade)

    End Sub

    Private Sub saveperperGrade()


        Dim iCODE As String = ""
        Dim iETc As String = ""
        Dim iPUR As Double = 0
        Dim iGRADE As String = ""
        Dim ilastupdate As Date 

        Dim idate As String = ""



        objConn = New SqlConnection(_connetion)
        objConn.Open()


        Dim isqldel As String = ""
        Dim isqlcount As String = ""
        Dim isqlcomman As String = ""


        isqldel = "Delete [LFB_PL$PAPER Grade & Cost] "
        objCmd = New SqlCommand(isqldel, objConn)


        Try
            objCmd.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("มีข้อผิดพลาดในการลบ Factor")

        End Try

        objCmd = Nothing





        For i As Integer = 0 To dgv_paper.RowCount - 1

            If dgv_paper.Rows(0).Cells(1).Value = "" Then
                MsgBox("ไม่พบรายการายละเอียดสินค้า")
                Exit Sub
            End If

            If dgv_paper.Rows(i).Cells(0).Value = "" Then
                Exit For
            Else

                iCODE = dgv_paper.Rows(i).Cells(0).Value
                iETc = dgv_paper.Rows(i).Cells(1).Value
                iPUR = dgv_paper.Rows(i).Cells(2).Value
                iGRADE = dgv_paper.Rows(i).Cells(3).Value


                dgv_paper.Columns(4).DefaultCellStyle.Format = "yyyy-MM-dd"


                ilastupdate = dgv_paper.Rows(i).Cells(4).Value

                idate = DateTime.Parse(ilastupdate).ToString("yyyy-MM-dd")



                isqlcomman = "INSERT INTO [LFB_PL$PAPER Grade & Cost]" &
                                  "([ID]" &
                                  ",[CODE]" &
                                  ",[ETc]" &
                                  ",[PUR]" &
                                  ",[GRADE]" &
                                  ",[lastupdate])" &
                                      " VALUES ('" & i + 1 & "','" & iCODE & "','" & iETc & "','" & iPUR & "','" & iGRADE & "','" & idate & "')"







            End If


            objCmd = New SqlCommand(isqlcomman, objConn)

            Try
                objCmd.ExecuteNonQuery()

            Catch ex As Exception

                MsgBox("มีข้อผิดพลาดในการบันทึก Factor")

            End Try


        Next



        RemovDet()


        For i As Integer = 0 To dgv_paper.RowCount - 1

            If dgv_paper.Rows(i).Cells(1).Value = "" Then
                Exit For
            Else


                iCODE = dgv_paper.Rows(i).Cells(0).Value
                iETc = dgv_paper.Rows(i).Cells(1).Value
                iPUR = dgv_paper.Rows(i).Cells(2).Value
                iGRADE = dgv_paper.Rows(i).Cells(3).Value
                ilastupdate = dgv_paper.Rows(i).Cells(4).Value

                '   idate = dgv_paper.Rows(i).Cells(4).Value
                '  DateTime.Parse((mskdDateofbirth.Text).ToString("yyyy-MM-dd"))

                ' ilastupdate = DateTime.Parse(idate).ToString("yyyy-MM-dd")


                dgv_paper.Columns(4).DefaultCellStyle.Format = "yyyy-MM-dd"


                ilastupdate = dgv_paper.Rows(i).Cells(4).Value

                Dim newDRows As DataRow = dtbLFB_PL_PaperGrade.NewRow()
                With newDRows
                    .Item("ID") = i + 1
                    .Item("CODE") = iCODE
                    .Item("ETc") = iETc
                    .Item("PUR") = iPUR
                    .Item("GRADE") = iGRADE
                    .Item("lastupdate") = ilastupdate

                End With

                dtbLFB_PL_PaperGrade.Rows.Add(newDRows)
            End If


        Next


        objCmd = Nothing
        objConn.Close()
        objConn = Nothing
        MsgBox("บันทึกสำเร็จ")

    End Sub


    Private Sub RemovDet()

        Dim irows() As DataRow = dtbLFB_PL_PaperGrade.Select("")
        If irows.Count > 0 Then
            For i As Integer = 0 To irows.Count - 1
                dtbLFB_PL_PaperGrade.Rows.Remove(irows(i))
            Next
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click

        AllmoveData()
        '  Me.LFB_PL_PAPER_Grade___CostTableAdapter.Fill(dtbLFB_PL_PaperGrade)
    End Sub



    Private Sub dtp_ValueChanged(sender As Object, e As System.EventArgs)
        '// Display date value.
        dgv_paper.CurrentCell.Value = Format(dtp.Value, "dd/MM/yyyy")
    End Sub
    Private Sub dgv_paper_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_paper.CellClick

        Select Case e.ColumnIndex
            '// DateTimePicker
            Case 4
                dtp = New DateTimePicker
                '//Adding DateTimePicker control into DataGridView   
                dgv_paper.Controls.Add(dtp)

                '// Setting the format (i.e. 02/07/2017 - dd/mm/yyyy)
                dtp.Format = DateTimePickerFormat.Short

                '// It returns the retangular area that represents the Display area for a cell  
                Dim oRectangle = dgv_paper.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)

                '//Setting area for DateTimePicker Control  
                dtp.Size = New Size(oRectangle.Width, oRectangle.Height)

                '// Setting Location
                dtp.Location = New Point(oRectangle.X, oRectangle.Y)
                '// Read value from DataGridView into DateTimePicker
                ' dtp.Value = dgv_paper.CurrentCell.Value
                dtp.Value = Now
                '// Now make it visible  
                dtp.Visible = True
                '// Force to change date value at dtp_ValueChanged Event.
                AddHandler dtp.ValueChanged, AddressOf dtp_ValueChanged


        End Select
    End Sub



    'Private Sub dgv_paper_CellClick(sender As Object, e As DataGridViewCellEventArgs)



    '    'Try
    '    '    If e.ColumnIndex = 5 Then
    '    '        dtp.Location = dgv_paper.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False).Location
    '    '        dtp.Visible = True
    '    '        If IsDBNull(dgv_paper.CurrentCell.Value) = False Then
    '    '            dtp.Value = dgv_paper.CurrentCell.Value
    '    '        Else
    '    '            dtp.Value = Now
    '    '        End If
    '    '    End If

    '    'Catch ex As Exception
    '    '    MessageBox.Show(ex.Message)
    '    'End Try



    '    'Dim i As Integer

    '    'With dgv_paper

    '    '    i = e.RowIndex

    '    '    If .Rows(i).Cells(0).Value.ToString <> "" Then
    '    '        txtpaper_id.Text = i + 1
    '    '    End If


    '    '    If (.Rows(i).Cells(1).ToString) = "" Then

    '    '        Exit Sub
    '    '    Else

    '    '        If .Rows(i).Cells(1).Value.ToString <> "" Then
    '    '            txtpaper_code.Text = .Rows(i).Cells(1).ToString
    '    '        End If

    '    '        If .Rows(i).Cells(2).Value.ToString <> "" Then

    '    '            txtpaper_etc.Text = .Rows(i).Cells(2).ToString
    '    '        End If

    '    '        If .Rows(i).Cells(3).Value.ToString <> "" Then

    '    '            txtpaper_pur.Text = .Rows(i).Cells(3).ToString
    '    '        End If

    '    '        If .Rows(i).Cells(4).Value.ToString <> "" Then
    '    '            txtpaper_grade.Text = .Rows(i).Cells(4).ToString
    '    '        End If

    '    '        If .Rows(i).Cells(5).Value.ToString <> "" Then
    '    '            MsgBox(.Rows(i).Cells(5).ToString)

    '    '            txtpaper_update.Text = .Rows(i).Cells(5).ToString
    '    '        End If




    '    '    End If
    '    'End With

    'End Sub



    Private Sub dgv_paper_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_paper.CellEnter

        Select Case e.ColumnIndex
            '// DateTimePicker
            Case 4
                dtp = New DateTimePicker
                '//Adding DateTimePicker control into DataGridView   
                dgv_paper.Controls.Add(dtp)

                '// Setting the format (i.e. 02/07/2017 - dd/mm/yyyy)
                dtp.Format = DateTimePickerFormat.Short

                '// It returns the retangular area that represents the Display area for a cell  
                Dim oRectangle = dgv_paper.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)

                '//Setting area for DateTimePicker Control  
                dtp.Size = New Size(oRectangle.Width, oRectangle.Height)

                '// Setting Location
                dtp.Location = New Point(oRectangle.X, oRectangle.Y)
                '// Read value from DataGridView into DateTimePicker
                ' dtp.Value = dgv_paper.CurrentCell.Value
                dtp.Value = Now
                '// Now make it visible  
                dtp.Visible = True
                '// Force to change date value at dtp_ValueChanged Event.
                AddHandler dtp.ValueChanged, AddressOf dtp_ValueChanged


        End Select

    End Sub


End Class