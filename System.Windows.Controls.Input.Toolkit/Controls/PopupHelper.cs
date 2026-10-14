using System;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace System.Windows.Controls
{
	// Token: 0x02000013 RID: 19
	internal class PopupHelper
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00005CE3 File Offset: 0x00003EE3
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00005CEB File Offset: 0x00003EEB
		public bool UsesClosingVisualState { get; private set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00005CF4 File Offset: 0x00003EF4
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00005CFC File Offset: 0x00003EFC
		private global::System.Windows.Controls.Control Parent { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000126 RID: 294 RVA: 0x00005D05 File Offset: 0x00003F05
		// (set) Token: 0x06000127 RID: 295 RVA: 0x00005D0D File Offset: 0x00003F0D
		public double MaxDropDownHeight { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00005D16 File Offset: 0x00003F16
		// (set) Token: 0x06000129 RID: 297 RVA: 0x00005D1E File Offset: 0x00003F1E
		public global::System.Windows.Controls.Primitives.Popup Popup { get; private set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00005D27 File Offset: 0x00003F27
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00005D34 File Offset: 0x00003F34
		public bool IsOpen
		{
			get
			{
				return this.Popup.IsOpen;
			}
			set
			{
				this.Popup.IsOpen = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00005D42 File Offset: 0x00003F42
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00005D4A File Offset: 0x00003F4A
		private global::System.Windows.FrameworkElement PopupChild { get; set; }

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x0600012E RID: 302 RVA: 0x00005D53 File Offset: 0x00003F53
		// (remove) Token: 0x0600012F RID: 303 RVA: 0x00005D6C File Offset: 0x00003F6C
		public event global::System.EventHandler Closed;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000130 RID: 304 RVA: 0x00005D85 File Offset: 0x00003F85
		// (remove) Token: 0x06000131 RID: 305 RVA: 0x00005D9E File Offset: 0x00003F9E
		public event global::System.EventHandler FocusChanged;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000132 RID: 306 RVA: 0x00005DB7 File Offset: 0x00003FB7
		// (remove) Token: 0x06000133 RID: 307 RVA: 0x00005DD0 File Offset: 0x00003FD0
		public event global::System.EventHandler UpdateVisualStates;

		// Token: 0x06000134 RID: 308 RVA: 0x00005DE9 File Offset: 0x00003FE9
		public PopupHelper(global::System.Windows.Controls.Control parent)
		{
			this.Parent = parent;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00005DF8 File Offset: 0x00003FF8
		public PopupHelper(global::System.Windows.Controls.Control parent, global::System.Windows.Controls.Primitives.Popup popup) : this(parent)
		{
			this.Popup = popup;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00005E08 File Offset: 0x00004008
		public void Arrange()
		{
			if (this.Popup == null || this.PopupChild == null || global::System.Windows.Application.Current == null)
			{
				return;
			}
			global::System.Windows.UIElement uielement = this.Parent;
			if (global::System.Windows.Application.Current.Windows.Count > 0)
			{
				uielement = global::System.Windows.Application.Current.Windows[0];
			}
			while (!(uielement is global::System.Windows.Window) && uielement != null)
			{
				uielement = (global::System.Windows.Media.VisualTreeHelper.GetParent(uielement) as global::System.Windows.UIElement);
			}
			global::System.Windows.Window window = uielement as global::System.Windows.Window;
			if (window == null)
			{
				return;
			}
			double actualWidth = window.ActualWidth;
			double actualHeight = window.ActualHeight;
			double num = this.PopupChild.ActualWidth;
			double num2 = this.PopupChild.ActualHeight;
			if (actualHeight == 0.0 || actualWidth == 0.0 || num == 0.0 || num2 == 0.0)
			{
				return;
			}
			double num3 = 0.0;
			double num4 = 0.0;
			double actualHeight2 = this.Parent.ActualHeight;
			double actualWidth2 = this.Parent.ActualWidth;
			double num5 = this.MaxDropDownHeight;
			if (double.IsInfinity(num5) || double.IsNaN(num5))
			{
				num5 = (actualHeight - actualHeight2) * 3.0 / 5.0;
			}
			num = global::System.Math.Min(num, actualWidth);
			num2 = global::System.Math.Min(num2, num5);
			num = global::System.Math.Max(actualWidth2, num);
			double num6 = num3;
			if (actualWidth < num6 + num)
			{
				num6 = actualWidth - num;
				num6 = global::System.Math.Max(0.0, num6);
			}
			bool flag = true;
			double num7 = num4 + actualHeight2;
			if (actualHeight < num7 + num2)
			{
				flag = false;
				num7 = num4 - num2;
				if (num7 < 0.0)
				{
					if (num4 < (actualHeight - actualHeight2) / 2.0)
					{
						flag = true;
						num7 = num4 + actualHeight2;
					}
					else
					{
						flag = false;
						num7 = num4 - num2;
					}
				}
			}
			num5 = (flag ? global::System.Math.Min(actualHeight - num7, num5) : global::System.Math.Min(num4, num5));
			this.Popup.HorizontalOffset = 0.0;
			this.Popup.VerticalOffset = 0.0;
			this.PopupChild.MinWidth = actualWidth2;
			this.PopupChild.MaxWidth = actualWidth;
			this.PopupChild.MinHeight = 0.0;
			this.PopupChild.MaxHeight = global::System.Math.Max(0.0, num5);
			this.PopupChild.Width = num;
			this.PopupChild.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Left;
			this.PopupChild.VerticalAlignment = global::System.Windows.VerticalAlignment.Top;
			global::System.Windows.Controls.Canvas.SetLeft(this.PopupChild, num6 - num3);
			global::System.Windows.Controls.Canvas.SetTop(this.PopupChild, num7 - num4);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000060A0 File Offset: 0x000042A0
		private void OnClosed(global::System.EventArgs e)
		{
			global::System.EventHandler closed = this.Closed;
			if (closed != null)
			{
				closed(this, e);
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000060C0 File Offset: 0x000042C0
		private void OnPopupClosedStateChanged(object sender, global::System.Windows.VisualStateChangedEventArgs e)
		{
			if (e != null && e.NewState != null && e.NewState.Name == "PopupClosed")
			{
				if (this.Popup != null)
				{
					this.Popup.IsOpen = false;
				}
				this.OnClosed(global::System.EventArgs.Empty);
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00006110 File Offset: 0x00004310
		public void BeforeOnApplyTemplate()
		{
			if (this.UsesClosingVisualState)
			{
				global::System.Windows.VisualStateGroup visualStateGroup = global::System.Windows.Controls.VisualStates.TryGetVisualStateGroup(this.Parent, "PopupStates");
				if (visualStateGroup != null)
				{
					visualStateGroup.CurrentStateChanged -= this.OnPopupClosedStateChanged;
					this.UsesClosingVisualState = false;
				}
			}
			if (this.Popup != null)
			{
				this.Popup.Closed -= this.Popup_Closed;
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00006174 File Offset: 0x00004374
		public void AfterOnApplyTemplate()
		{
			if (this.Popup != null)
			{
				this.Popup.Closed += this.Popup_Closed;
			}
			global::System.Windows.VisualStateGroup visualStateGroup = global::System.Windows.Controls.VisualStates.TryGetVisualStateGroup(this.Parent, "PopupStates");
			if (visualStateGroup != null)
			{
				visualStateGroup.CurrentStateChanged += this.OnPopupClosedStateChanged;
				this.UsesClosingVisualState = true;
			}
			if (this.Popup != null)
			{
				this.PopupChild = (this.Popup.Child as global::System.Windows.FrameworkElement);
				if (this.PopupChild != null)
				{
					this.PopupChild.GotFocus += this.PopupChild_GotFocus;
					this.PopupChild.LostFocus += this.PopupChild_LostFocus;
					this.PopupChild.MouseEnter += this.PopupChild_MouseEnter;
					this.PopupChild.MouseLeave += this.PopupChild_MouseLeave;
					this.PopupChild.SizeChanged += this.PopupChild_SizeChanged;
				}
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00006269 File Offset: 0x00004469
		private void PopupChild_SizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			this.Arrange();
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00006271 File Offset: 0x00004471
		private void OutsidePopup_MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.Popup != null)
			{
				this.Popup.IsOpen = false;
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00006287 File Offset: 0x00004487
		private void Popup_Closed(object sender, global::System.EventArgs e)
		{
			this.OnClosed(global::System.EventArgs.Empty);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00006294 File Offset: 0x00004494
		private void OnFocusChanged(global::System.EventArgs e)
		{
			global::System.EventHandler focusChanged = this.FocusChanged;
			if (focusChanged != null)
			{
				focusChanged(this, e);
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000062B4 File Offset: 0x000044B4
		private void OnUpdateVisualStates(global::System.EventArgs e)
		{
			global::System.EventHandler updateVisualStates = this.UpdateVisualStates;
			if (updateVisualStates != null)
			{
				updateVisualStates(this, e);
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000062D3 File Offset: 0x000044D3
		private void PopupChild_GotFocus(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.OnFocusChanged(global::System.EventArgs.Empty);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000062E0 File Offset: 0x000044E0
		private void PopupChild_LostFocus(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.OnFocusChanged(global::System.EventArgs.Empty);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000062ED File Offset: 0x000044ED
		private void PopupChild_MouseEnter(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			this.OnUpdateVisualStates(global::System.EventArgs.Empty);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000062FA File Offset: 0x000044FA
		private void PopupChild_MouseLeave(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			this.OnUpdateVisualStates(global::System.EventArgs.Empty);
		}
	}
}
