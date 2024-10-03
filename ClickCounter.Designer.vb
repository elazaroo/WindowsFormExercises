<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClickCounter
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
        lbCounter = New Label()
        btCount = New Button()
        SuspendLayout()
        ' 
        ' lbCounter
        ' 
        lbCounter.AutoSize = True
        lbCounter.Location = New Point(354, 93)
        lbCounter.Name = "lbCounter"
        lbCounter.Size = New Size(0, 20)
        lbCounter.TabIndex = 0
        ' 
        ' btCount
        ' 
        btCount.Location = New Point(322, 256)
        btCount.Name = "btCount"
        btCount.Size = New Size(94, 29)
        btCount.TabIndex = 1
        btCount.Text = "Count"
        btCount.UseVisualStyleBackColor = True
        ' 
        ' ClickCounter
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btCount)
        Controls.Add(lbCounter)
        Name = "ClickCounter"
        Text = "ClickCounter"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbCounter As Label
    Friend WithEvents btCount As Button
End Class
