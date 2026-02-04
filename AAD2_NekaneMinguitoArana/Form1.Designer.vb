<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LbCine = New System.Windows.Forms.Label()
        Me.pcTitanic = New System.Windows.Forms.PictureBox()
        Me.pcLaAsistenta = New System.Windows.Forms.PictureBox()
        Me.pcAida = New System.Windows.Forms.PictureBox()
        Me.pcJurassic = New System.Windows.Forms.PictureBox()
        Me.pcAvatar = New System.Windows.Forms.PictureBox()
        Me.LbAvatar = New System.Windows.Forms.Label()
        Me.lbSala1 = New System.Windows.Forms.Label()
        Me.lbJurassicPark = New System.Windows.Forms.Label()
        Me.lbSala2 = New System.Windows.Forms.Label()
        Me.lbAida = New System.Windows.Forms.Label()
        Me.lbSala3 = New System.Windows.Forms.Label()
        Me.lbLaAsistenta = New System.Windows.Forms.Label()
        Me.lbSala4 = New System.Windows.Forms.Label()
        Me.lbTitanic = New System.Windows.Forms.Label()
        Me.lbSala5 = New System.Windows.Forms.Label()
        Me.btCreditos = New System.Windows.Forms.Button()
        CType(Me.pcTitanic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcLaAsistenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcAida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcJurassic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbCine
        '
        Me.LbCine.AutoSize = True
        Me.LbCine.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCine.Location = New System.Drawing.Point(415, 36)
        Me.LbCine.Name = "LbCine"
        Me.LbCine.Size = New System.Drawing.Size(95, 38)
        Me.LbCine.TabIndex = 5
        Me.LbCine.Text = "CINE"
        '
        'pcTitanic
        '
        Me.pcTitanic.Image = Global.AAD2_NekaneMinguitoArana.My.Resources.Resources.titanic
        Me.pcTitanic.Location = New System.Drawing.Point(580, 451)
        Me.pcTitanic.Name = "pcTitanic"
        Me.pcTitanic.Size = New System.Drawing.Size(174, 162)
        Me.pcTitanic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcTitanic.TabIndex = 4
        Me.pcTitanic.TabStop = False
        Me.pcTitanic.Tag = "4"
        '
        'pcLaAsistenta
        '
        Me.pcLaAsistenta.Image = Global.AAD2_NekaneMinguitoArana.My.Resources.Resources.laAsistenta
        Me.pcLaAsistenta.Location = New System.Drawing.Point(206, 451)
        Me.pcLaAsistenta.Name = "pcLaAsistenta"
        Me.pcLaAsistenta.Size = New System.Drawing.Size(191, 162)
        Me.pcLaAsistenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcLaAsistenta.TabIndex = 3
        Me.pcLaAsistenta.TabStop = False
        Me.pcLaAsistenta.Tag = "3"
        '
        'pcAida
        '
        Me.pcAida.Image = Global.AAD2_NekaneMinguitoArana.My.Resources.Resources.aida
        Me.pcAida.Location = New System.Drawing.Point(701, 170)
        Me.pcAida.Name = "pcAida"
        Me.pcAida.Size = New System.Drawing.Size(213, 172)
        Me.pcAida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcAida.TabIndex = 2
        Me.pcAida.TabStop = False
        Me.pcAida.Tag = "1"
        '
        'pcJurassic
        '
        Me.pcJurassic.Image = Global.AAD2_NekaneMinguitoArana.My.Resources.Resources.jurassicpark
        Me.pcJurassic.Location = New System.Drawing.Point(398, 170)
        Me.pcJurassic.Name = "pcJurassic"
        Me.pcJurassic.Size = New System.Drawing.Size(213, 172)
        Me.pcJurassic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcJurassic.TabIndex = 1
        Me.pcJurassic.TabStop = False
        Me.pcJurassic.Tag = "5"
        '
        'pcAvatar
        '
        Me.pcAvatar.Image = Global.AAD2_NekaneMinguitoArana.My.Resources.Resources.avatar
        Me.pcAvatar.Location = New System.Drawing.Point(120, 170)
        Me.pcAvatar.Name = "pcAvatar"
        Me.pcAvatar.Size = New System.Drawing.Size(195, 172)
        Me.pcAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcAvatar.TabIndex = 0
        Me.pcAvatar.TabStop = False
        Me.pcAvatar.Tag = "2"
        '
        'LbAvatar
        '
        Me.LbAvatar.AutoSize = True
        Me.LbAvatar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAvatar.Location = New System.Drawing.Point(185, 110)
        Me.LbAvatar.Name = "LbAvatar"
        Me.LbAvatar.Size = New System.Drawing.Size(69, 25)
        Me.LbAvatar.TabIndex = 6
        Me.LbAvatar.Text = "Avatar"
        '
        'lbSala1
        '
        Me.lbSala1.AutoSize = True
        Me.lbSala1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSala1.Location = New System.Drawing.Point(193, 147)
        Me.lbSala1.Name = "lbSala1"
        Me.lbSala1.Size = New System.Drawing.Size(56, 20)
        Me.lbSala1.TabIndex = 7
        Me.lbSala1.Text = "Sala 1"
        '
        'lbJurassicPark
        '
        Me.lbJurassicPark.AutoSize = True
        Me.lbJurassicPark.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbJurassicPark.Location = New System.Drawing.Point(442, 110)
        Me.lbJurassicPark.Name = "lbJurassicPark"
        Me.lbJurassicPark.Size = New System.Drawing.Size(125, 25)
        Me.lbJurassicPark.TabIndex = 8
        Me.lbJurassicPark.Text = "JurassicPark"
        '
        'lbSala2
        '
        Me.lbSala2.AutoSize = True
        Me.lbSala2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSala2.Location = New System.Drawing.Point(477, 147)
        Me.lbSala2.Name = "lbSala2"
        Me.lbSala2.Size = New System.Drawing.Size(56, 20)
        Me.lbSala2.TabIndex = 9
        Me.lbSala2.Text = "Sala 2"
        '
        'lbAida
        '
        Me.lbAida.AutoSize = True
        Me.lbAida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAida.Location = New System.Drawing.Point(770, 110)
        Me.lbAida.Name = "lbAida"
        Me.lbAida.Size = New System.Drawing.Size(52, 25)
        Me.lbAida.TabIndex = 10
        Me.lbAida.Text = "Aida"
        '
        'lbSala3
        '
        Me.lbSala3.AutoSize = True
        Me.lbSala3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSala3.Location = New System.Drawing.Point(771, 147)
        Me.lbSala3.Name = "lbSala3"
        Me.lbSala3.Size = New System.Drawing.Size(56, 20)
        Me.lbSala3.TabIndex = 11
        Me.lbSala3.Text = "Sala 3"
        '
        'lbLaAsistenta
        '
        Me.lbLaAsistenta.AutoSize = True
        Me.lbLaAsistenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLaAsistenta.Location = New System.Drawing.Point(246, 398)
        Me.lbLaAsistenta.Name = "lbLaAsistenta"
        Me.lbLaAsistenta.Size = New System.Drawing.Size(120, 25)
        Me.lbLaAsistenta.TabIndex = 12
        Me.lbLaAsistenta.Text = "La Asistenta"
        '
        'lbSala4
        '
        Me.lbSala4.AutoSize = True
        Me.lbSala4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSala4.Location = New System.Drawing.Point(279, 428)
        Me.lbSala4.Name = "lbSala4"
        Me.lbSala4.Size = New System.Drawing.Size(56, 20)
        Me.lbSala4.TabIndex = 13
        Me.lbSala4.Text = "Sala 4"
        '
        'lbTitanic
        '
        Me.lbTitanic.AutoSize = True
        Me.lbTitanic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitanic.Location = New System.Drawing.Point(638, 398)
        Me.lbTitanic.Name = "lbTitanic"
        Me.lbTitanic.Size = New System.Drawing.Size(70, 25)
        Me.lbTitanic.TabIndex = 14
        Me.lbTitanic.Text = "Titanic"
        '
        'lbSala5
        '
        Me.lbSala5.AutoSize = True
        Me.lbSala5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSala5.Location = New System.Drawing.Point(652, 428)
        Me.lbSala5.Name = "lbSala5"
        Me.lbSala5.Size = New System.Drawing.Size(56, 20)
        Me.lbSala5.TabIndex = 15
        Me.lbSala5.Text = "Sala 5"
        '
        'btCreditos
        '
        Me.btCreditos.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCreditos.Location = New System.Drawing.Point(811, 576)
        Me.btCreditos.Name = "btCreditos"
        Me.btCreditos.Size = New System.Drawing.Size(190, 68)
        Me.btCreditos.TabIndex = 16
        Me.btCreditos.Text = "Creditos"
        Me.btCreditos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1013, 656)
        Me.Controls.Add(Me.btCreditos)
        Me.Controls.Add(Me.lbSala5)
        Me.Controls.Add(Me.lbTitanic)
        Me.Controls.Add(Me.lbSala4)
        Me.Controls.Add(Me.lbLaAsistenta)
        Me.Controls.Add(Me.lbSala3)
        Me.Controls.Add(Me.lbAida)
        Me.Controls.Add(Me.lbSala2)
        Me.Controls.Add(Me.lbJurassicPark)
        Me.Controls.Add(Me.lbSala1)
        Me.Controls.Add(Me.LbAvatar)
        Me.Controls.Add(Me.LbCine)
        Me.Controls.Add(Me.pcTitanic)
        Me.Controls.Add(Me.pcLaAsistenta)
        Me.Controls.Add(Me.pcAida)
        Me.Controls.Add(Me.pcJurassic)
        Me.Controls.Add(Me.pcAvatar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pcTitanic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcLaAsistenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcAida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcJurassic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcAvatar As PictureBox
    Friend WithEvents pcJurassic As PictureBox
    Friend WithEvents pcAida As PictureBox
    Friend WithEvents pcLaAsistenta As PictureBox
    Friend WithEvents pcTitanic As PictureBox
    Friend WithEvents LbCine As Label
    Friend WithEvents LbAvatar As Label
    Friend WithEvents lbSala1 As Label
    Friend WithEvents lbJurassicPark As Label
    Friend WithEvents lbSala2 As Label
    Friend WithEvents lbAida As Label
    Friend WithEvents lbSala3 As Label
    Friend WithEvents lbLaAsistenta As Label
    Friend WithEvents lbSala4 As Label
    Friend WithEvents lbTitanic As Label
    Friend WithEvents lbSala5 As Label
    Friend WithEvents btCreditos As Button
End Class
