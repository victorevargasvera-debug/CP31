using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000079 RID: 121
	internal struct CellKey : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.CellKey>
	{
		// Token: 0x060005F1 RID: 1521 RVA: 0x00017D20 File Offset: 0x00015F20
		internal CellKey(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._record = record;
			this._field = field;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00017D30 File Offset: 0x00015F30
		internal CellKey(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			this = new global::Infragistics.Windows.DataPresenter.CellKey(cell.Record, cell.Field);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00017D44 File Offset: 0x00015F44
		public override int GetHashCode()
		{
			return this._field.GetHashCode() ^ this._record.GetHashCode();
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00017D5D File Offset: 0x00015F5D
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.DataPresenter.CellKey && this.Equals((global::Infragistics.Windows.DataPresenter.CellKey)obj);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00017D75 File Offset: 0x00015F75
		public override string ToString()
		{
			return string.Format("Field={0}, Record={1}", this._field, this._record);
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x00017D8D File Offset: 0x00015F8D
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._record.Cells[this._field];
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00017DA5 File Offset: 0x00015FA5
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x00017DAD File Offset: 0x00015FAD
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00017DB5 File Offset: 0x00015FB5
		internal bool Equals(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this._record == record && this._field == field;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00017DCB File Offset: 0x00015FCB
		public bool Equals(global::Infragistics.Windows.DataPresenter.CellKey other)
		{
			return other._field == this._field && other._record == this._record;
		}

		// Token: 0x040001CE RID: 462
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x040001CF RID: 463
		private global::Infragistics.Windows.DataPresenter.Field _field;
	}
}
