using System;
using System.Globalization;
using System.Windows.Data;
using AcpASKLib;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000DF RID: 223
	public class SelectedItemConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000D4E RID: 3406 RVA: 0x001181D0 File Offset: 0x001163D0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			bool flag;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (value != null)
						{
							num2 = (short)851050497;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_146;
					case 1:
						num2 = (short)937295874;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (value is global::AcpASKLib.SystemKeyData)
						{
							num2 = (short)1651703808;
							short num3 = num2;
							num2 = (short)626851844;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_146;
					case 3:
						goto IL_6C;
					case 4:
					{
						num2 = (short)1391625621;
						short num4 = num2;
						num2 = (short)1072137621;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1463353344;
							if (num2 != 0)
							{
							}
							num2 = (short)308019201;
							if (num2 != 0)
							{
							}
							flag = true;
							num2 = (short)562954243;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					break;
				}
				IL_24:
				flag = false;
				num2 = (short)712769536;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_6C:
			IL_146:
			return flag;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0011832C File Offset: 0x0011652C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)22806528;
			short num2 = num;
			num = (short)1507860994;
			short num3 = num;
			num = (short)1365516802;
			switch (num3 == num)
			{
			}
			num = (short)1336344577;
			if (num != 0)
			{
			}
			num = (short)626524160;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
