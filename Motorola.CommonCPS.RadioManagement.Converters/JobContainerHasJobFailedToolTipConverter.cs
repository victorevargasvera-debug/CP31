using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000053 RID: 83
	public class JobContainerHasJobFailedToolTipConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000FC RID: 252 RVA: 0x0000E0A4 File Offset: 0x0000C2A4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1319763970;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_128;
				case 1:
					goto IL_C3;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_36;
					}
					continue;
				case 3:
					num = (short)1863385089;
					if (num != 0)
					{
					}
					if (!(bool)value)
					{
						num = (short)26607616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_130;
				}
				IL_36:
				num = (short)209452345;
				short num3 = num;
				num = (short)1128332601;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)743374848;
					if (num != 0)
					{
					}
					if (value == null)
					{
						num = (short)753926144;
						short num4 = num;
						num = (short)769327105;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1191051267;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_C3:
			return string.Empty;
			IL_128:
			return string.Empty;
			IL_130:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobContainerHasJobFailed_ToolTip;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000E1E8 File Offset: 0x0000C3E8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1987837953;
			if (num != 0)
			{
			}
			num = (short)365168134;
			short num2 = num;
			num = (short)598410758;
			switch (num2 == num)
			{
			}
			num = (short)789053440;
			if (num != 0)
			{
			}
			num = (short)751108096;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
