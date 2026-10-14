using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Threading;
using Gibraltar.Monitor;
using Gibraltar.Serialization;
using Gibraltar.Server.Client;
using Loupe.Extensibility.Data;

namespace Gibraltar.Messaging.Net
{
	// Token: 0x02000247 RID: 583
	[global::System.Diagnostics.DebuggerDisplay("Endpoint: {Options} Connected: {IsConnected}")]
	internal abstract class NetworkClient : global::System.IDisposable
	{
		// Token: 0x14000087 RID: 135
		// (add) Token: 0x06001D40 RID: 7488 RVA: 0x00066B44 File Offset: 0x00064D44
		// (remove) Token: 0x06001D41 RID: 7489 RVA: 0x00066B80 File Offset: 0x00064D80
		public event global::System.EventHandler Connected;

		// Token: 0x14000088 RID: 136
		// (add) Token: 0x06001D42 RID: 7490 RVA: 0x00066BBC File Offset: 0x00064DBC
		// (remove) Token: 0x06001D43 RID: 7491 RVA: 0x00066BF8 File Offset: 0x00064DF8
		public event global::System.EventHandler Disconnected;

		// Token: 0x14000089 RID: 137
		// (add) Token: 0x06001D44 RID: 7492 RVA: 0x00066C34 File Offset: 0x00064E34
		// (remove) Token: 0x06001D45 RID: 7493 RVA: 0x00066C70 File Offset: 0x00064E70
		public event global::System.EventHandler Closed;

		// Token: 0x1400008A RID: 138
		// (add) Token: 0x06001D46 RID: 7494 RVA: 0x00066CAC File Offset: 0x00064EAC
		// (remove) Token: 0x06001D47 RID: 7495 RVA: 0x00066CE8 File Offset: 0x00064EE8
		public event global::Gibraltar.Messaging.NetworkEventHandler Failed;

