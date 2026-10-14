using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001EA RID: 490
	public class MaximumSummaryCalculator : global::Infragistics.Windows.DataPresenter.SummaryCalculator
	{
		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x00086B7F File Offset: 0x00084D7F
		public override string Description
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.MaximumSummaryCalculator.SR_DESCRIPTION);
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x00086B8B File Offset: 0x00084D8B
		public override string DisplayName
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.MaximumSummaryCalculator.SR_DISPLAY_NAME);
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x00086B97 File Offset: 0x00084D97
		public override string Name
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.MaximumSummaryCalculator.NAME;
			}
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x00086B9E File Offset: 0x00084D9E
		public override void Aggregate(object dataValue, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.MinimumSummaryCalculator.AggregateMinMaxHelper(dataValue, summaryResult, record, false, ref this._max, ref this._firstTime);
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x00086BB5 File Offset: 0x00084DB5
		public override void BeginCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			this._max = null;
			this._firstTime = true;
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x00086BC8 File Offset: 0x00084DC8
		public override bool CanProcessDataType(global::System.Type dataType)
		{
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(dataType);
			return typeof(global::System.IComparable).IsAssignableFrom(underlyingType);
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00086BF1 File Offset: 0x00084DF1
		public override object EndCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			return this._max;
		}

		// Token: 0x04000CE0 RID: 3296
		internal static readonly string NAME = "Maximum";

		// Token: 0x04000CE1 RID: 3297
		internal static readonly string SR_DISPLAY_NAME = "SummaryCalculator_Maximum_Name";

		// Token: 0x04000CE2 RID: 3298
		internal static readonly string SR_DESCRIPTION = "SummaryCalculator_Maximum_Description";

		// Token: 0x04000CE3 RID: 3299
		internal static readonly string RES_IMAGE = "SummaryCalculator_Maximum_Image";

		// Token: 0x04000CE4 RID: 3300
		private bool _firstTime;

		// Token: 0x04000CE5 RID: 3301
		private object _max;
	}
}
