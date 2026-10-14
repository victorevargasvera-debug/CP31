using System;
using System.IO;

namespace Gibraltar.Serialization
{
	// Token: 0x02000108 RID: 264
	internal abstract class PacketManagerBase
	{
		// Token: 0x06000AF1 RID: 2801
		public abstract global::System.IO.MemoryStream GetNextPacket();

		// Token: 0x02000498 RID: 1176
		protected class Buffer
		{
			// Token: 0x17000EB6 RID: 3766
			// (get) Token: 0x0600331B RID: 13083 RVA: 0x000B9B0C File Offset: 0x000B7D0C
			// (set) Token: 0x0600331C RID: 13084 RVA: 0x000B9B14 File Offset: 0x000B7D14
			public byte[] DataBytes { get; private set; }

			// Token: 0x17000EB7 RID: 3767
			// (get) Token: 0x0600331D RID: 13085 RVA: 0x000B9B20 File Offset: 0x000B7D20
			// (set) Token: 0x0600331E RID: 13086 RVA: 0x000B9B28 File Offset: 0x000B7D28
			public int Length { get; set; }

			// Token: 0x17000EB8 RID: 3768
			// (get) Token: 0x0600331F RID: 13087 RVA: 0x000B9B34 File Offset: 0x000B7D34
			// (set) Token: 0x06003320 RID: 13088 RVA: 0x000B9B3C File Offset: 0x000B7D3C
			public int Position { get; set; }

			// Token: 0x06003321 RID: 13089 RVA: 0x000B9B48 File Offset: 0x000B7D48
			public Buffer()
			{
				this.DataBytes = new byte[131072];
			}

			// Token: 0x06003322 RID: 13090 RVA: 0x000B9B60 File Offset: 0x000B7D60
			public void Reset()
			{
				this.Length = 0;
				this.Position = 0;
				this.PrependToNextBuffer = false;
				this.NeededFromNextBuffer = 0;
			}

			// Token: 0x06003323 RID: 13091 RVA: 0x000B9B90 File Offset: 0x000B7D90
			public void ExpandIfNeeded(int newLength)
			{
				if (this.DataBytes.Length >= newLength)
				{
					return;
				}
				int i;
				for (i = this.DataBytes.Length; i < newLength; i += 131072)
				{
				}
				this.DataBytes = new byte[i];
			}

			// Token: 0x06003324 RID: 13092 RVA: 0x000B9BD8 File Offset: 0x000B7DD8
			public bool IsEmpty()
			{
				return this.Position >= this.Length;
			}

			// Token: 0x06003325 RID: 13093 RVA: 0x000B9BEC File Offset: 0x000B7DEC
			public int BytesAvailable()
			{
				return this.Length - this.Position;
			}

			// Token: 0x17000EB9 RID: 3769
			// (get) Token: 0x06003326 RID: 13094 RVA: 0x000B9BFC File Offset: 0x000B7DFC
			// (set) Token: 0x06003327 RID: 13095 RVA: 0x000B9C04 File Offset: 0x000B7E04
			public bool PrependToNextBuffer { get; private set; }

			// Token: 0x17000EBA RID: 3770
			// (get) Token: 0x06003328 RID: 13096 RVA: 0x000B9C10 File Offset: 0x000B7E10
			// (set) Token: 0x06003329 RID: 13097 RVA: 0x000B9C18 File Offset: 0x000B7E18
			public int NeededFromNextBuffer { get; private set; }

			// Token: 0x0600332A RID: 13098 RVA: 0x000B9C24 File Offset: 0x000B7E24
			public global::System.IO.MemoryStream GetPacketStream()
			{
				int num = this.ReadPacketLength();
				if (num == -1)
				{
					this.PrependToNextBuffer = true;
					return null;
				}
				if (num < 1)
				{
					throw new global::Gibraltar.Serialization.GibraltarSerializationException("The size of the next packet is smaller than 1 byte or negative, which can't be correct.  The packet stream is corrupted.", true);
				}
				if (num > this.BytesAvailable())
				{
					this.NeededFromNextBuffer = num - (this.Length - this.Position);
					return null;
				}
				return this.GetPacketStream(num);
			}

			// Token: 0x0600332B RID: 13099 RVA: 0x000B9C8C File Offset: 0x000B7E8C
			public global::System.IO.MemoryStream GetPacketStream(int packetLength)
			{
				global::System.IO.MemoryStream result = new global::System.IO.MemoryStream(this.DataBytes, this.Position, packetLength);
				this.Position += packetLength;
				return result;
			}

			// Token: 0x0600332C RID: 13100 RVA: 0x000B9CC0 File Offset: 0x000B7EC0
			public void ReadBytes(byte[] destination, int offset, int count)
			{
				if (count <= 0)
				{
					throw new global::Gibraltar.Serialization.GibraltarSerializationException("ReadBytes called with non-positive count: " + count, true);
				}
				if (offset + count > destination.Length)
				{
					throw new global::Gibraltar.Serialization.GibraltarSerializationException(string.Concat(new object[]
					{
						"ReadBytes called with count that would overflow buffer. Count=",
						count,
						", Buffer.Length=",
						destination.Length,
						", Buffer.Offset=",
						offset
					}), true);
				}
				if (count > this.BytesAvailable())
				{
					throw new global::Gibraltar.Serialization.GibraltarSerializationException(string.Concat(new object[]
					{
						"ReadBytes called to read ",
						count,
						" bytes when only ",
						this.BytesAvailable(),
						" bytes are available."
					}), true);
				}
				global::System.Buffer.BlockCopy(this.DataBytes, this.Position, destination, offset, count);
				this.Position += count;
			}

			// Token: 0x0600332D RID: 13101 RVA: 0x000B9DB0 File Offset: 0x000B7FB0
			private int ReadPacketLength()
			{
				ulong num = 0UL;
				int num2 = 0;
				int i = this.Position;
				while (i < this.Length)
				{
					if (i > this.Position + 5)
					{
						throw new global::Gibraltar.Serialization.GibraltarSerializationException("Invalid length detected in ReadPacketLength. Length should not be more that 5 bytes.", true);
					}
					byte b = this.DataBytes[i];
					if (num2 < 56)
					{
						num |= ((ulong)b & 127UL) << num2;
						num2 += 7;
						if ((b & 128) == 0)
						{
							this.Position = i + 1;
							if (num < 0UL || num > 2147483647UL)
							{
								throw new global::Gibraltar.Serialization.GibraltarSerializationException("Illegal packet length: " + num, true);
							}
							return (int)num;
						}
						else
						{
							i++;
						}
					}
					else
					{
						num |= ((ulong)b & 255UL) << 56;
						this.Position = i + 1;
						if (num < 0UL || num > 2147483647UL)
						{
							throw new global::Gibraltar.Serialization.GibraltarSerializationException("Illegal packet length read: " + num, true);
						}
						return (int)num;
					}
				}
				return -1;
			}

			// Token: 0x04001370 RID: 4976
			private const int BufferSize = 131072;
		}
	}
}
