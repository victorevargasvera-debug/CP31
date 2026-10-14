using System;
using System.Globalization;
using System.Linq;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200002D RID: 45
	public class PercentData
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0000B651 File Offset: 0x00009851
		// (set) Token: 0x0600021B RID: 539 RVA: 0x0000B659 File Offset: 0x00009859
		protected internal double GeneratedMinimumValue { get; set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0000B662 File Offset: 0x00009862
		// (set) Token: 0x0600021D RID: 541 RVA: 0x0000B66A File Offset: 0x0000986A
		protected internal double GeneratedMaximumValue { get; set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0000B673 File Offset: 0x00009873
		// (set) Token: 0x0600021F RID: 543 RVA: 0x0000B67B File Offset: 0x0000987B
		public double Range { get; private set; }

		// Token: 0x06000220 RID: 544 RVA: 0x0000B684 File Offset: 0x00009884
		public static global::Infragistics.Controls.Grids.PercentData CreatePercentData(global::Infragistics.CachedTypedInfo objectDataType, string key, global::System.Linq.IQueryable query)
		{
			global::Infragistics.Controls.Grids.PercentData percentData = new global::Infragistics.Controls.Grids.PercentData();
			global::Infragistics.SummaryContext summaryContext = global::Infragistics.SummaryContext.CreateGenericSummary(objectDataType, key, global::Infragistics.LinqSummaryOperator.Minimum);
			percentData.GeneratedMinimumValue = global::System.Convert.ToDouble(summaryContext.Execute(query), global::System.Globalization.CultureInfo.InvariantCulture);
			global::Infragistics.SummaryContext summaryContext2 = global::Infragistics.SummaryContext.CreateGenericSummary(objectDataType, key, global::Infragistics.LinqSummaryOperator.Maximum);
			percentData.GeneratedMaximumValue = global::System.Convert.ToDouble(summaryContext2.Execute(query), global::System.Globalization.CultureInfo.InvariantCulture);
			percentData.Range = percentData.GeneratedMaximumValue - percentData.GeneratedMinimumValue;
			return percentData;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000B6EB File Offset: 0x000098EB
		protected internal double GetPercentValue(double value)
		{
			return (value - this.GeneratedMinimumValue) / this.Range * 100.0;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000B706 File Offset: 0x00009906
		protected internal double GetRealValue(double percentage)
		{
			return percentage * this.Range / 100.0 + this.GeneratedMinimumValue;
		}
	}
}
