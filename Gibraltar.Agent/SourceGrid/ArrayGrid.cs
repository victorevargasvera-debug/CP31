using System;
using System.ComponentModel;
using SourceGrid.Cells;
using SourceGrid.Cells.Editors;
using SourceGrid.Cells.Virtual;

namespace SourceGrid
{
	// Token: 0x0200040F RID: 1039
	[global::System.ComponentModel.ToolboxItem(true)]
	internal class ArrayGrid : global::SourceGrid.GridVirtual
	{
		// Token: 0x06002D7C RID: 11644 RVA: 0x00099000 File Offset: 0x00097200
		protected override global::SourceGrid.RowsBase CreateRowsObject()
		{
			return new global::SourceGrid.ArrayRows(this);
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x00099008 File Offset: 0x00097208
		protected override global::SourceGrid.ColumnsBase CreateColumnsObject()
		{
			return new global::SourceGrid.ArrayColumns(this);
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x00099010 File Offset: 0x00097210
		public override global::SourceGrid.Cells.ICellVirtual GetCell(int row, int column)
		{
			if (row < base.FixedRows && column < base.FixedColumns)
			{
				return this.mHeader;
			}
			if (row < base.FixedRows)
			{
				return this.mColumnHeader;
			}
			if (column < base.FixedColumns)
			{
				return this.mRowHeader;
			}
			return this.mValueCell;
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06002D7F RID: 11647 RVA: 0x0009906C File Offset: 0x0009726C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public new global::SourceGrid.ArrayRows Rows
		{
			get
			{
				return (global::SourceGrid.ArrayRows)base.Rows;
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06002D80 RID: 11648 RVA: 0x0009907C File Offset: 0x0009727C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public new global::SourceGrid.ArrayColumns Columns
		{
			get
			{
				return (global::SourceGrid.ArrayColumns)base.Columns;
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06002D81 RID: 11649 RVA: 0x0009908C File Offset: 0x0009728C
		// (set) Token: 0x06002D82 RID: 11650 RVA: 0x00099094 File Offset: 0x00097294
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Array DataSource
		{
			get
			{
				return this.mDataSource;
			}
			set
			{
				if (value != null && value.Rank != 2)
				{
					throw new global::SourceGrid.SourceGridException("Array dimension not valid, must be an array with 2 dimensions");
				}
				this.mDataSource = value;
				this.Bind();
			}
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x000990C0 File Offset: 0x000972C0
		protected virtual void Bind()
		{
			this.ValueCell = null;
			if (this.mDataSource != null)
			{
				this.mValueCell = new global::SourceGrid.Cells.Virtual.CellVirtual();
				this.mValueCell.Model.AddModel(new global::SourceGrid.ArrayValueModel());
				this.mValueCell.Editor = global::SourceGrid.Cells.Editors.Factory.Create(this.mDataSource.GetType().GetElementType());
			}
			this.Rows.RowsChanged();
			this.Columns.ColumnsChanged();
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06002D84 RID: 11652 RVA: 0x0009913C File Offset: 0x0009733C
		// (set) Token: 0x06002D85 RID: 11653 RVA: 0x00099144 File Offset: 0x00097344
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::SourceGrid.Cells.ICellVirtual ColumnHeader
		{
			get
			{
				return this.mColumnHeader;
			}
			set
			{
				this.mColumnHeader = value;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06002D86 RID: 11654 RVA: 0x00099150 File Offset: 0x00097350
		// (set) Token: 0x06002D87 RID: 11655 RVA: 0x00099158 File Offset: 0x00097358
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::SourceGrid.Cells.ICellVirtual RowHeader
		{
			get
			{
				return this.mRowHeader;
			}
			set
			{
				this.mRowHeader = value;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06002D88 RID: 11656 RVA: 0x00099164 File Offset: 0x00097364
		// (set) Token: 0x06002D89 RID: 11657 RVA: 0x0009916C File Offset: 0x0009736C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::SourceGrid.Cells.ICellVirtual Header
		{
			get
			{
				return this.mHeader;
			}
			set
			{
				this.mHeader = value;
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06002D8A RID: 11658 RVA: 0x00099178 File Offset: 0x00097378
		// (set) Token: 0x06002D8B RID: 11659 RVA: 0x00099180 File Offset: 0x00097380
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::SourceGrid.Cells.ICellVirtual ValueCell
		{
			get
			{
				return this.mValueCell;
			}
			set
			{
				this.mValueCell = value;
			}
		}

		// Token: 0x04000F65 RID: 3941
		private global::System.Array mDataSource;

		// Token: 0x04000F66 RID: 3942
		private global::SourceGrid.Cells.ICellVirtual mColumnHeader = new global::SourceGrid.ArrayColumnHeader();

		// Token: 0x04000F67 RID: 3943
		private global::SourceGrid.Cells.ICellVirtual mRowHeader = new global::SourceGrid.ArrayRowHeader();

		// Token: 0x04000F68 RID: 3944
		private global::SourceGrid.Cells.ICellVirtual mHeader = new global::SourceGrid.ArrayHeader();

		// Token: 0x04000F69 RID: 3945
		private global::SourceGrid.Cells.ICellVirtual mValueCell;
	}
}
