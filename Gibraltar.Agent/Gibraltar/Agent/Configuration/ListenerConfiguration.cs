using System;
using Gibraltar.Monitor;

namespace Gibraltar.Agent.Configuration
{
	// Token: 0x02000045 RID: 69
	public sealed class ListenerConfiguration
	{
		// Token: 0x060003E3 RID: 995 RVA: 0x0000B7AC File Offset: 0x000099AC
		internal ListenerConfiguration(global::Gibraltar.Monitor.ListenerConfiguration configuration)
		{
			this.m_WrappedConfiguration = configuration;
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0000B7BC File Offset: 0x000099BC
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x0000B7CC File Offset: 0x000099CC
		public bool AutoTraceRegistration
		{
			get
			{
				return this.m_WrappedConfiguration.AutoTraceRegistration;
			}
			set
			{
				this.m_WrappedConfiguration.AutoTraceRegistration = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0000B7DC File Offset: 0x000099DC
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x0000B7EC File Offset: 0x000099EC
		public bool EnableConsole
		{
			get
			{
				return this.m_WrappedConfiguration.EnableConsole;
			}
			set
			{
				this.m_WrappedConfiguration.EnableConsole = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0000B7FC File Offset: 0x000099FC
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x0000B80C File Offset: 0x00009A0C
		public bool EnableProcessPerformance
		{
			get
			{
				return this.m_WrappedConfiguration.EnableProcessPerformance;
			}
			set
			{
				this.m_WrappedConfiguration.EnableProcessPerformance = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0000B81C File Offset: 0x00009A1C
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x0000B82C File Offset: 0x00009A2C
		public bool EnableDiskPerformance
		{
			get
			{
				return this.m_WrappedConfiguration.EnableDiskPerformance;
			}
			set
			{
				this.m_WrappedConfiguration.EnableDiskPerformance = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0000B83C File Offset: 0x00009A3C
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x0000B84C File Offset: 0x00009A4C
		public bool EnableMemoryPerformance
		{
			get
			{
				return this.m_WrappedConfiguration.EnableMemoryPerformance;
			}
			set
			{
				this.m_WrappedConfiguration.EnableMemoryPerformance = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0000B85C File Offset: 0x00009A5C
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x0000B86C File Offset: 0x00009A6C
		public bool EnableNetworkPerformance
		{
			get
			{
				return this.m_WrappedConfiguration.EnableNetworkPerformance;
			}
			set
			{
				this.m_WrappedConfiguration.EnableNetworkPerformance = value;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0000B87C File Offset: 0x00009A7C
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x0000B88C File Offset: 0x00009A8C
		public bool EnableSystemPerformance
		{
			get
			{
				return this.m_WrappedConfiguration.EnableSystemPerformance;
			}
			set
			{
				this.m_WrappedConfiguration.EnableSystemPerformance = value;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0000B89C File Offset: 0x00009A9C
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x0000B8AC File Offset: 0x00009AAC
		public bool EnableNetworkEvents
		{
			get
			{
				return this.m_WrappedConfiguration.EnableNetworkEvents;
			}
			set
			{
				this.m_WrappedConfiguration.EnableNetworkEvents = value;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0000B8BC File Offset: 0x00009ABC
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x0000B8CC File Offset: 0x00009ACC
		public bool EnablePowerEvents
		{
			get
			{
				return this.m_WrappedConfiguration.EnablePowerEvents;
			}
			set
			{
				this.m_WrappedConfiguration.EnablePowerEvents = value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0000B8DC File Offset: 0x00009ADC
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x0000B8EC File Offset: 0x00009AEC
		public bool EnableUserEvents
		{
			get
			{
				return this.m_WrappedConfiguration.EnableUserEvents;
			}
			set
			{
				this.m_WrappedConfiguration.EnableUserEvents = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0000B8FC File Offset: 0x00009AFC
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x0000B90C File Offset: 0x00009B0C
		public bool EnableAssemblyEvents
		{
			get
			{
				return this.m_WrappedConfiguration.EnableAssemblyEvents;
			}
			set
			{
				this.m_WrappedConfiguration.EnableAssemblyEvents = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0000B91C File Offset: 0x00009B1C
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x0000B92C File Offset: 0x00009B2C
		public bool EnableAssemblyLoadFailureEvents
		{
			get
			{
				return this.m_WrappedConfiguration.EnableAssemblyLoadFailureEvents;
			}
			set
			{
				this.m_WrappedConfiguration.EnableAssemblyLoadFailureEvents = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0000B93C File Offset: 0x00009B3C
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x0000B94C File Offset: 0x00009B4C
		public bool CatchUnhandledExceptions
		{
			get
			{
				return this.m_WrappedConfiguration.CatchUnhandledExceptions;
			}
			set
			{
				this.m_WrappedConfiguration.CatchUnhandledExceptions = value;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0000B95C File Offset: 0x00009B5C
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x0000B96C File Offset: 0x00009B6C
		public bool CatchApplicationExceptions
		{
			get
			{
				return this.m_WrappedConfiguration.CatchApplicationExceptions;
			}
			set
			{
				this.m_WrappedConfiguration.CatchApplicationExceptions = value;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0000B97C File Offset: 0x00009B7C
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x0000B98C File Offset: 0x00009B8C
		public bool ReportErrorsToUser
		{
			get
			{
				return this.m_WrappedConfiguration.ReportErrorsToUser;
			}
			set
			{
				this.m_WrappedConfiguration.ReportErrorsToUser = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0000B99C File Offset: 0x00009B9C
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x0000B9AC File Offset: 0x00009BAC
		public bool EndSessionOnTraceClose
		{
			get
			{
				return this.m_WrappedConfiguration.EndSessionOnTraceClose;
			}
			set
			{
				this.m_WrappedConfiguration.EndSessionOnTraceClose = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0000B9BC File Offset: 0x00009BBC
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x0000B9CC File Offset: 0x00009BCC
		public bool EnableCommandLine
		{
			get
			{
				return this.m_WrappedConfiguration.EnableCommandLine;
			}
			set
			{
				this.m_WrappedConfiguration.EnableCommandLine = value;
			}
		}

		// Token: 0x040000D0 RID: 208
		private readonly global::Gibraltar.Monitor.ListenerConfiguration m_WrappedConfiguration;
	}
}
