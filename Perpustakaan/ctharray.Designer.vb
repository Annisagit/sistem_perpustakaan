<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctharray
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
        Me.ListBoxArray = New System.Windows.Forms.ListBox()
        Me.ListBoxArrayDynamic = New System.Windows.Forms.ListBox()
        Me.ListBoxMulti = New System.Windows.Forms.ListBox()
        Me.ListArrayList = New System.Windows.Forms.ListBox()
        Me.ListHashtable = New System.Windows.Forms.ListBox()
        Me.ListBoxStack = New System.Windows.Forms.ListBox()
        Me.ListBoxQueue = New System.Windows.Forms.ListBox()
        Me.LblDemoArrayMulti = New System.Windows.Forms.Label()
        Me.LblDemoArray = New System.Windows.Forms.Label()
        Me.LblDemoHashTable = New System.Windows.Forms.Label()
        Me.LblDemoQueue = New System.Windows.Forms.Label()
        Me.LblDemoArrayDynamic = New System.Windows.Forms.Label()
        Me.LblDemoArrayList = New System.Windows.Forms.Label()
        Me.LblDemoStack = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBoxArray
        '
        Me.ListBoxArray.FormattingEnabled = True
        Me.ListBoxArray.ItemHeight = 25
        Me.ListBoxArray.Location = New System.Drawing.Point(40, 88)
        Me.ListBoxArray.Name = "ListBoxArray"
        Me.ListBoxArray.Size = New System.Drawing.Size(180, 129)
        Me.ListBoxArray.TabIndex = 0
        '
        'ListBoxArrayDynamic
        '
        Me.ListBoxArrayDynamic.FormattingEnabled = True
        Me.ListBoxArrayDynamic.ItemHeight = 25
        Me.ListBoxArrayDynamic.Location = New System.Drawing.Point(168, 287)
        Me.ListBoxArrayDynamic.Name = "ListBoxArrayDynamic"
        Me.ListBoxArrayDynamic.Size = New System.Drawing.Size(180, 129)
        Me.ListBoxArrayDynamic.TabIndex = 1
        '
        'ListBoxMulti
        '
        Me.ListBoxMulti.FormattingEnabled = True
        Me.ListBoxMulti.ItemHeight = 25
        Me.ListBoxMulti.Location = New System.Drawing.Point(296, 88)
        Me.ListBoxMulti.Name = "ListBoxMulti"
        Me.ListBoxMulti.Size = New System.Drawing.Size(180, 129)
        Me.ListBoxMulti.TabIndex = 2
        '
        'ListArrayList
        '
        Me.ListArrayList.FormattingEnabled = True
        Me.ListArrayList.ItemHeight = 25
        Me.ListArrayList.Location = New System.Drawing.Point(433, 287)
        Me.ListArrayList.Name = "ListArrayList"
        Me.ListArrayList.Size = New System.Drawing.Size(180, 129)
        Me.ListArrayList.TabIndex = 3
        '
        'ListHashtable
        '
        Me.ListHashtable.FormattingEnabled = True
        Me.ListHashtable.ItemHeight = 25
        Me.ListHashtable.Location = New System.Drawing.Point(560, 88)
        Me.ListHashtable.Name = "ListHashtable"
        Me.ListHashtable.Size = New System.Drawing.Size(180, 129)
        Me.ListHashtable.TabIndex = 4
        '
        'ListBoxStack
        '
        Me.ListBoxStack.FormattingEnabled = True
        Me.ListBoxStack.ItemHeight = 25
        Me.ListBoxStack.Location = New System.Drawing.Point(702, 287)
        Me.ListBoxStack.Name = "ListBoxStack"
        Me.ListBoxStack.Size = New System.Drawing.Size(180, 129)
        Me.ListBoxStack.TabIndex = 5
        '
        'ListBoxQueue
        '
        Me.ListBoxQueue.FormattingEnabled = True
        Me.ListBoxQueue.ItemHeight = 25
        Me.ListBoxQueue.Location = New System.Drawing.Point(822, 88)
        Me.ListBoxQueue.Name = "ListBoxQueue"
        Me.ListBoxQueue.Size = New System.Drawing.Size(180, 129)
        Me.ListBoxQueue.TabIndex = 6
        '
        'LblDemoArrayMulti
        '
        Me.LblDemoArrayMulti.Location = New System.Drawing.Point(272, 24)
        Me.LblDemoArrayMulti.Name = "LblDemoArrayMulti"
        Me.LblDemoArrayMulti.Size = New System.Drawing.Size(234, 39)
        Me.LblDemoArrayMulti.TabIndex = 7
        Me.LblDemoArrayMulti.Text = "Demo Array Multidimensi"
        Me.LblDemoArrayMulti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDemoArray
        '
        Me.LblDemoArray.Location = New System.Drawing.Point(12, 24)
        Me.LblDemoArray.Name = "LblDemoArray"
        Me.LblDemoArray.Size = New System.Drawing.Size(234, 39)
        Me.LblDemoArray.TabIndex = 8
        Me.LblDemoArray.Text = "Demo Array "
        Me.LblDemoArray.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDemoHashTable
        '
        Me.LblDemoHashTable.Location = New System.Drawing.Point(531, 24)
        Me.LblDemoHashTable.Name = "LblDemoHashTable"
        Me.LblDemoHashTable.Size = New System.Drawing.Size(234, 39)
        Me.LblDemoHashTable.TabIndex = 9
        Me.LblDemoHashTable.Text = "Demo Hash Table"
        Me.LblDemoHashTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDemoQueue
        '
        Me.LblDemoQueue.Location = New System.Drawing.Point(798, 24)
        Me.LblDemoQueue.Name = "LblDemoQueue"
        Me.LblDemoQueue.Size = New System.Drawing.Size(234, 39)
        Me.LblDemoQueue.TabIndex = 10
        Me.LblDemoQueue.Text = "Demo Queue"
        Me.LblDemoQueue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDemoArrayDynamic
        '
        Me.LblDemoArrayDynamic.Location = New System.Drawing.Point(143, 232)
        Me.LblDemoArrayDynamic.Name = "LblDemoArrayDynamic"
        Me.LblDemoArrayDynamic.Size = New System.Drawing.Size(234, 39)
        Me.LblDemoArrayDynamic.TabIndex = 11
        Me.LblDemoArrayDynamic.Text = "Demo Array Dynamic"
        Me.LblDemoArrayDynamic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDemoArrayList
        '
        Me.LblDemoArrayList.Location = New System.Drawing.Point(409, 232)
        Me.LblDemoArrayList.Name = "LblDemoArrayList"
        Me.LblDemoArrayList.Size = New System.Drawing.Size(234, 39)
        Me.LblDemoArrayList.TabIndex = 12
        Me.LblDemoArrayList.Text = "Demo Array List"
        Me.LblDemoArrayList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDemoStack
        '
        Me.LblDemoStack.Location = New System.Drawing.Point(672, 232)
        Me.LblDemoStack.Name = "LblDemoStack"
        Me.LblDemoStack.Size = New System.Drawing.Size(234, 39)
        Me.LblDemoStack.TabIndex = 13
        Me.LblDemoStack.Text = "Demo Stack"
        Me.LblDemoStack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ctharray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 450)
        Me.Controls.Add(Me.LblDemoStack)
        Me.Controls.Add(Me.LblDemoArrayList)
        Me.Controls.Add(Me.LblDemoArrayDynamic)
        Me.Controls.Add(Me.LblDemoQueue)
        Me.Controls.Add(Me.LblDemoHashTable)
        Me.Controls.Add(Me.LblDemoArray)
        Me.Controls.Add(Me.LblDemoArrayMulti)
        Me.Controls.Add(Me.ListBoxQueue)
        Me.Controls.Add(Me.ListBoxStack)
        Me.Controls.Add(Me.ListHashtable)
        Me.Controls.Add(Me.ListArrayList)
        Me.Controls.Add(Me.ListBoxMulti)
        Me.Controls.Add(Me.ListBoxArrayDynamic)
        Me.Controls.Add(Me.ListBoxArray)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Name = "ctharray"
        Me.Text = "ctharray"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxArray As ListBox
    Friend WithEvents ListBoxArrayDynamic As ListBox
    Friend WithEvents ListBoxMulti As ListBox
    Friend WithEvents ListArrayList As ListBox
    Friend WithEvents ListHashtable As ListBox
    Friend WithEvents ListBoxStack As ListBox
    Friend WithEvents ListBoxQueue As ListBox
    Friend WithEvents LblDemoArrayMulti As Label
    Friend WithEvents LblDemoArray As Label
    Friend WithEvents LblDemoHashTable As Label
    Friend WithEvents LblDemoQueue As Label
    Friend WithEvents LblDemoArrayDynamic As Label
    Friend WithEvents LblDemoArrayList As Label
    Friend WithEvents LblDemoStack As Label
End Class
