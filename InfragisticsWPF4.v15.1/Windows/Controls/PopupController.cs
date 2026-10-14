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
	// Token: 0x02000244 RID: 580
	internal class PopupController : global::System.Windows.DependencyObject
	{
		// Token: 0x060016D6 RID: 5846 RVA: 0x00053F98 File Offset: 0x00052198
		private PopupController(global::System.Windows.Controls.Primitives.Popup popup, global::System.Windows.FrameworkElement owner)
		{
			this._owner = owner;
			this._popup = popup;
			this._popup.Opened += this.OnPopupOpened;
			global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.Controls.PopupController.HorizontalOffsetProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Controls.Primitives.Popup.HorizontalOffsetProperty, global::System.Windows.Data.BindingMode.OneWay, popup));
			global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.Controls.PopupController.VerticalOffsetProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Controls.Primitives.Popup.VerticalOffsetProperty, global::System.Windows.Data.BindingMode.OneWay, popup));
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x00054000 File Offset: 0x00052200
		// (set) Token: 0x060016D8 RID: 5848 RVA: 0x00054008 File Offset: 0x00052208
		public bool BindPopupRootExtents { get; set; }

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x00054011 File Offset: 0x00052211
		// (set) Token: 0x060016DA RID: 5850 RVA: 0x00054019 File Offset: 0x00052219
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

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x00054024 File Offset: 0x00052224
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

		// Token: 0x060016DC RID: 5852 RVA: 0x000540AC File Offset: 0x000522AC
		public static global::Infragistics.Windows.Controls.PopupController Create(global::System.Windows.Controls.Primitives.Popup popup, global::System.Windows.FrameworkElement owner)
		{
			if (!global::Infragistics.Windows.Controls.PopupController._controllerCreateFailed)
			{
				try
				{
					global::System.Security.Permissions.UIPermission uipermission = new global::System.Security.Permissions.UIPermission(global::System.Security.Permissions.UIPermissionWindow.AllWindows);
					uipermission.Demand();
					global::System.Security.PermissionSet permissionSet = new global::System.Security.PermissionSet(global::System.Security.Permissions.PermissionState.Unrestricted);
					permissionSet.Demand();
					return new global::Infragistics.Windows.Controls.PopupController(popup, owner);
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Controls.PopupController._controllerCreateFailed = true;
				}
			}
			return null;
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x00054100 File Offset: 0x00052300
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

		// Token: 0x060016DE RID: 5854 RVA: 0x0005415C File Offset: 0x0005235C
		internal void Deactivate()
		{
			this._isDeactivated = true;
			this._popup.Opened -= this.OnPopupOpened;
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x0005417C File Offset: 0x0005237C
		private void AddChildHook(global::System.Windows.PresentationSource newSource)
		{
			this.RemoveChildHook(newSource);
			global::System.Windows.Interop.HwndSource hwndSource = newSource as global::System.Windows.Interop.HwndSource;
			if (hwndSource != null)
			{
				hwndSource.AddHook(new global::System.Windows.Interop.HwndSourceHook(this.ChildHookProc));
			}
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x000541AC File Offset: 0x000523AC
		private void AddOwnerHook(global::System.Windows.PresentationSource newSource)
		{
			this.RemoveOwnerHook(newSource);
			global::System.Windows.Interop.HwndSource hwndSource = newSource as global::System.Windows.Interop.HwndSource;
			if (hwndSource != null)
			{
				hwndSource.AddHook(new global::System.Windows.Interop.HwndSourceHook(this.OwnerHookProc));
			}
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x000541DC File Offset: 0x000523DC
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

		// Token: 0x060016E2 RID: 5858 RVA: 0x0005429C File Offset: 0x0005249C
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

		// Token: 0x060016E3 RID: 5859 RVA: 0x00054384 File Offset: 0x00052584
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

		// Token: 0x060016E4 RID: 5860 RVA: 0x0005440C File Offset: 0x0005260C
		private void OnChildSourceChanged(object sender, global::System.Windows.SourceChangedEventArgs e)
		{
			this.RemoveChildHook(e.OldSource);
			this._childSource = e.NewSource;
			this.InitializeChildSource(e.NewSource);
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00054432 File Offset: 0x00052632
		private static void OnOffsetChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Controls.PopupController)d).RefreshPopupLocation();
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x0005443F File Offset: 0x0005263F
		private void OnOwnerSourceChanged(object sender, global::System.Windows.SourceChangedEventArgs e)
		{
			this.RemoveOwnerHook(e.OldSource);
			this._ownerSource = e.NewSource;
			this.AddOwnerHook(this._ownerSource);
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00054468 File Offset: 0x00052668
		private void OnPopupClosed(object sender, global::System.EventArgs e)
		{
			this._popup.Closed -= this.OnPopupClosed;
			if (!this._isDeactivated)
			{
				this._popup.Opened += this.OnPopupOpened;
			}
			this.RemoveChildHook(this._childSource);
			this.RemoveOwnerHook(this._ownerSource);
			this._ownerSource = null;
			this._childSource = null;
			global::System.Windows.PresentationSource.RemoveSourceChangedHandler(this._popup, new global::System.Windows.SourceChangedEventHandler(this.OnOwnerSourceChanged));
			global::System.Windows.PresentationSource.RemoveSourceChangedHandler(this._popup.Child, new global::System.Windows.SourceChangedEventHandler(this.OnChildSourceChanged));
			global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._boundPopupRoot) as global::System.Windows.FrameworkElement;
			this._boundPopupRoot = null;
			if (frameworkElement != null)
			{
				frameworkElement.ClearValue(global::System.Windows.FrameworkElement.WidthProperty);
				frameworkElement.ClearValue(global::System.Windows.FrameworkElement.MinWidthProperty);
				frameworkElement.ClearValue(global::System.Windows.FrameworkElement.MaxWidthProperty);
				frameworkElement.ClearValue(global::System.Windows.FrameworkElement.HeightProperty);
				frameworkElement.ClearValue(global::System.Windows.FrameworkElement.MinHeightProperty);
				frameworkElement.ClearValue(global::System.Windows.FrameworkElement.MaxHeightProperty);
			}
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00054564 File Offset: 0x00052764
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
			if (this._childSource != null && this.BindPopupRootExtents)
			{
				global::System.Windows.FrameworkElement frameworkElement = this._childSource.RootVisual as global::System.Windows.FrameworkElement;
				this._boundPopupRoot = ((frameworkElement != null) ? new global::System.WeakReference(frameworkElement) : null);
				if (frameworkElement != null)
				{
					frameworkElement.SetBinding(global::System.Windows.FrameworkElement.WidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.WidthProperty, global::System.Windows.Data.BindingMode.OneWay, this._popup));
					frameworkElement.SetBinding(global::System.Windows.FrameworkElement.MinWidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.MinWidthProperty, global::System.Windows.Data.BindingMode.OneWay, this._popup));
					frameworkElement.SetBinding(global::System.Windows.FrameworkElement.MaxWidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.MaxWidthProperty, global::System.Windows.Data.BindingMode.OneWay, this._popup));
					frameworkElement.SetBinding(global::System.Windows.FrameworkElement.HeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.HeightProperty, global::System.Windows.Data.BindingMode.OneWay, this._popup));
					frameworkElement.SetBinding(global::System.Windows.FrameworkElement.MinHeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.MinHeightProperty, global::System.Windows.Data.BindingMode.OneWay, this._popup));
					frameworkElement.SetBinding(global::System.Windows.FrameworkElement.MaxHeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.MaxHeightProperty, global::System.Windows.Data.BindingMode.OneWay, this._popup));
				}
			}
			this.RefreshPopupLocation();
			this.BringToFront(this._childSource);
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x00054720 File Offset: 0x00052920
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

		// Token: 0x060016EA RID: 5866 RVA: 0x00054790 File Offset: 0x00052990
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

		// Token: 0x060016EB RID: 5867 RVA: 0x00054830 File Offset: 0x00052A30
		private void RemoveChildHook(global::System.Windows.PresentationSource oldSource)
		{
			global::System.Windows.Interop.HwndSource hwndSource = oldSource as global::System.Windows.Interop.HwndSource;
			if (hwndSource != null)
			{
				hwndSource.RemoveHook(new global::System.Windows.Interop.HwndSourceHook(this.ChildHookProc));
			}
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x0005485C File Offset: 0x00052A5C
		private void RemoveOwnerHook(global::System.Windows.PresentationSource oldSource)
		{
			global::System.Windows.Interop.HwndSource hwndSource = oldSource as global::System.Windows.Interop.HwndSource;
			if (hwndSource != null)
			{
				hwndSource.RemoveHook(new global::System.Windows.Interop.HwndSourceHook(this.OwnerHookProc));
			}
		}

		// Token: 0x04000BD4 RID: 3028
		private global::System.Windows.FrameworkElement _owner;

		// Token: 0x04000BD5 RID: 3029
		private global::System.Windows.PresentationSource _ownerSource;

		// Token: 0x04000BD6 RID: 3030
		private global::System.Windows.PresentationSource _childSource;

		// Token: 0x04000BD7 RID: 3031
		private global::System.Windows.Controls.Primitives.Popup _popup;

		// Token: 0x04000BD8 RID: 3032
		private bool? _topMost;

		// Token: 0x04000BD9 RID: 3033
		private bool _isDeactivated;

		// Token: 0x04000BDA RID: 3034
		private global::System.WeakReference _boundPopupRoot;

		// Token: 0x04000BDB RID: 3035
		private static bool _controllerCreateFailed;

		// Token: 0x04000BDC RID: 3036
		private static readonly global::System.Windows.DependencyProperty HorizontalOffsetProperty = global::System.Windows.DependencyProperty.Register("HorizontalOffset", typeof(double), typeof(global::Infragistics.Windows.Controls.PopupController), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.PopupController.OnOffsetChanged)));

		// Token: 0x04000BDD RID: 3037
		private static readonly global::System.Windows.DependencyProperty VerticalOffsetProperty = global::System.Windows.DependencyProperty.Register("VerticalOffset", typeof(double), typeof(global::Infragistics.Windows.Controls.PopupController), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.PopupController.OnOffsetChanged)));
	}
}
