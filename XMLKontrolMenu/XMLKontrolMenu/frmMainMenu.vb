Imports System.Xml

Public Class frmMainMenu
    Dim xmlText As XmlReader = XmlReader.Create(Application.StartupPath & "\test.xml")

    Public Sub readXML()
        While xmlText.Read()
            If xmlText.IsStartElement() Then
                Select Case xmlText.Name.ToString
                    Case "to"
                        txtXML.Text += xmlText.ReadElementContentAsString & Environment.NewLine
                    Case "from"
                        txtXML.Text += xmlText.ReadElementContentAsString & Environment.NewLine
                    Case "heading"
                        txtXML.Text += xmlText.ReadElementContentAsString & Environment.NewLine
                    Case "body"
                        txtXML.Text += xmlText.ReadElementContentAsString & Environment.NewLine
                End Select
            End If
        End While
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readXML()
    End Sub
End Class
