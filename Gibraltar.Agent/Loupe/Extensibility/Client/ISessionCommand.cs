using System;
using System.Collections.Generic;
using Loupe.Extensibility.Data;

namespace Loupe.Extensibility.Client
{
	// Token: 0x0200009C RID: 156
	internal interface ISessionCommand : global::System.IDisposable
	{
		// Token: 0x060006B8 RID: 1720
		void Initialize(global::Loupe.Extensibility.Client.IRepositoryContext context);

		// Token: 0x060006B9 RID: 1721
		void ConfigurationChanged();

		// Token: 0x060006BA RID: 1722
		void RegisterCommands(global::Loupe.Extensibility.Client.IUserInterfaceContext controller);

		// Token: 0x060006BB RID: 1723
		void BeforeCommandsDisplay(global::Loupe.Extensibility.Client.IUserInterfaceContext controller, global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.ISessionSummary> sessionSummaries);

		// Token: 0x060006BC RID: 1724
		void Process(global::Loupe.Extensibility.Client.IUserInterfaceContext controller, string commandName, global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.ISessionSummary> sessionSummaries);
	}
}
