using System;
using Infragistics.Collections;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001DC RID: 476
	internal class InternalRowsCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Grids.RowBase>
	{
		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x0002C756 File Offset: 0x0002A956
		// (set) Token: 0x06000C9F RID: 3231 RVA: 0x0002C75E File Offset: 0x0002A95E
		public global::Infragistics.Controls.Grids.RowsManager RootRowsManager { get; set; }

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0002C768 File Offset: 0x0002A968
		private int RecursiveGetCount(global::Infragistics.Controls.Grids.RowsManagerBase manager)
		{
			int num = manager.FullRowCount;
			foreach (global::Infragistics.Controls.Grids.RowsManagerBase manager2 in manager.VisibleChildManagers)
			{
				num += this.RecursiveGetCount(manager2);
			}
			return num;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0002C7C0 File Offset: 0x0002A9C0
		private static int GetOffsetIndex(global::Infragistics.Controls.Grids.RowsManagerBase manager)
		{
			int num = 0;
			while (manager.ParentRow != null)
			{
				num += manager.ParentRow.Manager.ResolveIndexForRow(manager.ParentRow) + 1;
				manager = manager.ParentRow.Manager;
			}
			return num;
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0002C804 File Offset: 0x0002AA04
		private global::Infragistics.Controls.Grids.RowBase GetRowForIndex(int index, global::Infragistics.Controls.Grids.RowsManagerBase currentManager, int currentOffset, int additionalOffset)
		{
			int num = 0;
			foreach (global::Infragistics.Controls.Grids.RowsManagerBase rowsManagerBase in currentManager.VisibleChildManagers)
			{
				int num2 = global::Infragistics.Controls.Grids.Primitives.InternalRowsCollection.GetOffsetIndex(rowsManagerBase) + num + additionalOffset;
				if (index < num2)
				{
					return currentManager.ResolveRowForIndex(index - currentOffset - num);
				}
				int num3 = this.RecursiveGetCount(rowsManagerBase);
				if (index >= num2 && index < num2 + num3)
				{
					return this.GetRowForIndex(index, rowsManagerBase, num2, num + additionalOffset);
				}
				num += num3;
			}
			return currentManager.ResolveRowForIndex(index - currentOffset - num);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0002C8A8 File Offset: 0x0002AAA8
		private bool GetIndexOfRow(global::Infragistics.Controls.Grids.RowsManagerBase currentManager, global::Infragistics.Controls.Grids.RowBase row, ref int index)
		{
			if (currentManager != row.Manager)
			{
				foreach (global::Infragistics.Controls.Grids.RowsManagerBase rowsManagerBase in currentManager.VisibleChildManagers)
				{
					if (this.GetIndexOfRow(rowsManagerBase, row, ref index))
					{
						return true;
					}
					if (rowsManagerBase is global::Infragistics.Controls.Grids.ChildBandRowsManager)
					{
						index += rowsManagerBase.FullRowCount;
					}
					if (rowsManagerBase is global::Infragistics.Controls.Grids.RowsManager)
					{
						index += rowsManagerBase.FullRowCount;
					}
				}
				return false;
			}
			global::Infragistics.Controls.Grids.RowsManager rowsManager = row.Manager as global::Infragistics.Controls.Grids.RowsManager;
			if (rowsManager != null)
			{
				int num = rowsManager.ResolveIndexForRow(row);
				int num2 = num;
				foreach (global::Infragistics.Controls.Grids.RowsManagerBase rowsManagerBase2 in currentManager.VisibleChildManagers)
				{
					int num3 = rowsManager.ResolveIndexForRow(rowsManagerBase2.ParentRow);
					if (num > num3)
					{
						num2 += this.RecursiveGetCount(rowsManagerBase2);
					}
				}
				index += num2 + global::Infragistics.Controls.Grids.Primitives.InternalRowsCollection.GetOffsetIndex(currentManager);
				return true;
			}
			global::Infragistics.Controls.Grids.ChildBandRowsManager childBandRowsManager = row.Manager as global::Infragistics.Controls.Grids.ChildBandRowsManager;
			if (childBandRowsManager != null)
			{
				int num4 = childBandRowsManager.ResolveIndexForRow(row);
				int num5 = num4;
				foreach (global::Infragistics.Controls.Grids.RowsManagerBase rowsManagerBase3 in currentManager.VisibleChildManagers)
				{
					int num6 = childBandRowsManager.ResolveIndexForRow(rowsManagerBase3.ParentRow);
					if (num4 > num6)
					{
						num5 += this.RecursiveGetCount(rowsManagerBase3);
					}
				}
				index += num5 + global::Infragistics.Controls.Grids.Primitives.InternalRowsCollection.GetOffsetIndex(currentManager);
				return true;
			}
			return false;
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0002CA50 File Offset: 0x0002AC50
		protected override int GetCount()
		{
			return this.RecursiveGetCount(this.RootRowsManager);
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0002CA5E File Offset: 0x0002AC5E
		protected override global::Infragistics.Controls.Grids.RowBase GetItem(int index)
		{
			if (this.RootRowsManager.VisibleChildManagers.Count == 0)
			{
				return this.RootRowsManager.Rows[index];
			}
			return this.GetRowForIndex(index, this.RootRowsManager, 0, 0);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x0002CA94 File Offset: 0x0002AC94
		public override int IndexOf(global::Infragistics.Controls.Grids.RowBase item)
		{
			int result = 0;
			if (this.GetIndexOfRow(this.RootRowsManager, item, ref result))
			{
				return result;
			}
			return -1;
		}
	}
}
