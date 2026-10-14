using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000055 RID: 85
	public class JobTypeToUINameConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000102 RID: 258 RVA: 0x0000E420 File Offset: 0x0000C620
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)641794054;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.CommonDBConstants.JobType jobType;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1846607875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					bool flag = (bool)values[0];
					jobType = (global::Motorola.CommonCPS.Server.CommonDBConstants.JobType)values[1];
					if (flag)
					{
						num = (short)102825991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CD;
				}
				case 2:
					if (jobType == global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Read)
					{
						num = (short)1194917893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CD;
				case 3:
				{
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)629211137;
						if (num != 0)
						{
						}
						num = (short)1818951681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)96204479;
					short num3 = num;
					num = (short)1235089087;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9D;
					default:
						num = (short)762052608;
						if (num != 0)
						{
						}
						num = (short)1684602884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_19A;
				case 5:
					goto IL_9D;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 7:
					num = (short)299892738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_46:
				if (values[0] == global::System.Windows.DependencyProperty.UnsetValue)
				{
					goto IL_1CB;
				}
				num = (short)1274609664;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9D:
			num = (short)1345388544;
			short num4 = num;
			return global::Motorola.CommonCPS.ResourceRepository.Resources.DB_MIGRATION_READ_JOB;
			IL_19A:
			IL_1CB:
			return null;
			IL_1CD:
			return jobType.ToResourceString();
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000E600 File Offset: 0x0000C800
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1731980766;
			short num2 = num;
			num = (short)1062661598;
			switch (num2 == num)
			{
			}
			num = (short)789118976;
			if (num != 0)
			{
			}
			num = (short)1532166145;
			if (num != 0)
			{
			}
			num = (short)456130560;
			short num3 = num;
			return new object[]
			{
				value
			};
		}
	}
}
