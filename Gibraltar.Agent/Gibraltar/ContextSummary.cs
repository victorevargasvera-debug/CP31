using System;
using System.Net.NetworkInformation;
using System.Reflection;

namespace Gibraltar
{
	// Token: 0x020000BE RID: 190
	internal class ContextSummary
	{
		// Token: 0x060007FC RID: 2044 RVA: 0x00010A54 File Offset: 0x0000EC54
		public ContextSummary()
		{
			string text;
			global::Gibraltar.ContextSummary.GetApplicationNameSafe(out this.m_Product, out this.m_Application, out this.m_ApplicationVersion, out text);
			if (this.m_Product == "Unknown Product" || this.m_Application == "Unknown Application")
			{
				this.m_HasUnknowns = true;
			}
			this.m_UserDomainName = global::System.Environment.UserDomainName;
			this.m_UserName = global::System.Environment.UserName;
			this.m_FullyQualifiedUserName = (string.IsNullOrEmpty(this.m_UserDomainName) ? this.m_UserName : global::Gibraltar.StringReference.GetReference(this.m_UserDomainName + "\\" + this.m_UserName));
			try
			{
				global::Gibraltar.OSVersionInfo osversionInfo = new global::Gibraltar.OSVersionInfo();
				this.m_OSVersion = new global::System.Version(osversionInfo.MajorVersion, osversionInfo.MinorVersion, osversionInfo.BuildNumber);
			}
			catch
			{
				global::System.OperatingSystem osversion = global::System.Environment.OSVersion;
				this.m_OSVersion = osversion.Version;
			}
			try
			{
				global::System.Net.NetworkInformation.IPGlobalProperties ipglobalProperties = global::System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties();
				this.m_HostName = ipglobalProperties.HostName;
				this.m_DnsDomainName = (ipglobalProperties.DomainName ?? string.Empty);
			}
			catch
			{
				try
				{
					this.m_HostName = global::System.Environment.MachineName;
				}
				catch (global::System.Exception obj)
				{
					global::System.GC.KeepAlive(obj);
					this.m_HostName = "unknown";
				}
				this.m_DnsDomainName = string.Empty;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x00010BD4 File Offset: 0x0000EDD4
		public bool HasUnknowns
		{
			get
			{
				return this.m_HasUnknowns;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00010BDC File Offset: 0x0000EDDC
		public string Product
		{
			get
			{
				return this.m_Product;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x00010BE4 File Offset: 0x0000EDE4
		public string Application
		{
			get
			{
				return this.m_Application;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00010BEC File Offset: 0x0000EDEC
		public global::System.Version ApplicationVersion
		{
			get
			{
				return this.m_ApplicationVersion;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x00010BF4 File Offset: 0x0000EDF4
		public global::System.Version OSVersion
		{
			get
			{
				return this.m_OSVersion;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00010BFC File Offset: 0x0000EDFC
		public string HostName
		{
			get
			{
				return this.m_HostName;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00010C04 File Offset: 0x0000EE04
		public string DnsDomainName
		{
			get
			{
				return this.m_DnsDomainName;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00010C0C File Offset: 0x0000EE0C
		public string UserDomainName
		{
			get
			{
				return this.m_UserDomainName;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00010C14 File Offset: 0x0000EE14
		public string UserName
		{
			get
			{
				return this.m_UserName;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00010C1C File Offset: 0x0000EE1C
		public string FullyQualifiedUserName
		{
			get
			{
				return this.m_FullyQualifiedUserName;
			}
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00010C24 File Offset: 0x0000EE24
		public static void GetApplicationNameSafe(out string productName, out string applicationName, out global::System.Version applicationVersion, out string applicationDescription)
		{
			productName = "Unknown Product";
			applicationName = "Unknown Application";
			applicationVersion = new global::System.Version(0, 0);
			applicationDescription = string.Empty;
			try
			{
				global::System.Reflection.Assembly entryAssembly = global::System.Reflection.Assembly.GetEntryAssembly();
				if (entryAssembly != null)
				{
					applicationVersion = entryAssembly.GetName().Version;
					global::System.Reflection.AssemblyFileVersionAttribute[] array = entryAssembly.GetCustomAttributes(typeof(global::System.Reflection.AssemblyFileVersionAttribute), true) as global::System.Reflection.AssemblyFileVersionAttribute[];
					global::System.Reflection.AssemblyProductAttribute[] array2 = entryAssembly.GetCustomAttributes(typeof(global::System.Reflection.AssemblyProductAttribute), true) as global::System.Reflection.AssemblyProductAttribute[];
					global::System.Reflection.AssemblyTitleAttribute[] array3 = entryAssembly.GetCustomAttributes(typeof(global::System.Reflection.AssemblyTitleAttribute), true) as global::System.Reflection.AssemblyTitleAttribute[];
					global::System.Reflection.AssemblyDescriptionAttribute[] array4 = entryAssembly.GetCustomAttributes(typeof(global::System.Reflection.AssemblyDescriptionAttribute), true) as global::System.Reflection.AssemblyDescriptionAttribute[];
					if (array != null && array.Length != 0)
					{
						string version = array[0].Version;
						try
						{
							applicationVersion = new global::System.Version(version);
						}
						catch
						{
						}
					}
					if (array2 != null && array2.Length != 0)
					{
						productName = (array2[0].Product ?? string.Empty);
					}
					if (array3 != null && array3.Length != 0)
					{
						applicationName = (array3[0].Title ?? string.Empty);
					}
					if (array4 != null && array4.Length != 0)
					{
						applicationDescription = (array4[0].Description ?? string.Empty);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x040001A2 RID: 418
		public const string UnknownProduct = "Unknown Product";

		// Token: 0x040001A3 RID: 419
		public const string UnknownApplication = "Unknown Application";

		// Token: 0x040001A4 RID: 420
		private readonly bool m_HasUnknowns;

		// Token: 0x040001A5 RID: 421
		private readonly string m_Product;

		// Token: 0x040001A6 RID: 422
		private readonly string m_Application;

		// Token: 0x040001A7 RID: 423
		private readonly global::System.Version m_ApplicationVersion;

		// Token: 0x040001A8 RID: 424
		private readonly global::System.Version m_OSVersion;

		// Token: 0x040001A9 RID: 425
		private readonly string m_HostName;

		// Token: 0x040001AA RID: 426
		private readonly string m_DnsDomainName;

		// Token: 0x040001AB RID: 427
		private readonly string m_UserDomainName;

		// Token: 0x040001AC RID: 428
		private readonly string m_UserName;

		// Token: 0x040001AD RID: 429
		private readonly string m_FullyQualifiedUserName;
	}
}
