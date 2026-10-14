using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000024 RID: 36
	public class TitleConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00007468 File Offset: 0x00005668
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)982650753;
			short num2 = num;
			num = (short)1014632321;
			string text;
			string text2;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1156120577;
				if (num != 0)
				{
				}
				num = (short)126877696;
				if (num != 0)
				{
				}
				num = (short)1864695808;
				short num3 = num;
				text = (values[0] as string);
				text2 = (values[1] as string);
				if (string.IsNullOrEmpty(text))
				{
					return text2;
				}
				break;
			}
			}
			return string.Format(culture, global::Motorola.CommonCPS.ResourceRepository.Resources.CPS20TITLE_FORMAT_STRING, text, text2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00007540 File Offset: 0x00005740
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1356762272;
			short num2 = num;
			num = (short)1239846048;
			switch (num2 == num)
			{
			}
			num = (short)1079640065;
			if (num != 0)
			{
			}
			num = (short)1510801408;
			if (num != 0)
			{
			}
			num = (short)628621312;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
