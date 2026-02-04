<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucPelicula
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        pbImagen = New PictureBox()
        lblTitulo = New Label()
        lblSala = New Label()
        Label1 = New Label()
        CType(pbImagen, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbImagen
        ' 
        pbImagen.Location = New Point(0, 0)
        pbImagen.Name = "pbImagen"
        pbImagen.Size = New Size(338, 397)
        pbImagen.SizeMode = PictureBoxSizeMode.Zoom
        pbImagen.TabIndex = 0
        pbImagen.TabStop = False
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(44, 400)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(21, 20)
        lblTitulo.TabIndex = 1
        lblTitulo.Text = """"""
        ' 
        ' lblSala
        ' 
        lblSala.AutoSize = True
        lblSala.Location = New Point(201, 440)
        lblSala.Name = "lblSala"
        lblSala.Size = New Size(21, 20)
        lblSala.TabIndex = 2
        lblSala.Text = """"""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 440)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 20)
        Label1.TabIndex = 3
        Label1.Text = "Numero de sala:"
        ' 
        ' ucPelicula
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Label1)
        Controls.Add(lblSala)
        Controls.Add(lblTitulo)
        Controls.Add(pbImagen)
        Name = "ucPelicula"
        Size = New Size(338, 473)
        CType(pbImagen, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSala As Label
    Friend WithEvents Label1 As Label

End Class
