using System;
using System.Reflection;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x020001FC RID: 508
	internal class AnalysisPacket : global::Gibraltar.Monitor.Internal.GibraltarCachedPacket, global::Gibraltar.Serialization.IPacket, global::System.IEquatable<global::Gibraltar.Monitor.Internal.AnalysisPacket>
	{
		// Token: 0x0600192E RID: 6446 RVA: 0x00058D7C File Offset: 0x00056F7C
		public AnalysisPacket() : base(false)
		{
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x00058D88 File Offset: 0x00056F88
		// (set) Token: 0x06001930 RID: 6448 RVA: 0x00058D90 File Offset: 0x00056F90
		public string Caption
		{
			get
			{
				return this.m_Caption;
			}
			set
			{
				this.m_Caption = value;
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x00058D9C File Offset: 0x00056F9C
		// (set) Token: 0x06001932 RID: 6450 RVA: 0x00058DA4 File Offset: 0x00056FA4
		public string Description
		{
			get
			{
				return this.m_Description;
			}
			set
			{
				this.m_Description = value;
			}
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00058DB0 File Offset: 0x00056FB0
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00058DB4 File Offset: 0x00056FB4
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"Caption",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"Description",
						global::Gibraltar.Serialization.FieldType.String
					}
				}
			};
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00058E00 File Offset: 0x00057000
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("Caption", out this.m_Caption);
				packet.GetField("Description", out this.m_Caption);
			}
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00058E44 File Offset: 0x00057044
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("Caption", this.m_Caption);
			packet.SetField("Description", this.m_Description);
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00058E68 File Offset: 0x00057068
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.AnalysisPacket);
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00058E78 File Offset: 0x00057078
		public bool Equals(global::Gibraltar.Monitor.Internal.AnalysisPacket other)
		{
			return other != null && (this.Caption == other.Caption && this.Description == other.Description) && base.Equals(other);
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00058EC8 File Offset: 0x000570C8
		public override int GetHashCode()
		{
			int num = base.GetHashCode();
			if (this.m_Caption != null)
			{
				num ^= this.m_Caption.GetHashCode();
			}
			if (this.m_Description != null)
			{
				num ^= this.m_Description.GetHashCode();
			}
			return num;
		}

		// Token: 0x04000922 RID: 2338
		private string m_Caption;

		// Token: 0x04000923 RID: 2339
		private string m_Description;

		// Token: 0x04000924 RID: 2340
		private const int SerializationVersion = 1;
	}
}
