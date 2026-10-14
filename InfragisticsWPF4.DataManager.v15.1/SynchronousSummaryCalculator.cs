using System;
using System.Linq;

namespace Infragistics
{
	// Token: 0x0200003F RID: 63
	public abstract class SynchronousSummaryCalculator : global::Infragistics.SummaryCalculatorBase
	{
		// Token: 0x060002B6 RID: 694
		public abstract object Summarize(global::System.Linq.IQueryable data, string fieldKey);
	}
}
