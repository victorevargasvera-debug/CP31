using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000090 RID: 144
	internal interface ICellValueProvider
	{
		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600072A RID: 1834
		int RecordCount { get; }

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600072B RID: 1835
		int FieldCount { get; }

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600072C RID: 1836
		global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout { get; }

		// Token: 0x0600072D RID: 1837
		global::Infragistics.Windows.DataPresenter.Cell GetCell(int recordIndex, int fieldIndex);

		// Token: 0x0600072E RID: 1838
		global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(int recordIndex, int fieldIndex);

		// Token: 0x0600072F RID: 1839
		global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(global::Infragistics.Windows.DataPresenter.Cell cell);

		// Token: 0x06000730 RID: 1840
		global::Infragistics.Windows.DataPresenter.CellValueHolder GetValue(global::Infragistics.Windows.DataPresenter.CellKey cellKey);

		// Token: 0x06000731 RID: 1841
		global::Infragistics.Windows.DataPresenter.Field GetField(int fieldIndex);

		// Token: 0x06000732 RID: 1842
		global::Infragistics.Windows.DataPresenter.Field GetFieldForRecord(int fieldIndex, int recordIndex);

		// Token: 0x06000733 RID: 1843
		global::Infragistics.Windows.DataPresenter.DataRecord GetRecord(int recordIndex);

		// Token: 0x06000734 RID: 1844
		global::Infragistics.Windows.DataPresenter.ICellValueProvider GetCurrentCellValues(bool useConvertedValues);

		// Token: 0x06000735 RID: 1845
		void CopyTo(global::System.Array array, int arrayIndex);

		// Token: 0x06000736 RID: 1846
		global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.CellValueHolder> GetValueEnumerator();

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000737 RID: 1847
		int ValueCount { get; }

		// Token: 0x06000738 RID: 1848
		void ReplaceRecord(int recordIndex, global::Infragistics.Windows.DataPresenter.DataRecord newRecord);

		// Token: 0x06000739 RID: 1849
		void SetValue(int recordIndex, int fieldIndex, global::Infragistics.Windows.DataPresenter.CellValueHolder newValue);
	}
}
