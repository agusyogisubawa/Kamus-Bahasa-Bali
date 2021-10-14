Imports MySql.Data.MySqlClient
Public Class Form2
    Dim server As String = "Server=localhost;userid=root;password=;database=db_kamus"
    Dim SQLConnection As MySqlConnection
    Dim command As MySqlCommand
    Private Sub MenuUtamaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUtamaToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub AngkaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AngkaToolStripMenuItem.Click
        Me.Hide()
        Form3.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = server
        Dim reader As MySqlDataReader
        Dim translate As String
        translate = TextBox1.Text.ToLower
        If translate.Contains(" ") Then
            translate = translate.Replace(" ", String.Empty)
        End If
        Try
            If translate = "" Then
                MsgBox("Tidak Boleh Kosong", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            Else
                If RadioButton1.Checked = False And RadioButton2.Checked = False Then
                    MsgBox("Pilih Jenis Terjemahan Terlebih Dahulu", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                Else
                If RadioButton1.Checked = True Then
                    SQLConnection.Open()
                    Dim query As String
                        query = "select * from tb_angka where indo = '" & TextBox1.Text & "' or bali = '" & TextBox1.Text & "'"
                    command = New MySqlCommand(query, SQLConnection)
                    reader = command.ExecuteReader
                    If reader.Read = False Then
                        MsgBox("Angka Belum Terdaftar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                        TextBox2.Text = ""
                    Else
                        Dim bali = reader.GetString("bali")
                        If translate = bali Then
                            MsgBox("Silakan Pilih Translate Bahasa Bali - Angka", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                            TextBox2.Text = ""
                        Else
                            TextBox2.Text = bali
                        End If
                    End If
                    SQLConnection.Close()
                Else
                    If RadioButton2.Checked = True Then
                        SQLConnection.Open()
                        Dim query As String
                            query = "select * from tb_angka where indo = '" & TextBox1.Text & "' or bali = '" & TextBox1.Text & "'"
                        command = New MySqlCommand(query, SQLConnection)
                        reader = command.ExecuteReader
                        If reader.Read = False Then
                            MsgBox("Kata Belum Terdaftar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                            TextBox2.Text = ""
                        Else
                            Dim indo = reader.GetString("indo")
                            If translate = indo Then
                                MsgBox("Silakan Pilih Translate Angka - Bahasa Bali", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                                TextBox2.Text = ""
                            Else
                                TextBox2.Text = indo
                            End If
                        End If
                        SQLConnection.Close()
                    End If
                End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SQLConnection.Dispose()
        End Try

    End Sub

    Private Sub KataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KataToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class