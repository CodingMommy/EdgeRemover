Public Class Form1
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim parameters As CreateParams = MyBase.CreateParams
            parameters.ClassStyle += &H20000
            Return parameters
        End Get
    End Property


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Count > 1 Then
            Application.Exit()
        End If
        RoundedRegion(Me)
        RoundedRegion(CLoutput)
        RoundedRegion(UninstallButton)
        RoundedRegion(CloseButton)
    End Sub

    Private Sub RoundedRegion(ByRef sender As Object)
        Dim p As New Drawing2D.GraphicsPath()
        p.StartFigure()
        p.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        p.AddLine(10, 0, sender.Width - 10, 0)
        p.AddArc(New Rectangle(sender.Width - 10, 0, 10, 10), -90, 90)
        p.AddLine(sender.Width, 10, sender.Width, sender.Height - 10)
        p.AddArc(New Rectangle(sender.Width - 10, sender.Height - 10, 10, 10), 0, 90)
        p.AddLine(sender.Width - 10, sender.Height, 10, sender.Height)
        p.AddArc(New Rectangle(0, sender.Height - 10, 10, 10), 90, 90)
        p.CloseFigure()
        sender.Region = New Region(p)
    End Sub

    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub MainPanel_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MainArea.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            Me.Opacity = 0.9
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub MainPanel_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MainArea.MouseUp
        If e.Button = MouseButtons.Left Then
            Me.Opacity = 1
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub MainPanel_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MainArea.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
        End If
    End Sub

    Private Function GetFileVersionInfo(ByVal filename As String) As String
        Return Version.Parse(FileVersionInfo.GetVersionInfo(filename).FileVersion).ToString
    End Function

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Dim WithEvents EdgeSetupProcess As New Process()

    Private Sub UninstallButton_Click(sender As Object, e As EventArgs) Handles UninstallButton.Click
        CLoutput.Text = ""
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & " (x86)\Microsoft\Edge\Application\msedge.exe") Then
            Try
                CLoutput.AppendText("Found Edge Version " & GetFileVersionInfo(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & " (x86)\Microsoft\Edge\Application\msedge.exe") & ", uninstalling..." & vbCrLf)
                EdgeSetupProcess.StartInfo.FileName = My.Computer.FileSystem.SpecialDirectories.ProgramFiles & " (x86)\Microsoft\Edge\Application\" & GetFileVersionInfo(My.Computer.FileSystem.SpecialDirectories.ProgramFiles & " (x86)\Microsoft\Edge\Application\msedge.exe") & "\Installer\setup.exe"
                EdgeSetupProcess.StartInfo.Arguments = "--uninstall --force-uninstall --system-level"
                EdgeSetupProcess.Start()
                EdgeSetupProcess.WaitForExitAsync()
            Catch ex As Exception
                CLoutput.AppendText("Unhandled exception: " & ex.ToString & vbCrLf)
            End Try
        Else
            CLoutput.AppendText("Unable to find msedge.exe, have you already uninstalled Edge?" & vbCrLf)
        End If
    End Sub



    Private Sub CLoutput_TextChanged(sender As Object, e As EventArgs) Handles CLoutput.TextChanged
        CLoutput.SelectionStart = CLoutput.Text.Length
        CLoutput.ScrollToCaret()
    End Sub

    Private Sub EdgeSetupProcess_OutputDataReceived(sender As Object, e As EventArgs) Handles EdgeSetupProcess.Exited
        CLoutput.Invoke(Sub() CLoutput.AppendText("Succesfully uninstalled MSEdge..." & vbCrLf))
    End Sub
End Class
