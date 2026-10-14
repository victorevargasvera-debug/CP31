using System;
using System.Reflection;
using Gibraltar.Messaging;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000201 RID: 513
	internal abstract class GibraltarPacket : global::Gibraltar.Messaging.IMessengerPacket, global::Gibraltar.Serialization.IPacket, global::System.IEquatable<global::Gibraltar.Monitor.Internal.GibraltarPacket>
	{
		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001974 RID: 6516 RVA: 0x000598B8 File Offset: 0x00057AB8
		// (set) Token: 0x06001975 RID: 6517 RVA: 0x000598C0 File Offset: 0x00057AC0
		public long Sequence
		{
			get
			{
				return this.m_Sequence;
			}
			set
			{
				this.m_Sequence = value;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001976 RID: 6518 RVA: 0x000598CC File Offset: 0x00057ACC
		// (set) Token: 0x06001977 RID: 6519 RVA: 0x000598D4 File Offset: 0x00057AD4
		public global::System.DateTimeOffset Timestamp
		{
			get
			{
				return this.m_TimeStamp;
			}
			set
			{
				this.m_TimeStamp = value;
			}
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x000598E0 File Offset: 0x00057AE0
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.GibraltarPacket);
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x000598F0 File Offset: 0x00057AF0
		public bool Equals(global::Gibraltar.Monitor.Internal.GibraltarPacket other)
		{
			return other != null && this.Sequence == other.Sequence && this.Timestamp == other.Timestamp;
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00059920 File Offset: 0x00057B20
		public override int GetHashCode()
		{
			return (int)(this.m_Sequence >> 32) ^ (int)this.m_Sequence ^ this.m_TimeStamp.GetHashCode();
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00059948 File Offset: 0x00057B48
		public virtual void FixData()
		{
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x0005994C File Offset: 0x00057B4C
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00059950 File Offset: 0x00057B50
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"Sequence",
						this.m_Sequence.GetType()
					},
					{
						"TimeStamp",
						this.m_TimeStamp.GetType()
					}
				}
			};
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x000599B8 File Offset: 0x00057BB8
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("Sequence", this.m_Sequence);
			packet.SetField("TimeStamp", this.m_TimeStamp);
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x000599E8 File Offset: 0x00057BE8
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("Sequence", out this.m_Sequence);
				packet.GetField("TimeStamp", out this.m_TimeStamp);
			}
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00059A2C File Offset: 0x00057C2C
		protected void ReadFieldsFast(global::Gibraltar.Serialization.IFieldReader reader)
		{
			this.m_Sequence = reader.ReadInt64();
			this.m_TimeStamp = reader.ReadDateTimeOffset();
		}

		// Token: 0x0400093A RID: 2362
		private long m_Sequence;

		// Token: 0x0400093B RID: 2363
		private global::System.DateTimeOffset m_TimeStamp;

		// Token: 0x0400093C RID: 2364
		private const int Version = 1;
	}
}
