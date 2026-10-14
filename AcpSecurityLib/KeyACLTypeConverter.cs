using System;
using System.Globalization;
using System.Windows.Data;
using AcpASKLib;
using AcpCommonResources;

namespace AcpSecurityLib
{
	// Token: 0x02000007 RID: 7
	public class KeyACLTypeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002D04 File Offset: 0x00000F04
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			string result;
			global::AcpASKLib.KeyAccessLevelType keyAccessLevelType;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_118;
				case 1:
					return result;
				case 2:
					goto IL_141;
				case 3:
					if (keyAccessLevelType - global::AcpASKLib.KeyAccessLevelType.UNLM_ACC > 1)
					{
						num2 = (short)1073545220;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonResources.AcpResources.Unlimited_Id;
					num2 = (short)1943470081;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1081016320;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (keyAccessLevelType != global::AcpASKLib.KeyAccessLevelType.LIMITED_ACC)
					{
						num2 = (short)1000407040;
						short num3 = num2;
						num2 = (short)1134624770;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonResources.AcpResources.Limited_Id;
					num2 = (short)1437925382;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					num2 = (short)1108250855;
					short num4 = num2;
					num2 = (short)2110427367;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_141;
					default:
						goto IL_E6;
					}
					break;
				}
				}
				goto IL_2C;
				IL_141:
				num2 = (short)1116864515;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_E6:
			num2 = (short)1842020352;
			if (num2 != 0)
			{
			}
			return result;
			IL_118:
			num2 = (short)656015361;
			if (num2 != 0)
			{
			}
			return result;
			IL_2C:
			result = null;
			keyAccessLevelType = (global::AcpASKLib.KeyAccessLevelType)value;
			num2 = (short)1566965765;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002EAC File Offset: 0x000010AC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1361696722;
			short num2 = num;
			num = (short)627169234;
			switch (num2 == num)
			{
			default:
			{
				num = (short)694943744;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)756088833;
			if (num != 0)
			{
			}
			num = (short)1878196224;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
