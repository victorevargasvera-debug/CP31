using System;
using System.Globalization;
using System.Windows.Data;
using AcpCommonLib;

namespace MackinawCPS
{
	// Token: 0x02000014 RID: 20
	public class MainMenuEnabledConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600004A RID: 74 RVA: 0x0000B084 File Offset: 0x00009284
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_68;
			}
			int num;
			short num2;
			bool flag5;
			for (;;)
			{
				IL_0A:
				bool flag3;
				bool flag4;
				switch (num)
				{
				case 0:
					num2 = (short)156434452;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
					{
						num2 = (short)1044578322;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)380633094;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (values[2] == null)
					{
						num2 = (short)2127298569;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_170;
				case 3:
				{
					bool flag = (global::AcpCommonLib.ApplicationMode)values[0] != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode;
					bool flag2 = (bool)values[1];
					if (!flag)
					{
						num2 = (short)776667147;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_170;
				}
				case 4:
					goto IL_A9;
				case 5:
					num2 = (short)1646919697;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					flag3 = false;
					goto IL_3A2;
				case 7:
					num2 = (short)1887043585;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (values.Length == 4)
					{
						num2 = (short)110493701;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3BD;
				case 9:
					num2 = (short)61800467;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_26F;
				case 11:
					num2 = (short)1804795917;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_3BB;
				case 13:
					if ((bool)values[1])
					{
						num2 = (short)1777991696;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_170;
				case 14:
					num2 = (short)554434563;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					flag3 = (bool)values[1];
					goto IL_3A2;
				case 16:
				{
					num2 = (short)821838701;
					short num3 = num2;
					num2 = (short)1068974957;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A9;
					default:
						num2 = (short)1739915264;
						if (num2 != 0)
						{
						}
						num2 = (short)1141440514;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 17:
					if (values[0] is global::AcpCommonLib.ApplicationMode)
					{
						num2 = (short)1200357390;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3BD;
				case 18:
					num2 = (short)2100428815;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					flag4 = (values[3] == null);
					goto IL_256;
				case 20:
					if (values[0] is global::AcpCommonLib.ApplicationMode)
					{
						num2 = (short)1566572544;
						short num4 = num2;
						num2 = (short)2143682567;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3BD;
				case 21:
					flag4 = false;
					goto IL_256;
				}
				goto IL_68;
				IL_A9:
				if (values.Length == 2)
				{
					num2 = (short)432078848;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				num2 = (short)445513736;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_170:
				num2 = (short)1100808213;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_256:
				flag5 = flag4;
				num2 = (short)4325386;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3A2:
				flag5 = flag3;
				num2 = (short)793313292;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_26F:
			IL_3BB:
			IL_3BD:
			return flag5;
			IL_68:
			num2 = (short)211877889;
			if (num2 != 0)
			{
			}
			flag5 = true;
			num2 = (short)658964484;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000B454 File Offset: 0x00009654
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1126592687;
			short num2 = num;
			num = (short)355102895;
			switch (num2 == num)
			{
			}
			num = (short)1924792321;
			if (num != 0)
			{
			}
			num = (short)846069760;
			if (num != 0)
			{
			}
			num = (short)2018770944;
			short num3 = num;
			return null;
		}

		// Token: 0x04000028 RID: 40
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
