using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000048 RID: 72
	public class BoolToThicknessConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000DA RID: 218 RVA: 0x0000BE24 File Offset: 0x0000A024
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)905462220;
			short num2 = num;
			num = (short)586301900;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_DD:
				num = (short)265158657;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1612251137;
				if (num != 0)
				{
				}
				num = (short)2108948480;
				if (num != 0)
				{
				}
				num = (short)1563164675;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					num = (short)1943273474;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_F1;
				case 2:
					goto IL_107;
				case 3:
				{
					num = (short)1002110976;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_DA;
					}
					continue;
				}
				case 4:
					if (!(bool)value)
					{
						num = (short)1478098944;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)443416581;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_17A;
				}
				IL_DA:
				if (value == null)
				{
					goto IL_DD;
				}
				num = (short)1074855940;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_F1:
			return new global::System.Windows.Thickness(0.0);
			IL_107:
			global::System.Windows.Thickness thickness = new global::System.Windows.Thickness(0.0);
			goto IL_18A;
			IL_17A:
			thickness = new global::System.Windows.Thickness(1.0);
			IL_18A:
			return thickness;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000BFC0 File Offset: 0x0000A1C0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1235523368;
			short num2 = num;
			num = (short)460035880;
			switch (num2 == num)
			{
			}
			num = (short)832700417;
			if (num != 0)
			{
			}
			num = (short)217382912;
			short num3 = num;
			num = (short)1554579456;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
