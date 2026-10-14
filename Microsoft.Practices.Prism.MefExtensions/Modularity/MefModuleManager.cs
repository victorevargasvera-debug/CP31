using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Microsoft.Practices.Prism.Logging;
using Microsoft.Practices.Prism.Modularity;

namespace Microsoft.Practices.Prism.MefExtensions.Modularity
{
	// Token: 0x02000009 RID: 9
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Modularity.IModuleManager))]
	public class MefModuleManager : global::Microsoft.Practices.Prism.Modularity.ModuleManager, global::System.ComponentModel.Composition.IPartImportsSatisfiedNotification
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002A6F File Offset: 0x00000C6F
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MefModuleManager(global::Microsoft.Practices.Prism.Modularity.IModuleInitializer moduleInitializer, global::Microsoft.Practices.Prism.Modularity.IModuleCatalog moduleCatalog, global::Microsoft.Practices.Prism.Logging.ILoggerFacade loggerFacade) : base(moduleInitializer, moduleCatalog, loggerFacade)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002A7A File Offset: 0x00000C7A
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002A82 File Offset: 0x00000C82
		[global::System.ComponentModel.Composition.ImportMany(AllowRecomposition = true)]
		protected global::System.Collections.Generic.IEnumerable<global::System.Lazy<global::Microsoft.Practices.Prism.Modularity.IModule, global::Microsoft.Practices.Prism.MefExtensions.Modularity.IModuleExport>> ImportedModules { get; set; }

		// Token: 0x06000034 RID: 52 RVA: 0x00002A94 File Offset: 0x00000C94
		public virtual void OnImportsSatisfied()
		{
			global::System.Collections.Generic.IDictionary<string, global::Microsoft.Practices.Prism.Modularity.ModuleInfo> dictionary = base.ModuleCatalog.Modules.ToDictionary((global::Microsoft.Practices.Prism.Modularity.ModuleInfo m) => m.ModuleName);
			foreach (global::System.Lazy<global::Microsoft.Practices.Prism.Modularity.IModule, global::Microsoft.Practices.Prism.MefExtensions.Modularity.IModuleExport> lazy in this.ImportedModules)
			{
				global::System.Type moduleType = lazy.Metadata.ModuleType;
				global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo = null;
				if (!dictionary.TryGetValue(lazy.Metadata.ModuleName, out moduleInfo))
				{
					global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo2 = new global::Microsoft.Practices.Prism.Modularity.ModuleInfo
					{
						ModuleName = lazy.Metadata.ModuleName,
						ModuleType = moduleType.AssemblyQualifiedName,
						InitializationMode = lazy.Metadata.InitializationMode,
						State = ((lazy.Metadata.InitializationMode == global::Microsoft.Practices.Prism.Modularity.InitializationMode.OnDemand) ? global::Microsoft.Practices.Prism.Modularity.ModuleState.NotStarted : global::Microsoft.Practices.Prism.Modularity.ModuleState.ReadyForInitialization)
					};
					if (lazy.Metadata.DependsOnModuleNames != null)
					{
						moduleInfo2.DependsOn.AddRange(lazy.Metadata.DependsOnModuleNames);
					}
					base.ModuleCatalog.AddModule(moduleInfo2);
				}
				else
				{
					moduleInfo.ModuleType = moduleType.AssemblyQualifiedName;
				}
			}
			base.LoadModulesThatAreReadyForLoad();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002BFC File Offset: 0x00000DFC
		protected override bool ModuleNeedsRetrieval(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			return this.ImportedModules == null || !this.ImportedModules.Any((global::System.Lazy<global::Microsoft.Practices.Prism.Modularity.IModule, global::Microsoft.Practices.Prism.MefExtensions.Modularity.IModuleExport> lazyModule) => lazyModule.Metadata.ModuleName == moduleInfo.ModuleName);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002C3C File Offset: 0x00000E3C
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002C70 File Offset: 0x00000E70
		public override global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.IModuleTypeLoader> ModuleTypeLoaders
		{
			get
			{
				if (this.mefTypeLoaders == null)
				{
					this.mefTypeLoaders = new global::System.Collections.Generic.List<global::Microsoft.Practices.Prism.Modularity.IModuleTypeLoader>
					{
						this.mefFileModuleTypeLoader
					};
				}
				return this.mefTypeLoaders;
			}
			set
			{
				this.mefTypeLoaders = value;
			}
		}

		// Token: 0x0400000C RID: 12
		[global::System.ComponentModel.Composition.Import(AllowRecomposition = false)]
		private global::Microsoft.Practices.Prism.MefExtensions.Modularity.MefFileModuleTypeLoader mefFileModuleTypeLoader;

		// Token: 0x0400000D RID: 13
		private global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Modularity.IModuleTypeLoader> mefTypeLoaders;
	}
}
