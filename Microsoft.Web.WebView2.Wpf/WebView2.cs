using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Effects;
using Microsoft.Web.WebView2.Core;

namespace Microsoft.Web.WebView2.Wpf
{
	// Token: 0x02000003 RID: 3
	[global::System.ComponentModel.ToolboxItem(true)]
	public class WebView2 : global::System.Windows.Interop.HwndHost
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000021BB File Offset: 0x000003BB
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000021CD File Offset: 0x000003CD
		[global::System.ComponentModel.Category("Common")]
		public global::Microsoft.Web.WebView2.Wpf.CoreWebView2CreationProperties CreationProperties
		{
			get
			{
				return (global::Microsoft.Web.WebView2.Wpf.CoreWebView2CreationProperties)base.GetValue(global::Microsoft.Web.WebView2.Wpf.WebView2.CreationPropertiesProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Web.WebView2.Wpf.WebView2.CreationPropertiesProperty, value);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021DB File Offset: 0x000003DB
		private static object CoerceCreationPropertiesProperty(global::System.Windows.DependencyObject d, object value)
		{
			if (((global::Microsoft.Web.WebView2.Wpf.WebView2)d).Environment != null)
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			return value;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000021F1 File Offset: 0x000003F1
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000021F9 File Offset: 0x000003F9
		private global::Microsoft.Web.WebView2.Core.CoreWebView2Environment Environment { get; set; }

		// Token: 0x06000011 RID: 17 RVA: 0x00002204 File Offset: 0x00000404
		protected override global::System.Runtime.InteropServices.HandleRef BuildWindowCore(global::System.Runtime.InteropServices.HandleRef hwndParent)
		{
			global::System.IntPtr intPtr = global::Microsoft.Web.WebView2.Wpf.WebView2.NativeMethods.CreateWindowExW(global::Microsoft.Web.WebView2.Wpf.WebView2.NativeMethods.WS_EX.TRANSPARENT, "static", string.Empty, global::Microsoft.Web.WebView2.Wpf.WebView2.NativeMethods.WS.CLIPCHILDREN | global::Microsoft.Web.WebView2.Wpf.WebView2.NativeMethods.WS.VISIBLE | global::Microsoft.Web.WebView2.Wpf.WebView2.NativeMethods.WS.CHILD, 0, 0, 0, 0, hwndParent.Handle, global::System.IntPtr.Zero, global::System.Runtime.InteropServices.Marshal.GetHINSTANCE(typeof(global::Microsoft.Web.WebView2.Wpf.WebView2.NativeMethods).Module), global::System.IntPtr.Zero);
			if (this.CoreWebView2Controller != null)
			{
				this.ReparentController(intPtr, true);
			}
			if (!this._hwndTaskSource.Task.IsCompleted)
			{
				this._hwndTaskSource.SetResult(intPtr);
			}
			return new global::System.Runtime.InteropServices.HandleRef(null, intPtr);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002286 File Offset: 0x00000486
		protected override void DestroyWindowCore(global::System.Runtime.InteropServices.HandleRef hwnd)
		{
			if (this.CoreWebView2Controller != null)
			{
				this.ReparentController(global::System.IntPtr.Zero, true);
			}
			global::Microsoft.Web.WebView2.Wpf.WebView2.NativeMethods.DestroyWindow(hwnd.Handle);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000022AC File Offset: 0x000004AC
		protected override global::System.IntPtr WndProc(global::System.IntPtr hwnd, int msg, global::System.IntPtr wParam, global::System.IntPtr lParam, ref bool handled)
		{
			if (msg != 7)
			{
				if (msg == 15)
				{
					if (!this.IsInDesignMode)
					{
						global::Microsoft.Web.WebView2.Wpf.WebView2.NativeMethods.PaintStruct paintStruct;
						global::Microsoft.Web.WebView2.Wpf.WebView2.NativeMethods.BeginPaint(hwnd, out paintStruct);
						global::Microsoft.Web.WebView2.Wpf.WebView2.NativeMethods.EndPaint(hwnd, ref paintStruct);
						handled = true;
						return global::System.IntPtr.Zero;
					}
				}
			}
			else
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2Controller coreWebView2Controller = this.CoreWebView2Controller;
				if (coreWebView2Controller != null)
				{
					coreWebView2Controller.MoveFocus(global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Programmatic);
				}
			}
			return base.WndProc(hwnd, msg, wParam, lParam, ref handled);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000230C File Offset: 0x0000050C
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			if (!this.IsInDesignMode)
			{
				base.OnRender(dc);
				return;
			}
			global::System.Windows.Media.SolidColorBrush brush = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Color.FromArgb(this.DefaultBackgroundColor.A, this.DefaultBackgroundColor.R, this.DefaultBackgroundColor.G, this.DefaultBackgroundColor.B));
			global::System.Windows.Media.SolidColorBrush solidColorBrush = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Color.FromArgb(this.DesignModeForegroundColor.A, this.DesignModeForegroundColor.R, this.DesignModeForegroundColor.G, this.DesignModeForegroundColor.B));
			global::System.Windows.Media.Pen pen = new global::System.Windows.Media.Pen(solidColorBrush, 2.0);
			dc.DrawRectangle(brush, pen, new global::System.Windows.Rect(base.RenderSize));
			global::System.Windows.Media.Typeface typeface = new global::System.Windows.Media.Typeface("default");
			if (typeface == null && global::System.Windows.Media.Fonts.SystemTypefaces.Count > 0)
			{
				typeface = global::System.Windows.Media.Fonts.SystemTypefaces.GetEnumerator().Current;
			}
			global::System.Windows.Point origin = new global::System.Windows.Point(base.RenderSize.Width / 2.0, base.RenderSize.Height / 2.0);
			global::System.Windows.Media.FormattedText formattedText = new global::System.Windows.Media.FormattedText("WebView2", global::System.Globalization.CultureInfo.CurrentCulture, global::System.Windows.FlowDirection.LeftToRight, typeface, 20.0, solidColorBrush);
			origin = new global::System.Windows.Point(origin.X - formattedText.WidthIncludingTrailingWhitespace / 2.0, origin.Y - formattedText.Height / 2.0);
			dc.DrawText(formattedText, origin);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000249E File Offset: 0x0000069E
		// (set) Token: 0x06000016 RID: 22 RVA: 0x000024A6 File Offset: 0x000006A6
		private global::Microsoft.Web.WebView2.Core.CoreWebView2Controller CoreWebView2Controller { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000024AF File Offset: 0x000006AF
		[global::System.ComponentModel.Browsable(false)]
		public global::Microsoft.Web.WebView2.Core.CoreWebView2 CoreWebView2
		{
			get
			{
				base.VerifyAccess();
				this.VerifyNotDisposed();
				this.VerifyBrowserNotCrashed();
				global::Microsoft.Web.WebView2.Core.CoreWebView2Controller coreWebView2Controller = this.CoreWebView2Controller;
				if (coreWebView2Controller == null)
				{
					return null;
				}
				return coreWebView2Controller.CoreWebView2;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000024D4 File Offset: 0x000006D4
		private void VerifyCoreWebView2()
		{
			if (this.CoreWebView2 == null)
			{
				throw new global::System.InvalidOperationException("Attempted to use WebView2 functionality which requires its CoreWebView2 prior to the CoreWebView2 being initialized.  Call EnsureCoreWebView2Async or set the Source property first.");
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000019 RID: 25 RVA: 0x000024EC File Offset: 0x000006EC
		// (remove) Token: 0x0600001A RID: 26 RVA: 0x00002524 File Offset: 0x00000724
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs> CoreWebView2InitializationCompleted;

		// Token: 0x0600001B RID: 27 RVA: 0x0000255C File Offset: 0x0000075C
		public global::System.Threading.Tasks.Task EnsureCoreWebView2Async(global::Microsoft.Web.WebView2.Core.CoreWebView2Environment environment = null)
		{
			global::Microsoft.Web.WebView2.Wpf.WebView2.<>c__DisplayClass26_0 CS$<>8__locals1 = new global::Microsoft.Web.WebView2.Wpf.WebView2.<>c__DisplayClass26_0();
			CS$<>8__locals1.environment = environment;
			CS$<>8__locals1.<>4__this = this;
			if (this.IsInDesignMode)
			{
				return global::System.Threading.Tasks.Task.FromResult<int>(0);
			}
			base.VerifyAccess();
			this.VerifyNotDisposed();
			this.VerifyBrowserNotCrashed();
			if (this._initTask == null)
			{
				this._initTask = CS$<>8__locals1.<EnsureCoreWebView2Async>g__Init|0();
			}
			return this._initTask;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000025B8 File Offset: 0x000007B8
		protected override void Dispose(bool disposing)
		{
			if (this._disposed)
			{
				return;
			}
			this.Uninitialize(false);
			base.Dispose(disposing);
			this._disposed = true;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000025D8 File Offset: 0x000007D8
		private void VerifyNotDisposed()
		{
			if (this._disposed)
			{
				throw new global::System.ObjectDisposedException(base.Name);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000025F0 File Offset: 0x000007F0
		private void Uninitialize(bool browserCrashed = false)
		{
			this._browserCrashed = browserCrashed;
			if (this.CoreWebView2Controller != null)
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2Controller coreWebView2Controller = this.CoreWebView2Controller;
				this.CoreWebView2Controller = null;
				base.IsVisibleChanged -= this.UIElement_IsVisibleChanged;
				if (!this._browserCrashed)
				{
					coreWebView2Controller.CoreWebView2.ContentLoading -= this.CoreWebView2_ContentLoading;
					coreWebView2Controller.CoreWebView2.HistoryChanged -= this.CoreWebView2_HistoryChanged;
					coreWebView2Controller.CoreWebView2.NavigationCompleted -= this.CoreWebView2_NavigationCompleted;
					coreWebView2Controller.CoreWebView2.NavigationStarting -= this.CoreWebView2_NavigationStarting;
					coreWebView2Controller.CoreWebView2.ProcessFailed -= this.CoreWebView2_ProcessFailed;
					coreWebView2Controller.CoreWebView2.SourceChanged -= this.CoreWebView2_SourceChanged;
					coreWebView2Controller.CoreWebView2.WebMessageReceived -= this.CoreWebView2_WebMessageReceived;
					coreWebView2Controller.AcceleratorKeyPressed -= this.CoreWebView2Controller_AcceleratorKeyPressed;
					coreWebView2Controller.GotFocus -= this.CoreWebView2Controller_GotFocus;
					coreWebView2Controller.LostFocus -= this.CoreWebView2Controller_LostFocus;
					coreWebView2Controller.MoveFocusRequested -= this.CoreWebView2Controller_MoveFocusRequested;
					coreWebView2Controller.ZoomFactorChanged -= this.CoreWebView2Controller_ZoomFactorChanged;
					coreWebView2Controller.Close();
				}
			}
			this.Environment = null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002744 File Offset: 0x00000944
		private void CoreWebView2_ProcessFailed(object sender, global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs e)
		{
			if (e.ProcessFailedKind == global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedKind.BrowserProcessExited)
			{
				this.Uninitialize(true);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002755 File Offset: 0x00000955
		private void VerifyBrowserNotCrashed()
		{
			if (this._browserCrashed)
			{
				throw new global::System.InvalidOperationException("The WebView control is no longer valid because the browser process crashed.To work around this, please listen for the CoreWebView2.ProcessFailed event to explicitly manage the lifetime of the WebView2 control in the event of a browser failure.https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2.processfailed");
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000276A File Offset: 0x0000096A
		public override void BeginInit()
		{
			base.BeginInit();
			this._inInit = true;
			this._initAction_Source = null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002780 File Offset: 0x00000980
		public override void EndInit()
		{
			this._inInit = false;
			global::System.Action initAction_Source = this._initAction_Source;
			if (initAction_Source != null)
			{
				initAction_Source();
			}
			this._initAction_Source = null;
			base.EndInit();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000027A7 File Offset: 0x000009A7
		private void WhenInit_Source(global::System.Action action)
		{
			if (this._inInit)
			{
				this._initAction_Source = action;
				return;
			}
			action();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000027BF File Offset: 0x000009BF
		private void SetCurrentValueFromCore(global::System.Windows.DependencyProperty property, object value)
		{
			global::System.Diagnostics.Trace.Assert(this._propertyChangingFromCore == null);
			this._propertyChangingFromCore = property;
			base.SetCurrentValue(property, value);
			this._propertyChangingFromCore = null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000027E5 File Offset: 0x000009E5
		private bool IsPropertyChangingFromCore(global::System.Windows.DependencyProperty property)
		{
			if (property == null)
			{
				throw new global::System.ArgumentNullException("property");
			}
			return property == this._propertyChangingFromCore;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002800 File Offset: 0x00000A00
		private void ReparentController(global::System.IntPtr hwnd, bool sync = true)
		{
			if (hwnd == global::System.IntPtr.Zero)
			{
				this.CoreWebView2Controller.IsVisible = false;
				this.CoreWebView2Controller.ParentWindow = global::System.IntPtr.Zero;
				return;
			}
			this.CoreWebView2Controller.ParentWindow = hwnd;
			if (sync)
			{
				this.SyncControllerWithParentWindow();
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000284C File Offset: 0x00000A4C
		private void SyncControllerWithParentWindow()
		{
			base.UpdateWindowPos();
			if (global::System.Windows.Input.Keyboard.FocusedElement == this)
			{
				this.CoreWebView2Controller.MoveFocus(global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Programmatic);
			}
			this.CoreWebView2Controller.IsVisible = (base.Visibility == global::System.Windows.Visibility.Visible);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000287C File Offset: 0x00000A7C
		private void UIElement_IsVisibleChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (this.CoreWebView2Controller != null)
			{
				this.CoreWebView2Controller.IsVisible = (bool)e.NewValue;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000028A0 File Offset: 0x00000AA0
		protected override void OnWindowPositionChanged(global::System.Windows.Rect rcBoundingBox)
		{
			base.OnWindowPositionChanged(rcBoundingBox);
			if (this.CoreWebView2 != null)
			{
				this.CoreWebView2Controller.Bounds = new global::System.Drawing.Rectangle(0, 0, global::System.Convert.ToInt32(rcBoundingBox.Size.Width), global::System.Convert.ToInt32(rcBoundingBox.Size.Height));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000028F6 File Offset: 0x00000AF6
		// (set) Token: 0x0600002B RID: 43 RVA: 0x00002908 File Offset: 0x00000B08
		[global::System.ComponentModel.Category("Common")]
		public global::System.Uri Source
		{
			get
			{
				return (global::System.Uri)base.GetValue(global::Microsoft.Web.WebView2.Wpf.WebView2.SourceProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Web.WebView2.Wpf.WebView2.SourceProperty, value);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002918 File Offset: 0x00000B18
		private static bool SourcePropertyValid(object val)
		{
			global::System.Uri uri = (global::System.Uri)val;
			return uri == null || uri.IsAbsoluteUri;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002940 File Offset: 0x00000B40
		private static void SourcePropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Web.WebView2.Wpf.WebView2 control = (global::Microsoft.Web.WebView2.Wpf.WebView2)d;
			if (control.IsPropertyChangingFromCore(global::Microsoft.Web.WebView2.Wpf.WebView2.SourceProperty))
			{
				return;
			}
			global::System.Uri uri = (global::System.Uri)e.OldValue;
			global::System.Uri uri2 = (global::System.Uri)e.NewValue;
			if (uri2 == null)
			{
				throw new global::System.NotImplementedException("The Source property cannot be set to null.");
			}
			if (control.CoreWebView2 != null && (uri == null || uri.AbsoluteUri != uri2.AbsoluteUri))
			{
				control.CoreWebView2.Navigate(uri2.AbsoluteUri);
			}
			control.WhenInit_Source(delegate
			{
				control.EnsureCoreWebView2Async(null);
			});
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600002E RID: 46 RVA: 0x000029F8 File Offset: 0x00000BF8
		// (remove) Token: 0x0600002F RID: 47 RVA: 0x00002A30 File Offset: 0x00000C30
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs> SourceChanged;

		// Token: 0x06000030 RID: 48 RVA: 0x00002A65 File Offset: 0x00000C65
		private void CoreWebView2_SourceChanged(object sender, global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
		{
			this.SetCurrentValueFromCore(global::Microsoft.Web.WebView2.Wpf.WebView2.SourceProperty, new global::System.Uri(this.CoreWebView2.Source));
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs> sourceChanged = this.SourceChanged;
			if (sourceChanged == null)
			{
				return;
			}
			sourceChanged(this, e);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000031 RID: 49 RVA: 0x00002A94 File Offset: 0x00000C94
		// (remove) Token: 0x06000032 RID: 50 RVA: 0x00002ACC File Offset: 0x00000CCC
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs> NavigationStarting;

		// Token: 0x06000033 RID: 51 RVA: 0x00002B01 File Offset: 0x00000D01
		private void CoreWebView2_NavigationStarting(object sender, global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs> navigationStarting = this.NavigationStarting;
			if (navigationStarting == null)
			{
				return;
			}
			navigationStarting(this, e);
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000034 RID: 52 RVA: 0x00002B18 File Offset: 0x00000D18
		// (remove) Token: 0x06000035 RID: 53 RVA: 0x00002B50 File Offset: 0x00000D50
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs> NavigationCompleted;

		// Token: 0x06000036 RID: 54 RVA: 0x00002B85 File Offset: 0x00000D85
		private void CoreWebView2_NavigationCompleted(object sender, global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs> navigationCompleted = this.NavigationCompleted;
			if (navigationCompleted == null)
			{
				return;
			}
			navigationCompleted(this, e);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002B99 File Offset: 0x00000D99
		private void CoreWebView2_HistoryChanged(object sender, object e)
		{
			base.SetValue(global::Microsoft.Web.WebView2.Wpf.WebView2.CanGoBackPropertyKey, this.CoreWebView2.CanGoBack);
			base.SetValue(global::Microsoft.Web.WebView2.Wpf.WebView2.CanGoForwardPropertyKey, this.CoreWebView2.CanGoForward);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002BD1 File Offset: 0x00000DD1
		[global::System.ComponentModel.Browsable(false)]
		public bool CanGoBack
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Web.WebView2.Wpf.WebView2.CanGoBackProperty);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002BE3 File Offset: 0x00000DE3
		[global::System.ComponentModel.Browsable(false)]
		public bool CanGoForward
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Web.WebView2.Wpf.WebView2.CanGoForwardProperty);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002BF8 File Offset: 0x00000DF8
		protected override bool TabIntoCore(global::System.Windows.Input.TraversalRequest request)
		{
			if (this.CoreWebView2 == null)
			{
				return base.TabIntoCore(request);
			}
			switch (request.FocusNavigationDirection)
			{
			case global::System.Windows.Input.FocusNavigationDirection.Next:
			case global::System.Windows.Input.FocusNavigationDirection.First:
				this.CoreWebView2Controller.MoveFocus(global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Next);
				return true;
			case global::System.Windows.Input.FocusNavigationDirection.Previous:
			case global::System.Windows.Input.FocusNavigationDirection.Last:
				this.CoreWebView2Controller.MoveFocus(global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Previous);
				return true;
			default:
				return base.TabIntoCore(request);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002C57 File Offset: 0x00000E57
		protected override void OnGotKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			base.OnGotKeyboardFocus(e);
			global::Microsoft.Web.WebView2.Core.CoreWebView2Controller coreWebView2Controller = this.CoreWebView2Controller;
			if (coreWebView2Controller == null)
			{
				return;
			}
			coreWebView2Controller.MoveFocus(global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Programmatic);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002C74 File Offset: 0x00000E74
		private void CoreWebView2Controller_MoveFocusRequested(object sender, global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusRequestedEventArgs e)
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason reason = e.Reason;
			if (reason > global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Next)
			{
				if (reason == global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Previous)
				{
					this.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.Previous));
				}
			}
			else
			{
				this.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.Next));
			}
			e.Handled = true;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002CB5 File Offset: 0x00000EB5
		private void CoreWebView2Controller_GotFocus(object sender, object e)
		{
			base.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::System.Windows.UIElement.GotFocusEvent));
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002CC7 File Offset: 0x00000EC7
		private void CoreWebView2Controller_LostFocus(object sender, object e)
		{
			base.RaiseEvent(new global::System.Windows.RoutedEventArgs(global::System.Windows.UIElement.LostFocusEvent));
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002CDC File Offset: 0x00000EDC
		private void CoreWebView2Controller_AcceleratorKeyPressed(object sender, global::Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs e)
		{
			global::Microsoft.Web.WebView2.Wpf.WebView2.WebView2KeyEventArgs webView2KeyEventArgs = new global::Microsoft.Web.WebView2.Wpf.WebView2.WebView2KeyEventArgs(global::System.Windows.Input.Keyboard.PrimaryDevice, global::System.Windows.PresentationSource.FromDependencyObject(this), global::System.Environment.TickCount, global::System.Windows.Input.KeyInterop.KeyFromVirtualKey((int)e.VirtualKey))
			{
				RoutedEvent = ((e.KeyEventKind == global::Microsoft.Web.WebView2.Core.CoreWebView2KeyEventKind.KeyDown || e.KeyEventKind == global::Microsoft.Web.WebView2.Core.CoreWebView2KeyEventKind.SystemKeyDown) ? global::System.Windows.UIElement.PreviewKeyDownEvent : global::System.Windows.UIElement.PreviewKeyUpEvent)
			};
			base.RaiseEvent(webView2KeyEventArgs);
			e.Handled = webView2KeyEventArgs.Handled;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002D40 File Offset: 0x00000F40
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyDown(e);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002D49 File Offset: 0x00000F49
		protected override void OnKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyUp(e);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002D52 File Offset: 0x00000F52
		protected override void OnPreviewKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnPreviewKeyDown(e);
			if (e is global::Microsoft.Web.WebView2.Wpf.WebView2.WebView2KeyEventArgs)
			{
				e.RoutedEvent = global::System.Windows.UIElement.KeyDownEvent;
				base.RaiseEvent(e);
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002D75 File Offset: 0x00000F75
		protected override void OnPreviewKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnPreviewKeyUp(e);
			if (e is global::Microsoft.Web.WebView2.Wpf.WebView2.WebView2KeyEventArgs)
			{
				e.RoutedEvent = global::System.Windows.UIElement.KeyUpEvent;
				base.RaiseEvent(e);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002D98 File Offset: 0x00000F98
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002DAA File Offset: 0x00000FAA
		[global::System.ComponentModel.Category("Common")]
		public double ZoomFactor
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Web.WebView2.Wpf.WebView2.ZoomFactorProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Web.WebView2.Wpf.WebView2.ZoomFactorProperty, value);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002DC0 File Offset: 0x00000FC0
		private static void ZoomFactorPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Web.WebView2.Wpf.WebView2 webView = (global::Microsoft.Web.WebView2.Wpf.WebView2)d;
			if (webView.CoreWebView2 != null && !webView.IsPropertyChangingFromCore(global::Microsoft.Web.WebView2.Wpf.WebView2.ZoomFactorProperty))
			{
				webView.CoreWebView2Controller.ZoomFactor = (double)e.NewValue;
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000047 RID: 71 RVA: 0x00002E00 File Offset: 0x00001000
		// (remove) Token: 0x06000048 RID: 72 RVA: 0x00002E38 File Offset: 0x00001038
		public event global::System.EventHandler<global::System.EventArgs> ZoomFactorChanged;

		// Token: 0x06000049 RID: 73 RVA: 0x00002E6D File Offset: 0x0000106D
		private void CoreWebView2Controller_ZoomFactorChanged(object sender, object e)
		{
			this.SetCurrentValueFromCore(global::Microsoft.Web.WebView2.Wpf.WebView2.ZoomFactorProperty, this.CoreWebView2Controller.ZoomFactor);
			global::System.EventHandler<global::System.EventArgs> zoomFactorChanged = this.ZoomFactorChanged;
			if (zoomFactorChanged == null)
			{
				return;
			}
			zoomFactorChanged(this, global::System.EventArgs.Empty);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002EA0 File Offset: 0x000010A0
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002EB2 File Offset: 0x000010B2
		[global::System.ComponentModel.Category("Common")]
		public global::System.Drawing.Color DefaultBackgroundColor
		{
			get
			{
				return (global::System.Drawing.Color)base.GetValue(global::Microsoft.Web.WebView2.Wpf.WebView2.DefaultBackgroundColorProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Web.WebView2.Wpf.WebView2.DefaultBackgroundColorProperty, value);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002EC8 File Offset: 0x000010C8
		private static void DefaultBackgroundColorPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Web.WebView2.Wpf.WebView2 webView = (global::Microsoft.Web.WebView2.Wpf.WebView2)d;
			if (webView.CoreWebView2Controller != null)
			{
				webView.CoreWebView2Controller.DefaultBackgroundColor = (global::System.Drawing.Color)e.NewValue;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002EFB File Offset: 0x000010FB
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00002F0D File Offset: 0x0000110D
		[global::System.ComponentModel.Category("Common")]
		public global::System.Drawing.Color DesignModeForegroundColor
		{
			get
			{
				return (global::System.Drawing.Color)base.GetValue(global::Microsoft.Web.WebView2.Wpf.WebView2.DesignModeForegroundColorProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Web.WebView2.Wpf.WebView2.DesignModeForegroundColorProperty, value);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002F20 File Offset: 0x00001120
		public void GoBack()
		{
			if (this.CoreWebView2 != null)
			{
				this.CoreWebView2.GoBack();
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002F35 File Offset: 0x00001135
		public void GoForward()
		{
			if (this.CoreWebView2 != null)
			{
				this.CoreWebView2.GoForward();
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002F4A File Offset: 0x0000114A
		public void Reload()
		{
			this.VerifyCoreWebView2();
			this.CoreWebView2.Reload();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002F5D File Offset: 0x0000115D
		public void Stop()
		{
			this.VerifyCoreWebView2();
			this.CoreWebView2.Stop();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002F70 File Offset: 0x00001170
		public void NavigateToString(string htmlContent)
		{
			this.VerifyCoreWebView2();
			this.CoreWebView2.NavigateToString(htmlContent);
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000054 RID: 84 RVA: 0x00002F84 File Offset: 0x00001184
		// (remove) Token: 0x06000055 RID: 85 RVA: 0x00002FBC File Offset: 0x000011BC
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs> ContentLoading;

		// Token: 0x06000056 RID: 86 RVA: 0x00002FF1 File Offset: 0x000011F1
		private void CoreWebView2_ContentLoading(object sender, global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs e)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs> contentLoading = this.ContentLoading;
			if (contentLoading == null)
			{
				return;
			}
			contentLoading(this, e);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003008 File Offset: 0x00001208
		public global::System.Threading.Tasks.Task<string> ExecuteScriptAsync(string javaScript)
		{
			global::Microsoft.Web.WebView2.Wpf.WebView2.<ExecuteScriptAsync>d__110 <ExecuteScriptAsync>d__;
			<ExecuteScriptAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string>.Create();
			<ExecuteScriptAsync>d__.<>4__this = this;
			<ExecuteScriptAsync>d__.javaScript = javaScript;
			<ExecuteScriptAsync>d__.<>1__state = -1;
			<ExecuteScriptAsync>d__.<>t__builder.Start<global::Microsoft.Web.WebView2.Wpf.WebView2.<ExecuteScriptAsync>d__110>(ref <ExecuteScriptAsync>d__);
			return <ExecuteScriptAsync>d__.<>t__builder.Task;
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000058 RID: 88 RVA: 0x00003054 File Offset: 0x00001254
		// (remove) Token: 0x06000059 RID: 89 RVA: 0x0000308C File Offset: 0x0000128C
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs> WebMessageReceived;

		// Token: 0x0600005A RID: 90 RVA: 0x000030C1 File Offset: 0x000012C1
		private void CoreWebView2_WebMessageReceived(object sender, global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs> webMessageReceived = this.WebMessageReceived;
			if (webMessageReceived == null)
			{
				return;
			}
			webMessageReceived(this, e);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000030D5 File Offset: 0x000012D5
		protected bool IsInDesignMode
		{
			get
			{
				return global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000030DD File Offset: 0x000012DD
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Windows.Media.Brush OpacityMask
		{
			get
			{
				return base.OpacityMask;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000030E5 File Offset: 0x000012E5
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new double Opacity
		{
			get
			{
				return base.Opacity;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000030ED File Offset: 0x000012ED
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Windows.Media.Effects.Effect Effect
		{
			get
			{
				return base.Effect;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000030F5 File Offset: 0x000012F5
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Windows.Controls.ContextMenu ContextMenu
		{
			get
			{
				return base.ContextMenu;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000030FD File Offset: 0x000012FD
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Windows.Style FocusVisualStyle
		{
			get
			{
				return base.FocusVisualStyle;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00003105 File Offset: 0x00001305
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Windows.Input.InputScope InputScope
		{
			get
			{
				return base.InputScope;
			}
		}

		// Token: 0x04000005 RID: 5
		public static readonly global::System.Windows.DependencyProperty CreationPropertiesProperty = global::System.Windows.DependencyProperty.Register("CreationProperties", typeof(global::Microsoft.Web.WebView2.Wpf.CoreWebView2CreationProperties), typeof(global::Microsoft.Web.WebView2.Wpf.WebView2), new global::System.Windows.PropertyMetadata(null, null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Web.WebView2.Wpf.WebView2.CoerceCreationPropertiesProperty)));

		// Token: 0x04000007 RID: 7
		private global::System.Threading.Tasks.TaskCompletionSource<global::System.IntPtr> _hwndTaskSource = new global::System.Threading.Tasks.TaskCompletionSource<global::System.IntPtr>();

		// Token: 0x0400000A RID: 10
		private global::System.Threading.Tasks.Task _initTask;

		// Token: 0x0400000B RID: 11
		private bool _disposed;

		// Token: 0x0400000C RID: 12
		private bool _browserCrashed;

		// Token: 0x0400000D RID: 13
		private bool _inInit;

		// Token: 0x0400000E RID: 14
		private global::System.Action _initAction_Source;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.DependencyProperty _propertyChangingFromCore;

		// Token: 0x04000010 RID: 16
		public static readonly global::System.Windows.DependencyProperty SourceProperty = global::System.Windows.DependencyProperty.Register("Source", typeof(global::System.Uri), typeof(global::Microsoft.Web.WebView2.Wpf.WebView2), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Web.WebView2.Wpf.WebView2.SourcePropertyChanged), null), new global::System.Windows.ValidateValueCallback(global::Microsoft.Web.WebView2.Wpf.WebView2.SourcePropertyValid));

		// Token: 0x04000014 RID: 20
		private static readonly global::System.Windows.DependencyPropertyKey CanGoBackPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CanGoBack", typeof(bool), typeof(global::Microsoft.Web.WebView2.Wpf.WebView2), new global::System.Windows.PropertyMetadata(false));

		// Token: 0x04000015 RID: 21
		public static readonly global::System.Windows.DependencyProperty CanGoBackProperty = global::Microsoft.Web.WebView2.Wpf.WebView2.CanGoBackPropertyKey.DependencyProperty;

		// Token: 0x04000016 RID: 22
		private static readonly global::System.Windows.DependencyPropertyKey CanGoForwardPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CanGoForward", typeof(bool), typeof(global::Microsoft.Web.WebView2.Wpf.WebView2), new global::System.Windows.PropertyMetadata(false));

		// Token: 0x04000017 RID: 23
		public static readonly global::System.Windows.DependencyProperty CanGoForwardProperty = global::Microsoft.Web.WebView2.Wpf.WebView2.CanGoForwardPropertyKey.DependencyProperty;

		// Token: 0x04000018 RID: 24
		public static readonly global::System.Windows.DependencyProperty ZoomFactorProperty = global::System.Windows.DependencyProperty.Register("ZoomFactor", typeof(double), typeof(global::Microsoft.Web.WebView2.Wpf.WebView2), new global::System.Windows.PropertyMetadata(1.0, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Web.WebView2.Wpf.WebView2.ZoomFactorPropertyChanged), null));

		// Token: 0x0400001A RID: 26
		public static readonly global::System.Windows.DependencyProperty DefaultBackgroundColorProperty = global::System.Windows.DependencyProperty.Register("DefaultBackgroundColor", typeof(global::System.Drawing.Color), typeof(global::Microsoft.Web.WebView2.Wpf.WebView2), new global::System.Windows.PropertyMetadata(global::System.Drawing.Color.White, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Web.WebView2.Wpf.WebView2.DefaultBackgroundColorPropertyChanged), null));

		// Token: 0x0400001B RID: 27
		public static readonly global::System.Windows.DependencyProperty DesignModeForegroundColorProperty = global::System.Windows.DependencyProperty.Register("DesignModeForegroundColor", typeof(global::System.Drawing.Color), typeof(global::Microsoft.Web.WebView2.Wpf.WebView2), new global::System.Windows.PropertyMetadata(global::System.Drawing.Color.Black));

		// Token: 0x02000004 RID: 4
		private class WebView2KeyEventArgs : global::System.Windows.Input.KeyEventArgs
		{
			// Token: 0x06000063 RID: 99 RVA: 0x000032C3 File Offset: 0x000014C3
			public WebView2KeyEventArgs(global::System.Windows.Input.KeyboardDevice keyboard, global::System.Windows.PresentationSource inputSource, int timestamp, global::System.Windows.Input.Key key) : base(keyboard, inputSource, timestamp, key)
			{
			}
		}

		// Token: 0x02000005 RID: 5
		private static class NativeMethods
		{
			// Token: 0x06000064 RID: 100
			[global::System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
			public static extern global::System.IntPtr BeginPaint(global::System.IntPtr hwnd, out global::Microsoft.Web.WebView2.Wpf.WebView2.NativeMethods.PaintStruct lpPaint);

			// Token: 0x06000065 RID: 101
			[global::System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
			public static extern bool EndPaint(global::System.IntPtr hwnd, ref global::Microsoft.Web.WebView2.Wpf.WebView2.NativeMethods.PaintStruct lpPaint);

			// Token: 0x06000066 RID: 102
			[global::System.Runtime.InteropServices.DllImport("user32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
			public static extern global::System.IntPtr CreateWindowExW(global::Microsoft.Web.WebView2.Wpf.WebView2.NativeMethods.WS_EX dwExStyle, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lpClassName, [global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lpWindowName, global::Microsoft.Web.WebView2.Wpf.WebView2.NativeMethods.WS dwStyle, int x, int y, int nWidth, int nHeight, global::System.IntPtr hWndParent, global::System.IntPtr hMenu, global::System.IntPtr hInstance, global::System.IntPtr lpParam);

			// Token: 0x06000067 RID: 103
			[global::System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
			[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
			public static extern bool DestroyWindow(global::System.IntPtr hwnd);

			// Token: 0x02000009 RID: 9
			[global::System.Flags]
			public enum WS : uint
			{
				// Token: 0x04000027 RID: 39
				None = 0U,
				// Token: 0x04000028 RID: 40
				CLIPCHILDREN = 33554432U,
				// Token: 0x04000029 RID: 41
				VISIBLE = 268435456U,
				// Token: 0x0400002A RID: 42
				CHILD = 1073741824U
			}

			// Token: 0x0200000A RID: 10
			[global::System.Flags]
			public enum WS_EX : uint
			{
				// Token: 0x0400002C RID: 44
				None = 0U,
				// Token: 0x0400002D RID: 45
				TRANSPARENT = 32U
			}

			// Token: 0x0200000B RID: 11
			public enum WM : uint
			{
				// Token: 0x0400002F RID: 47
				SETFOCUS = 7U,
				// Token: 0x04000030 RID: 48
				PAINT = 15U
			}

			// Token: 0x0200000C RID: 12
			public struct Rect
			{
				// Token: 0x04000031 RID: 49
				public int left;

				// Token: 0x04000032 RID: 50
				public int top;

				// Token: 0x04000033 RID: 51
				public int right;

				// Token: 0x04000034 RID: 52
				public int bottom;
			}

			// Token: 0x0200000D RID: 13
			public struct PaintStruct
			{
				// Token: 0x04000035 RID: 53
				public global::System.IntPtr hdc;

				// Token: 0x04000036 RID: 54
				public bool fErase;

				// Token: 0x04000037 RID: 55
				public global::Microsoft.Web.WebView2.Wpf.WebView2.NativeMethods.Rect rcPaint;

				// Token: 0x04000038 RID: 56
				public bool fRestore;

				// Token: 0x04000039 RID: 57
				public bool fIncUpdate;

				// Token: 0x0400003A RID: 58
				[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
				public byte[] rgbReserved;
			}
		}
	}
}
