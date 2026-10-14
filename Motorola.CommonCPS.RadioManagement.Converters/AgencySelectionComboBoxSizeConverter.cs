using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000003 RID: 3
	public class AgencySelectionComboBoxSizeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)650735513;
			short num2 = num;
			num = (short)1326411673;
			switch (num2 == num)
			{
			}
			num = (short)1493434369;
			if (num != 0)
			{
			}
			num = (short)1930493952;
			if (num != 0)
			{
			}
			num = (short)1550385152;
			short num3 = num;
			return global::System.Convert.ToDouble(value, global::System.Globalization.CultureInfo.InvariantCulture) * global::System.Convert.ToDouble(parameter, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021E4 File Offset: 0x000003E4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)947126273;
			if (num != 0)
			{
			}
			num = (short)1323286587;
			short num2 = num;
			num = (short)656195643;
			switch (num2 == num)
			{
			}
			num = (short)620298240;
			if (num != 0)
			{
			}
			num = (short)1886257152;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
