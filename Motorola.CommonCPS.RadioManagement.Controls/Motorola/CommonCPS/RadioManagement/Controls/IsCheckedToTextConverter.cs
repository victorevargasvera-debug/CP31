using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200001C RID: 28
	internal class IsCheckedToTextConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00006EEC File Offset: 0x000050EC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2098397187;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_125;
				case 1:
					goto IL_9B;
				case 2:
				{
					if ((bool)value)
					{
						goto IL_130;
					}
					num = (short)859686039;
					short num3 = num;
					num = (short)825869463;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A0;
					default:
						num = (short)1030619136;
						if (num != 0)
						{
						}
						num = (short)71499776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
				{
					num = (short)386793472;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				}
				}
				IL_5D:
				if (value == null)
				{
					num = (short)1955201025;
					if (num != 0)
					{
					}
					num = (short)1517158401;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)173670402;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_9B:
			return string.Empty;
			IL_A0:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.General_No;
			IL_125:
			goto IL_A0;
			IL_130:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.General_Yes;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00007030 File Offset: 0x00005230
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1908539393;
			if (num != 0)
			{
			}
			num = (short)1172236836;
			short num2 = num;
			num = (short)1693903396;
			switch (num2 == num)
			{
			}
			num = (short)535494656;
			if (num != 0)
			{
			}
			num = (short)1419837440;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
