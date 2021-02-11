Public Class frmMainMenu

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readXML.readXML()
    End Sub

    Private Sub btnXMLOlustur_Click(sender As Object, e As EventArgs) Handles btnXMLOlustur.Click
        writeXML.writeXML()
    End Sub
End Class
