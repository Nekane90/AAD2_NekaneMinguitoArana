<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Creditos
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
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbNumRepos = New System.Windows.Forms.Label()
        Me.pcImagen = New System.Windows.Forms.PictureBox()
        CType(Me.pcImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(65, 117)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(48, 16)
        Me.lbNombre.TabIndex = 0
        Me.lbNombre.Text = "Label1"
        '
        'lbNumRepos
        '
        Me.lbNumRepos.AutoSize = True
        Me.lbNumRepos.Location = New System.Drawing.Point(65, 190)
        Me.lbNumRepos.Name = "lbNumRepos"
        Me.lbNumRepos.Size = New System.Drawing.Size(48, 16)
        Me.lbNumRepos.TabIndex = 1
        Me.lbNumRepos.Text = "Label2"
        '
        'pcImagen
        '
        Me.pcImagen.Location = New System.Drawing.Point(303, 83)
        Me.pcImagen.Name = "pcImagen"
        Me.pcImagen.Size = New System.Drawing.Size(135, 143)
        Me.pcImagen.TabIndex = 2
        Me.pcImagen.TabStop = False
        '
        'Creditos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(561, 378)
        Me.Controls.Add(Me.pcImagen)
        Me.Controls.Add(Me.lbNumRepos)
        Me.Controls.Add(Me.lbNombre)
        Me.Name = "Creditos"
        Me.Text = "Creditos"
        CType(Me.pcImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbNombre As Label
    Friend WithEvents lbNumRepos As Label
    Friend WithEvents pcImagen As PictureBox
End Class
