using System;
using Loupe.Extensibility.Data;

namespace Loupe.Extensibility.Client
{
	// Token: 0x0200009E RID: 158
	internal interface ISessionContext : global::Loupe.Extensibility.Client.IRepositoryContext, global::Loupe.Extensibility.Client.IGlobalContext
	{
		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060006C0 RID: 1728
		global::Loupe.Extensibility.Data.ISession Session { get; }

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060006C1 RID: 1729
		global::Loupe.Extensibility.Client.ISessionController SessionController { get; }
	}
}
