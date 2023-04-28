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
        startGame = New Button()
        SuspendLayout()
        ' 
        ' startGame
        ' 
        startGame.BackColor = SystemColors.ScrollBar
        startGame.Font = New Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point)
        startGame.ForeColor = Color.WhiteSmoke
        startGame.Location = New Point(174, 106)
        startGame.Name = "startGame"
        startGame.Size = New Size(261, 110)
        startGame.TabIndex = 0
        startGame.Text = "start program"
        startGame.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(745, 450)
        Controls.Add(startGame)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents startGame As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
