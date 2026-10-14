using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpBusinessLayer;
using AcpCommonLib;

namespace ConstraintHelper
{
	// Token: 0x020005F0 RID: 1520
	public class SRecViewVisibilityConverterForEmptyTbl : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600D0D7 RID: 53463 RVA: 0x00C38DDC File Offset: 0x00C36FDC
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1966211072;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_DF;
				}
				bool flag2;
				for (;;)
				{
					IL_28:
					num = (short)390332417;
					if (num != 0)
					{
					}
					int num3;
					bool flag;
					switch (num2)
					{
					case 0:
						goto IL_36C;
					case 1:
						IL_11F:
						num = (short)1843593231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::AcpBusinessLayer.Recordset recordset;
						if (recordset.Count == 0)
						{
							num = (short)1529544715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_167;
					}
					case 3:
						num3 = 4;
						num = (short)815398921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						flag = bool.Parse(values[num3].ToString());
						goto IL_2EC;
					case 5:
						if (!bool.Parse(values[3].ToString()))
						{
							num = (short)309329923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_72E;
					case 6:
						goto IL_285;
					case 7:
						num = (short)67174433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1856765957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_30A;
					case 10:
						num = (short)962658308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)2077032474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)593887234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (values[0] != null)
						{
							num = (short)586154005;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_167;
					case 14:
						if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1933246465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F4;
					case 15:
						if (values[2] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)347013143;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F4;
					case 16:
					{
						global::AcpBusinessLayer.Recordset recordset;
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator = recordset.TemplateNode.AllFields.GetEnumerator();
						num = (short)1035599897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						num = (short)104595469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)38535185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_167;
					case 19:
						if (values[num3] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1995177991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_285;
					case 20:
						goto IL_30A;
					case 21:
					{
						global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)values[0];
						num = (short)622002200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						if (num3 >= values.Length)
						{
							num = (short)1118568448;
							short num4 = num;
							num = (short)764542976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)848101395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_657;
					case 24:
					{
						global::AcpBusinessLayer.Recordset recordset;
						if (recordset.CanBeEmpty)
						{
							num = (short)1409220620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_167;
					}
					case 25:
						try
						{
							num = (short)1785921537;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)896794627;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_532;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
									if (enumerator.Current.DifferentiatedUserView <= global::AcpCommonLib.AppInfoManager.AppView)
									{
										num = (short)1867776004;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_5E5;
								case 4:
									flag2 = true;
									num = (short)1524498437;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_58B;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2031222784;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1891762178;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_590:
								num = (short)1468399622;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_532:
								goto IL_590;
							}
							IL_58B:
							IL_5E5:
							goto IL_167;
						}
						finally
						{
							num = (short)693698560;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_61D;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)201785346;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_654;
								}
								IL_61D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)976486401;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_654:;
						}
						goto IL_657;
					case 26:
					{
						global::AcpBusinessLayer.Recordset recordset;
						if (recordset.TemplateNode != null)
						{
							num = (short)1567555600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_167;
					}
					case 27:
						if ((global::AcpCommonLib.ApplicationMode)values[1] == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)9961504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F4;
					case 28:
						goto IL_3F4;
					case 29:
						if (!flag2)
						{
							num = (short)1700724744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_72E;
					case 30:
						flag = true;
						goto IL_2EC;
					case 31:
						if (!bool.Parse(values[2].ToString()))
						{
							num = (short)1460142108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_167;
					case 32:
						num = (short)1942814751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (!flag2)
						{
							num = (short)1765277706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)314638366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DF;
					IL_657:
					num = (short)833812527;
					short num5 = num;
					num = (short)352188463;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11F;
					default:
						num = (short)46333952;
						if (num != 0)
						{
						}
						num = (short)2085748763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_167:
					num = (short)350945309;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_285:
					num3++;
					num = (short)1918435348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2EC:
					flag2 = flag;
					num = (short)347275270;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30A:
					num = (short)1110114326;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F4:
					num = (short)488505362;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_36C:
				IL_72E:
				return flag2;
				IL_DF:
				flag2 = false;
				num = (short)2007367694;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600D0D8 RID: 53464 RVA: 0x00C39530 File Offset: 0x00C37730
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)928972800;
			short num2 = num;
			num = (short)1593620779;
			short num3 = num;
			num = (short)832747819;
			switch (num3 == num)
			{
			}
			num = (short)730398720;
			if (num != 0)
			{
			}
			num = (short)521404417;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
