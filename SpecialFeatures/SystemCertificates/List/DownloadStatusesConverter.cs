using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using CommonResources;

namespace SpecialFeatures.SystemCertificates.List
{
	// Token: 0x020001A8 RID: 424
	[global::System.Windows.Data.ValueConversion(typeof(global::SpecialFeatures.SystemCertificates.List.TheDownloadStatuses), typeof(string))]
	public class DownloadStatusesConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060013FF RID: 5119 RVA: 0x001CFCBC File Offset: 0x001CDEBC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)709754881;
					if (num2 != 0)
					{
					}
					num2 = (short)1167196162;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					global::SpecialFeatures.SystemCertificates.List.TheDownloadStatuses theDownloadStatuses;
					switch (theDownloadStatuses)
					{
					case global::SpecialFeatures.SystemCertificates.List.TheDownloadStatuses.OnServer:
						goto IL_129;
					case global::SpecialFeatures.SystemCertificates.List.TheDownloadStatuses.Downloading:
						goto IL_102;
					case global::SpecialFeatures.SystemCertificates.List.TheDownloadStatuses.Downloaded:
						goto IL_108;
					default:
						num2 = (short)1071448064;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_127;
				}
				goto IL_1C;
			}
			IL_102:
			return global::CommonResources.AppResources.VADownloadStatus_Downloading;
			IL_108:
			return global::CommonResources.AppResources.VADownloadStatus_Downloaded;
			IL_127:
			return string.Empty;
			IL_129:
			return global::CommonResources.AppResources.VADownloadStatus_OnServer;
			for (;;)
			{
				IL_1C:
				global::SpecialFeatures.SystemCertificates.List.TheDownloadStatuses theDownloadStatuses = (global::SpecialFeatures.SystemCertificates.List.TheDownloadStatuses)value;
				num2 = (short)1503891750;
				short num3 = num2;
				num2 = (short)236163366;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_82;
				}
				break;
			}
			num2 = (short)1558249472;
			short num4 = num2;
			IL_82:
			num2 = (short)1697710080;
			if (num2 != 0)
			{
			}
			num2 = (short)285212673;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x001CFE00 File Offset: 0x001CE000
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::System.DateTime dateTime;
			if (global::System.DateTime.TryParse(value as string, out dateTime))
			{
				short num = (short)46312613;
				short num2 = num;
				num = (short)1482468517;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)189136897;
					if (num != 0)
					{
					}
					num = (short)1725759488;
					short num3 = num;
					num = (short)635109376;
					if (num != 0)
					{
					}
					break;
				}
				}
				return dateTime;
			}
			return global::System.Windows.DependencyProperty.UnsetValue;
		}
	}
}
