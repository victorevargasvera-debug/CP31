using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000007 RID: 7
	public class AstroPcrSystemNameConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002880 File Offset: 0x00000A80
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 11;
			short num = (short)1342570499;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_129;
				case 1:
				{
					num = (short)211615744;
					short num3 = num;
					num = (short)890634242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (value.ToString().Equals(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("藵臷觹裻鯽淿", a_), global::System.StringComparison.OrdinalIgnoreCase))
					{
						goto IL_112;
					}
					goto IL_12E;
				case 3:
				{
					num = (short)1828075142;
					short num4 = num;
					num = (short)1584150150;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_112;
					default:
						num = (short)1613430784;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					}
					break;
				}
				}
				IL_88:
				if (value != null)
				{
					num = (short)1325727745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_12E;
				IL_112:
				num = (short)2075983872;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_129:
			return global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("럵꯷껹껻뇽叿笁眃爅洇有", a_);
			IL_12E:
			num = (short)2143158273;
			if (num != 0)
			{
			}
			return value;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000029E4 File Offset: 0x00000BE4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)41839002;
			short num2 = num;
			num = (short)902523290;
			switch (num2 == num)
			{
			}
			num = (short)1164836865;
			if (num != 0)
			{
			}
			num = (short)1993080832;
			if (num != 0)
			{
			}
			num = (short)1692467200;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
