using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace DevComponents.WpfRibbon
{
	// Token: 0x020000A6 RID: 166
	internal class Utility
	{
		// Token: 0x06000836 RID: 2102 RVA: 0x000BF628 File Offset: 0x000BD828
		public static bool ContainsName(global::System.Collections.IEnumerable items, string name)
		{
			short num = (short)1042219008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.IEnumerator enumerator = items.GetEnumerator();
				bool result;
				try
				{
					num = (short)831127560;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_196;
						case 1:
							num = (short)553123840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::System.Windows.FrameworkElement frameworkElement;
							if (frameworkElement != null)
							{
								num = (short)177799175;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							result = true;
							num = (short)1821573126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1234567169;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.FrameworkElement frameworkElement = enumerator.Current as global::System.Windows.FrameworkElement;
							num = (short)1215823874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::System.Windows.FrameworkElement frameworkElement;
							if (frameworkElement.Name == name)
							{
								num = (short)1661140995;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							goto IL_134;
						case 7:
							num = (short)1717370885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							switch (0)
							{
							case 0:
								goto IL_9C;
							}
							continue;
						}
						IL_9E:
						num = (short)866254852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_9C:
						goto IL_9E;
					}
					IL_134:
					goto IL_261;
					IL_196:
					goto IL_26;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_1B8;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_1A5:
						switch (num2)
						{
						case 0:
							goto IL_25E;
						case 1:
							disposable.Dispose();
							num = (short)1574502400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							num = (short)367397358;
							short num3 = num;
							num = (short)145623534;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_25E;
							default:
								num = (short)1629814784;
								if (num != 0)
								{
								}
								if (disposable != null)
								{
									num = (short)1257439233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_260;
							}
							break;
						}
						}
						goto IL_1B8;
					}
					IL_25E:
					IL_260:
					goto EndFinally_7;
					IL_1B8:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)2145189890;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_1A5;
					EndFinally_7:;
				}
				goto IL_261;
				IL_26:
				num = (short)24510465;
				if (num != 0)
				{
				}
				return false;
				IL_261:
				num = (short)2146435072;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x000BF8DC File Offset: 0x000BDADC
		public static int IndexOfName(global::System.Collections.IList items, string name)
		{
			switch (0)
			{
			case 0:
				goto IL_7C;
			}
			short num;
			int num3;
			int num4;
			for (;;)
			{
				IL_0A:
				num = (short)280432711;
				short num2 = num;
				num = (short)377294919;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1555169280;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						num = (short)405340165;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::System.Windows.FrameworkElement frameworkElement;
						if (frameworkElement != null)
						{
							num = (short)331415552;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B;
					}
					case 2:
						goto IL_1C7;
					case 3:
						goto IL_125;
					case 4:
						return -1;
					case 5:
					{
						global::System.Windows.FrameworkElement frameworkElement;
						if (frameworkElement.Name == name)
						{
							num = (short)698810369;
							if (num != 0)
							{
							}
							num = (short)483459074;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B;
					}
					case 6:
						goto IL_13C;
					case 7:
						goto IL_125;
					}
					goto IL_7C;
					IL_9B:
					num4++;
					num = (short)1723531267;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_125:
					num = (short)974979078;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_13C:
				if (num4 >= items.Count)
				{
					num = (short)1379008516;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.Windows.FrameworkElement frameworkElement = items[num4] as global::System.Windows.FrameworkElement;
					num = (short)1169686529;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			return -1;
			IL_1C7:
			num = (short)182452224;
			short num5 = num;
			return num4;
			IL_7C:
			num4 = 0;
			num = (short)1692008455;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000BFAB8 File Offset: 0x000BDCB8
		public static global::System.Windows.FrameworkElement FindByName(global::System.Collections.IEnumerable collection, string name)
		{
			short num = (short)1696858112;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)167182337;
				if (num != 0)
				{
				}
				global::System.Collections.IEnumerator enumerator = collection.GetEnumerator();
				global::System.Windows.FrameworkElement result;
				try
				{
					num = (short)353239057;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.Windows.FrameworkElement frameworkElement;
							if (frameworkElement != null)
							{
								num = (short)1373437959;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
						{
							global::System.Windows.Controls.HeaderedContentControl headeredContentControl;
							global::System.Windows.FrameworkElement frameworkElement2 = global::DevComponents.WpfRibbon.Utility.FindByName(((global::System.Windows.Controls.Panel)headeredContentControl.Content).Children, name);
							num = (short)256311301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::System.Windows.Controls.HeaderedContentControl headeredContentControl;
							if (headeredContentControl.Content is global::System.Windows.Controls.Panel)
							{
								num = (short)629407745;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							global::System.Windows.FrameworkElement frameworkElement3;
							if (frameworkElement3 != null)
							{
								num = (short)886964240;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							goto IL_47E;
						case 5:
						{
							global::System.Windows.FrameworkElement frameworkElement2;
							if (frameworkElement2 != null)
							{
								num = (short)902496286;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							num = (short)177078281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::System.Windows.FrameworkElement frameworkElement;
							result = frameworkElement;
							num = (short)437780508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							global::System.Windows.FrameworkElement frameworkElement4;
							if (frameworkElement4 != null)
							{
								num = (short)1768226838;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
						{
							global::System.Windows.FrameworkElement frameworkElement5;
							if (frameworkElement5.Name == name)
							{
								num = (short)802619415;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_21F;
						}
						case 10:
						{
							global::System.Windows.FrameworkElement frameworkElement5;
							if (frameworkElement5 is global::System.Windows.Controls.HeaderedContentControl)
							{
								num = (short)337051675;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 11:
							goto IL_182;
						case 12:
							num = (short)2000289805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_54E;
						case 14:
						{
							global::System.Windows.FrameworkElement frameworkElement5;
							global::System.Windows.FrameworkElement frameworkElement = global::DevComponents.WpfRibbon.Utility.FindByName(((global::System.Windows.Controls.ItemsControl)frameworkElement5).Items, name);
							num = (short)149291008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							goto IL_1FA;
						case 16:
						{
							global::System.Windows.FrameworkElement frameworkElement3;
							result = frameworkElement3;
							num = (short)521142297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
							switch (0)
							{
							case 0:
								goto IL_11B;
							}
							continue;
						case 18:
						{
							global::System.Windows.Controls.HeaderedContentControl headeredContentControl;
							if (headeredContentControl.Content is global::System.Windows.Controls.ItemsControl)
							{
								num = (short)1411776532;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)159842306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 19:
						{
							global::System.Windows.FrameworkElement frameworkElement5;
							if (frameworkElement5 is global::System.Windows.Controls.Panel)
							{
								num = (short)608239640;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1096089610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 20:
						{
							global::System.Windows.Controls.HeaderedContentControl headeredContentControl;
							global::System.Windows.FrameworkElement frameworkElement4 = global::DevComponents.WpfRibbon.Utility.FindByName(((global::System.Windows.Controls.ItemsControl)headeredContentControl.Content).Items, name);
							num = (short)499974152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)119275532;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.FrameworkElement frameworkElement5 = enumerator.Current as global::System.Windows.FrameworkElement;
							num = (short)1009582106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
						{
							global::System.Windows.FrameworkElement frameworkElement4;
							result = frameworkElement4;
							num = (short)1882259460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
						{
							global::System.Windows.FrameworkElement frameworkElement5;
							result = frameworkElement5;
							num = (short)154992651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
						{
							global::System.Windows.FrameworkElement frameworkElement5;
							global::System.Windows.FrameworkElement frameworkElement3 = global::DevComponents.WpfRibbon.Utility.FindByName(((global::System.Windows.Controls.Panel)frameworkElement5).Children, name);
							num = (short)1012269059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
							goto IL_21A;
						case 26:
						{
							global::System.Windows.FrameworkElement frameworkElement5;
							if (frameworkElement5 != null)
							{
								num = (short)1227227142;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_21F;
						}
						case 27:
						{
							global::System.Windows.FrameworkElement frameworkElement5;
							global::System.Windows.Controls.HeaderedContentControl headeredContentControl = (global::System.Windows.Controls.HeaderedContentControl)frameworkElement5;
							num = (short)1508966418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 28:
							goto IL_4ED;
						case 29:
						{
							global::System.Windows.FrameworkElement frameworkElement5;
							if (frameworkElement5 is global::System.Windows.Controls.ItemsControl)
							{
								num = (short)1252327438;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)289406995;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 30:
						{
							global::System.Windows.FrameworkElement frameworkElement2;
							result = frameworkElement2;
							num = (short)2132344847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_11B;
						IL_21F:
						num = (short)1283325981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2B4:
						num = (short)1042284565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_11B:
						goto IL_2B4;
					}
					IL_182:
					IL_1FA:
					IL_21A:
					IL_47E:
					IL_4ED:
					return result;
					IL_54E:
					goto IL_4D;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_570;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_55D:
						switch (num2)
						{
						case 0:
							goto IL_61A;
						case 1:
							if (disposable != null)
							{
								goto IL_594;
							}
							goto IL_61C;
						case 2:
						{
							num = (short)1141130424;
							short num3 = num;
							num = (short)1993688248;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_594;
							default:
								num = (short)959315968;
								if (num != 0)
								{
								}
								disposable.Dispose();
								num = (short)1928527872;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_570;
						IL_594:
						num = (short)924123138;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_61A:
					IL_61C:
					goto EndFinally_15;
					IL_570:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1686372353;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_55D;
					EndFinally_15:;
				}
				return result;
				IL_4D:
				num = (short)2134769664;
				short num4 = num;
				return null;
			}
			}
		}
	}
}
