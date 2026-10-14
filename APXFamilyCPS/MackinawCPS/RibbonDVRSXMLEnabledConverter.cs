using System;
using System.Globalization;
using System.Windows.Data;
using AcpCommonLib;

namespace MackinawCPS
{
	// Token: 0x0200001B RID: 27
	public class RibbonDVRSXMLEnabledConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600005F RID: 95 RVA: 0x0000C684 File Offset: 0x0000A884
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			bool flag3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1442096504;
					short num3 = num2;
					num2 = (short)161129848;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_145;
					default:
						num2 = (short)1862270976;
						if (num2 != 0)
						{
						}
						num2 = (short)980615173;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_7D;
				case 2:
					num2 = (short)1174011907;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (values[0] is global::AcpCommonLib.ApplicationMode)
					{
						goto IL_145;
					}
					goto IL_162;
				case 4:
					if (values.Length == 3)
					{
						num2 = (short)1415905282;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_162;
				case 5:
				{
					int num4 = (int)((global::AcpCommonLib.ApplicationMode)values[0]);
					bool flag = (bool)values[1];
					bool flag2 = (bool)values[2];
					if (num4 == 0 && flag && flag2)
					{
						num2 = (short)1434517510;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_162;
				}
				case 6:
					flag3 = true;
					num2 = (short)271908865;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
				IL_145:
				num2 = (short)1442381824;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_7D:
			IL_162:
			num2 = (short)805306368;
			short num5 = num2;
			num2 = (short)330498049;
			if (num2 != 0)
			{
			}
			return flag3;
			IL_2C:
			flag3 = false;
			num2 = (short)422641668;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000C84C File Offset: 0x0000AA4C
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1280770049;
			if (num != 0)
			{
			}
			num = (short)1344394697;
			short num2 = num;
			num = (short)1403311561;
			switch (num2 == num)
			{
			}
			num = (short)1254031360;
			if (num != 0)
			{
			}
			num = (short)1855913984;
			short num3 = num;
			return null;
		}

		// Token: 0x0400002F RID: 47
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
