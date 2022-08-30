<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DataNavigator
    Inherits Wisej.Web.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Wisej Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej Designer
    'It can be modified using the Wisej Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.NavBar = New Wisej.Web.ToolBar()
        Me.bFirst = New Wisej.Web.ToolBarButton()
        Me.bPrev = New Wisej.Web.ToolBarButton()
        Me.RecordLabel = New Wisej.Web.ToolBarButton()
        Me.bNext = New Wisej.Web.ToolBarButton()
        Me.bLast = New Wisej.Web.ToolBarButton()
        Me.bRefresh = New Wisej.Web.ToolBarButton()
        Me.bNew = New Wisej.Web.ToolBarButton()
        Me.bDelete = New Wisej.Web.ToolBarButton()
        Me.bFind = New Wisej.Web.ToolBarButton()
        Me.bPrint = New Wisej.Web.ToolBarButton()
        Me.bUndo = New Wisej.Web.ToolBarButton()
        Me.bSave = New Wisej.Web.ToolBarButton()
        Me.bClose = New Wisej.Web.ToolBarButton()
        Me.Panel = New Wisej.Web.Panel()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'NavBar
        '
        Me.NavBar.AutoSize = False
        Me.NavBar.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.NavBar.Buttons.AddRange(New Wisej.Web.ToolBarButton() {Me.bFirst, Me.bPrev, Me.RecordLabel, Me.bNext, Me.bLast, Me.bRefresh, Me.bNew, Me.bDelete, Me.bFind, Me.bPrint, Me.bUndo, Me.bSave, Me.bClose})
        Me.NavBar.Dock = Wisej.Web.DockStyle.None
        Me.NavBar.Font = New System.Drawing.Font("default", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.NavBar.Location = New System.Drawing.Point(3, 3)
        Me.NavBar.Margin = New Wisej.Web.Padding(0)
        Me.NavBar.Name = "NavBar"
        Me.NavBar.Size = New System.Drawing.Size(597, 44)
        Me.NavBar.TabIndex = 0
        Me.NavBar.TabStop = False
        '
        'bFirst
        '
        Me.bFirst.ImageSource = "icon-first"
        Me.bFirst.Name = "bFirst"
        Me.bFirst.Text = "Inizio"
        '
        'bPrev
        '
        Me.bPrev.ImageSource = "icon-left"
        Me.bPrev.Name = "bPrev"
        Me.bPrev.Text = "Prec."
        '
        'RecordLabel
        '
        Me.RecordLabel.Enabled = False
        Me.RecordLabel.Name = "RecordLabel"
        Me.RecordLabel.Text = "0/0"
        '
        'bNext
        '
        Me.bNext.ImageSource = "icon-right"
        Me.bNext.Name = "bNext"
        Me.bNext.Text = "Succ."
        '
        'bLast
        '
        Me.bLast.ImageSource = "icon-last"
        Me.bLast.Name = "bLast"
        Me.bLast.Text = "Fine"
        '
        'bRefresh
        '
        Me.bRefresh.ImageSource = "icon-redo"
        Me.bRefresh.Name = "bRefresh"
        Me.bRefresh.Text = "Ricarica dati"
        '
        'bNew
        '
        Me.bNew.ImageSource = "icon-new"
        Me.bNew.Name = "bNew"
        Me.bNew.Text = "Nuovo"
        '
        'bDelete
        '
        Me.bDelete.ImageSource = "tab-close"
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Text = "Elimina"
        '
        'bFind
        '
        Me.bFind.ImageSource = "icon-search"
        Me.bFind.Name = "bFind"
        Me.bFind.Text = "Ricerca"
        '
        'bPrint
        '
        Me.bPrint.ImageSource = "icon-print"
        Me.bPrint.Name = "bPrint"
        Me.bPrint.Text = "Stampa"
        '
        'bUndo
        '
        Me.bUndo.ImageSource = "icon-undo"
        Me.bUndo.Name = "bUndo"
        Me.bUndo.Text = "Annulla"
        '
        'bSave
        '
        Me.bSave.ImageSource = "icon-save"
        Me.bSave.Name = "bSave"
        Me.bSave.Text = "Salva"
        '
        'bClose
        '
        Me.bClose.ImageSource = "icon-exit"
        Me.bClose.Name = "bClose"
        Me.bClose.Text = "Chiudi"
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.NavBar)
        Me.Panel.Font = New System.Drawing.Font("default", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Panel.HeaderSize = 14
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Margin = New Wisej.Web.Padding(0)
        Me.Panel.Name = "Panel"
        Me.Panel.ShowCloseButton = False
        Me.Panel.ShowHeader = True
        Me.Panel.Size = New System.Drawing.Size(604, 60)
        Me.Panel.TabIndex = 1
        Me.Panel.Text = "Navigatore Dati"
        '
        'DataNavigator
        '
        Me.Controls.Add(Me.Panel)
        Me.Name = "DataNavigator"
        Me.Size = New System.Drawing.Size(624, 81)
        Me.Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bFirst As ToolBarButton
    Friend WithEvents bPrev As ToolBarButton
    Friend WithEvents bNext As ToolBarButton
    Friend WithEvents bLast As ToolBarButton
    Friend WithEvents bRefresh As ToolBarButton
    Friend WithEvents bNew As ToolBarButton
    Friend WithEvents bDelete As ToolBarButton
    Friend WithEvents bFind As ToolBarButton
    Friend WithEvents bUndo As ToolBarButton
    Friend WithEvents bSave As ToolBarButton
    Friend WithEvents bPrint As ToolBarButton
    Friend WithEvents bClose As ToolBarButton
    Friend WithEvents RecordLabel As ToolBarButton
    Public WithEvents NavBar As ToolBar
    Private WithEvents Panel As Panel
End Class
