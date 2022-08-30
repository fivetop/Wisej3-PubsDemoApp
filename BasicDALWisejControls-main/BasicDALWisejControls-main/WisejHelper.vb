
Public Class Utilities


    Public Shared Sub SetFixedWindowStyles(ByVal Form As Form)
        Form.FormBorderStyle = FormBorderStyle.Fixed
        Form.CloseBox = True
        Form.MinimizeBox = True
        Form.MaximizeBox = False

    End Sub


    Public Shared Sub BoundComboBoxItemsToDataSource(ByRef ComboBox As Wisej.Web.ComboBox, ByVal DataSource As Object, ByVal DisplayMember As String, ByVal ValueMember As String)

        ComboBox.DataSource = DataSource
        ComboBox.ValueMember = ValueMember
        ComboBox.DisplayMember = DisplayMember
    End Sub

    Public Shared Sub BoundComboBoxItemsToDataTable(ByVal ComboBox As Wisej.Web.ComboBox, ByVal DataTable As DataTable, ByVal DisplayMember As String, ByVal ValueMember As String, ByVal Optional DisplayNullValue As Boolean = False, Optional ByVal NullValue As Object = Nothing, Optional ByVal NullValueDisplayText As String = "")

        Dim nDataTable As DataTable = DataTable.Copy

        If DisplayNullValue = True Then

            Dim nRow As DataRow = nDataTable.NewRow
            nRow(DisplayMember) = NullValueDisplayText
            nRow(ValueMember) = NullValue
            nDataTable.Rows.Add(nRow)
        End If

        ComboBox.DataSource = nDataTable
        ComboBox.ValueMember = ValueMember
        ComboBox.DisplayMember = DisplayMember


    End Sub

    Public Shared Sub BoundComboBoxItemsToDbObject(ByVal ComboBox As Wisej.Web.ComboBox, ByVal DbObject As BasicDAL.DbObject, ByVal DisplayMember As String, ByVal ValueMember As String, ByVal Optional DisplayNullValue As Boolean = False, Optional ByVal NullValue As Object = Nothing, Optional ByVal NullValueDisplayText As String = "")

        DbObject.Open(True)
        BoundComboBoxItemsToDataTable(ComboBox, DbObject.DataTable, DisplayMember, ValueMember, DisplayNullValue, NullValue, NullValueDisplayText)

    End Sub
    Public Shared Sub BoundDataGridViewComboBoxColumnItemsToDbObject(ByVal ComboBox As Wisej.Web.DataGridViewComboBoxColumn, ByVal DbObject As BasicDAL.DbObject, ByVal DisplayMember As String, ByVal ValueMember As String, ByVal Optional DisplayNullValue As Boolean = False, Optional ByVal NullValue As Object = Nothing, Optional ByVal NullValueDisplayText As String = "")
        DbObject.Open(True)
        BoundDataGridViewComboBoxColumnItemsToDataTable(ComboBox, DbObject.GetDataTable(), DisplayMember, ValueMember, DisplayNullValue, NullValue)
    End Sub

    Public Shared Sub BoundDataGridViewComboBoxColumnItemsToDataTable(ByVal ComboBox As Wisej.Web.DataGridViewComboBoxColumn, ByVal DataTable As DataTable, ByVal DisplayMember As String, ByVal ValueMember As String, ByVal Optional DisplayNullValue As Boolean = False, Optional ByVal NullValue As Object = Nothing, Optional ByVal NullValueDisplayText As String = "")

        Dim nDataTable As DataTable = DataTable.Copy

        If DisplayNullValue = True Then

            Dim nRow As DataRow = nDataTable.NewRow
            nRow(DisplayMember) = NullValueDisplayText
            nRow(ValueMember) = NullValue
            nDataTable.Rows.Add(nRow)
        End If

        ComboBox.DataSource = nDataTable
        ComboBox.ValueMember = ValueMember
        ComboBox.DisplayMember = DisplayMember


    End Sub

    Public Shared Function SimpleSerialize(Of T)(ByVal toSerialize As T) As String
        Dim xmlSerializer As New System.Xml.Serialization.XmlSerializer(toSerialize.GetType())
        Using textWriter As New System.IO.StringWriter()

            Try
                xmlSerializer.Serialize(textWriter, toSerialize)
                Return textWriter.ToString()
            Catch e As Exception
                Return ""
            End Try

        End Using
    End Function

    Public Shared Function SimpleDeserialize(Of T)(ByVal XMLString As String) As T
        Dim returnObject As T = Nothing
        If String.IsNullOrEmpty(XMLString) Then
            Return Nothing
        End If

        Try
            Dim xmlStream As New System.IO.StringReader(XMLString)
            Dim serializer As New System.Xml.Serialization.XmlSerializer(GetType(T))
            returnObject = DirectCast(serializer.Deserialize(xmlStream), T)
        Catch e1 As Exception

        End Try
        Return returnObject
    End Function


    'Public Shared Function SimpleJsonSerialize(Of T)(ByVal toSerialize As T) As String
    '    ' Serializing object to json data  
    '    Dim js As System.Web.Script.Serialization.JavaScriptSerializer = New System.Web.Script.Serialization.JavaScriptSerializer()
    '    Dim jsonData As String = js.Serialize(toSerialize)
    '    Return jsonData
    'End Function

    'Public Shared Function SimpleJsonDeserialize(Of T)(ByVal Json As String) As T

    '    If String.IsNullOrEmpty(Json) Then
    '        Return Nothing
    '    End If
    '    Dim returnObject = Activator.CreateInstance(Of T)()
    '    Dim js As System.Web.Script.Serialization.JavaScriptSerializer = New System.Web.Script.Serialization.JavaScriptSerializer()
    '    Dim obj As Object = js.DeserializeObject(Json)

    '    Return obj

    'End Function
    Public Shared Function GetClientControlFullName(ByVal Control As Object, Optional ByVal Prefix As String = "App.") As String
        Dim cnames As New List(Of String)()
        Dim _c As String = ""
        Dim _Control As Object = Control
        _c = Control.Name
        Do
            If _Control.Parent IsNot Nothing Then
                If _Control.Name <> _Control.Parent.Name Then
                    _c = _Control.Parent.Name & "." & _c
                    _Control = _Control.Parent
                Else
                    Exit Do
                End If
            Else
                Exit Do
            End If
        Loop While True
        Return Prefix & _c
    End Function

    Public Shared Function ManageDbObjectEvents(ByVal DbObject As BasicDAL.DbObject, ByVal eventtype As BasicDAL.DataEventType, Optional ByVal text As String = "",
            Optional ByVal caption As String = "",
            Optional ByVal buttons As MessageBoxButtons = MessageBoxButtons.YesNo,
            Optional ByVal icon As MessageBoxIcon = MessageBoxIcon.Question,
            Optional ByVal defaultbutton As MessageBoxDefaultButton = MessageBoxDefaultButton.Button2) As Wisej.Web.DialogResult

        Dim x As Boolean = False
        Dim _text As String = ""

        If caption = "" Then
            caption = DbObject.FriendlyName
        End If

        Select Case eventtype
            Case BasicDAL.DataEventType.AddNew
                If (DbObject.DataChanged() = True) Then
                    x = True
                    _text = "Attenzione!" + vbCrLf + "I dati correnti sono stati modificati." + vbCrLf + "Le modifiche non verranno salvate!" + vbCrLf + "Confermi operazione di creazione nuovi dati?"
                End If
            Case BasicDAL.DataEventType.UndoChanges
                If (DbObject.DataChanged() = True) Then
                    x = True
                    _text = "Attenzione!" + vbCrLf + "Le modifiche effettuate verranno annullate!" + vbCrLf + "Confermi operazione di annullamento modifice?"
                End If

            Case BasicDAL.DataEventType.Delete, BasicDAL.DataEventType.DeleteAll, BasicDAL.DataEventType.DeleteFromDataSet, BasicDAL.DataEventType.DeleteFromDataTable
                x = True
                _text = "Attenzione!" + vbCrLf + "I dati verranno cancellati!" + vbCrLf + "Confermi operazione di cancellazione?"
            Case BasicDAL.DataEventType.MoveFirst, BasicDAL.DataEventType.MoveLast, BasicDAL.DataEventType.MoveNext, BasicDAL.DataEventType.MoveTo, BasicDAL.DataEventType.MovePrevious, BasicDAL.DataEventType.Query
                If (DbObject.DataChanged() = True) Then
                    x = True
                    _text = "Attenzione!" + vbCrLf + "I dati correnti sono stati modificati." + vbCrLf + "Le modifiche non verranno salvate!" + vbCrLf + "Confermi abbandono dati correnti?"
                End If
            Case BasicDAL.DataEventType.Update
                x = True
                _text = "Attenzione!" + vbCrLf + "Confermi aggiornamento dati?"
            Case BasicDAL.DataEventType.Disposing
                x = True
                _text = "Attenzione!" + vbCrLf + "I dati correnti sono stati modificati." + vbCrLf + "Le modifiche non verranno salvate!" + vbCrLf + "Confermi abbandono dati correnti?"
            Case Else
        End Select

        If text = "" Then text = _text
        If (x = True) Then
            Return Wisej.Web.MessageBox.Show(text, caption, buttons, icon, defaultbutton)

        End If
        Return DialogResult.None

    End Function

    Public Shared Function ManageDataNavigatorEvents(ByVal DataNavigator As BasicDALWisejControls.DataNavigator, ByVal eventtype As BasicDALWisejControls.DataNavigator.EventType, Optional ByVal text As String = "",
           Optional ByVal caption As String = "",
           Optional ByVal buttons As MessageBoxButtons = MessageBoxButtons.YesNo,
           Optional ByVal icon As MessageBoxIcon = MessageBoxIcon.Question,
           Optional ByVal defaultbutton As MessageBoxDefaultButton = MessageBoxDefaultButton.Button2) As Wisej.Web.DialogResult

        Dim x As Boolean = False
        Dim _text As String = ""

        If caption = "" Then
            caption = DataNavigator.ParentForm.Text
        End If
        Select Case eventtype
            Case BasicDALWisejControls.DataNavigator.EventType.AddNew
                If (DataNavigator.DbObject.DataChanged() = True) Then
                    _text = "Attenzione!" + vbCrLf + "I dati correnti sono stati modificati." + vbCrLf + "Le modifiche non verranno salvate!" + vbCrLf + "Confermi operazione di creazione nuovi dati?"
                    x = True
                End If

            Case BasicDALWisejControls.DataNavigator.EventType.Undo
                If (DataNavigator.DbObject.DataChanged() = True) Then
                    _text = "Attenzione!" + vbCrLf + "Le modifiche effettuate verranno annullate!" + vbCrLf + "Confermi operazione di annullamento modifice?"
                    x = True
                End If

            Case BasicDALWisejControls.DataNavigator.EventType.Delete, BasicDAL.DataEventType.DeleteAll, BasicDAL.DataEventType.DeleteFromDataSet, BasicDAL.DataEventType.DeleteFromDataTable
                x = True
                _text = "Attenzione!" + vbCrLf + "I dati verranno cancellati!" + vbCrLf + "Confermi operazione di cancellazione?"

            Case BasicDALWisejControls.DataNavigator.EventType.Move, BasicDALWisejControls.DataNavigator.EventType.MoveFirst, BasicDALWisejControls.DataNavigator.EventType.MoveLast, BasicDALWisejControls.DataNavigator.EventType.MoveNext, BasicDALWisejControls.DataNavigator.EventType.MovePrevious, BasicDALWisejControls.DataNavigator.EventType.Find, BasicDALWisejControls.DataNavigator.EventType.Refresh
                If (DataNavigator.DbObject.DataChanged() = True) Then
                    _text = "Attenzione!" + vbCrLf + "I dati correnti sono stati modificati." + vbCrLf + "Le modifiche non verranno salvate!" + vbCrLf + "Confermi abbandono dati correnti?"
                    x = True
                End If

            Case BasicDALWisejControls.DataNavigator.EventType.Save
                x = True
                _text = "Attenzione!" + vbCrLf + "Confermi aggiornamento dati?"
            Case BasicDALWisejControls.DataNavigator.EventType.Close
                If (DataNavigator.DbObject.DataChanged() = True) Then
                    x = True
                    _text = "Attenzione!" + vbCrLf + "I dati correnti sono stati modificati." + vbCrLf + "Le modifiche non verranno salvate!" + vbCrLf + "Confermi abbandono dati correnti?"
                End If

            Case Else
        End Select

        If text = "" Then text = _text
        If x = True Then
            Return Wisej.Web.MessageBox.Show(text, caption, buttons, icon, defaultbutton)
        End If
        Return DialogResult.None

    End Function
