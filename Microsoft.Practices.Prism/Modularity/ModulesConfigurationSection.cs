using System;
using System.Configuration;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000046 RID: 70
	public class ModulesConfigurationSection : global::System.Configuration.ConfigurationSection
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001CA RID: 458 RVA: 0x000064E6 File Offset: 0x000046E6
		// (set) Token: 0x060001CB RID: 459 RVA: 0x000064F8 File Offset: 0x000046F8
		[global::System.Configuration.ConfigurationProperty("", IsDefaultCollection = true, IsKey = false)]
		public global::Microsoft.Practices.Prism.Modularity.ModuleConfigurationElementCollection Modules
		{
			get
			{
				return (global::Microsoft.Practices.Prism.Modularity.ModuleConfigurationElementCollection)base[""];
			}
			set
			{
				base[""] = value;
			}
		}
	}
}
