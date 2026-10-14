using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200007C RID: 124
	internal class RecordCellRange : global::Infragistics.Windows.DataPresenter.CellRange
	{
		// Token: 0x06000610 RID: 1552 RVA: 0x00018037 File Offset: 0x00016237
		internal RecordCellRange(global::Infragistics.Windows.DataPresenter.DataRecord[] records, global::Infragistics.Windows.DataPresenter.Field[] fields)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(records);
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(fields);
			this._records = records;
			this._fields = fields;
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x00018059 File Offset: 0x00016259
		internal global::Infragistics.Windows.DataPresenter.Field[] Fields
		{
			get
			{
				return this._fields;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x00018061 File Offset: 0x00016261
		internal global::Infragistics.Windows.DataPresenter.DataRecord[] Records
		{
			get
			{
				return this._records;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00018069 File Offset: 0x00016269
		public override int RecordCount
		{
			get
			{
				return this._records.Length;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x00018073 File Offset: 0x00016273
		public override int FieldCount
		{
			get
			{
				return this._fields.Length;
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0001807D File Offset: 0x0001627D
		public override bool Exists(int recordIndex, int fieldIndex)
		{
			return recordIndex >= 0 && recordIndex < this.RecordCount && fieldIndex >= 0 && fieldIndex < this.FieldCount;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0001809C File Offset: 0x0001629C
		public override global::Infragistics.Windows.DataPresenter.Cell GetCell(int recordIndex, int fieldIndex)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._records[recordIndex];
			global::Infragistics.Windows.DataPresenter.Field field = this._fields[fieldIndex];
			return dataRecord.Cells[field];
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000180C7 File Offset: 0x000162C7
		public override global::Infragistics.Windows.DataPresenter.Field GetField(int fieldIndex)
		{
			return this._fields[fieldIndex];
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x000180D1 File Offset: 0x000162D1
		public override global::Infragistics.Windows.DataPresenter.DataRecord GetRecord(int recordIndex)
		{
			return this._records[recordIndex];
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x000180DB File Offset: 0x000162DB
		protected internal override void SetRecord(int recordIndex, global::Infragistics.Windows.DataPresenter.DataRecord newRecord)
		{
			this._records[recordIndex] = newRecord;
		}

		// Token: 0x040001D5 RID: 469
		private global::Infragistics.Windows.DataPresenter.DataRecord[] _records;

		// Token: 0x040001D6 RID: 470
		private global::Infragistics.Windows.DataPresenter.Field[] _fields;
	}
}
