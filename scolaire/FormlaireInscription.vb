Imports MySql.Data.MySqlClient
Public Class FormlaireInscription
    Dim genre As String
    Private Sub loadData()
        DataGridView1.Rows.Clear()
        connecttodb()
        cmd = New MySqlCommand("SELECT * FROM student", connection)
        ' runsql("SELECT * FROM student")
        myslDataReader = cmd.ExecuteReader
        While myslDataReader.Read
            DataGridView1.Rows.Add(myslDataReader.Item("matricule").ToString(), myslDataReader.Item("nom_etudiant").ToString(),
                    myslDataReader.Item("prenom_etudiant").ToString(), myslDataReader.Item("sexe_etudiant").ToString(),
                    myslDataReader.Item("date_naiss_etudiant").ToString(), myslDataReader.Item("lieu_naiss").ToString(),
                    myslDataReader.Item("contact_etudiant").ToString()', myslDataReader.Item("contact_parent").ToString()
                    )
        End While


    End Sub
    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim query As String = " INSERT INTO student (matricule, nom_etudiant, prenom_etudiant,sexe_etudiant, date_naiss_etudiant, lieu_naiss, contact_etudiant, contact_parent) VALUES ('" & Txt_mat.Text & "', '" & Txt_name.Text & "', '" & Txt_prenom.Text & "', '" & genre & "',
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

    Private Sub Txt_search_TextChanged(sender As Object, e As EventArgs) Handles Txt_search.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        genre = "Homme"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        genre = "Femme"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer
        Dim selectRows As DataGridViewRow
        index = e.RowIndex
        selectRows = DataGridView1.Rows(index)
        Txt_name.Text = selectRows.Cells(1).Value.ToString()
        Txt_prenom.Text = selectRows.Cells(2).Value.ToString()
        Txt_date_time.Text = selectRows.Cells(4).Value.ToString()
        Txt_lieu.Text = selectRows.Cells(5).Value.ToString()
        Txt_contact.Text = selectRows.Cells(6).Value.ToString()

    End Sub
End Class