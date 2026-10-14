using System;
using System.Globalization;
using System.Linq;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200002B RID: 43
	internal class AutomaticData
	{
		// Token: 0x06000206 RID: 518 RVA: 0x0000B3B8 File Offset: 0x000095B8
		public static double CreateAutomaticData(global::Infragistics.CachedTypedInfo objectDataType, string key, global::Infragistics.LinqSummaryOperator op, global::System.Linq.IQueryable query)
		{
			global::Infragistics.SummaryContext summaryContext = global::Infragistics.SummaryContext.CreateGenericSummary(objectDataType, key, op);
			return global::System.Convert.ToDouble(summaryContext.Execute(query), global::System.Globalization.CultureInfo.InvariantCulture);
		}
	}
}
