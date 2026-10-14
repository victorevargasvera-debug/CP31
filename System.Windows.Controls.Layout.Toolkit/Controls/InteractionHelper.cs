using System;
using System.Windows.Input;

namespace System.Windows.Controls
{
	// Token: 0x02000011 RID: 17
	internal sealed class InteractionHelper
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00006A44 File Offset: 0x00004C44
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00006A4C File Offset: 0x00004C4C
		public global::System.Windows.Controls.Control Control { get; private set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00006A55 File Offset: 0x00004C55
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00006A5D File Offset: 0x00004C5D
		public bool IsFocused { get; private set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00006A66 File Offset: 0x00004C66
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00006A6E File Offset: 0x00004C6E
		public bool IsMouseOver { get; private set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00006A77 File Offset: 0x00004C77
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00006A7F File Offset: 0x00004C7F
		public bool IsReadOnly { get; private set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00006A88 File Offset: 0x00004C88
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00006A90 File Offset: 0x00004C90
		public bool IsPressed { get; private set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00006A99 File Offset: 0x00004C99
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00006AA1 File Offset: 0x00004CA1
		private global::System.DateTime LastClickTime { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00006AAA File Offset: 0x00004CAA
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00006AB2 File Offset: 0x00004CB2
		private global::System.Windows.Point LastClickPosition { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00006ABB File Offset: 0x00004CBB
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00006AC3 File Offset: 0x00004CC3
		public int ClickCount { get; private set; }

		// Token: 0x06000119 RID: 281 RVA: 0x00006ACC File Offset: 0x00004CCC
		public InteractionHelper(global::System.Windows.Controls.Control control)
		{
			this.Control = control;
			this._updateVisualState = (control as global::System.Windows.Controls.IUpdateVisualState);
			control.Loaded += this.OnLoaded;
			control.IsEnabledChanged += this.OnIsEnabledChanged;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00006B0B File Offset: 0x00004D0B
		private void UpdateVisualState(bool useTransitions)
		{
			if (this._updateVisualState != null)
			{
				this._updateVisualState.UpdateVisualState(useTransitions);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00006B24 File Offset: 0x00004D24
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

		// Token: 0x0600011C RID: 284 RVA: 0x00006C6B File Offset: 0x00004E6B
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.UpdateVisualState(false);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00006C74 File Offset: 0x00004E74
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

		// Token: 0x0600011E RID: 286 RVA: 0x00006CAD File Offset: 0x00004EAD
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

		// Token: 0x0600011F RID: 287 RVA: 0x00006CD5 File Offset: 0x00004ED5
		public void OnApplyTemplateBase()
		{
			this.UpdateVisualState(false);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00006CE0 File Offset: 0x00004EE0
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

		// Token: 0x06000121 RID: 289 RVA: 0x00006D12 File Offset: 0x00004F12
		public void OnGotFocusBase()
		{
			this.UpdateVisualState(true);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00006D1C File Offset: 0x00004F1C
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

		// Token: 0x06000123 RID: 291 RVA: 0x00006D4E File Offset: 0x00004F4E
		public void OnLostFocusBase()
		{
			this.IsPressed = false;
			this.UpdateVisualState(true);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00006D60 File Offset: 0x00004F60
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

		// Token: 0x06000125 RID: 293 RVA: 0x00006D92 File Offset: 0x00004F92
		public void OnMouseEnterBase()
		{
			this.UpdateVisualState(true);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00006D9C File Offset: 0x00004F9C
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

		// Token: 0x06000127 RID: 295 RVA: 0x00006DCE File Offset: 0x00004FCE
		public void OnMouseLeaveBase()
		{
			this.UpdateVisualState(true);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00006DD8 File Offset: 0x00004FD8
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

		// Token: 0x06000129 RID: 297 RVA: 0x00006EB4 File Offset: 0x000050B4
		public void OnMouseLeftButtonDownBase()
		{
			this.UpdateVisualState(true);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00006EC0 File Offset: 0x000050C0
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

		// Token: 0x0600012B RID: 299 RVA: 0x00006EF2 File Offset: 0x000050F2
		public void OnMouseLeftButtonUpBase()
		{
			this.UpdateVisualState(true);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00006EFB File Offset: 0x000050FB
		public bool AllowKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			return this.Control.IsEnabled;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00006F16 File Offset: 0x00005116
		public bool AllowKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e == null)
			{
				throw new global::System.ArgumentNullException("e");
			}
			return this.Control.IsEnabled;
		}

		// Token: 0x04000058 RID: 88
		private const double SequentialClickThresholdInMilliseconds = 500.0;

		// Token: 0x04000059 RID: 89
		private const double SequentialClickThresholdInPixelsSquared = 9.0;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Controls.IUpdateVisualState _updateVisualState;
	}
}
