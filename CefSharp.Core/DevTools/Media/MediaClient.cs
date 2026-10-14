using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Media
{
	// Token: 0x020000BE RID: 190
	public class MediaClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06000659 RID: 1625 RVA: 0x00009099 File Offset: 0x00007299
		public MediaClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x0600065A RID: 1626 RVA: 0x000090A8 File Offset: 0x000072A8
		// (remove) Token: 0x0600065B RID: 1627 RVA: 0x000090BB File Offset: 0x000072BB
		public event global::System.EventHandler<global::CefSharp.DevTools.Media.PlayerPropertiesChangedEventArgs> PlayerPropertiesChanged
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Media.PlayerPropertiesChangedEventArgs>("Media.playerPropertiesChanged", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Media.PlayerPropertiesChangedEventArgs>("Media.playerPropertiesChanged", value);
			}
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x0600065C RID: 1628 RVA: 0x000090CF File Offset: 0x000072CF
		// (remove) Token: 0x0600065D RID: 1629 RVA: 0x000090E2 File Offset: 0x000072E2
		public event global::System.EventHandler<global::CefSharp.DevTools.Media.PlayerEventsAddedEventArgs> PlayerEventsAdded
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Media.PlayerEventsAddedEventArgs>("Media.playerEventsAdded", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Media.PlayerEventsAddedEventArgs>("Media.playerEventsAdded", value);
			}
		}

		// Token: 0x14000027 RID: 39
		// (add) Token: 0x0600065E RID: 1630 RVA: 0x000090F6 File Offset: 0x000072F6
		// (remove) Token: 0x0600065F RID: 1631 RVA: 0x00009109 File Offset: 0x00007309
		public event global::System.EventHandler<global::CefSharp.DevTools.Media.PlayerMessagesLoggedEventArgs> PlayerMessagesLogged
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Media.PlayerMessagesLoggedEventArgs>("Media.playerMessagesLogged", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Media.PlayerMessagesLoggedEventArgs>("Media.playerMessagesLogged", value);
			}
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06000660 RID: 1632 RVA: 0x0000911D File Offset: 0x0000731D
		// (remove) Token: 0x06000661 RID: 1633 RVA: 0x00009130 File Offset: 0x00007330
		public event global::System.EventHandler<global::CefSharp.DevTools.Media.PlayerErrorsRaisedEventArgs> PlayerErrorsRaised
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Media.PlayerErrorsRaisedEventArgs>("Media.playerErrorsRaised", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Media.PlayerErrorsRaisedEventArgs>("Media.playerErrorsRaised", value);
			}
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06000662 RID: 1634 RVA: 0x00009144 File Offset: 0x00007344
		// (remove) Token: 0x06000663 RID: 1635 RVA: 0x00009157 File Offset: 0x00007357
		public event global::System.EventHandler<global::CefSharp.DevTools.Media.PlayersCreatedEventArgs> PlayersCreated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Media.PlayersCreatedEventArgs>("Media.playersCreated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Media.PlayersCreatedEventArgs>("Media.playersCreated", value);
			}
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0000916C File Offset: 0x0000736C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Media.enable", parameters);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0000918C File Offset: 0x0000738C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Media.disable", parameters);
		}

		// Token: 0x040002DC RID: 732
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
