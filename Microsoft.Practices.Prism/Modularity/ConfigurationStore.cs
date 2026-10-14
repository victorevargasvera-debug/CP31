using System;
using System.Configuration;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000028 RID: 40
	public class ConfigurationStore : global::Microsoft.Practices.Prism.Modularity.IConfigurationStore
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00004373 File Offset: 0x00002573
		public global::Microsoft.Practices.Prism.Modularity.ModulesConfigurationSection RetrieveModuleConfigurationSection()
		{
			return global::System.Configuration.ConfigurationManager.GetSection("modules") as global::Microsoft.Practices.Prism.Modularity.ModulesConfigurationSection;
		}
	}
}
