using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using Gibraltar.Data;
using Gibraltar.Serialization;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x0200020A RID: 522
	[global::System.Diagnostics.DebuggerDisplay("{Caption} ({ID})")]
	internal class SessionSummaryPacket : global::Gibraltar.Monitor.Internal.GibraltarCachedPacket, global::Gibraltar.Serialization.IPacket, global::System.IEquatable<global::Gibraltar.Monitor.Internal.SessionSummaryPacket>
	{
		// Token: 0x060019BE RID: 6590 RVA: 0x0005A8B4 File Offset: 0x00058AB4
		public SessionSummaryPacket() : base(true)
		{
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0005A8C8 File Offset: 0x00058AC8
		public SessionSummaryPacket(global::Gibraltar.Data.SessionHeader sessionHeader) : base(sessionHeader.Id, true)
		{
			this.m_ComputerId = sessionHeader.ComputerId.GetValueOrDefault();
			base.Timestamp = sessionHeader.StartDateTime;
			this.m_EndDateTime = sessionHeader.EndDateTime;
			this.m_Caption = sessionHeader.Caption;
			this.m_TimeZoneCaption = sessionHeader.TimeZoneCaption;
			this.m_ProductName = sessionHeader.Product;
			this.m_ApplicationName = sessionHeader.Application;
			this.m_EnvironmentName = sessionHeader.Environment;
			this.m_PromotionLevelName = sessionHeader.PromotionLevel;
			this.m_ApplicationType = (global::Loupe.Extensibility.Data.ApplicationType)global::System.Enum.Parse(typeof(global::Loupe.Extensibility.Data.ApplicationType), sessionHeader.ApplicationTypeName, true);
			this.m_ApplicationDescription = sessionHeader.ApplicationDescription;
			this.m_ApplicationVersion = sessionHeader.ApplicationVersion;
			this.m_AgentVersion = sessionHeader.AgentVersion;
			this.m_UserName = sessionHeader.UserName;
			this.m_UserDomainName = sessionHeader.UserDomainName;
			this.m_HostName = sessionHeader.HostName;
			this.m_DnsDomainName = sessionHeader.DnsDomainName;
			this.m_OSPlatformCode = sessionHeader.OSPlatformCode;
			this.m_OSVersion = sessionHeader.OSVersion;
			this.m_OSServicePack = sessionHeader.OSServicePack;
			this.m_OSCultureName = sessionHeader.OSCultureName;
			this.m_OSArchitecture = sessionHeader.OSArchitecture;
			this.m_OSBootMode = sessionHeader.OSBootMode;
			this.m_OSSuiteMaskCode = sessionHeader.OSSuiteMask;
			this.m_OSProductTypeCode = sessionHeader.OSProductType;
			this.m_RuntimeVersion = sessionHeader.RuntimeVersion;
			this.m_RuntimeArchitecture = sessionHeader.RuntimeArchitecture;
			this.m_CurrentCultureName = sessionHeader.CurrentCultureName;
			this.m_CurrentUICultureName = sessionHeader.CurrentUICultureName;
			this.m_MemoryMB = sessionHeader.MemoryMB;
			this.m_Processors = sessionHeader.Processors;
			this.m_ProcessorCores = sessionHeader.ProcessorCores;
			this.m_UserInteractive = sessionHeader.UserInteractive;
			this.m_TerminalServer = sessionHeader.TerminalServer;
			this.m_ScreenWidth = sessionHeader.ScreenWidth;
			this.m_ScreenHeight = sessionHeader.ScreenHeight;
			this.m_ColorDepth = sessionHeader.ColorDepth;
			this.m_CommandLine = sessionHeader.CommandLine;
			this.m_Properties = new global::System.Collections.Generic.Dictionary<string, string>(sessionHeader.Properties);
			this.CalculateFullyQualifiedUserName();
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x0005AAF0 File Offset: 0x00058CF0
		// (set) Token: 0x060019C1 RID: 6593 RVA: 0x0005AAF8 File Offset: 0x00058CF8
		public global::System.Guid ComputerId
		{
			get
			{
				return this.m_ComputerId;
			}
			set
			{
				this.m_ComputerId = value;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x0005AB04 File Offset: 0x00058D04
		// (set) Token: 0x060019C3 RID: 6595 RVA: 0x0005AB0C File Offset: 0x00058D0C
		public global::System.DateTimeOffset EndDateTime
		{
			get
			{
				return this.m_EndDateTime;
			}
			set
			{
				this.m_EndDateTime = value;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x0005AB18 File Offset: 0x00058D18
		// (set) Token: 0x060019C5 RID: 6597 RVA: 0x0005AB20 File Offset: 0x00058D20
		public string Caption
		{
			get
			{
				return this.m_Caption;
			}
			set
			{
				this.m_Caption = global::Gibraltar.Monitor.Internal.SessionSummaryPacket.SetSafeStringValue(value, 1024);
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x0005AB34 File Offset: 0x00058D34
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x0005AB3C File Offset: 0x00058D3C
		public string TimeZoneCaption
		{
			get
			{
				return this.m_TimeZoneCaption;
			}
			set
			{
				this.m_TimeZoneCaption = global::Gibraltar.Monitor.Internal.SessionSummaryPacket.SetSafeStringValue(value, 120);
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x0005AB4C File Offset: 0x00058D4C
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x0005AB54 File Offset: 0x00058D54
		public string ProductName
		{
			get
			{
				return this.m_ProductName;
			}
			set
			{
				this.m_ProductName = global::Gibraltar.Monitor.Internal.SessionSummaryPacket.SetSafeStringValue(value, 120);
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x0005AB64 File Offset: 0x00058D64
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x0005AB6C File Offset: 0x00058D6C
		public string ApplicationName
		{
			get
			{
				return this.m_ApplicationName;
			}
			set
			{
				this.m_ApplicationName = global::Gibraltar.Monitor.Internal.SessionSummaryPacket.SetSafeStringValue(value, 120);
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x0005AB7C File Offset: 0x00058D7C
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x0005AB84 File Offset: 0x00058D84
		public string EnvironmentName
		{
			get
			{
				return this.m_EnvironmentName;
			}
			set
			{
				this.m_EnvironmentName = global::Gibraltar.Monitor.Internal.SessionSummaryPacket.SetSafeStringValue(value, 120);
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x0005AB94 File Offset: 0x00058D94
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x0005AB9C File Offset: 0x00058D9C
		public string PromotionLevelName
		{
			get
			{
				return this.m_PromotionLevelName;
			}
			set
			{
				this.m_PromotionLevelName = global::Gibraltar.Monitor.Internal.SessionSummaryPacket.SetSafeStringValue(value, 120);
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x0005ABAC File Offset: 0x00058DAC
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x0005ABB4 File Offset: 0x00058DB4
		public global::Loupe.Extensibility.Data.ApplicationType ApplicationType
		{
			get
			{
				return this.m_ApplicationType;
			}
			set
			{
				this.m_ApplicationType = value;
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x0005ABC0 File Offset: 0x00058DC0
		// (set) Token: 0x060019D3 RID: 6611 RVA: 0x0005ABC8 File Offset: 0x00058DC8
		public string ApplicationDescription
		{
			get
			{
				return this.m_ApplicationDescription;
			}
			set
			{
				this.m_ApplicationDescription = global::Gibraltar.Monitor.Internal.SessionSummaryPacket.SetSafeStringValue(value, 1024);
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x0005ABDC File Offset: 0x00058DDC
		// (set) Token: 0x060019D5 RID: 6613 RVA: 0x0005ABE4 File Offset: 0x00058DE4
		public global::System.Version ApplicationVersion
		{
			get
			{
				return this.m_ApplicationVersion;
			}
			set
			{
				this.m_ApplicationVersion = value;
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x0005ABF0 File Offset: 0x00058DF0
		// (set) Token: 0x060019D7 RID: 6615 RVA: 0x0005ABF8 File Offset: 0x00058DF8
		public global::System.Version AgentVersion
		{
			get
			{
				return this.m_AgentVersion;
			}
			set
			{
				this.m_AgentVersion = value;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x0005AC04 File Offset: 0x00058E04
		// (set) Token: 0x060019D9 RID: 6617 RVA: 0x0005AC0C File Offset: 0x00058E0C
		public string HostName
		{
			get
			{
				return this.m_HostName;
			}
			set
			{
				this.m_HostName = global::Gibraltar.Monitor.Internal.SessionSummaryPacket.SetSafeStringValue(value, 120);
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x0005AC1C File Offset: 0x00058E1C
		// (set) Token: 0x060019DB RID: 6619 RVA: 0x0005AC24 File Offset: 0x00058E24
		public string DnsDomainName
		{
			get
			{
				return this.m_DnsDomainName;
			}
			set
			{
				this.m_DnsDomainName = global::Gibraltar.Monitor.Internal.SessionSummaryPacket.SetSafeStringValue(value, 512);
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x0005AC38 File Offset: 0x00058E38
		// (set) Token: 0x060019DD RID: 6621 RVA: 0x0005AC40 File Offset: 0x00058E40
		public string UserName
		{
			get
			{
				return this.m_UserName;
			}
			set
			{
				this.m_UserName = global::Gibraltar.Monitor.Internal.SessionSummaryPacket.SetSafeStringValue(value, 120);
				this.CalculateFullyQualifiedUserName();
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x0005AC58 File Offset: 0x00058E58
		// (set) Token: 0x060019DF RID: 6623 RVA: 0x0005AC60 File Offset: 0x00058E60
		public string UserDomainName
		{
			get
			{
				return this.m_UserDomainName;
			}
			set
			{
				this.m_UserDomainName = global::Gibraltar.Monitor.Internal.SessionSummaryPacket.SetSafeStringValue(value, 50);
				this.CalculateFullyQualifiedUserName();
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x0005AC78 File Offset: 0x00058E78
		// (set) Token: 0x060019E1 RID: 6625 RVA: 0x0005AC80 File Offset: 0x00058E80
		public int OSPlatformCode
		{
			get
			{
				return this.m_OSPlatformCode;
			}
			set
			{
				this.m_OSPlatformCode = value;
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x0005AC8C File Offset: 0x00058E8C
		// (set) Token: 0x060019E3 RID: 6627 RVA: 0x0005AC94 File Offset: 0x00058E94
		public global::System.Version OSVersion
		{
			get
			{
				return this.m_OSVersion;
			}
			set
			{
				this.m_OSVersion = value;
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x0005ACA0 File Offset: 0x00058EA0
		// (set) Token: 0x060019E5 RID: 6629 RVA: 0x0005ACA8 File Offset: 0x00058EA8
		public string OSServicePack
		{
			get
			{
				return this.m_OSServicePack;
			}
			set
			{
				this.m_OSServicePack = global::Gibraltar.Monitor.Internal.SessionSummaryPacket.SetSafeStringValue(value, 50);
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x0005ACB8 File Offset: 0x00058EB8
		// (set) Token: 0x060019E7 RID: 6631 RVA: 0x0005ACC0 File Offset: 0x00058EC0
		public string OSCultureName
		{
			get
			{
				return this.m_OSCultureName;
			}
			set
			{
				this.m_OSCultureName = global::Gibraltar.Monitor.Internal.SessionSummaryPacket.SetSafeStringValue(value, 50);
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x0005ACD0 File Offset: 0x00058ED0
		// (set) Token: 0x060019E9 RID: 6633 RVA: 0x0005ACD8 File Offset: 0x00058ED8
		public global::System.Reflection.ProcessorArchitecture OSArchitecture
		{
			get
			{
				return this.m_OSArchitecture;
			}
			set
			{
				this.m_OSArchitecture = value;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x0005ACE4 File Offset: 0x00058EE4
		// (set) Token: 0x060019EB RID: 6635 RVA: 0x0005ACEC File Offset: 0x00058EEC
		public global::System.Windows.Forms.BootMode OSBootMode
		{
			get
			{
				return this.m_OSBootMode;
			}
			set
			{
				this.m_OSBootMode = value;
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x0005ACF8 File Offset: 0x00058EF8
		// (set) Token: 0x060019ED RID: 6637 RVA: 0x0005AD00 File Offset: 0x00058F00
		public int OSSuiteMask
		{
			get
			{
				return this.m_OSSuiteMaskCode;
			}
			set
			{
				this.m_OSSuiteMaskCode = value;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x0005AD0C File Offset: 0x00058F0C
		// (set) Token: 0x060019EF RID: 6639 RVA: 0x0005AD14 File Offset: 0x00058F14
		public int OSProductType
		{
			get
			{
				return this.m_OSProductTypeCode;
			}
			set
			{
				this.m_OSProductTypeCode = value;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x0005AD20 File Offset: 0x00058F20
		// (set) Token: 0x060019F1 RID: 6641 RVA: 0x0005AD28 File Offset: 0x00058F28
		public global::System.Version RuntimeVersion
		{
			get
			{
				return this.m_RuntimeVersion;
			}
			set
			{
				this.m_RuntimeVersion = value;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x0005AD34 File Offset: 0x00058F34
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x0005AD3C File Offset: 0x00058F3C
		public global::System.Reflection.ProcessorArchitecture RuntimeArchitecture
		{
			get
			{
				return this.m_RuntimeArchitecture;
			}
			set
			{
				this.m_RuntimeArchitecture = value;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x0005AD48 File Offset: 0x00058F48
		// (set) Token: 0x060019F5 RID: 6645 RVA: 0x0005AD50 File Offset: 0x00058F50
		public string CurrentCultureName
		{
			get
			{
				return this.m_CurrentCultureName;
			}
			set
			{
				this.m_CurrentCultureName = global::Gibraltar.Monitor.Internal.SessionSummaryPacket.SetSafeStringValue(value, 50);
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x0005AD60 File Offset: 0x00058F60
		// (set) Token: 0x060019F7 RID: 6647 RVA: 0x0005AD68 File Offset: 0x00058F68
		public string CurrentUICultureName
		{
			get
			{
				return this.m_CurrentUICultureName;
			}
			set
			{
				this.m_CurrentUICultureName = global::Gibraltar.Monitor.Internal.SessionSummaryPacket.SetSafeStringValue(value, 50);
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x0005AD78 File Offset: 0x00058F78
		// (set) Token: 0x060019F9 RID: 6649 RVA: 0x0005AD80 File Offset: 0x00058F80
		public int MemoryMB
		{
			get
			{
				return this.m_MemoryMB;
			}
			set
			{
				this.m_MemoryMB = value;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x060019FA RID: 6650 RVA: 0x0005AD8C File Offset: 0x00058F8C
		// (set) Token: 0x060019FB RID: 6651 RVA: 0x0005AD94 File Offset: 0x00058F94
		public int Processors
		{
			get
			{
				return this.m_Processors;
			}
			set
			{
				this.m_Processors = value;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x0005ADA0 File Offset: 0x00058FA0
		// (set) Token: 0x060019FD RID: 6653 RVA: 0x0005ADA8 File Offset: 0x00058FA8
		public int ProcessorCores
		{
			get
			{
				return this.m_ProcessorCores;
			}
			set
			{
				this.m_ProcessorCores = value;
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x0005ADB4 File Offset: 0x00058FB4
		// (set) Token: 0x060019FF RID: 6655 RVA: 0x0005ADBC File Offset: 0x00058FBC
		public bool UserInteractive
		{
			get
			{
				return this.m_UserInteractive;
			}
			set
			{
				this.m_UserInteractive = value;
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x0005ADC8 File Offset: 0x00058FC8
		// (set) Token: 0x06001A01 RID: 6657 RVA: 0x0005ADD0 File Offset: 0x00058FD0
		public bool TerminalServer
		{
			get
			{
				return this.m_TerminalServer;
			}
			set
			{
				this.m_TerminalServer = value;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x0005ADDC File Offset: 0x00058FDC
		// (set) Token: 0x06001A03 RID: 6659 RVA: 0x0005ADE4 File Offset: 0x00058FE4
		public int ScreenWidth
		{
			get
			{
				return this.m_ScreenWidth;
			}
			set
			{
				this.m_ScreenWidth = value;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x0005ADF0 File Offset: 0x00058FF0
		// (set) Token: 0x06001A05 RID: 6661 RVA: 0x0005ADF8 File Offset: 0x00058FF8
		public int ScreenHeight
		{
			get
			{
				return this.m_ScreenHeight;
			}
			set
			{
				this.m_ScreenHeight = value;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x0005AE04 File Offset: 0x00059004
		// (set) Token: 0x06001A07 RID: 6663 RVA: 0x0005AE0C File Offset: 0x0005900C
		public int ColorDepth
		{
			get
			{
				return this.m_ColorDepth;
			}
			set
			{
				this.m_ColorDepth = value;
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x0005AE18 File Offset: 0x00059018
		// (set) Token: 0x06001A09 RID: 6665 RVA: 0x0005AE20 File Offset: 0x00059020
		public string CommandLine
		{
			get
			{
				return this.m_CommandLine;
			}
			set
			{
				this.m_CommandLine = global::Gibraltar.Monitor.Internal.SessionSummaryPacket.SetSafeStringValue(value, 2048);
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x0005AE34 File Offset: 0x00059034
		public string FullyQualifiedUserName
		{
			get
			{
				return this.m_FullyQualifiedUserName;
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001A0B RID: 6667 RVA: 0x0005AE3C File Offset: 0x0005903C
		public global::System.Collections.Generic.Dictionary<string, string> Properties
		{
			get
			{
				return this.m_Properties;
			}
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x0005AE44 File Offset: 0x00059044
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x0005AE48 File Offset: 0x00059048
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			global::Gibraltar.Serialization.PacketDefinition packetDefinition = new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 3, false);
			packetDefinition.Fields.Add("ComputerId", global::Gibraltar.Serialization.FieldType.Guid);
			packetDefinition.Fields.Add("ProductName", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("ApplicationName", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("EnvironmentName", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("PromotionLevelName", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("ApplicationType", global::Gibraltar.Serialization.FieldType.Int32);
			packetDefinition.Fields.Add("ApplicationVersion", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("ApplicationDescription", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("Caption", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("TimeZoneCaption", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("EndDateTime", global::Gibraltar.Serialization.FieldType.DateTimeOffset);
			packetDefinition.Fields.Add("AgentVersion", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("UserName", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("UserDomainName", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("HostName", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("DNSDomainName", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("OSPlatformCode", global::Gibraltar.Serialization.FieldType.Int32);
			packetDefinition.Fields.Add("OSVersion", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("OSServicePack", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("OSCultureName", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("OSArchitecture", global::Gibraltar.Serialization.FieldType.Int32);
			packetDefinition.Fields.Add("OSBootMode", global::Gibraltar.Serialization.FieldType.Int32);
			packetDefinition.Fields.Add("OSSuiteMaskCode", global::Gibraltar.Serialization.FieldType.Int32);
			packetDefinition.Fields.Add("OSProductTypeCode", global::Gibraltar.Serialization.FieldType.Int32);
			packetDefinition.Fields.Add("RuntimeVersion", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("RuntimeArchitecture", global::Gibraltar.Serialization.FieldType.Int32);
			packetDefinition.Fields.Add("CurrentCultureName", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("CurrentUICultureName", global::Gibraltar.Serialization.FieldType.String);
			packetDefinition.Fields.Add("MemoryMB", global::Gibraltar.Serialization.FieldType.Int32);
			packetDefinition.Fields.Add("Processors", global::Gibraltar.Serialization.FieldType.Int32);
			packetDefinition.Fields.Add("ProcessorCores", global::Gibraltar.Serialization.FieldType.Int32);
			packetDefinition.Fields.Add("UserInteractive", global::Gibraltar.Serialization.FieldType.Bool);
			packetDefinition.Fields.Add("TerminalServer", global::Gibraltar.Serialization.FieldType.Bool);
			packetDefinition.Fields.Add("ScreenWidth", global::Gibraltar.Serialization.FieldType.Int32);
			packetDefinition.Fields.Add("ScreenHeight", global::Gibraltar.Serialization.FieldType.Int32);
			packetDefinition.Fields.Add("ColorDepth", global::Gibraltar.Serialization.FieldType.Int32);
			packetDefinition.Fields.Add("CommandLine", global::Gibraltar.Serialization.FieldType.String);
			foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair in this.m_Properties)
			{
				packetDefinition.Fields.Add(keyValuePair.Key, global::Gibraltar.Serialization.FieldType.String);
			}
			return packetDefinition;
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x0005B13C File Offset: 0x0005933C
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("ComputerId", this.m_ComputerId);
			packet.SetField("ProductName", this.m_ProductName);
			packet.SetField("ApplicationName", this.m_ApplicationName);
			packet.SetField("EnvironmentName", this.m_EnvironmentName);
			packet.SetField("PromotionLevelName", this.m_PromotionLevelName);
			packet.SetField("ApplicationVersion", this.m_ApplicationVersion.ToString());
			packet.SetField("ApplicationType", (int)this.m_ApplicationType);
			packet.SetField("ApplicationDescription", this.m_ApplicationDescription);
			packet.SetField("Caption", this.m_Caption);
			packet.SetField("TimeZoneCaption", this.m_TimeZoneCaption);
			packet.SetField("EndDateTime", this.m_EndDateTime);
			packet.SetField("AgentVersion", this.m_AgentVersion.ToString());
			packet.SetField("UserName", this.m_UserName);
			packet.SetField("UserDomainName", this.m_UserDomainName);
			packet.SetField("HostName", this.m_HostName);
			packet.SetField("DNSDomainName", this.m_DnsDomainName);
			packet.SetField("OSPlatformCode", this.m_OSPlatformCode);
			packet.SetField("OSVersion", this.m_OSVersion.ToString());
			packet.SetField("OSServicePack", this.m_OSServicePack);
			packet.SetField("OSCultureName", this.m_OSCultureName);
			packet.SetField("OSArchitecture", (int)this.m_OSArchitecture);
			packet.SetField("OSBootMode", (int)this.m_OSBootMode);
			packet.SetField("OSSuiteMaskCode", this.m_OSSuiteMaskCode);
			packet.SetField("OSProductTypeCode", this.m_OSProductTypeCode);
			packet.SetField("RuntimeVersion", this.m_RuntimeVersion.ToString());
			packet.SetField("RuntimeArchitecture", (int)this.m_RuntimeArchitecture);
			packet.SetField("CurrentCultureName", this.m_CurrentCultureName);
			packet.SetField("CurrentUICultureName", this.m_CurrentUICultureName);
			packet.SetField("MemoryMB", this.m_MemoryMB);
			packet.SetField("Processors", this.m_Processors);
			packet.SetField("ProcessorCores", this.m_ProcessorCores);
			packet.SetField("UserInteractive", this.m_UserInteractive);
			packet.SetField("TerminalServer", this.m_TerminalServer);
			packet.SetField("ScreenWidth", this.m_ScreenWidth);
			packet.SetField("ScreenHeight", this.m_ScreenHeight);
			packet.SetField("ColorDepth", this.m_ColorDepth);
			packet.SetField("CommandLine", this.m_CommandLine);
			foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair in this.m_Properties)
			{
				packet.SetField(keyValuePair.Key, keyValuePair.Value);
			}
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x0005B480 File Offset: 0x00059680
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.GetField("ProductName", out this.m_ProductName);
			packet.GetField("ApplicationName", out this.m_ApplicationName);
			string version;
			packet.GetField("ApplicationVersion", out version);
			this.m_ApplicationVersion = new global::System.Version(version);
			int applicationType;
			packet.GetField("ApplicationType", out applicationType);
			this.m_ApplicationType = (global::Loupe.Extensibility.Data.ApplicationType)applicationType;
			packet.GetField("ApplicationDescription", out this.m_ApplicationDescription);
			packet.GetField("Caption", out this.m_Caption);
			packet.GetField("TimeZoneCaption", out this.m_TimeZoneCaption);
			packet.GetField("EndDateTime", out this.m_EndDateTime);
			string version2;
			packet.GetField("AgentVersion", out version2);
			this.m_AgentVersion = new global::System.Version(version2);
			packet.GetField("UserName", out this.m_UserName);
			packet.GetField("UserDomainName", out this.m_UserDomainName);
			packet.GetField("HostName", out this.m_HostName);
			packet.GetField("DNSDomainName", out this.m_DnsDomainName);
			packet.GetField("OSPlatformCode", out this.m_OSPlatformCode);
			string version3;
			packet.GetField("OSVersion", out version3);
			this.m_OSVersion = new global::System.Version(version3);
			packet.GetField("OSServicePack", out this.m_OSServicePack);
			packet.GetField("OSCultureName", out this.m_OSCultureName);
			int osarchitecture;
			packet.GetField("OSArchitecture", out osarchitecture);
			this.m_OSArchitecture = (global::System.Reflection.ProcessorArchitecture)osarchitecture;
			int osbootMode;
			packet.GetField("OSBootMode", out osbootMode);
			this.m_OSBootMode = (global::System.Windows.Forms.BootMode)osbootMode;
			packet.GetField("OSSuiteMaskCode", out this.m_OSSuiteMaskCode);
			packet.GetField("OSProductTypeCode", out this.m_OSProductTypeCode);
			string version4;
			packet.GetField("RuntimeVersion", out version4);
			this.m_RuntimeVersion = new global::System.Version(version4);
			int runtimeArchitecture;
			packet.GetField("RuntimeArchitecture", out runtimeArchitecture);
			this.m_RuntimeArchitecture = (global::System.Reflection.ProcessorArchitecture)runtimeArchitecture;
			packet.GetField("CurrentCultureName", out this.m_CurrentCultureName);
			packet.GetField("CurrentUICultureName", out this.m_CurrentUICultureName);
			packet.GetField("MemoryMB", out this.m_MemoryMB);
			packet.GetField("Processors", out this.m_Processors);
			packet.GetField("ProcessorCores", out this.m_ProcessorCores);
			packet.GetField("UserInteractive", out this.m_UserInteractive);
			packet.GetField("TerminalServer", out this.m_TerminalServer);
			packet.GetField("ScreenWidth", out this.m_ScreenWidth);
			packet.GetField("ScreenHeight", out this.m_ScreenHeight);
			packet.GetField("ColorDepth", out this.m_ColorDepth);
			packet.GetField("CommandLine", out this.m_CommandLine);
			int num = 33;
			if (definition.Version > 2)
			{
				packet.GetField("ComputerId", out this.m_ComputerId);
				num++;
			}
			if (definition.Version > 1)
			{
				packet.GetField("EnvironmentName", out this.m_EnvironmentName);
				packet.GetField("PromotionLevelName", out this.m_PromotionLevelName);
				num += 2;
			}
			for (int i = num; i < definition.Fields.Count; i++)
			{
				global::Gibraltar.Serialization.FieldDefinition fieldDefinition = definition.Fields[i];
				string value;
				packet.GetField(fieldDefinition.Name, out value);
				this.m_Properties.Add(fieldDefinition.Name, value);
			}
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0005B7B0 File Offset: 0x000599B0
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.SessionSummaryPacket);
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x0005B7C0 File Offset: 0x000599C0
		public bool Equals(global::Gibraltar.Monitor.Internal.SessionSummaryPacket other)
		{
			if (other == null)
			{
				return false;
			}
			bool flag = this.ComputerId == other.ComputerId && this.Caption == other.Caption && this.EndDateTime == other.EndDateTime && this.ProductName == other.ProductName && this.ApplicationName == other.ApplicationName && this.EnvironmentName == other.EnvironmentName && this.PromotionLevelName == other.PromotionLevelName && this.ApplicationType == other.ApplicationType && this.ApplicationDescription == other.ApplicationDescription && this.ApplicationVersion == other.ApplicationVersion && this.HostName == other.HostName && this.DnsDomainName == other.DnsDomainName && this.AgentVersion == other.AgentVersion && this.UserDomainName == other.UserDomainName && this.UserName == other.UserName && this.TimeZoneCaption == other.TimeZoneCaption && base.Equals(other);
			if (flag)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair in this.m_Properties)
				{
					string value;
					flag = (other.Properties.TryGetValue(keyValuePair.Key, out value) && keyValuePair.Value.Equals(value));
					if (!flag)
					{
						break;
					}
				}
			}
			return flag;
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x0005B9C4 File Offset: 0x00059BC4
		public override int GetHashCode()
		{
			int num = base.GetHashCode();
			global::System.Guid computerId = this.m_ComputerId;
			num ^= this.m_ComputerId.GetHashCode();
			if (this.m_ProductName != null)
			{
				num ^= this.m_ProductName.GetHashCode();
			}
			if (this.m_ApplicationName != null)
			{
				num ^= this.m_ApplicationName.GetHashCode();
			}
			if (this.m_EnvironmentName != null)
			{
				num ^= this.m_EnvironmentName.GetHashCode();
			}
			if (this.m_PromotionLevelName != null)
			{
				num ^= this.m_PromotionLevelName.GetHashCode();
			}
			if (this.m_ApplicationVersion != null)
			{
				num ^= this.m_ApplicationVersion.GetHashCode();
			}
			num ^= this.m_ApplicationType.GetHashCode();
			if (this.m_ApplicationDescription != null)
			{
				num ^= this.m_ApplicationDescription.GetHashCode();
			}
			if (this.m_Caption != null)
			{
				num ^= this.m_Caption.GetHashCode();
			}
			if (this.m_TimeZoneCaption != null)
			{
				num ^= this.m_TimeZoneCaption.GetHashCode();
			}
			num ^= this.m_EndDateTime.GetHashCode();
			if (this.m_AgentVersion != null)
			{
				num ^= this.m_AgentVersion.GetHashCode();
			}
			if (this.m_UserName != null)
			{
				num ^= this.m_UserName.GetHashCode();
			}
			if (this.m_UserDomainName != null)
			{
				num ^= this.m_UserDomainName.GetHashCode();
			}
			if (this.m_HostName != null)
			{
				num ^= this.m_HostName.GetHashCode();
			}
			if (this.m_DnsDomainName != null)
			{
				num ^= this.m_DnsDomainName.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0005BB74 File Offset: 0x00059D74
		private static string SetSafeStringValue(string value, int maxLength)
		{
			string text = value ?? string.Empty;
			if (text.Length > maxLength)
			{
				text = text.Substring(0, maxLength);
			}
			return text;
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0005BBAC File Offset: 0x00059DAC
		private void CalculateFullyQualifiedUserName()
		{
			this.m_FullyQualifiedUserName = (string.IsNullOrEmpty(this.m_UserDomainName) ? this.m_UserName : global::Gibraltar.StringReference.GetReference(this.m_UserDomainName + "\\" + this.m_UserName));
		}

		// Token: 0x04000962 RID: 2402
		private global::System.Guid m_ComputerId;

		// Token: 0x04000963 RID: 2403
		private string m_ProductName;

		// Token: 0x04000964 RID: 2404
		private string m_ApplicationName;

		// Token: 0x04000965 RID: 2405
		private string m_EnvironmentName;

		// Token: 0x04000966 RID: 2406
		private string m_PromotionLevelName;

		// Token: 0x04000967 RID: 2407
		private global::System.Version m_ApplicationVersion;

		// Token: 0x04000968 RID: 2408
		private global::Loupe.Extensibility.Data.ApplicationType m_ApplicationType;

		// Token: 0x04000969 RID: 2409
		private string m_ApplicationDescription;

		// Token: 0x0400096A RID: 2410
		private string m_Caption;

		// Token: 0x0400096B RID: 2411
		private string m_TimeZoneCaption;

		// Token: 0x0400096C RID: 2412
		private global::System.DateTimeOffset m_EndDateTime;

		// Token: 0x0400096D RID: 2413
		private global::System.Version m_AgentVersion;

		// Token: 0x0400096E RID: 2414
		private string m_UserName;

		// Token: 0x0400096F RID: 2415
		private string m_UserDomainName;

		// Token: 0x04000970 RID: 2416
		private string m_HostName;

		// Token: 0x04000971 RID: 2417
		private string m_DnsDomainName;

		// Token: 0x04000972 RID: 2418
		private int m_OSPlatformCode;

		// Token: 0x04000973 RID: 2419
		private global::System.Version m_OSVersion;

		// Token: 0x04000974 RID: 2420
		private string m_OSServicePack;

		// Token: 0x04000975 RID: 2421
		private string m_OSCultureName;

		// Token: 0x04000976 RID: 2422
		private global::System.Reflection.ProcessorArchitecture m_OSArchitecture;

		// Token: 0x04000977 RID: 2423
		private global::System.Windows.Forms.BootMode m_OSBootMode;

		// Token: 0x04000978 RID: 2424
		private int m_OSSuiteMaskCode;

		// Token: 0x04000979 RID: 2425
		private int m_OSProductTypeCode;

		// Token: 0x0400097A RID: 2426
		private global::System.Version m_RuntimeVersion;

		// Token: 0x0400097B RID: 2427
		private global::System.Reflection.ProcessorArchitecture m_RuntimeArchitecture;

		// Token: 0x0400097C RID: 2428
		private string m_CurrentCultureName;

		// Token: 0x0400097D RID: 2429
		private string m_CurrentUICultureName;

		// Token: 0x0400097E RID: 2430
		private int m_MemoryMB;

		// Token: 0x0400097F RID: 2431
		private int m_Processors;

		// Token: 0x04000980 RID: 2432
		private int m_ProcessorCores;

		// Token: 0x04000981 RID: 2433
		private bool m_UserInteractive;

		// Token: 0x04000982 RID: 2434
		private bool m_TerminalServer;

		// Token: 0x04000983 RID: 2435
		private int m_ScreenWidth;

		// Token: 0x04000984 RID: 2436
		private int m_ScreenHeight;

		// Token: 0x04000985 RID: 2437
		private int m_ColorDepth;

		// Token: 0x04000986 RID: 2438
		private string m_CommandLine;

		// Token: 0x04000987 RID: 2439
		private readonly global::System.Collections.Generic.Dictionary<string, string> m_Properties = new global::System.Collections.Generic.Dictionary<string, string>();

		// Token: 0x04000988 RID: 2440
		private string m_FullyQualifiedUserName;

		// Token: 0x04000989 RID: 2441
		private const int SerializationVersion = 3;
	}
}
