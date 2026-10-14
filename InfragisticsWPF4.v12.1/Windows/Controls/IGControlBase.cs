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
	// Token: 0x02000188 RID: 392
	public abstract class IGControlBase : global::System.Windows.Controls.Control
	{
		// Token: 0x06000D20 RID: 3360 RVA: 0x00029CAC File Offset: 0x00027EAC
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

		// Token: 0x06000D21 RID: 3361 RVA: 0x00029D18 File Offset: 0x00027F18
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::Infragistics.Windows.Resizing.IResizeHost resizeHost = this as global::Infragistics.Windows.Resizing.IResizeHost;
			if (resizeHost != null && resizeHost.Controller.ResizerBar != null)
			{
				resizeHost.Controller.PositionResizerBar();
			}
			return base.ArrangeOverride(finalSize);
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x00029D50 File Offset: 0x00027F50
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			global::Infragistics.Windows.Resizing.IResizeHost resizeHost = this as global::Infragistics.Windows.Resizing.IResizeHost;
			if (resizeHost != null && resizeHost.Controller.ResizerBar != null && index == base.VisualChildrenCount)
			{
				return resizeHost.Controller.ResizerBar;
			}
			return base.GetVisualChild(index);
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00029D90 File Offset: 0x00027F90
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == global::System.Windows.Input.Key.Escape)
			{
				e.Handled = this.CancelPendingMouseOperations();
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

		// Token: 0x06000D24 RID: 3364 RVA: 0x00029DEE File Offset: 0x00027FEE
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			if (e.OriginalSource == this || !base.IsMouseCaptured)
			{
				this.CancelPendingMouseOperations();
			}
			base.OnLostMouseCapture(e);
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00029E0F File Offset: 0x0002800F
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			if (this._selectionController != null && !e.Handled)
			{
				this._selectionController.OnMouseLeftButtonDown(e);
				bool handled = e.Handled;
			}
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00029E3C File Offset: 0x0002803C
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

		// Token: 0x06000D27 RID: 3367 RVA: 0x00029E8C File Offset: 0x0002808C
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

		// Token: 0x06000D28 RID: 3368 RVA: 0x00029EDC File Offset: 0x000280DC
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnPreviewMouseLeftButtonDown(e);
			if (!e.Handled && !base.IsKeyboardFocused && !base.IsKeyboardFocusWithin && base.Focusable && base.IsEnabled && !global::Infragistics.Windows.Utilities.IsDescendantOf(this, global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.DependencyObject, true))
			{
				base.Focus();
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x00029F34 File Offset: 0x00028134
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

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000D2A RID: 3370
		protected internal abstract global::Infragistics.Windows.Commands.CommandsBase Commands { get; }

		// Token: 0x06000D2B RID: 3371 RVA: 0x00029F64 File Offset: 0x00028164
		protected virtual void OnActiveSelectionStrategyChanged(global::Infragistics.Windows.Selection.SelectionStrategyBase strategy)
		{
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00029F68 File Offset: 0x00028168
		private bool CancelPendingMouseOperations()
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
				flag = (flag || this._selectionController.CancelPendingOperations());
			}
			return flag;
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00029FB6 File Offset: 0x000281B6
		private void OnActiveSelectionStrategyChanged(object sender, global::System.EventArgs e)
		{
			this.OnActiveSelectionStrategyChanged(this._selectionController.ActiveStrategy);
		}

		// Token: 0x040006C8 RID: 1736
		private global::Infragistics.Windows.Selection.SelectionController _selectionController;

		// Token: 0x040006C9 RID: 1737
		private global::Infragistics.Windows.Resizing.ResizeController _resizeController;
	}
}
