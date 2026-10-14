using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Input;
using Infragistics.Windows.Internal;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x020000DD RID: 221
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class PopupResizer : global::System.Windows.Controls.Control
	{
		// Token: 0x06000818 RID: 2072 RVA: 0x0001C8A0 File Offset: 0x0001AAA0
		static PopupResizer()
		{
			global::System.Windows.Style style = new global::System.Windows.Style();
			style.Seal();
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Primitives.PopupResizer), new global::System.Windows.FrameworkPropertyMetadata(style));
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0001C975 File Offset: 0x0001AB75
		public PopupResizer()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Primitives.PopupResizer);
			base.IsTabStop = false;
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x0001C99B File Offset: 0x0001AB9B
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x0001C9AD File Offset: 0x0001ABAD
		public global::System.Windows.FrameworkElement ResizeElement
		{
			get
			{
				return (global::System.Windows.FrameworkElement)base.GetValue(global::Infragistics.Controls.Primitives.PopupResizer.ResizeElementProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Primitives.PopupResizer.ResizeElementProperty, value);
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0001C9BB File Offset: 0x0001ABBB
		private static void ResizeElementChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x0001C9BD File Offset: 0x0001ABBD
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x0001C9CF File Offset: 0x0001ABCF
		public global::System.Windows.Controls.Primitives.Popup Popup
		{
			get
			{
				return (global::System.Windows.Controls.Primitives.Popup)base.GetValue(global::Infragistics.Controls.Primitives.PopupResizer.PopupProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Primitives.PopupResizer.PopupProperty, value);
			}
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x0001C9DD File Offset: 0x0001ABDD
		private static void PopupChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x0001C9DF File Offset: 0x0001ABDF
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x0001C9F1 File Offset: 0x0001ABF1
		public global::Infragistics.Controls.Primitives.ResizerPosition Position
		{
			get
			{
				return (global::Infragistics.Controls.Primitives.ResizerPosition)base.GetValue(global::Infragistics.Controls.Primitives.PopupResizer.PositionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Primitives.PopupResizer.PositionProperty, value);
			}
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0001CA04 File Offset: 0x0001AC04
		private static void PositionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Primitives.PopupResizer popupResizer = (global::Infragistics.Controls.Primitives.PopupResizer)obj;
			popupResizer.EnsureVisualStates();
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0001CA20 File Offset: 0x0001AC20
		protected virtual void EndResize(bool cancel)
		{
			this._isMouseDown = false;
			this._isResizing = false;
			this._resizeElem.ReleaseMouseCapture();
			if (cancel && this.ResizeElement != null)
			{
				this.ResizeElement.Height = this._originalSize.Height;
				this.ResizeElement.Width = this._originalSize.Width;
			}
			this.OnPopupResized();
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0001CA84 File Offset: 0x0001AC84
		protected virtual void EnsureVisualStates()
		{
			bool flag = this.Position == global::Infragistics.Controls.Primitives.ResizerPosition.Above;
			if (flag)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Above", false);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Below", false);
			}
			bool flag2 = (this.ResizeElement != null) ? (this.ResizeElement.FlowDirection == global::System.Windows.FlowDirection.LeftToRight) : (base.FlowDirection == global::System.Windows.FlowDirection.LeftToRight);
			if (flag2)
			{
				if (flag)
				{
					global::System.Windows.VisualStateManager.GoToState(this, "AboveLTR", false);
					return;
				}
				global::System.Windows.VisualStateManager.GoToState(this, "LTR", false);
				return;
			}
			else
			{
				if (flag)
				{
					global::System.Windows.VisualStateManager.GoToState(this, "AboveRTL", false);
					return;
				}
				global::System.Windows.VisualStateManager.GoToState(this, "RTL", false);
				return;
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0001CB1C File Offset: 0x0001AD1C
		private void FlowDirectionChanged()
		{
			this.EnsureVisualStates();
			this._multiplier *= -1;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0001CB34 File Offset: 0x0001AD34
		private double CheckAndFixDiffWidth(double originalWidth, double diffWidth)
		{
			double x = this.ResizeElement.PointToScreen(new global::System.Windows.Point(0.0, 0.0)).X;
			global::System.Windows.Forms.Screen currentScreen = this.GetCurrentScreen();
			if (this.DoesGoBeyoundScreenBoundaries(originalWidth, diffWidth, currentScreen))
			{
				double screensWidth = this.GetScreensWidth(currentScreen);
				diffWidth = screensWidth - (x + originalWidth);
			}
			return diffWidth;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0001CB90 File Offset: 0x0001AD90
		private double GetScreensWidth(global::System.Windows.Forms.Screen currentScr)
		{
			int num = 0;
			global::System.Windows.Forms.Screen screen = global::System.Windows.Forms.Screen.AllScreens[num];
			double num2 = (double)screen.WorkingArea.Width;
			while (!screen.Equals(currentScr))
			{
				screen = global::System.Windows.Forms.Screen.AllScreens[++num];
				num2 += (double)screen.WorkingArea.Width;
			}
			return num2;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0001CBE4 File Offset: 0x0001ADE4
		private global::System.Windows.Forms.Screen GetCurrentScreen()
		{
			global::System.Windows.Point point = this.ResizeElement.PointToScreen(new global::System.Windows.Point(0.0, 0.0));
			return global::System.Windows.Forms.Screen.FromPoint(new global::System.Drawing.Point((int)point.X, (int)point.Y));
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0001CC30 File Offset: 0x0001AE30
		private bool DoesGoBeyoundScreenBoundaries(double originalWidth, double diffWidth, global::System.Windows.Forms.Screen currentScreen)
		{
			double num = this.ResizeElement.PointToScreen(new global::System.Windows.Point(0.0, 0.0)).X;
			double num2 = (double)currentScreen.WorkingArea.Width;
			num -= (double)currentScreen.WorkingArea.X;
			return num + originalWidth + diffWidth >= num2;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0001CC98 File Offset: 0x0001AE98
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this._resizeElem != null)
			{
				this._resizeElem.LostMouseCapture -= this.ResizableElement_LostMouseCapture;
				this._resizeElem.MouseLeftButtonUp -= this.ResizableElement_MouseLeftButtonUp;
				this._resizeElem.MouseLeftButtonDown -= this.ResizableElement_MouseLeftButtonDown;
				this._resizeElem.MouseMove -= this.ResizableElement_MouseMove;
			}
			this._flowDirectionTracker = null;
			this._resizeElem = (base.GetTemplateChild("ResizeElem") as global::System.Windows.FrameworkElement);
			if (this._resizeElem != null)
			{
				this._resizeElem.LostMouseCapture += this.ResizableElement_LostMouseCapture;
				this._resizeElem.MouseLeftButtonUp += this.ResizableElement_MouseLeftButtonUp;
				this._resizeElem.MouseLeftButtonDown += this.ResizableElement_MouseLeftButtonDown;
				this._resizeElem.MouseMove += this.ResizableElement_MouseMove;
				this._flowDirectionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this.ResizeElement, "FlowDirection", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.FlowDirectionChanged));
			}
			this.EnsureVisualStates();
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0001CDB8 File Offset: 0x0001AFB8
		private void ResizableElement_LostMouseCapture(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			this.EndResize(false);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0001CDC1 File Offset: 0x0001AFC1
		private void ResizableElement_MouseLeftButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.EndResize(false);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0001CDCA File Offset: 0x0001AFCA
		private void ResizableElement_MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.ResizeElement != null && !this.OnPopupResizing())
			{
				this._isMouseDown = ((global::System.Windows.UIElement)sender).CaptureMouse();
				e.Handled = this._isMouseDown;
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0001CDFC File Offset: 0x0001AFFC
		private void ResizableElement_MouseMove(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._isMouseDown)
			{
				global::System.Windows.UIElement uielement = this.Popup;
				if (uielement == null)
				{
					uielement = global::Infragistics.PlatformProxy.GetRootVisual(this.ResizeElement);
				}
				if (!this._isResizing)
				{
					double actualHeight = this.ResizeElement.ActualHeight;
					double actualWidth = this.ResizeElement.ActualWidth;
					if (double.IsNaN(actualWidth) || double.IsNaN(actualHeight) || (actualWidth == 0.0 && actualHeight == 0.0))
					{
						return;
					}
					this._isResizing = true;
					this._offsetPoint = e.GetPosition(uielement);
					this._originalSize = new global::System.Windows.Size(actualWidth, actualHeight);
					if (this.Popup != null)
					{
						this._originalTop = this.Popup.VerticalOffset;
					}
				}
				global::System.Windows.Point position = e.GetPosition(uielement);
				double x = position.X - this._offsetPoint.X;
				double y = position.Y - this._offsetPoint.Y;
				global::System.Windows.Point point = new global::System.Windows.Point(x, y);
				point.X = this.CheckAndFixDiffWidth(this._originalSize.Width, point.X);
				global::System.Windows.Size size = default(global::System.Windows.Size);
				size.Width = global::System.Math.Max(this._originalSize.Width - point.X, this.ResizeElement.MinWidth);
				size.Width = global::System.Math.Min(size.Width, this.ResizeElement.MaxWidth);
				size.Height = global::System.Math.Max(this._originalSize.Height - point.Y, this.ResizeElement.MinHeight);
				size.Height = global::System.Math.Min(size.Height, this.ResizeElement.MaxHeight);
				global::System.Windows.Size size2 = default(global::System.Windows.Size);
				size2.Width = global::System.Math.Max(this._originalSize.Width + point.X, this.ResizeElement.MinWidth);
				size2.Width = global::System.Math.Max(global::System.Math.Min(size2.Width, this.ResizeElement.MaxWidth), this.ResizeElement.MinWidth);
				size2.Height = global::System.Math.Max(this._originalSize.Height + point.Y, this.ResizeElement.MinHeight);
				size2.Height = global::System.Math.Min(size2.Height, this.ResizeElement.MaxHeight);
				point = new global::System.Windows.Point(this._originalSize.Width - size.Width, this._originalSize.Height - size.Height);
				global::System.Windows.Point point2 = default(global::System.Windows.Point);
				this.ResizeElement.Width = size2.Width;
				if (this.Popup != null)
				{
					if (global::System.Windows.SystemParameters.IsMenuDropRightAligned)
					{
						if (this.ResizeElement != null && this.ResizeElement.MinWidth <= size2.Width && size2.Width > 0.0)
						{
							this.Popup.HorizontalOffset = size2.Width;
						}
					}
					else
					{
						this.Popup.HorizontalOffset = 0.0;
					}
				}
				if (this.Position == global::Infragistics.Controls.Primitives.ResizerPosition.Above)
				{
					if (this.Popup != null)
					{
						if (size.Height != this.ResizeElement.MinHeight)
						{
							point2.Y = this._originalTop + point.Y;
							if (point2.Y == 0.0)
							{
								size.Height = this.ResizeElement.ActualHeight;
							}
							else if (size.Height < this.ResizeElement.MinHeight)
							{
								size.Height = this.ResizeElement.MinHeight;
								double num = this.ResizeElement.MinHeight - (this._originalSize.Height - point.Y);
								point2.Y = this._originalTop + point.Y - num;
							}
						}
						else
						{
							double num2 = this.ResizeElement.MinHeight - (this._originalSize.Height - point.Y);
							point2.Y = this._originalTop + point.Y - num2;
						}
						this.Popup.VerticalOffset = point2.Y;
					}
					this.ResizeElement.Height = size.Height;
					return;
				}
				this.ResizeElement.Height = size2.Height;
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x0600082F RID: 2095 RVA: 0x0001D24C File Offset: 0x0001B44C
		// (remove) Token: 0x06000830 RID: 2096 RVA: 0x0001D284 File Offset: 0x0001B484
		public event global::System.EventHandler<global::System.ComponentModel.CancelEventArgs> PopupResizing;

		// Token: 0x06000831 RID: 2097 RVA: 0x0001D2BC File Offset: 0x0001B4BC
		protected virtual bool OnPopupResizing()
		{
			if (this.PopupResizing != null)
			{
				global::System.ComponentModel.CancelEventArgs cancelEventArgs = new global::System.ComponentModel.CancelEventArgs();
				this.PopupResizing(this, cancelEventArgs);
				return cancelEventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000832 RID: 2098 RVA: 0x0001D2EC File Offset: 0x0001B4EC
		// (remove) Token: 0x06000833 RID: 2099 RVA: 0x0001D324 File Offset: 0x0001B524
		public event global::System.EventHandler PopupResized;

		// Token: 0x06000834 RID: 2100 RVA: 0x0001D359 File Offset: 0x0001B559
		protected void OnPopupResized()
		{
			if (this.PopupResized != null)
			{
				this.PopupResized(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x040003EC RID: 1004
		private global::System.Windows.FrameworkElement _resizeElem;

		// Token: 0x040003ED RID: 1005
		private bool _isMouseDown;

		// Token: 0x040003EE RID: 1006
		private bool _isResizing;

		// Token: 0x040003EF RID: 1007
		private global::System.Windows.Point _offsetPoint;

		// Token: 0x040003F0 RID: 1008
		private global::System.Windows.Size _originalSize;

		// Token: 0x040003F1 RID: 1009
		private double _originalTop;

		// Token: 0x040003F2 RID: 1010
		private int _multiplier = 1;

		// Token: 0x040003F3 RID: 1011
		private global::Infragistics.Windows.Internal.PropertyValueTracker _flowDirectionTracker;

		// Token: 0x040003F4 RID: 1012
		public static readonly global::System.Windows.DependencyProperty ResizeElementProperty = global::System.Windows.DependencyProperty.Register("ResizeElement", typeof(global::System.Windows.FrameworkElement), typeof(global::Infragistics.Controls.Primitives.PopupResizer), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.PopupResizer.ResizeElementChanged)));

		// Token: 0x040003F5 RID: 1013
		public static readonly global::System.Windows.DependencyProperty PopupProperty = global::System.Windows.DependencyProperty.Register("Popup", typeof(global::System.Windows.Controls.Primitives.Popup), typeof(global::Infragistics.Controls.Primitives.PopupResizer), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.PopupResizer.PopupChanged)));

		// Token: 0x040003F6 RID: 1014
		public static readonly global::System.Windows.DependencyProperty PositionProperty = global::System.Windows.DependencyProperty.Register("Position", typeof(global::Infragistics.Controls.Primitives.ResizerPosition), typeof(global::Infragistics.Controls.Primitives.PopupResizer), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Primitives.ResizerPosition.Below, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.PopupResizer.PositionChanged)));
	}
}
