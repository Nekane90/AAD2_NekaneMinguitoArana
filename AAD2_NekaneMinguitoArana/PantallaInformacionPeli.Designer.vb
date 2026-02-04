<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaInformacionPeli
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
        Me.lbTituloPeli = New System.Windows.Forms.Label()
        Me.lbTituloAñoExtreno = New System.Windows.Forms.Label()
        Me.lbAñoestreno = New System.Windows.Forms.Label()
        Me.lbTituloDuracion = New System.Windows.Forms.Label()
        Me.lbDuracion = New System.Windows.Forms.Label()
        Me.lbTituloPrecio = New System.Windows.Forms.Label()
        Me.lbPrecio = New System.Windows.Forms.Label()
        Me.lbTituloSinopsis = New System.Windows.Forms.Label()
        Me.lbSinopsis = New System.Windows.Forms.Label()
        Me.btVender = New System.Windows.Forms.Button()
        Me.pcImagen = New System.Windows.Forms.PictureBox()
        CType(Me.pcImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbTituloPeli
        '
        Me.lbTituloPeli.AutoSize = True
        Me.lbTituloPeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTituloPeli.Location = New System.Drawing.Point(361, 54)
        Me.lbTituloPeli.Name = "lbTituloPeli"
        Me.lbTituloPeli.Size = New System.Drawing.Size(131, 42)
        Me.lbTituloPeli.TabIndex = 0
        Me.lbTituloPeli.Text = "Label1"
        '
        'lbTituloAñoExtreno
        '
        Me.lbTituloAñoExtreno.AutoSize = True
        Me.lbTituloAñoExtreno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTituloAñoExtreno.Location = New System.Drawing.Point(51, 132)
        Me.lbTituloAñoExtreno.Name = "lbTituloAñoExtreno"
        Me.lbTituloAñoExtreno.Size = New System.Drawing.Size(151, 25)
        Me.lbTituloAñoExtreno.TabIndex = 1
        Me.lbTituloAñoExtreno.Text = "Año de estreno:"
        '
        'lbAñoestreno
        '
        Me.lbAñoestreno.AutoSize = True
        Me.lbAñoestreno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAñoestreno.Location = New System.Drawing.Point(226, 132)
        Me.lbAñoestreno.Name = "lbAñoestreno"
        Me.lbAñoestreno.Size = New System.Drawing.Size(64, 25)
        Me.lbAñoestreno.TabIndex = 2
        Me.lbAñoestreno.Text = "label1"
        '
        'lbTituloDuracion
        '
        Me.lbTituloDuracion.AutoSize = True
        Me.lbTituloDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTituloDuracion.Location = New System.Drawing.Point(51, 204)
        Me.lbTituloDuracion.Name = "lbTituloDuracion"
        Me.lbTituloDuracion.Size = New System.Drawing.Size(96, 25)
        Me.lbTituloDuracion.TabIndex = 3
        Me.lbTituloDuracion.Text = "Duracion:"
        '
        'lbDuracion
        '
        Me.lbDuracion.AutoSize = True
        Me.lbDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDuracion.Location = New System.Drawing.Point(226, 204)
        Me.lbDuracion.Name = "lbDuracion"
        Me.lbDuracion.Size = New System.Drawing.Size(64, 25)
        Me.lbDuracion.TabIndex = 4
        Me.lbDuracion.Text = "label1"
        '
        'lbTituloPrecio
        '
        Me.lbTituloPrecio.AutoSize = True
        Me.lbTituloPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTituloPrecio.Location = New System.Drawing.Point(448, 204)
        Me.lbTituloPrecio.Name = "lbTituloPrecio"
        Me.lbTituloPrecio.Size = New System.Drawing.Size(191, 25)
        Me.lbTituloPrecio.TabIndex = 5
        Me.lbTituloPrecio.Text = "Precio de la entrada:"
        '
        'lbPrecio
        '
        Me.lbPrecio.AutoSize = True
        Me.lbPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPrecio.Location = New System.Drawing.Point(676, 204)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(64, 25)
        Me.lbPrecio.TabIndex = 6
        Me.lbPrecio.Text = "label1"
        '
        'lbTituloSinopsis
        '
        Me.lbTituloSinopsis.AutoSize = True
        Me.lbTituloSinopsis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTituloSinopsis.Location = New System.Drawing.Point(54, 271)
        Me.lbTituloSinopsis.Name = "lbTituloSinopsis"
        Me.lbTituloSinopsis.Size = New System.Drawing.Size(93, 25)
        Me.lbTituloSinopsis.TabIndex = 7
        Me.lbTituloSinopsis.Text = "Sinopsis:"
        '
        'lbSinopsis
        '
        Me.lbSinopsis.AutoSize = True
        Me.lbSinopsis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSinopsis.Location = New System.Drawing.Point(229, 271)
        Me.lbSinopsis.Name = "lbSinopsis"
        Me.lbSinopsis.Size = New System.Drawing.Size(64, 25)
        Me.lbSinopsis.TabIndex = 8
        Me.lbSinopsis.Text = "label1"
        '
        'btVender
        '
        Me.btVender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btVender.Location = New System.Drawing.Point(681, 441)
        Me.btVender.Name = "btVender"
        Me.btVender.Size = New System.Drawing.Size(201, 65)
        Me.btVender.TabIndex = 9
        Me.btVender.Text = "VENDER ENTRADAS"
        Me.btVender.UseVisualStyleBackColor = True
        '
        'pcImagen
        '
        Me.pcImagen.Location = New System.Drawing.Point(725, 18)
        Me.pcImagen.Name = "pcImagen"
        Me.pcImagen.Size = New System.Drawing.Size(202, 139)
        Me.pcImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcImagen.TabIndex = 10
        Me.pcImagen.TabStop = False
        '
        'PantallaInformacionPeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(995, 533)
        Me.Controls.Add(Me.pcImagen)
        Me.Controls.Add(Me.btVender)
        Me.Controls.Add(Me.lbSinopsis)
        Me.Controls.Add(Me.lbTituloSinopsis)
        Me.Controls.Add(Me.lbPrecio)
        Me.Controls.Add(Me.lbTituloPrecio)
        Me.Controls.Add(Me.lbDuracion)
        Me.Controls.Add(Me.lbTituloDuracion)
        Me.Controls.Add(Me.lbAñoestreno)
        Me.Controls.Add(Me.lbTituloAñoExtreno)
        Me.Controls.Add(Me.lbTituloPeli)
        Me.Name = "PantallaInformacionPeli"
        Me.Text = "PantallaInformacionPeli"
        CType(Me.pcImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTituloPeli As Label
    Friend WithEvents lbTituloAñoExtreno As Label
    Friend WithEvents lbAñoestreno As Label
    Friend WithEvents lbTituloDuracion As Label
    Friend WithEvents lbDuracion As Label
    Friend WithEvents lbTituloPrecio As Label
    Friend WithEvents lbPrecio As Label
    Friend WithEvents lbTituloSinopsis As Label
    Friend WithEvents lbSinopsis As Label
    Friend WithEvents btVender As Button
    Friend WithEvents pcImagen As PictureBox
End Class
