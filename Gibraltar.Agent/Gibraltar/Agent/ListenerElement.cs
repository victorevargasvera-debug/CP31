using System;
using System.Configuration;

namespace Gibraltar.Agent
{
	// Token: 0x0200026F RID: 623
	internal class ListenerElement : global::System.Configuration.ConfigurationSection
	{
		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x0007349C File Offset: 0x0007169C
		// (set) Token: 0x06001FDE RID: 8158 RVA: 0x000734B0 File Offset: 0x000716B0
		[global::System.Configuration.ConfigurationProperty("autoTraceRegistration", DefaultValue = true, IsRequired = false)]
		public bool AutoTraceRegistration
		{
			get
			{
				return (bool)base["autoTraceRegistration"];
			}
			set
			{
				base["autoTraceRegistration"] = value;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x000734C4 File Offset: 0x000716C4
		// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x000734D8 File Offset: 0x000716D8
		[global::System.Configuration.ConfigurationProperty("enableCommandLine", DefaultValue = true, IsRequired = false)]
		public bool EnableCommandLine
		{
			get
			{
				return (bool)base["enableCommandLine"];
			}
			set
			{
				base["enableCommandLine"] = value;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x000734EC File Offset: 0x000716EC
		// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x00073500 File Offset: 0x00071700
		[global::System.Configuration.ConfigurationProperty("enableConsole", DefaultValue = true, IsRequired = false)]
		public bool EnableConsole
		{
			get
			{
				return (bool)base["enableConsole"];
			}
			set
			{
				base["enableConsole"] = value;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x00073514 File Offset: 0x00071714
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x00073528 File Offset: 0x00071728
		[global::System.Configuration.ConfigurationProperty("enableProcessPerformance", DefaultValue = true, IsRequired = false)]
		public bool EnableProcessPerformance
		{
			get
			{
				return (bool)base["enableProcessPerformance"];
			}
			set
			{
				base["enableProcessPerformance"] = value;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x0007353C File Offset: 0x0007173C
		// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x00073550 File Offset: 0x00071750
		[global::System.Configuration.ConfigurationProperty("enableDiskPerformance", DefaultValue = true, IsRequired = false)]
		public bool EnableDiskPerformance
		{
			get
			{
				return (bool)base["enableDiskPerformance"];
			}
			set
			{
				base["enableDiskPerformance"] = value;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x00073564 File Offset: 0x00071764
		// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x00073578 File Offset: 0x00071778
		[global::System.Configuration.ConfigurationProperty("enableMemoryPerformance", DefaultValue = false, IsRequired = false)]
		public bool EnableMemoryPerformance
		{
			get
			{
				return (bool)base["enableMemoryPerformance"];
			}
			set
			{
				base["enableMemoryPerformance"] = value;
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x0007358C File Offset: 0x0007178C
		// (set) Token: 0x06001FEA RID: 8170 RVA: 0x000735A0 File Offset: 0x000717A0
		[global::System.Configuration.ConfigurationProperty("enableNetworkPerformance", DefaultValue = true, IsRequired = false)]
		public bool EnableNetworkPerformance
		{
			get
			{
				return (bool)base["enableNetworkPerformance"];
			}
			set
			{
				base["enableNetworkPerformance"] = value;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x000735B4 File Offset: 0x000717B4
		// (set) Token: 0x06001FEC RID: 8172 RVA: 0x000735C8 File Offset: 0x000717C8
		[global::System.Configuration.ConfigurationProperty("enableSystemPerformance", DefaultValue = true, IsRequired = false)]
		public bool EnableSystemPerformance
		{
			get
			{
				return (bool)base["enableSystemPerformance"];
			}
			set
			{
				base["enableSystemPerformance"] = value;
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x000735DC File Offset: 0x000717DC
		// (set) Token: 0x06001FEE RID: 8174 RVA: 0x000735F0 File Offset: 0x000717F0
		[global::System.Configuration.ConfigurationProperty("enableNetworkEvents", DefaultValue = true, IsRequired = false)]
		public bool EnableNetworkEvents
		{
			get
			{
				return (bool)base["enableNetworkEvents"];
			}
			set
			{
				base["enableNetworkEvents"] = value;
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x00073604 File Offset: 0x00071804
		// (set) Token: 0x06001FF0 RID: 8176 RVA: 0x00073618 File Offset: 0x00071818
		[global::System.Configuration.ConfigurationProperty("enablePowerEvents", DefaultValue = true, IsRequired = false)]
		public bool EnablePowerEvents
		{
			get
			{
				return (bool)base["enablePowerEvents"];
			}
			set
			{
				base["enablePowerEvents"] = value;
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x0007362C File Offset: 0x0007182C
		// (set) Token: 0x06001FF2 RID: 8178 RVA: 0x00073640 File Offset: 0x00071840
		[global::System.Configuration.ConfigurationProperty("enableUserEvents", DefaultValue = true, IsRequired = false)]
		public bool EnableUserEvents
		{
			get
			{
				return (bool)base["enableUserEvents"];
			}
			set
			{
				base["enableUserEvents"] = value;
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x00073654 File Offset: 0x00071854
		// (set) Token: 0x06001FF4 RID: 8180 RVA: 0x00073668 File Offset: 0x00071868
		[global::System.Configuration.ConfigurationProperty("enableAssemblyEvents", DefaultValue = true, IsRequired = false)]
		public bool EnableAssemblyEvents
		{
			get
			{
				return (bool)base["enableAssemblyEvents"];
			}
			set
			{
				base["enableAssemblyEvents"] = value;
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x0007367C File Offset: 0x0007187C
		// (set) Token: 0x06001FF6 RID: 8182 RVA: 0x00073690 File Offset: 0x00071890
		[global::System.Configuration.ConfigurationProperty("enableAssemblyLoadFailureEvents", DefaultValue = false, IsRequired = false)]
		public bool EnableAssemblyLoadFailureEvents
		{
			get
			{
				return (bool)base["enableAssemblyLoadFailureEvents"];
			}
			set
			{
				base["enableAssemblyLoadFailureEvents"] = value;
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x000736A4 File Offset: 0x000718A4
		// (set) Token: 0x06001FF8 RID: 8184 RVA: 0x000736B8 File Offset: 0x000718B8
		[global::System.Configuration.ConfigurationProperty("catchUnhandledExceptions", DefaultValue = true, IsRequired = false)]
		public bool CatchUnhandledExceptions
		{
			get
			{
				return (bool)base["catchUnhandledExceptions"];
			}
			set
			{
				base["catchUnhandledExceptions"] = value;
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x000736CC File Offset: 0x000718CC
		// (set) Token: 0x06001FFA RID: 8186 RVA: 0x000736E0 File Offset: 0x000718E0
		[global::System.Configuration.ConfigurationProperty("catchApplicationExceptions", DefaultValue = true, IsRequired = false)]
		public bool CatchApplicationExceptions
		{
			get
			{
				return (bool)base["catchApplicationExceptions"];
			}
			set
			{
				base["catchApplicationExceptions"] = value;
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x000736F4 File Offset: 0x000718F4
		// (set) Token: 0x06001FFC RID: 8188 RVA: 0x00073708 File Offset: 0x00071908
		[global::System.Configuration.ConfigurationProperty("reportErrorsToUser", DefaultValue = true, IsRequired = false)]
		public bool ReportErrorsToUser
		{
			get
			{
				return (bool)base["reportErrorsToUser"];
			}
			set
			{
				base["reportErrorsToUser"] = value;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x0007371C File Offset: 0x0007191C
		// (set) Token: 0x06001FFE RID: 8190 RVA: 0x00073730 File Offset: 0x00071930
		[global::System.Configuration.ConfigurationProperty("endSessionOnTraceClose", DefaultValue = true, IsRequired = false)]
		public bool EndSessionOnTraceClose
		{
			get
			{
				return (bool)base["endSessionOnTraceClose"];
			}
			set
			{
				base["endSessionOnTraceClose"] = value;
			}
		}
	}
}
