using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001C3 RID: 451
	public class MaximumSummaryCalculator : global::Infragistics.Windows.DataPresenter.SummaryCalculator
	{
		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001A6D RID: 6765 RVA: 0x00072F2F File Offset: 0x0007112F
		public override string Description
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.MaximumSummaryCalculator.SR_DESCRIPTION);
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x00072F3B File Offset: 0x0007113B
		public override string DisplayName
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.MaximumSummaryCalculator.SR_DISPLAY_NAME);
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x00072F47 File Offset: 0x00071147
		public override string Name
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.MaximumSummaryCalculator.NAME;
			}
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x00072F4E File Offset: 0x0007114E
		public override void Aggregate(object dataValue, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.MinimumSummaryCalculator.AggregateMinMaxHelper(dataValue, summaryResult, record, false, ref this._max, ref this._firstTime);
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x00072F65 File Offset: 0x00071165
		public override void BeginCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			this._max = null;
			this._firstTime = true;
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x00072F78 File Offset: 0x00071178
		public override bool CanProcessDataType(global::System.Type dataType)
		{
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(dataType);
			return typeof(global::System.IComparable).IsAssignableFrom(underlyingType);
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x00072FA1 File Offset: 0x000711A1
		public override object EndCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			return this._max;
		}

		// Token: 0x04000AF6 RID: 2806
		internal static readonly string NAME = "Maximum";

		// Token: 0x04000AF7 RID: 2807
		internal static readonly string SR_DISPLAY_NAME = "SummaryCalculator_Maximum_Name";

		// Token: 0x04000AF8 RID: 2808
		internal static readonly string SR_DESCRIPTION = "SummaryCalculator_Maximum_Description";

		// Token: 0x04000AF9 RID: 2809
		internal static readonly string RES_IMAGE = "SummaryCalculator_Maximum_Image";

		// Token: 0x04000AFA RID: 2810
		private bool _firstTime;

		// Token: 0x04000AFB RID: 2811
		private object _max;
	}
}
