<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasicDALTextBox
    Inherits Wisej.Web.UserControl

    'BasicDALTextBox overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej Designer
    'It can be modified using the Wisej Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label = New Wisej.Web.Label()
        Me.TextBox = New Wisej.Web.TextBox()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(0, 3)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(93, 16)
        Me.Label.TabIndex = 0
        Me.Label.Text = "TextBox Label"
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(3, 19)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(104, 22)
        Me.TextBox.TabIndex = 1
        '
        'BasicDALTextBox
        '
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.Label)
        Me.Name = "BasicDALTextBox"
        Me.Size = New System.Drawing.Size(258, 42)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label As Label
    Friend WithEvents TextBox As TextBox
End Class
