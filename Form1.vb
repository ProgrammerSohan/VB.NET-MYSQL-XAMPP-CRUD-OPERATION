Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=vb-mysql-crud")
    Dim i As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        save()
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
    End Sub
End Class
