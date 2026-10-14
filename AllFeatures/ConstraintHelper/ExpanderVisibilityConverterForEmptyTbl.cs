using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpBusinessLayer;
using AcpCommonLib;

namespace ConstraintHelper
{
	// Token: 0x020005F1 RID: 1521
	public class ExpanderVisibilityConverterForEmptyTbl : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600D0DA RID: 53466 RVA: 0x00C395F4 File Offset: 0x00C377F4
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)553975808;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_D3;
				}
				bool flag;
				bool flag3;
				for (;;)
				{
					IL_27:
					num = (short)344493862;
					short num3 = num;
					num = (short)45846310;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_589;
					default:
					{
						num = (short)1931083776;
						if (num != 0)
						{
						}
						int num4;
						switch (num2)
						{
						case 0:
						{
							bool flag2;
							flag = (flag || flag2);
							num = (short)1346633734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							if (values[num4] != global::System.Windows.DependencyProperty.UnsetValue)
							{
								num = (short)2082144267;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_351;
						case 2:
							goto IL_522;
						case 3:
							num = (short)294846465;
							if (num != 0)
							{
							}
							if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
							{
								num = (short)198967298;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_182;
						case 4:
							goto IL_1BA;
						case 5:
						{
							global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)values[0];
							num = (short)1429995532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							num = (short)1671823360;
							short num5 = num;
							goto IL_351;
						}
						case 7:
							goto IL_589;
						case 8:
							if (values[0] != null)
							{
								num = (short)1194983429;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_182;
						case 9:
						{
							global::AcpBusinessLayer.Recordset recordset;
							if (recordset.Count == 0)
							{
								num = (short)1085210646;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F2;
						}
						case 10:
							goto IL_2B2;
						case 11:
							num = (short)1162149905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							global::AcpBusinessLayer.Recordset recordset;
							if (recordset.CanBeEmpty)
							{
								num = (short)1801715732;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F2;
						}
						case 13:
							goto IL_2B2;
						case 14:
							if (!flag3)
							{
								num = (short)153157636;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag = false;
							num4 = 2;
							num = (short)992477194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							if (num4 >= values.Length)
							{
								num = (short)1314848787;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1990066177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
						{
							global::AcpBusinessLayer.Recordset recordset;
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator = recordset.TemplateNode.AllFields.GetEnumerator();
							num = (short)172228615;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
						{
							bool flag2;
							if (bool.TryParse(values[num4].ToString(), out flag2))
							{
								num = (short)491978752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_351;
						}
						case 18:
						{
							global::AcpBusinessLayer.Recordset recordset;
							if (recordset.TemplateNode != null)
							{
								num = (short)1279328272;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F2;
						}
						case 19:
							goto IL_2ED;
						case 20:
							num = (short)270598153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							goto IL_182;
						case 22:
							num = (short)2113667090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D3;
						IL_2B2:
						num = (short)28573711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2F2:
						flag3 = true;
						num = (short)1714487317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_351:
						num4++;
						num = (short)236126221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_182:
					num = (short)657850382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_589:
					try
					{
						num = (short)589758465;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								flag3 = true;
								num = (short)1014497285;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_3FF;
								}
								continue;
							case 2:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1961820164;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)117047302;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_4B1;
							case 4:
								num = (short)2061828099;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_44D;
							case 6:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
								if (enumerator.Current.DifferentiatedUserView <= global::AcpCommonLib.AppInfoManager.AppView)
								{
									num = (short)832569344;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_401:
							num = (short)168361986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3FF:
							goto IL_401;
						}
						IL_44D:
						IL_4B1:
						goto IL_182;
					}
					finally
					{
						num = (short)798162944;
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
									goto IL_4E8;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1171652610;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_51F;
							}
							IL_4E8:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1834156033;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_51F:;
					}
					IL_522:
					num = (short)199098376;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1BA:
				return false;
				IL_2ED:
				return flag;
				IL_D3:
				flag3 = false;
				num = (short)336723971;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600D0DB RID: 53467 RVA: 0x00C39BAC File Offset: 0x00C37DAC
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)592314368;
			short num2 = num;
			num = (short)377487361;
			if (num != 0)
			{
			}
			num = (short)1355853859;
			short num3 = num;
			num = (short)1545383971;
			switch (num3 == num)
			{
			}
			num = (short)1062928384;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
