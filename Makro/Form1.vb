Public Class Form1
    Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)

    Private Const MOUSEEVENTF_LEFTDOWN = &H2 ' left button down
    Private Const MOUSEEVENTF_LEFTUP = &H4 ' left button up

    Private Const MOUSEEVENTF_MIDDLEDOWN = &H20
    Private Const MOUSEEVENTF_MIDDLEUP = &H40
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Long) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.BackColor = Color.Red
        CheckBox2.Checked = False
        Button3.Visible = False
        Label3.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button4.Enabled = False
        If CheckBox2.Checked = True Then
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()
            ListBox3.Items.Clear()
        End If

        Label4.Text = "Kayıt Başladı..."
        Button3.Visible = True
        Button1.Visible = False
        Label3.Visible = True
        Label1.Visible = False
        Button2.Enabled = True
        If CheckBox1.Checked = True Then
            My.Forms.Form1.Visible = False

        Else
            My.Forms.Form1.Visible = True
        End If
        If Button1.BackColor = Color.Silver Then
            Button1.BackColor = Color.White
            Button2.BackColor = Color.White
            Button3.BackColor = Color.White
        Else
            Button1.BackColor = Color.Silver
            Button2.BackColor = Color.White
            Button3.BackColor = Color.White
        End If
        Kayıt.Start()
        Timer3.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Visible = True
        Button3.Visible = False
        Label1.Visible = True
        Label3.Visible = False
        CheckBox2.Checked = False
        Label4.Text = "Kayıt Duraklatıldı..."
        Kayıt.Stop()
        Timer3.Stop()

        If Button2.BackColor = Color.Silver Then
            Button2.BackColor = Color.White
            Button1.BackColor = Color.White
            Button3.BackColor = Color.White
            Button4.BackColor = Color.White
        Else
            Button2.BackColor = Color.Silver
            Button3.BackColor = Color.White
            Button1.BackColor = Color.White
            Button4.BackColor = Color.White
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button4.Enabled = True
        Kayıt.Stop()
        Timer3.Stop()
        CheckBox2.Checked = True
        Label4.Text = "Kayıt Durduruldu..."
        Button1.Visible = True
        Button3.Visible = False
        Label3.Visible = False
        Label1.Visible = True
        If Button3.BackColor = Color.Silver Then
            Button3.BackColor = Color.White
            Button2.BackColor = Color.White
            Button1.BackColor = Color.White
            Button4.BackColor = Color.White
        Else
            Button3.BackColor = Color.Silver
            Button2.BackColor = Color.White
            Button1.BackColor = Color.White
            Button4.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.BackColor = Color.Green
            CheckBox1.ForeColor = Color.White

        Else
            CheckBox1.BackColor = Color.Red
            CheckBox1.ForeColor = Color.White
        End If
    End Sub

    Private Sub Kayıt_Tick(sender As Object, e As EventArgs) Handles Kayıt.Tick
        Label6.Text = ListBox1.Items.Count
        Label7.Text = ListBox2.Items.Count
        Label8.Text = ListBox3.Items.Count

        If CheckBox1.Checked = True Then
            If My.Forms.Form1.Visible = True Then
                If My.Computer.Keyboard.CtrlKeyDown Then
                    My.Forms.Form1.Visible = False
                End If
            Else
                If My.Computer.Keyboard.CtrlKeyDown Then
                    My.Forms.Form1.Visible = True
                End If
            End If
        End If

        ListBox1.Items.Add(Cursor.Position.X)
        ListBox2.Items.Add(Cursor.Position.Y)
        ListBox3.Items.Add(Cursor.Position.X)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label4.Text = "Kayıt Oynatılıyor..."
        Button1.Enabled = False
        Button2.Enabled = False
        Oynat.Start()
        Timer1.Start()

        ListBox1.SelectedIndex = 0
        ListBox2.SelectedIndex = 0
        ListBox3.SelectedIndex = 0
        If Button4.BackColor = Color.Silver Then
            Button4.BackColor = Color.White
            Button2.BackColor = Color.White
            Button1.BackColor = Color.White
            Button3.BackColor = Color.White
        Else
            Button4.BackColor = Color.Silver
            Button2.BackColor = Color.White
            Button1.BackColor = Color.White
            Button3.BackColor = Color.White
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Oynat_Tick(sender As Object, e As EventArgs) Handles Oynat.Tick




        Try
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            ListBox2.SelectedIndex = ListBox2.SelectedIndex + 1

        Catch ex As Exception
            Oynat.Stop()
            Timer1.Stop()

            Button1.Enabled = True

        End Try





        Try


            Try
                If ListBox2.Text = "sol" Then
                    mouse_event(MOUSEEVENTF_LEFTDOWN Or MOUSEEVENTF_LEFTUP, ListBox1.SelectedItem, ListBox2.SelectedItem, 0, 0)
                Else
                    Dim konum As New Point(ListBox1.SelectedItem, ListBox2.SelectedItem)
                    Cursor.Position = konum
                End If
                If ListBox2.Text = "sag" Then
                    mouse_event(MOUSEEVENTF_RIGHTDOWN Or MOUSEEVENTF_RIGHTUP, ListBox1.SelectedItem, ListBox2.SelectedItem, 0, 0)
                Else
                    Dim konum As New Point(ListBox1.SelectedItem, ListBox2.SelectedItem)
                    Cursor.Position = konum
                End If
            Catch ex As Exception

            End Try

        Catch ex As Exception
            Oynat.Stop()
            Timer1.Stop()

            Button1.Enabled = True
        End Try
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If GetAsyncKeyState(2) Then
            ListBox1.Items.Add("sag")
            ListBox2.Items.Add("sag")
            ListBox3.Items.Add("sag")
        End If
        If GetAsyncKeyState(1) Then
            ListBox1.Items.Add("sol")
            ListBox2.Items.Add("sol")
            ListBox3.Items.Add("sol")
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If ListBox2.SelectedItem = "sol" Then
                mouse_event(MOUSEEVENTF_LEFTDOWN Or MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)

            End If
            If ListBox2.SelectedItem = "sag" Then
                mouse_event(MOUSEEVENTF_RIGHTDOWN Or MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0)

            End If
        Catch ex As Exception

        End Try

    End Sub


End Class
