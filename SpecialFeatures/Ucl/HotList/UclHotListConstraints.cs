using System;
using AcpCommonLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001DA RID: 474
	internal class UclHotListConstraints
	{
		// Token: 0x060016F4 RID: 5876 RVA: 0x001F7A38 File Offset: 0x001F5C38
		internal static bool conAstroHotListCallIDIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			while (index != 65535)
			{
				short num = (short)48992866;
				short num2 = num;
				num = (short)1309512290;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1728708608;
					if (num != 0)
					{
					}
					num = (short)1669332993;
					if (num != 0)
					{
					}
					num = (short)1839661056;
					short num3 = num;
					return true;
				}
				}
			}
			return false;
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x001F7AEC File Offset: 0x001F5CEC
		internal static bool ConAstroContactAliasIsNotUnassigned(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)115974320;
			short num2 = num;
			num = (short)228630704;
			switch (num2 == num)
			{
			}
			num = (short)949813249;
			if (num != 0)
			{
			}
			num = (short)1715404800;
			if (num != 0)
			{
			}
			num = (short)356384768;
			short num3 = num;
			return (self as global::SpecialFeatures.Ucl.HotList.AstroCallHotListHotListSection).UclAstroCnvHotList_ContactAlias_A00043Object.Value > 0;
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x001F7BA8 File Offset: 0x001F5DA8
		internal static bool conMDCHotListCallIDIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			while (index != 65535)
			{
				short num = (short)1715230733;
				short num2 = num;
				num = (short)421287949;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1950023681;
					if (num != 0)
					{
					}
					num = (short)1495465984;
					if (num != 0)
					{
					}
					num = (short)16056320;
					short num3 = num;
					return true;
				}
				}
			}
			return false;
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x001F7C5C File Offset: 0x001F5E5C
		internal static bool ConMDCContactAliasIsNotUnassigned(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1471249825;
			short num2 = num;
			num = (short)962428321;
			switch (num2 == num)
			{
			}
			num = (short)975568897;
			if (num != 0)
			{
			}
			num = (short)340590592;
			if (num != 0)
			{
			}
			num = (short)731709440;
			short num3 = num;
			return (self as global::SpecialFeatures.Ucl.HotList.MDCCallHotListHotListSection).UclMDCCnvHotList_ContactAlias_A00046Object.Value > 0;
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x001F7D1C File Offset: 0x001F5F1C
		internal static bool conAstro25HotListCallIDIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num;
			while (index != 65535)
			{
				num = (short)1873702284;
				short num2 = num;
				num = (short)1359637900;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1077608448;
					if (num != 0)
					{
					}
					num = (short)1083179008;
					short num3 = num;
					return true;
				}
				}
			}
			num = (short)552468481;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x001F7DD4 File Offset: 0x001F5FD4
		internal static bool ConAstro25ContactAliasIsNotUnassigned(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1084882945;
			if (num != 0)
			{
			}
			num = (short)2104669407;
			short num2 = num;
			num = (short)783332575;
			switch (num2 == num)
			{
			}
			num = (short)1354170368;
			if (num != 0)
			{
			}
			num = (short)553648128;
			short num3 = num;
			return (self as global::SpecialFeatures.Ucl.HotList.TrunkingCallHotListHotListSection).UclAstro25TrkHotList_ContactAlias_A00037Object.Value > 0;
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x001F7E90 File Offset: 0x001F6090
		internal static bool conTrkT2HotListCallIDIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			while (index != 65535)
			{
				short num = (short)289637878;
				short num2 = num;
				num = (short)1099400694;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1184759809;
					if (num != 0)
					{
					}
					num = (short)1758330880;
					if (num != 0)
					{
					}
					num = (short)1462239232;
					short num3 = num;
					return true;
				}
				}
			}
			return false;
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x001F7F48 File Offset: 0x001F6148
		internal static bool ConTrkT2ContactAliasIsNotUnassigned(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2141264701;
			short num2 = num;
			num = (short)1621629757;
			switch (num2 == num)
			{
			}
			num = (short)150667265;
			if (num != 0)
			{
			}
			num = (short)1629159424;
			if (num != 0)
			{
			}
			num = (short)396886016;
			short num3 = num;
			return (self as global::SpecialFeatures.Ucl.HotList.TrunkingT2CallHotListHotListSection).UclT2TrkHotList_ContactAlias_A00040Object.Value > 0;
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x001F8004 File Offset: 0x001F6204
		internal static bool conPhoneHotListCallIDIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num;
			while (index != 65535)
			{
				num = (short)359475157;
				short num2 = num;
				num = (short)887760853;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)98762752;
					if (num != 0)
					{
					}
					num = (short)1963982848;
					short num3 = num;
					return true;
				}
				}
			}
			num = (short)1275133953;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x001F80B8 File Offset: 0x001F62B8
		internal static bool ConPhoneContactAliasIsNotUnassigned(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1657999632;
			short num2 = num;
			num = (short)92934416;
			switch (num2 == num)
			{
			}
			num = (short)30605312;
			if (num != 0)
			{
			}
			num = (short)1807417345;
			if (num != 0)
			{
			}
			num = (short)1118896128;
			short num3 = num;
			return (self as global::SpecialFeatures.Ucl.HotList.PhoneCallHotListHotListSection).UclPhoneHotList_ContactAlias_A00049Object.Value > 0;
		}
	}
}
