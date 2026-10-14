using System;
using System.Globalization;
using System.Windows.Data;
using AcpASKLib;
using AcpCommonResources;

namespace AcpSecurityLib
{
	// Token: 0x02000006 RID: 6
	public class KeySrcKeyTypeConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600000D RID: 13 RVA: 0x0000299C File Offset: 0x00000B9C
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			string result;
			short num2;
			global::AcpASKLib.KeySource keySource;
			global::AcpASKLib.KeyType keyType;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
					return result;
				case 4:
					num2 = (short)1709375495;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					return result;
				case 6:
					if (keySource == global::AcpASKLib.KeySource.HARDWARE)
					{
						num2 = (short)1380712460;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1763442697;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					result = global::AcpCommonResources.AcpResources.Undefined_Id;
					num2 = (short)1801191425;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					return result;
				case 9:
					num2 = (short)1939079169;
					if (num2 != 0)
					{
					}
					if (keySource == global::AcpASKLib.KeySource.LEGACY_KEY_FILE)
					{
						num2 = (short)1731723274;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonResources.AcpResources.Undefined_Id;
					num2 = (short)2086993922;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_E7;
				case 11:
					switch (keyType)
					{
					case global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY:
						num2 = (short)1559298054;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::AcpASKLib.KeyType.ADVANCED_WACN_KEY:
						result = global::AcpCommonResources.AcpResources.Advanced_WACN_Key;
						num2 = (short)551026693;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::AcpASKLib.KeyType.ADVANCED_CONV_SYSTEM_KEY:
						result = global::AcpCommonResources.AcpResources.Advanced_Conventional_Key;
						num2 = (short)963772419;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
					{
						num2 = (short)1693843456;
						short num3 = num2;
						num2 = (short)1790050308;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				case 12:
				{
					num2 = (short)607717328;
					short num4 = num2;
					num2 = (short)1855784912;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E7;
					default:
						num2 = (short)142278656;
						if (num2 != 0)
						{
						}
						result = global::AcpCommonResources.AcpResources.Advanced_System_Key;
						num2 = (short)1742798848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_44;
				IL_E7:
				result = global::AcpCommonResources.AcpResources.Legacy_Software_System_Key;
				num2 = (short)2053242888;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_44:
			result = null;
			keySource = (global::AcpASKLib.KeySource)values[0];
			keyType = (global::AcpASKLib.KeyType)values[1];
			num2 = (short)1261305867;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002C40 File Offset: 0x00000E40
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)486986537;
			short num2 = num;
			num = (short)1190384425;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1188364288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)670826497;
			if (num != 0)
			{
			}
			num = (short)1167982592;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
