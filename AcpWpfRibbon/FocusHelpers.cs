using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000050 RID: 80
	internal static class FocusHelpers
	{
		// Token: 0x060003A2 RID: 930 RVA: 0x0004DC18 File Offset: 0x0004BE18
		internal static bool FocusFirstChild(global::System.Windows.Controls.ItemsControl ic)
		{
			short num = (short)2059272193;
			if (num != 0)
			{
			}
			num = (short)1901395968;
			short num2 = num;
			num = (short)1685121851;
			short num3 = num;
			num = (short)613804859;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)401473536;
				if (num != 0)
				{
				}
				num = (short)913702912;
				int num4 = (int)num;
				switch (num4)
				{
				default:
				{
					global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)ic.Items).GetEnumerator();
					bool result;
					try
					{
						num = (short)1030356994;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								goto IL_2A5;
							case 1:
							{
								global::System.Windows.UIElement uielement;
								result = uielement.Focus();
								num = (short)53936131;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_127;
								}
								continue;
							case 3:
								goto IL_149;
							case 4:
								num = (short)1208025093;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::System.Windows.UIElement uielement;
								if (uielement.IsVisible)
								{
									num = (short)477364233;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
							{
								global::System.Windows.UIElement uielement;
								if (uielement != null)
								{
									num = (short)1866661892;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 7:
								num = (short)596836352;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								global::System.Windows.UIElement uielement;
								if (uielement.IsEnabled)
								{
									num = (short)8650762;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 9:
								num = (short)2052587528;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								num = (short)46727180;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1500053511;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Windows.UIElement uielement = enumerator.Current as global::System.Windows.UIElement;
								num = (short)745144326;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 12:
							{
								global::System.Windows.UIElement uielement;
								if (uielement.Focusable)
								{
									num = (short)1858666497;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_1D3:
							num = (short)1416036363;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_127:
							goto IL_1D3;
						}
						IL_149:
						return result;
						IL_2A5:
						break;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_2C7;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_2B4:
							switch (num4)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)789053442;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_31A;
							case 1:
								goto IL_318;
							case 2:
								disposable.Dispose();
								num = (short)922091521;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C7;
						}
						IL_318:
						IL_31A:
						goto EndFinally_9;
						IL_2C7:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1572864;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_2B4;
						EndFinally_9:;
					}
					return result;
				}
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0004DF60 File Offset: 0x0004C160
		internal static bool FocusFirstChild(global::System.Windows.Controls.Panel p)
		{
			short num = (short)708902913;
			if (num != 0)
			{
			}
			num = (short)1727791104;
			short num2 = num;
			num = (short)1660361416;
			short num3 = num;
			num = (short)1781340872;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2123038720;
				if (num != 0)
				{
				}
				num = (short)129499136;
				int num4 = (int)num;
				switch (num4)
				{
				default:
				{
					global::System.Collections.IEnumerator enumerator = p.Children.GetEnumerator();
					bool result;
					try
					{
						num = (short)369426433;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
							{
								global::System.Windows.UIElement uielement;
								if (uielement.IsVisible)
								{
									num = (short)1704067082;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_11A;
								}
								continue;
							case 2:
								num = (short)468189187;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_255;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1714356226;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
								num = (short)1993932800;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
							{
								global::System.Windows.UIElement uielement;
								if (uielement.IsEnabled)
								{
									num = (short)1959067655;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
							{
								global::System.Windows.UIElement uielement;
								if (uielement.Focusable)
								{
									num = (short)1055784968;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 7:
								num = (short)1362034694;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								global::System.Windows.UIElement uielement;
								result = uielement.Focus();
								num = (short)354811913;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								goto IL_1BB;
							case 10:
								num = (short)362545157;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_11C:
							num = (short)719585284;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_11A:
							goto IL_11C;
						}
						IL_1BB:
						return result;
						IL_255:
						break;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_277;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_264:
							switch (num4)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)1068564482;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2CE;
							case 1:
								goto IL_2CC;
							case 2:
								disposable.Dispose();
								num = (short)1613496321;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_277;
						}
						IL_2CC:
						IL_2CE:
						goto EndFinally_8;
						IL_277:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)2087845888;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_264;
						EndFinally_8:;
					}
					return result;
				}
				}
				break;
			}
			}
			return false;
		}
	}
}
