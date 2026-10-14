using System;
using System.Collections.Generic;
using System.Threading;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000117 RID: 279
	internal static class CachedCredentialsManager
	{
		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06000B8F RID: 2959 RVA: 0x0001D588 File Offset: 0x0001B788
		// (remove) Token: 0x06000B90 RID: 2960 RVA: 0x0001D5C0 File Offset: 0x0001B7C0
		public static event global::Gibraltar.Server.Client.CredentialsRequiredEventHandler CredentialsRequired;

		// Token: 0x06000B91 RID: 2961 RVA: 0x0001D5F8 File Offset: 0x0001B7F8
		public static global::Gibraltar.Server.Client.IWebAuthenticationProvider GetCredentials(global::Gibraltar.Server.Client.WebChannel targetChannel, bool useApiKey, global::System.Guid repositoryId, string keyContainerName, bool useMachineStore)
		{
			return global::Gibraltar.Server.Client.CachedCredentialsManager.GetCredentials(global::Gibraltar.Server.Client.CachedCredentialsManager.GetEntryUri(targetChannel), useApiKey, repositoryId, keyContainerName, useMachineStore);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0001D60C File Offset: 0x0001B80C
		public static global::Gibraltar.Server.Client.IWebAuthenticationProvider GetCachedCredentials(global::Gibraltar.Server.Client.WebChannel targetChannel, bool useApiKey, global::System.Guid repositoryId, string keyContainerName, bool useMachineStore)
		{
			return global::Gibraltar.Server.Client.CachedCredentialsManager.GetCachedCredentials(global::Gibraltar.Server.Client.CachedCredentialsManager.GetEntryUri(targetChannel), useApiKey, repositoryId, keyContainerName, useMachineStore);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0001D620 File Offset: 0x0001B820
		public static string GetEntryUri(global::Gibraltar.Server.Client.WebChannel channel)
		{
			return global::Gibraltar.Server.Client.CachedCredentialsManager.GetEntryUri(channel.HostName);
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0001D630 File Offset: 0x0001B830
		public static string GetEntryUri(string hostName)
		{
			return hostName.ToLowerInvariant();
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0001D638 File Offset: 0x0001B838
		private static global::Gibraltar.Server.Client.IWebAuthenticationProvider GetCredentials(string entryUri, bool useApiKey, global::System.Guid repositoryId, string keyContainerName, bool useMachineStore)
		{
			global::Gibraltar.Server.Client.IWebAuthenticationProvider webAuthenticationProvider = global::Gibraltar.Server.Client.CachedCredentialsManager.GetCachedCredentials(entryUri, useApiKey, repositoryId, keyContainerName, useMachineStore);
			if (webAuthenticationProvider == null)
			{
				webAuthenticationProvider = global::Gibraltar.Server.Client.CachedCredentialsManager.RequestUserCredentials(entryUri, repositoryId);
			}
			return webAuthenticationProvider;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0001D664 File Offset: 0x0001B864
		private static global::Gibraltar.Server.Client.IWebAuthenticationProvider GetCachedCredentials(string entryUri, bool useApiKey, global::System.Guid repositoryId, string keyContainerName, bool useMachineStore)
		{
			global::Gibraltar.Server.Client.CachedCredentialsManager.CredentialCacheKey key = new global::Gibraltar.Server.Client.CachedCredentialsManager.CredentialCacheKey(entryUri, repositoryId);
			object obj = global::Gibraltar.Server.Client.CachedCredentialsManager.g_Lock;
			global::Gibraltar.Server.Client.IWebAuthenticationProvider webAuthenticationProvider;
			lock (obj)
			{
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Server.Client.CachedCredentialsManager.g_Lock);
				if (!global::Gibraltar.Server.Client.CachedCredentialsManager.g_CachedCredentials.TryGetValue(key, out webAuthenticationProvider) && useApiKey)
				{
					webAuthenticationProvider = new global::Gibraltar.Server.Client.RepositoryCredentials(repositoryId, keyContainerName, useMachineStore);
					global::Gibraltar.Server.Client.CachedCredentialsManager.g_CachedCredentials.Add(key, webAuthenticationProvider);
				}
				if (global::Gibraltar.Server.Client.CachedCredentialsManager.g_CachedBlockedCredentials.ContainsKey(entryUri))
				{
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Server.Client.CachedCredentialsManager.g_Lock);
					throw new global::Gibraltar.Server.Client.WebChannelAuthorizationException("User declined to provide credentials");
				}
			}
			return webAuthenticationProvider;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0001D700 File Offset: 0x0001B900
		public static bool RequestCredentials(global::Gibraltar.Server.Client.WebChannel targetChannel, global::System.Guid repositoryId)
		{
			return global::Gibraltar.Server.Client.CachedCredentialsManager.RequestCredentials(global::Gibraltar.Server.Client.CachedCredentialsManager.GetEntryUri(targetChannel), repositoryId);
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x0001D710 File Offset: 0x0001B910
		public static bool RequestCredentials(string entryUri, global::System.Guid repositoryId)
		{
			return global::Gibraltar.Server.Client.CachedCredentialsManager.RequestUserCredentials(entryUri, repositoryId) != null;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x0001D71C File Offset: 0x0001B91C
		private static global::Gibraltar.Server.Client.IWebAuthenticationProvider RequestUserCredentials(string entryUri, global::System.Guid repositoryId)
		{
			global::Gibraltar.Server.Client.CachedCredentialsManager.CredentialCacheKey key = new global::Gibraltar.Server.Client.CachedCredentialsManager.CredentialCacheKey(entryUri, repositoryId);
			object obj = global::Gibraltar.Server.Client.CachedCredentialsManager.g_RequestLock;
			global::Gibraltar.Server.Client.IWebAuthenticationProvider authenticationProvider;
			lock (obj)
			{
				object obj2 = global::Gibraltar.Server.Client.CachedCredentialsManager.g_Lock;
				lock (obj2)
				{
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Server.Client.CachedCredentialsManager.g_Lock);
					if (global::Gibraltar.Server.Client.CachedCredentialsManager.g_CachedBlockedCredentials.ContainsKey(entryUri))
					{
						throw new global::Gibraltar.Server.Client.WebChannelAuthorizationException("User declined to provide credentials");
					}
					if (global::Gibraltar.Server.Client.CachedCredentialsManager.g_CachedCredentials.TryGetValue(key, out authenticationProvider))
					{
						return authenticationProvider;
					}
				}
				global::Gibraltar.Server.Client.CredentialsRequiredEventArgs credentialsRequiredEventArgs = new global::Gibraltar.Server.Client.CredentialsRequiredEventArgs(entryUri, repositoryId, false, null);
				global::Gibraltar.Server.Client.CachedCredentialsManager.OnCredentialsRequired(null, credentialsRequiredEventArgs);
				if (credentialsRequiredEventArgs.Cancel)
				{
					obj2 = global::Gibraltar.Server.Client.CachedCredentialsManager.g_Lock;
					lock (obj2)
					{
						global::Gibraltar.Server.Client.CachedCredentialsManager.g_CachedBlockedCredentials[entryUri] = entryUri;
						global::System.Threading.Monitor.PulseAll(global::Gibraltar.Server.Client.CachedCredentialsManager.g_Lock);
					}
					throw new global::Gibraltar.Server.Client.WebChannelAuthorizationException("User declined to provide credentials");
				}
				if (credentialsRequiredEventArgs.AuthenticationProvider == null)
				{
					throw new global::Gibraltar.Server.Client.WebChannelAuthorizationException("No credentials are available for the specified server");
				}
				authenticationProvider = credentialsRequiredEventArgs.AuthenticationProvider;
				obj2 = global::Gibraltar.Server.Client.CachedCredentialsManager.g_Lock;
				lock (obj2)
				{
					global::Gibraltar.Server.Client.CachedCredentialsManager.g_CachedCredentials.Add(key, authenticationProvider);
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Server.Client.CachedCredentialsManager.g_Lock);
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Server.Client.CachedCredentialsManager.g_RequestLock);
			}
			return authenticationProvider;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0001D8B8 File Offset: 0x0001BAB8
		public static bool UpdateCredentials(global::Gibraltar.Server.Client.WebChannel targetChannel, bool forceUpdate)
		{
			if (targetChannel == null)
			{
				throw new global::System.ArgumentNullException("targetChannel");
			}
			return global::Gibraltar.Server.Client.CachedCredentialsManager.UpdateCredentials(global::Gibraltar.Server.Client.CachedCredentialsManager.GetEntryUri(targetChannel), global::System.Guid.Empty, forceUpdate);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x0001D8DC File Offset: 0x0001BADC
		public static bool UpdateCredentials(global::Gibraltar.Server.Client.WebChannel targetChannel, global::System.Guid repositoryId, bool forceUpdate)
		{
			if (targetChannel == null)
			{
				throw new global::System.ArgumentNullException("targetChannel");
			}
			if (repositoryId == global::System.Guid.Empty)
			{
				throw new global::System.ArgumentNullException("repositoryId");
			}
			return global::Gibraltar.Server.Client.CachedCredentialsManager.UpdateCredentials(global::Gibraltar.Server.Client.CachedCredentialsManager.GetEntryUri(targetChannel), repositoryId, forceUpdate);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0001D918 File Offset: 0x0001BB18
		public static bool UpdateCredentials(string entryUri, global::System.Guid repositoryId, bool forceUpdate)
		{
			global::Gibraltar.Server.Client.CachedCredentialsManager.CredentialCacheKey key = new global::Gibraltar.Server.Client.CachedCredentialsManager.CredentialCacheKey(entryUri, repositoryId);
			bool result = false;
			object obj = global::Gibraltar.Server.Client.CachedCredentialsManager.g_Lock;
			lock (obj)
			{
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Server.Client.CachedCredentialsManager.g_Lock);
				if (!forceUpdate && global::Gibraltar.Server.Client.CachedCredentialsManager.g_CachedBlockedCredentials.ContainsKey(entryUri))
				{
					return false;
				}
				global::Gibraltar.Server.Client.IWebAuthenticationProvider authenticationProvider;
				global::Gibraltar.Server.Client.CachedCredentialsManager.g_CachedCredentials.TryGetValue(key, out authenticationProvider);
				object obj2 = global::Gibraltar.Server.Client.CachedCredentialsManager.g_RequestLock;
				lock (obj2)
				{
					global::Gibraltar.Server.Client.CredentialsRequiredEventArgs credentialsRequiredEventArgs = new global::Gibraltar.Server.Client.CredentialsRequiredEventArgs(entryUri, repositoryId, true, authenticationProvider);
					global::Gibraltar.Server.Client.CachedCredentialsManager.OnCredentialsRequired(null, credentialsRequiredEventArgs);
					if (!credentialsRequiredEventArgs.Cancel)
					{
						if (credentialsRequiredEventArgs.AuthenticationProvider == null)
						{
							throw new global::System.InvalidOperationException("No credentials are available for the specified server");
						}
						result = true;
						global::Gibraltar.Server.Client.CachedCredentialsManager.g_CachedBlockedCredentials.Remove(entryUri);
						global::Gibraltar.Server.Client.CachedCredentialsManager.g_CachedCredentials[key] = credentialsRequiredEventArgs.AuthenticationProvider;
					}
					global::System.Threading.Monitor.PulseAll(global::Gibraltar.Server.Client.CachedCredentialsManager.g_RequestLock);
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Server.Client.CachedCredentialsManager.g_Lock);
			}
			return result;
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0001DA24 File Offset: 0x0001BC24
		private static void OnCredentialsRequired(object source, global::Gibraltar.Server.Client.CredentialsRequiredEventArgs e)
		{
			global::Gibraltar.Server.Client.CredentialsRequiredEventHandler credentialsRequired = global::Gibraltar.Server.Client.CachedCredentialsManager.CredentialsRequired;
			if (credentialsRequired != null)
			{
				credentialsRequired(source, e);
			}
		}

		// Token: 0x04000341 RID: 833
		private static readonly object g_Lock = new object();

		// Token: 0x04000342 RID: 834
		private static readonly object g_RequestLock = new object();

		// Token: 0x04000343 RID: 835
		private static readonly global::System.Collections.Generic.Dictionary<global::Gibraltar.Server.Client.CachedCredentialsManager.CredentialCacheKey, global::Gibraltar.Server.Client.IWebAuthenticationProvider> g_CachedCredentials = new global::System.Collections.Generic.Dictionary<global::Gibraltar.Server.Client.CachedCredentialsManager.CredentialCacheKey, global::Gibraltar.Server.Client.IWebAuthenticationProvider>();

		// Token: 0x04000344 RID: 836
		private static readonly global::System.Collections.Generic.Dictionary<string, string> g_CachedBlockedCredentials = new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.Ordinal);

		// Token: 0x0200049A RID: 1178
		private class CredentialCacheKey : global::System.IEquatable<global::Gibraltar.Server.Client.CachedCredentialsManager.CredentialCacheKey>
		{
			// Token: 0x0600332E RID: 13102 RVA: 0x000B9EAC File Offset: 0x000B80AC
			public CredentialCacheKey(string entryUri, global::System.Guid repositoryId)
			{
				this.EntryUri = entryUri;
				this.RepositoryId = repositoryId;
				this.m_HashCode = this.EntryUri.ToLowerInvariant().GetHashCode();
				this.m_HashCode ^= this.RepositoryId.GetHashCode();
			}

			// Token: 0x17000EBB RID: 3771
			// (get) Token: 0x0600332F RID: 13103 RVA: 0x000B9F08 File Offset: 0x000B8108
			// (set) Token: 0x06003330 RID: 13104 RVA: 0x000B9F10 File Offset: 0x000B8110
			public string EntryUri { get; private set; }

			// Token: 0x17000EBC RID: 3772
			// (get) Token: 0x06003331 RID: 13105 RVA: 0x000B9F1C File Offset: 0x000B811C
			// (set) Token: 0x06003332 RID: 13106 RVA: 0x000B9F24 File Offset: 0x000B8124
			public global::System.Guid RepositoryId { get; private set; }

			// Token: 0x06003333 RID: 13107 RVA: 0x000B9F30 File Offset: 0x000B8130
			public bool Equals(global::Gibraltar.Server.Client.CachedCredentialsManager.CredentialCacheKey other)
			{
				return string.Equals(this.EntryUri, other.EntryUri, global::System.StringComparison.OrdinalIgnoreCase) && !(this.RepositoryId != other.RepositoryId);
			}

			// Token: 0x06003334 RID: 13108 RVA: 0x000B9F74 File Offset: 0x000B8174
			public override int GetHashCode()
			{
				return this.m_HashCode;
			}

			// Token: 0x04001376 RID: 4982
			private int m_HashCode;
		}
	}
}
