<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PillColor
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
        pbRed = New PictureBox()
        pbBlue = New PictureBox()
        CType(pbRed, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbBlue, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbRed
        ' 
        pbRed.Image = My.Resources.Resources.red
        pbRed.Location = New Point(197, 227)
        pbRed.Name = "pbRed"
        pbRed.Size = New Size(125, 62)
        pbRed.SizeMode = PictureBoxSizeMode.Zoom
        pbRed.TabIndex = 0
        pbRed.TabStop = False
        ' 
        ' pbBlue
        ' 
        pbBlue.Image = My.Resources.Resources.blue
        pbBlue.Location = New Point(505, 227)
        pbBlue.Name = "pbBlue"
        pbBlue.Size = New Size(125, 62)
        pbBlue.SizeMode = PictureBoxSizeMode.Zoom
        pbBlue.TabIndex = 1
        pbBlue.TabStop = False
        ' 
        ' PillColor
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(pbBlue)
        Controls.Add(pbRed)
        Name = "PillColor"
        Text = "PillColor"
        CType(pbRed, ComponentModel.ISupportInitialize).EndInit()
        CType(pbBlue, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbRed As PictureBox
    Friend WithEvents pbBlue As PictureBox
End Class
