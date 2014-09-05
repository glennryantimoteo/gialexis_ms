Public Class Add_Employee_Form

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Employee_Main.Show()
        Me.Hide()
    End Sub

    Private Sub Add_Employee_Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Employee_Main.Show()
        Me.Hide()
    End Sub

    Private Sub Add_Employee_Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblEmpId.Text = getLastInsertedId("SELECT * FROM employee") + 1

        openCn()
        closeRs(rs)
        setCmd("SELECT job_desc FROM designation ORDER BY job_desc")
        setRs()
        While Not rs.EOF
            cmbDesignation.Items.Add(rs.Fields("job_desc").Value.ToString)
            rs.MoveNext()
        End While

        cn.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If isEmpty(txtLastName) Then

        End If

        'Dim lName As String = txtLastName.Text
        'Dim fName As String = txtFirstName.Text
        'Dim mName As String = txtMiddleName.Text
        'Dim address As String = txtAddress.Text
        'Dim remarks As String = txtRemarks.Text
        'Dim age As String = txtAge.Text
        'Dim gender As String
        'Dim contact_number As String = txtContactNumber.Text
        'Dim designation As String = cmbDesignation.SelectedItem.ToString
        'Dim birthday As Date = dtpBirthday.Text
        'Dim dateHired As Date = dtpDateHired.Text
        'Dim emp_id As Integer = lblEmpId.Text



    End Sub



    Private Sub txtAge_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAge.LostFocus

    End Sub
End Class