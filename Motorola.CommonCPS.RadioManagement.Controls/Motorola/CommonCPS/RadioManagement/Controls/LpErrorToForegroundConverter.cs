using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000024 RID: 36
	public class LpErrorToForegroundConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600006F RID: 111 RVA: 0x000081C8 File Offset: 0x000063C8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num;
			object red;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_48;
				}
				int num2;
				string value2;
				for (;;)
				{
					IL_0A:
					num = (short)14548993;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						if (!string.IsNullOrEmpty(value2))
						{
							num = (short)1229848578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1737883649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_BB;
					case 2:
						red = global::System.Windows.Media.Brushes.Red;
						num = (short)308150275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_9F;
					}
					goto IL_48;
				}
				IL_9F:
				return red;
				IL_BB:
				goto IL_C0;
				IL_48:
				value2 = (string)value;
				num = (short)267124736;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			catch
			{
			}
			IL_C0:
			num = (short)1927806976;
			short num3 = num;
			num = (short)1640252313;
			short num4 = num;
			num = (short)1691370393;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return red;
			default:
				num = (short)1779695616;
				if (num != 0)
				{
				}
				return global::System.Windows.Media.Brushes.Blue;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00008324 File Offset: 0x00006524
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)795672576;
			short num2 = num;
			num = (short)565952361;
			short num3 = num;
			num = (short)1794097001;
			switch (num3 == num)
			{
			}
			num = (short)573374464;
			if (num != 0)
			{
			}
			num = (short)570163201;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
