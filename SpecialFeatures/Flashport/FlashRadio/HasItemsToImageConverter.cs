using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000E0 RID: 224
	public class HasItemsToImageConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000D51 RID: 3409 RVA: 0x001183D8 File Offset: 0x001165D8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			int num;
			short num2;
			global::System.Windows.Media.Imaging.BitmapImage bitmapImage;
			for (;;)
			{
				IL_13:
				string uriString;
				switch (num)
				{
				case 0:
				{
					num2 = (short)952107008;
					short num3 = num2;
					uriString = null;
					num2 = (short)881328130;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					num2 = (short)721289223;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if ((bool)value)
					{
						num2 = (short)403439624;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					uriString = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뾏솑ﮗﶛ잡얣튥\udda7\ud8a9즫\uddad讯\udbb3\udbb5좷햹튻\udbbd꺿뛁꿅ꯇꗉꋋ뷍ￏ럑ꛓꓕ럗꣙럝菟跡", a_);
					num2 = (short)2092171267;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_14A;
				case 4:
					if (value != null)
					{
						num2 = (short)814415873;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return bitmapImage;
				case 5:
					goto IL_14A;
				case 6:
					return bitmapImage;
				case 7:
				{
					num2 = (short)1890023968;
					short num4 = num2;
					num2 = (short)1989966368;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A6;
					default:
						num2 = (short)2083782656;
						if (num2 != 0)
						{
						}
						if (value is bool)
						{
							num2 = (short)1942487040;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return bitmapImage;
					}
					break;
				}
				case 8:
					uriString = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뾏솑ﮗﶛ잡얣튥\udda7\ud8a9즫\uddad讯\udbb3\udbb5좷햹튻\udbbd꺿뛁꿅ꯇꗉꋋ뷍ￏꗑ뗓ꓕ뛗동닛망컟诡蟣觥", a_);
					goto IL_A6;
				}
				goto IL_3D;
				IL_A6:
				num2 = (short)1034223621;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_14A:
				num2 = (short)433651713;
				if (num2 != 0)
				{
				}
				bitmapImage = new global::System.Windows.Media.Imaging.BitmapImage();
				bitmapImage.BeginInit();
				bitmapImage.UriSource = new global::System.Uri(uriString, global::System.UriKind.RelativeOrAbsolute);
				bitmapImage.DecodePixelWidth = 16;
				bitmapImage.EndInit();
				num2 = (short)179634182;
				num = (int)((global::System.IntPtr)num2);
			}
			return bitmapImage;
			IL_3D:
			bitmapImage = null;
			num2 = (short)1979449348;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x00118604 File Offset: 0x00116804
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)665911296;
			short num2 = num;
			num = (short)480837730;
			short num3 = num;
			num = (short)1243283554;
			switch (num3 == num)
			{
			}
			num = (short)1551106048;
			if (num != 0)
			{
			}
			num = (short)882769921;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
