using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200006D RID: 109
	public class MultiPasswordBoxConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600014B RID: 331 RVA: 0x00011CCC File Offset: 0x0000FECC
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)806223872;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				global::System.Collections.Generic.List<global::System.Windows.Controls.PasswordBox> list;
				int num4;
				for (;;)
				{
					IL_28:
					object obj;
					switch (num2)
					{
					case 0:
						list.Add((global::System.Windows.Controls.PasswordBox)obj);
						num = (short)1479868419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_17F;
					case 2:
						goto IL_148;
					case 3:
					{
						num = (short)1684970612;
						short num3 = num;
						num = (short)962894964;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_148;
						default:
							num = (short)1729560576;
							if (num != 0)
							{
							}
							goto IL_6F;
						}
						break;
					}
					case 4:
						goto IL_1BA;
					case 5:
					{
						if (num4 >= values.Length)
						{
							num = (short)311033860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						obj = values[num4];
						num = (short)966852608;
						short num5 = num;
						num = (short)1845559298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_17F;
					}
					goto IL_4B;
					IL_6F:
					num4++;
					num = (short)759758854;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17F:
					num = (short)1306394629;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_148:
					if (!(obj.GetType() == typeof(global::System.Windows.Controls.PasswordBox)))
					{
						goto IL_6F;
					}
					num = (short)1367474176;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1BA:
				num = (short)682557441;
				if (num != 0)
				{
				}
				return list;
				IL_4B:
				list = new global::System.Collections.Generic.List<global::System.Windows.Controls.PasswordBox>();
				num4 = 0;
				num = (short)265879553;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00011EC0 File Offset: 0x000100C0
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)993132544;
			short num2 = num;
			num = (short)1404764161;
			if (num != 0)
			{
			}
			num = (short)406717780;
			short num3 = num;
			num = (short)1894122836;
			switch (num3 == num)
			{
			}
			num = (short)1188823040;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
