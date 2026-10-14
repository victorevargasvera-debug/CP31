using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CefSharp.DevTools.DOM;
using CefSharp.DevTools.Page;

namespace CefSharp.DevTools.Emulation
{
	// Token: 0x02000290 RID: 656
	public class EmulationClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x060013C4 RID: 5060 RVA: 0x00015CAD File Offset: 0x00013EAD
		public EmulationClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x14000092 RID: 146
		// (add) Token: 0x060013C5 RID: 5061 RVA: 0x00015CBC File Offset: 0x00013EBC
		// (remove) Token: 0x060013C6 RID: 5062 RVA: 0x00015CCF File Offset: 0x00013ECF
		public event global::System.EventHandler<global::System.EventArgs> VirtualTimeBudgetExpired
		{
			add
			{
				this._client.AddEventHandler<global::System.EventArgs>("Emulation.virtualTimeBudgetExpired", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::System.EventArgs>("Emulation.virtualTimeBudgetExpired", value);
			}
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00015CE4 File Offset: 0x00013EE4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Emulation.CanEmulateResponse> CanEmulateAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Emulation.CanEmulateResponse>("Emulation.canEmulate", parameters);
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x00015D04 File Offset: 0x00013F04
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ClearDeviceMetricsOverrideAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.clearDeviceMetricsOverride", parameters);
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x00015D24 File Offset: 0x00013F24
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ClearGeolocationOverrideAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.clearGeolocationOverride", parameters);
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x00015D44 File Offset: 0x00013F44
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ResetPageScaleFactorAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.resetPageScaleFactor", parameters);
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00015D64 File Offset: 0x00013F64
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetFocusEmulationEnabledAsync(bool enabled)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("enabled", enabled);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setFocusEmulationEnabled", dictionary);
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x00015D9C File Offset: 0x00013F9C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetAutoDarkModeOverrideAsync(bool? enabled = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (enabled != null)
			{
				dictionary.Add("enabled", enabled.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setAutoDarkModeOverride", dictionary);
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x00015DE0 File Offset: 0x00013FE0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetCPUThrottlingRateAsync(double rate)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("rate", rate);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setCPUThrottlingRate", dictionary);
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x00015E18 File Offset: 0x00014018
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetDefaultBackgroundColorOverrideAsync(global::CefSharp.DevTools.DOM.RGBA color = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (color != null)
			{
				dictionary.Add("color", color.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setDefaultBackgroundColorOverride", dictionary);
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x00015E50 File Offset: 0x00014050
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetDeviceMetricsOverrideAsync(int width, int height, double deviceScaleFactor, bool mobile, double? scale = null, int? screenWidth = null, int? screenHeight = null, int? positionX = null, int? positionY = null, bool? dontSetVisibleSize = null, global::CefSharp.DevTools.Emulation.ScreenOrientation screenOrientation = null, global::CefSharp.DevTools.Page.Viewport viewport = null, global::CefSharp.DevTools.Emulation.DisplayFeature displayFeature = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("width", width);
			dictionary.Add("height", height);
			dictionary.Add("deviceScaleFactor", deviceScaleFactor);
			dictionary.Add("mobile", mobile);
			if (scale != null)
			{
				dictionary.Add("scale", scale.Value);
			}
			if (screenWidth != null)
			{
				dictionary.Add("screenWidth", screenWidth.Value);
			}
			if (screenHeight != null)
			{
				dictionary.Add("screenHeight", screenHeight.Value);
			}
			if (positionX != null)
			{
				dictionary.Add("positionX", positionX.Value);
			}
			if (positionY != null)
			{
				dictionary.Add("positionY", positionY.Value);
			}
			if (dontSetVisibleSize != null)
			{
				dictionary.Add("dontSetVisibleSize", dontSetVisibleSize.Value);
			}
			if (screenOrientation != null)
			{
				dictionary.Add("screenOrientation", screenOrientation.ToDictionary());
			}
			if (viewport != null)
			{
				dictionary.Add("viewport", viewport.ToDictionary());
			}
			if (displayFeature != null)
			{
				dictionary.Add("displayFeature", displayFeature.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setDeviceMetricsOverride", dictionary);
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x00015FBC File Offset: 0x000141BC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetScrollbarsHiddenAsync(bool hidden)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("hidden", hidden);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setScrollbarsHidden", dictionary);
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x00015FF4 File Offset: 0x000141F4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetDocumentCookieDisabledAsync(bool disabled)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("disabled", disabled);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setDocumentCookieDisabled", dictionary);
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x0001602C File Offset: 0x0001422C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetEmitTouchEventsForMouseAsync(bool enabled, global::CefSharp.DevTools.Emulation.SetEmitTouchEventsForMouseConfiguration? configuration = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("enabled", enabled);
			if (configuration != null)
			{
				dictionary.Add("configuration", base.EnumToString(configuration));
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setEmitTouchEventsForMouse", dictionary);
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x00016084 File Offset: 0x00014284
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetEmulatedMediaAsync(string media = null, global::System.Collections.Generic.IList<global::CefSharp.DevTools.Emulation.MediaFeature> features = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (!string.IsNullOrEmpty(media))
			{
				dictionary.Add("media", media);
			}
			if (features != null)
			{
				dictionary.Add("features", from x in features
				select x.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setEmulatedMedia", dictionary);
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x000160F0 File Offset: 0x000142F0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetEmulatedVisionDeficiencyAsync(global::CefSharp.DevTools.Emulation.SetEmulatedVisionDeficiencyType type)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("type", base.EnumToString(type));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setEmulatedVisionDeficiency", dictionary);
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0001612C File Offset: 0x0001432C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetGeolocationOverrideAsync(double? latitude = null, double? longitude = null, double? accuracy = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (latitude != null)
			{
				dictionary.Add("latitude", latitude.Value);
			}
			if (longitude != null)
			{
				dictionary.Add("longitude", longitude.Value);
			}
			if (accuracy != null)
			{
				dictionary.Add("accuracy", accuracy.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setGeolocationOverride", dictionary);
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x000161B0 File Offset: 0x000143B0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetIdleOverrideAsync(bool isUserActive, bool isScreenUnlocked)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("isUserActive", isUserActive);
			dictionary.Add("isScreenUnlocked", isScreenUnlocked);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setIdleOverride", dictionary);
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x000161F8 File Offset: 0x000143F8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ClearIdleOverrideAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.clearIdleOverride", parameters);
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00016218 File Offset: 0x00014418
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetPageScaleFactorAsync(double pageScaleFactor)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("pageScaleFactor", pageScaleFactor);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setPageScaleFactor", dictionary);
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00016250 File Offset: 0x00014450
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetScriptExecutionDisabledAsync(bool value)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("value", value);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setScriptExecutionDisabled", dictionary);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00016288 File Offset: 0x00014488
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetTouchEmulationEnabledAsync(bool enabled, int? maxTouchPoints = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("enabled", enabled);
			if (maxTouchPoints != null)
			{
				dictionary.Add("maxTouchPoints", maxTouchPoints.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setTouchEmulationEnabled", dictionary);
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x000162E0 File Offset: 0x000144E0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Emulation.SetVirtualTimePolicyResponse> SetVirtualTimePolicyAsync(global::CefSharp.DevTools.Emulation.VirtualTimePolicy policy, double? budget = null, int? maxVirtualTimeTaskStarvationCount = null, double? initialVirtualTime = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("policy", base.EnumToString(policy));
			if (budget != null)
			{
				dictionary.Add("budget", budget.Value);
			}
			if (maxVirtualTimeTaskStarvationCount != null)
			{
				dictionary.Add("maxVirtualTimeTaskStarvationCount", maxVirtualTimeTaskStarvationCount.Value);
			}
			if (initialVirtualTime != null)
			{
				dictionary.Add("initialVirtualTime", initialVirtualTime.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Emulation.SetVirtualTimePolicyResponse>("Emulation.setVirtualTimePolicy", dictionary);
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0001637C File Offset: 0x0001457C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetLocaleOverrideAsync(string locale = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (!string.IsNullOrEmpty(locale))
			{
				dictionary.Add("locale", locale);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setLocaleOverride", dictionary);
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x000163B4 File Offset: 0x000145B4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetTimezoneOverrideAsync(string timezoneId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("timezoneId", timezoneId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setTimezoneOverride", dictionary);
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x000163E4 File Offset: 0x000145E4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetDisabledImageTypesAsync(global::CefSharp.DevTools.Emulation.DisabledImageType[] imageTypes)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("imageTypes", base.EnumToString(imageTypes));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setDisabledImageTypes", dictionary);
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0001641C File Offset: 0x0001461C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetHardwareConcurrencyOverrideAsync(int hardwareConcurrency)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("hardwareConcurrency", hardwareConcurrency);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setHardwareConcurrencyOverride", dictionary);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00016454 File Offset: 0x00014654
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetUserAgentOverrideAsync(string userAgent, string acceptLanguage = null, string platform = null, global::CefSharp.DevTools.Emulation.UserAgentMetadata userAgentMetadata = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("userAgent", userAgent);
			if (!string.IsNullOrEmpty(acceptLanguage))
			{
				dictionary.Add("acceptLanguage", acceptLanguage);
			}
			if (!string.IsNullOrEmpty(platform))
			{
				dictionary.Add("platform", platform);
			}
			if (userAgentMetadata != null)
			{
				dictionary.Add("userAgentMetadata", userAgentMetadata.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setUserAgentOverride", dictionary);
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x000164C4 File Offset: 0x000146C4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetAutomationOverrideAsync(bool enabled)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("enabled", enabled);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Emulation.setAutomationOverride", dictionary);
		}

		// Token: 0x04000AB9 RID: 2745
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
