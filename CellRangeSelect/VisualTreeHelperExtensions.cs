using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace Motorola.CommonCPS.UI.CellRangeSelect
{
	// Token: 0x02000011 RID: 17
	public static class VisualTreeHelperExtensions
	{
		// Token: 0x06000093 RID: 147 RVA: 0x0000ACC0 File Offset: 0x00008EC0
		public static T FindParent<T>(global::System.Windows.DependencyObject dependencyObject) where T : class
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::System.Windows.DependencyObject dependencyObject2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1681999521;
					short num3 = num2;
					num2 = (short)1923040929;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1325268992;
						if (num2 != 0)
						{
						}
						num2 = (short)1841758209;
						if (num2 != 0)
						{
						}
						num2 = (short)1682702336;
						short num4 = num2;
						if (!(dependencyObject2 is T))
						{
							goto IL_115;
						}
						break;
					}
					}
					num2 = (short)275775491;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_115;
				case 2:
					num2 = (short)1596653568;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_113;
				case 4:
					if (dependencyObject2 != null)
					{
						num2 = (short)1619853314;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_154;
				}
				goto IL_24;
				IL_115:
				dependencyObject2 = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject2);
				num2 = (short)730791940;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_113:
			IL_154:
			return dependencyObject2 as T;
			IL_24:
			dependencyObject2 = dependencyObject;
			num2 = (short)593428481;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000AE2C File Offset: 0x0000902C
		public static global::System.Collections.Generic.IEnumerable<T> FindChildren<T>(global::System.Windows.DependencyObject dependencyObject) where T : global::System.Windows.DependencyObject
		{
			short num = (short)1105081266;
			short num2 = num;
			num = (short)522924978;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1216217088;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)126287873;
			if (num != 0)
			{
			}
			num = (short)607977472;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions<T>.a a = new global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions<T>.a(-2);
			a.e = dependencyObject;
			return a;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000AEE4 File Offset: 0x000090E4
		public static T FindFirstChild<T, U>(global::System.Windows.DependencyObject dependencyObject) where T : global::System.Windows.DependencyObject
		{
			short num = (short)673579008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerable<T> enumerable;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
						{
							if (enumerable == null)
							{
								num = (short)648934822;
								short num3 = num;
								num = (short)861992358;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_42;
								case 1:
									break;
								default:
								{
									num = (short)254672896;
									short num4 = num;
									break;
								}
								}
								num = (short)16384001;
								if (num != 0)
								{
								}
								num = (short)1152909312;
								if (num != 0)
								{
								}
								num = (short)1533607937;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.IEnumerator<T> enumerator = enumerable.GetEnumerator();
							num = (short)290455554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_10F;
						case 2:
							goto IL_2B6;
						}
						goto IL_3B;
					}
					IL_10F:
					IL_282:
					T result = default(T);
					return result;
					IL_2B6:
					try
					{
						num = (short)1302069251;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::System.Collections.Generic.IEnumerator<T> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1604780033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								T t = enumerator.Current;
								num = (short)3276802;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								num = (short)1939472388;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								T t;
								if (global::System.Windows.Media.VisualTreeHelper.GetChild(t, 0) is U)
								{
									num = (short)295305222;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_157;
								}
								continue;
							case 4:
								goto IL_216;
							case 5:
								goto IL_1A7;
							case 6:
							{
								T t;
								result = t;
								num = (short)1736310789;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_159:
							num = (short)1072037888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_157:
							goto IL_159;
						}
						IL_1A7:
						return result;
						IL_216:
						goto IL_28C;
					}
					finally
					{
						num = (short)1581973504;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<T> enumerator;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_24A;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1085276162;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_27F;
							}
							IL_24A:
							if (enumerator == null)
							{
								break;
							}
							num = (short)707002369;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_27F:;
					}
					goto IL_282;
					IL_28C:
					return default(T);
				}
				}
				IL_3B:
				enumerable = global::Motorola.CommonCPS.UI.CellRangeSelect.VisualTreeHelperExtensions.FindChildren<T>(dependencyObject);
				IL_42:
				num = (short)609746944;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000B1CC File Offset: 0x000093CC
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(26128523 + A_1) + (global::System.IntPtr)52 + (global::System.IntPtr)8 + (global::System.IntPtr)8 + (global::System.IntPtr)47);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_63;
			}
			IL_30:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_63:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_30;
		}
	}
}
