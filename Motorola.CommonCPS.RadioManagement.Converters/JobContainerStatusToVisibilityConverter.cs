using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000094 RID: 148
	public class JobContainerStatusToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001C0 RID: 448 RVA: 0x000170F0 File Offset: 0x000152F0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2019688451;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if ((global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus)value == global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.SCHEDULED)
					{
						num = (short)1587871748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_181;
				case 1:
					num = (short)311361536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)983498757;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)768540673;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 4:
				{
					num = (short)1206768081;
					short num3 = num;
					num = (short)1012191697;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_125;
					}
					break;
				}
				case 5:
					if ((global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus)value != global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.RUNNING)
					{
						num = (short)49741825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AD;
				}
				IL_63:
				if ((global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus)value == global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.PENDING)
				{
					break;
				}
				num = (short)323092480;
				short num4 = num;
				num = (short)306905090;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AD:
			return global::System.Windows.Visibility.Visible;
			IL_125:
			num = (short)127860736;
			if (num != 0)
			{
			}
			goto IL_AD;
			IL_181:
			return global::System.Windows.Visibility.Hidden;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00017284 File Offset: 0x00015484
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1433169738;
			short num2 = num;
			num = (short)298872650;
			switch (num2 == num)
			{
			}
			num = (short)809172992;
			short num3 = num;
			num = (short)510853121;
			if (num != 0)
			{
			}
			num = (short)1958543360;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
