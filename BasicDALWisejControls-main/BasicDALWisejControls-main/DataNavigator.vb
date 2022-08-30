Imports System
Imports Wisej.Web

Public Class DataNavigator
    Public Enum EventType
        Move
        MoveFirst
        MoveLast
        MoveNext
        MovePrevious
        AddNew
        Delete
        Save
        Close
        Undo
        Print
        Find
        Refresh
    End Enum

    Public ListViewColumns As New ListViewColumns
    Private _DataGridListViewDataTable As DataTable
    Private _DataGridListViewDefaultRowHeight As Integer = 24
    Private _MovePreviousCaption As String = "Prev."
    Private _MoveNextCaption As String = "Next"
    Private _MoveFirstCaption As String = "First"
    Private _MoveLastCaption As String = "Last"
    Private _AddNewCaption As String = "New"
    Private _DeleteCaption As String = "Delete"
    Private _SaveCaption As String = "Save"
    Private _RefreshCaption As String = "Refresh"
    Private _UndoCaption As String = "Undo"
    Private _CloseCaption As String = "Close"
    Private _FindCaption As String = "Find"
    Private _PrintCaption As String = "Print"

    'Private _MovePreviousFKey As Keys = Keys.F6
    'Private _MoveNextFKey As Keys = Keys.F7
    'Private _MoveFirstFKey As Keys = Keys.Shift + Keys.F6
    'Private _MoveLastFKey As Keys = Keys.Shift + Keys.F7
    'Private _AddNewFKey As Keys = Keys.F2
    'Private _DeleteFKey As Keys = Keys.F3
    'Private _SaveFKey As Keys = Keys.F10
    'Private _RefreshFKey As Keys = Keys.F5
    'Private _UndoFKey As Keys = Keys.F9
    'Private _CloseFKey As Keys = Keys.F12
    'Private _FindKey As Keys = Keys.F4

    'Private _PrintFKey As Integer = Keys.F8

    Private WithEvents _DbObject As BasicDAL.DbObject
    Private _Dataset As DataSet
    Private _DataTable As DataTable
    Private _BindingSource As BindingSource
    Private _DataGridListViewRowIndexColumnName As String = "$<rowindex>$"
    Private _DataGridListViewRowIndexColumnIndex As Integer = 0

    Private WithEvents _DataGrid As Wisej.Web.DataGridView
    Private WithEvents _DataGridListView As Wisej.Web.DataGridView



    Private _DeleteMessage As String = "Confermi la cancellazione dei dati?"
    Private _SaveMessage As String = "Confermi il salvataggio dei dati?"
    Private _AddNewMessage As String = "Confermi la l'inserimento di nuovi dati?"

    Private _ManageNavigation As Boolean = True
    Private _DataGridActive As Boolean = False
    Private _DataGridListViewActive As Boolean = False

    Private _DataPanel As Panel


    Event eAddNew()
    Event ePrint()
    Event eDelete()
    Event eRefresh()
    Event eClose()
    Event eFind()
    Event eSave()
    Event eMovePrevious()
    Event eMoveFirst()
    Event eMoveLast()
    Event eMoveNext()
    Event eUndo()


    Event eBoundCompleted()
    Event eAddNewRequest(ByRef Cancel As Boolean)
    Event ePrintRequest(ByRef Cancel As Boolean)
    Event eDeleteRequest(ByRef Cancel As Boolean)
    Event eRefreshRequest(ByRef Cancel As Boolean)
    Event eCloseRequest(ByRef Cancel As Boolean)
    Event eFindRequest(ByRef Cancel As Boolean)
    Event eSaveRequest(ByRef Cancel As Boolean)
    Event eMovePreviousRequest(ByRef Cancel As Boolean)
    Event eMoveFirstRequest(ByRef Cancel As Boolean)
    Event eMoveLastRequest(ByRef Cancel As Boolean)
    Event eMoveNextRequest(ByRef Cancel As Boolean)
    Event eUndoRequest(ByRef Cancel As Boolean)

    Private _ReadOnlyMode As Boolean = False
    'Private _AddNewPending As Boolean = False
    Private _DeletePending As Boolean = False
    Private _SavePending As Boolean = False
    Private _PrintPending As Boolean = False
    Private _FindPending As Boolean = False
    Private _UndoPending As Boolean = False
    Private _NavigationEnabled As Boolean = True
    Private _DataGridRow As Integer = -1
    Private _CompactMode As Boolean = False


    Property ReadOnlyMode As Boolean
        Get
            Return _ReadOnlyMode
        End Get
        Set(ByVal value As Boolean)
            _ReadOnlyMode = value
            Me.SetDataNavigator()
        End Set
    End Property

    Property CompactMode As Boolean
        Get
            Return _CompactMode
        End Get
        Set(ByVal value As Boolean)
            _CompactMode = value

            If _CompactMode = True Then

                bClose.Text = ""
                bClose.ToolTipText = _CloseCaption
                bDelete.Text = ""
                bDelete.ToolTipText = _DeleteCaption
                bFind.Text = ""
                bFind.ToolTipText = _FindCaption
                bFirst.Text = ""
                bFirst.ToolTipText = _MoveFirstCaption
                bLast.Text = ""
                bLast.ToolTipText = _MoveLastCaption
                bNew.Text = ""
                bNew.ToolTipText = _AddNewCaption
                bPrev.Text = ""
                bPrev.ToolTipText = _MovePreviousCaption
                bPrint.Text = ""
                bPrint.ToolTipText = _PrintCaption
                bRefresh.Text = ""
                bRefresh.ToolTipText = _RefreshCaption
                bSave.Text = ""
                bSave.ToolTipText = _SaveCaption
                bUndo.Text = ""
                bUndo.ToolTipText = _UndoCaption
                bNext.Text = ""
                bNext.ToolTipText = _MoveNextCaption

            Else
                bClose.Text = _CloseCaption
                bClose.ToolTipText = ""
                bDelete.Text = _DeleteCaption
                bDelete.ToolTipText = ""
                bFind.Text = _FindCaption
                bFind.ToolTipText = ""
                bFirst.Text = _MoveFirstCaption
                bFirst.ToolTipText = ""
                bLast.Text = _MoveLastCaption
                bLast.ToolTipText = ""
                bNew.Text = _AddNewCaption
                bNew.ToolTipText = ""
                bPrev.Text = _MovePreviousCaption
                bPrev.ToolTipText = ""
                bPrint.Text = _PrintCaption
                bPrint.ToolTipText = ""
                bRefresh.Text = _RefreshCaption
                bRefresh.ToolTipText = ""
                bSave.Text = _SaveCaption
                bSave.ToolTipText = ""
                bUndo.Text = _UndoCaption
                bUndo.ToolTipText = ""
                bNext.Text = _MoveNextCaption
                bNext.ToolTipText = ""
            End If

        End Set
    End Property

    Property DataGridListViewDefaultRowHeight As Integer
        Get
            DataGridListViewDefaultRowHeight = _DataGridListViewDefaultRowHeight
        End Get
        Set(ByVal value As Integer)
            _DataGridListViewDefaultRowHeight = value
            Me.DataGridListView.DefaultRowHeight = _DataGridListViewDefaultRowHeight
        End Set
    End Property


    Property BindingSource As BindingSource
        Get
            BindingSource = _BindingSource
        End Get
        Set(ByVal value As BindingSource)
            _BindingSource = value
        End Set
    End Property

    Property DataPanel() As Panel
        Get
            DataPanel = _DataPanel
        End Get
        Set(ByVal value As Panel)
            _DataPanel = value
        End Set
    End Property
    Property DataGridRow() As Integer
        Get
            DataGridRow = _DataGridRow
        End Get
        Set(ByVal value As Integer)
            _DataGridRow = value
        End Set
    End Property
    Property DataGrid() As Wisej.Web.DataGridView
        Get
            DataGrid = _DataGrid
        End Get
        Set(ByVal value As Wisej.Web.DataGridView)
            _DataGrid = value

        End Set
    End Property

    Property DataGridListView() As Wisej.Web.DataGridView
        Get
            DataGridListView = _DataGridListView
        End Get
        Set(ByVal value As Wisej.Web.DataGridView)
            _DataGridListView = value
            _DataGridListView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            _DataGridListView.MultiSelect = False


        End Set
    End Property
    Private _Caption As String
    Public Property Caption() As String
        Get

            Return _Caption

        End Get
        Set(ByVal value As String)
            _Caption = value
            Me.Panel.Text = _Caption
        End Set
    End Property

    Property RecordLabelVisible() As Boolean
        Get
            Return Me.RecordLabel.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.RecordLabel.Visible = value
        End Set
    End Property



    Property NavigationEnabled() As Boolean
        Get
            NavigationEnabled = _NavigationEnabled

        End Get
        Set(ByVal value As Boolean)
            _NavigationEnabled = value

            Select Case _NavigationEnabled
                Case Is = False
                    DisableNavigation()
                Case Is = True
                    EnableNavigation()
            End Select
        End Set
    End Property

    Public Sub DataNavigatorInit(Optional ByVal LoadData As Boolean = False)
        Me._InitDataNavigator(LoadData)
    End Sub

    Public Sub Init(Optional ByVal LoadData As Boolean = False)
        Me._InitDataNavigator(LoadData)
    End Sub

    Public Sub InitDataNavigator(Optional ByVal LoadData As Boolean = False)
        Me._InitDataNavigator(LoadData)
    End Sub


    Private Sub _InitDataNavigator(Optional ByVal LoadData As Boolean = False)

        If LoadData Then
            Me._DbObject.Open(True)
        End If

        If _DbObject.IsReadOnly Then
            Me.AddNewVisible = False
            Me.AddNewEnabled = False
            Me.DisableNew()

            Me.DeleteEnabled = False
            Me.DeleteVisible = False
            Me.DisableDelete()

            Me.SaveEnabled = False
            Me.SaveVisible = False
            Me.DisableSave()


            Me.UndoEnabled = False
            Me.UndoVisible = False
            Me.DisableUndo()
        Else
            Me.AddNewVisible = True
            Me.DeleteVisible = True
            Me.SaveVisible = True
            Me.UndoVisible = True
        End If


        UpdateRecordLabel()

    End Sub
    Public Function DataGrid_Save() As Integer
        Return DataGrid_Update(Me._DataGrid)
    End Function

    Public Function DataGrid_Save(ByVal DataGridView As Wisej.Web.DataGridView) As Integer
        Return DataGrid_Update(DataGridView)
    End Function

    Public Function DataGrid_Update() As Integer
        Return DataGrid_Update(Me._DataGrid)
    End Function

    Public Function DataGrid_Update_OLD(ByVal DataGridView As Wisej.Web.DataGridView) As Integer

        Dim AffectedRecords As Integer = 0
        Dim CurrentRowIndex As Integer = 0
        Dim FirstDisplayedScrollingRowIndex As Integer = 0
        Dim CurrentCellIndex As Integer = 0

        If DataGridView Is Nothing Then
            Return AffectedRecords

        End If
        If DataGridView IsNot Nothing And DataGridView.DataSource IsNot Nothing And DataGridView.CurrentRow IsNot Nothing Then

            Dim allowAdd As Boolean = DataGridView.AllowUserToAddRows

            CurrentRowIndex = DataGridView.CurrentRow.Index
            CurrentCellIndex = DataGrid.CurrentCell.ColumnIndex
            'FirstDisplayedScrollingRowIndex = DataGridView.FirstDisplayedRowIndex

            Try
                'DataGridView.CommitEdit()
                DataGridView.EndEdit()
                Dim dt As DataTable = DataGridView.DataSource()
                Dim dr As DataRow = Nothing

                Try
                    DataGridView.AllowUserToAddRows = True
                    dr = dt.Rows.Add()
                    DataGridView.CurrentCell = DataGridView(CurrentCellIndex, DataGridView.RowCount - 1)
                    dr.Delete()
                Catch ex As Exception
                    dr.Delete()
                End Try


                AffectedRecords = Me.DbObject.UpdateFromDataTable(dt)
                Me._DataGridRow = DataGridView.CurrentRow.Index
                'Me._AddNewPending = False

            Catch ex As Exception

                'DataGridView.AllowUserToAddRows = allowAdd

            End Try

            Try
                DataGridView.CurrentCell = DataGridView(CurrentCellIndex, CurrentRowIndex)
            Catch ex As Exception

            End Try

            DataGridView.AllowUserToAddRows = allowAdd




        End If

        SetDataNavigator()
        ' LockWindow(DataGridView.Handle, False)
        Return AffectedRecords

    End Function

    Public Function DataGrid_Update(ByRef DataGridView As Wisej.Web.DataGridView) As Integer

        Dim AffectedRecords As Integer = 0
        Dim CurrentRowIndex As Integer = 0
        Dim CurrentCellIndex As Integer = 0

        If DataGridView Is Nothing Then
            Return AffectedRecords
        End If

        If DataGridView IsNot Nothing And DataGridView.DataSource IsNot Nothing And DataGridView.CurrentRow IsNot Nothing Then

            Dim allowAdd As Boolean = DataGridView.AllowUserToAddRows

            CurrentRowIndex = DataGridView.CurrentRow.Index
            CurrentCellIndex = DataGrid.CurrentCell.ColumnIndex

            Try
                DataGridView.EndEdit()
                DataGridView.AllowUserToAddRows = True
                Dim dt As DataTable = DataGridView.DataSource()
                Dim dr As DataRow = Nothing
                Try
                    DataGridView.AllowUserToAddRows = True
                    DataGridView.DataSource = Nothing
                    dr = dt.Rows.Add()
                    'DataGridView.CurrentCell = DataGridView(CurrentCellIndex, DataGridView.RowCount - 1)
                    dr.Delete()
                Catch ex As Exception
                End Try
                AffectedRecords = Me.DbObject.UpdateFromDataTable(dt)
                DataGridView.DataSource = dt
                Me._DataGridRow = DataGridView.CurrentRow.Index
                'Me._AddNewPending = False
            Catch ex As Exception
                '
                '
            End Try

            Try
                DataGridView.CurrentCell = DataGridView(CurrentCellIndex, CurrentRowIndex)
            Catch ex As Exception
            End Try

            DataGridView.AllowUserToAddRows = allowAdd




        End If

        SetDataNavigator()
        ' LockWindow(DataGridView.Handle, False)
        Return AffectedRecords


    End Function



    Public Sub DataGrid_EnableRowChange()
        Me._DataGridRow = -1
    End Sub
    Public Function DataGrid_AddNew(Optional ByVal InsertAtCursor As Boolean = False) As Integer
        Return DataGrid_AddNew(Me._DataGrid, InsertAtCursor)
    End Function

    Private Function FindFirstEditableColumn(ByVal DataGridView As DataGridView) As Integer

        For I As Integer = 0 To DataGridView.Columns.Count - 1
            Dim c As DataGridViewColumn = DataGridView.Columns(I)
            If c.Visible = True Then
                If c.ReadOnly = False Then
                    Return I
                End If
            End If
        Next

        Return -1
    End Function

    Public Function DataGrid_AddNew(ByRef DataGridView As DataGridView, Optional InsertAtCursor As Boolean = False) As Integer

        Dim ColumnIndex As Integer = 0
        Dim RowIndex As Integer = 0
        Dim xRowIndex As Integer = 0
        ' LockWindow(Me.ParentForm.Handle, True)
        If DataGridView Is Nothing Then Return 0
        If DataGridView.DataSource IsNot Nothing Then
            Try
                Dim dt As DataTable = DataGridView.DataSource
                Dim Rf As String = dt.DefaultView.RowFilter
                Dim Rs As String = dt.DefaultView.Sort
                dt.DefaultView.RowFilter = ""
                ColumnIndex = FindFirstEditableColumn(DataGridView)


                If DataGridView.RowCount = 0 Then
                    RowIndex = 0
                    dt.Rows.Add()
                Else


                    If InsertAtCursor = True Then
                        ' ------- INSERISCE NELLA POSIZIONE DEL CURSORE ----
                        'RowIndex = DataGridView.CurrentRow.Index

                        Select Case DataGridView.SortOrder
                            Case Is = SortOrder.None
                                xRowIndex = CType(DataGridView.DataSource, DataTable).Rows.IndexOf(CType(DataGridView.CurrentRow.DataBoundItem, DataRowView).Row) + 1
                                Dim nRow As DataRow
                                nRow = dt.NewRow()
                                dt.Rows.InsertAt(nRow, xRowIndex)
                                RowIndex = xRowIndex
                            Case Is = SortOrder.Descending
                                dt.Rows.Add()
                                RowIndex = DataGridView.Rows.Count - 1
                            Case Is = SortOrder.Ascending
                                dt.Rows.Add()
                                RowIndex = 0
                        End Select

                        '----------------------------------------------------
                    Else

                        DataGridView.CurrentCell = DataGridView(ColumnIndex, DataGridView.Rows.Count - 1)
                        ' ------- INSERISCE ALLA FINE O ALL'INIZIO-----------
                        Select Case DataGridView.SortOrder
                            Case Is = SortOrder.Descending
                                dt.Rows.Add()
                                RowIndex = DataGridView.Rows.Count - 1
                            Case Is = SortOrder.Ascending
                                dt.Rows.Add()
                                RowIndex = 0
                            Case Is = SortOrder.None
                                dt.Rows.Add()
                                RowIndex = DataGridView.Rows.Count - 1
                        End Select
                        '----------------------------------------------------
                    End If
                    ColumnIndex = DataGridView.CurrentCell.ColumnIndex
                End If

                DataGridView.CurrentCell = DataGridView(ColumnIndex, RowIndex)
                'Me._AddNewPending = True
                Me._DataGridRow = DataGridView.CurrentCell.RowIndex
                Me.SetButtonsForAddNew()

            Catch ex As Exception
                'LockWindow(Me.ParentForm.Handle, False)
            End Try
        End If
        'LockWindow(Me.ParentForm.Handle, False)
        Return Me._DataGridRow
    End Function

    Public Function DataGrid_Delete() As Integer

        Return DataGrid_Delete(Me._DataGrid)

    End Function

    Public Function DataGrid_Delete(ByVal DataGridView As Wisej.Web.DataGridView) As Integer
        Dim RowIndex As Integer = 0
        If DataGridView Is Nothing Then Return 0 ' Exit Function
        If DataGridView.DataSource IsNot Nothing Then

            'If Me._ManageNavigation = True Then
            If DataGridView.CurrentRow IsNot Nothing Then
                RowIndex = DataGridView.CurrentRow.Index
                DataGridView.Rows.Remove(DataGridView.CurrentRow)
            End If
            'endif

            Dim dt As DataTable = DataGridView.DataSource
            SetDataNavigator()

            Dim xRec As Integer = 0
            xRec = _DbObject.UpdateFromDataTable(dt)

            If RowIndex <> 0 Then
                If RowIndex < DataGridView.Rows.Count Then
                    For Each Column As DataGridViewColumn In DataGridView.Columns
                        If Column.Visible = True Then
                            DataGridView.CurrentCell = DataGridView.Rows(RowIndex).Cells(Column.Index)
                            Exit For
                        End If
                    Next
                Else
                    For Each Column As DataGridViewColumn In DataGridView.Columns
                        If Column.Visible = True Then
                            DataGridView.CurrentCell = DataGridView.Rows(RowIndex - 1).Cells(Column.Index)
                            Exit For
                        End If
                    Next
                End If
            End If
            DataGridView.Refresh()
            Return xRec
        Else
            SetDataNavigator()
            Return 0
        End If

    End Function

    Public Sub DataGrid_Undo()
        DataGrid_Undo(Me._DataGrid)

    End Sub

    Public Sub DataGrid_Undo(ByVal DataGridView As Wisej.Web.DataGridView)

        If DataGridView Is Nothing Then Exit Sub
        If DataGridView.DataSource IsNot Nothing Then

            Dim dt As DataTable = _DataGrid.DataSource
            dt.RejectChanges()

            Me._DataGrid.CancelEdit()
            Me._DataGrid.Refresh()
            If Me.AddNewPending Then
                Me._DataGrid.Refresh()
            End If
        End If

        'Me._AddNewPending = False
        SetDataNavigator()

    End Sub
    Sub CancelFind()
        _FindPending = False
    End Sub
    Sub CancelPrint()
        _PrintPending = False
    End Sub
    Sub CancelSave()
        _SavePending = False
    End Sub
    Sub CancelAddNew()
        '_AddNewPending = False
        Me._DbObject.UndoChanges()
    End Sub

    Sub CancelUndo()
        _UndoPending = False

    End Sub
    Sub CancelDelete()
        _DeletePending = False
    End Sub
    Property UndoPending() As Boolean
        Get
            UndoPending = _UndoPending
        End Get
        Set(ByVal value As Boolean)
            _UndoPending = UndoPending
        End Set
    End Property
    Property FindPending() As Boolean
        Get
            FindPending = _FindPending
        End Get
        Set(ByVal value As Boolean)
            _FindPending = value
        End Set
    End Property
    Property PrintPending() As Boolean
        Get
            PrintPending = _PrintPending
        End Get
        Set(ByVal value As Boolean)
            _PrintPending = value
        End Set
    End Property

    Property SavePending() As Boolean
        Get
            SavePending = _SavePending
        End Get
        Set(ByVal value As Boolean)
            _SavePending = value
        End Set
    End Property

    ReadOnly Property AddNewPending() As Boolean
        Get
            AddNewPending = False
            If Me._DbObject IsNot Nothing Then
                AddNewPending = Me._DbObject.AddNewStatus
            End If

        End Get

    End Property

    Property DeletePending() As Boolean
        Get
            DeletePending = _DeletePending
        End Get
        Set(ByVal value As Boolean)
            _DeletePending = value
        End Set
    End Property

    Property DeleteMessage() As String
        Get
            DeleteMessage = _DeleteMessage

        End Get
        Set(ByVal value As String)
            _DeleteMessage = value

        End Set
    End Property

    Property SaveMessage() As String
        Get
            SaveMessage = _SaveMessage

        End Get
        Set(ByVal value As String)
            _SaveMessage = value

        End Set
    End Property
    Property DataSet() As DataSet
        Get
            DataSet = _Dataset

        End Get
        Set(ByVal value As DataSet)
            _Dataset = value
        End Set
    End Property

    Property DataGridActive() As Boolean
        Get

            If (Me._DataGrid IsNot Nothing) Then
                DataGridActive = Me._DataGrid.Enabled
            Else
                DataGridActive = _DataGridActive
            End If


        End Get
        Set(ByVal value As Boolean)
            If (Me._DataGrid IsNot Nothing) Then
                Me._DataGrid.Enabled = value
            End If

            _DataGridActive = value
            Me.UpdateRecordLabel()
        End Set
    End Property
    Property DataGridListViewActive() As Boolean
        Get

            DataGridListViewActive = _DataGridListViewActive


        End Get
        Set(ByVal value As Boolean)


            _DataGridListViewActive = value
        End Set
    End Property

    Property SaveVisible() As Boolean
        Get
            SaveVisible = Me.bSave.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.bSave.Visible = value

        End Set
    End Property
    Property SaveEnabled() As Boolean
        Get
            SaveEnabled = Me.bSave.Enabled
        End Get
        Set(ByVal value As Boolean)
            Me.bSave.Enabled = value
        End Set
    End Property

    Property UndoVisible() As Boolean
        Get
            UndoVisible = Me.bUndo.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.bUndo.Visible = value

        End Set
    End Property
    Property UndoEnabled() As Boolean
        Get
            UndoEnabled = Me.bUndo.Enabled
        End Get
        Set(ByVal value As Boolean)
            Me.bUndo.Enabled = value
        End Set
    End Property




    Property FindVisible() As Boolean
        Get
            FindVisible = Me.bFind.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.bFind.Visible = value

        End Set
    End Property
    Property FindEnabled() As Boolean
        Get
            FindEnabled = Me.bFind.Enabled
        End Get
        Set(ByVal value As Boolean)
            Me.bFind.Enabled = value
        End Set
    End Property

    Property DeleteEnabled() As Boolean
        Get
            DeleteEnabled = Me.bDelete.Enabled
        End Get
        Set(ByVal value As Boolean)
            Me.bDelete.Enabled = value
        End Set
    End Property

    Property PrintVisible() As Boolean
        Get
            PrintVisible = Me.bPrint.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.bPrint.Visible = value

        End Set
    End Property
    Property PrintEnabled() As Boolean
        Get
            PrintEnabled = Me.bPrint.Enabled
        End Get
        Set(ByVal value As Boolean)
            Me.bPrint.Enabled = value
        End Set
    End Property
    Property AddNewVisible() As Boolean
        Get
            AddNewVisible = Me.bNew.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.bNew.Visible = value

        End Set
    End Property
    Property CloseVisible() As Boolean
        Get
            CloseVisible = Me.bClose.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.bClose.Visible = value

        End Set
    End Property
    Property CloseEnabled() As Boolean
        Get
            CloseEnabled = Me.bClose.Enabled
        End Get
        Set(ByVal value As Boolean)
            Me.bClose.Enabled = value

        End Set
    End Property
    Public Sub ShowAllButtons()
        CloseVisible = True
        PrintVisible = True
        DeleteVisible = True
        RefreshVisible = True
        FindVisible = True
        SaveVisible = True
        UndoVisible = True
        AddNewVisible = True
        NavigationVisible(True)
        RecordLabelVisible = True
    End Sub
    Public Sub HideAllButtons()
        CloseVisible = False
        PrintVisible = False
        DeleteVisible = False
        RefreshVisible = False
        FindVisible = False
        SaveVisible = False
        UndoVisible = False
        AddNewVisible = False
        NavigationVisible(False)
        RecordLabelVisible = False
    End Sub

    Property ShowHeader() As Boolean
        Get
            Return Me.Panel.ShowHeader
        End Get
        Set(ByVal value As Boolean)
            Me.Panel.ShowHeader = value
        End Set
    End Property
    Property HeaderBackColor() As System.Drawing.Color
        Get
            Return Me.Panel.HeaderBackColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            Me.Panel.HeaderBackColor = value
        End Set
    End Property

    Property HeaderAlignment() As HorizontalAlignment
        Get
            Return Me.Panel.HeaderAlignment
        End Get
        Set(ByVal value As HorizontalAlignment)
            Me.Panel.HeaderAlignment = value
        End Set
    End Property
    Property HeaderForeColor() As System.Drawing.Color
        Get
            Return Me.Panel.HeaderForeColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            Me.Panel.HeaderForeColor = value
        End Set
    End Property

    Property HeaderPosition() As HeaderPosition
        Get
            Return Me.Panel.HeaderPosition
        End Get
        Set(ByVal value As HeaderPosition)
            Me.Panel.HeaderPosition = value
        End Set
    End Property
    Property HeaderSize() As Integer
        Get
            Return Me.Panel.HeaderSize
        End Get
        Set(ByVal value As Integer)
            Me.Panel.HeaderSize = value
        End Set
    End Property

    Property DeleteVisible() As Boolean
        Get
            DeleteVisible = Me.bDelete.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.bDelete.Visible = value
        End Set
    End Property
    Property AddNewEnabled() As Boolean
        Get
            AddNewEnabled = Me.bNew.Enabled
        End Get
        Set(ByVal value As Boolean)
            Me.bNew.Enabled = value


        End Set
    End Property

    Property ManageNavigation() As Boolean
        Get
            ManageNavigation = _ManageNavigation
        End Get
        Set(ByVal value As Boolean)
            _ManageNavigation = value
        End Set
    End Property

    Property DbObject() As BasicDAL.DbObject

        Get
            DbObject = _DbObject
        End Get

        Set(ByVal value As BasicDAL.DbObject)
            _DbObject = value

            Try
                Me.SetDataNavigator()
                Me.UpdateRecordLabel()
            Catch ex As Exception

            End Try

        End Set
    End Property

    Public Property DelegateCurrencyManager() As Boolean
        Get
            DelegateCurrencyManager = _ManageNavigation
        End Get
        Set(ByVal value As Boolean)
            _ManageNavigation = value
        End Set
    End Property


    'Property PrintFKey() As Keys
    '    Get
    '        PrintFKey = _PrintFKey
    '    End Get
    '    Set(ByVal value As Keys)
    '        _PrintFKey = value
    '    End Set
    'End Property
    'Property MovePreviousFKey() As Keys
    '    Get
    '        MovePreviousFKey = _MovePreviousFKey
    '    End Get
    '    Set(ByVal value As Keys)
    '        _MovePreviousFKey = value
    '    End Set
    'End Property

    'Property MoveNextFKey() As Keys
    '    Get
    '        MoveNextFKey = _MoveNextFKey
    '    End Get
    '    Set(ByVal value As Keys)
    '        _MoveNextFKey = value
    '    End Set
    'End Property

    'Property MoveFirstFKey() As Keys
    '    Get
    '        MoveFirstFKey = _MoveFirstFKey
    '    End Get
    '    Set(ByVal value As Keys)
    '        _MoveFirstFKey = value
    '    End Set
    'End Property

    'Property MoveLastFKey() As Keys
    '    Get
    '        MoveLastFKey = _MoveLastFKey
    '    End Get
    '    Set(ByVal value As Keys)
    '        _MoveLastFKey = value
    '    End Set
    'End Property

    'Property AddNewFKey() As Keys
    '    Get
    '        AddNewFKey = _AddNewFKey
    '    End Get
    '    Set(ByVal value As Keys)
    '        _AddNewFKey = value
    '    End Set
    'End Property

    'Property DeleteFKey() As Keys
    '    Get
    '        DeleteFKey = _DeleteFKey
    '    End Get
    '    Set(ByVal value As Keys)
    '        _DeleteFKey = value
    '    End Set
    'End Property


    'Property SaveFKey() As Keys
    '    Get
    '        SaveFKey = _SaveFKey
    '    End Get
    '    Set(ByVal value As Keys)
    '        _SaveFKey = value
    '    End Set
    'End Property

    'Property ReFreshFKey() As Keys
    '    Get
    '        ReFreshFKey = _RefreshFKey
    '    End Get
    '    Set(ByVal value As Keys)
    '        _RefreshFKey = value
    '    End Set
    'End Property

    'Property UndoFKey() As Keys
    '    Get
    '        UndoFKey = _UndoFKey
    '    End Get
    '    Set(ByVal value As Keys)
    '        _UndoFKey = value
    '    End Set
    'End Property



    'Property CloseFkey() As Keys
    '    Get
    '        CloseFkey = _CloseFKey
    '    End Get
    '    Set(ByVal value As Keys)
    '        _CloseFKey = value
    '    End Set
    'End Property


    Property AddNewCaption() As String
        Get
            AddNewCaption = Me._AddNewCaption
        End Get
        Set(ByVal value As String)
            Me._AddNewCaption = value
            Me.bNew.Text = value
        End Set
    End Property



    Property FindCaption() As String
        Get
            FindCaption = Me._FindCaption

        End Get
        Set(ByVal value As String)
            Me._FindCaption = value
            Me.bFind.Text = value
        End Set
    End Property
    Property CloseCaption() As String
        Get
            CloseCaption = Me._CloseCaption

        End Get
        Set(ByVal value As String)
            Me._CloseCaption = value
            Me.bClose.Text = value
        End Set
    End Property

    Property PrintCaption() As String
        Get
            PrintCaption = Me._PrintCaption

        End Get
        Set(ByVal value As String)
            Me._PrintCaption = value
            Me.bPrint.Text = value
        End Set
    End Property



    Property DeleteCaption() As String
        Get
            DeleteCaption = Me._DeleteCaption
        End Get
        Set(ByVal value As String)
            Me._DeleteCaption = value
            Me.bDelete.Text = value
        End Set

    End Property
    Property SaveCaption() As String
        Get
            SaveCaption = Me._SaveCaption
        End Get
        Set(ByVal value As String)
            Me._SaveCaption = value
            Me.bSave.Text = value
        End Set
    End Property


    Property RefreshEnabled() As Boolean
        Get
            RefreshEnabled = Me.bRefresh.Enabled
        End Get
        Set(ByVal value As Boolean)
            Me.bRefresh.Enabled = value

        End Set
    End Property


    Property RefreshVisible() As Boolean
        Get
            RefreshVisible = Me.bRefresh.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.bRefresh.Visible = value
        End Set
    End Property

    Property RefreshCaption() As String
        Get
            RefreshCaption = Me._RefreshCaption

        End Get
        Set(ByVal value As String)
            Me._RefreshCaption = value
            Me.bRefresh.Text = Me._RefreshCaption
        End Set
    End Property

    Property UndoCaption() As String
        Get
            UndoCaption = Me._UndoCaption

        End Get
        Set(ByVal value As String)
            Me._UndoCaption = value
            Me.bUndo.Text = Me._UndoCaption
        End Set
    End Property
    Property MovePreviousCaption() As String
        Get
            MovePreviousCaption = Me._MovePreviousCaption
        End Get
        Set(ByVal value As String)
            Me._MovePreviousCaption = value
            Me.bPrev.Text = Me._MovePreviousCaption
        End Set
    End Property
    Property MoveNextCaption() As String
        Get
            MoveNextCaption = Me._MoveNextCaption
        End Get
        Set(ByVal value As String)
            Me._MoveNextCaption = value
            Me.bNext.Text = Me._MoveNextCaption
        End Set
    End Property
    Property MoveLastCaption() As String
        Get
            MoveLastCaption = Me._MoveLastCaption
        End Get
        Set(ByVal value As String)
            Me._MoveLastCaption = value
            Me.bLast.Text = Me._MoveLastCaption
        End Set
    End Property
    Property MoveFirstCaption() As String
        Get
            MoveFirstCaption = Me._MoveFirstCaption

        End Get
        Set(ByVal value As String)
            Me._MoveFirstCaption = value
            Me.bFirst.Text = Me._MoveFirstCaption
        End Set
    End Property

    Public Sub LockParentFormUpdate(ByVal TrueFalse As Boolean)
        'LockWindow(Me.ParentForm.Handle, TrueFalse)
    End Sub

    'Public Sub HandleUserInput(ByVal sender As Object, ByVal e As Object)

    '    Dim Key As KeyEventArgs = e

    '    Select Case CInt(Key.KeyData)
    '        Case _MovePreviousFKey
    '            MovePrevious()
    '        Case _MoveNextFKey
    '            e.suppresskeypress = True
    '            MoveNext()
    '        Case _MoveFirstFKey
    '            e.suppresskeypress = True
    '            MoveFirst()
    '        Case _MoveLastFKey
    '            e.suppresskeypress = True
    '            MoveLast()
    '        Case _AddNewFKey
    '            e.suppresskeypress = True
    '            AddNew()
    '        Case _DeleteFKey
    '            e.suppresskeypress = True
    '            Delete()
    '        Case _SaveFKey
    '            e.suppresskeypress = True
    '            Save()
    '        Case _RefreshFKey
    '            e.suppresskeypress = True
    '            RefreshData()
    '        Case _PrintFKey
    '            e.suppresskeypress = True

    '            If Me.PrintEnabled = True And Me.PrintVisible = True Then
    '                RaiseEvent ePrint()
    '            End If

    '        Case _UndoFKey
    '            e.suppresskeypress = True
    '            Undo()
    '        Case _FindKey
    '            e.suppressKeypress = True
    '            If Me.FindEnabled = True And Me.FindVisible = True Then
    '                RaiseEvent eFind()
    '            End If

    '        Case _CloseFKey
    '            e.suppresskeypress = True
    '            RaiseEvent eClose()
    '        Case Else

    '    End Select




    'End Sub
    Public Sub NavigationVisible(ByVal Visible As Boolean)
        Me.bPrev.Visible = Visible
        Me.bFirst.Visible = Visible
        Me.bLast.Visible = Visible
        Me.bNext.Visible = Visible
        Me.RecordLabel.Visible = Visible
    End Sub
    Private Sub CheckDataChange()
        If Me._ManageNavigation = True And Me._DbObject IsNot Nothing Then

            If Me._DbObject.DataChanged Then
                Save()
            End If
        End If
    End Sub
    Private Sub Delete()

        'Me._AddNewPending = False
        Dim Cancel As Boolean = False
        RaiseEvent eDeleteRequest(Cancel)

        If Cancel = True Then Return
        If Me.DeleteVisible = False Then Return

        If Me._ManageNavigation = True Then
            If (MessageBox.Show(_DeleteMessage, Me.ParentForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

                If Me._DataGridActive = True And Me._DataGrid IsNot Nothing Then
                    Me.DataGrid_Delete()
                Else
                    Me._DbObject.Delete()
                End If
            End If
        Else
            RaiseEvent eDelete()
        End If


    End Sub
    Private Sub Save()

        Dim Cancel As Boolean = False
        RaiseEvent eSaveRequest(Cancel)
        If Cancel = True Then Return


        If Me.SaveVisible = False Or Me.SaveEnabled = False Then Return

        If Me._ManageNavigation = True Then
            If (MessageBox.Show(_SaveMessage, Me.ParentForm.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                If Me._DataGridActive = True And Me._DataGrid IsNot Nothing Then
                    Me.DataGrid_Update()
                    SetButtonForSave()
                Else
                    Me._DbObject.Update()
                    SetButtonForSave()
                End If
                SetButtonForSave()
                'Me._AddNewPending = False
                RaiseEvent eSave()
            End If
        Else
            SetButtonForSave()
            'Me._AddNewPending = False
            RaiseEvent eSave()
        End If

    End Sub
    Public Sub CheckDataPanel()


        If _DataPanel IsNot Nothing Then
            If _DbObject.RowCount = 0 Then
                _DataPanel.Enabled = False
                Me.DisableNavigation()
                Me.DisableSave()
                Me.DisableDelete()
                Me.DisableUndo()
                Me.DisableRefresh()
            Else
                If _DbObject.AddNewStatus = False Then
                    _DataPanel.Enabled = True
                    Me.EnableNavigation()
                    Me.EnableDelete()
                    Me.EnableUndo()
                    Me.EnableSave()
                    Me.EnableRefresh()
                    Me.EnablePrint()

                Else
                    _DataPanel.Enabled = True
                    Me.DisableNavigation()
                    Me.DisableDelete()
                    Me.EnableUndo()
                    Me.EnableSave()
                    Me.DisableRefresh()
                    Me.DisablePrint()
                    Me.DisableFind()

                End If

            End If
        End If
    End Sub
    Private Sub bFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bFirst.Click
        MoveFirst()
    End Sub

    Private Sub bPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPrev.Click
        MovePrevious()
    End Sub

    Private Sub bNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNext.Click
        MoveNext()
    End Sub

    Private Sub bLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bLast.Click

        MoveLast()

    End Sub

    Private Sub bRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRefresh.Click
        Me.RefreshData()
    End Sub

    Private Sub bNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNew.Click
        AddNew()
    End Sub

    Private Sub bDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bDelete.Click
        Delete()
    End Sub

    Private Sub bUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bUndo.Click
        Undo()
    End Sub

    Private Sub bSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSave.Click
        Save()
    End Sub

    Private Sub bFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bFind.Click

        Dim Cancel As Boolean = False
        RaiseEvent eFindRequest(Cancel)
        If Cancel = True Then Return
        RaiseEvent eFind()

    End Sub


    Private Sub bPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bPrint.Click
        Dim Cancel As Boolean = False
        RaiseEvent ePrintRequest(Cancel)
        If Cancel = True Then Return
        RaiseEvent ePrint()
    End Sub

    Private Sub bClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bClose.Click
        Dim Cancel As Boolean = False
        RaiseEvent eCloseRequest(Cancel)
        If Cancel = True Then Return
        RaiseEvent eClose()
    End Sub

    Public Sub DataGrid_RowChange()

        If Me._DataGridRow <> -1 Then
            If Me._DataGrid.CurrentRow.Index <> Me._DataGridRow Then
                Dim CurrentColumn As Integer = Me._DataGrid.CurrentCell.ColumnIndex
                Dim CurrentRow As Integer = Me._DataGrid.CurrentCell.RowIndex

                Me._DataGrid.CurrentCell = Me._DataGrid.Rows(Me._DataGridRow).Cells(CurrentColumn)

            End If
        End If


    End Sub
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        Me.Panel.Width = Me.NavBar.Width
        Me.Panel.Height = Me.NavBar.Height
        Me.Panel.Dock = DockStyle.Fill
        Me.Width = Me.Panel.Width
        Me.Height = Me.Panel.Height

        'Me.Width = Me.NavBar.Width
        'Me.Height = Me.NavBar.Height

        Me.NavBar.Dock = DockStyle.Fill
        ' Add any initialization after the InitializeComponent() call.
        Me.CompactMode = False

        Me.bLast.Visible = True
        Me.bFirst.Visible = True
        Me.bNew.Visible = True
        Me.bNext.Visible = True
        Me.bPrev.Visible = True
        Me.bSave.Visible = True
        Me.bDelete.Visible = True
        Me.bUndo.Visible = True
        Me.bPrint.Visible = True
        Me.bRefresh.Visible = True
        Me.bFind.Visible = True
        Me.bClose.Visible = True




    End Sub

    Private Sub AddNew()

        Dim Cancel As Boolean = False
        RaiseEvent eAddNewRequest(Cancel)
        If Cancel = True Then Exit Sub

        If Me.AddNewVisible = False Then Return

        If Me._ManageNavigation = True Then
            If Me._DataGridActive = True And Me._DataGrid IsNot Nothing Then
                Me.DataGrid_AddNew()
            Else
                _DbObject.AddNew()
            End If
            'Me._AddNewPending = True
            SetButtonsForAddNew()

        Else
            'Me._AddNewPending = True
            SetButtonsForAddNew()
            RaiseEvent eAddNew()

        End If

    End Sub

    Public Sub UpdateRecordLabel()

        '        If Me.DbObject IsNot Nothing And Me.RecordLabel.Visible = True Then
        If Me._DbObject IsNot Nothing And Me.RecordLabel.Visible = True Then

            Select Case Me.DataGridActive
                Case Is = False
                    'Me.RecordLabel.Lines(0) = Me._DbObject.CurrentPosition + 1
                    'Me.RecordLabel.Lines(1) = Me._DbObject.RowCount

                    Me.RecordLabel.Text = Me._DbObject.CurrentPosition + 1 & "/" & Me._DbObject.RowCount
                Case Is = True
                    Try
                        '   Me.RecordLabel.Lines(0) = Me.DataGrid.CurrentRow.Index + 1
                        '   Me.RecordLabel.Lines(1) = Me._DbObject.RowCount
                        If Me.DataGrid.CurrentRow IsNot Nothing Then
                            Me.RecordLabel.Text = Me.DataGrid.CurrentRow.Index + 1 & "/" & Me.DataGrid.RowCount
                        Else
                            Me.RecordLabel.Text = "0/0"
                        End If

                    Catch ex As Exception
                        'Me.RecordLabel.Lines(0) = 0
                        'Me.RecordLabel.Lines(1) = 0
                        Me.RecordLabel.Text = "0/0"
                    End Try

            End Select
        End If


    End Sub
    Public Sub DataGrid_MoveFirst(Optional ByVal IgnoreManageNavigation As Boolean = False)

        If IgnoreManageNavigation = False And Me._ManageNavigation = True Or Me._DataGrid Is Nothing Then Exit Sub
        If Me._DataGridActive = True And Me._DataGrid IsNot Nothing And Me.DataGrid.CurrentRow IsNot Nothing Then
            Me._DataGrid.CurrentCell = Me._DataGrid.Rows(0).Cells(Me._DataGrid.CurrentCell.ColumnIndex)
        End If
    End Sub
    Private Sub MoveFirstDataGridListView()
        If Me._DataGridListView IsNot Nothing Then
            Me._DataGridListView.CurrentCell = Me._DataGridListView.Rows(0).Cells(Me._DataGridListView.CurrentCell.ColumnIndex)
        End If

    End Sub

    Private Sub MoveFirst()

        Dim Cancel As Boolean = False
        RaiseEvent eMoveFirstRequest(Cancel)
        If Cancel = True Then Return


        If Me._ManageNavigation = True Then
            If Me._DataGridActive = True And Me._DataGrid IsNot Nothing Then
                Me._DataGrid.CurrentCell = Me._DataGrid.Rows(0).Cells(Me._DataGrid.CurrentCell.ColumnIndex)
            Else
                _DbObject.MoveFirst()
                MoveFirstDataGridListView()
            End If
        Else
            MoveFirstDataGridListView()
            RaiseEvent eMoveFirst()
        End If
        Me.UpdateRecordLabel()

    End Sub

    Public Sub DataGrid_MovePrevious(Optional ByVal IgnoreManageNavigation As Boolean = False)

        If IgnoreManageNavigation = False And Me._ManageNavigation = True Or Me._DataGrid Is Nothing Then Exit Sub

        If Me._DataGridActive = True And Me._DataGrid IsNot Nothing And Me.DataGrid.CurrentRow IsNot Nothing Then
            If Me._DataGrid.CurrentRow.Index > 0 Then
                Me._DataGrid.CurrentCell = Me._DataGrid.Rows(Me._DataGrid.CurrentRow.Index - 1).Cells(Me._DataGrid.CurrentCell.ColumnIndex)
            End If
        End If


    End Sub
    Private Sub MovePreviousDataGridListView()
        If Me._DataGridListView IsNot Nothing Then
            If Me._DataGridListView.CurrentRow.Index > 0 Then
                Me._DataGridListView.CurrentCell = Me._DataGridListView.Rows(Me._DataGridListView.CurrentRow.Index - 1).Cells(Me._DataGridListView.CurrentCell.ColumnIndex)
            End If
        End If
    End Sub


    Private Sub MovePrevious()

        Dim Cancel As Boolean = False
        RaiseEvent eMovePreviousRequest(Cancel)
        If Cancel = True Then Return

        If Me._ManageNavigation = True Then
            If Me._DataGridActive = True And Me._DataGrid IsNot Nothing Then
                If Me._DataGrid.CurrentRow.Index > 0 Then
                    Me._DataGrid.CurrentCell = Me._DataGrid.Rows(Me._DataGrid.CurrentRow.Index - 1).Cells(Me._DataGrid.CurrentCell.ColumnIndex)
                End If
            Else
                _DbObject.MovePrevious()
                MovePreviousDataGridListView()
            End If
        Else
            MovePreviousDataGridListView()
            RaiseEvent eMovePrevious()
        End If

        Me.UpdateRecordLabel()
    End Sub

    Public Sub DataGrid_MoveNext(Optional ByVal IgnoreManageNavigation As Boolean = False)

        If IgnoreManageNavigation = False And Me._ManageNavigation = True Or Me._DataGrid Is Nothing Then Exit Sub

        If Me._DataGridActive = True And Me._DataGrid IsNot Nothing And Me._DataGrid.CurrentRow IsNot Nothing Then
            If Me._DataGrid.CurrentRow.Index < Me._DataGrid.Rows.Count - 1 Then
                Me._DataGrid.CurrentCell = Me._DataGrid.Rows(Me._DataGrid.CurrentRow.Index + 1).Cells(Me._DataGrid.CurrentCell.ColumnIndex)
            End If
        End If
    End Sub

    Private Sub MoveNextDataGridListView()
        If Me._DataGridListView IsNot Nothing Then
            If Me._DataGridListView.CurrentRow.Index < Me._DataGridListView.Rows.Count - 1 Then
                Me._DataGridListView.CurrentCell = Me._DataGridListView.Rows(Me._DataGridListView.CurrentRow.Index + 1).Cells(Me._DataGridListView.CurrentCell.ColumnIndex)
            End If
        End If
    End Sub
    Private Sub MoveNext()

        Dim Cancel As Boolean = False
        RaiseEvent eMoveNextRequest(Cancel)
        If Cancel = True Then Return

        If Me._ManageNavigation = True Then
            If Me._DataGridActive = True And Me._DataGrid IsNot Nothing Then
                If Me._DataGrid.CurrentRow.Index < Me._DataGrid.Rows.Count - 1 Then
                    Me._DataGrid.CurrentCell = Me._DataGrid.Rows(Me._DataGrid.CurrentRow.Index + 1).Cells(Me._DataGrid.CurrentCell.ColumnIndex)
                End If
            Else
                _DbObject.MoveNext()
                MoveNextDataGridListView()
            End If
        Else
            MoveNextDataGridListView()
            RaiseEvent eMoveNext()
        End If

        Me.UpdateRecordLabel()


    End Sub

    Public Sub DataGrid_MoveLast(Optional ByVal IgnoreManageNavigation As Boolean = False)

        If IgnoreManageNavigation = False And Me._ManageNavigation = True Or Me._DataGrid Is Nothing Then Exit Sub
        If Me._DataGridActive = True And Me._DataGrid IsNot Nothing And Me.DataGrid.CurrentRow IsNot Nothing Then
            For i As Integer = 0 To Me._DataGrid.Columns.Count - 1
                If Me._DataGrid.Columns(i).ReadOnly = False Then
                    Me._DataGrid.CurrentCell = Me._DataGrid.Rows(Me._DataGrid.RowCount - 1).Cells(Me._DataGrid.CurrentCell.ColumnIndex)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub MoveLastDataGridListView()
        If Me._DataGridListView IsNot Nothing Then
            Me._DataGridListView.CurrentCell = Me._DataGridListView.Rows(Me._DataGridListView.RowCount - 1).Cells(Me._DataGridListView.CurrentCell.ColumnIndex)
        End If
    End Sub
    Private Sub MoveLast()


        Dim Cancel As Boolean = False
        RaiseEvent eMoveLastRequest(Cancel)
        If Cancel = True Then Return

        If Me._ManageNavigation = True Then
            If Me._DataGridActive = True And Me._DataGrid IsNot Nothing Then
                Me._DataGrid.CurrentCell = Me._DataGrid.Rows(Me._DataGrid.RowCount - 1).Cells(Me._DataGrid.CurrentCell.ColumnIndex)
            Else

                _DbObject.MoveLast()
                MoveLastDataGridListView()
            End If
        Else
            MoveLastDataGridListView()
            RaiseEvent eMoveLast()
        End If

        Me.UpdateRecordLabel()

    End Sub


    Private Sub RefreshData()

        Dim Cancel As Boolean = False
        RaiseEvent eRefreshRequest(Cancel)
        If Cancel = True Then Return


        If Me.RefreshVisible = False Or Me.RefreshEnabled = False Then Return

        CheckDataChange()

        Try
            Dim _odb As BasicDAL.DataBoundControlsBehaviour = Me._DbObject.DataBinding
            Dim _oev As Boolean = Me._DbObject.DisableEvents
            Me._DbObject.DataBinding = BasicDAL.DataBoundControlsBehaviour.NoDataBinding
            Me._DbObject.LoadAll()
            Me._DbObject.DataBinding = _odb
            Me._DbObject.DisableEvents = _oev
            Me._DbObject.MoveFirst()

        Catch ex As Exception

        End Try


        If Me._ManageNavigation = True Then
            If Me._DataGridActive = True And Me._DataGrid IsNot Nothing Then

                If Me._DbObject IsNot Nothing Then
                    Try
                        Me._DataGrid.DataSource = Me._DbObject.DataTable
                    Catch ex As Exception

                    End Try

                End If
            End If


        Else
            RaiseEvent eRefresh()
        End If
        Me.UpdateRecordLabel()

    End Sub
    Public Sub Undo()

        Dim Cancel As Boolean = False
        RaiseEvent eUndoRequest(Cancel)
        If Cancel = True Then Return

        Me.SetButtonForUndo()
        Me.UpdateRecordLabel()
        If Me._ManageNavigation = True Then
            If Me._DataGridActive = True And Me._DataGrid IsNot Nothing Then
                Me.DataGrid_Undo()
            Else
                _DbObject.UndoChanges()
            End If
        Else
            RaiseEvent eUndo()
        End If

        'Me._AddNewPending = False

    End Sub

    Public Sub SetButtonsForReadWrite()
        Me.bUndo.Enabled = True
        Me.bSave.Enabled = True
        Me.bNew.Enabled = True
        Me.bDelete.Enabled = True
    End Sub

    Public Sub SetButtonsForReadOnly()
        Me.bUndo.Enabled = False
        Me.bSave.Enabled = False
        Me.bNew.Enabled = False
        Me.bDelete.Enabled = False
    End Sub
    Public Sub SetButtonsForAddNew()

        DisableNavigation()

        Me.bUndo.Enabled = True
        Me.bSave.Enabled = True
        Me.bFind.Enabled = False
        Me.bPrint.Enabled = False
        Me.bRefresh.Enabled = False
        Me.bPrint.Enabled = False
        Me.bNew.Enabled = False
        Me.bClose.Enabled = False
        Me.bDelete.Enabled = False
        'Me._AddNewPending = True
        Select Case Me.DataGridActive
            Case False
            Case True
        End Select

    End Sub

    Public Sub DataGrid_StartEdit(ByVal CurrentRow As Integer)

        Me._DataGridRow = CurrentRow
        Me.SetButtonForEdit()
    End Sub

    Public Sub DataGrid_StartEdit()
        If Me._DataGrid IsNot Nothing Then

            Me.SetButtonForEdit()
        End If

    End Sub

    Public Sub SetButtonForEdit()

        DisableNavigation()

        Me.bFind.Enabled = False
        Me.bPrint.Enabled = False
        Me.bRefresh.Enabled = False
        Me.bPrint.Enabled = False
        Me.bNew.Enabled = False
        Me.bClose.Enabled = False
        Me.bDelete.Enabled = False

        Select Case Me.DataGridActive
            Case False
            Case True
        End Select

    End Sub
    Public Sub SetButtonForSave()


        EnableAllButtons()
        Select Case Me.DataGridActive
            Case False
            Case True
        End Select

    End Sub
    Private Sub SetButtonForUndo()

        EnableAllButtons()

        Select Case Me.DataGridActive
            Case False
            Case True
        End Select

    End Sub

    Sub DisableNavigation()
        Me.bFirst.Enabled = False
        Me.bNext.Enabled = False
        Me.bPrev.Enabled = False
        Me.bLast.Enabled = False
        Me._NavigationEnabled = False
    End Sub
    Sub EnableNavigation()
        Me.bFirst.Enabled = True
        Me.bNext.Enabled = True
        Me.bPrev.Enabled = True
        Me.bLast.Enabled = True
        Me._NavigationEnabled = True
    End Sub

    Sub DisableRefresh()
        Me.bRefresh.Enabled = False

    End Sub
    Sub EnableRefresh()
        Me.bRefresh.Enabled = True
    End Sub
    Sub DisableDelete()
        Me.bDelete.Enabled = False
    End Sub

    Sub DisableNew()
        Me.bNew.Enabled = False
    End Sub

    Sub EnableDelete()
        Me.bDelete.Enabled = True
    End Sub

    Sub DisableSave()
        Me.bSave.Enabled = False
    End Sub
    Sub DisableUndo()
        Me.bUndo.Enabled = False
    End Sub
    Sub EnableUndo()
        Me.bUndo.Enabled = True
    End Sub

    Sub EnableSave()
        Me.bSave.Enabled = True
    End Sub
    Sub DisableFind()
        Me.bFind.Enabled = False
    End Sub
    Sub EnableFind()
        Me.bFind.Enabled = True
    End Sub

    Sub DisablePrint()
        Me.bPrint.Enabled = False
    End Sub
    Sub EnablePrint()
        Me.bPrint.Enabled = True
    End Sub

    Sub EnableAllButtons()

        Me.bFirst.Enabled = True
        Me.bNext.Enabled = True
        Me.bPrev.Enabled = True
        Me.bLast.Enabled = True
        Me.bClose.Enabled = True
        Me.bDelete.Enabled = True
        Me.bNew.Enabled = True

        Me.bRefresh.Enabled = True

        Me.bFind.Enabled = True
        Me.bPrint.Enabled = True

        Me.bSave.Enabled = True
        Me.bUndo.Enabled = True
        Me._NavigationEnabled = True
    End Sub


    'Private Sub _DataGrid_CancelRowEdit(sender As Object, e As System.Windows.Forms.QuestionEventArgs) Handles _DataGrid.E
    '    DataGrid_Undo()
    'End Sub

    Private Sub _mDBObject_DataEventAfter(ByVal EventType As BasicDAL.DataEventType) Handles _DbObject.DataEventAfter

        SetDataNavigator()

        Select Case EventType
            Case BasicDAL.DataEventType.AddNew
                'Me._AddNewPending = True
            Case Is = BasicDAL.DataEventType.Query, BasicDAL.DataEventType.Delete, BasicDAL.DataEventType.DeleteAll, BasicDAL.DataEventType.DeleteFromDataSet, BasicDAL.DataEventType.DeleteFromDataTable
                Me.DataGridListViewInit()
            Case Else
                'Me._AddNewPending = False
        End Select

    End Sub

    Public Sub SetDataNavigator()


        Dim RowExist As Boolean = False


        Select Case Me.DataGridActive
            Case Is = True
                If Me._DataGrid IsNot Nothing Then

                    If Me._DataGrid.RowCount > 0 Then RowExist = True
                Else
                    If Me._DbObject.RowCount > 0 Then RowExist = True
                End If

            Case Else
                If Me.DbObject.RowCount <> 0 Then RowExist = True
        End Select

        Select Case RowExist
            Case Is = False
                Me.bLast.Enabled = False
                Me.bFirst.Enabled = False
                Me.bNext.Enabled = False
                Me.bPrev.Enabled = False
                Select Case Me._ReadOnlyMode
                    Case True
                        Me.bNew.Enabled = False
                    Case Else
                        Me.bNew.Enabled = True
                End Select
                Me.bSave.Enabled = False
                Me.bDelete.Enabled = False
                Me.bUndo.Enabled = False
                Me.bPrint.Enabled = True
                Me.bRefresh.Enabled = True
                Me.bFind.Enabled = True
                Me.bClose.Enabled = True
            Case Is = True
                Me.bLast.Enabled = True
                Me.bFirst.Enabled = True
                Me.bNext.Enabled = True
                Me.bPrev.Enabled = True
                Select Case Me._ReadOnlyMode
                    Case False
                        Me.bNew.Enabled = True
                        Me.bSave.Enabled = True
                        Me.bDelete.Enabled = True
                        Me.bUndo.Enabled = True
                    Case Else
                        Me.bNew.Enabled = False
                        Me.bSave.Enabled = False
                        Me.bDelete.Enabled = False
                        Me.bUndo.Enabled = False
                End Select
                Me.bPrint.Enabled = True
                Me.bRefresh.Enabled = True
                Me.bFind.Enabled = True
                Me.bClose.Enabled = True
        End Select

        If _DbObject.AddNewStatus = True Then
            Me.SetButtonsForAddNew()
        End If
        Me.UpdateRecordLabel()

    End Sub

    Private Sub _DbObject_BoundCompleted() Handles _DbObject.BoundCompleted
        RaiseEvent eBoundCompleted()
    End Sub


    Private Sub _DataGridListView_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles _DataGridListView.RowEnter

        If Me._DataGridListView.Focused Then
            Me._DbObject.MoveTo(CInt(Me._DataGridListView.CurrentRow.Cells(Me._DataGridListViewRowIndexColumnName).Value))
        End If

    End Sub

    Public Sub DataGridListViewInit()

        Dim ncolIndex As Integer

        If Me._DataGridListView Is Nothing Then Return
        Me._DataGridListView.DefaultRowHeight = Me._DataGridListViewDefaultRowHeight

        If Me.ListViewColumns.Count > 0 Then
            Me._DataGridListView.DataSource = Nothing
            Me._DataGridListView.AutoGenerateColumns = False
            Me._DataGridListView.Columns.Clear()
            Me._DataGridListView.Rows.Clear()

            For Each c As ListViewColumn In Me.ListViewColumns

                Dim _Name As String = c.DbColumn.DbColumnNameE
                Dim _FriendlyName As String = c.FriendlyName.Trim
                Dim _DisplayFormat As String = c.DisplayFormat
                If _FriendlyName = "" Then _FriendlyName = c.DbColumn.FriendlyName
                If _FriendlyName = "" Then _FriendlyName = _Name
                If _DisplayFormat.Trim = "" Then _DisplayFormat = c.DbColumn.DisplayFormat


                If c.ColumnType = DataGridListViewColumnType.Undefined Then
                    Select Case c.DbColumn.DbType
                        Case Is = DbType.Boolean
                            Dim ncol As New DataGridViewCheckBoxColumn
                            ncolIndex = Me._DataGridListView.Columns.Add(ncol)
                        Case Else
                            Dim ncol As New DataGridViewTextBoxColumn
                            ncolIndex = Me._DataGridListView.Columns.Add(ncol)
                    End Select
                Else
                    Select Case c.ColumnType
                        Case DataGridListViewColumnType.CheckBox
                            Dim ncol As New DataGridViewCheckBoxColumn
                            ncolIndex = Me._DataGridListView.Columns.Add(ncol)
                        Case DataGridListViewColumnType.Image
                            Dim ncol As New DataGridViewImageColumn
                            ncol.CellImageLayout = DataGridViewImageCellLayout.BestFit
                            ncolIndex = Me._DataGridListView.Columns.Add(ncol)

                        Case DataGridListViewColumnType.Link
                            Dim ncol As New DataGridViewLinkColumn
                            ncolIndex = Me._DataGridListView.Columns.Add(ncol)
                        Case Else
                            Dim ncol As New DataGridViewTextBoxColumn
                            ncolIndex = Me._DataGridListView.Columns.Add(ncol)
                    End Select
                End If

                Me._DataGridListView.Columns(ncolIndex).Name = _Name
                Me._DataGridListView.Columns(ncolIndex).HeaderText = _FriendlyName
                Me._DataGridListView.Columns(ncolIndex).DataPropertyName = _Name
                Me._DataGridListView.Columns(ncolIndex).DefaultCellStyle.Format = _DisplayFormat
                Select Case c.Width
                    Case = 0
                        Me._DataGridListView.Columns(ncolIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    Case Else
                        Me._DataGridListView.Columns(ncolIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                        Me._DataGridListView.Columns(ncolIndex).Width = c.Width
                End Select



            Next
        Else
            Me._DataGridListView.Columns.Clear()
            'Me._DataGridListView.Rows.Clear()
            For Each c As BasicDAL.DbColumn In Me.DbObject.GetDbColumns

                Dim _Name As String = c.DbColumnNameE
                Dim _FriendlyName As String = c.FriendlyName.Trim
                Dim _DisplayFormat As String = c.DisplayFormat
                If _FriendlyName = "" Then _FriendlyName = _Name


                Select Case c.DbType
                    Case Is = DbType.Boolean
                        Dim ncol As New DataGridViewCheckBoxColumn
                        ncolIndex = Me._DataGridListView.Columns.Add(ncol)
                    Case Else
                        Dim ncol As New DataGridViewTextBoxColumn
                        ncolIndex = Me._DataGridListView.Columns.Add(ncol)
                End Select

                Me._DataGridListView.Columns(ncolIndex).Name = _Name
                Me._DataGridListView.Columns(ncolIndex).HeaderText = _FriendlyName
                Me._DataGridListView.Columns(ncolIndex).DataPropertyName = _Name
                Me._DataGridListView.Columns(ncolIndex).DefaultCellStyle.Format = _DisplayFormat

            Next
        End If



        Dim hcol As New DataGridViewTextBoxColumn
        ncolIndex = Me._DataGridListView.Columns.Add(hcol)
        Me._DataGridListViewRowIndexColumnIndex = ncolIndex
        'Me._DataGridListView.Columns(ncolIndex - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me._DataGridListView.Columns(ncolIndex).Name = _DataGridListViewRowIndexColumnName
        Me._DataGridListView.Columns(ncolIndex).DataPropertyName = _DataGridListViewRowIndexColumnName
        Me._DataGridListView.Columns(ncolIndex).Visible = False
        Me._DataGridListView.Columns(ncolIndex).ShowInVisibilityMenu = False
        Me._DataGridListViewDataTable = Me._DbObject.DataTable.Copy
        Me._DataGridListViewDataTable.Columns.Add(_DataGridListViewRowIndexColumnName)

        For i = 0 To Me._DataGridListViewDataTable.Rows.Count - 1
            Me._DataGridListViewDataTable.Rows(i)(_DataGridListViewRowIndexColumnName) = i
        Next i

        Me._DataGridListView.DataSource = Me._DataGridListViewDataTable

    End Sub


End Class
Public Class ListViewColumn
    Private mDBColumn As BasicDAL.DbColumn
    Private mFriendlyName As String
    Private mDisplayFormat As String
    Private mColumnType As DataGridListViewColumnType
    Private mWidth As Integer = 100
    Property Width() As Integer
        Get
            Width = mWidth

        End Get
        Set(ByVal value As Integer)
            mWidth = value
        End Set
    End Property
    Property DisplayFormat() As String
        Get
            DisplayFormat = mDisplayFormat

        End Get
        Set(ByVal value As String)
            mDisplayFormat = value
        End Set
    End Property

    Property FriendlyName() As String
        Get
            FriendlyName = Me.mFriendlyName
        End Get
        Set(ByVal value As String)
            Me.mFriendlyName = value
        End Set
    End Property
    Property DbColumn() As BasicDAL.DbColumn
        Get
            DbColumn = Me.mDBColumn
        End Get
        Set(ByVal value As BasicDAL.DbColumn)
            mDBColumn = value
        End Set
    End Property
    Property ColumnType() As DataGridListViewColumnType
        Get
            ColumnType = Me.mColumnType
        End Get
        Set(ByVal value As DataGridListViewColumnType)
            mColumnType = value
        End Set
    End Property

End Class

Public Enum DataGridListViewColumnType As Integer
    Undefined = 0
    TextBox = 1
    CheckBox = 2
    Image = 3
    Link = 4
End Enum
Public Class ListViewColumns
    Inherits CollectionBase



    Public Sub Add(ByVal DbColumn As BasicDAL.DbColumn, ByVal FriendlyName As String, ByVal DisplayFormat As String, Optional ByVal ColumnType As DataGridListViewColumnType = DataGridListViewColumnType.Undefined, Optional ByVal Width As Integer = 0)
        Dim x As New ListViewColumn

        With x
            .DbColumn = DbColumn
            .FriendlyName = FriendlyName
            .DisplayFormat = DisplayFormat
            .ColumnType = ColumnType
            .Width = Width
        End With

        If Trim(x.FriendlyName) = "" Then x.FriendlyName = x.DbColumn.FriendlyName

        List.Add(x)

    End Sub


    Property Item(ByVal Index As Integer) As ListViewColumn
        Get
            Item = List.Item(Index)
        End Get
        Set(ByVal value As ListViewColumn)
            List.Item(Index) = value
        End Set
    End Property


End Class