using System;
using System.Linq;

namespace Infragistics
{
	// Token: 0x02000037 RID: 55
	public interface IRule
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000291 RID: 657
		global::Infragistics.EvaluationStage RuleExecution { get; }

		// Token: 0x06000292 RID: 658
		void GatherData(global::System.Linq.IQueryable query);
	}
}
