using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Comms.Util
{
	// Token: 0x0200017A RID: 378
	public struct HostVersion : global::System.IComparable
	{
		// Token: 0x060012BD RID: 4797 RVA: 0x0000371C File Offset: 0x0000191C
		public HostVersion(bool success, short major, short minor)
		{
			this.a = success;
			this.b = major;
			this.c = minor;
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x001A3E94 File Offset: 0x001A2094
		public readonly bool Success
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)442603827;
				short num2 = num;
				num = (short)1122933043;
				switch (num2 == num)
				{
				}
				num = (short)968425472;
				if (num != 0)
				{
				}
				num = (short)1145962497;
				if (num != 0)
				{
				}
				num = (short)1359216640;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x001A3F40 File Offset: 0x001A2140
		public readonly short Major
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1985825568;
				short num2 = num;
				num = (short)10439456;
				switch (num2 == num)
				{
				}
				num = (short)1569587201;
				if (num != 0)
				{
				}
				num = (short)728825856;
				if (num != 0)
				{
				}
				num = (short)779812864;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x001A3FF0 File Offset: 0x001A21F0
		public readonly short Minor
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)938992548;
				short num2 = num;
				num = (short)2086986660;
				switch (num2 == num)
				{
				}
				num = (short)1293811713;
				if (num != 0)
				{
				}
				num = (short)1636302848;
				if (num != 0)
				{
				}
				num = (short)1704001536;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x001A40A0 File Offset: 0x001A22A0
		internal static global::System.Text.RegularExpressions.Regex VersionPattern
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1480441009;
				short num2 = num;
				num = (short)723369137;
				switch (num2 == num)
				{
				}
				num = (short)983826432;
				if (num != 0)
				{
				}
				num = (short)2070085633;
				if (num != 0)
				{
				}
				num = (short)1845690368;
				short num3 = num;
				return global::SpecialFeatures.Comms.Util.HostVersion.d;
			}
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x001A4154 File Offset: 0x001A2354
		public static global::SpecialFeatures.Comms.Util.HostVersion Parse(string hostVersionStr)
		{
			int a_ = 2;
			short num = (short)1033175040;
			switch (num)
			{
			default:
			{
				num = (short)1111775287;
				short num2 = num;
				num = (short)1298028599;
				global::System.Text.RegularExpressions.Match match;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_CC:
					match = global::SpecialFeatures.Comms.Util.HostVersion.VersionPattern.Match(hostVersionStr ?? string.Empty);
					num = (short)213450753;
					if (num != 0)
					{
					}
					num = (short)1110376449;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)675938304;
					short num4 = num;
					num = (short)1459224576;
					if (num != 0)
					{
					}
					num = (short)60096514;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_190;
					case 1:
						if (match.Success)
						{
							num = (short)1793064960;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19D;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_CC;
						}
						continue;
					}
					goto IL_CC;
				}
				IL_190:
				short major;
				bool flag = global::SpecialFeatures.Comms.Util.HostVersion.a(match.Groups[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좄ﾌ", a_)], out major);
				short minor;
				flag = (global::SpecialFeatures.Comms.Util.HostVersion.a(match.Groups[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좄ﾌ", a_)], out minor) && flag);
				return new global::SpecialFeatures.Comms.Util.HostVersion(flag, major, minor);
				IL_19D:
				return default(global::SpecialFeatures.Comms.Util.HostVersion);
			}
			}
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x001A4308 File Offset: 0x001A2508
		private static bool a(global::System.Text.RegularExpressions.Group A_0, out short A_1)
		{
			A_1 = 0;
			short num;
			if (!A_0.Success)
			{
				num = (short)1102577665;
				if (num != 0)
				{
				}
				num = (short)1595333975;
				short num2 = num;
				num = (short)1155718487;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1724907520;
					if (num != 0)
					{
					}
					return false;
				}
			}
			num = (short)1992556544;
			short num3 = num;
			return short.TryParse(A_0.Value, out A_1);
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x001A43D0 File Offset: 0x001A25D0
		public int CompareTo(object obj)
		{
			short num = (short)2019033088;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::SpecialFeatures.Comms.Util.HostVersion hostVersion;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						int num3 = this.Minor.CompareTo(hostVersion.Minor);
						num = (short)725024770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return -1;
					case 2:
					{
						int num3;
						return num3;
					}
					case 3:
					{
						int num3;
						if (num3 == 0)
						{
							num = (short)2113536000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num3;
					}
					case 4:
					{
						num = (short)1779433472;
						short num4 = num;
						if (hostVersion.Equals(default(global::SpecialFeatures.Comms.Util.HostVersion)))
						{
							num = (short)251005149;
							short num5 = num;
							num = (short)571541725;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1723006976;
								if (num != 0)
								{
								}
								num = (short)382009345;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
						}
						else
						{
							int num3 = this.Major.CompareTo(hostVersion.Major);
						}
						num = (short)842268675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_43;
				}
				return -1;
				IL_43:
				num = (short)643825665;
				if (num != 0)
				{
				}
				hostVersion = global::SpecialFeatures.Comms.Util.HostVersion.Parse(obj.ToString());
				num = (short)929366020;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x001A459C File Offset: 0x001A279C
		// Note: this type is marked as 'beforefieldinit'.
		static HostVersion()
		{
			int a_ = 3;
			short num = (short)1548983371;
			short num2 = num;
			num = (short)1644534859;
			switch (num2 == num)
			{
			}
			num = (short)2093285377;
			if (num != 0)
			{
			}
			num = (short)1278345216;
			if (num != 0)
			{
			}
			num = (short)1839726592;
			short num3 = num;
			global::SpecialFeatures.Comms.Util.HostVersion.d = new global::System.Text.RegularExpressions.Regex(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud885풇캉뎋ꚍ꾏꺑\ud993ꂝﲟ욡\udfa3鞥蒧颩톫螭鲱讳麵螷蚹ힽ꺿귁뛃铇껉럋ￍﳏ꧓ￕ", a_));
		}

		// Token: 0x04000A13 RID: 2579
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly bool a;

		// Token: 0x04000A14 RID: 2580
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly short b;

		// Token: 0x04000A15 RID: 2581
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly short c;

		// Token: 0x04000A16 RID: 2582
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static readonly global::System.Text.RegularExpressions.Regex d;
	}
}
