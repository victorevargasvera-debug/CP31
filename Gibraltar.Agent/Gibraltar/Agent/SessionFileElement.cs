using System;
using System.Configuration;

namespace Gibraltar.Agent
{
	// Token: 0x0200026E RID: 622
	internal class SessionFileElement : global::System.Configuration.ConfigurationSection
	{
		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x000732B8 File Offset: 0x000714B8
		// (set) Token: 0x06001FC5 RID: 8133 RVA: 0x000732CC File Offset: 0x000714CC
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

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x000732E0 File Offset: 0x000714E0
		// (set) Token: 0x06001FC7 RID: 8135 RVA: 0x000732F4 File Offset: 0x000714F4
		[global::System.Configuration.ConfigurationProperty("folder", DefaultValue = "", IsRequired = false)]
		public string Folder
		{
			get
			{
				return base["folder"].ToString();
			}
			set
			{
				base["folder"] = value;
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x00073304 File Offset: 0x00071504
		// (set) Token: 0x06001FC9 RID: 8137 RVA: 0x00073318 File Offset: 0x00071518
		[global::System.Configuration.ConfigurationProperty("autoFlushInterval", DefaultValue = 15, IsRequired = false)]
		[global::System.Configuration.IntegerValidator(MinValue = 0, MaxValue = 2147483647)]
		public int AutoFlushInterval
		{
			get
			{
				return (int)base["autoFlushInterval"];
			}
			set
			{
				base["autoFlushInterval"] = value;
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06001FCA RID: 8138 RVA: 0x0007332C File Offset: 0x0007152C
		// (set) Token: 0x06001FCB RID: 8139 RVA: 0x00073340 File Offset: 0x00071540
		[global::System.Configuration.ConfigurationProperty("indexUpdateInterval", DefaultValue = 15, IsRequired = false)]
		[global::System.Configuration.IntegerValidator(MinValue = 0, MaxValue = 2147483647)]
		public int IndexUpdateInterval
		{
			get
			{
				return (int)base["indexUpdateInterval"];
			}
			set
			{
				base["indexUpdateInterval"] = value;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x00073354 File Offset: 0x00071554
		// (set) Token: 0x06001FCD RID: 8141 RVA: 0x00073368 File Offset: 0x00071568
		[global::System.Configuration.ConfigurationProperty("maxFileSize", DefaultValue = 20, IsRequired = false)]
		[global::System.Configuration.IntegerValidator(MinValue = 0, MaxValue = 2147483647)]
		public int MaxFileSize
		{
			get
			{
				return (int)base["maxFileSize"];
			}
			set
			{
				base["maxFileSize"] = value;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x0007337C File Offset: 0x0007157C
		// (set) Token: 0x06001FCF RID: 8143 RVA: 0x00073390 File Offset: 0x00071590
		[global::System.Configuration.ConfigurationProperty("maxFileDuration", DefaultValue = 1440, IsRequired = false)]
		public int MaxFileDuration
		{
			get
			{
				return (int)base["maxFileDuration"];
			}
			set
			{
				base["maxFileDuration"] = value;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x000733A4 File Offset: 0x000715A4
		// (set) Token: 0x06001FD1 RID: 8145 RVA: 0x000733B8 File Offset: 0x000715B8
		[global::System.Configuration.ConfigurationProperty("enableFilePruning", DefaultValue = true, IsRequired = false)]
		public bool EnableFilePruning
		{
			get
			{
				return (bool)base["enableFilePruning"];
			}
			set
			{
				base["enableFilePruning"] = value;
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x000733CC File Offset: 0x000715CC
		// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x000733E0 File Offset: 0x000715E0
		[global::System.Configuration.ConfigurationProperty("maxLocalDiskUsage", DefaultValue = 150, IsRequired = false)]
		public int MaxLocalDiskUsage
		{
			get
			{
				return (int)base["maxLocalDiskUsage"];
			}
			set
			{
				base["maxLocalDiskUsage"] = value;
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x000733F4 File Offset: 0x000715F4
		// (set) Token: 0x06001FD5 RID: 8149 RVA: 0x00073408 File Offset: 0x00071608
		[global::System.Configuration.ConfigurationProperty("maxLocalFileAge", DefaultValue = 90, IsRequired = false)]
		public int MaxLocalFileAge
		{
			get
			{
				return (int)base["maxLocalFileAge"];
			}
			set
			{
				base["maxLocalFileAge"] = value;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x0007341C File Offset: 0x0007161C
		// (set) Token: 0x06001FD7 RID: 8151 RVA: 0x00073430 File Offset: 0x00071630
		[global::System.Configuration.ConfigurationProperty("minimumFreeDisk", DefaultValue = 200, IsRequired = false)]
		[global::System.Configuration.IntegerValidator(MinValue = 1, MaxValue = 2147483647)]
		public int MinimumFreeDisk
		{
			get
			{
				return (int)base["minimumFreeDisk"];
			}
			set
			{
				base["minimumFreeDisk"] = value;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x00073444 File Offset: 0x00071644
		// (set) Token: 0x06001FD9 RID: 8153 RVA: 0x00073458 File Offset: 0x00071658
		[global::System.Configuration.ConfigurationProperty("forceSynchronous", DefaultValue = false, IsRequired = false)]
		public bool ForceSynchronous
		{
			get
			{
				return (bool)base["forceSynchronous"];
			}
			set
			{
				base["forceSynchronous"] = value;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06001FDA RID: 8154 RVA: 0x0007346C File Offset: 0x0007166C
		// (set) Token: 0x06001FDB RID: 8155 RVA: 0x00073480 File Offset: 0x00071680
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
