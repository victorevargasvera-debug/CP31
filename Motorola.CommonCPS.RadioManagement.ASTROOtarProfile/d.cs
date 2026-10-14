using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.ASTROOtarProfile
{
	// Token: 0x0200000E RID: 14
	internal class d : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00004F48 File Offset: 0x00003148
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1502674944;
			short num2 = num;
			num = (short)573587577;
			short num3 = num;
			num = (short)516964473;
			switch (num3 == num)
			{
			}
			num = (short)225771521;
			if (num != 0)
			{
			}
			num = (short)1736704000;
			if (num != 0)
			{
			}
			return value.ToString() == (string)parameter;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005008 File Offset: 0x00003208
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 13;
			short num = (short)159514625;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string a;
				switch (num2)
				{
				case 0:
					if (!(a == global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ᅝᑟ͡ᙣ㙥ᩧթ੫ݭᱯ᝱ݳ", a_)))
					{
						num = (short)362479624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_163;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_53;
					}
					continue;
				case 2:
					if (!(a == global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("ౝş١ൣ॥᭧", a_)))
					{
						num = (short)529661957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15A;
				case 3:
					if (!(a == global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.ModuleASTROOtarProfile.b("Ὕ౟๡", a_)))
					{
						goto IL_13E;
					}
					goto IL_E5;
				case 4:
				{
					num = (short)871839774;
					short num3 = num;
					num = (short)1851537438;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13E;
					default:
						goto IL_A6;
					}
					break;
				}
				case 5:
					num = (short)1249837057;
					if (num != 0)
					{
					}
					num = (short)1642790919;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1428815872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_105;
				case 8:
					num = (short)692846594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_53:
				if (!(bool)value)
				{
					num = (short)1071710212;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				a = (string)parameter;
				num = (short)566820867;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13E:
				num = (short)508559366;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A6:
			num = (short)582025216;
			if (num != 0)
			{
			}
			num = (short)1631125504;
			short num4 = num;
			return null;
			IL_E5:
			return global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.FilterOption.All;
			IL_105:
			return null;
			IL_15A:
			return global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.FilterOption.Radios;
			IL_163:
			return global::Motorola.CommonCPS.RadioManagement.ASTROOtarProfile.FilterOption.OtarProfiles;
		}
	}
}
