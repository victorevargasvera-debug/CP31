using System;
using System.Configuration;
using Loupe.Extensibility.Data;

namespace Gibraltar.Agent
{
	// Token: 0x02000272 RID: 626
	internal class ViewerElement : global::System.Configuration.ConfigurationSection
	{
		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x00073A4C File Offset: 0x00071C4C
		// (set) Token: 0x0600202B RID: 8235 RVA: 0x00073A60 File Offset: 0x00071C60
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

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x0600202C RID: 8236 RVA: 0x00073A74 File Offset: 0x00071C74
		// (set) Token: 0x0600202D RID: 8237 RVA: 0x00073A88 File Offset: 0x00071C88
		[global::System.Configuration.ConfigurationProperty("hotKey", DefaultValue = "Ctrl-Alt-F5", IsRequired = false)]
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

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x00073A98 File Offset: 0x00071C98
		// (set) Token: 0x0600202F RID: 8239 RVA: 0x00073AAC File Offset: 0x00071CAC
		[global::System.Configuration.ConfigurationProperty("maxMessages", DefaultValue = 10000, IsRequired = false)]
		[global::System.Configuration.IntegerValidator(MinValue = 0, MaxValue = 500000)]
		public int MaxMessages
		{
			get
			{
				return (int)base["maxMessages"];
			}
			set
			{
				base["maxMessages"] = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x00073AC0 File Offset: 0x00071CC0
		// (set) Token: 0x06002031 RID: 8241 RVA: 0x00073AD4 File Offset: 0x00071CD4
		[global::System.Configuration.ConfigurationProperty("showVerboseMessages", DefaultValue = true, IsRequired = false)]
		public bool ShowVerboseMessages
		{
			get
			{
				return (bool)base["showVerboseMessages"];
			}
			set
			{
				base["showVerboseMessages"] = value;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06002032 RID: 8242 RVA: 0x00073AE8 File Offset: 0x00071CE8
		// (set) Token: 0x06002033 RID: 8243 RVA: 0x00073AFC File Offset: 0x00071CFC
		[global::System.Configuration.ConfigurationProperty("formTitleText", DefaultValue = "Gibraltar Live Log Viewer", IsRequired = false)]
		public string FormTitleText
		{
			get
			{
				return (string)base["formTitleText"];
			}
			set
			{
				base["formTitleText"] = value;
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x00073B0C File Offset: 0x00071D0C
		// (set) Token: 0x06002035 RID: 8245 RVA: 0x00073B20 File Offset: 0x00071D20
		[global::System.Configuration.ConfigurationProperty("defaultFilterLevel", DefaultValue = global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, IsRequired = false)]
		public global::Loupe.Extensibility.Data.LogMessageSeverity DefaultFilterLevel
		{
			get
			{
				return (global::Loupe.Extensibility.Data.LogMessageSeverity)base["defaultFilterLevel"];
			}
			set
			{
				base["defaultFilterLevel"] = value;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x00073B34 File Offset: 0x00071D34
		// (set) Token: 0x06002037 RID: 8247 RVA: 0x00073B48 File Offset: 0x00071D48
		[global::System.Configuration.ConfigurationProperty("enableIndependentSeverityFilters", DefaultValue = false, IsRequired = false)]
		public bool EnableIndependentSeverityFilters
		{
			get
			{
				return (bool)base["enableIndependentSeverityFilters"];
			}
			set
			{
				base["enableIndependentSeverityFilters"] = value;
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x00073B5C File Offset: 0x00071D5C
		// (set) Token: 0x06002039 RID: 8249 RVA: 0x00073B70 File Offset: 0x00071D70
		[global::System.Configuration.ConfigurationProperty("showDetailsButton", DefaultValue = true, IsRequired = false)]
		public bool ShowDetailsButton
		{
			get
			{
				return (bool)base["showDetailsButton"];
			}
			set
			{
				base["showDetailsButton"] = value;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x0600203A RID: 8250 RVA: 0x00073B84 File Offset: 0x00071D84
		// (set) Token: 0x0600203B RID: 8251 RVA: 0x00073B98 File Offset: 0x00071D98
		[global::System.Configuration.ConfigurationProperty("showDetailsInGrid", DefaultValue = true, IsRequired = false)]
		public bool ShowDetailsInGrid
		{
			get
			{
				return (bool)base["showDetailsInGrid"];
			}
			set
			{
				base["showDetailsInGrid"] = value;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x0600203C RID: 8252 RVA: 0x00073BAC File Offset: 0x00071DAC
		// (set) Token: 0x0600203D RID: 8253 RVA: 0x00073BC0 File Offset: 0x00071DC0
		[global::System.Configuration.ConfigurationProperty("showDetailsInTooltips", DefaultValue = false, IsRequired = false)]
		public bool ShowDetailsInTooltips
		{
			get
			{
				return (bool)base["showDetailsInTooltips"];
			}
			set
			{
				base["showDetailsInTooltips"] = value;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x0600203E RID: 8254 RVA: 0x00073BD4 File Offset: 0x00071DD4
		// (set) Token: 0x0600203F RID: 8255 RVA: 0x00073BE8 File Offset: 0x00071DE8
		[global::System.Configuration.ConfigurationProperty("showMessageCounters", DefaultValue = true, IsRequired = false)]
		public bool ShowMessageCounters
		{
			get
			{
				return (bool)base["showMessageCounters"];
			}
			set
			{
				base["showMessageCounters"] = value;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06002040 RID: 8256 RVA: 0x00073BFC File Offset: 0x00071DFC
		// (set) Token: 0x06002041 RID: 8257 RVA: 0x00073C10 File Offset: 0x00071E10
		[global::System.Configuration.ConfigurationProperty("runButtonText", DefaultValue = "Click to Auto Refresh", IsRequired = false)]
		public string RunButtonText
		{
			get
			{
				return (string)base["runButtonText"];
			}
			set
			{
				base["runButtonText"] = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06002042 RID: 8258 RVA: 0x00073C20 File Offset: 0x00071E20
		// (set) Token: 0x06002043 RID: 8259 RVA: 0x00073C34 File Offset: 0x00071E34
		[global::System.Configuration.ConfigurationProperty("runButtonTextVisible", DefaultValue = false, IsRequired = false)]
		public bool RunButtonTextVisible
		{
			get
			{
				return (bool)base["runButtonTextVisible"];
			}
			set
			{
				base["runButtonTextVisible"] = value;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06002044 RID: 8260 RVA: 0x00073C48 File Offset: 0x00071E48
		// (set) Token: 0x06002045 RID: 8261 RVA: 0x00073C5C File Offset: 0x00071E5C
		[global::System.Configuration.ConfigurationProperty("pauseButtonText", DefaultValue = "Pause", IsRequired = false)]
		public string PauseButtonText
		{
			get
			{
				return (string)base["pauseButtonText"];
			}
			set
			{
				base["pauseButtonText"] = value;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06002046 RID: 8262 RVA: 0x00073C6C File Offset: 0x00071E6C
		// (set) Token: 0x06002047 RID: 8263 RVA: 0x00073C80 File Offset: 0x00071E80
		[global::System.Configuration.ConfigurationProperty("pauseButtonTextVisible", DefaultValue = false, IsRequired = false)]
		public bool PauseButtonTextVisible
		{
			get
			{
				return (bool)base["pauseButtonTextVisible"];
			}
			set
			{
				base["pauseButtonTextVisible"] = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x00073C94 File Offset: 0x00071E94
		// (set) Token: 0x06002049 RID: 8265 RVA: 0x00073CA8 File Offset: 0x00071EA8
		[global::System.Configuration.ConfigurationProperty("resetSearchButtonText", DefaultValue = "Reset", IsRequired = false)]
		public string ResetSearchButtonText
		{
			get
			{
				return (string)base["resetSearchButtonText"];
			}
			set
			{
				base["resetSearchButtonText"] = value;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x0600204A RID: 8266 RVA: 0x00073CB8 File Offset: 0x00071EB8
		// (set) Token: 0x0600204B RID: 8267 RVA: 0x00073CCC File Offset: 0x00071ECC
		[global::System.Configuration.ConfigurationProperty("resetSearchButtonTextVisible", DefaultValue = false, IsRequired = false)]
		public bool ResetSearchButtonTextVisible
		{
			get
			{
				return (bool)base["resetSearchButtonTextVisible"];
			}
			set
			{
				base["resetSearchButtonTextVisible"] = value;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x0600204C RID: 8268 RVA: 0x00073CE0 File Offset: 0x00071EE0
		// (set) Token: 0x0600204D RID: 8269 RVA: 0x00073CF4 File Offset: 0x00071EF4
		[global::System.Configuration.ConfigurationProperty("clearMessagesButtonText", DefaultValue = "Clear", IsRequired = false)]
		public string ClearMessagesButtonText
		{
			get
			{
				return (string)base["clearMessagesButtonText"];
			}
			set
			{
				base["clearMessagesButtonText"] = value;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x0600204E RID: 8270 RVA: 0x00073D04 File Offset: 0x00071F04
		// (set) Token: 0x0600204F RID: 8271 RVA: 0x00073D18 File Offset: 0x00071F18
		[global::System.Configuration.ConfigurationProperty("clearMessagesButtonTextVisible", DefaultValue = false, IsRequired = false)]
		public bool ClearMessagesButtonTextVisible
		{
			get
			{
				return (bool)base["clearMessagesButtonTextVisible"];
			}
			set
			{
				base["clearMessagesButtonTextVisible"] = value;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002050 RID: 8272 RVA: 0x00073D2C File Offset: 0x00071F2C
		// (set) Token: 0x06002051 RID: 8273 RVA: 0x00073D40 File Offset: 0x00071F40
		[global::System.Configuration.ConfigurationProperty("showToolBar", DefaultValue = true, IsRequired = false)]
		public bool ShowToolBar
		{
			get
			{
				return (bool)base["showToolBar"];
			}
			set
			{
				base["showToolBar"] = value;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002052 RID: 8274 RVA: 0x00073D54 File Offset: 0x00071F54
		// (set) Token: 0x06002053 RID: 8275 RVA: 0x00073D68 File Offset: 0x00071F68
		[global::System.Configuration.ConfigurationProperty("enableMultiSelection", DefaultValue = true, IsRequired = false)]
		public bool EnableMultiSelection
		{
			get
			{
				return (bool)base["enableMultiSelection"];
			}
			set
			{
				base["enableMultiSelection"] = value;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06002054 RID: 8276 RVA: 0x00073D7C File Offset: 0x00071F7C
		// (set) Token: 0x06002055 RID: 8277 RVA: 0x00073D90 File Offset: 0x00071F90
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

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x00073DA4 File Offset: 0x00071FA4
		// (set) Token: 0x06002057 RID: 8279 RVA: 0x00073DB8 File Offset: 0x00071FB8
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

		// Token: 0x04000BF9 RID: 3065
		public const string DefaultHotKey = "Ctrl-Alt-F5";
	}
}
