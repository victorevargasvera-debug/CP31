using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using DevAge.Windows.Forms;
using SourceGrid.Cells;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Editors;

namespace SourceGrid
{
	// Token: 0x020003F2 RID: 1010
	internal class ListEditor : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06002CCD RID: 11469 RVA: 0x000967F4 File Offset: 0x000949F4
		public ListEditor()
		{
			this.InitializeComponent();
			this.grid.Selection.FocusRowLeaving += this.Selection_FocusRowLeaving;
			this.grid.Selection.FocusRowEntered += this.Selection_FocusRowEntered;
			this.grid.Selection.FocusStyle = global::SourceGrid.FocusStyle.None;
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x0009685C File Offset: 0x00094A5C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x00096884 File Offset: 0x00094A84
		private void InitializeComponent()
		{
			global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(typeof(global::SourceGrid.ListEditor));
			this.grid = new global::SourceGrid.Grid();
			this.btDown = new global::System.Windows.Forms.Button();
			this.btUp = new global::System.Windows.Forms.Button();
			this.btRemove = new global::System.Windows.Forms.Button();
			this.btAdd = new global::System.Windows.Forms.Button();
			this.btrRefreshList = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.grid.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grid.AutoStretchColumnsToFitWidth = false;
			this.grid.AutoStretchRowsToFitHeight = false;
			this.grid.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.grid.CustomSort = false;
			this.grid.Location = new global::System.Drawing.Point(4, 32);
			this.grid.Name = "grid";
			this.grid.Size = new global::System.Drawing.Size(332, 216);
			this.grid.SpecialKeys = global::SourceGrid.GridSpecialKeys.Default;
			this.grid.TabIndex = 0;
			this.btDown.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btDown.Enabled = false;
			this.btDown.Image = (global::System.Drawing.Image)resourceManager.GetObject("btDown.Image");
			this.btDown.ImageAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btDown.Location = new global::System.Drawing.Point(312, 4);
			this.btDown.Name = "btDown";
			this.btDown.Size = new global::System.Drawing.Size(24, 23);
			this.btDown.TabIndex = 1;
			this.btDown.Click += this.btDown_Click;
			this.btUp.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btUp.Enabled = false;
			this.btUp.Image = (global::System.Drawing.Image)resourceManager.GetObject("btUp.Image");
			this.btUp.ImageAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btUp.Location = new global::System.Drawing.Point(284, 4);
			this.btUp.Name = "btUp";
			this.btUp.Size = new global::System.Drawing.Size(24, 23);
			this.btUp.TabIndex = 2;
			this.btUp.Click += this.btUp_Click;
			this.btRemove.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btRemove.Enabled = false;
			this.btRemove.Image = (global::System.Drawing.Image)resourceManager.GetObject("btRemove.Image");
			this.btRemove.ImageAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btRemove.Location = new global::System.Drawing.Point(220, 4);
			this.btRemove.Name = "btRemove";
			this.btRemove.Size = new global::System.Drawing.Size(24, 23);
			this.btRemove.TabIndex = 3;
			this.btRemove.Click += this.btRemove_Click;
			this.btAdd.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btAdd.Image = (global::System.Drawing.Image)resourceManager.GetObject("btAdd.Image");
			this.btAdd.ImageAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btAdd.Location = new global::System.Drawing.Point(192, 4);
			this.btAdd.Name = "btAdd";
			this.btAdd.Size = new global::System.Drawing.Size(24, 23);
			this.btAdd.TabIndex = 4;
			this.btAdd.Click += this.btAdd_Click;
			this.btrRefreshList.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btrRefreshList.Image = (global::System.Drawing.Image)resourceManager.GetObject("btrRefreshList.Image");
			this.btrRefreshList.ImageAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btrRefreshList.Location = new global::System.Drawing.Point(252, 4);
			this.btrRefreshList.Name = "btrRefreshList";
			this.btrRefreshList.Size = new global::System.Drawing.Size(24, 23);
			this.btrRefreshList.TabIndex = 5;
			this.btrRefreshList.Click += this.btrRefreshList_Click;
			base.Controls.Add(this.btrRefreshList);
			base.Controls.Add(this.btAdd);
			base.Controls.Add(this.btRemove);
			base.Controls.Add(this.btUp);
			base.Controls.Add(this.btDown);
			base.Controls.Add(this.grid);
			base.Name = "ListEditor";
			base.Size = new global::System.Drawing.Size(340, 252);
			base.ResumeLayout(false);
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06002CD0 RID: 11472 RVA: 0x00096D10 File Offset: 0x00094F10
		// (set) Token: 0x06002CD1 RID: 11473 RVA: 0x00096D18 File Offset: 0x00094F18
		public global::System.Collections.ArrayList List
		{
			get
			{
				return this.m_List;
			}
			set
			{
				this.m_List = value;
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06002CD2 RID: 11474 RVA: 0x00096D24 File Offset: 0x00094F24
		// (set) Token: 0x06002CD3 RID: 11475 RVA: 0x00096D2C File Offset: 0x00094F2C
		public global::System.Type ItemType
		{
			get
			{
				return this.m_ItemType;
			}
			set
			{
				this.m_ItemType = value;
				this.LoadEditors();
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06002CD4 RID: 11476 RVA: 0x00096D3C File Offset: 0x00094F3C
		// (set) Token: 0x06002CD5 RID: 11477 RVA: 0x00096D44 File Offset: 0x00094F44
		[global::System.ComponentModel.Browsable(false)]
		public global::SourceGrid.Cells.Editors.EditorBase[] Editors
		{
			get
			{
				return this.m_Editors;
			}
			set
			{
				this.m_Editors = value;
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06002CD6 RID: 11478 RVA: 0x00096D50 File Offset: 0x00094F50
		// (set) Token: 0x06002CD7 RID: 11479 RVA: 0x00096D58 File Offset: 0x00094F58
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Reflection.PropertyInfo[] Properties
		{
			get
			{
				return this.m_Properties;
			}
			set
			{
				this.m_Properties = value;
			}
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x00096D64 File Offset: 0x00094F64
		private void LoadEditors()
		{
			if (this.m_ItemType != null)
			{
				this.m_Properties = this.m_ItemType.GetProperties();
				global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
				for (int i = 0; i < this.m_Properties.Length; i++)
				{
					global::System.ComponentModel.AttributeCollection attributes = global::System.ComponentModel.TypeDescriptor.GetProperties(this.m_ItemType)[this.m_Properties[i].Name].Attributes;
					if (attributes[typeof(global::System.ComponentModel.BrowsableAttribute)].Equals(global::System.ComponentModel.BrowsableAttribute.Yes))
					{
						arrayList.Add(this.m_Properties[i]);
					}
				}
				this.m_Editors = new global::SourceGrid.Cells.Editors.EditorBase[arrayList.Count];
				this.m_Properties = new global::System.Reflection.PropertyInfo[arrayList.Count];
				for (int j = 0; j < arrayList.Count; j++)
				{
					global::System.Reflection.PropertyInfo propertyInfo = (global::System.Reflection.PropertyInfo)arrayList[j];
					this.m_Properties[j] = propertyInfo;
					this.m_Editors[j] = global::SourceGrid.Cells.Editors.Factory.Create(propertyInfo.PropertyType);
					if (this.m_Editors[j] != null)
					{
						this.m_Editors[j].EnableEdit = propertyInfo.CanWrite;
					}
				}
				return;
			}
			this.m_Editors = null;
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x00096EA4 File Offset: 0x000950A4
		public void LoadList()
		{
			if (this.m_ItemType == null)
			{
				throw new global::System.ApplicationException("ItemType is null");
			}
			if (this.m_List == null)
			{
				this.m_List = new global::System.Collections.ArrayList();
			}
			if (this.m_Properties.Length != this.m_Editors.Length)
			{
				throw new global::System.ApplicationException("Properteis.Length != Editors.Length");
			}
			this.grid.FixedRows = 1;
			this.grid.FixedColumns = 0;
			this.grid.Redim(this.m_List.Count + this.grid.FixedRows, this.m_Properties.Length + this.grid.FixedColumns);
			for (int i = 0; i < this.m_Properties.Length; i++)
			{
				global::SourceGrid.Cells.ColumnHeader columnHeader = new global::SourceGrid.Cells.ColumnHeader(this.m_Properties[i].Name);
				this.grid[0, i + this.grid.FixedColumns] = columnHeader;
				columnHeader.AutomaticSortEnabled = false;
			}
			for (int j = 0; j < this.m_List.Count; j++)
			{
				this.PopulateRow(j + this.grid.FixedRows, this.m_List[j]);
			}
			this.grid.AutoStretchColumnsToFitWidth = true;
			this.grid.AutoSizeCells();
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x00096FEC File Offset: 0x000951EC
		private void PopulateRow(int p_GridRow, object p_Object)
		{
			for (int i = 0; i < this.m_Properties.Length; i++)
			{
				this.PopulateCell(p_GridRow, i + this.grid.FixedColumns, this.m_Properties[i], this.m_Editors[i], p_Object);
			}
			this.grid.Rows[p_GridRow].Tag = p_Object;
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x00097058 File Offset: 0x00095258
		private void PopulateCell(int p_GridRow, int p_GridCol, global::System.Reflection.PropertyInfo p_PropInfo, global::SourceGrid.Cells.Editors.EditorBase p_Editor, object p_Object)
		{
			this.grid[p_GridRow, p_GridCol] = new global::SourceGrid.Cells.Cell(p_PropInfo.GetValue(p_Object, null));
			this.grid[p_GridRow, p_GridCol].Editor = p_Editor;
			global::SourceGrid.Cells.Controllers.BindProperty controller = new global::SourceGrid.Cells.Controllers.BindProperty(p_PropInfo, p_Object);
			this.grid[p_GridRow, p_GridCol].AddController(controller);
			global::SourceGrid.Cells.Controllers.CustomEvents customEvents = new global::SourceGrid.Cells.Controllers.CustomEvents();
			customEvents.ValueChanged += this.Grid_ValueChanged;
			this.grid[p_GridRow, p_GridCol].AddController(customEvents);
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x000970E0 File Offset: 0x000952E0
		private void btAdd_Click(object sender, global::System.EventArgs e)
		{
			try
			{
				int rowsCount = this.grid.RowsCount;
				this.grid.Rows.Insert(rowsCount);
				object obj = global::System.Activator.CreateInstance(this.m_ItemType);
				this.m_List.Add(obj);
				this.PopulateRow(rowsCount, obj);
				this.OnListChanged(global::System.EventArgs.Empty);
			}
			catch (global::System.Exception p_Exception)
			{
				global::DevAge.Windows.Forms.ErrorDialog.Show(this, p_Exception, "Error");
			}
		}

		// Token: 0x140000DD RID: 221
		// (add) Token: 0x06002CDD RID: 11485 RVA: 0x00097160 File Offset: 0x00095360
		// (remove) Token: 0x06002CDE RID: 11486 RVA: 0x0009717C File Offset: 0x0009537C
		public event global::System.EventHandler ListChanged;

		// Token: 0x06002CDF RID: 11487 RVA: 0x00097198 File Offset: 0x00095398
		protected virtual void OnListChanged(global::System.EventArgs e)
		{
			if (this.ListChanged != null)
			{
				this.ListChanged(this, e);
			}
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x000971B4 File Offset: 0x000953B4
		private void Grid_ValueChanged(object sender, global::System.EventArgs e)
		{
			this.OnListChanged(e);
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x000971C0 File Offset: 0x000953C0
		private void btRemove_Click(object sender, global::System.EventArgs e)
		{
			try
			{
				if (!this.grid.Selection.ActivePosition.IsEmpty() && this.grid.Selection.ActivePosition.Row >= this.grid.FixedRows)
				{
					this.m_List.Remove(this.grid.Rows[this.grid.Selection.ActivePosition.Row].Tag);
					this.grid.Rows.Remove(this.grid.Selection.ActivePosition.Row);
					this.OnListChanged(global::System.EventArgs.Empty);
				}
			}
			catch (global::System.Exception p_Exception)
			{
				global::DevAge.Windows.Forms.ErrorDialog.Show(this, p_Exception, "Error");
			}
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x000972A8 File Offset: 0x000954A8
		private void btrRefreshList_Click(object sender, global::System.EventArgs e)
		{
			try
			{
				this.LoadList();
			}
			catch (global::System.Exception p_Exception)
			{
				global::DevAge.Windows.Forms.ErrorDialog.Show(this, p_Exception, "Error");
			}
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x000972E4 File Offset: 0x000954E4
		private void btUp_Click(object sender, global::System.EventArgs e)
		{
			try
			{
				if (!this.grid.Selection.ActivePosition.IsEmpty() && this.grid.Selection.ActivePosition.Row >= this.grid.FixedRows)
				{
					object tag = this.grid.Rows[this.grid.Selection.ActivePosition.Row].Tag;
					int row = this.grid.Selection.ActivePosition.Row;
					int num = this.m_List.IndexOf(tag);
					this.m_List.Remove(tag);
					this.m_List.Insert(num - 1, tag);
					this.grid.Rows.Move(row, row - 1);
					this.grid.Selection.FocusRow(row - 1);
					this.OnListChanged(global::System.EventArgs.Empty);
				}
			}
			catch (global::System.Exception p_Exception)
			{
				global::DevAge.Windows.Forms.ErrorDialog.Show(this, p_Exception, "Error");
			}
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x00097408 File Offset: 0x00095608
		private void btDown_Click(object sender, global::System.EventArgs e)
		{
			try
			{
				if (!this.grid.Selection.ActivePosition.IsEmpty() && this.grid.Selection.ActivePosition.Row >= this.grid.FixedRows && this.grid.Selection.ActivePosition.Row < this.grid.Rows.Count - 1)
				{
					object tag = this.grid.Rows[this.grid.Selection.ActivePosition.Row].Tag;
					int row = this.grid.Selection.ActivePosition.Row;
					int num = this.m_List.IndexOf(tag);
					this.m_List.Remove(tag);
					this.m_List.Insert(num + 1, tag);
					this.grid.Rows.Move(row, row + 1);
					this.grid.Selection.FocusRow(row + 1);
					this.OnListChanged(global::System.EventArgs.Empty);
				}
			}
			catch (global::System.Exception p_Exception)
			{
				global::DevAge.Windows.Forms.ErrorDialog.Show(this, p_Exception, "Error");
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x0009756C File Offset: 0x0009576C
		// (set) Token: 0x06002CE6 RID: 11494 RVA: 0x0009757C File Offset: 0x0009577C
		public bool EnableAdd
		{
			get
			{
				return this.btAdd.Visible;
			}
			set
			{
				this.btAdd.Visible = value;
			}
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x0009758C File Offset: 0x0009578C
		// (set) Token: 0x06002CE8 RID: 11496 RVA: 0x0009759C File Offset: 0x0009579C
		public bool EnableRemove
		{
			get
			{
				return this.btRemove.Visible;
			}
			set
			{
				this.btRemove.Visible = value;
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x000975AC File Offset: 0x000957AC
		// (set) Token: 0x06002CEA RID: 11498 RVA: 0x000975BC File Offset: 0x000957BC
		public bool EnableRefresh
		{
			get
			{
				return this.btrRefreshList.Visible;
			}
			set
			{
				this.btrRefreshList.Visible = value;
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06002CEB RID: 11499 RVA: 0x000975CC File Offset: 0x000957CC
		// (set) Token: 0x06002CEC RID: 11500 RVA: 0x000975DC File Offset: 0x000957DC
		public bool EnableMove
		{
			get
			{
				return this.btUp.Visible;
			}
			set
			{
				this.btUp.Visible = value;
				this.btDown.Visible = value;
			}
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x000975F8 File Offset: 0x000957F8
		private void Selection_FocusRowLeaving(object sender, global::SourceGrid.RowCancelEventArgs e)
		{
			this.btDown.Enabled = false;
			this.btUp.Enabled = false;
			this.btRemove.Enabled = false;
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x00097620 File Offset: 0x00095820
		private void Selection_FocusRowEntered(object sender, global::SourceGrid.RowEventArgs e)
		{
			this.btDown.Enabled = true;
			this.btUp.Enabled = true;
			this.btRemove.Enabled = true;
		}

		// Token: 0x04000F34 RID: 3892
		private global::SourceGrid.Grid grid;

		// Token: 0x04000F35 RID: 3893
		private global::System.Windows.Forms.Button btDown;

		// Token: 0x04000F36 RID: 3894
		private global::System.Windows.Forms.Button btUp;

		// Token: 0x04000F37 RID: 3895
		private global::System.Windows.Forms.Button btRemove;

		// Token: 0x04000F38 RID: 3896
		private global::System.Windows.Forms.Button btAdd;

		// Token: 0x04000F39 RID: 3897
		private global::System.Windows.Forms.Button btrRefreshList;

		// Token: 0x04000F3A RID: 3898
		private global::System.ComponentModel.Container components;

		// Token: 0x04000F3B RID: 3899
		private global::System.Collections.ArrayList m_List;

		// Token: 0x04000F3C RID: 3900
		private global::System.Type m_ItemType;

		// Token: 0x04000F3D RID: 3901
		private global::SourceGrid.Cells.Editors.EditorBase[] m_Editors;

		// Token: 0x04000F3E RID: 3902
		private global::System.Reflection.PropertyInfo[] m_Properties;
	}
}
