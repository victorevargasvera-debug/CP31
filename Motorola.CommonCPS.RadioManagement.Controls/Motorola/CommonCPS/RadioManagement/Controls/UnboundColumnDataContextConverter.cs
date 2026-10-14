using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000031 RID: 49
	internal class UnboundColumnDataContextConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000096 RID: 150 RVA: 0x0000A4F4 File Offset: 0x000086F4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1960837121;
			if (num != 0)
			{
			}
			num = (short)1143707734;
			short num2 = num;
			num = (short)1031313494;
			switch (num2 == num)
			{
			}
			num = (short)449249280;
			if (num != 0)
			{
			}
			num = (short)789970944;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.Set set = value as global::Motorola.CommonCPS.RadioManagement.UIModels.Set;
			return set.Fields[parameter.ToString()];
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000A5B4 File Offset: 0x000087B4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1225572458;
			short num2 = num;
			num = (short)1355137130;
			switch (num2 == num)
			{
			}
			num = (short)604307457;
			if (num != 0)
			{
			}
			num = (short)529989632;
			if (num != 0)
			{
			}
			num = (short)1750859776;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
