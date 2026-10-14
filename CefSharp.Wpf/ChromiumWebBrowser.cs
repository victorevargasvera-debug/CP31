using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Threading;
using CefSharp.Core;
using CefSharp.Enums;
using CefSharp.Internals;
using CefSharp.Structs;
using CefSharp.Wpf.Experimental;
using CefSharp.Wpf.Experimental.Accessibility;
using CefSharp.Wpf.Handler;
using CefSharp.Wpf.Internals;
using CefSharp.Wpf.Rendering;
using Microsoft.Win32.SafeHandles;

namespace CefSharp.Wpf
{
	// Token: 0x02000003 RID: 3
	[global::System.Windows.TemplatePart(Name = "PART_image", Type = typeof(global::System.Windows.Controls.Image))]
	[global::System.Windows.TemplatePart(Name = "PART_popupImage", Type = typeof(global::System.Windows.Controls.Image))]
	public class ChromiumWebBrowser : global::System.Windows.Controls.Control, global::CefSharp.Internals.IRenderWebBrowser, global::CefSharp.Internals.IWebBrowserInternal, global::CefSharp.IWebBrowser, global::CefSharp.IChromiumWebBrowserBase, global::System.IDisposable, global::CefSharp.Wpf.IWpfWebBrowser, global::System.Windows.IInputElement
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x0000205F File Offset: 0x0000025F
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00002067 File Offset: 0x00000267
		public bool ResizeHackEnabled { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002070 File Offset: 0x00000270
		// (set) Token: 0x06000005 RID: 5 RVA: 0x00002078 File Offset: 0x00000278
		public int ResizeHackDelayInMs { get; set; } = 50;

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002081 File Offset: 0x00000281
		public bool IsDisposed
		{
			get
			{
				return global::System.Threading.Interlocked.CompareExchange(ref this.disposeSignaled, 1, 1) == 1;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002093 File Offset: 0x00000293
		// (set) Token: 0x06000008 RID: 8 RVA: 0x0000209B File Offset: 0x0000029B
		public global::CefSharp.Wpf.IWpfKeyboardHandler WpfKeyboardHandler { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020A4 File Offset: 0x000002A4
		// (set) Token: 0x0600000A RID: 10 RVA: 0x000020AC File Offset: 0x000002AC
		public global::CefSharp.IBrowserSettings BrowserSettings
		{
			get
			{
				return this.browserSettings;
			}
			set
			{
				if (this.browserCreated)
				{
					throw new global::System.Exception("Browser has already been created. BrowserSettings must be set before the underlying CEF browser is created.");
				}
				if (this.browserSettings != null && this.browserSettings.AutoDispose)
				{
					this.browserSettings.Dispose();
				}
				this.browserSettings = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020E8 File Offset: 0x000002E8
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000020F0 File Offset: 0x000002F0
		public global::CefSharp.IRequestContext RequestContext
		{
			get
			{
				return this.requestContext;
			}
			set
			{
				if (this.browserCreated)
				{
					throw new global::System.Exception("Browser has already been created. RequestContext must be set before the underlying CEF browser is created.");
				}
				if (value != null && !global::CefSharp.Core.ObjectFactory.RequestContextType.IsAssignableFrom(value.UnWrap().GetType()))
				{
					throw new global::System.Exception(string.Format("RequestContext can only be of type {0} or null", global::CefSharp.Core.ObjectFactory.RequestContextType));
				}
				this.requestContext = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002146 File Offset: 0x00000346
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000214E File Offset: 0x0000034E
		public global::CefSharp.Wpf.IRenderHandler RenderHandler { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002157 File Offset: 0x00000357
		// (set) Token: 0x06000010 RID: 16 RVA: 0x0000215F File Offset: 0x0000035F
		public global::CefSharp.IAccessibilityHandler AccessibilityHandler { get; set; }

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000011 RID: 17 RVA: 0x00002168 File Offset: 0x00000368
		// (remove) Token: 0x06000012 RID: 18 RVA: 0x000021A0 File Offset: 0x000003A0
		public event global::System.EventHandler<global::CefSharp.Wpf.PaintEventArgs> Paint;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000013 RID: 19 RVA: 0x000021D8 File Offset: 0x000003D8
		// (remove) Token: 0x06000014 RID: 20 RVA: 0x00002210 File Offset: 0x00000410
		public event global::System.EventHandler<global::CefSharp.Wpf.VirtualKeyboardRequestedEventArgs> VirtualKeyboardRequested;

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002245 File Offset: 0x00000445
		// (set) Token: 0x06000016 RID: 22 RVA: 0x0000224D File Offset: 0x0000044D
		public global::System.Windows.Input.ICommand BackCommand { get; private set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002256 File Offset: 0x00000456
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000225E File Offset: 0x0000045E
		public global::System.Windows.Input.ICommand ForwardCommand { get; private set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002267 File Offset: 0x00000467
		// (set) Token: 0x0600001A RID: 26 RVA: 0x0000226F File Offset: 0x0000046F
		public global::System.Windows.Input.ICommand ReloadCommand { get; private set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002278 File Offset: 0x00000478
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002280 File Offset: 0x00000480
		public global::System.Windows.Input.ICommand PrintCommand { get; private set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002289 File Offset: 0x00000489
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002291 File Offset: 0x00000491
		public global::System.Windows.Input.ICommand ZoomInCommand { get; private set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001F RID: 31 RVA: 0x0000229A File Offset: 0x0000049A
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000022A2 File Offset: 0x000004A2
		public global::System.Windows.Input.ICommand ZoomOutCommand { get; private set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000022AB File Offset: 0x000004AB
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000022B3 File Offset: 0x000004B3
		public global::System.Windows.Input.ICommand ZoomResetCommand { get; private set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000022BC File Offset: 0x000004BC
		// (set) Token: 0x06000024 RID: 36 RVA: 0x000022C4 File Offset: 0x000004C4
		public global::System.Windows.Input.ICommand ViewSourceCommand { get; private set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000022CD File Offset: 0x000004CD
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000022D5 File Offset: 0x000004D5
		public global::System.Windows.Input.ICommand CleanupCommand { get; private set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000022DE File Offset: 0x000004DE
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000022E6 File Offset: 0x000004E6
		public global::System.Windows.Input.ICommand StopCommand { get; private set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000022EF File Offset: 0x000004EF
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000022F7 File Offset: 0x000004F7
		public global::System.Windows.Input.ICommand CutCommand { get; private set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002300 File Offset: 0x00000500
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002308 File Offset: 0x00000508
		public global::System.Windows.Input.ICommand CopyCommand { get; private set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002311 File Offset: 0x00000511
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002319 File Offset: 0x00000519
		public global::System.Windows.Input.ICommand PasteCommand { get; private set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002322 File Offset: 0x00000522
		// (set) Token: 0x06000030 RID: 48 RVA: 0x0000232A File Offset: 0x0000052A
		public global::System.Windows.Input.ICommand SelectAllCommand { get; private set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002333 File Offset: 0x00000533
		// (set) Token: 0x06000032 RID: 50 RVA: 0x0000233B File Offset: 0x0000053B
		public global::System.Windows.Input.ICommand UndoCommand { get; private set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002344 File Offset: 0x00000544
		// (set) Token: 0x06000034 RID: 52 RVA: 0x0000234C File Offset: 0x0000054C
		public global::System.Windows.Input.ICommand RedoCommand { get; private set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002355 File Offset: 0x00000555
		// (set) Token: 0x06000036 RID: 54 RVA: 0x0000235D File Offset: 0x0000055D
		public global::System.Windows.Input.ICommand ToggleAudioMuteCommand { get; private set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002366 File Offset: 0x00000566
		// (set) Token: 0x06000038 RID: 56 RVA: 0x0000236E File Offset: 0x0000056E
		public float DpiScaleFactor { get; set; }

		// Token: 0x06000039 RID: 57 RVA: 0x00002378 File Offset: 0x00000578
		static ChromiumWebBrowser()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::CefSharp.Wpf.ChromiumWebBrowser), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::CefSharp.Wpf.ChromiumWebBrowser)));
			if (global::CefSharp.CefSharpSettings.ShutdownOnExit)
			{
				global::System.Windows.Threading.Dispatcher dispatcher = global::System.Windows.Threading.Dispatcher.FromThread(global::System.Threading.Thread.CurrentThread);
				if (dispatcher == null)
				{
					global::System.Windows.Application application = global::System.Windows.Application.Current;
					if (application != null)
					{
						application.Exit += global::CefSharp.Wpf.ChromiumWebBrowser.OnApplicationExit;
						return;
					}
				}
				else
				{
					dispatcher.ShutdownStarted += global::CefSharp.Wpf.ChromiumWebBrowser.DispatcherShutdownStarted;
					dispatcher.ShutdownFinished += global::CefSharp.Wpf.ChromiumWebBrowser.DispatcherShutdownFinished;
				}
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002620 File Offset: 0x00000820
		private static void DispatcherShutdownStarted(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Threading.Dispatcher dispatcher = (global::System.Windows.Threading.Dispatcher)sender;
			dispatcher.ShutdownStarted -= global::CefSharp.Wpf.ChromiumWebBrowser.DispatcherShutdownStarted;
			if (!global::CefSharp.Wpf.ChromiumWebBrowser.DesignMode)
			{
				global::CefSharp.Wpf.ChromiumWebBrowser.CefPreShutdown();
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002654 File Offset: 0x00000854
		private static void DispatcherShutdownFinished(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Threading.Dispatcher dispatcher = (global::System.Windows.Threading.Dispatcher)sender;
			dispatcher.ShutdownFinished -= global::CefSharp.Wpf.ChromiumWebBrowser.DispatcherShutdownFinished;
			if (!global::CefSharp.Wpf.ChromiumWebBrowser.DesignMode)
			{
				global::CefSharp.Wpf.ChromiumWebBrowser.CefShutdown();
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002686 File Offset: 0x00000886
		private static void OnApplicationExit(object sender, global::System.Windows.ExitEventArgs e)
		{
			if (!global::CefSharp.Wpf.ChromiumWebBrowser.DesignMode)
			{
				global::CefSharp.Wpf.ChromiumWebBrowser.CefShutdown();
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002694 File Offset: 0x00000894
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static void CefPreShutdown()
		{
			global::CefSharp.Cef.PreShutdown();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000269B File Offset: 0x0000089B
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static void CefShutdown()
		{
			global::CefSharp.Cef.Shutdown();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000026A4 File Offset: 0x000008A4
		public static void UnregisterShutdownHandler()
		{
			global::System.Windows.Threading.Dispatcher dispatcher = global::System.Windows.Threading.Dispatcher.FromThread(global::System.Threading.Thread.CurrentThread);
			if (dispatcher != null)
			{
				dispatcher.ShutdownStarted -= global::CefSharp.Wpf.ChromiumWebBrowser.DispatcherShutdownStarted;
				dispatcher.ShutdownFinished -= global::CefSharp.Wpf.ChromiumWebBrowser.DispatcherShutdownFinished;
			}
			global::System.Windows.Application application = global::System.Windows.Application.Current;
			if (application != null)
			{
				application.Exit -= global::CefSharp.Wpf.ChromiumWebBrowser.OnApplicationExit;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000026FE File Offset: 0x000008FE
		public ChromiumWebBrowser()
		{
			global::CefSharp.Wpf.ChromiumWebBrowser.DesignMode = global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this);
			if (!global::CefSharp.Wpf.ChromiumWebBrowser.DesignMode)
			{
				this.NoInliningConstructor();
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002731 File Offset: 0x00000931
		public ChromiumWebBrowser(global::System.Windows.Interop.HwndSource parentWindowHwndSource, string initialAddress, global::System.Windows.Size size) : this(initialAddress)
		{
			this.CreateBrowser(parentWindowHwndSource, size);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002743 File Offset: 0x00000943
		public ChromiumWebBrowser(string initialAddress)
		{
			this.initialAddress = initialAddress;
			this.NoInliningConstructor();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000276C File Offset: 0x0000096C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private void NoInliningConstructor()
		{
			if (!global::CefSharp.Cef.IsInitialized)
			{
				global::CefSharp.Wpf.CefSettings settings = new global::CefSharp.Wpf.CefSettings();
				if (!global::CefSharp.Cef.Initialize(settings))
				{
					throw new global::System.InvalidOperationException("Cef.Initialize() failed.Check the log file see https://github.com/cefsharp/CefSharp/wiki/Trouble-Shooting#log-file for details.");
				}
			}
			global::CefSharp.Cef.AddDisposable(this);
			base.Focusable = true;
			base.FocusVisualStyle = null;
			base.IsTabStop = true;
			base.Dispatcher.BeginInvoke(new global::System.Action(delegate()
			{
				this.WebBrowser = this;
			}), global::System.Array.Empty<object>());
			base.Loaded += this.OnLoaded;
			base.SizeChanged += this.OnActualSizeChanged;
			base.GotKeyboardFocus += this.OnGotKeyboardFocus;
			base.LostKeyboardFocus += this.OnLostKeyboardFocus;
			base.DragEnter += this.OnDragEnter;
			base.DragOver += this.OnDragOver;
			base.DragLeave += this.OnDragLeave;
			base.Drop += this.OnDrop;
			base.IsVisibleChanged += this.OnIsVisibleChanged;
			base.ToolTip = (this.toolTip = new global::System.Windows.Controls.ToolTip());
			this.toolTip.StaysOpen = true;
			this.toolTip.Visibility = global::System.Windows.Visibility.Collapsed;
			this.toolTip.Closed += this.OnTooltipClosed;
			this.BackCommand = new global::CefSharp.Wpf.DelegateCommand(new global::System.Action(base.Back), () => this.CanGoBack);
			this.ForwardCommand = new global::CefSharp.Wpf.DelegateCommand(new global::System.Action(base.Forward), () => this.CanGoForward);
			this.ReloadCommand = new global::CefSharp.Wpf.DelegateCommand(new global::System.Action(base.Reload), () => !this.IsLoading);
			this.PrintCommand = new global::CefSharp.Wpf.DelegateCommand(new global::System.Action(base.Print), null);
			this.ZoomInCommand = new global::CefSharp.Wpf.DelegateCommand(new global::System.Action(this.ZoomIn), null);
			this.ZoomOutCommand = new global::CefSharp.Wpf.DelegateCommand(new global::System.Action(this.ZoomOut), null);
			this.ZoomResetCommand = new global::CefSharp.Wpf.DelegateCommand(new global::System.Action(this.ZoomReset), null);
			this.ViewSourceCommand = new global::CefSharp.Wpf.DelegateCommand(new global::System.Action(base.ViewSource), null);
			this.CleanupCommand = new global::CefSharp.Wpf.DelegateCommand(new global::System.Action(this.Dispose), null);
			this.StopCommand = new global::CefSharp.Wpf.DelegateCommand(new global::System.Action(base.Stop), null);
			this.CutCommand = new global::CefSharp.Wpf.DelegateCommand(new global::System.Action(base.Cut), null);
			this.CopyCommand = new global::CefSharp.Wpf.DelegateCommand(new global::System.Action(base.Copy), null);
			this.PasteCommand = new global::CefSharp.Wpf.DelegateCommand(new global::System.Action(base.Paste), null);
			this.SelectAllCommand = new global::CefSharp.Wpf.DelegateCommand(new global::System.Action(base.SelectAll), null);
			this.UndoCommand = new global::CefSharp.Wpf.DelegateCommand(new global::System.Action(base.Undo), null);
			this.RedoCommand = new global::CefSharp.Wpf.DelegateCommand(new global::System.Action(base.Redo), null);
			this.ToggleAudioMuteCommand = new global::CefSharp.Wpf.DelegateCommand(new global::System.Action(base.ToggleAudioMute), null);
			this.managedCefBrowserAdapter = global::CefSharp.ManagedCefBrowserAdapter.Create(this, true);
			this.browserSettings = global::CefSharp.Core.ObjectFactory.CreateBrowserSettings(true);
			this.WpfKeyboardHandler = new global::CefSharp.Wpf.Internals.WpfKeyboardHandler(this);
			global::System.Windows.PresentationSource.AddSourceChangedHandler(this, new global::System.Windows.SourceChangedEventHandler(this.PresentationSourceChangedHandler));
			this.MenuHandler = new global::CefSharp.Wpf.Handler.ContextMenuHandler(false);
			base.UseLayoutRounding = true;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002ABC File Offset: 0x00000CBC
		~ChromiumWebBrowser()
		{
			this.Dispose(false);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002AEC File Offset: 0x00000CEC
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002AFB File Offset: 0x00000CFB
		protected virtual void Dispose(bool disposing)
		{
			if (global::System.Threading.Interlocked.CompareExchange(ref this.disposeSignaled, 1, 0) != 0)
			{
				return;
			}
			if (global::CefSharp.Wpf.ChromiumWebBrowser.DesignMode)
			{
				return;
			}
			this.InternalDispose(disposing);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002B1C File Offset: 0x00000D1C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private void InternalDispose(bool disposing)
		{
			if (disposing)
			{
				this.CanExecuteJavascriptInMainFrame = false;
				global::System.Threading.Interlocked.Exchange(ref this.browserInitialized, 0);
				global::CefSharp.IBrowser browser = this.browser;
				if (browser != null)
				{
					browser.GetHost().WasHidden(true);
				}
				this.UiThreadRunAsync(delegate
				{
					base.SetCurrentValue(global::CefSharp.Wpf.ChromiumWebBrowser.IsBrowserInitializedProperty, false);
					this.WebBrowser = null;
				}, global::System.Windows.Threading.DispatcherPriority.DataBind);
				this.ConsoleMessage = null;
				this.FrameLoadEnd = null;
				this.FrameLoadStart = null;
				this.AddressChanged = null;
				this.IsBrowserInitializedChanged = null;
				this.LoadError = null;
				this.LoadingStateChanged = null;
				this.Paint = null;
				this.StatusMessage = null;
				this.TitleChanged = null;
				this.VirtualKeyboardRequested = null;
				this.JavascriptMessageReceived = null;
				this.FreeHandlersExceptLifeSpanAndFocus();
				this.FocusHandler = new global::CefSharp.Internals.NoFocusHandler();
				this.browser = null;
				this.BrowserCore = null;
				global::CefSharp.IDragData dragData = this.currentDragData;
				if (dragData != null)
				{
					dragData.Dispose();
				}
				this.currentDragData = null;
				global::System.Windows.PresentationSource.RemoveSourceChangedHandler(this, new global::System.Windows.SourceChangedEventHandler(this.PresentationSourceChangedHandler));
				if (this.sourceWindow != null)
				{
					this.sourceWindow.StateChanged -= this.OnWindowStateChanged;
					this.sourceWindow.LocationChanged -= this.OnWindowLocationChanged;
					this.sourceWindow = null;
				}
				base.Loaded -= this.OnLoaded;
				base.SizeChanged -= this.OnActualSizeChanged;
				base.GotKeyboardFocus -= this.OnGotKeyboardFocus;
				base.LostKeyboardFocus -= this.OnLostKeyboardFocus;
				base.DragEnter -= this.OnDragEnter;
				base.DragOver -= this.OnDragOver;
				base.DragLeave -= this.OnDragLeave;
				base.Drop -= this.OnDrop;
				base.IsVisibleChanged -= this.OnIsVisibleChanged;
				if (this.tooltipTimer != null)
				{
					this.tooltipTimer.Tick -= this.OnTooltipTimerTick;
					this.tooltipTimer.Stop();
					this.tooltipTimer = null;
				}
				if (this.CleanupElement != null)
				{
					this.CleanupElement.Unloaded -= this.OnCleanupElementUnloaded;
				}
				global::CefSharp.Internals.IBrowserAdapter browserAdapter = this.managedCefBrowserAdapter;
				if (browserAdapter != null)
				{
					browserAdapter.Dispose();
				}
				this.managedCefBrowserAdapter = null;
				this.LifeSpanHandler = null;
				global::CefSharp.Wpf.IWpfKeyboardHandler wpfKeyboardHandler = this.WpfKeyboardHandler;
				if (wpfKeyboardHandler != null)
				{
					wpfKeyboardHandler.Dispose();
				}
				this.WpfKeyboardHandler = null;
				global::CefSharp.Wpf.IRenderHandler renderHandler = this.RenderHandler;
				this.RenderHandler = null;
				if (renderHandler != null)
				{
					renderHandler.Dispose();
				}
				this.source = null;
			}
			global::CefSharp.Cef.RemoveDisposable(this);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002D94 File Offset: 0x00000F94
		global::CefSharp.Structs.ScreenInfo? global::CefSharp.Internals.IRenderWebBrowser.GetScreenInfo()
		{
			return this.GetScreenInfo();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002D9C File Offset: 0x00000F9C
		protected virtual global::CefSharp.Structs.ScreenInfo? GetScreenInfo()
		{
			global::CefSharp.Structs.Rect value = this.monitorInfo.Monitor;
			global::CefSharp.Structs.Rect value2 = this.monitorInfo.WorkArea;
			if ((double)this.DpiScaleFactor > 1.0)
			{
				value = value.ScaleByDpi(this.DpiScaleFactor);
				value2 = value2.ScaleByDpi(this.DpiScaleFactor);
			}
			global::CefSharp.Structs.ScreenInfo value3 = new global::CefSharp.Structs.ScreenInfo
			{
				DeviceScaleFactor = this.DpiScaleFactor,
				Rect = new global::CefSharp.Structs.Rect?(value),
				AvailableRect = new global::CefSharp.Structs.Rect?(value2)
			};
			return new global::CefSharp.Structs.ScreenInfo?(value3);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002E30 File Offset: 0x00001030
		global::CefSharp.Structs.Rect global::CefSharp.Internals.IRenderWebBrowser.GetViewRect()
		{
			return this.GetViewRect();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002E38 File Offset: 0x00001038
		protected virtual global::CefSharp.Structs.Rect GetViewRect()
		{
			global::CefSharp.Structs.Size? size = this.resizeHackSize;
			if (size == null)
			{
				return this.viewRect;
			}
			global::CefSharp.Structs.Size value = size.Value;
			return new global::CefSharp.Structs.Rect(0, 0, value.Width, value.Height);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002E79 File Offset: 0x00001079
		bool global::CefSharp.Internals.IRenderWebBrowser.GetScreenPoint(int viewX, int viewY, out int screenX, out int screenY)
		{
			return this.GetScreenPoint(viewX, viewY, out screenX, out screenY);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002E88 File Offset: 0x00001088
		protected virtual bool GetScreenPoint(int viewX, int viewY, out int screenX, out int screenY)
		{
			screenX = 0;
			screenY = 0;
			if (this.DpiScaleFactor > 1f)
			{
				screenX = (int)(this.browserScreenLocation.X + (double)((float)viewX * this.DpiScaleFactor));
				screenY = (int)(this.browserScreenLocation.Y + (double)((float)viewY * this.DpiScaleFactor));
			}
			else
			{
				screenX = (int)(this.browserScreenLocation.X + (double)viewX);
				screenY = (int)(this.browserScreenLocation.Y + (double)viewY);
			}
			return true;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002F02 File Offset: 0x00001102
		bool global::CefSharp.Internals.IRenderWebBrowser.StartDragging(global::CefSharp.IDragData dragData, global::CefSharp.Enums.DragOperationsMask allowedOps, int x, int y)
		{
			return this.StartDragging(dragData, allowedOps, x, y);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002F10 File Offset: 0x00001110
		protected virtual bool StartDragging(global::CefSharp.IDragData dragData, global::CefSharp.Enums.DragOperationsMask allowedOps, int x, int y)
		{
			global::System.Windows.DataObject dataObject = new global::System.Windows.DataObject();
			dataObject.SetText(dragData.FragmentText, global::System.Windows.TextDataFormat.Text);
			dataObject.SetText(dragData.FragmentText, global::System.Windows.TextDataFormat.UnicodeText);
			dataObject.SetText(dragData.FragmentHtml, global::System.Windows.TextDataFormat.Html);
			this.currentDragData = dragData.Clone();
			this.currentDragData.ResetFileContents();
			this.UiThreadRunAsync(delegate
			{
				if (this.browser != null)
				{
					global::System.Windows.DragDropEffects dragDropEffects = global::System.Windows.DragDrop.DoDragDrop(this, dataObject, allowedOps.GetDragEffects());
					this.currentDragData = null;
					this.browser.GetHost().DragSourceEndedAt(x, y, dragDropEffects.GetDragOperationsMask());
					this.browser.GetHost().DragSourceSystemDragEnded();
				}
			}, global::System.Windows.Threading.DispatcherPriority.DataBind);
			return true;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002FAC File Offset: 0x000011AC
		void global::CefSharp.Internals.IRenderWebBrowser.UpdateDragCursor(global::CefSharp.Enums.DragOperationsMask operation)
		{
			this.UpdateDragCursor(operation);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002FB5 File Offset: 0x000011B5
		protected virtual void UpdateDragCursor(global::CefSharp.Enums.DragOperationsMask operation)
		{
			this.currentDragDropEffects = operation.GetDragEffects();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002FC3 File Offset: 0x000011C3
		void global::CefSharp.Internals.IRenderWebBrowser.OnAcceleratedPaint(global::CefSharp.PaintElementType type, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr sharedHandle)
		{
			this.OnAcceleratedPaint(type == global::CefSharp.PaintElementType.Popup, dirtyRect, sharedHandle);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002FD1 File Offset: 0x000011D1
		protected virtual void OnAcceleratedPaint(bool isPopup, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr sharedHandle)
		{
			global::CefSharp.Wpf.IRenderHandler renderHandler = this.RenderHandler;
			if (renderHandler == null)
			{
				return;
			}
			renderHandler.OnAcceleratedPaint(isPopup, dirtyRect, sharedHandle);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002FE6 File Offset: 0x000011E6
		void global::CefSharp.Internals.IRenderWebBrowser.OnPaint(global::CefSharp.PaintElementType type, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr buffer, int width, int height)
		{
			this.OnPaint(type == global::CefSharp.PaintElementType.Popup, dirtyRect, buffer, width, height);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002FF8 File Offset: 0x000011F8
		protected virtual void OnPaint(bool isPopup, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr buffer, int width, int height)
		{
			if (this.resizeHackIgnoreOnPaint)
			{
				return;
			}
			global::System.EventHandler<global::CefSharp.Wpf.PaintEventArgs> paint = this.Paint;
			if (paint != null)
			{
				global::CefSharp.Wpf.PaintEventArgs paintEventArgs = new global::CefSharp.Wpf.PaintEventArgs(isPopup, dirtyRect, buffer, width, height);
				paint(this, paintEventArgs);
				if (paintEventArgs.Handled)
				{
					return;
				}
			}
			global::System.Windows.Controls.Image image = isPopup ? this.popupImage : this.image;
			global::CefSharp.Wpf.IRenderHandler renderHandler = this.RenderHandler;
			if (renderHandler == null)
			{
				return;
			}
			renderHandler.OnPaint(isPopup, dirtyRect, buffer, width, height, image);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003060 File Offset: 0x00001260
		void global::CefSharp.Internals.IRenderWebBrowser.OnPopupSize(global::CefSharp.Structs.Rect rect)
		{
			this.OnPopupSize(rect);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000306C File Offset: 0x0000126C
		protected virtual void OnPopupSize(global::CefSharp.Structs.Rect rect)
		{
			this.UiThreadRunAsync(delegate
			{
				this.SetPopupSizeAndPositionImpl(rect);
			}, global::System.Windows.Threading.DispatcherPriority.DataBind);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000030A0 File Offset: 0x000012A0
		void global::CefSharp.Internals.IRenderWebBrowser.OnPopupShow(bool isOpen)
		{
			this.OnPopupShow(isOpen);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000030AC File Offset: 0x000012AC
		protected virtual void OnPopupShow(bool isOpen)
		{
			this.UiThreadRunAsync(delegate
			{
				this.popupImage.Visibility = (isOpen ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Hidden);
			}, global::System.Windows.Threading.DispatcherPriority.DataBind);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000030E0 File Offset: 0x000012E0
		void global::CefSharp.Internals.IRenderWebBrowser.OnCursorChange(global::System.IntPtr handle, global::CefSharp.Enums.CursorType type, global::CefSharp.Structs.CursorInfo customCursorInfo)
		{
			this.OnCursorChange(handle, type, customCursorInfo);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000030EC File Offset: 0x000012EC
		protected virtual void OnCursorChange(global::System.IntPtr handle, global::CefSharp.Enums.CursorType type, global::CefSharp.Structs.CursorInfo customCursorInfo)
		{
			if (type == global::CefSharp.Enums.CursorType.Custom)
			{
				this.UiThreadRunSync(delegate
				{
					this.Cursor = global::System.Windows.Interop.CursorInteropHelper.Create(new global::Microsoft.Win32.SafeHandles.SafeFileHandle(handle, false));
				}, global::System.Windows.Threading.DispatcherPriority.DataBind);
				return;
			}
			this.UiThreadRunAsync(delegate
			{
				this.Cursor = global::System.Windows.Interop.CursorInteropHelper.Create(new global::Microsoft.Win32.SafeHandles.SafeFileHandle(handle, false));
			}, global::System.Windows.Threading.DispatcherPriority.DataBind);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003139 File Offset: 0x00001339
		void global::CefSharp.Internals.IRenderWebBrowser.OnImeCompositionRangeChanged(global::CefSharp.Structs.Range selectedRange, global::CefSharp.Structs.Rect[] characterBounds)
		{
			this.OnImeCompositionRangeChanged(selectedRange, characterBounds);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003144 File Offset: 0x00001344
		protected virtual void OnImeCompositionRangeChanged(global::CefSharp.Structs.Range selectedRange, global::CefSharp.Structs.Rect[] characterBounds)
		{
			global::CefSharp.Wpf.Experimental.WpfImeKeyboardHandler wpfImeKeyboardHandler = this.WpfKeyboardHandler as global::CefSharp.Wpf.Experimental.WpfImeKeyboardHandler;
			if (wpfImeKeyboardHandler != null)
			{
				wpfImeKeyboardHandler.ChangeCompositionRange(selectedRange, characterBounds);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003168 File Offset: 0x00001368
		void global::CefSharp.Internals.IRenderWebBrowser.OnVirtualKeyboardRequested(global::CefSharp.IBrowser browser, global::CefSharp.Enums.TextInputMode inputMode)
		{
			this.OnVirtualKeyboardRequested(browser, inputMode);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003174 File Offset: 0x00001374
		protected virtual void OnVirtualKeyboardRequested(global::CefSharp.IBrowser browser, global::CefSharp.Enums.TextInputMode inputMode)
		{
			global::CefSharp.Wpf.VirtualKeyboardRequestedEventArgs e = new global::CefSharp.Wpf.VirtualKeyboardRequestedEventArgs(browser, inputMode);
			global::System.EventHandler<global::CefSharp.Wpf.VirtualKeyboardRequestedEventArgs> virtualKeyboardRequested = this.VirtualKeyboardRequested;
			if (virtualKeyboardRequested == null)
			{
				return;
			}
			virtualKeyboardRequested(this, e);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000319C File Offset: 0x0000139C
		void global::CefSharp.Internals.IWebBrowserInternal.SetAddress(global::CefSharp.AddressChangedEventArgs args)
		{
			this.UiThreadRunAsync(delegate
			{
				this.ignoreUriChange = true;
				this.SetCurrentValue(global::CefSharp.Wpf.ChromiumWebBrowser.AddressProperty, args.Address);
				this.ignoreUriChange = false;
				this.SetCurrentValue(global::CefSharp.Wpf.ChromiumWebBrowser.TooltipTextProperty, null);
			}, global::System.Windows.Threading.DispatcherPriority.DataBind);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000031D0 File Offset: 0x000013D0
		void global::CefSharp.Internals.IWebBrowserInternal.SetTitle(global::CefSharp.TitleChangedEventArgs args)
		{
			this.UiThreadRunAsync(delegate
			{
				this.SetCurrentValue(global::CefSharp.Wpf.ChromiumWebBrowser.TitleProperty, args.Title);
			}, global::System.Windows.Threading.DispatcherPriority.DataBind);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003204 File Offset: 0x00001404
		void global::CefSharp.Internals.IWebBrowserInternal.SetTooltipText(string tooltipText)
		{
			this.UiThreadRunAsync(delegate
			{
				this.SetCurrentValue(global::CefSharp.Wpf.ChromiumWebBrowser.TooltipTextProperty, tooltipText);
			}, global::System.Windows.Threading.DispatcherPriority.DataBind);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00003238 File Offset: 0x00001438
		public bool CanGoBack
		{
			get
			{
				return (bool)base.GetValue(global::CefSharp.Wpf.ChromiumWebBrowser.CanGoBackProperty);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000324A File Offset: 0x0000144A
		public bool CanGoForward
		{
			get
			{
				return (bool)base.GetValue(global::CefSharp.Wpf.ChromiumWebBrowser.CanGoForwardProperty);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000325C File Offset: 0x0000145C
		// (set) Token: 0x06000066 RID: 102 RVA: 0x0000326E File Offset: 0x0000146E
		public string Address
		{
			get
			{
				return (string)base.GetValue(global::CefSharp.Wpf.ChromiumWebBrowser.AddressProperty);
			}
			set
			{
				base.SetValue(global::CefSharp.Wpf.ChromiumWebBrowser.AddressProperty, value);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000067 RID: 103 RVA: 0x0000327C File Offset: 0x0000147C
		// (remove) Token: 0x06000068 RID: 104 RVA: 0x000032B4 File Offset: 0x000014B4
		public event global::System.Windows.DependencyPropertyChangedEventHandler AddressChanged;

		// Token: 0x06000069 RID: 105 RVA: 0x000032EC File Offset: 0x000014EC
		private static void OnAddressChanged(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::CefSharp.Wpf.ChromiumWebBrowser chromiumWebBrowser = (global::CefSharp.Wpf.ChromiumWebBrowser)sender;
			string oldValue = (string)args.OldValue;
			string newValue = (string)args.NewValue;
			chromiumWebBrowser.OnAddressChanged(oldValue, newValue);
			global::System.Windows.DependencyPropertyChangedEventHandler addressChanged = chromiumWebBrowser.AddressChanged;
			if (addressChanged == null)
			{
				return;
			}
			addressChanged(chromiumWebBrowser, args);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003334 File Offset: 0x00001534
		protected virtual void OnAddressChanged(string oldValue, string newValue)
		{
			if (this.ignoreUriChange || newValue == null || !this.InternalIsBrowserInitialized())
			{
				return;
			}
			this.Load(newValue);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00003351 File Offset: 0x00001551
		public bool IsLoading
		{
			get
			{
				return (bool)base.GetValue(global::CefSharp.Wpf.ChromiumWebBrowser.IsLoadingProperty);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00003363 File Offset: 0x00001563
		public bool IsBrowserInitialized
		{
			get
			{
				return (bool)base.GetValue(global::CefSharp.Wpf.ChromiumWebBrowser.IsBrowserInitializedProperty);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600006D RID: 109 RVA: 0x00003378 File Offset: 0x00001578
		// (remove) Token: 0x0600006E RID: 110 RVA: 0x000033B0 File Offset: 0x000015B0
		public event global::System.Windows.DependencyPropertyChangedEventHandler IsBrowserInitializedChanged;

		// Token: 0x0600006F RID: 111 RVA: 0x000033E8 File Offset: 0x000015E8
		private static void OnIsBrowserInitializedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::CefSharp.Wpf.ChromiumWebBrowser chromiumWebBrowser = (global::CefSharp.Wpf.ChromiumWebBrowser)d;
			bool oldValue = (bool)e.OldValue;
			bool newValue = (bool)e.NewValue;
			chromiumWebBrowser.OnIsBrowserInitializedChanged(oldValue, newValue);
			global::System.Windows.DependencyPropertyChangedEventHandler isBrowserInitializedChanged = chromiumWebBrowser.IsBrowserInitializedChanged;
			if (isBrowserInitializedChanged == null)
			{
				return;
			}
			isBrowserInitializedChanged(chromiumWebBrowser, e);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003430 File Offset: 0x00001630
		protected virtual void OnIsBrowserInitializedChanged(bool oldValue, bool newValue)
		{
			if (newValue && !this.IsDisposed)
			{
				global::System.Threading.Tasks.Task<double> zoomLevelAsync = this.GetZoomLevelAsync();
				zoomLevelAsync.ContinueWith(delegate(global::System.Threading.Tasks.Task<double> previous)
				{
					if (previous.Status == global::System.Threading.Tasks.TaskStatus.RanToCompletion)
					{
						this.UiThreadRunAsync(delegate
						{
							if (!this.IsDisposed)
							{
								this.SetCurrentValue(global::CefSharp.Wpf.ChromiumWebBrowser.ZoomLevelProperty, previous.Result);
							}
						}, global::System.Windows.Threading.DispatcherPriority.DataBind);
						return;
					}
					throw new global::System.InvalidOperationException("Unexpected failure of calling CEF->GetZoomLevelAsync", previous.Exception);
				}, global::System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00003467 File Offset: 0x00001667
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00003479 File Offset: 0x00001679
		public string Title
		{
			get
			{
				return (string)base.GetValue(global::CefSharp.Wpf.ChromiumWebBrowser.TitleProperty);
			}
			set
			{
				base.SetValue(global::CefSharp.Wpf.ChromiumWebBrowser.TitleProperty, value);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000073 RID: 115 RVA: 0x00003488 File Offset: 0x00001688
		// (remove) Token: 0x06000074 RID: 116 RVA: 0x000034C0 File Offset: 0x000016C0
		public event global::System.Windows.DependencyPropertyChangedEventHandler TitleChanged;

		// Token: 0x06000075 RID: 117 RVA: 0x000034F8 File Offset: 0x000016F8
		private static void OnTitleChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::CefSharp.Wpf.ChromiumWebBrowser chromiumWebBrowser = (global::CefSharp.Wpf.ChromiumWebBrowser)d;
			global::System.Windows.DependencyPropertyChangedEventHandler titleChanged = chromiumWebBrowser.TitleChanged;
			if (titleChanged == null)
			{
				return;
			}
			titleChanged(chromiumWebBrowser, e);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000351E File Offset: 0x0000171E
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00003530 File Offset: 0x00001730
		public double ZoomLevel
		{
			get
			{
				return (double)base.GetValue(global::CefSharp.Wpf.ChromiumWebBrowser.ZoomLevelProperty);
			}
			set
			{
				base.SetValue(global::CefSharp.Wpf.ChromiumWebBrowser.ZoomLevelProperty, value);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003544 File Offset: 0x00001744
		private static void OnZoomLevelChanged(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::CefSharp.Wpf.ChromiumWebBrowser chromiumWebBrowser = (global::CefSharp.Wpf.ChromiumWebBrowser)sender;
			double oldValue = (double)args.OldValue;
			double newValue = (double)args.NewValue;
			chromiumWebBrowser.OnZoomLevelChanged(oldValue, newValue);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000357A File Offset: 0x0000177A
		protected virtual void OnZoomLevelChanged(double oldValue, double newValue)
		{
			this.SetZoomLevel(newValue);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00003583 File Offset: 0x00001783
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00003595 File Offset: 0x00001795
		public double ZoomLevelIncrement
		{
			get
			{
				return (double)base.GetValue(global::CefSharp.Wpf.ChromiumWebBrowser.ZoomLevelIncrementProperty);
			}
			set
			{
				base.SetValue(global::CefSharp.Wpf.ChromiumWebBrowser.ZoomLevelIncrementProperty, value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000035A8 File Offset: 0x000017A8
		// (set) Token: 0x0600007D RID: 125 RVA: 0x000035BA File Offset: 0x000017BA
		public global::System.Windows.FrameworkElement CleanupElement
		{
			get
			{
				return (global::System.Windows.FrameworkElement)base.GetValue(global::CefSharp.Wpf.ChromiumWebBrowser.CleanupElementProperty);
			}
			set
			{
				base.SetValue(global::CefSharp.Wpf.ChromiumWebBrowser.CleanupElementProperty, value);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000035C8 File Offset: 0x000017C8
		private static void OnCleanupElementChanged(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			global::CefSharp.Wpf.ChromiumWebBrowser chromiumWebBrowser = (global::CefSharp.Wpf.ChromiumWebBrowser)sender;
			global::System.Windows.FrameworkElement oldValue = (global::System.Windows.FrameworkElement)args.OldValue;
			global::System.Windows.FrameworkElement newValue = (global::System.Windows.FrameworkElement)args.NewValue;
			chromiumWebBrowser.OnCleanupElementChanged(oldValue, newValue);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000035FE File Offset: 0x000017FE
		protected virtual void OnCleanupElementChanged(global::System.Windows.FrameworkElement oldValue, global::System.Windows.FrameworkElement newValue)
		{
			if (oldValue != null)
			{
				oldValue.Unloaded -= this.OnCleanupElementUnloaded;
			}
			if (newValue != null)
			{
				newValue.Unloaded -= this.OnCleanupElementUnloaded;
				newValue.Unloaded += this.OnCleanupElementUnloaded;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000363C File Offset: 0x0000183C
		private void OnCleanupElementUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.Dispose();
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00003644 File Offset: 0x00001844
		public string TooltipText
		{
			get
			{
				return (string)base.GetValue(global::CefSharp.Wpf.ChromiumWebBrowser.TooltipTextProperty);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003658 File Offset: 0x00001858
		private static void OnTooltipTextChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::CefSharp.Wpf.ChromiumWebBrowser chromiumWebBrowser = (global::CefSharp.Wpf.ChromiumWebBrowser)d;
			string oldValue = (string)e.OldValue;
			string newValue = (string)e.NewValue;
			chromiumWebBrowser.OnTooltipTextChanged(oldValue, newValue);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003690 File Offset: 0x00001890
		protected virtual void OnTooltipTextChanged(string oldValue, string newValue)
		{
			global::System.Windows.Threading.DispatcherTimer dispatcherTimer = this.tooltipTimer;
			if (dispatcherTimer == null)
			{
				return;
			}
			if (string.IsNullOrEmpty(oldValue) && string.IsNullOrEmpty(newValue))
			{
				return;
			}
			if (string.IsNullOrEmpty(newValue))
			{
				if (dispatcherTimer.IsEnabled)
				{
					dispatcherTimer.Stop();
				}
				this.OpenOrCloseToolTip(null);
				return;
			}
			if (!dispatcherTimer.IsEnabled)
			{
				dispatcherTimer.Start();
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000036E5 File Offset: 0x000018E5
		// (set) Token: 0x06000085 RID: 133 RVA: 0x000036F7 File Offset: 0x000018F7
		public global::CefSharp.IWebBrowser WebBrowser
		{
			get
			{
				return (global::CefSharp.IWebBrowser)base.GetValue(global::CefSharp.Wpf.ChromiumWebBrowser.WebBrowserProperty);
			}
			set
			{
				base.SetValue(global::CefSharp.Wpf.ChromiumWebBrowser.WebBrowserProperty, value);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003708 File Offset: 0x00001908
		private void OnDrop(object sender, global::System.Windows.DragEventArgs e)
		{
			if (this.browser != null)
			{
				global::CefSharp.MouseEvent mouseEvent = this.GetMouseEvent(e);
				global::CefSharp.Enums.DragOperationsMask dragOperationsMask = e.AllowedEffects.GetDragOperationsMask();
				this.browser.GetHost().DragTargetDragOver(mouseEvent, dragOperationsMask);
				this.browser.GetHost().DragTargetDragDrop(mouseEvent);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003754 File Offset: 0x00001954
		private void OnDragLeave(object sender, global::System.Windows.DragEventArgs e)
		{
			if (this.browser != null)
			{
				this.browser.GetHost().DragTargetDragLeave();
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000376E File Offset: 0x0000196E
		private void OnDragOver(object sender, global::System.Windows.DragEventArgs e)
		{
			if (this.browser != null)
			{
				this.browser.GetHost().DragTargetDragOver(this.GetMouseEvent(e), e.AllowedEffects.GetDragOperationsMask());
			}
			e.Effects = this.currentDragDropEffects;
			e.Handled = true;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000037B0 File Offset: 0x000019B0
		private void OnDragEnter(object sender, global::System.Windows.DragEventArgs e)
		{
			if (this.browser != null)
			{
				global::CefSharp.MouseEvent mouseEvent = this.GetMouseEvent(e);
				global::CefSharp.Enums.DragOperationsMask dragOperationsMask = e.AllowedEffects.GetDragOperationsMask();
				global::CefSharp.IDragData dragData = this.currentDragData ?? e.GetDragData();
				this.browser.GetHost().DragTargetDragEnter(dragData, mouseEvent, dragOperationsMask);
				this.browser.GetHost().DragTargetDragOver(mouseEvent, dragOperationsMask);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003810 File Offset: 0x00001A10
		private void PresentationSourceChangedHandler(object sender, global::System.Windows.SourceChangedEventArgs args)
		{
			if (args.NewSource != null)
			{
				this.source = (global::System.Windows.Interop.HwndSource)args.NewSource;
				this.WpfKeyboardHandler.Setup(this.source);
				this.NotifyDpiChange((float)this.source.CompositionTarget.TransformToDevice.M11);
				global::System.Windows.Window window = this.source.RootVisual as global::System.Windows.Window;
				if (window != null)
				{
					window.StateChanged += this.OnWindowStateChanged;
					window.LocationChanged += this.OnWindowLocationChanged;
					this.sourceWindow = window;
					if (this.CleanupElement == null)
					{
						this.CleanupElement = window;
					}
					else
					{
						global::System.Windows.Window window2 = this.CleanupElement as global::System.Windows.Window;
						if (window2 != null && window2 != window)
						{
							this.CleanupElement = window;
						}
					}
				}
				this.browserScreenLocation = this.GetBrowserScreenLocation();
				this.monitorInfo.Init();
				global::CefSharp.Wpf.Internals.MonitorInfo.GetMonitorInfoForWindowHandle(this.source.Handle, ref this.monitorInfo);
				return;
			}
			if (args.OldSource != null)
			{
				this.WpfKeyboardHandler.Dispose();
				global::System.Windows.Window window3 = args.OldSource.RootVisual as global::System.Windows.Window;
				if (window3 != null)
				{
					window3.StateChanged -= this.OnWindowStateChanged;
					window3.LocationChanged -= this.OnWindowLocationChanged;
					this.sourceWindow = null;
				}
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003953 File Offset: 0x00001B53
		protected override void OnDpiChanged(global::System.Windows.DpiScale oldDpi, global::System.Windows.DpiScale newDpi)
		{
			this.NotifyDpiChange((float)newDpi.DpiScaleX);
			base.OnDpiChanged(oldDpi, newDpi);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000396C File Offset: 0x00001B6C
		private void OnWindowStateChanged(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Window window = (global::System.Windows.Window)sender;
			switch (window.WindowState)
			{
			case global::System.Windows.WindowState.Normal:
			case global::System.Windows.WindowState.Maximized:
				if (this.previousWindowState == global::System.Windows.WindowState.Minimized && base.IsVisible)
				{
					this.OnBrowserWasHidden(false);
				}
				break;
			case global::System.Windows.WindowState.Minimized:
				this.OnBrowserWasHidden(true);
				break;
			}
			this.previousWindowState = window.WindowState;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000039C8 File Offset: 0x00001BC8
		protected virtual void OnBrowserWasHidden(bool hidden)
		{
			if (this.browser != null)
			{
				this.browser.GetHost().WasHidden(hidden);
				if (this.ResizeHackEnabled)
				{
					if (hidden)
					{
						this.resizeHackIgnoreOnPaint = true;
						return;
					}
					this.CefUiThreadRunAsync(delegate
					{
						global::CefSharp.Wpf.ChromiumWebBrowser.<<OnBrowserWasHidden>b__240_0>d <<OnBrowserWasHidden>b__240_0>d;
						<<OnBrowserWasHidden>b__240_0>d.<>t__builder = global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Create();
						<<OnBrowserWasHidden>b__240_0>d.<>4__this = this;
						<<OnBrowserWasHidden>b__240_0>d.<>1__state = -1;
						<<OnBrowserWasHidden>b__240_0>d.<>t__builder.Start<global::CefSharp.Wpf.ChromiumWebBrowser.<<OnBrowserWasHidden>b__240_0>d>(ref <<OnBrowserWasHidden>b__240_0>d);
					});
				}
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003A14 File Offset: 0x00001C14
		protected virtual global::System.Windows.Point GetBrowserScreenLocation()
		{
			if (this.source != null && global::System.Windows.PresentationSource.FromVisual(this) != null)
			{
				return base.PointToScreen(default(global::System.Windows.Point));
			}
			return default(global::System.Windows.Point);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003A4A File Offset: 0x00001C4A
		private void OnWindowLocationChanged(object sender, global::System.EventArgs e)
		{
			this.browserScreenLocation = this.GetBrowserScreenLocation();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003A58 File Offset: 0x00001C58
		public bool CreateBrowser(global::System.Windows.Interop.HwndSource parentWindowHwndSource, global::System.Windows.Size initialSize)
		{
			if (initialSize.IsEmpty || initialSize.Equals(new global::System.Windows.Size(0.0, 0.0)))
			{
				throw new global::System.Exception("Invalid size, must be greater than 0,0");
			}
			this.source = parentWindowHwndSource;
			if (!this.CreateOffscreenBrowser(initialSize))
			{
				return false;
			}
			global::System.Windows.RoutedEventHandler handler = null;
			handler = delegate(object sender, global::System.Windows.RoutedEventArgs args)
			{
				this.Loaded -= handler;
				global::CefSharp.IBrowserHost browserHost = this.GetBrowserHost();
				if (browserHost != null)
				{
					browserHost.Invalidate(global::CefSharp.PaintElementType.View);
				}
			};
			base.Loaded += handler;
			return true;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003AE0 File Offset: 0x00001CE0
		protected virtual bool CreateOffscreenBrowser(global::System.Windows.Size size)
		{
			if (this.browserCreated || size.IsEmpty || size.Equals(new global::System.Windows.Size(0.0, 0.0)))
			{
				return false;
			}
			if (!((global::CefSharp.Internals.IWebBrowserInternal)this).HasParent)
			{
				global::CefSharp.IWindowInfo windowInfo = this.CreateOffscreenBrowserWindowInfo((this.source == null) ? global::System.IntPtr.Zero : this.source.Handle);
				this.managedCefBrowserAdapter.CreateBrowser(windowInfo, this.browserSettings, this.requestContext, this.initialAddress);
				if (this.browserSettings.AutoDispose)
				{
					this.browserSettings.Dispose();
				}
				this.browserSettings = null;
			}
			this.browserCreated = true;
			return true;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003B90 File Offset: 0x00001D90
		protected virtual global::CefSharp.IWindowInfo CreateOffscreenBrowserWindowInfo(global::System.IntPtr handle)
		{
			global::CefSharp.IWindowInfo windowInfo = global::CefSharp.Core.ObjectFactory.CreateWindowInfo();
			windowInfo.SetAsWindowless(handle);
			return windowInfo;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003BAB File Offset: 0x00001DAB
		internal void UiThreadRunAsync(global::System.Action action, global::System.Windows.Threading.DispatcherPriority priority = global::System.Windows.Threading.DispatcherPriority.DataBind)
		{
			if (base.Dispatcher.CheckAccess())
			{
				action();
				return;
			}
			if (!base.Dispatcher.HasShutdownStarted)
			{
				base.Dispatcher.BeginInvoke(action, priority, global::System.Array.Empty<object>());
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003BE1 File Offset: 0x00001DE1
		private void UiThreadRunSync(global::System.Action action, global::System.Windows.Threading.DispatcherPriority priority = global::System.Windows.Threading.DispatcherPriority.DataBind)
		{
			if (base.Dispatcher.CheckAccess())
			{
				action();
				return;
			}
			if (!base.Dispatcher.HasShutdownStarted)
			{
				base.Dispatcher.Invoke(action, priority);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003C14 File Offset: 0x00001E14
		private void OnActualSizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			this.CreateOffscreenBrowser(e.NewSize);
			this.viewRect = new global::CefSharp.Structs.Rect(0, 0, (int)e.NewSize.Width, (int)e.NewSize.Height);
			if (this.browser != null)
			{
				this.browser.GetHost().WasResized();
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003C74 File Offset: 0x00001E74
		private void OnIsVisibleChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			bool flag = (bool)args.NewValue;
			if (this.browser != null)
			{
				this.OnBrowserWasHidden(!flag);
				if (flag)
				{
					global::CefSharp.IBrowserHost host = this.browser.GetHost();
					host.GetZoomLevelAsync().ContinueWith(delegate(global::System.Threading.Tasks.Task<double> t)
					{
						if (!this.IsDisposed)
						{
							base.SetCurrentValue(global::CefSharp.Wpf.ChromiumWebBrowser.ZoomLevelProperty, t.Result);
						}
					}, global::System.Threading.CancellationToken.None, global::System.Threading.Tasks.TaskContinuationOptions.OnlyOnRanToCompletion, global::System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
				}
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003CD8 File Offset: 0x00001ED8
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs routedEventArgs)
		{
			this.tooltipTimer = new global::System.Windows.Threading.DispatcherTimer(global::System.TimeSpan.FromSeconds(0.5), global::System.Windows.Threading.DispatcherPriority.Render, new global::System.EventHandler(this.OnTooltipTimerTick), base.Dispatcher);
			this.tooltipTimer.IsEnabled = false;
			this.browserScreenLocation = this.GetBrowserScreenLocation();
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003D2C File Offset: 0x00001F2C
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this.image == null)
			{
				this.image = (global::System.Windows.Controls.Image)base.GetTemplateChild("PART_image");
			}
			if (this.popupImage == null)
			{
				this.popupImage = (global::System.Windows.Controls.Image)base.GetTemplateChild("PART_popupImage");
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003D7C File Offset: 0x00001F7C
		private global::CefSharp.MouseEvent GetMouseEvent(global::System.Windows.DragEventArgs e)
		{
			global::System.Windows.Point position = e.GetPosition(this);
			return new global::CefSharp.MouseEvent((int)position.X, (int)position.Y, e.GetModifiers());
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003DAC File Offset: 0x00001FAC
		private void SetPopupSizeAndPositionImpl(global::CefSharp.Structs.Rect rect)
		{
			this.popupImage.Width = (double)rect.Width;
			this.popupImage.Height = (double)rect.Height;
			global::System.Windows.Controls.Canvas.SetLeft(this.popupImage, (double)rect.X);
			global::System.Windows.Controls.Canvas.SetTop(this.popupImage, (double)rect.Y);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00003E05 File Offset: 0x00002005
		private void OnTooltipTimerTick(object sender, global::System.EventArgs e)
		{
			if (!this.IsDisposed)
			{
				this.tooltipTimer.Stop();
				this.OpenOrCloseToolTip(this.TooltipText);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00003E26 File Offset: 0x00002026
		private void OnTooltipClosed(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.toolTip.Visibility = global::System.Windows.Visibility.Collapsed;
			this.toolTip.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Absolute;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00003E40 File Offset: 0x00002040
		protected virtual void OpenOrCloseToolTip(string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				if (this.toolTip.IsOpen)
				{
					this.toolTip.IsOpen = false;
					return;
				}
			}
			else
			{
				if (this.toolTip.IsOpen)
				{
					this.toolTip.IsOpen = false;
				}
				if (this.toolTip.Style == null)
				{
					this.toolTip.Content = new global::System.Windows.Controls.TextBlock
					{
						Text = text,
						TextWrapping = global::System.Windows.TextWrapping.Wrap
					};
				}
				else
				{
					this.toolTip.SetCurrentValue(global::System.Windows.Controls.ContentControl.ContentProperty, text);
				}
				this.toolTip.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Mouse;
				this.toolTip.Visibility = global::System.Windows.Visibility.Visible;
				this.toolTip.IsOpen = true;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003EED File Offset: 0x000020ED
		private void OnGotKeyboardFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			if (this.browser == null)
			{
				this.initialFocus = true;
				return;
			}
			this.browser.GetHost().SetFocus(true);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00003F10 File Offset: 0x00002110
		private void OnLostKeyboardFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			if (this.browser == null)
			{
				this.initialFocus = false;
				return;
			}
			this.browser.GetHost().SetFocus(false);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00003F33 File Offset: 0x00002133
		protected override void OnPreviewKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (!e.Handled && this.browser != null)
			{
				this.WpfKeyboardHandler.HandleKeyPress(e);
			}
			base.OnPreviewKeyDown(e);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003F58 File Offset: 0x00002158
		protected override void OnPreviewKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			if (!e.Handled && this.browser != null)
			{
				this.WpfKeyboardHandler.HandleKeyPress(e);
			}
			base.OnPreviewKeyUp(e);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003F7D File Offset: 0x0000217D
		protected override void OnPreviewTextInput(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			if (!e.Handled && this.browser != null)
			{
				this.WpfKeyboardHandler.HandleTextInput(e);
			}
			base.OnPreviewTextInput(e);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003FA4 File Offset: 0x000021A4
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			if (!e.Handled && this.browser != null && e.StylusDevice == null)
			{
				global::System.Windows.Point position = e.GetPosition(this);
				global::CefSharp.CefEventFlags modifiers = e.GetModifiers();
				this.browser.GetHost().SendMouseMoveEvent((int)position.X, (int)position.Y, false, modifiers);
			}
			base.OnMouseMove(e);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004004 File Offset: 0x00002204
		protected override void OnMouseWheel(global::System.Windows.Input.MouseWheelEventArgs e)
		{
			if (!e.Handled && this.browser != null)
			{
				global::System.Windows.Point position = e.GetPosition(this);
				global::CefSharp.CefEventFlags modifiers = e.GetModifiers();
				bool flag = global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftShift) || global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightShift);
				int x = (int)position.X;
				int y = (int)position.Y;
				this.browser.SendMouseWheelEvent(x, y, flag ? e.Delta : 0, (!flag) ? e.Delta : 0, modifiers);
				e.Handled = true;
			}
			base.OnMouseWheel(e);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000408C File Offset: 0x0000228C
		protected override void OnMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (e.StylusDevice == null)
			{
				base.Focus();
				this.OnMouseButton(e);
				if (e.ChangedButton == global::System.Windows.Input.MouseButton.Left && e.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
				{
					base.CaptureMouse();
				}
			}
			base.OnMouseDown(e);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000040C3 File Offset: 0x000022C3
		protected override void OnMouseUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (e.StylusDevice == null)
			{
				this.OnMouseButton(e);
				if (e.ChangedButton == global::System.Windows.Input.MouseButton.Left && e.LeftButton == global::System.Windows.Input.MouseButtonState.Released)
				{
					base.ReleaseMouseCapture();
				}
			}
			base.OnMouseUp(e);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000040F4 File Offset: 0x000022F4
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			if (!e.Handled && this.browser != null && e.StylusDevice == null)
			{
				global::CefSharp.CefEventFlags modifiers = e.GetModifiers();
				global::System.Windows.Point position = e.GetPosition(this);
				this.browser.GetHost().SendMouseMoveEvent((int)position.X, (int)position.Y, true, modifiers);
				((global::CefSharp.Internals.IWebBrowserInternal)this).SetTooltipText(null);
			}
			base.OnMouseLeave(e);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00004158 File Offset: 0x00002358
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			if (!e.Handled && this.browser != null)
			{
				this.browser.GetHost().SendCaptureLostEvent();
			}
			base.OnLostMouseCapture(e);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004184 File Offset: 0x00002384
		private void OnMouseButton(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (!e.Handled && this.browser != null)
			{
				global::CefSharp.CefEventFlags modifiers = e.GetModifiers();
				bool flag = e.ButtonState == global::System.Windows.Input.MouseButtonState.Released;
				global::System.Windows.Point position = e.GetPosition(this);
				if (e.ChangedButton == global::System.Windows.Input.MouseButton.XButton1)
				{
					if (this.CanGoBack && flag)
					{
						this.Back();
					}
				}
				else if (e.ChangedButton == global::System.Windows.Input.MouseButton.XButton2)
				{
					if (this.CanGoForward && flag)
					{
						this.Forward();
					}
				}
				else
				{
					int num = e.ClickCount;
					if (num > 3)
					{
						num = 1;
					}
					this.browser.GetHost().SendMouseClickEvent((int)position.X, (int)position.Y, (global::CefSharp.MouseButtonType)e.ChangedButton, flag, num, modifiers);
				}
				e.Handled = true;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00004233 File Offset: 0x00002433
		protected override void OnTouchDown(global::System.Windows.Input.TouchEventArgs e)
		{
			base.Focus();
			base.CaptureTouch(e.TouchDevice);
			this.OnTouch(e);
			base.OnTouchDown(e);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004257 File Offset: 0x00002457
		protected override void OnTouchMove(global::System.Windows.Input.TouchEventArgs e)
		{
			this.OnTouch(e);
			base.OnTouchMove(e);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004267 File Offset: 0x00002467
		protected override void OnTouchUp(global::System.Windows.Input.TouchEventArgs e)
		{
			base.ReleaseTouchCapture(e.TouchDevice);
			this.OnTouch(e);
			base.OnTouchUp(e);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00004284 File Offset: 0x00002484
		private void OnTouch(global::System.Windows.Input.TouchEventArgs e)
		{
			if (!e.Handled && this.browser != null)
			{
				global::CefSharp.CefEventFlags modifierKeys = global::CefSharp.Wpf.Internals.WpfExtensions.GetModifierKeys(global::CefSharp.CefEventFlags.None);
				global::System.Windows.Input.TouchPoint touchPoint = e.GetTouchPoint(this);
				global::CefSharp.Enums.TouchEventType type;
				switch (touchPoint.Action)
				{
				case global::System.Windows.Input.TouchAction.Down:
					type = global::CefSharp.Enums.TouchEventType.Pressed;
					break;
				case global::System.Windows.Input.TouchAction.Move:
					type = global::CefSharp.Enums.TouchEventType.Moved;
					break;
				case global::System.Windows.Input.TouchAction.Up:
					type = global::CefSharp.Enums.TouchEventType.Released;
					break;
				default:
					type = global::CefSharp.Enums.TouchEventType.Cancelled;
					break;
				}
				global::CefSharp.Structs.TouchEvent evt = new global::CefSharp.Structs.TouchEvent
				{
					Id = e.TouchDevice.Id,
					X = (float)touchPoint.Position.X,
					Y = (float)touchPoint.Position.Y,
					PointerType = global::CefSharp.Enums.PointerType.Touch,
					Type = type,
					Modifiers = modifierKeys
				};
				this.browser.GetHost().SendTouchEvent(evt);
				e.Handled = true;
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00004360 File Offset: 0x00002560
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityHandler accessibilityHandler = this.AccessibilityHandler as global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityHandler;
			if (accessibilityHandler == null)
			{
				return base.OnCreateAutomationPeer();
			}
			return accessibilityHandler.AutomationPeer;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000438C File Offset: 0x0000258C
		public void Load(string url)
		{
			if (this.IsDisposed)
			{
				return;
			}
			if (this.InternalIsBrowserInitialized())
			{
				if (this.browser == null)
				{
					return;
				}
				this.initialLoadCalled = true;
				using (global::CefSharp.IFrame mainFrame = this.browser.MainFrame)
				{
					mainFrame.LoadUrl(url);
					return;
				}
			}
			if (this.browserCreated)
			{
				this.UiThreadRunAsync(delegate
				{
					this.Address = url;
				}, global::System.Windows.Threading.DispatcherPriority.DataBind);
				return;
			}
			this.initialAddress = url;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000442C File Offset: 0x0000262C
		private void ZoomIn()
		{
			this.UiThreadRunAsync(delegate
			{
				this.ZoomLevel += this.ZoomLevelIncrement;
			}, global::System.Windows.Threading.DispatcherPriority.DataBind);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00004441 File Offset: 0x00002641
		private void ZoomOut()
		{
			this.UiThreadRunAsync(delegate
			{
				this.ZoomLevel -= this.ZoomLevelIncrement;
			}, global::System.Windows.Threading.DispatcherPriority.DataBind);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00004456 File Offset: 0x00002656
		private void ZoomReset()
		{
			this.UiThreadRunAsync(delegate
			{
				this.ZoomLevel = 0.0;
			}, global::System.Windows.Threading.DispatcherPriority.DataBind);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000446C File Offset: 0x0000266C
		public virtual void NotifyDpiChange(float newDpi)
		{
			if (this.DpiScaleFactor.Equals(newDpi))
			{
				return;
			}
			bool flag = this.DpiScaleFactor > 0f && !this.DpiScaleFactor.Equals(newDpi);
			this.DpiScaleFactor = newDpi;
			if (flag && this.browser != null)
			{
				this.browser.GetHost().NotifyScreenInfoChanged();
			}
			if (this.RenderHandler == null || this.RenderHandler is global::CefSharp.Wpf.Rendering.WritableBitmapRenderHandler || this.RenderHandler is global::CefSharp.Wpf.Rendering.DirectWritableBitmapRenderHandler)
			{
				float num = 96f * this.DpiScaleFactor;
				global::CefSharp.Wpf.IRenderHandler renderHandler = this.RenderHandler;
				if (global::CefSharp.Cef.CurrentlyOnThread(global::CefSharp.CefThreadIds.TID_UI))
				{
					this.RenderHandler = new global::CefSharp.Wpf.Rendering.DirectWritableBitmapRenderHandler((double)num, (double)num, true, global::System.Windows.Threading.DispatcherPriority.Render);
				}
				else
				{
					this.RenderHandler = new global::CefSharp.Wpf.Rendering.WritableBitmapRenderHandler((double)num, (double)num, true, global::System.Windows.Threading.DispatcherPriority.Render);
				}
				if (renderHandler != null)
				{
					renderHandler.Dispose();
				}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000453C File Offset: 0x0000273C
		public global::System.Threading.Tasks.Task WaitForRenderIdleAsync(int idleTimeInMs = 500, global::System.TimeSpan? timeout = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::CefSharp.Wpf.ChromiumWebBrowser.<WaitForRenderIdleAsync>d__279 <WaitForRenderIdleAsync>d__;
			<WaitForRenderIdleAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<WaitForRenderIdleAsync>d__.<>4__this = this;
			<WaitForRenderIdleAsync>d__.idleTimeInMs = idleTimeInMs;
			<WaitForRenderIdleAsync>d__.timeout = timeout;
			<WaitForRenderIdleAsync>d__.cancellationToken = cancellationToken;
			<WaitForRenderIdleAsync>d__.<>1__state = -1;
			<WaitForRenderIdleAsync>d__.<>t__builder.Start<global::CefSharp.Wpf.ChromiumWebBrowser.<WaitForRenderIdleAsync>d__279>(ref <WaitForRenderIdleAsync>d__);
			return <WaitForRenderIdleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004597 File Offset: 0x00002797
		public void UseLegacyKeyboardHandler()
		{
			if (!(this.WpfKeyboardHandler is global::CefSharp.Wpf.Internals.WpfLegacyKeyboardHandler))
			{
				this.WpfKeyboardHandler.Dispose();
				this.WpfKeyboardHandler = new global::CefSharp.Wpf.Internals.WpfLegacyKeyboardHandler(this);
				this.WpfKeyboardHandler.Setup(this.source);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x000045CE File Offset: 0x000027CE
		public global::CefSharp.IJavascriptObjectRepository JavascriptObjectRepository
		{
			get
			{
				global::CefSharp.Internals.IBrowserAdapter browserAdapter = this.managedCefBrowserAdapter;
				if (browserAdapter == null)
				{
					return null;
				}
				return browserAdapter.JavascriptObjectRepository;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000045E1 File Offset: 0x000027E1
		public global::CefSharp.IBrowser GetBrowser()
		{
			this.ThrowExceptionIfDisposed();
			this.ThrowExceptionIfBrowserNotInitialized();
			return this.browser;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000045F8 File Offset: 0x000027F8
		private global::System.Threading.Tasks.Task CefUiThreadRunAsync(global::System.Action action)
		{
			global::CefSharp.Wpf.ChromiumWebBrowser.<CefUiThreadRunAsync>d__284 <CefUiThreadRunAsync>d__;
			<CefUiThreadRunAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<CefUiThreadRunAsync>d__.<>4__this = this;
			<CefUiThreadRunAsync>d__.action = action;
			<CefUiThreadRunAsync>d__.<>1__state = -1;
			<CefUiThreadRunAsync>d__.<>t__builder.Start<global::CefSharp.Wpf.ChromiumWebBrowser.<CefUiThreadRunAsync>d__284>(ref <CefUiThreadRunAsync>d__);
			return <CefUiThreadRunAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004644 File Offset: 0x00002844
		private global::System.Threading.Tasks.Task ResizeHackRun()
		{
			global::CefSharp.Wpf.ChromiumWebBrowser.<ResizeHackRun>d__285 <ResizeHackRun>d__;
			<ResizeHackRun>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<ResizeHackRun>d__.<>4__this = this;
			<ResizeHackRun>d__.<>1__state = -1;
			<ResizeHackRun>d__.<>t__builder.Start<global::CefSharp.Wpf.ChromiumWebBrowser.<ResizeHackRun>d__285>(ref <ResizeHackRun>d__);
			return <ResizeHackRun>d__.<>t__builder.Task;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00004687 File Offset: 0x00002887
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0000468F File Offset: 0x0000288F
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.IBrowser BrowserCore { get; internal set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00004698 File Offset: 0x00002898
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000046A0 File Offset: 0x000028A0
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool CanExecuteJavascriptInMainFrame { get; private set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000046A9 File Offset: 0x000028A9
		// (set) Token: 0x060000BF RID: 191 RVA: 0x000046B1 File Offset: 0x000028B1
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.IDialogHandler DialogHandler { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x000046BA File Offset: 0x000028BA
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x000046C2 File Offset: 0x000028C2
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.IJsDialogHandler JsDialogHandler { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000046CB File Offset: 0x000028CB
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x000046D3 File Offset: 0x000028D3
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.IKeyboardHandler KeyboardHandler { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000046DC File Offset: 0x000028DC
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x000046E4 File Offset: 0x000028E4
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.IRequestHandler RequestHandler { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000046ED File Offset: 0x000028ED
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x000046F5 File Offset: 0x000028F5
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.IDownloadHandler DownloadHandler { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000046FE File Offset: 0x000028FE
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00004706 File Offset: 0x00002906
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.ILoadHandler LoadHandler { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000470F File Offset: 0x0000290F
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00004717 File Offset: 0x00002917
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.ILifeSpanHandler LifeSpanHandler { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00004720 File Offset: 0x00002920
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00004728 File Offset: 0x00002928
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.IDisplayHandler DisplayHandler { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00004731 File Offset: 0x00002931
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00004739 File Offset: 0x00002939
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.IContextMenuHandler MenuHandler { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00004742 File Offset: 0x00002942
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x0000474A File Offset: 0x0000294A
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.IRenderProcessMessageHandler RenderProcessMessageHandler { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00004753 File Offset: 0x00002953
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000475B File Offset: 0x0000295B
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.IFindHandler FindHandler { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00004764 File Offset: 0x00002964
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000476C File Offset: 0x0000296C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.IAudioHandler AudioHandler { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00004775 File Offset: 0x00002975
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000477D File Offset: 0x0000297D
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.IFrameHandler FrameHandler { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00004786 File Offset: 0x00002986
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000478E File Offset: 0x0000298E
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.IPermissionHandler PermissionHandler { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00004797 File Offset: 0x00002997
		// (set) Token: 0x060000DB RID: 219 RVA: 0x0000479F File Offset: 0x0000299F
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.IFocusHandler FocusHandler { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000047A8 File Offset: 0x000029A8
		// (set) Token: 0x060000DD RID: 221 RVA: 0x000047B0 File Offset: 0x000029B0
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.IDragHandler DragHandler { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000047B9 File Offset: 0x000029B9
		// (set) Token: 0x060000DF RID: 223 RVA: 0x000047C1 File Offset: 0x000029C1
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::CefSharp.IResourceRequestHandlerFactory ResourceRequestHandlerFactory { get; set; }

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060000E0 RID: 224 RVA: 0x000047CC File Offset: 0x000029CC
		// (remove) Token: 0x060000E1 RID: 225 RVA: 0x00004804 File Offset: 0x00002A04
		public event global::System.EventHandler<global::CefSharp.LoadErrorEventArgs> LoadError;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060000E2 RID: 226 RVA: 0x0000483C File Offset: 0x00002A3C
		// (remove) Token: 0x060000E3 RID: 227 RVA: 0x00004874 File Offset: 0x00002A74
		public event global::System.EventHandler<global::CefSharp.FrameLoadStartEventArgs> FrameLoadStart;

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060000E4 RID: 228 RVA: 0x000048AC File Offset: 0x00002AAC
		// (remove) Token: 0x060000E5 RID: 229 RVA: 0x000048E4 File Offset: 0x00002AE4
		public event global::System.EventHandler<global::CefSharp.FrameLoadEndEventArgs> FrameLoadEnd;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060000E6 RID: 230 RVA: 0x0000491C File Offset: 0x00002B1C
		// (remove) Token: 0x060000E7 RID: 231 RVA: 0x00004954 File Offset: 0x00002B54
		public event global::System.EventHandler<global::CefSharp.LoadingStateChangedEventArgs> LoadingStateChanged;

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060000E8 RID: 232 RVA: 0x0000498C File Offset: 0x00002B8C
		// (remove) Token: 0x060000E9 RID: 233 RVA: 0x000049C4 File Offset: 0x00002BC4
		public event global::System.EventHandler<global::CefSharp.ConsoleMessageEventArgs> ConsoleMessage;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060000EA RID: 234 RVA: 0x000049FC File Offset: 0x00002BFC
		// (remove) Token: 0x060000EB RID: 235 RVA: 0x00004A34 File Offset: 0x00002C34
		public event global::System.EventHandler<global::CefSharp.StatusMessageEventArgs> StatusMessage;

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060000EC RID: 236 RVA: 0x00004A6C File Offset: 0x00002C6C
		// (remove) Token: 0x060000ED RID: 237 RVA: 0x00004AA4 File Offset: 0x00002CA4
		public event global::System.EventHandler<global::CefSharp.JavascriptMessageReceivedEventArgs> JavascriptMessageReceived;

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00004AD9 File Offset: 0x00002CD9
		bool global::CefSharp.IChromiumWebBrowserBase.IsBrowserInitialized
		{
			get
			{
				return this.InternalIsBrowserInitialized();
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00004AE1 File Offset: 0x00002CE1
		void global::CefSharp.Internals.IWebBrowserInternal.SetCanExecuteJavascriptOnMainFrame(long frameId, bool canExecute)
		{
			if (frameId > this.canExecuteJavascriptInMainFrameId && !canExecute)
			{
				return;
			}
			this.canExecuteJavascriptInMainFrameId = frameId;
			this.CanExecuteJavascriptInMainFrame = canExecute;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00004B00 File Offset: 0x00002D00
		void global::CefSharp.Internals.IWebBrowserInternal.SetJavascriptMessageReceived(global::CefSharp.JavascriptMessageReceivedEventArgs args)
		{
			global::System.Threading.Tasks.Task.Run(delegate()
			{
				global::System.EventHandler<global::CefSharp.JavascriptMessageReceivedEventArgs> javascriptMessageReceived = this.JavascriptMessageReceived;
				if (javascriptMessageReceived == null)
				{
					return;
				}
				javascriptMessageReceived(this, args);
			});
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00004B33 File Offset: 0x00002D33
		void global::CefSharp.Internals.IWebBrowserInternal.OnFrameLoadStart(global::CefSharp.FrameLoadStartEventArgs args)
		{
			global::System.EventHandler<global::CefSharp.FrameLoadStartEventArgs> frameLoadStart = this.FrameLoadStart;
			if (frameLoadStart == null)
			{
				return;
			}
			frameLoadStart(this, args);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00004B47 File Offset: 0x00002D47
		void global::CefSharp.Internals.IWebBrowserInternal.OnFrameLoadEnd(global::CefSharp.FrameLoadEndEventArgs args)
		{
			global::System.EventHandler<global::CefSharp.FrameLoadEndEventArgs> frameLoadEnd = this.FrameLoadEnd;
			if (frameLoadEnd == null)
			{
				return;
			}
			frameLoadEnd(this, args);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00004B5B File Offset: 0x00002D5B
		void global::CefSharp.Internals.IWebBrowserInternal.OnConsoleMessage(global::CefSharp.ConsoleMessageEventArgs args)
		{
			global::System.EventHandler<global::CefSharp.ConsoleMessageEventArgs> consoleMessage = this.ConsoleMessage;
			if (consoleMessage == null)
			{
				return;
			}
			consoleMessage(this, args);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00004B6F File Offset: 0x00002D6F
		void global::CefSharp.Internals.IWebBrowserInternal.OnStatusMessage(global::CefSharp.StatusMessageEventArgs args)
		{
			global::System.EventHandler<global::CefSharp.StatusMessageEventArgs> statusMessage = this.StatusMessage;
			if (statusMessage == null)
			{
				return;
			}
			statusMessage(this, args);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00004B84 File Offset: 0x00002D84
		void global::CefSharp.Internals.IWebBrowserInternal.OnLoadError(global::CefSharp.LoadErrorEventArgs args)
		{
			global::System.EventHandler<global::CefSharp.LoadErrorEventArgs> loadError = this.LoadError;
			if (loadError != null)
			{
				loadError(this, args);
			}
			global::System.Action<bool?, global::CefSharp.CefErrorCode?> action = this.initialLoadAction;
			if (action == null)
			{
				return;
			}
			action(null, new global::CefSharp.CefErrorCode?(args.ErrorCode));
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00004BC8 File Offset: 0x00002DC8
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00004BD0 File Offset: 0x00002DD0
		bool global::CefSharp.Internals.IWebBrowserInternal.HasParent { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00004BD9 File Offset: 0x00002DD9
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x00004BE1 File Offset: 0x00002DE1
		global::System.IDisposable global::CefSharp.Internals.IWebBrowserInternal.DevToolsContext { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00004BEA File Offset: 0x00002DEA
		global::CefSharp.Internals.IBrowserAdapter global::CefSharp.Internals.IWebBrowserInternal.BrowserAdapter
		{
			get
			{
				return this.managedCefBrowserAdapter;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00004BF4 File Offset: 0x00002DF4
		void global::CefSharp.Internals.IWebBrowserInternal.OnAfterBrowserCreated(global::CefSharp.IBrowser browser)
		{
			if (this.IsDisposed || browser.IsDisposed)
			{
				return;
			}
			this.browser = browser;
			this.BrowserCore = browser;
			this.initialLoadAction = new global::System.Action<bool?, global::CefSharp.CefErrorCode?>(this.InitialLoad);
			global::System.Threading.Interlocked.Exchange(ref this.browserInitialized, 1);
			this.OnAfterBrowserCreated(browser);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00004C48 File Offset: 0x00002E48
		void global::CefSharp.Internals.IWebBrowserInternal.SetLoadingStateChange(global::CefSharp.LoadingStateChangedEventArgs args)
		{
			this.SetLoadingStateChange(args);
			global::System.EventHandler<global::CefSharp.LoadingStateChangedEventArgs> loadingStateChanged = this.LoadingStateChanged;
			if (loadingStateChanged != null)
			{
				loadingStateChanged(this, args);
			}
			global::System.Action<bool?, global::CefSharp.CefErrorCode?> action = this.initialLoadAction;
			if (action == null)
			{
				return;
			}
			action(new bool?(args.IsLoading), null);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00004C93 File Offset: 0x00002E93
		public void LoadUrl(string url)
		{
			this.Load(url);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00004C9C File Offset: 0x00002E9C
		public global::System.Threading.Tasks.Task<global::CefSharp.LoadUrlAsyncResponse> LoadUrlAsync(string url)
		{
			return global::CefSharp.WebBrowserExtensions.LoadUrlAsync(this, url);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00004CA5 File Offset: 0x00002EA5
		public global::System.Threading.Tasks.Task<global::CefSharp.WaitForNavigationAsyncResponse> WaitForNavigationAsync(global::System.TimeSpan? timeout = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return global::CefSharp.WebBrowserExtensions.WaitForNavigationAsync(this, timeout, cancellationToken);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00004CAF File Offset: 0x00002EAF
		public global::System.Threading.Tasks.Task<global::CefSharp.LoadUrlAsyncResponse> WaitForInitialLoadAsync()
		{
			return this.initialLoadTaskCompletionSource.Task;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00004CBC File Offset: 0x00002EBC
		public bool TryGetBrowserCoreById(int browserId, out global::CefSharp.IBrowser browser)
		{
			global::CefSharp.Internals.IBrowserAdapter browserAdapter = this.managedCefBrowserAdapter;
			if (this.IsDisposed || browserAdapter == null || browserAdapter.IsDisposed)
			{
				browser = null;
				return false;
			}
			browser = browserAdapter.GetBrowser(browserId);
			return browser != null;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00004CF8 File Offset: 0x00002EF8
		public global::System.Threading.Tasks.Task<global::CefSharp.Structs.DomRect> GetContentSizeAsync()
		{
			global::CefSharp.Wpf.ChromiumWebBrowser.<GetContentSizeAsync>d__417 <GetContentSizeAsync>d__;
			<GetContentSizeAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::CefSharp.Structs.DomRect>.Create();
			<GetContentSizeAsync>d__.<>4__this = this;
			<GetContentSizeAsync>d__.<>1__state = -1;
			<GetContentSizeAsync>d__.<>t__builder.Start<global::CefSharp.Wpf.ChromiumWebBrowser.<GetContentSizeAsync>d__417>(ref <GetContentSizeAsync>d__);
			return <GetContentSizeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00004D3C File Offset: 0x00002F3C
		private void InitialLoad(bool? isLoading, global::CefSharp.CefErrorCode? errorCode)
		{
			if (this.IsDisposed)
			{
				this.initialLoadAction = null;
				this.initialLoadTaskCompletionSource.TrySetCanceled();
				return;
			}
			if (isLoading == null)
			{
				if (errorCode != null)
				{
					global::CefSharp.CefErrorCode? cefErrorCode = errorCode;
					global::CefSharp.CefErrorCode cefErrorCode2 = global::CefSharp.CefErrorCode.Aborted;
					if (cefErrorCode.GetValueOrDefault() == cefErrorCode2 & cefErrorCode != null)
					{
						return;
					}
					this.initialLoadAction = null;
					this.initialLoadTaskCompletionSource.TrySetResultAsync(new global::CefSharp.LoadUrlAsyncResponse(errorCode.Value, -1));
				}
				return;
			}
			if (isLoading.Value)
			{
				return;
			}
			this.initialLoadAction = null;
			global::CefSharp.IBrowser browser = this.browser;
			global::CefSharp.IBrowserHost browserHost = (browser != null) ? browser.GetHost() : null;
			global::CefSharp.NavigationEntry navigationEntry = (browserHost != null) ? browserHost.GetVisibleNavigationEntry() : null;
			int num = (navigationEntry != null) ? navigationEntry.HttpStatusCode : -1;
			if (num == 0)
			{
				num = -1;
			}
			this.initialLoadTaskCompletionSource.TrySetResultAsync(new global::CefSharp.LoadUrlAsyncResponse(global::CefSharp.CefErrorCode.None, num));
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00004E08 File Offset: 0x00003008
		private void OnAfterBrowserCreated(global::CefSharp.IBrowser browser)
		{
			this.UiThreadRunAsync(delegate
			{
				if (!this.IsDisposed)
				{
					base.SetCurrentValue(global::CefSharp.Wpf.ChromiumWebBrowser.IsBrowserInitializedProperty, true);
					if (string.IsNullOrEmpty(this.initialAddress) && !string.IsNullOrEmpty(this.Address) && !this.initialLoadCalled)
					{
						this.Load(this.Address);
					}
				}
			}, global::System.Windows.Threading.DispatcherPriority.DataBind);
			if (this.initialFocus)
			{
				global::CefSharp.IBrowserHost host = browser.GetHost();
				if (host == null)
				{
					return;
				}
				host.SetFocus(true);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00004E38 File Offset: 0x00003038
		private void SetLoadingStateChange(global::CefSharp.LoadingStateChangedEventArgs args)
		{
			this.UiThreadRunAsync(delegate
			{
				this.SetCurrentValue(global::CefSharp.Wpf.ChromiumWebBrowser.CanGoBackProperty, args.CanGoBack);
				this.SetCurrentValue(global::CefSharp.Wpf.ChromiumWebBrowser.CanGoForwardProperty, args.CanGoForward);
				this.SetCurrentValue(global::CefSharp.Wpf.ChromiumWebBrowser.IsLoadingProperty, args.IsLoading);
				((global::CefSharp.Wpf.DelegateCommand)this.BackCommand).RaiseCanExecuteChanged();
				((global::CefSharp.Wpf.DelegateCommand)this.ForwardCommand).RaiseCanExecuteChanged();
				((global::CefSharp.Wpf.DelegateCommand)this.ReloadCommand).RaiseCanExecuteChanged();
			}, global::System.Windows.Threading.DispatcherPriority.DataBind);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00004E6C File Offset: 0x0000306C
		private void FreeHandlersExceptLifeSpanAndFocus()
		{
			global::CefSharp.IAudioHandler audioHandler = this.AudioHandler;
			if (audioHandler != null)
			{
				audioHandler.Dispose();
			}
			this.AudioHandler = null;
			this.DialogHandler = null;
			this.FindHandler = null;
			this.RequestHandler = null;
			this.DisplayHandler = null;
			this.LoadHandler = null;
			this.KeyboardHandler = null;
			this.JsDialogHandler = null;
			this.DragHandler = null;
			this.DownloadHandler = null;
			this.MenuHandler = null;
			this.ResourceRequestHandlerFactory = null;
			this.RenderProcessMessageHandler = null;
			this.FreeDevToolsContext();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00004EEB File Offset: 0x000030EB
		private bool InternalIsBrowserInitialized()
		{
			return global::System.Threading.Interlocked.CompareExchange(ref this.browserInitialized, 0, 0) == 1;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00004EFD File Offset: 0x000030FD
		private void ThrowExceptionIfBrowserNotInitialized()
		{
			if (!this.InternalIsBrowserInitialized())
			{
				throw new global::System.Exception("The ChromiumWebBrowser instance creates the underlying Chromium Embedded Framework (CEF) browser instance in an async fashion. The undelying CefBrowser instance is not yet initialized. Use the IsBrowserInitializedChanged event and check the IsBrowserInitialized property to determine when the browser has been initialized.");
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00004F12 File Offset: 0x00003112
		private void ThrowExceptionIfDisposed()
		{
			if (this.IsDisposed)
			{
				throw new global::System.ObjectDisposedException("ChromiumWebBrowser");
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00004F27 File Offset: 0x00003127
		global::System.Windows.Threading.Dispatcher global::CefSharp.Wpf.IWpfWebBrowser.get_Dispatcher()
		{
			return base.Dispatcher;
		}

		// Token: 0x04000001 RID: 1
		public const string PartImageName = "PART_image";

		// Token: 0x04000002 RID: 2
		public const string PartPopupImageName = "PART_popupImage";

		// Token: 0x04000003 RID: 3
		private global::CefSharp.Structs.Rect viewRect;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.WindowState previousWindowState;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Interop.HwndSource source;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Window sourceWindow;

		// Token: 0x04000007 RID: 7
		private global::CefSharp.Wpf.Internals.MonitorInfoEx monitorInfo;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Threading.DispatcherTimer tooltipTimer;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Controls.ToolTip toolTip;

		// Token: 0x0400000A RID: 10
		private global::CefSharp.Internals.IBrowserAdapter managedCefBrowserAdapter;

		// Token: 0x0400000B RID: 11
		private bool ignoreUriChange;

		// Token: 0x0400000C RID: 12
		private string initialAddress;

		// Token: 0x0400000D RID: 13
		private bool initialLoadCalled;

		// Token: 0x0400000E RID: 14
		private bool browserCreated;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Controls.Image image;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Controls.Image popupImage;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Point browserScreenLocation;

		// Token: 0x04000012 RID: 18
		private global::CefSharp.IBrowserSettings browserSettings;

		// Token: 0x04000013 RID: 19
		private global::CefSharp.IRequestContext requestContext;

		// Token: 0x04000014 RID: 20
		private global::CefSharp.IDragData currentDragData;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.DragDropEffects currentDragDropEffects;

		// Token: 0x04000016 RID: 22
		private static bool DesignMode;

		// Token: 0x04000017 RID: 23
		private bool resizeHackIgnoreOnPaint;

		// Token: 0x04000018 RID: 24
		private global::CefSharp.Structs.Size? resizeHackSize;

		// Token: 0x04000019 RID: 25
		private bool initialFocus;

		// Token: 0x04000033 RID: 51
		public static global::System.Windows.DependencyProperty CanGoBackProperty = global::System.Windows.DependencyProperty.Register("CanGoBack", typeof(bool), typeof(global::CefSharp.Wpf.ChromiumWebBrowser));

		// Token: 0x04000034 RID: 52
		public static global::System.Windows.DependencyProperty CanGoForwardProperty = global::System.Windows.DependencyProperty.Register("CanGoForward", typeof(bool), typeof(global::CefSharp.Wpf.ChromiumWebBrowser));

		// Token: 0x04000035 RID: 53
		public static readonly global::System.Windows.DependencyProperty AddressProperty = global::System.Windows.DependencyProperty.Register("Address", typeof(string), typeof(global::CefSharp.Wpf.ChromiumWebBrowser), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::CefSharp.Wpf.ChromiumWebBrowser.OnAddressChanged)));

		// Token: 0x04000037 RID: 55
		public static readonly global::System.Windows.DependencyProperty IsLoadingProperty = global::System.Windows.DependencyProperty.Register("IsLoading", typeof(bool), typeof(global::CefSharp.Wpf.ChromiumWebBrowser), new global::System.Windows.PropertyMetadata(false));

		// Token: 0x04000038 RID: 56
		public static readonly global::System.Windows.DependencyProperty IsBrowserInitializedProperty = global::System.Windows.DependencyProperty.Register("IsBrowserInitialized", typeof(bool), typeof(global::CefSharp.Wpf.ChromiumWebBrowser), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::CefSharp.Wpf.ChromiumWebBrowser.OnIsBrowserInitializedChanged)));

		// Token: 0x0400003A RID: 58
		public static readonly global::System.Windows.DependencyProperty TitleProperty = global::System.Windows.DependencyProperty.Register("Title", typeof(string), typeof(global::CefSharp.Wpf.ChromiumWebBrowser), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::CefSharp.Wpf.ChromiumWebBrowser.OnTitleChanged)));

		// Token: 0x0400003C RID: 60
		public static readonly global::System.Windows.DependencyProperty ZoomLevelProperty = global::System.Windows.DependencyProperty.Register("ZoomLevel", typeof(double), typeof(global::CefSharp.Wpf.ChromiumWebBrowser), new global::System.Windows.UIPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::CefSharp.Wpf.ChromiumWebBrowser.OnZoomLevelChanged)));

		// Token: 0x0400003D RID: 61
		public static readonly global::System.Windows.DependencyProperty ZoomLevelIncrementProperty = global::System.Windows.DependencyProperty.Register("ZoomLevelIncrement", typeof(double), typeof(global::CefSharp.Wpf.ChromiumWebBrowser), new global::System.Windows.PropertyMetadata(0.1));

		// Token: 0x0400003E RID: 62
		public static readonly global::System.Windows.DependencyProperty CleanupElementProperty = global::System.Windows.DependencyProperty.Register("CleanupElement", typeof(global::System.Windows.FrameworkElement), typeof(global::CefSharp.Wpf.ChromiumWebBrowser), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::CefSharp.Wpf.ChromiumWebBrowser.OnCleanupElementChanged)));

		// Token: 0x0400003F RID: 63
		public static readonly global::System.Windows.DependencyProperty TooltipTextProperty = global::System.Windows.DependencyProperty.Register("TooltipText", typeof(string), typeof(global::CefSharp.Wpf.ChromiumWebBrowser), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::CefSharp.Wpf.ChromiumWebBrowser.OnTooltipTextChanged)));

		// Token: 0x04000040 RID: 64
		public static readonly global::System.Windows.DependencyProperty WebBrowserProperty = global::System.Windows.DependencyProperty.Register("WebBrowser", typeof(global::CefSharp.IWebBrowser), typeof(global::CefSharp.Wpf.ChromiumWebBrowser), new global::System.Windows.UIPropertyMetadata(null));

		// Token: 0x04000041 RID: 65
		public const string BrowserNotInitializedExceptionErrorMessage = "The ChromiumWebBrowser instance creates the underlying Chromium Embedded Framework (CEF) browser instance in an async fashion. The undelying CefBrowser instance is not yet initialized. Use the IsBrowserInitializedChanged event and check the IsBrowserInitialized property to determine when the browser has been initialized.";

		// Token: 0x04000042 RID: 66
		private const string CefInitializeFailedErrorMessage = "Cef.Initialize() failed.Check the log file see https://github.com/cefsharp/CefSharp/wiki/Trouble-Shooting#log-file for details.";

		// Token: 0x04000043 RID: 67
		private long canExecuteJavascriptInMainFrameId;

		// Token: 0x04000044 RID: 68
		private int browserInitialized;

		// Token: 0x04000045 RID: 69
		private int disposeSignaled;

		// Token: 0x04000046 RID: 70
		private global::CefSharp.IBrowser browser;

		// Token: 0x04000047 RID: 71
		private global::System.Threading.Tasks.TaskCompletionSource<global::CefSharp.LoadUrlAsyncResponse> initialLoadTaskCompletionSource = new global::System.Threading.Tasks.TaskCompletionSource<global::CefSharp.LoadUrlAsyncResponse>();

		// Token: 0x04000048 RID: 72
		private global::System.Action<bool?, global::CefSharp.CefErrorCode?> initialLoadAction;
	}
}
