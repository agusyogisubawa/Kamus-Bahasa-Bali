Imports MySql.Data.MySqlClient
Public Class Form3
    Dim server As String = "Server=localhost;userid=root;password=;database=db_kamus"
    Dim SQLConnection As MySqlConnection
    Dim command As MySqlCommand
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Bahasa Bali Andap")
        ComboBox1.Items.Add("Bahasa Bali Alus Sor")
        ComboBox1.Items.Add("Bahasa Bali Alus Singgih")
    End Sub
    Private Sub MenuUtamaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuUtamaToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub AngkaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AngkaToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
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
                        If ComboBox1.Text = "Bahasa Bali Andap" Then
                            Dim query As String
                            query = "select * from tb_kata where indonesia = '" & TextBox1.Text & "' or baliandap = '" & TextBox1.Text & "'"
                            command = New MySqlCommand(query, SQLConnection)
                            reader = command.ExecuteReader
                            If reader.Read = False Then
                                MsgBox("Kata Belum Terdaftar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                                TextBox2.Text = ""
                            Else
                                Dim bali1 = reader.GetString("baliandap")
                                If translate = bali1 Then
                                    MsgBox("Silakan Pilih Translate Bahasa Bali - Bahasa Indonesia", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                                    TextBox2.Text = ""
                                Else
                                    TextBox2.Text = bali1
                                End If
                            End If
                        ElseIf ComboBox1.Text = "Bahasa Bali Alus Sor" Then
                            Dim query As String
                            query = "select * from tb_kata where indonesia = '" & TextBox1.Text & "' or balisor = '" & TextBox1.Text & "'"
                            command = New MySqlCommand(query, SQLConnection)
                            reader = command.ExecuteReader
                            If reader.Read = False Then
                                MsgBox("Kata Belum Terdaftar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                                TextBox2.Text = ""
                            Else
                                Dim bali = reader.GetString("balisor")
                                If translate = bali Then
                                    MsgBox("Silakan Pilih Translate Bahasa Bali - Bahasa Indonesia", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                                    TextBox2.Text = ""
                                Else
                                    TextBox2.Text = bali
                                End If
                            End If
                        ElseIf ComboBox1.Text = "Bahasa Bali Alus Singgih" Then
                            Dim query As String
                            query = "select * from tb_kata where indonesia = '" & TextBox1.Text & "' or balisinggih = '" & TextBox1.Text & "'"
                            command = New MySqlCommand(query, SQLConnection)
                            reader = command.ExecuteReader
                            If reader.Read = False Then
                                MsgBox("Kata Belum Terdaftar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                                TextBox2.Text = ""
                            Else
                                Dim bali = reader.GetString("balisinggih")
                                If translate = bali Then
                                    MsgBox("Silakan Pilih Translate Bahasa Bali - Bahasa Indonesia", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                                    TextBox2.Text = ""
                                Else
                                    TextBox2.Text = bali
                                End If
                            End If
                        Else
                            ComboBox1.SelectedItem = False
                            MsgBox("Pilih Jenis Bahasa Bali Terlebih Dahulu", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                        End If
                        SQLConnection.Close()
                    Else
                        RadioButton2.Checked = True
                        SQLConnection.Open()
                        Dim query As String
                        query = "select * from tb_kata where indonesia = '" & TextBox1.Text & "' or baliandap = '" & TextBox1.Text & "' or balisor = '" & TextBox1.Text & "' or balisinggih = '" & TextBox1.Text & "'"
                        command = New MySqlCommand(query, SQLConnection)
                        reader = command.ExecuteReader
                        If reader.Read = False Then
                            MsgBox("Kata Belum Terdaftar", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                            TextBox2.Text = ""
                        Else
                            Dim indo = reader.GetString("indonesia")
                            If translate = indo Then
                                MsgBox("Silakan Pilih Translate Bahasa Indonesia - Bahasa Bali", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                                TextBox2.Text = ""
                            Else
                                TextBox2.Text = indo
                            End If
                        End If
                        SQLConnection.Close()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            SQLConnection.Dispose()
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            ComboBox1.Enabled = True
        Else
            RadioButton2.Checked = True
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class