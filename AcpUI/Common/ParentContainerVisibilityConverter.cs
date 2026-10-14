using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace AcpUI.Common
{
	// Token: 0x02000088 RID: 136
	public class ParentContainerVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x0007B7B4 File Offset: 0x000799B4
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)157745153;
			int num2 = (int)((global::System.IntPtr)num);
			bool flag2;
			for (;;)
			{
				int num3;
				bool flag;
				switch (num2)
				{
				case 0:
					flag = bool.Parse(values[num3].ToString());
					goto IL_253;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 2:
					goto IL_95;
				case 3:
					goto IL_B3;
				case 4:
					flag = true;
					goto IL_253;
				case 5:
					goto IL_115;
				case 6:
					goto IL_90;
				case 7:
					if (!flag2)
					{
						num = (short)1774256139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1154613252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (num3 >= values.Length)
					{
						num = (short)110821376;
						short num4 = num;
						num = (short)362151941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1206583305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (values[num3] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)141557772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_95;
				case 10:
					goto IL_B3;
				case 11:
					num = (short)333250561;
					if (num != 0)
					{
					}
					num = (short)1689976832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)1588461575;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_59:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)378732550;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1661566178;
				short num5 = num;
				num = (short)1615953122;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B3;
				default:
					num = (short)317784064;
					if (num != 0)
					{
					}
					flag2 = false;
					num3 = 0;
					num = (short)1285750787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_95:
				num3++;
				num = (short)103809034;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B3:
				num = (short)1423048712;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_253:
				flag2 = flag;
				num = (short)1657143298;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_90:
			return false;
			IL_115:
			return flag2;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0007BA54 File Offset: 0x00079C54
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)524269063;
			short num2 = num;
			num = (short)2063906311;
			switch (num2 == num)
			{
			}
			num = (short)1659109377;
			if (num != 0)
			{
			}
			num = (short)94175232;
			if (num != 0)
			{
			}
			num = (short)1774452736;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
