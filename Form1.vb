Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=vb-mysql-crud")
    Dim i As Integer
    Dim dr As MySqlDataReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()
    End Sub

    Public Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `table-crud`", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("PRODUCTNO"), dr.Item("PRODUCTNAME"), dr.Item("PRICE"), dr.Item("GROUP"), dr.Item("EXPDATE"), Format(CBool(dr.Item("STATUS"))))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        save()
        DGV_load()
    End Sub

    Private Sub save()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("
                INSERT INTO `table-crud`(`PRODUCTNO`, `PRODUCTNAME`, `PRICE`, `GROUP`, `EXPDATE`, `STATUS`) 
                VALUES (@PRODUCTNO, @PRODUCTNAME, @PRICE, @GROUP, @EXPDATE, @STATUS);
            ", conn)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@PRODUCTNO", txt_prono.Text)
            cmd.Parameters.AddWithValue("@PRODUCTNAME", txt_proname.Text)
            cmd.Parameters.AddWithValue("@PRICE", CDec(txt_price.Text))
            'cmd.Parameters.AddWithValue("@PRICE", txt_price.Text)
            cmd.Parameters.AddWithValue("@GROUP", combo_progroup.Text)
            cmd.Parameters.AddWithValue("@EXPDATE", exp_datepicker.Value)
            cmd.Parameters.AddWithValue("@STATUS", status_checkbox.Checked)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Save Successfully !", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Save Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        clear()
    End Sub

    Public Sub clear()
        txt_prono.Clear()
        txt_proname.Clear()
        txt_price.Clear()
        combo_progroup.Text = ""
        exp_datepicker.Value = Now
        status_checkbox.CheckState = False


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txt_prono.Text = DataGridView1.CurrentRow.Cells(0).Value
        txt_proname.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_price.Text = DataGridView1.CurrentRow.Cells(2).Value
        combo_progroup.Text = DataGridView1.CurrentRow.Cells(3).Value
        exp_datepicker.Text = DataGridView1.CurrentRow.Cells(4).Value
        status_checkbox.Checked = DataGridView1.CurrentRow.Cells(5).Value

        txt_prono.ReadOnly = True
        Button1.Enabled = False

    End Sub

    Sub Edit()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE `table-crud` SET `PRODUCTNAME`=@PRODUCTNAME,`PRICE`=@PRICE,`GROUP`=@GROUP,`EXPDATE`=@EXPDATE,`STATUS`=@STATUS WHERE
`PRODUCTNO`=@PRODUCTNO", conn)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@PRODUCTNO", txt_prono.Text)
            cmd.Parameters.AddWithValue("@PRODUCTNAME", txt_proname.Text)
            cmd.Parameters.AddWithValue("@PRICE", CDec(txt_price.Text))
            ' cmd.Parameters.AddWithValue("@PRICE", txt_price.Text)
            cmd.Parameters.AddWithValue("@GROUP", combo_progroup.Text)
            cmd.Parameters.AddWithValue("@EXPDATE", exp_datepicker.Value)
            cmd.Parameters.AddWithValue("@STATUS", status_checkbox.Checked)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record Update Successfully !", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Record Update Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        clear()
        DGV_load()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Edit()


    End Sub

    Public Sub delete()
        If MsgBox("Are You Sure Delete This Record", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM `table-crud` WHERE `PRODUCTNO`=@PRODUCTNO", conn)

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@PRODUCTNO", txt_prono.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Record Deleted Successfully !", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Record Delete Failed !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
            clear()
            DGV_load()

        Else
            Return

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        delete()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clear()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM `table-crud` WHERE PRODUCTNO like '%" & txt_search.Text & "%' OR PRODUCTNAME like '%" & txt_search.Text & "%'", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("PRODUCTNO"), dr.Item("PRODUCTNAME"), dr.Item("PRICE"), dr.Item("GROUP"), dr.Item("EXPDATE"), Format(CBool(dr.Item("STATUS"))))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub
End Class
