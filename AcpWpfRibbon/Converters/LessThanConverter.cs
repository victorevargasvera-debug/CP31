using System;
using System.Globalization;
using System.Windows.Data;

namespace DevComponents.WpfRibbon.Converters
{
	// Token: 0x020000D7 RID: 215
	[global::System.Windows.Data.ValueConversion(typeof(double), typeof(bool), ParameterType = typeof(double))]
	public class LessThanConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060008CE RID: 2254 RVA: 0x000C8A84 File Offset: 0x000C6C84
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 16;
			short num = (short)296288257;
			if (num != 0)
			{
			}
			num = (short)460420195;
			short num2 = num;
			num = (short)1503753315;
			switch (num2 == num)
			{
			}
			num = (short)743047168;
			if (num != 0)
			{
			}
			num = (short)2033582080;
			short num3 = num;
			double num4 = (double)value;
			double num5;
			if (parameter is double)
			{
				num5 = (double)parameter;
			}
			else
			{
				if (!(parameter is string))
				{
					throw new global::System.ArgumentException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㵧ѩὫ᭭oɱ᭳ѵ౷ό᡻幽ﺉﲍ낏ﶗ뒙벛춝햟튡풣즥\udaa7\udea9즫쪭邯펱욳펵颷\udeb9펻쮽ꊿ껁ꇃ꧇꓉꣋ꏏꛑꛓ뿕뛗뷙", a_));
				}
				if (!double.TryParse(parameter.ToString(), out num5))
				{
					throw new global::System.FormatException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᡧ୩ṫ཭ᵯٱᅳѵ塷ᑹ፻੽ꁿꚅﮇﾉﲋﺍﾏﲗ몙햟삡좣쎥袧첩쎫\udcad\uddaf펱삳隵\ud9b7풹\ud8bb麽ꎿꏁ꫃ꣅꟇ뻉곍뗏ꓓ럕꫗꧙맛뫝컟", a_));
				}
			}
			return num4 < num5;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000C8BA0 File Offset: 0x000C6DA0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 6;
			short num = (short)903655455;
			short num2 = num;
			num = (short)921022495;
			switch (num2 == num)
			{
			}
			num = (short)1247805441;
			if (num != 0)
			{
			}
			num = (short)1710424064;
			if (num != 0)
			{
			}
			num = (short)514129920;
			short num3 = num;
			return new global::System.NotSupportedException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᵝཟౡባͥᩧṩ⹫཭፯ᥱ味ᡵ᝷๹屻ൽ慎ﺉ낏뚕肟송쮣좥\udea7쾩\udeab\udaad햯삱骳", a_));
		}
	}
}
