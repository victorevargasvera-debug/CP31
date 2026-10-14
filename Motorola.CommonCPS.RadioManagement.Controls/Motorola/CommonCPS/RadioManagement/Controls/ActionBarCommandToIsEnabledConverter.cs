using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000BC RID: 188
	internal class ActionBarCommandToIsEnabledConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060004D9 RID: 1241 RVA: 0x0004F298 File Offset: 0x0004D498
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1316814849;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1913913344;
				short num3 = num;
				switch (num2)
				{
				case 0:
				{
					num = (short)458686465;
					if (num != 0)
					{
					}
					num = (short)1611898011;
					short num4 = num;
					num = (short)675978395;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_EC;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 2:
					goto IL_11C;
				case 3:
					num = (short)1268252674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5D:
				if (value != null)
				{
					num = (short)925696003;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)2146238464;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_EC:
			num = (short)709361664;
			if (num != 0)
			{
			}
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Collapsed;
			goto IL_11F;
			IL_11C:
			visibility = global::System.Windows.Visibility.Visible;
			IL_11F:
			return visibility;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0004F3CC File Offset: 0x0004D5CC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1298216158;
			short num2 = num;
			num = (short)1210856670;
			switch (num2 == num)
			{
			}
			num = (short)783089665;
			if (num != 0)
			{
			}
			num = (short)1255211008;
			short num3 = num;
			num = (short)2041774080;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
