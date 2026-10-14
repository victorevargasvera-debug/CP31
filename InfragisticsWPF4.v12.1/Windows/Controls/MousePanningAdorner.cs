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
	// Token: 0x020001F5 RID: 501
	internal class MousePanningAdorner : global::System.Windows.Documents.Adorner
	{
		// Token: 0x060012D6 RID: 4822 RVA: 0x00044A20 File Offset: 0x00042C20
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

		// Token: 0x060012D7 RID: 4823 RVA: 0x00044AEC File Offset: 0x00042CEC
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

		// Token: 0x060012D8 RID: 4824 RVA: 0x00044B3C File Offset: 0x00042D3C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			return new global::System.Windows.Size(25.0, 25.0);
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00044B55 File Offset: 0x00042D55
		protected override void OnGotMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnGotMouseCapture(e);
			this.InitializeCursor(0.0, 0.0);
			base.ForceCursor = true;
			this.InitializeFocusedElement(global::System.Windows.Input.Keyboard.FocusedElement);
			e.Handled = true;
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00044B90 File Offset: 0x00042D90
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

		// Token: 0x060012DB RID: 4827 RVA: 0x00044BEC File Offset: 0x00042DEC
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			global::System.Windows.Point position = e.GetPosition(base.AdornedElement);
			this.ProcessMouseMove(position);
			base.OnMouseMove(e);
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00044C14 File Offset: 0x00042E14
		protected override void OnMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseDown(e);
			e.Handled = true;
			base.ReleaseMouseCapture();
		}

		// Token: 0x060012DD RID: 4829 RVA: 0x00044C2C File Offset: 0x00042E2C
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

		// Token: 0x060012DE RID: 4830 RVA: 0x00044C8A File Offset: 0x00042E8A
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			if (this._panImage != null)
			{
				drawingContext.DrawImage(this._panImage, new global::System.Windows.Rect(0.0, 0.0, 25.0, 25.0));
			}
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00044CCC File Offset: 0x00042ECC
		private double CalculateTimerInterval(double offset)
		{
			if (global::System.Math.Abs(offset) <= 12.5)
			{
				return 0.0;
			}
			offset = global::System.Math.Min(298.0, global::System.Math.Abs(offset));
			return global::System.Math.Pow((300.0 - offset) / 300.0, 3.0) * 500.0;
		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x00044D37 File Offset: 0x00042F37
		internal static bool CanScroll(global::System.Windows.Controls.ScrollViewer scrollViewer)
		{
			return scrollViewer != null && (scrollViewer.ViewportWidth < scrollViewer.ExtentWidth || scrollViewer.ViewportHeight < scrollViewer.ExtentHeight);
		}

		// Token: 0x060012E1 RID: 4833 RVA: 0x00044D5C File Offset: 0x00042F5C
		private static void DisposeTimer(ref global::System.Windows.Threading.DispatcherTimer timer)
		{
			if (timer != null)
			{
				timer.Stop();
				timer = null;
			}
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x00044D6C File Offset: 0x00042F6C
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

		// Token: 0x060012E3 RID: 4835 RVA: 0x00044E98 File Offset: 0x00043098
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

		// Token: 0x060012E4 RID: 4836 RVA: 0x00044F14 File Offset: 0x00043114
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

		// Token: 0x060012E5 RID: 4837 RVA: 0x00044F90 File Offset: 0x00043190
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

		// Token: 0x060012E6 RID: 4838 RVA: 0x00045034 File Offset: 0x00043234
		private void OnFocusedElementLostFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::System.Windows.IInputElement focusedElement = base.IsMouseCaptured ? global::System.Windows.Input.Keyboard.FocusedElement : null;
			this.InitializeFocusedElement(focusedElement);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00045059 File Offset: 0x00043259
		private void OnFocusedElementPreviewKeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			base.ReleaseMouseCapture();
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00045064 File Offset: 0x00043264
		private void OnMouseUpTimerTick(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Point point = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetCursorPosApi();
			point = base.AdornedElement.PointFromScreen(point);
			if (point != this._lastMouseMovePt)
			{
				this.ProcessMouseMove(point);
			}
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0004509C File Offset: 0x0004329C
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

		// Token: 0x040009B4 RID: 2484
		private const double Radius = 12.5;

		// Token: 0x040009B5 RID: 2485
		private global::System.Windows.Controls.ScrollViewer _scrollViewer;

		// Token: 0x040009B6 RID: 2486
		private double _offsetX;

		// Token: 0x040009B7 RID: 2487
		private double _offsetY;

		// Token: 0x040009B8 RID: 2488
		private global::System.Windows.Threading.DispatcherTimer _timerHorz;

		// Token: 0x040009B9 RID: 2489
		private global::System.Windows.Threading.DispatcherTimer _timerVert;

		// Token: 0x040009BA RID: 2490
		private global::System.Windows.Threading.DispatcherTimer _mouseUpTimer;

		// Token: 0x040009BB RID: 2491
		private bool _canScrollVert = true;

		// Token: 0x040009BC RID: 2492
		private bool _canScrollHorz = true;

		// Token: 0x040009BD RID: 2493
		private global::Infragistics.Windows.Controls.MousePanningAdorner.ScrollCursor _currentScrollDir;

		// Token: 0x040009BE RID: 2494
		private bool _hasScrolled;

		// Token: 0x040009BF RID: 2495
		private global::System.Windows.Point _lastMouseMovePt = new global::System.Windows.Point(-10000.0, -10000.0);

		// Token: 0x040009C0 RID: 2496
		private global::System.Windows.Media.ImageSource _panImage;

		// Token: 0x040009C1 RID: 2497
		private global::System.Windows.IInputElement _focusedElement;

		// Token: 0x020001F6 RID: 502
		private enum ScrollCursor
		{
			// Token: 0x040009C3 RID: 2499
			None,
			// Token: 0x040009C4 RID: 2500
			ScrollUp,
			// Token: 0x040009C5 RID: 2501
			ScrollDown,
			// Token: 0x040009C6 RID: 2502
			ScrollLeft = 4,
			// Token: 0x040009C7 RID: 2503
			ScrollRight = 8,
			// Token: 0x040009C8 RID: 2504
			ScrollUpDown = 3,
			// Token: 0x040009C9 RID: 2505
			ScrollLeftRight = 12,
			// Token: 0x040009CA RID: 2506
			ScrollUpLeft = 5,
			// Token: 0x040009CB RID: 2507
			ScrollUpRight = 9,
			// Token: 0x040009CC RID: 2508
			ScrollDownRight,
			// Token: 0x040009CD RID: 2509
			ScrollDownLeft = 6,
			// Token: 0x040009CE RID: 2510
			ScrollAll = 15
		}
	}
}
