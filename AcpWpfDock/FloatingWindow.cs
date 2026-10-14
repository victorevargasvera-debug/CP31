using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;

namespace DevComponents.WpfDock
{
	// Token: 0x02000038 RID: 56
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class FloatingWindow : global::System.Windows.Window
	{
		// Token: 0x06000273 RID: 627 RVA: 0x0004089C File Offset: 0x0003EA9C
		static FloatingWindow()
		{
			short num = (short)32206315;
			short num2 = num;
			num = (short)1359113707;
			switch (num2 == num)
			{
			}
			num = (short)1987903488;
			if (num != 0)
			{
			}
			num = (short)1210122240;
			short num3 = num;
			num = (short)883163137;
			if (num != 0)
			{
			}
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfDock.FloatingWindow), global::DevComponents.WpfDock.DockWindow.ActivatedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfDock.FloatingWindow.b));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfDock.FloatingWindow), global::DevComponents.WpfDock.DockWindow.DeactivatedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfDock.FloatingWindow.a));
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00040988 File Offset: 0x0003EB88
		public FloatingWindow()
		{
			base.WindowStyle = global::System.Windows.WindowStyle.ToolWindow;
			base.ShowInTaskbar = false;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000409AC File Offset: 0x0003EBAC
		private static void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)539564724;
			short num2 = num;
			num = (short)405674676;
			switch (num2 == num)
			{
			}
			num = (short)1408040961;
			if (num != 0)
			{
			}
			num = (short)590872576;
			short num3 = num;
			num = (short)1740242944;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfDock.FloatingWindow)A_0).b(A_1.OriginalSource as global::DevComponents.WpfDock.DockWindow);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00040A6C File Offset: 0x0003EC6C
		private void b(global::DevComponents.WpfDock.DockWindow A_0)
		{
			short num = (short)465305602;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.a.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfDock.DockWindow.ActivatedEvent, A_0));
					goto IL_105;
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)283836417;
				if (num != 0)
				{
				}
				if (this.a == null)
				{
					break;
				}
				num = (short)67913938;
				short num3 = num;
				num = (short)2044283090;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)721027072;
					short num4 = num;
					num = (short)484048896;
					if (num != 0)
					{
					}
					num = (short)475660288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_105:
				num = (short)1379860481;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00040B9C File Offset: 0x0003ED9C
		private static void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)774596920;
			short num2 = num;
			num = (short)1131702584;
			switch (num2 == num)
			{
			}
			num = (short)1621950465;
			if (num != 0)
			{
			}
			num = (short)408682496;
			short num3 = num;
			num = (short)1219166208;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfDock.FloatingWindow)A_0).a(A_1.OriginalSource as global::DevComponents.WpfDock.DockWindow);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00040C58 File Offset: 0x0003EE58
		private void a(global::DevComponents.WpfDock.DockWindow A_0)
		{
			short num = (short)811925506;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)994902017;
					if (num != 0)
					{
					}
					this.a.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfDock.DockWindow.DeactivatedEvent, A_0));
					goto IL_108;
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				}
				IL_32:
				if (this.a == null)
				{
					break;
				}
				num = (short)993491432;
				short num3 = num;
				num = (short)294746600;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1997144064;
					if (num != 0)
					{
					}
					num = (short)1585905664;
					short num4 = num;
					num = (short)1864433664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_108:
				num = (short)1148321793;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00040D88 File Offset: 0x0003EF88
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00040E38 File Offset: 0x0003F038
		[global::System.ComponentModel.Browsable(false)]
		public global::DevComponents.WpfDock.DockSite DockSite
		{
			get
			{
				short num = (short)57404568;
				short num2 = num;
				num = (short)1962601624;
				switch (num2 == num)
				{
				}
				num = (short)1299251201;
				if (num != 0)
				{
				}
				num = (short)784531456;
				short num3 = num;
				num = (short)2062024704;
				if (num != 0)
				{
				}
				return this.a;
			}
			internal set
			{
				short num = (short)1683839421;
				short num2 = num;
				num = (short)1058167229;
				switch (num2 == num)
				{
				}
				num = (short)1950613505;
				if (num != 0)
				{
				}
				num = (short)1516306432;
				short num3 = num;
				num = (short)406847488;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00040EE8 File Offset: 0x0003F0E8
		protected override void OnSourceInitialized(global::System.EventArgs e)
		{
			short num = (short)61649063;
			short num2 = num;
			num = (short)91992231;
			switch (num2 == num)
			{
			}
			num = (short)1290862593;
			if (num != 0)
			{
			}
			num = (short)1954676736;
			short num3 = num;
			num = (short)1115488256;
			if (num != 0)
			{
			}
			base.OnSourceInitialized(e);
			global::System.Windows.Interop.HwndSource.FromHwnd(new global::System.Windows.Interop.WindowInteropHelper(this).Handle).AddHook(new global::System.Windows.Interop.HwndSourceHook(this.c));
			this.d = true;
			this.a();
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00040FC8 File Offset: 0x0003F1C8
		private global::System.IntPtr c(global::System.IntPtr A_0, int A_1, global::System.IntPtr A_2, global::System.IntPtr A_3, ref bool A_4)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::System.IntPtr result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1052706540;
					short num3 = num2;
					num2 = (short)1607730924;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_43;
					default:
						num2 = (short)1275985920;
						if (num2 != 0)
						{
						}
						num2 = (short)1324023809;
						if (num2 != 0)
						{
						}
						result = this.b(A_0, A_1, A_2, A_3, ref A_4);
						num2 = (short)494927874;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (A_1 == 274)
					{
						num2 = (short)497942528;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_165;
				case 2:
					goto IL_86;
				case 3:
					result = this.a(A_0, A_1, A_2, A_3, ref A_4);
					num2 = (short)1295843332;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_163;
				case 5:
					goto IL_43;
				}
				goto IL_28;
				IL_43:
				if (A_1 == 163)
				{
					num2 = (short)2044133379;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					num2 = (short)2133131265;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_86:
			IL_163:
			IL_165:
			num2 = (short)1978466304;
			short num4 = num2;
			return result;
			IL_28:
			result = global::System.IntPtr.Zero;
			num2 = (short)2071003141;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00041164 File Offset: 0x0003F364
		private global::System.IntPtr b(global::System.IntPtr A_0, int A_1, global::System.IntPtr A_2, global::System.IntPtr A_3, ref bool A_4)
		{
			short num = (short)464584704;
			switch (num)
			{
			default:
			{
				num = (short)323092481;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::DevComponents.WpfDock.eEventActionSource eEventActionSource;
					global::DevComponents.WpfDock.eEventActionSource actionSource;
					global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
					switch (num2)
					{
					case 0:
						goto IL_39C;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_B5;
						}
						continue;
					case 2:
						goto IL_4AB;
					case 3:
						goto IL_2E9;
					case 4:
						if (eEventActionSource == global::DevComponents.WpfDock.eEventActionSource.Mouse)
						{
							num = (short)125304850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FF;
					case 5:
						num = (short)437649429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1865416705;
						if (num != 0)
						{
						}
						actionSource = global::DevComponents.WpfDock.eEventActionSource.Mouse;
						num = (short)103940113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_415;
					case 8:
						if (dockWindowGroup != null)
						{
							num = (short)11206661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FF;
					case 9:
						num = (short)297074704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (base.Content is global::DevComponents.WpfDock.SplitPanel)
						{
							num = (short)1731133465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FF;
					case 11:
						goto IL_482;
					case 12:
					{
						int num3 = global::DevComponents.WpfDock.j.a(A_3);
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup2 = base.Content as global::DevComponents.WpfDock.DockWindowGroup;
						num = (short)622592022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_22E;
					case 14:
					{
						int num3;
						if (num3 != 0)
						{
							goto IL_109;
						}
						goto IL_1A3;
					}
					case 15:
						num = (short)1104543763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup2;
						if (dockWindowGroup2.SelectedDockWindow == null)
						{
							num = (short)1183842317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E7;
					}
					case 17:
					{
						int num4;
						if (num4 != 0)
						{
							num = (short)159645711;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_415;
					}
					case 18:
						this.c = true;
						base.CaptureMouse();
						A_4 = true;
						num = (short)1922957315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						int num4;
						if (num4 == -1)
						{
							num = (short)1120075783;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_482;
					}
					case 20:
					{
						num = (short)664862720;
						short num5 = num;
						if (A_2 == (global::System.IntPtr)61458)
						{
							num = (short)1553793036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FF;
					}
					case 21:
						if (dockWindowGroup.SelectedDockWindow != null)
						{
							num = (short)1288503302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FF;
					case 22:
					{
						global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup2;
						if (dockWindowGroup2 != null)
						{
							num = (short)2048327689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22E;
					}
					case 23:
					{
						int num3;
						if (num3 == -1)
						{
							num = (short)1552285720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39C;
					}
					case 24:
						goto IL_1A3;
					case 25:
					{
						num = (short)826231833;
						short num6 = num;
						num = (short)1461734425;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_109;
						default:
							num = (short)801964032;
							if (num != 0)
							{
							}
							goto IL_E7;
						}
						break;
					}
					case 26:
					{
						int num4 = global::DevComponents.WpfDock.j.a(A_3);
						dockWindowGroup = (base.Content as global::DevComponents.WpfDock.DockWindowGroup);
						num = (short)1144258568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						num = (short)4915223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B5:
					if (A_2 == (global::System.IntPtr)61536)
					{
						num = (short)481034266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)764346388;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E7:
					eEventActionSource = global::DevComponents.WpfDock.eEventActionSource.Mouse;
					num = (short)1943142414;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_109:
					num = (short)94371867;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A3:
					eEventActionSource = global::DevComponents.WpfDock.eEventActionSource.Keyboard;
					num = (short)384040960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22E:
					num = (short)625606666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39C:
					num = (short)1540947972;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_415:
					actionSource = global::DevComponents.WpfDock.eEventActionSource.Keyboard;
					num = (short)1115226123;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_482:
					dockWindowGroup.SelectedDockWindow.Close(actionSource);
					A_4 = true;
					num = (short)1227489282;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2E9:
				IL_4AB:
				IL_4FF:
				return global::System.IntPtr.Zero;
			}
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00041678 File Offset: 0x0003F878
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1684933609;
			short num2 = num;
			num = (short)1576209385;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1956708352;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1199439873;
			if (num != 0)
			{
			}
			num = (short)10158080;
			if (num != 0)
			{
			}
			this.b = default(global::System.Windows.Point);
			this.c = false;
			base.OnLostMouseCapture(e);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0004173C File Offset: 0x0003F93C
		protected override void OnPreviewMouseUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)106889218;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					IL_5B:
					num = (short)1923022849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)2094399489;
					if (num != 0)
					{
					}
					if (global::System.Windows.Input.Mouse.Captured == this)
					{
						num = (short)1039335427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.c = false;
					num = (short)940572677;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 3:
					base.ReleaseMouseCapture();
					num = (short)1496973316;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_F8;
				case 5:
					goto IL_F8;
				}
				IL_3C:
				if (this.c)
				{
					num = (short)861208576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_F8:
				num = (short)443382942;
				short num3 = num;
				num = (short)1153006750;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_5B;
				case 1:
					goto IL_157;
				}
				break;
			}
			num = (short)1990656000;
			short num4 = num;
			IL_157:
			num = (short)647299072;
			if (num != 0)
			{
			}
			base.OnPreviewMouseUp(e);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000418BC File Offset: 0x0003FABC
		protected override void OnPreviewMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1158610944;
			switch (num)
			{
			default:
			{
				num = (short)310444045;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::DevComponents.WpfDock.DockWindowGroup a_;
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Point position;
						if (global::System.Math.Abs(position.X - this.b.X) <= 0.0)
						{
							num = (short)731774986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D3;
					}
					case 1:
						if (base.Content is global::DevComponents.WpfDock.DockWindowGroup)
						{
							num = (short)1485570052;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)973144075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_281;
					case 3:
						goto IL_17D;
					case 4:
						a_ = (base.Content as global::DevComponents.WpfDock.DockWindowGroup);
						num = (short)1621426190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						try
						{
							num = (short)1517813764;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Windows.UIElement uielement;
									if (uielement is global::DevComponents.WpfDock.DockWindowGroup)
									{
										num = (short)385417224;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)270270464;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)1333133318;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1242628098;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement = enumerator.Current;
									num = (short)185729029;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_36C;
									}
									continue;
								case 5:
								{
									global::System.Windows.UIElement uielement;
									if (uielement.Visibility == global::System.Windows.Visibility.Visible)
									{
										num = (short)1262223361;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_464;
								case 7:
									goto IL_408;
								case 8:
								{
									global::System.Windows.UIElement uielement;
									a_ = (uielement as global::DevComponents.WpfDock.DockWindowGroup);
									num = (short)2000683015;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_40D:
								num = (short)39911427;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_36C:
								goto IL_40D;
							}
							IL_408:
							IL_464:
							goto IL_233;
						}
						finally
						{
							num = (short)1938948096;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_49B;
									}
									continue;
								case 1:
									goto IL_4D0;
								case 2:
									enumerator.Dispose();
									num = (short)4521985;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_49B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1893269506;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4D0:;
						}
						goto IL_4D3;
					case 6:
					{
						num = (short)203948032;
						short num3 = num;
						if (global::DevComponents.WpfDock.i.a(this.b))
						{
							num = (short)1722155016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Point position = e.GetPosition(this);
						num = (short)1189281792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1630273552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						this.b = e.GetPosition(this);
						num = (short)1556086787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_4D3;
					case 10:
						goto IL_581;
					case 11:
						if (base.Content is global::DevComponents.WpfDock.SplitPanel)
						{
							num = (short)1441857553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_233;
					case 12:
						num = (short)1092616198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						switch (0)
						{
						case 0:
							goto IL_8C;
						}
						continue;
					case 14:
						goto IL_233;
					case 15:
					{
						global::System.Windows.Point position;
						if (global::System.Math.Abs(position.Y - this.b.Y) > 0.0)
						{
							num = (short)547160073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_586;
					}
					case 16:
						if (this.c)
						{
							num = (short)1426128908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_586;
					case 17:
					{
						num = (short)879654056;
						short num4 = num;
						num = (short)1461417128;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_581;
						default:
						{
							num = (short)1187840000;
							if (num != 0)
							{
							}
							global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator = (base.Content as global::DevComponents.WpfDock.SplitPanel).Children.GetEnumerator();
							num = (short)262930437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					IL_8C:
					if (global::System.Windows.Input.Mouse.Captured == this)
					{
						num = (short)2019295239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_233:
					num = (short)1930166273;
					if (num != 0)
					{
					}
					this.a.a(a_, false, global::DevComponents.WpfDock.eEventActionSource.Mouse);
					num = (short)1373831170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D3:
					base.ReleaseMouseCapture();
					a_ = null;
					num = (short)1794375681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_581:
					num = (short)1644298255;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_17D:
				IL_281:
				IL_586:
				base.OnPreviewMouseMove(e);
				return;
			}
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00041E74 File Offset: 0x00040074
		private global::System.IntPtr a(global::System.IntPtr A_0, int A_1, global::System.IntPtr A_2, global::System.IntPtr A_3, ref bool A_4)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!this.a.IsDockingInProgress)
					{
						num2 = (short)1525547010;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B5;
				case 1:
					goto IL_B5;
				case 2:
					this.a.RestoreLastDockPosition(base.Content as global::DevComponents.WpfDock.DockWindowGroup, true, global::DevComponents.WpfDock.eEventActionSource.Mouse);
					num2 = (short)930742273;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
				IL_B5:
				num2 = (short)1551870433;
				short num3 = num2;
				num2 = (short)917350881;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_EA;
				}
			}
			IL_EA:
			num2 = (short)659030017;
			if (num2 != 0)
			{
			}
			num2 = (short)511574016;
			if (num2 != 0)
			{
			}
			return global::System.IntPtr.Zero;
			IL_1C:
			num2 = (short)1202126848;
			short num4 = num2;
			A_4 = true;
			num2 = (short)740425728;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00041FAC File Offset: 0x000401AC
		protected override void OnClosed(global::System.EventArgs e)
		{
			short num = (short)1318715392;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1932001280;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					continue;
				}
				case 1:
					goto IL_9B;
				case 2:
					this.a.a(this);
					num = (short)1189543937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5B:
				if (this.a == null)
				{
					break;
				}
				num = (short)1349124098;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9B:
			num = (short)82914197;
			short num4 = num;
			num = (short)1258761109;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_9B;
			default:
				num = (short)1364262912;
				if (num != 0)
				{
				}
				num = (short)74645505;
				if (num != 0)
				{
				}
				base.OnClosed(e);
				return;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000283 RID: 643 RVA: 0x000420D0 File Offset: 0x000402D0
		// (set) Token: 0x06000284 RID: 644 RVA: 0x00042180 File Offset: 0x00040380
		internal bool CanClose
		{
			get
			{
				short num = (short)1550177313;
				short num2 = num;
				num = (short)576574497;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1774714880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1058406401;
				if (num != 0)
				{
				}
				num = (short)2010447872;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1551106049;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)829747511;
					short num3 = num;
					num = (short)1638199607;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1838022656;
						if (num != 0)
						{
						}
						num = (short)1448017921;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							this.e = value;
							num = (short)1565261826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_A9;
							}
							continue;
						case 2:
							if (this.d)
							{
								num = (short)1290141699;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 3:
							goto IL_CE;
						case 4:
							return;
						}
						IL_A9:
						if (this.e != value)
						{
							num = (short)1358692352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_CE:
					num = (short)615645184;
					short num4 = num;
					this.a();
					num = (short)476905476;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000422E8 File Offset: 0x000404E8
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_46;
			}
			short num;
			int num3;
			global::System.IntPtr handle;
			for (;;)
			{
				IL_0A:
				num = (short)1620443136;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (handle == global::System.IntPtr.Zero)
					{
						num = (short)333905922;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8A;
				case 1:
				{
					num = (short)1332723276;
					short num4 = num;
					num = (short)450149964;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8A;
					default:
						goto IL_D8;
					}
					break;
				}
				case 2:
					return;
				}
				goto IL_46;
				IL_8A:
				num = (short)121241601;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_D8:
			num = (short)1403387905;
			if (num != 0)
			{
			}
			num = (short)1764294656;
			if (num != 0)
			{
			}
			global::System.IntPtr systemMenu = global::DevComponents.WpfDock.j.GetSystemMenu(handle, false);
			uint a_;
			if (this.e)
			{
				a_ = 0U;
			}
			else
			{
				a_ = 1U;
			}
			global::DevComponents.WpfDock.j.EnableMenuItem(systemMenu, 61536U, a_);
			return;
			IL_46:
			handle = new global::System.Windows.Interop.WindowInteropHelper(this).Handle;
			num = (short)966852608;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04000195 RID: 405
		private global::DevComponents.WpfDock.DockSite a;

		// Token: 0x04000196 RID: 406
		private global::System.Windows.Point b;

		// Token: 0x04000197 RID: 407
		private bool c;

		// Token: 0x04000198 RID: 408
		private bool d;

		// Token: 0x04000199 RID: 409
		private bool e;
	}
}
