using System;
using System.Globalization;
using System.Windows.Data;
using AcpBusinessLayer.UndoRedo;
using AcpCommonResources;

namespace AcpBusinessLayer.ValueConverters
{
	// Token: 0x02000044 RID: 68
	public class IPAddressConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060004C4 RID: 1220 RVA: 0x00066E14 File Offset: 0x00065014
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 11;
			short num = (short)1628304511;
			short num2 = num;
			num = (short)1978791039;
			switch (num2 == num)
			{
			}
			num = (short)169934848;
			short num3 = num;
			num = (short)1462697984;
			if (num != 0)
			{
			}
			num = (short)1407451137;
			if (num != 0)
			{
			}
			long num4 = (long)value;
			return string.Concat(new string[]
			{
				((byte)num4).ToString(),
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_),
				((byte)(num4 >> 8)).ToString(),
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_),
				((byte)(num4 >> 16)).ToString(),
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_),
				((byte)(num4 >> 24)).ToString()
			});
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00066F48 File Offset: 0x00065148
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 19;
			short num = (short)987496448;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_85;
				}
				long num7;
				for (;;)
				{
					IL_32:
					string[] array;
					int num3;
					int fromBase;
					long num4;
					switch (num2)
					{
					case 0:
						goto IL_279;
					case 1:
						goto IL_CC;
					case 2:
						goto IL_C7;
					case 3:
						if (array[num3].ToUpper().StartsWith(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("헤", a_)))
						{
							num = (short)108920846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						fromBase = 10;
						num = (short)1920794628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_CC;
					case 5:
						goto IL_2B3;
					case 6:
						if (num4 >= 0L)
						{
							goto IL_F7;
						}
						goto IL_13B;
					case 7:
						if (array.Length != 4)
						{
							num = (short)109707281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = 0;
						num = (short)1921843209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)312213522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_279;
					case 10:
						if (num3 >= 4)
						{
							num = (short)1507131397;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1948123148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						if (string.IsNullOrEmpty((string)value))
						{
							num = (short)975241218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array = ((string)value).Split(new char[]
						{
							'.'
						}, 5);
						num = (short)679477248;
						short num5 = num;
						num = (short)1380122631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (array[num3].ToUpper().StartsWith(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("헤뿦", a_)))
						{
							num = (short)194248717;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1724841987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						fromBase = 16;
						num = (short)309002255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						fromBase = 8;
						num = (short)799408129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_CC;
					case 16:
						goto IL_274;
					case 17:
					{
						num = (short)1401793000;
						short num6 = num;
						num = (short)638364136;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F7;
						default:
							goto IL_1F5;
						}
						break;
					}
					case 18:
						num = (short)316538881;
						if (num != 0)
						{
						}
						if (num4 > 255L)
						{
							num = (short)1261502480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num7 += num4 << 8 * num3;
						num3++;
						num = (short)344326144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_85;
					IL_CC:
					num4 = (long)global::System.Convert.ToInt32(array[num3], fromBase);
					num = (short)168558598;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F7:
					num = (short)440860680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_279:
					num = (short)1960050698;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C7:
				throw new global::System.ArgumentNullException();
				IL_13B:
				throw new global::System.ArgumentException(global::AcpCommonResources.AcpResources.Octet_Larger_Than_255);
				IL_1F5:
				num = (short)743702528;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentException(global::AcpCommonResources.AcpResources.Not_IPV4_Format);
				IL_274:
				goto IL_13B;
				IL_2B3:
				return num7;
				IL_85:
				num7 = 0L;
				num = (short)1744830475;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}
	}
}
