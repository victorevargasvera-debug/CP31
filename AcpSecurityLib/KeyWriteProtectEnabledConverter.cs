using System;
using System.Globalization;
using System.Windows.Data;
using AcpASKLib;
using AcpCommonResources;

namespace AcpSecurityLib
{
	// Token: 0x02000008 RID: 8
	public class KeyWriteProtectEnabledConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002F70 File Offset: 0x00001170
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int num;
			short num2;
			string result;
			global::AcpASKLib.KeySource keySource;
			bool flag;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						num2 = (short)1826619395;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
					{
						num2 = (short)802750465;
						if (num2 != 0)
						{
						}
						result = global::AcpCommonResources.AcpResources.NA_Id;
						num2 = (short)542521532;
						short num3 = num2;
						num2 = (short)2008496316;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3C;
						default:
							num2 = (short)1586561024;
							if (num2 != 0)
							{
							}
							num2 = (short)988545026;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						return result;
					case 3:
						if (keySource == global::AcpASKLib.KeySource.LEGACY_KEY_FILE)
						{
							num2 = (short)523960321;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 4:
						if (keySource != global::AcpASKLib.KeySource.HARDWARE)
						{
							num2 = (short)352845824;
							short num4 = num2;
							num2 = (short)1788215296;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = flag.ToString();
						num2 = (short)1539178501;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						return result;
					}
					goto IL_28;
				}
				return result;
			}
			IL_28:
			result = null;
			keySource = (global::AcpASKLib.KeySource)values[0];
			flag = (bool)values[1];
			IL_3C:
			num2 = (short)819855364;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003108 File Offset: 0x00001308
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2055107097;
			short num2 = num;
			num = (short)2040885785;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1920270336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)704839681;
			if (num != 0)
			{
			}
			num = (short)1310785536;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000031C8 File Offset: 0x000013C8
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1401278742 + A_1) + (global::System.IntPtr)30 + (global::System.IntPtr)91 + (global::System.IntPtr)36);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}
	}
}
