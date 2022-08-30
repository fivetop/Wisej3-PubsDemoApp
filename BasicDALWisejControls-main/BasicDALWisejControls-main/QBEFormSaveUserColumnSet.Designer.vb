<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QBEFormSaveUserColumnSet
    Inherits Wisej.Web.Form

    'UserControl overrides dispose to clean up the component list.
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
    Private Sub InitializeComponent()
        Dim ComponentTool1 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Me.ButtonOK = New Wisej.Web.Button()
        Me.ButtonClose = New Wisej.Web.Button()
        Me.Label1 = New Wisej.Web.Label()
        Me.txtNomeFile = New Wisej.Web.TextBox()
        Me.txtDescrizione = New Wisej.Web.TextBox()
        Me.Label2 = New Wisej.Web.Label()
        Me.txtUtentiGruppi = New Wisej.Web.TextBox()
        Me.Label3 = New Wisej.Web.Label()
        Me.txtDBObject = New Wisej.Web.TextBox()
        Me.Label4 = New Wisej.Web.Label()
        Me.SuspendLayout()
        '
        'ButtonOK
        '
        Me.ButtonOK.Anchor = CType((Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.ButtonOK.DialogResult = Wisej.Web.DialogResult.OK
        Me.ButtonOK.Location = New System.Drawing.Point(228, 186)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(129, 36)
        Me.ButtonOK.TabIndex = 0
        Me.ButtonOK.Text = "OK"
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((Wisej.Web.AnchorStyles.Bottom Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.ButtonClose.DialogResult = Wisej.Web.DialogResult.Cancel
        Me.ButtonClose.Location = New System.Drawing.Point(363, 186)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(129, 36)
        Me.ButtonClose.TabIndex = 1
        Me.ButtonClose.Text = "Annulla"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.Location = New System.Drawing.Point(15, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nome Filtro"
        '
        'txtNomeFile
        '
        Me.txtNomeFile.Location = New System.Drawing.Point(15, 20)
        Me.txtNomeFile.Name = "txtNomeFile"
        Me.txtNomeFile.Size = New System.Drawing.Size(477, 22)
        Me.txtNomeFile.TabIndex = 3
        '
        'txtDescrizione
        '
        Me.txtDescrizione.Location = New System.Drawing.Point(15, 61)
        Me.txtDescrizione.Name = "txtDescrizione"
        Me.txtDescrizione.Size = New System.Drawing.Size(477, 22)
        Me.txtDescrizione.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.Location = New System.Drawing.Point(15, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descrizione"
        '
        'txtUtentiGruppi
        '
        Me.txtUtentiGruppi.Location = New System.Drawing.Point(15, 148)
        Me.txtUtentiGruppi.Name = "txtUtentiGruppi"
        Me.txtUtentiGruppi.Size = New System.Drawing.Size(477, 22)
        Me.txtUtentiGruppi.TabIndex = 7
        ComponentTool1.ImageSource = "icon-search"
        ComponentTool1.Name = "Ricerca"
        ComponentTool1.ToolTipText = "Ricerca"
        Me.txtUtentiGruppi.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool1})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label3.Location = New System.Drawing.Point(15, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Si applica ad Utenti/Gruppi"
        '
        'txtDBObject
        '
        Me.txtDBObject.Location = New System.Drawing.Point(15, 105)
        Me.txtDBObject.Name = "txtDBObject"
        Me.txtDBObject.Size = New System.Drawing.Size(477, 22)
        Me.txtDBObject.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label4.Location = New System.Drawing.Point(15, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Oggetto DB"
        '
        'QBEFormSaveUserColumnSet
        '
        Me.AcceptButton = Me.ButtonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromName("@menu")
        Me.CancelButton = Me.ButtonClose
        Me.ClientSize = New System.Drawing.Size(507, 240)
        Me.CloseBox = False
        Me.ControlBox = False
        Me.Controls.Add(Me.txtDBObject)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtUtentiGruppi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescrizione)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomeFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonOK)
        Me.MaximizeBox = False
        Me.Name = "QBEFormSaveUserColumnSet"
        Me.Text = "Salvataggio Filtro Personalizzato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonOK As Wisej.Web.Button
    Friend WithEvents ButtonClose As Wisej.Web.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNomeFile As TextBox
    Friend WithEvents txtDescrizione As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUtentiGruppi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDBObject As TextBox
    Friend WithEvents Label4 As Label
End Class
