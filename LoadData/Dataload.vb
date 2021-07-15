Imports System.Data.SQLite
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class Dataload

    ' Dim conn As New SQLiteConnection("Data Source =./Rtg.bin")
    'Dim tablename As String = ""

    Public Sub SQLiteLoad(ByVal tablename As String, ByVal conn As SQLiteConnection, ByVal datagrid As DataGridView)
        Dim cmd As New SQLiteCommand("SELECT * FROM `" & tablename & "`", conn)
        Dim adapter As New SQLiteDataAdapter(cmd)
        Dim dset As New DataSet
        adapter.Fill(dset)
        datagrid.DataSource = dset.Tables(0)
    End Sub

    Public Sub MySqlLoad(ByVal tablename As String, ByVal conn As MySqlConnection, ByVal datagrid As DataGridView)


        [Dim cmd As New MySqlCommand("SELECT * FROM `" & tablename & "`", conn)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim dset As New DataSet
        adapter.Fill(dset)
        datagrid.DataSource = dset.Tables(0)
    End Sub
End Class