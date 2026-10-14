using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000008 RID: 8
	public class BoolToBrushConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002AA8 File Offset: 0x00000CA8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1622999043;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_125;
				case 1:
					goto IL_EA;
				case 2:
					if (!(bool)value)
					{
						num = (short)1472724992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12D;
				case 3:
				{
					num = (short)980615168;
					short num3 = num;
					num = (short)1173898915;
					short num4 = num;
					num = (short)1600145059;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12D;
					default:
						num = (short)848887808;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_AB;
						}
						continue;
					}
					break;
				}
				}
				IL_AB:
				num = (short)882573313;
				if (num != 0)
				{
				}
				if (value == null)
				{
					num = (short)666697729;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1251475458;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_EA:
			return global::System.Windows.Media.Brushes.Transparent;
			IL_125:
			return global::System.Windows.Media.Brushes.Transparent;
			IL_12D:
			return global::System.Windows.Media.Brushes.Red;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002BE8 File Offset: 0x00000DE8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1429044725;
			short num2 = num;
			num = (short)1253801461;
			switch (num2 == num)
			{
			}
			num = (short)840433665;
			if (num != 0)
			{
			}
			num = (short)1629618176;
			if (num != 0)
			{
			}
			num = (short)1992687616;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
