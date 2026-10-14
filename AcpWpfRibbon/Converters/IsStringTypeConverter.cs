using System;
using System.Globalization;
using System.Windows.Data;

namespace DevComponents.WpfRibbon.Converters
{
	// Token: 0x020000D6 RID: 214
	[global::System.Windows.Data.ValueConversion(typeof(object), typeof(bool))]
	public class IsStringTypeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060008CB RID: 2251 RVA: 0x000C88EC File Offset: 0x000C6AEC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)544473089;
			if (num != 0)
			{
			}
			if (!(value is string))
			{
				num = (short)797904703;
				short num2 = num;
				num = (short)365301567;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)547684352;
					if (num != 0)
					{
					}
					num = (short)193003520;
					short num3 = num;
					return false;
				}
				}
			}
			return true;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x000C89AC File Offset: 0x000C6BAC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 10;
			short num = (short)632327626;
			short num2 = num;
			num = (short)432573898;
			switch (num2 == num)
			{
			}
			num = (short)1732444160;
			if (num != 0)
			{
			}
			num = (short)2145714177;
			if (num != 0)
			{
			}
			num = (short)1693646848;
			short num3 = num;
			return new global::System.NotSupportedException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("Ⅱୣࡥṧཀྵṫᩭ㉯፱ᝳᵵ塷ᑹ፻੽ꁿﺋ揄뒓몙즟톡蒣얥잧쒩\udaab쮭슯욱톳쒵隷", a_));
		}
	}
}
