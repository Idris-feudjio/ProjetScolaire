<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormlaireInscription
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_mat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_prenom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_lieu = New System.Windows.Forms.TextBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_supp = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.matricule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_prenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_lieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Txt_lieu)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Txt_prenom)
        Me.Panel1.Controls.Add(Me.Txt_mat)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Txt_name)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(823, 208)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matricule :"
        '
        'Txt_name
        '
        Me.Txt_name.Location = New System.Drawing.Point(117, 54)
        Me.Txt_name.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Txt_name.Multiline = True
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.Size = New System.Drawing.Size(691, 33)
        Me.Txt_name.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nom :"
        '
        'Txt_mat
        '
        Me.Txt_mat.Location = New System.Drawing.Point(117, 13)
        Me.Txt_mat.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Txt_mat.Multiline = True
        Me.Txt_mat.Name = "Txt_mat"
        Me.Txt_mat.Size = New System.Drawing.Size(691, 33)
        Me.Txt_mat.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Prenom :"
        '
        'Txt_prenom
        '
        Me.Txt_prenom.Location = New System.Drawing.Point(117, 95)
        Me.Txt_prenom.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Txt_prenom.Multiline = True
        Me.Txt_prenom.Name = "Txt_prenom"
        Me.Txt_prenom.Size = New System.Drawing.Size(691, 33)
        Me.Txt_prenom.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Date Naiss :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(117, 133)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(255, 26)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Lieu :"
        '
        'Txt_lieu
        '
        Me.Txt_lieu.Location = New System.Drawing.Point(117, 167)
        Me.Txt_lieu.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Txt_lieu.Multiline = True
        Me.Txt_lieu.Name = "Txt_lieu"
        Me.Txt_lieu.Size = New System.Drawing.Size(691, 33)
        Me.Txt_lieu.TabIndex = 10
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(37, 228)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(123, 33)
        Me.btn_insert.TabIndex = 1
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_modifier
        '
        Me.btn_modifier.Location = New System.Drawing.Point(193, 228)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(123, 33)
        Me.btn_modifier.TabIndex = 2
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = True
        '
        'btn_supp
        '
        Me.btn_supp.Location = New System.Drawing.Point(690, 228)
        Me.btn_supp.Name = "btn_supp"
        Me.btn_supp.Size = New System.Drawing.Size(123, 33)
        Me.btn_supp.TabIndex = 3
        Me.btn_supp.Text = "Supprimer"
        Me.btn_supp.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.matricule, Me.col_nom, Me.col_prenom, Me.col_date, Me.col_lieu})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 267)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(823, 284)
        Me.DataGridView1.TabIndex = 4
        '
        'matricule
        '
        Me.matricule.HeaderText = "Matricule"
        Me.matricule.Name = "matricule"
        '
        'col_nom
        '
        Me.col_nom.HeaderText = "Nom"
        Me.col_nom.Name = "col_nom"
        Me.col_nom.Width = 200
        '
        'col_prenom
        '
        Me.col_prenom.HeaderText = "Prenom"
        Me.col_prenom.Name = "col_prenom"
        Me.col_prenom.Width = 200
        '
        'col_date
        '
        Me.col_date.HeaderText = "Date de naissance"
        Me.col_date.Name = "col_date"
        '
        'col_lieu
        '
        Me.col_lieu.HeaderText = "Lieu"
        Me.col_lieu.Name = "col_lieu"
        Me.col_lieu.Width = 200
        '
        'FormlaireInscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 563)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_supp)
        Me.Controls.Add(Me.btn_modifier)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormlaireInscription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormlaireInscription"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_prenom As TextBox
    Friend WithEvents Txt_mat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_name As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_lieu As TextBox
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_supp As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents matricule As DataGridViewTextBoxColumn
    Friend WithEvents col_nom As DataGridViewTextBoxColumn
    Friend WithEvents col_prenom As DataGridViewTextBoxColumn
    Friend WithEvents col_date As DataGridViewTextBoxColumn
    Friend WithEvents col_lieu As DataGridViewTextBoxColumn
End Class
