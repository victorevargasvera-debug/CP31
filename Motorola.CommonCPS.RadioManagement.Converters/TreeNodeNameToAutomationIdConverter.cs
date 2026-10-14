using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000025 RID: 37
	public class TreeNodeNameToAutomationIdConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000071 RID: 113 RVA: 0x00007600 File Offset: 0x00005800
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					if (text != null)
					{
						num2 = (short)1163526146;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1293313173;
					short num3 = num2;
					num2 = (short)874931349;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F9;
					default:
					{
						num2 = (short)98304000;
						if (num2 != 0)
						{
						}
						num2 = (short)2134441984;
						short num4 = num2;
						num2 = (short)1691484161;
						if (num2 != 0)
						{
						}
						num2 = (short)347865089;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_F9;
				case 2:
					goto IL_115;
				}
				goto IL_25;
			}
			IL_F9:
			return null;
			IL_115:
			return text.Substring(0, text.Contains(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("웻", a_)) ? text.IndexOf(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("웻", a_), global::System.StringComparison.InvariantCulture) : text.Length);
			IL_25:
			text = (value as string);
			num2 = (short)1785331712;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00007760 File Offset: 0x00005960
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1702100993;
			if (num != 0)
			{
			}
			num = (short)2001554200;
			short num2 = num;
			num = (short)1393445656;
			switch (num2 == num)
			{
			}
			num = (short)1446707200;
			if (num != 0)
			{
			}
			num = (short)1894514688;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
