using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200001B RID: 27
	internal class FieldsToIsValidConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00006B28 File Offset: 0x00004D28
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)709033984;
			switch (num)
			{
			default:
			{
				num = (short)377094144;
				short num2 = num;
				num = (short)1444347911;
				int num3 = (int)((global::System.IntPtr)num);
				bool flag3;
				bool flag4;
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_278;
					case 1:
						num = (short)1073020938;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_180;
					case 3:
						goto IL_2DA;
					case 4:
					{
						bool flag;
						bool flag2;
						if (!flag && flag2)
						{
							num = (short)590479362;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_182;
					}
					case 5:
					{
						bool flag;
						if (flag)
						{
							num = (short)355794957;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_148;
					}
					case 6:
					{
						bool flag = (bool)values[0];
						flag3 = (bool)values[1];
						bool flag2 = (bool)values[2];
						flag4 = (bool)values[3];
						num = (short)63504396;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					case 8:
						goto IL_146;
					case 9:
					{
						bool flag2;
						if (!flag2)
						{
							num = (short)723320832;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_148;
					}
					case 10:
						if (values.Length == 0)
						{
							num = (short)1112670216;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1930297355;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						num = (short)1439445708;
						short num4 = num;
						num = (short)184562380;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2DF;
						default:
							num = (short)1430061057;
							if (num != 0)
							{
							}
							num = (short)1936130048;
							if (num != 0)
							{
							}
							if (values.Length == 4)
							{
								num = (short)314376198;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2DF;
						}
						break;
					}
					case 12:
					{
						bool flag;
						bool flag2;
						if (flag && flag2)
						{
							num = (short)593690627;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)175636485;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						num = (short)913309705;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A5:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1879113729;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_148:
					num = (short)1404567556;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_102:
				return false;
				IL_146:
				goto IL_102;
				IL_180:
				return flag4;
				IL_182:
				return false;
				IL_278:
				return flag3;
				IL_2DA:
				return flag3 && flag4;
				IL_2DF:
				bool flag5 = (bool)values[1];
				return flag5;
			}
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006E28 File Offset: 0x00005028
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1340637411;
			short num2 = num;
			num = (short)1888125155;
			switch (num2 == num)
			{
			}
			num = (short)169148417;
			if (num != 0)
			{
			}
			num = (short)1987837952;
			if (num != 0)
			{
			}
			num = (short)1949696000;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
