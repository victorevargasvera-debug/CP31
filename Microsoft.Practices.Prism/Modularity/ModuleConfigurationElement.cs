using System;
using System.Configuration;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x0200003C RID: 60
	public class ModuleConfigurationElement : global::System.Configuration.ConfigurationElement
	{
		// Token: 0x06000173 RID: 371 RVA: 0x00005AF8 File Offset: 0x00003CF8
		public ModuleConfigurationElement()
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00005B00 File Offset: 0x00003D00
		public ModuleConfigurationElement(string assemblyFile, string moduleType, string moduleName, bool startupLoaded)
		{
			base["assemblyFile"] = assemblyFile;
			base["moduleType"] = moduleType;
			base["moduleName"] = moduleName;
			base["startupLoaded"] = startupLoaded;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00005B3E File Offset: 0x00003D3E
		// (set) Token: 0x06000176 RID: 374 RVA: 0x00005B50 File Offset: 0x00003D50
		[global::System.Configuration.ConfigurationProperty("assemblyFile", IsRequired = true)]
		public string AssemblyFile
		{
			get
			{
				return (string)base["assemblyFile"];
			}
			set
			{
				base["assemblyFile"] = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00005B5E File Offset: 0x00003D5E
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00005B70 File Offset: 0x00003D70
		[global::System.Configuration.ConfigurationProperty("moduleType", IsRequired = true)]
		public string ModuleType
		{
			get
			{
				return (string)base["moduleType"];
			}
			set
			{
				base["moduleType"] = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00005B7E File Offset: 0x00003D7E
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00005B90 File Offset: 0x00003D90
		[global::System.Configuration.ConfigurationProperty("moduleName", IsRequired = true)]
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

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00005B9E File Offset: 0x00003D9E
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[global::System.Configuration.ConfigurationProperty("startupLoaded", IsRequired = false, DefaultValue = true)]
		public bool StartupLoaded
		{
			get
			{
				return (bool)base["startupLoaded"];
			}
			set
			{
				base["startupLoaded"] = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600017D RID: 381 RVA: 0x00005BC3 File Offset: 0x00003DC3
		// (set) Token: 0x0600017E RID: 382 RVA: 0x00005BD5 File Offset: 0x00003DD5
		[global::System.Configuration.ConfigurationProperty("dependencies", IsDefaultCollection = true, IsKey = false)]
		public global::Microsoft.Practices.Prism.Modularity.ModuleDependencyCollection Dependencies
		{
			get
			{
				return (global::Microsoft.Practices.Prism.Modularity.ModuleDependencyCollection)base["dependencies"];
			}
			set
			{
				base["dependencies"] = value;
			}
		}
	}
}
