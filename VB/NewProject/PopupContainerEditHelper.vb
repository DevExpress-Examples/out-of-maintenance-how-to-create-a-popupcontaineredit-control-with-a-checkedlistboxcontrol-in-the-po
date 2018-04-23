Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.ComponentModel
Imports System.Collections

Namespace NewProject
    Public Class PopupContainerEditHelper
        Public Sub New(ByVal popupContainerEdit As RepositoryItemPopupContainerEdit)
            RepositoryItem = popupContainerEdit

            PopuControl = CreatePopuControl()
            CheckedListBox = CreateCheckedListBoxControl()

            CheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill
            CheckedListBox.CheckOnClick = True
            PopuControl.Controls.Add(CheckedListBox)
            RepositoryItem.TextEditStyle = TextEditStyles.DisableTextEditor
            RepositoryItem.PopupControl = PopuControl

            SubscribeEditor()
        End Sub

#Region "Methods"
        Private Sub SubscribeEditor()
            AddHandler RepositoryItem.QueryResultValue, AddressOf RepositoryItem_QueryResultValue
            AddHandler RepositoryItem.QueryDisplayText, AddressOf RepositoryItem_QueryDisplayText
        End Sub
        Private Sub RepositoryItem_QueryDisplayText(ByVal sender As Object, ByVal e As QueryDisplayTextEventArgs)
            e.DisplayText = String.Join(";", GetCheckedText())
        End Sub

        Private Function GetCheckedText() As IEnumerable(Of String)
            Dim result As New List(Of String)

            For Each number As Integer In CheckedListBox.CheckedIndices
                result.Add(CheckedListBox.GetItemText(number))
            Next number
            Return result
        End Function

        Private Function GetCheckedValues() As IEnumerable(Of Object)
            Dim result As New List(Of Object)

            For Each number As Integer In CheckedListBox.CheckedIndices
                result.Add(CheckedListBox.GetItemValue(number))
            Next number
            Return result
        End Function

        Private Sub RepositoryItem_QueryResultValue(ByVal sender As Object, ByVal e As QueryResultValueEventArgs)
            e.Value = GetCheckedValues().ToArray()
        End Sub

        Protected Overridable Function CreatePopuControl() As PopupContainerControl
            Return New PopupContainerControl()
        End Function

        Protected Overridable Function CreateCheckedListBoxControl() As CheckedListBoxControl
            Return New CheckedListBoxControl()
        End Function
#End Region

#Region "Properties"
        Public Property ValueMember() As String
            Get
                Return CheckedListBox.ValueMember
            End Get
            Set(ByVal value As String)
                CheckedListBox.ValueMember = value
            End Set
        End Property
        Public Property DisplayMember() As String
            Get
                Return CheckedListBox.DisplayMember
            End Get
            Set(ByVal value As String)
                CheckedListBox.DisplayMember = value
            End Set
        End Property


        Public Property DataSource() As Object
            Get
                Return CheckedListBox.DataSource
            End Get
            Set(ByVal value As Object)
                CheckedListBox.DataSource = value
            End Set
        End Property

        Public ReadOnly Property Items() As CheckedListBoxItemCollection
            Get
                Return CheckedListBox.Items
            End Get
        End Property

        Private privateCheckedListBox As CheckedListBoxControl
        Public Property CheckedListBox() As CheckedListBoxControl
            Get
                Return privateCheckedListBox
            End Get
            Private Set(ByVal value As CheckedListBoxControl)
                privateCheckedListBox = value
            End Set
        End Property
        Private privatePopuControl As PopupContainerControl
        Public Property PopuControl() As PopupContainerControl
            Get
                Return privatePopuControl
            End Get
            Private Set(ByVal value As PopupContainerControl)
                privatePopuControl = value
            End Set
        End Property
        Private privateRepositoryItem As RepositoryItemPopupContainerEdit
        Public Property RepositoryItem() As RepositoryItemPopupContainerEdit
            Get
                Return privateRepositoryItem
            End Get
            Private Set(ByVal value As RepositoryItemPopupContainerEdit)
                privateRepositoryItem = value
            End Set
        End Property
#End Region
    End Class
End Namespace
