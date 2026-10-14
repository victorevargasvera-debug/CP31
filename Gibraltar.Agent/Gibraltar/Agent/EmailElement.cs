using System;
using System.Configuration;

namespace Gibraltar.Agent
{
	// Token: 0x0200026A RID: 618
	internal class EmailElement : global::System.Configuration.ConfigurationSection
	{
		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06001F93 RID: 8083 RVA: 0x00072F50 File Offset: 0x00071150
		// (set) Token: 0x06001F94 RID: 8084 RVA: 0x00072F64 File Offset: 0x00071164
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

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06001F95 RID: 8085 RVA: 0x00072F74 File Offset: 0x00071174
		// (set) Token: 0x06001F96 RID: 8086 RVA: 0x00072F88 File Offset: 0x00071188
		[global::System.Configuration.ConfigurationProperty("user", DefaultValue = "", IsRequired = false)]
		public string User
		{
			get
			{
				return (string)base["user"];
			}
			set
			{
				base["user"] = value;
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06001F97 RID: 8087 RVA: 0x00072F98 File Offset: 0x00071198
		// (set) Token: 0x06001F98 RID: 8088 RVA: 0x00072FAC File Offset: 0x000711AC
		[global::System.Configuration.ConfigurationProperty("password", DefaultValue = "", IsRequired = false)]
		public string Password
		{
			get
			{
				return (string)base["password"];
			}
			set
			{
				base["password"] = value;
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x00072FBC File Offset: 0x000711BC
		// (set) Token: 0x06001F9A RID: 8090 RVA: 0x00072FD0 File Offset: 0x000711D0
		[global::System.Configuration.ConfigurationProperty("port", DefaultValue = 0, IsRequired = false)]
		[global::System.Configuration.IntegerValidator(MinValue = 0, MaxValue = 65535)]
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

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x00072FE4 File Offset: 0x000711E4
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x00072FF8 File Offset: 0x000711F8
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

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x0007300C File Offset: 0x0007120C
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x00073020 File Offset: 0x00071220
		[global::System.Configuration.ConfigurationProperty("maxMessageSize", DefaultValue = 10, IsRequired = false)]
		[global::System.Configuration.IntegerValidator(MinValue = 0, MaxValue = 2048)]
		public int MaxMessageSize
		{
			get
			{
				return (int)base["maxMessageSize"];
			}
			set
			{
				base["maxMessageSizeMb"] = value;
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x00073034 File Offset: 0x00071234
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x00073048 File Offset: 0x00071248
		[global::System.Configuration.ConfigurationProperty("fromAddress", DefaultValue = "", IsRequired = false)]
		public string FromAddress
		{
			get
			{
				return (string)base["fromAddress"];
			}
			set
			{
				base["fromAddress"] = value;
			}
		}
	}
}
