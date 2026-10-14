using System;
using System.Globalization;
using System.Net;
using System.Windows.Data;
using AllFeatures;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004C7 RID: 1223
	public sealed class ConvertSubnetAddress : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600A0EA RID: 41194 RVA: 0x009666EC File Offset: 0x009648EC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 1;
			global::System.Net.IPAddress ipaddress;
			short num;
			while (global::System.Net.IPAddress.TryParse(((long)value).ToString(), out ipaddress))
			{
				num = (short)1184628736;
				short num2 = num;
				num = (short)145735902;
				short num3 = num;
				num = (short)1597620446;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)62455808;
					if (num != 0)
					{
					}
					byte[] addressBytes = ipaddress.GetAddressBytes();
					return string.Format(global::AllFeatures.CodeplugGuid.b("링믅뇉﷋돍ﻏ꧑ꯕ", a_), addressBytes[0], addressBytes[1], addressBytes[2]);
				}
				}
			}
			num = (short)1603534849;
			if (num != 0)
			{
			}
			return "";
		}

		// Token: 0x0600A0EB RID: 41195 RVA: 0x009667F4 File Offset: 0x009649F4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)192937984;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A3;
				}
				long[] array2;
				string text;
				for (;;)
				{
					IL_28:
					num = (short)1580427956;
					short num3 = num;
					num = (short)1967286964;
					int num4;
					string[] array;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1995309056;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							if (num4 >= array.Length)
							{
								num = (short)1588527109;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)891420673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							long num5;
							if (!long.TryParse(array[num4], out num5))
							{
								num = (short)1004666886;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array2[num4] = num5;
							num = (short)1877934082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_1FA;
						case 3:
							goto IL_E5;
						case 4:
							goto IL_1B9;
						case 5:
							goto IL_1F0;
						case 6:
							array2[num4] = 0L;
							num = (short)2061631497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (string.IsNullOrEmpty(text))
							{
								num = (short)1526595587;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_15A;
						case 8:
						{
							num = (short)156631040;
							short num6 = num;
							goto IL_1B9;
						}
						case 9:
							num = (short)135200769;
							if (num != 0)
							{
							}
							goto IL_1FA;
						}
						goto IL_A3;
						IL_1B9:
						num = (short)2057895936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1FA:
						num4++;
						num = (short)2082734084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_15A:
					array = text.Split(new char[]
					{
						'.'
					});
					array2 = new long[3];
					num4 = 0;
					num = (short)343670792;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E5:
				return 0L;
				IL_1F0:
				return (array2[0] << 24) + (array2[1] << 16) + (array2[2] << 8);
				IL_A3:
				text = (string)value;
				num = (short)1380712455;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
