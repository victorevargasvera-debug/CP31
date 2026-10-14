using System;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001F1 RID: 497
	public class SpecialRecordOrder : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x00087AFC File Offset: 0x00085CFC
		// (set) Token: 0x06001EF2 RID: 7922 RVA: 0x00087B04 File Offset: 0x00085D04
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

		// Token: 0x06001EF3 RID: 7923 RVA: 0x00087B21 File Offset: 0x00085D21
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAddRecord()
		{
			return -1 != this._addRecordOrder;
		}

		// Token: 0x06001EF4 RID: 7924 RVA: 0x00087B2F File Offset: 0x00085D2F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAddRecord()
		{
			this.AddRecord = -1;
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x00087B38 File Offset: 0x00085D38
		// (set) Token: 0x06001EF6 RID: 7926 RVA: 0x00087B40 File Offset: 0x00085D40
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

		// Token: 0x06001EF7 RID: 7927 RVA: 0x00087B5D File Offset: 0x00085D5D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeFilterRecord()
		{
			return -1 != this._filterRecordOrder;
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x00087B6B File Offset: 0x00085D6B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetFilterRecord()
		{
			this.FilterRecord = -1;
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x00087B74 File Offset: 0x00085D74
		// (set) Token: 0x06001EFA RID: 7930 RVA: 0x00087B7C File Offset: 0x00085D7C
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

		// Token: 0x06001EFB RID: 7931 RVA: 0x00087B99 File Offset: 0x00085D99
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeSummaryRecord()
		{
			return -1 != this._summaryRecordOrder;
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00087BA7 File Offset: 0x00085DA7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetSummaryRecord()
		{
			this.SummaryRecord = -1;
		}

		// Token: 0x04000D09 RID: 3337
		private const int DEFAULT_ORDER_VALUE = -1;

		// Token: 0x04000D0A RID: 3338
		private int _addRecordOrder;

		// Token: 0x04000D0B RID: 3339
		private int _summaryRecordOrder;

		// Token: 0x04000D0C RID: 3340
		private int _filterRecordOrder;
	}
}
