Public Class Employee_Main

    Private Sub Employee_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbSearchBy.SelectedIndex = 0
        openCn()

        Dim fields() As String = {"id", "last_name", "first_name", "contact_number"}
        shw(dgvEmpRecord, fields, "employee")
        cn.Close()

    End Sub


    Private Sub txtSearchKey_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchKey.GotFocus
        If txtSearchKey.Text = "Search" Then
            txtSearchKey.Clear()
            txtSearchKey.Font = New Font(Font.FontFamily, 11, FontStyle.Regular)
            txtSearchKey.ForeColor = Color.Black
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim fields() As String = {"id", "last_name", "first_name", "contact_number"}
        Dim searchColumn As String

        Select Case cmbSearchBy.SelectedIndex
            Case 0
                searchColumn = "id"
            Case 1
                searchColumn = "last_name"
            Case 2
                searchColumn = "first_name"
        End Select

        openCn()
        If txtSearchKey.Text = "" Or txtSearchKey.Text = "Search" Then
            shw(dgvEmpRecord, fields, "employee")
        Else
            shw(dgvEmpRecord, fields, "employee", searchColumn, txtSearchKey.Text)
        End If



        cn.Close()

        txtSearchKey.Font = New Font(Font.FontFamily, 11, FontStyle.Italic)
        txtSearchKey.ForeColor = Color.DarkGray
        txtSearchKey.Text = "Search"
    End Sub

    Private Sub txtSearchKey_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchKey.LostFocus
        If txtSearchKey.Text = "" Then
            txtSearchKey.Font = New Font(Font.FontFamily, 11, FontStyle.Italic)
            txtSearchKey.ForeColor = Color.DarkGray
            txtSearchKey.Text = "Search"
        End If
    End Sub

    Private Sub btnAddEmp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEmp.Click
        Add_Employee_Form.Show()
        Me.Hide()
    End Sub
End Class