		// Token: 0x06001D48 RID: 7496 RVA: 0x00066D24 File Offset: 0x00064F24
		protected NetworkClient(global::Gibraltar.Server.Client.NetworkConnectionOptions options, bool retryConnections, int majorVersion, int minorVersion)
		{
			if (options == null)
			{
				throw new global::System.ArgumentNullException("options");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_Options = options;
				this.m_RetryConnections = retryConnections;
				this.m_MajorVersion = majorVersion;
				this.m_MinorVersion = minorVersion;
			}
			this.CalculateStateMessage(null);
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x00066DA8 File Offset: 0x00064FA8
		protected NetworkClient(global::System.Net.Sockets.TcpClient tcpClient, int majorVersion, int minorVersion)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_SingleSocket = true;
				this.m_TcpClient = tcpClient;
				this.m_RetryConnections = false;
				this.m_MajorVersion = majorVersion;
				this.m_MinorVersion = minorVersion;
			}
			this.CalculateStateMessage(null);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x00066E1C File Offset: 0x0006501C
		public void Start()
		{
			this.Initialize();
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x00066E24 File Offset: 0x00065024
		public void Close()
		{
			try
			{
				this.ActionOnClosed();
			}
			catch (global::System.Exception exception)
			{
				global::Gibraltar.Monitor.Log.RecordException(0, exception, null, "Loupe.Network.Client", true);
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06001D4C RID: 7500 RVA: 0x00066E60 File Offset: 0x00065060
		public bool IsConnected
		{
			get
			{
				return this.m_Connected;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x00066E68 File Offset: 0x00065068
		public bool IsFailed
		{
			get
			{
				return this.m_ConnectionFailed;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06001D4E RID: 7502 RVA: 0x00066E70 File Offset: 0x00065070
		public bool IsClosed
		{
			get
			{
				return this.m_Closed;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x00066E7C File Offset: 0x0006507C
		public bool HasCorruptData
		{
			get
			{
				return this.m_HasCorruptData;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x00066E84 File Offset: 0x00065084
		public int PacketsLostCount
		{
			get
			{
				return this.m_PacketsLostCount;
			}
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x00066E8C File Offset: 0x0006508C
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00066E9C File Offset: 0x0006509C
		public global::Gibraltar.Server.Client.NetworkConnectionOptions GetOptions()
		{
			return this.m_Options.Clone();
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x00066EAC File Offset: 0x000650AC
		public override string ToString()
		{
			return this.m_StatusString;
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x00066EB4 File Offset: 0x000650B4
		protected virtual void Dispose(bool releaseManaged)
		{
			if (releaseManaged)
			{
				this.Close();
				this.DisposeMembers();
			}
		}

		// Token: 0x06001D55 RID: 7509
		protected abstract bool Connect();

		// Token: 0x06001D56 RID: 7510
		protected abstract void TransferData();

		// Token: 0x06001D57 RID: 7511 RVA: 0x00066EC8 File Offset: 0x000650C8
		protected virtual void OnClose()
		{
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x00066ECC File Offset: 0x000650CC
		protected virtual void OnConnected()
		{
			global::System.EventHandler connected = this.Connected;
			if (connected != null)
			{
				try
				{
					connected(this, new global::System.EventArgs());
				}
				catch (global::System.Exception ex)
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Network.Client", "Client exception thrown during connected event", ex.Message, new object[0]);
					}
				}
			}
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x00066F38 File Offset: 0x00065138
		protected virtual void OnDisconnected()
		{
			global::System.EventHandler disconnected = this.Disconnected;
			if (disconnected != null)
			{
				try
				{
					disconnected(this, new global::System.EventArgs());
				}
				catch (global::System.Exception ex)
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Network.Client", "Client exception thrown during disconnected event", ex.Message, new object[0]);
					}
				}
			}
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x00066FA4 File Offset: 0x000651A4
		protected virtual void OnClosed()
		{
			global::System.EventHandler closed = this.Closed;
			if (closed != null)
			{
				try
				{
					closed(this, new global::System.EventArgs());
				}
				catch (global::System.Exception ex)
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Network.Client", "Client exception thrown during closed event", ex.Message, new object[0]);
					}
				}
			}
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x00067010 File Offset: 0x00065210
		protected virtual void OnFailed(string message)
		{
			global::Gibraltar.Messaging.NetworkEventHandler failed = this.Failed;
			if (failed != null)
			{
				try
				{
					failed(this, new global::Gibraltar.Messaging.NetworkEventArgs(message));
				}
				catch (global::System.Exception ex)
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Network.Client", "Client exception thrown during failed event", ex.Message, new object[0]);
					}
				}
			}
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x0006707C File Offset: 0x0006527C
		protected virtual void OnPacketFactoryRegister(global::Gibraltar.Serialization.PacketReader packetReader)
		{
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x00067080 File Offset: 0x00065280
		protected global::Gibraltar.Server.Client.NetworkConnectionOptions Options
		{
			get
			{
				return this.m_Options;
			}
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x00067088 File Offset: 0x00065288
		protected void SendMessage(global::Gibraltar.Messaging.Net.NetworkMessage message)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				bool flag = false;
				global::System.Exception innerException = null;
				if (this.m_NetworkStream != null)
				{
					try
					{
						message.Write(this.m_NetworkStream);
						flag = true;
					}
					catch (global::System.Exception innerException)
					{
					}
				}
				if (!flag)
				{
					throw new global::Gibraltar.Server.Client.GibraltarNetworkException("Unable to send message, usually because the network connection was lost.", innerException);
				}
			}
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x00067104 File Offset: 0x00065304
		protected void SendPacket(global::Gibraltar.Serialization.IPacket packet)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				bool flag = false;
				global::System.Exception innerException = null;
				if (this.m_NetworkStream != null)
				{
					if (this.m_PacketWriter == null)
					{
						this.m_PacketWriter = new global::Gibraltar.Serialization.PacketWriter(this.m_NetworkStream, this.m_MajorVersion, this.m_MinorVersion);
					}
					try
					{
						this.m_PacketWriter.Write(packet);
						flag = true;
					}
					catch (global::System.Net.Sockets.SocketException ex)
					{
						this.ActionSocketFailed(ex);
					}
					catch (global::System.IO.IOException ex2)
					{
						if (ex2.InnerException != null && ex2.InnerException is global::System.Net.Sockets.SocketException)
						{
							this.ActionSocketFailed(ex2);
						}
						else
						{
							innerException = ex2;
						}
					}
					catch (global::System.Exception innerException)
					{
					}
				}
				if (!flag)
				{
					throw new global::Gibraltar.Server.Client.GibraltarNetworkException("Unable to send packet, usually because the network connection was lost.", innerException);
				}
			}
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x00067204 File Offset: 0x00065404
		protected global::Gibraltar.Messaging.Net.NetworkMessage ReadNetworkMessage()
		{
			if (this.m_NetworkSerializer == null)
			{
				this.m_NetworkSerializer = new global::Gibraltar.Messaging.Net.NetworkSerializer();
			}
			bool flag = false;
			global::Gibraltar.Messaging.Net.NetworkMessage networkMessage;
			do
			{
				networkMessage = this.m_NetworkSerializer.ReadNext();
				if (networkMessage == null)
				{
					byte[] buffer;
					int num = this.ReadSocket(out buffer);
					if (num == 0)
					{
						flag = true;
					}
					else
					{
						this.m_NetworkSerializer.AppendData(buffer, num);
					}
				}
			}
			while (!flag && networkMessage == null);
			return networkMessage;
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x0006726C File Offset: 0x0006546C
		protected global::Gibraltar.Serialization.IPacket ReadSerializedPacket()
		{
			if (this.m_PacketReader == null)
			{
				this.m_PacketStream = new global::Gibraltar.PipeStream(10240);
				this.m_PacketReader = new global::Gibraltar.Serialization.PacketReader(this.m_PacketStream, false, this.m_MajorVersion, this.m_MinorVersion);
				this.OnPacketFactoryRegister(this.m_PacketReader);
				if (this.m_NetworkSerializer != null)
				{
					byte[] unusedData = this.m_NetworkSerializer.UnusedData;
					if (unusedData != null && unusedData.Length != 0)
					{
						this.AppendToStream(this.m_PacketStream, unusedData, unusedData.Length);
					}
				}
			}
			bool flag = false;
			global::Gibraltar.Serialization.IPacket packet = null;
			for (;;)
			{
				if (!this.m_PacketReader.DataAvailable || packet != null)
				{
					if (packet == null)
					{
						byte[] buffer;
						int num = this.ReadSocket(out buffer);
						if (num == 0)
						{
							flag = true;
						}
						else
						{
							this.AppendToStream(this.m_PacketStream, buffer, num);
						}
					}
					if (flag || packet != null)
					{
						break;
					}
				}
				else
				{
					try
					{
						packet = this.m_PacketReader.Read();
					}
					catch (global::System.Exception ex)
					{
						this.m_HasCorruptData = true;
						this.m_PacketsLostCount++;
						global::Gibraltar.Serialization.GibraltarSerializationException ex2 = ex as global::Gibraltar.Serialization.GibraltarSerializationException;
						if (ex2 != null && ex2.StreamFailed)
						{
							if (!global::Gibraltar.Monitor.Log.SilentMode)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Network.Client", "Exception during packet stream read, unable to continue deserializing data", "While attempting to deserialize a packet an exception was reported. This has failed the stream so serialization will stop.\r\nException: {0}", new object[]
								{
									ex.Message
								});
							}
							throw;
						}
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Network.Client", "Exception during packet read, discarding packet and continuing", "While attempting to deserialize a packet an exception was reported.  Since this may be a problem with just this one packet, we'll continue deserializing.\r\nException: {0}", new object[]
							{
								ex.Message
							});
						}
					}
				}
			}
			this.m_PacketStream.Trim();
			return packet;
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x00067410 File Offset: 0x00065610
		protected void RemoteClose()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Network.Client", "Live view session ending at remote request", "We have received an indication from the other end of the connection that it is time to end the live view session.", new object[0]);
				}
				this.Close();
			}
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x00067474 File Offset: 0x00065674
		protected virtual bool RetryDelay(ref int defaultDelayMs)
		{
			return true;
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00067478 File Offset: 0x00065678
		private void AsyncNetworkStreamMain()
		{
			try
			{
				int num = 0;
				while (!this.m_Closed)
				{
					try
					{
						this.ActionOnDisconnected();
						using (global::System.Net.Sockets.TcpClient tcpClient = this.GetTcpClient())
						{
							this.m_TcpClient = tcpClient;
							this.CalculateStateMessage(tcpClient);
							global::System.Net.Sockets.NetworkStream stream = tcpClient.GetStream();
							global::System.IO.Stream networkStream;
							if (this.m_Options != null && this.m_Options.UseSsl)
							{
								try
								{
									global::System.Net.Security.SslStream sslStream = new global::System.Net.Security.SslStream(stream, false);
									sslStream.AuthenticateAsClient(this.m_Options.HostName);
									networkStream = sslStream;
									goto IL_74;
								}
								catch (global::System.Security.Authentication.AuthenticationException)
								{
									this.Close();
									throw;
								}
							}
							networkStream = stream;
							IL_74:
							object @lock = this.m_Lock;
							lock (@lock)
							{
								this.m_NetworkStream = networkStream;
							}
							bool flag = this.Connect();
							this.CalculateStateMessage(tcpClient);
							if (flag)
							{
								num = 0;
								this.ActionOnConnected();
								this.TransferData();
							}
						}
					}
					catch (global::System.Threading.ThreadAbortException)
					{
						throw;
					}
					catch (global::Gibraltar.Server.Client.GibraltarNetworkException exception)
					{
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Monitor.LogWriteMode.Queued, exception, "Loupe.Network.Client", "Recovering from network failure", "The TCP Socket has been disposed and now we will prepare to reconnect.\r\nPrevious Failures: {0:N0}\r\nConnection Info: {1}", new object[]
							{
								num,
								this.m_Options
							});
						}
					}
					catch (global::System.Exception ex)
					{
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Network.Client", "Unexpected exception while working with network stream", "We will clear the current state and attempt to re-establish (if allowed)\r\n{0}\r\nException: {1}", new object[]
							{
								this,
								ex
							});
						}
					}
					finally
					{
						this.CalculateStateMessage(null);
						if (!this.m_RetryConnections)
						{
							this.Close();
						}
						this.DisposeMembers();
					}
					if (!this.m_Closed)
					{
						int millisecondsTimeout = 0;
						if (num != 0)
						{
							if (num < 5)
							{
								millisecondsTimeout = 500;
							}
							else if (num < 13)
							{
								millisecondsTimeout = 15000;
							}
							else
							{
								millisecondsTimeout = 60000;
							}
						}
						if (!this.RetryDelay(ref millisecondsTimeout))
						{
							this.Close();
						}
						else
						{
							num++;
							global::System.Threading.Thread.Sleep(millisecondsTimeout);
						}
					}
				}
			}
			catch (global::System.Threading.ThreadAbortException)
			{
				throw;
			}
			catch (global::System.Exception ex2)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex2, "Loupe.Network.Client", "Background network reader thread failed", "The thread is exiting due to an exception and the client will effectively be dead.\r\nException: {0}", new object[]
				{
					ex2.Message
				});
				this.ActionOnDisconnected();
			}
			finally
			{
				this.CalculateStateMessage(null);
				this.m_BackgroundReader = null;
			}
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x000677A8 File Offset: 0x000659A8
		private void DisposeMembers()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				global::Gibraltar.Messaging.Net.NetworkClient.SafeDispose(this.m_PacketWriter);
				this.m_PacketWriter = null;
				global::Gibraltar.Messaging.Net.NetworkClient.SafeDispose(this.m_NetworkStream);
				this.m_NetworkStream = null;
				global::Gibraltar.Messaging.Net.NetworkClient.SafeDispose(this.m_NetworkSerializer);
				this.m_NetworkSerializer = null;
				global::Gibraltar.Messaging.Net.NetworkClient.SafeDispose(this.m_PacketReader);
				this.m_PacketReader = null;
				global::Gibraltar.Messaging.Net.NetworkClient.SafeDispose(this.m_PacketStream);
				this.m_PacketStream = null;
			}
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x00067838 File Offset: 0x00065A38
		private static void SafeDispose(global::System.IDisposable disposableObject)
		{
			if (disposableObject != null)
			{
				try
				{
					disposableObject.Dispose();
				}
				catch (global::System.Exception exception)
				{
					global::Gibraltar.Monitor.Log.RecordException(0, exception, null, "Loupe.Network.Client", true);
				}
			}
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x0006787C File Offset: 0x00065A7C
		private void Initialize()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_BackgroundReader == null)
				{
					this.m_BackgroundReader = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.AsyncNetworkStreamMain));
					this.m_BackgroundReader.IsBackground = true;
					this.m_BackgroundReader.Name = "Loupe Tcp Network Client";
					this.m_BackgroundReader.Start();
				}
			}
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x00067900 File Offset: 0x00065B00
		private void AppendToStream(global::System.IO.Stream seeekableStream, byte[] buffer, int length)
		{
			if (length <= 0)
			{
				return;
			}
			long position = seeekableStream.Position;
			seeekableStream.Position = seeekableStream.Length;
			seeekableStream.Write(buffer, 0, length);
			seeekableStream.Position = position;
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x0006793C File Offset: 0x00065B3C
		private void ActionSocketFailed(global::System.Exception ex)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_Connected)
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Network.Client", "Network Socket Failed", "We received an exception from the socket when performing an operation and will assume it has failed.\r\n{0}\r\nException: {1}", new object[]
						{
							this.m_StatusString,
							ex.Message
						});
					}
					this.ActionOnDisconnected();
					if (!this.m_RetryConnections)
					{
						this.ActionOnFailed(ex.Message);
					}
				}
			}
			throw new global::Gibraltar.Server.Client.GibraltarNetworkException("The network socket has failed", ex);
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x000679E0 File Offset: 0x00065BE0
		private void ActionOnConnected()
		{
			bool flag = false;
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (!this.m_Connected)
				{
					this.m_Connected = true;
					flag = true;
				}
			}
			if (flag)
			{
				this.OnConnected();
			}
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x00067A38 File Offset: 0x00065C38
		private void ActionOnDisconnected()
		{
			bool flag = false;
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_Connected)
				{
					this.m_Connected = false;
					flag = true;
				}
			}
			if (flag)
			{
				this.OnDisconnected();
			}
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00067A90 File Offset: 0x00065C90
		private void ActionOnClosed()
		{
			bool flag = false;
			try
			{
				global::System.Threading.Thread thread = null;
				global::System.IO.Stream stream = null;
				if (!this.m_Closed)
				{
					object @lock = this.m_Lock;
					lock (@lock)
					{
						if (!this.m_Closed)
						{
							flag = true;
							this.m_Closed = true;
							stream = this.m_NetworkStream;
							thread = this.m_BackgroundReader;
						}
					}
				}
				if (flag)
				{
					if (stream != null)
					{
						this.OnClose();
						this.m_RetryConnections = false;
						if (this.m_TcpClient != null && this.m_TcpClient.Client != null)
						{
							this.m_TcpClient.Client.Close();
							this.m_TcpClient.Close();
						}
					}
					if (global::System.Threading.Thread.CurrentThread != thread)
					{
						global::System.DateTimeOffset right = global::System.DateTimeOffset.Now.AddSeconds(5.0);
						while (thread != null)
						{
							if (!(global::System.DateTimeOffset.Now < right))
							{
								thread.Abort();
								break;
							}
							global::System.Threading.Thread.Sleep(16);
							object @lock = this.m_Lock;
							lock (@lock)
							{
								thread = this.m_BackgroundReader;
							}
						}
					}
				}
			}
			finally
			{
				this.ActionOnDisconnected();
				this.OnClosed();
			}
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x00067C18 File Offset: 0x00065E18
		private void ActionOnFailed(string message)
		{
			bool flag = false;
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (!this.m_ConnectionFailed)
				{
					this.m_ConnectionFailed = true;
					flag = true;
				}
			}
			if (flag)
			{
				this.OnFailed(message);
			}
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x00067C74 File Offset: 0x00065E74
		private void CalculateStateMessage(global::System.Net.Sockets.TcpClient client)
		{
			string text = null;
			if (client != null)
			{
				try
				{
					if (client.Connected)
					{
						global::System.Net.Sockets.Socket client2 = client.Client;
						global::System.Net.IPEndPoint ipendPoint = (global::System.Net.IPEndPoint)client2.LocalEndPoint;
						global::System.Net.IPEndPoint ipendPoint2 = (global::System.Net.IPEndPoint)client2.RemoteEndPoint;
						text = string.Format("{4}Network Client from {0}:{1} to {2}:{3}", new object[]
						{
							ipendPoint.Address,
							ipendPoint.Port,
							ipendPoint2.Address,
							ipendPoint2.Port,
							this.m_Options.UseSsl ? "Encrypted " : string.Empty
						});
					}
				}
				catch
				{
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				if (this.m_Options != null)
				{
					text = string.Format("{2}Network Client to {0}:{1} (Not connected)", this.m_Options.HostName, this.m_Options.Port, this.m_Options.UseSsl ? "Encrypted " : string.Empty);
				}
				else
				{
					text = "Network Client (Not connected)";
				}
			}
			this.m_StatusString = text;
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x00067DA0 File Offset: 0x00065FA0
		private global::System.Net.Sockets.TcpClient GetTcpClient()
		{
			global::System.Net.Sockets.TcpClient tcpClient = null;
			global::System.Exception innerException = null;
			if (this.m_SingleSocket)
			{
				tcpClient = this.m_TcpClient;
				this.m_TcpClient = null;
			}
			else
			{
				try
				{
					tcpClient = new global::System.Net.Sockets.TcpClient(this.m_Options.HostName, this.m_Options.Port);
				}
				catch (global::System.Net.Sockets.SocketException innerException)
				{
				}
				catch (global::System.IO.IOException ex)
				{
					if (ex.InnerException == null || !(ex.InnerException is global::System.Net.Sockets.SocketException))
					{
						throw;
					}
					innerException = ex;
				}
			}
			if (tcpClient == null)
			{
				throw new global::Gibraltar.Server.Client.GibraltarNetworkException("There is no connection available", innerException);
			}
			return tcpClient;
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x00067E50 File Offset: 0x00066050
		private int ReadSocket(out byte[] buffer)
		{
			buffer = new byte[10240];
			int result = 0;
			try
			{
				if (this.m_NetworkStream.CanRead)
				{
					global::Gibraltar.Messaging.Net.NetworkClient.AsyncSocketReadState asyncSocketReadState = new global::Gibraltar.Messaging.Net.NetworkClient.AsyncSocketReadState(this.m_NetworkStream);
					this.m_NetworkStream.BeginRead(buffer, 0, buffer.Length, new global::System.AsyncCallback(this.OnReadSocketEndRead), asyncSocketReadState);
					asyncSocketReadState.ResetEvent.WaitOne();
					result = asyncSocketReadState.DataLength;
					if (asyncSocketReadState.Exception != null)
					{
						throw asyncSocketReadState.Exception;
					}
				}
			}
			catch (global::System.Net.Sockets.SocketException ex)
			{
				this.ActionSocketFailed(ex);
			}
			catch (global::System.IO.IOException ex2)
			{
				if (ex2.InnerException == null || !(ex2.InnerException is global::System.Net.Sockets.SocketException))
				{
					throw;
				}
				this.ActionSocketFailed(ex2);
			}
			return result;
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x00067F2C File Offset: 0x0006612C
		private void OnReadSocketEndRead(global::System.IAsyncResult result)
		{
			global::Gibraltar.Messaging.Net.NetworkClient.AsyncSocketReadState asyncSocketReadState = (global::Gibraltar.Messaging.Net.NetworkClient.AsyncSocketReadState)result.AsyncState;
			try
			{
				asyncSocketReadState.DataLength = asyncSocketReadState.Stream.EndRead(result);
			}
			catch (global::System.Exception exception)
			{
				asyncSocketReadState.Exception = exception;
			}
			finally
			{
				asyncSocketReadState.ResetEvent.Set();
			}
		}

		// Token: 0x04000AD4 RID: 2772
		public const string LogCategory = "Loupe.Network.Client";

		// Token: 0x04000AD5 RID: 2773
		private const int NetworkReadBufferLength = 10240;

		// Token: 0x04000AD6 RID: 2774
		private readonly global::Gibraltar.Server.Client.NetworkConnectionOptions m_Options;

		// Token: 0x04000AD7 RID: 2775
		private bool m_RetryConnections;

		// Token: 0x04000AD8 RID: 2776
		private readonly int m_MajorVersion;

		// Token: 0x04000AD9 RID: 2777
		private readonly int m_MinorVersion;

		// Token: 0x04000ADA RID: 2778
		private readonly object m_Lock = new object();

		// Token: 0x04000ADB RID: 2779
		private global::System.Threading.Thread m_BackgroundReader;

		// Token: 0x04000ADC RID: 2780
		private bool m_SingleSocket;

		// Token: 0x04000ADD RID: 2781
		private bool m_Connected;

		// Token: 0x04000ADE RID: 2782
		private bool m_ConnectionFailed;

		// Token: 0x04000ADF RID: 2783
		private volatile bool m_Closed;

		// Token: 0x04000AE0 RID: 2784
		private bool m_HasCorruptData;

		// Token: 0x04000AE1 RID: 2785
		private int m_PacketsLostCount;

		// Token: 0x04000AE2 RID: 2786
		private string m_StatusString;

		// Token: 0x04000AE3 RID: 2787
		private global::Gibraltar.Messaging.Net.NetworkSerializer m_NetworkSerializer;

		// Token: 0x04000AE4 RID: 2788
		private global::System.IO.Stream m_NetworkStream;

		// Token: 0x04000AE5 RID: 2789
		private global::Gibraltar.PipeStream m_PacketStream;

		// Token: 0x04000AE6 RID: 2790
		private global::Gibraltar.Serialization.PacketReader m_PacketReader;

		// Token: 0x04000AE7 RID: 2791
		private global::Gibraltar.Serialization.PacketWriter m_PacketWriter;

		// Token: 0x04000AE8 RID: 2792
		private global::System.Net.Sockets.TcpClient m_TcpClient;

		// Token: 0x020004B8 RID: 1208
		private class AsyncSocketReadState
		{
			// Token: 0x060033DE RID: 13278 RVA: 0x000BB1A8 File Offset: 0x000B93A8
			public AsyncSocketReadState(global::System.IO.Stream stream)
			{
				this.Stream = stream;
				this.ResetEvent = new global::System.Threading.ManualResetEvent(false);
			}

			// Token: 0x17000EF5 RID: 3829
			// (get) Token: 0x060033DF RID: 13279 RVA: 0x000BB1C4 File Offset: 0x000B93C4
			// (set) Token: 0x060033E0 RID: 13280 RVA: 0x000BB1CC File Offset: 0x000B93CC
			public global::System.Exception Exception { get; set; }

			// Token: 0x17000EF6 RID: 3830
			// (get) Token: 0x060033E1 RID: 13281 RVA: 0x000BB1D8 File Offset: 0x000B93D8
			// (set) Token: 0x060033E2 RID: 13282 RVA: 0x000BB1E0 File Offset: 0x000B93E0
			public int DataLength { get; set; }

			// Token: 0x17000EF7 RID: 3831
			// (get) Token: 0x060033E3 RID: 13283 RVA: 0x000BB1EC File Offset: 0x000B93EC
			// (set) Token: 0x060033E4 RID: 13284 RVA: 0x000BB1F4 File Offset: 0x000B93F4
			public global::System.Threading.ManualResetEvent ResetEvent { get; private set; }

			// Token: 0x17000EF8 RID: 3832
			// (get) Token: 0x060033E5 RID: 13285 RVA: 0x000BB200 File Offset: 0x000B9400
			// (set) Token: 0x060033E6 RID: 13286 RVA: 0x000BB208 File Offset: 0x000B9408
			public global::System.IO.Stream Stream { get; private set; }
		}
	}
}
