using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Gibraltar.Data;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;
using Microsoft.VisualBasic.Devices;

namespace Gibraltar.Monitor
{
	// Token: 0x020001AA RID: 426
	internal class SessionSummary : global::Loupe.Extensibility.Data.ISessionSummary, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1400006A RID: 106
		// (add) Token: 0x060012CB RID: 4811 RVA: 0x00036BE8 File Offset: 0x00034DE8
		// (remove) Token: 0x060012CC RID: 4812 RVA: 0x00036C24 File Offset: 0x00034E24
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060012CD RID: 4813 RVA: 0x00036C60 File Offset: 0x00034E60
		internal SessionSummary(global::Gibraltar.Monitor.AgentConfiguration configuration)
		{
			this.m_IsLive = true;
			this.m_Packet = new global::Gibraltar.Monitor.Internal.SessionSummaryPacket();
			this.m_SessionStatus = global::Loupe.Extensibility.Data.SessionStatus.Running;
			this.m_PrivacyEnabled = configuration.Publisher.EnableAnonymousMode;
			try
			{
				this.m_Packet.ID = global::System.Guid.NewGuid();
				this.m_Packet.Caption = null;
				this.m_Packet.UserName = (this.m_PrivacyEnabled ? string.Empty : global::System.Environment.UserName);
				this.m_Packet.UserDomainName = (this.m_PrivacyEnabled ? string.Empty : global::System.Environment.UserDomainName);
				this.m_Packet.TimeZoneCaption = global::System.TimeZone.CurrentTimeZone.StandardName;
				this.m_Packet.EndDateTime = this.StartDateTime;
				global::Gibraltar.Monitor.PublisherConfiguration publisher = configuration.Publisher;
				string text = null;
				string text2 = null;
				string text3 = null;
				global::System.Version version = null;
				if (publisher.ApplicationType != global::Loupe.Extensibility.Data.ApplicationType.Unknown)
				{
					this.m_AgentAppType = publisher.ApplicationType;
					if (!global::Gibraltar.Monitor.Log.IsMonoRuntime)
					{
						if (this.m_AgentAppType == (global::System.Environment.UserInteractive ? global::Loupe.Extensibility.Data.ApplicationType.Service : global::Loupe.Extensibility.Data.ApplicationType.Windows))
						{
							this.m_AgentAppType = global::Loupe.Extensibility.Data.ApplicationType.Console;
						}
					}
					else if (global::System.Environment.UserInteractive && this.m_AgentAppType == global::Loupe.Extensibility.Data.ApplicationType.Service)
					{
						this.m_AgentAppType = global::Loupe.Extensibility.Data.ApplicationType.Console;
					}
				}
				else
				{
					global::System.Reflection.Assembly entryAssembly = global::System.Reflection.Assembly.GetEntryAssembly();
					if (entryAssembly == null)
					{
						string text4 = null;
						try
						{
							global::System.Reflection.Assembly[] assemblies = global::System.AppDomain.CurrentDomain.GetAssemblies();
							global::System.Reflection.Assembly assembly = null;
							global::System.Version v = new global::System.Version(0, 0);
							foreach (global::System.Reflection.Assembly assembly2 in assemblies)
							{
								global::System.Reflection.AssemblyName name = assembly2.GetName();
								if (name.Name == "System.Web")
								{
									global::System.Version version2 = name.Version;
									if (assembly == null || version2 > v)
									{
										assembly = assembly2;
										v = version2;
									}
								}
							}
							global::System.Type type = null;
							if (assembly != null)
							{
								type = assembly.GetType("System.Web.HttpRuntime");
							}
							if (type != null)
							{
								global::System.Reflection.PropertyInfo property = type.GetProperty("AppDomainAppVirtualPath", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
								if (property != null)
								{
									text4 = (property.GetValue(null, null) as string);
								}
							}
						}
						catch
						{
						}
						if (string.IsNullOrEmpty(text4))
						{
							this.m_AgentAppType = global::Loupe.Extensibility.Data.ApplicationType.Unknown;
						}
						else
						{
							text = "ASP.NET";
							text2 = text4;
							text3 = "ASP.NET Web application";
							this.m_AgentAppType = global::Loupe.Extensibility.Data.ApplicationType.AspNet;
						}
					}
					else
					{
						int num;
						if (global::Gibraltar.Monitor.Log.IsMonoRuntime)
						{
							try
							{
								num = global::System.Diagnostics.Process.GetCurrentProcess().SessionId;
								goto IL_27C;
							}
							catch
							{
								num = 0;
								goto IL_27C;
							}
						}
						num = global::System.Diagnostics.Process.GetCurrentProcess().SessionId;
						IL_27C:
						if (!global::Gibraltar.Monitor.Log.IsMonoRuntime && num == 0 && !global::System.Environment.UserInteractive)
						{
							this.m_AgentAppType = global::Loupe.Extensibility.Data.ApplicationType.Service;
						}
						else
						{
							this.m_AgentAppType = global::Loupe.Extensibility.Data.ApplicationType.Console;
							if (global::Gibraltar.Monitor.Log.IsMonoRuntime || global::System.Environment.UserInteractive)
							{
								foreach (global::System.Reflection.AssemblyName assemblyName in entryAssembly.GetReferencedAssemblies())
								{
									if (assemblyName.Name == "System.Windows.Forms")
									{
										this.m_AgentAppType = global::Loupe.Extensibility.Data.ApplicationType.Windows;
										break;
									}
									if (assemblyName.Name == "System.Windows.Presentation")
									{
										this.m_AgentAppType = global::Loupe.Extensibility.Data.ApplicationType.Windows;
										break;
									}
								}
							}
						}
					}
				}
				this.m_Packet.ApplicationType = this.m_AgentAppType;
				if (this.m_AgentAppType != global::Loupe.Extensibility.Data.ApplicationType.AspNet)
				{
					global::Gibraltar.ContextSummary.GetApplicationNameSafe(out text, out text2, out version, out text3);
				}
				this.m_Packet.ProductName = (string.IsNullOrEmpty(publisher.ProductName) ? text : publisher.ProductName);
				this.m_Packet.ApplicationName = (string.IsNullOrEmpty(publisher.ApplicationName) ? text2 : publisher.ApplicationName);
				this.m_Packet.ApplicationVersion = (publisher.ApplicationVersion ?? version);
				this.m_Packet.ApplicationDescription = (string.IsNullOrEmpty(publisher.ApplicationDescription) ? text3 : publisher.ApplicationDescription);
				this.m_Packet.EnvironmentName = publisher.EnvironmentName;
				this.m_Packet.PromotionLevelName = publisher.PromotionLevelName;
				this.m_Packet.ProductName = (string.IsNullOrEmpty(this.m_Packet.ProductName) ? "Unknown" : this.m_Packet.ProductName);
				this.m_Packet.ApplicationName = (string.IsNullOrEmpty(this.m_Packet.ApplicationName) ? "Unknown" : this.m_Packet.ApplicationName);
				this.m_Packet.ApplicationVersion = (this.m_Packet.ApplicationVersion ?? new global::System.Version(0, 0));
				this.m_Packet.ApplicationDescription = (this.m_Packet.ApplicationDescription ?? string.Empty);
				this.m_Packet.EnvironmentName = (this.m_Packet.EnvironmentName ?? string.Empty);
				this.m_Packet.PromotionLevelName = (this.m_Packet.PromotionLevelName ?? string.Empty);
				this.m_Packet.ComputerId = global::Gibraltar.Monitor.SessionSummary.GetComputerIdSafe(this.m_Packet.ProductName, configuration);
				this.m_Packet.AgentVersion = global::Gibraltar.Monitor.SessionSummary.GetAgentVersionSafe();
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
			if (!this.m_PrivacyEnabled)
			{
				try
				{
					global::System.Net.NetworkInformation.IPGlobalProperties ipglobalProperties = global::System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties();
					this.m_Packet.HostName = ipglobalProperties.HostName;
					this.m_Packet.DnsDomainName = (ipglobalProperties.DomainName ?? string.Empty);
					goto IL_5E2;
				}
				catch
				{
					try
					{
						this.m_Packet.HostName = global::System.Environment.MachineName;
					}
					catch (global::System.Exception obj2)
					{
						global::System.GC.KeepAlive(obj2);
						this.m_Packet.HostName = "unknown";
					}
					this.m_Packet.DnsDomainName = string.Empty;
					goto IL_5E2;
				}
			}
			this.m_Packet.HostName = "anonymous";
			this.m_Packet.DnsDomainName = string.Empty;
			IL_5E2:
			try
			{
				global::Gibraltar.OSVersionInfo osversionInfo = new global::Gibraltar.OSVersionInfo();
				this.m_Packet.OSPlatformCode = osversionInfo.PlatformId;
				this.m_Packet.OSVersion = new global::System.Version(osversionInfo.MajorVersion, osversionInfo.MinorVersion, osversionInfo.BuildNumber);
				this.m_Packet.OSServicePack = osversionInfo.ServicePack;
				this.m_Packet.OSSuiteMask = osversionInfo.SuiteMask;
				this.m_Packet.OSProductType = osversionInfo.ProductType;
			}
			catch
			{
				global::System.OperatingSystem osversion = global::System.Environment.OSVersion;
				this.m_Packet.OSPlatformCode = (int)osversion.Platform;
				this.m_Packet.OSVersion = osversion.Version;
				this.m_Packet.OSServicePack = osversion.ServicePack;
			}
			try
			{
				this.m_Packet.RuntimeArchitecture = ((global::System.IntPtr.Size == 4) ? global::System.Reflection.ProcessorArchitecture.X86 : global::System.Reflection.ProcessorArchitecture.Amd64);
				this.m_Packet.OSCultureName = global::System.Globalization.CultureInfo.InstalledUICulture.ToString();
				this.m_Packet.CurrentCultureName = global::System.Globalization.CultureInfo.CurrentCulture.ToString();
				this.m_Packet.CurrentUICultureName = global::System.Globalization.CultureInfo.CurrentUICulture.ToString();
				string text5 = global::System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
				if (!string.IsNullOrEmpty(text5) && text5.Equals("x86", global::System.StringComparison.OrdinalIgnoreCase))
				{
					string environmentVariable = global::System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432");
					if (!string.IsNullOrEmpty(environmentVariable) && environmentVariable.Equals("AMD64", global::System.StringComparison.OrdinalIgnoreCase))
					{
						text5 = "AMD64";
					}
				}
				global::System.Reflection.ProcessorArchitecture osarchitecture;
				if (string.IsNullOrEmpty(text5))
				{
					osarchitecture = this.m_Packet.RuntimeArchitecture;
				}
				else if (text5.Equals("amd64", global::System.StringComparison.OrdinalIgnoreCase))
				{
					osarchitecture = global::System.Reflection.ProcessorArchitecture.Amd64;
				}
				else
				{
					osarchitecture = global::System.Reflection.ProcessorArchitecture.X86;
				}
				this.m_Packet.OSArchitecture = osarchitecture;
				this.m_Packet.OSBootMode = global::System.Windows.Forms.SystemInformation.BootMode;
				this.m_Packet.RuntimeVersion = global::System.Environment.Version;
				try
				{
					long num2;
					if (global::Gibraltar.Monitor.Log.IsMonoRuntime)
					{
						num2 = new global::System.Diagnostics.PerformanceCounter("Mono Memory", "Total Physical Memory").RawValue;
					}
					else
					{
						num2 = global::System.Convert.ToInt64(new global::Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory);
					}
					this.m_Packet.MemoryMB = global::System.Convert.ToInt32(num2 / 1048576L);
				}
				catch (global::System.Exception obj3)
				{
					global::System.GC.KeepAlive(obj3);
				}
				this.m_Packet.Processors = global::System.Environment.ProcessorCount;
				this.m_Packet.ProcessorCores = this.m_Packet.Processors;
				this.m_Packet.UserInteractive = global::System.Environment.UserInteractive;
				if (!global::Gibraltar.Monitor.Log.IsMonoRuntime || this.m_AgentAppType == global::Loupe.Extensibility.Data.ApplicationType.Windows)
				{
					this.m_Packet.TerminalServer = global::System.Windows.Forms.SystemInformation.TerminalServerSession;
					global::System.Drawing.Size size = global::System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
					this.m_Packet.ColorDepth = global::System.Windows.Forms.Screen.PrimaryScreen.BitsPerPixel;
					this.m_Packet.ScreenHeight = size.Height;
					this.m_Packet.ScreenWidth = size.Width;
				}
				this.m_Packet.CommandLine = ((this.m_PrivacyEnabled || !configuration.Listener.EnableCommandLine) ? string.Empty : global::System.Environment.CommandLine);
			}
			catch (global::System.Exception obj4)
			{
				global::System.GC.KeepAlive(obj4);
			}
			try
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair in configuration.Properties)
				{
					this.m_Packet.Properties.Add(keyValuePair.Key, keyValuePair.Value);
				}
			}
			catch (global::System.Exception obj5)
			{
				global::System.GC.KeepAlive(obj5);
			}
			this.m_Packet.Caption = this.m_Packet.ApplicationName;
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x000376EC File Offset: 0x000358EC
		internal SessionSummary(global::Gibraltar.Monitor.Internal.SessionSummaryPacket packet)
		{
			if (packet == null)
			{
				throw new global::System.ArgumentNullException("packet");
			}
			this.m_Packet = packet;
			this.m_SessionStatus = global::Loupe.Extensibility.Data.SessionStatus.Unknown;
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x00037718 File Offset: 0x00035918
		public void ApplyMappingOverrides(string productName, string applicationName, global::System.Version applicationVersion, string environmentName, string promotionLevelName)
		{
			this.m_Packet.ProductName = productName;
			this.m_Packet.ApplicationName = applicationName;
			this.m_Packet.ApplicationVersion = applicationVersion;
			this.m_Packet.EnvironmentName = environmentName;
			this.m_Packet.PromotionLevelName = promotionLevelName;
			this.m_Packet.Caption = applicationName;
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00037774 File Offset: 0x00035974
		global::Loupe.Extensibility.Data.ISession global::Loupe.Extensibility.Data.ISessionSummary.Session()
		{
			throw new global::System.NotSupportedException("Retrieving the full session from a SessionSummary is not supported");
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x00037780 File Offset: 0x00035980
		public global::System.Guid Id
		{
			get
			{
				return this.m_Packet.ID;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x00037790 File Offset: 0x00035990
		public global::System.Uri Uri
		{
			get
			{
				throw new global::System.NotSupportedException("Links are not supported in this context");
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x0003779C File Offset: 0x0003599C
		bool global::Loupe.Extensibility.Data.ISessionSummary.IsNew
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x000377A0 File Offset: 0x000359A0
		bool global::Loupe.Extensibility.Data.ISessionSummary.IsComplete
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x000377A4 File Offset: 0x000359A4
		bool global::Loupe.Extensibility.Data.ISessionSummary.IsLive
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x000377A8 File Offset: 0x000359A8
		bool global::Loupe.Extensibility.Data.ISessionSummary.HasData
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x000377AC File Offset: 0x000359AC
		public global::System.Guid? ComputerId
		{
			get
			{
				return new global::System.Guid?(this.m_Packet.ComputerId);
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x000377C0 File Offset: 0x000359C0
		public string TimeZoneCaption
		{
			get
			{
				return this.m_Packet.TimeZoneCaption;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x000377D0 File Offset: 0x000359D0
		public global::System.DateTimeOffset StartDateTime
		{
			get
			{
				return this.m_Packet.Timestamp;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x000377E0 File Offset: 0x000359E0
		public global::System.DateTimeOffset DisplayStartDateTime
		{
			get
			{
				return this.StartDateTime;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x000377E8 File Offset: 0x000359E8
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x00037810 File Offset: 0x00035A10
		public global::System.DateTimeOffset EndDateTime
		{
			get
			{
				if (this.m_IsLive)
				{
					this.m_Packet.EndDateTime = global::System.DateTimeOffset.Now;
				}
				return this.m_Packet.EndDateTime;
			}
			internal set
			{
				this.m_Packet.EndDateTime = value;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x00037820 File Offset: 0x00035A20
		public global::System.DateTimeOffset DisplayEndDateTime
		{
			get
			{
				return this.EndDateTime;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x00037828 File Offset: 0x00035A28
		public global::System.TimeSpan Duration
		{
			get
			{
				return this.EndDateTime - this.StartDateTime;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x0003783C File Offset: 0x00035A3C
		global::System.DateTimeOffset global::Loupe.Extensibility.Data.ISessionSummary.AddedDateTime
		{
			get
			{
				return this.StartDateTime;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060012E0 RID: 4832 RVA: 0x00037844 File Offset: 0x00035A44
		global::System.DateTimeOffset global::Loupe.Extensibility.Data.ISessionSummary.DisplayAddedDateTime
		{
			get
			{
				return this.StartDateTime;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x0003784C File Offset: 0x00035A4C
		global::System.DateTimeOffset global::Loupe.Extensibility.Data.ISessionSummary.UpdatedDateTime
		{
			get
			{
				return this.EndDateTime;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060012E2 RID: 4834 RVA: 0x00037854 File Offset: 0x00035A54
		global::System.DateTimeOffset global::Loupe.Extensibility.Data.ISessionSummary.DisplayUpdatedDateTime
		{
			get
			{
				return this.EndDateTime;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x0003785C File Offset: 0x00035A5C
		public string DurationShort
		{
			get
			{
				global::System.TimeSpan duration = this.Duration;
				string result;
				if (duration.Days > 0)
				{
					result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0:00}:{1:00}:{2:00}:{3:00}", new object[]
					{
						duration.Days,
						duration.Hours,
						duration.Minutes,
						duration.Seconds
					});
				}
				else
				{
					result = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0:00}:{1:00}:{2:00}", new object[]
					{
						duration.Hours,
						duration.Minutes,
						duration.Seconds
					});
				}
				return result;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x0003791C File Offset: 0x00035B1C
		// (set) Token: 0x060012E5 RID: 4837 RVA: 0x0003792C File Offset: 0x00035B2C
		public string Caption
		{
			get
			{
				return this.m_Packet.Caption;
			}
			set
			{
				if (this.m_Packet.Caption != value)
				{
					this.m_Packet.Caption = value;
					this.SendPropertyChanged("Caption");
				}
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x0003795C File Offset: 0x00035B5C
		public string Product
		{
			get
			{
				return this.m_Packet.ProductName;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x0003796C File Offset: 0x00035B6C
		public string Application
		{
			get
			{
				return this.m_Packet.ApplicationName;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x0003797C File Offset: 0x00035B7C
		public string Environment
		{
			get
			{
				return this.m_Packet.EnvironmentName;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x0003798C File Offset: 0x00035B8C
		public string PromotionLevel
		{
			get
			{
				return this.m_Packet.PromotionLevelName;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x0003799C File Offset: 0x00035B9C
		public global::Loupe.Extensibility.Data.ApplicationType ApplicationType
		{
			get
			{
				return this.m_Packet.ApplicationType;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x000379AC File Offset: 0x00035BAC
		public global::Loupe.Extensibility.Data.ApplicationType AgentAppType
		{
			get
			{
				return this.m_AgentAppType;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x000379B4 File Offset: 0x00035BB4
		public string ApplicationDescription
		{
			get
			{
				return this.m_Packet.ApplicationDescription;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x000379C4 File Offset: 0x00035BC4
		public global::System.Version ApplicationVersion
		{
			get
			{
				return this.m_Packet.ApplicationVersion;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x000379D4 File Offset: 0x00035BD4
		public global::System.Version AgentVersion
		{
			get
			{
				return this.m_Packet.AgentVersion;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x000379E4 File Offset: 0x00035BE4
		public string HostName
		{
			get
			{
				return this.m_Packet.HostName;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x000379F4 File Offset: 0x00035BF4
		public string DnsDomainName
		{
			get
			{
				return this.m_Packet.DnsDomainName;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x00037A04 File Offset: 0x00035C04
		public string FullyQualifiedUserName
		{
			get
			{
				return this.m_Packet.FullyQualifiedUserName;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x00037A14 File Offset: 0x00035C14
		public string UserName
		{
			get
			{
				return this.m_Packet.UserName;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x00037A24 File Offset: 0x00035C24
		public string UserDomainName
		{
			get
			{
				return this.m_Packet.UserDomainName;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x00037A34 File Offset: 0x00035C34
		public global::System.Version OSVersion
		{
			get
			{
				return this.m_Packet.OSVersion;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x00037A44 File Offset: 0x00035C44
		public string OSServicePack
		{
			get
			{
				return this.m_Packet.OSServicePack;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x00037A54 File Offset: 0x00035C54
		public string OSCultureName
		{
			get
			{
				return this.m_Packet.OSCultureName;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x00037A64 File Offset: 0x00035C64
		public global::System.Reflection.ProcessorArchitecture OSArchitecture
		{
			get
			{
				return this.m_Packet.OSArchitecture;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x00037A74 File Offset: 0x00035C74
		public global::System.Windows.Forms.BootMode OSBootMode
		{
			get
			{
				return this.m_Packet.OSBootMode;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x00037A84 File Offset: 0x00035C84
		public int OSPlatformCode
		{
			get
			{
				return this.m_Packet.OSPlatformCode;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x00037A94 File Offset: 0x00035C94
		public int OSProductType
		{
			get
			{
				return this.m_Packet.OSProductType;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x00037AA4 File Offset: 0x00035CA4
		public int OSSuiteMask
		{
			get
			{
				return this.m_Packet.OSSuiteMask;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x00037AB4 File Offset: 0x00035CB4
		public string OSFamilyName
		{
			get
			{
				this.EnsureOsVersionInfoLoaded();
				return this.m_OsVersionInfo.FamilyName;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x00037AC8 File Offset: 0x00035CC8
		public string OSEditionName
		{
			get
			{
				this.EnsureOsVersionInfoLoaded();
				return this.m_OsVersionInfo.EditionName;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x00037ADC File Offset: 0x00035CDC
		public string OSFullName
		{
			get
			{
				this.EnsureOsVersionInfoLoaded();
				return this.m_OsVersionInfo.FullName;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00037AF0 File Offset: 0x00035CF0
		public string OSFullNameWithServicePack
		{
			get
			{
				this.EnsureOsVersionInfoLoaded();
				return this.m_OsVersionInfo.FullNameWithServicePack;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x00037B04 File Offset: 0x00035D04
		public global::System.Version RuntimeVersion
		{
			get
			{
				return this.m_Packet.RuntimeVersion;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x00037B14 File Offset: 0x00035D14
		public global::System.Reflection.ProcessorArchitecture RuntimeArchitecture
		{
			get
			{
				return this.m_Packet.RuntimeArchitecture;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00037B24 File Offset: 0x00035D24
		public string CurrentCultureName
		{
			get
			{
				return this.m_Packet.CurrentCultureName;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x00037B34 File Offset: 0x00035D34
		public string CurrentUICultureName
		{
			get
			{
				return this.m_Packet.CurrentUICultureName;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x00037B44 File Offset: 0x00035D44
		public int MemoryMB
		{
			get
			{
				return this.m_Packet.MemoryMB;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001305 RID: 4869 RVA: 0x00037B54 File Offset: 0x00035D54
		public int Processors
		{
			get
			{
				return this.m_Packet.Processors;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x00037B64 File Offset: 0x00035D64
		public int ProcessorCores
		{
			get
			{
				return this.m_Packet.ProcessorCores;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x00037B74 File Offset: 0x00035D74
		public bool UserInteractive
		{
			get
			{
				return this.m_Packet.UserInteractive;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x00037B84 File Offset: 0x00035D84
		public bool TerminalServer
		{
			get
			{
				return this.m_Packet.TerminalServer;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x00037B94 File Offset: 0x00035D94
		public int ScreenWidth
		{
			get
			{
				return this.m_Packet.ScreenWidth;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x00037BA4 File Offset: 0x00035DA4
		public int ScreenHeight
		{
			get
			{
				return this.m_Packet.ScreenHeight;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600130B RID: 4875 RVA: 0x00037BB4 File Offset: 0x00035DB4
		public int ColorDepth
		{
			get
			{
				return this.m_Packet.ColorDepth;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x00037BC4 File Offset: 0x00035DC4
		public string CommandLine
		{
			get
			{
				return this.m_Packet.CommandLine;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x0600130D RID: 4877 RVA: 0x00037BD4 File Offset: 0x00035DD4
		// (set) Token: 0x0600130E RID: 4878 RVA: 0x00037BE0 File Offset: 0x00035DE0
		public global::Loupe.Extensibility.Data.SessionStatus Status
		{
			get
			{
				return this.m_SessionStatus;
			}
			internal set
			{
				this.m_SessionStatus = value;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x0600130F RID: 4879 RVA: 0x00037BEC File Offset: 0x00035DEC
		// (set) Token: 0x06001310 RID: 4880 RVA: 0x00037BF4 File Offset: 0x00035DF4
		public int MessageCount
		{
			get
			{
				return this.m_MessageCount;
			}
			internal set
			{
				this.m_MessageCount = value;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x00037C00 File Offset: 0x00035E00
		// (set) Token: 0x06001312 RID: 4882 RVA: 0x00037C08 File Offset: 0x00035E08
		public int CriticalCount
		{
			get
			{
				return this.m_CriticalCount;
			}
			internal set
			{
				this.m_CriticalCount = value;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001313 RID: 4883 RVA: 0x00037C14 File Offset: 0x00035E14
		// (set) Token: 0x06001314 RID: 4884 RVA: 0x00037C1C File Offset: 0x00035E1C
		public int ErrorCount
		{
			get
			{
				return this.m_ErrorCount;
			}
			internal set
			{
				this.m_ErrorCount = value;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001315 RID: 4885 RVA: 0x00037C28 File Offset: 0x00035E28
		// (set) Token: 0x06001316 RID: 4886 RVA: 0x00037C30 File Offset: 0x00035E30
		public int WarningCount
		{
			get
			{
				return this.m_WarningCount;
			}
			internal set
			{
				this.m_WarningCount = value;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x00037C3C File Offset: 0x00035E3C
		public global::System.Collections.Generic.IDictionary<string, string> Properties
		{
			get
			{
				return this.m_Packet.Properties;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x00037C4C File Offset: 0x00035E4C
		public global::Loupe.Extensibility.Data.IComputer Computer
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00037C50 File Offset: 0x00035E50
		public static string DefaultCaption(global::Gibraltar.Monitor.SessionSummary sessionSummary)
		{
			string str = string.Empty;
			if (string.IsNullOrEmpty(sessionSummary.Application))
			{
				str += "(Unknown app)";
			}
			else if (sessionSummary.Application.Length > 32)
			{
				str += sessionSummary.Application.Substring(0, 32);
			}
			else
			{
				str += sessionSummary.Application;
			}
			str = str + " " + sessionSummary.StartDateTime.DateTime.ToShortDateString();
			return str + " " + sessionSummary.StartDateTime.DateTime.ToShortTimeString();
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x00037D08 File Offset: 0x00035F08
		internal global::Gibraltar.Monitor.Internal.SessionSummaryPacket Packet
		{
			get
			{
				return this.m_Packet;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x0600131B RID: 4891 RVA: 0x00037D10 File Offset: 0x00035F10
		internal bool PrivacyEnabled
		{
			get
			{
				return this.m_PrivacyEnabled;
			}
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00037D18 File Offset: 0x00035F18
		internal void UpdateMessageStatistics(global::Gibraltar.Monitor.Internal.LogMessagePacket packet)
		{
			this.m_MessageCount++;
			switch (packet.Severity)
			{
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Critical:
				this.m_CriticalCount++;
				return;
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Error:
				this.m_ErrorCount++;
				return;
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Critical | global::Loupe.Extensibility.Data.LogMessageSeverity.Error:
				break;
			case global::Loupe.Extensibility.Data.LogMessageSeverity.Warning:
				this.m_WarningCount++;
				break;
			default:
				return;
			}
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x00037D84 File Offset: 0x00035F84
		internal void ClearMessageStatistics()
		{
			this.m_MessageCount = 0;
			this.m_CriticalCount = 0;
			this.m_ErrorCount = 0;
			this.m_WarningCount = 0;
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00037DA4 File Offset: 0x00035FA4
		private void EnsureOsVersionInfoLoaded()
		{
			if (this.m_OsVersionInfo == null)
			{
				this.m_OsVersionInfo = new global::Gibraltar.OSVersionInfo(this.OSPlatformCode, this.OSVersion, this.OSServicePack, this.OSSuiteMask, this.OSProductType);
			}
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00037DEC File Offset: 0x00035FEC
		private static global::System.Version GetAgentVersionSafe()
		{
			global::System.Version result = new global::System.Version(1, 0);
			try
			{
				global::Gibraltar.Monitor.SessionAssemblyInfo sessionAssemblyInfo = new global::Gibraltar.Monitor.SessionAssemblyInfo(global::System.Reflection.Assembly.GetExecutingAssembly(), false);
				string text = sessionAssemblyInfo.FileVersion;
				if (string.IsNullOrEmpty(text))
				{
					text = sessionAssemblyInfo.Version;
				}
				if (!string.IsNullOrEmpty(text))
				{
					result = new global::System.Version(text);
				}
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
			return result;
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x00037E58 File Offset: 0x00036058
		private static global::System.Guid GetComputerIdSafe(string product, global::Gibraltar.Monitor.AgentConfiguration configuration)
		{
			global::System.Guid guid = global::System.Guid.Empty;
			try
			{
				string text = global::System.IO.Path.Combine(global::Gibraltar.Data.PathManager.FindBestPath(global::Gibraltar.Data.PathType.Collection), "computer.gak");
				if (!global::System.IO.File.Exists(text))
				{
					string text2 = global::System.IO.Path.Combine(global::Gibraltar.Monitor.LocalRepository.CalculateRepositoryPath(product, configuration.SessionFile.Folder), "repository.gak");
					if (global::System.IO.File.Exists(text2))
					{
						try
						{
							global::System.IO.File.Copy(text2, text, false);
						}
						catch (global::System.Exception obj)
						{
							global::System.GC.KeepAlive(obj);
						}
					}
				}
				if (global::System.IO.File.Exists(text))
				{
					string g = global::System.IO.File.ReadAllText(text, global::System.Text.Encoding.UTF8);
					guid = new global::System.Guid(g);
				}
				if (guid == global::System.Guid.Empty)
				{
					guid = global::System.Guid.NewGuid();
					global::System.IO.File.WriteAllText(text, guid.ToString(), global::System.Text.Encoding.UTF8);
					global::System.IO.File.SetAttributes(text, global::System.IO.FileAttributes.Hidden);
				}
			}
			catch (global::System.Exception obj2)
			{
				global::System.GC.KeepAlive(obj2);
				guid = global::System.Guid.Empty;
			}
			return guid;
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00037F4C File Offset: 0x0003614C
		private void SendPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x04000654 RID: 1620
		private readonly bool m_IsLive;

		// Token: 0x04000655 RID: 1621
		private readonly global::Gibraltar.Monitor.Internal.SessionSummaryPacket m_Packet;

		// Token: 0x04000656 RID: 1622
		private int m_CriticalCount;

		// Token: 0x04000657 RID: 1623
		private int m_ErrorCount;

		// Token: 0x04000658 RID: 1624
		private int m_WarningCount;

		// Token: 0x04000659 RID: 1625
		private int m_MessageCount;

		// Token: 0x0400065A RID: 1626
		private volatile global::Loupe.Extensibility.Data.SessionStatus m_SessionStatus;

		// Token: 0x0400065B RID: 1627
		private global::Gibraltar.OSVersionInfo m_OsVersionInfo;

		// Token: 0x0400065C RID: 1628
		private global::Loupe.Extensibility.Data.ApplicationType m_AgentAppType;

		// Token: 0x0400065D RID: 1629
		private readonly bool m_PrivacyEnabled;
	}
}
