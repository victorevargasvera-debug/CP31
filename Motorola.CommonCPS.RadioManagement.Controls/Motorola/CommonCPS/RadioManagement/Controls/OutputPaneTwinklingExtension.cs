using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Animation;
using Infragistics.Windows.DockManager;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000074 RID: 116
	public static class OutputPaneTwinklingExtension
	{
		// Token: 0x06000267 RID: 615 RVA: 0x000286C4 File Offset: 0x000268C4
		public static void TwinkingPaneTabItem(this global::Infragistics.Windows.DockManager.ContentPane pane, bool v)
		{
			short num = (short)1340604419;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					global::Infragistics.Windows.DockManager.PaneTabItem paneTabItem;
					if (paneTabItem != null)
					{
						num = (short)1305083908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 2:
				{
					global::Infragistics.Windows.DockManager.PaneTabItem paneTabItem = global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.b[pane];
					num = (short)767950849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 4:
				{
					num = (short)1813861706;
					short num3 = num;
					num = (short)1504073034;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1588461569;
						if (num != 0)
						{
						}
						num = (short)1571356672;
						if (num != 0)
						{
						}
						global::Infragistics.Windows.DockManager.PaneTabItem paneTabItem;
						global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.a(paneTabItem, v);
						num = (short)194969600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				IL_3A:
				if (!global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.b.ContainsKey(pane))
				{
					break;
				}
				num = (short)657457152;
				short num4 = num;
				num = (short)998572034;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00028838 File Offset: 0x00026A38
		static OutputPaneTwinklingExtension()
		{
			int a_ = 18;
			short num = (short)1726396643;
			short num2 = num;
			num = (short)461224163;
			switch (num2 == num)
			{
			}
			num = (short)397279233;
			if (num != 0)
			{
			}
			num = (short)1114898432;
			if (num != 0)
			{
			}
			num = (short)136249344;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.IsRegisterTwinklingForContentPaneProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udfabﲭ햯햱\uddb3억첷\udfb9캻랿ꯁ꫃귅꓇ꏉꋋ꧍雏뷑ꛓ闕럗듙꣛믝軟雡듣蟥蛧迩", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension), new global::System.Windows.UIPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.OnIsRegisterTwinklingForContentPaneChanged)));
			global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.b = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DockManager.ContentPane, global::Infragistics.Windows.DockManager.PaneTabItem>();
			global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.a = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DockManager.PaneTabItem, global::System.Windows.Media.Animation.Storyboard>();
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00028944 File Offset: 0x00026B44
		private static global::System.Windows.Media.Animation.Storyboard a(global::Infragistics.Windows.DockManager.PaneTabItem A_0)
		{
			int a_ = 6;
			short num = (short)1367408640;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				global::System.Windows.Media.Animation.Storyboard storyboard;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.a.ContainsKey(A_0))
						{
							num = (short)515637250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_208;
					case 1:
					{
						string name = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캝솟첡솣즧좩\udaad햯\udfb1", a_) + A_0.GetHashCode().ToString();
						global::System.Windows.NameScope.SetNameScope(A_0, new global::System.Windows.NameScope());
						A_0.RegisterName(name, A_0);
						global::System.Windows.Duration duration = new global::System.Windows.Duration(global::System.TimeSpan.FromSeconds(1.0));
						global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation(0.2, 1.0, duration);
						global::System.Windows.Media.Animation.Storyboard.SetTargetProperty(doubleAnimation, new global::System.Windows.PropertyPath(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("톝킟쎡잣쾥\udca7펩", a_), global::System.Array.Empty<object>()));
						global::System.Windows.Media.Animation.Storyboard.SetTargetName(doubleAnimation, name);
						storyboard = new global::System.Windows.Media.Animation.Storyboard();
						storyboard.AutoReverse = true;
						storyboard.RepeatBehavior = global::System.Windows.Media.Animation.RepeatBehavior.Forever;
						storyboard.Children.Add(doubleAnimation);
						global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.a.Add(A_0, storyboard);
						num = (short)972685316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						storyboard = global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.a[A_0];
						num = (short)2005991427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_208;
					case 4:
						goto IL_206;
					case 5:
						if (storyboard == null)
						{
							num = (short)635502593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return storyboard;
					}
					break;
					IL_208:
					num = (short)722862085;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_50:
				storyboard = null;
				num = (short)69337089;
				if (num != 0)
				{
				}
				num = (short)1691760726;
				short num3 = num;
				num = (short)2109683798;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_206:
					return storyboard;
				case 1:
					break;
				default:
				{
					num = (short)564461568;
					short num4 = num;
					break;
				}
				}
				num = (short)392429568;
				if (num != 0)
				{
				}
				num = (short)1681326080;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00028BBC File Offset: 0x00026DBC
		private static void a(global::Infragistics.Windows.DockManager.PaneTabItem A_0, bool A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::System.Windows.Media.Animation.Storyboard storyboard;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_159;
				case 1:
					if (storyboard != null)
					{
						num2 = (short)1829502979;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					goto IL_119;
				case 3:
					num2 = (short)1151401988;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					if (A_1)
					{
						num2 = (short)1462829056;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					storyboard.Stop(A_0);
					num2 = (short)2135889328;
					short num3 = num2;
					num2 = (short)8852912;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_119;
					default:
						num2 = (short)431292417;
						if (num2 != 0)
						{
						}
						num2 = (short)1773993984;
						if (num2 != 0)
						{
						}
						num2 = (short)831979522;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
			}
			IL_119:
			return;
			IL_159:
			storyboard.Begin(A_0, true);
			return;
			IL_24:
			num2 = (short)586809344;
			short num4 = num2;
			storyboard = global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.a(A_0);
			num2 = (short)385286145;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00028D24 File Offset: 0x00026F24
		public static bool GetIsRegisterTwinklingForContentPane(global::System.Windows.DependencyObject obj)
		{
			short num = (short)861669950;
			short num2 = num;
			num = (short)1807813182;
			switch (num2 == num)
			{
			}
			num = (short)1566834688;
			short num3 = num;
			num = (short)753139712;
			if (num != 0)
			{
			}
			num = (short)1932722177;
			if (num != 0)
			{
			}
			return (bool)obj.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.IsRegisterTwinklingForContentPaneProperty);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00028DE0 File Offset: 0x00026FE0
		public static void SetIsRegisterTwinklingForContentPane(global::System.Windows.DependencyObject obj, bool value)
		{
			short num = (short)292409926;
			short num2 = num;
			num = (short)1748685382;
			switch (num2 == num)
			{
			}
			num = (short)2045902848;
			short num3 = num;
			num = (short)1520566273;
			if (num != 0)
			{
			}
			num = (short)2015690752;
			if (num != 0)
			{
			}
			obj.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.IsRegisterTwinklingForContentPaneProperty, value);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00028E9C File Offset: 0x0002709C
		private static void OnIsRegisterTwinklingForContentPaneChanged(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1280376832;
			short num2 = num;
			num = (short)990773252;
			int num3 = (int)((global::System.IntPtr)num);
			global::Infragistics.Windows.DockManager.PaneTabItem paneTabItem;
			global::Infragistics.Windows.DockManager.ContentPane pane;
			for (;;)
			{
				num = (short)589218857;
				short num4 = num;
				num = (short)762692649;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)951451648;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_105;
					case 1:
						paneTabItem = (global::Infragistics.Windows.DockManager.PaneTabItem)A_0;
						pane = paneTabItem.Pane;
						num = (short)165412864;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (A_0 is global::Infragistics.Windows.DockManager.PaneTabItem)
						{
							num = (short)1009909761;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_120;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_B8;
						}
						continue;
					case 5:
						num = (short)1540423682;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					}
					IL_B8:
					if (A_0 != null)
					{
						num = (short)2003501061;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_105:
				if (pane != null)
				{
					num = (short)430112771;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					paneTabItem.Loaded += global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.a;
					num = (short)1458503681;
					if (num != 0)
					{
					}
					num = (short)388235270;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			IL_120:
			global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.a(pane, paneTabItem);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0002905C File Offset: 0x0002725C
		private static void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)881332306;
			short num2 = num;
			num = (short)828313682;
			switch (num2 == num)
			{
			}
			num = (short)1752301568;
			short num3 = num;
			num = (short)1354498049;
			if (num != 0)
			{
			}
			num = (short)2113142784;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.DockManager.PaneTabItem paneTabItem = (global::Infragistics.Windows.DockManager.PaneTabItem)A_0;
			paneTabItem.Loaded -= global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.a;
			global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.a(paneTabItem.Pane, paneTabItem);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0002912C File Offset: 0x0002732C
		private static void a(global::Infragistics.Windows.DockManager.ContentPane A_0, global::Infragistics.Windows.DockManager.PaneTabItem A_1)
		{
			short num = (short)901251076;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)872677377;
					if (num != 0)
					{
					}
					num = (short)1361830755;
					short num3 = num;
					num = (short)38462307;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_166;
					default:
					{
						num = (short)1030553600;
						if (num != 0)
						{
						}
						num = (short)1201930240;
						short num4 = num;
						num = (short)1499725827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_12E;
				case 2:
					if (global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.b.ContainsKey(A_0))
					{
						num = (short)1498808321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_173;
				case 3:
					if (A_1 == null)
					{
						num = (short)1380515845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)164298754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 5:
					goto IL_164;
				}
				IL_3C:
				if (A_0 == null)
				{
					return;
				}
				num = (short)1341194240;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_12E:
			goto IL_166;
			IL_164:
			return;
			IL_166:
			global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.b[A_0] = A_1;
			return;
			IL_173:
			global::Motorola.CommonCPS.RadioManagement.Controls.OutputPaneTwinklingExtension.b.Add(A_0, A_1);
		}

		// Token: 0x040000B7 RID: 183
		private static global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DockManager.PaneTabItem, global::System.Windows.Media.Animation.Storyboard> a;

		// Token: 0x040000B8 RID: 184
		public static readonly global::System.Windows.DependencyProperty IsRegisterTwinklingForContentPaneProperty;

		// Token: 0x040000B9 RID: 185
		private static global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DockManager.ContentPane, global::Infragistics.Windows.DockManager.PaneTabItem> b;
	}
}
