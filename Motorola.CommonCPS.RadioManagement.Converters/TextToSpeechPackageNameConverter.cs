using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x020000A8 RID: 168
	public class TextToSpeechPackageNameConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060001FC RID: 508 RVA: 0x0001AF70 File Offset: 0x00019170
		public object Convert(object[] value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1245773824;
			short num2 = num;
			string empty = string.Empty;
			object obj = value[0];
			if (obj == global::System.Windows.DependencyProperty.UnsetValue)
			{
				num = (short)812470693;
				short num3 = num;
				num = (short)263213477;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1263403008;
					if (num != 0)
					{
					}
					num = (short)1341128705;
					if (num != 0)
					{
					}
					break;
				}
				return string.Empty;
			}
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GenerateTTSGUIName((string)obj);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0001B03C File Offset: 0x0001923C
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1708974313;
			short num2 = num;
			num = (short)22405353;
			switch (num2 == num)
			{
			}
			num = (short)535560192;
			short num3 = num;
			num = (short)260046849;
			if (num != 0)
			{
			}
			num = (short)832045056;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
