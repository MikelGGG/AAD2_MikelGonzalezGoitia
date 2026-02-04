<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        pbImagenDetalle = New PictureBox()
        lblTitulo = New Label()
        lblAnio = New Label()
        lblDuracion = New Label()
        lblPrecio = New Label()
        txtSinopsis = New TextBox()
        btnVenderEntradas = New Button()
        CType(pbImagenDetalle, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbImagenDetalle
        ' 
        pbImagenDetalle.Location = New Point(12, 12)
        pbImagenDetalle.Name = "pbImagenDetalle"
        pbImagenDetalle.Size = New Size(286, 357)
        pbImagenDetalle.SizeMode = PictureBoxSizeMode.Zoom
        pbImagenDetalle.TabIndex = 0
        pbImagenDetalle.TabStop = False
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.Location = New Point(304, 12)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(146, 54)
        lblTitulo.TabIndex = 1
        lblTitulo.Text = "Label1"
        ' 
        ' lblAnio
        ' 
        lblAnio.AutoSize = True
        lblAnio.Location = New Point(317, 85)
        lblAnio.Name = "lblAnio"
        lblAnio.Size = New Size(53, 20)
        lblAnio.TabIndex = 2
        lblAnio.Text = "Label1"
        ' 
        ' lblDuracion
        ' 
        lblDuracion.AutoSize = True
        lblDuracion.Location = New Point(317, 144)
        lblDuracion.Name = "lblDuracion"
        lblDuracion.Size = New Size(53, 20)
        lblDuracion.TabIndex = 3
        lblDuracion.Text = "Label2"
        ' 
        ' lblPrecio
        ' 
        lblPrecio.AutoSize = True
        lblPrecio.Location = New Point(317, 187)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(53, 20)
        lblPrecio.TabIndex = 4
        lblPrecio.Text = "Label3"
        ' 
        ' txtSinopsis
        ' 
        txtSinopsis.Location = New Point(317, 228)
        txtSinopsis.Multiline = True
        txtSinopsis.Name = "txtSinopsis"
        txtSinopsis.ReadOnly = True
        txtSinopsis.ScrollBars = ScrollBars.Vertical
        txtSinopsis.Size = New Size(184, 141)
        txtSinopsis.TabIndex = 5
        ' 
        ' btnVenderEntradas
        ' 
        btnVenderEntradas.Location = New Point(554, 251)
        btnVenderEntradas.Name = "btnVenderEntradas"
        btnVenderEntradas.Size = New Size(153, 103)
        btnVenderEntradas.TabIndex = 6
        btnVenderEntradas.Text = "Vender Entradas"
        btnVenderEntradas.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(866, 395)
        Controls.Add(btnVenderEntradas)
        Controls.Add(txtSinopsis)
        Controls.Add(lblPrecio)
        Controls.Add(lblDuracion)
        Controls.Add(lblAnio)
        Controls.Add(lblTitulo)
        Controls.Add(pbImagenDetalle)
        Name = "Form2"
        Text = "Form2"
        CType(pbImagenDetalle, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbImagenDetalle As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblAnio As Label
    Friend WithEvents lblDuracion As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtSinopsis As TextBox
    Friend WithEvents btnVenderEntradas As Button
End Class
