using System;
using System.Collections.Generic;
using System.ComponentModel;
using SourceGrid.Cells;
using SourceGrid.Cells.DataGrid;
using SourceGrid.Conditions;

namespace SourceGrid
{
	// Token: 0x0200040E RID: 1038
	internal class DataGridColumn : global::SourceGrid.ColumnInfo
	{
		// Token: 0x06002D6E RID: 11630 RVA: 0x00098DF4 File Offset: 0x00096FF4
		public DataGridColumn(global::SourceGrid.DataGrid grid) : base(grid)
		{
			this.mHeaderCell = new global::SourceGrid.Cells.DataGrid.ColumnHeader(string.Empty);
			this.mDataCell = new global::SourceGrid.Cells.DataGrid.Cell();
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x00098E30 File Offset: 0x00097030
		public DataGridColumn(global::SourceGrid.DataGrid grid, global::SourceGrid.Cells.ICellVirtual headerCell, global::SourceGrid.Cells.ICellVirtual dataCell, string propertyName) : base(grid)
		{
			this.mPropertyName = propertyName;
			this.mHeaderCell = headerCell;
			this.mDataCell = dataCell;
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x00098E68 File Offset: 0x00097068
		public static global::SourceGrid.DataGridColumn CreateRowHeader(global::SourceGrid.DataGrid grid)
		{
			return new global::SourceGrid.DataGridColumn(grid, new global::SourceGrid.Cells.DataGrid.Header(), new global::SourceGrid.Cells.DataGrid.RowHeader(), null);
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06002D71 RID: 11633 RVA: 0x00098E7C File Offset: 0x0009707C
		public new global::SourceGrid.DataGrid Grid
		{
			get
			{
				return (global::SourceGrid.DataGrid)base.Grid;
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06002D72 RID: 11634 RVA: 0x00098E8C File Offset: 0x0009708C
		// (set) Token: 0x06002D73 RID: 11635 RVA: 0x00098E94 File Offset: 0x00097094
		public string PropertyName
		{
			get
			{
				return this.mPropertyName;
			}
			set
			{
				this.mPropertyName = value;
				this.mPropertyColumn = null;
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06002D74 RID: 11636 RVA: 0x00098EA4 File Offset: 0x000970A4
		public global::System.ComponentModel.PropertyDescriptor PropertyColumn
		{
			get
			{
				if (this.mPropertyColumn == null && this.Grid.DataSource != null)
				{
					this.mPropertyColumn = this.Grid.DataSource.GetItemProperty(this.PropertyName, global::System.StringComparison.InvariantCultureIgnoreCase);
				}
				return this.mPropertyColumn;
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06002D75 RID: 11637 RVA: 0x00098EF4 File Offset: 0x000970F4
		// (set) Token: 0x06002D76 RID: 11638 RVA: 0x00098EFC File Offset: 0x000970FC
		public global::SourceGrid.Cells.ICellVirtual HeaderCell
		{
			get
			{
				return this.mHeaderCell;
			}
			set
			{
				this.mHeaderCell = value;
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06002D77 RID: 11639 RVA: 0x00098F08 File Offset: 0x00097108
		// (set) Token: 0x06002D78 RID: 11640 RVA: 0x00098F10 File Offset: 0x00097110
		public global::SourceGrid.Cells.ICellVirtual DataCell
		{
			get
			{
				return this.mDataCell;
			}
			set
			{
				this.mDataCell = value;
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06002D79 RID: 11641 RVA: 0x00098F1C File Offset: 0x0009711C
		public global::System.Collections.Generic.List<global::SourceGrid.Conditions.ICondition> Conditions
		{
			get
			{
				return this.mConditions;
			}
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x00098F24 File Offset: 0x00097124
		public virtual global::SourceGrid.Cells.ICellVirtual GetDataCell(int gridRow)
		{
			object itemRow = this.Grid.Rows.IndexToDataSourceRow(gridRow);
			foreach (global::SourceGrid.Conditions.ICondition condition in this.Conditions)
			{
				if (condition.Evaluate(this, gridRow, itemRow))
				{
					global::SourceGrid.Cells.ICellVirtual cellVirtual;
					if (!this.mConditionalCells.TryGetValue(condition, out cellVirtual))
					{
						cellVirtual = condition.ApplyCondition(this.DataCell);
						this.mConditionalCells.Add(condition, cellVirtual);
					}
					return cellVirtual;
				}
			}
			return this.DataCell;
		}

		// Token: 0x04000F5F RID: 3935
		private string mPropertyName;

		// Token: 0x04000F60 RID: 3936
		private global::System.ComponentModel.PropertyDescriptor mPropertyColumn;

		// Token: 0x04000F61 RID: 3937
		private global::SourceGrid.Cells.ICellVirtual mHeaderCell;

		// Token: 0x04000F62 RID: 3938
		private global::SourceGrid.Cells.ICellVirtual mDataCell;

		// Token: 0x04000F63 RID: 3939
		private global::System.Collections.Generic.List<global::SourceGrid.Conditions.ICondition> mConditions = new global::System.Collections.Generic.List<global::SourceGrid.Conditions.ICondition>();

		// Token: 0x04000F64 RID: 3940
		private global::System.Collections.Generic.Dictionary<global::SourceGrid.Conditions.ICondition, global::SourceGrid.Cells.ICellVirtual> mConditionalCells = new global::System.Collections.Generic.Dictionary<global::SourceGrid.Conditions.ICondition, global::SourceGrid.Cells.ICellVirtual>();
	}
}
