using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ConstraintHelper
{
	// Token: 0x020005F3 RID: 1523
	public class InvertBoolToVisibleConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600D0E0 RID: 53472 RVA: 0x00C39F5C File Offset: 0x00C3815C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num;
			for (;;)
			{
				num = (short)1254227968;
				short num2 = num;
				num = (short)705363969;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_DE;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5E;
						}
						continue;
					case 2:
						goto IL_7A;
					case 3:
						if ((bool)value)
						{
							num = (short)1579679744;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E6;
					}
					IL_5E:
					if (!(value is bool))
					{
						num = (short)1142947842;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1654587395;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_E6:
				num = (short)1561927625;
				short num4 = num;
				num = (short)988225481;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_11B;
				}
			}
			IL_7A:
			return global::System.Windows.DependencyProperty.UnsetValue;
			IL_DE:
			num = (short)1461452801;
			if (num != 0)
			{
			}
			return global::System.Windows.Visibility.Collapsed;
			IL_11B:
			num = (short)1795489792;
			if (num != 0)
			{
			}
			return global::System.Windows.Visibility.Visible;
		}

		// Token: 0x0600D0E1 RID: 53473 RVA: 0x00C3A0A0 File Offset: 0x00C382A0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1680736256;
			short num2 = num;
			num = (short)689817487;
			short num3 = num;
			num = (short)473679759;
			switch (num3 == num)
			{
			}
			num = (short)1524105216;
			if (num != 0)
			{
			}
			num = (short)2009333761;
			if (num != 0)
			{
			}
			throw new global::System.NotSupportedException();
		}
	}
}
