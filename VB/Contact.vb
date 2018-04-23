Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Imports DevExpress.Xpo

Namespace LinkedObjectAsCard
	Public Class Contact
		Inherits XPObject

		Public Sub New()
			MyBase.New()
		End Sub

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Public Sub New(ByVal name As String, ByVal phone As String)
			Me.FullName = name
			Me.Phone = phone
		End Sub

		Public FullName As String
		Public Phone As String

		Public Address As Address

		Public ReadOnly Property Itself() As Contact
			Get
				Return Me
			End Get
		End Property
	End Class


	Public Class Address
		Inherits XPObject

		Public Sub New()
			MyBase.New()
		End Sub

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		Public Sub New(ByVal line1 As String, ByVal zip As String, ByVal country As String)
			Me.Line1 = line1
			Me.ZIP = zip
			Me.Country = country
		End Sub

		Public Line1 As String
		Public ZIP As String
		Public Country As String
	End Class
End Namespace 'end of root namespace