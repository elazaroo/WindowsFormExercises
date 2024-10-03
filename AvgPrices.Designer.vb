<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvgPrices
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
        tbPrice1 = New TextBox()
        tbPrice2 = New TextBox()
        tbPrice3 = New TextBox()
        btCalculate = New Button()
        SuspendLayout()
        ' 
        ' tbPrice1
        ' 
        tbPrice1.Location = New Point(119, 104)
        tbPrice1.Name = "tbPrice1"
        tbPrice1.Size = New Size(125, 27)
        tbPrice1.TabIndex = 0
        ' 
        ' tbPrice2
        ' 
        tbPrice2.Location = New Point(336, 104)
        tbPrice2.Name = "tbPrice2"
        tbPrice2.Size = New Size(125, 27)
        tbPrice2.TabIndex = 1
        ' 
        ' tbPrice3
        ' 
        tbPrice3.Location = New Point(568, 104)
        tbPrice3.Name = "tbPrice3"
        tbPrice3.Size = New Size(125, 27)
        tbPrice3.TabIndex = 2
        ' 
        ' btCalculate
        ' 
        btCalculate.Location = New Point(352, 223)
        btCalculate.Name = "btCalculate"
        btCalculate.Size = New Size(94, 29)
        btCalculate.TabIndex = 3
        btCalculate.Text = "Calculate"
        btCalculate.UseVisualStyleBackColor = True
        ' 
        ' AvgPrices
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btCalculate)
        Controls.Add(tbPrice3)
        Controls.Add(tbPrice2)
        Controls.Add(tbPrice1)
        Name = "AvgPrices"
        Text = "AvgPrices"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbPrice1 As TextBox
    Friend WithEvents tbPrice2 As TextBox
    Friend WithEvents tbPrice3 As TextBox
    Friend WithEvents btCalculate As Button
End Class
