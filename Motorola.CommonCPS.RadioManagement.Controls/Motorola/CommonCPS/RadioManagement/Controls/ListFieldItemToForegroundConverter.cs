using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000039 RID: 57
	internal class ListFieldItemToForegroundConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060000AF RID: 175 RVA: 0x0000BD74 File Offset: 0x00009F74
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1088552961;
					if (num2 != 0)
					{
					}
					num2 = (short)920069859;
					short num3 = num2;
					num2 = (short)664348387;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_139;
					default:
						num2 = (short)1722155008;
						if (num2 != 0)
						{
						}
						if (!flag)
						{
							num2 = (short)125829121;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1450246147;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_C8;
				case 2:
					goto IL_131;
				case 3:
					if (!(bool)values[1])
					{
						num2 = (short)31850498;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_139;
				}
				goto IL_20;
			}
			IL_C8:
			return global::System.Windows.Media.Brushes.Gray;
			IL_131:
			num2 = (short)1176502272;
			short num4 = num2;
			return global::System.Windows.Media.Brushes.Red;
			IL_139:
			return global::System.Windows.Media.Brushes.Black;
			IL_20:
			flag = (bool)values[0];
			num2 = (short)771883008;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000BEC0 File Offset: 0x0000A0C0
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)752625992;
			short num2 = num;
			num = (short)1166223688;
			switch (num2 == num)
			{
			}
			num = (short)2048786432;
			short num3 = num;
			num = (short)912523264;
			if (num != 0)
			{
			}
			num = (short)637599745;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
