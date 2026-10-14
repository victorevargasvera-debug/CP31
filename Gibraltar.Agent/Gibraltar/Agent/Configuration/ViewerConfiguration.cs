using System;
using Gibraltar.Messaging;
using Loupe.Extensibility.Data;

namespace Gibraltar.Agent.Configuration
{
	// Token: 0x02000048 RID: 72
	public sealed class ViewerConfiguration
	{
		// Token: 0x06000430 RID: 1072 RVA: 0x0000BC7C File Offset: 0x00009E7C
		internal ViewerConfiguration(global::Gibraltar.Messaging.ViewerMessengerConfiguration configuration)
		{
			this.m_WrappedConfiguration = configuration;
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0000BC8C File Offset: 0x00009E8C
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x0000BC9C File Offset: 0x00009E9C
		public string HotKey
		{
			get
			{
				return this.m_WrappedConfiguration.HotKey;
			}
			set
			{
				this.m_WrappedConfiguration.HotKey = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0000BCAC File Offset: 0x00009EAC
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x0000BCBC File Offset: 0x00009EBC
		public int MaxMessages
		{
			get
			{
				return this.m_WrappedConfiguration.MaxMessages;
			}
			set
			{
				this.m_WrappedConfiguration.MaxMessages = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0000BCCC File Offset: 0x00009ECC
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x0000BCDC File Offset: 0x00009EDC
		public bool ShowVerboseMessages
		{
			get
			{
				return this.m_WrappedConfiguration.ShowVerboseMessages;
			}
			set
			{
				this.m_WrappedConfiguration.ShowVerboseMessages = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x0000BCEC File Offset: 0x00009EEC
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x0000BCFC File Offset: 0x00009EFC
		public string FormTitleText
		{
			get
			{
				return this.m_WrappedConfiguration.FormTitleText;
			}
			set
			{
				this.m_WrappedConfiguration.FormTitleText = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0000BD0C File Offset: 0x00009F0C
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x0000BD1C File Offset: 0x00009F1C
		public global::Gibraltar.Agent.LogMessageSeverity DefaultFilterLevel
		{
			get
			{
				return (global::Gibraltar.Agent.LogMessageSeverity)this.m_WrappedConfiguration.DefaultFilterLevel;
			}
			set
			{
				this.m_WrappedConfiguration.DefaultFilterLevel = (global::Loupe.Extensibility.Data.LogMessageSeverity)value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0000BD2C File Offset: 0x00009F2C
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x0000BD3C File Offset: 0x00009F3C
		public bool EnableIndependentSeverityFilters
		{
			get
			{
				return this.m_WrappedConfiguration.EnableIndependentSeverityFilters;
			}
			set
			{
				this.m_WrappedConfiguration.EnableIndependentSeverityFilters = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0000BD4C File Offset: 0x00009F4C
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x0000BD5C File Offset: 0x00009F5C
		public bool ShowDetailsButton
		{
			get
			{
				return this.m_WrappedConfiguration.ShowDetailsButton;
			}
			set
			{
				this.m_WrappedConfiguration.ShowDetailsButton = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x0000BD6C File Offset: 0x00009F6C
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x0000BD7C File Offset: 0x00009F7C
		public bool ShowDetailsInGrid
		{
			get
			{
				return this.m_WrappedConfiguration.ShowDetailsInGrid;
			}
			set
			{
				this.m_WrappedConfiguration.ShowDetailsInGrid = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0000BD8C File Offset: 0x00009F8C
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x0000BD9C File Offset: 0x00009F9C
		public bool ShowDetailsInTooltips
		{
			get
			{
				return this.m_WrappedConfiguration.ShowDetailsInTooltips;
			}
			set
			{
				this.m_WrappedConfiguration.ShowDetailsInTooltips = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0000BDAC File Offset: 0x00009FAC
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x0000BDBC File Offset: 0x00009FBC
		public bool ShowMessageCounters
		{
			get
			{
				return this.m_WrappedConfiguration.ShowMessageCounters;
			}
			set
			{
				this.m_WrappedConfiguration.ShowMessageCounters = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x0000BDCC File Offset: 0x00009FCC
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x0000BDDC File Offset: 0x00009FDC
		public string RunButtonText
		{
			get
			{
				return this.m_WrappedConfiguration.RunButtonText;
			}
			set
			{
				this.m_WrappedConfiguration.RunButtonText = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0000BDEC File Offset: 0x00009FEC
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x0000BDFC File Offset: 0x00009FFC
		public bool RunButtonTextVisible
		{
			get
			{
				return this.m_WrappedConfiguration.RunButtonTextVisible;
			}
			set
			{
				this.m_WrappedConfiguration.RunButtonTextVisible = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0000BE0C File Offset: 0x0000A00C
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x0000BE1C File Offset: 0x0000A01C
		public string PauseButtonText
		{
			get
			{
				return this.m_WrappedConfiguration.PauseButtonText;
			}
			set
			{
				this.m_WrappedConfiguration.PauseButtonText = value;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0000BE2C File Offset: 0x0000A02C
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x0000BE3C File Offset: 0x0000A03C
		public bool PauseButtonTextVisible
		{
			get
			{
				return this.m_WrappedConfiguration.PauseButtonTextVisible;
			}
			set
			{
				this.m_WrappedConfiguration.PauseButtonTextVisible = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0000BE4C File Offset: 0x0000A04C
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x0000BE5C File Offset: 0x0000A05C
		public string ResetSearchButtonText
		{
			get
			{
				return this.m_WrappedConfiguration.ResetSearchButtonText;
			}
			set
			{
				this.m_WrappedConfiguration.ResetSearchButtonText = value;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0000BE6C File Offset: 0x0000A06C
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x0000BE7C File Offset: 0x0000A07C
		public bool ResetSearchButtonTextVisible
		{
			get
			{
				return this.m_WrappedConfiguration.ResetSearchButtonTextVisible;
			}
			set
			{
				this.m_WrappedConfiguration.ResetSearchButtonTextVisible = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0000BE8C File Offset: 0x0000A08C
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x0000BE9C File Offset: 0x0000A09C
		public string ClearMessagesButtonText
		{
			get
			{
				return this.m_WrappedConfiguration.ClearMessagesButtonText;
			}
			set
			{
				this.m_WrappedConfiguration.ClearMessagesButtonText = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0000BEAC File Offset: 0x0000A0AC
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x0000BEBC File Offset: 0x0000A0BC
		public bool ClearMessagesButtonTextVisible
		{
			get
			{
				return this.m_WrappedConfiguration.ClearMessagesButtonTextVisible;
			}
			set
			{
				this.m_WrappedConfiguration.ClearMessagesButtonTextVisible = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0000BECC File Offset: 0x0000A0CC
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x0000BEDC File Offset: 0x0000A0DC
		public bool ShowToolBar
		{
			get
			{
				return this.m_WrappedConfiguration.ShowToolBar;
			}
			set
			{
				this.m_WrappedConfiguration.ShowToolBar = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0000BEEC File Offset: 0x0000A0EC
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x0000BEFC File Offset: 0x0000A0FC
		public bool EnableMultiSelection
		{
			get
			{
				return this.m_WrappedConfiguration.EnableMultiSelection;
			}
			set
			{
				this.m_WrappedConfiguration.EnableMultiSelection = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0000BF0C File Offset: 0x0000A10C
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x0000BF1C File Offset: 0x0000A11C
		public bool ForceSynchronous
		{
			get
			{
				return this.m_WrappedConfiguration.ForceSynchronous;
			}
			set
			{
				this.m_WrappedConfiguration.ForceSynchronous = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0000BF2C File Offset: 0x0000A12C
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x0000BF3C File Offset: 0x0000A13C
		public int MaxQueueLength
		{
			get
			{
				return this.m_WrappedConfiguration.MaxQueueLength;
			}
			set
			{
				this.m_WrappedConfiguration.MaxQueueLength = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0000BF4C File Offset: 0x0000A14C
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x0000BF5C File Offset: 0x0000A15C
		public bool Enabled
		{
			get
			{
				return this.m_WrappedConfiguration.Enabled;
			}
			set
			{
				this.m_WrappedConfiguration.Enabled = value;
			}
		}

		// Token: 0x040000D4 RID: 212
		private readonly global::Gibraltar.Messaging.ViewerMessengerConfiguration m_WrappedConfiguration;

		// Token: 0x040000D5 RID: 213
		public const string DefaultHotKey = "Ctrl-Alt-F5";
	}
}
