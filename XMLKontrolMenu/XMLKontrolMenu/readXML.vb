Imports System.Xml

Public Class readXML

    Shared xmlText As XmlReader = XmlReader.Create(Application.StartupPath & "\test.xml")   'XML yolu gösterildi

    Public Shared Sub readXML()
        While xmlText.Read()    'XML Okunmaya başlandı

            If xmlText.NodeType = XmlNodeType.Element Then 'XML Nod'u element tipinde ise gir, attribute,text,document,none ise atla
                Select Case xmlText.Name
                    Case "to"
                        frmMainMenu.txtXML.Text += xmlText.ReadElementContentAsString & Environment.NewLine
                    Case "from"
                        frmMainMenu.txtXML.Text += xmlText.ReadElementContentAsString & Environment.NewLine
                    Case "heading"
                        frmMainMenu.txtXML.Text += xmlText.ReadElementContentAsString & Environment.NewLine
                    Case "body"
                        frmMainMenu.txtXML.Text += xmlText.ReadElementContentAsString & Environment.NewLine
                End Select
            End If

        End While
    End Sub

    'Public Shared Sub readXMLWithTag()

    '    Dim childNode As XmlNode

    '    While xmlText.Read()

    '        frmMainMenu.txtXML.Text = childNode.Attributes("to").InnerXml

    '    End While
    'End Sub

End Class
