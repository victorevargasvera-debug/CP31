using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200008A RID: 138
	internal interface ICellValueProvider
	{
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060006A6 RID: 1702
		int RecordCount { get; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060006A7 RID: 1703
		int FieldCount { get; }

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060006A8 RID: 1704
		global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout { get; }

		// Token: 0x060006A9 RID: 1705
		global::Infragistics.Windows.DataPresenter.Cell GetCell(int recordIndex, int fieldIndex);

		// Token: 0x060006AA RID: 1706
		global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(int recordIndex, int fieldIndex);

		// Token: 0x060006AB RID: 1707
		global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(global::Infragistics.Windows.DataPresenter.Cell cell);

		// Token: 0x060006AC RID: 1708
		global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(global::Infragistics.Windows.DataPresenter.CellKey cellKey);

		// Token: 0x060006AD RID: 1709
		global::Infragistics.Windows.DataPresenter.Field GetField(int fieldIndex);

		// Token: 0x060006AE RID: 1710
		global::Infragistics.Windows.DataPresenter.DataRecord GetRecord(int recordIndex);

		// Token: 0x060006AF RID: 1711
		global::Infragistics.Windows.DataPresenter.ICellValueProvider GetCurrentCellValues(bool useConvertedValues);

		// Token: 0x060006B0 RID: 1712
		void CopyTo(global::System.Array array, int arrayIndex);

		// Token: 0x060006B1 RID: 1713
		global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.CellValueHolder> GetValueEnumerator();

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060006B2 RID: 1714
		int ValueCount { get; }

		// Token: 0x060006B3 RID: 1715
		void ReplaceRecord(int recordIndex, global::Infragistics.Windows.DataPresenter.DataRecord newRecord);

		// Token: 0x060006B4 RID: 1716
		void SetValue(int recordIndex, int fieldIndex, global::Infragistics.Windows.DataPresenter.CellValueHolder newValue);
	}
}
