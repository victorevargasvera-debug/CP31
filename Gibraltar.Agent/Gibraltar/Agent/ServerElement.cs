using System;
using System.Configuration;

namespace Gibraltar.Agent
{
	// Token: 0x0200026D RID: 621
	internal class ServerElement : global::System.Configuration.ConfigurationSection
	{
		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x000730E0 File Offset: 0x000712E0
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x000730F4 File Offset: 0x000712F4
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

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x00073108 File Offset: 0x00071308
		// (set) Token: 0x06001FAE RID: 8110 RVA: 0x0007311C File Offset: 0x0007131C
		[global::System.Configuration.ConfigurationProperty("autoSendSessions", DefaultValue = false, IsRequired = false)]
		public bool AutoSendSessions
		{
			get
			{
				return (bool)base["autoSendSessions"];
			}
			set
			{
				base["autoSendSessions"] = value;
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x00073130 File Offset: 0x00071330
		// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x00073144 File Offset: 0x00071344
		[global::System.Configuration.ConfigurationProperty("autoSendOnError", DefaultValue = true, IsRequired = false)]
		public bool AutoSendOnError
		{
			get
			{
				return (bool)base["autoSendOnError"];
			}
			set
			{
				base["autoSendOnError"] = value;
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x00073158 File Offset: 0x00071358
		// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x0007316C File Offset: 0x0007136C
		[global::System.Configuration.ConfigurationProperty("sendAllApplications", DefaultValue = false, IsRequired = false)]
		public bool SendAllApplications
		{
			get
			{
				return (bool)base["sendAllApplications"];
			}
			set
			{
				base["sendAllApplications"] = value;
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x00073180 File Offset: 0x00071380
		// (set) Token: 0x06001FB4 RID: 8116 RVA: 0x00073194 File Offset: 0x00071394
		[global::System.Configuration.ConfigurationProperty("purgeSentSessions", DefaultValue = false, IsRequired = false)]
		public bool PurgeSentSessions
		{
			get
			{
				return (bool)base["purgeSentSessions"];
			}
			set
			{
				base["purgeSentSessions"] = value;
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x000731A8 File Offset: 0x000713A8
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x000731BC File Offset: 0x000713BC
		[global::System.Configuration.ConfigurationProperty("customerName", DefaultValue = "", IsRequired = false)]
		public string CustomerName
		{
			get
			{
				return (string)base["customerName"];
			}
			set
			{
				base["customerName"] = value;
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x000731CC File Offset: 0x000713CC
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x000731E0 File Offset: 0x000713E0
		[global::System.Configuration.ConfigurationProperty("useGibraltarService", DefaultValue = false, IsRequired = false)]
		public bool UseGibraltarService
		{
			get
			{
				return (bool)base["useGibraltarService"];
			}
			set
			{
				base["useGibraltarService"] = value;
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x000731F4 File Offset: 0x000713F4
		// (set) Token: 0x06001FBA RID: 8122 RVA: 0x00073208 File Offset: 0x00071408
		[global::System.Configuration.ConfigurationProperty("useSsl", DefaultValue = false, IsRequired = false)]
		public bool UseSsl
		{
			get
			{
				return (bool)base["useSsl"];
			}
			set
			{
				base["useSsl"] = value;
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001FBB RID: 8123 RVA: 0x0007321C File Offset: 0x0007141C
		// (set) Token: 0x06001FBC RID: 8124 RVA: 0x00073230 File Offset: 0x00071430
		[global::System.Configuration.ConfigurationProperty("server", DefaultValue = "", IsRequired = false)]
		public string Server
		{
			get
			{
				return (string)base["server"];
			}
			set
			{
				base["server"] = value;
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x00073240 File Offset: 0x00071440
		// (set) Token: 0x06001FBE RID: 8126 RVA: 0x00073254 File Offset: 0x00071454
		[global::System.Configuration.ConfigurationProperty("port", DefaultValue = 0, IsRequired = false)]
		public int Port
		{
			get
			{
				return (int)base["port"];
			}
			set
			{
				base["port"] = value;
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06001FBF RID: 8127 RVA: 0x00073268 File Offset: 0x00071468
		// (set) Token: 0x06001FC0 RID: 8128 RVA: 0x0007327C File Offset: 0x0007147C
		[global::System.Configuration.ConfigurationProperty("applicationBaseDirectory", DefaultValue = "", IsRequired = false)]
		public string ApplicationBaseDirectory
		{
			get
			{
				return (string)base["applicationBaseDirectory"];
			}
			set
			{
				base["applicationBaseDirectory"] = value;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x0007328C File Offset: 0x0007148C
		// (set) Token: 0x06001FC2 RID: 8130 RVA: 0x000732A0 File Offset: 0x000714A0
		[global::System.Configuration.ConfigurationProperty("repository", DefaultValue = "", IsRequired = false)]
		public string Repository
		{
			get
			{
				return (string)base["repository"];
			}
			set
			{
				base["repository"] = value;
			}
		}
	}
}
