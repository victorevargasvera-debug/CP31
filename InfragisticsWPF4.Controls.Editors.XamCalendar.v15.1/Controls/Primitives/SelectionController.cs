using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000037 RID: 55
	internal sealed class SelectionController
	{
		// Token: 0x0600026C RID: 620 RVA: 0x0000CF14 File Offset: 0x0000B114
		internal SelectionController(global::Infragistics.Controls.Primitives.ISelectionHost host)
		{
			if (host == null)
			{
				throw new global::System.ArgumentNullException("host");
			}
			this._host = host;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000CF31 File Offset: 0x0000B131
		// (set) Token: 0x0600026E RID: 622 RVA: 0x0000CF39 File Offset: 0x0000B139
		internal global::Infragistics.Controls.Primitives.SelectionStrategyBase ActiveStrategy
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

		// Token: 0x0600026F RID: 623 RVA: 0x0000CF51 File Offset: 0x0000B151
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

		// Token: 0x06000270 RID: 624 RVA: 0x0000CF80 File Offset: 0x0000B180
		public void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.FrameworkElement rootElement = this._host.RootElement;
			if (rootElement == null)
			{
				return;
			}
			this._currentItem = global::Infragistics.Controls.Primitives.SelectionController.GetSelectableItem(e, rootElement);
			if (this._currentItem == null)
			{
				return;
			}
			this.ActiveStrategy = this._host.GetSelectionStrategyForItem(this._currentItem);
			global::Infragistics.Controls.Primitives.SelectionStrategyBase currentStrategy = this._currentStrategy;
			if (currentStrategy == null)
			{
				return;
			}
			bool flag = currentStrategy.OnMouseLeftButtonDown(this._currentItem, e);
			if (!flag)
			{
				if (flag)
				{
					currentStrategy.CancelPendingOperations();
				}
				this.ActiveStrategy = null;
				return;
			}
			currentStrategy.CaptureMouseForRoot();
			e.Handled = true;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000D008 File Offset: 0x0000B208
		public void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			try
			{
				if (this._currentStrategy == null)
				{
					return;
				}
				this._currentItem = global::Infragistics.Controls.Primitives.SelectionController.GetSelectableItem(e, this._host.RootElement);
				this._currentStrategy.OnMouseLeftButtonUp(this._currentItem, e);
				if (this._currentStrategy != null)
				{
					this._currentStrategy.ReleaseCapture();
				}
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

		// Token: 0x06000272 RID: 626 RVA: 0x0000D090 File Offset: 0x0000B290
		public void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._currentStrategy == null)
			{
				return;
			}
			this._currentItem = global::Infragistics.Controls.Primitives.SelectionController.GetSelectableItem(e, this._host.RootElement);
			this._currentStrategy.OnMouseMove(this._currentItem, e);
			e.Handled = true;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000D0CC File Offset: 0x0000B2CC
		private void OnActiveStrategyChanged()
		{
			if (this.ActiveStrategyChanged != null)
			{
				this.ActiveStrategyChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000D0E7 File Offset: 0x0000B2E7
		private void ReleaseCapture()
		{
			if (this._currentStrategy != null && this._currentStrategy.IsMouseCaptured)
			{
				this._currentStrategy.ReleaseRootElementCapture();
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000D10C File Offset: 0x0000B30C
		internal static global::Infragistics.Controls.Primitives.ISelectableItem GetSelectableItem(global::System.Windows.Input.MouseEventArgs e, global::System.Windows.DependencyObject root)
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
			global::System.Windows.Point position = e.GetPosition((global::System.Windows.UIElement)root);
			global::System.Windows.UIElement visualDescendantFromPoint = global::Infragistics.Controls.PresentationUtilities.GetVisualDescendantFromPoint<global::System.Windows.UIElement>(root as global::System.Windows.UIElement, position, null);
			if (visualDescendantFromPoint == null)
			{
				return null;
			}
			global::Infragistics.Controls.Primitives.ISelectableElement selectableElement = global::Infragistics.Controls.Primitives.SelectionController.GetSelectableElement(visualDescendantFromPoint, root);
			if (selectableElement == null)
			{
				return null;
			}
			return selectableElement.SelectableItem;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000D16C File Offset: 0x0000B36C
		internal static global::Infragistics.Controls.Primitives.ISelectableElement GetSelectableElement(global::System.Windows.DependencyObject element, global::System.Windows.DependencyObject root)
		{
			if (element is global::Infragistics.Controls.Primitives.ISelectableElement)
			{
				return (global::Infragistics.Controls.Primitives.ISelectableElement)element;
			}
			if (element == root)
			{
				return null;
			}
			global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(element);
			if (parent == null)
			{
				return null;
			}
			return global::Infragistics.Controls.Primitives.SelectionController.GetSelectableElement(parent, root);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000277 RID: 631 RVA: 0x0000D1A4 File Offset: 0x0000B3A4
		// (remove) Token: 0x06000278 RID: 632 RVA: 0x0000D1DC File Offset: 0x0000B3DC
		public event global::System.EventHandler ActiveStrategyChanged;

		// Token: 0x04000178 RID: 376
		private global::Infragistics.Controls.Primitives.ISelectionHost _host;

		// Token: 0x04000179 RID: 377
		private global::Infragistics.Controls.Primitives.SelectionStrategyBase _currentStrategy;

		// Token: 0x0400017A RID: 378
		private global::Infragistics.Controls.Primitives.ISelectableItem _currentItem;
	}
}
