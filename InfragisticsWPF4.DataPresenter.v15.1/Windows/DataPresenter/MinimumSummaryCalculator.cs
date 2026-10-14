using System;
using System.Globalization;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001EB RID: 491
	public class MinimumSummaryCalculator : global::Infragistics.Windows.DataPresenter.SummaryCalculator
	{
		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x00086C2B File Offset: 0x00084E2B
		public override string Description
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.MinimumSummaryCalculator.SR_DESCRIPTION);
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x00086C37 File Offset: 0x00084E37
		public override string DisplayName
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(global::Infragistics.Windows.DataPresenter.MinimumSummaryCalculator.SR_DISPLAY_NAME);
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x00086C43 File Offset: 0x00084E43
		public override string Name
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.MinimumSummaryCalculator.NAME;
			}
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x00086C4A File Offset: 0x00084E4A
		public override void Aggregate(object dataValue, global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult, global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.MinimumSummaryCalculator.AggregateMinMaxHelper(dataValue, summaryResult, record, true, ref this._min, ref this._firstTime);
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x00086C61 File Offset: 0x00084E61
		public override void BeginCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			this._min = null;
			this._firstTime = true;
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x00086C74 File Offset: 0x00084E74
		public override bool CanProcessDataType(global::System.Type dataType)
		{
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(dataType);
			return typeof(global::System.IComparable).IsAssignableFrom(underlyingType);
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x00086C9D File Offset: 0x00084E9D
		public override object EndCalculation(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			return this._min;
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x00086CA8 File Offset: 0x00084EA8
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

		// Token: 0x04000CE6 RID: 3302
		internal static readonly string NAME = "Minimum";

		// Token: 0x04000CE7 RID: 3303
		internal static readonly string SR_DISPLAY_NAME = "SummaryCalculator_Minimum_Name";

		// Token: 0x04000CE8 RID: 3304
		internal static readonly string SR_DESCRIPTION = "SummaryCalculator_Minimum_Description";

		// Token: 0x04000CE9 RID: 3305
		internal static readonly string RES_IMAGE = "SummaryCalculator_Minimum_Image";

		// Token: 0x04000CEA RID: 3306
		private bool _firstTime;

		// Token: 0x04000CEB RID: 3307
		private object _min;
	}
}
