Public Class CalendarTableView

    Private Sub CalendarBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CalendarBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FencingDataSet)

    End Sub

    Private Sub CalendarTableView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FencingDataSet.Calendar' table. You can move, or remove it, as needed.
        Me.CalendarTableAdapter.Fill(Me.FencingDataSet.Calendar)

    End Sub

    Private Sub EventNameToolStripButton_Click(sender As Object, e As EventArgs) Handles EventNameToolStripButton.Click
        If EventNameToolStripTextBox.Text = "" Then
            MsgBox("Please enter a word to search")
        Else
            Try
                Me.CalendarTableAdapter.EventName(Me.FencingDataSet.Calendar, EventNameToolStripTextBox.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub


    'closes 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    'simple msgbox label
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        MsgBox("For Weapon: 0 is No Weapon, 1 is Foil, 2 is Sabre, 3 is Epee")
    End Sub


    'For the slider
    Dim mousex = Cursor.Position.X
    Dim mousey = Cursor.Position.Y
    Private Sub PictureBox1_MouseDown(sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub PictureBox1_MouseUp(sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mousex = Cursor.Position.X
        mousey = Cursor.Position.Y

        Me.Left = mousex - 400
        Me.Top = mousey - 5
    End Sub


    Private Sub ButDisableSearch_Click(sender As Object, e As EventArgs) Handles ButDisableSearch.Click
        EventNameToolStripLabel.Visible = False
        EventNameToolStripButton.Visible = False
        EventNameToolStripTextBox.Visible = False
        ButEnableSearch.Visible = True
        ButDisableSearch.Visible = False
    End Sub
    Private Sub ButEnableSearch_Click(sender As Object, e As EventArgs) Handles ButEnableSearch.Click
        EventNameToolStripLabel.Visible = True
        EventNameToolStripButton.Visible = True
        EventNameToolStripTextBox.Visible = True
        ButEnableSearch.Visible = False
        ButDisableSearch.Visible = True
    End Sub

    
End Class