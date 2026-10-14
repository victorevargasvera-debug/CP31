using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001E8 RID: 488
	public class AverageSummaryCalculator : global::Infragistics.Windows.DataPresenter.SummaryCalculator
	{
		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001E69 RID: 7785 RVA: 0x00086A0C File Offset: 0x00084C0C
		public override string Description
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.AverageSummaryCalculator.SR_DESCRIPTION);
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x00086A18 File Offset: 0x00084C18
		public override string DisplayName
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.AverageSummaryCalculator.SR_DISPLAY_NAME);
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001E6B RID: 7787 RVA: 0x00086A24 File Offset: 0x00084C24
		public override string Name
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.AverageSummaryCalculator.NAME;
			}
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00086A2C File Offset: 0x00084C2C
		public override void Aggregate(object dataValue, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record)
		{
			decimal d;
			if (global::Infragistics.Windows.DataPresenter.SummaryCalculator.ToDecimal(dataValue, out d, summaryResult, record))
			{
				this._sum += d;
				this._count++;
			}
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00086A65 File Offset: 0x00084C65
		public override void BeginCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			this._sum = 0m;
			this._count = 0;
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00086A7C File Offset: 0x00084C7C
		public override bool CanProcessDataType(global::System.Type dataType)
		{
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(dataType);
			return global::Infragistics.Windows.Utilities.IsNumericType(underlyingType);
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x00086A98 File Offset: 0x00084C98
		public override object EndCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			decimal num = (this._count > 0) ? (this._sum / this._count) : 0m;
			return num;
		}

		// Token: 0x04000CD5 RID: 3285
		internal static readonly string NAME = "Average";

		// Token: 0x04000CD6 RID: 3286
		internal static readonly string SR_DISPLAY_NAME = "SummaryCalculator_Average_Name";

		// Token: 0x04000CD7 RID: 3287
		internal static readonly string SR_DESCRIPTION = "SummaryCalculator_Average_Description";

		// Token: 0x04000CD8 RID: 3288
		internal static readonly string RES_IMAGE = "SummaryCalculator_Average_Image";

		// Token: 0x04000CD9 RID: 3289
		private int _count;

		// Token: 0x04000CDA RID: 3290
		private decimal _sum;
	}
}
