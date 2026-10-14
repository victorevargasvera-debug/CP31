using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000E2 RID: 226
	public class WebAudioClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06000751 RID: 1873 RVA: 0x00009D35 File Offset: 0x00007F35
		public WebAudioClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06000752 RID: 1874 RVA: 0x00009D44 File Offset: 0x00007F44
		// (remove) Token: 0x06000753 RID: 1875 RVA: 0x00009D57 File Offset: 0x00007F57
		public event global::System.EventHandler<global::CefSharp.DevTools.WebAudio.ContextCreatedEventArgs> ContextCreated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.WebAudio.ContextCreatedEventArgs>("WebAudio.contextCreated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.WebAudio.ContextCreatedEventArgs>("WebAudio.contextCreated", value);
			}
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06000754 RID: 1876 RVA: 0x00009D6B File Offset: 0x00007F6B
		// (remove) Token: 0x06000755 RID: 1877 RVA: 0x00009D7E File Offset: 0x00007F7E
		public event global::System.EventHandler<global::CefSharp.DevTools.WebAudio.ContextWillBeDestroyedEventArgs> ContextWillBeDestroyed
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.WebAudio.ContextWillBeDestroyedEventArgs>("WebAudio.contextWillBeDestroyed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.WebAudio.ContextWillBeDestroyedEventArgs>("WebAudio.contextWillBeDestroyed", value);
			}
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06000756 RID: 1878 RVA: 0x00009D92 File Offset: 0x00007F92
		// (remove) Token: 0x06000757 RID: 1879 RVA: 0x00009DA5 File Offset: 0x00007FA5
		public event global::System.EventHandler<global::CefSharp.DevTools.WebAudio.ContextChangedEventArgs> ContextChanged
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.WebAudio.ContextChangedEventArgs>("WebAudio.contextChanged", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.WebAudio.ContextChangedEventArgs>("WebAudio.contextChanged", value);
			}
		}

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06000758 RID: 1880 RVA: 0x00009DB9 File Offset: 0x00007FB9
		// (remove) Token: 0x06000759 RID: 1881 RVA: 0x00009DCC File Offset: 0x00007FCC
		public event global::System.EventHandler<global::CefSharp.DevTools.WebAudio.AudioListenerCreatedEventArgs> AudioListenerCreated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.WebAudio.AudioListenerCreatedEventArgs>("WebAudio.audioListenerCreated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.WebAudio.AudioListenerCreatedEventArgs>("WebAudio.audioListenerCreated", value);
			}
		}

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x0600075A RID: 1882 RVA: 0x00009DE0 File Offset: 0x00007FE0
		// (remove) Token: 0x0600075B RID: 1883 RVA: 0x00009DF3 File Offset: 0x00007FF3
		public event global::System.EventHandler<global::CefSharp.DevTools.WebAudio.AudioListenerWillBeDestroyedEventArgs> AudioListenerWillBeDestroyed
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.WebAudio.AudioListenerWillBeDestroyedEventArgs>("WebAudio.audioListenerWillBeDestroyed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.WebAudio.AudioListenerWillBeDestroyedEventArgs>("WebAudio.audioListenerWillBeDestroyed", value);
			}
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x0600075C RID: 1884 RVA: 0x00009E07 File Offset: 0x00008007
		// (remove) Token: 0x0600075D RID: 1885 RVA: 0x00009E1A File Offset: 0x0000801A
		public event global::System.EventHandler<global::CefSharp.DevTools.WebAudio.AudioNodeCreatedEventArgs> AudioNodeCreated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.WebAudio.AudioNodeCreatedEventArgs>("WebAudio.audioNodeCreated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.WebAudio.AudioNodeCreatedEventArgs>("WebAudio.audioNodeCreated", value);
			}
		}

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x0600075E RID: 1886 RVA: 0x00009E2E File Offset: 0x0000802E
		// (remove) Token: 0x0600075F RID: 1887 RVA: 0x00009E41 File Offset: 0x00008041
		public event global::System.EventHandler<global::CefSharp.DevTools.WebAudio.AudioNodeWillBeDestroyedEventArgs> AudioNodeWillBeDestroyed
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.WebAudio.AudioNodeWillBeDestroyedEventArgs>("WebAudio.audioNodeWillBeDestroyed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.WebAudio.AudioNodeWillBeDestroyedEventArgs>("WebAudio.audioNodeWillBeDestroyed", value);
			}
		}

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06000760 RID: 1888 RVA: 0x00009E55 File Offset: 0x00008055
		// (remove) Token: 0x06000761 RID: 1889 RVA: 0x00009E68 File Offset: 0x00008068
		public event global::System.EventHandler<global::CefSharp.DevTools.WebAudio.AudioParamCreatedEventArgs> AudioParamCreated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.WebAudio.AudioParamCreatedEventArgs>("WebAudio.audioParamCreated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.WebAudio.AudioParamCreatedEventArgs>("WebAudio.audioParamCreated", value);
			}
		}

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06000762 RID: 1890 RVA: 0x00009E7C File Offset: 0x0000807C
		// (remove) Token: 0x06000763 RID: 1891 RVA: 0x00009E8F File Offset: 0x0000808F
		public event global::System.EventHandler<global::CefSharp.DevTools.WebAudio.AudioParamWillBeDestroyedEventArgs> AudioParamWillBeDestroyed
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.WebAudio.AudioParamWillBeDestroyedEventArgs>("WebAudio.audioParamWillBeDestroyed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.WebAudio.AudioParamWillBeDestroyedEventArgs>("WebAudio.audioParamWillBeDestroyed", value);
			}
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06000764 RID: 1892 RVA: 0x00009EA3 File Offset: 0x000080A3
		// (remove) Token: 0x06000765 RID: 1893 RVA: 0x00009EB6 File Offset: 0x000080B6
		public event global::System.EventHandler<global::CefSharp.DevTools.WebAudio.NodesConnectedEventArgs> NodesConnected
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.WebAudio.NodesConnectedEventArgs>("WebAudio.nodesConnected", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.WebAudio.NodesConnectedEventArgs>("WebAudio.nodesConnected", value);
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06000766 RID: 1894 RVA: 0x00009ECA File Offset: 0x000080CA
		// (remove) Token: 0x06000767 RID: 1895 RVA: 0x00009EDD File Offset: 0x000080DD
		public event global::System.EventHandler<global::CefSharp.DevTools.WebAudio.NodesDisconnectedEventArgs> NodesDisconnected
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.WebAudio.NodesDisconnectedEventArgs>("WebAudio.nodesDisconnected", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.WebAudio.NodesDisconnectedEventArgs>("WebAudio.nodesDisconnected", value);
			}
		}

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06000768 RID: 1896 RVA: 0x00009EF1 File Offset: 0x000080F1
		// (remove) Token: 0x06000769 RID: 1897 RVA: 0x00009F04 File Offset: 0x00008104
		public event global::System.EventHandler<global::CefSharp.DevTools.WebAudio.NodeParamConnectedEventArgs> NodeParamConnected
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.WebAudio.NodeParamConnectedEventArgs>("WebAudio.nodeParamConnected", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.WebAudio.NodeParamConnectedEventArgs>("WebAudio.nodeParamConnected", value);
			}
		}

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x0600076A RID: 1898 RVA: 0x00009F18 File Offset: 0x00008118
		// (remove) Token: 0x0600076B RID: 1899 RVA: 0x00009F2B File Offset: 0x0000812B
		public event global::System.EventHandler<global::CefSharp.DevTools.WebAudio.NodeParamDisconnectedEventArgs> NodeParamDisconnected
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.WebAudio.NodeParamDisconnectedEventArgs>("WebAudio.nodeParamDisconnected", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.WebAudio.NodeParamDisconnectedEventArgs>("WebAudio.nodeParamDisconnected", value);
			}
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00009F40 File Offset: 0x00008140
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("WebAudio.enable", parameters);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00009F60 File Offset: 0x00008160
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("WebAudio.disable", parameters);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00009F80 File Offset: 0x00008180
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.WebAudio.GetRealtimeDataResponse> GetRealtimeDataAsync(string contextId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("contextId", contextId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.WebAudio.GetRealtimeDataResponse>("WebAudio.getRealtimeData", dictionary);
		}

		// Token: 0x04000351 RID: 849
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
