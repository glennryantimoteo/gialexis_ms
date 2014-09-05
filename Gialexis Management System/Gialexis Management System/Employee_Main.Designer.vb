<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbSearchBy = New System.Windows.Forms.ComboBox
        Me.txtSearchKey = New System.Windows.Forms.TextBox
        Me.dgvEmpRecord = New System.Windows.Forms.DataGridView
        Me.emp_id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.last_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.first_name = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.contact_num = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnEditEmp = New System.Windows.Forms.Button
        Me.btnAddEmp = New System.Windows.Forms.Button
        CType(Me.dgvEmpRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(253, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Search by:"
        '
        'cmbSearchBy
        '
        Me.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchBy.FormattingEnabled = True
        Me.cmbSearchBy.Items.AddRange(New Object() {"Employee ID", "Last Name", "First Name"})
        Me.cmbSearchBy.Location = New System.Drawing.Point(339, 20)
        Me.cmbSearchBy.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSearchBy.Name = "cmbSearchBy"
        Me.cmbSearchBy.Size = New System.Drawing.Size(166, 26)
        Me.cmbSearchBy.TabIndex = 4
        '
        'txtSearchKey
        '
        Me.txtSearchKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchKey.ForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchKey.Location = New System.Drawing.Point(553, 20)
        Me.txtSearchKey.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchKey.Name = "txtSearchKey"
        Me.txtSearchKey.Size = New System.Drawing.Size(215, 24)
        Me.txtSearchKey.TabIndex = 5
        Me.txtSearchKey.Text = "Search"
        '
        'dgvEmpRecord
        '
        Me.dgvEmpRecord.AllowUserToAddRows = False
        Me.dgvEmpRecord.AllowUserToResizeColumns = False
        Me.dgvEmpRecord.AllowUserToResizeRows = False
        Me.dgvEmpRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.emp_id, Me.last_name, Me.first_name, Me.contact_num})
        Me.dgvEmpRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvEmpRecord.Location = New System.Drawing.Point(256, 53)
        Me.dgvEmpRecord.MultiSelect = False
        Me.dgvEmpRecord.Name = "dgvEmpRecord"
        Me.dgvEmpRecord.RowHeadersVisible = False
        Me.dgvEmpRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpRecord.Size = New System.Drawing.Size(620, 239)
        Me.dgvEmpRecord.TabIndex = 7
        '
        'emp_id
        '
        Me.emp_id.HeaderText = "Employee ID"
        Me.emp_id.Name = "emp_id"
        Me.emp_id.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.emp_id.Width = 115
        '
        'last_name
        '
        Me.last_name.HeaderText = "Last Name"
        Me.last_name.Name = "last_name"
        Me.last_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.last_name.Width = 170
        '
        'first_name
        '
        Me.first_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.first_name.HeaderText = "First Name"
        Me.first_name.Name = "first_name"
        Me.first_name.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'contact_num
        '
        Me.contact_num.HeaderText = "Contact Number"
        Me.contact_num.Name = "contact_num"
        Me.contact_num.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.contact_num.Width = 140
        '
        'btnSearch
        '
        Me.btnSearch.Image = Global.Gialexis_Management_System.My.Resources.Resources.Search_icon
        Me.btnSearch.Location = New System.Drawing.Point(776, 19)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(44, 26)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Gialexis_Management_System.My.Resources.Resources.view_emp
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(17, 186)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 62)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "            View Employee Record"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnEditEmp
        '
        Me.btnEditEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditEmp.Image = Global.Gialexis_Management_System.My.Resources.Resources.edit_emp
        Me.btnEditEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditEmp.Location = New System.Drawing.Point(17, 105)
        Me.btnEditEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditEmp.Name = "btnEditEmp"
        Me.btnEditEmp.Size = New System.Drawing.Size(219, 62)
        Me.btnEditEmp.TabIndex = 1
        Me.btnEditEmp.Text = "            Edit Employee Record"
        Me.btnEditEmp.UseVisualStyleBackColor = True
        '
        'btnAddEmp
        '
        Me.btnAddEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmp.Image = Global.Gialexis_Management_System.My.Resources.Resources.add_emp
        Me.btnAddEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddEmp.Location = New System.Drawing.Point(17, 24)
        Me.btnAddEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(219, 62)
        Me.btnAddEmp.TabIndex = 0
        Me.btnAddEmp.Text = "            Add Employee Record"
        Me.btnAddEmp.UseVisualStyleBackColor = True
        '
        'Employee_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 485)
        Me.Controls.Add(Me.dgvEmpRecord)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearchKey)
        Me.Controls.Add(Me.cmbSearchBy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEditEmp)
        Me.Controls.Add(Me.btnAddEmp)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Employee_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Employee Main"
        CType(Me.dgvEmpRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents btnAddEmp As System.Windows.Forms.Button
    Friend WithEvents btnEditEmp As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearchKey As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents dgvEmpRecord As System.Windows.Forms.DataGridView
    Friend WithEvents emp_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents last_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents first_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contact_num As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
