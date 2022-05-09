<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormlaireInscription
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_modifier = New System.Windows.Forms.Button()
        Me.btn_supp = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_mat = New System.Windows.Forms.TextBox()
        Me.Txt_prenom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_date_time = New System.Windows.Forms.DateTimePicker()
        Me.Txt_lieu = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_contact = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Btn_print = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_search = New System.Windows.Forms.TextBox()
        Me.matricule = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_prenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_genre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_lieu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(13, 269)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(110, 33)
        Me.btn_insert.TabIndex = 1
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_modifier
        '
        Me.btn_modifier.Location = New System.Drawing.Point(142, 269)
        Me.btn_modifier.Name = "btn_modifier"
        Me.btn_modifier.Size = New System.Drawing.Size(110, 33)
        Me.btn_modifier.TabIndex = 2
        Me.btn_modifier.Text = "Modifier"
        Me.btn_modifier.UseVisualStyleBackColor = True
        '
        'btn_supp
        '
        Me.btn_supp.Location = New System.Drawing.Point(271, 269)
        Me.btn_supp.Name = "btn_supp"
        Me.btn_supp.Size = New System.Drawing.Size(110, 33)
        Me.btn_supp.TabIndex = 3
        Me.btn_supp.Text = "Supprimer"
        Me.btn_supp.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.matricule, Me.col_nom, Me.col_prenom, Me.col_genre, Me.col_date, Me.col_lieu, Me.col_contact})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Location = New System.Drawing.Point(12, 313)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.IndianRed
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(933, 406)
        Me.DataGridView1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matricule :"
        '
        'Txt_name
        '
        Me.Txt_name.Location = New System.Drawing.Point(114, 104)
        Me.Txt_name.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Txt_name.Multiline = True
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.Size = New System.Drawing.Size(380, 33)
        Me.Txt_name.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(47, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nom :"
        '
        'Txt_mat
        '
        Me.Txt_mat.Location = New System.Drawing.Point(114, 63)
        Me.Txt_mat.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Txt_mat.Multiline = True
        Me.Txt_mat.Name = "Txt_mat"
        Me.Txt_mat.Size = New System.Drawing.Size(380, 33)
        Me.Txt_mat.TabIndex = 4
        '
        'Txt_prenom
        '
        Me.Txt_prenom.Location = New System.Drawing.Point(114, 145)
        Me.Txt_prenom.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Txt_prenom.Multiline = True
        Me.Txt_prenom.Name = "Txt_prenom"
        Me.Txt_prenom.Size = New System.Drawing.Size(380, 33)
        Me.Txt_prenom.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Prenom :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(509, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Date Naiss :"
        '
        'Txt_date_time
        '
        Me.Txt_date_time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_date_time.Location = New System.Drawing.Point(613, 60)
        Me.Txt_date_time.Name = "Txt_date_time"
        Me.Txt_date_time.Size = New System.Drawing.Size(269, 26)
        Me.Txt_date_time.TabIndex = 9
        '
        'Txt_lieu
        '
        Me.Txt_lieu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_lieu.Location = New System.Drawing.Point(613, 93)
        Me.Txt_lieu.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Txt_lieu.Multiline = True
        Me.Txt_lieu.Name = "Txt_lieu"
        Me.Txt_lieu.Size = New System.Drawing.Size(269, 33)
        Me.Txt_lieu.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(556, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Lieu :"
        '
        'Txt_contact
        '
        Me.Txt_contact.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_contact.Location = New System.Drawing.Point(613, 133)
        Me.Txt_contact.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Txt_contact.Multiline = True
        Me.Txt_contact.Name = "Txt_contact"
        Me.Txt_contact.Size = New System.Drawing.Size(269, 33)
        Me.Txt_contact.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(531, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Contact :"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(543, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Genre :"
        '
        'RadioButton1
        '
        Me.RadioButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(712, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(81, 22)
        Me.RadioButton1.TabIndex = 15
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Homme"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(613, 26)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 22)
        Me.RadioButton2.TabIndex = 16
        Me.RadioButton2.Text = "Femme"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Txt_contact)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Txt_lieu)
        Me.Panel1.Controls.Add(Me.Txt_date_time)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Txt_prenom)
        Me.Panel1.Controls.Add(Me.Txt_mat)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Txt_name)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 64)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(931, 197)
        Me.Panel1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"6éme", "5ème", "4ème", "3ème", "2nde", "1ème", "Tld"})
        Me.ComboBox1.Location = New System.Drawing.Point(114, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(380, 26)
        Me.ComboBox1.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(32, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Classe :"
        '
        'Btn_print
        '
        Me.Btn_print.Location = New System.Drawing.Point(400, 268)
        Me.Btn_print.Name = "Btn_print"
        Me.Btn_print.Size = New System.Drawing.Size(110, 33)
        Me.Btn_print.TabIndex = 5
        Me.Btn_print.Text = "Imprimmer"
        Me.Btn_print.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(535, 276)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Recherche"
        '
        'Txt_search
        '
        Me.Txt_search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_search.Location = New System.Drawing.Point(619, 268)
        Me.Txt_search.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Txt_search.Multiline = True
        Me.Txt_search.Name = "Txt_search"
        Me.Txt_search.Size = New System.Drawing.Size(324, 33)
        Me.Txt_search.TabIndex = 19
        '
        'matricule
        '
        Me.matricule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.matricule.HeaderText = "Matricule"
        Me.matricule.Name = "matricule"
        Me.matricule.ReadOnly = True
        '
        'col_nom
        '
        Me.col_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_nom.HeaderText = "Nom"
        Me.col_nom.Name = "col_nom"
        Me.col_nom.ReadOnly = True
        '
        'col_prenom
        '
        Me.col_prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_prenom.HeaderText = "Prenom"
        Me.col_prenom.Name = "col_prenom"
        Me.col_prenom.ReadOnly = True
        '
        'col_genre
        '
        Me.col_genre.HeaderText = "Genre"
        Me.col_genre.Name = "col_genre"
        Me.col_genre.ReadOnly = True
        '
        'col_date
        '
        Me.col_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_date.HeaderText = "Date de naissance"
        Me.col_date.Name = "col_date"
        Me.col_date.ReadOnly = True
        '
        'col_lieu
        '
        Me.col_lieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_lieu.HeaderText = "Lieu"
        Me.col_lieu.Name = "col_lieu"
        Me.col_lieu.ReadOnly = True
        '
        'col_contact
        '
        Me.col_contact.HeaderText = "Contact"
        Me.col_contact.Name = "col_contact"
        Me.col_contact.ReadOnly = True
        '
        'FormlaireInscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 731)
        Me.Controls.Add(Me.Txt_search)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Btn_print)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_supp)
        Me.Controls.Add(Me.btn_modifier)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormlaireInscription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormlaireInscription"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_modifier As Button
    Friend WithEvents btn_supp As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_mat As TextBox
    Friend WithEvents Txt_prenom As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_date_time As DateTimePicker
    Friend WithEvents Txt_lieu As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_contact As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Btn_print As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Txt_search As TextBox
    Friend WithEvents matricule As DataGridViewTextBoxColumn
    Friend WithEvents col_nom As DataGridViewTextBoxColumn
    Friend WithEvents col_prenom As DataGridViewTextBoxColumn
    Friend WithEvents col_genre As DataGridViewTextBoxColumn
    Friend WithEvents col_date As DataGridViewTextBoxColumn
    Friend WithEvents col_lieu As DataGridViewTextBoxColumn
    Friend WithEvents col_contact As DataGridViewTextBoxColumn
End Class
