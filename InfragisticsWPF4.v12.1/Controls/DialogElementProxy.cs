using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Interop;
using Infragistics.Windows.Controls;

namespace Infragistics.Controls
{
	// Token: 0x02000032 RID: 50
	internal class DialogElementProxy : global::System.IDisposable
	{
		// Token: 0x0600022A RID: 554 RVA: 0x00009EC4 File Offset: 0x000080C4
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

		// Token: 0x0600022B RID: 555 RVA: 0x00009F18 File Offset: 0x00008118
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

		// Token: 0x0600022C RID: 556 RVA: 0x00009FC9 File Offset: 0x000081C9
		internal void Close()
		{
			global::Infragistics.Controls.DialogManager.CloseDialog(this.DialogElement);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00009FD8 File Offset: 0x000081D8
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

		// Token: 0x0600022E RID: 558 RVA: 0x0000A088 File Offset: 0x00008288
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

		// Token: 0x0600022F RID: 559 RVA: 0x0000A0DB File Offset: 0x000082DB
		private void OnWindowClosing(object sender, global::System.ComponentModel.CancelEventArgs args)
		{
			if (!args.Cancel)
			{
				args.Cancel = ((global::Infragistics.Controls.IDialogElementProxyHost)this._childElement).OnClosing();
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0000A0FB File Offset: 0x000082FB
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

		// Token: 0x04000082 RID: 130
		private bool _isInitialized;

		// Token: 0x04000083 RID: 131
		private global::System.Windows.FrameworkElement _childElement;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.FrameworkElement _dialogElement;
	}
}
