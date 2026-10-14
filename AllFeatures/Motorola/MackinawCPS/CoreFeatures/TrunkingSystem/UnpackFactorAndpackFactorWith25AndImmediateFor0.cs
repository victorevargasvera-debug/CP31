using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000073 RID: 115
	public sealed class UnpackFactorAndpackFactorWith25AndImmediateFor0 : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000C76 RID: 3190 RVA: 0x000CEE18 File Offset: 0x000CD018
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)431882241;
			if (num != 0)
			{
			}
			int num2 = (int)value;
			if (num2 == 0)
			{
				for (;;)
				{
					num = (short)1402654944;
					short num3 = num;
					num = (short)1947390176;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_69;
					}
				}
				IL_69:
				num = (short)729546752;
				if (num != 0)
				{
				}
				num = (short)240844800;
				short num4 = num;
				return global::CommonResources.AcgResources.ID_IMMEDIATE;
			}
			return ((double)(num2 * 25)).ToString();
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x000CEEE0 File Offset: 0x000CD0E0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			string text = value.ToString();
			if (text == global::CommonResources.AcgResources.ID_IMMEDIATE)
			{
				short num;
				for (;;)
				{
					num = (short)1387545276;
					short num2 = num;
					num = (short)359416508;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_4F;
					}
				}
				IL_4F:
				num = (short)1169358848;
				if (num != 0)
				{
				}
				num = (short)892469249;
				if (num != 0)
				{
				}
				num = (short)637272064;
				short num3 = num;
				return 0;
			}
			return global::System.Convert.ToInt32(text) / 25;
		}
	}
}
