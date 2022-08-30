<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Window1
    Inherits Wisej.Web.Form

    'Overrides dispose to clean up the component list.
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
    Private Sub InitializeComponent()
        Me.DataNavigator = New BasicDALWisejControls.DataNavigator()
        Me.DBString = New Wisej.Web.TextBox()
        Me.DBInt = New Wisej.Web.TextBox()
        Me.DBDate = New Wisej.Web.TextBox()
        Me.DBFLoat = New Wisej.Web.TextBox()
        Me.DataRepeater1 = New Wisej.Web.DataRepeater()
        Me.Repeater_DBInt = New Wisej.Web.TextBox()
        Me.Repeater_DBString = New Wisej.Web.TextBox()
        Me.Repeater_DBFloat = New Wisej.Web.TextBox()
        CType(Me.DataRepeater1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataRepeater1.ItemTemplate.SuspendLayout()
        Me.DataRepeater1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataNavigator
        '
        Me.DataNavigator.Dock = Wisej.Web.DockStyle.Bottom
        Me.DataNavigator.Location = New System.Drawing.Point(0, 415)
        Me.DataNavigator.Name = "DataNavigator"
        Me.DataNavigator.Size = New System.Drawing.Size(1003, 81)
        Me.DataNavigator.TabIndex = 0
        '
        'DBString
        '
        Me.DBString.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DBString.LabelText = "DBString"
        Me.DBString.Location = New System.Drawing.Point(19, 72)
        Me.DBString.Name = "DBString"
        Me.DBString.Size = New System.Drawing.Size(110, 40)
        Me.DBString.TabIndex = 1
        '
        'DBInt
        '
        Me.DBInt.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DBInt.LabelText = "DBInt"
        Me.DBInt.Location = New System.Drawing.Point(19, 26)
        Me.DBInt.Name = "DBInt"
        Me.DBInt.Size = New System.Drawing.Size(110, 40)
        Me.DBInt.TabIndex = 2
        '
        'DBDate
        '
        Me.DBDate.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DBDate.LabelText = "DBDate"
        Me.DBDate.Location = New System.Drawing.Point(19, 118)
        Me.DBDate.Name = "DBDate"
        Me.DBDate.Size = New System.Drawing.Size(110, 40)
        Me.DBDate.TabIndex = 3
        '
        'DBFLoat
        '
        Me.DBFLoat.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DBFLoat.LabelText = "DBFloat"
        Me.DBFLoat.Location = New System.Drawing.Point(19, 164)
        Me.DBFLoat.Name = "DBFLoat"
        Me.DBFLoat.Size = New System.Drawing.Size(110, 40)
        Me.DBFLoat.TabIndex = 4
        '
        'DataRepeater1
        '
        Me.DataRepeater1.AllowUserToAddItems = False
        Me.DataRepeater1.AllowUserToDeleteItems = False
        Me.DataRepeater1.ItemSize = New System.Drawing.Size(200, 56)
        '
        'DataRepeater1.ItemTemplate
        '
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Repeater_DBFloat)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Repeater_DBString)
        Me.DataRepeater1.ItemTemplate.Controls.Add(Me.Repeater_DBInt)
        Me.DataRepeater1.ItemTemplate.Size = New System.Drawing.Size(441, 56)
        Me.DataRepeater1.Location = New System.Drawing.Point(214, 36)
        Me.DataRepeater1.Name = "DataRepeater1"
        Me.DataRepeater1.Size = New System.Drawing.Size(443, 334)
        Me.DataRepeater1.TabIndex = 5
        Me.DataRepeater1.Text = "DataRepeater1"
        '
        'Repeater_DBInt
        '
        Me.Repeater_DBInt.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Repeater_DBInt.LabelText = "DBInt"
        Me.Repeater_DBInt.Location = New System.Drawing.Point(3, 3)
        Me.Repeater_DBInt.Name = "Repeater_DBInt"
        Me.Repeater_DBInt.Size = New System.Drawing.Size(110, 40)
        Me.Repeater_DBInt.TabIndex = 6
        '
        'Repeater_DBString
        '
        Me.Repeater_DBString.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Repeater_DBString.LabelText = "DBString"
        Me.Repeater_DBString.Location = New System.Drawing.Point(119, 3)
        Me.Repeater_DBString.Name = "Repeater_DBString"
        Me.Repeater_DBString.Size = New System.Drawing.Size(110, 40)
        Me.Repeater_DBString.TabIndex = 7
        '
        'Repeater_DBFloat
        '
        Me.Repeater_DBFloat.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Repeater_DBFloat.LabelText = "DBFloat"
        Me.Repeater_DBFloat.Location = New System.Drawing.Point(235, 3)
        Me.Repeater_DBFloat.Name = "Repeater_DBFloat"
        Me.Repeater_DBFloat.Size = New System.Drawing.Size(110, 40)
        Me.Repeater_DBFloat.TabIndex = 8
        '
        'Window1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 496)
        Me.Controls.Add(Me.DBInt)
        Me.Controls.Add(Me.DataRepeater1)
        Me.Controls.Add(Me.DBFLoat)
        Me.Controls.Add(Me.DBDate)
        Me.Controls.Add(Me.DBString)
        Me.Controls.Add(Me.DataNavigator)
        Me.Name = "Window1"
        Me.Text = "Window1"
        Me.DataRepeater1.ItemTemplate.ResumeLayout(False)
        Me.DataRepeater1.ItemTemplate.PerformLayout()
        CType(Me.DataRepeater1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataRepeater1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataNavigator As BasicDALWisejControls.DataNavigator
    Friend WithEvents DBString As TextBox
    Friend WithEvents DBInt As TextBox
    Friend WithEvents DBDate As TextBox
    Friend WithEvents DBFLoat As TextBox
    Friend WithEvents DataRepeater1 As DataRepeater
    Friend WithEvents Repeater_DBFloat As TextBox
    Friend WithEvents Repeater_DBString As TextBox
    Friend WithEvents Repeater_DBInt As TextBox
End Class
