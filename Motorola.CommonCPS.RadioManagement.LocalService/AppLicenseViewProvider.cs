using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200006F RID: 111
	public class AppLicenseViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo>
	{
		// Token: 0x0600036A RID: 874 RVA: 0x0005229C File Offset: 0x0005049C
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo> FetchRange(int startIndex, int length, out int milliseconds)
		{
			milliseconds = 1;
			if (startIndex == 0)
			{
				short num;
				for (;;)
				{
					num = (short)952238080;
					short num2 = num;
					num = (short)1286947655;
					short num3 = num;
					num = (short)2019377991;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_68;
					}
				}
				IL_68:
				num = (short)526254081;
				if (num != 0)
				{
				}
				num = (short)1695678464;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.ListAppLicenses();
			}
			return new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo>();
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00052364 File Offset: 0x00050564
		public int GetTotalCount()
		{
			short num = (short)1120205760;
			short num2 = num;
			num = (short)1508965312;
			switch (num2 == num)
			{
			default:
			{
				num = (short)723320832;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)459735040;
			if (num != 0)
			{
			}
			num = (short)1606549505;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.GetAppLicenseCount();
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00052420 File Offset: 0x00050620
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo item)
		{
			short num = (short)857538561;
			if (num != 0)
			{
			}
			num = (short)618659840;
			short num2 = num;
			num = (short)1945871499;
			short num3 = num;
			num = (short)1620157579;
			switch (num3 == num)
			{
			}
			num = (short)1393754112;
			if (num != 0)
			{
			}
			item.Validator = null;
		}
	}
}
