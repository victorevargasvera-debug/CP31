using System;
using System.Runtime.CompilerServices;
using AcpCommonLib;

namespace AcpBusinessLayer
{
	// Token: 0x02000005 RID: 5
	public static class AcpConstraints
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002170 File Offset: 0x00000370
		internal static bool AcpVisibilityRules(global::AcpBusinessLayer.AcpFieldBase self)
		{
			switch (0)
			{
			case 0:
				goto IL_A8;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_4F5;
				case 1:
					if (!self.TieredOut)
					{
						num2 = (short)1587937317;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_579;
				case 2:
					num2 = (short)1403584522;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1931804680;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					self.HiddenDynamic = true;
					num2 = (short)2003632164;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)545521691;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_37E;
				case 7:
					self.HiddenDynamic = true;
					num2 = (short)451936279;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (self.DifferentiatedUserView == global::AcpCommonLib.DifferentiatedUserViewType.Labtool)
					{
						num2 = (short)1463746569;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_238;
				case 9:
					self.HiddenDynamic = true;
					num2 = (short)1924136960;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (self.DifferentiatedUserView == global::AcpCommonLib.DifferentiatedUserViewType.Depot)
					{
						num2 = (short)67305502;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_301;
				case 11:
					if (self.GuiVersion > global::AcpCommonLib.AppInfoManager.GuiVersion)
					{
						num2 = (short)1251344390;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1789394979;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (self.DifferentiatedUserView <= global::AcpCommonLib.DifferentiatedUserViewType.Secret)
					{
						num2 = (short)1828519968;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)487391251;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.DEPOT)
					{
						num2 = (short)473825295;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_174;
				case 14:
					num2 = (short)436666401;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					num2 = (short)672137236;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					goto IL_27D;
				case 17:
					if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.LABTOOL)
					{
						num2 = (short)1616969759;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_215;
				case 18:
					goto IL_3CC;
				case 19:
					if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.DEPOT)
					{
						num2 = (short)2074214402;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_301;
				case 20:
					if (self.DifferentiatedUserView == global::AcpCommonLib.DifferentiatedUserViewType.Depot)
					{
						num2 = (short)1052770308;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_174;
				case 21:
					num2 = (short)1772945420;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					if (self.DifferentiatedUserView <= global::AcpCommonLib.AppInfoManager.AppView)
					{
						num2 = (short)410899157;
						short num3 = num2;
						num2 = (short)613929685;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_61D;
						}
					}
					num2 = (short)1117388814;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					goto IL_210;
				case 24:
					goto IL_452;
				case 25:
					goto IL_42F;
				case 26:
					if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.LABTOOL)
					{
						num2 = (short)450035715;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_238;
				case 27:
					if (!self.CustomViewVisibility)
					{
						num2 = (short)149880853;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5A7;
				case 28:
					self.HiddenDynamic = true;
					num2 = (short)1227423768;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					goto IL_233;
				case 30:
					self.HiddenDynamic = true;
					num2 = (short)1175453721;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					num2 = (short)1754791970;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
				{
					self.HiddenDynamic = true;
					num2 = (short)131268608;
					short num4 = num2;
					num2 = (short)163184658;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 33:
					if (self.DifferentiatedUserView <= global::AcpCommonLib.DifferentiatedUserViewType.Secret)
					{
						num2 = (short)334757895;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1202913293;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					if (self.DifferentiatedUserView == global::AcpCommonLib.DifferentiatedUserViewType.Labtool)
					{
						num2 = (short)361955356;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_215;
				case 35:
					if (global::AcpCommonLib.AppInfoManager.AppView == global::AcpCommonLib.DifferentiatedUserViewType.Custom)
					{
						num2 = (short)775815173;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5A7;
				case 36:
					goto IL_5A2;
				case 37:
					num2 = (short)584974347;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_A8;
				IL_174:
				num2 = (short)1311309841;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_215:
				self.HiddenStatic = true;
				num2 = (short)861208605;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_238:
				self.HiddenStatic = true;
				num2 = (short)689569793;
				if (num2 != 0)
				{
				}
				num2 = (short)2141126672;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_301:
				num2 = (short)1289879578;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5A7:
				num2 = (short)1440808982;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_210:
			IL_233:
			return false;
			IL_27D:
			return false;
			IL_37E:
			goto IL_579;
			IL_3CC:
			IL_42F:
			return false;
			IL_452:
			return false;
			IL_4F5:
			return false;
			IL_579:
			self.HiddenStatic = true;
			return false;
			IL_5A2:
			return false;
			IL_61D:
			num2 = (short)1373044736;
			if (num2 != 0)
			{
			}
			return true;
			IL_A8:
			self.HiddenDynamic = false;
			self.HiddenStatic = false;
			num2 = (short)836304897;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000027B4 File Offset: 0x000009B4
		internal static bool AcpEditabilityRules(global::AcpBusinessLayer.AcpFieldBase self)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (global::AcpBusinessLayer.AcpConstraints.IsPermissionGranted != null)
					{
						num2 = (short)1294139395;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11C;
				case 1:
					goto IL_AC;
				case 2:
					goto IL_11C;
				case 3:
					result = global::AcpBusinessLayer.AcpConstraints.IsPermissionGranted(self);
					num2 = (short)1553661954;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)243990533;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (self.Protected)
					{
						num2 = (short)318963713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11C;
				case 6:
					if (self != null)
					{
						num2 = (short)1997012996;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11C;
				}
				goto IL_2C;
				IL_AC:
				num2 = (short)1188036608;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_11C:
				num2 = (short)1622730754;
				short num3 = num2;
				num2 = (short)43837442;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AC;
				default:
					goto IL_154;
				}
			}
			IL_154:
			num2 = (short)1435238400;
			if (num2 != 0)
			{
			}
			num2 = (short)1280638976;
			short num4 = num2;
			return result;
			IL_2C:
			result = true;
			num2 = (short)646447105;
			if (num2 != 0)
			{
			}
			num2 = (short)338427910;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002958 File Offset: 0x00000B58
		public static bool AcpAlwaysNonEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1077280768;
			short num2 = num;
			num = (short)1885600683;
			short num3 = num;
			num = (short)225835947;
			switch (num3 == num)
			{
			}
			num = (short)1484128257;
			if (num != 0)
			{
			}
			num = (short)561250304;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002A04 File Offset: 0x00000C04
		internal static bool AcpAlwaysEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)621019136;
			short num2 = num;
			num = (short)333761511;
			short num3 = num;
			num = (short)1798687719;
			switch (num3 == num)
			{
			}
			num = (short)1400504320;
			if (num != 0)
			{
			}
			num = (short)826605569;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002AAC File Offset: 0x00000CAC
		internal static bool AcpAlwaysInvisible(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)297861120;
			short num2 = num;
			num = (short)1951305929;
			short num3 = num;
			num = (short)713461961;
			switch (num3 == num)
			{
			}
			num = (short)88014848;
			if (num != 0)
			{
			}
			num = (short)1889337345;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002B54 File Offset: 0x00000D54
		internal static bool AcpValidilityRules(global::AcpCommonLib.IAcpField self)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)113115136;
					short num3 = num2;
					num2 = (short)1407320067;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (acpFieldBase != null)
					{
						num2 = (short)1531576320;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					result = global::AcpBusinessLayer.AcpConstraints.IsValuePermitted(acpFieldBase);
					num2 = (short)984023045;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (acpFieldBase.Protected)
					{
						num2 = (short)671350790;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					if (global::AcpBusinessLayer.AcpConstraints.IsValuePermitted != null)
					{
						num2 = (short)129957890;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 5:
					return result;
				case 6:
				{
					num2 = (short)687113249;
					short num4 = num2;
					num2 = (short)74220577;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)2016215041;
						if (num2 != 0)
						{
						}
						num2 = (short)27590656;
						if (num2 != 0)
						{
						}
						num2 = (short)1185480708;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_2C;
			}
			return result;
			IL_2C:
			result = true;
			acpFieldBase = (self as global::AcpBusinessLayer.AcpFieldBase);
			num2 = (short)1095565313;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002D08 File Offset: 0x00000F08
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002DB4 File Offset: 0x00000FB4
		public static global::AcpCommonLib.InternalConstraint IsPermissionGranted
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)35061760;
				short num2 = num;
				num = (short)768814639;
				short num3 = num;
				num = (short)217656879;
				switch (num3 == num)
				{
				}
				num = (short)1044971520;
				if (num != 0)
				{
				}
				num = (short)2125987841;
				if (num != 0)
				{
				}
				return global::AcpBusinessLayer.AcpConstraints.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1460469760;
				short num2 = num;
				num = (short)876894043;
				short num3 = num;
				num = (short)786126683;
				switch (num3 == num)
				{
				}
				num = (short)1057619968;
				if (num != 0)
				{
				}
				num = (short)1935802369;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpConstraints.a = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002E68 File Offset: 0x00001068
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002F14 File Offset: 0x00001114
		public static global::AcpCommonLib.InternalConstraint IsValuePermitted
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1446379520;
				short num2 = num;
				num = (short)1735177850;
				short num3 = num;
				num = (short)292992634;
				switch (num3 == num)
				{
				}
				num = (short)663289857;
				if (num != 0)
				{
				}
				num = (short)424017920;
				if (num != 0)
				{
				}
				return global::AcpBusinessLayer.AcpConstraints.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1729560576;
				short num2 = num;
				num = (short)723012889;
				short num3 = num;
				num = (short)1015762201;
				switch (num3 == num)
				{
				}
				num = (short)1722286081;
				if (num != 0)
				{
				}
				num = (short)59244544;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpConstraints.b = value;
			}
		}

		// Token: 0x04000004 RID: 4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.InternalConstraint a;

		// Token: 0x04000005 RID: 5
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.InternalConstraint b;
	}
}
