using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.WebAuthn
{
	// Token: 0x020000C9 RID: 201
	public class WebAuthnClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x060006A8 RID: 1704 RVA: 0x00009432 File Offset: 0x00007632
		public WebAuthnClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x060006A9 RID: 1705 RVA: 0x00009441 File Offset: 0x00007641
		// (remove) Token: 0x060006AA RID: 1706 RVA: 0x00009454 File Offset: 0x00007654
		public event global::System.EventHandler<global::CefSharp.DevTools.WebAuthn.CredentialAddedEventArgs> CredentialAdded
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.WebAuthn.CredentialAddedEventArgs>("WebAuthn.credentialAdded", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.WebAuthn.CredentialAddedEventArgs>("WebAuthn.credentialAdded", value);
			}
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x060006AB RID: 1707 RVA: 0x00009468 File Offset: 0x00007668
		// (remove) Token: 0x060006AC RID: 1708 RVA: 0x0000947B File Offset: 0x0000767B
		public event global::System.EventHandler<global::CefSharp.DevTools.WebAuthn.CredentialAssertedEventArgs> CredentialAsserted
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.WebAuthn.CredentialAssertedEventArgs>("WebAuthn.credentialAsserted", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.WebAuthn.CredentialAssertedEventArgs>("WebAuthn.credentialAsserted", value);
			}
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00009490 File Offset: 0x00007690
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync(bool? enableUI = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (enableUI != null)
			{
				dictionary.Add("enableUI", enableUI.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("WebAuthn.enable", dictionary);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x000094D4 File Offset: 0x000076D4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("WebAuthn.disable", parameters);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x000094F4 File Offset: 0x000076F4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.WebAuthn.AddVirtualAuthenticatorResponse> AddVirtualAuthenticatorAsync(global::CefSharp.DevTools.WebAuthn.VirtualAuthenticatorOptions options)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("options", options.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.WebAuthn.AddVirtualAuthenticatorResponse>("WebAuthn.addVirtualAuthenticator", dictionary);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0000952C File Offset: 0x0000772C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetResponseOverrideBitsAsync(string authenticatorId, bool? isBogusSignature = null, bool? isBadUV = null, bool? isBadUP = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("authenticatorId", authenticatorId);
			if (isBogusSignature != null)
			{
				dictionary.Add("isBogusSignature", isBogusSignature.Value);
			}
			if (isBadUV != null)
			{
				dictionary.Add("isBadUV", isBadUV.Value);
			}
			if (isBadUP != null)
			{
				dictionary.Add("isBadUP", isBadUP.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("WebAuthn.setResponseOverrideBits", dictionary);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x000095BC File Offset: 0x000077BC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> RemoveVirtualAuthenticatorAsync(string authenticatorId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("authenticatorId", authenticatorId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("WebAuthn.removeVirtualAuthenticator", dictionary);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x000095EC File Offset: 0x000077EC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> AddCredentialAsync(string authenticatorId, global::CefSharp.DevTools.WebAuthn.Credential credential)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("authenticatorId", authenticatorId);
			dictionary.Add("credential", credential.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("WebAuthn.addCredential", dictionary);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00009630 File Offset: 0x00007830
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.WebAuthn.GetCredentialResponse> GetCredentialAsync(string authenticatorId, byte[] credentialId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("authenticatorId", authenticatorId);
			dictionary.Add("credentialId", base.ToBase64String(credentialId));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.WebAuthn.GetCredentialResponse>("WebAuthn.getCredential", dictionary);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00009674 File Offset: 0x00007874
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.WebAuthn.GetCredentialsResponse> GetCredentialsAsync(string authenticatorId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("authenticatorId", authenticatorId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.WebAuthn.GetCredentialsResponse>("WebAuthn.getCredentials", dictionary);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x000096A4 File Offset: 0x000078A4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> RemoveCredentialAsync(string authenticatorId, byte[] credentialId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("authenticatorId", authenticatorId);
			dictionary.Add("credentialId", base.ToBase64String(credentialId));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("WebAuthn.removeCredential", dictionary);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x000096E8 File Offset: 0x000078E8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ClearCredentialsAsync(string authenticatorId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("authenticatorId", authenticatorId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("WebAuthn.clearCredentials", dictionary);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00009718 File Offset: 0x00007918
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetUserVerifiedAsync(string authenticatorId, bool isUserVerified)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("authenticatorId", authenticatorId);
			dictionary.Add("isUserVerified", isUserVerified);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("WebAuthn.setUserVerified", dictionary);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0000975C File Offset: 0x0000795C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetAutomaticPresenceSimulationAsync(string authenticatorId, bool enabled)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("authenticatorId", authenticatorId);
			dictionary.Add("enabled", enabled);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("WebAuthn.setAutomaticPresenceSimulation", dictionary);
		}

		// Token: 0x04000302 RID: 770
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
