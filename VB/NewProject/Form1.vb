Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors
Imports System.ComponentModel

Namespace NewProject
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim source As BindingList(Of MyObject) = CreateDataSource()

			Dim helper1 As New PopupContainerEditHelper(popupContainerEdit1.Properties)
			helper1.DataSource = source
			helper1.DisplayMember = "Name"
			helper1.ValueMember = "Age"
			AddHandler popupContainerEdit1.Properties.EditValueChanged, AddressOf popupContainerEdit1Properties_EditValueChanged


			Dim helper2 As New PopupContainerEditHelper(popupContainerEdit2.Properties)
			For j As Integer = 0 To source.Count - 1
				helper2.Items.Add(source(j))
				helper2.Items(j).Description = String.Format("Item {0}", j)
			Next j
			AddHandler popupContainerEdit2.Properties.EditValueChanged, AddressOf Properties_EditValueChanged

		End Sub

		Private Sub Properties_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim popupContainerEdit As PopupContainerEdit = TryCast(sender, PopupContainerEdit)
			listBox2.DataSource = popupContainerEdit.EditValue
		End Sub

		Private Sub popupContainerEdit1Properties_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim popupContainerEdit As PopupContainerEdit = TryCast(sender, PopupContainerEdit)
			listBox1.DataSource = popupContainerEdit.EditValue
		End Sub

		Private Function CreateDataSource() As BindingList(Of MyObject)
			Dim source As New BindingList(Of MyObject)()

			For i As Integer = 0 To 9
				source.Add(New MyObject() With {.Name = String.Format("Name {0}", i), .Age = i})
			Next i

			Return source
		End Function
	End Class
End Namespace
