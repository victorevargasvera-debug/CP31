using System;
using System.Diagnostics;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Data.Internal
{
	// Token: 0x02000262 RID: 610
	[global::System.Diagnostics.DebuggerDisplay("Product: {Product} App: {Application} Criteria: {Criteria}")]
	internal class SessionCriteriaPredicate
	{
		// Token: 0x06001F1F RID: 7967 RVA: 0x00070D98 File Offset: 0x0006EF98
		public SessionCriteriaPredicate(string productName, string applicationName, global::Gibraltar.Data.SessionCriteria criteria)
		{
			this.m_ProductName = productName;
			this.m_ApplicationName = applicationName;
			this.m_Criteria = criteria;
			this.m_ActiveSession = ((this.m_Criteria & global::Gibraltar.Data.SessionCriteria.ActiveSession) == global::Gibraltar.Data.SessionCriteria.ActiveSession);
			this.m_NewSessions = ((this.m_Criteria & global::Gibraltar.Data.SessionCriteria.NewSessions) == global::Gibraltar.Data.SessionCriteria.NewSessions);
			this.m_CompletedSessions = ((this.m_Criteria & global::Gibraltar.Data.SessionCriteria.CompletedSessions) == global::Gibraltar.Data.SessionCriteria.CompletedSessions);
			this.m_CrashedSessions = ((this.m_Criteria & global::Gibraltar.Data.SessionCriteria.CrashedSessions) == global::Gibraltar.Data.SessionCriteria.CrashedSessions);
			this.m_CriticalSessions = ((this.m_Criteria & global::Gibraltar.Data.SessionCriteria.CriticalSessions) == global::Gibraltar.Data.SessionCriteria.CriticalSessions);
			this.m_ErrorSessions = ((this.m_Criteria & global::Gibraltar.Data.SessionCriteria.ErrorSessions) == global::Gibraltar.Data.SessionCriteria.ErrorSessions);
			this.m_WarningSessions = ((this.m_Criteria & global::Gibraltar.Data.SessionCriteria.WarningSessions) == global::Gibraltar.Data.SessionCriteria.WarningSessions);
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x00070E44 File Offset: 0x0006F044
		public global::Gibraltar.Data.SessionCriteria Criteria
		{
			get
			{
				return this.m_Criteria;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06001F21 RID: 7969 RVA: 0x00070E4C File Offset: 0x0006F04C
		public string Application
		{
			get
			{
				return this.m_ApplicationName;
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x00070E54 File Offset: 0x0006F054
		public string Product
		{
			get
			{
				return this.m_ProductName;
			}
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00070E5C File Offset: 0x0006F05C
		public bool Predicate(global::Loupe.Extensibility.Data.ISessionSummary sessionSummary)
		{
			if (!sessionSummary.Product.Equals(this.m_ProductName, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
			if (!string.IsNullOrEmpty(this.m_ApplicationName) && !sessionSummary.Application.Equals(this.m_ApplicationName, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
			if (this.m_ActiveSession && global::Gibraltar.Monitor.Log.SessionSummary.Id == sessionSummary.Id)
			{
				return true;
			}
			if (sessionSummary.Status != global::Loupe.Extensibility.Data.SessionStatus.Running)
			{
				if (this.m_CompletedSessions)
				{
					return true;
				}
				if (sessionSummary.IsNew && this.m_NewSessions)
				{
					return true;
				}
				if (this.m_CrashedSessions && sessionSummary.Status == global::Loupe.Extensibility.Data.SessionStatus.Crashed)
				{
					return true;
				}
				if (this.m_CriticalSessions && sessionSummary.CriticalCount > 0)
				{
					return true;
				}
				if (this.m_ErrorSessions && sessionSummary.ErrorCount > 0)
				{
					return true;
				}
				if (this.m_WarningSessions && sessionSummary.WarningCount > 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000BBA RID: 3002
		private readonly string m_ProductName;

		// Token: 0x04000BBB RID: 3003
		private readonly string m_ApplicationName;

		// Token: 0x04000BBC RID: 3004
		private readonly global::Gibraltar.Data.SessionCriteria m_Criteria;

		// Token: 0x04000BBD RID: 3005
		private bool m_ActiveSession;

		// Token: 0x04000BBE RID: 3006
		private bool m_NewSessions;

		// Token: 0x04000BBF RID: 3007
		private bool m_CompletedSessions;

		// Token: 0x04000BC0 RID: 3008
		private bool m_CrashedSessions;

		// Token: 0x04000BC1 RID: 3009
		private bool m_CriticalSessions;

		// Token: 0x04000BC2 RID: 3010
		private bool m_ErrorSessions;

		// Token: 0x04000BC3 RID: 3011
		private bool m_WarningSessions;
	}
}
