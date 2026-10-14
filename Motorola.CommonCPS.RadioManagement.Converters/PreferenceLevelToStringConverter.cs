using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000072 RID: 114
	public class PreferenceLevelToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600015A RID: 346 RVA: 0x00012744 File Offset: 0x00010944
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1013776384;
			short num2 = num;
			num = (short)2028843889;
			short num3 = num;
			num = (short)533705585;
			switch (num3 == num)
			{
			}
			num = (short)751370241;
			if (num != 0)
			{
			}
			num = (short)1597571072;
			if (num != 0)
			{
			}
			return ((global::Motorola.CommonCPS.Server.CommonDBConstants.PreferLevel)value).ToResourceString();
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000127FC File Offset: 0x000109FC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_149;
				case 1:
				{
					num2 = (short)94437377;
					if (num2 != 0)
					{
					}
					string text;
					if (text.Equals(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_SiteList_PreferredLevel1))
					{
						num2 = (short)46399495;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)687538176;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_1E5;
				case 3:
					goto IL_130;
				case 4:
					goto IL_16E;
				case 5:
				{
					string text;
					if (text.Equals(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_SiteList_PreferredLevel3))
					{
						num2 = (short)1779826691;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1659174918;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
				{
					string text;
					if (text.Equals(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_SiteList_PreferredLevel4))
					{
						num2 = (short)496828418;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1EE;
				}
				case 7:
					goto IL_E5;
				}
				goto IL_30;
			}
			IL_E5:
			num2 = (short)1950482432;
			short num3 = num2;
			return global::Motorola.CommonCPS.Server.CommonDBConstants.PreferLevel.LEVEL1;
			IL_130:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.PreferLevel.LEVEL3;
			IL_16E:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.PreferLevel.LEVEL2;
			IL_1E5:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.PreferLevel.LEVEL4;
			IL_1EE:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.PreferLevel.LEVEL2;
			IL_30:
			num2 = (short)430143687;
			short num4 = num2;
			num2 = (short)1679325383;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_149:
				int num;
				string text;
				if (text.Equals(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_SiteList_PreferredLevel2))
				{
					num2 = (short)24838148;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				num2 = (short)1959723013;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)258801664;
				if (num2 != 0)
				{
				}
				string text = value as string;
				num2 = (short)1555365889;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}
	}
}
