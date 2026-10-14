using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000225 RID: 549
	internal class MousePanningAdorner : global::System.Windows.Documents.Adorner
	{
		// Token: 0x060014B3 RID: 5299 RVA: 0x0004A730 File Offset: 0x00048930
		internal MousePanningAdorner(global::System.Windows.Controls.ScrollViewer scrollViewer, double offsetX, double offsetY) : base(scrollViewer)
		{
			if (scrollViewer == null)
			{
				throw new global::System.ArgumentNullException("scrollViewer");
			}
			this._scrollViewer = scrollViewer;
			this._offsetX = offsetX;
			this._offsetY = offsetY;
			this._canScrollHorz = (scrollViewer.ViewportWidth < scrollViewer.ExtentWidth);
			this._canScrollVert = (scrollViewer.ViewportHeight < scrollViewer.ExtentHeight);
			object resourceKey;
			if (this._canScrollHorz && this._canScrollVert)
			{
				resourceKey = global::Infragistics.Windows.Controls.MousePanningDecorator.ScrollAllImageKey;
			}
			else if (this._canScrollHorz)
			{
				resourceKey = global::Infragistics.Windows.Controls.MousePanningDecorator.ScrollEWImageKey;
			}
			else
			{
				resourceKey = global::Infragistics.Windows.Controls.MousePanningDecorator.ScrollNSImageKey;
			}
			object obj = scrollViewer.TryFindResource(resourceKey);
			this._panImage = (obj as global::System.Windows.Media.ImageSource);
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0004A7FC File Offset: 0x000489FC
		public override global::System.Windows.Media.GeneralTransform GetDesiredTransform(global::System.Windows.Media.GeneralTransform transform)
		{
			return new global::System.Windows.Media.GeneralTransformGroup
			{
				Children = 
				{
					transform,
					new global::System.Windows.Media.TranslateTransform(this._offsetX - 12.5, this._offsetY - 12.5)
				}
			};
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0004A84C File Offset: 0x00048A4C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			return new global::System.Windows.Size(25.0, 25.0);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0004A865 File Offset: 0x00048A65
		protected override void OnGotMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnGotMouseCapture(e);
			this.InitializeCursor(0.0, 0.0);
			base.ForceCursor = true;
			this.InitializeFocusedElement(global::System.Windows.Input.Keyboard.FocusedElement);
			e.Handled = true;
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0004A8A0 File Offset: 0x00048AA0
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnLostMouseCapture(e);
			global::Infragistics.Windows.Controls.MousePanningAdorner.DisposeTimer(ref this._timerHorz);
			global::Infragistics.Windows.Controls.MousePanningAdorner.DisposeTimer(ref this._timerVert);
			global::Infragistics.Windows.Controls.MousePanningAdorner.DisposeTimer(ref this._mouseUpTimer);
			this.InitializeFocusedElement(null);
			global::System.Windows.Documents.AdornerLayer adornerLayer = base.Parent as global::System.Windows.Documents.AdornerLayer;
			if (adornerLayer != null)
			{
				adornerLayer.Remove(this);
			}
			e.Handled = true;
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0004A8FC File Offset: 0x00048AFC
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			global::System.Windows.Point position = e.GetPosition(base.AdornedElement);
			this.ProcessMouseMove(position);
			base.OnMouseMove(e);
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0004A924 File Offset: 0x00048B24
		protected override void OnMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseDown(e);
			e.Handled = true;
			base.ReleaseMouseCapture();
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0004A93C File Offset: 0x00048B3C
		protected override void OnMouseUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this._hasScrolled)
			{
				base.ReleaseMouseCapture();
			}
			else if (!global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				this._mouseUpTimer = new global::System.Windows.Threading.DispatcherTimer(global::System.TimeSpan.FromMilliseconds(250.0), global::System.Windows.Threading.DispatcherPriority.Input, new global::System.EventHandler(this.OnMouseUpTimerTick), base.Dispatcher);
			}
			base.OnMouseUp(e);
			e.Handled = true;
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0004A99A File Offset: 0x00048B9A
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			if (this._panImage != null)
			{
				drawingContext.DrawImage(this._panImage, new global::System.Windows.Rect(0.0, 0.0, 25.0, 25.0));
			}
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0004A9DC File Offset: 0x00048BDC
		private double CalculateTimerInterval(double offset)
		{
			if (global::System.Math.Abs(offset) <= 12.5)
			{
				return 0.0;
			}
			offset = global::System.Math.Min(298.0, global::System.Math.Abs(offset));
			return global::System.Math.Pow((300.0 - offset) / 300.0, 3.0) * 500.0;
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0004AA47 File Offset: 0x00048C47
		internal static bool CanScroll(global::System.Windows.Controls.ScrollViewer scrollViewer)
		{
			return scrollViewer != null && (scrollViewer.ViewportWidth < scrollViewer.ExtentWidth || scrollViewer.ViewportHeight < scrollViewer.ExtentHeight);
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0004AA6C File Offset: 0x00048C6C
		private static void DisposeTimer(ref global::System.Windows.Threading.DispatcherTimer timer)
		{
			if (timer != null)
			{
				timer.Stop();
				timer = null;
			}
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0004AA7C File Offset: 0x00048C7C
		private void InitializeCursor(double offsetX, double offsetY)
		{
			global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor scrollCursor = global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.None;
			if (this._canScrollVert)
			{
				if (offsetY < -12.5)
				{
					scrollCursor |= global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollUp;
				}
				if (offsetY > 12.5)
				{
					scrollCursor |= global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollDown;
				}
			}
			if (this._canScrollVert)
			{
				if (offsetX < -12.5)
				{
					scrollCursor |= global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollLeft;
				}
				if (offsetX > 12.5)
				{
					scrollCursor |= global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollRight;
				}
			}
			if (scrollCursor == global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.None)
			{
				if (this._canScrollVert)
				{
					scrollCursor |= global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollUpDown;
				}
				if (this._canScrollHorz)
				{
					scrollCursor |= global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollLeftRight;
				}
			}
			this._currentScrollDir = scrollCursor;
			global::System.Windows.Input.Cursor cursor = null;
			switch (scrollCursor)
			{
			case global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollUp:
				cursor = global::System.Windows.Input.Cursors.ScrollN;
				break;
			case global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollDown:
				cursor = global::System.Windows.Input.Cursors.ScrollS;
				break;
			case global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollUpDown:
				cursor = global::System.Windows.Input.Cursors.ScrollNS;
				break;
			case global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollLeft:
				cursor = global::System.Windows.Input.Cursors.ScrollW;
				break;
			case global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollUpLeft:
				cursor = global::System.Windows.Input.Cursors.ScrollNW;
				break;
			case global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollDownLeft:
				cursor = global::System.Windows.Input.Cursors.ScrollSW;
				break;
			case global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollRight:
				cursor = global::System.Windows.Input.Cursors.ScrollE;
				break;
			case global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollUpRight:
				cursor = global::System.Windows.Input.Cursors.ScrollNE;
				break;
			case global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollDownRight:
				cursor = global::System.Windows.Input.Cursors.ScrollSE;
				break;
			case global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollLeftRight:
				cursor = global::System.Windows.Input.Cursors.ScrollWE;
				break;
			case global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollAll:
				cursor = global::System.Windows.Input.Cursors.ScrollAll;
				break;
			}
			base.Cursor = cursor;
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0004ABA8 File Offset: 0x00048DA8
		private void InitializeFocusedElement(global::System.Windows.IInputElement focusedElement)
		{
			if (this._focusedElement != focusedElement)
			{
				if (this._focusedElement != null)
				{
					this._focusedElement.PreviewKeyDown -= this.OnFocusedElementPreviewKeyDown;
					this._focusedElement.LostKeyboardFocus -= this.OnFocusedElementLostFocus;
				}
				this._focusedElement = focusedElement;
				if (focusedElement != null)
				{
					focusedElement.PreviewKeyDown += this.OnFocusedElementPreviewKeyDown;
					focusedElement.LostKeyboardFocus += this.OnFocusedElementLostFocus;
				}
			}
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0004AC24 File Offset: 0x00048E24
		private void InitializeTimer(global::System.Windows.Controls.Orientation orientation, double offset, ref global::System.Windows.Threading.DispatcherTimer timer)
		{
			double num = this.CalculateTimerInterval(offset);
			if (num <= 0.0)
			{
				if (timer != null)
				{
					timer.Stop();
				}
				return;
			}
			global::System.TimeSpan timeSpan = global::System.TimeSpan.FromMilliseconds(num);
			if (timer != null)
			{
				if (timeSpan != timer.Interval)
				{
					timer.Interval = timeSpan;
				}
				if (!timer.IsEnabled)
				{
					timer.Start();
					return;
				}
			}
			else
			{
				timer = new global::System.Windows.Threading.DispatcherTimer(timeSpan, global::System.Windows.Threading.DispatcherPriority.Input, new global::System.EventHandler(this.OnTimerTick), base.Dispatcher);
			}
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0004ACA0 File Offset: 0x00048EA0
		private void ProcessMouseMove(global::System.Windows.Point mousePosition)
		{
			this._lastMouseMovePt = mousePosition;
			double num = this._canScrollHorz ? (mousePosition.X - this._offsetX) : 0.0;
			double num2 = this._canScrollVert ? (mousePosition.Y - this._offsetY) : 0.0;
			this.InitializeTimer(global::System.Windows.Controls.Orientation.Horizontal, num, ref this._timerHorz);
			this.InitializeTimer(global::System.Windows.Controls.Orientation.Vertical, num2, ref this._timerVert);
			if (!this._hasScrolled)
			{
				this._hasScrolled = (this._timerHorz != null || this._timerVert != null);
			}
			this.InitializeCursor(num, num2);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0004AD44 File Offset: 0x00048F44
		private void OnFocusedElementLostFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::System.Windows.IInputElement focusedElement = base.IsMouseCaptured ? global::System.Windows.Input.Keyboard.FocusedElement : null;
			this.InitializeFocusedElement(focusedElement);
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0004AD69 File Offset: 0x00048F69
		private void OnFocusedElementPreviewKeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			base.ReleaseMouseCapture();
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x0004AD74 File Offset: 0x00048F74
		private void OnMouseUpTimerTick(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Point point = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetCursorPosApi();
			point = base.AdornedElement.PointFromScreen(point);
			if (point != this._lastMouseMovePt)
			{
				this.ProcessMouseMove(point);
			}
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x0004ADAC File Offset: 0x00048FAC
		private void OnTimerTick(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Controls.Orientation orientation = (sender == this._timerHorz) ? global::System.Windows.Controls.Orientation.Horizontal : global::System.Windows.Controls.Orientation.Vertical;
			if (orientation == global::System.Windows.Controls.Orientation.Vertical)
			{
				if ((this._currentScrollDir & global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollUpDown) == global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollUp)
				{
					this._scrollViewer.LineUp();
					return;
				}
				if ((this._currentScrollDir & global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollUpDown) == global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollDown)
				{
					this._scrollViewer.LineDown();
					return;
				}
			}
			else
			{
				if ((this._currentScrollDir & global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollLeftRight) == global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollLeft)
				{
					this._scrollViewer.LineLeft();
					return;
				}
				if ((this._currentScrollDir & global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollLeftRight) == global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor.ScrollRight)
				{
					this._scrollViewer.LineRight();
				}
			}
		}

		// Token: 0x04000AFF RID: 2815
		private const double Radius = 12.5;

		// Token: 0x04000B00 RID: 2816
		private global::System.Windows.Controls.ScrollViewer _scrollViewer;

		// Token: 0x04000B01 RID: 2817
		private double _offsetX;

		// Token: 0x04000B02 RID: 2818
		private double _offsetY;

		// Token: 0x04000B03 RID: 2819
		private global::System.Windows.Threading.DispatcherTimer _timerHorz;

		// Token: 0x04000B04 RID: 2820
		private global::System.Windows.Threading.DispatcherTimer _timerVert;

		// Token: 0x04000B05 RID: 2821
		private global::System.Windows.Threading.DispatcherTimer _mouseUpTimer;

		// Token: 0x04000B06 RID: 2822
		private bool _canScrollVert = true;

		// Token: 0x04000B07 RID: 2823
		private bool _canScrollHorz = true;

		// Token: 0x04000B08 RID: 2824
		private global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor _currentScrollDir;

		// Token: 0x04000B09 RID: 2825
		private bool _hasScrolled;

		// Token: 0x04000B0A RID: 2826
		private global::System.Windows.Point _lastMouseMovePt = new global::System.Windows.Point(-10000.0, -10000.0);

		// Token: 0x04000B0B RID: 2827
		private global::System.Windows.Media.ImageSource _panImage;

		// Token: 0x04000B0C RID: 2828
		private global::System.Windows.IInputElement _focusedElement;

		// Token: 0x02000226 RID: 550
		private enum ScrollCursor
		{
			// Token: 0x04000B0E RID: 2830
			None,
			// Token: 0x04000B0F RID: 2831
			ScrollUp,
			// Token: 0x04000B10 RID: 2832
			ScrollDown,
			// Token: 0x04000B11 RID: 2833
			ScrollLeft = 4,
			// Token: 0x04000B12 RID: 2834
			ScrollRight = 8,
			// Token: 0x04000B13 RID: 2835
			ScrollUpDown = 3,
			// Token: 0x04000B14 RID: 2836
			ScrollLeftRight = 12,
			// Token: 0x04000B15 RID: 2837
			ScrollUpLeft = 5,
			// Token: 0x04000B16 RID: 2838
			ScrollUpRight = 9,
			// Token: 0x04000B17 RID: 2839
			ScrollDownRight,
			// Token: 0x04000B18 RID: 2840
			ScrollDownLeft = 6,
			// Token: 0x04000B19 RID: 2841
			ScrollAll = 15
		}
	}
}
