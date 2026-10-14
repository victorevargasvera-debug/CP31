using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200007A RID: 122
	internal abstract class CellRange
	{
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060005FB RID: 1531
		public abstract int RecordCount { get; }

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060005FC RID: 1532
		public abstract int FieldCount { get; }

		// Token: 0x060005FD RID: 1533
		public abstract bool Exists(int recordIndex, int fieldIndex);

		// Token: 0x060005FE RID: 1534
		public abstract global::Infragistics.Windows.DataPresenter.Cell GetCell(int recordIndex, int fieldIndex);

		// Token: 0x060005FF RID: 1535
		public abstract global::Infragistics.Windows.DataPresenter.Field GetField(int fieldIndex);

		// Token: 0x06000600 RID: 1536
		public abstract global::Infragistics.Windows.DataPresenter.DataRecord GetRecord(int recordIndex);

		// Token: 0x06000601 RID: 1537 RVA: 0x00017DF0 File Offset: 0x00015FF0
		public global::Infragistics.Windows.DataPresenter.Field[] GetFields()
		{
			int fieldCount = this.FieldCount;
			global::Infragistics.Windows.DataPresenter.Field[] array = new global::Infragistics.Windows.DataPresenter.Field[fieldCount];
			for (int i = 0; i < fieldCount; i++)
			{
				array[i] = this.GetField(i);
			}
			return array;
		}

		// Token: 0x06000602 RID: 1538
		protected internal abstract void SetRecord(int recordIndex, global::Infragistics.Windows.DataPresenter.DataRecord newRecord);
	}
}
