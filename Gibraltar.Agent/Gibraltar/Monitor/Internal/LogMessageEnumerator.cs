using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Gibraltar.Data;
using Gibraltar.Serialization;
using Ionic.Zlib;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x020001F7 RID: 503
	internal class LogMessageEnumerator : global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.LogMessage>, global::System.IDisposable, global::System.Collections.IEnumerator
	{
		// Token: 0x060018DE RID: 6366 RVA: 0x000579E0 File Offset: 0x00055BE0
		public LogMessageEnumerator(global::Gibraltar.Monitor.Session session, global::Gibraltar.Monitor.ThreadInfoCollection threads, global::Gibraltar.Monitor.ApplicationUserCollection users, global::System.Collections.Generic.List<global::Gibraltar.Data.GLFReader> availableReaders)
		{
			this.m_Session = session;
			this.m_AvailableReaders = availableReaders;
			this.m_UnloadedReaders = new global::System.Collections.Generic.List<global::Gibraltar.Data.GLFReader>();
			this.m_Threads = threads;
			this.m_Users = users;
			this.Reset();
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00057A18 File Offset: 0x00055C18
		public bool MoveNext()
		{
			this.Current = null;
			int num = 0;
			while (this.m_PacketManager != null)
			{
				for (;;)
				{
					global::Gibraltar.Serialization.IPacket packet;
					try
					{
						global::System.IO.MemoryStream nextPacket = this.m_PacketManager.GetNextPacket();
						if (nextPacket == null)
						{
							break;
						}
						packet = this.m_PacketReader.ReadPacket(nextPacket);
						num++;
					}
					catch (global::System.Exception ex)
					{
						this.m_HasCorruptData = true;
						this.m_PacketsLostCount = this.PacketsLostCount + 1;
						global::Gibraltar.Serialization.GibraltarSerializationException ex2 = ex as global::Gibraltar.Serialization.GibraltarSerializationException;
						global::Ionic.Zlib.ZlibException ex3 = ex as global::Ionic.Zlib.ZlibException;
						if ((ex2 != null && ex2.StreamFailed) || ex3 != null)
						{
							if (!global::Gibraltar.Monitor.Log.SilentMode)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Session", "Unable to continue deserializing data during packet stream read due to " + ex.GetBaseException().GetType(), "While attempting to deserialize packet number {0} an exception was reported. This has failed the stream so serialization will stop.\r\nException: {1}", new object[]
								{
									num,
									ex.Message
								});
							}
							break;
						}
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Session", "Discarding packet and continuing due to " + ex.GetBaseException().GetType(), "While attempting to deserialize packet number {0} an exception was reported.  Since this may be a problem with just this one packet, we'll continue deserializing.\r\nException: {1}", new object[]
							{
								num,
								ex.Message
							});
						}
						continue;
					}
					if (packet != null)
					{
						try
						{
							global::Gibraltar.Monitor.Internal.LogMessagePacket logMessagePacket;
							global::Gibraltar.Monitor.Internal.ApplicationUserPacket packet2;
							global::Gibraltar.Monitor.Internal.ThreadInfoPacket packet3;
							if ((logMessagePacket = (packet as global::Gibraltar.Monitor.Internal.LogMessagePacket)) != null)
							{
								global::Gibraltar.Monitor.ThreadInfo threadInfo;
								if (!this.m_Threads.TryGetValue(logMessagePacket.ThreadIndex, out threadInfo))
								{
									threadInfo = null;
								}
								global::Gibraltar.Monitor.ApplicationUser applicationUser = null;
								if (!string.IsNullOrEmpty(logMessagePacket.UserName))
								{
									this.m_Users.TryFindUserName(logMessagePacket.UserName, out applicationUser);
								}
								global::Gibraltar.Monitor.LogMessage value = new global::Gibraltar.Monitor.LogMessage(this.m_Session, threadInfo, applicationUser, logMessagePacket);
								this.Current = value;
							}
							else if ((packet2 = (packet as global::Gibraltar.Monitor.Internal.ApplicationUserPacket)) != null)
							{
								global::Gibraltar.Monitor.ApplicationUser user = new global::Gibraltar.Monitor.ApplicationUser(packet2);
								this.m_Users.TrySetValue(user);
							}
							else if ((packet3 = (packet as global::Gibraltar.Monitor.Internal.ThreadInfoPacket)) != null)
							{
								global::Gibraltar.Monitor.ThreadInfo item = new global::Gibraltar.Monitor.ThreadInfo(packet3);
								if (!this.m_Threads.Contains(item))
								{
									this.m_Threads.Add(item);
								}
							}
							global::Gibraltar.Monitor.Internal.GibraltarPacket gibraltarPacket;
							if ((gibraltarPacket = (packet as global::Gibraltar.Monitor.Internal.GibraltarPacket)) != null)
							{
								this.m_LastSequence = global::System.Math.Max(this.m_LastSequence, gibraltarPacket.Sequence);
							}
						}
						catch (global::System.Exception ex4)
						{
							global::System.GC.KeepAlive(ex4);
							if (!global::Gibraltar.Monitor.Log.SilentMode)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex4, "Loupe.Session", "Unexpected exception while loading packet stream", "{0}", new object[]
								{
									ex4.Message
								});
							}
						}
					}
					if (this.Current != null)
					{
						return true;
					}
				}
				this.MoveNextReader();
			}
			return false;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00057CC4 File Offset: 0x00055EC4
		public void Reset()
		{
			this.Current = null;
			this.m_UnloadedReaders.Clear();
			this.m_UnloadedReaders.AddRange(this.m_AvailableReaders);
			this.MoveNextReader();
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x060018E1 RID: 6369 RVA: 0x00057CF0 File Offset: 0x00055EF0
		// (set) Token: 0x060018E2 RID: 6370 RVA: 0x00057CF8 File Offset: 0x00055EF8
		public global::Gibraltar.Monitor.LogMessage Current { get; private set; }

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x060018E3 RID: 6371 RVA: 0x00057D04 File Offset: 0x00055F04
		object global::System.Collections.IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060018E4 RID: 6372 RVA: 0x00057D0C File Offset: 0x00055F0C
		public bool HasCorruptData
		{
			get
			{
				return this.m_HasCorruptData;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x00057D14 File Offset: 0x00055F14
		public int PacketsLostCount
		{
			get
			{
				return this.m_PacketsLostCount;
			}
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00057D1C File Offset: 0x00055F1C
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00057D2C File Offset: 0x00055F2C
		protected virtual void Dispose(bool releaseManaged)
		{
			if (!this.m_IsDisposed)
			{
				this.m_IsDisposed = true;
				if (releaseManaged)
				{
					this.m_PacketManager = null;
					this.m_PacketReader = null;
					this.m_AvailableReaders.Clear();
					this.m_UnloadedReaders.Clear();
				}
			}
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00057D6C File Offset: 0x00055F6C
		private void MoveNextReader()
		{
			this.m_PacketManager = null;
			this.m_PacketReader = null;
			if (this.m_UnloadedReaders.Count > 0)
			{
				global::Gibraltar.Data.GLFReader glfreader = this.m_UnloadedReaders[0];
				try
				{
					global::System.IO.Stream packetStreamStart = glfreader.GetPacketStreamStart();
					this.m_PacketManager = new global::Gibraltar.Serialization.PacketManager(packetStreamStart);
					this.m_PacketReader = new global::Gibraltar.Serialization.PacketReader(null, true, glfreader.MajorVersion, glfreader.MinorVersion);
					new global::Gibraltar.Monitor.Internal.SessionPacketFactory().Register(this.m_PacketReader);
					new global::Gibraltar.Monitor.Internal.LogMessagePacketFactory(this.m_Session).Register(this.m_PacketReader);
				}
				catch (global::System.Threading.ThreadAbortException exception)
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, global::Gibraltar.Monitor.LogWriteMode.Queued, exception, "Loupe.Session", "Aborting loading packet stream.", "A thread abort exception was thrown on our worker thread so we'll stop trying to load the session.", new object[0]);
					}
					this.m_PacketsLostCount++;
				}
				catch (global::System.Exception ex)
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.WaitForCommit, ex, "Loupe.Session", "Exception loading packet stream.", "{0}: {1}", new object[]
						{
							ex.GetType(),
							ex.Message
						});
					}
					this.m_PacketsLostCount++;
				}
				this.m_UnloadedReaders.Remove(glfreader);
			}
		}

		// Token: 0x040008FE RID: 2302
		private readonly global::Gibraltar.Monitor.Session m_Session;

		// Token: 0x040008FF RID: 2303
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Data.GLFReader> m_AvailableReaders;

		// Token: 0x04000900 RID: 2304
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Data.GLFReader> m_UnloadedReaders;

		// Token: 0x04000901 RID: 2305
		private readonly global::Gibraltar.Monitor.ThreadInfoCollection m_Threads;

		// Token: 0x04000902 RID: 2306
		private readonly global::Gibraltar.Monitor.ApplicationUserCollection m_Users;

		// Token: 0x04000903 RID: 2307
		private bool m_HasCorruptData;

		// Token: 0x04000904 RID: 2308
		private int m_PacketsLostCount;

		// Token: 0x04000905 RID: 2309
		private long m_LastSequence;

		// Token: 0x04000906 RID: 2310
		private global::Gibraltar.Serialization.PacketReader m_PacketReader;

		// Token: 0x04000907 RID: 2311
		private global::Gibraltar.Serialization.PacketManager m_PacketManager;

		// Token: 0x04000908 RID: 2312
		private bool m_IsDisposed;
	}
}
