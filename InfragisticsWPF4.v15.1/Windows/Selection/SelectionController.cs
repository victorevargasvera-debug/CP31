using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace Infragistics.Windows.Selection
{
	// Token: 0x020002AC RID: 684
	internal sealed class SelectionController
	{
		// Token: 0x06001AEE RID: 6894 RVA: 0x00066449 File Offset: 0x00064649
		internal SelectionController(global::Infragistics.Windows.Selection.ISelectionHost host)
		{
			if (host == null)
			{
				throw new global::System.ArgumentNullException("host");
			}
			this._host = host;
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001AEF RID: 6895 RVA: 0x00066466 File Offset: 0x00064666
		// (set) Token: 0x06001AF0 RID: 6896 RVA: 0x0006646E File Offset: 0x0006466E
		internal global::Infragistics.Windows.Selection.SelectionStrategyBase ActiveStrategy
		{
			get
			{
				return this._currentStrategy;
			}
			set
			{
				if (value != this._currentStrategy)
				{
					if (value == null)
					{
						this._currentStrategy.InitializeController(null);
					}
					this._currentStrategy = value;
					this.OnActiveStrategyChanged();
				}
			}
		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x00066498 File Offset: 0x00064698
		public bool CancelPendingOperations(bool killDblClickTimer)
		{
			if (killDblClickTimer && this._dblClickThreshhold != null)
			{
				this._dblClickThreshhold.Dispose();
				this._dblClickThreshhold = null;
			}
			if (this._currentStrategy != null && !this._currentStrategy.IsReleasingMouseCapture)
			{
				this._currentStrategy.CancelPendingOperations();
				this.ActiveStrategy = null;
				return true;
			}
			return false;
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x000664EC File Offset: 0x000646EC
		public bool IsWithinDblClickThreshold()
		{
			if (this._dblClickThreshhold != null && this._dblClickThreshhold.HasTimeExpired())
			{
				this._dblClickThreshhold = null;
			}
			return this._dblClickThreshhold != null;
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x00066518 File Offset: 0x00064718
		public void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.FrameworkElement rootElement = this._host.RootElement;
			if (rootElement == null)
			{
				return;
			}
			this._currentItem = global::Infragistics.Windows.Selection.SelectionController.GetSelectableItem(e, rootElement);
			if (this._currentItem == null)
			{
				return;
			}
			this.ActiveStrategy = this._host.GetSelectionStrategyForItem(this._currentItem);
			global::Infragistics.Windows.Selection.SelectionStrategyBase currentStrategy = this._currentStrategy;
			if (currentStrategy == null)
			{
				return;
			}
			if (this._dblClickThreshhold == null)
			{
				this._dblClickThreshhold = new global::Infragistics.Windows.Selection.SelectionController.DoubleClickThreshold(this, e.GetPosition(this._host.RootElement));
			}
			bool flag = currentStrategy.OnMouseLeftButtonDown(this._currentItem, e);
			if (!flag || global::System.Windows.Input.Mouse.LeftButton != global::System.Windows.Input.MouseButtonState.Pressed)
			{
				if (flag)
				{
					currentStrategy.CancelPendingOperations();
				}
				if (this._dblClickThreshhold != null)
				{
					this._dblClickThreshhold.Dispose();
					this._dblClickThreshhold = null;
					if (flag)
					{
						this._host.ScrollPendingItemIntoView();
					}
				}
				this.ActiveStrategy = null;
				return;
			}
			bool ignoreNextMouseMove = currentStrategy.IgnoreNextMouseMove;
			currentStrategy.IgnoreNextMouseMove = true;
			currentStrategy.InitializeController(this);
			try
			{
				rootElement.CaptureMouse();
			}
			finally
			{
				currentStrategy.IgnoreNextMouseMove = ignoreNextMouseMove;
			}
			e.Handled = true;
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x00066624 File Offset: 0x00064824
		public void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			try
			{
				if (this._currentStrategy == null)
				{
					return;
				}
				this._currentItem = global::Infragistics.Windows.Selection.SelectionController.GetSelectableItem(e, this._host.RootElement);
				this._currentStrategy.OnMouseLeftButtonUp(this._currentItem, e);
				if (this._currentStrategy != null)
				{
					this._currentStrategy.InitializeController(null);
				}
				this._currentItem = null;
				this._currentStrategy = null;
			}
			finally
			{
				this.ReleaseCapture();
			}
			this.VerifyDblClickThreshhold(e);
			this.OnActiveStrategyChanged();
			e.Handled = true;
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x000666B4 File Offset: 0x000648B4
		public void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			this.VerifyDblClickThreshhold(e);
			if (this._currentStrategy == null)
			{
				return;
			}
			this._currentItem = global::Infragistics.Windows.Selection.SelectionController.GetSelectableItem(e, this._host.RootElement);
			this._currentStrategy.OnMouseMove(this._currentItem, e);
			e.Handled = true;
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00066702 File Offset: 0x00064902
		private void OnActiveStrategyChanged()
		{
			if (this.ActiveStrategyChanged != null)
			{
				this.ActiveStrategyChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x0006671D File Offset: 0x0006491D
		private void ReleaseCapture()
		{
			if (this._host.RootElement.IsMouseCaptured)
			{
				this._host.RootElement.ReleaseMouseCapture();
			}
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x00066744 File Offset: 0x00064944
		private void VerifyDblClickThreshhold(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._dblClickThreshhold != null && (this._dblClickThreshhold.HasTimeExpired() || !this._dblClickThreshhold.IsWithinSizeThreshhold(e.GetPosition(this._host.RootElement))) && this._currentStrategy == null)
			{
				this._dblClickThreshhold = null;
				this._host.ScrollPendingItemIntoView();
			}
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x000667A0 File Offset: 0x000649A0
		internal static global::Infragistics.Windows.Selection.ISelectableItem GetSelectableItem(global::System.Windows.Input.MouseEventArgs e, global::System.Windows.DependencyObject root)
		{
			if (!(root is global::System.Windows.IInputElement))
			{
				return null;
			}
			if (!(root is global::System.Windows.Media.Visual))
			{
				return null;
			}
			if (!(root is global::System.Windows.UIElement))
			{
				return null;
			}
			global::System.Windows.Point position = e.MouseDevice.GetPosition((global::System.Windows.IInputElement)root);
			global::Infragistics.Windows.Selection.SelectionController._hitTestResult = null;
			if (root is global::System.Windows.UIElement)
			{
				global::Infragistics.Windows.Selection.SelectionController._hitTestResult = (((global::System.Windows.UIElement)root).InputHitTest(position) as global::System.Windows.DependencyObject);
			}
			else
			{
				global::System.Windows.Media.VisualTreeHelper.HitTest((global::System.Windows.Media.Visual)root, new global::System.Windows.Media.HitTestFilterCallback(global::Infragistics.Windows.Selection.SelectionController.OnHitTestFilterCallback), new global::System.Windows.Media.HitTestResultCallback(global::Infragistics.Windows.Selection.SelectionController.OnHitTestResultCallback), new global::System.Windows.Media.PointHitTestParameters(position));
			}
			if (global::Infragistics.Windows.Selection.SelectionController._hitTestResult == null)
			{
				return null;
			}
			global::Infragistics.Windows.Selection.ISelectableElement selectableElement = global::Infragistics.Windows.Selection.SelectionController.GetSelectableElement(global::Infragistics.Windows.Selection.SelectionController._hitTestResult, root);
			global::Infragistics.Windows.Selection.SelectionController._hitTestResult = null;
			if (selectableElement == null)
			{
				return null;
			}
			return selectableElement.SelectableItem;
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00066852 File Offset: 0x00064A52
		private static global::System.Windows.Media.HitTestResultBehavior OnHitTestResultCallback(global::System.Windows.Media.HitTestResult result)
		{
			global::Infragistics.Windows.Selection.SelectionController._hitTestResult = result.VisualHit;
			return global::System.Windows.Media.HitTestResultBehavior.Stop;
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00066860 File Offset: 0x00064A60
		private static global::System.Windows.Media.HitTestFilterBehavior OnHitTestFilterCallback(global::System.Windows.DependencyObject target)
		{
			global::System.Windows.Media.HitTestFilterBehavior result = global::System.Windows.Media.HitTestFilterBehavior.Continue;
			global::System.Windows.UIElement uielement = target as global::System.Windows.UIElement;
			if (uielement != null && (!uielement.IsVisible || !uielement.IsHitTestVisible))
			{
				result = global::System.Windows.Media.HitTestFilterBehavior.ContinueSkipSelfAndChildren;
			}
			return result;
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0006688C File Offset: 0x00064A8C
		internal static global::Infragistics.Windows.Selection.ISelectableElement GetSelectableElement(global::System.Windows.DependencyObject element, global::System.Windows.DependencyObject root)
		{
			if (element is global::Infragistics.Windows.Selection.ISelectableElement)
			{
				return (global::Infragistics.Windows.Selection.ISelectableElement)element;
			}
			if (element == root)
			{
				return null;
			}
			global::System.Windows.DependencyObject parent = global::Infragistics.Windows.Utilities.GetParent(element);
			if (parent == null)
			{
				return null;
			}
			return global::Infragistics.Windows.Selection.SelectionController.GetSelectableElement(parent, root);
		}

		// Token: 0x1400003C RID: 60
		// (add) Token: 0x06001AFD RID: 6909 RVA: 0x000668C4 File Offset: 0x00064AC4
		// (remove) Token: 0x06001AFE RID: 6910 RVA: 0x000668FC File Offset: 0x00064AFC
		public event global::System.EventHandler ActiveStrategyChanged;

		// Token: 0x04000D56 RID: 3414
		private global::Infragistics.Windows.Selection.ISelectionHost _host;

		// Token: 0x04000D57 RID: 3415
		private global::Infragistics.Windows.Selection.SelectionStrategyBase _currentStrategy;

		// Token: 0x04000D58 RID: 3416
		private global::Infragistics.Windows.Selection.ISelectableItem _currentItem;

		// Token: 0x04000D59 RID: 3417
		private global::Infragistics.Windows.Selection.SelectionController.DoubleClickThreshold _dblClickThreshhold;

		// Token: 0x04000D5A RID: 3418
		private static global::System.Windows.DependencyObject _hitTestResult;

		// Token: 0x020002AD RID: 685
		private class DoubleClickThreshold
		{
			// Token: 0x06001B00 RID: 6912 RVA: 0x00066934 File Offset: 0x00064B34
			internal DoubleClickThreshold(global::Infragistics.Windows.Selection.SelectionController controller, global::System.Windows.Point startPoint)
			{
				this._controller = controller;
				this._startPoint = startPoint;
				this._rootElement = this._controller._host.RootElement;
				this._rootElement.Unloaded += this.OnRootElementUnloaded;
				int systemDoubleClickTime = global::Infragistics.Windows.Utilities.SystemDoubleClickTime;
				this._expiration = global::System.DateTime.Now.AddMilliseconds((double)(systemDoubleClickTime + 10));
				this._timer = new global::System.Windows.Threading.DispatcherTimer();
				this._timer.Interval = global::System.TimeSpan.FromMilliseconds((double)systemDoubleClickTime);
				this._timer.Tick += this.OnTimerTick;
				this._timer.Start();
			}

			// Token: 0x06001B01 RID: 6913 RVA: 0x000669E0 File Offset: 0x00064BE0
			internal void Dispose()
			{
				this._expired = true;
				if (this._rootElement != null)
				{
					this._rootElement.Unloaded -= this.OnRootElementUnloaded;
					this._rootElement = null;
				}
				if (this._timer != null)
				{
					this._timer.Stop();
					this._timer = null;
				}
			}

			// Token: 0x06001B02 RID: 6914 RVA: 0x00066A34 File Offset: 0x00064C34
			internal bool HasTimeExpired()
			{
				if (!this._expired)
				{
					this._expired = (global::System.DateTime.Now > this._expiration);
					if (this._expired)
					{
						this.Dispose();
					}
				}
				return this._expired;
			}

			// Token: 0x06001B03 RID: 6915 RVA: 0x00066A68 File Offset: 0x00064C68
			internal bool IsWithinSizeThreshhold(global::System.Windows.Point pt)
			{
				if (!this._expired)
				{
					global::System.Windows.Size systemDoubleClickSize = global::Infragistics.Windows.Utilities.SystemDoubleClickSize;
					this._expired = (pt.X < this._startPoint.X - systemDoubleClickSize.Width || pt.X > this._startPoint.X + systemDoubleClickSize.Width || pt.Y < this._startPoint.Y - systemDoubleClickSize.Height || pt.Y > this._startPoint.Y + systemDoubleClickSize.Height);
					if (this._expired)
					{
						this.Dispose();
					}
				}
				return !this._expired;
			}

			// Token: 0x06001B04 RID: 6916 RVA: 0x00066B16 File Offset: 0x00064D16
			private void OnRootElementUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
			{
				this.Dispose();
			}

			// Token: 0x06001B05 RID: 6917 RVA: 0x00066B1E File Offset: 0x00064D1E
			private void OnTimerTick(object sender, global::System.EventArgs e)
			{
				this.Dispose();
				if (this._controller._dblClickThreshhold == this && this._controller._currentStrategy == null)
				{
					this._controller._dblClickThreshhold = null;
					this._controller._host.ScrollPendingItemIntoView();
				}
			}

			// Token: 0x04000D5C RID: 3420
			private global::Infragistics.Windows.Selection.SelectionController _controller;

			// Token: 0x04000D5D RID: 3421
			private global::System.DateTime _expiration;

			// Token: 0x04000D5E RID: 3422
			private global::System.Windows.Point _startPoint;

			// Token: 0x04000D5F RID: 3423
			private global::System.Windows.Threading.DispatcherTimer _timer;

			// Token: 0x04000D60 RID: 3424
			private bool _expired;

			// Token: 0x04000D61 RID: 3425
			private global::System.Windows.FrameworkElement _rootElement;
		}
	}
}
