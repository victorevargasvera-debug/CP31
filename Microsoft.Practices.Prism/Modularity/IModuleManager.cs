using System;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000036 RID: 54
	public interface IModuleManager
	{
		// Token: 0x0600011C RID: 284
		void Run();

		// Token: 0x0600011D RID: 285
		void LoadModule(string moduleName);

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600011E RID: 286
		// (remove) Token: 0x0600011F RID: 287
		event global::System.EventHandler<global::Microsoft.Practices.Prism.Modularity.ModuleDownloadProgressChangedEventArgs> ModuleDownloadProgressChanged;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000120 RID: 288
		// (remove) Token: 0x06000121 RID: 289
		event global::System.EventHandler<global::Microsoft.Practices.Prism.Modularity.LoadModuleCompletedEventArgs> LoadModuleCompleted;
	}
}
