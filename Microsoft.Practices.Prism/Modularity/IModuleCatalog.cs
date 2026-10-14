using System;
using System.Collections.Generic;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000034 RID: 52
	public interface IModuleCatalog
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000116 RID: 278
		global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> Modules { get; }

		// Token: 0x06000117 RID: 279
		global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> GetDependentModules(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo);

		// Token: 0x06000118 RID: 280
		global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> CompleteListWithDependencies(global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.ModuleInfo> modules);

		// Token: 0x06000119 RID: 281
		void Initialize();

		// Token: 0x0600011A RID: 282
		void AddModule(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo);
	}
}
