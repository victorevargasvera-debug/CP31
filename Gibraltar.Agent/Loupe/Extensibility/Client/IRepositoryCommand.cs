using System;

namespace Loupe.Extensibility.Client
{
	// Token: 0x02000092 RID: 146
	internal interface IRepositoryCommand : global::System.IDisposable
	{
		// Token: 0x0600068A RID: 1674
		void Initialize(global::Loupe.Extensibility.Client.IRepositoryContext context);

		// Token: 0x0600068B RID: 1675
		void ConfigurationChanged();

		// Token: 0x0600068C RID: 1676
		void RegisterCommands(global::Loupe.Extensibility.Client.IUserInterfaceContext controller);

		// Token: 0x0600068D RID: 1677
		void BeforeCommandsDisplay(global::Loupe.Extensibility.Client.IUserInterfaceContext controller);

		// Token: 0x0600068E RID: 1678
		void Process(global::Loupe.Extensibility.Client.IUserInterfaceContext controller, string commandName);
	}
}
