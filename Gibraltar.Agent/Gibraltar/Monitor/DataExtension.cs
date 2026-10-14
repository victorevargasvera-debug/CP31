using System;
using Gibraltar.Monitor.Internal;

namespace Gibraltar.Monitor
{
	// Token: 0x02000188 RID: 392
	internal class DataExtension : global::System.IEquatable<global::Gibraltar.Monitor.DataExtension>
	{
		// Token: 0x0600106E RID: 4206 RVA: 0x0002D91C File Offset: 0x0002BB1C
		internal DataExtension(global::Gibraltar.Monitor.Analysis analysis, global::Gibraltar.Monitor.Internal.IDataObject owner)
		{
			this.m_Analysis = analysis;
			this.m_ID = owner.Id;
			this.m_Markers = new global::Gibraltar.Monitor.DataMarkerCollection(this.m_Analysis);
			this.m_Comments = new global::Gibraltar.Monitor.CommentCollection();
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x0002D954 File Offset: 0x0002BB54
		internal DataExtension(global::Gibraltar.Monitor.Analysis analysis, global::Gibraltar.Monitor.Internal.DataExtensionPacket packet, global::Gibraltar.Monitor.CommentCollection comments)
		{
			this.m_Analysis = analysis;
			this.m_Comments = comments;
			this.m_ID = packet.ID;
			if (this.m_Comments == null)
			{
				this.m_Comments = new global::Gibraltar.Monitor.CommentCollection();
			}
			if (this.m_Markers == null)
			{
				this.m_Markers = new global::Gibraltar.Monitor.DataMarkerCollection(this.m_Analysis);
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001070 RID: 4208 RVA: 0x0002D9B8 File Offset: 0x0002BBB8
		public global::Gibraltar.Monitor.Analysis Analysis
		{
			get
			{
				return this.m_Analysis;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x0002D9C0 File Offset: 0x0002BBC0
		public global::System.Guid Id
		{
			get
			{
				return this.m_ID;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x0002D9C8 File Offset: 0x0002BBC8
		public global::Gibraltar.Monitor.DataMarkerCollection Markers
		{
			get
			{
				return this.m_Markers;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x0002D9D0 File Offset: 0x0002BBD0
		public global::Gibraltar.Monitor.CommentCollection Comments
		{
			get
			{
				return this.m_Comments;
			}
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0002D9D8 File Offset: 0x0002BBD8
		public bool Equals(global::Gibraltar.Monitor.DataExtension other)
		{
			return other != null && this.m_ID == other.Id;
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x0002D9F4 File Offset: 0x0002BBF4
		internal global::Gibraltar.Monitor.Internal.DataExtensionPacket Packet
		{
			get
			{
				return new global::Gibraltar.Monitor.Internal.DataExtensionPacket(this.m_ID);
			}
		}

		// Token: 0x04000581 RID: 1409
		private readonly global::Gibraltar.Monitor.Analysis m_Analysis;

		// Token: 0x04000582 RID: 1410
		private readonly global::System.Guid m_ID;

		// Token: 0x04000583 RID: 1411
		private readonly global::Gibraltar.Monitor.DataMarkerCollection m_Markers;

		// Token: 0x04000584 RID: 1412
		private readonly global::Gibraltar.Monitor.CommentCollection m_Comments;
	}
}
