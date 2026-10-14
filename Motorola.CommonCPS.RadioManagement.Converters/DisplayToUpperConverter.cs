using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000091 RID: 145
	public class DisplayToUpperConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x000168C8 File Offset: 0x00014AC8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num;
			for (;;)
			{
				num = (short)2162689;
				if (num != 0)
				{
				}
				if (value == null)
				{
					return value;
				}
				num = (short)398069290;
				short num2 = num;
				num = (short)1793265194;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_64;
				}
			}
			IL_64:
			num = (short)1350565888;
			short num3 = num;
			num = (short)231145472;
			if (num != 0)
			{
			}
			return value.ToString().ToUpper(global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0001698C File Offset: 0x00014B8C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)876335997;
			short num2 = num;
			num = (short)2101400445;
			switch (num2 == num)
			{
			}
			num = (short)1052508160;
			short num3 = num;
			num = (short)860880896;
			if (num != 0)
			{
			}
			num = (short)1805189121;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
