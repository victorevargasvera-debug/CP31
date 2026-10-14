using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Threading;
using Infragistics.Windows;
using Infragistics.Windows.Controls;

namespace Infragistics.Controls
{
	// Token: 0x0200003F RID: 63
	internal static class DialogManager
	{
		// Token: 0x06000296 RID: 662 RVA: 0x0000AE14 File Offset: 0x00009014
		internal static void ActivateDialog(global::System.Windows.FrameworkElement dialog)
		{
			if (dialog is global::System.Windows.Window)
			{
				((global::System.Windows.Window)dialog).Activate();
				return;
			}
			if (dialog is global::Infragistics.Windows.Controls.ToolWindow)
			{
				((global::Infragistics.Windows.Controls.ToolWindow)dialog).Activate();
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000AE40 File Offset: 0x00009040
		internal static void CloseDialog(global::System.Windows.FrameworkElement dialogElement)
		{
			global::System.Windows.Window window = dialogElement as global::System.Windows.Window;
			if (window != null)
			{
				window.Close();
				return;
			}
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = dialogElement as global::Infragistics.Windows.Controls.ToolWindow;
			if (toolWindow != null)
			{
				toolWindow.Close();
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000AE70 File Offset: 0x00009070
		internal static global::System.Windows.FrameworkElement DisplayDialog(global::System.Windows.FrameworkElement container, global::System.Windows.FrameworkElement dialogContents, global::System.Windows.Size dialogSize, bool resizable, object header, bool showModally, global::System.Windows.ResourceDictionary resources, global::System.Func<bool> closingCallback, global::System.Action<bool?> closedCallback)
		{
			return global::Infragistics.Controls.DialogManager.DisplayDialog(container, dialogContents, dialogSize, resizable, header, showModally, resources, closingCallback, closedCallback, false);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000AFFC File Offset: 0x000091FC
		internal static global::System.Windows.FrameworkElement DisplayDialog(global::System.Windows.FrameworkElement container, global::System.Windows.FrameworkElement dialogContents, global::System.Windows.Size dialogSize, bool resizable, object header, bool showModally, global::System.Windows.ResourceDictionary resources, global::System.Func<bool> closingCallback, global::System.Action<bool?> closedCallback, bool resizeSilverlightWindowToFitInBrowser)
		{
			global::Infragistics.Controls.DialogManager.<>c__DisplayClassc CS$<>8__locals1 = new global::Infragistics.Controls.DialogManager.<>c__DisplayClassc();
			CS$<>8__locals1.showModally = showModally;
			CS$<>8__locals1.closingCallback = closingCallback;
			CS$<>8__locals1.closedCallback = closedCallback;
			global::System.Windows.Window window3 = container as global::System.Windows.Window;
			if (window3 == null && !global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				window3 = global::Infragistics.Controls.PresentationUtilities.GetVisualAncestor<global::System.Windows.Window>(container, null, null);
			}
			if (dialogContents is global::System.Windows.Window)
			{
				global::System.Windows.Window window = dialogContents as global::System.Windows.Window;
				window.Title = ((header == null) ? string.Empty : header.ToString());
				window.ResizeMode = (resizable ? global::System.Windows.ResizeMode.CanResizeWithGrip : global::System.Windows.ResizeMode.NoResize);
				window.Owner = window3;
				if (window3 == null)
				{
					global::System.IntPtr ownerHwnd = global::Infragistics.Controls.DialogManager.GetOwnerHwnd(container);
					if (global::System.IntPtr.Zero != ownerHwnd)
					{
						global::Infragistics.Controls.DialogManager.SetWindowOwner(dialogContents as global::System.Windows.Window, ownerHwnd);
					}
				}
				if (!resizable)
				{
					window.WindowStyle = global::System.Windows.WindowStyle.ToolWindow;
				}
				global::Infragistics.Windows.Utilities.EnableModelessKeyboardInteropForWindow(window);
				if (CS$<>8__locals1.showModally)
				{
					window.WindowStartupLocation = global::System.Windows.WindowStartupLocation.CenterOwner;
				}
				if (dialogSize != global::System.Windows.Size.Empty)
				{
					dialogContents.Width = dialogSize.Width;
					dialogContents.Height = dialogSize.Height;
				}
				else
				{
					window.SizeToContent = global::System.Windows.SizeToContent.WidthAndHeight;
				}
				if (resources != null)
				{
					dialogContents.Resources.MergedDictionaries.Add(resources);
				}
				window.Loaded += delegate(object sender, global::System.Windows.RoutedEventArgs e)
				{
					global::System.Windows.Threading.DispatcherOperationCallback method = delegate(object param)
					{
						((global::System.Windows.Window)param).MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
						return null;
					};
					((global::System.Windows.Window)sender).Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Loaded, method, sender);
				};
				window.Closing += delegate(object sender, global::System.ComponentModel.CancelEventArgs e)
				{
					global::System.Windows.Window window2 = sender as global::System.Windows.Window;
					if (CS$<>8__locals1.closingCallback != null)
					{
						bool flag = CS$<>8__locals1.closingCallback();
						if (flag)
						{
							e.Cancel = true;
						}
					}
					if (!CS$<>8__locals1.showModally && !e.Cancel)
					{
						window2.Owner = null;
					}
				};
				if (CS$<>8__locals1.closedCallback != null)
				{
					window.Closed += delegate(object sender, global::System.EventArgs e)
					{
						CS$<>8__locals1.closedCallback(window.DialogResult);
					};
				}
				if (CS$<>8__locals1.showModally)
				{
					((global::System.Windows.Window)dialogContents).ShowDialog();
				}
				else
				{
					((global::System.Windows.Window)dialogContents).Show();
				}
				return dialogContents;
			}
			global::Infragistics.Windows.Controls.ToolWindow toolWindow = new global::Infragistics.Windows.Controls.ToolWindow();
			toolWindow.Content = dialogContents;
			toolWindow.ResizeMode = (resizable ? global::System.Windows.ResizeMode.CanResizeWithGrip : global::System.Windows.ResizeMode.NoResize);
			toolWindow.Title = ((header == null) ? string.Empty : header.ToString());
			if (dialogSize != global::System.Windows.Size.Empty)
			{
				toolWindow.Width = dialogSize.Width;
				toolWindow.Height = dialogSize.Height;
			}
			if (!resizable)
			{
				toolWindow.AllowMaximize = (toolWindow.AllowMinimize = false);
			}
			if (CS$<>8__locals1.showModally)
			{
				toolWindow.WindowStartupLocation = global::Infragistics.Windows.Controls.ToolWindowStartupLocation.CenterOwnerWindow;
			}
			if (resources != null)
			{
				toolWindow.Resources.MergedDictionaries.Add(resources);
			}
			toolWindow.Loaded += delegate(object sender, global::System.Windows.RoutedEventArgs e)
			{
				global::System.Windows.Threading.DispatcherOperationCallback method = delegate(object param)
				{
					((global::Infragistics.Windows.Controls.ToolWindow)param).MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
					return null;
				};
				((global::Infragistics.Windows.Controls.ToolWindow)sender).Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Loaded, method, sender);
			};
			if (CS$<>8__locals1.closingCallback != null)
			{
				toolWindow.Closing += delegate(object sender, global::System.ComponentModel.CancelEventArgs e)
				{
					bool flag = CS$<>8__locals1.closingCallback();
					if (flag)
					{
						e.Cancel = true;
					}
				};
			}
			if (CS$<>8__locals1.closedCallback != null)
			{
				toolWindow.Closed += delegate(object sender, global::System.EventArgs e)
				{
					CS$<>8__locals1.closedCallback(toolWindow.DialogResult);
				};
			}
			global::System.Windows.FrameworkElement owner = container ?? window3;
			if (CS$<>8__locals1.showModally)
			{
				toolWindow.ShowDialog(owner, null);
			}
			else
			{
				toolWindow.Show(owner);
			}
			return toolWindow;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000B374 File Offset: 0x00009574
		internal static global::System.IntPtr GetOwnerHwnd(global::System.Windows.FrameworkElement owner)
		{
			if (global::Infragistics.Controls.DialogManager._getOwnerHwndFailed)
			{
				return global::System.IntPtr.Zero;
			}
			if (global::System.Windows.Interop.BrowserInteropHelper.IsBrowserHosted)
			{
				return global::System.IntPtr.Zero;
			}
			global::System.IntPtr result;
			try
			{
				result = global::Infragistics.Controls.DialogManager.GetOwnerHwndImpl(owner);
			}
			catch (global::System.Security.SecurityException)
			{
				global::Infragistics.Controls.DialogManager._getOwnerHwndFailed = true;
				result = global::System.IntPtr.Zero;
			}
			return result;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000B3C4 File Offset: 0x000095C4
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static global::System.IntPtr GetOwnerHwndImpl(global::System.Windows.FrameworkElement owner)
		{
			global::System.Windows.Interop.HwndSource hwndSource = global::System.Windows.PresentationSource.FromVisual(owner) as global::System.Windows.Interop.HwndSource;
			if (hwndSource == null)
			{
				return global::System.IntPtr.Zero;
			}
			return hwndSource.Handle;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000B3EC File Offset: 0x000095EC
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static void SetWindowOwner(global::System.Windows.Window window, global::System.IntPtr ownerHwnd)
		{
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(window);
			windowInteropHelper.Owner = ownerHwnd;
		}

		// Token: 0x040000C7 RID: 199
		private static bool _getOwnerHwndFailed;

		// Token: 0x02000040 RID: 64
		internal class CloseDialogHelper<T>
		{
			// Token: 0x060002A2 RID: 674 RVA: 0x0000B409 File Offset: 0x00009609
			internal CloseDialogHelper(global::System.Action<bool?, T> closeAction, T closeContext)
			{
				this._context = closeContext;
				this._closeAction = closeAction;
			}

			// Token: 0x060002A3 RID: 675 RVA: 0x0000B41F File Offset: 0x0000961F
			public void OnClosed(bool? dialogResult)
			{
				this._closeAction(dialogResult, this._context);
			}

			// Token: 0x040000CC RID: 204
			private T _context;

			// Token: 0x040000CD RID: 205
			private global::System.Action<bool?, T> _closeAction;
		}
	}
}
