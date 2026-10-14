using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001C5 RID: 453
	public class SumSummaryCalculator : global::Infragistics.Windows.DataPresenter.SummaryCalculator
	{
		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x00073133 File Offset: 0x00071333
		public override string Description
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.SumSummaryCalculator.SR_DESCRIPTION);
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001A81 RID: 6785 RVA: 0x0007313F File Offset: 0x0007133F
		public override string DisplayName
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.SumSummaryCalculator.SR_DISPLAY_NAME);
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x0007314B File Offset: 0x0007134B
		public override string Name
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.SumSummaryCalculator.NAME;
			}
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x00073154 File Offset: 0x00071354
		public override void Aggregate(object dataValue, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record)
		{
			decimal d;
			if (global::Infragistics.Windows.DataPresenter.SummaryCalculator.ToDecimal(dataValue, out d, summaryResult, record))
			{
				this._sum += d;
			}
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0007317F File Offset: 0x0007137F
		public override void BeginCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			this._sum = 0m;
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x00073190 File Offset: 0x00071390
		public override bool CanProcessDataType(global::System.Type dataType)
		{
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(dataType);
			return global::Infragistics.Windows.Utilities.IsNumericType(underlyingType);
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x000731AA File Offset: 0x000713AA
		public override object EndCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			return this._sum;
		}

		// Token: 0x04000B02 RID: 2818
		internal static readonly string NAME = "Sum";

		// Token: 0x04000B03 RID: 2819
		internal static readonly string SR_DISPLAY_NAME = "SummaryCalculator_Sum_Name";

		// Token: 0x04000B04 RID: 2820
		internal static readonly string SR_DESCRIPTION = "SummaryCalculator_Sum_Description";

		// Token: 0x04000B05 RID: 2821
		internal static readonly string RES_IMAGE = "SummaryCalculator_Sum_Image";

		// Token: 0x04000B06 RID: 2822
		private decimal _sum;
	}
}
