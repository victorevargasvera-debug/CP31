using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace Microsoft.Web.WebView2.WinForms
{
	// Token: 0x02000003 RID: 3
	public class WebView2 : global::System.Windows.Forms.Control, global::System.ComponentModel.ISupportInitialize
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000020D5 File Offset: 0x000002D5
		[global::System.ComponentModel.ToolboxItem(true)]
		public WebView2()
		{
			this.InitializeComponent();
			base.SetStyle(global::System.Windows.Forms.ControlStyles.UserPaint, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002111 File Offset: 0x00000311
		protected override void Dispose(bool disposing)
		{
			if (!disposing || base.IsDisposed)
			{
				return;
			}
			if (this.IsInitialized)
			{
				this.UnsubscribeHandlersAndCloseController(false);
			}
			if (this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002148 File Offset: 0x00000348
		private void UnsubscribeHandlersAndCloseController(bool browserCrashed = false)
		{
			this.IsInitialized = false;
			this._browserCrashed = browserCrashed;
			base.HandleDestroyed -= this.WebView2_HandleDestroyed;
			base.HandleCreated -= this.WebView2_HandleCreated;
			if (!this._browserCrashed)
			{
				this.CoreWebView2.NavigationCompleted -= this.CoreWebView2_NavigationCompleted;
				this.CoreWebView2.NavigationStarting -= this.CoreWebView2_NavigationStarting;
				this.CoreWebView2.SourceChanged -= this.CoreWebView2_SourceChanged;
				this.CoreWebView2.WebMessageReceived -= this.CoreWebView2_WebMessageReceived;
				this.CoreWebView2.ContentLoading -= this.CoreWebView2_ContentLoading;
				this.CoreWebView2.ProcessFailed -= this.CoreWebView2_ProcessFailed;
				this._coreWebView2Controller.ZoomFactorChanged -= this._coreWebView2Controller_ZoomFactorChanged;
				this._coreWebView2Controller.MoveFocusRequested -= this.CoreWebView2Controller_MoveFocusRequested;
				this._coreWebView2Controller.AcceleratorKeyPressed -= this._coreWebView2Controller_AcceleratorKeyPressed;
				this._coreWebView2Controller.Close();
			}
			this._coreWebView2Controller = null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002274 File Offset: 0x00000474
		protected override void OnPaint(global::System.Windows.Forms.PaintEventArgs e)
		{
			base.OnPaint(e);
			if (this.IsInDesignMode)
			{
				e.Graphics.FillRectangle(new global::System.Drawing.SolidBrush(this.BackColor), base.ClientRectangle);
				e.Graphics.DrawRectangle(new global::System.Drawing.Pen(new global::System.Drawing.SolidBrush(this.ForeColor), 2f), base.ClientRectangle);
				global::System.Drawing.SizeF sizeF = e.Graphics.MeasureString("WebView2", this.Font);
				if (this.BackgroundImage != null)
				{
					e.Graphics.DrawImage(this.BackgroundImage, new global::System.Drawing.Rectangle(global::System.Drawing.Point.Empty, base.ClientSize));
				}
				e.Graphics.DrawString("WebView2", this.Font, new global::System.Drawing.SolidBrush(this.ForeColor), (float)(base.ClientSize.Width / 2) - sizeF.Width / 2f, (float)(base.ClientSize.Height / 2) - sizeF.Height / 2f);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002374 File Offset: 0x00000574
		protected override void WndProc(ref global::System.Windows.Forms.Message m)
		{
			if (m.Msg == 15 && !this.IsInDesignMode)
			{
				global::Microsoft.Web.WebView2.WinForms.WebView2.NativeMethods.PaintStruct paintStruct;
				global::Microsoft.Web.WebView2.WinForms.WebView2.NativeMethods.BeginPaint(m.HWnd, out paintStruct);
				global::Microsoft.Web.WebView2.WinForms.WebView2.NativeMethods.EndPaint(m.HWnd, ref paintStruct);
				m.Result = global::System.IntPtr.Zero;
				return;
			}
			base.WndProc(ref m);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000023C2 File Offset: 0x000005C2
		// (set) Token: 0x0600000F RID: 15 RVA: 0x000023CA File Offset: 0x000005CA
		[global::System.ComponentModel.Browsable(false)]
		public global::Microsoft.Web.WebView2.WinForms.CoreWebView2CreationProperties CreationProperties
		{
			get
			{
				return this._creationProperties;
			}
			set
			{
				if (this._initTask != null)
				{
					throw new global::System.InvalidOperationException("CreationProperties cannot be modified after the initialization of CoreWebView2 has begun.");
				}
				this._creationProperties = value;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000023E8 File Offset: 0x000005E8
		public global::System.Threading.Tasks.Task EnsureCoreWebView2Async(global::Microsoft.Web.WebView2.Core.CoreWebView2Environment environment = null)
		{
			if (this.IsInDesignMode)
			{
				return global::System.Threading.Tasks.Task.FromResult<int>(0);
			}
			this.VerifyNotClosedGuard();
			this.VerifyBrowserNotCrashedGuard();
			if (base.InvokeRequired)
			{
				throw new global::System.InvalidOperationException("The method EnsureCoreWebView2Async can be invoked only from the UI thread.");
			}
			if (this._initTask == null)
			{
				this._initTask = this.InitCoreWebView2Async(environment);
			}
			return this._initTask;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002440 File Offset: 0x00000640
		private global::System.Threading.Tasks.Task InitCoreWebView2Async(global::Microsoft.Web.WebView2.Core.CoreWebView2Environment environment = null)
		{
			global::Microsoft.Web.WebView2.WinForms.WebView2.<InitCoreWebView2Async>d__13 <InitCoreWebView2Async>d__;
			<InitCoreWebView2Async>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<InitCoreWebView2Async>d__.<>4__this = this;
			<InitCoreWebView2Async>d__.environment = environment;
			<InitCoreWebView2Async>d__.<>1__state = -1;
			<InitCoreWebView2Async>d__.<>t__builder.Start<global::Microsoft.Web.WebView2.WinForms.WebView2.<InitCoreWebView2Async>d__13>(ref <InitCoreWebView2Async>d__);
			return <InitCoreWebView2Async>d__.<>t__builder.Task;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000248B File Offset: 0x0000068B
		private void WebView2_HandleCreated(object sender, global::System.EventArgs e)
		{
			this._coreWebView2Controller.ParentWindow = base.Handle;
			this._coreWebView2Controller.IsVisible = base.Visible;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000024AF File Offset: 0x000006AF
		private void WebView2_HandleDestroyed(object sender, global::System.EventArgs e)
		{
			this._coreWebView2Controller.IsVisible = false;
			this._coreWebView2Controller.ParentWindow = global::System.IntPtr.Zero;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000024CD File Offset: 0x000006CD
		protected override global::System.Windows.Forms.CreateParams CreateParams
		{
			get
			{
				global::System.Windows.Forms.CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 32;
				return createParams;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000024E4 File Offset: 0x000006E4
		private void _coreWebView2Controller_AcceleratorKeyPressed(object sender, global::Microsoft.Web.WebView2.Core.CoreWebView2AcceleratorKeyPressedEventArgs e)
		{
			switch (e.KeyEventKind)
			{
			case global::Microsoft.Web.WebView2.Core.CoreWebView2KeyEventKind.KeyDown:
			case global::Microsoft.Web.WebView2.Core.CoreWebView2KeyEventKind.SystemKeyDown:
			{
				global::System.Windows.Forms.KeyEventArgs keyEventArgs = new global::System.Windows.Forms.KeyEventArgs((global::System.Windows.Forms.Keys)e.VirtualKey);
				this.OnKeyDown(keyEventArgs);
				e.Handled = keyEventArgs.Handled;
				return;
			}
			case global::Microsoft.Web.WebView2.Core.CoreWebView2KeyEventKind.KeyUp:
			case global::Microsoft.Web.WebView2.Core.CoreWebView2KeyEventKind.SystemKeyUp:
			{
				global::System.Windows.Forms.KeyEventArgs keyEventArgs2 = new global::System.Windows.Forms.KeyEventArgs((global::System.Windows.Forms.Keys)e.VirtualKey);
				this.OnKeyUp(keyEventArgs2);
				e.Handled = keyEventArgs2.Handled;
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002550 File Offset: 0x00000750
		private void CoreWebView2Controller_MoveFocusRequested(object sender, global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusRequestedEventArgs e)
		{
			bool forward = e.Reason == global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Next || e.Reason == global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Programmatic;
			global::System.Windows.Forms.Control control = base.FindForm() ?? base.Parent;
			e.Handled = (control == null || control.SelectNextControl(this, forward, true, true, true));
			if (this._lastMoveFocusReason != global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Programmatic)
			{
				this._coreWebView2Controller.MoveFocus(this._lastMoveFocusReason);
				this._lastMoveFocusReason = global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Programmatic;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000025BB File Offset: 0x000007BB
		protected override void OnVisibleChanged(global::System.EventArgs e)
		{
			base.OnVisibleChanged(e);
			if (this.IsInitialized && !this._browserCrashed)
			{
				this._coreWebView2Controller.IsVisible = base.Visible;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000025E5 File Offset: 0x000007E5
		protected override void OnSizeChanged(global::System.EventArgs e)
		{
			base.OnSizeChanged(e);
			if (this.IsInitialized && !this._browserCrashed)
			{
				this._coreWebView2Controller.Bounds = new global::System.Drawing.Rectangle(0, 0, base.Width, base.Height);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000261C File Offset: 0x0000081C
		protected override void Select(bool directed, bool forward)
		{
			if (directed)
			{
				this._lastMoveFocusReason = (forward ? global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Next : global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Previous);
			}
			base.Select(directed, forward);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002636 File Offset: 0x00000836
		protected override void OnGotFocus(global::System.EventArgs e)
		{
			base.OnGotFocus(e);
			if (this.IsInitialized && !this._browserCrashed)
			{
				this._coreWebView2Controller.MoveFocus(this._lastMoveFocusReason);
				this._lastMoveFocusReason = global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason.Programmatic;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002667 File Offset: 0x00000867
		// (set) Token: 0x0600001C RID: 28 RVA: 0x0000266F File Offset: 0x0000086F
		private bool IsInitialized { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002678 File Offset: 0x00000878
		private bool IsInDesignMode
		{
			get
			{
				global::System.ComponentModel.ISite sitedParentSite = this.GetSitedParentSite(this);
				return sitedParentSite != null && sitedParentSite.DesignMode;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002698 File Offset: 0x00000898
		private global::System.ComponentModel.ISite GetSitedParentSite(global::System.Windows.Forms.Control control)
		{
			if (control == null)
			{
				throw new global::System.ArgumentNullException("control");
			}
			if (control.Site == null && control.Parent != null)
			{
				return this.GetSitedParentSite(control.Parent);
			}
			return control.Site;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000026CC File Offset: 0x000008CC
		public global::Microsoft.Web.WebView2.Core.CoreWebView2 CoreWebView2
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2 result;
				try
				{
					global::Microsoft.Web.WebView2.Core.CoreWebView2Controller coreWebView2Controller = this._coreWebView2Controller;
					result = ((coreWebView2Controller != null) ? coreWebView2Controller.CoreWebView2 : null);
				}
				catch (global::System.Exception innerException)
				{
					if (base.InvokeRequired)
					{
						throw new global::System.InvalidOperationException("CoreWebView2 can only be accessed from the UI thread.", innerException);
					}
					throw;
				}
				return result;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002718 File Offset: 0x00000918
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002734 File Offset: 0x00000934
		public double ZoomFactor
		{
			get
			{
				if (this._coreWebView2Controller != null)
				{
					return this._coreWebView2Controller.ZoomFactor;
				}
				return this._zoomFactor;
			}
			set
			{
				this._zoomFactor = value;
				if (this._coreWebView2Controller != null)
				{
					this._coreWebView2Controller.ZoomFactor = value;
				}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002751 File Offset: 0x00000951
		void global::System.ComponentModel.ISupportInitialize.BeginInit()
		{
			this._inInit = true;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000275A File Offset: 0x0000095A
		void global::System.ComponentModel.ISupportInitialize.EndInit()
		{
			this._inInit = false;
			if (this._source == null)
			{
				return;
			}
			if (!this.IsInitialized)
			{
				this.EnsureCoreWebView2Async(null);
				return;
			}
			this.CoreWebView2.Navigate(this._source.AbsoluteUri);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002799 File Offset: 0x00000999
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000027A4 File Offset: 0x000009A4
		[global::System.ComponentModel.Browsable(true)]
		public global::System.Uri Source
		{
			get
			{
				return this._source;
			}
			set
			{
				if (value == null)
				{
					if (this._source == null)
					{
						return;
					}
					throw new global::System.NotImplementedException("Setting Source to null is not implemented yet.");
				}
				else
				{
					if (!value.IsAbsoluteUri)
					{
						throw new global::System.ArgumentException("Only absolute URI is allowed", "Source");
					}
					if (this._source != null && this._source.AbsoluteUri == value.AbsoluteUri)
					{
						return;
					}
					this._source = value;
					if (this._inInit)
					{
						return;
					}
					if (!this.IsInitialized)
					{
						this.EnsureCoreWebView2Async(null);
						return;
					}
					this.CoreWebView2.Navigate(value.AbsoluteUri);
					return;
				}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002848 File Offset: 0x00000A48
		private bool ShouldSerializeSource()
		{
			global::System.Uri source = this._source;
			int? num;
			if (source == null)
			{
				num = null;
			}
			else
			{
				string absoluteUri = source.AbsoluteUri;
				num = ((absoluteUri != null) ? new int?(absoluteUri.Length) : null);
			}
			int? num2 = num;
			return num2.GetValueOrDefault() > 0;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002893 File Offset: 0x00000A93
		private void ResetSource()
		{
			this._source = null;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0000289C File Offset: 0x00000A9C
		[global::System.ComponentModel.Browsable(false)]
		public bool CanGoForward
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2 coreWebView = this.CoreWebView2;
				return coreWebView != null && coreWebView.CanGoForward;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000028AF File Offset: 0x00000AAF
		[global::System.ComponentModel.Browsable(false)]
		public bool CanGoBack
		{
			get
			{
				global::Microsoft.Web.WebView2.Core.CoreWebView2 coreWebView = this.CoreWebView2;
				return coreWebView != null && coreWebView.CanGoBack;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000028C2 File Offset: 0x00000AC2
		// (set) Token: 0x0600002B RID: 43 RVA: 0x000028DE File Offset: 0x00000ADE
		public global::System.Drawing.Color DefaultBackgroundColor
		{
			get
			{
				if (this._coreWebView2Controller != null)
				{
					return this._coreWebView2Controller.DefaultBackgroundColor;
				}
				return this._defaultBackgroundColor;
			}
			set
			{
				if (this._coreWebView2Controller != null)
				{
					this._coreWebView2Controller.DefaultBackgroundColor = value;
					return;
				}
				this._defaultBackgroundColor = value;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000028FC File Offset: 0x00000AFC
		public global::System.Threading.Tasks.Task<string> ExecuteScriptAsync(string script)
		{
			global::Microsoft.Web.WebView2.WinForms.WebView2.<ExecuteScriptAsync>d__56 <ExecuteScriptAsync>d__;
			<ExecuteScriptAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string>.Create();
			<ExecuteScriptAsync>d__.<>4__this = this;
			<ExecuteScriptAsync>d__.script = script;
			<ExecuteScriptAsync>d__.<>1__state = -1;
			<ExecuteScriptAsync>d__.<>t__builder.Start<global::Microsoft.Web.WebView2.WinForms.WebView2.<ExecuteScriptAsync>d__56>(ref <ExecuteScriptAsync>d__);
			return <ExecuteScriptAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002947 File Offset: 0x00000B47
		public void Reload()
		{
			this.VerifyInitializedGuard();
			this.VerifyBrowserNotCrashedGuard();
			this.CoreWebView2.Reload();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002960 File Offset: 0x00000B60
		public void GoForward()
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2 coreWebView = this.CoreWebView2;
			if (coreWebView == null)
			{
				return;
			}
			coreWebView.GoForward();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002972 File Offset: 0x00000B72
		public void GoBack()
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2 coreWebView = this.CoreWebView2;
			if (coreWebView == null)
			{
				return;
			}
			coreWebView.GoBack();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002984 File Offset: 0x00000B84
		public void NavigateToString(string htmlContent)
		{
			this.VerifyInitializedGuard();
			this.VerifyBrowserNotCrashedGuard();
			this.CoreWebView2.NavigateToString(htmlContent);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000299E File Offset: 0x00000B9E
		public void Stop()
		{
			global::Microsoft.Web.WebView2.Core.CoreWebView2 coreWebView = this.CoreWebView2;
			if (coreWebView == null)
			{
				return;
			}
			coreWebView.Stop();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000029B0 File Offset: 0x00000BB0
		private void VerifyInitializedGuard()
		{
			if (!this.IsInitialized)
			{
				throw new global::System.InvalidOperationException("The instance of CoreWebView2 is uninitialized and unable to complete this operation. See EnsureCoreWebView2Async.");
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000029C5 File Offset: 0x00000BC5
		private void VerifyNotClosedGuard()
		{
			if (base.IsDisposed)
			{
				throw new global::System.InvalidOperationException("The instance of CoreWebView2 is disposed and unable to complete this operation.");
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000029DA File Offset: 0x00000BDA
		private void VerifyBrowserNotCrashedGuard()
		{
			if (this._browserCrashed)
			{
				throw new global::System.InvalidOperationException("The instance of CoreWebView2 is no longer valid because the browser process crashed.To work around this, please listen for the ProcessFailed event to explicitly manage the lifetime of the WebView2 control in the event of a browser failure.https://docs.microsoft.com/en-us/dotnet/api/microsoft.web.webview2.core.corewebview2.processfailed");
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000035 RID: 53 RVA: 0x000029F0 File Offset: 0x00000BF0
		// (remove) Token: 0x06000036 RID: 54 RVA: 0x00002A28 File Offset: 0x00000C28
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs> CoreWebView2InitializationCompleted;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000037 RID: 55 RVA: 0x00002A60 File Offset: 0x00000C60
		// (remove) Token: 0x06000038 RID: 56 RVA: 0x00002A98 File Offset: 0x00000C98
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs> NavigationStarting;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000039 RID: 57 RVA: 0x00002AD0 File Offset: 0x00000CD0
		// (remove) Token: 0x0600003A RID: 58 RVA: 0x00002B08 File Offset: 0x00000D08
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs> NavigationCompleted;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600003B RID: 59 RVA: 0x00002B40 File Offset: 0x00000D40
		// (remove) Token: 0x0600003C RID: 60 RVA: 0x00002B78 File Offset: 0x00000D78
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs> WebMessageReceived;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600003D RID: 61 RVA: 0x00002BB0 File Offset: 0x00000DB0
		// (remove) Token: 0x0600003E RID: 62 RVA: 0x00002BE8 File Offset: 0x00000DE8
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs> SourceChanged;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600003F RID: 63 RVA: 0x00002C20 File Offset: 0x00000E20
		// (remove) Token: 0x06000040 RID: 64 RVA: 0x00002C58 File Offset: 0x00000E58
		public event global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs> ContentLoading;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000041 RID: 65 RVA: 0x00002C90 File Offset: 0x00000E90
		// (remove) Token: 0x06000042 RID: 66 RVA: 0x00002CC8 File Offset: 0x00000EC8
		public event global::System.EventHandler<global::System.EventArgs> ZoomFactorChanged;

		// Token: 0x06000043 RID: 67 RVA: 0x00002CFD File Offset: 0x00000EFD
		private void CoreWebView2_NavigationStarting(object sender, global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs> navigationStarting = this.NavigationStarting;
			if (navigationStarting == null)
			{
				return;
			}
			navigationStarting(this, e);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002D11 File Offset: 0x00000F11
		private void CoreWebView2_NavigationCompleted(object sender, global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs> navigationCompleted = this.NavigationCompleted;
			if (navigationCompleted == null)
			{
				return;
			}
			navigationCompleted(this, e);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002D25 File Offset: 0x00000F25
		private void CoreWebView2_WebMessageReceived(object sender, global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs> webMessageReceived = this.WebMessageReceived;
			if (webMessageReceived == null)
			{
				return;
			}
			webMessageReceived(this, e);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002D39 File Offset: 0x00000F39
		private void CoreWebView2_SourceChanged(object sender, global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
		{
			this._source = new global::System.Uri(this.CoreWebView2.Source);
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs> sourceChanged = this.SourceChanged;
			if (sourceChanged == null)
			{
				return;
			}
			sourceChanged(this, e);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002D63 File Offset: 0x00000F63
		private void CoreWebView2_ContentLoading(object sender, global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs e)
		{
			global::System.EventHandler<global::Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs> contentLoading = this.ContentLoading;
			if (contentLoading == null)
			{
				return;
			}
			contentLoading(this, e);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002D77 File Offset: 0x00000F77
		private void CoreWebView2_ProcessFailed(object sender, global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedEventArgs e)
		{
			if (e.ProcessFailedKind == global::Microsoft.Web.WebView2.Core.CoreWebView2ProcessFailedKind.BrowserProcessExited)
			{
				this.UnsubscribeHandlersAndCloseController(true);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002D88 File Offset: 0x00000F88
		private void _coreWebView2Controller_ZoomFactorChanged(object sender, object e)
		{
			this._zoomFactor = this._coreWebView2Controller.ZoomFactor;
			global::System.EventHandler<global::System.EventArgs> zoomFactorChanged = this.ZoomFactorChanged;
			if (zoomFactorChanged == null)
			{
				return;
			}
			zoomFactorChanged(this, global::System.EventArgs.Empty);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002DB1 File Offset: 0x00000FB1
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Drawing.Font Font
		{
			get
			{
				return base.Font;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002DB9 File Offset: 0x00000FB9
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new string Text
		{
			get
			{
				return base.Text;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002DC1 File Offset: 0x00000FC1
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new bool AllowDrop
		{
			get
			{
				return base.AllowDrop;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002DC9 File Offset: 0x00000FC9
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Windows.Forms.ContextMenuStrip ContextMenuStrip
		{
			get
			{
				return base.ContextMenuStrip;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002DD1 File Offset: 0x00000FD1
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Windows.Forms.ContextMenu ContextMenu
		{
			get
			{
				return base.ContextMenu;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002DD9 File Offset: 0x00000FD9
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
		}

		// Token: 0x04000005 RID: 5
		private const string _designText = "WebView2";

		// Token: 0x04000006 RID: 6
		private const int _designBorderWidth = 2;

		// Token: 0x04000007 RID: 7
		private global::Microsoft.Web.WebView2.WinForms.CoreWebView2CreationProperties _creationProperties;

		// Token: 0x04000008 RID: 8
		internal global::System.Threading.Tasks.Task _initTask;

		// Token: 0x04000009 RID: 9
		private global::Microsoft.Web.WebView2.Core.CoreWebView2MoveFocusReason _lastMoveFocusReason;

		// Token: 0x0400000B RID: 11
		private global::Microsoft.Web.WebView2.Core.CoreWebView2Controller _coreWebView2Controller;

		// Token: 0x0400000C RID: 12
		private double _zoomFactor = 1.0;

		// Token: 0x0400000D RID: 13
		private bool _inInit;

		// Token: 0x0400000E RID: 14
		private global::System.Uri _source;

		// Token: 0x0400000F RID: 15
		private global::System.Drawing.Color _defaultBackgroundColor = global::System.Drawing.Color.White;

		// Token: 0x04000017 RID: 23
		private bool _browserCrashed;

		// Token: 0x04000018 RID: 24
		private global::System.ComponentModel.IContainer components;

		// Token: 0x02000004 RID: 4
		private static class NativeMethods
		{
			// Token: 0x06000050 RID: 80
			[global::System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
			public static extern global::System.IntPtr BeginPaint(global::System.IntPtr hwnd, out global::Microsoft.Web.WebView2.WinForms.WebView2.NativeMethods.PaintStruct lpPaint);

			// Token: 0x06000051 RID: 81
			[global::System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
			public static extern bool EndPaint(global::System.IntPtr hwnd, ref global::Microsoft.Web.WebView2.WinForms.WebView2.NativeMethods.PaintStruct lpPaint);

			// Token: 0x02000007 RID: 7
			[global::System.Flags]
			public enum WS_EX : uint
			{
				// Token: 0x04000025 RID: 37
				None = 0U,
				// Token: 0x04000026 RID: 38
				TRANSPARENT = 32U
			}

			// Token: 0x02000008 RID: 8
			public enum WM : uint
			{
				// Token: 0x04000028 RID: 40
				PAINT = 15U
			}

			// Token: 0x02000009 RID: 9
			public struct Rect
			{
				// Token: 0x04000029 RID: 41
				public int left;

				// Token: 0x0400002A RID: 42
				public int top;

				// Token: 0x0400002B RID: 43
				public int right;

				// Token: 0x0400002C RID: 44
				public int bottom;
			}

			// Token: 0x0200000A RID: 10
			public struct PaintStruct
			{
				// Token: 0x0400002D RID: 45
				public global::System.IntPtr hdc;

				// Token: 0x0400002E RID: 46
				public bool fErase;

				// Token: 0x0400002F RID: 47
				public global::Microsoft.Web.WebView2.WinForms.WebView2.NativeMethods.Rect rcPaint;

				// Token: 0x04000030 RID: 48
				public bool fRestore;

				// Token: 0x04000031 RID: 49
				public bool fIncUpdate;

				// Token: 0x04000032 RID: 50
				[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 32)]
				public byte[] rgbReserved;
			}
		}
	}
}
