using System;
using System.Reflection;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x020001FE RID: 510
	internal class CommentPacket : global::Gibraltar.Monitor.Internal.GibraltarPacket, global::Gibraltar.Serialization.IPacket, global::System.IEquatable<global::Gibraltar.Monitor.Internal.CommentPacket>
	{
		// Token: 0x0600193D RID: 6461 RVA: 0x0005907C File Offset: 0x0005727C
		public CommentPacket()
		{
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00059084 File Offset: 0x00057284
		public CommentPacket(global::Gibraltar.Monitor.Internal.DataExtensionPacket extensionPacket)
		{
			this.DataExtensionPacket = extensionPacket;
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x00059094 File Offset: 0x00057294
		// (set) Token: 0x06001940 RID: 6464 RVA: 0x0005909C File Offset: 0x0005729C
		public global::Gibraltar.Monitor.Internal.DataExtensionPacket DataExtensionPacket { get; set; }

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x000590A8 File Offset: 0x000572A8
		// (set) Token: 0x06001942 RID: 6466 RVA: 0x000590B0 File Offset: 0x000572B0
		public global::System.Guid Id
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

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x000590BC File Offset: 0x000572BC
		// (set) Token: 0x06001944 RID: 6468 RVA: 0x000590C4 File Offset: 0x000572C4
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

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x000590D0 File Offset: 0x000572D0
		// (set) Token: 0x06001946 RID: 6470 RVA: 0x000590D8 File Offset: 0x000572D8
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

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001947 RID: 6471 RVA: 0x000590E4 File Offset: 0x000572E4
		// (set) Token: 0x06001948 RID: 6472 RVA: 0x000590EC File Offset: 0x000572EC
		public string UserName
		{
			get
			{
				return this.m_UserName;
			}
			set
			{
				this.m_UserName = value;
			}
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x000590F8 File Offset: 0x000572F8
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return new global::Gibraltar.Serialization.IPacket[]
			{
				this.DataExtensionPacket
			};
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0005910C File Offset: 0x0005730C
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, true)
			{
				Fields = 
				{
					{
						"ID",
						global::Gibraltar.Serialization.FieldType.Guid
					},
					{
						"Caption",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"Description",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"UserName",
						global::Gibraltar.Serialization.FieldType.String
					}
				}
			};
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00059178 File Offset: 0x00057378
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("ID", out this.m_ID);
				packet.GetField("Caption", out this.m_Caption);
				packet.GetField("Description", out this.m_Description);
				packet.GetField("UserName", out this.m_UserName);
			}
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x000591DC File Offset: 0x000573DC
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("ID", this.m_ID);
			packet.SetField("Caption", this.m_Caption);
			packet.SetField("Description", this.m_Description);
			packet.SetField("UserName", this.m_UserName);
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00059238 File Offset: 0x00057438
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.CommentPacket);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00059248 File Offset: 0x00057448
		public bool Equals(global::Gibraltar.Monitor.Internal.CommentPacket other)
		{
			return other != null && (this.Id == other.Id && this.Caption == other.Caption && this.Description == other.Description && this.UserName == other.UserName) && base.Equals(other);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x000592C4 File Offset: 0x000574C4
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
			if (this.m_UserName != null)
			{
				num ^= this.m_UserName.GetHashCode();
			}
			return num;
		}

		// Token: 0x04000929 RID: 2345
		private global::System.Guid m_ID;

		// Token: 0x0400092A RID: 2346
		private string m_Caption;

		// Token: 0x0400092B RID: 2347
		private string m_Description;

		// Token: 0x0400092C RID: 2348
		private string m_UserName;

		// Token: 0x0400092E RID: 2350
		private const int SerializationVersion = 1;
	}
}
