Module Globals
    Public cmd As New ADODB.Command
    Public cn As New ADODB.Connection
    Public rs As New ADODB.Recordset

    ' open database connection
    Public Sub openCn()
        Dim iDB As String
        Dim iDr As String
        Dim iOpt As String
        Dim iPort As String
        Dim iSvr As String
        Dim iUser As String
        Dim iPwd As String
        Dim connStr As String

        iDB = "gialexis_db"
        iDr = "{MySQL ODBC 3.51 Driver}"
        iOpt = "3"
        iPort = "3306"
        iSvr = "localhost"
        iUser = "root"
        iPwd = ""
        connStr = "driver=" & iDr & ";server" & iSvr & ";database=" & iDB & _
                    ";UID=" & iUser & ";pwd=" & iPwd & ";PORT=" & iPort & _
                    ";OPTION=" & iOpt & ";STMT=;"

        'if connection is not open, open the connection
        If cn.State = 0 Then
            Try
                cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                cn.ConnectionString = connStr
                cn.Open()
                'MsgBox("connected")
            Catch ex As Exception
                'odbc 3.51 is not installed
                MsgBox("Error: " & vbCrLf & ex.ToString, MsgBoxStyle.Critical, "Error Message")
            End Try
        End If
    End Sub

    'set sql command
    Public Sub setCmd(ByVal query As String)
        cmd = New ADODB.Command
        With cmd
            .ActiveConnection = cn
            .CommandText = query
            .Execute()
        End With
    End Sub

    'set recordset/resultset of sql query
    Public Sub setRs()
        rs = New ADODB.Recordset
        With rs
            .ActiveConnection = cn
            .CursorLocation = ADODB.CursorLocationEnum.adUseClient
            .CursorType = ADODB.CursorTypeEnum.adOpenKeyset
            .LockType = ADODB.LockTypeEnum.adLockOptimistic
            .Open(cmd)
        End With
    End Sub

    'close recordset/resultset
    Public Sub closeRs(ByVal record As ADODB.Recordset)
        If record.State = ADODB.ObjectStateEnum.adStateOpen Then
            record.Close()
        End If
    End Sub

    'displays data in datagridview
    'parameters are datagridview, array of fields in table, table name
    Public Overloads Sub shw(ByRef dgv As DataGridView, ByVal fields() As String, ByVal table As String)
        Dim fieldLength As Integer
        Dim columns As String
        Dim arr As ArrayList

        fieldLength = fields.Length
        columns = String.Join(", ", fields)

        closeRs(rs)
        setCmd("SELECT " & columns & " FROM " & table)
        setRs()

        dgv.Rows.Clear()
        While Not rs.EOF
            arr = New ArrayList
            For i = 0 To fieldLength - 1
                arr.Add(rs.Fields(i).Value)
            Next
            dgv.Rows.Add(arr.ToArray)
            rs.MoveNext()
        End While
    End Sub

    Public Overloads Sub shw(ByRef dgv As DataGridView, ByVal fields() As String, ByVal table As String, ByVal searchColumn As String, ByVal searchKey As String)
        Dim fieldLength As Integer
        Dim columns As String
        Dim arr As ArrayList

        fieldLength = fields.Length
        columns = String.Join(", ", fields)

        closeRs(rs)
        setCmd("SELECT " & columns & " FROM " & table & " WHERE  " & searchColumn & " LIKE '" & searchKey & "%'")
        setRs()

        If rs.RecordCount > 0 Then
            dgv.Rows.Clear()
            While Not rs.EOF
                arr = New ArrayList
                For i = 0 To fieldLength - 1
                    arr.Add(rs.Fields(i).Value)
                Next
                dgv.Rows.Add(arr.ToArray)
                rs.MoveNext()
            End While
        Else
            'shw(dgv, fields, table)
            MessageBox.Show("Employee not found in database.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
        
    End Sub

    Function getLastInsertedId(ByVal query As String) As Integer
        Dim lastInsertedId As Integer
        openCn()
        closeRs(rs)
        setCmd(query)
        setRs()
        lastInsertedId = rs.Fields("id").Value
        cn.Close()

        Return lastInsertedId
    End Function

    Function isEmpty(ByVal txt As TextBox) As Boolean
        If txt.Text.Length = 0 Then
            txt.Focus()
            txt.BackColor = Color.PeachPuff
            MessageBox.Show("Missing information. Please fill up the form completely.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return True
        Else
            txt.BackColor = SystemColors.Window
            Return False
        End If
    End Function

End Module
