<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class datagrid
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LblListPerpustakaanGrid = New System.Windows.Forms.Label()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.Btnselect = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(1434, 368)
        Me.DataGridView1.TabIndex = 0
        '
        'LblListPerpustakaanGrid
        '
        Me.LblListPerpustakaanGrid.AutoSize = True
        Me.LblListPerpustakaanGrid.Font = New System.Drawing.Font("Segoe UI Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblListPerpustakaanGrid.Location = New System.Drawing.Point(574, 9)
        Me.LblListPerpustakaanGrid.Name = "LblListPerpustakaanGrid"
        Me.LblListPerpustakaanGrid.Size = New System.Drawing.Size(566, 48)
        Me.LblListPerpustakaanGrid.TabIndex = 1
        Me.LblListPerpustakaanGrid.Text = "LIST KOLEKSI PERPUSTAKAAN"
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(1326, 453)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(112, 34)
        Me.BtnRemove.TabIndex = 9
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'Btnselect
        '
        Me.Btnselect.Location = New System.Drawing.Point(1198, 453)
        Me.Btnselect.Name = "Btnselect"
        Me.Btnselect.Size = New System.Drawing.Size(112, 34)
        Me.Btnselect.TabIndex = 10
        Me.Btnselect.Text = "Select"
        Me.Btnselect.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(1068, 453)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(112, 34)
        Me.BtnUpdate.TabIndex = 11
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'datagrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1460, 499)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.Btnselect)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.LblListPerpustakaanGrid)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "datagrid"
        Me.Text = "datagrid"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LblListPerpustakaanGrid As Label
    Friend WithEvents BtnShowDataGrid As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents Btnselect As Button
    Friend WithEvents BtnUpdate As Button
End Class
