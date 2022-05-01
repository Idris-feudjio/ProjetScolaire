Imports MySql.Data.MySqlClient


Module AbstractDtoModule

    'Public connection As New MySqlConnection()
    Public cmd As New MySqlCommand
    Public myslDataReader As MySqlDataReader
    Public connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=handle_student")
    Public Sub connecttodb()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            'MessageBox.Show("connect successfull")
        Catch ex As Exception
            MessageBox.Show("Failed", ex.Message)
        End Try

    End Sub

    Public Sub runsql(ByRef sql As String)
        connecttodb()
        Try
            cmd.Connection = connection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            connection.Close()
            'MsgBox("data has been update")
        Catch ex As Exception
            MsgBox("failed when update data!")
        End Try
    End Sub

    Public Sub loaddatatomysql(ByRef datagrid As DataGridView, ByVal selectquery As String)
        connecttodb() 'open connection db
        Dim mysqldatadapter As MySqlDataAdapter
        Dim dt As DataTable
        mysqldatadapter = New MySqlDataAdapter(selectquery, connection)

        dt = New DataTable
        mysqldatadapter.Fill(dt)
        datagrid.DataSource = dt
        connection.Close()
        mysqldatadapter.Dispose()

    End Sub

    Public Sub deletedata(ByRef datagrid As DataGridView, ByVal tablename As String, ByVal selectquery As String)
        Dim row As Integer
        Dim id As Integer
        Dim message As String
        Dim deletequery As String

        row = datagrid.CurrentRow.Index
        id = datagrid(0, row).Value
        message = MsgBox("are you sure to delete this data ?", vbYesNo + vbInformation, "warning")
        If message = vbNo Then
            Exit Sub
        End If

        deletequery = "delete from '" & tablename & "' id = '" & id & "' "  'query to delete element to table

        runsql(deletequery) ' call functtion to update data

        loaddatatomysql(datagrid, selectquery)  'fill new data into gridview 
    End Sub

    Public Sub inserttodata(ByVal datagrid As DataGridView, ByVal insertquery As String, selectquery As String)
        Dim message As String
        message = MsgBox("are you sure to insert this data ?", vbYesNo + vbInformation, "information")
        If message = vbNo Then
            Exit Sub
        End If
        runsql(insertquery)
        ' loaddatatomysql(datagrid, selectquery)

        ' a revoir cette fonctionnalite
        'with form
        '    datagrid.refresh()
        '    loaddatatomysql(datagrid, selectquery)
        'end with

    End Sub

    Public Sub updatedb(ByVal datagrid As DataGridView, ByVal updatequery As String, ByVal selectquery As String)

    End Sub
End Module
