using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000E1 RID: 225
	public class HasItemsToMessageConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000D54 RID: 3412 RVA: 0x001186B0 File Offset: 0x001168B0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			string result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)514523137;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)26935296;
					short num3 = num2;
					if ((bool)value)
					{
						num2 = (short)571867142;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::CommonResources.AppResources.No_Advanced_System_Key_loaded;
					num2 = (short)123666439;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_B1;
				case 3:
				{
					num2 = (short)1630985208;
					short num4 = num2;
					num2 = (short)423025656;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B1;
					default:
						num2 = (short)378011648;
						if (num2 != 0)
						{
						}
						if (value != null)
						{
							num2 = (short)557645826;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 4:
					return result;
				case 5:
					num2 = (short)1698824193;
					if (num2 != 0)
					{
					}
					if (value is bool)
					{
						num2 = (short)2072641536;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 6:
					result = global::CommonResources.AppResources.Owner_System_ID_Can_Only_Be_Initialized_Once;
					num2 = (short)637796356;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					return result;
				}
				goto IL_30;
				IL_B1:
				num2 = (short)2069037061;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_30:
			result = null;
			num2 = (short)749666307;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00118884 File Offset: 0x00116A84
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)127205376;
			short num2 = num;
			num = (short)591785091;
			short num3 = num;
			num = (short)1081535619;
			switch (num3 == num)
			{
			}
			num = (short)1857421313;
			if (num != 0)
			{
			}
			num = (short)969539584;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
