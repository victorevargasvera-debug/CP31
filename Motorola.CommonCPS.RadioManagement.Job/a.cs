using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Job
{
	// Token: 0x02000005 RID: 5
	internal class a : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000024F0 File Offset: 0x000006F0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)868387510;
			short num2 = num;
			num = (short)1067158198;
			switch (num2 == num)
			{
			}
			num = (short)1380319233;
			if (num != 0)
			{
			}
			num = (short)1766916096;
			short num3 = num;
			num = (short)1277755392;
			if (num != 0)
			{
			}
			return value.ToString() == (string)parameter;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000025AC File Offset: 0x000007AC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 11;
			short num = (short)967376901;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string a;
				switch (num2)
				{
				case 0:
					if (!(a == global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("娚焜猞", a_)))
					{
						num = (short)1411317768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_72;
				case 1:
				{
					num = (short)1331462759;
					short num3 = num;
					num = (short)1161069159;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_92;
					default:
						num = (short)778436608;
						if (num != 0)
						{
						}
						if (!(a == global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("䬚漜瀞䘠儢䐤䨦䐨䈪䌬䠮", a_)))
						{
							num = (short)411959298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED;
					}
					break;
				}
				case 2:
					num = (short)948043779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!(a == global::Motorola.CommonCPS.RadioManagement.Job.ModuleJob.b("吚洜稞匠䈢儤並䘨䔪䰬䌮", a_)))
					{
						num = (short)1155727366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E4;
				case 4:
					goto IL_70;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_53;
					}
					continue;
				case 6:
					num = (short)762970119;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_8D;
				case 8:
					num = (short)468647937;
					if (num != 0)
					{
					}
					num = (short)633208833;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_53:
				if (!(bool)value)
				{
					num = (short)717815812;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_92:
				a = (string)parameter;
				num = (short)2066481152;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_70:
			return null;
			IL_72:
			return global::Motorola.CommonCPS.RadioManagement.Job.FilterOption.All;
			IL_8D:
			return null;
			IL_E4:
			return global::Motorola.CommonCPS.RadioManagement.Job.FilterOption.Operational;
			IL_ED:
			num = (short)1118896128;
			short num4 = num;
			return global::Motorola.CommonCPS.RadioManagement.Job.FilterOption.Programming;
		}
	}
}
