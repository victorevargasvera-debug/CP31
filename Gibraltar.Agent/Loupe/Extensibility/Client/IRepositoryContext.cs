using System;

namespace Loupe.Extensibility.Client
{
	// Token: 0x02000099 RID: 153
	internal interface IRepositoryContext : global::Loupe.Extensibility.Client.IGlobalContext
	{
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060006AD RID: 1709
		global::Loupe.Extensibility.Client.IRepositoryController RepositoryController { get; }

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060006AE RID: 1710
		global::Loupe.Extensibility.Client.IRepositoryConfiguration Configuration { get; }

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060006AF RID: 1711
		global::Loupe.Extensibility.IRepository Repository { get; }

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060006B0 RID: 1712
		bool IsServerAvailable { get; }

		// Token: 0x060006B1 RID: 1713
		void DisplaySession(global::System.Guid sessionId, object state);

		// Token: 0x060006B2 RID: 1714
		void EditConfiguration();
	}
}
