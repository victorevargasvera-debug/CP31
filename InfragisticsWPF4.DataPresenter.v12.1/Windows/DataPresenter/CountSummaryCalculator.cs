using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001C2 RID: 450
	public class CountSummaryCalculator : global::Infragistics.Windows.DataPresenter.SummaryCalculator
	{
		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001A64 RID: 6756 RVA: 0x00072EB5 File Offset: 0x000710B5
		public override string Description
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.CountSummaryCalculator.SR_DESCRIPTION);
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x00072EC1 File Offset: 0x000710C1
		public override string DisplayName
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.CountSummaryCalculator.SR_DISPLAY_NAME);
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x06001A66 RID: 6758 RVA: 0x00072ECD File Offset: 0x000710CD
		public override string Name
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CountSummaryCalculator.NAME;
			}
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x00072ED4 File Offset: 0x000710D4
		public override void Aggregate(object dataValue, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._count++;
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00072EE4 File Offset: 0x000710E4
		public override void BeginCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			this._count = 0;
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00072EED File Offset: 0x000710ED
		public override bool CanProcessDataType(global::System.Type dataType)
		{
			return true;
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00072EF0 File Offset: 0x000710F0
		public override object EndCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			return this._count;
		}

		// Token: 0x04000AF1 RID: 2801
		internal static readonly string NAME = "Count";

		// Token: 0x04000AF2 RID: 2802
		internal static readonly string SR_DISPLAY_NAME = "SummaryCalculator_Count_Name";

		// Token: 0x04000AF3 RID: 2803
		internal static readonly string SR_DESCRIPTION = "SummaryCalculator_Count_Description";

		// Token: 0x04000AF4 RID: 2804
		internal static readonly string RES_IMAGE = "SummaryCalculator_Count_Image";

		// Token: 0x04000AF5 RID: 2805
		private int _count;
	}
}
