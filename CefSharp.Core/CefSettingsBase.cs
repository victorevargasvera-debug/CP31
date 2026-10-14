using System;
using System.Collections.Generic;
using CefSharp.Core;
using CefSharp.Internals;

namespace CefSharp
{
	// Token: 0x02000004 RID: 4
	public abstract class CefSettingsBase : global::System.IDisposable
	{
		// Token: 0x06000066 RID: 102 RVA: 0x0000267E File Offset: 0x0000087E
		public void Dispose()
		{
			this.disposed = true;
			this.settings = null;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000268E File Offset: 0x0000088E
		public bool IsDisposed
		{
			get
			{
				return this.disposed;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002696 File Offset: 0x00000896
		public global::System.Collections.Generic.IEnumerable<global::CefSharp.CefCustomScheme> CefCustomSchemes
		{
			get
			{
				return this.settings.CefCustomSchemes;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000026A3 File Offset: 0x000008A3
		public global::CefSharp.Internals.CommandLineArgDictionary CefCommandLineArgs
		{
			get
			{
				return this.settings.CefCommandLineArgs;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000026B0 File Offset: 0x000008B0
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000026BD File Offset: 0x000008BD
		public bool ChromeRuntime
		{
			get
			{
				return this.settings.ChromeRuntime;
			}
			set
			{
				this.settings.ChromeRuntime = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000026CB File Offset: 0x000008CB
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000026D8 File Offset: 0x000008D8
		public bool CommandLineArgsDisabled
		{
			get
			{
				return this.settings.CommandLineArgsDisabled;
			}
			set
			{
				this.settings.CommandLineArgsDisabled = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000026E6 File Offset: 0x000008E6
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000026F3 File Offset: 0x000008F3
		public bool ExternalMessagePump
		{
			get
			{
				return this.settings.ExternalMessagePump;
			}
			set
			{
				this.settings.ExternalMessagePump = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002701 File Offset: 0x00000901
		// (set) Token: 0x06000071 RID: 113 RVA: 0x0000270E File Offset: 0x0000090E
		public bool MultiThreadedMessageLoop
		{
			get
			{
				return this.settings.MultiThreadedMessageLoop;
			}
			set
			{
				this.settings.MultiThreadedMessageLoop = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000271C File Offset: 0x0000091C
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002729 File Offset: 0x00000929
		public string BrowserSubprocessPath
		{
			get
			{
				return this.settings.BrowserSubprocessPath;
			}
			set
			{
				this.settings.BrowserSubprocessPath = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00002737 File Offset: 0x00000937
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002744 File Offset: 0x00000944
		public string CachePath
		{
			get
			{
				return this.settings.CachePath;
			}
			set
			{
				this.settings.CachePath = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002752 File Offset: 0x00000952
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000275F File Offset: 0x0000095F
		public string RootCachePath
		{
			get
			{
				return this.settings.RootCachePath;
			}
			set
			{
				this.settings.RootCachePath = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000276D File Offset: 0x0000096D
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000277A File Offset: 0x0000097A
		public string UserDataPath
		{
			get
			{
				return this.settings.UserDataPath;
			}
			set
			{
				this.settings.UserDataPath = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00002788 File Offset: 0x00000988
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000027A0 File Offset: 0x000009A0
		public bool IgnoreCertificateErrors
		{
			get
			{
				return this.settings.CefCommandLineArgs.ContainsKey("ignore-certificate-errors");
			}
			set
			{
				if (value)
				{
					if (!this.settings.CefCommandLineArgs.ContainsKey("ignore-certificate-errors"))
					{
						this.settings.CefCommandLineArgs.Add("ignore-certificate-errors");
						return;
					}
				}
				else if (this.settings.CefCommandLineArgs.ContainsKey("ignore-certificate-errors"))
				{
					this.settings.CefCommandLineArgs.Remove("ignore-certificate-errors");
				}
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000280A File Offset: 0x00000A0A
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002817 File Offset: 0x00000A17
		public string Locale
		{
			get
			{
				return this.settings.Locale;
			}
			set
			{
				this.settings.Locale = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002825 File Offset: 0x00000A25
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002832 File Offset: 0x00000A32
		public string LocalesDirPath
		{
			get
			{
				return this.settings.LocalesDirPath;
			}
			set
			{
				this.settings.LocalesDirPath = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00002840 File Offset: 0x00000A40
		// (set) Token: 0x06000081 RID: 129 RVA: 0x0000284D File Offset: 0x00000A4D
		public string ResourcesDirPath
		{
			get
			{
				return this.settings.ResourcesDirPath;
			}
			set
			{
				this.settings.ResourcesDirPath = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000285B File Offset: 0x00000A5B
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002868 File Offset: 0x00000A68
		public string LogFile
		{
			get
			{
				return this.settings.LogFile;
			}
			set
			{
				this.settings.LogFile = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002876 File Offset: 0x00000A76
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002883 File Offset: 0x00000A83
		public global::CefSharp.LogSeverity LogSeverity
		{
			get
			{
				return this.settings.LogSeverity;
			}
			set
			{
				this.settings.LogSeverity = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002891 File Offset: 0x00000A91
		// (set) Token: 0x06000087 RID: 135 RVA: 0x0000289E File Offset: 0x00000A9E
		public string JavascriptFlags
		{
			get
			{
				return this.settings.JavascriptFlags;
			}
			set
			{
				this.settings.JavascriptFlags = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000028AC File Offset: 0x00000AAC
		// (set) Token: 0x06000089 RID: 137 RVA: 0x000028B9 File Offset: 0x00000AB9
		public bool PackLoadingDisabled
		{
			get
			{
				return this.settings.PackLoadingDisabled;
			}
			set
			{
				this.settings.PackLoadingDisabled = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000028C7 File Offset: 0x00000AC7
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000028D4 File Offset: 0x00000AD4
		public string UserAgentProduct
		{
			get
			{
				return this.settings.UserAgentProduct;
			}
			set
			{
				this.settings.UserAgentProduct = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000028E2 File Offset: 0x00000AE2
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000028EF File Offset: 0x00000AEF
		public int RemoteDebuggingPort
		{
			get
			{
				return this.settings.RemoteDebuggingPort;
			}
			set
			{
				this.settings.RemoteDebuggingPort = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000028FD File Offset: 0x00000AFD
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000290A File Offset: 0x00000B0A
		public int UncaughtExceptionStackSize
		{
			get
			{
				return this.settings.UncaughtExceptionStackSize;
			}
			set
			{
				this.settings.UncaughtExceptionStackSize = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002918 File Offset: 0x00000B18
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002925 File Offset: 0x00000B25
		public string UserAgent
		{
			get
			{
				return this.settings.UserAgent;
			}
			set
			{
				this.settings.UserAgent = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00002933 File Offset: 0x00000B33
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002940 File Offset: 0x00000B40
		public bool WindowlessRenderingEnabled
		{
			get
			{
				return this.settings.WindowlessRenderingEnabled;
			}
			set
			{
				this.settings.WindowlessRenderingEnabled = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000294E File Offset: 0x00000B4E
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000295B File Offset: 0x00000B5B
		public bool PersistSessionCookies
		{
			get
			{
				return this.settings.PersistSessionCookies;
			}
			set
			{
				this.settings.PersistSessionCookies = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00002969 File Offset: 0x00000B69
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002976 File Offset: 0x00000B76
		public bool PersistUserPreferences
		{
			get
			{
				return this.settings.PersistUserPreferences;
			}
			set
			{
				this.settings.PersistUserPreferences = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00002984 File Offset: 0x00000B84
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002991 File Offset: 0x00000B91
		public string AcceptLanguageList
		{
			get
			{
				return this.settings.AcceptLanguageList;
			}
			set
			{
				this.settings.AcceptLanguageList = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000299F File Offset: 0x00000B9F
		// (set) Token: 0x0600009B RID: 155 RVA: 0x000029AC File Offset: 0x00000BAC
		public uint BackgroundColor
		{
			get
			{
				return this.settings.BackgroundColor;
			}
			set
			{
				this.settings.BackgroundColor = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000029BA File Offset: 0x00000BBA
		// (set) Token: 0x0600009D RID: 157 RVA: 0x000029C7 File Offset: 0x00000BC7
		public string CookieableSchemesList
		{
			get
			{
				return this.settings.CookieableSchemesList;
			}
			set
			{
				this.settings.CookieableSchemesList = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000029D5 File Offset: 0x00000BD5
		// (set) Token: 0x0600009F RID: 159 RVA: 0x000029E2 File Offset: 0x00000BE2
		public bool CookieableSchemesExcludeDefaults
		{
			get
			{
				return this.settings.CookieableSchemesExcludeDefaults;
			}
			set
			{
				this.settings.CookieableSchemesExcludeDefaults = value;
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000029F0 File Offset: 0x00000BF0
		public void RegisterScheme(global::CefSharp.CefCustomScheme scheme)
		{
			this.settings.RegisterScheme(scheme);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000029FE File Offset: 0x00000BFE
		public void DisableGpuAcceleration()
		{
			if (!this.settings.CefCommandLineArgs.ContainsKey("disable-gpu"))
			{
				this.settings.CefCommandLineArgs.Add("disable-gpu");
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002A2C File Offset: 0x00000C2C
		public void EnablePrintPreview()
		{
			if (!this.settings.CefCommandLineArgs.ContainsKey("enable-print-preview"))
			{
				this.settings.CefCommandLineArgs.Add("enable-print-preview");
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002A5C File Offset: 0x00000C5C
		public void SetOffScreenRenderingBestPerformanceArgs()
		{
			if (!this.settings.CefCommandLineArgs.ContainsKey("disable-gpu"))
			{
				this.settings.CefCommandLineArgs.Add("disable-gpu");
			}
			if (!this.settings.CefCommandLineArgs.ContainsKey("disable-gpu-compositing"))
			{
				this.settings.CefCommandLineArgs.Add("disable-gpu-compositing");
			}
			if (!this.settings.CefCommandLineArgs.ContainsKey("enable-begin-frame-scheduling"))
			{
				this.settings.CefCommandLineArgs.Add("enable-begin-frame-scheduling");
			}
		}

		// Token: 0x04000003 RID: 3
		private bool disposed;

		// Token: 0x04000004 RID: 4
		internal global::CefSharp.Core.CefSettingsBase settings = new global::CefSharp.Core.CefSettingsBase();
	}
}
