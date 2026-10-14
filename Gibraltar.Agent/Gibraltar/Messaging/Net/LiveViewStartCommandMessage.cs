using System;
using System.Diagnostics;
using System.IO;
using Gibraltar.Data;

namespace Gibraltar.Messaging.Net
{
	// Token: 0x0200024B RID: 587
	[global::System.Diagnostics.DebuggerDisplay("Session: {SessionId}, Offset: {SequenceOffset}")]
	internal class LiveViewStartCommandMessage : global::Gibraltar.Messaging.Net.NetworkMessage
	{
		// Token: 0x06001D7D RID: 7549 RVA: 0x00068060 File Offset: 0x00066260
		internal LiveViewStartCommandMessage()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				base.TypeCode = global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.LiveViewStartCommand;
				base.Version = new global::System.Version(1, 0);
			}
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x000680BC File Offset: 0x000662BC
		public LiveViewStartCommandMessage(global::System.Guid repositoryId, global::System.Guid sessionId, global::System.Guid channelId, long sequenceOffset = 0L) : this()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_RepositoryId = repositoryId;
				this.m_SequenceOffset = sequenceOffset;
				this.m_SessionId = sessionId;
				this.m_ChannelId = channelId;
				this.Validate();
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x0006811C File Offset: 0x0006631C
		public global::System.Guid ChannelId
		{
			get
			{
				object @lock = this.m_Lock;
				global::System.Guid channelId;
				lock (@lock)
				{
					channelId = this.m_ChannelId;
				}
				return channelId;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x0006815C File Offset: 0x0006635C
		public long SequenceOffset
		{
			get
			{
				object @lock = this.m_Lock;
				long sequenceOffset;
				lock (@lock)
				{
					sequenceOffset = this.m_SequenceOffset;
				}
				return sequenceOffset;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x0006819C File Offset: 0x0006639C
		public global::System.Guid SessionId
		{
			get
			{
				object @lock = this.m_Lock;
				global::System.Guid sessionId;
				lock (@lock)
				{
					sessionId = this.m_SessionId;
				}
				return sessionId;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x000681DC File Offset: 0x000663DC
		public global::System.Guid RepositoryId
		{
			get
			{
				object @lock = this.m_Lock;
				global::System.Guid repositoryId;
				lock (@lock)
				{
					repositoryId = this.m_RepositoryId;
				}
				return repositoryId;
			}
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x0006821C File Offset: 0x0006641C
		public void Validate()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.ChannelId == global::System.Guid.Empty)
				{
					throw new global::System.InvalidOperationException("There is no channel Id specified");
				}
				if (this.SessionId == global::System.Guid.Empty)
				{
					throw new global::System.InvalidOperationException("There is no session Id specified");
				}
			}
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x00068294 File Offset: 0x00066494
		protected override void OnWrite(global::System.IO.Stream stream)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.m_RepositoryId);
				global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.m_SessionId);
				global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.m_ChannelId);
				global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.m_SequenceOffset);
			}
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x000682FC File Offset: 0x000664FC
		protected override void OnRead(global::System.IO.Stream stream)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out this.m_RepositoryId);
				global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out this.m_SessionId);
				global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out this.m_ChannelId);
				global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out this.m_SequenceOffset);
			}
		}

		// Token: 0x04000AFB RID: 2811
		private readonly object m_Lock = new object();

		// Token: 0x04000AFC RID: 2812
		private global::System.Guid m_RepositoryId;

		// Token: 0x04000AFD RID: 2813
		private long m_SequenceOffset;

		// Token: 0x04000AFE RID: 2814
		private global::System.Guid m_SessionId;

		// Token: 0x04000AFF RID: 2815
		private global::System.Guid m_ChannelId;
	}
}
