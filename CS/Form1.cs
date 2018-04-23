using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LinkedObjectAsCard
{
	public class Form1 : System.Windows.Forms.Form
	{

	#region  Windows Form Designer generated code 

		public Form1() : base()
		{

			InitializeComponent();

		}

		//Form overrides dispose to clean up the component list.
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView GridView1;
		internal DevExpress.Xpo.XPCollection colContacts;
		internal DevExpress.XtraGrid.Columns.GridColumn colFullName;
		internal DevExpress.XtraGrid.Views.Card.CardView CardView1;
		internal DevExpress.XtraGrid.Columns.GridColumn colLine1;
		internal DevExpress.XtraGrid.Columns.GridColumn colZIP;
		internal DevExpress.XtraGrid.Columns.GridColumn colCountry;
		internal DevExpress.XtraGrid.Views.Card.CardView CardView2;
		internal DevExpress.XtraGrid.Columns.GridColumn colPhone1;
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.CardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colLine1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridControl1 = new DevExpress.XtraGrid.GridControl();
            this.colContacts = new DevExpress.Xpo.XPCollection();
            this.CardView2 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.colPhone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CardView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CardView1
            // 
            this.CardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLine1,
            this.colZIP,
            this.colCountry});
            this.CardView1.FocusedCardTopFieldIndex = 0;
            this.CardView1.GridControl = this.GridControl1;
            this.CardView1.Name = "CardView1";
            this.CardView1.OptionsView.ShowCardCaption = false;
            this.CardView1.OptionsView.ShowHorzScrollBar = false;
            this.CardView1.OptionsView.ShowQuickCustomizeButton = false;
            // 
            // colLine1
            // 
            this.colLine1.Caption = "Line1";
            this.colLine1.FieldName = "Line1";
            this.colLine1.Name = "colLine1";
            this.colLine1.Visible = true;
            this.colLine1.VisibleIndex = 0;
            // 
            // colZIP
            // 
            this.colZIP.Caption = "ZIP";
            this.colZIP.FieldName = "ZIP";
            this.colZIP.Name = "colZIP";
            this.colZIP.Visible = true;
            this.colZIP.VisibleIndex = 1;
            // 
            // colCountry
            // 
            this.colCountry.Caption = "Country";
            this.colCountry.FieldName = "Country";
            this.colCountry.Name = "colCountry";
            this.colCountry.Visible = true;
            this.colCountry.VisibleIndex = 2;
            // 
            // GridControl1
            // 
            this.GridControl1.DataSource = this.colContacts;
            this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.CardView1;
            gridLevelNode1.RelationName = "Address";
            gridLevelNode2.LevelTemplate = this.CardView2;
            gridLevelNode2.RelationName = "Itself";
            this.GridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.GridControl1.Location = new System.Drawing.Point(0, 0);
            this.GridControl1.MainView = this.GridView1;
            this.GridControl1.Name = "GridControl1";
            this.GridControl1.Size = new System.Drawing.Size(528, 258);
            this.GridControl1.TabIndex = 0;
            this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CardView2,
            this.GridView1,
            this.CardView1});
            // 
            // colContacts
            // 
            this.colContacts.DisplayableProperties = "This;IsDeleted;Oid;FullName;Phone;Address;Itself";
            this.colContacts.ObjectType = typeof(LinkedObjectAsCard.Contact);
            // 
            // CardView2
            // 
            this.CardView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPhone1});
            this.CardView2.FocusedCardTopFieldIndex = 0;
            this.CardView2.GridControl = this.GridControl1;
            this.CardView2.Name = "CardView2";
            this.CardView2.OptionsView.ShowCardCaption = false;
            this.CardView2.OptionsView.ShowHorzScrollBar = false;
            this.CardView2.OptionsView.ShowQuickCustomizeButton = false;
            this.CardView2.ViewCaption = "More info...";
            // 
            // colPhone1
            // 
            this.colPhone1.Caption = "Phone";
            this.colPhone1.FieldName = "Phone";
            this.colPhone1.Name = "colPhone1";
            this.colPhone1.Visible = true;
            this.colPhone1.VisibleIndex = 0;
            // 
            // GridView1
            // 
            this.GridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullName});
            this.GridView1.GridControl = this.GridControl1;
            this.GridView1.Name = "GridView1";
            this.GridView1.OptionsDetail.AllowZoomDetail = false;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "FullName";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(528, 258);
            this.Controls.Add(this.GridControl1);
            this.Name = "Form1";
            this.Text = "How to display a linked object (one-to-one relation) as a detail card view in the" +
                " XtraGrid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CardView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);

		}

	#endregion

		private void Form1_Load(object sender, System.EventArgs e)
		{
			CreateDefaultContacts();
		}

		public void CreateDefaultContacts()
		{
			if (colContacts.Count == 0)
			{
				Contact cont = null;
				Address addr = null;

				cont = new Contact("Maria Anders", "030-0074321");
				addr = new Address("Obere Str. 57", "12209", "Germany");
				cont.Address = addr;
				//addr.Save()
				cont.Save();

				cont = new Contact("Antonio Moreno", "(5) 555-3932");
				addr = new Address("Mataderos  2312", "05023", "Mexico");
				cont.Address = addr;
				//addr.Save()
				cont.Save();

				colContacts.Reload();
			}
		}

		[STAThread]
		static void Main()
		{
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}

	}

} //end of root namespace