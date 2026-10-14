using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200009B RID: 155
	public class DisplayTextConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001D5 RID: 469 RVA: 0x00018544 File Offset: 0x00016744
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			string text;
			string text2;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_72;
				case 1:
					for (;;)
					{
						text = value.ToString();
						text2 = string.Empty;
						num2 = (short)1069215704;
						short num3 = num2;
						num2 = (short)1891561432;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_155;
						}
					}
					IL_155:
					num2 = (short)164691968;
					if (num2 != 0)
					{
					}
					num2 = (short)1238237185;
					if (num2 != 0)
					{
					}
					num2 = (short)1009713154;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_72;
				case 3:
				{
					if (text2.Length >= text.Length)
					{
						num2 = (short)1879048197;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text2 += global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("\ud9f2", a_);
					num2 = (short)1893662720;
					short num4 = num2;
					num2 = (short)1635057664;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (value != null)
					{
						num2 = (short)688455681;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text2;
				case 5:
					return text2;
				}
				goto IL_31;
				IL_72:
				num2 = (short)2062024707;
				num = (int)((global::System.IntPtr)num2);
			}
			return text2;
			IL_31:
			text = string.Empty;
			text2 = string.Empty;
			num2 = (short)1012531204;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00018704 File Offset: 0x00016904
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)373547373;
			short num2 = num;
			num = (short)1696325997;
			switch (num2 == num)
			{
			}
			num = (short)750321664;
			if (num != 0)
			{
			}
			num = (short)959905793;
			if (num != 0)
			{
			}
			num = (short)2120941568;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
