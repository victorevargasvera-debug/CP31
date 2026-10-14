using System;
using System.Drawing;
using System.Reflection;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000204 RID: 516
	internal class MarkerPacket : global::Gibraltar.Monitor.Internal.GibraltarPacket, global::Gibraltar.Serialization.IPacket, global::System.IEquatable<global::Gibraltar.Monitor.Internal.MarkerPacket>
	{
		// Token: 0x06001986 RID: 6534 RVA: 0x00059BC8 File Offset: 0x00057DC8
		public MarkerPacket()
		{
			this.ID = global::System.Guid.NewGuid();
			this.Caption = string.Empty;
			this.Description = string.Empty;
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06001987 RID: 6535 RVA: 0x00059C00 File Offset: 0x00057E00
		// (set) Token: 0x06001988 RID: 6536 RVA: 0x00059C08 File Offset: 0x00057E08
		public global::System.Guid ID
		{
			get
			{
				return this.m_ID;
			}
			set
			{
				this.m_ID = value;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x00059C14 File Offset: 0x00057E14
		// (set) Token: 0x0600198A RID: 6538 RVA: 0x00059C1C File Offset: 0x00057E1C
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

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x0600198B RID: 6539 RVA: 0x00059C28 File Offset: 0x00057E28
		// (set) Token: 0x0600198C RID: 6540 RVA: 0x00059C30 File Offset: 0x00057E30
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

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x00059C3C File Offset: 0x00057E3C
		// (set) Token: 0x0600198E RID: 6542 RVA: 0x00059C44 File Offset: 0x00057E44
		public global::System.Drawing.Color Color
		{
			get
			{
				return this.m_Color;
			}
			set
			{
				this.m_Color = value;
			}
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00059C50 File Offset: 0x00057E50
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.MarkerPacket);
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00059C60 File Offset: 0x00057E60
		public bool Equals(global::Gibraltar.Monitor.Internal.MarkerPacket other)
		{
			return other != null && (this.ID == other.ID && this.Caption == other.Caption && this.Description == other.Description && this.Color == other.Color) && base.Equals(other);
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00059CDC File Offset: 0x00057EDC
		public override int GetHashCode()
		{
			int num = base.GetHashCode();
			num ^= this.m_ID.GetHashCode();
			if (this.m_Caption != null)
			{
				num ^= this.m_Caption.GetHashCode();
			}
			if (this.m_Description != null)
			{
				num ^= this.m_Description.GetHashCode();
			}
			return num ^ this.m_Color.GetHashCode();
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00059D50 File Offset: 0x00057F50
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00059D54 File Offset: 0x00057F54
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"ID",
						this.m_ID.GetType()
					},
					{
						"Caption",
						this.m_Caption.GetType()
					},
					{
						"Description",
						this.m_Description.GetType()
					},
					{
						"Color",
						global::Gibraltar.Serialization.FieldType.Int32
					}
				}
			};
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00059DE4 File Offset: 0x00057FE4
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("ID", this.m_ID);
			packet.SetField("Caption", this.m_Caption);
			packet.SetField("Description", this.m_Description);
			packet.SetField("Color", this.Color.ToArgb());
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x00059E4C File Offset: 0x0005804C
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("ID", out this.m_ID);
				packet.GetField("Caption", out this.m_Caption);
				packet.GetField("Description", out this.m_Description);
				int argb;
				packet.GetField("Color", out argb);
				this.Color = global::System.Drawing.Color.FromArgb(argb);
			}
		}

		// Token: 0x04000943 RID: 2371
		private global::System.Guid m_ID;

		// Token: 0x04000944 RID: 2372
		private string m_Caption;

		// Token: 0x04000945 RID: 2373
		private string m_Description;

		// Token: 0x04000946 RID: 2374
		private global::System.Drawing.Color m_Color;

		// Token: 0x04000947 RID: 2375
		private const int SerializationVersion = 1;
	}
}
