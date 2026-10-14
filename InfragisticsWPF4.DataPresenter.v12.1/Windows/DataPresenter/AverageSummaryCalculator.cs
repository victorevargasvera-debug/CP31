using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001C1 RID: 449
	public class AverageSummaryCalculator : global::Infragistics.Windows.DataPresenter.SummaryCalculator
	{
		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001A5B RID: 6747 RVA: 0x00072DBC File Offset: 0x00070FBC
		public override string Description
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.AverageSummaryCalculator.SR_DESCRIPTION);
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x00072DC8 File Offset: 0x00070FC8
		public override string DisplayName
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.AverageSummaryCalculator.SR_DISPLAY_NAME);
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001A5D RID: 6749 RVA: 0x00072DD4 File Offset: 0x00070FD4
		public override string Name
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.AverageSummaryCalculator.NAME;
			}
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x00072DDC File Offset: 0x00070FDC
		public override void Aggregate(object dataValue, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record)
		{
			decimal d;
			if (global::Infragistics.Windows.DataPresenter.SummaryCalculator.ToDecimal(dataValue, out d, summaryResult, record))
			{
				this._sum += d;
				this._count++;
			}
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x00072E15 File Offset: 0x00071015
		public override void BeginCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			this._sum = 0m;
			this._count = 0;
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x00072E2C File Offset: 0x0007102C
		public override bool CanProcessDataType(global::System.Type dataType)
		{
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(dataType);
			return global::Infragistics.Windows.Utilities.IsNumericType(underlyingType);
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00072E48 File Offset: 0x00071048
		public override object EndCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			decimal num = (this._count > 0) ? (this._sum / this._count) : 0m;
			return num;
		}

		// Token: 0x04000AEB RID: 2795
		internal static readonly string NAME = "Average";

		// Token: 0x04000AEC RID: 2796
		internal static readonly string SR_DISPLAY_NAME = "SummaryCalculator_Average_Name";

		// Token: 0x04000AED RID: 2797
		internal static readonly string SR_DESCRIPTION = "SummaryCalculator_Average_Description";

		// Token: 0x04000AEE RID: 2798
		internal static readonly string RES_IMAGE = "SummaryCalculator_Average_Image";

		// Token: 0x04000AEF RID: 2799
		private int _count;

		// Token: 0x04000AF0 RID: 2800
		private decimal _sum;
	}
}
