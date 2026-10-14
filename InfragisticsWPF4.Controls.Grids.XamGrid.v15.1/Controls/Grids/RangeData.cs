using System;
using System.Globalization;
using System.Linq;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000031 RID: 49
	internal class RangeData
	{
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0000BF8E File Offset: 0x0000A18E
		// (set) Token: 0x06000243 RID: 579 RVA: 0x0000BF96 File Offset: 0x0000A196
		private double GeneratedMinimumValue { get; set; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0000BF9F File Offset: 0x0000A19F
		// (set) Token: 0x06000245 RID: 581 RVA: 0x0000BFA7 File Offset: 0x0000A1A7
		private double GeneratedMaximumValue { get; set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0000BFB0 File Offset: 0x0000A1B0
		// (set) Token: 0x06000247 RID: 583 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		public double Range { get; private set; }

		// Token: 0x06000248 RID: 584 RVA: 0x0000BFC1 File Offset: 0x0000A1C1
		internal double GetPercentValue(double value)
		{
			return (value - this.GeneratedMinimumValue) / this.Range * 100.0;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000BFDC File Offset: 0x0000A1DC
		public static global::Infragistics.Controls.Grids.RangeData CreateRangeData(double? setMinValue, double? setMaxValue, global::Infragistics.CachedTypedInfo objectDataType, string key, global::System.Linq.IQueryable query)
		{
			global::Infragistics.Controls.Grids.RangeData rangeData = new global::Infragistics.Controls.Grids.RangeData();
			if (setMinValue != null)
			{
				rangeData.GeneratedMinimumValue = setMinValue.Value;
			}
			else
			{
				global::Infragistics.SummaryContext summaryContext = global::Infragistics.SummaryContext.CreateGenericSummary(objectDataType, key, global::Infragistics.LinqSummaryOperator.Minimum);
				rangeData.GeneratedMinimumValue = global::System.Convert.ToDouble(summaryContext.Execute(query), global::System.Globalization.CultureInfo.InvariantCulture);
			}
			if (setMaxValue != null)
			{
				rangeData.GeneratedMaximumValue = setMaxValue.Value;
			}
			else
			{
				global::Infragistics.SummaryContext summaryContext2 = global::Infragistics.SummaryContext.CreateGenericSummary(objectDataType, key, global::Infragistics.LinqSummaryOperator.Maximum);
				rangeData.GeneratedMaximumValue = global::System.Convert.ToDouble(summaryContext2.Execute(query), global::System.Globalization.CultureInfo.InvariantCulture);
			}
			rangeData.Range = rangeData.GeneratedMaximumValue - rangeData.GeneratedMinimumValue;
			return rangeData;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000C077 File Offset: 0x0000A277
		public static global::Infragistics.Controls.Grids.RangeData CreateRangeData(double setMinValue, double setMaxValue)
		{
			return global::Infragistics.Controls.Grids.RangeData.CreateRangeData(new double?(setMinValue), new double?(setMaxValue), null, null, null);
		}
	}
}
