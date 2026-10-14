using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200006A RID: 106
	internal class ParentPopupControlImpl
	{
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000502 RID: 1282 RVA: 0x0006C1D8 File Offset: 0x0006A3D8
		// (remove) Token: 0x06000503 RID: 1283 RVA: 0x0006C308 File Offset: 0x0006A508
		internal event global::System.EventHandler InternalMenuModeChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler eventHandler2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1370005090;
						short num3 = num2;
						num2 = (short)1813945954;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_DD;
						default:
							num2 = (short)2146238464;
							if (num2 != 0)
							{
							}
							num2 = (short)806813697;
							if (num2 != 0)
							{
							}
							goto IL_A9;
						}
						break;
					}
					case 1:
						goto IL_DD;
					case 2:
						return;
					}
					goto IL_1C;
					IL_A9:
					global::System.EventHandler eventHandler = eventHandler2;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler, value);
					eventHandler2 = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.InternalMenuModeChanged, value2, eventHandler);
					num2 = (short)168427521;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_DD:
					if (eventHandler2 != eventHandler)
					{
						goto IL_A9;
					}
					num2 = (short)1987248128;
					short num4 = num2;
					num2 = (short)335609858;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				eventHandler2 = this.InternalMenuModeChanged;
				num2 = (short)396689408;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler eventHandler2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1571495821;
						short num3 = num2;
						num2 = (short)28450701;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_DE;
						default:
							num2 = (short)875298816;
							if (num2 != 0)
							{
							}
							goto IL_A9;
						}
						break;
					}
					case 1:
						goto IL_DE;
					case 2:
						return;
					}
					goto IL_1C;
					IL_A9:
					global::System.EventHandler eventHandler = eventHandler2;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler, value);
					eventHandler2 = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.InternalMenuModeChanged, value2, eventHandler);
					num2 = (short)1356529665;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_DE:
					if (eventHandler2 != eventHandler)
					{
						goto IL_A9;
					}
					num2 = (short)1048313856;
					short num4 = num2;
					num2 = (short)1148977154;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				num2 = (short)164036609;
				if (num2 != 0)
				{
				}
				eventHandler2 = this.InternalMenuModeChanged;
				num2 = (short)928186368;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0006C43C File Offset: 0x0006A63C
		public ParentPopupControlImpl(global::System.Windows.FrameworkElement parent)
		{
			this.m_Parent = parent;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0006C458 File Offset: 0x0006A658
		public static void OnButtonDropDownPreviewClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			global::DevComponents.WpfRibbon.IPopupParentControl popupParentControl;
			short num2;
			global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (popupParentControl.IsPopupMode)
					{
						num2 = (short)1949696009;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					goto IL_1B6;
				case 2:
				{
					num2 = (short)416350208;
					short num3 = num2;
					e.Handled = true;
					num2 = (short)1980825606;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (!buttonDropDown.StaysOpenOnClick)
					{
						num2 = (short)1754005505;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					if (!global::DevComponents.WpfRibbon.ParentPopupControlImpl.IsOnPopup(popupParentControl as global::System.Windows.UIElement))
					{
						num2 = (short)863895554;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					if (buttonDropDown != null)
					{
						num2 = (short)332922887;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
					return;
				case 7:
					num2 = (short)587595779;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (popupParentControl != null)
					{
						num2 = (short)77791242;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 9:
					num2 = (short)1892220929;
					if (num2 != 0)
					{
					}
					popupParentControl.IsPopupMode = false;
					num2 = (short)652017668;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
				{
					num2 = (short)1650612731;
					short num4 = num2;
					num2 = (short)622352891;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B6;
					default:
						num2 = (short)208863232;
						if (num2 != 0)
						{
						}
						num2 = (short)1539899392;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_3C;
				IL_1B6:
				num2 = (short)1795227656;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_3C:
			popupParentControl = (global::DevComponents.WpfRibbon.IPopupParentControl)sender;
			buttonDropDown = (e.OriginalSource as global::DevComponents.WpfRibbon.ButtonDropDown);
			num2 = (short)954073093;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0006C6A0 File Offset: 0x0006A8A0
		public void ClosePopupOnMouseEvent(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)883163147;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)308281356;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)947519488;
					short num3 = num;
					num = (short)1891500033;
					if (num != 0)
					{
					}
					global::System.Windows.FrameworkElement frameworkElement = e.OriginalSource as global::System.Windows.FrameworkElement;
					global::System.Windows.FrameworkElement captureElement = this.CaptureElement;
					num = (short)2094792713;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					num = (short)1281556487;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					global::System.Windows.FrameworkElement frameworkElement;
					global::System.Windows.FrameworkElement captureElement;
					if (frameworkElement != captureElement)
					{
						num = (short)1530200074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_146;
				}
				case 4:
					goto IL_28F;
				case 5:
					num = (short)2095644687;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)167116803;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (e.ChangedButton == global::System.Windows.Input.MouseButton.Right)
					{
						num = (short)1841561604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					IL_23B:
					goto IL_146;
				case 9:
				{
					global::System.Windows.FrameworkElement frameworkElement;
					if (frameworkElement != null)
					{
						num = (short)1071316998;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 10:
					num = (short)1501691917;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_69;
					}
					continue;
				case 12:
				{
					global::System.Windows.FrameworkElement frameworkElement;
					if (frameworkElement.TemplatedParent is global::DevComponents.WpfRibbon.BasePopupControl)
					{
						num = (short)2093875208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 13:
				{
					global::System.Windows.FrameworkElement frameworkElement;
					global::System.Windows.FrameworkElement captureElement;
					if (frameworkElement.TemplatedParent != captureElement)
					{
						num = (short)1657339904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_146;
				}
				case 14:
					return;
				case 15:
					if (e.ChangedButton != global::System.Windows.Input.MouseButton.Left)
					{
						num = (short)1304821762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_28F;
				case 16:
					if (this.IsPopupMode)
					{
						num = (short)1007091713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_69:
				if (!e.Handled)
				{
					num = (short)583598085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_146:
				this.IsPopupMode = false;
				e.Handled = true;
				num = (short)2058848408;
				short num4 = num;
				num = (short)1601144984;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_23B;
				default:
					num = (short)1783889920;
					if (num != 0)
					{
					}
					num = (short)1336410126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_28F:
				num = (short)2031681552;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0006C9C8 File Offset: 0x0006ABC8
		public static void OnLostMouseCapture(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)917569536;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_13A;
				}
				global::DevComponents.WpfRibbon.IPopupParentControl popupParentControl;
				global::DevComponents.WpfRibbon.BasePopupControl basePopupControl;
				global::DevComponents.WpfRibbon.BasePopupControl basePopupControl2;
				for (;;)
				{
					IL_27:
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
					switch (num2)
					{
					case 0:
						goto IL_2F7;
					case 1:
						if (global::System.Windows.Input.Mouse.Captured is global::System.Windows.FrameworkElement)
						{
							num = (short)1519124528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A64;
					case 2:
						IL_752:
						if (!global::DevComponents.WpfRibbon.ParentPopupControlImpl.IsVisualDescendant(popupParentControl as global::System.Windows.DependencyObject, global::System.Windows.Input.Mouse.Captured as global::System.Windows.DependencyObject))
						{
							num = (short)354484271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						num = (short)1183055912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (e.OriginalSource is global::System.Windows.FrameworkElement)
						{
							num = (short)139264026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E7;
					case 5:
						if (global::System.Windows.Input.Mouse.Captured != popupParentControl)
						{
							num = (short)1623326781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						goto IL_27B;
					case 7:
						num = (short)1225654286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						return;
					case 9:
						return;
					case 10:
						num = (short)138805275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)655491117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)843644978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_AE9;
					case 14:
						if (buttonDropDown.IsPopupOpen)
						{
							num = (short)254345241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_280;
					case 15:
						if ((buttonDropDown = global::DevComponents.WpfRibbon.ParentPopupControlImpl.FindButtonDropDown(e.OriginalSource as global::System.Windows.FrameworkElement)) != null)
						{
							num = (short)1826488327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_280;
					case 16:
						num = (short)112132131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (!global::DevComponents.WpfRibbon.ParentPopupControlImpl.IsChildOf(((global::DevComponents.WpfRibbon.Ribbon)popupParentControl).SelectedItem as global::System.Windows.UIElement, global::System.Windows.Input.Mouse.Captured as global::System.Windows.UIElement))
						{
							num = (short)586612760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 18:
						if (global::System.Windows.Input.Mouse.Captured != null)
						{
							num = (short)979501076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_528;
					case 19:
						num = (short)41877508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)1065549826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)794624017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (buttonDropDown.IsPopupOpen)
						{
							num = (short)1987903527;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61F;
					case 23:
						num = (short)1327628337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_306;
					case 25:
						basePopupControl = global::DevComponents.WpfRibbon.ParentPopupControlImpl.GetBasePopupControl(buttonDropDown);
						num = (short)894632002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)835911739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (global::DevComponents.WpfRibbon.ParentPopupControlImpl.IsLogicalDescendant(popupParentControl as global::System.Windows.DependencyObject, e.OriginalSource as global::System.Windows.DependencyObject))
						{
							num = (short)283181109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1536950310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						return;
					case 29:
						num = (short)1355546639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						num = (short)460521494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (global::System.Windows.Input.Mouse.Captured == null)
						{
							num = (short)2013134885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_280;
					case 32:
						if (((global::DevComponents.WpfRibbon.Ribbon)popupParentControl).IsRibbonMenuOpen)
						{
							num = (short)1205993493;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_306;
					case 33:
						num = (short)1722220576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)2029780993;
						if (num != 0)
						{
						}
						if (global::System.Windows.Input.Mouse.Captured is global::System.Windows.Controls.ContextMenu)
						{
							num = (short)1871839255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8F0;
					case 35:
						if (!((global::DevComponents.WpfRibbon.Ribbon)popupParentControl).IsRibbonMenuOpen)
						{
							num = (short)1579876404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_85B;
					case 36:
					{
						num = (short)210501632;
						short num3 = num;
						num = (short)1513881662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						num = (short)219480108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (global::System.Windows.Input.Mouse.Captured == null)
						{
							num = (short)1185677331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E7;
					case 39:
						return;
					case 40:
						if (popupParentControl is global::DevComponents.WpfRibbon.Ribbon)
						{
							num = (short)487325712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6B6;
					case 41:
						if (buttonDropDown != null)
						{
							num = (short)817168414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61F;
					case 42:
						num = (short)1426915392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (((global::System.Windows.FrameworkElement)global::System.Windows.Input.Mouse.Captured).TemplatedParent is global::DevComponents.WpfRibbon.ButtonDropDown)
						{
							num = (short)814088228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A64;
					case 44:
						if (e.OriginalSource is global::System.Windows.FrameworkElement)
						{
							num = (short)1669791773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_280;
					case 45:
						if (global::System.Windows.Input.Mouse.Captured == null)
						{
							num = (short)1879375872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 46:
						if (popupParentControl is global::DevComponents.WpfRibbon.Ribbon)
						{
							num = (short)1151139873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_306;
					case 47:
						goto IL_528;
					case 48:
						num = (short)363986987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						if (((global::System.Windows.Controls.ContextMenu)global::System.Windows.Input.Mouse.Captured).Name == global::DevComponents.WpfRibbon.Ribbon.SysQatCustomizeContextMenu)
						{
							num = (short)1066532892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8F0;
					case 50:
						if (global::System.Windows.Input.Mouse.Captured is global::System.Windows.FrameworkElement)
						{
							num = (short)2002059318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61F;
					case 51:
						if (popupParentControl.IsPopupMode)
						{
							num = (short)1082851339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 52:
						goto IL_6B6;
					case 53:
						goto IL_81A;
					case 54:
						buttonDropDown = global::DevComponents.WpfRibbon.ParentPopupControlImpl.FindButtonDropDown(global::System.Windows.Input.Mouse.Captured as global::System.Windows.FrameworkElement);
						num = (short)1733820457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						if (!global::DevComponents.WpfRibbon.ParentPopupControlImpl.IsIgnoredCaptureType(global::System.Windows.Input.Mouse.Captured))
						{
							num = (short)976617484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61F;
					case 56:
						basePopupControl2 = global::DevComponents.WpfRibbon.ParentPopupControlImpl.GetBasePopupControl(((global::System.Windows.FrameworkElement)e.OriginalSource).TemplatedParent as global::System.Windows.FrameworkElement);
						num = (short)2020212794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						if (!global::DevComponents.WpfRibbon.ParentPopupControlImpl.IsVisualDescendant(popupParentControl as global::System.Windows.DependencyObject, e.OriginalSource as global::System.Windows.DependencyObject))
						{
							num = (short)1122959370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_81A;
					case 58:
						if (basePopupControl2 != null)
						{
							num = (short)193134598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B90;
					case 59:
						if (((global::System.Windows.FrameworkElement)e.OriginalSource).TemplatedParent is global::DevComponents.WpfRibbon.ButtonDropDown)
						{
							num = (short)2120482858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E7;
					case 60:
						if (!popupParentControl.QueryMouseCapturePopupClose(global::System.Windows.Input.Mouse.Captured as global::System.Windows.DependencyObject))
						{
							num = (short)646053896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)554369089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						num = (short)8912897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						if (((global::DevComponents.WpfRibbon.ButtonDropDown)((global::System.Windows.FrameworkElement)global::System.Windows.Input.Mouse.Captured).TemplatedParent).IsPopupOpen)
						{
							num = (short)1506476041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A64;
					case 63:
						goto IL_371;
					case 64:
						if (((global::DevComponents.WpfRibbon.ButtonDropDown)((global::System.Windows.FrameworkElement)e.OriginalSource).TemplatedParent).IsPopupOpen)
						{
							num = (short)1753546808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E7;
					case 65:
						if (e.OriginalSource == popupParentControl)
						{
							num = (short)981336067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_85B;
					case 66:
						if (basePopupControl != null)
						{
							num = (short)1127481357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DF;
					}
					goto IL_13A;
					IL_280:
					num = (short)2113994798;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_306:
					popupParentControl.IsPopupMode = false;
					num = (short)523985611;
					short num4 = num;
					num = (short)1816093387;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_752;
					default:
						num = (short)519372800;
						if (num != 0)
						{
						}
						num = (short)501415999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_4E7:
					num = (short)1222508575;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_528:
					num = (short)683933730;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_61F:
					num = (short)1785987132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6B6:
					num = (short)1034878994;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_81A:
					num = (short)1337327667;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_85B:
					num = (short)1030422585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A64:
					buttonDropDown = null;
					num = (short)1151926327;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_27B:
				global::System.Windows.Input.Mouse.Capture(basePopupControl2, global::System.Windows.Input.CaptureMode.SubTree);
				return;
				IL_2F7:
				global::System.Windows.Input.Mouse.Capture(popupParentControl as global::System.Windows.IInputElement, global::System.Windows.Input.CaptureMode.SubTree);
				e.Handled = true;
				return;
				IL_371:
				return;
				IL_4DF:
				popupParentControl.IsPopupMode = false;
				return;
				IL_8F0:
				popupParentControl.IsPopupMode = false;
				return;
				IL_AE9:
				global::System.Windows.Input.Mouse.Capture(basePopupControl, global::System.Windows.Input.CaptureMode.SubTree);
				return;
				IL_B90:
				popupParentControl.IsPopupMode = false;
				return;
				IL_13A:
				popupParentControl = (sender as global::DevComponents.WpfRibbon.IPopupParentControl);
				num = (short)1396310021;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0006D570 File Offset: 0x0006B770
		private static bool IsIgnoredCaptureType(global::System.Windows.IInputElement o)
		{
			short num = (short)2009530369;
			if (num != 0)
			{
			}
			num = (short)319946753;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1659305984;
				short num3 = num;
				num = (short)1502771635;
				short num4 = num;
				num = (short)412711347;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				default:
					num = (short)16580608;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)1027932162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_D1;
						}
						continue;
					case 2:
						if (o is global::DevComponents.WpfRibbon.ButtonDropDown)
						{
							num = (short)711852035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						goto IL_12B;
					}
					IL_D1:
					if (o is global::DevComponents.WpfRibbon.BasePopupControl)
					{
						return true;
					}
					num = (short)1776680960;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return true;
			IL_12B:
			return true;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0006D6AC File Offset: 0x0006B8AC
		private static global::DevComponents.WpfRibbon.BasePopupControl GetBasePopupControl(global::System.Windows.FrameworkElement elem)
		{
			short num = (short)1451425795;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)826767411;
					short num3 = num;
					num = (short)1513912371;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_41;
					default:
						goto IL_106;
					}
					break;
				}
				case 1:
					if (elem is global::DevComponents.WpfRibbon.BasePopupControl)
					{
						num = (short)2047541248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_41;
				case 2:
				{
					num = (short)1504313344;
					short num4 = num;
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 4:
					goto IL_188;
				case 5:
					if (!(elem.Parent is global::System.Windows.FrameworkElement))
					{
						num = (short)827654148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1423114241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_3C;
				IL_41:
				elem = (elem.Parent as global::System.Windows.FrameworkElement);
				num = (short)1183973378;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_146:
				num = (short)2039283717;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C:
				goto IL_146;
			}
			IL_106:
			num = (short)1934557185;
			if (num != 0)
			{
			}
			num = (short)618987520;
			if (num != 0)
			{
			}
			return elem as global::DevComponents.WpfRibbon.BasePopupControl;
			IL_188:
			return null;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0006D844 File Offset: 0x0006BA44
		private static global::DevComponents.WpfRibbon.ButtonDropDown FindButtonDropDown(global::System.Windows.FrameworkElement elem)
		{
			short num = (short)1452927552;
			short num2 = num;
			num = (short)214952512;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_214:
				num = (short)1558577157;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)914489344;
				if (num != 0)
				{
				}
				num = (short)870055947;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 1:
					if (elem != null)
					{
						num = (short)250937354;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B5;
				case 2:
					goto IL_13C;
				case 3:
					if (!(elem.Parent is global::System.Windows.FrameworkElement))
					{
						num = (short)1299120140;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)359596038;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (elem != null)
					{
						num = (short)1710292999;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_214;
				case 5:
					if (elem == null)
					{
						num = (short)760545293;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13E;
				case 6:
					if (elem.TemplatedParent is global::DevComponents.WpfRibbon.ButtonDropDown)
					{
						num = (short)193986569;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					elem = (elem.Parent as global::System.Windows.FrameworkElement);
					num = (short)1678376960;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)614334472;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)1319829505;
					if (num != 0)
					{
					}
					num = (short)615645184;
					short num4 = num;
					if (elem.TemplatedParent is global::DevComponents.WpfRibbon.ButtonDropDown)
					{
						num = (short)737935362;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_214;
				}
				case 9:
					goto IL_1CE;
				case 10:
					elem = (global::System.Windows.Media.VisualTreeHelper.GetParent(elem) as global::System.Windows.FrameworkElement);
					num = (short)127795204;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_AC;
					}
					continue;
				case 12:
					goto IL_13E;
				case 13:
					goto IL_249;
				}
				goto IL_AC;
				IL_13E:
				num = (short)715456513;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_24B:
				num = (short)1717960707;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_AC:
				goto IL_24B;
			}
			IL_13C:
			return elem.TemplatedParent as global::DevComponents.WpfRibbon.ButtonDropDown;
			IL_1CE:
			return elem.TemplatedParent as global::DevComponents.WpfRibbon.ButtonDropDown;
			IL_249:
			IL_2B5:
			return null;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0006DB08 File Offset: 0x0006BD08
		public void OnIsSelectedChanged(object sender, global::System.Windows.RoutedPropertyChangedEventArgs<bool> e)
		{
			switch (0)
			{
			case 0:
				goto IL_60;
			}
			int num;
			global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.CurrentSelection != buttonDropDown)
					{
						num2 = (short)1706360833;
						if (num2 != 0)
						{
						}
						num2 = (short)962723856;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_298;
				case 1:
					if (buttonDropDown.GetPopupParent() == this.Parent)
					{
						num2 = (short)1712783379;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_298;
				case 2:
					goto IL_298;
				case 3:
					num2 = (short)541589510;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					bool flag;
					this.CurrentSelection.IsPopupOpen = flag;
					num2 = (short)306446350;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					return;
				case 6:
				{
					bool flag;
					if (this.CurrentSelection.IsPopupOpen != flag)
					{
						num2 = (short)1776025604;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_298;
				}
				case 7:
				{
					bool flag = this.CurrentSelection.IsPopupOpen;
					this.CurrentSelection.IsPopupOpen = false;
					num2 = (short)1830223882;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
				{
					if (e.NewValue)
					{
						num2 = (short)1995243532;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)313196544;
					short num3 = num2;
					num2 = (short)553844751;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
					if (buttonDropDown != null)
					{
						num2 = (short)155254801;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 10:
					goto IL_CB;
				case 11:
					this.CurrentSelection = null;
					num2 = (short)852099074;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					num2 = (short)1686306816;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
				{
					bool flag;
					if (this.CurrentSelection != null && flag)
					{
						num2 = (short)1095303171;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_298;
				}
				case 14:
					goto IL_298;
				case 15:
				{
					num2 = (short)199960507;
					short num4 = num2;
					num2 = (short)1399400379;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A4;
					default:
						num2 = (short)1986330624;
						if (num2 != 0)
						{
						}
						if (this.CurrentSelection == buttonDropDown)
						{
							num2 = (short)1355284491;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_298;
					}
					break;
				}
				case 16:
					num2 = (short)246218753;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					goto IL_1A4;
				case 18:
					if (this.CurrentSelection != null)
					{
						num2 = (short)1111162887;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_CB;
				case 19:
				{
					bool flag = false;
					num2 = (short)761593874;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_60;
				IL_CB:
				this.CurrentSelection = buttonDropDown;
				num2 = (short)689635341;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1A4:
				num2 = (short)1763311624;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_298:
				e.Handled = true;
				num2 = (short)1651769349;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_60:
			buttonDropDown = (e.OriginalSource as global::DevComponents.WpfRibbon.ButtonDropDown);
			num2 = (short)183697417;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0006DECC File Offset: 0x0006C0CC
		public global::System.Windows.UIElement Parent
		{
			get
			{
				short num = (short)2132571715;
				short num2 = num;
				num = (short)967407171;
				switch (num2 == num)
				{
				default:
				{
					num = (short)330629120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)30670848;
				if (num != 0)
				{
				}
				num = (short)1134100481;
				if (num != 0)
				{
				}
				return this.m_Parent;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0006DF78 File Offset: 0x0006C178
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x0006E028 File Offset: 0x0006C228
		public global::DevComponents.WpfRibbon.ButtonDropDown CurrentSelection
		{
			get
			{
				short num = (short)148737841;
				short num2 = num;
				num = (short)1677168433;
				switch (num2 == num)
				{
				default:
				{
					num = (short)421396480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)860749824;
				if (num != 0)
				{
				}
				num = (short)37748737;
				if (num != 0)
				{
				}
				return this.m_CurrentSelection;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_30;
				}
				int num;
				short num2;
				bool flag;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)784314087;
						short num3 = num2;
						num2 = (short)1534570215;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_108;
						default:
							num2 = (short)1394081792;
							if (num2 != 0)
							{
							}
							if (this.m_CurrentSelection != null)
							{
								num2 = (short)486735874;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						break;
					}
					case 1:
					{
						num2 = (short)1804664832;
						short num4 = num2;
						this.m_CurrentSelection.Focus();
						num2 = (short)1212612614;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						this.m_CurrentSelection.IsSelected = true;
						num2 = (short)2074738691;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (flag)
						{
							num2 = (short)1510146049;
							if (num2 != 0)
							{
							}
							num2 = (short)787283969;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 4:
						flag = this.m_CurrentSelection.IsKeyboardFocused;
						this.m_CurrentSelection.IsSelected = false;
						num2 = (short)1617494023;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						if (this.m_CurrentSelection != null)
						{
							num2 = (short)714604548;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_101;
					case 6:
						return;
					case 7:
						goto IL_101;
					}
					goto IL_30;
					IL_108:
					num2 = (short)194904064;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_101:
					this.m_CurrentSelection = value;
					goto IL_108;
				}
				return;
				IL_30:
				flag = false;
				num2 = (short)633929733;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x0006E220 File Offset: 0x0006C420
		private global::System.Windows.FrameworkElement CaptureElement
		{
			get
			{
				short num = (short)915865601;
				if (num != 0)
				{
				}
				num = (short)320208896;
				short num2 = num;
				num = (short)751216425;
				short num3 = num;
				num = (short)833005353;
				switch (num3 == num)
				{
				}
				num = (short)101515264;
				if (num != 0)
				{
				}
				return this.m_Parent;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0006E2CC File Offset: 0x0006C4CC
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x0006E37C File Offset: 0x0006C57C
		public bool IsPopupMode
		{
			get
			{
				short num = (short)912410961;
				short num2 = num;
				num = (short)1900169553;
				switch (num2 == num)
				{
				default:
				{
					num = (short)327024640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1790115840;
				if (num != 0)
				{
				}
				num = (short)1814953985;
				if (num != 0)
				{
				}
				return this.m_IsPopupMode;
			}
			set
			{
				short num = (short)2043478030;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!global::DevComponents.WpfRibbon.ParentPopupControlImpl.IsOnPopup(this.m_Parent))
						{
							num = (short)452657168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C2;
					case 1:
						num = (short)1171062784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.m_IsPopupMode)
						{
							num = (short)6553609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)67698693;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!global::DevComponents.WpfRibbon.ParentPopupControlImpl.IsVisualDescendant(this.m_Parent, global::System.Windows.Input.Mouse.Captured as global::System.Windows.Media.Visual))
						{
							num = (short)1990197249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C2;
					case 4:
						global::System.Windows.Input.Mouse.Capture(null);
						num = (short)1109917709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (this.CurrentSelection != null)
						{
							num = (short)758054918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_183;
					case 6:
						this.CurrentSelection.IsPopupOpen = false;
						this.CurrentSelection = null;
						num = (short)1385627658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_248;
					case 8:
						goto IL_362;
					case 9:
						num = (short)467206147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_183;
					case 11:
						this.m_IsPopupMode = value;
						num = (short)431816706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (this.HasCapture)
						{
							num = (short)1343881217;
							if (num != 0)
							{
							}
							num = (short)1452408832;
							short num3 = num;
							num = (short)1251409924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22B;
					case 13:
						goto IL_22B;
					case 14:
						switch (0)
						{
						case 0:
							goto IL_6A;
						}
						continue;
					case 15:
						if (!global::System.Windows.Input.Mouse.Capture(this.CaptureElement, global::System.Windows.Input.CaptureMode.SubTree))
						{
							num = (short)219873288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C2;
					case 16:
					{
						num = (short)891023201;
						short num4 = num;
						num = (short)825421665;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_183;
						default:
							num = (short)1503330304;
							if (num != 0)
							{
							}
							num = (short)617349135;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_6A:
					if (this.m_IsPopupMode != value)
					{
						num = (short)42336267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_183:
					this.OnInternalMenuModeChanged(global::System.EventArgs.Empty);
					global::DevComponents.WpfRibbon.ParentPopupControlImpl.SetSuspendPopupAnimation(this.m_Parent as global::System.Windows.Controls.ItemsControl, null, false);
					num = (short)1559429132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22B:
					this.RestorePreviousFocus();
					num = (short)2006319111;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C2:
				this.OnInternalMenuModeChanged(global::System.EventArgs.Empty);
				return;
				IL_248:
				return;
				IL_362:
				this.m_IsPopupMode = false;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x0006E6F0 File Offset: 0x0006C8F0
		private bool IsKeyboardFocusWithin
		{
			get
			{
				global::System.Windows.UIElement parent = this.m_Parent;
				if (parent != null)
				{
					short num = (short)314078802;
					short num2 = num;
					num = (short)697529938;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1609760768;
						if (num != 0)
						{
						}
						num = (short)2108555264;
						short num3 = num;
						num = (short)1613430785;
						if (num != 0)
						{
						}
						return parent.IsKeyboardFocusWithin;
					}
					}
				}
				return false;
			}
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0006E7B0 File Offset: 0x0006C9B0
		private void RestorePreviousFocus()
		{
			for (;;)
			{
				IL_00:
				short num = (short)2034630660;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.DependencyObject parent;
					switch (num2)
					{
					case 0:
					{
						num = (short)1110573056;
						short num3 = num;
						global::System.Windows.DependencyObject focusScope;
						if (focusScope != null)
						{
							num = (short)378667016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
					{
						global::System.Windows.DependencyObject focusScope;
						global::System.Windows.Input.FocusManager.SetFocusedElement(focusScope, null);
						num = (short)1955528707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)1249648839;
						short num4 = num;
						num = (short)1123295431;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)1877671937;
							if (num != 0)
							{
							}
							num = (short)1731264512;
							if (num != 0)
							{
							}
							global::System.Windows.IInputElement focusedElement;
							if (this.ContainsElement(focusedElement))
							{
								num = (short)1769668609;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						}
						break;
					}
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_4C;
						}
						continue;
					case 5:
						goto IL_1D0;
					case 6:
						if (parent != null)
						{
							num = (short)1565786119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
					{
						global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(parent);
						num = (short)1141243904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::System.Windows.DependencyObject focusScope;
						global::System.Windows.IInputElement focusedElement = global::System.Windows.Input.FocusManager.GetFocusedElement(focusScope);
						num = (short)1487339522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						global::System.Windows.Input.Keyboard.Focus(null);
						num = (short)1432027141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_4C:
					if (this.IsKeyboardFocusWithin)
					{
						num = (short)1093140489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1D0:
					parent = this.m_Parent.Parent;
					num = (short)64880646;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0006E9D0 File Offset: 0x0006CBD0
		private bool ContainsElement(global::System.Windows.IInputElement element)
		{
			short num = (short)432930818;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::System.Windows.DependencyObject dependencyObject;
					if (dependencyObject != null)
					{
						num = (short)382402561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 1:
				{
					global::System.Windows.DependencyObject dependencyObject;
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = dependencyObject as global::DevComponents.WpfRibbon.ButtonDropDown;
					num = (short)2147090436;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 3:
					goto IL_200;
				case 4:
				{
					global::System.Windows.DependencyObject dependencyObject;
					if (global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(dependencyObject) == this.m_Parent)
					{
						num = (short)109838349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1951137797;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
					if (buttonDropDown != null)
					{
						num = (short)305135624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 6:
				{
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
					if (buttonDropDown != null)
					{
						num = (short)1285554187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_205;
				}
				case 7:
				{
					num = (short)1707540480;
					short num3 = num;
					global::System.Windows.DependencyObject dependencyObject;
					if (dependencyObject == null)
					{
						num = (short)218169347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)105775110;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					goto IL_17C;
				case 9:
					goto IL_17C;
				case 10:
					goto IL_205;
				case 11:
				{
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
					global::System.Windows.DependencyObject dependencyObject = buttonDropDown.Parent;
					num = (short)1501233162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					return true;
				case 13:
					return true;
				case 14:
				{
					global::System.Windows.DependencyObject dependencyObject;
					if (dependencyObject == this.m_Parent)
					{
						num = (short)664076300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1355808768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 15:
					return true;
				}
				IL_64:
				num = (short)1967983768;
				short num4 = num;
				num = (short)1793789080;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				default:
				{
					num = (short)1340342272;
					if (num != 0)
					{
					}
					if (element == this.m_Parent)
					{
						num = (short)1887305743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.DependencyObject dependencyObject = element as global::System.Windows.DependencyObject;
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = element as global::DevComponents.WpfRibbon.ButtonDropDown;
					num = (short)591986697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_17C:
				num = (short)667746305;
				if (num != 0)
				{
				}
				num = (short)830275591;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_205:
				num = (short)1771962382;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_200:
			return false;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0006ECB0 File Offset: 0x0006CEB0
		internal static void SetSuspendPopupAnimation(global::System.Windows.Controls.ItemsControl itemsCont, global::DevComponents.WpfRibbon.ButtonDropDown ignore, bool suspend)
		{
			short num = (short)1699872769;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num4;
				int count;
				switch (num2)
				{
				case 0:
					goto IL_17C;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 2:
				{
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
					global::DevComponents.WpfRibbon.ParentPopupControlImpl.SetSuspendPopupAnimation(buttonDropDown, null, suspend);
					num = (short)1050542080;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_200;
				case 4:
				{
					num = (short)412032412;
					short num3 = num;
					num = (short)213261724;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1015218177;
						if (num != 0)
						{
						}
						num = (short)1336475648;
						if (num != 0)
						{
						}
						break;
					}
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
					buttonDropDown.IsPopupAnimationSuspended = suspend;
					num = (short)254476294;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					return;
				case 6:
					if (!suspend)
					{
						num = (short)797573122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17C;
				case 7:
					goto IL_200;
				case 8:
					num = (short)1688535052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1539833866;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
					if (buttonDropDown != ignore)
					{
						num = (short)1577517064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17C;
				}
				case 11:
				{
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
					if (buttonDropDown != null)
					{
						num = (short)1613496329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17C;
				}
				case 12:
				{
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
					if (buttonDropDown.IsPopupAnimationSuspended != suspend)
					{
						num = (short)1581973508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17C;
				}
				case 13:
				{
					if (num4 >= count)
					{
						num = (short)976486405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = itemsCont.ItemContainerGenerator.ContainerFromIndex(num4) as global::DevComponents.WpfRibbon.ButtonDropDown;
					num = (short)979435531;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 14:
					return;
				}
				IL_61:
				if (itemsCont == null)
				{
					num = (short)416743438;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				count = itemsCont.Items.Count;
				num4 = 0;
				num = (short)1773076483;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_17C:
				num4++;
				num = (short)506855424;
				short num5 = num;
				num = (short)1743323143;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_200:
				num = (short)1675100173;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0006EF7C File Offset: 0x0006D17C
		public bool HasCapture
		{
			get
			{
				short num = (short)2123890689;
				if (num != 0)
				{
				}
				num = (short)2012467840;
				short num2 = num;
				num = (short)660787840;
				switch (num2 == num)
				{
				}
				num = (short)935723008;
				short num3 = num;
				num = (short)1475215360;
				if (num != 0)
				{
				}
				return global::System.Windows.Input.Mouse.Captured == this.CaptureElement;
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0006F030 File Offset: 0x0006D230
		internal static bool IsLogicalDescendant(global::System.Windows.DependencyObject reference, global::System.Windows.DependencyObject node)
		{
			short num;
			for (;;)
			{
				num = (short)1136525316;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (node == null)
						{
							num = (short)1950941192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						node = global::System.Windows.LogicalTreeHelper.GetParent(node);
						num = (short)1923284994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return true;
					case 2:
						if (node == reference)
						{
							num = (short)1592131585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D7;
					case 3:
						goto IL_146;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_4C;
						}
						continue;
					case 5:
						if (reference == null)
						{
							num = (short)1155072003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)160759814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1005977601;
						if (num != 0)
						{
						}
						if (node == reference)
						{
							num = (short)802422791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D7;
					case 7:
						goto IL_1F7;
					case 8:
						return false;
					case 9:
						num = (short)50921477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_4C:
					if (node != null)
					{
						num = (short)641990665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
					IL_D7:
					num = (short)257097728;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_146:
				num = (short)1081090586;
				short num3 = num;
				num = (short)1486561818;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_17C;
				}
			}
			return true;
			IL_17C:
			num = (short)40501248;
			if (num != 0)
			{
			}
			return false;
			IL_1F7:
			num = (short)989986816;
			short num4 = num;
			return true;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0006F23C File Offset: 0x0006D43C
		internal static bool IsVisualDescendant(global::System.Windows.DependencyObject reference, global::System.Windows.DependencyObject node)
		{
			int a_ = 3;
			short num = (short)1732968452;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Controls.Primitives.Popup popup;
				switch (num2)
				{
				case 0:
					if (popup != null)
					{
						num = (short)1626013697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37E;
				case 1:
					num = (short)1286340611;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (node is global::System.Windows.Controls.ContentControl)
					{
						num = (short)1082327051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CD;
				case 3:
				{
					num = (short)619656559;
					short num3 = num;
					num = (short)1163539823;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2E4;
					default:
						num = (short)1262092288;
						if (num != 0)
						{
						}
						if (popup.Parent != null)
						{
							num = (short)1575419918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37E;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_81;
					}
					continue;
				case 5:
					return true;
				case 6:
					if (node == reference)
					{
						num = (short)2079850501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_253;
				case 7:
					return false;
				case 8:
					if (node != null)
					{
						num = (short)1677721618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_305;
				case 9:
					node = global::System.Windows.LogicalTreeHelper.GetParent(node);
					num = (short)1883832330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_305;
				case 11:
					num = (short)918487052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (((global::System.Windows.Controls.ContentControl)node).Name == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("୚ᱜ൞㕠㱢㕤ࡦᥨṪᵬⱮṰᵲŴቶ᝸ེ", a_))
					{
						num = (short)170000403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CD;
				case 13:
					if (node == null)
					{
						num = (short)300744711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					popup = (node as global::System.Windows.Controls.Primitives.Popup);
					num = (short)880410624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_2E4;
				case 15:
					return true;
				case 16:
					if (!(node is global::System.Windows.Controls.Primitives.Popup))
					{
						num = (short)959447049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_305;
				case 17:
					goto IL_305;
				case 18:
					num = (short)1135411216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					node = global::System.Windows.LogicalTreeHelper.GetParent(node);
					num = (short)483262472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_305;
				}
				IL_81:
				if (node == reference)
				{
					num = (short)7340033;
					if (num != 0)
					{
					}
					num = (short)1158217743;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_253;
				IL_CD:
				num = (short)192806912;
				short num4 = num;
				node = global::DevComponents.WpfRibbon.ParentPopupControlImpl.FindParent(node);
				num = (short)323354644;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_253:
				num = (short)974127117;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E4:
				node = popup.Parent;
				num = (short)734003217;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_305:
				num = (short)1702428678;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_37E:
				num = (short)790953986;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0006F608 File Offset: 0x0006D808
		private static global::System.Windows.DependencyObject FindParent(global::System.Windows.DependencyObject dpo)
		{
			short num = (short)2068226819;
			short num2 = num;
			num = (short)527278851;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_136:
				num = (short)1376124947;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1917845504;
				if (num != 0)
				{
				}
				num = (short)1605435392;
				num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_CB;
					}
					break;
				}
				break;
			}
			global::DevComponents.WpfRibbon.RibbonBar ribbonBar;
			global::System.Windows.FrameworkContentElement frameworkContentElement;
			global::System.Windows.Media.Visual visual;
			global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
			for (;;)
			{
				IL_74:
				global::System.Windows.ContentElement contentElement;
				global::System.Windows.ContentElement contentElement2;
				switch (num3)
				{
				case 0:
					contentElement = null;
					goto IL_37B;
				case 1:
					goto IL_1F3;
				case 2:
					goto IL_377;
				case 3:
					if (ribbonBar != null)
					{
						num = (short)1751711758;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C2;
				case 4:
					contentElement = (dpo as global::System.Windows.ContentElement);
					goto IL_37B;
				case 5:
					if (frameworkContentElement != null)
					{
						num = (short)684523521;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C0;
				case 6:
					goto IL_301;
				case 7:
					if (contentElement2 != null)
					{
						num = (short)894435338;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)52363281;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_173;
				case 9:
					if (visual != null)
					{
						num = (short)107741196;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1744502788;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					dpo = global::System.Windows.ContentOperations.GetParent(contentElement2);
					num = (short)988545035;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (dpo != null)
					{
						num = (short)849281025;
						if (num != 0)
						{
						}
						num = (short)1308491794;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					frameworkContentElement = (contentElement2 as global::System.Windows.FrameworkContentElement);
					num = (short)740818949;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)1011351552;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_1AE;
				case 14:
				{
					num = (short)1369702400;
					short num4 = num;
					num = (short)990445583;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 15:
					if (ribbonBar.Parent != null)
					{
						num = (short)1945108482;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C2;
				case 16:
					if (ribbonTab != null)
					{
						num = (short)991952902;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F8;
				case 17:
					if (visual != null)
					{
						num = (short)1139081229;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C0;
				case 18:
					return dpo;
				case 19:
					if (ribbonTab.Parent != null)
					{
						num = (short)371982344;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F8;
				}
				goto IL_CB;
				IL_1F8:
				visual = (dpo as global::System.Windows.Media.Visual);
				num = (short)234225673;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C2:
				ribbonTab = (dpo as global::DevComponents.WpfRibbon.RibbonTab);
				num = (short)1024131088;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_37B:
				contentElement2 = contentElement;
				num = (short)1940324359;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_173:
			return ribbonTab.Parent;
			IL_1AE:
			return global::System.Windows.Media.VisualTreeHelper.GetParent(visual);
			IL_1F3:
			return frameworkContentElement.Parent;
			IL_301:
			goto IL_136;
			IL_377:
			return ribbonBar.Parent;
			IL_3C0:
			return null;
			IL_CB:
			ribbonBar = (dpo as global::DevComponents.WpfRibbon.RibbonBar);
			num = (short)1813184515;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_74;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0006F9D8 File Offset: 0x0006DBD8
		internal static bool IsChildOf(global::System.Windows.UIElement parent, global::System.Windows.UIElement pc)
		{
			short num = (short)1050476546;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.FrameworkElement frameworkElement;
				switch (num2)
				{
				case 0:
					goto IL_177;
				case 1:
					return true;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 3:
					if (frameworkElement != null)
					{
						num = (short)332726276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D2;
				case 4:
					num = (short)2044461073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)764477440;
					short num3 = num;
					num = (short)1090846736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					return true;
				case 7:
					if (frameworkElement != null)
					{
						num = (short)625606661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 8:
					goto IL_271;
				case 9:
					if (frameworkElement == parent)
					{
						num = (short)1779367942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					frameworkElement = (global::System.Windows.LogicalTreeHelper.GetParent(frameworkElement) as global::System.Windows.FrameworkElement);
					num = (short)1146159104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_271;
				case 11:
					if (frameworkElement == parent)
					{
						num = (short)1560477697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					frameworkElement = (global::System.Windows.Media.VisualTreeHelper.GetParent(frameworkElement) as global::System.Windows.FrameworkElement);
					num = (short)2015821832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					return false;
				case 13:
					goto IL_177;
				case 14:
					return false;
				case 15:
					goto IL_2D2;
				case 16:
					if (frameworkElement == null)
					{
						num = (short)1543634958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)543227913;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
				{
					if (frameworkElement == null)
					{
						num = (short)1314717711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1752631893;
					short num4 = num;
					num = (short)1625688661;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num = (short)576913409;
						if (num != 0)
						{
						}
						num = (short)1641545728;
						if (num != 0)
						{
						}
						num = (short)421789707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_6D:
				if (pc == null)
				{
					num = (short)1134428172;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				frameworkElement = (global::System.Windows.Media.VisualTreeHelper.GetParent(pc) as global::System.Windows.FrameworkElement);
				num = (short)2135883786;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_177:
				num = (short)1644494855;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_271:
				num = (short)1602355203;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D2:
				frameworkElement = (global::System.Windows.Media.VisualTreeHelper.GetParent(pc) as global::System.Windows.FrameworkElement);
				num = (short)517603341;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0006FD0C File Offset: 0x0006DF0C
		internal static bool IsOnPopup(global::System.Windows.UIElement pc)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)465371140;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.FrameworkElement frameworkElement;
					switch (num2)
					{
					case 0:
						goto IL_128;
					case 1:
						goto IL_AD;
					case 2:
					{
						if (frameworkElement.Parent is global::System.Windows.Controls.Primitives.Popup)
						{
							num = (short)882049025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						frameworkElement = (frameworkElement.Parent as global::System.Windows.FrameworkElement);
						num = (short)1132650079;
						short num3 = num;
						num = (short)2145246815;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)627965952;
							if (num != 0)
							{
							}
							num = (short)1021116419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_128;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_4C;
						}
						continue;
					case 5:
						return false;
					case 6:
						if (!(frameworkElement is global::System.Windows.Controls.Primitives.Popup))
						{
							num = (short)1254096903;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 7:
						num = (short)2005204994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (frameworkElement == null)
						{
							num = (short)2037121029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)166133766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return false;
					}
					IL_4C:
					if (pc == null)
					{
						num = (short)1417543689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					frameworkElement = (global::System.Windows.Media.VisualTreeHelper.GetParent(pc) as global::System.Windows.FrameworkElement);
					num = (short)1849753600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_128:
					num = (short)942800904;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return false;
			IL_AD:
			num = (short)1902510081;
			if (num != 0)
			{
			}
			num = (short)1281032192;
			short num4 = num;
			return true;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0006FF38 File Offset: 0x0006E138
		private void OnInternalMenuModeChanged(global::System.EventArgs e)
		{
			short num = (short)305725442;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_1E:
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)613810177;
					if (num != 0)
					{
					}
					this.InternalMenuModeChanged(this, e);
					num = (short)675807232;
					short num3 = num;
					num = (short)1998716928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				while (this.InternalMenuModeChanged != null)
				{
					num = (short)755906296;
					short num4 = num;
					num = (short)1218393848;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1327497216;
						if (num != 0)
						{
						}
						num = (short)2109079553;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1E;
					}
				}
				break;
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0007005C File Offset: 0x0006E25C
		internal void OnTooltipOpening(global::System.Windows.Controls.ToolTipEventArgs e)
		{
			short num = (short)19005443;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1576293334;
					short num3 = num;
					num = (short)754275286;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_91;
					default:
						num = (short)260964352;
						if (num != 0)
						{
						}
						goto IL_1DB;
					}
					break;
				}
				case 1:
					if (this.CurrentSelection.IsPopupOpen)
					{
						goto IL_91;
					}
					return;
				case 2:
					if (global::DevComponents.WpfRibbon.ParentPopupControlImpl.IsVisualDescendant(e.OriginalSource as global::System.Windows.DependencyObject, this.CurrentSelection))
					{
						num = (short)1092222980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DB;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 4:
					num = (short)2045902853;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (e.OriginalSource == this.CurrentSelection)
					{
						num = (short)2124939271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					return;
				case 7:
					num = (short)1371340801;
					if (num != 0)
					{
					}
					num = (short)1795555329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)1192755200;
					short num4 = num;
					num = (short)415760386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_48:
				if (this.CurrentSelection != null)
				{
					num = (short)903872520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_91:
				num = (short)1732968448;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1DB:
				e.Handled = true;
				num = (short)1849229318;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0400028E RID: 654
		private global::System.Windows.FrameworkElement m_Parent;

		// Token: 0x0400028F RID: 655
		private global::DevComponents.WpfRibbon.ButtonDropDown m_CurrentSelection;

		// Token: 0x04000290 RID: 656
		private bool m_IsPopupMode;
	}
}
