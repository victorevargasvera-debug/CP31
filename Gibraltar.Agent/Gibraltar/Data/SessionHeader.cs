using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Data
{
	// Token: 0x0200025A RID: 602
	internal sealed class SessionHeader : global::Loupe.Extensibility.Data.ISessionSummary, global::System.ComponentModel.INotifyPropertyChanged, global::System.IEquatable<global::Gibraltar.Data.SessionHeader>
	{
		// Token: 0x1400008B RID: 139
		// (add) Token: 0x06001E2F RID: 7727 RVA: 0x0006B718 File Offset: 0x00069918
		// (remove) Token: 0x06001E30 RID: 7728 RVA: 0x0006B754 File Offset: 0x00069954
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06001E31 RID: 7729 RVA: 0x0006B790 File Offset: 0x00069990
		public SessionHeader(global::Gibraltar.Monitor.SessionSummary sessionSummary) : this(sessionSummary.Properties)
		{
			this.Id = sessionSummary.Id;
			this.ComputerId = sessionSummary.ComputerId;
			this.Product = sessionSummary.Product;
			this.Application = sessionSummary.Application;
			this.Environment = sessionSummary.Environment;
			this.PromotionLevel = sessionSummary.PromotionLevel;
			this.ApplicationVersion = sessionSummary.ApplicationVersion;
			this.ApplicationTypeName = sessionSummary.ApplicationType.ToString();
			this.ApplicationDescription = sessionSummary.ApplicationDescription;
			this.Caption = sessionSummary.Caption;
			this.StatusName = sessionSummary.Status.ToString();
			this.TimeZoneCaption = sessionSummary.TimeZoneCaption;
			this.StartDateTime = sessionSummary.StartDateTime;
			this.EndDateTime = sessionSummary.EndDateTime;
			this.AgentVersion = sessionSummary.AgentVersion;
			this.UserName = sessionSummary.UserName;
			this.UserDomainName = sessionSummary.UserDomainName;
			this.HostName = sessionSummary.HostName;
			this.DnsDomainName = sessionSummary.DnsDomainName;
			this.MessageCount = sessionSummary.MessageCount;
			this.CriticalCount = sessionSummary.CriticalCount;
			this.ErrorCount = sessionSummary.ErrorCount;
			this.WarningCount = sessionSummary.WarningCount;
			this.OSPlatformCode = sessionSummary.OSPlatformCode;
			this.OSVersion = sessionSummary.OSVersion;
			this.OSServicePack = sessionSummary.OSServicePack;
			this.OSCultureName = sessionSummary.OSCultureName;
			this.OSArchitecture = sessionSummary.OSArchitecture;
			this.OSBootMode = sessionSummary.OSBootMode;
			this.OSSuiteMask = sessionSummary.OSSuiteMask;
			this.OSProductType = sessionSummary.OSProductType;
			this.RuntimeVersion = sessionSummary.RuntimeVersion;
			this.RuntimeArchitecture = sessionSummary.RuntimeArchitecture;
			this.CurrentCultureName = sessionSummary.CurrentCultureName;
			this.CurrentUICultureName = sessionSummary.CurrentUICultureName;
			this.MemoryMB = sessionSummary.MemoryMB;
			this.Processors = sessionSummary.Processors;
			this.ProcessorCores = sessionSummary.ProcessorCores;
			this.UserInteractive = sessionSummary.UserInteractive;
			this.TerminalServer = sessionSummary.TerminalServer;
			this.ScreenWidth = sessionSummary.ScreenWidth;
			this.ScreenHeight = sessionSummary.ScreenHeight;
			this.ColorDepth = sessionSummary.ColorDepth;
			this.CommandLine = sessionSummary.CommandLine;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0006B9DC File Offset: 0x00069BDC
		public SessionHeader(global::System.Collections.Generic.IDictionary<string, string> properties)
		{
			this.m_Lock = new object();
			this.m_Properties = new global::System.Collections.Generic.Dictionary<string, string>();
			base..ctor();
			this.m_MajorVersion = (int)global::Gibraltar.Data.FileHeader.DefaultMajorVersion;
			this.m_MinorVersion = (int)global::Gibraltar.Data.FileHeader.DefaultMinorVersion;
			this.m_Properties = new global::System.Collections.Generic.Dictionary<string, string>(properties);
			this.IsNew = true;
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x0006BA34 File Offset: 0x00069C34
		public SessionHeader(byte[] data)
		{
			this.m_Lock = new object();
			this.m_Properties = new global::System.Collections.Generic.Dictionary<string, string>();
			base..ctor();
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(data))
			{
				this.m_Valid = this.LoadStream(memoryStream, data.Length);
			}
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x0006BA98 File Offset: 0x00069C98
		public SessionHeader(global::System.IO.Stream data, int length)
		{
			this.m_Lock = new object();
			this.m_Properties = new global::System.Collections.Generic.Dictionary<string, string>();
			base..ctor();
			if (data == null)
			{
				throw new global::System.ArgumentNullException("data");
			}
			this.m_Valid = this.LoadStream(data, length);
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x0006BAD8 File Offset: 0x00069CD8
		public byte[] RawData()
		{
			object @lock = this.m_Lock;
			byte[] result;
			lock (@lock)
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(2048);
				byte[] array;
				if (this.m_LastRawData == null)
				{
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_MajorVersion);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_MinorVersion);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_SessionId);
					memoryStream.Write(array, 0, array.Length);
					if (global::Gibraltar.Data.FileHeader.SupportsComputerId(this.m_MajorVersion, this.m_MinorVersion))
					{
						array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_ComputerId.GetValueOrDefault());
						memoryStream.Write(array, 0, array.Length);
					}
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_ProductName);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_ApplicationName);
					memoryStream.Write(array, 0, array.Length);
					if (global::Gibraltar.Data.FileHeader.SupportsEnvironmentAndPromotion(this.m_MajorVersion, this.m_MinorVersion))
					{
						array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_EnvironmentName);
						memoryStream.Write(array, 0, array.Length);
						array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_PromotionLevelName);
						memoryStream.Write(array, 0, array.Length);
					}
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_ApplicationVersion.ToString());
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_ApplicationTypeName);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_ApplicationDescription);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_Caption);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_TimeZoneCaption);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_SessionStatusName);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_SessionStartDateTime);
					memoryStream.Write(array, 0, array.Length);
					this.m_OffsetSessionEndDateTime = memoryStream.Position;
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_SessionEndDateTime);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_AgentVersion.ToString());
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_UserName);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_UserDomainName);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_HostName);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_DnsDomainName);
					memoryStream.Write(array, 0, array.Length);
					this.m_OffsetMessageCount = memoryStream.Position;
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_MessageCount);
					memoryStream.Write(array, 0, array.Length);
					this.m_OffsetCriticalCount = memoryStream.Position;
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_CriticalCount);
					memoryStream.Write(array, 0, array.Length);
					this.m_OffsetErrorCount = memoryStream.Position;
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_ErrorCount);
					memoryStream.Write(array, 0, array.Length);
					this.m_OffsetWarningCount = memoryStream.Position;
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_WarningCount);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_OSPlatformCode);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_OSVersion.ToString());
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_OSServicePack);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_OSCultureName);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_OSArchitecture.ToString());
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_OSBootMode.ToString());
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_OSSuiteMaskCode);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_OSProductTypeCode);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_RuntimeVersion.ToString());
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_RuntimeArchitecture.ToString());
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_CurrentCultureName);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_CurrentUICultureName);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_MemoryMB);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_Processors);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_ProcessorCores);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_UserInteractive);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_TerminalServer);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_ScreenWidth);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_ScreenHeight);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_ColorDepth);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_CommandLine);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_Properties.Count);
					memoryStream.Write(array, 0, array.Length);
					foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair in this.m_Properties)
					{
						array = global::Gibraltar.Data.BinarySerializer.SerializeValue(keyValuePair.Key);
						memoryStream.Write(array, 0, array.Length);
						array = global::Gibraltar.Data.BinarySerializer.SerializeValue(keyValuePair.Value);
						memoryStream.Write(array, 0, array.Length);
					}
					this.m_LastRawData = memoryStream.ToArray();
				}
				else
				{
					memoryStream.Write(this.m_LastRawData, 0, this.m_LastRawData.Length);
				}
				if (this.m_HasFileInfo)
				{
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_FileID);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_FileSequence);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_FileStartDateTime);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_FileEndDateTime);
					memoryStream.Write(array, 0, array.Length);
					array = global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_IsLastFile);
					memoryStream.Write(array, 0, array.Length);
				}
				array = global::Gibraltar.Data.BinarySerializer.CalculateCRC(memoryStream.ToArray(), (int)memoryStream.Position);
				memoryStream.Write(array, 0, array.Length);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x0006C15C File Offset: 0x0006A35C
		// (set) Token: 0x06001E37 RID: 7735 RVA: 0x0006C164 File Offset: 0x0006A364
		public int MajorVersion
		{
			get
			{
				return this.m_MajorVersion;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_MajorVersion = value;
				}
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x0006C1A8 File Offset: 0x0006A3A8
		// (set) Token: 0x06001E39 RID: 7737 RVA: 0x0006C1B0 File Offset: 0x0006A3B0
		public int MinorVersion
		{
			get
			{
				return this.m_MinorVersion;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_MinorVersion = value;
				}
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06001E3A RID: 7738 RVA: 0x0006C1F4 File Offset: 0x0006A3F4
		// (set) Token: 0x06001E3B RID: 7739 RVA: 0x0006C1FC File Offset: 0x0006A3FC
		public global::System.Guid Id
		{
			get
			{
				return this.m_SessionId;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_SessionId = value;
				}
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06001E3C RID: 7740 RVA: 0x0006C240 File Offset: 0x0006A440
		public global::System.Uri Uri
		{
			get
			{
				throw new global::System.NotSupportedException("Links are not supported in this context");
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06001E3D RID: 7741 RVA: 0x0006C24C File Offset: 0x0006A44C
		public bool IsComplete
		{
			get
			{
				return this.m_HasFileInfo && this.m_IsLastFile;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x0006C264 File Offset: 0x0006A464
		// (set) Token: 0x06001E3F RID: 7743 RVA: 0x0006C26C File Offset: 0x0006A46C
		public global::System.Guid? ComputerId
		{
			get
			{
				return this.m_ComputerId;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_ComputerId = value;
				}
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x0006C2B0 File Offset: 0x0006A4B0
		// (set) Token: 0x06001E41 RID: 7745 RVA: 0x0006C2B8 File Offset: 0x0006A4B8
		public string Caption
		{
			get
			{
				return this.m_Caption;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_Caption = value;
				}
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x0006C2FC File Offset: 0x0006A4FC
		// (set) Token: 0x06001E43 RID: 7747 RVA: 0x0006C304 File Offset: 0x0006A504
		public string Product
		{
			get
			{
				return this.m_ProductName;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_ProductName = value;
				}
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x0006C348 File Offset: 0x0006A548
		// (set) Token: 0x06001E45 RID: 7749 RVA: 0x0006C350 File Offset: 0x0006A550
		public string Application
		{
			get
			{
				return this.m_ApplicationName;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_ApplicationName = value;
				}
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x0006C394 File Offset: 0x0006A594
		// (set) Token: 0x06001E47 RID: 7751 RVA: 0x0006C39C File Offset: 0x0006A59C
		public string Environment
		{
			get
			{
				return this.m_EnvironmentName;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_EnvironmentName = value;
				}
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x0006C3E0 File Offset: 0x0006A5E0
		// (set) Token: 0x06001E49 RID: 7753 RVA: 0x0006C3E8 File Offset: 0x0006A5E8
		public string PromotionLevel
		{
			get
			{
				return this.m_PromotionLevelName;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_PromotionLevelName = value;
				}
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x0006C42C File Offset: 0x0006A62C
		public global::Loupe.Extensibility.Data.ApplicationType ApplicationType
		{
			get
			{
				return (global::Loupe.Extensibility.Data.ApplicationType)global::System.Enum.Parse(typeof(global::Loupe.Extensibility.Data.ApplicationType), this.m_ApplicationTypeName, true);
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x0006C44C File Offset: 0x0006A64C
		// (set) Token: 0x06001E4C RID: 7756 RVA: 0x0006C454 File Offset: 0x0006A654
		public string ApplicationTypeName
		{
			get
			{
				return this.m_ApplicationTypeName;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_ApplicationTypeName = value;
				}
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06001E4D RID: 7757 RVA: 0x0006C498 File Offset: 0x0006A698
		// (set) Token: 0x06001E4E RID: 7758 RVA: 0x0006C4A0 File Offset: 0x0006A6A0
		public string ApplicationDescription
		{
			get
			{
				return this.m_ApplicationDescription;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_ApplicationDescription = value;
				}
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06001E4F RID: 7759 RVA: 0x0006C4E4 File Offset: 0x0006A6E4
		// (set) Token: 0x06001E50 RID: 7760 RVA: 0x0006C4EC File Offset: 0x0006A6EC
		public global::System.Version ApplicationVersion
		{
			get
			{
				return this.m_ApplicationVersion;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_ApplicationVersion = value;
				}
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06001E51 RID: 7761 RVA: 0x0006C530 File Offset: 0x0006A730
		// (set) Token: 0x06001E52 RID: 7762 RVA: 0x0006C538 File Offset: 0x0006A738
		public global::System.Version AgentVersion
		{
			get
			{
				return this.m_AgentVersion;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_AgentVersion = value;
				}
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06001E53 RID: 7763 RVA: 0x0006C57C File Offset: 0x0006A77C
		// (set) Token: 0x06001E54 RID: 7764 RVA: 0x0006C584 File Offset: 0x0006A784
		public string HostName
		{
			get
			{
				return this.m_HostName;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_HostName = value;
				}
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06001E55 RID: 7765 RVA: 0x0006C5C8 File Offset: 0x0006A7C8
		// (set) Token: 0x06001E56 RID: 7766 RVA: 0x0006C5D0 File Offset: 0x0006A7D0
		public string DnsDomainName
		{
			get
			{
				return this.m_DnsDomainName;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_DnsDomainName = value;
				}
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06001E57 RID: 7767 RVA: 0x0006C614 File Offset: 0x0006A814
		// (set) Token: 0x06001E58 RID: 7768 RVA: 0x0006C61C File Offset: 0x0006A81C
		public string TimeZoneCaption
		{
			get
			{
				return this.m_TimeZoneCaption;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_TimeZoneCaption = value;
				}
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06001E59 RID: 7769 RVA: 0x0006C660 File Offset: 0x0006A860
		// (set) Token: 0x06001E5A RID: 7770 RVA: 0x0006C668 File Offset: 0x0006A868
		public string UserName
		{
			get
			{
				return this.m_UserName;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_FullyQualifiedUserName = null;
					this.m_UserName = value;
				}
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06001E5B RID: 7771 RVA: 0x0006C6B4 File Offset: 0x0006A8B4
		// (set) Token: 0x06001E5C RID: 7772 RVA: 0x0006C6BC File Offset: 0x0006A8BC
		public string UserDomainName
		{
			get
			{
				return this.m_UserDomainName;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_FullyQualifiedUserName = null;
					this.m_UserDomainName = value;
				}
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x0006C708 File Offset: 0x0006A908
		public string FullyQualifiedUserName
		{
			get
			{
				if (this.m_FullyQualifiedUserName == null)
				{
					this.m_FullyQualifiedUserName = (string.IsNullOrEmpty(this.UserDomainName) ? this.UserName : (this.UserDomainName + "\\" + this.UserName));
				}
				return this.m_FullyQualifiedUserName;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x0006C764 File Offset: 0x0006A964
		// (set) Token: 0x06001E5F RID: 7775 RVA: 0x0006C76C File Offset: 0x0006A96C
		public global::System.DateTimeOffset StartDateTime
		{
			get
			{
				return this.m_SessionStartDateTime;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_SessionStartDateTime = value;
				}
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x0006C7B0 File Offset: 0x0006A9B0
		public global::System.DateTimeOffset DisplayStartDateTime
		{
			get
			{
				return this.StartDateTime;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06001E61 RID: 7777 RVA: 0x0006C7B8 File Offset: 0x0006A9B8
		// (set) Token: 0x06001E62 RID: 7778 RVA: 0x0006C7C0 File Offset: 0x0006A9C0
		public global::System.DateTimeOffset EndDateTime
		{
			get
			{
				return this.m_SessionEndDateTime;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					if (this.m_LastRawData != null)
					{
						if (this.m_OffsetSessionEndDateTime == 0L)
						{
							this.m_LastRawData = null;
						}
						else
						{
							global::Gibraltar.Data.BinarySerializer.SerializeValue(value).CopyTo(this.m_LastRawData, this.m_OffsetSessionEndDateTime);
						}
					}
					this.m_SessionEndDateTime = value;
				}
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06001E63 RID: 7779 RVA: 0x0006C838 File Offset: 0x0006AA38
		public global::System.DateTimeOffset DisplayEndDateTime
		{
			get
			{
				return this.EndDateTime;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001E64 RID: 7780 RVA: 0x0006C840 File Offset: 0x0006AA40
		public global::System.TimeSpan Duration
		{
			get
			{
				global::System.TimeSpan result = this.m_SessionEndDateTime - this.m_SessionStartDateTime;
				if (result.TotalSeconds < 0.0)
				{
					result = new global::System.TimeSpan(0L);
				}
				return result;
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x0006C884 File Offset: 0x0006AA84
		public global::Loupe.Extensibility.Data.SessionStatus Status
		{
			get
			{
				return this.m_SessionStatus;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x0006C88C File Offset: 0x0006AA8C
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x0006C894 File Offset: 0x0006AA94
		public string StatusName
		{
			get
			{
				return this.m_SessionStatusName;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					if (string.CompareOrdinal(this.m_SessionStatusName, value) != 0)
					{
						this.m_LastRawData = null;
						this.m_SessionStatusName = value;
						this.m_SessionStatus = this.StatusNameToStatus(this.m_SessionStatusName);
					}
				}
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x0006C8FC File Offset: 0x0006AAFC
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x0006C904 File Offset: 0x0006AB04
		public int MessageCount
		{
			get
			{
				return this.m_MessageCount;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					if (this.m_LastRawData != null)
					{
						if (this.m_OffsetMessageCount == 0L)
						{
							this.m_LastRawData = null;
						}
						else
						{
							global::Gibraltar.Data.BinarySerializer.SerializeValue(value).CopyTo(this.m_LastRawData, this.m_OffsetMessageCount);
						}
					}
					this.m_MessageCount = value;
				}
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x0006C97C File Offset: 0x0006AB7C
		// (set) Token: 0x06001E6B RID: 7787 RVA: 0x0006C984 File Offset: 0x0006AB84
		public int CriticalCount
		{
			get
			{
				return this.m_CriticalCount;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					if (this.m_LastRawData != null)
					{
						if (this.m_OffsetCriticalCount == 0L)
						{
							this.m_LastRawData = null;
						}
						else
						{
							global::Gibraltar.Data.BinarySerializer.SerializeValue(value).CopyTo(this.m_LastRawData, this.m_OffsetCriticalCount);
						}
					}
					this.m_CriticalCount = value;
				}
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x0006C9FC File Offset: 0x0006ABFC
		// (set) Token: 0x06001E6D RID: 7789 RVA: 0x0006CA04 File Offset: 0x0006AC04
		public int ErrorCount
		{
			get
			{
				return this.m_ErrorCount;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					if (this.m_LastRawData != null)
					{
						if (this.m_OffsetErrorCount == 0L)
						{
							this.m_LastRawData = null;
						}
						else
						{
							global::Gibraltar.Data.BinarySerializer.SerializeValue(value).CopyTo(this.m_LastRawData, this.m_OffsetErrorCount);
						}
					}
					this.m_ErrorCount = value;
				}
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x0006CA7C File Offset: 0x0006AC7C
		// (set) Token: 0x06001E6F RID: 7791 RVA: 0x0006CA84 File Offset: 0x0006AC84
		public int WarningCount
		{
			get
			{
				return this.m_WarningCount;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					if (this.m_LastRawData != null)
					{
						if (this.m_OffsetWarningCount == 0L)
						{
							this.m_LastRawData = null;
						}
						else
						{
							global::Gibraltar.Data.BinarySerializer.SerializeValue(value).CopyTo(this.m_LastRawData, this.m_OffsetWarningCount);
						}
					}
					this.m_WarningCount = value;
				}
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x0006CAFC File Offset: 0x0006ACFC
		// (set) Token: 0x06001E71 RID: 7793 RVA: 0x0006CB04 File Offset: 0x0006AD04
		public global::System.Version OSVersion
		{
			get
			{
				return this.m_OSVersion;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_OSVersion = value;
				}
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x0006CB48 File Offset: 0x0006AD48
		// (set) Token: 0x06001E73 RID: 7795 RVA: 0x0006CB50 File Offset: 0x0006AD50
		public string OSServicePack
		{
			get
			{
				return this.m_OSServicePack;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_OSServicePack = value;
				}
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x0006CB94 File Offset: 0x0006AD94
		// (set) Token: 0x06001E75 RID: 7797 RVA: 0x0006CB9C File Offset: 0x0006AD9C
		public string OSCultureName
		{
			get
			{
				return this.m_OSCultureName;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_OSCultureName = value;
				}
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x0006CBE0 File Offset: 0x0006ADE0
		// (set) Token: 0x06001E77 RID: 7799 RVA: 0x0006CBE8 File Offset: 0x0006ADE8
		public int OSPlatformCode
		{
			get
			{
				return this.m_OSPlatformCode;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_OSPlatformCode = value;
				}
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06001E78 RID: 7800 RVA: 0x0006CC2C File Offset: 0x0006AE2C
		// (set) Token: 0x06001E79 RID: 7801 RVA: 0x0006CC34 File Offset: 0x0006AE34
		public int OSProductType
		{
			get
			{
				return this.m_OSProductTypeCode;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_OSProductTypeCode = value;
				}
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x0006CC78 File Offset: 0x0006AE78
		// (set) Token: 0x06001E7B RID: 7803 RVA: 0x0006CC80 File Offset: 0x0006AE80
		public int OSSuiteMask
		{
			get
			{
				return this.m_OSSuiteMaskCode;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_OSSuiteMaskCode = value;
				}
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x0006CCC4 File Offset: 0x0006AEC4
		public string OSFamilyName
		{
			get
			{
				this.EnsureOSInfoLoaded();
				return this.m_VersionInfo.FamilyName;
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x0006CCD8 File Offset: 0x0006AED8
		public string OSEditionName
		{
			get
			{
				this.EnsureOSInfoLoaded();
				return this.m_VersionInfo.EditionName;
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x0006CCEC File Offset: 0x0006AEEC
		public string OSFullName
		{
			get
			{
				this.EnsureOSInfoLoaded();
				return this.m_VersionInfo.FullName;
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x0006CD00 File Offset: 0x0006AF00
		public string OSFullNameWithServicePack
		{
			get
			{
				this.EnsureOSInfoLoaded();
				return this.m_VersionInfo.FullNameWithServicePack;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x0006CD14 File Offset: 0x0006AF14
		// (set) Token: 0x06001E81 RID: 7809 RVA: 0x0006CD1C File Offset: 0x0006AF1C
		public global::System.Reflection.ProcessorArchitecture OSArchitecture
		{
			get
			{
				return this.m_OSArchitecture;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_OSArchitecture = value;
				}
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06001E82 RID: 7810 RVA: 0x0006CD60 File Offset: 0x0006AF60
		// (set) Token: 0x06001E83 RID: 7811 RVA: 0x0006CD68 File Offset: 0x0006AF68
		public global::System.Windows.Forms.BootMode OSBootMode
		{
			get
			{
				return this.m_OSBootMode;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_OSBootMode = value;
				}
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x0006CDAC File Offset: 0x0006AFAC
		// (set) Token: 0x06001E85 RID: 7813 RVA: 0x0006CDB4 File Offset: 0x0006AFB4
		public global::System.Version RuntimeVersion
		{
			get
			{
				return this.m_RuntimeVersion;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_RuntimeVersion = value;
				}
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x0006CDF8 File Offset: 0x0006AFF8
		// (set) Token: 0x06001E87 RID: 7815 RVA: 0x0006CE00 File Offset: 0x0006B000
		public global::System.Reflection.ProcessorArchitecture RuntimeArchitecture
		{
			get
			{
				return this.m_RuntimeArchitecture;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_RuntimeArchitecture = value;
				}
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x0006CE44 File Offset: 0x0006B044
		// (set) Token: 0x06001E89 RID: 7817 RVA: 0x0006CE4C File Offset: 0x0006B04C
		public string CurrentCultureName
		{
			get
			{
				return this.m_CurrentCultureName;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_CurrentCultureName = value;
				}
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x0006CE90 File Offset: 0x0006B090
		// (set) Token: 0x06001E8B RID: 7819 RVA: 0x0006CE98 File Offset: 0x0006B098
		public string CurrentUICultureName
		{
			get
			{
				return this.m_CurrentUICultureName;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_CurrentUICultureName = value;
				}
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x0006CEDC File Offset: 0x0006B0DC
		// (set) Token: 0x06001E8D RID: 7821 RVA: 0x0006CEE4 File Offset: 0x0006B0E4
		public int MemoryMB
		{
			get
			{
				return this.m_MemoryMB;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_MemoryMB = value;
				}
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x0006CF28 File Offset: 0x0006B128
		// (set) Token: 0x06001E8F RID: 7823 RVA: 0x0006CF30 File Offset: 0x0006B130
		public int Processors
		{
			get
			{
				return this.m_Processors;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_Processors = value;
				}
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x0006CF74 File Offset: 0x0006B174
		// (set) Token: 0x06001E91 RID: 7825 RVA: 0x0006CF7C File Offset: 0x0006B17C
		public int ProcessorCores
		{
			get
			{
				return this.m_ProcessorCores;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_ProcessorCores = value;
				}
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x0006CFC0 File Offset: 0x0006B1C0
		// (set) Token: 0x06001E93 RID: 7827 RVA: 0x0006CFC8 File Offset: 0x0006B1C8
		public bool UserInteractive
		{
			get
			{
				return this.m_UserInteractive;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_UserInteractive = value;
				}
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x0006D00C File Offset: 0x0006B20C
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x0006D014 File Offset: 0x0006B214
		public bool TerminalServer
		{
			get
			{
				return this.m_TerminalServer;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_TerminalServer = value;
				}
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x0006D058 File Offset: 0x0006B258
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x0006D060 File Offset: 0x0006B260
		public int ScreenWidth
		{
			get
			{
				return this.m_ScreenWidth;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_ScreenWidth = value;
				}
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x0006D0A4 File Offset: 0x0006B2A4
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x0006D0AC File Offset: 0x0006B2AC
		public int ScreenHeight
		{
			get
			{
				return this.m_ScreenHeight;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_ScreenHeight = value;
				}
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x0006D0F0 File Offset: 0x0006B2F0
		// (set) Token: 0x06001E9B RID: 7835 RVA: 0x0006D0F8 File Offset: 0x0006B2F8
		public int ColorDepth
		{
			get
			{
				return this.m_ColorDepth;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_ColorDepth = value;
				}
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x0006D13C File Offset: 0x0006B33C
		// (set) Token: 0x06001E9D RID: 7837 RVA: 0x0006D144 File Offset: 0x0006B344
		public string CommandLine
		{
			get
			{
				return this.m_CommandLine;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_LastRawData = null;
					this.m_CommandLine = value;
				}
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x0006D188 File Offset: 0x0006B388
		// (set) Token: 0x06001E9F RID: 7839 RVA: 0x0006D190 File Offset: 0x0006B390
		public global::System.Guid FileId
		{
			get
			{
				return this.m_FileID;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_FileID = value;
					this.m_HasFileInfo = true;
				}
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x0006D1D4 File Offset: 0x0006B3D4
		// (set) Token: 0x06001EA1 RID: 7841 RVA: 0x0006D1DC File Offset: 0x0006B3DC
		public global::System.DateTimeOffset FileStartDateTime
		{
			get
			{
				return this.m_FileStartDateTime;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_FileStartDateTime = value;
				}
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x0006D21C File Offset: 0x0006B41C
		// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x0006D224 File Offset: 0x0006B424
		public global::System.DateTimeOffset FileEndDateTime
		{
			get
			{
				return this.m_FileEndDateTime;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_FileEndDateTime = value;
				}
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x0006D264 File Offset: 0x0006B464
		// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x0006D26C File Offset: 0x0006B46C
		public int FileSequence
		{
			get
			{
				return this.m_FileSequence;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_FileSequence = value;
				}
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x0006D2AC File Offset: 0x0006B4AC
		public global::System.Collections.Generic.IDictionary<string, string> Properties
		{
			get
			{
				return this.m_Properties;
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06001EA7 RID: 7847 RVA: 0x0006D2B4 File Offset: 0x0006B4B4
		public global::Loupe.Extensibility.Data.IComputer Computer
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06001EA8 RID: 7848 RVA: 0x0006D2B8 File Offset: 0x0006B4B8
		public global::System.DateTimeOffset AddedDateTime
		{
			get
			{
				return this.m_SessionStartDateTime;
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001EA9 RID: 7849 RVA: 0x0006D2C0 File Offset: 0x0006B4C0
		public global::System.DateTimeOffset DisplayAddedDateTime
		{
			get
			{
				return this.m_SessionStartDateTime;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x0006D2C8 File Offset: 0x0006B4C8
		public global::System.DateTimeOffset UpdatedDateTime
		{
			get
			{
				return this.m_FileEndDateTime;
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001EAB RID: 7851 RVA: 0x0006D2D0 File Offset: 0x0006B4D0
		public global::System.DateTimeOffset DisplayUpdatedDateTime
		{
			get
			{
				return this.m_FileEndDateTime;
			}
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x0006D2D8 File Offset: 0x0006B4D8
		global::Loupe.Extensibility.Data.ISession global::Loupe.Extensibility.Data.ISessionSummary.Session()
		{
			throw new global::System.NotSupportedException("Loading a full session from a raw session header isn't supported");
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001EAD RID: 7853 RVA: 0x0006D2E4 File Offset: 0x0006B4E4
		// (set) Token: 0x06001EAE RID: 7854 RVA: 0x0006D2EC File Offset: 0x0006B4EC
		public bool IsLastFile
		{
			get
			{
				return this.m_IsLastFile;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_IsLastFile = value;
				}
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001EAF RID: 7855 RVA: 0x0006D32C File Offset: 0x0006B52C
		public bool IsValid
		{
			get
			{
				return this.m_Valid;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x0006D334 File Offset: 0x0006B534
		// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x0006D33C File Offset: 0x0006B53C
		public bool IsNew { get; set; }

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x0006D348 File Offset: 0x0006B548
		// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x0006D350 File Offset: 0x0006B550
		public bool IsLive { get; set; }

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x0006D35C File Offset: 0x0006B55C
		// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x0006D364 File Offset: 0x0006B564
		public bool HasData { get; set; }

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x0006D370 File Offset: 0x0006B570
		public bool HasFileInfo
		{
			get
			{
				return this.m_HasFileInfo;
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x0006D378 File Offset: 0x0006B578
		public bool SupportsFragments
		{
			get
			{
				return global::Gibraltar.Data.FileHeader.SupportsFragments(this.m_MajorVersion, this.m_MinorVersion);
			}
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x0006D38C File Offset: 0x0006B58C
		public bool Equals(global::Gibraltar.Data.SessionHeader other)
		{
			return other != null && this.m_SessionId.Equals(other.Id);
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x0006D3A8 File Offset: 0x0006B5A8
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Gibraltar.Data.SessionHeader);
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x0006D3B8 File Offset: 0x0006B5B8
		public override int GetHashCode()
		{
			if (this.m_HashCode == 0)
			{
				this.CalculateHash();
			}
			return this.m_HashCode;
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x0006D3D4 File Offset: 0x0006B5D4
		private static bool ArraysAreEqual<T>(T[] source, T[] target)
		{
			if (source == null && target == null)
			{
				return true;
			}
			if (source == null || target == null)
			{
				return false;
			}
			if (source.Length != target.Length)
			{
				return false;
			}
			for (int i = 0; i < source.Length; i++)
			{
				if (!source[i].Equals(target[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x0006D448 File Offset: 0x0006B648
		private global::Loupe.Extensibility.Data.SessionStatus StatusNameToStatus(string name)
		{
			global::Loupe.Extensibility.Data.SessionStatus sessionStatus = global::Loupe.Extensibility.Data.SessionStatus.Unknown;
			if (!(name == "Running") && !(name == "running"))
			{
				if (!(name == "Normal") && !(name == "normal"))
				{
					if (name == "Crashed" || name == "crashed")
					{
						sessionStatus = global::Loupe.Extensibility.Data.SessionStatus.Crashed;
					}
				}
				else
				{
					sessionStatus = global::Loupe.Extensibility.Data.SessionStatus.Normal;
				}
			}
			else
			{
				sessionStatus = global::Loupe.Extensibility.Data.SessionStatus.Running;
			}
			if (sessionStatus == global::Loupe.Extensibility.Data.SessionStatus.Unknown)
			{
				string a = name.ToLowerInvariant();
				if (!(a == "crashed"))
				{
					if (!(a == "normal"))
					{
						if (!(a == "running"))
						{
							if (!(a == "unknown"))
							{
							}
							sessionStatus = global::Loupe.Extensibility.Data.SessionStatus.Unknown;
						}
						else
						{
							sessionStatus = global::Loupe.Extensibility.Data.SessionStatus.Running;
						}
					}
					else
					{
						sessionStatus = global::Loupe.Extensibility.Data.SessionStatus.Normal;
					}
				}
				else
				{
					sessionStatus = global::Loupe.Extensibility.Data.SessionStatus.Crashed;
				}
			}
			return sessionStatus;
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x0006D53C File Offset: 0x0006B73C
		private bool LoadStream(global::System.IO.Stream rawData, int length)
		{
			long position = rawData.Position;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_MajorVersion);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_MinorVersion);
			if (this.m_MajorVersion > (int)global::Gibraltar.Data.FileHeader.DefaultMajorVersion)
			{
				return false;
			}
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_SessionId);
			if (global::Gibraltar.Data.FileHeader.SupportsComputerId(this.m_MajorVersion, this.m_MinorVersion))
			{
				global::System.Guid value;
				global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out value);
				this.m_ComputerId = new global::System.Guid?(value);
			}
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_ProductName);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_ApplicationName);
			if (global::Gibraltar.Data.FileHeader.SupportsEnvironmentAndPromotion(this.m_MajorVersion, this.m_MinorVersion))
			{
				global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_EnvironmentName);
				global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_PromotionLevelName);
			}
			string version;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out version);
			this.m_ApplicationVersion = new global::System.Version(version);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_ApplicationTypeName);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_ApplicationDescription);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_Caption);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_TimeZoneCaption);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_SessionStatusName);
			this.m_SessionStatus = this.StatusNameToStatus(this.m_SessionStatusName);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_SessionStartDateTime);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_SessionEndDateTime);
			string version2;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out version2);
			this.m_AgentVersion = new global::System.Version(version2);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_UserName);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_UserDomainName);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_HostName);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_DnsDomainName);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_MessageCount);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_CriticalCount);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_ErrorCount);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_WarningCount);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_OSPlatformCode);
			string version3;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out version3);
			this.m_OSVersion = new global::System.Version(version3);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_OSServicePack);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_OSCultureName);
			string value2;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out value2);
			this.m_OSArchitecture = (global::System.Reflection.ProcessorArchitecture)global::System.Enum.Parse(typeof(global::System.Reflection.ProcessorArchitecture), value2, true);
			string value3;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out value3);
			this.m_OSBootMode = (global::System.Windows.Forms.BootMode)global::System.Enum.Parse(typeof(global::System.Windows.Forms.BootMode), value3, true);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_OSSuiteMaskCode);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_OSProductTypeCode);
			string version4;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out version4);
			this.m_RuntimeVersion = new global::System.Version(version4);
			string value4;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out value4);
			this.m_RuntimeArchitecture = (global::System.Reflection.ProcessorArchitecture)global::System.Enum.Parse(typeof(global::System.Reflection.ProcessorArchitecture), value4, true);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_CurrentCultureName);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_CurrentUICultureName);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_MemoryMB);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_Processors);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_ProcessorCores);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_UserInteractive);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_TerminalServer);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_ScreenWidth);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_ScreenHeight);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_ColorDepth);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_CommandLine);
			int num;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out num);
			for (int i = 0; i < num; i++)
			{
				string key;
				global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out key);
				string value5;
				global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out value5);
				this.m_Properties.Add(key, value5);
			}
			long num2 = (length == 0) ? rawData.Length : ((long)length);
			if (rawData.Position < num2 - 4L)
			{
				this.m_HasFileInfo = true;
				global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_FileID);
				global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_FileSequence);
				global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_FileStartDateTime);
				global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_FileEndDateTime);
				global::Gibraltar.Data.BinarySerializer.DeserializeValue(rawData, out this.m_IsLastFile);
			}
			byte[] array = new byte[rawData.Position - position];
			rawData.Position = position;
			rawData.Read(array, 0, array.Length);
			byte[] array2 = new byte[4];
			rawData.Read(array2, 0, array2.Length);
			bool result = global::Gibraltar.Data.SessionHeader.ArraysAreEqual<byte>(global::Gibraltar.Data.BinarySerializer.CalculateCRC(array, array.Length), array2);
			this.SwapStringReferences();
			return result;
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x0006D938 File Offset: 0x0006BB38
		private void CalculateHash()
		{
			int hashCode = this.m_SessionId.GetHashCode();
			this.m_HashCode = hashCode;
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x0006D964 File Offset: 0x0006BB64
		private void EnsureOSInfoLoaded()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_VersionInfo = new global::Gibraltar.OSVersionInfo(this.OSPlatformCode, this.OSVersion, this.OSServicePack, this.OSSuiteMask, this.OSProductType);
			}
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x0006D9C4 File Offset: 0x0006BBC4
		private void SwapStringReferences()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				global::Gibraltar.StringReference.SwapReference(ref this.m_ProductName);
				global::Gibraltar.StringReference.SwapReference(ref this.m_ApplicationName);
				global::Gibraltar.StringReference.SwapReference(ref this.m_EnvironmentName);
				global::Gibraltar.StringReference.SwapReference(ref this.m_PromotionLevelName);
				global::Gibraltar.StringReference.SwapReference(ref this.m_ApplicationTypeName);
				global::Gibraltar.StringReference.SwapReference(ref this.m_ApplicationDescription);
				global::Gibraltar.StringReference.SwapReference(ref this.m_Caption);
				global::Gibraltar.StringReference.SwapReference(ref this.m_TimeZoneCaption);
				global::Gibraltar.StringReference.SwapReference(ref this.m_SessionStatusName);
				global::Gibraltar.StringReference.SwapReference(ref this.m_UserName);
				global::Gibraltar.StringReference.SwapReference(ref this.m_UserDomainName);
				global::Gibraltar.StringReference.SwapReference(ref this.m_HostName);
				global::Gibraltar.StringReference.SwapReference(ref this.m_DnsDomainName);
				global::Gibraltar.StringReference.SwapReference(ref this.m_OSServicePack);
				global::Gibraltar.StringReference.SwapReference(ref this.m_OSCultureName);
				global::Gibraltar.StringReference.SwapReference(ref this.m_CurrentCultureName);
				global::Gibraltar.StringReference.SwapReference(ref this.m_CurrentUICultureName);
				global::Gibraltar.StringReference.SwapReference(ref this.m_CommandLine);
			}
		}

		// Token: 0x04000B46 RID: 2886
		private readonly object m_Lock;

		// Token: 0x04000B47 RID: 2887
		private int m_MajorVersion;

		// Token: 0x04000B48 RID: 2888
		private int m_MinorVersion;

		// Token: 0x04000B49 RID: 2889
		private global::System.Guid? m_ComputerId;

		// Token: 0x04000B4A RID: 2890
		private global::System.Guid m_SessionId;

		// Token: 0x04000B4B RID: 2891
		private global::System.DateTimeOffset m_SessionStartDateTime;

		// Token: 0x04000B4C RID: 2892
		private global::System.DateTimeOffset m_SessionEndDateTime;

		// Token: 0x04000B4D RID: 2893
		private string m_Caption;

		// Token: 0x04000B4E RID: 2894
		private string m_ProductName;

		// Token: 0x04000B4F RID: 2895
		private string m_ApplicationName;

		// Token: 0x04000B50 RID: 2896
		private string m_EnvironmentName;

		// Token: 0x04000B51 RID: 2897
		private string m_PromotionLevelName;

		// Token: 0x04000B52 RID: 2898
		private global::System.Version m_ApplicationVersion;

		// Token: 0x04000B53 RID: 2899
		private string m_ApplicationTypeName;

		// Token: 0x04000B54 RID: 2900
		private string m_ApplicationDescription;

		// Token: 0x04000B55 RID: 2901
		private string m_TimeZoneCaption;

		// Token: 0x04000B56 RID: 2902
		private global::System.Version m_AgentVersion;

		// Token: 0x04000B57 RID: 2903
		private string m_UserName;

		// Token: 0x04000B58 RID: 2904
		private string m_UserDomainName;

		// Token: 0x04000B59 RID: 2905
		private string m_HostName;

		// Token: 0x04000B5A RID: 2906
		private string m_DnsDomainName;

		// Token: 0x04000B5B RID: 2907
		private string m_SessionStatusName;

		// Token: 0x04000B5C RID: 2908
		private int m_MessageCount;

		// Token: 0x04000B5D RID: 2909
		private int m_CriticalCount;

		// Token: 0x04000B5E RID: 2910
		private int m_ErrorCount;

		// Token: 0x04000B5F RID: 2911
		private int m_WarningCount;

		// Token: 0x04000B60 RID: 2912
		private int m_OSPlatformCode;

		// Token: 0x04000B61 RID: 2913
		private global::System.Version m_OSVersion;

		// Token: 0x04000B62 RID: 2914
		private string m_OSServicePack;

		// Token: 0x04000B63 RID: 2915
		private string m_OSCultureName;

		// Token: 0x04000B64 RID: 2916
		private global::System.Reflection.ProcessorArchitecture m_OSArchitecture;

		// Token: 0x04000B65 RID: 2917
		private global::System.Windows.Forms.BootMode m_OSBootMode;

		// Token: 0x04000B66 RID: 2918
		private int m_OSSuiteMaskCode;

		// Token: 0x04000B67 RID: 2919
		private int m_OSProductTypeCode;

		// Token: 0x04000B68 RID: 2920
		private global::System.Version m_RuntimeVersion;

		// Token: 0x04000B69 RID: 2921
		private global::System.Reflection.ProcessorArchitecture m_RuntimeArchitecture;

		// Token: 0x04000B6A RID: 2922
		private string m_CurrentCultureName;

		// Token: 0x04000B6B RID: 2923
		private string m_CurrentUICultureName;

		// Token: 0x04000B6C RID: 2924
		private int m_MemoryMB;

		// Token: 0x04000B6D RID: 2925
		private int m_Processors;

		// Token: 0x04000B6E RID: 2926
		private int m_ProcessorCores;

		// Token: 0x04000B6F RID: 2927
		private bool m_UserInteractive;

		// Token: 0x04000B70 RID: 2928
		private bool m_TerminalServer;

		// Token: 0x04000B71 RID: 2929
		private int m_ScreenWidth;

		// Token: 0x04000B72 RID: 2930
		private int m_ScreenHeight;

		// Token: 0x04000B73 RID: 2931
		private int m_ColorDepth;

		// Token: 0x04000B74 RID: 2932
		private string m_CommandLine;

		// Token: 0x04000B75 RID: 2933
		private readonly global::System.Collections.Generic.Dictionary<string, string> m_Properties;

		// Token: 0x04000B76 RID: 2934
		private bool m_HasFileInfo;

		// Token: 0x04000B77 RID: 2935
		private global::System.Guid m_FileID;

		// Token: 0x04000B78 RID: 2936
		private global::System.DateTimeOffset m_FileStartDateTime;

		// Token: 0x04000B79 RID: 2937
		private global::System.DateTimeOffset m_FileEndDateTime;

		// Token: 0x04000B7A RID: 2938
		private readonly bool m_Valid;

		// Token: 0x04000B7B RID: 2939
		private bool m_IsLastFile;

		// Token: 0x04000B7C RID: 2940
		private int m_FileSequence;

		// Token: 0x04000B7D RID: 2941
		private long m_OffsetSessionEndDateTime;

		// Token: 0x04000B7E RID: 2942
		private long m_OffsetMessageCount;

		// Token: 0x04000B7F RID: 2943
		private long m_OffsetCriticalCount;

		// Token: 0x04000B80 RID: 2944
		private long m_OffsetErrorCount;

		// Token: 0x04000B81 RID: 2945
		private long m_OffsetWarningCount;

		// Token: 0x04000B82 RID: 2946
		private byte[] m_LastRawData;

		// Token: 0x04000B83 RID: 2947
		private string m_FullyQualifiedUserName;

		// Token: 0x04000B84 RID: 2948
		private int m_HashCode;

		// Token: 0x04000B85 RID: 2949
		private global::Gibraltar.OSVersionInfo m_VersionInfo;

		// Token: 0x04000B86 RID: 2950
		private global::Loupe.Extensibility.Data.SessionStatus m_SessionStatus;
	}
}
