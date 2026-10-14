using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000081 RID: 129
	internal class RecordCellRange : global::Infragistics.Windows.DataPresenter.CellRange
	{
		// Token: 0x0600068B RID: 1675 RVA: 0x0001A5B6 File Offset: 0x000187B6
		internal RecordCellRange(global::Infragistics.Windows.DataPresenter.DataRecord[] records, global::Infragistics.Windows.DataPresenter.Field[] fields)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(records);
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(fields);
			this._records = records;
			this._fields = fields;
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x0001A5D8 File Offset: 0x000187D8
		internal global::Infragistics.Windows.DataPresenter.Field[] Fields
		{
			get
			{
				return this._fields;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x0001A5E0 File Offset: 0x000187E0
		internal global::Infragistics.Windows.DataPresenter.DataRecord[] Records
		{
			get
			{
				return this._records;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x0001A5E8 File Offset: 0x000187E8
		public override int RecordCount
		{
			get
			{
				return this._records.Length;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x0001A5F2 File Offset: 0x000187F2
		public override int FieldCount
		{
			get
			{
				return this._fields.Length;
			}
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0001A5FC File Offset: 0x000187FC
		public override bool Exists(int recordIndex, int fieldIndex)
		{
			return recordIndex >= 0 && recordIndex < this.RecordCount && fieldIndex >= 0 && fieldIndex < this.FieldCount;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0001A61C File Offset: 0x0001881C
		public override global::Infragistics.Windows.DataPresenter.Cell GetCell(int recordIndex, int fieldIndex)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._records[recordIndex];
			global::Infragistics.Windows.DataPresenter.Field field = this._fields[fieldIndex];
			return dataRecord.Cells[field];
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0001A647 File Offset: 0x00018847
		public override global::Infragistics.Windows.DataPresenter.Field GetField(int fieldIndex)
		{
			return this._fields[fieldIndex];
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0001A651 File Offset: 0x00018851
		public override global::Infragistics.Windows.DataPresenter.DataRecord GetRecord(int recordIndex)
		{
			return this._records[recordIndex];
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0001A65B File Offset: 0x0001885B
		protected internal override void SetRecord(int recordIndex, global::Infragistics.Windows.DataPresenter.DataRecord newRecord)
		{
			this._records[recordIndex] = newRecord;
		}

		// Token: 0x04000211 RID: 529
		private global::Infragistics.Windows.DataPresenter.DataRecord[] _records;

		// Token: 0x04000212 RID: 530
		private global::Infragistics.Windows.DataPresenter.Field[] _fields;
	}
}
