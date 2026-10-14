using System;
using System.Reflection;
using Gibraltar.Serialization;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x020001FF RID: 511
	internal class ExceptionInfoPacket : global::Gibraltar.Monitor.Internal.GibraltarPacket, global::Gibraltar.Serialization.IPacket, global::System.IEquatable<global::Gibraltar.Monitor.Internal.ExceptionInfoPacket>, global::Loupe.Extensibility.Data.IExceptionInfo
	{
		// Token: 0x06001950 RID: 6480 RVA: 0x0005933C File Offset: 0x0005753C
		public ExceptionInfoPacket()
		{
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x00059344 File Offset: 0x00057544
		public ExceptionInfoPacket(global::System.Exception exception)
		{
			this.m_TypeName = exception.GetType().FullName;
			this.m_Message = exception.Message;
			this.m_Source = exception.Source;
			this.m_StackTrace = exception.StackTrace;
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x00059390 File Offset: 0x00057590
		// (set) Token: 0x06001953 RID: 6483 RVA: 0x00059398 File Offset: 0x00057598
		public string TypeName
		{
			get
			{
				return this.m_TypeName;
			}
			set
			{
				this.m_TypeName = value;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x000593A4 File Offset: 0x000575A4
		// (set) Token: 0x06001955 RID: 6485 RVA: 0x000593AC File Offset: 0x000575AC
		public string Message
		{
			get
			{
				return this.m_Message;
			}
			set
			{
				this.m_Message = value;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x000593B8 File Offset: 0x000575B8
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x000593C0 File Offset: 0x000575C0
		public string Source
		{
			get
			{
				return this.m_Source;
			}
			set
			{
				this.m_Source = value;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x000593CC File Offset: 0x000575CC
		// (set) Token: 0x06001959 RID: 6489 RVA: 0x000593D4 File Offset: 0x000575D4
		public string StackTrace
		{
			get
			{
				return this.m_StackTrace;
			}
			set
			{
				this.m_StackTrace = value;
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x000593E0 File Offset: 0x000575E0
		// (set) Token: 0x0600195B RID: 6491 RVA: 0x000593E8 File Offset: 0x000575E8
		public global::Loupe.Extensibility.Data.IExceptionInfo InnerException
		{
			get
			{
				return this.m_InnerException;
			}
			set
			{
				this.m_InnerException = value;
			}
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x000593F4 File Offset: 0x000575F4
		public override void FixData()
		{
			base.FixData();
			global::Gibraltar.StringReference.SwapReference(ref this.m_TypeName);
			global::Gibraltar.StringReference.SwapReference(ref this.m_Message);
			global::Gibraltar.StringReference.SwapReference(ref this.m_Source);
			global::Gibraltar.StringReference.SwapReference(ref this.m_StackTrace);
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x00059428 File Offset: 0x00057628
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.ExceptionInfoPacket);
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x00059438 File Offset: 0x00057638
		public bool Equals(global::Gibraltar.Monitor.Internal.ExceptionInfoPacket other)
		{
			return other != null && (this.TypeName == other.TypeName && this.Message == other.Message && this.Source == other.Source && this.StackTrace == other.StackTrace) && base.Equals(other);
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x000594B4 File Offset: 0x000576B4
		public override int GetHashCode()
		{
			int num = base.GetHashCode();
			if (this.m_TypeName != null)
			{
				num ^= this.m_TypeName.GetHashCode();
			}
			if (this.m_Message != null)
			{
				num ^= this.m_Message.GetHashCode();
			}
			if (this.m_Source != null)
			{
				num ^= this.m_Source.GetHashCode();
			}
			if (this.m_StackTrace != null)
			{
				num ^= this.m_StackTrace.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x00059534 File Offset: 0x00057734
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"TypeName",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"Message",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"Source",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"StackTrace",
						global::Gibraltar.Serialization.FieldType.String
					}
				}
			};
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x000595A0 File Offset: 0x000577A0
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("TypeName", this.TypeName);
			packet.SetField("Message", this.Message);
			packet.SetField("Source", this.Source);
			packet.SetField("StackTrace", this.StackTrace);
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x000595F8 File Offset: 0x000577F8
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("TypeName", out this.m_TypeName);
				packet.GetField("Message", out this.m_Message);
				packet.GetField("Source", out this.m_Source);
				packet.GetField("StackTrace", out this.m_StackTrace);
			}
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x0005965C File Offset: 0x0005785C
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x0400092F RID: 2351
		private string m_TypeName;

		// Token: 0x04000930 RID: 2352
		private string m_Message;

		// Token: 0x04000931 RID: 2353
		private string m_Source;

		// Token: 0x04000932 RID: 2354
		private string m_StackTrace;

		// Token: 0x04000933 RID: 2355
		private global::Loupe.Extensibility.Data.IExceptionInfo m_InnerException;

		// Token: 0x04000934 RID: 2356
		private const int SerializationVersion = 1;
	}
}
