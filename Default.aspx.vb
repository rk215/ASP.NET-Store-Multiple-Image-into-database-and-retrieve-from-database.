Imports System.Data.SqlClient
Imports System.Data
Partial Class _Default
    Inherits System.Web.UI.Page
    Dim con As New SqlConnection(ConfigurationManager.ConnectionStrings("testConnectionString").ConnectionString)
    Dim ds As New DataSet
    Dim cmd As SqlCommand
    Dim ad As SqlDataAdapter
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fpath, spath, tpath, fstore, sstore, tstore As String
        fpath = Server.MapPath("FImage/")
        fstore = "FImage/" + FileUpload1.FileName
        fpath = fpath + FileUpload1.FileName
        FileUpload1.SaveAs(fpath)

        spath = Server.MapPath("SImage/")
        sstore = "SImage/" + FileUpload2.FileName
        spath = spath + FileUpload2.FileName
        FileUpload2.SaveAs(spath)

        tpath = Server.MapPath("TImage/")
        tstore = "TImage/" + FileUpload3.FileName
        tpath = tpath + FileUpload3.FileName
        FileUpload3.SaveAs(tpath)

        cmd = New SqlCommand("insert into multipleimageupdate values(@fimg,@simg,@timg)", con)
        cmd.Parameters.AddWithValue("@fimg", fstore)
        cmd.Parameters.AddWithValue("@simg", sstore)
        cmd.Parameters.AddWithValue("@timg", tstore)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()



    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fpath, spath, tpath, fstore, sstore, tstore As String
        If FileUpload4.HasFile Then
            fpath = Server.MapPath("FImage/")
            fstore = "FImage/" + FileUpload4.FileName
            fpath = fpath + FileUpload4.FileName
            FileUpload4.SaveAs(fpath)
            cmd = New SqlCommand("update multipleimageupdate set fimg=@fimg where i=@i", con)
            cmd.Parameters.AddWithValue("@fimg", fstore)
            cmd.Parameters.AddWithValue("@i", TextBox1.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End If
        If FileUpload5.HasFile Then
            spath = Server.MapPath("SImage/")
            sstore = "SImage/" + FileUpload5.FileName
            spath = spath + FileUpload5.FileName
            FileUpload5.SaveAs(spath)
            cmd = New SqlCommand("update multipleimageupdate set simg=@simg where i=@i", con)
            cmd.Parameters.AddWithValue("@simg", sstore)
            cmd.Parameters.AddWithValue("@i", TextBox1.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End If
        If FileUpload6.HasFile Then
            tpath = Server.MapPath("TImage/")
            tstore = "TImage/" + FileUpload6.FileName
            tpath = tpath + FileUpload3.FileName
            FileUpload6.SaveAs(tpath)

            cmd = New SqlCommand("update multipleimageupdate set timg=@timg where i=@i", con)
            cmd.Parameters.AddWithValue("@timg", tstore)
            cmd.Parameters.AddWithValue("@i", TextBox1.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        End If

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        cmd = New SqlCommand("select fimg,simg,timg from multipleimageupdate where i=@i", con)
        cmd.Parameters.AddWithValue("@i", TextBox1.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        Using dr As SqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                Image1.ImageUrl = dr("fimg")
                Image3.ImageUrl = dr("timg")
                Image2.ImageUrl = dr("simg")
            End If
        End Using


    End Sub
End Class
