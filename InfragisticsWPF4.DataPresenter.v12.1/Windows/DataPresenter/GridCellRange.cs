using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200007B RID: 123
	internal class GridCellRange : global::Infragistics.Windows.DataPresenter.CellRange
	{
		// Token: 0x06000604 RID: 1540 RVA: 0x00017E2A File Offset: 0x0001602A
		internal GridCellRange(global::Infragistics.Windows.DataPresenter.Cell[] cells, global::Infragistics.Windows.DataPresenter.Field[] fields) : this(cells, fields.Length)
		{
			this._fields = fields;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00017E3D File Offset: 0x0001603D
		internal GridCellRange(global::Infragistics.Windows.DataPresenter.Cell[] cells, int fieldCount)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(cells);
			this._fieldCount = fieldCount;
			this._recordCount = cells.Length / fieldCount;
			this._cells = cells;
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x00017E64 File Offset: 0x00016064
		internal global::Infragistics.Windows.DataPresenter.Cell[] Cells
		{
			get
			{
				return this._cells;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00017E6C File Offset: 0x0001606C
		public override int RecordCount
		{
			get
			{
				return this._recordCount;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x00017E74 File Offset: 0x00016074
		public override int FieldCount
		{
			get
			{
				return this._fieldCount;
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00017E7C File Offset: 0x0001607C
		public override bool Exists(int recordIndex, int fieldIndex)
		{
			return recordIndex >= 0 && recordIndex < this._recordCount && fieldIndex >= 0 && fieldIndex < this._fieldCount && this.GetCell(recordIndex, fieldIndex) != null;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00017EA8 File Offset: 0x000160A8
		public override global::Infragistics.Windows.DataPresenter.Cell GetCell(int recordIndex, int fieldIndex)
		{
			return this._cells[recordIndex * this._fieldCount + fieldIndex];
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00017EBC File Offset: 0x000160BC
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

		// Token: 0x0600060C RID: 1548 RVA: 0x00017F0C File Offset: 0x0001610C
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

		// Token: 0x0600060D RID: 1549 RVA: 0x00017F48 File Offset: 0x00016148
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

		// Token: 0x0600060E RID: 1550 RVA: 0x00017F98 File Offset: 0x00016198
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

		// Token: 0x0600060F RID: 1551 RVA: 0x00017FD8 File Offset: 0x000161D8
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
					this._cells[i] = newRecord.Cells[this.GetField(i % fieldCount)];
				}
				i++;
			}
		}

		// Token: 0x040001D0 RID: 464
		private global::Infragistics.Windows.DataPresenter.Cell[] _cells;

		// Token: 0x040001D1 RID: 465
		private int _fieldCount;

		// Token: 0x040001D2 RID: 466
		private int _recordCount;

		// Token: 0x040001D3 RID: 467
		private global::Infragistics.Windows.DataPresenter.Field[] _fields;

		// Token: 0x040001D4 RID: 468
		private global::Infragistics.Windows.DataPresenter.DataRecord[] _records;
	}
}
