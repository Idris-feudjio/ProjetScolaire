Imports MySql.Data.MySqlClient
Public Class FormlaireInscription
    Private Sub loadData()
        DataGridView1.Rows.Clear()
        connecttodb()
        cmd = New MySqlCommand("SELECT * FROM student", connection)
        myslDataReader = cmd.ExecuteReader
        While myslDataReader.Read
            DataGridView1.Rows.Add(myslDataReader.Item("matricule").ToString(), myslDataReader.Item("nom_etudiant").ToString(),
                                   myslDataReader.Item("prenom_etudiant").ToString(), myslDataReader.Item("sexe_etudiant").ToString(),
                                    myslDataReader.Item("date_naiss_etudiant").ToString(), myslDataReader.Item("lieu_naiss").ToString(),
                                     myslDataReader.Item("contact_etudiant").ToString(), myslDataReader.Item("contact_parent").ToString()
                    )
        End While


    End Sub
    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim res As String = "INSERT INTO student ()"
        Dim query As String = " INSERT INTO student (matricule, nom_etudiant, prenom_etudiant,sexe_etudiant, date_naiss_etudiant, lieu_naiss, contact_etudiant, contact_parent) VALUES ('" & Txt_mat.Text & "', '" & Txt_name.Text & "', '" & Txt_prenom.Text & "', 'Homme',
        '2022-04-27', '" & Txt_lieu.Text & "', '654550898', '658218699')
        "
        Dim selected As String = "SELECT * FROM student"
        inserttodata(DataGridView1, query, selected)
        loadData()
    End Sub

    Private Sub FormlaireInscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim selected As String = "SELECT * FROM student"
        Dim cel As DataGridView
        'loaddatatomysql(DataGridView1, selected)
        loadData()
    End Sub


End Class