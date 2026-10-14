using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000022 RID: 34
	public class SerialNoToHeaderConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00006ECC File Offset: 0x000050CC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 6;
			short num = (short)1294280210;
			short num2 = num;
			num = (short)1389045266;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E8:
				num = (short)1175912450;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1849425920;
				if (num != 0)
				{
				}
				num = (short)628752385;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_154;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					continue;
				case 2:
					if (parameter.Equals(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("苰蟲铴菶賸裺", a_)))
					{
						num = (short)490733569;
						if (num != 0)
						{
						}
						num = (short)1460404224;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_162;
				case 3:
					goto IL_DA;
				}
				IL_88:
				if (!parameter.Equals(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("韰雲铴菶賸觺飼", a_)))
				{
					goto IL_E8;
				}
				num = (short)813629440;
				short num4 = num;
				num = (short)224198659;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_DA:
			return string.Format(global::Motorola.CommonCPS.ResourceRepository.Resources.CPS2_Activate_Header_Features, value);
			IL_154:
			return string.Format(global::Motorola.CommonCPS.ResourceRepository.Resources.CPS2_Activate_Header_Status, value);
			IL_162:
			return value.ToString();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00007044 File Offset: 0x00005244
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)882114560;
			short num2 = num;
			num = (short)473451328;
			short num3 = num;
			num = (short)601508672;
			switch (num3 == num)
			{
			}
			num = (short)787742721;
			if (num != 0)
			{
			}
			num = (short)1826095104;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
