using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace AcpUI.Common
{
	// Token: 0x0200008D RID: 141
	public class SRecViewVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000616 RID: 1558 RVA: 0x0007CCF8 File Offset: 0x0007AEF8
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1345519617;
			if (num != 0)
			{
			}
			num = (short)1303183371;
			int num2 = (int)((global::System.IntPtr)num);
			bool flag;
			for (;;)
			{
				int num4;
				bool flag2;
				switch (num2)
				{
				case 0:
					goto IL_247;
				case 1:
				{
					if (flag)
					{
						num = (short)810876937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)716253296;
					short num3 = num;
					num = (short)1767319664;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_238;
					default:
						num = (short)1545207808;
						if (num != 0)
						{
						}
						num = (short)877199364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_C6;
				case 3:
					goto IL_C6;
				case 4:
					num = (short)1803878412;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!bool.Parse(values[0].ToString()))
					{
						num = (short)1479409678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2DB;
				case 6:
					goto IL_FE;
				case 7:
					if (num4 >= values.Length)
					{
						num = (short)113770502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1836187661;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)932184065;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					flag2 = true;
					goto IL_267;
				case 10:
					goto IL_C1;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_89;
					}
					continue;
				case 12:
					goto IL_238;
				case 13:
					if (values[num4] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)202768392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_247;
				case 14:
					num4 = 1;
					num = (short)225378307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_89:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)376045578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)641662976;
				short num5 = num;
				flag = false;
				num = (short)1052639237;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C6:
				num = (short)1864761351;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_247:
				num4++;
				num = (short)979435522;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_267:
				flag = flag2;
				num = (short)2132410368;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_238:
				flag2 = bool.Parse(values[num4].ToString());
				goto IL_267;
			}
			IL_C1:
			return false;
			IL_FE:
			IL_2DB:
			return flag;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0007CFE8 File Offset: 0x0007B1E8
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)728367105;
			if (num != 0)
			{
			}
			num = (short)1567817728;
			short num2 = num;
			num = (short)906209131;
			short num3 = num;
			num = (short)1538303851;
			switch (num3 == num)
			{
			}
			num = (short)1210646528;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
