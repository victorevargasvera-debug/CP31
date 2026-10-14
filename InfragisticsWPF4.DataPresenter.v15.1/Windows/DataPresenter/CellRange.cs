using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200007F RID: 127
	internal abstract class CellRange
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000676 RID: 1654
		public abstract int RecordCount { get; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000677 RID: 1655
		public abstract int FieldCount { get; }

		// Token: 0x06000678 RID: 1656
		public abstract bool Exists(int recordIndex, int fieldIndex);

		// Token: 0x06000679 RID: 1657
		public abstract global::Infragistics.Windows.DataPresenter.Cell GetCell(int recordIndex, int fieldIndex);

		// Token: 0x0600067A RID: 1658
		public abstract global::Infragistics.Windows.DataPresenter.Field GetField(int fieldIndex);

		// Token: 0x0600067B RID: 1659
		public abstract global::Infragistics.Windows.DataPresenter.DataRecord GetRecord(int recordIndex);

		// Token: 0x0600067C RID: 1660 RVA: 0x0001A340 File Offset: 0x00018540
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

		// Token: 0x0600067D RID: 1661
		protected internal abstract void SetRecord(int recordIndex, global::Infragistics.Windows.DataPresenter.DataRecord newRecord);
	}
}
