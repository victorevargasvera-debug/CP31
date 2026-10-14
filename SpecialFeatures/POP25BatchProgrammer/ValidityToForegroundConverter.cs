using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace SpecialFeatures.POP25BatchProgrammer
{
	// Token: 0x020000A2 RID: 162
	public class ValidityToForegroundConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000B2D RID: 2861 RVA: 0x000D5A94 File Offset: 0x000D3C94
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			global::System.Windows.Media.Brush result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (!(bool)value)
					{
						num2 = (short)758513665;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					num2 = (short)1021771777;
					if (num2 != 0)
					{
					}
					result = global::System.Windows.Media.Brushes.Red;
					num2 = (short)182321154;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_116;
				}
				goto IL_1C;
			}
			IL_116:
			return result;
			IL_1C:
			result = global::System.Windows.SystemColors.ControlTextBrush;
			num2 = (short)1482207237;
			short num3 = num2;
			num2 = (short)1701031941;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			default:
			{
				num2 = (short)757399552;
				if (num2 != 0)
				{
				}
				num2 = (short)571473920;
				short num4 = num2;
				num2 = (short)1782972416;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x000D5BBC File Offset: 0x000D3DBC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)977388336;
			short num2 = num;
			num = (short)1745208112;
			switch (num2 == num)
			{
			}
			num = (short)1841299456;
			if (num != 0)
			{
			}
			num = (short)1313800193;
			if (num != 0)
			{
			}
			num = (short)126091264;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
