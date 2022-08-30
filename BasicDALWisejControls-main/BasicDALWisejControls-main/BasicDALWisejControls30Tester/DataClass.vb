Imports System.Data


Public Class TestTable

    Inherits BasicDAL.DbObject

    Public DBInt As New BasicDAL.DbColumn("DBInt", DbType.Int32, True, 0)
    Public DBString As New BasicDAL.DbColumn("DBString", DbType.String, False, "")
    Public DBDate As New BasicDAL.DbColumn("DBDate", DbType.DateTime, False, Nothing)
    Public DBBit As New BasicDAL.DbColumn("DBBit", DbType.Boolean, False, False)
    Public DBFloat As New BasicDAL.DbColumn("DBFloat", DbType.Double, False, 0)
    'Public ParamX As New BasicDAL.DbParameter("CICCIO", DbType.Int32, ParameterDirection.Input)

    Public Sub New()
        'MyClass.DbObjectType = BasicDAL.DbObjectTypeEnum.SQLQuery
        'MyClass.SQLQuery = "SELECT * FROM TestTable order by DBInt"

        '        ParamX.Value = "ciao"

        MyClass.DbTableName = "TestTable"
        MyClass.InterfaceMode = BasicDAL.InterfaceModeEnum.Public

    End Sub

End Class
<Serializable>
Public Class TestTableSQL

    Inherits BasicDAL.DbObject

    Public DBInt As New BasicDAL.DbColumn("DBInt", DbType.Int32, True, 0)
    Public DBString As New BasicDAL.DbColumn("DBString", DbType.String, False, "")
    Public DBDate As New BasicDAL.DbColumn("DBDate", DbType.DateTime, False, Nothing)
    Public DBBit As New BasicDAL.DbColumn("DBBit", DbType.Boolean, False, False)
    Public DBFloat As New BasicDAL.DbColumn("DBFloat", DbType.Double, False, 0)


    'Public DBString1 As New BasicDAL.DbColumn("[DBString1]", DbType.String, False, "")
    'Public DBString2 As New BasicDAL.DbColumn("[DBString2]", DbType.String, False, "")
    'Public DBString3 As New BasicDAL.DbColumn("[DBString3]", DbType.String, False, "")
    'Public DBString4 As New BasicDAL.DbColumn("[DBString4]", DbType.String, False, "")
    'Public DBString5 As New BasicDAL.DbColumn("[DBString5]", DbType.String, False, "")
    'Public DBString6 As New BasicDAL.DbColumn("[DBString6]", DbType.String, False, "")
    'Public DBString7 As New BasicDAL.DbColumn("[DBString7]", DbType.String, False, "")
    'Public DBString8 As New BasicDAL.DbColumn("[DBString8]", DbType.String, False, "")
    'Public DBString9 As New BasicDAL.DbColumn("[DBString9]", DbType.String, False, "")
    'Public DBString10 As New BasicDAL.DbColumn("[DBString10]", DbType.String, False, "")
    'Public DBString11 As New BasicDAL.DbColumn("[DBString11]", DbType.String, False, "")
    'Public DBString12 As New BasicDAL.DbColumn("[DBString12]", DbType.String, False, "")
    'Public DBString13 As New BasicDAL.DbColumn("[DBString13]", DbType.String, False, "")
    'Public DBString14 As New BasicDAL.DbColumn("[DBString14]", DbType.String, False, "")
    'Public DBString15 As New BasicDAL.DbColumn("[DBString15]", DbType.String, False, "")
    'Public DBString16 As New BasicDAL.DbColumn("[DBString16]", DbType.String, False, "")
    'Public DBString17 As New BasicDAL.DbColumn("[DBString17]", DbType.String, False, "")
    'Public DBString18 As New BasicDAL.DbColumn("[DBString18]", DbType.String, False, "")
    'Public DBString19 As New BasicDAL.DbColumn("[DBString19]", DbType.String, False, "")
    'Public DBString20 As New BasicDAL.DbColumn("[DBString20]", DbType.String, False, "")
    'Public DBString21 As New BasicDAL.DbColumn("[DBString21]", DbType.String, False, "")
    'Public DBString22 As New BasicDAL.DbColumn("[DBString22]", DbType.String, False, "")
    'Public DBString23 As New BasicDAL.DbColumn("[DBString23]", DbType.String, False, "")
    'Public DBString24 As New BasicDAL.DbColumn("[DBString24]", DbType.String, False, "")
    'Public DBString25 As New BasicDAL.DbColumn("[DBString25]", DbType.String, False, "")
    'Public DBString26 As New BasicDAL.DbColumn("[DBString26]", DbType.String, False, "")
    'Public DBString27 As New BasicDAL.DbColumn("[DBString27]", DbType.String, False, "")
    'Public DBString28 As New BasicDAL.DbColumn("[DBString28]", DbType.String, False, "")
    'Public DBString29 As New BasicDAL.DbColumn("[DBString29]", DbType.String, False, "")
    'Public DBString30 As New BasicDAL.DbColumn("[DBString30]", DbType.String, False, "")


    Public Sub New()
        '        MyClass.DbObjectType = BasicDAL.DbObjectTypeEnum.SQLQuery
        ' MyClass.SQLQuery = "SELECT * FROM TestTable WHERE DBINT>1"
        MyClass.DbObjectType = BasicDAL.DbObjectTypeEnum.Table
        MyClass.DbTableName = "TestTable"



        'MyClass.InterfaceMode = BasicDAL.InterfaceModeEnum.Public

    End Sub

End Class