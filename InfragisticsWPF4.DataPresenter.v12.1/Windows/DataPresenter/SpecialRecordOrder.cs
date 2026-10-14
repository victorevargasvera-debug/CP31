using System;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001CA RID: 458
	public class SpecialRecordOrder : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x00073DC0 File Offset: 0x00071FC0
		// (set) Token: 0x06001ADF RID: 6879 RVA: 0x00073DC8 File Offset: 0x00071FC8
		[global::System.ComponentModel.Bindable(true)]
		public int AddRecord
		{
			get
			{
				return this._addRecordOrder;
			}
			set
			{
				if (this._addRecordOrder != value)
				{
					this._addRecordOrder = value;
					base.RaisePropertyChangedEvent("AddRecord");
				}
			}
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00073DE5 File Offset: 0x00071FE5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAddRecord()
		{
			return -1 != this._addRecordOrder;
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00073DF3 File Offset: 0x00071FF3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAddRecord()
		{
			this.AddRecord = -1;
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x00073DFC File Offset: 0x00071FFC
		// (set) Token: 0x06001AE3 RID: 6883 RVA: 0x00073E04 File Offset: 0x00072004
		[global::System.ComponentModel.Bindable(true)]
		public int FilterRecord
		{
			get
			{
				return this._filterRecordOrder;
			}
			set
			{
				if (this._filterRecordOrder != value)
				{
					this._filterRecordOrder = value;
					base.RaisePropertyChangedEvent("FilterRecord");
				}
			}
		}

		// Token: 0x06001AE4 RID: 6884 RVA: 0x00073E21 File Offset: 0x00072021
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFilterRecord()
		{
			return -1 != this._filterRecordOrder;
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x00073E2F File Offset: 0x0007202F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetFilterRecord()
		{
			this.FilterRecord = -1;
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x00073E38 File Offset: 0x00072038
		// (set) Token: 0x06001AE7 RID: 6887 RVA: 0x00073E40 File Offset: 0x00072040
		[global::System.ComponentModel.Bindable(true)]
		public int SummaryRecord
		{
			get
			{
				return this._summaryRecordOrder;
			}
			set
			{
				if (this._summaryRecordOrder != value)
				{
					this._summaryRecordOrder = value;
					base.RaisePropertyChangedEvent("SummaryRecord");
				}
			}
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x00073E5D File Offset: 0x0007205D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSummaryRecord()
		{
			return -1 != this._summaryRecordOrder;
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x00073E6B File Offset: 0x0007206B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSummaryRecord()
		{
			this.SummaryRecord = -1;
		}

		// Token: 0x04000B1D RID: 2845
		private const int DEFAULT_ORDER_VALUE = -1;

		// Token: 0x04000B1E RID: 2846
		private int _addRecordOrder;

		// Token: 0x04000B1F RID: 2847
		private int _summaryRecordOrder;

		// Token: 0x04000B20 RID: 2848
		private int _filterRecordOrder;
	}
}
