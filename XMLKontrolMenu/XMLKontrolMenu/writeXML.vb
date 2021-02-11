Imports System.Xml

Public Class writeXML
    Shared fileName As String = Application.StartupPath & "\abc.xml"

    Public Shared Sub writeXML()
        Try
            Dim xmlWriter As XmlWriter = XmlWriter.Create(fileName)     'XML oluşturuldu.

            xmlWriter.WriteStartDocument()  'Döküman açıldı.
            xmlWriter.WriteStartElement("users")    'Root tag oluşturuldu.

            xmlWriter.WriteStartElement("user")     'Child tag oluşturuldu.
            xmlWriter.WriteAttributeString("name", "Emir")  'Attribute oluşturmak için gereken localName ve value girildi.
            xmlWriter.WriteAttributeString("surname", "Karpuz")
            xmlWriter.WriteAttributeString("age", "29")

            xmlWriter.WriteEndElement()     'Root tag kapatıldı.
            xmlWriter.WriteEndDocument()    'Döküman kapatıldı.
            xmlWriter.Close()   'XML bitirildi.
        Catch ex As Exception
            MessageBox.Show("Hata: " & ex.Message, "Hata")
        End Try

    End Sub

End Class
