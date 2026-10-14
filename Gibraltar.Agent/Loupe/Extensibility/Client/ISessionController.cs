using System;
using Loupe.Extensibility.Data;

namespace Loupe.Extensibility.Client
{
	// Token: 0x0200009D RID: 157
	internal interface ISessionController : global::System.IDisposable
	{
		// Token: 0x060006BD RID: 1725
		void Initialize(global::Loupe.Extensibility.Client.ISessionContext context, global::Loupe.Extensibility.Data.ISession session);

		// Token: 0x060006BE RID: 1726
		void Open(object state);

		// Token: 0x060006BF RID: 1727
		void ConfigurationChanged();
	}
}
