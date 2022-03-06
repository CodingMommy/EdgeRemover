<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MainArea = New System.Windows.Forms.Panel()
        Me.UninstallButton = New System.Windows.Forms.Button()
        Me.CLoutput = New System.Windows.Forms.RichTextBox()
        Me.WindowTitle = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.MainArea.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainArea
        '
        Me.MainArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.MainArea.Controls.Add(Me.WindowTitle)
        Me.MainArea.Controls.Add(Me.CloseButton)
        Me.MainArea.Dock = System.Windows.Forms.DockStyle.Top
        Me.MainArea.Location = New System.Drawing.Point(0, 0)
        Me.MainArea.Name = "MainArea"
        Me.MainArea.Size = New System.Drawing.Size(400, 25)
        Me.MainArea.TabIndex = 0
        '
        'UninstallButton
        '
        Me.UninstallButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UninstallButton.FlatAppearance.BorderSize = 0
        Me.UninstallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UninstallButton.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UninstallButton.Location = New System.Drawing.Point(10, 209)
        Me.UninstallButton.Margin = New System.Windows.Forms.Padding(10)
        Me.UninstallButton.Name = "UninstallButton"
        Me.UninstallButton.Size = New System.Drawing.Size(380, 32)
        Me.UninstallButton.TabIndex = 1
        Me.UninstallButton.Text = "Uninstall Edge"
        Me.UninstallButton.UseVisualStyleBackColor = False
        '
        'CLoutput
        '
        Me.CLoutput.BackColor = System.Drawing.Color.Black
        Me.CLoutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CLoutput.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CLoutput.ForeColor = System.Drawing.Color.White
        Me.CLoutput.Location = New System.Drawing.Point(10, 35)
        Me.CLoutput.Margin = New System.Windows.Forms.Padding(10)
        Me.CLoutput.Name = "CLoutput"
        Me.CLoutput.ReadOnly = True
        Me.CLoutput.Size = New System.Drawing.Size(380, 164)
        Me.CLoutput.TabIndex = 0
        Me.CLoutput.Text = "Waiting..."
        '
        'WindowTitle
        '
        Me.WindowTitle.AutoSize = True
        Me.WindowTitle.BackColor = System.Drawing.Color.Transparent
        Me.WindowTitle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.WindowTitle.ForeColor = System.Drawing.Color.White
        Me.WindowTitle.Location = New System.Drawing.Point(3, 4)
        Me.WindowTitle.Name = "WindowTitle"
        Me.WindowTitle.Size = New System.Drawing.Size(115, 17)
        Me.WindowTitle.TabIndex = 0
        Me.WindowTitle.Text = "MSEdge Remover"
        '
        'CloseButton
        '
        Me.CloseButton.BackgroundImage = CType(resources.GetObject("CloseButton.BackgroundImage"), System.Drawing.Image)
        Me.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Location = New System.Drawing.Point(375, 0)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(25, 25)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 250)
        Me.Controls.Add(Me.UninstallButton)
        Me.Controls.Add(Me.CLoutput)
        Me.Controls.Add(Me.MainArea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "MSEdge Remover"
        Me.MainArea.ResumeLayout(False)
        Me.MainArea.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainArea As Panel
    Friend WithEvents WindowTitle As Label
    Friend WithEvents CLoutput As RichTextBox
    Friend WithEvents UninstallButton As Button
    Friend WithEvents CloseButton As Button
End Class
