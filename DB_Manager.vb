Imports System.Data
Imports System.Data.OleDb

Module DB_Manager
    Public dbconnection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Shared\rnr-db.accdb;Persist Security Info=False")
    Public dbcommand As OleDbCommand
End Module
