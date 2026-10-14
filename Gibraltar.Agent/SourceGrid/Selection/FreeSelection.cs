using System;
using SourceGrid.Decorators;

namespace SourceGrid.Selection
{
	// Token: 0x020003BA RID: 954
	internal class FreeSelection : global::SourceGrid.Selection.SelectionBase
	{
		// Token: 0x06002BAA RID: 11178 RVA: 0x00092A2C File Offset: 0x00090C2C
		public FreeSelection()
		{
			this.mRegion.Changed += delegate(object sender, global::SourceGrid.RangeRegionChangedEventArgs e)
			{
				this.OnSelectionChanged(e);
			};
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x00092A70 File Offset: 0x00090C70
		public override void BindToGrid(global::SourceGrid.GridVirtual p_grid)
		{
			base.BindToGrid(p_grid);
			this.mDecorator = new global::SourceGrid.Decorators.DecoratorSelection(this);
			base.Grid.Decorators.Add(this.mDecorator);
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x00092AAC File Offset: 0x00090CAC
		public override void UnBindToGrid()
		{
			base.Grid.Decorators.Remove(this.mDecorator);
			base.UnBindToGrid();
		}

		// Token: 0x06002BAD RID: 11181 RVA: 0x00092ACC File Offset: 0x00090CCC
		public override bool IsSelectedColumn(int column)
		{
			return this.mRegion.ContainsColumn(column);
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x00092ADC File Offset: 0x00090CDC
		public override void SelectColumn(int column, bool select)
		{
			global::SourceGrid.Range range = base.Grid.Columns.GetRange(column);
			this.SelectRange(range, select);
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x00092B08 File Offset: 0x00090D08
		public override bool IsSelectedRow(int row)
		{
			return this.mRegion.ContainsRow(row);
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x00092B18 File Offset: 0x00090D18
		public override void SelectRow(int row, bool select)
		{
			global::SourceGrid.Range range = base.Grid.Rows.GetRange(row);
			this.SelectRange(range, select);
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x00092B44 File Offset: 0x00090D44
		public override bool IsSelectedCell(global::SourceGrid.Position position)
		{
			return this.mRegion.Contains(position);
		}

		// Token: 0x06002BB2 RID: 11186 RVA: 0x00092B54 File Offset: 0x00090D54
		public override void SelectCell(global::SourceGrid.Position position, bool select)
		{
			this.SelectRange(base.Grid.PositionToCellRange(position), select);
		}

		// Token: 0x06002BB3 RID: 11187 RVA: 0x00092B6C File Offset: 0x00090D6C
		public override bool IsSelectedRange(global::SourceGrid.Range range)
		{
			return this.mRegion.Contains(range);
		}

		// Token: 0x06002BB4 RID: 11188 RVA: 0x00092B7C File Offset: 0x00090D7C
		public override void SelectRange(global::SourceGrid.Range range, bool select)
		{
			if (select)
			{
				this.mRegion.Add(base.ValidateRange(range));
				return;
			}
			this.mRegion.Remove(range);
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x00092BA8 File Offset: 0x00090DA8
		protected override void OnResetSelection()
		{
			this.mRegion.Clear();
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x00092BB8 File Offset: 0x00090DB8
		public override bool IsEmpty()
		{
			return this.mRegion.IsEmpty();
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x00092BC8 File Offset: 0x00090DC8
		public override global::SourceGrid.RangeRegion GetSelectionRegion()
		{
			return new global::SourceGrid.RangeRegion(this.mRegion);
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x00092BD8 File Offset: 0x00090DD8
		public override bool IntersectsWith(global::SourceGrid.Range rng)
		{
			return this.mRegion.IntersectsWith(rng);
		}

		// Token: 0x04000EA2 RID: 3746
		private global::SourceGrid.RangeRegion mRegion = new global::SourceGrid.RangeRegion();

		// Token: 0x04000EA3 RID: 3747
		private global::SourceGrid.Decorators.DecoratorSelection mDecorator;
	}
}
