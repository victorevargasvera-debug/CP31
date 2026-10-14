using System;
using Loupe.Extensibility.Client;
using Loupe.Extensibility.Data;

namespace Loupe.Extensibility.Server
{
	// Token: 0x0200004F RID: 79
	internal interface ISessionAnalyzer : global::System.IDisposable
	{
		// Token: 0x0600049C RID: 1180
		void Initialize(global::Loupe.Extensibility.Client.IRepositoryContext context);

		// Token: 0x0600049D RID: 1181
		void ConfigurationChanged();

		// Token: 0x0600049E RID: 1182
		void Process(global::Loupe.Extensibility.Data.ISession session);
	}
}
