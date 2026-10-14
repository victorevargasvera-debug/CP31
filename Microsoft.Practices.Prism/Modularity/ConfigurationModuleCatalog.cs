using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000092 RID: 146
	public class ConfigurationModuleCatalog : global::Microsoft.Practices.Prism.Modularity.ModuleCatalog
	{
		// Token: 0x060003D7 RID: 983 RVA: 0x0000AC48 File Offset: 0x00008E48
		public ConfigurationModuleCatalog()
		{
			this.Store = new global::Microsoft.Practices.Prism.Modularity.ConfigurationStore();
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0000AC5B File Offset: 0x00008E5B
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x0000AC63 File Offset: 0x00008E63
		public global::Microsoft.Practices.Prism.Modularity.IConfigurationStore Store { get; set; }

		// Token: 0x060003DA RID: 986 RVA: 0x0000AC6C File Offset: 0x00008E6C
		protected override void InnerLoad()
		{
			if (this.Store == null)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Practices.Prism.Properties.Resources.ConfigurationStoreCannotBeNull);
			}
			this.EnsureModulesDiscovered();
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000AC88 File Offset: 0x00008E88
		private static string GetFileAbsoluteUri(string filePath)
		{
			global::System.Uri uri = new global::System.UriBuilder
			{
				Host = string.Empty,
				Scheme = global::System.Uri.UriSchemeFile,
				Path = global::System.IO.Path.GetFullPath(filePath)
			}.Uri;
			return uri.ToString();
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000ACCC File Offset: 0x00008ECC
		private void EnsureModulesDiscovered()
		{
			global::Microsoft.Practices.Prism.Modularity.ModulesConfigurationSection modulesConfigurationSection = this.Store.RetrieveModuleConfigurationSection();
			if (modulesConfigurationSection != null)
			{
				foreach (object obj in modulesConfigurationSection.Modules)
				{
					global::Microsoft.Practices.Prism.Modularity.ModuleConfigurationElement moduleConfigurationElement = (global::Microsoft.Practices.Prism.Modularity.ModuleConfigurationElement)obj;
					global::System.Collections.Generic.IList<string> list = new global::System.Collections.Generic.List<string>();
					if (moduleConfigurationElement.Dependencies.Count > 0)
					{
						foreach (object obj2 in moduleConfigurationElement.Dependencies)
						{
							global::Microsoft.Practices.Prism.Modularity.ModuleDependencyConfigurationElement moduleDependencyConfigurationElement = (global::Microsoft.Practices.Prism.Modularity.ModuleDependencyConfigurationElement)obj2;
							list.Add(moduleDependencyConfigurationElement.ModuleName);
						}
					}
					global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo = new global::Microsoft.Practices.Prism.Modularity.ModuleInfo(moduleConfigurationElement.ModuleName, moduleConfigurationElement.ModuleType)
					{
						Ref = global::Microsoft.Practices.Prism.Modularity.ConfigurationModuleCatalog.GetFileAbsoluteUri(moduleConfigurationElement.AssemblyFile),
						InitializationMode = (moduleConfigurationElement.StartupLoaded ? global::Microsoft.Practices.Prism.Modularity.InitializationMode.WhenAvailable : global::Microsoft.Practices.Prism.Modularity.InitializationMode.OnDemand)
					};
					moduleInfo.DependsOn.AddRange(list.ToArray<string>());
					this.AddModule(moduleInfo);
				}
			}
		}
	}
}
