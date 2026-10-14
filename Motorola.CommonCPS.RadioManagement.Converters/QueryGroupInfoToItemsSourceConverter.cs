using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200007F RID: 127
	public class QueryGroupInfoToItemsSourceConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000181 RID: 385 RVA: 0x00014318 File Offset: 0x00012518
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1623982080;
			switch (num)
			{
			default:
			{
				num = (short)437125125;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1695154176;
					short num3 = num;
					global::System.Collections.Generic.List<string> list;
					int num4;
					string text;
					switch (num2)
					{
					case 0:
						return list;
					case 1:
					{
						if (num4 > text.Length - 2)
						{
							num = (short)1201078272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string item = text.Substring(num4, 2);
						list.Add(item);
						num4 += 2;
						goto IL_101;
					}
					case 2:
						num = (short)648609793;
						if (num != 0)
						{
						}
						goto IL_170;
					case 3:
						goto IL_170;
					case 4:
						goto IL_E8;
					case 5:
					{
						num = (short)1791188585;
						short num5 = num;
						num = (short)1560174185;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_101;
						default:
							num = (short)383909888;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_D0;
							}
							continue;
						}
						break;
					}
					}
					IL_D0:
					if (value == null)
					{
						num = (short)212140036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text = value.ToString();
					list = new global::System.Collections.Generic.List<string>();
					num4 = 0;
					num = (short)1694629891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_101:
					num = (short)1552220162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_170:
					num = (short)1685979137;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E8:
				return null;
			}
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000144DC File Offset: 0x000126DC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1409632177;
			short num2 = num;
			num = (short)375080881;
			switch (num2 == num)
			{
			default:
			{
				num = (short)719060992;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)16973824;
			if (num != 0)
			{
			}
			num = (short)1564803073;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
