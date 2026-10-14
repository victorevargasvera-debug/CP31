using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000010 RID: 16
	internal class BoolToSelectionModeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00003E88 File Offset: 0x00002088
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)979435523;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)96075777;
					if (num != 0)
					{
					}
					num = (short)97452033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_127;
				case 2:
					goto IL_10D;
				case 3:
					goto IL_14;
				}
				goto IL_34;
				IL_14:
				switch (0)
				{
				case 0:
					IL_34:
					if (!(bool)value)
					{
						num = (short)1301827551;
						short num3 = num;
						num = (short)2101170143;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
						{
							num = (short)1381629952;
							if (num != 0)
							{
							}
							num = (short)1107689472;
							short num4 = num;
							num = (short)2031550464;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					else
					{
						num = (short)705953794;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_10D:
			global::System.Windows.Controls.SelectionMode selectionMode = global::System.Windows.Controls.SelectionMode.Extended;
			goto IL_12A;
			IL_127:
			selectionMode = global::System.Windows.Controls.SelectionMode.Single;
			IL_12A:
			return selectionMode;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003FC4 File Offset: 0x000021C4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1273616192;
			short num2 = num;
			num = (short)2052118336;
			switch (num2 == num)
			{
			}
			num = (short)1762263040;
			short num3 = num;
			num = (short)1931476993;
			if (num != 0)
			{
			}
			num = (short)524681216;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
