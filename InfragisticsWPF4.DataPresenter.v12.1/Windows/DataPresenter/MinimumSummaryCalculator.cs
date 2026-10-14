using System;
using System.Globalization;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001C4 RID: 452
	public class MinimumSummaryCalculator : global::Infragistics.Windows.DataPresenter.SummaryCalculator
	{
		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x00072FDB File Offset: 0x000711DB
		public override string Description
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.MinimumSummaryCalculator.SR_DESCRIPTION);
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001A77 RID: 6775 RVA: 0x00072FE7 File Offset: 0x000711E7
		public override string DisplayName
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.MinimumSummaryCalculator.SR_DISPLAY_NAME);
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x00072FF3 File Offset: 0x000711F3
		public override string Name
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.MinimumSummaryCalculator.NAME;
			}
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x00072FFA File Offset: 0x000711FA
		public override void Aggregate(object dataValue, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.MinimumSummaryCalculator.AggregateMinMaxHelper(dataValue, summaryResult, record, true, ref this._min, ref this._firstTime);
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x00073011 File Offset: 0x00071211
		public override void BeginCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			this._min = null;
			this._firstTime = true;
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x00073024 File Offset: 0x00071224
		public override bool CanProcessDataType(global::System.Type dataType)
		{
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(dataType);
			return typeof(global::System.IComparable).IsAssignableFrom(underlyingType);
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x0007304D File Offset: 0x0007124D
		public override object EndCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			return this._min;
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x00073058 File Offset: 0x00071258
		internal static void AggregateMinMaxHelper(object dataValue, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record, bool calcMin, ref object currMinOrMax, ref bool firstTime)
		{
			if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsNullOrEmpty(dataValue))
			{
				if (calcMin && currMinOrMax == null)
				{
					currMinOrMax = dataValue;
				}
				return;
			}
			object obj = global::Infragistics.Windows.DataPresenter.SummaryCalculator.ConvertToFieldEditAsType(dataValue, summaryResult, record);
			if (obj == null)
			{
				return;
			}
			if (firstTime)
			{
				currMinOrMax = obj;
				firstTime = false;
				return;
			}
			int num;
			if (obj is global::System.IComparable)
			{
				num = ((global::System.IComparable)obj).CompareTo(currMinOrMax);
			}
			else
			{
				string strB = (string)global::Infragistics.Windows.DataPresenter.SummaryCalculator.ConvertDataValue(currMinOrMax, typeof(string), summaryResult, record);
				string strA = (string)global::Infragistics.Windows.DataPresenter.SummaryCalculator.ConvertDataValue(obj, typeof(string), summaryResult, record);
				num = string.Compare(strA, strB, false, global::System.Globalization.CultureInfo.CurrentCulture);
			}
			if (calcMin ? (num < 0) : (num > 0))
			{
				currMinOrMax = obj;
			}
		}

		// Token: 0x04000AFC RID: 2812
		internal static readonly string NAME = "Minimum";

		// Token: 0x04000AFD RID: 2813
		internal static readonly string SR_DISPLAY_NAME = "SummaryCalculator_Minimum_Name";

		// Token: 0x04000AFE RID: 2814
		internal static readonly string SR_DESCRIPTION = "SummaryCalculator_Minimum_Description";

		// Token: 0x04000AFF RID: 2815
		internal static readonly string RES_IMAGE = "SummaryCalculator_Minimum_Image";

		// Token: 0x04000B00 RID: 2816
		private bool _firstTime;

		// Token: 0x04000B01 RID: 2817
		private object _min;
	}
}
