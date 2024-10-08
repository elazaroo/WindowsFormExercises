<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salary
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
        lboxPost = New ListBox()
        cboxSyndicate = New ComboBox()
        cboxSeniority = New ComboBox()
        nudSons = New NumericUpDown()
        lbPost = New Label()
        lbSyndicate = New Label()
        lbSeniority = New Label()
        Sons = New Label()
        btCalculate = New Button()
        CType(nudSons, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lboxPost
        ' 
        lboxPost.FormattingEnabled = True
        lboxPost.Items.AddRange(New Object() {"Worker", "Administrative", "Technical", "Professional"})
        lboxPost.Location = New Point(32, 65)
        lboxPost.Name = "lboxPost"
        lboxPost.Size = New Size(150, 104)
        lboxPost.TabIndex = 0
        lboxPost.SelectedItem = "Worker"
        ' 
        ' cboxSyndicate
        ' 
        cboxSyndicate.FormattingEnabled = True
        cboxSyndicate.Items.AddRange(New Object() {"Yes", "No"})
        cboxSyndicate.Location = New Point(220, 65)
        cboxSyndicate.Name = "cboxSyndicate"
        cboxSyndicate.Size = New Size(151, 28)
        cboxSyndicate.TabIndex = 1
        cboxSyndicate.SelectedItem = "No"
        ' 
        ' cboxSeniority
        ' 
        cboxSeniority.FormattingEnabled = True
        cboxSeniority.Items.AddRange(New Object() {"Less than 5", "Between 5 and 10", "More than 10"})
        cboxSeniority.Location = New Point(416, 65)
        cboxSeniority.Name = "cboxSeniority"
        cboxSeniority.Size = New Size(151, 28)
        cboxSeniority.TabIndex = 2
        cboxSeniority.SelectedItem = "Less than 5"
        ' 
        ' nudSons
        ' 
        nudSons.Location = New Point(606, 66)
        nudSons.Name = "nudSons"
        nudSons.Size = New Size(150, 27)
        nudSons.TabIndex = 3
        ' 
        ' lbPost
        ' 
        lbPost.AutoSize = True
        lbPost.Location = New Point(32, 31)
        lbPost.Name = "lbPost"
        lbPost.Size = New Size(36, 20)
        lbPost.TabIndex = 4
        lbPost.Text = "Post"
        ' 
        ' lbSyndicate
        ' 
        lbSyndicate.AutoSize = True
        lbSyndicate.Location = New Point(220, 31)
        lbSyndicate.Name = "lbSyndicate"
        lbSyndicate.Size = New Size(73, 20)
        lbSyndicate.TabIndex = 5
        lbSyndicate.Text = "Syndicate"
        ' 
        ' lbSeniority
        ' 
        lbSeniority.AutoSize = True
        lbSeniority.Location = New Point(416, 31)
        lbSeniority.Name = "lbSeniority"
        lbSeniority.Size = New Size(67, 20)
        lbSeniority.TabIndex = 6
        lbSeniority.Text = "Seniority"
        ' 
        ' Sons
        ' 
        Sons.AutoSize = True
        Sons.Location = New Point(606, 31)
        Sons.Name = "Sons"
        Sons.Size = New Size(40, 20)
        Sons.TabIndex = 7
        Sons.Text = "Sons"
        ' 
        ' btCalculate
        ' 
        btCalculate.Location = New Point(331, 174)
        btCalculate.Name = "btCalculate"
        btCalculate.Size = New Size(94, 29)
        btCalculate.TabIndex = 8
        btCalculate.Text = "Calculate"
        btCalculate.UseVisualStyleBackColor = True
        ' 
        ' Salary
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btCalculate)
        Controls.Add(Sons)
        Controls.Add(lbSeniority)
        Controls.Add(lbSyndicate)
        Controls.Add(lbPost)
        Controls.Add(nudSons)
        Controls.Add(cboxSeniority)
        Controls.Add(cboxSyndicate)
        Controls.Add(lboxPost)
        Name = "Salary"
        Text = "Salary"
        CType(nudSons, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lboxPost As ListBox
    Friend WithEvents cboxSyndicate As ComboBox
    Friend WithEvents cboxSeniority As ComboBox
    Friend WithEvents nudSons As NumericUpDown
    Friend WithEvents lbPost As Label
    Friend WithEvents lbSyndicate As Label
    Friend WithEvents lbSeniority As Label
    Friend WithEvents Sons As Label
    Friend WithEvents btCalculate As Button
End Class
