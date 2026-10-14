using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using CommonResources;

namespace SpecialFeatures.DVRSFiles.List
{
	// Token: 0x02000129 RID: 297
	[global::System.Windows.Data.ValueConversion(typeof(global::SpecialFeatures.DVRSFiles.List.TheDownloadStatuses), typeof(string))]
	public class DownloadStatusesConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000FB1 RID: 4017 RVA: 0x00161B94 File Offset: 0x0015FD94
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_46;
			}
			short num;
			int num3;
			global::SpecialFeatures.DVRSFiles.List.TheDownloadStatuses theDownloadStatuses;
			for (;;)
			{
				IL_0A:
				num = (short)1356005376;
				short num2 = num;
				switch (num3)
				{
				case 0:
					num = (short)187432961;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_120;
				case 2:
					switch (theDownloadStatuses)
					{
					case global::SpecialFeatures.DVRSFiles.List.TheDownloadStatuses.OnServer:
						goto IL_122;
					case global::SpecialFeatures.DVRSFiles.List.TheDownloadStatuses.Downloading:
						goto IL_FC;
					case global::SpecialFeatures.DVRSFiles.List.TheDownloadStatuses.Downloaded:
						goto IL_102;
					default:
					{
						num = (short)1252872735;
						short num4 = num;
						num = (short)1172591135;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_120;
						default:
							num = (short)349241345;
							if (num != 0)
							{
							}
							num = (short)1178992640;
							if (num != 0)
							{
							}
							num = (short)1366884352;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					break;
				}
				goto IL_46;
			}
			IL_FC:
			return global::CommonResources.AppResources.VADownloadStatus_Downloading;
			IL_102:
			return global::CommonResources.AppResources.VADownloadStatus_Downloaded;
			IL_120:
			return string.Empty;
			IL_122:
			return global::CommonResources.AppResources.VADownloadStatus_OnServer;
			IL_46:
			theDownloadStatuses = (global::SpecialFeatures.DVRSFiles.List.TheDownloadStatuses)value;
			num = (short)136642562;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00161CD0 File Offset: 0x0015FED0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::System.DateTime dateTime;
			if (global::System.DateTime.TryParse(value as string, out dateTime))
			{
				short num = (short)1827164357;
				short num2 = num;
				num = (short)313413829;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)270204929;
					if (num != 0)
					{
					}
					num = (short)1744568320;
					if (num != 0)
					{
					}
					num = (short)2072182784;
					short num3 = num;
					break;
				}
				}
				return dateTime;
			}
			return global::System.Windows.DependencyProperty.UnsetValue;
		}
	}
}
