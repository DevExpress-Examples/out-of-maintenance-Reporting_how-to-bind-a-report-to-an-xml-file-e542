Imports System
Imports System.Windows.Forms

Namespace DataBinding_XMLDataPath
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim report As New XtraReport1()
			report.XmlDataPath = Application.StartupPath & "\..\..\Data\Cars.xml"

			report.ShowPreview()
		End Sub
	End Class
End Namespace