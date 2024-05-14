<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class input_date
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.predmet = New System.Windows.Forms.ListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Предмет = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Тип = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Оценка = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'predmet
        '
        Me.predmet.FormattingEnabled = True
        Me.predmet.ItemHeight = 24
        Me.predmet.Location = New System.Drawing.Point(24, 22)
        Me.predmet.Name = "predmet"
        Me.predmet.Size = New System.Drawing.Size(355, 484)
        Me.predmet.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Предмет, Me.Тип, Me.Оценка})
        Me.DataGridView1.Location = New System.Drawing.Point(408, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(764, 484)
        Me.DataGridView1.TabIndex = 1
        '
        'Предмет
        '
        Me.Предмет.HeaderText = "Предмет"
        Me.Предмет.Name = "Предмет"
        '
        'Тип
        '
        Me.Тип.HeaderText = "Тип"
        Me.Тип.Name = "Тип"
        '
        'Оценка
        '
        Me.Оценка.HeaderText = "Оценка/Баллы"
        Me.Оценка.Name = "Оценка"
        '
        'input_date
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1194, 536)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.predmet)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "input_date"
        Me.Text = "Ввод данных"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents predmet As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Предмет As DataGridViewTextBoxColumn
    Friend WithEvents Тип As DataGridViewTextBoxColumn
    Friend WithEvents Оценка As DataGridViewTextBoxColumn
End Class
