Imports System
Imports Wisej.Web

Public Class QBEFormSaveUserColumnSet
    Public QBEUserColumnsSet As QBEUserColumnsSet = Nothing
    Public StorePath As String = Application.CommonAppDataPath
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click

        If Me.QBEUserColumnsSet Is Nothing Then
            Return
        End If

        Dim xml As String = ""
        Dim FileName As String = ""

        BasicDAL.Utilities.SerializeObjectToFile(FileName, Me.QBEUserColumnsSet)
    End Sub
End Class
