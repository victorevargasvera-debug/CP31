using System;

namespace Loupe.Extensibility.Client
{
	// Token: 0x0200009A RID: 154
	internal interface IRepositoryController : global::System.IDisposable
	{
		// Token: 0x060006B3 RID: 1715
		void Initialize(global::Loupe.Extensibility.Client.IRepositoryContext context);

		// Token: 0x060006B4 RID: 1716
		void ConfigurationChanged();
	}
}
