using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000272 RID: 626
	public class ChildBandRowsManager : global::Infragistics.Controls.Grids.RowsManagerBase
	{
		// Token: 0x060014CD RID: 5325 RVA: 0x0004C7BC File Offset: 0x0004A9BC
		public ChildBandRowsManager(global::Infragistics.Controls.Grids.Row parentRow) : base(parentRow.ColumnLayout)
		{
			this.ParentRow = parentRow;
			this.Level = parentRow.Manager.Level + 1;
			object data = parentRow.Data;
			this._childLayoutRows = new global::Infragistics.Controls.Grids.Primitives.ChildBandCollection();
			this._rows = new global::Infragistics.Controls.Grids.Primitives.RowBaseCollection(this._childLayoutRows);
			if (data != null)
			{
				foreach (global::Infragistics.Controls.Grids.ColumnLayout layout in base.ColumnLayout.Columns.ColumnLayouts)
				{
					this.AddChildBand(layout);
				}
				this._childLayoutRows.Sort(new global::Infragistics.Controls.Grids.ChildBandComparer());
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x0004C870 File Offset: 0x0004AA70
		public global::Infragistics.Controls.Grids.Primitives.ChildBandColumn Column
		{
			get
			{
				if (this._column == null)
				{
					this._column = new global::Infragistics.Controls.Grids.Primitives.ChildBandColumn();
				}
				return this._column;
			}
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x0004C88C File Offset: 0x0004AA8C
		private void AddChildBand(global::Infragistics.Controls.Grids.ColumnLayout layout)
		{
			layout.Grid = base.ColumnLayout.Grid;
			global::Infragistics.Controls.Grids.Primitives.ChildBand childBand = new global::Infragistics.Controls.Grids.Primitives.ChildBand(this, layout, (global::Infragistics.Controls.Grids.Row)this.ParentRow);
			this._childLayoutRows.Add(childBand);
			childBand.ColumnLayout.RegisterChildBandRowsManager(this);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x0004C8D8 File Offset: 0x0004AAD8
		internal void InvalidateManager()
		{
			if (this.ParentRow != null)
			{
				bool flag = false;
				foreach (object obj in this.Rows)
				{
					global::Infragistics.Controls.Grids.Primitives.ChildBand childBand = (global::Infragistics.Controls.Grids.Primitives.ChildBand)obj;
					if (childBand.ResolveIsVisible)
					{
						flag = true;
						break;
					}
				}
				for (int i = base.VisibleChildManagers.Count - 1; i >= 0; i--)
				{
					global::Infragistics.Controls.Grids.RowsManagerBase rowsManagerBase = base.VisibleChildManagers[i];
					if (rowsManagerBase.ColumnLayout == null || rowsManagerBase.ColumnLayout.Visibility == global::System.Windows.Visibility.Collapsed)
					{
						base.UnregisterChildRowsManager(rowsManagerBase);
					}
				}
				if (base.VisibleChildManagers.Count == 0 && !flag)
				{
					this.ParentRow.Manager.UnregisterChildRowsManager(this);
				}
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x0004C9B0 File Offset: 0x0004ABB0
		public override global::Infragistics.Controls.Grids.Primitives.RowBaseCollection Rows
		{
			get
			{
				return this._rows;
			}
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x0004C9B8 File Offset: 0x0004ABB8
		protected override int CompareTo(global::Infragistics.Controls.Grids.RowsManagerBase other)
		{
			return this.ParentRow.Index.CompareTo(other.ParentRow.Index);
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0004C9E4 File Offset: 0x0004ABE4
		protected internal override double ResolveIndentation(global::Infragistics.Controls.Grids.RowBase row)
		{
			double result = 0.0;
			if (((global::Infragistics.Controls.Grids.Primitives.ChildBand)row).ResolveIsVisible)
			{
				result = base.ResolveIndentation(row);
			}
			else if (this.ParentRow != null)
			{
				result = this.ParentRow.Manager.ResolveIndentation(this.ParentRow);
			}
			return result;
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0004CA34 File Offset: 0x0004AC34
		protected internal override void UnregisterRowsManager(bool removeColumnLayout, bool clearChildRowsManager, bool clearSelection)
		{
			if (clearChildRowsManager)
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.ChildBand> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.ChildBand>(this._childLayoutRows);
				foreach (global::Infragistics.Controls.Grids.Primitives.ChildBand childBand in list)
				{
					if (childBand.Manager == this)
					{
						childBand.ChildRowsManager.UnregisterRowsManager(removeColumnLayout, clearChildRowsManager, clearSelection);
						this._disposed = true;
						this._childLayoutRows.Remove(childBand);
						childBand.Unregister();
					}
				}
			}
			base.UnregisterRowsManager(removeColumnLayout, clearChildRowsManager, clearSelection);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0004CAC4 File Offset: 0x0004ACC4
		protected override void OnRegisteredAsVisibleChildManager()
		{
			foreach (global::Infragistics.Controls.Grids.Primitives.ChildBand childBand in this._childLayoutRows)
			{
				if (childBand.ResolveIsVisible)
				{
					if (childBand.IsExpanded)
					{
						base.RegisterChildRowsManager(childBand.ChildRowsManager);
					}
				}
				else if (childBand.ColumnLayout.Visibility == global::System.Windows.Visibility.Visible)
				{
					base.RegisterChildRowsManager(childBand.ChildRowsManager);
				}
			}
			base.OnRegisteredAsVisibleChildManager();
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0004CB48 File Offset: 0x0004AD48
		protected override void OnUnregisteredAsVisibleChildManager()
		{
			foreach (global::Infragistics.Controls.Grids.Primitives.ChildBand childBand in this._childLayoutRows)
			{
				if (!childBand.ResolveIsVisible)
				{
					base.UnregisterChildRowsManager(childBand.ChildRowsManager);
				}
			}
			base.OnUnregisteredAsVisibleChildManager();
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x0004CBA8 File Offset: 0x0004ADA8
		protected internal override int FullRowCount
		{
			get
			{
				int num = 0;
				foreach (global::Infragistics.Controls.Grids.Primitives.ChildBand childBand in this._childLayoutRows)
				{
					if (childBand.ResolveIsVisible)
					{
						num++;
					}
				}
				return num;
			}
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x0004CC00 File Offset: 0x0004AE00
		protected internal override global::Infragistics.Controls.Grids.RowBase ResolveRowForIndex(int index)
		{
			int num = 0;
			global::Infragistics.Controls.Grids.RowBase result = null;
			foreach (global::Infragistics.Controls.Grids.Primitives.ChildBand childBand in this._childLayoutRows)
			{
				if (childBand.ResolveIsVisible)
				{
					if (num == index)
					{
						result = childBand;
						break;
					}
					num++;
				}
			}
			return result;
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0004CC60 File Offset: 0x0004AE60
		protected internal override int ResolveIndexForRow(global::Infragistics.Controls.Grids.RowBase row)
		{
			int num = 0;
			foreach (global::Infragistics.Controls.Grids.Primitives.ChildBand childBand in this._childLayoutRows)
			{
				if (childBand.ResolveIsVisible)
				{
					if (row == childBand)
					{
						return num;
					}
					num++;
				}
				else if (row == childBand)
				{
					break;
				}
			}
			return num - 1;
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x0004CCC8 File Offset: 0x0004AEC8
		protected override void OnChildColumnLayoutRemoved(global::Infragistics.Controls.Grids.ColumnLayout layout)
		{
			global::Infragistics.Controls.Grids.Primitives.ChildBand childBand = this._childLayoutRows[layout.Key];
			if (childBand != null)
			{
				if (childBand.ColumnLayout != null)
				{
					childBand.ColumnLayout.UnregisterChildBandRowsManager(this);
				}
				this._childLayoutRows.Remove(childBand);
				childBand.Unregister();
			}
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0004CD14 File Offset: 0x0004AF14
		protected override void OnChildColumnLayoutAdded(global::Infragistics.Controls.Grids.ColumnLayout layout)
		{
			if (this._childLayoutRows[layout.Key] == null)
			{
				this.AddChildBand(layout);
			}
			else
			{
				this._childLayoutRows.Sort(new global::Infragistics.Controls.Grids.ChildBandComparer());
				base.SortVisibleChildManagers();
			}
			if (!layout.IsMoving)
			{
				((global::Infragistics.Controls.Grids.RowsManager)this.ParentRow.Manager).ClearRows();
			}
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x0004CD74 File Offset: 0x0004AF74
		internal void ChildColumnLayout_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (!this._disposed && e.PropertyName == "ColumnLayoutHeaderVisibility")
			{
				global::Infragistics.Controls.Grids.Row row = (global::Infragistics.Controls.Grids.Row)this.ParentRow;
				if (row.IsExpanded)
				{
					foreach (global::Infragistics.Controls.Grids.Primitives.ChildBand childBand in this._childLayoutRows)
					{
						base.UnregisterChildRowsManager(childBand.ChildRowsManager);
					}
					this.OnRegisteredAsVisibleChildManager();
				}
			}
		}

		// Token: 0x04000655 RID: 1621
		private readonly global::Infragistics.Controls.Grids.Primitives.RowBaseCollection _rows;

		// Token: 0x04000656 RID: 1622
		private readonly global::Infragistics.Controls.Grids.Primitives.ChildBandCollection _childLayoutRows;

		// Token: 0x04000657 RID: 1623
		private global::Infragistics.Controls.Grids.Primitives.ChildBandColumn _column;

		// Token: 0x04000658 RID: 1624
		private bool _disposed;
	}
}
