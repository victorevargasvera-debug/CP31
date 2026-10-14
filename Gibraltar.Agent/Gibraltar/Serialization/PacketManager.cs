using System;
using System.IO;

namespace Gibraltar.Serialization
{
	// Token: 0x02000106 RID: 262
	internal class PacketManager : global::Gibraltar.Serialization.PacketManagerBase
	{
		// Token: 0x06000AEB RID: 2795 RVA: 0x0001B5D8 File Offset: 0x000197D8
		public PacketManager(global::System.IO.Stream stream)
		{
			this.m_Stream = stream;
			if (this.m_CurrentBuffer == null)
			{
				this.m_CurrentBuffer = new global::Gibraltar.Serialization.PacketManagerBase.Buffer();
			}
			if (this.m_OtherBuffer == null)
			{
				this.m_OtherBuffer = new global::Gibraltar.Serialization.PacketManagerBase.Buffer();
			}
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0001B614 File Offset: 0x00019814
		private int FetchBuffer(global::Gibraltar.Serialization.PacketManagerBase.Buffer buffer)
		{
			int num = (buffer.Position == buffer.Length) ? 0 : buffer.Position;
			int count = buffer.DataBytes.Length - num;
			int num2 = this.m_Stream.Read(buffer.DataBytes, num, count);
			if (num2 > 0)
			{
				buffer.Length = num + num2;
			}
			else
			{
				buffer.Length = num;
			}
			return num2;
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0001B680 File Offset: 0x00019880
		private void SwapBuffers()
		{
			global::Gibraltar.Serialization.PacketManagerBase.Buffer currentBuffer = this.m_CurrentBuffer;
			this.m_CurrentBuffer = this.m_OtherBuffer;
			this.m_OtherBuffer = currentBuffer;
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0001B6AC File Offset: 0x000198AC
		public override global::System.IO.MemoryStream GetNextPacket()
		{
			for (int i = 0; i < 2; i++)
			{
				global::System.IO.MemoryStream packetStream;
				if (this.m_CurrentBuffer.PrependToNextBuffer)
				{
					int num = this.m_CurrentBuffer.BytesAvailable();
					if (num <= 0 || num >= 5)
					{
						throw new global::Gibraltar.Serialization.GibraltarSerializationException("Unexpected number of BytesAvailable: " + num + ". The value should be in the range [1..4] because it is a partial length.", true);
					}
					this.m_OtherBuffer.Reset();
					this.m_CurrentBuffer.ReadBytes(this.m_OtherBuffer.DataBytes, 0, num);
					this.m_OtherBuffer.Position = num;
					if (this.FetchBuffer(this.m_OtherBuffer) <= 0)
					{
						throw new global::Gibraltar.Serialization.GibraltarSerializationException("Unable to read the rest of a packet length that spans buffers", true);
					}
					this.m_OtherBuffer.Position = 0;
					this.SwapBuffers();
					packetStream = this.m_CurrentBuffer.GetPacketStream();
				}
				else if (this.m_CurrentBuffer.NeededFromNextBuffer > 0)
				{
					int num2 = this.m_CurrentBuffer.BytesAvailable();
					int neededFromNextBuffer = this.m_CurrentBuffer.NeededFromNextBuffer;
					int num3 = num2 + neededFromNextBuffer;
					this.m_OtherBuffer.Reset();
					this.m_OtherBuffer.ExpandIfNeeded(num3);
					if (num2 > 0)
					{
						this.m_CurrentBuffer.ReadBytes(this.m_OtherBuffer.DataBytes, 0, num2);
					}
					this.m_OtherBuffer.Position = num2;
					int num4 = this.FetchBuffer(this.m_OtherBuffer);
					if (num4 < neededFromNextBuffer)
					{
						throw new global::Gibraltar.Serialization.GibraltarSerializationException(string.Format("Incomplete session file detected after reading {0} packets.  Expected {1} bytes but hit EOF after {2} bytes.", this.m_PacketCount, num3, num2 + num4), true);
					}
					this.m_OtherBuffer.Position = 0;
					this.SwapBuffers();
					packetStream = this.m_CurrentBuffer.GetPacketStream(num3);
				}
				else
				{
					if (this.m_CurrentBuffer.IsEmpty())
					{
						this.m_CurrentBuffer.Reset();
						if (this.FetchBuffer(this.m_CurrentBuffer) <= 0)
						{
							return null;
						}
					}
					packetStream = this.m_CurrentBuffer.GetPacketStream();
				}
				if (packetStream != null)
				{
					this.m_PacketCount++;
					return packetStream;
				}
			}
			return null;
		}

		// Token: 0x040002FC RID: 764
		private readonly global::System.IO.Stream m_Stream;

		// Token: 0x040002FD RID: 765
		private global::Gibraltar.Serialization.PacketManagerBase.Buffer m_CurrentBuffer;

		// Token: 0x040002FE RID: 766
		private global::Gibraltar.Serialization.PacketManagerBase.Buffer m_OtherBuffer;

		// Token: 0x040002FF RID: 767
		private int m_PacketCount;
	}
}
