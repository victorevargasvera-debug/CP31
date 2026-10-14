using System;
using Loupe.Extensibility.Data;

namespace Gibraltar.Agent.Internal
{
	// Token: 0x02000039 RID: 57
	internal class SessionSummaryPredicate
	{
		// Token: 0x06000346 RID: 838 RVA: 0x0000AEE0 File Offset: 0x000090E0
		public SessionSummaryPredicate(global::System.Predicate<global::Gibraltar.Agent.SessionSummary> sessionSummaryPredicate)
		{
			this.m_SessionSummaryPredicate = sessionSummaryPredicate;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000AEF0 File Offset: 0x000090F0
		public bool Predicate(global::Loupe.Extensibility.Data.ISessionSummary sessionSummary)
		{
			global::Gibraltar.Agent.SessionSummary obj = new global::Gibraltar.Agent.SessionSummary(sessionSummary);
			return this.m_SessionSummaryPredicate(obj);
		}

		// Token: 0x040000BD RID: 189
		private readonly global::System.Predicate<global::Gibraltar.Agent.SessionSummary> m_SessionSummaryPredicate;
	}
}
