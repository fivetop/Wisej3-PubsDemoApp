Imports System
Imports System.Data
Imports Wisej.Web

Public Class Window1
    Dim ConnectionString As String
    Dim DB_TestTable As New TestTable
    Dim qDB_TestTable As New TestTable
    Dim DS As DataSet
    Dim DBConfig As New BasicDAL.DbConfig

    Private Sub Window1_Load(sender As Object, e As EventArgs) Handles Me.Load
        DBConfig.AuthenticationMode = 0
        DBConfig.DataBaseName = "TestDB"
        DBConfig.ServerName = "(local)"
        DBConfig.Provider = BasicDAL.Providers.SqlServer
        DBConfig.AuthenticationMode = 1


        Me.DB_TestTable.DataBinding = BasicDAL.DataBoundControlsBehaviour.BasicDALDataBinding

        With Me.DB_TestTable
            .DBInt.BoundControls.Add(Me.DBInt, "text")
            .DBString.BoundControls.Add(Me.DBString, "text") ', BasicDAL.BindingBehaviour.ReadWrite)
            .DBDate.BoundControls.Add(Me.DbDate, "text") ', BasicDAL.BindingBehaviour.ReadWrite)
            .DBFloat.BoundControls.Add(Me.DBFloat, "text") ', BasicDAL.BindingBehaviour.ReadWrite)
            .InitBoundControls()
        End With

        Me.DB_TestTable.Init(DBConfig, BasicDAL.Providers.SqlServer)

        Me.DataNavigator.ManageNavigation = False

        Me.DataNavigator.DbObject = Me.DB_TestTable

        Me.DB_TestTable.DistinctClause = False
        Me.DB_TestTable.UseDataReader = False


        Me.Repeater_DBInt.DataBindings.Add("Text", Me.DB_TestTable.DataTable, "DBInt")
        Me.Repeater_DBString.DataBindings.Add("Text", Me.DB_TestTable.DataTable, "DBString")
        Me.Repeater_DBFloat.DataBindings.Add("Text", Me.DB_TestTable.DataTable, "DBFloat")

    End Sub

    Private Sub DataNavigator_eMoveFirst() Handles DataNavigator.eMoveFirst
        DataNavigator.DbObject.MoveFirst()
    End Sub

    Private Sub DataNavigator_eMoveLast() Handles DataNavigator.eMoveLast
        DataNavigator.DbObject.MoveLast()
    End Sub

    Private Sub DataNavigator_eMoveNext() Handles DataNavigator.eMoveNext
        DataNavigator.DbObject.MoveNext()
    End Sub

    Private Sub DataNavigator_eMovePrevious() Handles DataNavigator.eMovePrevious
        DataNavigator.DbObject.MovePrevious()
    End Sub
    Private Sub DataNavigator_eAddNew() Handles DataNavigator.eAddNew
        DataNavigator.DbObject.AddNew()
    End Sub

    Private Sub DataNavigator_eClose() Handles DataNavigator.eClose
        Me.Close()
    End Sub

    Private Sub DataNavigator_eDelete() Handles DataNavigator.eDelete
        DataNavigator.DbObject.Delete()
    End Sub


    Private Sub DataNavigator_eFind() Handles DataNavigator.eFind

        'QBEForm_DbObject()

        Dim QBEDbObject As TestTable = New TestTable()
        Dim QBEForm As New BasicDALWisejControls.QBEForm

        QBEDbObject.Init(Me.DBConfig)
        QBEForm.Mode = BasicDALWisejControls.QbeMode.Query
        QBEForm.ResultMode = BasicDALWisejControls.QBEResultMode.SelectedRows ' torna tutte le righe selezionate
        QBEForm.CallerForm = Me
        QBEForm.Text = "Ricerca " + Me.Text

        QBEForm.DbObject = QBEDbObject
        QBEForm.QueryDbObject = Me.DB_TestTable
        QBEForm.AutoLoadAll = True
        QBEForm.UseExactSearchForString = False
        QBEForm.DbColumnsMapping.Add(QBEDbObject.DBInt, Me.DB_TestTable.DBInt)
        QBEForm.ShowQBE(Me)

    End Sub

    Private Sub DataNavigator_eRefresh() Handles DataNavigator.eRefresh
        DataNavigator.DbObject.LoadAll()
        DataNavigator.DbObject.MoveFirst()
        Me.DataRepeater1.DataSource = Me.DB_TestTable.DataTable

    End Sub

    Private Sub DataNavigator_eSave() Handles DataNavigator.eSave
        DataNavigator.DbObject.Update()
    End Sub

    Private Sub DataNavigator_eUndo() Handles DataNavigator.eUndo
        DataNavigator.DbObject.UndoChanges()
    End Sub

End Class
