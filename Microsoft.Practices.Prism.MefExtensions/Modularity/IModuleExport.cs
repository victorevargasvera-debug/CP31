using System;
using System.ComponentModel;
using Microsoft.Practices.Prism.Modularity;

namespace Microsoft.Practices.Prism.MefExtensions.Modularity
{
	// Token: 0x02000006 RID: 6
	public interface IModuleExport
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001A RID: 26
		string ModuleName { get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001B RID: 27
		global::System.Type ModuleType { get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001C RID: 28
		[global::System.ComponentModel.DefaultValue(global::Microsoft.Practices.Prism.Modularity.InitializationMode.WhenAvailable)]
		global::Microsoft.Practices.Prism.Modularity.InitializationMode InitializationMode { get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001D RID: 29
		[global::System.ComponentModel.DefaultValue(null)]
		string[] DependsOnModuleNames { get; }
	}
}
