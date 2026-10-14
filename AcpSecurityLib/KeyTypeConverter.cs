using System;
using System.Globalization;
using System.Windows.Data;
using AcpASKLib;
using AcpCommonResources;

namespace AcpSecurityLib
{
	// Token: 0x02000005 RID: 5
	public class KeyTypeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002590 File Offset: 0x00000790
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			string result;
			short num2;
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
				{
					num2 = (short)1408434176;
					short num3 = num2;
					num2 = (short)1718419459;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					result = global::AcpCommonResources.AcpResources.Undefined_Id;
					num2 = (short)809435140;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return result;
				case 5:
					switch (keyType)
					{
					case global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY:
						result = global::AcpCommonResources.AcpResources.Advanced_Trunking_System;
						num2 = (short)46202880;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::AcpASKLib.KeyType.ADVANCED_WACN_KEY:
						result = global::AcpCommonResources.AcpResources.Advanced_WACN_System;
						num2 = (short)1241645062;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::AcpASKLib.KeyType.ADVANCED_CONV_SYSTEM_KEY:
						result = global::AcpCommonResources.AcpResources.Advanced_Conventional_System;
						num2 = (short)37945345;
						if (num2 != 0)
						{
						}
						num2 = (short)1923284993;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
					{
						num2 = (short)1292408190;
						short num4 = num2;
						num2 = (short)1278186878;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1875509248;
							if (num2 != 0)
							{
							}
							num2 = (short)1334968322;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					break;
				case 6:
					return result;
				}
				goto IL_2C;
			}
			return result;
			IL_2C:
			result = null;
			keyType = (global::AcpASKLib.KeyType)value;
			num2 = (short)1715929093;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002750 File Offset: 0x00000950
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::AcpASKLib.KeyType keyType;
			short num2;
			string a;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					keyType = global::AcpASKLib.KeyType.ADVANCED_CONV_SYSTEM_KEY;
					num2 = (short)1966931977;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					if (a == global::AcpCommonResources.AcpResources.Advanced_Trunking_System)
					{
						num2 = (short)2096562182;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)577502938;
					short num3 = num2;
					num2 = (short)2110586586;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CB;
					default:
						num2 = (short)1032650752;
						if (num2 != 0)
						{
						}
						num2 = (short)1500315655;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_E5;
				case 3:
					goto IL_127;
				case 4:
					keyType = global::AcpASKLib.KeyType.ADVANCED_WACN_KEY;
					num2 = (short)1660420101;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_C6;
				case 6:
					goto IL_CB;
				case 7:
					if (a == global::AcpCommonResources.AcpResources.Advanced_WACN_System)
					{
						num2 = (short)360448004;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					keyType = global::AcpASKLib.KeyType.UNDEFINED_KEY;
					num2 = (short)1744830467;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (a == global::AcpCommonResources.AcpResources.Advanced_Conventional_System)
					{
						num2 = (short)1487536129;
						if (num2 != 0)
						{
						}
						num2 = (short)62324736;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)299827201;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_105;
				}
				goto IL_38;
				IL_CB:
				keyType = global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY;
				num2 = (short)1936195586;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_C6:
			IL_E5:
			IL_105:
			IL_127:
			num2 = (short)821886976;
			short num4 = num2;
			return keyType;
			IL_38:
			keyType = global::AcpASKLib.KeyType.UNDEFINED_KEY;
			a = (string)value;
			num2 = (short)1954545672;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
