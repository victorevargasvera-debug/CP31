using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Infragistics.Collections;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200023E RID: 574
	public class ColumnLayoutCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Grids.ColumnLayout>, global::Infragistics.IProvidePersistenceLookupKeys
	{
		// Token: 0x06001211 RID: 4625 RVA: 0x000436A6 File Offset: 0x000418A6
		internal ColumnLayoutCollection(global::Infragistics.Controls.Grids.XamGrid grid)
		{
			this._grid = grid;
			if (this._grid != null)
			{
				this._isInDesigner = global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this._grid);
			}
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x000436D0 File Offset: 0x000418D0
		public global::Infragistics.Controls.Grids.ColumnLayout FromType(global::System.Type type)
		{
			global::Infragistics.Controls.Grids.ColumnLayout result = null;
			if (type != null)
			{
				foreach (global::Infragistics.Controls.Grids.ColumnLayout columnLayout in this.Items)
				{
					string strA = columnLayout.TargetTypeName ?? string.Empty;
					if (string.Compare(strA, type.Name, global::System.StringComparison.OrdinalIgnoreCase) == 0 || string.Compare(strA, type.FullName, global::System.StringComparison.OrdinalIgnoreCase) == 0)
					{
						result = columnLayout;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x00043754 File Offset: 0x00041954
		public global::Infragistics.Controls.Grids.ColumnLayout FromKey(string key)
		{
			global::Infragistics.Controls.Grids.ColumnLayout result = null;
			foreach (global::Infragistics.Controls.Grids.ColumnLayout columnLayout in this.Items)
			{
				if (columnLayout.Key == key)
				{
					result = columnLayout;
					break;
				}
			}
			return result;
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x000437B0 File Offset: 0x000419B0
		protected internal void AddItemLocally(global::Infragistics.Controls.Grids.ColumnLayout item)
		{
			if (item != null)
			{
				item.IsDefinedGlobally = new bool?(false);
				this.AddItemSilently(base.Count, item);
			}
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x000437D0 File Offset: 0x000419D0
		protected virtual global::System.Collections.ObjectModel.Collection<string> GetLookupKeys()
		{
			global::System.Collections.ObjectModel.Collection<string> collection = new global::System.Collections.ObjectModel.Collection<string>();
			foreach (global::Infragistics.Controls.Grids.ColumnLayout columnLayout in this.Items)
			{
				collection.Add(columnLayout.Key);
			}
			return collection;
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0004382C File Offset: 0x00041A2C
		protected virtual bool CanRehydrate(global::System.Collections.ObjectModel.Collection<string> lookupKeys)
		{
			if (lookupKeys == null || lookupKeys.Count != this.Items.Count)
			{
				return false;
			}
			for (int i = 0; i < lookupKeys.Count; i++)
			{
				if (lookupKeys[i] != this.Items[i].Key)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00043884 File Offset: 0x00041A84
		internal global::Infragistics.Controls.Grids.ColumnLayout InternalFromType(global::System.Type type)
		{
			foreach (global::Infragistics.Controls.Grids.ColumnLayout columnLayout in this.Items)
			{
				string strA = columnLayout.TargetTypeName ?? string.Empty;
				if ((columnLayout.IsDefinedGloballyResolved && string.Compare(strA, type.Name, global::System.StringComparison.OrdinalIgnoreCase) == 0) || string.Compare(strA, type.FullName, global::System.StringComparison.OrdinalIgnoreCase) == 0)
				{
					return columnLayout;
				}
			}
			return null;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00043908 File Offset: 0x00041B08
		internal global::Infragistics.Controls.Grids.ColumnLayout InternalFromKey(string key)
		{
			global::Infragistics.Controls.Grids.ColumnLayout result = null;
			foreach (global::Infragistics.Controls.Grids.ColumnLayout columnLayout in this.Items)
			{
				if (columnLayout.IsDefinedGloballyResolved && columnLayout.Key == key)
				{
					result = columnLayout;
					break;
				}
			}
			return result;
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0004396C File Offset: 0x00041B6C
		protected override void OnItemAdded(int index, global::Infragistics.Controls.Grids.ColumnLayout item)
		{
			if (item != null)
			{
				if (!string.IsNullOrEmpty(item.Key))
				{
					if (item.IsDefinedGlobally == null)
					{
						item.IsDefinedGlobally = new bool?(true);
					}
				}
				else if (!this._isInDesigner)
				{
					throw new global::Infragistics.Controls.Grids.EmptyColumnKeyException();
				}
			}
			base.OnItemAdded(index, item);
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x000439C0 File Offset: 0x00041BC0
		protected override void AddItemSilently(int index, global::Infragistics.Controls.Grids.ColumnLayout item)
		{
			if (item != null && item.Key == "XamWebGrid_Root_XamWebGrid" && this._grid != null)
			{
				item.Grid = this._grid;
				if (this._grid.RowsManager != null)
				{
					this._grid.RowsManager.ColumnLayout = item;
				}
			}
			base.AddItemSilently(index, item);
		}

		// Token: 0x17000564 RID: 1380
		public global::Infragistics.Controls.Grids.ColumnLayout this[string key]
		{
			get
			{
				foreach (global::Infragistics.Controls.Grids.ColumnLayout columnLayout in this.Items)
				{
					if (columnLayout.Key == key)
					{
						return columnLayout;
					}
				}
				return null;
			}
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x00043A78 File Offset: 0x00041C78
		global::System.Collections.ObjectModel.Collection<string> global::Infragistics.IProvidePersistenceLookupKeys.GetLookupKeys()
		{
			return this.GetLookupKeys();
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00043A80 File Offset: 0x00041C80
		bool global::Infragistics.IProvidePersistenceLookupKeys.CanRehydrate(global::System.Collections.ObjectModel.Collection<string> lookupKeys)
		{
			return this.CanRehydrate(lookupKeys);
		}

		// Token: 0x040005AE RID: 1454
		private bool _isInDesigner;

		// Token: 0x040005AF RID: 1455
		private global::Infragistics.Controls.Grids.XamGrid _grid;
	}
}
