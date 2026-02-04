<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCreditos
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
        pbAvatar = New PictureBox()
        lblNombre = New Label()
        lblBio = New Label()
        lnkPerfil = New LinkLabel()
        btnCerrar = New Button()
        lblRep = New Label()
        CType(pbAvatar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbAvatar
        ' 
        pbAvatar.Location = New Point(12, 12)
        pbAvatar.Name = "pbAvatar"
        pbAvatar.Size = New Size(290, 285)
        pbAvatar.SizeMode = PictureBoxSizeMode.Zoom
        pbAvatar.TabIndex = 0
        pbAvatar.TabStop = False
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNombre.Location = New Point(349, 32)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(124, 46)
        lblNombre.TabIndex = 1
        lblNombre.Text = "Label1"
        ' 
        ' lblBio
        ' 
        lblBio.AutoSize = True
        lblBio.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBio.Location = New Point(349, 119)
        lblBio.Name = "lblBio"
        lblBio.Size = New Size(124, 46)
        lblBio.TabIndex = 2
        lblBio.Text = "Label1"
        ' 
        ' lnkPerfil
        ' 
        lnkPerfil.AutoSize = True
        lnkPerfil.Font = New Font("Nirmala UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lnkPerfil.Location = New Point(29, 353)
        lnkPerfil.Name = "lnkPerfil"
        lnkPerfil.Size = New Size(191, 46)
        lnkPerfil.TabIndex = 3
        lnkPerfil.TabStop = True
        lnkPerfil.Text = "LinkLabel1"
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Location = New Point(566, 398)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(92, 40)
        btnCerrar.TabIndex = 4
        btnCerrar.Text = "Salir"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' lblRep
        ' 
        lblRep.AutoSize = True
        lblRep.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRep.Location = New Point(349, 217)
        lblRep.Name = "lblRep"
        lblRep.Size = New Size(124, 46)
        lblRep.TabIndex = 5
        lblRep.Text = "Label1"
        ' 
        ' FormCreditos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(670, 450)
        Controls.Add(lblRep)
        Controls.Add(btnCerrar)
        Controls.Add(lnkPerfil)
        Controls.Add(lblBio)
        Controls.Add(lblNombre)
        Controls.Add(pbAvatar)
        Name = "FormCreditos"
        Text = "FormCreditos"
        CType(pbAvatar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbAvatar As PictureBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblBio As Label
    Friend WithEvents lnkPerfil As LinkLabel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents lblRep As Label
End Class
