using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200007D RID: 125
	public class ProductFamilyToStringConvertor : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600017B RID: 379 RVA: 0x0001400C File Offset: 0x0001220C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1348769812;
			short num2 = num;
			num = (short)259495956;
			switch (num2 == num)
			{
			}
			num = (short)1884160001;
			if (num != 0)
			{
			}
			num = (short)1649213440;
			if (num != 0)
			{
			}
			num = (short)1175257088;
			short num3 = num;
			return ((global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily)value).ToResourceString();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000140C0 File Offset: 0x000122C0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1509228545;
			if (num != 0)
			{
			}
			num = (short)1391486537;
			short num2 = num;
			num = (short)71722569;
			switch (num2 == num)
			{
			}
			num = (short)1645150208;
			if (num != 0)
			{
			}
			num = (short)1536425984;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
