using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Animation
{
	// Token: 0x0200037E RID: 894
	public class AnimationClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06001AF3 RID: 6899 RVA: 0x0001C711 File Offset: 0x0001A911
		public AnimationClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x140000B3 RID: 179
		// (add) Token: 0x06001AF4 RID: 6900 RVA: 0x0001C720 File Offset: 0x0001A920
		// (remove) Token: 0x06001AF5 RID: 6901 RVA: 0x0001C733 File Offset: 0x0001A933
		public event global::System.EventHandler<global::CefSharp.DevTools.Animation.AnimationCanceledEventArgs> AnimationCanceled
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Animation.AnimationCanceledEventArgs>("Animation.animationCanceled", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Animation.AnimationCanceledEventArgs>("Animation.animationCanceled", value);
			}
		}

		// Token: 0x140000B4 RID: 180
		// (add) Token: 0x06001AF6 RID: 6902 RVA: 0x0001C747 File Offset: 0x0001A947
		// (remove) Token: 0x06001AF7 RID: 6903 RVA: 0x0001C75A File Offset: 0x0001A95A
		public event global::System.EventHandler<global::CefSharp.DevTools.Animation.AnimationCreatedEventArgs> AnimationCreated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Animation.AnimationCreatedEventArgs>("Animation.animationCreated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Animation.AnimationCreatedEventArgs>("Animation.animationCreated", value);
			}
		}

		// Token: 0x140000B5 RID: 181
		// (add) Token: 0x06001AF8 RID: 6904 RVA: 0x0001C76E File Offset: 0x0001A96E
		// (remove) Token: 0x06001AF9 RID: 6905 RVA: 0x0001C781 File Offset: 0x0001A981
		public event global::System.EventHandler<global::CefSharp.DevTools.Animation.AnimationStartedEventArgs> AnimationStarted
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Animation.AnimationStartedEventArgs>("Animation.animationStarted", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Animation.AnimationStartedEventArgs>("Animation.animationStarted", value);
			}
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x0001C798 File Offset: 0x0001A998
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Animation.disable", parameters);
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x0001C7B8 File Offset: 0x0001A9B8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Animation.enable", parameters);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0001C7D8 File Offset: 0x0001A9D8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Animation.GetCurrentTimeResponse> GetCurrentTimeAsync(string id)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("id", id);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Animation.GetCurrentTimeResponse>("Animation.getCurrentTime", dictionary);
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0001C808 File Offset: 0x0001AA08
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Animation.GetPlaybackRateResponse> GetPlaybackRateAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Animation.GetPlaybackRateResponse>("Animation.getPlaybackRate", parameters);
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0001C828 File Offset: 0x0001AA28
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ReleaseAnimationsAsync(string[] animations)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("animations", animations);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Animation.releaseAnimations", dictionary);
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0001C858 File Offset: 0x0001AA58
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Animation.ResolveAnimationResponse> ResolveAnimationAsync(string animationId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("animationId", animationId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Animation.ResolveAnimationResponse>("Animation.resolveAnimation", dictionary);
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0001C888 File Offset: 0x0001AA88
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SeekAnimationsAsync(string[] animations, double currentTime)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("animations", animations);
			dictionary.Add("currentTime", currentTime);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Animation.seekAnimations", dictionary);
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x0001C8CC File Offset: 0x0001AACC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetPausedAsync(string[] animations, bool paused)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("animations", animations);
			dictionary.Add("paused", paused);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Animation.setPaused", dictionary);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0001C910 File Offset: 0x0001AB10
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetPlaybackRateAsync(double playbackRate)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("playbackRate", playbackRate);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Animation.setPlaybackRate", dictionary);
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x0001C948 File Offset: 0x0001AB48
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetTimingAsync(string animationId, double duration, double delay)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("animationId", animationId);
			dictionary.Add("duration", duration);
			dictionary.Add("delay", delay);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Animation.setTiming", dictionary);
		}

		// Token: 0x04000E5C RID: 3676
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
