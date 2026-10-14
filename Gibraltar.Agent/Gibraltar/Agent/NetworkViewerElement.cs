using System;
using System.Configuration;

namespace Gibraltar.Agent
{
	// Token: 0x02000268 RID: 616
	internal class NetworkViewerElement : global::System.Configuration.ConfigurationSection
	{
		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x00072DBC File Offset: 0x00070FBC
		// (set) Token: 0x06001F7E RID: 8062 RVA: 0x00072DD0 File Offset: 0x00070FD0
		[global::System.Configuration.ConfigurationProperty("enabled", DefaultValue = true, IsRequired = false)]
		public bool Enabled
		{
			get
			{
				return (bool)base["enabled"];
			}
			set
			{
				base["enabled"] = value;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06001F7F RID: 8063 RVA: 0x00072DE4 File Offset: 0x00070FE4
		// (set) Token: 0x06001F80 RID: 8064 RVA: 0x00072DF8 File Offset: 0x00070FF8
		[global::System.Configuration.ConfigurationProperty("allowLocalClients", DefaultValue = true, IsRequired = false)]
		public bool AllowLocalClients
		{
			get
			{
				return (bool)base["allowLocalClients"];
			}
			set
			{
				base["allowLocalClients"] = value;
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06001F81 RID: 8065 RVA: 0x00072E0C File Offset: 0x0007100C
		// (set) Token: 0x06001F82 RID: 8066 RVA: 0x00072E20 File Offset: 0x00071020
		[global::System.Configuration.ConfigurationProperty("allowRemoteClients", DefaultValue = false, IsRequired = false)]
		public bool AllowRemoteClients
		{
			get
			{
				return (bool)base["allowRemoteClients"];
			}
			set
			{
				base["allowRemoteClients"] = value;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x00072E34 File Offset: 0x00071034
		// (set) Token: 0x06001F84 RID: 8068 RVA: 0x00072E48 File Offset: 0x00071048
		[global::System.Configuration.ConfigurationProperty("maxQueueLength", DefaultValue = 2000, IsRequired = false)]
		[global::System.Configuration.IntegerValidator(MinValue = 1, MaxValue = 50000)]
		public int MaxQueueLength
		{
			get
			{
				return (int)base["maxQueueLength"];
			}
			set
			{
				base["maxQueueLength"] = value;
			}
		}
	}
}
