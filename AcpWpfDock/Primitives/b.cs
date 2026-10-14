using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DevComponents.WpfDock.Primitives
{
	// Token: 0x02000055 RID: 85
	internal class b : global::System.Windows.Controls.Canvas
	{
		// Token: 0x06000317 RID: 791 RVA: 0x0004C9BC File Offset: 0x0004ABBC
		public b()
		{
			base.ClipToBounds = true;
			base.Focusable = true;
			base.FocusVisualStyle = null;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0004C9E4 File Offset: 0x0004ABE4
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)533266432;
			int num2 = (int)((global::System.IntPtr)num);
			global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_89;
					}
					continue;
				case 1:
					this.c().AutoHideOpen = false;
					num = (short)1346109453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)379256854;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return;
				case 4:
					if (global::System.Windows.Input.Keyboard.FocusedElement is global::System.Windows.Controls.ContextMenu)
					{
						num = (short)1384775694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1297809414;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)226820119;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (this.a != null)
					{
						num = (short)522321928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2DD;
				case 7:
					if (global::System.Windows.Input.Keyboard.FocusedElement is global::System.Windows.Controls.ContextMenu)
					{
						num = (short)397148169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_404;
				case 8:
					num = (short)1305542672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_2D8;
				case 10:
					num = (short)228458515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
				{
					global::DevComponents.WpfDock.DockSite dockSite;
					if (dockSite.AutoHidePopupOverlay)
					{
						num = (short)1161232389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2DD;
				}
				case 12:
					dockWindowGroup = this.b();
					num = (short)46333970;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_278;
				case 14:
					goto IL_441;
				case 15:
				{
					if (global::DevComponents.WpfDock.i.a(this))
					{
						goto IL_486;
					}
					num = (short)440954159;
					short num3 = num;
					num = (short)1581935919;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1371734016;
						if (num != 0)
						{
						}
						num = (short)1311768577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 16:
					if (global::System.Windows.Input.Keyboard.FocusedElement is global::System.Windows.Window)
					{
						num = (short)1535180820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2DD;
				case 17:
				{
					num = (short)1706688512;
					short num4 = num;
					num = (short)144900103;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 18:
					if (dockWindowGroup != null)
					{
						num = (short)485228554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_404;
				case 19:
					if (dockWindowGroup.OptionsContextMenu == global::System.Windows.Input.Keyboard.FocusedElement)
					{
						num = (short)575340561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_404;
				case 20:
				{
					global::DevComponents.WpfDock.DockSite dockSite = this.a.GetDockSite();
					num = (short)294453249;
					if (num != 0)
					{
					}
					num = (short)599064600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 21:
					num = (short)151650315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (this.c() != null)
					{
						num = (short)892665868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_486;
				case 23:
				{
					global::DevComponents.WpfDock.DockSite dockSite;
					if (global::System.Windows.Window.GetWindow(dockSite) == global::System.Windows.Input.Keyboard.FocusedElement)
					{
						num = (short)1870921731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2DD;
				}
				case 24:
				{
					global::DevComponents.WpfDock.DockSite dockSite;
					if (dockSite != null)
					{
						num = (short)1841299477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2DD;
				}
				}
				IL_89:
				if (!(bool)e.NewValue)
				{
					num = (short)686030850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_2DD:
				num = (short)264175631;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_404:
				num = (short)39780356;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_278:
			goto IL_486;
			IL_2D8:
			dockWindowGroup.OptionsContextMenu.Closed += this.b;
			return;
			IL_441:
			(global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.Controls.ContextMenu).Closed += this.b;
			return;
			IL_486:
			base.OnIsKeyboardFocusWithinChanged(e);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0004CE80 File Offset: 0x0004B080
		private void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)919476374;
			short num2 = num;
			num = (short)1920145558;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_138:
				if (base.IsKeyboardFocusWithin)
				{
					return;
				}
				num = (short)1506279427;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)2053373952;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_74;
				}
				break;
			}
			global::System.Windows.Controls.ContextMenu contextMenu;
			for (;;)
			{
				IL_56:
				switch (num3)
				{
				case 0:
					goto IL_FB;
				case 1:
					if (contextMenu != null)
					{
						num = (short)563675138;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FB;
				case 2:
					contextMenu.Closed -= this.b;
					num = (short)1698365440;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					base.Focus();
					num = (short)2012741632;
					short num4 = num;
					num = (short)734986245;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_138;
				case 5:
					goto IL_F6;
				}
				goto IL_74;
				IL_FB:
				num = (short)1876557825;
				if (num != 0)
				{
				}
				num = (short)386400260;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_F6:
			return;
			IL_74:
			contextMenu = (A_0 as global::System.Windows.Controls.ContextMenu);
			num = (short)1472266241;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_56;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0004D018 File Offset: 0x0004B218
		public global::DevComponents.WpfDock.DockWindow c()
		{
			short num = (short)371720192;
			short num2 = num;
			num = (short)121297943;
			short num3 = num;
			num = (short)33414167;
			switch (num3 == num)
			{
			}
			num = (short)191365120;
			if (num != 0)
			{
			}
			num = (short)2038431745;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0004D0C8 File Offset: 0x0004B2C8
		public void b(global::DevComponents.WpfDock.DockWindow A_0)
		{
			short num = (short)1360461824;
			short num2 = num;
			num = (short)1764425729;
			if (num != 0)
			{
			}
			num = (short)1114786422;
			short num3 = num;
			num = (short)442583670;
			switch (num3 == num)
			{
			}
			num = (short)165216256;
			if (num != 0)
			{
			}
			this.a = A_0;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0004D17C File Offset: 0x0004B37C
		internal void b(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1104084992;
			short num2 = num;
			num = (short)1637767105;
			short num3 = num;
			num = (short)1178949569;
			switch (num3 == num)
			{
			}
			num = (short)207421441;
			if (num != 0)
			{
			}
			num = (short)40173568;
			if (num != 0)
			{
			}
			this.d();
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0004D22C File Offset: 0x0004B42C
		internal void d()
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_30;
				}
				int num;
				short num2;
				global::DevComponents.WpfDock.Primitives.a a;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_21D;
					case 1:
						if (base.Children.Count > 0)
						{
							num2 = (short)1638858758;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_21F;
					case 2:
						if (a != null)
						{
							num2 = (short)513671171;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_E6;
					case 3:
						a.b().Remove(this);
						num2 = (short)1318125573;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						if (base.Children[0] is global::DevComponents.WpfDock.SplitPanel)
						{
							num2 = (short)1039728647;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_21F;
					case 5:
						goto IL_E6;
					case 6:
						num2 = (short)655360004;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
					{
						global::DevComponents.WpfDock.SplitPanel splitPanel = base.Children[0] as global::DevComponents.WpfDock.SplitPanel;
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup = splitPanel.Children[0] as global::DevComponents.WpfDock.DockWindowGroup;
						dockWindowGroup.SelectedContent = null;
						dockWindowGroup.SelectedContentHeader = null;
						dockWindowGroup.SelectedDockWindow = null;
						splitPanel.Children.Clear();
						num2 = (short)1822425089;
						if (num2 != 0)
						{
						}
						num2 = (short)753270784;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
					IL_E6:
					num2 = (short)1783036344;
					short num3 = num2;
					num2 = (short)1141045688;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num2 = (short)798425088;
						if (num2 != 0)
						{
						}
						num2 = (short)837419009;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				IL_30:
				a = (base.Parent as global::DevComponents.WpfDock.Primitives.a);
				num2 = (short)1011679232;
				short num4 = num2;
				num2 = (short)1174470658;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_21D:
			IL_21F:
			base.Children.Clear();
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0004D464 File Offset: 0x0004B664
		private global::DevComponents.WpfDock.DockWindowGroup b()
		{
			for (;;)
			{
				IL_00:
				short num = (short)1752956928;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					case 1:
						goto IL_15B;
					case 2:
						num = (short)1631518721;
						if (num != 0)
						{
						}
						if (base.Children[0] is global::DevComponents.WpfDock.SplitPanel)
						{
							num = (short)1407778817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_160;
					case 3:
						num = (short)1529282562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_34:
					num = (short)983133584;
					short num3 = num;
					num = (short)163540368;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
					{
						num = (short)1841430528;
						short num4 = num;
						num = (short)1079640064;
						if (num != 0)
						{
						}
						if (base.Children.Count <= 0)
						{
							goto IL_160;
						}
						num = (short)1647837187;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
			IL_15B:
			return (base.Children[0] as global::DevComponents.WpfDock.SplitPanel).Children[0] as global::DevComponents.WpfDock.DockWindowGroup;
			IL_160:
			return null;
		}

		// Token: 0x040001F7 RID: 503
		private global::DevComponents.WpfDock.DockWindow a;
	}
}
