using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ActionConsolidation
{
	// Token: 0x02000421 RID: 1057
	public sealed class PackUnpackYesNoToTrueFalse : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600910E RID: 37134 RVA: 0x0088DF28 File Offset: 0x0088C128
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			while ((bool)value)
			{
				short num = (short)2111039823;
				short num2 = num;
				num = (short)544139599;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)17891328;
					short num3 = num;
					num = (short)763428865;
					if (num != 0)
					{
					}
					num = (short)728432640;
					if (num != 0)
					{
					}
					return global::CommonResources.AcgResources.ID_YES;
				}
				}
			}
			return global::CommonResources.AcgResources.ID_NO;
		}

		// Token: 0x0600910F RID: 37135 RVA: 0x0088DFEC File Offset: 0x0088C1EC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num;
			while ((string)value == global::CommonResources.AcgResources.ID_YES)
			{
				num = (short)616390753;
				short num2 = num;
				num = (short)1238786145;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)489422848;
					short num3 = num;
					num = (short)1025769472;
					if (num != 0)
					{
					}
					return true;
				}
				}
			}
			num = (short)1536950273;
			if (num != 0)
			{
			}
			return false;
		}
	}
}
