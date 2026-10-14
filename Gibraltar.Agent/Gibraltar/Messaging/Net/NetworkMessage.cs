using System;
using System.IO;
using Gibraltar.Data;

namespace Gibraltar.Messaging.Net
{
	// Token: 0x0200024D RID: 589
	internal abstract class NetworkMessage
	{
		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x000683F8 File Offset: 0x000665F8
		// (set) Token: 0x06001D8F RID: 7567 RVA: 0x00068438 File Offset: 0x00066638
		public global::System.Version Version
		{
			get
			{
				object @lock = this.m_Lock;
				global::System.Version version;
				lock (@lock)
				{
					version = this.m_Version;
				}
				return version;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_Version = value;
				}
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x00068478 File Offset: 0x00066678
		// (set) Token: 0x06001D91 RID: 7569 RVA: 0x000684B8 File Offset: 0x000666B8
		public global::Gibraltar.Messaging.Net.NetworkMessageTypeCode TypeCode
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Messaging.Net.NetworkMessageTypeCode typeCode;
				lock (@lock)
				{
					typeCode = this.m_TypeCode;
				}
				return typeCode;
			}
			set
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_TypeCode = value;
				}
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x000684F8 File Offset: 0x000666F8
		public int Length
		{
			get
			{
				object @lock = this.m_Lock;
				int result;
				lock (@lock)
				{
					if (this.m_Length == 0)
					{
						global::System.IO.Stream stream = new global::System.IO.MemoryStream();
						this.Write(stream);
						result = (int)stream.Length;
					}
					else
					{
						result = this.m_Length;
					}
				}
				return result;
			}
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x0006855C File Offset: 0x0006675C
		public static bool ReadHeader(global::System.IO.Stream stream, out int packetLength, out global::Gibraltar.Messaging.Net.NetworkMessageTypeCode typeCode, out global::System.Version version)
		{
			if (stream.Length - stream.Position >= 16L)
			{
				long position = stream.Position;
				global::Gibraltar.Messaging.Net.NetworkMessage.ReadPacket(stream, out typeCode, out version, out packetLength);
				stream.Position = position;
				return true;
			}
			packetLength = 0;
			typeCode = global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.Unknown;
			version = null;
			return false;
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x000685A8 File Offset: 0x000667A8
		public static global::Gibraltar.Messaging.Net.NetworkMessage Read(global::System.IO.Stream stream)
		{
			global::Gibraltar.Messaging.Net.NetworkMessageTypeCode networkMessageTypeCode;
			global::System.Version version;
			int length;
			global::Gibraltar.Messaging.Net.NetworkMessage.ReadPacket(stream, out networkMessageTypeCode, out version, out length);
			global::Gibraltar.Messaging.Net.NetworkMessage networkMessage;
			switch (networkMessageTypeCode)
			{
			case global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.LiveViewStartCommand:
				networkMessage = new global::Gibraltar.Messaging.Net.LiveViewStartCommandMessage();
				break;
			case global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.LiveViewStopCommand:
				networkMessage = new global::Gibraltar.Messaging.Net.LiveViewStopCommandMessage();
				break;
			case global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.SendSession:
				networkMessage = new global::Gibraltar.Messaging.Net.SendSessionCommandMessage();
				break;
			case global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.SessionHeader:
				networkMessage = new global::Gibraltar.Messaging.Net.SessionHeaderMessage();
				break;
			case global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.GetSessionHeaders:
				networkMessage = new global::Gibraltar.Messaging.Net.GetSessionHeadersCommandMessage();
				break;
			case global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.RegisterAnalystCommand:
				networkMessage = new global::Gibraltar.Messaging.Net.RegisterAnalystCommandMessage();
				break;
			case global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.RegisterAgentCommand:
				networkMessage = new global::Gibraltar.Messaging.Net.RegisterAgentCommandMessage();
				break;
			case global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.SessionClosed:
				networkMessage = new global::Gibraltar.Messaging.Net.SessionClosedMessage();
				break;
			case global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.PacketStreamStartCommand:
				networkMessage = new global::Gibraltar.Messaging.Net.PacketStreamStartCommandMessage();
				break;
			default:
				throw new global::System.InvalidOperationException("Unable to create network packet because it uses a type code that is unknown: " + networkMessageTypeCode);
			}
			networkMessage.m_Length = length;
			networkMessage.m_TypeCode = networkMessageTypeCode;
			networkMessage.m_Version = version;
			networkMessage.OnRead(stream);
			return networkMessage;
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x0006868C File Offset: 0x0006688C
		public void Write(global::System.IO.Stream stream)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				this.OnWrite(memoryStream);
				memoryStream.Position = 0L;
				global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, (int)this.m_TypeCode);
				global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.m_Version.Major);
				global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.m_Version.Minor);
				global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, (int)(memoryStream.Length + 16L));
				memoryStream.WriteTo(stream);
			}
		}

		// Token: 0x06001D96 RID: 7574
		protected abstract void OnWrite(global::System.IO.Stream stream);

		// Token: 0x06001D97 RID: 7575
		protected abstract void OnRead(global::System.IO.Stream stream);

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x00068720 File Offset: 0x00066920
		protected virtual int BaseLength
		{
			get
			{
				return 16;
			}
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00068724 File Offset: 0x00066924
		private static void ReadPacket(global::System.IO.Stream stream, out global::Gibraltar.Messaging.Net.NetworkMessageTypeCode typeCode, out global::System.Version version, out int length)
		{
			int num;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out num);
			typeCode = (global::Gibraltar.Messaging.Net.NetworkMessageTypeCode)num;
			int major;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out major);
			int minor;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out minor);
			version = new global::System.Version(major, minor);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out length);
		}

		// Token: 0x04000B02 RID: 2818
		private const int BasePacketLength = 16;

		// Token: 0x04000B03 RID: 2819
		private readonly object m_Lock = new object();

		// Token: 0x04000B04 RID: 2820
		private global::System.Version m_Version;

		// Token: 0x04000B05 RID: 2821
		private global::Gibraltar.Messaging.Net.NetworkMessageTypeCode m_TypeCode;

		// Token: 0x04000B06 RID: 2822
		private int m_Length;
	}
}
