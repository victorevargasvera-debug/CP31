using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Windows.Commands;
using Infragistics.Windows.Resizing;
using Infragistics.Windows.Selection;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020001AD RID: 429
	public abstract class IGControlBase : global::System.Windows.Controls.Control
	{
		// Token: 0x06000E6A RID: 3690 RVA: 0x0002E3A0 File Offset: 0x0002C5A0
		protected IGControlBase()
		{
			global::Infragistics.Windows.Themes.ThemeManager.VerifyThemeInformationRegistered(base.GetType().Assembly);
			if (this is global::Infragistics.Windows.Selection.ISelectionHost)
			{
				this._selectionController = new global::Infragistics.Windows.Selection.SelectionController((global::Infragistics.Windows.Selection.ISelectionHost)this);
				this._selectionController.ActiveStrategyChanged += this.OnActiveSelectionStrategyChanged;
			}
			if (this is global::Infragistics.Windows.Resizing.IResizeHost)
			{
				this._resizeController = ((global::Infragistics.Windows.Resizing.IResizeHost)this).Controller;
			}
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x0002E40C File Offset: 0x0002C60C
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::Infragistics.Windows.Resizing.IResizeHost resizeHost = this as global::Infragistics.Windows.Resizing.IResizeHost;
			if (resizeHost != null && resizeHost.Controller.ResizerBar != null)
			{
				resizeHost.Controller.PositionResizerBar();
			}
			return base.ArrangeOverride(finalSize);
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0002E444 File Offset: 0x0002C644
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			global::Infragistics.Windows.Resizing.IResizeHost resizeHost = this as global::Infragistics.Windows.Resizing.IResizeHost;
			if (resizeHost != null && resizeHost.Controller.ResizerBar != null && index == base.VisualChildrenCount)
			{
				return resizeHost.Controller.ResizerBar;
			}
			return base.GetVisualChild(index);
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x0002E484 File Offset: 0x0002C684
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == global::System.Windows.Input.Key.Escape)
			{
				e.Handled = this.CancelPendingMouseOperations(true);
			}
			base.OnKeyDown(e);
			if (e.Handled)
			{
				return;
			}
			if (!e.Handled && this.Commands != null && this.Commands.ProcessKeyboardInput(e, this as global::Infragistics.Windows.Commands.ICommandHost))
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x0002E4E3 File Offset: 0x0002C6E3
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			if (e.OriginalSource == this || !base.IsMouseCaptured)
			{
				this.CancelPendingMouseOperations(false);
			}
			base.OnLostMouseCapture(e);
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x0002E505 File Offset: 0x0002C705
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			if (this._selectionController != null && !e.Handled)
			{
				this._selectionController.OnMouseLeftButtonDown(e);
				bool handled = e.Handled;
			}
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x0002E534 File Offset: 0x0002C734
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (this._resizeController != null && this._resizeController.IsResizing)
			{
				return;
			}
			if (this._selectionController != null && !e.Handled)
			{
				this._selectionController.OnMouseMove(e);
				bool handled = e.Handled;
			}
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x0002E584 File Offset: 0x0002C784
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			if (this._resizeController != null && this._resizeController.IsResizing)
			{
				return;
			}
			if (this._selectionController != null && !e.Handled)
			{
				this._selectionController.OnMouseLeftButtonUp(e);
				bool handled = e.Handled;
			}
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x0002E5D4 File Offset: 0x0002C7D4
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnPreviewMouseLeftButtonDown(e);
			if (!e.Handled && !base.IsKeyboardFocused && !base.IsKeyboardFocusWithin && base.Focusable && base.IsEnabled && !global::Infragistics.Windows.Utilities.IsDescendantOf(this, global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.DependencyObject, true))
			{
				this.PerformFocusOnPreviewMouseLeftButtonDown(e);
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x0002E62C File Offset: 0x0002C82C
		protected override int VisualChildrenCount
		{
			get
			{
				int num = base.VisualChildrenCount;
				global::Infragistics.Windows.Resizing.IResizeHost resizeHost = this as global::Infragistics.Windows.Resizing.IResizeHost;
				if (resizeHost != null && resizeHost.Controller.ResizerBar != null)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000E74 RID: 3700
		protected internal abstract global::Infragistics.Windows.Commands.CommandsBase Commands { get; }

		// Token: 0x06000E75 RID: 3701 RVA: 0x0002E65C File Offset: 0x0002C85C
		protected virtual void OnActiveSelectionStrategyChanged(global::Infragistics.Windows.Selection.SelectionStrategyBase strategy)
		{
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x0002E65E File Offset: 0x0002C85E
		internal virtual void PerformFocusOnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs args)
		{
			base.Focus();
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x0002E668 File Offset: 0x0002C868
		private bool CancelPendingMouseOperations(bool killDblClickTimer)
		{
			global::Infragistics.Windows.Resizing.IResizeHost resizeHost = this as global::Infragistics.Windows.Resizing.IResizeHost;
			bool flag = false;
			if (resizeHost != null && resizeHost.Controller.IsResizing)
			{
				resizeHost.Controller.CancelResize();
				flag = true;
			}
			if (this._selectionController != null)
			{
				flag = (flag || this._selectionController.CancelPendingOperations(killDblClickTimer));
			}
			return flag;
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x0002E6B7 File Offset: 0x0002C8B7
		private void OnActiveSelectionStrategyChanged(object sender, global::System.EventArgs e)
		{
			this.OnActiveSelectionStrategyChanged(this._selectionController.ActiveStrategy);
		}

		// Token: 0x040007EE RID: 2030
		private global::Infragistics.Windows.Selection.SelectionController _selectionController;

		// Token: 0x040007EF RID: 2031
		private global::Infragistics.Windows.Resizing.ResizeController _resizeController;
	}
}
