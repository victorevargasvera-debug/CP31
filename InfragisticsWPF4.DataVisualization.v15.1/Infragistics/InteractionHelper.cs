using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Infragistics
{
	// Token: 0x020000E5 RID: 229
	public sealed class InteractionHelper
	{
		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x0002A520 File Offset: 0x00028720
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x0002A528 File Offset: 0x00028728
		public global::System.Windows.Controls.Control Control { get; private set; }

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x0002A531 File Offset: 0x00028731
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x0002A539 File Offset: 0x00028739
		public bool IsFocused { get; private set; }

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x0002A542 File Offset: 0x00028742
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x0002A54A File Offset: 0x0002874A
		public bool IsMouseOver { get; private set; }

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x0002A553 File Offset: 0x00028753
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x0002A55B File Offset: 0x0002875B
		public bool IsReadOnly { get; private set; }

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x0002A564 File Offset: 0x00028764
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x0002A56C File Offset: 0x0002876C
		public bool IsPressed { get; private set; }

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0002A575 File Offset: 0x00028775
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x0002A57D File Offset: 0x0002877D
		private global::System.DateTime LastClickTime { get; set; }

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x0002A586 File Offset: 0x00028786
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x0002A58E File Offset: 0x0002878E
		private global::System.Windows.Point LastClickPosition { get; set; }

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x0002A597 File Offset: 0x00028797
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x0002A59F File Offset: 0x0002879F
		public int ClickCount { get; private set; }

		// Token: 0x0600098F RID: 2447 RVA: 0x0002A5A8 File Offset: 0x000287A8
		public InteractionHelper(global::System.Windows.Controls.Control control)
		{
			this.Control = control;
			this._updateVisualState = (control as global::Infragistics.IUpdateVisualState);
			control.Loaded += this.OnLoaded;
			control.IsEnabledChanged += this.OnIsEnabledChanged;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0002A5E7 File Offset: 0x000287E7
		private void UpdateVisualState(bool useTransitions)
		{
			if (this._updateVisualState != null)
			{
				this._updateVisualState.UpdateVisualState(useTransitions);
			}
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0002A600 File Offset: 0x00028800
		public void UpdateVisualStateBase(bool useTransitions)
		{
			if (!this.Control.IsEnabled)
			{
				global::Infragistics.VisualStates.GoToState(this.Control, useTransitions, new string[]
				{
					"Disabled",
					"Normal"
				});
			}
			else if (this.IsReadOnly)
			{
				global::Infragistics.VisualStates.GoToState(this.Control, useTransitions, new string[]
				{
					"ReadOnly",
					"Normal"
				});
			}
			else if (this.IsPressed)
			{
				global::Infragistics.VisualStates.GoToState(this.Control, useTransitions, new string[]
				{
					"Pressed",
					"MouseOver",
					"Normal"
				});
			}
			else if (this.IsMouseOver)
			{
				global::Infragistics.VisualStates.GoToState(this.Control, useTransitions, new string[]
				{
					"MouseOver",
					"Normal"
				});
			}
			else
			{
				global::Infragistics.VisualStates.GoToState(this.Control, useTransitions, new string[]
				{
					"Normal"
				});
			}
			if (this.IsFocused)
			{
				global::Infragistics.VisualStates.GoToState(this.Control, useTransitions, new string[]
				{
					"Focused",
					"Unfocused"
				});
				return;
			}
			global::Infragistics.VisualStates.GoToState(this.Control, useTransitions, new string[]
			{
				"Unfocused"
			});
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0002A747 File Offset: 0x00028947
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.UpdateVisualState(false);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0002A750 File Offset: 0x00028950
		private void OnIsEnabledChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (!(bool)e.NewValue)
			{
				this.IsPressed = false;
				this.SetMouseOver(false);
				this.IsFocused = false;
			}
			this.UpdateVisualState(true);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0002A789 File Offset: 0x00028989
		public void OnIsReadOnlyChanged(bool value)
		{
			this.IsReadOnly = value;
			if (!value)
			{
				this.IsPressed = false;
				this.SetMouseOver(false);
				this.IsFocused = false;
			}
			this.UpdateVisualState(true);
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0002A7B1 File Offset: 0x000289B1
		private void SetMouseOver(bool isOver)
		{
			this.IsMouseOver = isOver;
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0002A7BA File Offset: 0x000289BA
		public void OnApplyTemplateBase()
		{
			this.UpdateVisualState(false);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0002A7C4 File Offset: 0x000289C4
		public bool AllowGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			bool isEnabled = this.Control.IsEnabled;
			if (isEnabled)
			{
				this.IsFocused = true;
			}
			return isEnabled;
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0002A7F6 File Offset: 0x000289F6
		public void OnGotFocusBase()
		{
			this.UpdateVisualState(true);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0002A800 File Offset: 0x00028A00
		public bool AllowLostFocus(global::System.Windows.RoutedEventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			bool isEnabled = this.Control.IsEnabled;
			if (isEnabled)
			{
				this.IsFocused = false;
			}
			return isEnabled;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0002A832 File Offset: 0x00028A32
		public void OnLostFocusBase()
		{
			this.IsPressed = false;
			this.UpdateVisualState(true);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0002A844 File Offset: 0x00028A44
		public bool AllowMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			bool isEnabled = this.Control.IsEnabled;
			if (isEnabled)
			{
				this.SetMouseOver(true);
			}
			return isEnabled;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0002A876 File Offset: 0x00028A76
		public void OnMouseEnterBase()
		{
			this.UpdateVisualState(true);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0002A880 File Offset: 0x00028A80
		public bool AllowMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			bool isEnabled = this.Control.IsEnabled;
			if (isEnabled)
			{
				this.SetMouseOver(false);
			}
			return isEnabled;
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0002A8B2 File Offset: 0x00028AB2
		public void OnMouseLeaveBase()
		{
			this.UpdateVisualState(true);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0002A8BC File Offset: 0x00028ABC
		public bool AllowMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			bool isEnabled = this.Control.IsEnabled;
			if (isEnabled)
			{
				global::System.DateTime utcNow = global::System.DateTime.UtcNow;
				global::System.Windows.Point position = e.GetPosition(this.Control);
				double totalMilliseconds = (utcNow - this.LastClickTime).TotalMilliseconds;
				global::System.Windows.Point lastClickPosition = this.LastClickPosition;
				double num = position.X - lastClickPosition.X;
				double num2 = position.Y - lastClickPosition.Y;
				double num3 = num * num + num2 * num2;
				if (totalMilliseconds < 500.0 && num3 < 9.0)
				{
					this.ClickCount++;
				}
				else
				{
					this.ClickCount = 1;
				}
				this.LastClickTime = utcNow;
				this.LastClickPosition = position;
				this.IsPressed = true;
			}
			else
			{
				this.ClickCount = 1;
			}
			return isEnabled;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0002A998 File Offset: 0x00028B98
		public void OnMouseLeftButtonDownBase()
		{
			this.UpdateVisualState(true);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0002A9A4 File Offset: 0x00028BA4
		public bool AllowMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			bool isEnabled = this.Control.IsEnabled;
			if (isEnabled)
			{
				this.IsPressed = false;
			}
			return isEnabled;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0002A9D6 File Offset: 0x00028BD6
		public void OnMouseLeftButtonUpBase()
		{
			this.UpdateVisualState(true);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0002A9DF File Offset: 0x00028BDF
		public bool AllowKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			return this.Control.IsEnabled;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0002A9FA File Offset: 0x00028BFA
		public bool AllowKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			return this.Control.IsEnabled;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0002AA18 File Offset: 0x00028C18
		public static global::System.Windows.Input.Key GetLogicalKey(global::System.Windows.FlowDirection flowDirection, global::System.Windows.Input.Key originalKey)
		{
			global::System.Windows.Input.Key result = originalKey;
			if (flowDirection == global::System.Windows.FlowDirection.RightToLeft)
			{
				switch (originalKey)
				{
				case global::System.Windows.Input.Key.Left:
					result = global::System.Windows.Input.Key.Right;
					break;
				case global::System.Windows.Input.Key.Right:
					result = global::System.Windows.Input.Key.Left;
					break;
				}
			}
			return result;
		}

		// Token: 0x04000359 RID: 857
		private const double SequentialClickThresholdInMilliseconds = 500.0;

		// Token: 0x0400035A RID: 858
		private const double SequentialClickThresholdInPixelsSquared = 9.0;

		// Token: 0x0400035B RID: 859
		private global::Infragistics.IUpdateVisualState _updateVisualState;
	}
}
