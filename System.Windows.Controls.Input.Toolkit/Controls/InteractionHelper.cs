using System;
using System.Windows.Input;

namespace System.Windows.Controls
{
	// Token: 0x02000019 RID: 25
	internal sealed class InteractionHelper
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00006A83 File Offset: 0x00004C83
		// (set) Token: 0x06000177 RID: 375 RVA: 0x00006A8B File Offset: 0x00004C8B
		public global::System.Windows.Controls.Control Control { get; private set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00006A94 File Offset: 0x00004C94
		// (set) Token: 0x06000179 RID: 377 RVA: 0x00006A9C File Offset: 0x00004C9C
		public bool IsFocused { get; private set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00006AA5 File Offset: 0x00004CA5
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00006AAD File Offset: 0x00004CAD
		public bool IsMouseOver { get; private set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00006AB6 File Offset: 0x00004CB6
		// (set) Token: 0x0600017D RID: 381 RVA: 0x00006ABE File Offset: 0x00004CBE
		public bool IsReadOnly { get; private set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00006AC7 File Offset: 0x00004CC7
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00006ACF File Offset: 0x00004CCF
		public bool IsPressed { get; private set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00006AD8 File Offset: 0x00004CD8
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00006AE0 File Offset: 0x00004CE0
		private global::System.DateTime LastClickTime { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00006AE9 File Offset: 0x00004CE9
		// (set) Token: 0x06000183 RID: 387 RVA: 0x00006AF1 File Offset: 0x00004CF1
		private global::System.Windows.Point LastClickPosition { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00006AFA File Offset: 0x00004CFA
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00006B02 File Offset: 0x00004D02
		public int ClickCount { get; private set; }

		// Token: 0x06000186 RID: 390 RVA: 0x00006B0B File Offset: 0x00004D0B
		public InteractionHelper(global::System.Windows.Controls.Control control)
		{
			this.Control = control;
			this._updateVisualState = (control as global::System.Windows.Controls.IUpdateVisualState);
			control.Loaded += this.OnLoaded;
			control.IsEnabledChanged += this.OnIsEnabledChanged;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00006B4A File Offset: 0x00004D4A
		private void UpdateVisualState(bool useTransitions)
		{
			if (this._updateVisualState != null)
			{
				this._updateVisualState.UpdateVisualState(useTransitions);
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00006B60 File Offset: 0x00004D60
		public void UpdateVisualStateBase(bool useTransitions)
		{
			if (!this.Control.IsEnabled)
			{
				global::System.Windows.Controls.VisualStates.GoToState(this.Control, useTransitions, new string[]
				{
					"Disabled",
					"Normal"
				});
			}
			else if (this.IsReadOnly)
			{
				global::System.Windows.Controls.VisualStates.GoToState(this.Control, useTransitions, new string[]
				{
					"ReadOnly",
					"Normal"
				});
			}
			else if (this.IsPressed)
			{
				global::System.Windows.Controls.VisualStates.GoToState(this.Control, useTransitions, new string[]
				{
					"Pressed",
					"MouseOver",
					"Normal"
				});
			}
			else if (this.IsMouseOver)
			{
				global::System.Windows.Controls.VisualStates.GoToState(this.Control, useTransitions, new string[]
				{
					"MouseOver",
					"Normal"
				});
			}
			else
			{
				global::System.Windows.Controls.VisualStates.GoToState(this.Control, useTransitions, new string[]
				{
					"Normal"
				});
			}
			if (this.IsFocused)
			{
				global::System.Windows.Controls.VisualStates.GoToState(this.Control, useTransitions, new string[]
				{
					"Focused",
					"Unfocused"
				});
				return;
			}
			global::System.Windows.Controls.VisualStates.GoToState(this.Control, useTransitions, new string[]
			{
				"Unfocused"
			});
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00006CA7 File Offset: 0x00004EA7
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.UpdateVisualState(false);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00006CB0 File Offset: 0x00004EB0
		private void OnIsEnabledChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (!(bool)e.NewValue)
			{
				this.IsPressed = false;
				this.IsMouseOver = false;
				this.IsFocused = false;
			}
			this.UpdateVisualState(true);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00006CE9 File Offset: 0x00004EE9
		public void OnIsReadOnlyChanged(bool value)
		{
			this.IsReadOnly = value;
			if (!value)
			{
				this.IsPressed = false;
				this.IsMouseOver = false;
				this.IsFocused = false;
			}
			this.UpdateVisualState(true);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00006D11 File Offset: 0x00004F11
		public void OnApplyTemplateBase()
		{
			this.UpdateVisualState(false);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00006D1C File Offset: 0x00004F1C
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

		// Token: 0x0600018E RID: 398 RVA: 0x00006D4E File Offset: 0x00004F4E
		public void OnGotFocusBase()
		{
			this.UpdateVisualState(true);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00006D58 File Offset: 0x00004F58
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

		// Token: 0x06000190 RID: 400 RVA: 0x00006D8A File Offset: 0x00004F8A
		public void OnLostFocusBase()
		{
			this.IsPressed = false;
			this.UpdateVisualState(true);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00006D9C File Offset: 0x00004F9C
		public bool AllowMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			bool isEnabled = this.Control.IsEnabled;
			if (isEnabled)
			{
				this.IsMouseOver = true;
			}
			return isEnabled;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00006DCE File Offset: 0x00004FCE
		public void OnMouseEnterBase()
		{
			this.UpdateVisualState(true);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00006DD8 File Offset: 0x00004FD8
		public bool AllowMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			bool isEnabled = this.Control.IsEnabled;
			if (isEnabled)
			{
				this.IsMouseOver = false;
			}
			return isEnabled;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00006E0A File Offset: 0x0000500A
		public void OnMouseLeaveBase()
		{
			this.UpdateVisualState(true);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00006E14 File Offset: 0x00005014
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

		// Token: 0x06000196 RID: 406 RVA: 0x00006EF0 File Offset: 0x000050F0
		public void OnMouseLeftButtonDownBase()
		{
			this.UpdateVisualState(true);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00006EFC File Offset: 0x000050FC
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

		// Token: 0x06000198 RID: 408 RVA: 0x00006F2E File Offset: 0x0000512E
		public void OnMouseLeftButtonUpBase()
		{
			this.UpdateVisualState(true);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00006F37 File Offset: 0x00005137
		public bool AllowKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			return this.Control.IsEnabled;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00006F52 File Offset: 0x00005152
		public bool AllowKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			return this.Control.IsEnabled;
		}

		// Token: 0x04000075 RID: 117
		private const double SequentialClickThresholdInMilliseconds = 500.0;

		// Token: 0x04000076 RID: 118
		private const double SequentialClickThresholdInPixelsSquared = 9.0;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Controls.IUpdateVisualState _updateVisualState;
	}
}
