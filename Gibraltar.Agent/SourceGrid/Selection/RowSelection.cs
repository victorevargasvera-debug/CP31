using System;
using System.Collections.Generic;
using SourceGrid.Decorators;

namespace SourceGrid.Selection
{
	// Token: 0x020003E2 RID: 994
	internal class RowSelection : global::SourceGrid.Selection.SelectionBase
	{
		// Token: 0x06002C5F RID: 11359 RVA: 0x000950F0 File Offset: 0x000932F0
		public override void BindToGrid(global::SourceGrid.GridVirtual p_grid)
		{
			base.BindToGrid(p_grid);
			this.mDecorator = new global::SourceGrid.Decorators.DecoratorSelection(this);
			base.Grid.Decorators.Add(this.mDecorator);
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x0009512C File Offset: 0x0009332C
		public override void UnBindToGrid()
		{
			base.Grid.Decorators.Remove(this.mDecorator);
			base.UnBindToGrid();
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x0009514C File Offset: 0x0009334C
		public override bool IsSelectedColumn(int column)
		{
			return false;
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x00095150 File Offset: 0x00093350
		public override void SelectColumn(int column, bool select)
		{
			throw new global::System.Exception("The method or operation is not implemented.");
		}

		// Token: 0x06002C63 RID: 11363 RVA: 0x0009515C File Offset: 0x0009335C
		public override bool IsSelectedRow(int row)
		{
			return this.mList.Contains(row);
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x0009516C File Offset: 0x0009336C
		public override void SelectRow(int row, bool select)
		{
			if (select && !this.mList.Contains(row))
			{
				this.mList.Add(row);
				this.OnSelectionChanged(new global::SourceGrid.RangeRegionChangedEventArgs(base.Grid.Rows.GetRange(row), global::SourceGrid.Range.Empty));
				return;
			}
			if (!select && this.mList.Contains(row))
			{
				this.mList.Remove(row);
				this.OnSelectionChanged(new global::SourceGrid.RangeRegionChangedEventArgs(global::SourceGrid.Range.Empty, base.Grid.Rows.GetRange(row)));
			}
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x00095208 File Offset: 0x00093408
		public override bool IsSelectedCell(global::SourceGrid.Position position)
		{
			return this.IsSelectedRow(position.Row);
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x00095218 File Offset: 0x00093418
		public override void SelectCell(global::SourceGrid.Position position, bool select)
		{
			this.SelectRow(position.Row, select);
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x00095228 File Offset: 0x00093428
		public override bool IsSelectedRange(global::SourceGrid.Range range)
		{
			for (int i = range.Start.Row; i <= range.End.Row; i++)
			{
				if (!this.IsSelectedRow(i))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002C68 RID: 11368 RVA: 0x00095274 File Offset: 0x00093474
		public override void SelectRange(global::SourceGrid.Range range, bool select)
		{
			for (int i = range.Start.Row; i <= range.End.Row; i++)
			{
				this.SelectRow(i, select);
			}
		}

		// Token: 0x06002C69 RID: 11369 RVA: 0x000952B8 File Offset: 0x000934B8
		protected override void OnResetSelection()
		{
			global::SourceGrid.RangeRegion selectionRegion = this.GetSelectionRegion();
			this.mList.Clear();
			this.OnSelectionChanged(new global::SourceGrid.RangeRegionChangedEventArgs(null, selectionRegion));
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x000952E8 File Offset: 0x000934E8
		public override bool IsEmpty()
		{
			return this.mList.Count == 0;
		}

		// Token: 0x06002C6B RID: 11371 RVA: 0x000952F8 File Offset: 0x000934F8
		public override global::SourceGrid.RangeRegion GetSelectionRegion()
		{
			global::SourceGrid.RangeRegion rangeRegion = new global::SourceGrid.RangeRegion();
			if (base.Grid.Columns.Count > 0)
			{
				this.mList.Sort();
				foreach (int num in this.mList)
				{
					rangeRegion.Add(base.ValidateRange(new global::SourceGrid.Range(num, 0, num, base.Grid.Columns.Count - 1)));
				}
			}
			return rangeRegion;
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x0009539C File Offset: 0x0009359C
		public override bool IntersectsWith(global::SourceGrid.Range rng)
		{
			for (int i = rng.Start.Row; i <= rng.End.Row; i++)
			{
				if (this.IsSelectedRow(i))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000F16 RID: 3862
		private global::SourceGrid.Decorators.DecoratorSelection mDecorator;

		// Token: 0x04000F17 RID: 3863
		private global::System.Collections.Generic.List<int> mList = new global::System.Collections.Generic.List<int>();
	}
}
