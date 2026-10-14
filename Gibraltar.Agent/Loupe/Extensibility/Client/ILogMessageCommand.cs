using System;
using System.Collections.Generic;
using Loupe.Extensibility.Data;

namespace Loupe.Extensibility.Client
{
	// Token: 0x02000097 RID: 151
	internal interface ILogMessageCommand : global::System.IDisposable
	{
		// Token: 0x060006A4 RID: 1700
		void Initialize(global::Loupe.Extensibility.Client.ISessionContext context);

		// Token: 0x060006A5 RID: 1701
		void ConfigurationChanged();

		// Token: 0x060006A6 RID: 1702
		void RegisterCommands(global::Loupe.Extensibility.Client.IUserInterfaceContext context);

		// Token: 0x060006A7 RID: 1703
		void BeforeCommandsDisplay(global::Loupe.Extensibility.Client.IUserInterfaceContext context, global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.ILogMessage> messages);

		// Token: 0x060006A8 RID: 1704
		void Process(global::Loupe.Extensibility.Client.IUserInterfaceContext context, string commandName, global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.ILogMessage> messages);
	}
}
