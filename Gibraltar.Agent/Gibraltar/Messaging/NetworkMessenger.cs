using System;
using System.Collections.Generic;
using System.Threading;
using Gibraltar.Data;
using Gibraltar.Messaging.Net;
using Gibraltar.Monitor;
using Gibraltar.Server.Client;
using Loupe.Extensibility.Data;

namespace Gibraltar.Messaging
{
	// Token: 0x02000229 RID: 553
	internal class NetworkMessenger : global::Gibraltar.Messaging.MessengerBase
	{
		// Token: 0x06001BC8 RID: 7112 RVA: 0x00060A1C File Offset: 0x0005EC1C
		public NetworkMessenger() : base(false)
		{
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x00060A88 File Offset: 0x0005EC88
		public global::Gibraltar.Messaging.ICachedMessengerPacket[] HeaderPackets
		{
			get
			{
				return base.Publisher.HeaderPackets;
			}
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x00060A98 File Offset: 0x0005EC98
		public void StartLiveView(global::System.Guid repositoryId, global::System.Guid channelId, long sequenceOffset = 0L)
		{
			if (this.m_ConnectionOptions != null)
			{
				this.StartLiveView(this.m_ConnectionOptions, repositoryId, channelId, sequenceOffset);
			}
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x00060ABC File Offset: 0x0005ECBC
		public void StartLiveView(global::Gibraltar.Server.Client.NetworkConnectionOptions options, global::System.Guid repositoryId, global::System.Guid channelId, long sequenceOffset = 0L)
		{
			if (channelId == global::System.Guid.Empty)
			{
				throw new global::System.ArgumentNullException("channelId");
			}
			global::Gibraltar.Messaging.NetworkWriter networkWriter = new global::Gibraltar.Messaging.NetworkWriter(this, options, repositoryId, channelId, sequenceOffset);
			networkWriter.Start();
			this.RegisterWriter(networkWriter);
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00060B04 File Offset: 0x0005ED04
		public void SendToServer(global::Gibraltar.Messaging.Net.SendSessionCommandMessage sendSessionCommand)
		{
			try
			{
				if (!global::Gibraltar.Monitor.Log.SendSessions(new global::Gibraltar.Data.SessionCriteria?(sendSessionCommand.Criteria), null, true))
				{
					global::Gibraltar.Monitor.Log.EndFile("Remote Live Sessions client requested the log file be rolled over");
				}
			}
			catch (global::System.Exception ex)
			{
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Network.Client", "Failed to process send to server command", "An exception was thrown that prevents us from completing the command:\r\n{0}", new object[]
					{
						ex.Message
					});
				}
			}
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00060B80 File Offset: 0x0005ED80
		public void SendSummary()
		{
			global::Gibraltar.Server.Client.LiveSessionPublisher client = this.m_Client;
			if (client != null)
			{
				this.SendSummary(client);
			}
			global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Server.Client.LiveSessionPublisher> localProxyConnections = this.m_LocalProxyConnections;
			global::Gibraltar.Server.Client.LiveSessionPublisher[] array;
			lock (localProxyConnections)
			{
				array = new global::Gibraltar.Server.Client.LiveSessionPublisher[this.m_LocalProxyConnections.Count];
				this.m_LocalProxyConnections.Values.CopyTo(array, 0);
			}
			foreach (global::Gibraltar.Server.Client.LiveSessionPublisher publisher in array)
			{
				this.SendSummary(publisher);
			}
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x00060C18 File Offset: 0x0005EE18
		private void SendSummary(global::Gibraltar.Server.Client.LiveSessionPublisher publisher)
		{
			try
			{
				if (publisher.IsConnected)
				{
					publisher.SendSummary();
				}
			}
			catch (global::System.Exception ex)
			{
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Network.Client", "Failed to send summary to the server or other network proxy", "An exception was thrown that prevents us from sending the latest session summary to the server:\r\nServer or Proxy: {0}\r\n{1} Exception:\r\n{2}", new object[]
					{
						publisher,
						ex.GetType(),
						ex.Message
					});
				}
			}
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00060C90 File Offset: 0x0005EE90
		internal void ActivateWriter(global::Gibraltar.Messaging.NetworkWriter writer, long sequenceOffset = 0L)
		{
			try
			{
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Network.Messenger", "New remote network viewer connection starting", "We will process the connection attempt and feed it our buffered data.\r\nRemote Endpoint: {0}\r\nSequence Offset: {1:N0}", new object[]
					{
						writer,
						sequenceOffset
					});
				}
				global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter> activeClients = this.m_ActiveClients;
				lock (activeClients)
				{
					global::Gibraltar.Messaging.ICachedMessengerPacket[] headerPackets = this.HeaderPackets;
					if (headerPackets != null)
					{
						writer.Write(headerPackets);
					}
					global::Gibraltar.Messaging.IMessengerPacket[] array = this.m_Buffer.ToArray();
					if (sequenceOffset > 0L && array.Length != 0 && array[0].Sequence <= sequenceOffset)
					{
						if (array[array.Length - 1].Sequence <= sequenceOffset)
						{
							array = new global::Gibraltar.Messaging.IMessengerPacket[0];
						}
						else
						{
							int num = 0;
							for (int i = array.Length - 2; i >= 0; i--)
							{
								if (array[i].Sequence <= sequenceOffset)
								{
									num = i + 1;
								}
							}
							global::Gibraltar.Messaging.IMessengerPacket[] array2 = new global::Gibraltar.Messaging.IMessengerPacket[array.Length - num];
							try
							{
								global::System.Array.Copy(array, num, array2, 0, array.Length - num);
								array = array2;
							}
							catch (global::System.ArgumentException ex)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, false, "Loupe.Network.Messenger", "Unable to create offset buffer due to " + ex.GetType(), "Original Buffer Length: {0}\r\nFirst Packet Offset: {1}\r\nOffset Buffer Length: {2}", new object[]
								{
									array.Length,
									num,
									array2.Length
								});
							}
						}
					}
					if (array.Length != 0)
					{
						writer.Write(array);
					}
					if (!writer.IsFailed && !this.m_ActiveClients.Contains(writer))
					{
						this.m_ActiveClients.Add(writer);
					}
				}
			}
			catch (global::System.Exception exception)
			{
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.RecordException(0, exception, null, "Loupe.Network.Messenger", true);
				}
			}
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00060E9C File Offset: 0x0005F09C
		protected override void OnInitialize(global::Gibraltar.Messaging.MessengerConfiguration configuration)
		{
			base.Caption = "Network Viewer Messenger";
			base.Description = "Messenger implementation that sends session data live over a Tcp connection.";
			base.OverflowMode = global::Gibraltar.Messaging.OverflowMode.Drop;
			global::Gibraltar.Messaging.NetworkMessengerConfiguration networkMessengerConfiguration = (global::Gibraltar.Messaging.NetworkMessengerConfiguration)configuration;
			if (networkMessengerConfiguration.AllowLocalClients)
			{
				this.m_DiscoveryFileMonitor = new global::Gibraltar.Messaging.LocalServerDiscoveryFileMonitor();
				this.m_DiscoveryFileMonitor.FileChanged += this.DiscoveryFileMonitorOnFileChanged;
				this.m_DiscoveryFileMonitor.FileDeleted += this.DiscoveryFileMonitorOnFileDeleted;
				this.m_DiscoveryFileMonitor.Start();
			}
			if (networkMessengerConfiguration.AllowRemoteClients)
			{
				global::Gibraltar.Messaging.ServerConfiguration server = global::Gibraltar.Monitor.Log.Configuration.Server;
				if (server.Enabled)
				{
					this.m_HubConnection = new global::Gibraltar.Server.Client.HubConnection(server);
					this.m_EnableOutbound = true;
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Network.Messenger", "Remote live view enabled, will be availalble once connected to server", "Server Configuraiton:\r\n{0}", new object[]
						{
							server
						});
					}
				}
			}
			base.AutoFlush = true;
			base.AutoFlushInterval = 5;
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x00060F8C File Offset: 0x0005F18C
		protected override void OnClose()
		{
			if (this.m_IsClosed)
			{
				return;
			}
			if (this.m_DiscoveryFileMonitor != null)
			{
				try
				{
					this.m_DiscoveryFileMonitor.FileChanged -= this.DiscoveryFileMonitorOnFileChanged;
					this.m_DiscoveryFileMonitor.FileDeleted -= this.DiscoveryFileMonitorOnFileDeleted;
					this.m_DiscoveryFileMonitor.Stop();
				}
				catch
				{
				}
			}
			global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter> deadClients = this.m_DeadClients;
			lock (deadClients)
			{
				global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter> obj = this.m_ActiveClients;
				lock (obj)
				{
					foreach (global::Gibraltar.Messaging.NetworkWriter item in this.m_ActiveClients)
					{
						if (!this.m_DeadClients.Contains(item))
						{
							this.m_DeadClients.Add(item);
						}
					}
					this.m_ActiveClients.Clear();
					this.m_Buffer.Clear();
				}
				obj = this.m_PendingClients;
				lock (obj)
				{
					foreach (global::Gibraltar.Messaging.NetworkWriter item2 in this.m_PendingClients)
					{
						if (!this.m_DeadClients.Contains(item2))
						{
							this.m_DeadClients.Add(item2);
						}
					}
					this.m_PendingClients.Clear();
				}
			}
			this.DropDeadConnections();
			global::System.Collections.Generic.List<global::Gibraltar.Server.Client.LiveSessionPublisher> list = null;
			global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Server.Client.LiveSessionPublisher> localProxyConnections = this.m_LocalProxyConnections;
			lock (localProxyConnections)
			{
				if (this.m_LocalProxyConnections.Count > 0)
				{
					list = new global::System.Collections.Generic.List<global::Gibraltar.Server.Client.LiveSessionPublisher>(this.m_LocalProxyConnections.Values);
					this.m_LocalProxyConnections.Clear();
				}
			}
			if (list != null)
			{
				foreach (global::Gibraltar.Server.Client.LiveSessionPublisher liveSessionPublisher in list)
				{
					liveSessionPublisher.Close();
				}
			}
			if (this.m_Client != null)
			{
				this.m_Client.Dispose();
				this.m_Client = null;
			}
			if (this.m_HubConnection != null)
			{
				this.m_HubConnection.Dispose();
				this.m_HubConnection = null;
			}
			this.m_IsClosed = true;
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x00061238 File Offset: 0x0005F438
		protected override void OnCommand(global::Gibraltar.Messaging.MessagingCommand command, object state, bool writeThrough, ref global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest maintenanceRequested)
		{
			if (command != global::Gibraltar.Messaging.MessagingCommand.ExitMode)
			{
				if (command == global::Gibraltar.Messaging.MessagingCommand.OpenRemoteViewer)
				{
					global::Gibraltar.Server.Client.NetworkConnectionOptions options = (global::Gibraltar.Server.Client.NetworkConnectionOptions)state;
					this.StartLiveView(options, global::System.Guid.Empty, global::System.Guid.NewGuid(), 0L);
					return;
				}
			}
			else
			{
				this.OnClose();
			}
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00061278 File Offset: 0x0005F478
		protected override void OnWrite(global::Gibraltar.Messaging.IMessengerPacket packet, bool writeThrough, ref global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest maintenanceRequested)
		{
			if (this.m_IsClosed)
			{
				return;
			}
			if (global::Gibraltar.Messaging.NetworkWriter.CanWritePacket(packet))
			{
				global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter> activeClients = this.m_ActiveClients;
				lock (activeClients)
				{
					this.CachePacket(packet);
					foreach (global::Gibraltar.Messaging.NetworkWriter networkWriter in this.m_ActiveClients)
					{
						try
						{
							if (networkWriter.IsFailed || networkWriter.IsClosed)
							{
								maintenanceRequested = global::Gibraltar.Messaging.MessengerBase.MaintenanceModeRequest.Regular;
							}
							else
							{
								networkWriter.Write(packet);
							}
						}
						catch (global::System.Exception exception)
						{
							global::Gibraltar.ErrorNotifier.Notify(this, exception);
						}
					}
				}
			}
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x0006134C File Offset: 0x0005F54C
		protected override void OnFlush()
		{
			this.AttemptRemoteConnectionAsync();
			this.SendSummary();
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0006135C File Offset: 0x0005F55C
		protected override void OnMaintenance()
		{
			this.DropDeadConnections();
			this.AttemptRemoteConnectionAsync();
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0006136C File Offset: 0x0005F56C
		private void CachePacket(global::Gibraltar.Messaging.IMessengerPacket packet)
		{
			if (packet == null)
			{
				return;
			}
			global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter> activeClients = this.m_ActiveClients;
			lock (activeClients)
			{
				if (this.m_BufferSize > 0)
				{
					this.m_Buffer.Enqueue(packet);
				}
				while (this.m_Buffer.Count > this.m_BufferSize)
				{
					this.m_Buffer.Dequeue();
				}
			}
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x000613E8 File Offset: 0x0005F5E8
		private void AttemptRemoteConnectionAsync()
		{
			if (!this.m_EnableOutbound)
			{
				return;
			}
			if (this.m_ActiveRemoteConnectionAttempt)
			{
				return;
			}
			this.m_ActiveRemoteConnectionAttempt = true;
			global::System.Threading.ThreadPool.QueueUserWorkItem(new global::System.Threading.WaitCallback(this.AsyncEnsureRemoteConnection));
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00061420 File Offset: 0x0005F620
		private void AsyncEnsureRemoteConnection(object state)
		{
			try
			{
				try
				{
					global::Gibraltar.Server.Client.HubConnection hubConnection = this.m_HubConnection;
					global::System.DateTimeOffset dateTimeOffset;
					lock (hubConnection)
					{
						dateTimeOffset = this.m_HubConfigurationExpiration;
					}
					global::Gibraltar.Server.Client.NetworkConnectionOptions networkConnectionOptions = null;
					if (!this.m_HubConnection.IsConnected || dateTimeOffset < global::System.DateTimeOffset.Now)
					{
						this.m_HubConnection.Reconnect();
						global::System.DateTimeOffset now = global::System.DateTimeOffset.Now;
						if (this.m_HubConnection.Status == global::Gibraltar.Server.Client.HubStatus.Expired)
						{
							if (this.m_HubConnection.ExpirationDt == null)
							{
								dateTimeOffset = now.AddDays(1.0);
							}
							else
							{
								global::System.TimeSpan timeSpan = now - this.m_HubConnection.ExpirationDt.Value;
								if (timeSpan.TotalHours < 24.0)
								{
									dateTimeOffset = now.AddMinutes(15.0);
								}
								else if (timeSpan.TotalDays < 4.0)
								{
									dateTimeOffset = now.AddHours(6.0);
								}
								else
								{
									dateTimeOffset = now.AddDays(1.0);
								}
							}
							if (!global::Gibraltar.Monitor.Log.SilentMode)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Network.Messenger", "Loupe server status is expired so no remote live view possible.", "Will check the server configuration again at {0}", new object[]
								{
									dateTimeOffset
								});
							}
						}
						else
						{
							dateTimeOffset = now.AddMinutes((double)(60 - now.Minute));
							networkConnectionOptions = this.m_HubConnection.AgentLiveStreamOptions;
							if (networkConnectionOptions == null && !global::Gibraltar.Monitor.Log.SilentMode)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Network.Messenger", "Remote live view not available due to server configuration", "The server is configured to have live view disabled so even though we have it enabled there is no live view.", new object[0]);
							}
						}
						hubConnection = this.m_HubConnection;
						lock (hubConnection)
						{
							this.m_HubConfigurationExpiration = dateTimeOffset;
						}
						if (networkConnectionOptions != this.m_ConnectionOptions)
						{
							if (!global::Gibraltar.Monitor.Log.SilentMode)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Network.Messenger", "Loupe server live view options are different than our running configuration so we will close the client.", "New configuration:\r\n{0}", new object[]
								{
									networkConnectionOptions
								});
							}
							this.m_ConnectionOptions = networkConnectionOptions;
							this.CloseClient(this.m_Client);
							this.m_Client = null;
						}
					}
				}
				catch (global::System.Exception ex)
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Network.Messenger", "Remote viewer connecton attempt failed", "While attempting to open our outbound connection to the proxy server an exception was thrown.  We will retry again later.\r\nException: {0}", new object[]
						{
							ex.Message
						});
					}
				}
				try
				{
					if (this.m_Client == null && this.m_ConnectionOptions != null)
					{
						global::Gibraltar.Server.Client.LiveSessionPublisher liveSessionPublisher = new global::Gibraltar.Server.Client.LiveSessionPublisher(this, this.m_ConnectionOptions);
						liveSessionPublisher.Start();
						this.m_Client = liveSessionPublisher;
						this.SendSummary(this.m_Client);
					}
				}
				catch (global::System.Exception ex2)
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex2, "Loupe.Network.Messenger", "Remote viewer connecton attempt failed", "While attempting to open our outbound connection to the proxy server an exception was thrown.  We will retry again later.\r\nException: {0}", new object[]
						{
							ex2.Message
						});
					}
				}
			}
			finally
			{
				this.m_ActiveRemoteConnectionAttempt = false;
			}
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x00061784 File Offset: 0x0005F984
		private void CloseClient(global::Gibraltar.Server.Client.LiveSessionPublisher deadClient)
		{
			if (deadClient == null)
			{
				return;
			}
			global::Gibraltar.Server.Client.NetworkConnectionOptions options = deadClient.GetOptions();
			if (options != null)
			{
				global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter> deadClients = this.m_DeadClients;
				lock (deadClients)
				{
					global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter> obj = this.m_ActiveClients;
					lock (obj)
					{
						foreach (global::Gibraltar.Messaging.NetworkWriter networkWriter in this.m_ActiveClients)
						{
							if (networkWriter.GetOptions().Equals(options) && !this.m_DeadClients.Contains(networkWriter))
							{
								this.m_DeadClients.Add(networkWriter);
							}
						}
					}
					obj = this.m_PendingClients;
					lock (obj)
					{
						foreach (global::Gibraltar.Messaging.NetworkWriter networkWriter2 in this.m_PendingClients)
						{
							if (networkWriter2.GetOptions().Equals(options) && !this.m_DeadClients.Contains(networkWriter2))
							{
								this.m_DeadClients.Add(networkWriter2);
							}
						}
						this.m_PendingClients.Clear();
					}
				}
				this.DropDeadConnections();
			}
			deadClient.Dispose();
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x00061950 File Offset: 0x0005FB50
		private void DropDeadConnections()
		{
			global::Gibraltar.Messaging.NetworkWriter[] array = null;
			global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter> deadClients = this.m_DeadClients;
			lock (deadClients)
			{
				if (this.m_DeadClients.Count > 0)
				{
					array = new global::Gibraltar.Messaging.NetworkWriter[this.m_DeadClients.Count];
					this.m_DeadClients.CopyTo(array);
				}
				this.m_DeadClients.Clear();
			}
			if (array != null)
			{
				foreach (global::Gibraltar.Messaging.NetworkWriter writer in array)
				{
					this.UnregisterWriter(writer);
				}
			}
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x000619EC File Offset: 0x0005FBEC
		private void RegisterWriter(global::Gibraltar.Messaging.NetworkWriter newWriter)
		{
			newWriter.Closed += this.NetworkWriter_Closed;
			newWriter.Connected += this.NetworkWriter_Connected;
			newWriter.Failed += this.NetworkWriter_Failed;
			global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter> pendingClients = this.m_PendingClients;
			lock (pendingClients)
			{
				this.m_PendingClients.Add(newWriter);
			}
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x00061A64 File Offset: 0x0005FC64
		private void UnregisterWriter(global::Gibraltar.Messaging.NetworkWriter writer)
		{
			writer.Closed -= this.NetworkWriter_Closed;
			writer.Connected -= this.NetworkWriter_Connected;
			writer.Failed -= this.NetworkWriter_Failed;
			global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter> obj = this.m_PendingClients;
			lock (obj)
			{
				this.m_PendingClients.Remove(writer);
			}
			obj = this.m_ActiveClients;
			lock (obj)
			{
				this.m_ActiveClients.Remove(writer);
			}
			writer.Dispose();
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00061B18 File Offset: 0x0005FD18
		private void DiscoveryFileMonitorOnFileChanged(object sender, global::Gibraltar.Messaging.LocalServerDiscoveryFileEventArgs e)
		{
			global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Server.Client.LiveSessionPublisher> localProxyConnections = this.m_LocalProxyConnections;
			lock (localProxyConnections)
			{
				global::Gibraltar.Server.Client.LiveSessionPublisher liveSessionPublisher;
				if (!this.m_LocalProxyConnections.TryGetValue(e.File.FileNamePath, out liveSessionPublisher) && e.File.IsAlive)
				{
					liveSessionPublisher = new global::Gibraltar.Server.Client.LiveSessionPublisher(this, e.File);
					liveSessionPublisher.Start();
					this.m_LocalProxyConnections.Add(e.File.FileNamePath, liveSessionPublisher);
				}
			}
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x00061BA8 File Offset: 0x0005FDA8
		private void DiscoveryFileMonitorOnFileDeleted(object sender, global::Gibraltar.Messaging.LocalServerDiscoveryFileEventArgs e)
		{
			global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Server.Client.LiveSessionPublisher> localProxyConnections = this.m_LocalProxyConnections;
			global::Gibraltar.Server.Client.LiveSessionPublisher liveSessionPublisher;
			lock (localProxyConnections)
			{
				if (this.m_LocalProxyConnections.TryGetValue(e.File.FileNamePath, out liveSessionPublisher) && liveSessionPublisher != null)
				{
					this.m_LocalProxyConnections.Remove(e.File.FileNamePath);
				}
			}
			this.CloseClient(liveSessionPublisher);
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x00061C20 File Offset: 0x0005FE20
		private void NetworkWriter_Closed(object sender, global::System.EventArgs e)
		{
			global::Gibraltar.Messaging.NetworkWriter networkWriter = (global::Gibraltar.Messaging.NetworkWriter)sender;
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Network.Messenger", "Remote network viewer connection closed", "Remote Endpoint: {0}", new object[]
				{
					networkWriter
				});
			}
			global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter> deadClients = this.m_DeadClients;
			lock (deadClients)
			{
				if (!this.m_DeadClients.Contains(networkWriter))
				{
					this.m_DeadClients.Add(networkWriter);
				}
			}
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x00061CA4 File Offset: 0x0005FEA4
		private void NetworkWriter_Connected(object sender, global::System.EventArgs e)
		{
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x00061CA8 File Offset: 0x0005FEA8
		private void NetworkWriter_Failed(object sender, global::Gibraltar.Messaging.NetworkEventArgs e)
		{
			global::Gibraltar.Messaging.NetworkWriter networkWriter = (global::Gibraltar.Messaging.NetworkWriter)sender;
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Network.Messenger", "Remote network viewer connection failed", "We will add it to our dead writers collection and it will get permanently removed in the next maintenance cycle.\r\nRemote Endpoint: {0}", new object[]
				{
					networkWriter
				});
			}
			global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter> deadClients = this.m_DeadClients;
			lock (deadClients)
			{
				if (!this.m_DeadClients.Contains(networkWriter))
				{
					this.m_DeadClients.Add(networkWriter);
				}
			}
		}

		// Token: 0x04000A01 RID: 2561
		public new const string LogCategory = "Loupe.Network.Messenger";

		// Token: 0x04000A02 RID: 2562
		private const int DefaultBufferSize = 1000;

		// Token: 0x04000A03 RID: 2563
		private int m_BufferSize = 1000;

		// Token: 0x04000A04 RID: 2564
		private readonly object m_Lock = new object();

		// Token: 0x04000A05 RID: 2565
		private readonly global::System.Collections.Generic.Queue<global::Gibraltar.Messaging.IMessengerPacket> m_Buffer = new global::System.Collections.Generic.Queue<global::Gibraltar.Messaging.IMessengerPacket>();

		// Token: 0x04000A06 RID: 2566
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter> m_PendingClients = new global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter>();

		// Token: 0x04000A07 RID: 2567
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter> m_ActiveClients = new global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter>();

		// Token: 0x04000A08 RID: 2568
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter> m_DeadClients = new global::System.Collections.Generic.List<global::Gibraltar.Messaging.NetworkWriter>();

		// Token: 0x04000A09 RID: 2569
		private readonly global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Server.Client.LiveSessionPublisher> m_LocalProxyConnections = new global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Server.Client.LiveSessionPublisher>(global::System.StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000A0A RID: 2570
		private global::Gibraltar.Messaging.LocalServerDiscoveryFileMonitor m_DiscoveryFileMonitor;

		// Token: 0x04000A0B RID: 2571
		private volatile bool m_ActiveRemoteConnectionAttempt;

		// Token: 0x04000A0C RID: 2572
		private global::Gibraltar.Server.Client.HubConnection m_HubConnection;

		// Token: 0x04000A0D RID: 2573
		private global::Gibraltar.Server.Client.LiveSessionPublisher m_Client;

		// Token: 0x04000A0E RID: 2574
		private bool m_EnableOutbound;

		// Token: 0x04000A0F RID: 2575
		private global::Gibraltar.Server.Client.NetworkConnectionOptions m_ConnectionOptions;

		// Token: 0x04000A10 RID: 2576
		private bool m_IsClosed;

		// Token: 0x04000A11 RID: 2577
		private global::System.DateTimeOffset m_HubConfigurationExpiration;
	}
}
