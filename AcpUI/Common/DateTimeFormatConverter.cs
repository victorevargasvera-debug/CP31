using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace AcpUI.Common
{
	// Token: 0x0200007D RID: 125
	public class DateTimeFormatConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060005E6 RID: 1510 RVA: 0x00078B64 File Offset: 0x00076D64
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 12;
			short num = (short)383647745;
			if (num != 0)
			{
			}
			num = (short)446562304;
			switch (num)
			{
			default:
			{
				num = (short)746979333;
				int num2 = (int)((global::System.IntPtr)num);
				string text;
				global::System.DateTime dateTime2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (text != null)
						{
							num = (short)1776091136;
							short num3 = num;
							num = (short)970588163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AD;
					case 1:
						goto IL_110;
					case 2:
						if (value is long)
						{
							num = (short)1764032516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_207;
					case 3:
						goto IL_1A2;
					case 4:
					{
						long ticks = (long)value;
						global::System.DateTime dateTime = new global::System.DateTime(ticks);
						dateTime2 = dateTime.ToLocalTime();
						text = (parameter as string);
						num = (short)1668284416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_8B;
						}
						continue;
					}
					IL_8B:
					if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
					{
						num = (short)1916615044;
						short num4 = num;
						num = (short)1129658756;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_110;
						default:
							num = (short)199163904;
							if (num != 0)
							{
							}
							num = (short)415760385;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					else
					{
						num = (short)761856002;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_110:
				return string.Empty;
				IL_1A2:
				return string.Format(culture, text, dateTime2);
				IL_1AD:
				return string.Format(culture, global::AcpUI.Common.Utility.c("\ud9a1钣鲥첧캩膫ﶯﾱ馳쾵솷쎹얻麽ꢿ꫁ﻃꯅꗇ량", a_), dateTime2);
				IL_207:
				return value.ToString();
			}
			}
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00078D80 File Offset: 0x00076F80
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 8;
			short num = (short)49520465;
			short num2 = num;
			num = (short)1997184849;
			switch (num2 == num)
			{
			default:
			{
				num = (short)528220160;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)986185729;
			if (num != 0)
			{
			}
			num = (short)1935015936;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException(global::AcpUI.Common.Utility.c("펝얟횡첣즥첧誩슫솭쒯銱\uddb3\udbb5좷횹\ud9bb펽ꖿ곁냃ꏅ곇", a_));
		}
	}
}
