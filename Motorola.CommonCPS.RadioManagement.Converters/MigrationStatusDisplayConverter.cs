using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200005E RID: 94
	public class MigrationStatusDisplayConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600011D RID: 285 RVA: 0x0000FA88 File Offset: 0x0000DC88
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			while ((global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus)value != global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.Complete)
			{
				short num = (short)1479352818;
				short num2 = num;
				num = (short)285876722;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1392836608;
					short num3 = num;
					num = (short)1670316032;
					if (num != 0)
					{
					}
					num = (short)169476097;
					if (num != 0)
					{
					}
					return global::Motorola.CommonCPS.ResourceRepository.Resources.DB_Migration_In_Progress;
				}
				}
			}
			return global::Motorola.CommonCPS.ResourceRepository.Resources.DB_Migration_Complete;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000FB44 File Offset: 0x0000DD44
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1055391745;
			if (num != 0)
			{
			}
			num = (short)1148154955;
			short num2 = num;
			num = (short)571831371;
			switch (num2 == num)
			{
			}
			num = (short)1908015104;
			if (num != 0)
			{
			}
			num = (short)871956480;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
