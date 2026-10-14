using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001EC RID: 492
	public class SumSummaryCalculator : global::Infragistics.Windows.DataPresenter.SummaryCalculator
	{
		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x00086D83 File Offset: 0x00084F83
		public override string Description
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.SumSummaryCalculator.SR_DESCRIPTION);
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x00086D8F File Offset: 0x00084F8F
		public override string DisplayName
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.SumSummaryCalculator.SR_DISPLAY_NAME);
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x00086D9B File Offset: 0x00084F9B
		public override string Name
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.SumSummaryCalculator.NAME;
			}
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x00086DA4 File Offset: 0x00084FA4
		public override void Aggregate(object dataValue, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record)
		{
			decimal d;
			if (global::Infragistics.Windows.DataPresenter.SummaryCalculator.ToDecimal(dataValue, out d, summaryResult, record))
			{
				this._sum += d;
			}
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x00086DCF File Offset: 0x00084FCF
		public override void BeginCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			this._sum = 0m;
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x00086DE0 File Offset: 0x00084FE0
		public override bool CanProcessDataType(global::System.Type dataType)
		{
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(dataType);
			return global::Infragistics.Windows.Utilities.IsNumericType(underlyingType);
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x00086DFA File Offset: 0x00084FFA
		public override object EndCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			return this._sum;
		}

		// Token: 0x04000CEC RID: 3308
		internal static readonly string NAME = "Sum";

		// Token: 0x04000CED RID: 3309
		internal static readonly string SR_DISPLAY_NAME = "SummaryCalculator_Sum_Name";

		// Token: 0x04000CEE RID: 3310
		internal static readonly string SR_DESCRIPTION = "SummaryCalculator_Sum_Description";

		// Token: 0x04000CEF RID: 3311
		internal static readonly string RES_IMAGE = "SummaryCalculator_Sum_Image";

		// Token: 0x04000CF0 RID: 3312
		private decimal _sum;
	}
}
