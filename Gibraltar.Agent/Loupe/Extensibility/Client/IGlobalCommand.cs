using System;

namespace Loupe.Extensibility.Client
{
	// Token: 0x02000098 RID: 152
	internal interface IGlobalCommand : global::System.IDisposable
	{
		// Token: 0x060006A9 RID: 1705
		void Initialize(global::Loupe.Extensibility.Client.IGlobalContext context);

		// Token: 0x060006AA RID: 1706
		void RegisterCommands(global::Loupe.Extensibility.Client.IUserInterfaceContext controller);

		// Token: 0x060006AB RID: 1707
		void BeforeCommandsDisplay(global::Loupe.Extensibility.Client.IUserInterfaceContext controller);

		// Token: 0x060006AC RID: 1708
		void Process(global::Loupe.Extensibility.Client.IUserInterfaceContext controller, string commandName);
	}
}
