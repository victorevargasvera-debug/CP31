using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using RFResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000061 RID: 97
	public class PasswordMaxAttemptConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000126 RID: 294 RVA: 0x00010240 File Offset: 0x0000E440
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1777532931;
			int num2 = (int)((global::System.IntPtr)num);
			int num3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (num3 == 255)
					{
						num = (short)318177282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_194;
				case 1:
					if (value == global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)936837125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3 = int.Parse(value.ToString(), global::System.Globalization.CultureInfo.CurrentCulture);
					num = (short)1516240896;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_CD;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
				{
					num = (short)24842840;
					short num4 = num;
					num = (short)1391727192;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D2;
					default:
					{
						num = (short)1392705536;
						short num5 = num;
						num = (short)616693760;
						if (num != 0)
						{
						}
						num = (short)2063073281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 5:
					goto IL_188;
				}
				IL_3C:
				if (value == null)
				{
					goto IL_D2;
				}
				num = (short)1180631041;
				if (num != 0)
				{
				}
				num = (short)738000900;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CD:
			return this.a();
			IL_D2:
			return "";
			IL_188:
			goto IL_D2;
			IL_194:
			return num3.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000103F0 File Offset: 0x0000E5F0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value.ToString() == this.a())
			{
				short num = (short)1391662981;
				short num2 = num;
				num = (short)138549125;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B4;
				case 1:
					break;
				default:
				{
					num = (short)723582976;
					short num3 = num;
					break;
				}
				}
				num = (short)860618753;
				if (num != 0)
				{
				}
				num = (short)1404108800;
				if (num != 0)
				{
				}
				IL_B4:
				return 255;
			}
			return int.Parse(value.ToString(), global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000104D4 File Offset: 0x0000E6D4
		private string a()
		{
			int a_ = 2;
			short num = (short)943838207;
			short num2 = num;
			num = (short)150983679;
			switch (num2 == num)
			{
			}
			num = (short)1221525505;
			if (num != 0)
			{
			}
			num = (short)1840316416;
			short num3 = num;
			num = (short)1502806016;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("\udfec\udaee쓰폲\ud8f4ퟶ", a_) + global::RFResourceRepository.RFResources.INFINITE_SYMBOL;
		}
	}
}
