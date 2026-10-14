using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000043 RID: 67
	public class SelectedPasswordPolicyToMaxAttemptsEnable : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000CB RID: 203 RVA: 0x0000B1B0 File Offset: 0x000093B0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)327091313;
			short num2 = num;
			num = (short)3409009;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F1:
				num = (short)156827650;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5E;
			default:
			{
				num = (short)480641024;
				short num4 = num;
				goto IL_5E;
			}
			}
			for (;;)
			{
				IL_B9:
				switch (num3)
				{
				case 0:
					if (value == global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1292173317;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F1;
				case 1:
					num = (short)50921472;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if ((global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy)value == global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy.ReadWrite)
					{
						num = (short)557645828;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16E;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_D7;
					}
					continue;
				case 4:
					goto IL_124;
				case 5:
					goto IL_165;
				}
				IL_D7:
				if (value == null)
				{
					goto IL_126;
				}
				num = (short)1997537281;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_124:
			return true;
			IL_126:
			return false;
			IL_165:
			goto IL_126;
			IL_16E:
			return false;
			IL_5E:
			num = (short)162922496;
			if (num != 0)
			{
			}
			num = (short)47054849;
			if (num != 0)
			{
			}
			num = (short)1263271939;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_B9;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000B334 File Offset: 0x00009534
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)672408866;
			short num2 = num;
			num = (short)1025058082;
			switch (num2 == num)
			{
			}
			num = (short)1729036289;
			if (num != 0)
			{
			}
			num = (short)651624448;
			short num3 = num;
			num = (short)2097545216;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
