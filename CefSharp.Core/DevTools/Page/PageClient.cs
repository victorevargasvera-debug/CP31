using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001BF RID: 447
	public class PageClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06000D1C RID: 3356 RVA: 0x0000EB3A File Offset: 0x0000CD3A
		public PageClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x14000054 RID: 84
		// (add) Token: 0x06000D1D RID: 3357 RVA: 0x0000EB49 File Offset: 0x0000CD49
		// (remove) Token: 0x06000D1E RID: 3358 RVA: 0x0000EB5C File Offset: 0x0000CD5C
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.DomContentEventFiredEventArgs> DomContentEventFired
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.DomContentEventFiredEventArgs>("Page.domContentEventFired", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.DomContentEventFiredEventArgs>("Page.domContentEventFired", value);
			}
		}

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x06000D1F RID: 3359 RVA: 0x0000EB70 File Offset: 0x0000CD70
		// (remove) Token: 0x06000D20 RID: 3360 RVA: 0x0000EB83 File Offset: 0x0000CD83
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.FileChooserOpenedEventArgs> FileChooserOpened
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.FileChooserOpenedEventArgs>("Page.fileChooserOpened", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.FileChooserOpenedEventArgs>("Page.fileChooserOpened", value);
			}
		}

		// Token: 0x14000056 RID: 86
		// (add) Token: 0x06000D21 RID: 3361 RVA: 0x0000EB97 File Offset: 0x0000CD97
		// (remove) Token: 0x06000D22 RID: 3362 RVA: 0x0000EBAA File Offset: 0x0000CDAA
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.FrameAttachedEventArgs> FrameAttached
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.FrameAttachedEventArgs>("Page.frameAttached", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.FrameAttachedEventArgs>("Page.frameAttached", value);
			}
		}

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x06000D23 RID: 3363 RVA: 0x0000EBBE File Offset: 0x0000CDBE
		// (remove) Token: 0x06000D24 RID: 3364 RVA: 0x0000EBD1 File Offset: 0x0000CDD1
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.FrameDetachedEventArgs> FrameDetached
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.FrameDetachedEventArgs>("Page.frameDetached", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.FrameDetachedEventArgs>("Page.frameDetached", value);
			}
		}

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x06000D25 RID: 3365 RVA: 0x0000EBE5 File Offset: 0x0000CDE5
		// (remove) Token: 0x06000D26 RID: 3366 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.FrameNavigatedEventArgs> FrameNavigated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.FrameNavigatedEventArgs>("Page.frameNavigated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.FrameNavigatedEventArgs>("Page.frameNavigated", value);
			}
		}

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x06000D27 RID: 3367 RVA: 0x0000EC0C File Offset: 0x0000CE0C
		// (remove) Token: 0x06000D28 RID: 3368 RVA: 0x0000EC1F File Offset: 0x0000CE1F
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.DocumentOpenedEventArgs> DocumentOpened
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.DocumentOpenedEventArgs>("Page.documentOpened", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.DocumentOpenedEventArgs>("Page.documentOpened", value);
			}
		}

		// Token: 0x1400005A RID: 90
		// (add) Token: 0x06000D29 RID: 3369 RVA: 0x0000EC33 File Offset: 0x0000CE33
		// (remove) Token: 0x06000D2A RID: 3370 RVA: 0x0000EC46 File Offset: 0x0000CE46
		public event global::System.EventHandler<global::System.EventArgs> FrameResized
		{
			add
			{
				this._client.AddEventHandler<global::System.EventArgs>("Page.frameResized", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::System.EventArgs>("Page.frameResized", value);
			}
		}

		// Token: 0x1400005B RID: 91
		// (add) Token: 0x06000D2B RID: 3371 RVA: 0x0000EC5A File Offset: 0x0000CE5A
		// (remove) Token: 0x06000D2C RID: 3372 RVA: 0x0000EC6D File Offset: 0x0000CE6D
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.FrameRequestedNavigationEventArgs> FrameRequestedNavigation
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.FrameRequestedNavigationEventArgs>("Page.frameRequestedNavigation", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.FrameRequestedNavigationEventArgs>("Page.frameRequestedNavigation", value);
			}
		}

		// Token: 0x1400005C RID: 92
		// (add) Token: 0x06000D2D RID: 3373 RVA: 0x0000EC81 File Offset: 0x0000CE81
		// (remove) Token: 0x06000D2E RID: 3374 RVA: 0x0000EC94 File Offset: 0x0000CE94
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.FrameStartedLoadingEventArgs> FrameStartedLoading
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.FrameStartedLoadingEventArgs>("Page.frameStartedLoading", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.FrameStartedLoadingEventArgs>("Page.frameStartedLoading", value);
			}
		}

		// Token: 0x1400005D RID: 93
		// (add) Token: 0x06000D2F RID: 3375 RVA: 0x0000ECA8 File Offset: 0x0000CEA8
		// (remove) Token: 0x06000D30 RID: 3376 RVA: 0x0000ECBB File Offset: 0x0000CEBB
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.FrameStoppedLoadingEventArgs> FrameStoppedLoading
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.FrameStoppedLoadingEventArgs>("Page.frameStoppedLoading", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.FrameStoppedLoadingEventArgs>("Page.frameStoppedLoading", value);
			}
		}

		// Token: 0x1400005E RID: 94
		// (add) Token: 0x06000D31 RID: 3377 RVA: 0x0000ECCF File Offset: 0x0000CECF
		// (remove) Token: 0x06000D32 RID: 3378 RVA: 0x0000ECE2 File Offset: 0x0000CEE2
		public event global::System.EventHandler<global::System.EventArgs> InterstitialHidden
		{
			add
			{
				this._client.AddEventHandler<global::System.EventArgs>("Page.interstitialHidden", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::System.EventArgs>("Page.interstitialHidden", value);
			}
		}

		// Token: 0x1400005F RID: 95
		// (add) Token: 0x06000D33 RID: 3379 RVA: 0x0000ECF6 File Offset: 0x0000CEF6
		// (remove) Token: 0x06000D34 RID: 3380 RVA: 0x0000ED09 File Offset: 0x0000CF09
		public event global::System.EventHandler<global::System.EventArgs> InterstitialShown
		{
			add
			{
				this._client.AddEventHandler<global::System.EventArgs>("Page.interstitialShown", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::System.EventArgs>("Page.interstitialShown", value);
			}
		}

		// Token: 0x14000060 RID: 96
		// (add) Token: 0x06000D35 RID: 3381 RVA: 0x0000ED1D File Offset: 0x0000CF1D
		// (remove) Token: 0x06000D36 RID: 3382 RVA: 0x0000ED30 File Offset: 0x0000CF30
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.JavascriptDialogClosedEventArgs> JavascriptDialogClosed
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.JavascriptDialogClosedEventArgs>("Page.javascriptDialogClosed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.JavascriptDialogClosedEventArgs>("Page.javascriptDialogClosed", value);
			}
		}

		// Token: 0x14000061 RID: 97
		// (add) Token: 0x06000D37 RID: 3383 RVA: 0x0000ED44 File Offset: 0x0000CF44
		// (remove) Token: 0x06000D38 RID: 3384 RVA: 0x0000ED57 File Offset: 0x0000CF57
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.JavascriptDialogOpeningEventArgs> JavascriptDialogOpening
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.JavascriptDialogOpeningEventArgs>("Page.javascriptDialogOpening", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.JavascriptDialogOpeningEventArgs>("Page.javascriptDialogOpening", value);
			}
		}

		// Token: 0x14000062 RID: 98
		// (add) Token: 0x06000D39 RID: 3385 RVA: 0x0000ED6B File Offset: 0x0000CF6B
		// (remove) Token: 0x06000D3A RID: 3386 RVA: 0x0000ED7E File Offset: 0x0000CF7E
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.LifecycleEventEventArgs> LifecycleEvent
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.LifecycleEventEventArgs>("Page.lifecycleEvent", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.LifecycleEventEventArgs>("Page.lifecycleEvent", value);
			}
		}

		// Token: 0x14000063 RID: 99
		// (add) Token: 0x06000D3B RID: 3387 RVA: 0x0000ED92 File Offset: 0x0000CF92
		// (remove) Token: 0x06000D3C RID: 3388 RVA: 0x0000EDA5 File Offset: 0x0000CFA5
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.BackForwardCacheNotUsedEventArgs> BackForwardCacheNotUsed
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.BackForwardCacheNotUsedEventArgs>("Page.backForwardCacheNotUsed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.BackForwardCacheNotUsedEventArgs>("Page.backForwardCacheNotUsed", value);
			}
		}

		// Token: 0x14000064 RID: 100
		// (add) Token: 0x06000D3D RID: 3389 RVA: 0x0000EDB9 File Offset: 0x0000CFB9
		// (remove) Token: 0x06000D3E RID: 3390 RVA: 0x0000EDCC File Offset: 0x0000CFCC
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.LoadEventFiredEventArgs> LoadEventFired
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.LoadEventFiredEventArgs>("Page.loadEventFired", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.LoadEventFiredEventArgs>("Page.loadEventFired", value);
			}
		}

		// Token: 0x14000065 RID: 101
		// (add) Token: 0x06000D3F RID: 3391 RVA: 0x0000EDE0 File Offset: 0x0000CFE0
		// (remove) Token: 0x06000D40 RID: 3392 RVA: 0x0000EDF3 File Offset: 0x0000CFF3
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.NavigatedWithinDocumentEventArgs> NavigatedWithinDocument
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.NavigatedWithinDocumentEventArgs>("Page.navigatedWithinDocument", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.NavigatedWithinDocumentEventArgs>("Page.navigatedWithinDocument", value);
			}
		}

		// Token: 0x14000066 RID: 102
		// (add) Token: 0x06000D41 RID: 3393 RVA: 0x0000EE07 File Offset: 0x0000D007
		// (remove) Token: 0x06000D42 RID: 3394 RVA: 0x0000EE1A File Offset: 0x0000D01A
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.ScreencastFrameEventArgs> ScreencastFrame
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.ScreencastFrameEventArgs>("Page.screencastFrame", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.ScreencastFrameEventArgs>("Page.screencastFrame", value);
			}
		}

		// Token: 0x14000067 RID: 103
		// (add) Token: 0x06000D43 RID: 3395 RVA: 0x0000EE2E File Offset: 0x0000D02E
		// (remove) Token: 0x06000D44 RID: 3396 RVA: 0x0000EE41 File Offset: 0x0000D041
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.ScreencastVisibilityChangedEventArgs> ScreencastVisibilityChanged
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.ScreencastVisibilityChangedEventArgs>("Page.screencastVisibilityChanged", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.ScreencastVisibilityChangedEventArgs>("Page.screencastVisibilityChanged", value);
			}
		}

		// Token: 0x14000068 RID: 104
		// (add) Token: 0x06000D45 RID: 3397 RVA: 0x0000EE55 File Offset: 0x0000D055
		// (remove) Token: 0x06000D46 RID: 3398 RVA: 0x0000EE68 File Offset: 0x0000D068
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.WindowOpenEventArgs> WindowOpen
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.WindowOpenEventArgs>("Page.windowOpen", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.WindowOpenEventArgs>("Page.windowOpen", value);
			}
		}

		// Token: 0x14000069 RID: 105
		// (add) Token: 0x06000D47 RID: 3399 RVA: 0x0000EE7C File Offset: 0x0000D07C
		// (remove) Token: 0x06000D48 RID: 3400 RVA: 0x0000EE8F File Offset: 0x0000D08F
		public event global::System.EventHandler<global::CefSharp.DevTools.Page.CompilationCacheProducedEventArgs> CompilationCacheProduced
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Page.CompilationCacheProducedEventArgs>("Page.compilationCacheProduced", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Page.CompilationCacheProducedEventArgs>("Page.compilationCacheProduced", value);
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0000EEA4 File Offset: 0x0000D0A4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.AddScriptToEvaluateOnNewDocumentResponse> AddScriptToEvaluateOnNewDocumentAsync(string source, string worldName = null, bool? includeCommandLineAPI = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("source", source);
			if (!string.IsNullOrEmpty(worldName))
			{
				dictionary.Add("worldName", worldName);
			}
			if (includeCommandLineAPI != null)
			{
				dictionary.Add("includeCommandLineAPI", includeCommandLineAPI.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.AddScriptToEvaluateOnNewDocumentResponse>("Page.addScriptToEvaluateOnNewDocument", dictionary);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0000EF08 File Offset: 0x0000D108
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> BringToFrontAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.bringToFront", parameters);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x0000EF28 File Offset: 0x0000D128
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.CaptureScreenshotResponse> CaptureScreenshotAsync(global::CefSharp.DevTools.Page.CaptureScreenshotFormat? format = null, int? quality = null, global::CefSharp.DevTools.Page.Viewport clip = null, bool? fromSurface = null, bool? captureBeyondViewport = null, bool? optimizeForSpeed = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (format != null)
			{
				dictionary.Add("format", base.EnumToString(format));
			}
			if (quality != null)
			{
				dictionary.Add("quality", quality.Value);
			}
			if (clip != null)
			{
				dictionary.Add("clip", clip.ToDictionary());
			}
			if (fromSurface != null)
			{
				dictionary.Add("fromSurface", fromSurface.Value);
			}
			if (captureBeyondViewport != null)
			{
				dictionary.Add("captureBeyondViewport", captureBeyondViewport.Value);
			}
			if (optimizeForSpeed != null)
			{
				dictionary.Add("optimizeForSpeed", optimizeForSpeed.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.CaptureScreenshotResponse>("Page.captureScreenshot", dictionary);
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x0000F000 File Offset: 0x0000D200
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.CaptureSnapshotResponse> CaptureSnapshotAsync(global::CefSharp.DevTools.Page.CaptureSnapshotFormat? format = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (format != null)
			{
				dictionary.Add("format", base.EnumToString(format));
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.CaptureSnapshotResponse>("Page.captureSnapshot", dictionary);
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x0000F044 File Offset: 0x0000D244
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.CreateIsolatedWorldResponse> CreateIsolatedWorldAsync(string frameId, string worldName = null, bool? grantUniveralAccess = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("frameId", frameId);
			if (!string.IsNullOrEmpty(worldName))
			{
				dictionary.Add("worldName", worldName);
			}
			if (grantUniveralAccess != null)
			{
				dictionary.Add("grantUniveralAccess", grantUniveralAccess.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.CreateIsolatedWorldResponse>("Page.createIsolatedWorld", dictionary);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x0000F0A8 File Offset: 0x0000D2A8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.disable", parameters);
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0000F0C8 File Offset: 0x0000D2C8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.enable", parameters);
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x0000F0E8 File Offset: 0x0000D2E8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.GetAppManifestResponse> GetAppManifestAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.GetAppManifestResponse>("Page.getAppManifest", parameters);
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x0000F108 File Offset: 0x0000D308
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.GetInstallabilityErrorsResponse> GetInstallabilityErrorsAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.GetInstallabilityErrorsResponse>("Page.getInstallabilityErrors", parameters);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x0000F128 File Offset: 0x0000D328
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.GetAppIdResponse> GetAppIdAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.GetAppIdResponse>("Page.getAppId", parameters);
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x0000F148 File Offset: 0x0000D348
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.GetAdScriptIdResponse> GetAdScriptIdAsync(string frameId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("frameId", frameId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.GetAdScriptIdResponse>("Page.getAdScriptId", dictionary);
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x0000F178 File Offset: 0x0000D378
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.GetFrameTreeResponse> GetFrameTreeAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.GetFrameTreeResponse>("Page.getFrameTree", parameters);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0000F198 File Offset: 0x0000D398
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.GetLayoutMetricsResponse> GetLayoutMetricsAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.GetLayoutMetricsResponse>("Page.getLayoutMetrics", parameters);
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0000F1B8 File Offset: 0x0000D3B8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.GetNavigationHistoryResponse> GetNavigationHistoryAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.GetNavigationHistoryResponse>("Page.getNavigationHistory", parameters);
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0000F1D8 File Offset: 0x0000D3D8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ResetNavigationHistoryAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.resetNavigationHistory", parameters);
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.GetResourceContentResponse> GetResourceContentAsync(string frameId, string url)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("frameId", frameId);
			dictionary.Add("url", url);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.GetResourceContentResponse>("Page.getResourceContent", dictionary);
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x0000F234 File Offset: 0x0000D434
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.GetResourceTreeResponse> GetResourceTreeAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.GetResourceTreeResponse>("Page.getResourceTree", parameters);
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x0000F254 File Offset: 0x0000D454
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> HandleJavaScriptDialogAsync(bool accept, string promptText = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("accept", accept);
			if (!string.IsNullOrEmpty(promptText))
			{
				dictionary.Add("promptText", promptText);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.handleJavaScriptDialog", dictionary);
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.NavigateResponse> NavigateAsync(string url, string referrer = null, global::CefSharp.DevTools.Page.TransitionType? transitionType = null, string frameId = null, global::CefSharp.DevTools.Page.ReferrerPolicy? referrerPolicy = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("url", url);
			if (!string.IsNullOrEmpty(referrer))
			{
				dictionary.Add("referrer", referrer);
			}
			if (transitionType != null)
			{
				dictionary.Add("transitionType", base.EnumToString(transitionType));
			}
			if (!string.IsNullOrEmpty(frameId))
			{
				dictionary.Add("frameId", frameId);
			}
			if (referrerPolicy != null)
			{
				dictionary.Add("referrerPolicy", base.EnumToString(referrerPolicy));
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.NavigateResponse>("Page.navigate", dictionary);
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0000F33C File Offset: 0x0000D53C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> NavigateToHistoryEntryAsync(int entryId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("entryId", entryId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.navigateToHistoryEntry", dictionary);
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x0000F374 File Offset: 0x0000D574
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.PrintToPDFResponse> PrintToPDFAsync(bool? landscape = null, bool? displayHeaderFooter = null, bool? printBackground = null, double? scale = null, double? paperWidth = null, double? paperHeight = null, double? marginTop = null, double? marginBottom = null, double? marginLeft = null, double? marginRight = null, string pageRanges = null, string headerTemplate = null, string footerTemplate = null, bool? preferCSSPageSize = null, global::CefSharp.DevTools.Page.PrintToPDFTransferMode? transferMode = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (landscape != null)
			{
				dictionary.Add("landscape", landscape.Value);
			}
			if (displayHeaderFooter != null)
			{
				dictionary.Add("displayHeaderFooter", displayHeaderFooter.Value);
			}
			if (printBackground != null)
			{
				dictionary.Add("printBackground", printBackground.Value);
			}
			if (scale != null)
			{
				dictionary.Add("scale", scale.Value);
			}
			if (paperWidth != null)
			{
				dictionary.Add("paperWidth", paperWidth.Value);
			}
			if (paperHeight != null)
			{
				dictionary.Add("paperHeight", paperHeight.Value);
			}
			if (marginTop != null)
			{
				dictionary.Add("marginTop", marginTop.Value);
			}
			if (marginBottom != null)
			{
				dictionary.Add("marginBottom", marginBottom.Value);
			}
			if (marginLeft != null)
			{
				dictionary.Add("marginLeft", marginLeft.Value);
			}
			if (marginRight != null)
			{
				dictionary.Add("marginRight", marginRight.Value);
			}
			if (!string.IsNullOrEmpty(pageRanges))
			{
				dictionary.Add("pageRanges", pageRanges);
			}
			if (!string.IsNullOrEmpty(headerTemplate))
			{
				dictionary.Add("headerTemplate", headerTemplate);
			}
			if (!string.IsNullOrEmpty(footerTemplate))
			{
				dictionary.Add("footerTemplate", footerTemplate);
			}
			if (preferCSSPageSize != null)
			{
				dictionary.Add("preferCSSPageSize", preferCSSPageSize.Value);
			}
			if (transferMode != null)
			{
				dictionary.Add("transferMode", base.EnumToString(transferMode));
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.PrintToPDFResponse>("Page.printToPDF", dictionary);
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x0000F55C File Offset: 0x0000D75C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ReloadAsync(bool? ignoreCache = null, string scriptToEvaluateOnLoad = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (ignoreCache != null)
			{
				dictionary.Add("ignoreCache", ignoreCache.Value);
			}
			if (!string.IsNullOrEmpty(scriptToEvaluateOnLoad))
			{
				dictionary.Add("scriptToEvaluateOnLoad", scriptToEvaluateOnLoad);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.reload", dictionary);
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x0000F5B4 File Offset: 0x0000D7B4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> RemoveScriptToEvaluateOnNewDocumentAsync(string identifier)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("identifier", identifier);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.removeScriptToEvaluateOnNewDocument", dictionary);
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x0000F5E4 File Offset: 0x0000D7E4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ScreencastFrameAckAsync(int sessionId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("sessionId", sessionId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.screencastFrameAck", dictionary);
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0000F61C File Offset: 0x0000D81C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.SearchInResourceResponse> SearchInResourceAsync(string frameId, string url, string query, bool? caseSensitive = null, bool? isRegex = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("frameId", frameId);
			dictionary.Add("url", url);
			dictionary.Add("query", query);
			if (caseSensitive != null)
			{
				dictionary.Add("caseSensitive", caseSensitive.Value);
			}
			if (isRegex != null)
			{
				dictionary.Add("isRegex", isRegex.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.SearchInResourceResponse>("Page.searchInResource", dictionary);
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0000F6A4 File Offset: 0x0000D8A4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetAdBlockingEnabledAsync(bool enabled)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("enabled", enabled);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.setAdBlockingEnabled", dictionary);
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x0000F6DC File Offset: 0x0000D8DC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetBypassCSPAsync(bool enabled)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("enabled", enabled);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.setBypassCSP", dictionary);
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x0000F714 File Offset: 0x0000D914
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.GetPermissionsPolicyStateResponse> GetPermissionsPolicyStateAsync(string frameId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("frameId", frameId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.GetPermissionsPolicyStateResponse>("Page.getPermissionsPolicyState", dictionary);
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0000F744 File Offset: 0x0000D944
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Page.GetOriginTrialsResponse> GetOriginTrialsAsync(string frameId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("frameId", frameId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Page.GetOriginTrialsResponse>("Page.getOriginTrials", dictionary);
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0000F774 File Offset: 0x0000D974
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetFontFamiliesAsync(global::CefSharp.DevTools.Page.FontFamilies fontFamilies, global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.ScriptFontFamilies> forScripts = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("fontFamilies", fontFamilies.ToDictionary());
			if (forScripts != null)
			{
				dictionary.Add("forScripts", from x in forScripts
				select x.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.setFontFamilies", dictionary);
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0000F7DC File Offset: 0x0000D9DC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetFontSizesAsync(global::CefSharp.DevTools.Page.FontSizes fontSizes)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("fontSizes", fontSizes.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.setFontSizes", dictionary);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0000F814 File Offset: 0x0000DA14
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetDocumentContentAsync(string frameId, string html)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("frameId", frameId);
			dictionary.Add("html", html);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.setDocumentContent", dictionary);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0000F850 File Offset: 0x0000DA50
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetLifecycleEventsEnabledAsync(bool enabled)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("enabled", enabled);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.setLifecycleEventsEnabled", dictionary);
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0000F888 File Offset: 0x0000DA88
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StartScreencastAsync(global::CefSharp.DevTools.Page.StartScreencastFormat? format = null, int? quality = null, int? maxWidth = null, int? maxHeight = null, int? everyNthFrame = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (format != null)
			{
				dictionary.Add("format", base.EnumToString(format));
			}
			if (quality != null)
			{
				dictionary.Add("quality", quality.Value);
			}
			if (maxWidth != null)
			{
				dictionary.Add("maxWidth", maxWidth.Value);
			}
			if (maxHeight != null)
			{
				dictionary.Add("maxHeight", maxHeight.Value);
			}
			if (everyNthFrame != null)
			{
				dictionary.Add("everyNthFrame", everyNthFrame.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.startScreencast", dictionary);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0000F94C File Offset: 0x0000DB4C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StopLoadingAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.stopLoading", parameters);
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x0000F96C File Offset: 0x0000DB6C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> CrashAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.crash", parameters);
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x0000F98C File Offset: 0x0000DB8C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> CloseAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.close", parameters);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0000F9AC File Offset: 0x0000DBAC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetWebLifecycleStateAsync(global::CefSharp.DevTools.Page.SetWebLifecycleStateState state)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("state", base.EnumToString(state));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.setWebLifecycleState", dictionary);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0000F9E8 File Offset: 0x0000DBE8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StopScreencastAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.stopScreencast", parameters);
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0000FA08 File Offset: 0x0000DC08
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ProduceCompilationCacheAsync(global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.CompilationCacheParams> scripts)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("scripts", from x in scripts
			select x.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.produceCompilationCache", dictionary);
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0000FA5C File Offset: 0x0000DC5C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> AddCompilationCacheAsync(string url, byte[] data)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("url", url);
			dictionary.Add("data", base.ToBase64String(data));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.addCompilationCache", dictionary);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0000FAA0 File Offset: 0x0000DCA0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ClearCompilationCacheAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.clearCompilationCache", parameters);
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x0000FAC0 File Offset: 0x0000DCC0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetSPCTransactionModeAsync(global::CefSharp.DevTools.Page.AutoResponseMode mode)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("mode", base.EnumToString(mode));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.setSPCTransactionMode", dictionary);
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x0000FAFC File Offset: 0x0000DCFC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetRPHRegistrationModeAsync(global::CefSharp.DevTools.Page.AutoResponseMode mode)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("mode", base.EnumToString(mode));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.setRPHRegistrationMode", dictionary);
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x0000FB38 File Offset: 0x0000DD38
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> GenerateTestReportAsync(string message, string group = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("message", message);
			if (!string.IsNullOrEmpty(group))
			{
				dictionary.Add("group", group);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.generateTestReport", dictionary);
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0000FB7C File Offset: 0x0000DD7C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> WaitForDebuggerAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.waitForDebugger", parameters);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetInterceptFileChooserDialogAsync(bool enabled)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("enabled", enabled);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Page.setInterceptFileChooserDialog", dictionary);
		}

		// Token: 0x04000706 RID: 1798
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
