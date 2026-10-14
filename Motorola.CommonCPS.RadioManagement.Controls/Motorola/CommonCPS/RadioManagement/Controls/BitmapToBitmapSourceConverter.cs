using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200000E RID: 14
	internal class BitmapToBitmapSourceConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600002A RID: 42 RVA: 0x000037E0 File Offset: 0x000019E0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)951255041;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.IO.MemoryStream memoryStream;
				global::System.Windows.Media.Imaging.BitmapImage bitmapImage;
				switch (num2)
				{
				case 0:
					try
					{
						((global::System.Drawing.Bitmap)value).Save(memoryStream, global::System.Drawing.Imaging.ImageFormat.Png);
						memoryStream.Position = 0L;
						bitmapImage.BeginInit();
						bitmapImage.StreamSource = memoryStream;
						bitmapImage.CacheOption = global::System.Windows.Media.Imaging.BitmapCacheOption.OnLoad;
						bitmapImage.EndInit();
						return bitmapImage;
					}
					finally
					{
						num = (short)42336257;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_13B;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_B9;
								}
								continue;
							case 2:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)1899954176;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_B9:
							num = (short)776787303;
							short num3 = num;
							num = (short)519624039;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_13D;
							default:
								num = (short)1103757312;
								if (num != 0)
								{
								}
								if (memoryStream == null)
								{
									goto IL_13D;
								}
								num = (short)737607682;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						IL_13B:
						IL_13D:;
					}
					goto IL_13E;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					goto IL_4B;
				}
				IL_30:
				if (value == null)
				{
					num = (short)45416450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_13E:
				bitmapImage = new global::System.Windows.Media.Imaging.BitmapImage();
				memoryStream = new global::System.IO.MemoryStream();
				num = (short)1557331968;
				short num4 = num;
				num = (short)1643773953;
				if (num != 0)
				{
				}
				num = (short)110624768;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4B:
			return null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000039BC File Offset: 0x00001BBC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)912799641;
			short num2 = num;
			num = (short)1703294873;
			switch (num2 == num)
			{
			}
			num = (short)2053898240;
			if (num != 0)
			{
			}
			num = (short)1736835073;
			if (num != 0)
			{
			}
			num = (short)25427968;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
