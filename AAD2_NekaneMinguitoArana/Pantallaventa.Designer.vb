<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pantallaventa
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbEligeEntradas = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btComprar = New System.Windows.Forms.Button()
        Me.lbTituloPeli = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbEligeEntradas
        '
        Me.lbEligeEntradas.AutoSize = True
        Me.lbEligeEntradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEligeEntradas.Location = New System.Drawing.Point(161, 144)
        Me.lbEligeEntradas.Name = "lbEligeEntradas"
        Me.lbEligeEntradas.Size = New System.Drawing.Size(322, 29)
        Me.lbEligeEntradas.TabIndex = 0
        Me.lbEligeEntradas.Text = "Elige el número de entradas:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(244, 220)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(130, 27)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btComprar
        '
        Me.btComprar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btComprar.Location = New System.Drawing.Point(234, 332)
        Me.btComprar.Name = "btComprar"
        Me.btComprar.Size = New System.Drawing.Size(152, 53)
        Me.btComprar.TabIndex = 2
        Me.btComprar.Text = "COMPRAR"
        Me.btComprar.UseVisualStyleBackColor = True
        '
        'lbTituloPeli
        '
        Me.lbTituloPeli.AutoSize = True
        Me.lbTituloPeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTituloPeli.Location = New System.Drawing.Point(206, 50)
        Me.lbTituloPeli.Name = "lbTituloPeli"
        Me.lbTituloPeli.Size = New System.Drawing.Size(101, 32)
        Me.lbTituloPeli.TabIndex = 3
        Me.lbTituloPeli.Text = "Label1"
        '
        'Pantallaventa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(659, 454)
        Me.Controls.Add(Me.lbTituloPeli)
        Me.Controls.Add(Me.btComprar)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.lbEligeEntradas)
        Me.Name = "Pantallaventa"
        Me.Text = "Pantallaventa"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbEligeEntradas As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents btComprar As Button
    Friend WithEvents lbTituloPeli As Label
End Class
