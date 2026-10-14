using System;

namespace Loupe.Extensibility.Server
{
	// Token: 0x0200005C RID: 92
	internal interface IRepositoryExtension : global::System.IDisposable
	{
		// Token: 0x060004EA RID: 1258
		void Initialize(global::Loupe.Extensibility.Server.IRepositoryExtensionContext context);

		// Token: 0x060004EB RID: 1259
		void Shutdown();
	}
}
