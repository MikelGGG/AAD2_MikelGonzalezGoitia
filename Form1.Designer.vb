<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        flpPeliculas = New FlowLayoutPanel()
        btnCreditos = New Button()
        SuspendLayout()
        ' 
        ' flpPeliculas
        ' 
        flpPeliculas.AutoScroll = True
        flpPeliculas.Location = New Point(0, 0)
        flpPeliculas.Name = "flpPeliculas"
        flpPeliculas.Size = New Size(1096, 519)
        flpPeliculas.TabIndex = 0
        ' 
        ' btnCreditos
        ' 
        btnCreditos.Location = New Point(12, 525)
        btnCreditos.Name = "btnCreditos"
        btnCreditos.Size = New Size(1073, 29)
        btnCreditos.TabIndex = 1
        btnCreditos.Text = "Creditos"
        btnCreditos.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1097, 566)
        Controls.Add(btnCreditos)
        Controls.Add(flpPeliculas)
        Name = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents flpPeliculas As FlowLayoutPanel
    Friend WithEvents btnCreditos As Button

End Class
