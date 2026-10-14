using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000062 RID: 98
	public class PasswordNullValueConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600012A RID: 298 RVA: 0x000105B4 File Offset: 0x0000E7B4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1578505984;
			short num2 = num;
			num = (short)606410496;
			switch (num2 == num)
			{
			}
			num = (short)404226049;
			if (num != 0)
			{
			}
			num = (short)13565952;
			short num3 = num;
			num = (short)796000256;
			if (num != 0)
			{
			}
			return value;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0001065C File Offset: 0x0000E85C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1431109634;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return value;
				case 1:
				{
					if (value.ToString() == string.Empty)
					{
						goto IL_139;
					}
					num = (short)1311506433;
					if (num != 0)
					{
					}
					num = (short)230227968;
					short num3 = num;
					num = (short)2071165352;
					short num4 = num;
					num = (short)986872232;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1908604928;
						if (num != 0)
						{
						}
						num = (short)1428422659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 3:
					return value;
				}
				IL_35:
				if (value == null)
				{
					num = (short)1771831296;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)879099905;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return value;
			IL_139:
			return null;
		}
	}
}
