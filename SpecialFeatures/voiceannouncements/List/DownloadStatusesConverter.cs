using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using CommonResources;

namespace SpecialFeatures.VoiceAnnouncements.List
{
	// Token: 0x02000024 RID: 36
	[global::System.Windows.Data.ValueConversion(typeof(global::SpecialFeatures.VoiceAnnouncements.List.TheDownloadStatuses), typeof(string))]
	public class DownloadStatusesConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600059E RID: 1438 RVA: 0x00052D08 File Offset: 0x00050F08
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::SpecialFeatures.VoiceAnnouncements.List.TheDownloadStatuses theDownloadStatuses;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1738651041;
					short num3 = num2;
					num2 = (short)1678488993;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D2;
					default:
						num2 = (short)1914961920;
						if (num2 != 0)
						{
						}
						switch (theDownloadStatuses)
						{
						case global::SpecialFeatures.VoiceAnnouncements.List.TheDownloadStatuses.OnServer:
							goto IL_122;
						case global::SpecialFeatures.VoiceAnnouncements.List.TheDownloadStatuses.Downloading:
							goto IL_D4;
						case global::SpecialFeatures.VoiceAnnouncements.List.TheDownloadStatuses.Downloaded:
							goto IL_DA;
						default:
							num2 = (short)1473052674;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					break;
				}
				case 1:
					goto IL_120;
				case 2:
					goto IL_D2;
				}
				goto IL_1C;
				IL_D2:
				num2 = (short)1363214336;
				short num4 = num2;
				num2 = (short)533069825;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D4:
			return global::CommonResources.AppResources.VADownloadStatus_Downloading;
			IL_DA:
			return global::CommonResources.AppResources.VADownloadStatus_Downloaded;
			IL_120:
			return string.Empty;
			IL_122:
			return global::CommonResources.AppResources.VADownloadStatus_OnServer;
			IL_1C:
			num2 = (short)1569718273;
			if (num2 != 0)
			{
			}
			theDownloadStatuses = (global::SpecialFeatures.VoiceAnnouncements.List.TheDownloadStatuses)value;
			num2 = (short)438566912;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00052E44 File Offset: 0x00051044
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1668349952;
			short num2 = num;
			num = (short)1675984849;
			short num3 = num;
			num = (short)1377796049;
			global::System.DateTime dateTime;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1381564417;
				if (num != 0)
				{
				}
				num = (short)1433731072;
				if (num != 0)
				{
				}
				if (!global::System.DateTime.TryParse(value as string, out dateTime))
				{
					return global::System.Windows.DependencyProperty.UnsetValue;
				}
				break;
			}
			return dateTime;
		}
	}
}
