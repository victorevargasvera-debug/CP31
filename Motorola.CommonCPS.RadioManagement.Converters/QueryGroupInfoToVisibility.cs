using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000080 RID: 128
	public class QueryGroupInfoToVisibility : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000184 RID: 388 RVA: 0x000145A0 File Offset: 0x000127A0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)540934146;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)808070448;
					short num3 = num;
					num = (short)1700670768;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_109;
					default:
						goto IL_D6;
					}
					break;
				}
				case 1:
					goto IL_109;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 3:
				{
					num = (short)701366272;
					short num4 = num;
					num = (short)959119361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_35:
				if (value != null)
				{
					num = (short)403898369;
					if (num != 0)
					{
					}
					num = (short)634912771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_138;
				IL_109:
				if (!(value.ToString() == parameter.ToString()))
				{
					goto IL_138;
				}
				num = (short)1617166336;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D6:
			num = (short)1852768256;
			if (num != 0)
			{
			}
			return global::System.Windows.Visibility.Visible;
			IL_138:
			return global::System.Windows.Visibility.Hidden;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000146EC File Offset: 0x000128EC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)422822334;
			short num2 = num;
			num = (short)1723515326;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1243611136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)768081921;
			if (num != 0)
			{
			}
			num = (short)892665856;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
