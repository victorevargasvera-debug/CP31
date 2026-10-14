using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Threading;
using Loupe.Extensibility.Data;

namespace Gibraltar.Server.Client
{
	// Token: 0x0200012E RID: 302
	[global::System.Diagnostics.DebuggerDisplay("{HostName} State: {ConnectionState}")]
	internal class WebChannel : global::Gibraltar.Server.Client.IWebChannelConnection, global::System.IDisposable
	{
		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06000C49 RID: 3145 RVA: 0x0001FD80 File Offset: 0x0001DF80
		// (remove) Token: 0x06000C4A RID: 3146 RVA: 0x0001FDBC File Offset: 0x0001DFBC
		public event global::Gibraltar.Server.Client.ChannelConnectionStateChangedEventHandler ConnectionStateChanged;

		// Token: 0x06000C4B RID: 3147 RVA: 0x0001FDF8 File Offset: 0x0001DFF8
		public WebChannel(global::Gibraltar.Server.Client.IClientLogger logger, string hostName) : this(logger, false, hostName, null, null)
		{
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0001FE08 File Offset: 0x0001E008
		public WebChannel(global::Gibraltar.Server.Client.IClientLogger logger, bool useSsl, string hostName, string applicationBaseDirectory, global::System.Version appProtocolVersion) : this(logger, useSsl, hostName, useSsl ? 443 : 80, applicationBaseDirectory, appProtocolVersion)
		{
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0001FE38 File Offset: 0x0001E038
		public WebChannel(global::Gibraltar.Server.Client.IClientLogger logger, bool useSsl, string hostName, int port, string applicationBaseDirectory, global::System.Version appProtocolVersion)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			if (hostName != null)
			{
				this.m_HostName = hostName.Trim();
			}
			if (string.IsNullOrEmpty(hostName))
			{
				throw new global::System.ArgumentNullException("hostName", "A server name must be provided for a connection");
			}
			this.m_Logger = logger;
			this.m_UseSsl = useSsl;
			this.m_Port = port;
			this.m_ApplicationBaseDirectory = applicationBaseDirectory;
			this.AppProtocolVersion = appProtocolVersion;
			if (!string.IsNullOrEmpty(this.m_ApplicationBaseDirectory))
			{
				this.m_ApplicationBaseDirectory = this.m_ApplicationBaseDirectory.Trim();
				if (!this.m_ApplicationBaseDirectory.StartsWith("/"))
				{
					this.m_ApplicationBaseDirectory = "/" + this.m_ApplicationBaseDirectory;
				}
				if (!this.m_ApplicationBaseDirectory.EndsWith("/"))
				{
					this.m_ApplicationBaseDirectory += "/";
				}
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000C4E RID: 3150 RVA: 0x0001FF5C File Offset: 0x0001E15C
		// (set) Token: 0x06000C4F RID: 3151 RVA: 0x0001FF64 File Offset: 0x0001E164
		public global::System.Version AppProtocolVersion { get; set; }

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x0001FF70 File Offset: 0x0001E170
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x0001FF78 File Offset: 0x0001E178
		public bool EnableLogging { get; set; }

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x0001FF84 File Offset: 0x0001E184
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x0001FF8C File Offset: 0x0001E18C
		public global::Gibraltar.Server.Client.IWebAuthenticationProvider AuthenticationProvider
		{
			get
			{
				return this.m_AuthenticationProvider;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_AuthenticationProvider = value;
					global::System.Threading.Monitor.PulseAll(this.m_Lock);
				}
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x0001FFD4 File Offset: 0x0001E1D4
		public string HostName
		{
			get
			{
				return this.m_HostName;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x0001FFDC File Offset: 0x0001E1DC
		public int Port
		{
			get
			{
				return this.m_Port;
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0001FFE4 File Offset: 0x0001E1E4
		public bool UseSsl
		{
			get
			{
				return this.m_UseSsl;
			}
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x0001FFEC File Offset: 0x0001E1EC
		public string ApplicationBaseDirectory
		{
			get
			{
				return this.m_ApplicationBaseDirectory;
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0001FFF4 File Offset: 0x0001E1F4
		public global::System.Uri EntryUri
		{
			get
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					if (this.m_BaseAddress != null)
					{
						return this.m_BaseAddress;
					}
				}
				return new global::System.Uri(this.CalculateBaseAddress());
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00020054 File Offset: 0x0001E254
		public global::Gibraltar.Server.Client.ChannelConnectionState ConnectionState
		{
			get
			{
				return this.m_ConnectionState;
			}
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x00020060 File Offset: 0x0001E260
		public void ExecuteRequest(global::Gibraltar.Server.Client.IWebRequest newRequest, int maxRetries)
		{
			if (newRequest == null)
			{
				throw new global::System.ArgumentNullException("newRequest");
			}
			if (newRequest.RequiresAuthentication && this.m_AuthenticationProvider == null)
			{
				throw new global::System.ArgumentException("The request requires authentication and no authentication provider is available.", "newRequest");
			}
			this.EnsureConnectionInitialized();
			this.m_Cancel = false;
			bool flag = false;
			bool flag2 = false;
			int num = 0;
			try
			{
				while (!this.m_Cancel && !flag && (maxRetries < 0 || num <= maxRetries))
				{
					try
					{
						if (this.m_ConnectionState == global::Gibraltar.Server.Client.ChannelConnectionState.Disconnected)
						{
							this.SetConnectionState(global::Gibraltar.Server.Client.ChannelConnectionState.Connecting);
						}
						else if (this.m_ConnectionState == global::Gibraltar.Server.Client.ChannelConnectionState.Connected)
						{
							this.SetConnectionState(global::Gibraltar.Server.Client.ChannelConnectionState.TransferingData);
						}
						if (newRequest.RequiresAuthentication && !this.m_AuthenticationProvider.IsAuthenticated)
						{
							this.Authenticate();
						}
						this.m_RequestSupportsAuthentication = newRequest.SupportsAuthentication;
						newRequest.ProcessRequest(this);
						this.SetConnectionState(global::Gibraltar.Server.Client.ChannelConnectionState.Connected);
						flag = true;
					}
					catch (global::System.Net.WebException ex)
					{
						global::System.Net.WebExceptionStatus status = ex.Status;
						if (status != global::System.Net.WebExceptionStatus.ProtocolError)
						{
							if (status == global::System.Net.WebExceptionStatus.MessageLengthLimitExceeded)
							{
								throw;
							}
							if (this.EnableLogging)
							{
								this.m_Logger.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, ex, true, "Loupe.Server.Client", "Connection error while making web channel request", "We received a communication exception while executing the current request on our channel.  Since it isn't an authentication exception we're going to retry the request.\r\nRequest:{0}\r\nError Count:{1}\r\nException:\r\n{0}", new object[]
								{
									newRequest,
									num,
									ex.Message
								});
							}
							this.SetConnectionState(global::Gibraltar.Server.Client.ChannelConnectionState.Disconnected);
							num++;
							flag2 = false;
							if (this.CanRetry(maxRetries, num))
							{
								if (num > 1)
								{
									this.SleepForConnection();
								}
							}
							else
							{
								if (ex.Status == global::System.Net.WebExceptionStatus.ConnectFailure || ex.Status == global::System.Net.WebExceptionStatus.NameResolutionFailure)
								{
									throw new global::Gibraltar.Server.Client.WebChannelConnectFailureException("Unable to connect to the destination server", ex, (ex.Response == null) ? null : ex.Response.ResponseUri);
								}
								if (ex.Status == global::System.Net.WebExceptionStatus.ConnectionClosed)
								{
									throw new global::Gibraltar.Server.Client.WebChannelConnectFailureException("Server refused connection", ex, (ex.Response == null) ? null : ex.Response.ResponseUri);
								}
								throw new global::Gibraltar.Server.Client.WebChannelException(ex.Message, ex, (ex.Response == null) ? null : ex.Response.ResponseUri);
							}
						}
						else
						{
							global::System.Net.HttpWebResponse httpWebResponse = (global::System.Net.HttpWebResponse)ex.Response;
							if (httpWebResponse.StatusCode == global::System.Net.HttpStatusCode.NotFound)
							{
								throw new global::Gibraltar.Server.Client.WebChannelFileNotFoundException("File not found", ex, httpWebResponse.ResponseUri);
							}
							if (httpWebResponse.StatusCode == global::System.Net.HttpStatusCode.Unauthorized)
							{
								if (this.m_AuthenticationProvider == null || !newRequest.SupportsAuthentication || flag2)
								{
									throw new global::Gibraltar.Server.Client.WebChannelAuthorizationException("Username or password not valid", ex, httpWebResponse.ResponseUri);
								}
								if (this.EnableLogging)
								{
									this.m_Logger.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, ex, true, "Loupe.Server.Client", "Attempting to authenticate to server", "Because we got an HTTP 401 error from the server we're going to attempt to authenticate with our server credentials and try again.  Status Description:\r\n{0}", new object[]
									{
										httpWebResponse.StatusDescription
									});
								}
								flag2 = true;
								this.Authenticate();
							}
							else if (httpWebResponse.StatusCode == global::System.Net.HttpStatusCode.MethodNotAllowed && !this.m_UseCompatibilityMethods)
							{
								this.m_UseCompatibilityMethods = true;
								this.SetUseCompatiblilityMethodsOverride(this.m_HostName, this.m_UseCompatibilityMethods);
								if (this.EnableLogging)
								{
									this.m_Logger.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, ex, true, "Loupe.Server.Client", "Switching to http method compatibility mode", "Because we got an HTTP 405 error from the server we're going to turn on Http method compatibility translation and try again.  Status Description:\r\n{0}", new object[]
									{
										httpWebResponse.StatusDescription
									});
								}
							}
							else
							{
								if (httpWebResponse.StatusCode != global::System.Net.HttpStatusCode.ExpectationFailed || this.m_UseHttpVersion10)
								{
									throw;
								}
								this.m_UseHttpVersion10 = true;
								this.SetUseHttpVersion10Override(this.m_HostName, this.m_UseHttpVersion10);
								if (this.EnableLogging)
								{
									this.m_Logger.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, ex, true, "Loupe.Server.Client", "Switching to http 1.0 compatibility mode", "Because we got an HTTP 417 error from the server we're going to turn on Http 1.0 compatibility translation and try again.  Status Description:\r\n{0}", new object[]
									{
										httpWebResponse.StatusDescription
									});
								}
							}
						}
					}
				}
			}
			catch (global::System.Exception ex2)
			{
				if (this.EnableLogging)
				{
					this.m_Logger.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, ex2, true, "Loupe.Server.Client", ex2.Message, "While executing a web channel request an exception was thrown, which will be thrown to our caller.\r\nRequest: {0}\r\n", new object[]
					{
						newRequest
					});
				}
				throw;
			}
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00020490 File Offset: 0x0001E690
		public void Authenticate()
		{
			if (this.EnableLogging)
			{
				this.m_Logger.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Server.Client", "Attempting to authenticate communication channel", null, new object[0]);
			}
			object @lock = this.m_Lock;
			global::Gibraltar.Server.Client.IWebAuthenticationProvider authenticationProvider;
			lock (@lock)
			{
				authenticationProvider = this.m_AuthenticationProvider;
				global::System.Threading.Monitor.PulseAll(this.m_Lock);
			}
			if (authenticationProvider == null)
			{
				if (this.EnableLogging)
				{
					this.m_Logger.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Server.Client", "Unable to authenticate communication channel", "There is no authentication provider available to process the current authentication request.", new object[0]);
				}
				return;
			}
			this.EnsureConnectionInitialized();
			try
			{
				this.ResetChannel(null);
				this.m_AuthenticationProvider.Login(this, this.m_Connection);
			}
			catch (global::System.Net.WebException ex)
			{
				if (ex.Status == global::System.Net.WebExceptionStatus.ProtocolError)
				{
					global::System.Net.HttpWebResponse httpWebResponse = (global::System.Net.HttpWebResponse)ex.Response;
					if (httpWebResponse.StatusCode == global::System.Net.HttpStatusCode.NotFound)
					{
						throw new global::Gibraltar.Server.Client.WebChannelFileNotFoundException("File not found", ex, httpWebResponse.ResponseUri);
					}
					if (httpWebResponse.StatusCode == global::System.Net.HttpStatusCode.Unauthorized)
					{
						throw new global::Gibraltar.Server.Client.WebChannelAuthorizationException("Username or password not valid", ex, ex.Response.ResponseUri);
					}
				}
				throw;
			}
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x000205CC File Offset: 0x0001E7CC
		public void Cancel()
		{
			this.m_Cancel = true;
			object obj = this.m_ResponseLock;
			lock (obj)
			{
				if (this.m_Connection != null && this.m_Connection.IsBusy)
				{
					this.m_Connection.CancelAsync();
				}
				global::System.Threading.Monitor.PulseAll(this.m_ResponseLock);
			}
			obj = this.m_Lock;
			lock (obj)
			{
				global::System.Threading.Monitor.PulseAll(this.m_Lock);
			}
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0002066C File Offset: 0x0001E86C
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0002067C File Offset: 0x0001E87C
		public byte[] DownloadData(string relativeUrl, int? timeout)
		{
			object requestLock = this.m_RequestLock;
			byte[] result;
			lock (requestLock)
			{
				this.PreProcessRequest(ref relativeUrl, null);
				global::System.Threading.Monitor.PulseAll(this.m_RequestLock);
				result = this.m_Connection.DownloadData(relativeUrl);
			}
			return result;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x000206D4 File Offset: 0x0001E8D4
		public byte[] DownloadData(string relativeUrl, global::System.Collections.Generic.IList<global::Gibraltar.NameValuePair<string>> additionalHeaders, int? timeout)
		{
			object requestLock = this.m_RequestLock;
			byte[] result;
			lock (requestLock)
			{
				this.PreProcessRequest(ref relativeUrl, null, additionalHeaders);
				byte[] array;
				try
				{
					array = this.m_Connection.DownloadData(relativeUrl);
				}
				finally
				{
					this.ResetChannel(additionalHeaders);
				}
				global::System.Threading.Monitor.PulseAll(this.m_RequestLock);
				result = array;
			}
			return result;
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00020748 File Offset: 0x0001E948
		public void DownloadFile(string relativeUrl, string destinationFileName, int? timeout)
		{
			object requestLock = this.m_RequestLock;
			lock (requestLock)
			{
				this.PreProcessRequest(ref relativeUrl, null);
				this.m_Connection.DownloadFile(relativeUrl, destinationFileName);
				global::System.Threading.Monitor.PulseAll(this.m_RequestLock);
			}
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x000207A0 File Offset: 0x0001E9A0
		public string DownloadString(string relativeUrl, int? timeout)
		{
			object requestLock = this.m_RequestLock;
			string result;
			lock (requestLock)
			{
				this.PreProcessRequest(ref relativeUrl, null);
				global::System.Threading.Monitor.PulseAll(this.m_RequestLock);
				result = this.m_Connection.DownloadString(relativeUrl);
			}
			return result;
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x000207F8 File Offset: 0x0001E9F8
		public byte[] UploadData(string relativeUrl, string method, string contentType, byte[] data, global::System.Collections.Generic.IList<global::Gibraltar.NameValuePair<string>> additionalHeaders, int? timeout)
		{
			object requestLock = this.m_RequestLock;
			byte[] result;
			lock (requestLock)
			{
				this.PreProcessRequest(ref relativeUrl, ref method, contentType, additionalHeaders);
				global::System.Threading.Monitor.PulseAll(this.m_RequestLock);
				result = this.m_Connection.UploadData(relativeUrl, method, data);
			}
			return result;
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00020858 File Offset: 0x0001EA58
		public byte[] UploadFile(string relativeUrl, string method, string contentType, string sourceFileNamePath, int? timeout)
		{
			object requestLock = this.m_RequestLock;
			byte[] result;
			lock (requestLock)
			{
				this.PreProcessRequest(ref relativeUrl, ref method, contentType, null);
				global::System.Threading.Monitor.PulseAll(this.m_RequestLock);
				result = this.m_Connection.UploadFile(relativeUrl, method, sourceFileNamePath);
			}
			return result;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x000208B8 File Offset: 0x0001EAB8
		public string UploadString(string relativeUrl, string method, string contentType, string data, int? timeout)
		{
			object requestLock = this.m_RequestLock;
			string result;
			lock (requestLock)
			{
				this.PreProcessRequest(ref relativeUrl, ref method, contentType, null);
				global::System.Threading.Monitor.PulseAll(this.m_RequestLock);
				result = this.m_Connection.UploadString(relativeUrl, method, data);
			}
			return result;
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x00020918 File Offset: 0x0001EB18
		protected virtual void Dispose(bool releaseManagedObjects)
		{
			if (releaseManagedObjects && !this.m_Disposed)
			{
				this.Cancel();
				if (this.m_Connection != null)
				{
					this.m_Connection.Dispose();
					this.m_Connection = null;
				}
				this.m_Disposed = true;
			}
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x00020968 File Offset: 0x0001EB68
		protected virtual void OnConnectionStateChanged(global::Gibraltar.Server.Client.ChannelConnectionState state)
		{
			global::Gibraltar.Server.Client.ChannelConnectionStateChangedEventHandler connectionStateChanged = this.ConnectionStateChanged;
			if (connectionStateChanged != null)
			{
				global::Gibraltar.Server.Client.ChannelConnectionStateChangedEventArgs e = new global::Gibraltar.Server.Client.ChannelConnectionStateChangedEventArgs(state);
				connectionStateChanged(this, e);
			}
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x00020998 File Offset: 0x0001EB98
		private byte[] DownloadDataAsync(string relativeUrl, int timeout)
		{
			this.m_DownloadDataRespose = null;
			this.m_Connection.DownloadDataCompleted += this.Connection_DownloadDataCompleted;
			byte[] result;
			try
			{
				this.m_Connection.DownloadDataAsync(this.GenerateUri(relativeUrl));
				global::System.DateTimeOffset left = global::System.DateTimeOffset.UtcNow.AddSeconds((double)timeout);
				object responseLock = this.m_ResponseLock;
				global::System.Net.DownloadDataCompletedEventArgs downloadDataRespose;
				lock (responseLock)
				{
					while (this.m_Connection.IsBusy)
					{
						global::System.Threading.Monitor.Wait(this.m_ResponseLock, 256);
						if (left <= global::System.DateTimeOffset.UtcNow)
						{
							this.m_Connection.CancelAsync();
						}
					}
					downloadDataRespose = this.m_DownloadDataRespose;
					global::System.Threading.Monitor.PulseAll(this.m_ResponseLock);
				}
				if (downloadDataRespose == null)
				{
					throw new global::Gibraltar.Server.Client.GibraltarNetworkException("Unable to complete the network request, no response could be determined.");
				}
				if (downloadDataRespose.Error != null)
				{
					throw downloadDataRespose.Error;
				}
				if (downloadDataRespose.Cancelled)
				{
					throw new global::Gibraltar.Server.Client.GibraltarTimeoutException(string.Format("The request did not complete within the allowed time of {0} seconds.", timeout));
				}
				result = downloadDataRespose.Result;
			}
			finally
			{
				this.m_Connection.DownloadDataCompleted -= this.Connection_DownloadDataCompleted;
				this.m_DownloadDataRespose = null;
			}
			return result;
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00020ADC File Offset: 0x0001ECDC
		private void DownloadFileAsync(string relativeUrl, string destinationFileName, int timeout)
		{
			this.m_DownloadFileRespose = null;
			this.m_Connection.DownloadFileCompleted += this.Connection_DownloadFileCompleted;
			try
			{
				this.m_Connection.DownloadFileAsync(this.GenerateUri(relativeUrl), destinationFileName);
				global::System.DateTimeOffset left = global::System.DateTimeOffset.UtcNow.AddSeconds((double)timeout);
				object responseLock = this.m_ResponseLock;
				global::System.ComponentModel.AsyncCompletedEventArgs downloadFileRespose;
				lock (responseLock)
				{
					while (this.m_Connection.IsBusy)
					{
						global::System.Threading.Monitor.Wait(this.m_ResponseLock, 1000);
						if (left <= global::System.DateTimeOffset.UtcNow)
						{
							this.m_Connection.CancelAsync();
						}
					}
					downloadFileRespose = this.m_DownloadFileRespose;
					global::System.Threading.Monitor.PulseAll(this.m_ResponseLock);
				}
				if (downloadFileRespose == null)
				{
					throw new global::Gibraltar.Server.Client.GibraltarNetworkException("Unable to complete the network request, no response could be determined.");
				}
				if (downloadFileRespose.Error != null)
				{
					throw downloadFileRespose.Error;
				}
				if (downloadFileRespose.Cancelled)
				{
					throw new global::Gibraltar.Server.Client.GibraltarTimeoutException(string.Format("The request did not complete within the allowed time of {0} seconds.", timeout));
				}
			}
			finally
			{
				this.m_Connection.DownloadFileCompleted -= this.Connection_DownloadFileCompleted;
				this.m_DownloadFileRespose = null;
			}
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00020C18 File Offset: 0x0001EE18
		private string DownloadStringAsync(string relativeUrl, int timeout)
		{
			this.m_DownloadDataRespose = null;
			this.m_Connection.DownloadStringCompleted += this.Connection_DownloadStringCompleted;
			string result;
			try
			{
				this.m_Connection.DownloadStringAsync(this.GenerateUri(relativeUrl));
				global::System.DateTimeOffset left = global::System.DateTimeOffset.UtcNow.AddSeconds((double)timeout);
				object responseLock = this.m_ResponseLock;
				global::System.Net.DownloadStringCompletedEventArgs downloadStringRespose;
				lock (responseLock)
				{
					while (this.m_Connection.IsBusy)
					{
						global::System.Threading.Monitor.Wait(this.m_ResponseLock, 256);
						if (left <= global::System.DateTimeOffset.UtcNow)
						{
							this.m_Connection.CancelAsync();
						}
					}
					downloadStringRespose = this.m_DownloadStringRespose;
					global::System.Threading.Monitor.PulseAll(this.m_ResponseLock);
				}
				if (downloadStringRespose == null)
				{
					throw new global::Gibraltar.Server.Client.GibraltarNetworkException("Unable to complete the network request, no response could be determined.");
				}
				if (downloadStringRespose.Error != null)
				{
					throw downloadStringRespose.Error;
				}
				if (downloadStringRespose.Cancelled)
				{
					throw new global::Gibraltar.Server.Client.GibraltarTimeoutException(string.Format("The request did not complete within the allowed time of {0} seconds.", timeout));
				}
				result = downloadStringRespose.Result;
			}
			finally
			{
				this.m_Connection.DownloadStringCompleted -= this.Connection_DownloadStringCompleted;
				this.m_DownloadDataRespose = null;
			}
			return result;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00020D5C File Offset: 0x0001EF5C
		private byte[] UploadDataAsync(string relativeUrl, string method, byte[] data)
		{
			this.m_UploadDataRespose = null;
			this.m_Connection.UploadDataCompleted += this.Connection_UploadDataCompleted;
			byte[] result;
			try
			{
				this.m_Connection.UploadDataAsync(this.GenerateUri(relativeUrl), method, data);
				object responseLock = this.m_ResponseLock;
				global::System.Net.UploadDataCompletedEventArgs uploadDataRespose;
				lock (responseLock)
				{
					while (this.m_UploadDataRespose == null)
					{
						global::System.Threading.Monitor.Wait(this.m_ResponseLock, 1000);
					}
					uploadDataRespose = this.m_UploadDataRespose;
					global::System.Threading.Monitor.PulseAll(this.m_ResponseLock);
				}
				if (uploadDataRespose.Error != null)
				{
					throw uploadDataRespose.Error;
				}
				result = uploadDataRespose.Result;
			}
			finally
			{
				this.m_Connection.UploadDataCompleted -= this.Connection_UploadDataCompleted;
				this.m_UploadDataRespose = null;
			}
			return result;
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00020E40 File Offset: 0x0001F040
		private byte[] UploadFileAsync(string relativeUrl, string method, string sourceFileNamePath)
		{
			this.m_UploadFileRespose = null;
			this.m_Connection.UploadFileCompleted += this.Connection_UploadFileCompleted;
			byte[] result;
			try
			{
				this.m_Connection.UploadFileAsync(this.GenerateUri(relativeUrl), method, sourceFileNamePath);
				object responseLock = this.m_ResponseLock;
				global::System.Net.UploadFileCompletedEventArgs uploadFileRespose;
				lock (responseLock)
				{
					while (this.m_UploadFileRespose == null)
					{
						global::System.Threading.Monitor.Wait(this.m_ResponseLock, 1000);
					}
					uploadFileRespose = this.m_UploadFileRespose;
					global::System.Threading.Monitor.PulseAll(this.m_ResponseLock);
				}
				if (uploadFileRespose.Error != null)
				{
					throw uploadFileRespose.Error;
				}
				result = uploadFileRespose.Result;
			}
			finally
			{
				this.m_Connection.UploadFileCompleted -= this.Connection_UploadFileCompleted;
				this.m_UploadFileRespose = null;
			}
			return result;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00020F24 File Offset: 0x0001F124
		private void EnsureConnectionInitialized()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_Connection == null)
				{
					global::Gibraltar.Server.Client.ExtendedTimeoutWebClient extendedTimeoutWebClient = new global::Gibraltar.Server.Client.ExtendedTimeoutWebClient();
					extendedTimeoutWebClient.BaseAddress = this.CalculateBaseAddress();
					extendedTimeoutWebClient.Encoding = global::System.Text.Encoding.UTF8;
					extendedTimeoutWebClient.Timeout = 120000;
					extendedTimeoutWebClient.Proxy = global::System.Net.WebRequest.DefaultWebProxy;
					if (extendedTimeoutWebClient.Proxy == null)
					{
						extendedTimeoutWebClient.Proxy = global::System.Net.WebRequest.GetSystemWebProxy();
					}
					if (extendedTimeoutWebClient.Proxy != null && extendedTimeoutWebClient.Proxy.Credentials == null)
					{
						extendedTimeoutWebClient.Proxy.Credentials = global::System.Net.CredentialCache.DefaultCredentials;
					}
					this.m_BaseAddress = new global::System.Uri(extendedTimeoutWebClient.BaseAddress);
					this.m_Connection = extendedTimeoutWebClient;
				}
				global::System.Threading.Monitor.PulseAll(this.m_Lock);
			}
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00020FFC File Offset: 0x0001F1FC
		private bool CanRetry(int maxRetries, int errorCount)
		{
			return maxRetries < 0 || errorCount <= maxRetries;
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00021010 File Offset: 0x0001F210
		private string CalculateBaseAddress()
		{
			bool flag = true;
			if (!this.m_UseSsl && (this.m_Port == 0 || this.m_Port == 80))
			{
				flag = false;
			}
			else if (this.m_UseSsl && (this.m_Port == 0 || this.m_Port == 443))
			{
				flag = false;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(1024);
			stringBuilder.AppendFormat("{0}://{1}", this.UseSsl ? "https" : "http", this.HostName);
			if (flag)
			{
				stringBuilder.AppendFormat(":{0}", this.m_Port);
			}
			if (!string.IsNullOrEmpty(this.m_ApplicationBaseDirectory))
			{
				stringBuilder.Append(this.m_ApplicationBaseDirectory);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x000210EC File Offset: 0x0001F2EC
		private void ResetChannel(global::System.Collections.Generic.IList<global::Gibraltar.NameValuePair<string>> additionalHeaders)
		{
			this.m_Connection.Headers.Remove("X-Request-Method");
			this.m_Connection.Headers.Remove("X-Request-Timestamp");
			this.m_Connection.Headers.Remove("X-Request-App-Protocol");
			if (additionalHeaders != null)
			{
				foreach (global::Gibraltar.NameValuePair<string> nameValuePair in additionalHeaders)
				{
					this.m_Connection.Headers.Remove(nameValuePair.Name);
				}
			}
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00021194 File Offset: 0x0001F394
		private void PreProcessRequest(ref string relativeUrl, string contentType)
		{
			string text = "GET";
			this.PreProcessRequest(ref relativeUrl, ref text, contentType, null);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x000211B8 File Offset: 0x0001F3B8
		private void PreProcessRequest(ref string relativeUrl, string contentType, global::System.Collections.Generic.IList<global::Gibraltar.NameValuePair<string>> additionalHeaders)
		{
			string text = "GET";
			this.PreProcessRequest(ref relativeUrl, ref text, contentType, additionalHeaders);
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x000211DC File Offset: 0x0001F3DC
		private void PreProcessRequest(ref string relativeUrl, ref string method, string contentType, global::System.Collections.Generic.IList<global::Gibraltar.NameValuePair<string>> additionalHeaders)
		{
			if (this.m_FirstRequest)
			{
				this.m_UseCompatibilityMethods = this.GetUseCompatiblilityMethodsOverride(this.m_HostName);
				this.m_UseHttpVersion10 = this.GetUseHttpVersion10Override(this.m_HostName);
				this.m_FirstRequest = false;
			}
			relativeUrl = (relativeUrl.StartsWith("/") ? relativeUrl.Substring(1) : relativeUrl);
			this.ResetChannel(additionalHeaders);
			if (additionalHeaders != null)
			{
				foreach (global::Gibraltar.NameValuePair<string> nameValuePair in additionalHeaders)
				{
					this.m_Connection.Headers[nameValuePair.Name] = nameValuePair.Value;
				}
			}
			this.m_Connection.Headers["Content-Type"] = contentType;
			if (this.m_UseCompatibilityMethods)
			{
				method = method.ToUpperInvariant();
				if (method.Equals("PUT") || method.Equals("DELETE"))
				{
					this.m_Connection.Headers["X-Request-Method"] = method;
					method = "POST";
				}
			}
			this.m_Connection.UseHttpVersion10 = this.m_UseHttpVersion10;
			this.m_Connection.Headers["X-Request-Timestamp"] = global::System.DateTimeOffset.UtcNow.ToString("o");
			if (this.AppProtocolVersion != null)
			{
				this.m_Connection.Headers["X-Request-App-Protocol"] = this.AppProtocolVersion.ToString();
			}
			if (this.m_AuthenticationProvider != null)
			{
				this.m_AuthenticationProvider.PreProcessRequest(this, this.m_Connection, relativeUrl, this.m_RequestSupportsAuthentication);
			}
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x000213A4 File Offset: 0x0001F5A4
		private void SleepForConnection()
		{
			int num = global::System.Math.Min(this.m_RetryDelaySeconds * 2, 5);
			this.m_RetryDelaySeconds += num;
			this.m_RetryDelaySeconds = global::System.Math.Min(this.m_RetryDelaySeconds, 120);
			global::System.DateTimeOffset dateTimeOffset = global::System.DateTimeOffset.Now.AddSeconds((double)this.m_RetryDelaySeconds);
			global::System.DateTimeOffset now = global::System.DateTimeOffset.Now;
			object @lock = this.m_Lock;
			lock (@lock)
			{
				while (!this.m_Cancel && now < dateTimeOffset)
				{
					global::System.Threading.Monitor.Wait(this.m_Lock, global::System.Math.Min((int)(dateTimeOffset - now).TotalMilliseconds, 1));
					now = global::System.DateTimeOffset.Now;
				}
				global::System.Threading.Monitor.PulseAll(this.m_Lock);
			}
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00021478 File Offset: 0x0001F678
		private void SetConnectionState(global::Gibraltar.Server.Client.ChannelConnectionState newState)
		{
			bool flag = false;
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (newState != this.m_ConnectionState)
				{
					flag = true;
					this.m_ConnectionState = newState;
				}
				global::System.Threading.Monitor.PulseAll(this.m_Lock);
			}
			if (flag)
			{
				this.OnConnectionStateChanged(newState);
			}
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x000214E4 File Offset: 0x0001F6E4
		private global::System.Uri GenerateUri(string relativeUrl)
		{
			return new global::System.Uri(this.m_BaseAddress, relativeUrl);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x000214F4 File Offset: 0x0001F6F4
		private bool GetUseCompatiblilityMethodsOverride(string server)
		{
			bool result = true;
			global::System.Collections.Generic.Dictionary<string, bool> obj = global::Gibraltar.Server.Client.WebChannel.s_ServerUseCompatibilitySetting;
			lock (obj)
			{
				bool flag;
				if (global::Gibraltar.Server.Client.WebChannel.s_ServerUseCompatibilitySetting.TryGetValue(server, out flag))
				{
					result = flag;
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Server.Client.WebChannel.s_ServerUseCompatibilitySetting);
			}
			return result;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0002154C File Offset: 0x0001F74C
		private bool GetUseHttpVersion10Override(string server)
		{
			bool result = this.m_UseHttpVersion10;
			global::System.Collections.Generic.Dictionary<string, bool> obj = global::Gibraltar.Server.Client.WebChannel.s_ServerUseHttpVersion10Setting;
			lock (obj)
			{
				bool flag;
				if (global::Gibraltar.Server.Client.WebChannel.s_ServerUseHttpVersion10Setting.TryGetValue(server, out flag))
				{
					result = flag;
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Server.Client.WebChannel.s_ServerUseHttpVersion10Setting);
			}
			return result;
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x000215A8 File Offset: 0x0001F7A8
		private void SetUseCompatiblilityMethodsOverride(string server, bool useCompatibilityMethods)
		{
			global::System.Collections.Generic.Dictionary<string, bool> obj = global::Gibraltar.Server.Client.WebChannel.s_ServerUseCompatibilitySetting;
			lock (obj)
			{
				if (global::Gibraltar.Server.Client.WebChannel.s_ServerUseCompatibilitySetting.ContainsKey(server))
				{
					global::Gibraltar.Server.Client.WebChannel.s_ServerUseCompatibilitySetting[server] = useCompatibilityMethods;
				}
				else
				{
					global::Gibraltar.Server.Client.WebChannel.s_ServerUseCompatibilitySetting.Add(server, useCompatibilityMethods);
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Server.Client.WebChannel.s_ServerUseCompatibilitySetting);
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00021614 File Offset: 0x0001F814
		private void SetUseHttpVersion10Override(string server, bool useHttpVersion10)
		{
			global::System.Collections.Generic.Dictionary<string, bool> obj = global::Gibraltar.Server.Client.WebChannel.s_ServerUseHttpVersion10Setting;
			lock (obj)
			{
				if (global::Gibraltar.Server.Client.WebChannel.s_ServerUseHttpVersion10Setting.ContainsKey(server))
				{
					global::Gibraltar.Server.Client.WebChannel.s_ServerUseHttpVersion10Setting[server] = useHttpVersion10;
				}
				else
				{
					global::Gibraltar.Server.Client.WebChannel.s_ServerUseHttpVersion10Setting.Add(server, useHttpVersion10);
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Server.Client.WebChannel.s_ServerUseHttpVersion10Setting);
			}
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00021680 File Offset: 0x0001F880
		private void Connection_DownloadDataCompleted(object sender, global::System.Net.DownloadDataCompletedEventArgs e)
		{
			object responseLock = this.m_ResponseLock;
			lock (responseLock)
			{
				this.m_DownloadDataRespose = e;
				global::System.Threading.Monitor.PulseAll(this.m_ResponseLock);
			}
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x000216C8 File Offset: 0x0001F8C8
		private void Connection_DownloadFileCompleted(object sender, global::System.ComponentModel.AsyncCompletedEventArgs e)
		{
			object responseLock = this.m_ResponseLock;
			lock (responseLock)
			{
				this.m_DownloadFileRespose = e;
				global::System.Threading.Monitor.PulseAll(this.m_ResponseLock);
			}
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00021710 File Offset: 0x0001F910
		private void Connection_DownloadStringCompleted(object sender, global::System.Net.DownloadStringCompletedEventArgs e)
		{
			object responseLock = this.m_ResponseLock;
			lock (responseLock)
			{
				this.m_DownloadStringRespose = e;
				global::System.Threading.Monitor.PulseAll(this.m_ResponseLock);
			}
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00021758 File Offset: 0x0001F958
		private void Connection_UploadDataCompleted(object sender, global::System.Net.UploadDataCompletedEventArgs e)
		{
			object responseLock = this.m_ResponseLock;
			lock (responseLock)
			{
				this.m_UploadDataRespose = e;
				global::System.Threading.Monitor.PulseAll(this.m_ResponseLock);
			}
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x000217A0 File Offset: 0x0001F9A0
		private void Connection_UploadFileCompleted(object sender, global::System.Net.UploadFileCompletedEventArgs e)
		{
			object responseLock = this.m_ResponseLock;
			lock (responseLock)
			{
				this.m_UploadFileRespose = e;
				global::System.Threading.Monitor.PulseAll(this.m_ResponseLock);
			}
		}

		// Token: 0x04000397 RID: 919
		private int m_RetryDelaySeconds = 1;

		// Token: 0x04000398 RID: 920
		private const int MinimumRetryDelaySeconds = 1;

		// Token: 0x04000399 RID: 921
		private const int MaximumRetryDelaySeconds = 120;

		// Token: 0x0400039A RID: 922
		private const int DefaultTimeooutSeconds = 120;

		// Token: 0x0400039B RID: 923
		private const string HeaderContentType = "Content-Type";

		// Token: 0x0400039C RID: 924
		private const string HeaderRequestMethod = "X-Request-Method";

		// Token: 0x0400039D RID: 925
		private const string HeaderRequestTimestamp = "X-Request-Timestamp";

		// Token: 0x0400039E RID: 926
		private const string HeaderRequestAppProtocolVersion = "X-Request-App-Protocol";

		// Token: 0x0400039F RID: 927
		public const string LogCategory = "Loupe.Server.Client";

		// Token: 0x040003A0 RID: 928
		private readonly object m_Lock = new object();

		// Token: 0x040003A1 RID: 929
		private readonly object m_RequestLock = new object();

		// Token: 0x040003A2 RID: 930
		private readonly object m_ResponseLock = new object();

		// Token: 0x040003A3 RID: 931
		private static readonly global::System.Collections.Generic.Dictionary<string, bool> s_ServerUseCompatibilitySetting = new global::System.Collections.Generic.Dictionary<string, bool>(global::System.StringComparer.OrdinalIgnoreCase);

		// Token: 0x040003A4 RID: 932
		private static readonly global::System.Collections.Generic.Dictionary<string, bool> s_ServerUseHttpVersion10Setting = new global::System.Collections.Generic.Dictionary<string, bool>(global::System.StringComparer.OrdinalIgnoreCase);

		// Token: 0x040003A5 RID: 933
		private volatile bool m_Cancel;

		// Token: 0x040003A6 RID: 934
		private global::Gibraltar.Server.Client.IWebAuthenticationProvider m_AuthenticationProvider;

		// Token: 0x040003A7 RID: 935
		private global::Gibraltar.Server.Client.ExtendedTimeoutWebClient m_Connection;

		// Token: 0x040003A8 RID: 936
		private global::System.Uri m_BaseAddress;

		// Token: 0x040003A9 RID: 937
		private volatile global::Gibraltar.Server.Client.ChannelConnectionState m_ConnectionState;

		// Token: 0x040003AA RID: 938
		private global::System.Net.DownloadDataCompletedEventArgs m_DownloadDataRespose;

		// Token: 0x040003AB RID: 939
		private global::System.ComponentModel.AsyncCompletedEventArgs m_DownloadFileRespose;

		// Token: 0x040003AC RID: 940
		private global::System.Net.DownloadStringCompletedEventArgs m_DownloadStringRespose;

		// Token: 0x040003AD RID: 941
		private global::System.Net.UploadDataCompletedEventArgs m_UploadDataRespose;

		// Token: 0x040003AE RID: 942
		private global::System.Net.UploadFileCompletedEventArgs m_UploadFileRespose;

		// Token: 0x040003AF RID: 943
		private readonly global::Gibraltar.Server.Client.IClientLogger m_Logger;

		// Token: 0x040003B0 RID: 944
		private readonly bool m_UseSsl;

		// Token: 0x040003B1 RID: 945
		private readonly string m_HostName;

		// Token: 0x040003B2 RID: 946
		private readonly int m_Port;

		// Token: 0x040003B3 RID: 947
		private readonly string m_ApplicationBaseDirectory;

		// Token: 0x040003B4 RID: 948
		private bool m_UseCompatibilityMethods;

		// Token: 0x040003B5 RID: 949
		private bool m_UseHttpVersion10;

		// Token: 0x040003B6 RID: 950
		private bool m_FirstRequest = true;

		// Token: 0x040003B7 RID: 951
		private bool m_RequestSupportsAuthentication;

		// Token: 0x040003B8 RID: 952
		private volatile bool m_Disposed;
	}
}
