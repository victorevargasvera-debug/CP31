using System;
using System.Diagnostics;
using System.Net;
using System.Threading;
using Gibraltar.Server.Client.Data;
using Loupe.Extensibility.Data;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000124 RID: 292
	[global::System.Diagnostics.DebuggerDisplay("{EndUserTestUrl} Status: {Status}")]
	internal class HubConnection : global::System.IDisposable
	{
		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06000BDC RID: 3036 RVA: 0x0001DF40 File Offset: 0x0001C140
		// (remove) Token: 0x06000BDD RID: 3037 RVA: 0x0001DF7C File Offset: 0x0001C17C
		public event global::Gibraltar.Server.Client.ChannelConnectionStateChangedEventHandler ConnectionStateChanged;

		// Token: 0x14000034 RID: 52
		// (add) Token: 0x06000BDE RID: 3038 RVA: 0x0001DFB8 File Offset: 0x0001C1B8
		// (remove) Token: 0x06000BDF RID: 3039 RVA: 0x0001DFF0 File Offset: 0x0001C1F0
		public static event global::Gibraltar.Server.Client.HubConnectionCanConnectEventHandler CanConnectCompleted;

		// Token: 0x06000BE0 RID: 3040 RVA: 0x0001E028 File Offset: 0x0001C228
		public HubConnection(global::Gibraltar.Server.Client.IServerConfiguration configuration) : this(configuration.UseGibraltarService, configuration.CustomerName, configuration.Server, configuration.Port, configuration.UseSsl, configuration.ApplicationBaseDirectory, configuration.Repository)
		{
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0001E06C File Offset: 0x0001C26C
		public HubConnection(bool useGibraltarService, string customerName, string server, int port, bool useSsl, string applicationBaseDirectory, string repository)
		{
			this.m_UseGibraltarService = useGibraltarService;
			if (this.m_UseGibraltarService)
			{
				this.m_CustomerName = customerName;
				return;
			}
			this.m_Server = server;
			this.m_Port = port;
			this.m_UseSsl = useSsl;
			this.m_ApplicationBaseDirectory = applicationBaseDirectory;
			this.m_Repository = repository;
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0001E0E8 File Offset: 0x0001C2E8
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x0001E0F0 File Offset: 0x0001C2F0
		public static global::Gibraltar.Server.Client.IClientLogger Logger { get; set; }

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x0001E0F8 File Offset: 0x0001C2F8
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x0001E100 File Offset: 0x0001C300
		public bool EnableLogging
		{
			get
			{
				return this.m_EnableLogging;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					if (value != this.m_EnableLogging)
					{
						this.m_EnableLogging = value;
						object channelLock = this.m_ChannelLock;
						lock (channelLock)
						{
							if (this.m_CurrentChannel != null)
							{
								this.m_CurrentChannel.EnableLogging = this.m_EnableLogging;
							}
							global::System.Threading.Monitor.PulseAll(this.m_ChannelLock);
						}
					}
					global::System.Threading.Monitor.PulseAll(this.m_Lock);
				}
			}
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x0001E1A0 File Offset: 0x0001C3A0
		public void SetCredentials(global::System.Guid clientRepositoryId, bool useApiKey, string keyContainerName, bool useMachineStore)
		{
			if (clientRepositoryId.Equals(global::System.Guid.Empty))
			{
				throw new global::System.ArgumentNullException("clientRepositoryId");
			}
			if (string.IsNullOrEmpty(keyContainerName))
			{
				throw new global::System.ArgumentNullException("keyContainerName");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_UseCredentials = true;
				this.m_UseRepositoryCredentials = useApiKey;
				this.m_ClientRepositoryId = clientRepositoryId;
				this.m_KeyContainerName = keyContainerName;
				this.m_UseMachineStore = useMachineStore;
				global::System.Threading.Monitor.PulseAll(this.m_Lock);
			}
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x0001E238 File Offset: 0x0001C438
		public bool CanConnect(out global::Gibraltar.Server.Client.HubStatus status, out string statusMessage)
		{
			bool result = false;
			status = global::Gibraltar.Server.Client.HubStatus.Maintenance;
			statusMessage = null;
			global::System.Guid? serverRepositoryId = null;
			global::System.DateTimeOffset? expirationDt = null;
			string publicKey = null;
			global::System.Version protocolVersion = this.m_ProtocolVersion;
			object obj = this.m_ChannelLock;
			lock (obj)
			{
				if (this.m_CurrentChannel != null)
				{
					bool flag = true;
					try
					{
						global::Gibraltar.Server.Client.HubConfigurationGetRequest hubConfigurationGetRequest = new global::Gibraltar.Server.Client.HubConfigurationGetRequest();
						this.m_CurrentChannel.ExecuteRequest(hubConfigurationGetRequest, 1);
						global::Gibraltar.Server.Client.Data.HubConfigurationXml configuration = hubConfigurationGetRequest.Configuration;
						if (configuration.redirectRequested || configuration.status != global::Gibraltar.Server.Client.Data.HubStatusXml.available)
						{
							flag = false;
						}
						else
						{
							result = true;
							status = global::Gibraltar.Server.Client.HubStatus.Unknown;
						}
						publicKey = configuration.publicKey;
					}
					catch (global::System.Exception ex)
					{
						if (!global::Gibraltar.Server.Client.HubConnection.Logger.SilentMode)
						{
							global::Gibraltar.Server.Client.HubConnection.Logger.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, ex, false, "Loupe.Repository.Server", "Unable to get server configuration, connection will be assumed unavailable.", "Due to an exception we were unable to retrieve the server configuration.  We'll assume the server is in maintenance until we can succeed.  Exception: {0}\r\n", new object[]
							{
								ex.Message
							});
						}
						flag = false;
					}
					if (!flag && !this.IsRootHub(this.m_CurrentChannel.HostName, this.m_CurrentChannel.Port, this.m_CurrentChannel.UseSsl, this.m_CurrentChannel.ApplicationBaseDirectory))
					{
						this.CurrentChannel = null;
					}
				}
				if (this.m_CurrentChannel == null)
				{
					global::Gibraltar.Server.Client.NetworkConnectionOptions networkConnectionOptions;
					global::Gibraltar.Server.Client.NetworkConnectionOptions networkConnectionOptions2;
					this.CurrentChannel = this.Connect(out status, out statusMessage, out serverRepositoryId, out expirationDt, out protocolVersion, out publicKey, out networkConnectionOptions, out networkConnectionOptions2);
					if (status == global::Gibraltar.Server.Client.HubStatus.Unknown)
					{
						result = true;
					}
				}
				global::System.Threading.Monitor.PulseAll(this.m_ChannelLock);
			}
			obj = this.m_StatusLock;
			lock (obj)
			{
				this.m_Status = status;
				this.m_StatusMessage = statusMessage;
				this.m_ServerRepositoryId = serverRepositoryId;
				this.m_ExpirationDt = expirationDt;
				this.m_PublicKey = publicKey;
				if (status == global::Gibraltar.Server.Client.HubStatus.Unknown)
				{
					this.ProtocolVersion = protocolVersion;
				}
			}
			return result;
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0001E444 File Offset: 0x0001C644
		public static bool CanConnect(global::Gibraltar.Server.Client.IServerConfiguration configuration, out global::Gibraltar.Server.Client.HubStatus status, out string statusMessage)
		{
			return global::Gibraltar.Server.Client.HubConnection.CanConnect(configuration.UseGibraltarService, configuration.CustomerName, configuration.Server, configuration.Port, configuration.UseSsl, configuration.ApplicationBaseDirectory, configuration.Repository, out status, out statusMessage);
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0001E488 File Offset: 0x0001C688
		public static bool CanConnect(bool useGibraltarService, string customerName, string server, int port, bool useSsl, string applicationBaseDirectory, string repository, out global::Gibraltar.Server.Client.HubStatus status, out string statusMessage)
		{
			bool result = false;
			global::System.Guid? guid;
			global::System.DateTimeOffset? dateTimeOffset;
			global::System.Version v;
			string text;
			global::Gibraltar.Server.Client.NetworkConnectionOptions networkConnectionOptions;
			global::Gibraltar.Server.Client.NetworkConnectionOptions networkConnectionOptions2;
			using (global::Gibraltar.Server.Client.WebChannel webChannel = global::Gibraltar.Server.Client.HubConnection.Connect(useGibraltarService, customerName, server, port, useSsl, applicationBaseDirectory, repository, out status, out statusMessage, out guid, out dateTimeOffset, out v, out text, out networkConnectionOptions, out networkConnectionOptions2))
			{
				if (webChannel != null && status == global::Gibraltar.Server.Client.HubStatus.Unknown)
				{
					if (v < global::Gibraltar.Server.Client.HubConnection.Hub30ProtocolVersion)
					{
						statusMessage = "The server is implementing an older, incompatible version of the server protocol.";
					}
					else
					{
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x0001E50C File Offset: 0x0001C70C
		public static void CanConnectAsync(bool useGibraltarService, string customerName, string server, int port, bool useSsl, string applicationBaseDirectory, string repository)
		{
			object[] state = new object[]
			{
				useGibraltarService,
				customerName,
				server,
				port,
				useSsl,
				applicationBaseDirectory,
				repository
			};
			global::System.Threading.ThreadPool.QueueUserWorkItem(new global::System.Threading.WaitCallback(global::Gibraltar.Server.Client.HubConnection.AsyncCanConnect), state);
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x0001E568 File Offset: 0x0001C768
		public void ExecuteRequest(global::Gibraltar.Server.Client.IWebRequest newRequest, int maxRetries)
		{
			global::Gibraltar.Server.Client.WebChannel webChannel = this.CurrentChannel;
			try
			{
				webChannel.ExecuteRequest(newRequest, maxRetries);
			}
			catch (global::Gibraltar.Server.Client.WebChannelAuthorizationException ex)
			{
				global::Gibraltar.Server.Client.HubConnection.Logger.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, ex, true, "Loupe.Repository.Server", "Requesting updated credentials for the server connection due to " + ex.GetType(), "We're going to assume the user can provide current credentials.\r\nDetails: {0}", new object[]
				{
					ex.Message
				});
				if (!global::Gibraltar.Server.Client.CachedCredentialsManager.UpdateCredentials(webChannel, this.m_ClientRepositoryId, false))
				{
					throw;
				}
				this.ExecuteRequest(newRequest, maxRetries);
			}
			catch (global::Gibraltar.Server.Client.WebChannelConnectFailureException)
			{
				if (!this.IsRootHub(webChannel.HostName, webChannel.Port, webChannel.UseSsl, webChannel.ApplicationBaseDirectory))
				{
					webChannel = this.ResetChannel();
					webChannel.ExecuteRequest(newRequest, maxRetries);
				}
			}
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x0001E63C File Offset: 0x0001C83C
		public global::Gibraltar.Server.Client.Data.ClientRepositoryXml CreateSubscription(global::Gibraltar.Server.Client.Data.ClientRepositoryXml repositoryXml)
		{
			global::Gibraltar.Server.Client.ClientRepositoryUploadRequest clientRepositoryUploadRequest = new global::Gibraltar.Server.Client.ClientRepositoryUploadRequest(repositoryXml);
			object channelLock = this.m_ChannelLock;
			lock (channelLock)
			{
				global::Gibraltar.Server.Client.WebChannel currentChannel = this.CurrentChannel;
				bool flag = false;
				do
				{
					try
					{
						currentChannel.ExecuteRequest(clientRepositoryUploadRequest, 1);
					}
					catch (global::Gibraltar.Server.Client.WebChannelAuthorizationException ex)
					{
						global::Gibraltar.Server.Client.HubConnection.Logger.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, ex, true, "Loupe.Repository.Server", "Requesting updated credentials for the server connection due to " + ex.GetType(), "We're going to assume the user can provide current credentials.\r\nDetails: {0}", new object[]
						{
							ex.Message
						});
						flag = global::Gibraltar.Server.Client.CachedCredentialsManager.UpdateCredentials(currentChannel, this.m_ClientRepositoryId, false);
						if (!flag)
						{
							throw;
						}
					}
				}
				while (flag);
				global::System.Threading.Monitor.PulseAll(this.m_ChannelLock);
			}
			return clientRepositoryUploadRequest.ResponseRepository;
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x0001E708 File Offset: 0x0001C908
		public global::Gibraltar.Server.Client.Data.ClientRepositoryXml CreateSubscription(global::Gibraltar.Server.Client.Data.ClientRepositoryXml repositoryXml, string sharedSecret)
		{
			global::Gibraltar.Server.Client.ClientRepositoryUploadRequest clientRepositoryUploadRequest = new global::Gibraltar.Server.Client.ClientRepositoryUploadRequest(repositoryXml);
			object channelLock = this.m_ChannelLock;
			lock (channelLock)
			{
				global::Gibraltar.Server.Client.WebChannel currentChannel = this.CurrentChannel;
				global::Gibraltar.Server.Client.IWebAuthenticationProvider authenticationProvider = currentChannel.AuthenticationProvider;
				currentChannel.AuthenticationProvider = new global::Gibraltar.Server.Client.CustomerCredentials(sharedSecret);
				try
				{
					currentChannel.ExecuteRequest(clientRepositoryUploadRequest, 1);
				}
				finally
				{
					currentChannel.AuthenticationProvider = authenticationProvider;
				}
				global::System.Threading.Monitor.PulseAll(this.m_ChannelLock);
			}
			return clientRepositoryUploadRequest.ResponseRepository;
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x0001E794 File Offset: 0x0001C994
		public void Authenticate()
		{
			this.CurrentChannel.Authenticate();
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x0001E7A4 File Offset: 0x0001C9A4
		public void UpdateCredentials(global::System.Guid repositoryId)
		{
			global::Gibraltar.Server.Client.CachedCredentialsManager.UpdateCredentials(global::Gibraltar.Server.Client.CachedCredentialsManager.GetEntryUri(this.m_UseGibraltarService ? "hub.gibraltarsoftware.com" : this.m_Server), repositoryId, false);
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x0001E7D0 File Offset: 0x0001C9D0
		public bool IsAuthenticated
		{
			get
			{
				bool result = false;
				object channelLock = this.m_ChannelLock;
				lock (channelLock)
				{
					if (this.m_CurrentChannel != null && this.m_CurrentChannel.AuthenticationProvider != null)
					{
						result = this.m_CurrentChannel.AuthenticationProvider.IsAuthenticated;
					}
					global::System.Threading.Monitor.PulseAll(this.m_ChannelLock);
				}
				return result;
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x0001E840 File Offset: 0x0001CA40
		public bool IsConnected
		{
			get
			{
				bool result = false;
				object channelLock = this.m_ChannelLock;
				lock (channelLock)
				{
					if (this.m_CurrentChannel != null)
					{
						global::Gibraltar.Server.Client.ChannelConnectionState connectionState = this.m_CurrentChannel.ConnectionState;
						if (connectionState - global::Gibraltar.Server.Client.ChannelConnectionState.Connected <= 1)
						{
							result = true;
						}
					}
					global::System.Threading.Monitor.PulseAll(this.m_ChannelLock);
				}
				return result;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x0001E8A8 File Offset: 0x0001CAA8
		public global::Gibraltar.Server.Client.HubStatus Status
		{
			get
			{
				this.EnsureConnectAttempted();
				object statusLock = this.m_StatusLock;
				global::Gibraltar.Server.Client.HubStatus status;
				lock (statusLock)
				{
					status = this.m_Status;
				}
				return status;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x0001E8EC File Offset: 0x0001CAEC
		public string StatusMessage
		{
			get
			{
				this.EnsureConnectAttempted();
				object statusLock = this.m_StatusLock;
				string statusMessage;
				lock (statusLock)
				{
					statusMessage = this.m_StatusMessage;
				}
				return statusMessage;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x0001E930 File Offset: 0x0001CB30
		public global::System.Guid? ServerRepositoryId
		{
			get
			{
				this.EnsureConnectAttempted();
				object statusLock = this.m_StatusLock;
				global::System.Guid? serverRepositoryId;
				lock (statusLock)
				{
					serverRepositoryId = this.m_ServerRepositoryId;
				}
				return serverRepositoryId;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x0001E974 File Offset: 0x0001CB74
		public global::System.DateTimeOffset? ExpirationDt
		{
			get
			{
				this.EnsureConnectAttempted();
				object statusLock = this.m_StatusLock;
				global::System.DateTimeOffset? expirationDt;
				lock (statusLock)
				{
					expirationDt = this.m_ExpirationDt;
				}
				return expirationDt;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x0001E9B8 File Offset: 0x0001CBB8
		public string PublicKey
		{
			get
			{
				this.EnsureConnectAttempted();
				object statusLock = this.m_StatusLock;
				string publicKey;
				lock (statusLock)
				{
					publicKey = this.m_PublicKey;
				}
				return publicKey;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x0001E9FC File Offset: 0x0001CBFC
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x0001EA4C File Offset: 0x0001CC4C
		public global::System.Version ProtocolVersion
		{
			get
			{
				this.EnsureConnectAttempted();
				object statusLock = this.m_StatusLock;
				global::System.Version result;
				lock (statusLock)
				{
					result = (this.m_ProtocolVersion ?? new global::System.Version());
				}
				return result;
			}
			set
			{
				object statusLock = this.m_StatusLock;
				lock (statusLock)
				{
					this.m_ProtocolVersion = value;
				}
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x0001EA8C File Offset: 0x0001CC8C
		public global::Gibraltar.Server.Client.NetworkConnectionOptions AgentLiveStreamOptions
		{
			get
			{
				this.EnsureConnectAttempted();
				object statusLock = this.m_StatusLock;
				global::Gibraltar.Server.Client.NetworkConnectionOptions agentLiveStreamOptions;
				lock (statusLock)
				{
					agentLiveStreamOptions = this.m_AgentLiveStreamOptions;
				}
				return agentLiveStreamOptions;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x0001EAD0 File Offset: 0x0001CCD0
		public global::Gibraltar.Server.Client.NetworkConnectionOptions ClientLiveStreamOptions
		{
			get
			{
				this.EnsureConnectAttempted();
				object statusLock = this.m_StatusLock;
				global::Gibraltar.Server.Client.NetworkConnectionOptions clientLiveStreamOptions;
				lock (statusLock)
				{
					clientLiveStreamOptions = this.m_ClientLiveStreamOptions;
				}
				return clientLiveStreamOptions;
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0001EB14 File Offset: 0x0001CD14
		public void Reconnect()
		{
			this.ResetChannel();
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0001EB20 File Offset: 0x0001CD20
		public static void ValidateConfiguration(bool useGibraltarService, string customerName, string server, int port, bool useSsl, string applicationBaseDirectory)
		{
			if (!useGibraltarService && string.IsNullOrEmpty(customerName) && string.IsNullOrEmpty(server))
			{
				throw new global::System.InvalidOperationException("No server connection configuration could be found");
			}
			if (useGibraltarService)
			{
				if (string.IsNullOrEmpty(customerName))
				{
					throw new global::System.InvalidOperationException("A valid customer name is required to use the Loupe Service,");
				}
			}
			else
			{
				if (string.IsNullOrEmpty(server))
				{
					throw new global::System.InvalidOperationException("When using a private server a full server name is required");
				}
				if (port < 0)
				{
					throw new global::System.InvalidOperationException("When overriding the connection port, a positive number must be specified.  Use zero to accept the default port.");
				}
			}
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0001EB9C File Offset: 0x0001CD9C
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0001EBAC File Offset: 0x0001CDAC
		protected virtual void Dispose(bool releaseManaged)
		{
			if (releaseManaged)
			{
				this.CurrentChannel = null;
			}
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x0001EBBC File Offset: 0x0001CDBC
		protected virtual void OnConnectionStateChanged(global::Gibraltar.Server.Client.ChannelConnectionState state)
		{
			global::Gibraltar.Server.Client.ChannelConnectionStateChangedEventHandler connectionStateChanged = this.ConnectionStateChanged;
			if (connectionStateChanged != null)
			{
				global::Gibraltar.Server.Client.ChannelConnectionStateChangedEventArgs e = new global::Gibraltar.Server.Client.ChannelConnectionStateChangedEventArgs(state);
				connectionStateChanged(this, e);
			}
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0001EBEC File Offset: 0x0001CDEC
		private void EnsureConnectAttempted()
		{
			if (!this.m_HaveTriedToConnect)
			{
				global::Gibraltar.Server.Client.WebChannel currentChannel = this.CurrentChannel;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x0001EC04 File Offset: 0x0001CE04
		// (set) Token: 0x06000C02 RID: 3074 RVA: 0x0001ED14 File Offset: 0x0001CF14
		private global::Gibraltar.Server.Client.WebChannel CurrentChannel
		{
			get
			{
				object channelLock = this.m_ChannelLock;
				global::Gibraltar.Server.Client.WebChannel currentChannel;
				lock (channelLock)
				{
					if (this.m_CurrentChannel == null)
					{
						try
						{
							global::Gibraltar.Server.Client.HubStatus status;
							string text;
							global::System.Guid? serverRepositoryId;
							global::System.DateTimeOffset? expirationDt;
							global::System.Version protocolVersion;
							string publicKey;
							global::Gibraltar.Server.Client.NetworkConnectionOptions agentLiveStreamOptions;
							global::Gibraltar.Server.Client.NetworkConnectionOptions clientLiveStreamOptions;
							global::Gibraltar.Server.Client.WebChannel webChannel = this.Connect(out status, out text, out serverRepositoryId, out expirationDt, out protocolVersion, out publicKey, out agentLiveStreamOptions, out clientLiveStreamOptions);
							object statusLock = this.m_StatusLock;
							lock (statusLock)
							{
								this.m_Status = status;
								this.m_StatusMessage = text;
								this.m_ExpirationDt = expirationDt;
								this.m_PublicKey = publicKey;
								this.m_AgentLiveStreamOptions = agentLiveStreamOptions;
								this.m_ClientLiveStreamOptions = clientLiveStreamOptions;
								this.m_ServerRepositoryId = serverRepositoryId;
								if (this.m_Status == global::Gibraltar.Server.Client.HubStatus.Unknown)
								{
									this.ProtocolVersion = protocolVersion;
								}
							}
							if (webChannel == null)
							{
								throw new global::Gibraltar.Server.Client.WebChannelConnectFailureException(text);
							}
							this.CurrentChannel = webChannel;
						}
						finally
						{
							this.m_HaveTriedToConnect = true;
						}
					}
					global::System.Threading.Monitor.PulseAll(this.m_ChannelLock);
					currentChannel = this.m_CurrentChannel;
				}
				return currentChannel;
			}
			set
			{
				object channelLock = this.m_ChannelLock;
				lock (channelLock)
				{
					if (value != this.m_CurrentChannel)
					{
						if (this.m_CurrentChannel != null)
						{
							this.m_CurrentChannel.Dispose();
							this.m_CurrentChannel.ConnectionStateChanged -= this.CurrentChannel_ConnectionStateChanged;
							this.m_CurrentChannel = null;
							this.m_HaveTriedToConnect = false;
						}
						if (value != null)
						{
							this.m_CurrentChannel = value;
							this.m_CurrentChannel.ConnectionStateChanged += this.CurrentChannel_ConnectionStateChanged;
						}
						global::System.Threading.Monitor.PulseAll(this.m_ChannelLock);
					}
				}
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x0001EDC8 File Offset: 0x0001CFC8
		public string EndUserTestUrl
		{
			get
			{
				if (string.IsNullOrEmpty(this.m_TestUrl))
				{
					global::Gibraltar.Server.Client.WebChannel webChannel = null;
					string text3;
					try
					{
						global::Gibraltar.Server.Client.HubStatus hubStatus;
						string text;
						global::System.Guid? guid;
						global::System.DateTimeOffset? dateTimeOffset;
						global::System.Version version;
						string text2;
						global::Gibraltar.Server.Client.NetworkConnectionOptions networkConnectionOptions;
						global::Gibraltar.Server.Client.NetworkConnectionOptions networkConnectionOptions2;
						webChannel = global::Gibraltar.Server.Client.HubConnection.Connect(this.m_UseGibraltarService, this.m_CustomerName, this.m_Server, this.m_Port, this.m_UseSsl, this.m_ApplicationBaseDirectory, this.m_Repository, out hubStatus, out text, out guid, out dateTimeOffset, out version, out text2, out networkConnectionOptions, out networkConnectionOptions2);
						if (webChannel == null)
						{
							webChannel = global::Gibraltar.Server.Client.HubConnection.ConnectToHub(this.m_UseGibraltarService, this.m_CustomerName, this.m_Server, this.m_Port, this.m_UseSsl, this.m_ApplicationBaseDirectory, this.m_Repository);
						}
						text3 = webChannel.EntryUri.AbsoluteUri;
					}
					finally
					{
						if (webChannel != null)
						{
							webChannel.Dispose();
						}
					}
					if (!string.IsNullOrEmpty(text3))
					{
						if (text3.EndsWith("HUB", global::System.StringComparison.OrdinalIgnoreCase))
						{
							text3 = text3.Remove(text3.Length - 4);
						}
						else if (text3.EndsWith("HUB/", global::System.StringComparison.OrdinalIgnoreCase))
						{
							text3 = text3.Remove(text3.Length - 4);
						}
					}
					this.m_TestUrl = text3;
				}
				return this.m_TestUrl;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x0001EEF4 File Offset: 0x0001D0F4
		public bool SupportsFileFragments
		{
			get
			{
				return this.ProtocolVersion >= global::Gibraltar.Server.Client.HubConnection.Hub30ProtocolVersion;
			}
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0001EF10 File Offset: 0x0001D110
		private global::Gibraltar.Server.Client.WebChannel ResetChannel()
		{
			object channelLock = this.m_ChannelLock;
			global::Gibraltar.Server.Client.WebChannel currentChannel;
			lock (channelLock)
			{
				this.CurrentChannel = null;
				currentChannel = this.CurrentChannel;
				global::System.Threading.Monitor.PulseAll(this.m_ChannelLock);
			}
			return currentChannel;
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x0001EF60 File Offset: 0x0001D160
		private static void AsyncCanConnect(object state)
		{
			global::Gibraltar.Server.Client.HubConnectionCanConnectEventArgs e = null;
			try
			{
				object[] array = (object[])state;
				bool useGibraltarService = (bool)array[0];
				string customerName = (string)array[1];
				string server = (string)array[2];
				int port = (int)array[3];
				bool useSsl = (bool)array[4];
				string applicationBaseDirectory = (string)array[5];
				string repository = (string)array[6];
				global::Gibraltar.Server.Client.HubStatus value;
				string message;
				bool isValid = global::Gibraltar.Server.Client.HubConnection.CanConnect(useGibraltarService, customerName, server, port, useSsl, applicationBaseDirectory, repository, out value, out message);
				e = new global::Gibraltar.Server.Client.HubConnectionCanConnectEventArgs(null, false, new global::Gibraltar.Server.Client.HubStatus?(value), message, isValid);
			}
			catch (global::System.Exception error)
			{
				e = new global::Gibraltar.Server.Client.HubConnectionCanConnectEventArgs(error, false, null, null, false);
			}
			finally
			{
				global::Gibraltar.Server.Client.HubConnectionCanConnectEventHandler canConnectCompleted = global::Gibraltar.Server.Client.HubConnection.CanConnectCompleted;
				if (canConnectCompleted != null)
				{
					canConnectCompleted(null, e);
				}
			}
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x0001F034 File Offset: 0x0001D234
		private global::Gibraltar.Server.Client.WebChannel Connect(out global::Gibraltar.Server.Client.HubStatus status, out string statusMessage, out global::System.Guid? serverRepositoryId, out global::System.DateTimeOffset? expirationDt, out global::System.Version protocolVersion, out string publicKey, out global::Gibraltar.Server.Client.NetworkConnectionOptions agentLiveStream, out global::Gibraltar.Server.Client.NetworkConnectionOptions clientLiveStream)
		{
			global::Gibraltar.Server.Client.WebChannel webChannel = global::Gibraltar.Server.Client.HubConnection.Connect(this.m_UseGibraltarService, this.m_CustomerName, this.m_Server, this.m_Port, this.m_UseSsl, this.m_ApplicationBaseDirectory, this.m_Repository, out status, out statusMessage, out serverRepositoryId, out expirationDt, out protocolVersion, out publicKey, out agentLiveStream, out clientLiveStream);
			if (webChannel != null)
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					webChannel.EnableLogging = this.m_EnableLogging;
					if (this.m_UseCredentials)
					{
						webChannel.AuthenticationProvider = global::Gibraltar.Server.Client.CachedCredentialsManager.GetCredentials(webChannel, this.m_UseRepositoryCredentials, this.m_ClientRepositoryId, this.m_KeyContainerName, this.m_UseMachineStore);
					}
					global::System.Threading.Monitor.PulseAll(this.m_Lock);
				}
			}
			return webChannel;
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0001F0F4 File Offset: 0x0001D2F4
		private static global::Gibraltar.Server.Client.WebChannel Connect(bool useGibraltarService, string customerName, string server, int port, bool useSsl, string applicationBaseDirectory, string repository, out global::Gibraltar.Server.Client.HubStatus status, out string statusMessage, out global::System.Guid? serverRepositoryId, out global::System.DateTimeOffset? expirationDt, out global::System.Version protocolVersion, out string publicKey, out global::Gibraltar.Server.Client.NetworkConnectionOptions agentLiveStream, out global::Gibraltar.Server.Client.NetworkConnectionOptions clientLiveStream)
		{
			global::Gibraltar.Server.Client.WebChannel webChannel = null;
			bool flag = true;
			status = global::Gibraltar.Server.Client.HubStatus.Maintenance;
			statusMessage = null;
			serverRepositoryId = null;
			expirationDt = null;
			protocolVersion = new global::System.Version();
			publicKey = null;
			agentLiveStream = null;
			clientLiveStream = null;
			try
			{
				global::Gibraltar.Server.Client.HubConnection.ValidateConfiguration(useGibraltarService, customerName, server, port, useSsl, applicationBaseDirectory);
			}
			catch (global::System.Exception ex)
			{
				flag = false;
				statusMessage = "Invalid configuration: " + ex.Message;
			}
			try
			{
				webChannel = global::Gibraltar.Server.Client.HubConnection.ConnectToHub(useGibraltarService, customerName, server, port, useSsl, applicationBaseDirectory, repository);
				global::Gibraltar.Server.Client.HubConfigurationGetRequest hubConfigurationGetRequest = new global::Gibraltar.Server.Client.HubConfigurationGetRequest();
				webChannel.AuthenticationProvider = global::Gibraltar.Server.Client.CachedCredentialsManager.GetCachedCredentials(webChannel, false, global::System.Guid.Empty, null, false);
				try
				{
					webChannel.ExecuteRequest(hubConfigurationGetRequest, 1);
				}
				catch (global::Gibraltar.Server.Client.WebChannelAuthorizationException ex2)
				{
					global::Gibraltar.Server.Client.HubConnection.Logger.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, ex2, true, "Loupe.Repository.Server", "Requesting updated credentials for the server connection due to " + ex2.GetType(), "We're going to assume the user can provide current credentials.\r\nDetails: {0}", new object[]
					{
						ex2.Message
					});
					if (!global::Gibraltar.Server.Client.CachedCredentialsManager.UpdateCredentials(webChannel, false))
					{
						throw;
					}
					webChannel.AuthenticationProvider = global::Gibraltar.Server.Client.CachedCredentialsManager.GetCredentials(webChannel, false, global::System.Guid.Empty, null, false);
					webChannel.ExecuteRequest(hubConfigurationGetRequest, 1);
				}
				global::Gibraltar.Server.Client.Data.HubConfigurationXml configuration = hubConfigurationGetRequest.Configuration;
				if (configuration.redirectRequested)
				{
					webChannel.Dispose();
					webChannel = global::Gibraltar.Server.Client.HubConnection.Connect(configuration.redirectUseGibraltarSds, configuration.redirectCustomerName, configuration.redirectHostName, configuration.redirectPort, configuration.redirectUseSsl, configuration.redirectApplicationBaseDirectory, configuration.redirectCustomerName, out status, out statusMessage, out serverRepositoryId, out expirationDt, out protocolVersion, out publicKey, out agentLiveStream, out clientLiveStream);
				}
				else
				{
					status = (global::Gibraltar.Server.Client.HubStatus)configuration.status;
					switch (status)
					{
					case global::Gibraltar.Server.Client.HubStatus.Unknown:
						break;
					case global::Gibraltar.Server.Client.HubStatus.Maintenance:
						statusMessage = "The Server is currently undergoing maintenance and can't process requests.";
						break;
					case global::Gibraltar.Server.Client.HubStatus.Expired:
						statusMessage = "The Server's license has expired.  " + (useGibraltarService ? "You can reactivate your license in seconds at www.GibraltarSoftware.com." : "To renew your license, run the Administration tool on the Loupe Server.");
						break;
					default:
						throw new global::System.ArgumentOutOfRangeException("status");
					}
					if (configuration.id != null)
					{
						serverRepositoryId = new global::System.Guid?(new global::System.Guid(configuration.id));
					}
					if (configuration.expirationDt != null)
					{
						expirationDt = new global::System.DateTimeOffset?(global::Gibraltar.Server.Client.Data.DataConverter.FromDateTimeOffsetXml(configuration.expirationDt));
					}
					publicKey = configuration.publicKey;
					if (!string.IsNullOrEmpty(configuration.protocolVersion))
					{
						protocolVersion = new global::System.Version(configuration.protocolVersion);
					}
					global::Gibraltar.Server.Client.Data.LiveStreamServerXml liveStream = configuration.liveStream;
					if (liveStream != null)
					{
						agentLiveStream = new global::Gibraltar.Server.Client.NetworkConnectionOptions
						{
							HostName = webChannel.HostName,
							Port = liveStream.agentPort,
							UseSsl = liveStream.useSsl
						};
						clientLiveStream = new global::Gibraltar.Server.Client.NetworkConnectionOptions
						{
							HostName = webChannel.HostName,
							Port = liveStream.clientPort,
							UseSsl = liveStream.useSsl
						};
					}
				}
			}
			catch (global::Gibraltar.Server.Client.WebChannelFileNotFoundException)
			{
				flag = false;
				if (useGibraltarService)
				{
					status = global::Gibraltar.Server.Client.HubStatus.Expired;
					statusMessage = "The specified customer name is not valid";
				}
				else
				{
					statusMessage = "The server does not support this service or the specified directory is not valid";
				}
			}
			catch (global::System.Net.WebException ex3)
			{
				flag = false;
				global::System.Net.HttpWebResponse httpWebResponse = (global::System.Net.HttpWebResponse)ex3.Response;
				statusMessage = httpWebResponse.StatusDescription;
				if (useGibraltarService)
				{
					global::System.Net.HttpStatusCode statusCode = httpWebResponse.StatusCode;
					if (statusCode == global::System.Net.HttpStatusCode.BadRequest || statusCode == global::System.Net.HttpStatusCode.NotFound)
					{
						status = global::Gibraltar.Server.Client.HubStatus.Expired;
						statusMessage = "The specified customer name is not valid";
					}
				}
				else
				{
					global::System.Net.HttpStatusCode statusCode = httpWebResponse.StatusCode;
					if (statusCode != global::System.Net.HttpStatusCode.BadRequest)
					{
						if (statusCode == global::System.Net.HttpStatusCode.NotFound)
						{
							statusMessage = "No service could be found with the provided information";
						}
					}
					else
					{
						statusMessage = "The server does not support this service or the specified directory is not valid";
					}
				}
			}
			catch (global::System.Exception ex4)
			{
				flag = false;
				statusMessage = ex4.Message;
			}
			if (!flag && webChannel != null)
			{
				webChannel.Dispose();
				webChannel = null;
			}
			return webChannel;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0001F50C File Offset: 0x0001D70C
		private static global::Gibraltar.Server.Client.WebChannel ConnectToHub(bool useGibraltarService, string customerName, string server, int port, bool useSsl, string applicationBaseDirectory, string repository)
		{
			global::Gibraltar.Server.Client.WebChannel result;
			if (useGibraltarService)
			{
				result = new global::Gibraltar.Server.Client.WebChannel(global::Gibraltar.Server.Client.HubConnection.Logger, true, "hub.gibraltarsoftware.com", string.Format("Customers/{0}/", customerName) + "Hub", global::Gibraltar.Server.Client.HubConnection.ClientProtocolVersion);
			}
			else
			{
				string applicationBaseDirectory2 = global::Gibraltar.Server.Client.HubConnection.EffectiveApplicationBaseDirectory(applicationBaseDirectory, repository) + "Hub";
				result = new global::Gibraltar.Server.Client.WebChannel(global::Gibraltar.Server.Client.HubConnection.Logger, useSsl, server, port, applicationBaseDirectory2, global::Gibraltar.Server.Client.HubConnection.ClientProtocolVersion);
			}
			return result;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0001F580 File Offset: 0x0001D780
		private static string EffectiveApplicationBaseDirectory(string applicationBaseDirectory, string repository)
		{
			string text = applicationBaseDirectory ?? string.Empty;
			if (!string.IsNullOrEmpty(text) && !text.EndsWith("/"))
			{
				text += "/";
			}
			if (!string.IsNullOrEmpty(repository))
			{
				text += string.Format("Customers/{0}/", repository);
			}
			return text;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0001F5E4 File Offset: 0x0001D7E4
		private bool IsRootHub(string hostName, int port, bool useSsl, string applicationBaseDirectory)
		{
			bool result = true;
			if (string.IsNullOrEmpty(hostName))
			{
				result = false;
			}
			else if (this.m_UseGibraltarService)
			{
				if (!hostName.Equals("hub.gibraltarsoftware.com", global::System.StringComparison.OrdinalIgnoreCase))
				{
					result = false;
				}
				if (!string.Equals(string.Format("Customers/{0}/", this.m_CustomerName), applicationBaseDirectory))
				{
					result = false;
				}
			}
			else if (!hostName.Equals(this.m_Server, global::System.StringComparison.OrdinalIgnoreCase) || this.m_Port != port || this.m_UseSsl != useSsl)
			{
				result = false;
			}
			else if (!string.Equals(global::Gibraltar.Server.Client.HubConnection.EffectiveApplicationBaseDirectory(this.m_ApplicationBaseDirectory, this.m_Repository), applicationBaseDirectory))
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0001F69C File Offset: 0x0001D89C
		private void CurrentChannel_ConnectionStateChanged(object sender, global::Gibraltar.Server.Client.ChannelConnectionStateChangedEventArgs e)
		{
			this.OnConnectionStateChanged(e.State);
		}

		// Token: 0x0400035B RID: 859
		public const string SHA1HashHeader = "X-Gibraltar-Hash";

		// Token: 0x0400035C RID: 860
		internal const string LogCategory = "Loupe.Repository.Server";

		// Token: 0x0400035D RID: 861
		internal const string SdsServerName = "hub.gibraltarsoftware.com";

		// Token: 0x0400035E RID: 862
		private const string SdsEntryPath = "Customers/{0}/";

		// Token: 0x0400035F RID: 863
		public static readonly global::System.Version Hub30ProtocolVersion = new global::System.Version(1, 2);

		// Token: 0x04000360 RID: 864
		public static readonly global::System.Version ClientProtocolVersion = global::Gibraltar.Server.Client.HubConnection.Hub30ProtocolVersion;

		// Token: 0x04000361 RID: 865
		private readonly object m_Lock = new object();

		// Token: 0x04000362 RID: 866
		private readonly object m_ChannelLock = new object();

		// Token: 0x04000363 RID: 867
		private readonly bool m_UseGibraltarService;

		// Token: 0x04000364 RID: 868
		private readonly string m_CustomerName;

		// Token: 0x04000365 RID: 869
		private readonly bool m_UseSsl;

		// Token: 0x04000366 RID: 870
		private readonly string m_Server;

		// Token: 0x04000367 RID: 871
		private readonly int m_Port;

		// Token: 0x04000368 RID: 872
		private readonly string m_ApplicationBaseDirectory;

		// Token: 0x04000369 RID: 873
		private readonly string m_Repository;

		// Token: 0x0400036A RID: 874
		private string m_TestUrl;

		// Token: 0x0400036B RID: 875
		private global::Gibraltar.Server.Client.WebChannel m_CurrentChannel;

		// Token: 0x0400036C RID: 876
		private bool m_EnableLogging;

		// Token: 0x0400036D RID: 877
		private readonly object m_StatusLock = new object();

		// Token: 0x0400036E RID: 878
		private volatile bool m_HaveTriedToConnect;

		// Token: 0x0400036F RID: 879
		private global::System.Guid? m_ServerRepositoryId;

		// Token: 0x04000370 RID: 880
		private global::Gibraltar.Server.Client.HubStatus m_Status;

		// Token: 0x04000371 RID: 881
		private string m_StatusMessage;

		// Token: 0x04000372 RID: 882
		private global::System.DateTimeOffset? m_ExpirationDt;

		// Token: 0x04000373 RID: 883
		private string m_PublicKey;

		// Token: 0x04000374 RID: 884
		private global::System.Version m_ProtocolVersion;

		// Token: 0x04000375 RID: 885
		private global::Gibraltar.Server.Client.NetworkConnectionOptions m_AgentLiveStreamOptions;

		// Token: 0x04000376 RID: 886
		private global::Gibraltar.Server.Client.NetworkConnectionOptions m_ClientLiveStreamOptions;

		// Token: 0x04000377 RID: 887
		private bool m_UseCredentials;

		// Token: 0x04000378 RID: 888
		private bool m_UseRepositoryCredentials;

		// Token: 0x04000379 RID: 889
		private global::System.Guid m_ClientRepositoryId;

		// Token: 0x0400037A RID: 890
		private string m_KeyContainerName;

		// Token: 0x0400037B RID: 891
		private bool m_UseMachineStore;
	}
}
