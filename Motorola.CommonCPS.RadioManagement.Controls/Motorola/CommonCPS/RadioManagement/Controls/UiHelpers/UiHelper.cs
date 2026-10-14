using System;
using System.Windows;
using System.Windows.Media;

namespace Motorola.CommonCPS.RadioManagement.Controls.UiHelpers
{
	// Token: 0x0200012C RID: 300
	public static class UiHelper
	{
		// Token: 0x06000948 RID: 2376 RVA: 0x00098EAC File Offset: 0x000970AC
		public static T FindChild<T>(global::System.Windows.DependencyObject dependencyObject) where T : global::System.Windows.DependencyObject
		{
			short num = (short)1777401856;
			switch (num)
			{
			default:
			{
				num = (short)1752694784;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Windows.DependencyObject child;
				T t;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_74;
						}
						continue;
					case 1:
						goto IL_254;
					case 2:
						if (child != null)
						{
							goto IL_FE;
						}
						goto IL_98;
					case 3:
					{
						num = (short)941401415;
						short num3 = num;
						num = (short)690791751;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FE;
						default:
							goto IL_18C;
						}
						break;
					}
					case 4:
						goto IL_11B;
					case 5:
					{
						if (t != null)
						{
							num = (short)1071054856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4;
						num4++;
						num = (short)581500929;
						if (num != 0)
						{
						}
						num = (short)1109458948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						int num4 = 0;
						num = (short)143327242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						int num4;
						if (num4 >= global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(dependencyObject))
						{
							num = (short)982056963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						child = global::System.Windows.Media.VisualTreeHelper.GetChild(dependencyObject, num4);
						num = (short)565444610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						return t;
					case 9:
						num = (short)1608646667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_11B;
					case 11:
						if (child is T)
						{
							num = (short)1458700289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_98;
					}
					IL_74:
					if (dependencyObject != null)
					{
						num = (short)1923809286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_280;
					IL_98:
					t = global::Motorola.CommonCPS.RadioManagement.Controls.UiHelpers.UiHelper.FindChild<T>(child);
					num = (short)546832389;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FE:
					num = (short)835911689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11B:
					num = (short)1615986695;
					num2 = (int)((global::System.IntPtr)num);
				}
				return t;
				IL_18C:
				num = (short)360054784;
				if (num != 0)
				{
				}
				goto IL_280;
				IL_254:
				num = (short)158859264;
				short num5 = num;
				return (T)((object)child);
				IL_280:
				return default(T);
			}
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00099144 File Offset: 0x00097344
		public static T FindChildByName<T>(global::System.Windows.DependencyObject dependencyObject, string name) where T : global::System.Windows.DependencyObject
		{
			global::System.Windows.DependencyObject child;
			T t;
			for (;;)
			{
				IL_00:
				short num = (short)1168113664;
				switch (num)
				{
				default:
				{
					num = (short)75890689;
					if (num != 0)
					{
					}
					num = (short)290652169;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (((global::System.Windows.FrameworkElement)child).Name.Equals(name, global::System.StringComparison.InvariantCultureIgnoreCase))
							{
								num = (short)1188954122;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_192;
						case 1:
							return t;
						case 2:
							goto IL_23F;
						case 3:
							goto IL_1D9;
						case 4:
							if (child is T)
							{
								num = (short)160169992;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_192;
						case 5:
						{
							int num3 = 0;
							num = (short)2064252931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)984481796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_1D9;
						case 8:
							num = (short)1266876416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							switch (0)
							{
							case 0:
								goto IL_A4;
							}
							continue;
						case 10:
							goto IL_28D;
						case 11:
						{
							num = (short)593625088;
							short num4 = num;
							int num3;
							if (num3 >= global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(dependencyObject))
							{
								num = (short)197722114;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							child = global::System.Windows.Media.VisualTreeHelper.GetChild(dependencyObject, num3);
							num = (short)853082125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
						{
							if (t != null)
							{
								num = (short)1571291137;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num3;
							num3++;
							num = (short)2062745607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
							if (child != null)
							{
								num = (short)1509031942;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_192;
						}
						IL_A4:
						if (dependencyObject == null)
						{
							goto IL_2D3;
						}
						num = (short)2005481279;
						short num5 = num;
						num = (short)116602687;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1937899520;
							if (num != 0)
							{
							}
							num = (short)218103813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_192:
						t = global::Motorola.CommonCPS.RadioManagement.Controls.UiHelpers.UiHelper.FindChildByName<T>(child, name);
						num = (short)2123235340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1D9:
						num = (short)1492123659;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			return t;
			IL_23F:
			goto IL_2D3;
			IL_28D:
			return (T)((object)child);
			IL_2D3:
			return default(T);
		}
	}
}
