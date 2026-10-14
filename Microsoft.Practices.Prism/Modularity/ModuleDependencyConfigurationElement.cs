using System;
using System.Configuration;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000040 RID: 64
	public class ModuleDependencyConfigurationElement : global::System.Configuration.ConfigurationElement
	{
		// Token: 0x06000193 RID: 403 RVA: 0x00005D6C File Offset: 0x00003F6C
		public ModuleDependencyConfigurationElement()
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00005D74 File Offset: 0x00003F74
		public ModuleDependencyConfigurationElement(string moduleName)
		{
			base["moduleName"] = moduleName;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00005D88 File Offset: 0x00003F88
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00005D9A File Offset: 0x00003F9A
		[global::System.Configuration.ConfigurationProperty("moduleName", IsRequired = true, IsKey = true)]
		public string ModuleName
		{
			get
			{
				return (string)base["moduleName"];
			}
			set
			{
				base["moduleName"] = value;
			}
		}
	}
}
