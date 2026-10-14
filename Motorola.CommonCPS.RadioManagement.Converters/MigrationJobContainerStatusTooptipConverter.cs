using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000058 RID: 88
	public class MigrationJobContainerStatusTooptipConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600010B RID: 267 RVA: 0x0000EA60 File Offset: 0x0000CC60
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num;
			if ((int)value <= 0)
			{
				num = (short)1478049077;
				short num2 = num;
				num = (short)1014250805;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)343015424;
					if (num != 0)
					{
					}
					num = (short)1830617089;
					if (num != 0)
					{
					}
					return global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_JOB_PERFORM;
				}
			}
			num = (short)264699904;
			short num3 = num;
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_JOB_FAILED, (int)value);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000EB34 File Offset: 0x0000CD34
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1179373833;
			short num2 = num;
			num = (short)699977993;
			switch (num2 == num)
			{
			}
			num = (short)1264189441;
			if (num != 0)
			{
			}
			num = (short)1357119488;
			if (num != 0)
			{
			}
			num = (short)2033909760;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
