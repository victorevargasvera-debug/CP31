using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Infragistics.Windows.Selection
{
	// Token: 0x02000270 RID: 624
	internal sealed class SelectionController
	{
		// Token: 0x060018CC RID: 6348 RVA: 0x0005F6A9 File Offset: 0x0005D8A9
		internal SelectionController(global::Infragistics.Windows.Selection.ISelectionHost host)
		{
			if (host == null)
			{
				throw new global::System.ArgumentNullException("host");
			}
			this._host = host;
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x0005F6C6 File Offset: 0x0005D8C6
		// (set) Token: 0x060018CE RID: 6350 RVA: 0x0005F6CE File Offset: 0x0005D8CE
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
					this._currentStrategy = value;
					this.OnActiveStrategyChanged();
				}
			}
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0005F6E6 File Offset: 0x0005D8E6
		public bool CancelPendingOperations()
		{
			if (this._currentStrategy != null && !this._currentStrategy.IsReleasingMouseCapture)
			{
				this._currentStrategy.CancelPendingOperations();
				this.ActiveStrategy = null;
				return true;
			}
			return false;
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0005F714 File Offset: 0x0005D914
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
			bool flag = currentStrategy.OnMouseLeftButtonDown(this._currentItem, e);
			if (!flag || global::System.Windows.Input.Mouse.LeftButton != global::System.Windows.Input.MouseButtonState.Pressed)
			{
				if (flag)
				{
					currentStrategy.CancelPendingOperations();
				}
				this.ActiveStrategy = null;
				return;
			}
			bool ignoreNextMouseMove = currentStrategy.IgnoreNextMouseMove;
			currentStrategy.IgnoreNextMouseMove = true;
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

		// Token: 0x060018D1 RID: 6353 RVA: 0x0005F7CC File Offset: 0x0005D9CC
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
				this._currentItem = null;
				this._currentStrategy = null;
			}
			finally
			{
				this.ReleaseCapture();
			}
			this.OnActiveStrategyChanged();
			e.Handled = true;
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0005F840 File Offset: 0x0005DA40
		public void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._currentStrategy == null)
			{
				return;
			}
			this._currentItem = global::Infragistics.Windows.Selection.SelectionController.GetSelectableItem(e, this._host.RootElement);
			this._currentStrategy.OnMouseMove(this._currentItem, e);
			e.Handled = true;
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0005F87C File Offset: 0x0005DA7C
		private void OnActiveStrategyChanged()
		{
			if (this.ActiveStrategyChanged != null)
			{
				this.ActiveStrategyChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0005F897 File Offset: 0x0005DA97
		private void ReleaseCapture()
		{
			if (this._host.RootElement.IsMouseCaptured)
			{
				this._host.RootElement.ReleaseMouseCapture();
			}
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0005F8BC File Offset: 0x0005DABC
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

		// Token: 0x060018D6 RID: 6358 RVA: 0x0005F96E File Offset: 0x0005DB6E
		private static global::System.Windows.Media.HitTestResultBehavior OnHitTestResultCallback(global::System.Windows.Media.HitTestResult result)
		{
			global::Infragistics.Windows.Selection.SelectionController._hitTestResult = result.VisualHit;
			return global::System.Windows.Media.HitTestResultBehavior.Stop;
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0005F97C File Offset: 0x0005DB7C
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

		// Token: 0x060018D8 RID: 6360 RVA: 0x0005F9A8 File Offset: 0x0005DBA8
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

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x060018D9 RID: 6361 RVA: 0x0005F9E0 File Offset: 0x0005DBE0
		// (remove) Token: 0x060018DA RID: 6362 RVA: 0x0005FA18 File Offset: 0x0005DC18
		public event global::System.EventHandler ActiveStrategyChanged;

		// Token: 0x04000BEB RID: 3051
		private global::Infragistics.Windows.Selection.ISelectionHost _host;

		// Token: 0x04000BEC RID: 3052
		private global::Infragistics.Windows.Selection.SelectionStrategyBase _currentStrategy;

		// Token: 0x04000BED RID: 3053
		private global::Infragistics.Windows.Selection.ISelectableItem _currentItem;

		// Token: 0x04000BEE RID: 3054
		private static global::System.Windows.DependencyObject _hitTestResult;
	}
}
