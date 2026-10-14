using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200005C RID: 92
	public class JobContainerProgressSummaryToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000117 RID: 279 RVA: 0x0000F680 File Offset: 0x0000D880
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1926103042;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)871318131;
				short num3 = num;
				num = (short)1171276403;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_133;
				default:
				{
					num = (short)5046272;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_133;
					case 1:
						num = (short)1587216387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					case 3:
						if ((global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus)value == global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.CANCELED)
						{
							num = (short)2076246016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_135;
					}
					IL_7E:
					num = (short)1230503936;
					short num4 = num;
					if ((global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus)value == global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.FAILED)
					{
						goto IL_F3;
					}
					num = (short)962527233;
					if (num != 0)
					{
					}
					num = (short)1303773185;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_F3:
			return global::System.Windows.Visibility.Collapsed;
			IL_133:
			goto IL_F3;
			IL_135:
			return global::System.Windows.Visibility.Visible;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000F7C8 File Offset: 0x0000D9C8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1489906607;
			short num2 = num;
			num = (short)901000111;
			switch (num2 == num)
			{
			}
			num = (short)400293889;
			if (num != 0)
			{
			}
			num = (short)1262354432;
			if (num != 0)
			{
			}
			num = (short)105775104;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
