<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        lblNombrePeli = New Label()
        lblStockDisponible = New Label()
        Label2 = New Label()
        Label3 = New Label()
        numCantidad = New NumericUpDown()
        Label4 = New Label()
        lblTotal = New Label()
        btnComprar = New Button()
        CType(numCantidad, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(189, 20)
        Label1.TabIndex = 0
        Label1.Text = "PELICULA SELECCIONADA: "
        ' 
        ' lblNombrePeli
        ' 
        lblNombrePeli.AutoSize = True
        lblNombrePeli.Location = New Point(274, 29)
        lblNombrePeli.Name = "lblNombrePeli"
        lblNombrePeli.Size = New Size(53, 20)
        lblNombrePeli.TabIndex = 1
        lblNombrePeli.Text = "Label2"
        ' 
        ' lblStockDisponible
        ' 
        lblStockDisponible.AutoSize = True
        lblStockDisponible.Location = New Point(273, 93)
        lblStockDisponible.Name = "lblStockDisponible"
        lblStockDisponible.Size = New Size(53, 20)
        lblStockDisponible.TabIndex = 2
        lblStockDisponible.Text = "Label2"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 20)
        Label2.TabIndex = 3
        Label2.Text = "STOCK DISPONIBLE: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(35, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 4
        Label3.Text = "CANTIDAD: "
        ' 
        ' numCantidad
        ' 
        numCantidad.Location = New Point(273, 138)
        numCantidad.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        numCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        numCantidad.Name = "numCantidad"
        numCantidad.Size = New Size(53, 27)
        numCantidad.TabIndex = 5
        numCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(35, 191)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 20)
        Label4.TabIndex = 6
        Label4.Text = "COSTE TOTAL: "
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(273, 191)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(53, 20)
        lblTotal.TabIndex = 7
        lblTotal.Text = "Label5"
        ' 
        ' btnComprar
        ' 
        btnComprar.Location = New Point(35, 239)
        btnComprar.Name = "btnComprar"
        btnComprar.Size = New Size(113, 98)
        btnComprar.TabIndex = 8
        btnComprar.Text = "CONFIRMAR COMPRA"
        btnComprar.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(383, 387)
        Controls.Add(btnComprar)
        Controls.Add(lblTotal)
        Controls.Add(Label4)
        Controls.Add(numCantidad)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblStockDisponible)
        Controls.Add(lblNombrePeli)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Form3"
        CType(numCantidad, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombrePeli As Label
    Friend WithEvents lblStockDisponible As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents numCantidad As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnComprar As Button
End Class
