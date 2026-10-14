using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Agent
{
	// Token: 0x02000013 RID: 19
	public sealed class SessionSummary
	{
		// Token: 0x060000FA RID: 250 RVA: 0x000049D8 File Offset: 0x00002BD8
		internal SessionSummary(global::Gibraltar.Monitor.SessionSummary summary)
		{
			this.m_WrappedSummary = summary;
			this.m_Properties = new global::System.Collections.Generic.Dictionary<string, string>(summary.Properties);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000049F8 File Offset: 0x00002BF8
		internal SessionSummary(global::Loupe.Extensibility.Data.ISessionSummary summary)
		{
			this.m_WrappedISessionSummary = summary;
			this.m_Properties = new global::System.Collections.Generic.Dictionary<string, string>(summary.Properties);
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00004A18 File Offset: 0x00002C18
		public global::System.Guid Id
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.Id;
				}
				return this.m_WrappedSummary.Id;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00004A3C File Offset: 0x00002C3C
		public string TimeZoneCaption
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.TimeZoneCaption;
				}
				return this.m_WrappedSummary.TimeZoneCaption;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00004A60 File Offset: 0x00002C60
		public global::System.DateTimeOffset StartDateTime
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.StartDateTime;
				}
				return this.m_WrappedSummary.StartDateTime;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00004A84 File Offset: 0x00002C84
		public global::System.DateTimeOffset EndDateTime
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.EndDateTime;
				}
				return this.m_WrappedSummary.EndDateTime;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00004AA8 File Offset: 0x00002CA8
		public global::System.TimeSpan Duration
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.Duration;
				}
				return this.m_WrappedSummary.Duration;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00004ACC File Offset: 0x00002CCC
		public string Caption
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.Caption;
				}
				return this.m_WrappedSummary.Caption;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00004AF0 File Offset: 0x00002CF0
		public string Product
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.Product;
				}
				return this.m_WrappedSummary.Product;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00004B14 File Offset: 0x00002D14
		public string Application
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.Application;
				}
				return this.m_WrappedSummary.Application;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00004B38 File Offset: 0x00002D38
		public string Environment
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.Environment;
				}
				return this.m_WrappedSummary.Environment;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00004B5C File Offset: 0x00002D5C
		public string PromotionLevel
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.PromotionLevel;
				}
				return this.m_WrappedSummary.PromotionLevel;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00004B80 File Offset: 0x00002D80
		public global::Gibraltar.Agent.ApplicationType ApplicationType
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return (global::Gibraltar.Agent.ApplicationType)this.m_WrappedISessionSummary.ApplicationType;
				}
				return (global::Gibraltar.Agent.ApplicationType)this.m_WrappedSummary.ApplicationType;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00004BA4 File Offset: 0x00002DA4
		public string ApplicationDescription
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.ApplicationDescription;
				}
				return this.m_WrappedSummary.ApplicationDescription;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00004BC8 File Offset: 0x00002DC8
		public global::System.Version ApplicationVersion
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.ApplicationVersion;
				}
				return this.m_WrappedSummary.ApplicationVersion;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00004BEC File Offset: 0x00002DEC
		public global::System.Version AgentVersion
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.AgentVersion;
				}
				return this.m_WrappedSummary.AgentVersion;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00004C10 File Offset: 0x00002E10
		public string HostName
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.HostName;
				}
				return this.m_WrappedSummary.HostName;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00004C34 File Offset: 0x00002E34
		public string DnsDomainName
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.DnsDomainName;
				}
				return this.m_WrappedSummary.DnsDomainName;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00004C58 File Offset: 0x00002E58
		public string FullyQualifiedUserName
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.FullyQualifiedUserName;
				}
				return this.m_WrappedSummary.FullyQualifiedUserName;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00004C7C File Offset: 0x00002E7C
		public string UserName
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.UserName;
				}
				return this.m_WrappedSummary.UserName;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00004CA0 File Offset: 0x00002EA0
		public string UserDomainName
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.UserDomainName;
				}
				return this.m_WrappedSummary.UserDomainName;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00004CC4 File Offset: 0x00002EC4
		public global::System.Version OSVersion
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.OSVersion;
				}
				return this.m_WrappedSummary.OSVersion;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00004CE8 File Offset: 0x00002EE8
		public string OSServicePack
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.OSServicePack;
				}
				return this.m_WrappedSummary.OSServicePack;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00004D0C File Offset: 0x00002F0C
		public string OSCultureName
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.OSCultureName;
				}
				return this.m_WrappedSummary.OSCultureName;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00004D30 File Offset: 0x00002F30
		public global::System.Reflection.ProcessorArchitecture OSArchitecture
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.OSArchitecture;
				}
				return this.m_WrappedSummary.OSArchitecture;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00004D54 File Offset: 0x00002F54
		public global::System.Windows.Forms.BootMode OSBootMode
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.OSBootMode;
				}
				return this.m_WrappedSummary.OSBootMode;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00004D78 File Offset: 0x00002F78
		public int OSPlatformCode
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.OSPlatformCode;
				}
				return this.m_WrappedSummary.OSPlatformCode;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00004D9C File Offset: 0x00002F9C
		public int OSProductType
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.OSProductType;
				}
				return this.m_WrappedSummary.OSProductType;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00004DC0 File Offset: 0x00002FC0
		public int OSSuiteMask
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.OSSuiteMask;
				}
				return this.m_WrappedSummary.OSSuiteMask;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00004DE4 File Offset: 0x00002FE4
		public string OSFamilyName
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.OSFamilyName;
				}
				return this.m_WrappedSummary.OSFamilyName;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00004E08 File Offset: 0x00003008
		public string OSEditionName
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.OSEditionName;
				}
				return this.m_WrappedSummary.OSEditionName;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00004E2C File Offset: 0x0000302C
		public string OSFullName
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.OSFullName;
				}
				return this.m_WrappedSummary.OSFullName;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00004E50 File Offset: 0x00003050
		public string OSFullNameWithServicePack
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.OSFullNameWithServicePack;
				}
				return this.m_WrappedSummary.OSFullNameWithServicePack;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00004E74 File Offset: 0x00003074
		public global::System.Version RuntimeVersion
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.RuntimeVersion;
				}
				return this.m_WrappedSummary.RuntimeVersion;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00004E98 File Offset: 0x00003098
		public global::System.Reflection.ProcessorArchitecture RuntimeArchitecture
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.RuntimeArchitecture;
				}
				return this.m_WrappedSummary.RuntimeArchitecture;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00004EBC File Offset: 0x000030BC
		public string CurrentCultureName
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.CurrentCultureName;
				}
				return this.m_WrappedSummary.CurrentCultureName;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00004EE0 File Offset: 0x000030E0
		public string CurrentUICultureName
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.CurrentUICultureName;
				}
				return this.m_WrappedSummary.CurrentUICultureName;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00004F04 File Offset: 0x00003104
		public int MemoryMB
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.MemoryMB;
				}
				return this.m_WrappedSummary.MemoryMB;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00004F28 File Offset: 0x00003128
		public int Processors
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.Processors;
				}
				return this.m_WrappedSummary.Processors;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00004F4C File Offset: 0x0000314C
		public int ProcessorCores
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.ProcessorCores;
				}
				return this.m_WrappedSummary.ProcessorCores;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00004F70 File Offset: 0x00003170
		public bool UserInteractive
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.UserInteractive;
				}
				return this.m_WrappedSummary.UserInteractive;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00004F94 File Offset: 0x00003194
		public bool TerminalServer
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.TerminalServer;
				}
				return this.m_WrappedSummary.TerminalServer;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00004FB8 File Offset: 0x000031B8
		public int ScreenWidth
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.ScreenWidth;
				}
				return this.m_WrappedSummary.ScreenWidth;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00004FDC File Offset: 0x000031DC
		public int ScreenHeight
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.ScreenHeight;
				}
				return this.m_WrappedSummary.ScreenHeight;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00005000 File Offset: 0x00003200
		public int ColorDepth
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.ColorDepth;
				}
				return this.m_WrappedSummary.ColorDepth;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00005024 File Offset: 0x00003224
		public string CommandLine
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.CommandLine;
				}
				return this.m_WrappedSummary.CommandLine;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00005048 File Offset: 0x00003248
		public global::Gibraltar.Agent.SessionStatus Status
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return (global::Gibraltar.Agent.SessionStatus)this.m_WrappedISessionSummary.Status;
				}
				return (global::Gibraltar.Agent.SessionStatus)this.m_WrappedSummary.Status;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000506C File Offset: 0x0000326C
		public int MessageCount
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.MessageCount;
				}
				return this.m_WrappedSummary.MessageCount;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00005090 File Offset: 0x00003290
		public int CriticalCount
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.CriticalCount;
				}
				return this.m_WrappedSummary.CriticalCount;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600012B RID: 299 RVA: 0x000050B4 File Offset: 0x000032B4
		public int ErrorCount
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.ErrorCount;
				}
				return this.m_WrappedSummary.ErrorCount;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000050D8 File Offset: 0x000032D8
		public int WarningCount
		{
			get
			{
				if (this.m_WrappedSummary == null)
				{
					return this.m_WrappedISessionSummary.WarningCount;
				}
				return this.m_WrappedSummary.WarningCount;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600012D RID: 301 RVA: 0x000050FC File Offset: 0x000032FC
		public global::System.Collections.Generic.Dictionary<string, string> Properties
		{
			get
			{
				return this.m_Properties;
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00005104 File Offset: 0x00003304
		internal void SyncWrappedObject(global::Gibraltar.Monitor.SessionSummary summary)
		{
			if (summary != this.m_WrappedSummary)
			{
				this.m_WrappedSummary = summary;
			}
		}

		// Token: 0x04000050 RID: 80
		private readonly global::Loupe.Extensibility.Data.ISessionSummary m_WrappedISessionSummary;

		// Token: 0x04000051 RID: 81
		private global::Gibraltar.Monitor.SessionSummary m_WrappedSummary;

		// Token: 0x04000052 RID: 82
		private readonly global::System.Collections.Generic.Dictionary<string, string> m_Properties;
	}
}
