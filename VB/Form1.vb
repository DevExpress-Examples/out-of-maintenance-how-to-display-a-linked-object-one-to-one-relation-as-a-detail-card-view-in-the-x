Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Namespace LinkedObjectAsCard
	Public Class Form1
		Inherits System.Windows.Forms.Form

	#Region " Windows Form Designer generated code "

		Public Sub New()
			MyBase.New()

			InitializeComponent()

		End Sub

		'Form overrides dispose to clean up the component list.
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		'Required by the Windows Form Designer
		Private components As System.ComponentModel.IContainer

		'NOTE: The following procedure is required by the Windows Form Designer
		'It can be modified using the Windows Form Designer.  
		'Do not modify it using the code editor.
		Friend GridControl1 As DevExpress.XtraGrid.GridControl
		Friend GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Friend colContacts As DevExpress.Xpo.XPCollection
		Friend colFullName As DevExpress.XtraGrid.Columns.GridColumn
		Friend CardView1 As DevExpress.XtraGrid.Views.Card.CardView
		Friend colLine1 As DevExpress.XtraGrid.Columns.GridColumn
		Friend colZIP As DevExpress.XtraGrid.Columns.GridColumn
		Friend colCountry As DevExpress.XtraGrid.Columns.GridColumn
		Friend CardView2 As DevExpress.XtraGrid.Views.Card.CardView
		Friend colPhone1 As DevExpress.XtraGrid.Columns.GridColumn
		<System.Diagnostics.DebuggerStepThrough()> _
		Private Sub InitializeComponent()
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Dim gridLevelNode2 As New DevExpress.XtraGrid.GridLevelNode()
			Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
			Me.colLine1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colZIP = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCountry = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.colContacts = New DevExpress.Xpo.XPCollection()
			Me.CardView2 = New DevExpress.XtraGrid.Views.Card.CardView()
			Me.colPhone1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colFullName = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.colContacts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CardView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' CardView1
			' 
			Me.CardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colLine1, Me.colZIP, Me.colCountry})
			Me.CardView1.FocusedCardTopFieldIndex = 0
			Me.CardView1.GridControl = Me.GridControl1
			Me.CardView1.Name = "CardView1"
			Me.CardView1.OptionsView.ShowCardCaption = False
			Me.CardView1.OptionsView.ShowHorzScrollBar = False
			Me.CardView1.OptionsView.ShowQuickCustomizeButton = False
			' 
			' colLine1
			' 
			Me.colLine1.Caption = "Line1"
			Me.colLine1.FieldName = "Line1"
			Me.colLine1.Name = "colLine1"
			Me.colLine1.Visible = True
			Me.colLine1.VisibleIndex = 0
			' 
			' colZIP
			' 
			Me.colZIP.Caption = "ZIP"
			Me.colZIP.FieldName = "ZIP"
			Me.colZIP.Name = "colZIP"
			Me.colZIP.Visible = True
			Me.colZIP.VisibleIndex = 1
			' 
			' colCountry
			' 
			Me.colCountry.Caption = "Country"
			Me.colCountry.FieldName = "Country"
			Me.colCountry.Name = "colCountry"
			Me.colCountry.Visible = True
			Me.colCountry.VisibleIndex = 2
			' 
			' GridControl1
			' 
			Me.GridControl1.DataSource = Me.colContacts
			Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			gridLevelNode1.LevelTemplate = Me.CardView1
			gridLevelNode1.RelationName = "Address"
			gridLevelNode2.LevelTemplate = Me.CardView2
			gridLevelNode2.RelationName = "Itself"
			Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1, gridLevelNode2})
			Me.GridControl1.Location = New System.Drawing.Point(0, 0)
			Me.GridControl1.MainView = Me.GridView1
			Me.GridControl1.Name = "GridControl1"
			Me.GridControl1.Size = New System.Drawing.Size(528, 258)
			Me.GridControl1.TabIndex = 0
			Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.CardView2, Me.GridView1, Me.CardView1})
			' 
			' colContacts
			' 
			Me.colContacts.DisplayableProperties = "This;IsDeleted;Oid;FullName;Phone;Address;Itself"
			Me.colContacts.ObjectType = GetType(LinkedObjectAsCard.Contact)
			' 
			' CardView2
			' 
			Me.CardView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colPhone1})
			Me.CardView2.FocusedCardTopFieldIndex = 0
			Me.CardView2.GridControl = Me.GridControl1
			Me.CardView2.Name = "CardView2"
			Me.CardView2.OptionsView.ShowCardCaption = False
			Me.CardView2.OptionsView.ShowHorzScrollBar = False
			Me.CardView2.OptionsView.ShowQuickCustomizeButton = False
			Me.CardView2.ViewCaption = "More info..."
			' 
			' colPhone1
			' 
			Me.colPhone1.Caption = "Phone"
			Me.colPhone1.FieldName = "Phone"
			Me.colPhone1.Name = "colPhone1"
			Me.colPhone1.Visible = True
			Me.colPhone1.VisibleIndex = 0
			' 
			' GridView1
			' 
			Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colFullName})
			Me.GridView1.GridControl = Me.GridControl1
			Me.GridView1.Name = "GridView1"
			Me.GridView1.OptionsDetail.AllowZoomDetail = False
			' 
			' colFullName
			' 
			Me.colFullName.Caption = "FullName"
			Me.colFullName.FieldName = "FullName"
			Me.colFullName.Name = "colFullName"
			Me.colFullName.Visible = True
			Me.colFullName.VisibleIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(528, 258)
			Me.Controls.Add(Me.GridControl1)
			Me.Name = "Form1"
			Me.Text = "How to display a linked object (one-to-one relation) as a detail card view in the" & " XtraGrid"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.colContacts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CardView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

	#End Region

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			CreateDefaultContacts()
		End Sub

		Public Sub CreateDefaultContacts()
			If colContacts.Count = 0 Then
				Dim cont As Contact = Nothing
				Dim addr As Address = Nothing

				cont = New Contact("Maria Anders", "030-0074321")
				addr = New Address("Obere Str. 57", "12209", "Germany")
				cont.Address = addr
				'addr.Save()
				cont.Save()

				cont = New Contact("Antonio Moreno", "(5) 555-3932")
				addr = New Address("Mataderos  2312", "05023", "Mexico")
				cont.Address = addr
				'addr.Save()
				cont.Save()

				colContacts.Reload()
			End If
		End Sub

		<STAThread> _
		Shared Sub Main()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub

	End Class

End Namespace 'end of root namespace