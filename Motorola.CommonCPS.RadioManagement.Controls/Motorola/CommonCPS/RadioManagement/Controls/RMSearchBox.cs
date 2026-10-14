using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.Controls.UiHelpers;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200006D RID: 109
	public class RMSearchBox : global::System.Windows.Controls.ComboBox
	{
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000238 RID: 568 RVA: 0x00025680 File Offset: 0x00023880
		// (remove) Token: 0x06000239 RID: 569 RVA: 0x000257B8 File Offset: 0x000239B8
		public event global::System.EventHandler<global::System.EventArgs> SearchTriggered
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				global::System.EventHandler<global::System.EventArgs> eventHandler;
				for (;;)
				{
					IL_0A:
					int num;
					global::System.EventHandler<global::System.EventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						num2 = (short)1180434433;
						if (num2 != 0)
						{
						}
						num2 = (short)1034027008;
						short num3 = num2;
						if (eventHandler == eventHandler2)
						{
							num2 = (short)20250624;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_83;
					}
					case 2:
						goto IL_83;
					}
					break;
					IL_83:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::System.EventArgs> value2 = (global::System.EventHandler<global::System.EventArgs>)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::System.EventArgs>>(ref this.SearchTriggered, value2, eventHandler2);
					num2 = (short)812056577;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1C:
				eventHandler = this.SearchTriggered;
				num2 = (short)112717863;
				short num4 = num2;
				num2 = (short)416542759;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num2 = (short)1917845504;
					if (num2 != 0)
					{
					}
					num2 = (short)1916338178;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				global::System.EventHandler<global::System.EventArgs> eventHandler;
				for (;;)
				{
					IL_0A:
					int num;
					global::System.EventHandler<global::System.EventArgs> eventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						num2 = (short)1311047680;
						short num3 = num2;
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1094123520;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_AA;
					}
					case 2:
						num2 = (short)1689845761;
						if (num2 != 0)
						{
						}
						goto IL_AA;
					}
					break;
					IL_AA:
					eventHandler2 = eventHandler;
					global::System.EventHandler<global::System.EventArgs> value2 = (global::System.EventHandler<global::System.EventArgs>)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::System.EventArgs>>(ref this.SearchTriggered, value2, eventHandler2);
					num2 = (short)334692353;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1C:
				eventHandler = this.SearchTriggered;
				num2 = (short)1568402383;
				short num4 = num2;
				num2 = (short)1123609551;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num2 = (short)1663500288;
					if (num2 != 0)
					{
					}
					num2 = (short)887291906;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000258EC File Offset: 0x00023AEC
		static RMSearchBox()
		{
			int a_ = 18;
			short num = (short)1480050653;
			short num2 = num;
			num = (short)778946525;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1826357248;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1348272129;
			if (num != 0)
			{
			}
			num = (short)1386348544;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox.TimerDelayProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﺩ얫쎭햯삱펵풷\udbb9얻", a_), typeof(double), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox), new global::System.Windows.PropertyMetadata(1000.0, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox.OnTimerDelayChanged)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox.IsSearchTimerEnabledProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udfabﶭ햯펱욳햵킷햻펽ꖿ냁臃ꣅ꧇꣉ꃋꯍ듏", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox.a)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox.LastValueExpirationTimerDelayProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("춫\uddad쒯햳\udab5춷\udfb9僚욽낿ꯁ뛃Ʂ볇ꏉꏋꃍ蓏믑맓돕꫗黙맛닝臟鯡", a_), typeof(double), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox), new global::System.Windows.PropertyMetadata(1000.0, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox.OnLastValueExpirationTimerDelayChanged)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox)));
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00025A9C File Offset: 0x00023C9C
		public RMSearchBox()
		{
			base.IsEditable = true;
			base.IsTextSearchEnabled = false;
			base.DataContext = this;
			this._historicalSearchOptions = new global::System.Collections.Generic.List<string>();
			base.ItemsSource = this.ReversedHistoricalSearchOptions;
			this._typingDelaytimer = new global::System.Timers.Timer(this.TimerDelay)
			{
				AutoReset = false
			};
			this._lastEnteredValueTimer = new global::System.Timers.Timer(this.LastValueExpirationTimerDelay)
			{
				AutoReset = false
			};
			this._lastEnteredValueTimer.Elapsed += this.LastEnteredValueTimer_Elapsed;
			base.LostFocus += this.RMSearchableComboBox_LostFocus;
			base.Unloaded += this.RMSearchBox_Unloaded;
			base.Loaded += this.RMSearchBox_Loaded;
			base.DropDownOpened += this.RMSearchBox_DropDownOpened;
			base.MouseLeftButtonDown += this.RMSearchBox_MouseLeftButtonDown;
			base.MouseRightButtonDown += this.RMSearchBox_MouseRightButtonDown;
			base.ContextMenuOpening += global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox.RMSearchBox_ContextMenuOpening;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00025BAC File Offset: 0x00023DAC
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00025C68 File Offset: 0x00023E68
		public double TimerDelay
		{
			get
			{
				short num = (short)306584592;
				short num2 = num;
				num = (short)1807686672;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1911881728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)813826049;
				if (num != 0)
				{
				}
				num = (short)1658191872;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox.TimerDelayProperty);
			}
			set
			{
				int num;
				double num2;
				short num3;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							this._typingDelaytimer.Interval = num2;
							num3 = (short)1006567425;
							num = (int)((global::System.IntPtr)num3);
							continue;
						case 1:
							return;
						case 2:
							num2 = 100.0;
							num3 = (short)27394051;
							num = (int)((global::System.IntPtr)num3);
							continue;
						case 3:
							goto IL_B6;
						case 4:
							if (this.IsSearchTimerEnabled)
							{
								num3 = (short)1855717377;
								if (num3 != 0)
								{
								}
								num3 = (short)2092826624;
								num = (int)((global::System.IntPtr)num3);
								continue;
							}
							return;
						case 5:
							if (value <= 100.0)
							{
								num3 = (short)360644608;
								short num4 = num3;
								num3 = (short)1570045954;
								num = (int)((global::System.IntPtr)num3);
								continue;
							}
							goto IL_B6;
						}
						goto IL_28;
						IL_B6:
						num3 = (short)1445624003;
						short num5 = num3;
						num3 = (short)678787267;
						switch ((num5 == num3) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2A;
						default:
							num3 = (short)331153408;
							if (num3 != 0)
							{
							}
							base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox.TimerDelayProperty, num2);
							num3 = (short)359464964;
							num = (int)((global::System.IntPtr)num3);
							break;
						}
					}
					return;
				}
				IL_28:
				num2 = value;
				IL_2A:
				num3 = (short)759169029;
				num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00025E14 File Offset: 0x00024014
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00025ECC File Offset: 0x000240CC
		public bool IsSearchTimerEnabled
		{
			get
			{
				short num = (short)2068724691;
				short num2 = num;
				num = (short)478165971;
				switch (num2 == num)
				{
				default:
				{
					num = (short)639107072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1514471425;
				if (num != 0)
				{
				}
				num = (short)1946681344;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox.IsSearchTimerEnabledProperty);
			}
			set
			{
				short num = (short)1669010956;
				short num2 = num;
				num = (short)1158223372;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1555234816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1465778176;
				if (num != 0)
				{
				}
				num = (short)343343105;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox.IsSearchTimerEnabledProperty, value);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00025F84 File Offset: 0x00024184
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00026040 File Offset: 0x00024240
		public double LastValueExpirationTimerDelay
		{
			get
			{
				short num = (short)1421606913;
				if (num != 0)
				{
				}
				num = (short)596180992;
				short num2 = num;
				num = (short)1333602471;
				short num3 = num;
				num = (short)1374955687;
				switch (num3 == num)
				{
				}
				num = (short)737804288;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox.LastValueExpirationTimerDelayProperty);
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				short num;
				double num4;
				for (;;)
				{
					IL_0A:
					num = (short)2073427968;
					short num2 = num;
					int num3;
					switch (num3)
					{
					case 0:
						goto IL_F0;
					case 1:
						num4 = 100.0;
						num = (short)1957560320;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (value <= 100.0)
						{
							num = (short)201981953;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F2;
					}
					break;
				}
				IL_44:
				num4 = value;
				num = (short)974149273;
				short num5 = num;
				num = (short)1865701017;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_F0:
					break;
				default:
				{
					num = (short)1189609472;
					if (num != 0)
					{
					}
					num = (short)1589772290;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				}
				IL_F2:
				num = (short)1261502465;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox.LastValueExpirationTimerDelayProperty, num4);
				this._lastEnteredValueTimer.Interval = num4;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00026184 File Offset: 0x00024384
		public global::System.Collections.Generic.IEnumerable<string> ReversedHistoricalSearchOptions
		{
			get
			{
				short num = (short)1471048058;
				short num2 = num;
				num = (short)1779853690;
				switch (num2 == num)
				{
				}
				num = (short)395247617;
				if (num != 0)
				{
				}
				num = (short)2099445760;
				if (num != 0)
				{
				}
				num = (short)1570701312;
				short num3 = num;
				global::System.Collections.Generic.List<string> list = this._historicalSearchOptions.ToList<string>();
				list.Reverse();
				this.e();
				return list;
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00026244 File Offset: 0x00024444
		private void OnPaste(object A_0, global::System.Windows.DataObjectPastingEventArgs A_1)
		{
			short num;
			for (;;)
			{
				this._lastPressedKey = global::System.Windows.Input.Key.None;
				if (!this.IsSearchTimerEnabled)
				{
					goto IL_95;
				}
				num = (short)462204837;
				short num2 = num;
				num = (short)1031974821;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_49;
				}
			}
			IL_49:
			num = (short)1355481088;
			if (num != 0)
			{
			}
			num = (short)1264254976;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox.a(this._typingDelaytimer);
			return;
			IL_95:
			num = (short)1757741057;
			if (num != 0)
			{
			}
			this.d();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00026314 File Offset: 0x00024514
		private static void RMSearchBox_ContextMenuOpening(object A_0, global::System.Windows.Controls.ContextMenuEventArgs A_1)
		{
			short num = (short)731709441;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)100139009;
					if (num != 0)
					{
					}
					num = (short)507576320;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				}
				case 2:
				{
					num = (short)937336120;
					short num4 = num;
					num = (short)605134136;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)19464192;
						if (num != 0)
						{
						}
						A_1.Handled = true;
						num = (short)2087976960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					flag = (null != null);
					goto IL_FB;
				}
				IL_85:
				global::System.Windows.UIElement uielement = global::System.Windows.Input.Mouse.DirectlyOver as global::System.Windows.UIElement;
				if (uielement == null)
				{
					num = (short)816644099;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				flag = (uielement.GetSelfAndAncestors().FirstOrDefault(new global::System.Func<global::System.Windows.DependencyObject, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox.<>c.<>9.a)) != null);
				IL_FB:
				if (flag)
				{
					break;
				}
				num = (short)424869890;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00026488 File Offset: 0x00024688
		protected override void OnPreviewKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)190382080;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_C3;
				case 1:
					if (e.Key == global::System.Windows.Input.Key.Return)
					{
						num = (short)1100349442;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C5;
				case 2:
					num = (short)785121281;
					if (num != 0)
					{
					}
					this.d();
					num = (short)2102788096;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_44;
			}
			IL_C3:
			IL_C5:
			num = (short)1063647407;
			short num4 = num;
			num = (short)1078524079;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C3;
			default:
				num = (short)885522432;
				if (num != 0)
				{
				}
				this._lastPressedKey = e.Key;
				return;
			}
			IL_44:
			this.OnKeyDown(e);
			num = (short)1679818753;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000265B0 File Offset: 0x000247B0
		private void RMSearchBox_DropDownOpened(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1398079491;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B2;
				case 1:
					if (this.IsSearchTimerEnabled)
					{
						num = (short)521732098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B2;
				case 2:
					this._typingDelaytimer.Stop();
					num = (short)1659174912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1205927937;
					if (num != 0)
					{
					}
					num = (short)100794368;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_8F;
					}
					continue;
				}
				case 4:
					num = (short)228130817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_138;
				}
				IL_8F:
				if (!base.HasItems)
				{
					num = (short)242024452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_138;
				IL_B2:
				this._lastEnteredValueTimer.Stop();
				base.IsDropDownOpen = false;
				num = (short)196018181;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_138:
				num = (short)215860459;
				short num4 = num;
				num = (short)9094379;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_16C;
				}
			}
			IL_16C:
			num = (short)1360920576;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00026740 File Offset: 0x00024940
		protected override void OnSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					bool flag;
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						global::System.Windows.Controls.TextBox textBox = this._textBox;
						if (textBox == null)
						{
							num2 = (short)46071811;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						flag = (textBox.CaretIndex != 0);
						goto IL_B4;
					}
					case 2:
					{
						num2 = (short)982546741;
						short num3 = num2;
						num2 = (short)958101813;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5D;
						default:
							num2 = (short)1746337793;
							if (num2 != 0)
							{
							}
							num2 = (short)1495203840;
							if (num2 != 0)
							{
							}
							num2 = (short)154009600;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						flag = true;
						goto IL_B4;
					}
					goto IL_20;
					IL_B4:
					if (!flag)
					{
						goto IL_154;
					}
					num2 = (short)1224015874;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_154:
				this._textBox.Select(0, 0);
				this._textBox.CaretIndex = this._textBox.Text.Length;
				return;
			}
			IL_20:
			num2 = (short)691077120;
			short num4 = num2;
			base.OnSelectionChanged(e);
			this.d();
			base.IsDropDownOpen = false;
			IL_5D:
			num2 = (short)1807482881;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000268CC File Offset: 0x00024ACC
		private void RMSearchBox_MouseRightButtonDown(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)6479226;
			short num2 = num;
			num = (short)1598741882;
			switch (num2 == num)
			{
			}
			num = (short)817627137;
			if (num != 0)
			{
			}
			num = (short)913178624;
			if (num != 0)
			{
			}
			num = (short)1261240320;
			short num3 = num;
			base.Focus();
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00026980 File Offset: 0x00024B80
		private void RMSearchBox_MouseLeftButtonDown(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)1950547969;
			if (num != 0)
			{
			}
			num = (short)390665337;
			short num2 = num;
			num = (short)1956582521;
			switch (num2 == num)
			{
			}
			num = (short)441974784;
			if (num != 0)
			{
			}
			num = (short)1998454784;
			short num3 = num;
			base.Focus();
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00026A30 File Offset: 0x00024C30
		private void RMSearchBox_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 14;
			short num = (short)953614337;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_183;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				case 2:
					if (this._clearSearchTermButton != null)
					{
						num = (short)343277572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_73;
				case 3:
					goto IL_73;
				case 4:
					this._clearSearchTermButton.Click += this.ClearSearchTermButton_Click;
					num = (short)1467351043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this._typingDelaytimer.Elapsed += this.Timer_Elapsed;
					num = (short)2092236800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)1757366734;
					short num3 = num;
					num = (short)984566222;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1004077057;
						if (num != 0)
						{
						}
						num = (short)1781727232;
						if (num != 0)
						{
						}
						if (this._textBox == null)
						{
							num = (short)1519976455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20C;
					}
					break;
				}
				case 7:
					return;
				}
				IL_4E:
				if (this.IsSearchTimerEnabled)
				{
					num = (short)1753546757;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_183;
				IL_73:
				num = (short)145948678;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_183:
				this._textBox = global::Motorola.CommonCPS.RadioManagement.Controls.UiHelpers.UiHelper.FindChild<global::System.Windows.Controls.TextBox>(this);
				this._clearSearchTermButton = (base.GetTemplateChild(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쒧쾩춫\udcadힱ햳쒵\udbb7특\udbbd늿꿁蛃독볇뻉ꏋꃍ", a_)) as global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton);
				this._magnifierButton = (base.GetTemplateChild(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즧충슫잭횯\udbb1톳쒵ힹ\uddbb\ud9bdꖿ", a_)) as global::System.Windows.Controls.Button);
				num = (short)217513986;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_20C:
			num = (short)1817903104;
			short num4 = num;
			this._textBox.TextChanged += this.TextBox_TextChanged;
			global::System.Windows.DataObject.AddPastingHandler(this._textBox, new global::System.Windows.DataObjectPastingEventHandler(this.OnPaste));
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00026CA4 File Offset: 0x00024EA4
		private void TextBox_TextChanged(object A_0, global::System.Windows.Controls.TextChangedEventArgs A_1)
		{
			short num = (short)1342046210;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_198;
				case 1:
				{
					if (!string.IsNullOrEmpty(base.Text))
					{
						num = (short)1887305732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this._clearSearchTermButton.Visibility = global::System.Windows.Visibility.Collapsed;
					this._magnifierButton.Visibility = global::System.Windows.Visibility.Visible;
					num = (short)893242841;
					short num3 = num;
					num = (short)1852886489;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_122;
					default:
						num = (short)1174142976;
						if (num != 0)
						{
						}
						num = (short)1157103616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 3:
					goto IL_1D3;
				case 4:
					this._magnifierButton.Visibility = global::System.Windows.Visibility.Collapsed;
					this._clearSearchTermButton.Visibility = global::System.Windows.Visibility.Visible;
					num = (short)1884684296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (this.IsSearchTimerEnabled)
					{
						num = (short)671154179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_241;
				case 6:
					return;
				case 7:
					return;
				case 8:
					goto IL_122;
				case 9:
					if (this._clearSearchTermButton == null)
					{
						num = (short)860291078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)755957761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4C:
				if (this._magnifierButton == null)
				{
					num = (short)616366087;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2017132544;
				short num4 = num;
				num = (short)1528496137;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_198:
				num = (short)642056197;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_122:
				goto IL_198;
			}
			return;
			IL_1D3:
			num = (short)1532952577;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox.a(this._typingDelaytimer);
			return;
			IL_241:
			this.d();
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00026EF8 File Offset: 0x000250F8
		private void ClearSearchTermButton_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num;
			for (;;)
			{
				base.Text = string.Empty;
				if (base.SelectedValue != null)
				{
					goto IL_BB;
				}
				num = (short)1626480181;
				short num2 = num;
				num = (short)1516576309;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_4D;
				}
			}
			IL_4D:
			num = (short)1942487041;
			if (num != 0)
			{
			}
			num = (short)1175388160;
			short num3 = num;
			num = (short)1515323392;
			if (num != 0)
			{
			}
			this.d();
			return;
			IL_BB:
			base.SelectedValue = null;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00026FC8 File Offset: 0x000251C8
		private void e()
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this._lastPressedKey != global::System.Windows.Input.Key.Space)
						{
							num2 = (short)190251016;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
					{
						num2 = (short)1158152193;
						if (num2 != 0)
						{
						}
						num2 = (short)1011928989;
						short num3 = num2;
						num2 = (short)232574877;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_40;
						default:
						{
							num2 = (short)1889796096;
							if (num2 != 0)
							{
							}
							if (this._textBox == null)
							{
								num2 = (short)286261254;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)610795520;
							short num4 = num2;
							this._textBox.Focus();
							num2 = (short)1043988483;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						return;
					case 3:
						if (this._textBox.CaretIndex == 0)
						{
							num2 = (short)1173094407;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 4:
						num2 = (short)972881920;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						if (this._lastPressedKey != global::System.Windows.Input.Key.Delete)
						{
							num2 = (short)1849294852;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 6:
						return;
					case 7:
						num2 = (short)796917765;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						this._textBox.CaretIndex = this._textBox.Text.Length;
						num2 = (short)971571202;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_34;
				}
				return;
			}
			IL_34:
			base.Text = this._lastEnteredValue;
			IL_40:
			num2 = (short)793903105;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000271F0 File Offset: 0x000253F0
		private void RMSearchBox_Unloaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)328236347;
			short num2 = num;
			num = (short)1862303035;
			switch (num2 == num)
			{
			}
			num = (short)774242304;
			if (num != 0)
			{
			}
			num = (short)1563951105;
			if (num != 0)
			{
			}
			num = (short)1287323648;
			short num3 = num;
			this._lastEnteredValueTimer.Close();
			this._typingDelaytimer.Close();
			this._lastEnteredValue = null;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000272B4 File Offset: 0x000254B4
		private void LastEnteredValueTimer_Elapsed(object A_0, global::System.Timers.ElapsedEventArgs A_1)
		{
			short num = (short)1737514100;
			short num2 = num;
			num = (short)1587108980;
			switch (num2 == num)
			{
			}
			num = (short)1919614977;
			if (num != 0)
			{
			}
			num = (short)798752768;
			if (num != 0)
			{
			}
			num = (short)1692139520;
			short num3 = num;
			base.Dispatcher.BeginInvoke(new global::System.Action(this.b), global::System.Array.Empty<object>());
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0002737C File Offset: 0x0002557C
		private void RMSearchableComboBox_LostFocus(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1799687153;
			short num2 = num;
			num = (short)1801260017;
			switch (num2 == num)
			{
			}
			num = (short)1205469185;
			if (num != 0)
			{
			}
			num = (short)753795072;
			if (num != 0)
			{
			}
			num = (short)1054015488;
			short num3 = num;
			this._lastEnteredValueTimer.Stop();
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00027430 File Offset: 0x00025630
		private static void OnLastValueExpirationTimerDelayChanged(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox rmsearchBox;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1614801104;
					short num3 = num2;
					num2 = (short)1853941968;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)2115108864;
						if (num2 != 0)
						{
						}
						num2 = (short)24772608;
						short num4 = num2;
						num2 = (short)1456275457;
						if (num2 != 0)
						{
						}
						rmsearchBox.LastValueExpirationTimerDelay = (double)A_1.NewValue;
						num2 = (short)1633615874;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					if (rmsearchBox != null)
					{
						num2 = (short)1818230784;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			rmsearchBox = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox);
			num2 = (short)587857921;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00027558 File Offset: 0x00025758
		private static void OnTimerDelayChanged(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox rmsearchBox;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1580597249;
					if (num2 != 0)
					{
					}
					num2 = (short)1115312266;
					short num3 = num2;
					num2 = (short)1020416138;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)1008205824;
						short num4 = num2;
						num2 = (short)1213857792;
						if (num2 != 0)
						{
						}
						rmsearchBox.TimerDelay = (double)A_1.NewValue;
						num2 = (short)1463943170;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					if (rmsearchBox != null)
					{
						num2 = (short)504233984;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			rmsearchBox = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox);
			num2 = (short)1049427969;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00027680 File Offset: 0x00025880
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox rmsearchBox;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1883684999;
					short num3 = num2;
					num2 = (short)64405639;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)1159790592;
						short num4 = num2;
						num2 = (short)1302396928;
						if (num2 != 0)
						{
						}
						rmsearchBox.IsSearchTimerEnabled = (bool)A_1.NewValue;
						num2 = (short)478085122;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					if (rmsearchBox != null)
					{
						num2 = (short)1786118144;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			rmsearchBox = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox);
			num2 = (short)316080129;
			if (num2 != 0)
			{
			}
			num2 = (short)162791425;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000277A8 File Offset: 0x000259A8
		private void Timer_Elapsed(object A_0, global::System.Timers.ElapsedEventArgs A_1)
		{
			short num = (short)1420223969;
			short num2 = num;
			num = (short)1329063393;
			switch (num2 == num)
			{
			}
			num = (short)326172672;
			short num3 = num;
			num = (short)245891073;
			if (num != 0)
			{
			}
			num = (short)1359740928;
			if (num != 0)
			{
			}
			base.Dispatcher.BeginInvoke(new global::System.Action(this.a), global::System.Array.Empty<object>());
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0002786C File Offset: 0x00025A6C
		private static void a(global::System.Timers.Timer A_0)
		{
			short num = (short)1169779187;
			short num2 = num;
			num = (short)968124915;
			switch (num2 == num)
			{
			}
			num = (short)638451712;
			short num3 = num;
			num = (short)477429761;
			if (num != 0)
			{
			}
			num = (short)603848704;
			if (num != 0)
			{
			}
			A_0.Close();
			A_0.Start();
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00027920 File Offset: 0x00025B20
		private void d()
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
					goto IL_BB;
				case 1:
				{
					global::System.EventHandler<global::System.EventArgs> searchTriggered = this.SearchTriggered;
					if (searchTriggered != null)
					{
						searchTriggered(this, global::System.EventArgs.Empty);
						num2 = (short)1080164352;
						short num3 = num2;
						num2 = (short)581435392;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1366813012;
					short num4 = num2;
					num2 = (short)1876552020;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BB;
					default:
						num2 = (short)993132544;
						if (num2 != 0)
						{
						}
						num2 = (short)410976258;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_121;
				}
				goto IL_1C;
			}
			IL_BB:
			IL_121:
			base.Dispatcher.BeginInvoke(new global::System.Action(this.c), global::System.Array.Empty<object>());
			return;
			IL_1C:
			num2 = (short)2025455617;
			if (num2 != 0)
			{
			}
			this._typingDelaytimer.Close();
			num2 = (short)2038038529;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00027A70 File Offset: 0x00025C70
		private void c()
		{
			short num;
			try
			{
				num = (short)436338699;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					switch (num2)
					{
					case 0:
						if (!string.IsNullOrEmpty(this._lastEnteredValue))
						{
							num = (short)24182788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BA;
					case 1:
						if (this._lastPressedKey != global::System.Windows.Input.Key.Back)
						{
							num = (short)2099904525;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36E;
					case 2:
						num = (short)1706098689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_385;
					case 4:
						num = (short)115474440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (this._historicalSearchOptions.Contains(text))
						{
							num = (short)265355282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12F;
					case 6:
						goto IL_266;
					case 7:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)615055362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36E;
					case 8:
						if (base.Text.StartsWith(this._lastEnteredValue))
						{
							num = (short)224198672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BA;
					case 9:
						this._historicalSearchOptions.RemoveAt(0);
						num = (short)670564358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_36E;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_72;
						}
						continue;
					case 12:
						goto IL_2BA;
					case 13:
					{
						num = (short)797030610;
						short num3 = num;
						num = (short)1059961042;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_369;
						default:
							num = (short)1373372416;
							if (num != 0)
							{
							}
							num = (short)1349517327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 14:
						goto IL_369;
					case 15:
						if (this._historicalSearchOptions.Count == 10)
						{
							num = (short)1783955465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_266;
					case 16:
						this._historicalSearchOptions.RemoveAt(this._historicalSearchOptions.Count - 1);
						num = (short)289800204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)1534590976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						int index = this._historicalSearchOptions.IndexOf(text);
						this._historicalSearchOptions.RemoveAt(index);
						num = (short)831324174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_72:
					if (this._historicalSearchOptions.Any<string>())
					{
						num = (short)69664785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2BA;
					IL_12F:
					num = (short)1330642951;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_369:
					goto IL_12F;
					IL_266:
					this._historicalSearchOptions.Add(text);
					global::Motorola.CommonCPS.RadioManagement.Controls.RMSearchBox.a(this._lastEnteredValueTimer);
					this._lastEnteredValue = base.Text;
					base.ItemsSource = null;
					base.ItemsSource = this.ReversedHistoricalSearchOptions;
					num = (short)522780682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BA:
					text = base.Text.Trim();
					num = (short)1843920901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36E:
					num = (short)53477379;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_385:;
			}
			catch (global::System.Exception ex)
			{
				global::System.Console.WriteLine(ex.Message);
			}
			num = (short)2145845248;
			short num4 = num;
			num = (short)748290049;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00027E80 File Offset: 0x00026080
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b()
		{
			short num = (short)2133373139;
			short num2 = num;
			num = (short)432255187;
			switch (num2 == num)
			{
			}
			num = (short)480509952;
			short num3 = num;
			num = (short)765198337;
			if (num != 0)
			{
			}
			num = (short)2020671488;
			if (num != 0)
			{
			}
			this._lastEnteredValue = string.Empty;
			this._lastEnteredValueTimer.Close();
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00027F44 File Offset: 0x00026144
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a()
		{
			short num = (short)1890170951;
			short num2 = num;
			num = (short)2036054087;
			switch (num2 == num)
			{
			}
			num = (short)406847488;
			short num3 = num;
			num = (short)1652097024;
			if (num != 0)
			{
			}
			num = (short)1598488577;
			if (num != 0)
			{
			}
			this.c();
			this.d();
		}

		// Token: 0x040000A0 RID: 160
		private const int HistoricalSearchCapacity = 10;

		// Token: 0x040000A1 RID: 161
		private const double DefaultTimerValue = 1000.0;

		// Token: 0x040000A2 RID: 162
		private const double MinimalTimerValue = 100.0;

		// Token: 0x040000A4 RID: 164
		private readonly global::System.Timers.Timer _typingDelaytimer;

		// Token: 0x040000A5 RID: 165
		private readonly global::System.Timers.Timer _lastEnteredValueTimer;

		// Token: 0x040000A6 RID: 166
		private readonly global::System.Collections.Generic.List<string> _historicalSearchOptions;

		// Token: 0x040000A7 RID: 167
		private string _lastEnteredValue = string.Empty;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Controls.TextBox _textBox;

		// Token: 0x040000A9 RID: 169
		private global::Motorola.CommonCPS.RadioManagement.Controls.RMLinkButton _clearSearchTermButton;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Controls.Button _magnifierButton;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Input.Key _lastPressedKey;

		// Token: 0x040000AC RID: 172
		public static readonly global::System.Windows.DependencyProperty TimerDelayProperty;

		// Token: 0x040000AD RID: 173
		public static readonly global::System.Windows.DependencyProperty IsSearchTimerEnabledProperty;

		// Token: 0x040000AE RID: 174
		public static readonly global::System.Windows.DependencyProperty LastValueExpirationTimerDelayProperty;
	}
}
