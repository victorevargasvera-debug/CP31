using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Gibraltar
{
	// Token: 0x020000B6 RID: 182
	internal class OSVersionInfo
	{
		// Token: 0x060007A3 RID: 1955 RVA: 0x0000E7C4 File Offset: 0x0000C9C4
		public OSVersionInfo()
		{
			global::Gibraltar.OSVersionInfo.OSVERSIONINFO osversioninfo = new global::Gibraltar.OSVersionInfo.OSVERSIONINFO();
			global::System.OperatingSystem osversion = global::System.Environment.OSVersion;
			global::System.PlatformID platform = osversion.Platform;
			if (platform >= global::System.PlatformID.Unix)
			{
				osversioninfo.PlatformId = (int)platform;
				osversioninfo.MajorVersion = osversion.Version.Major;
				osversioninfo.MinorVersion = osversion.Version.Minor;
				osversioninfo.BuildNumber = osversion.Version.Build;
				osversioninfo.CSDVersion = osversion.ServicePack;
			}
			else
			{
				if (!global::Gibraltar.OSVersionInfo.UseOSVersionInfoEx(osversioninfo))
				{
					this.LoadOsVersionInfo(osversioninfo);
				}
				else
				{
					this.LoadOsVersionInfoEx();
				}
				if (this.MajorVersion >= 6)
				{
					this.LoadProductInfo();
				}
			}
			this.CalculateNames();
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0000E878 File Offset: 0x0000CA78
		public OSVersionInfo(int platformId, global::System.Version osVersion, string servicePack, int suiteMask, int productType)
		{
			this.PlatformId = platformId;
			this.MajorVersion = osVersion.Major;
			this.MinorVersion = osVersion.Minor;
			this.BuildNumber = osVersion.Build;
			this.ServicePack = servicePack;
			this.SuiteMask = suiteMask;
			this.ProductType = productType;
			this.CalculateNames();
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060007A5 RID: 1957 RVA: 0x0000E8D8 File Offset: 0x0000CAD8
		// (set) Token: 0x060007A6 RID: 1958 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		public int PlatformId { get; private set; }

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060007A7 RID: 1959 RVA: 0x0000E8EC File Offset: 0x0000CAEC
		// (set) Token: 0x060007A8 RID: 1960 RVA: 0x0000E8F4 File Offset: 0x0000CAF4
		public int MajorVersion { get; private set; }

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060007A9 RID: 1961 RVA: 0x0000E900 File Offset: 0x0000CB00
		// (set) Token: 0x060007AA RID: 1962 RVA: 0x0000E908 File Offset: 0x0000CB08
		public int MinorVersion { get; private set; }

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060007AB RID: 1963 RVA: 0x0000E914 File Offset: 0x0000CB14
		// (set) Token: 0x060007AC RID: 1964 RVA: 0x0000E91C File Offset: 0x0000CB1C
		public int BuildNumber { get; private set; }

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060007AD RID: 1965 RVA: 0x0000E928 File Offset: 0x0000CB28
		// (set) Token: 0x060007AE RID: 1966 RVA: 0x0000E930 File Offset: 0x0000CB30
		public int SpMajorVersion { get; private set; }

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060007AF RID: 1967 RVA: 0x0000E93C File Offset: 0x0000CB3C
		// (set) Token: 0x060007B0 RID: 1968 RVA: 0x0000E944 File Offset: 0x0000CB44
		public int SpMinorVersion { get; private set; }

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x0000E950 File Offset: 0x0000CB50
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x0000E958 File Offset: 0x0000CB58
		public int SuiteMask { get; private set; }

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x0000E964 File Offset: 0x0000CB64
		// (set) Token: 0x060007B4 RID: 1972 RVA: 0x0000E96C File Offset: 0x0000CB6C
		public string ServicePack { get; private set; }

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x0000E978 File Offset: 0x0000CB78
		// (set) Token: 0x060007B6 RID: 1974 RVA: 0x0000E980 File Offset: 0x0000CB80
		public int ProductType { get; private set; }

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x0000E98C File Offset: 0x0000CB8C
		public string FamilyName
		{
			get
			{
				if (!this.m_NamesCalculated)
				{
					this.CalculateNames();
				}
				return this.m_OSFamilyName;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x0000E9A8 File Offset: 0x0000CBA8
		public string EditionName
		{
			get
			{
				if (!this.m_NamesCalculated)
				{
					this.CalculateNames();
				}
				return this.m_OSEditionName;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x0000E9C4 File Offset: 0x0000CBC4
		public string FullName
		{
			get
			{
				if (!this.m_NamesCalculated)
				{
					this.CalculateNames();
				}
				return this.m_OSFamilyName + (string.IsNullOrEmpty(this.m_OSEditionName) ? string.Empty : (" " + this.m_OSEditionName));
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x0000EA1C File Offset: 0x0000CC1C
		public string FullNameWithServicePack
		{
			get
			{
				return this.FullName + (string.IsNullOrEmpty(this.ServicePack) ? string.Empty : (" " + this.ServicePack));
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x0000EA64 File Offset: 0x0000CC64
		public global::System.Version Version
		{
			get
			{
				if (this.m_Version == null)
				{
					this.m_Version = new global::System.Version(this.MajorVersion, this.MinorVersion, this.BuildNumber);
				}
				return this.m_Version;
			}
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0000EAAC File Offset: 0x0000CCAC
		private static bool UseOSVersionInfoEx(global::Gibraltar.OSVersionInfo.OSVERSIONINFO info)
		{
			if (!global::Gibraltar.OSVersionInfo.NativeMethods.GetVersionEx(info))
			{
				throw new global::System.InvalidOperationException("Failed to get OSVersionInfo. Error = 0x" + global::System.Runtime.InteropServices.Marshal.GetLastWin32Error().ToString("8X", global::System.Globalization.CultureInfo.CurrentCulture));
			}
			return info.PlatformId >= 4 || (info.MajorVersion >= 4 && (info.MajorVersion > 4 || (info.MinorVersion >= 0 && (info.MinorVersion > 0 || info.CSDVersion == "Service Pack 6"))));
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0000EB50 File Offset: 0x0000CD50
		private void LoadOsVersionInfo(global::Gibraltar.OSVersionInfo.OSVERSIONINFO info)
		{
			this.PlatformId = info.PlatformId;
			this.MajorVersion = info.MajorVersion;
			this.MinorVersion = info.MinorVersion;
			this.BuildNumber = info.BuildNumber;
			this.ServicePack = info.CSDVersion;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0000EBA0 File Offset: 0x0000CDA0
		private void LoadOsVersionInfoEx()
		{
			global::Gibraltar.OSVersionInfo.OSVERSIONINFOEX osversioninfoex = new global::Gibraltar.OSVersionInfo.OSVERSIONINFOEX();
			if (!global::Gibraltar.OSVersionInfo.NativeMethods.GetVersionEx(osversioninfoex))
			{
				throw new global::System.InvalidOperationException("Failed to get OSVersionInfoEx. Error = 0x" + global::System.Runtime.InteropServices.Marshal.GetLastWin32Error().ToString("8X", global::System.Globalization.CultureInfo.CurrentCulture));
			}
			this.PlatformId = osversioninfoex.PlatformId;
			this.MajorVersion = osversioninfoex.MajorVersion;
			this.MinorVersion = osversioninfoex.MinorVersion;
			this.BuildNumber = osversioninfoex.BuildNumber;
			this.ServicePack = osversioninfoex.CSDVersion;
			this.SpMajorVersion = (int)osversioninfoex.ServicePackMajor;
			this.SpMinorVersion = (int)osversioninfoex.ServicePackMinor;
			this.SuiteMask = (int)osversioninfoex.SuiteMask;
			this.ProductType = (int)osversioninfoex.ProductType;
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0000EC58 File Offset: 0x0000CE58
		private void LoadProductInfo()
		{
			int productType;
			if (!global::Gibraltar.OSVersionInfo.NativeMethods.GetProductInfo(this.MajorVersion, this.MinorVersion, this.SpMajorVersion, this.SpMinorVersion, out productType))
			{
				throw new global::System.InvalidOperationException("Failed to get OSVersionInfoEx. Error = 0x" + global::System.Runtime.InteropServices.Marshal.GetLastWin32Error().ToString("8X", global::System.Globalization.CultureInfo.CurrentCulture));
			}
			this.ProductType = productType;
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0000ECBC File Offset: 0x0000CEBC
		private void CalculateNames()
		{
			this.m_NamesCalculated = true;
			string text = null;
			int num = this.PlatformId;
			switch (num)
			{
			case 0:
				text = "Win32s";
				goto IL_18E;
			case 1:
				num = this.MinorVersion;
				if (num == 0)
				{
					text = "Windows 95";
					goto IL_18E;
				}
				if (num == 10)
				{
					text = "Windows 98";
					goto IL_18E;
				}
				if (num != 90)
				{
					goto IL_18E;
				}
				text = "Windows ME";
				goto IL_18E;
			case 2:
				switch (this.MajorVersion)
				{
				case 3:
					text = "Windows NT 3.51";
					goto IL_18E;
				case 4:
					text = "Windows NT 4.0";
					goto IL_18E;
				case 5:
					switch (this.MinorVersion)
					{
					case 0:
						text = "Windows 2000";
						goto IL_18E;
					case 1:
						text = "Windows XP";
						goto IL_18E;
					case 2:
						text = "Windows 2003";
						goto IL_18E;
					default:
						goto IL_18E;
					}
					break;
				case 6:
					switch (this.MinorVersion)
					{
					case 0:
						text = "Windows Vista";
						goto IL_18E;
					case 1:
						text = "Windows 7";
						goto IL_18E;
					case 2:
						text = "Windows 8";
						goto IL_18E;
					case 3:
						text = "Windows 8.1";
						goto IL_18E;
					default:
						goto IL_18E;
					}
					break;
				case 7:
				case 8:
				case 9:
					goto IL_18E;
				case 10:
					text = "Windows 10";
					goto IL_18E;
				default:
					goto IL_18E;
				}
				break;
			case 3:
				text = "Windows CE";
				goto IL_18E;
			case 4:
				break;
			case 5:
				goto IL_18E;
			case 6:
				text = "MacOS X";
				goto IL_18E;
			default:
				if (num != 128)
				{
					goto IL_18E;
				}
				break;
			}
			text = "Unix";
			IL_18E:
			if (string.IsNullOrEmpty(text))
			{
				text = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1}.{2}", new object[]
				{
					this.MajorVersion,
					this.MinorVersion,
					this.BuildNumber
				});
			}
			string oseditionName = string.Empty;
			if (this.PlatformId < 4)
			{
				if (this.MajorVersion < 6)
				{
					if (this.ProductType == 3 || this.ProductType == 2)
					{
						if (global::Gibraltar.OSVersionInfo.TestFlag(this.SuiteMask, 1U) || global::Gibraltar.OSVersionInfo.TestFlag(this.SuiteMask, 32U))
						{
							oseditionName = "Small Business Server";
						}
						else if (global::Gibraltar.OSVersionInfo.TestFlag(this.SuiteMask, 128U))
						{
							oseditionName = "Datacenter Server";
						}
						else if (global::Gibraltar.OSVersionInfo.TestFlag(this.SuiteMask, 2U))
						{
							if (this.MinorVersion == 0)
							{
								oseditionName = "Advanced Server";
							}
							else
							{
								oseditionName = "Enterprise Server";
							}
						}
						else if (global::Gibraltar.OSVersionInfo.TestFlag(this.SuiteMask, 1024U))
						{
							oseditionName = "Web Server";
						}
						else if (global::Gibraltar.OSVersionInfo.TestFlag(this.SuiteMask, 64U) || global::Gibraltar.OSVersionInfo.TestFlag(this.SuiteMask, 2048U))
						{
							oseditionName = "Embedded";
						}
						else if (global::Gibraltar.OSVersionInfo.TestFlag(this.SuiteMask, 32768U))
						{
							oseditionName = "Home Server";
						}
						else
						{
							oseditionName = "Standard Server";
						}
					}
					else if (this.ProductType == 1)
					{
						if (global::Gibraltar.OSVersionInfo.TestFlag(this.SuiteMask, 512U))
						{
							oseditionName = "Home";
						}
						else
						{
							oseditionName = "Professional";
						}
					}
				}
				else
				{
					bool flag = false;
					uint productType = (uint)this.ProductType;
					switch (productType)
					{
					case 0U:
						oseditionName = "Unknown";
						break;
					case 1U:
						oseditionName = "Ultimate Edition";
						break;
					case 2U:
						oseditionName = "Home Basic";
						break;
					case 3U:
						oseditionName = "Home Premium";
						break;
					case 4U:
					case 72U:
						flag = false;
						oseditionName = "Enterprise";
						break;
					case 5U:
						oseditionName = "Home Basic N";
						break;
					case 6U:
						oseditionName = "Business";
						break;
					case 7U:
					case 36U:
					case 79U:
						flag = true;
						oseditionName = "Standard Server";
						break;
					case 8U:
					case 37U:
					case 80U:
						flag = true;
						oseditionName = "Datacenter Server";
						break;
					case 9U:
						flag = true;
						oseditionName = "Small Business Server";
						break;
					case 10U:
					case 15U:
					case 38U:
						flag = true;
						oseditionName = "Enterprise Server";
						break;
					case 11U:
						oseditionName = "Starter";
						break;
					case 12U:
					case 39U:
						flag = true;
						oseditionName = "Datacenter Server Core";
						break;
					case 13U:
					case 40U:
						flag = true;
						oseditionName = "Standard Server Core";
						break;
					case 14U:
					case 41U:
						flag = true;
						oseditionName = "Enterprise Server Core";
						break;
					case 16U:
						oseditionName = "Business N";
						break;
					case 17U:
						flag = true;
						oseditionName = "Web Server";
						break;
					case 18U:
					case 64U:
						flag = true;
						oseditionName = "Cluster Server";
						break;
					case 19U:
						flag = true;
						oseditionName = "Home Server";
						break;
					case 20U:
						flag = true;
						oseditionName = "Storage Server Express";
						break;
					case 21U:
					case 96U:
						flag = true;
						oseditionName = "Storage Server Standard";
						break;
					case 22U:
					case 95U:
						flag = true;
						oseditionName = "Storage Server Workgroup";
						break;
					case 23U:
						flag = true;
						oseditionName = "Storage Server Enterprise";
						break;
					case 24U:
					case 35U:
						flag = true;
						oseditionName = "Windows Essential Server Solutions";
						break;
					case 25U:
						flag = true;
						oseditionName = "Small Business Server Premium";
						break;
					case 26U:
						oseditionName = "Home Premium N";
						break;
					case 27U:
					case 84U:
						flag = false;
						oseditionName = "Enterprise N";
						break;
					case 28U:
						oseditionName = "Ultimate N Edition";
						break;
					case 29U:
						flag = true;
						oseditionName = "Web Server Core";
						break;
					case 30U:
						flag = true;
						oseditionName = "Essential Business Server Management Server";
						break;
					case 31U:
						flag = true;
						oseditionName = "Essential Business Server Security Server";
						break;
					case 32U:
						flag = true;
						oseditionName = "Essential Business Server Messaging Server";
						break;
					case 33U:
						flag = true;
						oseditionName = "Server Foundation";
						break;
					case 34U:
						flag = true;
						oseditionName = "Home Server 2011";
						break;
					case 42U:
						flag = true;
						oseditionName = "Hyper-V Server";
						break;
					case 43U:
						flag = true;
						oseditionName = "Storage Server Express Core";
						break;
					case 44U:
						flag = true;
						oseditionName = "Storage Server Standard Core";
						break;
					case 45U:
						flag = true;
						oseditionName = "Storage Server Workgroup Core";
						break;
					case 46U:
						flag = true;
						oseditionName = "Storage Server Enterprise Core";
						break;
					case 47U:
						oseditionName = "Starter N";
						break;
					case 48U:
						oseditionName = "Professional";
						break;
					case 49U:
						oseditionName = "Professional N";
						break;
					case 50U:
						flag = true;
						oseditionName = "Small Business Server 2011 Essentials";
						break;
					case 51U:
						oseditionName = "Server For SB Solutions";
						break;
					case 52U:
						flag = true;
						oseditionName = "Server Solutions Premium";
						break;
					case 53U:
						flag = true;
						oseditionName = "Server Solutions Premium Core";
						break;
					case 54U:
					case 55U:
						oseditionName = "Server For SB Solutions EM";
						break;
					case 56U:
						flag = true;
						oseditionName = "Multipoint Server";
						break;
					case 57U:
					case 58U:
					case 65U:
					case 73U:
					case 74U:
					case 75U:
					case 78U:
					case 81U:
					case 82U:
					case 83U:
					case 85U:
					case 86U:
					case 87U:
					case 88U:
					case 89U:
					case 90U:
					case 91U:
					case 92U:
					case 93U:
					case 94U:
					case 97U:
					case 102U:
						break;
					case 59U:
					case 61U:
						flag = true;
						oseditionName = "Essential Server Solution Management";
						break;
					case 60U:
					case 62U:
						flag = true;
						oseditionName = "Essential Server Solution Additional";
						break;
					case 63U:
						flag = true;
						oseditionName = "Small Business Server Premium Core";
						break;
					case 66U:
						oseditionName = "Starter E";
						break;
					case 67U:
						oseditionName = "Home Basic E";
						break;
					case 68U:
						oseditionName = "Home Premium E";
						break;
					case 69U:
						oseditionName = "Professional E";
						break;
					case 70U:
						flag = false;
						oseditionName = "Enterprise E";
						break;
					case 71U:
						oseditionName = "Ultimate E Edition";
						break;
					case 76U:
						flag = true;
						oseditionName = "MultiPoint Server Standard";
						break;
					case 77U:
						flag = true;
						oseditionName = "MultiPoint Server Premium ";
						break;
					case 98U:
						oseditionName = "N";
						break;
					case 99U:
						oseditionName = "China";
						break;
					case 100U:
						oseditionName = "Single Language";
						break;
					case 101U:
						oseditionName = string.Empty;
						break;
					case 103U:
						oseditionName = "Professional with Media Center";
						break;
					default:
						if (productType == 2882382797U)
						{
							oseditionName = "Unlicensed";
						}
						break;
					}
					if (flag)
					{
						if (this.MajorVersion == 6)
						{
							switch (this.MinorVersion)
							{
							case 0:
								text = "Windows 2008";
								break;
							case 1:
								text = "Windows 2008 R2";
								break;
							case 2:
								text = "Windows 2012";
								break;
							case 3:
								text = "Windows 2012 R2";
								break;
							default:
								text = "Windows Server";
								break;
							}
						}
						else if (this.MajorVersion == 10)
						{
							text = "Windows 2016";
						}
					}
				}
			}
			this.m_OSFamilyName = text;
			this.m_OSEditionName = oseditionName;
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0000F574 File Offset: 0x0000D774
		private static bool TestFlag(int mask, uint testFlag)
		{
			return ((long)mask & (long)((ulong)testFlag)) != 0L;
		}

		// Token: 0x04000179 RID: 377
		private bool m_NamesCalculated;

		// Token: 0x0400017A RID: 378
		private string m_OSFamilyName;

		// Token: 0x0400017B RID: 379
		private string m_OSEditionName;

		// Token: 0x0400017C RID: 380
		private global::System.Version m_Version;

		// Token: 0x02000489 RID: 1161
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private class OSVERSIONINFO
		{
			// Token: 0x060032EF RID: 13039 RVA: 0x000B95C4 File Offset: 0x000B77C4
			public OSVERSIONINFO()
			{
				this.OSVersionInfoSize = global::System.Runtime.InteropServices.Marshal.SizeOf(this);
			}

			// Token: 0x060032F0 RID: 13040 RVA: 0x000B95D8 File Offset: 0x000B77D8
			private void StopTheCompilerComplaining()
			{
				this.MajorVersion = 0;
				this.MinorVersion = 0;
				this.BuildNumber = 0;
				this.PlatformId = 0;
				this.CSDVersion = string.Empty;
			}

			// Token: 0x040012E6 RID: 4838
			public int OSVersionInfoSize;

			// Token: 0x040012E7 RID: 4839
			public int MajorVersion;

			// Token: 0x040012E8 RID: 4840
			public int MinorVersion;

			// Token: 0x040012E9 RID: 4841
			public int BuildNumber;

			// Token: 0x040012EA RID: 4842
			public int PlatformId;

			// Token: 0x040012EB RID: 4843
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 128)]
			public string CSDVersion;
		}

		// Token: 0x0200048A RID: 1162
		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Sequential, CharSet = global::System.Runtime.InteropServices.CharSet.Auto)]
		private class OSVERSIONINFOEX
		{
			// Token: 0x060032F1 RID: 13041 RVA: 0x000B9604 File Offset: 0x000B7804
			public OSVERSIONINFOEX()
			{
				this.OSVersionInfoSize = global::System.Runtime.InteropServices.Marshal.SizeOf(this);
			}

			// Token: 0x060032F2 RID: 13042 RVA: 0x000B9618 File Offset: 0x000B7818
			private void StopTheCompilerComplaining()
			{
				this.MajorVersion = 0;
				this.MinorVersion = 0;
				this.BuildNumber = 0;
				this.PlatformId = 0;
				this.CSDVersion = string.Empty;
				this.ServicePackMajor = 0;
				this.ServicePackMinor = 0;
				this.SuiteMask = 0;
				this.ProductType = 0;
				this.Reserved = 0;
			}

			// Token: 0x040012EC RID: 4844
			public int OSVersionInfoSize;

			// Token: 0x040012ED RID: 4845
			public int MajorVersion;

			// Token: 0x040012EE RID: 4846
			public int MinorVersion;

			// Token: 0x040012EF RID: 4847
			public int BuildNumber;

			// Token: 0x040012F0 RID: 4848
			public int PlatformId;

			// Token: 0x040012F1 RID: 4849
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 128)]
			public string CSDVersion;

			// Token: 0x040012F2 RID: 4850
			public short ServicePackMajor;

			// Token: 0x040012F3 RID: 4851
			public short ServicePackMinor;

			// Token: 0x040012F4 RID: 4852
			public ushort SuiteMask;

			// Token: 0x040012F5 RID: 4853
			public byte ProductType;

			// Token: 0x040012F6 RID: 4854
			public byte Reserved;
		}

		// Token: 0x0200048B RID: 1163
		private class NativeMethods
		{
			// Token: 0x060032F3 RID: 13043 RVA: 0x000B9674 File Offset: 0x000B7874
			private NativeMethods()
			{
			}

			// Token: 0x060032F4 RID: 13044
			[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
			public static extern bool GetVersionEx([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] global::Gibraltar.OSVersionInfo.OSVERSIONINFO osVersionInfo);

			// Token: 0x060032F5 RID: 13045
			[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
			public static extern bool GetVersionEx([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] global::Gibraltar.OSVersionInfo.OSVERSIONINFOEX osVersionInfoEx);

			// Token: 0x060032F6 RID: 13046
			[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
			public static extern bool GetProductInfo([global::System.Runtime.InteropServices.In] int OsMajorVersion, [global::System.Runtime.InteropServices.In] int OsMinorVersion, [global::System.Runtime.InteropServices.In] int SpMajorVersion, [global::System.Runtime.InteropServices.In] int SpMinorVersion, out int ProductType);
		}

		// Token: 0x0200048C RID: 1164
		private class VerPlatformId
		{
			// Token: 0x060032F7 RID: 13047 RVA: 0x000B967C File Offset: 0x000B787C
			private VerPlatformId()
			{
			}

			// Token: 0x040012F7 RID: 4855
			public const int Win32s = 0;

			// Token: 0x040012F8 RID: 4856
			public const int Win32Windows = 1;

			// Token: 0x040012F9 RID: 4857
			public const int Win32NT = 2;

			// Token: 0x040012FA RID: 4858
			public const int WinCE = 3;

			// Token: 0x040012FB RID: 4859
			public const int Unix = 4;

			// Token: 0x040012FC RID: 4860
			public const int MaxOSX = 6;

			// Token: 0x040012FD RID: 4861
			public const int UnixMono1 = 128;
		}

		// Token: 0x0200048D RID: 1165
		private class VerSuiteMask
		{
			// Token: 0x060032F8 RID: 13048 RVA: 0x000B9684 File Offset: 0x000B7884
			private VerSuiteMask()
			{
			}

			// Token: 0x040012FE RID: 4862
			public const uint VER_SERVER_NT = 2147483648U;

			// Token: 0x040012FF RID: 4863
			public const uint VER_WORKSTATION_NT = 1073741824U;

			// Token: 0x04001300 RID: 4864
			public const ushort VER_SUITE_SMALLBUSINESS = 1;

			// Token: 0x04001301 RID: 4865
			public const ushort VER_SUITE_ENTERPRISE = 2;

			// Token: 0x04001302 RID: 4866
			public const ushort VER_SUITE_BACKOFFICE = 4;

			// Token: 0x04001303 RID: 4867
			public const ushort VER_SUITE_COMMUNICATIONS = 8;

			// Token: 0x04001304 RID: 4868
			public const ushort VER_SUITE_TERMINAL = 16;

			// Token: 0x04001305 RID: 4869
			public const ushort VER_SUITE_SMALLBUSINESS_RESTRICTED = 32;

			// Token: 0x04001306 RID: 4870
			public const ushort VER_SUITE_EMBEDDEDNT = 64;

			// Token: 0x04001307 RID: 4871
			public const ushort VER_SUITE_DATACENTER = 128;

			// Token: 0x04001308 RID: 4872
			public const ushort VER_SUITE_SINGLEUSERTS = 256;

			// Token: 0x04001309 RID: 4873
			public const ushort VER_SUITE_PERSONAL = 512;

			// Token: 0x0400130A RID: 4874
			public const ushort VER_SUITE_BLADE = 1024;

			// Token: 0x0400130B RID: 4875
			public const ushort VER_SUITE_EMBEDDED_RESTRICTED = 2048;

			// Token: 0x0400130C RID: 4876
			public const ushort VER_SUITE_WH_SERVER = 32768;
		}

		// Token: 0x0200048E RID: 1166
		private class VerProductType
		{
			// Token: 0x060032F9 RID: 13049 RVA: 0x000B968C File Offset: 0x000B788C
			private VerProductType()
			{
			}

			// Token: 0x0400130D RID: 4877
			public const byte VER_NT_WORKSTATION = 1;

			// Token: 0x0400130E RID: 4878
			public const byte VER_NT_DOMAIN_CONTROLLER = 2;

			// Token: 0x0400130F RID: 4879
			public const byte VER_NT_SERVER = 3;
		}

		// Token: 0x0200048F RID: 1167
		private class VerProductInfo
		{
			// Token: 0x04001310 RID: 4880
			public const uint PRODUCT_BUSINESS = 6U;

			// Token: 0x04001311 RID: 4881
			public const uint PRODUCT_BUSINESS_N = 16U;

			// Token: 0x04001312 RID: 4882
			public const uint PRODUCT_CLUSTER_SERVER = 18U;

			// Token: 0x04001313 RID: 4883
			public const uint PRODUCT_CLUSTER_SERVER_V = 64U;

			// Token: 0x04001314 RID: 4884
			public const uint PRODUCT_CORE = 101U;

			// Token: 0x04001315 RID: 4885
			public const uint PRODUCT_CORE_N = 98U;

			// Token: 0x04001316 RID: 4886
			public const uint PRODUCT_CORE_COUNTRYSPECIFIC = 99U;

			// Token: 0x04001317 RID: 4887
			public const uint PRODUCT_CORE_SINGLELANGUAGE = 100U;

			// Token: 0x04001318 RID: 4888
			public const uint PRODUCT_DATACENTER_EVALUATION_SERVER = 80U;

			// Token: 0x04001319 RID: 4889
			public const uint PRODUCT_DATACENTER_SERVER = 8U;

			// Token: 0x0400131A RID: 4890
			public const uint PRODUCT_DATACENTER_SERVER_CORE = 12U;

			// Token: 0x0400131B RID: 4891
			public const uint PRODUCT_DATACENTER_SERVER_CORE_V = 39U;

			// Token: 0x0400131C RID: 4892
			public const uint PRODUCT_DATACENTER_SERVER_V = 37U;

			// Token: 0x0400131D RID: 4893
			public const uint PRODUCT_ENTERPRISE = 4U;

			// Token: 0x0400131E RID: 4894
			public const uint PRODUCT_ENTERPRISE_E = 70U;

			// Token: 0x0400131F RID: 4895
			public const uint PRODUCT_ENTERPRISE_N_EVALUATION = 84U;

			// Token: 0x04001320 RID: 4896
			public const uint PRODUCT_ENTERPRISE_N = 27U;

			// Token: 0x04001321 RID: 4897
			public const uint PRODUCT_ENTERPRISE_EVALUATION = 72U;

			// Token: 0x04001322 RID: 4898
			public const uint PRODUCT_ENTERPRISE_SERVER = 10U;

			// Token: 0x04001323 RID: 4899
			public const uint PRODUCT_ENTERPRISE_SERVER_CORE = 14U;

			// Token: 0x04001324 RID: 4900
			public const uint PRODUCT_ENTERPRISE_SERVER_CORE_V = 41U;

			// Token: 0x04001325 RID: 4901
			public const uint PRODUCT_ENTERPRISE_SERVER_IA64 = 15U;

			// Token: 0x04001326 RID: 4902
			public const uint PRODUCT_ENTERPRISE_SERVER_V = 38U;

			// Token: 0x04001327 RID: 4903
			public const uint PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT = 59U;

			// Token: 0x04001328 RID: 4904
			public const uint PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL = 60U;

			// Token: 0x04001329 RID: 4905
			public const uint PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC = 61U;

			// Token: 0x0400132A RID: 4906
			public const uint PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC = 62U;

			// Token: 0x0400132B RID: 4907
			public const uint PRODUCT_HOME_BASIC = 2U;

			// Token: 0x0400132C RID: 4908
			public const uint PRODUCT_HOME_BASIC_E = 67U;

			// Token: 0x0400132D RID: 4909
			public const uint PRODUCT_HOME_BASIC_N = 5U;

			// Token: 0x0400132E RID: 4910
			public const uint PRODUCT_HOME_PREMIUM = 3U;

			// Token: 0x0400132F RID: 4911
			public const uint PRODUCT_HOME_PREMIUM_E = 68U;

			// Token: 0x04001330 RID: 4912
			public const uint PRODUCT_HOME_PREMIUM_N = 26U;

			// Token: 0x04001331 RID: 4913
			public const uint PRODUCT_HOME_PREMIUM_SERVER = 34U;

			// Token: 0x04001332 RID: 4914
			public const uint PRODUCT_HOME_SERVER = 19U;

			// Token: 0x04001333 RID: 4915
			public const uint PRODUCT_HYPERV = 42U;

			// Token: 0x04001334 RID: 4916
			public const uint PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT = 30U;

			// Token: 0x04001335 RID: 4917
			public const uint PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING = 32U;

			// Token: 0x04001336 RID: 4918
			public const uint PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY = 31U;

			// Token: 0x04001337 RID: 4919
			public const uint PRODUCT_MULTIPOINT_STANDARD_SERVER = 76U;

			// Token: 0x04001338 RID: 4920
			public const uint PRODUCT_MULTIPOINT_PREMIUM_SERVER = 77U;

			// Token: 0x04001339 RID: 4921
			public const uint PRODUCT_PROFESSIONAL = 48U;

			// Token: 0x0400133A RID: 4922
			public const uint PRODUCT_PROFESSIONAL_E = 69U;

			// Token: 0x0400133B RID: 4923
			public const uint PRODUCT_PROFESSIONAL_N = 49U;

			// Token: 0x0400133C RID: 4924
			public const uint PRODUCT_PROFESSIONAL_WMC = 103U;

			// Token: 0x0400133D RID: 4925
			public const uint PRODUCT_SB_SOLUTION_SERVER_EM = 54U;

			// Token: 0x0400133E RID: 4926
			public const uint PRODUCT_SERVER_FOR_SB_SOLUTIONS = 51U;

			// Token: 0x0400133F RID: 4927
			public const uint PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM = 55U;

			// Token: 0x04001340 RID: 4928
			public const uint PRODUCT_SERVER_FOR_SMALLBUSINESS = 24U;

			// Token: 0x04001341 RID: 4929
			public const uint PRODUCT_SERVER_FOR_SMALLBUSINESS_V = 35U;

			// Token: 0x04001342 RID: 4930
			public const uint PRODUCT_SERVER_FOUNDATION = 33U;

			// Token: 0x04001343 RID: 4931
			public const uint PRODUCT_SB_SOLUTION_SERVER = 50U;

			// Token: 0x04001344 RID: 4932
			public const uint PRODUCT_SMALLBUSINESS_SERVER = 9U;

			// Token: 0x04001345 RID: 4933
			public const uint PRODUCT_SMALLBUSINESS_SERVER_PREMIUM = 25U;

			// Token: 0x04001346 RID: 4934
			public const uint PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE = 63U;

			// Token: 0x04001347 RID: 4935
			public const uint PRODUCT_SOLUTION_EMBEDDEDSERVER = 56U;

			// Token: 0x04001348 RID: 4936
			public const uint PRODUCT_STANDARD_EVALUATION_SERVER = 79U;

			// Token: 0x04001349 RID: 4937
			public const uint PRODUCT_STANDARD_SERVER = 7U;

			// Token: 0x0400134A RID: 4938
			public const uint PRODUCT_STANDARD_SERVER_CORE = 13U;

			// Token: 0x0400134B RID: 4939
			public const uint PRODUCT_STANDARD_SERVER_CORE_V = 40U;

			// Token: 0x0400134C RID: 4940
			public const uint PRODUCT_STANDARD_SERVER_SOLUTIONS = 52U;

			// Token: 0x0400134D RID: 4941
			public const uint PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE = 53U;

			// Token: 0x0400134E RID: 4942
			public const uint PRODUCT_STANDARD_SERVER_V = 36U;

			// Token: 0x0400134F RID: 4943
			public const uint PRODUCT_STARTER = 11U;

			// Token: 0x04001350 RID: 4944
			public const uint PRODUCT_STARTER_E = 66U;

			// Token: 0x04001351 RID: 4945
			public const uint PRODUCT_STARTER_N = 47U;

			// Token: 0x04001352 RID: 4946
			public const uint PRODUCT_STORAGE_ENTERPRISE_SERVER = 23U;

			// Token: 0x04001353 RID: 4947
			public const uint PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE = 46U;

			// Token: 0x04001354 RID: 4948
			public const uint PRODUCT_STORAGE_EXPRESS_SERVER = 20U;

			// Token: 0x04001355 RID: 4949
			public const uint PRODUCT_STORAGE_EXPRESS_SERVER_CORE = 43U;

			// Token: 0x04001356 RID: 4950
			public const uint PRODUCT_STORAGE_STANDARD_EVALUATION_SERVER = 96U;

			// Token: 0x04001357 RID: 4951
			public const uint PRODUCT_STORAGE_STANDARD_SERVER = 21U;

			// Token: 0x04001358 RID: 4952
			public const uint PRODUCT_STORAGE_STANDARD_SERVER_CORE = 44U;

			// Token: 0x04001359 RID: 4953
			public const uint PRODUCT_STORAGE_WORKGROUP_EVALUATION_SERVER = 95U;

			// Token: 0x0400135A RID: 4954
			public const uint PRODUCT_STORAGE_WORKGROUP_SERVER = 22U;

			// Token: 0x0400135B RID: 4955
			public const uint PRODUCT_STORAGE_WORKGROUP_SERVER_CORE = 45U;

			// Token: 0x0400135C RID: 4956
			public const uint PRODUCT_UNDEFINED = 0U;

			// Token: 0x0400135D RID: 4957
			public const uint PRODUCT_UNLICENSED = 2882382797U;

			// Token: 0x0400135E RID: 4958
			public const uint PRODUCT_ULTIMATE = 1U;

			// Token: 0x0400135F RID: 4959
			public const uint PRODUCT_ULTIMATE_E = 71U;

			// Token: 0x04001360 RID: 4960
			public const uint PRODUCT_ULTIMATE_N = 28U;

			// Token: 0x04001361 RID: 4961
			public const uint PRODUCT_WEB_SERVER = 17U;

			// Token: 0x04001362 RID: 4962
			public const uint PRODUCT_WEB_SERVER_CORE = 29U;
		}
	}
}
