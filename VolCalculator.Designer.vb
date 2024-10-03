<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VolCalculator
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
        lbDiameter = New Label()
        lbHeight = New Label()
        tbDiameter = New TextBox()
        tbHeight = New TextBox()
        btCalculate = New Button()
        lbResult = New Label()
        SuspendLayout()
        ' 
        ' lbDiameter
        ' 
        lbDiameter.AutoSize = True
        lbDiameter.Location = New Point(227, 74)
        lbDiameter.Name = "lbDiameter"
        lbDiameter.Size = New Size(71, 20)
        lbDiameter.TabIndex = 0
        lbDiameter.Text = "Diameter"
        ' 
        ' lbHeight
        ' 
        lbHeight.AutoSize = True
        lbHeight.Location = New Point(486, 74)
        lbHeight.Name = "lbHeight"
        lbHeight.Size = New Size(54, 20)
        lbHeight.TabIndex = 1
        lbHeight.Text = "Height"
        ' 
        ' tbDiameter
        ' 
        tbDiameter.Location = New Point(207, 119)
        tbDiameter.Name = "tbDiameter"
        tbDiameter.Size = New Size(125, 27)
        tbDiameter.TabIndex = 2
        ' 
        ' tbHeight
        ' 
        tbHeight.Location = New Point(452, 119)
        tbHeight.Name = "tbHeight"
        tbHeight.Size = New Size(125, 27)
        tbHeight.TabIndex = 3
        ' 
        ' btCalculate
        ' 
        btCalculate.Location = New Point(350, 209)
        btCalculate.Name = "btCalculate"
        btCalculate.Size = New Size(94, 29)
        btCalculate.TabIndex = 4
        btCalculate.Text = "Calculate"
        btCalculate.UseVisualStyleBackColor = True
        ' 
        ' lbResult
        ' 
        lbResult.AutoSize = True
        lbResult.Location = New Point(371, 305)
        lbResult.Name = "lbResult"
        lbResult.Size = New Size(0, 20)
        lbResult.TabIndex = 5
        ' 
        ' VolCalculator
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lbResult)
        Controls.Add(btCalculate)
        Controls.Add(tbHeight)
        Controls.Add(tbDiameter)
        Controls.Add(lbHeight)
        Controls.Add(lbDiameter)
        Name = "VolCalculator"
        Text = "VolCalculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbDiameter As Label
    Friend WithEvents lbHeight As Label
    Friend WithEvents tbDiameter As TextBox
    Friend WithEvents tbHeight As TextBox
    Friend WithEvents btCalculate As Button
    Friend WithEvents lbResult As Label
End Class
