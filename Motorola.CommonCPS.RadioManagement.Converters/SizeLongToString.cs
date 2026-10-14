using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000046 RID: 70
	public class SizeLongToString : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x0000B8BC File Offset: 0x00009ABC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 0;
			short num = (short)1835073536;
			short num2 = num;
			num = (short)1083558001;
			short num3 = num;
			num = (short)1950730353;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_C2:
				num = (short)234160130;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)219611136;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_9D;
				}
				break;
			}
			string result;
			for (;;)
			{
				IL_87:
				switch (num4)
				{
				case 0:
					return result;
				case 1:
					if ((long)value >= 0L)
					{
						goto IL_C2;
					}
					result = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Unavailable;
					num = (short)1255735296;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)908328961;
					if (num != 0)
					{
					}
					result = string.Format(global::System.Globalization.NumberFormatInfo.CurrentInfo, global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("郪\uddec헮鿰쏲裴", a_), value);
					num = (short)19005443;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return result;
				}
				goto IL_9D;
			}
			return result;
			IL_9D:
			result = string.Empty;
			num = (short)1336737793;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_87;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000BA20 File Offset: 0x00009C20
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1643608521;
			short num2 = num;
			num = (short)1125611977;
			switch (num2 == num)
			{
			}
			num = (short)1045692416;
			if (num != 0)
			{
			}
			num = (short)1806499840;
			short num3 = num;
			num = (short)866844673;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
