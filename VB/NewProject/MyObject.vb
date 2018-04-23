Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors

Namespace NewProject
	Public Class MyObject
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property

		Private privateAge As Integer
		Public Property Age() As Integer
			Get
				Return privateAge
			End Get
			Set(ByVal value As Integer)
				privateAge = value
			End Set
		End Property

	End Class
End Namespace
