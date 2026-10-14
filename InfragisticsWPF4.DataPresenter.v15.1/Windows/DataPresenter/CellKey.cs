using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200007E RID: 126
	internal struct CellKey : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.CellKey>
	{
		// Token: 0x0600066C RID: 1644 RVA: 0x0001A270 File Offset: 0x00018470
		internal CellKey(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._record = record;
			this._field = field;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0001A280 File Offset: 0x00018480
		internal CellKey(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			this = new global::Infragistics.Windows.DataPresenter.CellKey(cell.Record, cell.Field);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0001A294 File Offset: 0x00018494
		public override int GetHashCode()
		{
			return this._field.GetHashCode() ^ this._record.GetHashCode();
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0001A2AD File Offset: 0x000184AD
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.DataPresenter.CellKey && this.Equals((global::Infragistics.Windows.DataPresenter.CellKey)obj);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0001A2C5 File Offset: 0x000184C5
		public override string ToString()
		{
			return string.Format("Field={0}, Record={1}", this._field, this._record);
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x0001A2DD File Offset: 0x000184DD
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._record.Cells[this._field];
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x0001A2F5 File Offset: 0x000184F5
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x0001A2FD File Offset: 0x000184FD
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0001A305 File Offset: 0x00018505
		internal bool Equals(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this._record == record && this._field == field;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0001A31B File Offset: 0x0001851B
		public bool Equals(global::Infragistics.Windows.DataPresenter.CellKey other)
		{
			return other._field == this._field && other._record == this._record;
		}

		// Token: 0x0400020A RID: 522
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x0400020B RID: 523
		private global::Infragistics.Windows.DataPresenter.Field _field;
	}
}
