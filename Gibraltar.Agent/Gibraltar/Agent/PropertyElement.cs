using System;
using System.Configuration;

namespace Gibraltar.Agent
{
	// Token: 0x0200026C RID: 620
	internal class PropertyElement : global::System.Configuration.ConfigurationSection
	{
		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x00073090 File Offset: 0x00071290
		// (set) Token: 0x06001FA7 RID: 8103 RVA: 0x000730A4 File Offset: 0x000712A4
		[global::System.Configuration.ConfigurationProperty("name", DefaultValue = "", IsRequired = true)]
		public string Name
		{
			get
			{
				return (string)base["name"];
			}
			set
			{
				base["name"] = value;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x000730B4 File Offset: 0x000712B4
		// (set) Token: 0x06001FA9 RID: 8105 RVA: 0x000730C8 File Offset: 0x000712C8
		[global::System.Configuration.ConfigurationProperty("value", DefaultValue = "", IsRequired = true)]
		public string Value
		{
			get
			{
				return (string)base["value"];
			}
			set
			{
				base["value"] = value;
			}
		}
	}
}
