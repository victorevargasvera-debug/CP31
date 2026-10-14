using System;
using System.Configuration;

namespace Gibraltar.Agent
{
	// Token: 0x02000270 RID: 624
	internal class PackagerElement : global::System.Configuration.ConfigurationSection
	{
		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x0007374C File Offset: 0x0007194C
		// (set) Token: 0x06002001 RID: 8193 RVA: 0x00073760 File Offset: 0x00071960
		[global::System.Configuration.ConfigurationProperty("hotKey", DefaultValue = "Ctrl-Alt-F4", IsRequired = false)]
		public string HotKey
		{
			get
			{
				return (string)base["hotKey"];
			}
			set
			{
				base["hotKey"] = value;
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x00073770 File Offset: 0x00071970
		// (set) Token: 0x06002003 RID: 8195 RVA: 0x00073784 File Offset: 0x00071984
		[global::System.Configuration.ConfigurationProperty("allowFile", DefaultValue = true, IsRequired = false)]
		public bool AllowFile
		{
			get
			{
				return (bool)base["allowFile"];
			}
			set
			{
				base["allowFile"] = value;
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x00073798 File Offset: 0x00071998
		// (set) Token: 0x06002005 RID: 8197 RVA: 0x000737AC File Offset: 0x000719AC
		[global::System.Configuration.ConfigurationProperty("allowRemovableMedia", DefaultValue = true, IsRequired = false)]
		public bool AllowRemovableMedia
		{
			get
			{
				return (bool)base["allowRemovableMedia"];
			}
			set
			{
				base["allowRemovableMedia"] = value;
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x000737C0 File Offset: 0x000719C0
		// (set) Token: 0x06002007 RID: 8199 RVA: 0x000737D4 File Offset: 0x000719D4
		[global::System.Configuration.ConfigurationProperty("allowServer", DefaultValue = true, IsRequired = false)]
		public bool AllowServer
		{
			get
			{
				return (bool)base["allowServer"];
			}
			set
			{
				base["allowServer"] = value;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x000737E8 File Offset: 0x000719E8
		// (set) Token: 0x06002009 RID: 8201 RVA: 0x000737FC File Offset: 0x000719FC
		[global::System.Configuration.ConfigurationProperty("allowEmail", DefaultValue = true, IsRequired = false)]
		public bool AllowEmail
		{
			get
			{
				return (bool)base["allowEmail"];
			}
			set
			{
				base["allowEmail"] = value;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x0600200A RID: 8202 RVA: 0x00073810 File Offset: 0x00071A10
		// (set) Token: 0x0600200B RID: 8203 RVA: 0x00073824 File Offset: 0x00071A24
		[global::System.Configuration.ConfigurationProperty("fromEmailAddress", DefaultValue = "", IsRequired = false)]
		public string FromEmailAddress
		{
			get
			{
				return (string)base["fromEmailAddress"];
			}
			set
			{
				base["fromEmailAddress"] = value;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x00073834 File Offset: 0x00071A34
		// (set) Token: 0x0600200D RID: 8205 RVA: 0x00073848 File Offset: 0x00071A48
		[global::System.Configuration.ConfigurationProperty("destinationEmailAddress", DefaultValue = "", IsRequired = false)]
		public string DestinationEmailAddress
		{
			get
			{
				return (string)base["destinationEmailAddress"];
			}
			set
			{
				base["destinationEmailAddress"] = value;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x00073858 File Offset: 0x00071A58
		// (set) Token: 0x0600200F RID: 8207 RVA: 0x0007386C File Offset: 0x00071A6C
		[global::System.Configuration.ConfigurationProperty("productName", DefaultValue = "", IsRequired = false)]
		public string ProductName
		{
			get
			{
				return (string)base["productName"];
			}
			set
			{
				base["productName"] = value;
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x0007387C File Offset: 0x00071A7C
		// (set) Token: 0x06002011 RID: 8209 RVA: 0x00073890 File Offset: 0x00071A90
		[global::System.Configuration.ConfigurationProperty("applicationName", DefaultValue = "", IsRequired = false)]
		public string ApplicationName
		{
			get
			{
				return (string)base["applicationName"];
			}
			set
			{
				base["applicationName"] = value;
			}
		}

		// Token: 0x04000BF8 RID: 3064
		public const string DefaultHotKey = "Ctrl-Alt-F4";
	}
}
