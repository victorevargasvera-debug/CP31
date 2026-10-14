using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000080 RID: 128
	internal class GridCellRange : global::Infragistics.Windows.DataPresenter.CellRange
	{
		// Token: 0x0600067F RID: 1663 RVA: 0x0001A37A File Offset: 0x0001857A
		internal GridCellRange(global::Infragistics.Windows.DataPresenter.Cell[] cells, global::Infragistics.Windows.DataPresenter.Field[] fields) : this(cells, fields.Length)
		{
			this._fields = fields;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0001A38D File Offset: 0x0001858D
		private GridCellRange(global::Infragistics.Windows.DataPresenter.Cell[] cells, int fieldCount)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(cells);
			this._fieldCount = fieldCount;
			this._recordCount = cells.Length / fieldCount;
			this._cells = cells;
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x0001A3B4 File Offset: 0x000185B4
		internal global::Infragistics.Windows.DataPresenter.Cell[] Cells
		{
			get
			{
				return this._cells;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x0001A3BC File Offset: 0x000185BC
		public override int RecordCount
		{
			get
			{
				return this._recordCount;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0001A3C4 File Offset: 0x000185C4
		public override int FieldCount
		{
			get
			{
				return this._fieldCount;
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0001A3CC File Offset: 0x000185CC
		public override bool Exists(int recordIndex, int fieldIndex)
		{
			return recordIndex >= 0 && recordIndex < this._recordCount && fieldIndex >= 0 && fieldIndex < this._fieldCount && this.GetCell(recordIndex, fieldIndex) != null;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0001A3F8 File Offset: 0x000185F8
		public override global::Infragistics.Windows.DataPresenter.Cell GetCell(int recordIndex, int fieldIndex)
		{
			return this._cells[recordIndex * this._fieldCount + fieldIndex];
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001A40C File Offset: 0x0001860C
		public override global::Infragistics.Windows.DataPresenter.Field GetField(int fieldIndex)
		{
			if (this._fields == null)
			{
				this._fields = new global::Infragistics.Windows.DataPresenter.Field[this._fieldCount];
				for (int i = 0; i < this._fieldCount; i++)
				{
					this._fields[i] = this.GetFieldHelper(i);
				}
			}
			return this._fields[fieldIndex];
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0001A45C File Offset: 0x0001865C
		private global::Infragistics.Windows.DataPresenter.Field GetFieldHelper(int fieldIndex)
		{
			for (int i = 0; i < this._recordCount; i++)
			{
				global::Infragistics.Windows.DataPresenter.Cell cell = this._cells[i * this._fieldCount + fieldIndex];
				if (cell != null)
				{
					return cell.Field;
				}
			}
			return null;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0001A498 File Offset: 0x00018698
		public override global::Infragistics.Windows.DataPresenter.DataRecord GetRecord(int recordIndex)
		{
			if (this._records == null)
			{
				this._records = new global::Infragistics.Windows.DataPresenter.DataRecord[this._recordCount];
				for (int i = 0; i < this._recordCount; i++)
				{
					this._records[i] = this.GetRecordHelper(i);
				}
			}
			return this._records[recordIndex];
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0001A4E8 File Offset: 0x000186E8
		private global::Infragistics.Windows.DataPresenter.DataRecord GetRecordHelper(int recordIndex)
		{
			int i = recordIndex * this._fieldCount;
			int num = i + this._fieldCount;
			while (i < num)
			{
				global::Infragistics.Windows.DataPresenter.Cell cell = this._cells[i];
				if (cell != null)
				{
					return cell.Record;
				}
				i++;
			}
			return null;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0001A528 File Offset: 0x00018728
		protected internal override void SetRecord(int recordIndex, global::Infragistics.Windows.DataPresenter.DataRecord newRecord)
		{
			if (this._records != null)
			{
				this._records[recordIndex] = newRecord;
			}
			int fieldCount = this._fieldCount;
			int i = recordIndex * fieldCount;
			int num = i + fieldCount;
			while (i < num)
			{
				global::Infragistics.Windows.DataPresenter.Cell cell = this._cells[i];
				if (cell != null)
				{
					global::Infragistics.Windows.DataPresenter.Field field = this.GetField(i % fieldCount);
					if (field.Owner != newRecord.FieldLayout && newRecord.DataPresenter.IsTreeView)
					{
						field = field.GetMappedFieldInTree(newRecord.FieldLayout);
					}
					this._cells[i] = newRecord.Cells[field];
				}
				i++;
			}
		}

		// Token: 0x0400020C RID: 524
		private global::Infragistics.Windows.DataPresenter.Cell[] _cells;

		// Token: 0x0400020D RID: 525
		private int _fieldCount;

		// Token: 0x0400020E RID: 526
		private int _recordCount;

		// Token: 0x0400020F RID: 527
		private global::Infragistics.Windows.DataPresenter.Field[] _fields;

		// Token: 0x04000210 RID: 528
		private global::Infragistics.Windows.DataPresenter.DataRecord[] _records;
	}
}
