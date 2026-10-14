using System;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000029 RID: 41
	public interface IModuleTypeLoader
	{
		// Token: 0x060000C7 RID: 199
		bool CanLoadModuleType(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo);

		// Token: 0x060000C8 RID: 200
		void LoadModuleType(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo);

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060000C9 RID: 201
		// (remove) Token: 0x060000CA RID: 202
		event global::System.EventHandler<global::Microsoft.Practices.Prism.Modularity.ModuleDownloadProgressChangedEventArgs> ModuleDownloadProgressChanged;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060000CB RID: 203
		// (remove) Token: 0x060000CC RID: 204
		event global::System.EventHandler<global::Microsoft.Practices.Prism.Modularity.LoadModuleCompletedEventArgs> LoadModuleCompleted;
	}
}