End Class

Public Class BasicDALMessageBox

    Public Sub Show(ByVal Text As String, Optional ByVal Caption As String = "Errore Gestione Dati")
        MessageBox.Show(Text, Caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

End Class

Public Class BasicDALValidatorLabel
    Public BoundControl As BasicDAL.BoundControl
    Private Label As New Wisej.Web.Label
    Public Sub New(ByVal BoundControl As BasicDAL.BoundControl)
        Label.Parent = BoundControl.Control.Parent
        Label.Top = BoundControl.Control.Top
        Label.Left = BoundControl.Control.Top + BoundControl.Control.Width
        Label.Font = BoundControl.Control.Font
        Dim textSize As Drawing.Size = Windows.Forms.TextRenderer.MeasureText("M", Label.Font)
        Label.Width = textSize.Width
        Label.BackColor = Drawing.Color.Red
        Label.ForeColor = Drawing.Color.White
        Label.Text = "!"
        Label.Visible = False
    End Sub
    Public Sub Show()
        Label.Visible = True
    End Sub
    Public Sub Hide()
        Label.Visible = False
    End Sub
End Class


Public Class DataGridViewColumnsResizer
    Private Const AutoSizeColumnMode_AllCells As Integer = 3 'Convert.ToInt32(DataGridViewAutoSizeColumnMode.AllCells);
    Private Const AutoSizeColumnMode_AllCellsExceptHeader As Integer = 2 'Convert.ToInt32(DataGridViewAutoSizeColumnMode.AllCellsExceptHeader );
    Private Const AutoSizeColumnMode_ColumnHeader As Integer = 1 ' Convert.ToInt32(DataGridViewAutoSizeColumnMode.ColumnHeader );
    Private Const AutoSizeColumnMode_DisplayedCells As Integer = 5 ' Convert.ToInt32(DataGridViewAutoSizeColumnMode.DisplayedCells);
    Private Const AutoSizeColumnMode_DisplayedCellsExceptHeader As Integer = 4 'Convert.ToInt32(DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader);
    Private Const AutoSizeColumnMode_Fill As Integer = 6 ' Convert.ToInt32(DataGridViewAutoSizeColumnMode.Fill );
    Private Const AutoSizeColumnMode_None As Integer = 0 ' Convert.ToInt32(DataGridViewAutoSizeColumnMode.None );
    Private Const AutoSizeColumnMode_NotSet As Integer = -1 ' Convert.ToInt32(DataGridViewAutoSizeColumnMode.NotSet );

    Public DataGridView As DataGridView
    Public Sub AutoSize()


        Dim ColumnWidth As New System.Collections.Generic.Dictionary(Of Integer, Integer)()
        Dim RowHeight As New System.Collections.Generic.Dictionary(Of Integer, Integer)()
        Dim ColumnIndexDefault As New System.Collections.Generic.List(Of Integer)()
        Dim ColumnIndexCustom As New System.Collections.Generic.List(Of Integer)()
        Dim _ColumnWidth As Integer = 0
        Dim _RowHeight As Integer = 0
        Dim AutoSizeMode As Integer = 0

        For i As Integer = 0 To DataGridView.Columns.Count - 1
            Dim Column As DataGridViewColumn = DataGridView.Columns(i)
            AutoSizeMode = CInt(Fix(Column.AutoSizeMode))
            If AutoSizeMode = AutoSizeColumnMode_NotSet Then
                ColumnIndexDefault.Add(i)
            Else
                ColumnIndexCustom.Add(i)
            End If
            ColumnWidth.Add(i, Column.Width)
            RowHeight.Add(i, DataGridView.RowTemplate.Height)
        Next i

        For c As Integer = 0 To ColumnIndexCustom.Count - 1
            Dim Column As DataGridViewColumn = DataGridView.Columns(ColumnIndexCustom(c))
            _ColumnWidth = ColumnWidth(ColumnIndexCustom(c))
            SetColumnWidth(Column, CInt(Fix(Column.AutoSizeMode)))


        Next c
        For c As Integer = 0 To ColumnIndexDefault.Count - 1
            Dim Column As DataGridViewColumn = DataGridView.Columns(ColumnIndexDefault(c))
            _ColumnWidth = ColumnWidth(ColumnIndexDefault(c))
            SetColumnWidth(Column, CInt(Fix(DataGridView.AutoSizeColumnsMode)))



        Next c

    End Sub

    Private Sub SetColumnWidth(ByVal Column As DataGridViewColumn, ByVal SizeMode As Integer)

        Dim dgv As DataGridView = Column.DataGridView
        Dim Rows As Integer
        Dim _w As Integer = 0
        Dim w As Integer = 0


        Select Case SizeMode

            Case = AutoSizeColumnMode_None

            Case = AutoSizeColumnMode_ColumnHeader
                w = GetColumnHeaderWidth(Column.HeaderCell)
                Column.Width = w

            Case = AutoSizeColumnMode_AllCells
                w = GetColumnHeaderWidth(Column.HeaderCell)
                For r As Integer = 0 To dgv.RowCount - 1
                    _w = GetColumnWidth(dgv.Rows(r).Cells(Column.Index))
                    If _w > w Then
                        w = _w
                    End If
                Next r
                Column.Width = w

            Case = AutoSizeColumnMode_AllCellsExceptHeader
                For r As Integer = 0 To dgv.RowCount - 1
                    _w = GetColumnWidth(dgv.Rows(r).Cells(Column.Index))
                    If _w > w Then
                        w = _w
                    End If
                Next r
                Column.Width = w

            Case = AutoSizeColumnMode_DisplayedCells
                w = GetColumnHeaderWidth(Column.HeaderCell)

                If dgv.RowCount > 50 Then
                    Rows = 50
                Else
                    Rows = dgv.RowCount
                End If

                For r As Integer = 0 To Rows - 1
                    _w = GetColumnWidth(dgv.Rows(r).Cells(Column.Index))
                    If _w > w Then
                        w = _w
                    End If
                Next r
                Column.Width = w

            Case = AutoSizeColumnMode_DisplayedCellsExceptHeader
                If dgv.RowCount <= 50 Then
                    Rows = 50
                Else
                    Rows = dgv.RowCount
                End If

                For r As Integer = 0 To Rows - 1
                    _w = GetColumnWidth(dgv.Rows(r).Cells(Column.Index))
                    If _w > w Then
                        w = _w
                    End If
                Next r
                Column.Width = w

            Case = AutoSizeColumnMode_Fill
                Column.Width = Column.Width

            Case Else

        End Select





    End Sub


    Private Sub SetRowHeight(ByVal Rows As Integer, ByVal Column As DataGridViewColumn, ByVal SizeMode As Integer)

        Dim dgv As DataGridView = Column.DataGridView
        For r As Integer = 0 To Rows - 1
            Dim SizeC As New System.Drawing.Size()
            Dim Size As New System.Drawing.Size()
            GetDataGridVielCellSize(dgv.Rows(r).Cells(Column.Index), Size, SizeC)

            Dim _width As Integer = Size.Width
            Dim _height As Integer = Size.Height
            Dim _theight As Integer = dgv.RowTemplate.Height
            Dim _h As Integer
            If _height <> 0 AndAlso _theight <> 0 Then
                'try
                '{
                _h = _theight \ _height
                If _h >= 1 Then
                    _width = _width \ _h
                End If
                If _width > Column.Width Then
                    Column.Width = _width
                End If
                '}
                'catch (Exception)
                '{


                '}
            End If
        Next r


    End Sub



    Private Function GetColumnHeaderWidth(ByVal Cell As DataGridViewCell) As Integer
        Dim SizeC As New System.Drawing.Size()
        Dim Size As New System.Drawing.Size()
        GetDataGridVielCellSize(Cell, Size, SizeC)

        Dim _width As Integer = Size.Width + (SizeC.Width)
        Dim _height As Double = Size.Height

        Dim _theight As Double = DataGridView.ColumnHeadersHeight
        Return _width
    End Function

    Private Function GetColumnWidth(ByVal Cell As DataGridViewCell) As Integer
        Dim SizeC As New System.Drawing.Size()
        Dim Size As New System.Drawing.Size()
        GetDataGridVielCellSize(Cell, Size, SizeC)

        Dim _width As Integer = Size.Width + SizeC.Width
        Dim _height As Double = Size.Height

        Dim _theight As Double = DataGridView.RowTemplate.Height
        Dim _h As Double

        If Cell.Value IsNot Nothing Then
            If Cell.Value.ToString().Contains(" ") = True Then
                If _height <> 0 AndAlso _theight >= _height Then
                    _h = _theight / _height
                    If _h >= 1 Then
                        _width = CInt(Fix(_width / _h))
                    End If
                End If
            End If
        End If

        Return _width
    End Function

    Private Sub GetDataGridVielCellSize(ByVal Cell As DataGridViewCell, ByRef Size As System.Drawing.Size, ByRef SizeC As System.Drawing.Size)
        Dim Column As DataGridViewColumn = Cell.OwningColumn
        Dim font As System.Drawing.Font = Column.DefaultCellStyle.Font
        If font Is Nothing Then
            font = Column.DataGridView.Font
        End If
        Dim fakeImage As System.Drawing.Image = New System.Drawing.Bitmap(1, 1) 'As we cannot use CreateGraphics() in a class library, so the fake image is used to load the Graphics.
        Dim graphics As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(fakeImage)
        Dim sizeF As New System.Drawing.SizeF()

        Dim sizeCF As New System.Drawing.SizeF()
        If Cell.Value IsNot Nothing Then
            sizeCF = graphics.MeasureString("M", font)
            SizeC.Height = CInt(Fix(sizeCF.Height))
            SizeC.Width = CInt(Fix(sizeCF.Width))

            sizeF = graphics.MeasureString(Cell.Value.ToString(), font)

            Size.Height = CInt(Fix(sizeF.Height))
            Size.Width = CInt(Fix(sizeF.Width))
        End If


    End Sub


End Class



''' <summary>
''' Dynamically determine and set a tab order for a container and children according to a given strategy.
''' </summary>
Public Class TabOrderManager
    ''' <summary>
    ''' Compare two controls in the selected tab scheme.
    ''' </summary>
    Private Class TabSchemeComparer
        Implements IComparer

        Private comparisonScheme As TabScheme

#Region "IComparer Members"

        Public Overridable Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare

            Dim control1 As Control = CType(x, Control)
            Dim control2 As Control = CType(y, Control)

            If IsNothing(control1) Or IsNothing(control2) Then
                Debug.Assert(False, "Attempting to compare a non-control")
                Return 0
            End If

            If comparisonScheme = TabScheme.AcrossFirst Then

                '// The primary direction to sort is the y direction (using the Top property).
                '// If two controls have the same y coordination, then we sort them by their x's.
                If control1.Top < control2.Top Then
                    Return -1
                ElseIf control1.Top > control2.Top Then
                    Return 1
                Else
                    Return (control1.Left.CompareTo(control2.Left))
                End If
            Else    '// comparisonScheme = TabScheme.DownFirst

                '// The primary direction to sort is the x direction (using the Left property).
                '// If two controls have the same x coordination, then we sort them by their y's.
                If control1.Left < control2.Left Then
                    Return -1
                ElseIf control1.Left > control2.Left Then
                    Return 1
                Else
                    Return (control1.Top.CompareTo(control2.Top))
                End If
            End If
        End Function

#End Region

        '// Create a tab scheme comparer that uses the given scheme.
        Public Sub New(ByVal scheme As TabScheme)
            comparisonScheme = scheme
        End Sub

    End Class

    ''' <summary>
    ''' The container whose tab order we manage.
    ''' </summary>
    Private container As Control

    ''' <summary>
    ''' Hash of controls to schemes so that individual containers can have different ordering
    ''' strategies than their parents.
    ''' </summary>
    Private schemeOverrides As Hashtable

    ''' <summary>
    ''' The tab index we start numbering from when the tab order is applied.
    ''' </summary>
    Private curTabIndex As Integer = 0

    ''' <summary>
    ''' The general tab-ordering strategy (i.e. whether we tab across rows first, or down columns).
    ''' </summary>
    Public Enum TabScheme
        None
        AcrossFirst
        DownFirst
    End Enum

    ''' <summary>
    ''' Constructor
    ''' </summary>
    ''' <param name="container">The container whose tab order we manage.</param>
    Public Sub New(ByVal container As Control)
        Me.container = container
        Me.curTabIndex = 0
        Me.schemeOverrides = New Hashtable
    End Sub

    ''' <summary>
    ''' Construct a tab order manager that starts numbering at the given tab index.
    ''' </summary>
    ''' <param name="container">The container whose tab order we manage.</param>
    ''' <param name="curTabIndex">Where to start numbering.</param>
    ''' <param name="schemeOverrides">List of controls with explicitly defined schemes.</param>
    Private Sub New(ByVal container As Control, ByVal curTabIndex As Integer, ByVal schemeOverrides As Hashtable)
        Me.container = container
        Me.curTabIndex = curTabIndex
        Me.schemeOverrides = schemeOverrides
    End Sub

    ''' <summary>
    ''' Explicitly set a tab order scheme for a given (presumably container) control.
    ''' </summary>
    ''' <param name="c">The control to set the scheme for.</param>
    ''' <param name="scheme">The requested scheme.</param>
    Public Sub SetSchemeForControl(ByVal c As Control, ByVal scheme As TabScheme)
        schemeOverrides(c) = scheme
    End Sub

    ''' <summary>
    ''' Recursively set the tab order on this container and all of its children.
    ''' </summary>
    ''' <param name="scheme">The tab ordering strategy to apply.</param>
    ''' <returns>The next tab index to be used.</returns>
    Public Function SetTabOrder(ByVal scheme As TabScheme) As Integer

        '// Tab order isn't important enough to ever cause a crash, so replace any exceptions
        '// with assertions.
        Try
            Dim controlArraySorted As New ArrayList
            controlArraySorted.AddRange(container.Controls)
            controlArraySorted.Sort(New TabSchemeComparer(scheme))

            'Dim controlsWithScheme As ArrayList
            Dim c As Control
            For Each c In controlArraySorted
                c.TabIndex = curTabIndex
                curTabIndex = curTabIndex + 1

                If c.Controls.Count > 0 Then
                    '// Control has children -- recurse.
                    Dim childScheme As TabScheme = scheme
                    If schemeOverrides.Contains(c) Then
                        childScheme = CType(schemeOverrides(c), TabScheme)
                    End If
                    curTabIndex = (New TabOrderManager(c, curTabIndex, schemeOverrides)).SetTabOrder(childScheme)
                End If
            Next c

            Return curTabIndex
        Catch e As Exception
            Debug.Assert(False, "Exception in TabOrderManager.SetTabOrder:  " + e.Message)
            Return 0
        End Try
    End Function
End Class
