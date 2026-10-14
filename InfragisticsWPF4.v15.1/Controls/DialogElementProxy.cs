using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Interop;
using Infragistics.Windows.Controls;

namespace Infragistics.Controls
{
	// Token: 0x02000041 RID: 65
	internal class DialogElementProxy : global::System.IDisposable
	{
		// Token: 0x060002A4 RID: 676 RVA: 0x0000B434 File Offset: 0x00009634
		internal DialogElementProxy(global::System.Windows.FrameworkElement childElement)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(childElement, "childElement");
			if (!(childElement is global::Infragistics.Controls.IDialogElementProxyHost))
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_DoesNotImplementInterface", new object[]
				{
					"IDialogElementProxyHost"
				}), "childElement");
			}
			this._childElement = childElement;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000B488 File Offset: 0x00009688
		public void Dispose()
		{
			if (this._childElement != null)
			{
				if (this._dialogElement != null)
				{
					if (global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
					{
						((global::Infragistics.Windows.Controls.ToolWindow)this._dialogElement).Closing -= this.OnWindowClosing;
					}
					else if (this._dialogElement is global::System.Windows.Window)
					{
						((global::System.Windows.Window)this._dialogElement).Closing -= this.OnWindowClosing;
					}
					else if (this._dialogElement is global::Infragistics.Windows.Controls.ToolWindow)
					{
						((global::Infragistics.Windows.Controls.ToolWindow)this._dialogElement).Closing -= this.OnWindowClosing;
					}
					this._dialogElement = null;
				}
				this._isInitialized = false;
				this._childElement = null;
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000B539 File Offset: 0x00009739
		internal void Close()
		{
			global::Infragistics.Controls.DialogManager.CloseDialog(this.DialogElement);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000B548 File Offset: 0x00009748
		internal void Initialize()
		{
			if (!this._isInitialized && this.DialogElement != null)
			{
				if (global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
				{
					if (this.DialogElement is global::Infragistics.Windows.Controls.ToolWindow)
					{
						((global::Infragistics.Windows.Controls.ToolWindow)this.DialogElement).Closing += this.OnWindowClosing;
					}
				}
				else if (this.DialogElement is global::System.Windows.Window)
				{
					((global::System.Windows.Window)this.DialogElement).Closing += this.OnWindowClosing;
				}
				else if (this.DialogElement is global::Infragistics.Windows.Controls.ToolWindow)
				{
					((global::Infragistics.Windows.Controls.ToolWindow)this.DialogElement).Closing += this.OnWindowClosing;
				}
				this._isInitialized = true;
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000B5F8 File Offset: 0x000097F8
		internal void SetDialogResult(bool result)
		{
			global::System.Windows.FrameworkElement dialogElement = this.DialogElement;
			if (dialogElement is global::System.Windows.Window)
			{
				((global::System.Windows.Window)dialogElement).DialogResult = new bool?(result);
				return;
			}
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = dialogElement as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow != null)
			{
				if (toolWindow.IsModal)
				{
					toolWindow.DialogResult = new bool?(result);
					return;
				}
				toolWindow.Close();
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000B64B File Offset: 0x0000984B
		private void OnWindowClosing(object sender, global::System.ComponentModel.CancelEventArgs args)
		{
			if (!args.Cancel)
			{
				args.Cancel = ((global::Infragistics.Controls.IDialogElementProxyHost)this._childElement).OnClosing();
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000B66B File Offset: 0x0000986B
		internal global::System.Windows.FrameworkElement DialogElement
		{
			get
			{
				if (this._dialogElement == null)
				{
					this._dialogElement = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(this._childElement);
					if (this._dialogElement == null)
					{
						this._dialogElement = global::Infragistics.Controls.PresentationUtilities.GetVisualAncestor<global::System.Windows.Window>(this._childElement, null, null);
					}
				}
				return this._dialogElement;
			}
		}

		// Token: 0x040000CE RID: 206
		private bool _isInitialized;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.FrameworkElement _childElement;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.FrameworkElement _dialogElement;
	}
}
