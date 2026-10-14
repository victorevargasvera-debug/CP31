using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Interop;
using System.Windows.Media;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000213 RID: 531
	internal class PopupController : global::System.Windows.DependencyObject
	{
		// Token: 0x060014EC RID: 5356 RVA: 0x0004DF34 File Offset: 0x0004C134
		private PopupController(global::System.Windows.Controls.Primitives.Popup popup, global::System.Windows.FrameworkElement owner)
		{
			this._owner = owner;
			this._popup = popup;
			this._popup.Opened += this.OnPopupOpened;
			global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.Controls.PopupController.HorizontalOffsetProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Controls.Primitives.Popup.HorizontalOffsetProperty, global::System.Windows.Data.BindingMode.OneWay, popup));
			global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.Controls.PopupController.VerticalOffsetProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Controls.Primitives.Popup.VerticalOffsetProperty, global::System.Windows.Data.BindingMode.OneWay, popup));
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x0004DF9C File Offset: 0x0004C19C
		// (set) Token: 0x060014EE RID: 5358 RVA: 0x0004DFA4 File Offset: 0x0004C1A4
		public bool? TopMost
		{
			get
			{
				return this._topMost;
			}
			set
			{
				this._topMost = value;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x0004DFB0 File Offset: 0x0004C1B0
		private bool IsTopMost
		{
			get
			{
				bool? topMost = this.TopMost;
				if (topMost == null)
				{
					topMost = new bool?(false);
					if (this._ownerSource != null)
					{
						global::System.Windows.Window window = this._ownerSource.RootVisual as global::System.Windows.Window;
						if (window != null && !global::Infragistics.Windows.Utilities.IsBrowserWindow(window))
						{
							topMost = new bool?(window.Topmost);
						}
						else
						{
							global::System.Windows.Interop.HwndSource hwndSource = this._ownerSource as global::System.Windows.Interop.HwndSource;
							if (hwndSource != null && !hwndSource.IsDisposed)
							{
								topMost = new bool?(global::Infragistics.Windows.Helpers.NativeWindowMethods.IsTopMostApi(hwndSource.Handle));
							}
						}
					}
				}
				return topMost.Value;
			}
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0004E038 File Offset: 0x0004C238
		public static global::Infragistics.Windows.Controls.PopupController Create(global::System.Windows.Controls.Primitives.Popup popup, global::System.Windows.FrameworkElement owner)
		{
			if (!global::Infragistics.Windows.Controls.PopupController._controllerCreateFailed)
			{
				try
				{
					global::System.Security.Permissions.UIPermission uipermission = new global::System.Security.Permissions.UIPermission(global::System.Security.Permissions.UIPermissionWindow.AllWindows);
					uipermission.Demand();
					return new global::Infragistics.Windows.Controls.PopupController(popup, owner);
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Controls.PopupController._controllerCreateFailed = true;
				}
			}
			return null;
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0004E080 File Offset: 0x0004C280
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		internal static void BringToFront(global::System.Windows.Controls.Primitives.Popup popup)
		{
			if (popup.IsOpen)
			{
				global::System.Windows.UIElement child = popup.Child;
				if (child != null)
				{
					global::System.Windows.Interop.HwndSource hwndSource = global::System.Windows.PresentationSource.FromVisual(child) as global::System.Windows.Interop.HwndSource;
					if (!hwndSource.IsDisposed && hwndSource.Handle != global::System.IntPtr.Zero)
					{
						global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowPosApi(hwndSource.Handle, global::Infragistics.Windows.Helpers.NativeWindowMethods.HWND_TOP, 0, 0, 0, 0, 19);
					}
				}
			}
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0004E0DC File Offset: 0x0004C2DC
		private void AddChildHook(global::System.Windows.PresentationSource newSource)
		{
			this.RemoveChildHook(newSource);
			global::System.Windows.Interop.HwndSource hwndSource = newSource as global::System.Windows.Interop.HwndSource;
			if (hwndSource != null)
			{
				hwndSource.AddHook(new global::System.Windows.Interop.HwndSourceHook(this.ChildHookProc));
			}
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0004E10C File Offset: 0x0004C30C
		private void AddOwnerHook(global::System.Windows.PresentationSource newSource)
		{
			this.RemoveOwnerHook(newSource);
			global::System.Windows.Interop.HwndSource hwndSource = newSource as global::System.Windows.Interop.HwndSource;
			if (hwndSource != null)
			{
				hwndSource.AddHook(new global::System.Windows.Interop.HwndSourceHook(this.OwnerHookProc));
			}
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0004E13C File Offset: 0x0004C33C
		private object BringToFront(object state)
		{
			global::System.Windows.Interop.HwndSource hwndSource = state as global::System.Windows.Interop.HwndSource;
			if (hwndSource != null && !hwndSource.IsDisposed && hwndSource.Handle != global::System.IntPtr.Zero)
			{
				global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this._popup);
				if (window != null && !global::Infragistics.Windows.Utilities.IsBrowserWindow(window))
				{
					global::System.IntPtr intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetFocus();
					global::System.IntPtr handle = new global::System.Windows.Interop.WindowInteropHelper(window).Handle;
					bool flag = false;
					while (intPtr != global::System.IntPtr.Zero)
					{
						if (intPtr == handle || intPtr == hwndSource.Handle)
						{
							flag = true;
							break;
						}
						intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetParent(intPtr);
					}
					if (!flag)
					{
						window.Activate();
					}
				}
				global::System.IntPtr hwnd_TOP = global::Infragistics.Windows.Helpers.NativeWindowMethods.HWND_TOP;
				global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowPosApi(hwndSource.Handle, hwnd_TOP, 0, 0, 0, 0, 19);
			}
			return null;
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0004E1FC File Offset: 0x0004C3FC
		private global::System.IntPtr ChildHookProc(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			if (msg != 33)
			{
				if (msg == 70)
				{
					global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPOS windowpos = (global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPOS)global::System.Runtime.InteropServices.Marshal.PtrToStructure(lParam, typeof(global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPOS));
					global::System.Windows.Interop.HwndSource hwndSource = this._childSource as global::System.Windows.Interop.HwndSource;
					global::System.Windows.Media.Matrix matrix = (((hwndSource != null) ? hwndSource.CompositionTarget : null) != null) ? hwndSource.CompositionTarget.TransformToDevice : global::System.Windows.Media.Matrix.Identity;
					global::System.Windows.Point point = new global::System.Windows.Point(this._popup.HorizontalOffset, this._popup.VerticalOffset);
					point = matrix.Transform(point);
					global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT point2 = new global::Infragistics.Windows.Helpers.NativeWindowMethods.POINT((int)point.X, (int)point.Y);
					windowpos.x = point2.X;
					windowpos.y = point2.Y;
					global::System.Runtime.InteropServices.Marshal.StructureToPtr(windowpos, lParam, true);
				}
			}
			else
			{
				this.BringToFront(this._childSource);
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0004E2E4 File Offset: 0x0004C4E4
		private void InitializeChildSource(global::System.Windows.PresentationSource source)
		{
			global::System.Windows.Interop.HwndSource hwndSource = source as global::System.Windows.Interop.HwndSource;
			if (hwndSource != null)
			{
				bool isTopMost = this.IsTopMost;
				global::System.IntPtr handle = hwndSource.Handle;
				if (handle != global::System.IntPtr.Zero)
				{
					global::System.IntPtr windowLong = global::Infragistics.Windows.Helpers.NativeWindowMethods.GetWindowLong(handle, -20);
					global::System.IntPtr intPtr = windowLong;
					if (isTopMost)
					{
						intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.AddBits(intPtr, 8);
					}
					else
					{
						intPtr = global::Infragistics.Windows.Helpers.NativeWindowMethods.RemoveBits(intPtr, 8);
					}
					if (windowLong != intPtr)
					{
						global::System.IntPtr hWndInsertAfter = isTopMost ? global::Infragistics.Windows.Helpers.NativeWindowMethods.HWND_TOPMOST : global::Infragistics.Windows.Helpers.NativeWindowMethods.HWND_NOTOPMOST;
						global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowPosApi(handle, hWndInsertAfter, 0, 0, 0, 0, 19);
					}
				}
				this.AddChildHook(source);
			}
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0004E36C File Offset: 0x0004C56C
		private void OnChildSourceChanged(object sender, global::System.Windows.SourceChangedEventArgs e)
		{
			this.RemoveChildHook(e.OldSource);
			this._childSource = e.NewSource;
			this.InitializeChildSource(e.NewSource);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0004E392 File Offset: 0x0004C592
		private static void OnOffsetChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.PopupController)d).RefreshPopupLocation();
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0004E39F File Offset: 0x0004C59F
		private void OnOwnerSourceChanged(object sender, global::System.Windows.SourceChangedEventArgs e)
		{
			this.RemoveOwnerHook(e.OldSource);
			this._ownerSource = e.NewSource;
			this.AddOwnerHook(this._ownerSource);
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x0004E3C8 File Offset: 0x0004C5C8
		private void OnPopupClosed(object sender, global::System.EventArgs e)
		{
			this._popup.Closed -= this.OnPopupClosed;
			this._popup.Opened += this.OnPopupOpened;
			this.RemoveChildHook(this._childSource);
			this.RemoveOwnerHook(this._ownerSource);
			this._ownerSource = null;
			this._childSource = null;
			global::System.Windows.PresentationSource.RemoveSourceChangedHandler(this._popup, new global::System.Windows.SourceChangedEventHandler(this.OnOwnerSourceChanged));
			global::System.Windows.PresentationSource.RemoveSourceChangedHandler(this._popup.Child, new global::System.Windows.SourceChangedEventHandler(this.OnChildSourceChanged));
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x0004E45C File Offset: 0x0004C65C
		private void OnPopupOpened(object sender, global::System.EventArgs e)
		{
			this._popup.Opened -= this.OnPopupOpened;
			this._popup.Closed += this.OnPopupClosed;
			this._ownerSource = global::System.Windows.PresentationSource.FromVisual(this._owner ?? this._popup);
			this._childSource = (global::System.Windows.PresentationSource.FromVisual(this._popup.Child) as global::System.Windows.Interop.HwndSource);
			this.InitializeChildSource(this._childSource);
			this.AddOwnerHook(this._ownerSource);
			global::System.Windows.PresentationSource.AddSourceChangedHandler(this._popup, new global::System.Windows.SourceChangedEventHandler(this.OnOwnerSourceChanged));
			global::System.Windows.PresentationSource.AddSourceChangedHandler(this._popup.Child, new global::System.Windows.SourceChangedEventHandler(this.OnChildSourceChanged));
			this.RefreshPopupLocation();
			this.BringToFront(this._childSource);
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0004E52C File Offset: 0x0004C72C
		private global::System.IntPtr OwnerHookProc(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			if (msg != 71)
			{
				if (msg == 126)
				{
					global::Infragistics.Windows.Controls.IToolWindowHost host = global::Infragistics.Windows.Controls.ToolWindowHostPopup.GetHost(this._popup);
					if (host != null)
					{
						host.EnsureOnScreen(true);
					}
				}
			}
			else
			{
				global::Infragistics.Windows.Controls.IToolWindowHost host2 = global::Infragistics.Windows.Controls.ToolWindowHostPopup.GetHost(this._popup);
				if (host2 != null && (((global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPOS)global::System.Runtime.InteropServices.Marshal.PtrToStructure(lParam, typeof(global::Infragistics.Windows.Helpers.NativeWindowMethods.WINDOWPOS))).flags & 3) != 3)
				{
					host2.RelativePositionStateChanged();
				}
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0004E59C File Offset: 0x0004C79C
		private void RefreshPopupLocation()
		{
			global::System.Windows.Interop.HwndSource hwndSource = this._childSource as global::System.Windows.Interop.HwndSource;
			if (hwndSource != null && !hwndSource.IsDisposed && hwndSource.CompositionTarget != null && hwndSource.Handle != global::System.IntPtr.Zero)
			{
				global::System.Windows.Media.Matrix transformToDevice = hwndSource.CompositionTarget.TransformToDevice;
				global::System.Windows.Point point = new global::System.Windows.Point(this._popup.HorizontalOffset, this._popup.VerticalOffset);
				global::System.Windows.Point point2 = transformToDevice.Transform(point);
				int flags = 533;
				global::Infragistics.Windows.Helpers.NativeWindowMethods.SetWindowPosApi(hwndSource.Handle, global::System.IntPtr.Zero, (int)point2.X, (int)point2.Y, 0, 0, flags);
			}
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x0004E63C File Offset: 0x0004C83C
		private void RemoveChildHook(global::System.Windows.PresentationSource oldSource)
		{
			global::System.Windows.Interop.HwndSource hwndSource = oldSource as global::System.Windows.Interop.HwndSource;
			if (hwndSource != null)
			{
				hwndSource.RemoveHook(new global::System.Windows.Interop.HwndSourceHook(this.ChildHookProc));
			}
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x0004E668 File Offset: 0x0004C868
		private void RemoveOwnerHook(global::System.Windows.PresentationSource oldSource)
		{
			global::System.Windows.Interop.HwndSource hwndSource = oldSource as global::System.Windows.Interop.HwndSource;
			if (hwndSource != null)
			{
				hwndSource.RemoveHook(new global::System.Windows.Interop.HwndSourceHook(this.OwnerHookProc));
			}
		}

		// Token: 0x04000A82 RID: 2690
		private global::System.Windows.FrameworkElement _owner;

		// Token: 0x04000A83 RID: 2691
		private global::System.Windows.PresentationSource _ownerSource;

		// Token: 0x04000A84 RID: 2692
		private global::System.Windows.PresentationSource _childSource;

		// Token: 0x04000A85 RID: 2693
		private global::System.Windows.Controls.Primitives.Popup _popup;

		// Token: 0x04000A86 RID: 2694
		private bool? _topMost;

		// Token: 0x04000A87 RID: 2695
		private static bool _controllerCreateFailed;

		// Token: 0x04000A88 RID: 2696
		private static readonly global::System.Windows.DependencyProperty HorizontalOffsetProperty = global::System.Windows.DependencyProperty.Register("HorizontalOffset", typeof(double), typeof(global::Infragistics.Windows.Controls.PopupController), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.PopupController.OnOffsetChanged)));

		// Token: 0x04000A89 RID: 2697
		private static readonly global::System.Windows.DependencyProperty VerticalOffsetProperty = global::System.Windows.DependencyProperty.Register("VerticalOffset", typeof(double), typeof(global::Infragistics.Windows.Controls.PopupController), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.PopupController.OnOffsetChanged)));
	}
}
