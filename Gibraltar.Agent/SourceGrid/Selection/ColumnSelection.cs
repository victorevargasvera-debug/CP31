using System;
using System.Collections.Generic;
using SourceGrid.Decorators;

namespace SourceGrid.Selection
{
	// Token: 0x02000336 RID: 822
	internal class ColumnSelection : global::SourceGrid.Selection.SelectionBase
	{
		// Token: 0x060026C5 RID: 9925 RVA: 0x00086554 File Offset: 0x00084754
		public override void BindToGrid(global::SourceGrid.GridVirtual p_grid)
		{
			base.BindToGrid(p_grid);
			this.mDecorator = new global::SourceGrid.Decorators.DecoratorSelection(this);
			base.Grid.Decorators.Add(this.mDecorator);
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x00086590 File Offset: 0x00084790
		public override void UnBindToGrid()
		{
			base.Grid.Decorators.Remove(this.mDecorator);
			base.UnBindToGrid();
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x000865B0 File Offset: 0x000847B0
		public override bool IsSelectedColumn(int column)
		{
			return this.mList.Contains(column);
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x000865C0 File Offset: 0x000847C0
		public override void SelectColumn(int column, bool select)
		{
			if (select && !this.mList.Contains(column))
			{
				this.mList.Add(column);
				this.OnSelectionChanged(new global::SourceGrid.RangeRegionChangedEventArgs(base.Grid.Columns.GetRange(column), global::SourceGrid.Range.Empty));
				return;
			}
			if (!select && this.mList.Contains(column))
			{
				this.mList.Remove(column);
				this.OnSelectionChanged(new global::SourceGrid.RangeRegionChangedEventArgs(global::SourceGrid.Range.Empty, base.Grid.Columns.GetRange(column)));
			}
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x0008665C File Offset: 0x0008485C
		public override bool IsSelectedRow(int row)
		{
			return false;
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x00086660 File Offset: 0x00084860
		public override void SelectRow(int row, bool select)
		{
			throw new global::System.Exception("The method or operation is not implemented.");
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x0008666C File Offset: 0x0008486C
		public override bool IsSelectedCell(global::SourceGrid.Position position)
		{
			return this.IsSelectedColumn(position.Column);
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x0008667C File Offset: 0x0008487C
		public override void SelectCell(global::SourceGrid.Position position, bool select)
		{
			this.SelectColumn(position.Column, select);
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x0008668C File Offset: 0x0008488C
		public override bool IsSelectedRange(global::SourceGrid.Range range)
		{
			for (int i = range.Start.Column; i <= range.End.Column; i++)
			{
				if (!this.IsSelectedColumn(i))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x000866D8 File Offset: 0x000848D8
		public override void SelectRange(global::SourceGrid.Range range, bool select)
		{
			for (int i = range.Start.Column; i <= range.End.Column; i++)
			{
				this.SelectColumn(i, select);
			}
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x0008671C File Offset: 0x0008491C
		protected override void OnResetSelection()
		{
			global::SourceGrid.RangeRegion selectionRegion = this.GetSelectionRegion();
			this.mList.Clear();
			this.OnSelectionChanged(new global::SourceGrid.RangeRegionChangedEventArgs(null, selectionRegion));
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x0008674C File Offset: 0x0008494C
		public override bool IsEmpty()
		{
			return this.mList.Count == 0;
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x0008675C File Offset: 0x0008495C
		public override global::SourceGrid.RangeRegion GetSelectionRegion()
		{
			global::SourceGrid.RangeRegion rangeRegion = new global::SourceGrid.RangeRegion();
			if (base.Grid.Rows.Count > 0)
			{
				foreach (int num in this.mList)
				{
					rangeRegion.Add(base.ValidateRange(new global::SourceGrid.Range(base.Grid.FixedRows, num, base.Grid.Rows.Count - 1, num)));
				}
			}
			return rangeRegion;
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x000867FC File Offset: 0x000849FC
		public override bool IntersectsWith(global::SourceGrid.Range rng)
		{
			for (int i = rng.Start.Column; i <= rng.End.Column; i++)
			{
				if (this.IsSelectedColumn(i))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000DA9 RID: 3497
		private global::SourceGrid.Decorators.DecoratorSelection mDecorator;

		// Token: 0x04000DAA RID: 3498
		private global::System.Collections.Generic.List<int> mList = new global::System.Collections.Generic.List<int>();
	}
}
