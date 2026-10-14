using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.RadioLicense
{
	// Token: 0x02000009 RID: 9
	internal class a : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000032 RID: 50 RVA: 0x0000436C File Offset: 0x0000256C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1486453566;
			short num2 = num;
			num = (short)494107454;
			switch (num2 == num)
			{
			}
			num = (short)553844736;
			if (num != 0)
			{
			}
			num = (short)2036662273;
			if (num != 0)
			{
			}
			num = (short)272367616;
			short num3 = num;
			return value.ToString() == (string)parameter;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000442C File Offset: 0x0000262C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 11;
			short num = (short)440860674;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string a;
				switch (num2)
				{
				case 0:
					goto IL_6E;
				case 1:
					num = (short)881262599;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				case 3:
					num = (short)346357766;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1062993928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!(a == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("渮崰弲", a_)))
					{
						goto IL_C6;
					}
					goto IL_70;
				case 6:
					goto IL_8C;
				case 7:
					if (!(a == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("椮吰刲䄴䈶䬸帺丼", a_)))
					{
						num = (short)1873477635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E3;
				case 8:
				{
					num = (short)1146093569;
					if (num != 0)
					{
					}
					if (!(a == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("紮倰圲尴堶䨸", a_)))
					{
						num = (short)286851073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1103971709;
					short num3 = num;
					num = (short)1018447229;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C6;
					default:
						goto IL_14C;
					}
					break;
				}
				}
				IL_52:
				if (!(bool)value)
				{
					num = (short)223477760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				a = (string)parameter;
				num = (short)633798661;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C6:
				num = (short)254541828;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_6E:
			num = (short)1913782272;
			short num4 = num;
			return null;
			IL_70:
			return global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption.All;
			IL_8C:
			return null;
			IL_E3:
			return global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption.Features;
			IL_14C:
			num = (short)81264640;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.RadioLicense.FilterOption.Radios;
		}
	}
}
