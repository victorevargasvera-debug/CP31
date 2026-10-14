using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000070 RID: 112
	public class PCRSubSystemTypeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000154 RID: 340 RVA: 0x000123BC File Offset: 0x000105BC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)140836864;
			short num2 = num;
			num = (short)1891922517;
			short num3 = num;
			num = (short)1326936661;
			switch (num3 == num)
			{
			}
			num = (short)757661697;
			if (num != 0)
			{
			}
			num = (short)51707904;
			if (num != 0)
			{
			}
			return ((global::Motorola.CommonCPS.Server.CommonDBConstants.PcrSystemSubType?)value).ToResourceString();
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00012474 File Offset: 0x00010674
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)418316288;
			short num2 = num;
			num = (short)1988768674;
			short num3 = num;
			num = (short)1015165858;
			switch (num3 == num)
			{
			}
			num = (short)1702363137;
			if (num != 0)
			{
			}
			num = (short)1887371264;
			if (num != 0)
			{
			}
			return (global::Motorola.CommonCPS.Server.CommonDBConstants.PcrSystemSubType?)value;
		}
	}
}
