using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001E9 RID: 489
	public class CountSummaryCalculator : global::Infragistics.Windows.DataPresenter.SummaryCalculator
	{
		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x00086B05 File Offset: 0x00084D05
		public override string Description
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.CountSummaryCalculator.SR_DESCRIPTION);
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x00086B11 File Offset: 0x00084D11
		public override string DisplayName
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.CountSummaryCalculator.SR_DISPLAY_NAME);
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x00086B1D File Offset: 0x00084D1D
		public override string Name
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CountSummaryCalculator.NAME;
			}
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x00086B24 File Offset: 0x00084D24
		public override void Aggregate(object dataValue, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._count++;
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x00086B34 File Offset: 0x00084D34
		public override void BeginCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			this._count = 0;
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x00086B3D File Offset: 0x00084D3D
		public override bool CanProcessDataType(global::System.Type dataType)
		{
			return true;
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00086B40 File Offset: 0x00084D40
		public override object EndCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			return this._count;
		}

		// Token: 0x04000CDB RID: 3291
		internal static readonly string NAME = "Count";

		// Token: 0x04000CDC RID: 3292
		internal static readonly string SR_DISPLAY_NAME = "SummaryCalculator_Count_Name";

		// Token: 0x04000CDD RID: 3293
		internal static readonly string SR_DESCRIPTION = "SummaryCalculator_Count_Description";

		// Token: 0x04000CDE RID: 3294
		internal static readonly string RES_IMAGE = "SummaryCalculator_Count_Image";

		// Token: 0x04000CDF RID: 3295
		private int _count;
	}
}
