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
	// Token: 0x02000030 RID: 48
	internal static class DialogManager
	{
		// Token: 0x0600021C RID: 540 RVA: 0x000098A4 File Offset: 0x00007AA4
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

		// Token: 0x0600021D RID: 541 RVA: 0x000098D0 File Offset: 0x00007AD0
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

		// Token: 0x0600021E RID: 542 RVA: 0x00009900 File Offset: 0x00007B00
		internal static global::System.Windows.FrameworkElement DisplayDialog(global::System.Windows.FrameworkElement container, global::System.Windows.FrameworkElement dialogContents, global::System.Windows.Size dialogSize, bool resizable, object header, bool showModally, global::System.Windows.ResourceDictionary resources, global::System.Func<bool> closingCallback, global::System.Action<bool?> closedCallback)
		{
			return global::Infragistics.Controls.DialogManager.DisplayDialog(container, dialogContents, dialogSize, resizable, header, showModally, resources, closingCallback, closedCallback, false);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00009A8C File Offset: 0x00007C8C
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

		// Token: 0x06000220 RID: 544 RVA: 0x00009E04 File Offset: 0x00008004
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

		// Token: 0x06000221 RID: 545 RVA: 0x00009E54 File Offset: 0x00008054
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

		// Token: 0x06000222 RID: 546 RVA: 0x00009E7C File Offset: 0x0000807C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static void SetWindowOwner(global::System.Windows.Window window, global::System.IntPtr ownerHwnd)
		{
			global::System.Windows.Interop.WindowInteropHelper windowInteropHelper = new global::System.Windows.Interop.WindowInteropHelper(window);
			windowInteropHelper.Owner = ownerHwnd;
		}

		// Token: 0x0400007B RID: 123
		private static bool _getOwnerHwndFailed;

		// Token: 0x02000031 RID: 49
		internal class CloseDialogHelper<T>
		{
			// Token: 0x06000228 RID: 552 RVA: 0x00009E99 File Offset: 0x00008099
			internal CloseDialogHelper(global::System.Action<bool?, T> closeAction, T closeContext)
			{
				this._context = closeContext;
				this._closeAction = closeAction;
			}

			// Token: 0x06000229 RID: 553 RVA: 0x00009EAF File Offset: 0x000080AF
			public void OnClosed(bool? dialogResult)
			{
				this._closeAction(dialogResult, this._context);
			}

			// Token: 0x04000080 RID: 128
			private T _context;

			// Token: 0x04000081 RID: 129
			private global::System.Action<bool?, T> _closeAction;
		}
	}
}
