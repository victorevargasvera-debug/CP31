using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200056B RID: 1387
	public class BcpgOutputStream : global::Org.BouncyCastle.Utilities.IO.BaseOutputStream
	{
		// Token: 0x06003507 RID: 13575 RVA: 0x000FD3C6 File Offset: 0x000FB5C6
		internal static global::Org.BouncyCastle.Bcpg.BcpgOutputStream Wrap(global::System.IO.Stream outStr)
		{
			if (outStr is global::Org.BouncyCastle.Bcpg.BcpgOutputStream)
			{
				return (global::Org.BouncyCastle.Bcpg.BcpgOutputStream)outStr;
			}
			return new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(outStr);
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x000FD3DD File Offset: 0x000FB5DD
		public BcpgOutputStream(global::System.IO.Stream outStr)
		{
			if (outStr == null)
			{
				throw new global::System.ArgumentNullException("outStr");
			}
			this.outStr = outStr;
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x000FD3FA File Offset: 0x000FB5FA
		public BcpgOutputStream(global::System.IO.Stream outStr, global::Org.BouncyCastle.Bcpg.PacketTag tag)
		{
			if (outStr == null)
			{
				throw new global::System.ArgumentNullException("outStr");
			}
			this.outStr = outStr;
			this.WriteHeader(tag, true, true, 0L);
		}

		// Token: 0x0600350A RID: 13578 RVA: 0x000FD424 File Offset: 0x000FB624
		public BcpgOutputStream(global::System.IO.Stream outStr, global::Org.BouncyCastle.Bcpg.PacketTag tag, long length, bool oldFormat)
		{
			if (outStr == null)
			{
				throw new global::System.ArgumentNullException("outStr");
			}
			this.outStr = outStr;
			if (length > (long)((ulong)-1))
			{
				this.WriteHeader(tag, false, true, 0L);
				this.partialBufferLength = 65536;
				this.partialBuffer = new byte[this.partialBufferLength];
				this.partialPower = 16;
				this.partialOffset = 0;
				return;
			}
			this.WriteHeader(tag, oldFormat, false, length);
		}

		// Token: 0x0600350B RID: 13579 RVA: 0x000FD493 File Offset: 0x000FB693
		public BcpgOutputStream(global::System.IO.Stream outStr, global::Org.BouncyCastle.Bcpg.PacketTag tag, long length)
		{
			if (outStr == null)
			{
				throw new global::System.ArgumentNullException("outStr");
			}
			this.outStr = outStr;
			this.WriteHeader(tag, false, false, length);
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x000FD4BC File Offset: 0x000FB6BC
		public BcpgOutputStream(global::System.IO.Stream outStr, global::Org.BouncyCastle.Bcpg.PacketTag tag, byte[] buffer)
		{
			if (outStr == null)
			{
				throw new global::System.ArgumentNullException("outStr");
			}
			this.outStr = outStr;
			this.WriteHeader(tag, false, true, 0L);
			this.partialBuffer = buffer;
			uint length = (uint)this.partialBuffer.Length;
			this.partialPower = 0;
			while (length != 1U)
			{
				length >>= 1;
				this.partialPower++;
			}
			if (this.partialPower > 30)
			{
				throw new global::System.IO.IOException("Buffer cannot be greater than 2^30 in length.");
			}
			this.partialBufferLength = 1 << this.partialPower;
			this.partialOffset = 0;
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x000FD54C File Offset: 0x000FB74C
		private void WriteNewPacketLength(long bodyLen)
		{
			if (bodyLen < 192L)
			{
				this.outStr.WriteByte((byte)bodyLen);
				return;
			}
			if (bodyLen <= 8383L)
			{
				bodyLen -= 192L;
				this.outStr.WriteByte((byte)((bodyLen >> 8 & 255L) + 192L));
				this.outStr.WriteByte((byte)bodyLen);
				return;
			}
			this.outStr.WriteByte(byte.MaxValue);
			this.outStr.WriteByte((byte)(bodyLen >> 24));
			this.outStr.WriteByte((byte)(bodyLen >> 16));
			this.outStr.WriteByte((byte)(bodyLen >> 8));
			this.outStr.WriteByte((byte)bodyLen);
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x000FD5FC File Offset: 0x000FB7FC
		private void WriteHeader(global::Org.BouncyCastle.Bcpg.PacketTag tag, bool oldPackets, bool partial, long bodyLen)
		{
			int hdr = 128;
			if (this.partialBuffer != null)
			{
				this.PartialFlush(true);
				this.partialBuffer = null;
			}
			if (oldPackets)
			{
				hdr |= (int)((int)tag << 2);
				if (partial)
				{
					this.WriteByte((byte)(hdr | 3));
					return;
				}
				if (bodyLen <= 255L)
				{
					this.WriteByte((byte)hdr);
					this.WriteByte((byte)bodyLen);
					return;
				}
				if (bodyLen <= 65535L)
				{
					this.WriteByte((byte)(hdr | 1));
					this.WriteByte((byte)(bodyLen >> 8));
					this.WriteByte((byte)bodyLen);
					return;
				}
				this.WriteByte((byte)(hdr | 2));
				this.WriteByte((byte)(bodyLen >> 24));
				this.WriteByte((byte)(bodyLen >> 16));
				this.WriteByte((byte)(bodyLen >> 8));
				this.WriteByte((byte)bodyLen);
				return;
			}
			else
			{
				hdr |= (int)((global::Org.BouncyCastle.Bcpg.PacketTag)64 | tag);
				this.WriteByte((byte)hdr);
				if (partial)
				{
					this.partialOffset = 0;
					return;
				}
				this.WriteNewPacketLength(bodyLen);
				return;
			}
		}

		// Token: 0x0600350F RID: 13583 RVA: 0x000FD6E0 File Offset: 0x000FB8E0
		private void PartialFlush(bool isLast)
		{
			if (isLast)
			{
				this.WriteNewPacketLength((long)this.partialOffset);
				this.outStr.Write(this.partialBuffer, 0, this.partialOffset);
			}
			else
			{
				this.outStr.WriteByte((byte)(224 | this.partialPower));
				this.outStr.Write(this.partialBuffer, 0, this.partialBufferLength);
			}
			this.partialOffset = 0;
		}

		// Token: 0x06003510 RID: 13584 RVA: 0x000FD750 File Offset: 0x000FB950
		private void WritePartial(byte b)
		{
			if (this.partialOffset == this.partialBufferLength)
			{
				this.PartialFlush(false);
			}
			byte[] array = this.partialBuffer;
			int num = this.partialOffset;
			this.partialOffset = num + 1;
			array[num] = b;
		}

		// Token: 0x06003511 RID: 13585 RVA: 0x000FD78C File Offset: 0x000FB98C
		private void WritePartial(byte[] buffer, int off, int len)
		{
			if (this.partialOffset == this.partialBufferLength)
			{
				this.PartialFlush(false);
			}
			if (len <= this.partialBufferLength - this.partialOffset)
			{
				global::System.Array.Copy(buffer, off, this.partialBuffer, this.partialOffset, len);
				this.partialOffset += len;
				return;
			}
			int diff = this.partialBufferLength - this.partialOffset;
			global::System.Array.Copy(buffer, off, this.partialBuffer, this.partialOffset, diff);
			off += diff;
			len -= diff;
			this.PartialFlush(false);
			while (len > this.partialBufferLength)
			{
				global::System.Array.Copy(buffer, off, this.partialBuffer, 0, this.partialBufferLength);
				off += this.partialBufferLength;
				len -= this.partialBufferLength;
				this.PartialFlush(false);
			}
			global::System.Array.Copy(buffer, off, this.partialBuffer, 0, len);
			this.partialOffset += len;
		}

		// Token: 0x06003512 RID: 13586 RVA: 0x000FD86B File Offset: 0x000FBA6B
		public override void WriteByte(byte value)
		{
			if (this.partialBuffer != null)
			{
				this.WritePartial(value);
				return;
			}
			this.outStr.WriteByte(value);
		}

		// Token: 0x06003513 RID: 13587 RVA: 0x000FD889 File Offset: 0x000FBA89
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this.partialBuffer != null)
			{
				this.WritePartial(buffer, offset, count);
				return;
			}
			this.outStr.Write(buffer, offset, count);
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x000FD8AB File Offset: 0x000FBAAB
		internal virtual void WriteShort(short n)
		{
			this.Write(new byte[]
			{
				(byte)(n >> 8),
				(byte)n
			});
		}

		// Token: 0x06003515 RID: 13589 RVA: 0x000FD8C5 File Offset: 0x000FBAC5
		internal virtual void WriteInt(int n)
		{
			this.Write(new byte[]
			{
				(byte)(n >> 24),
				(byte)(n >> 16),
				(byte)(n >> 8),
				(byte)n
			});
		}

		// Token: 0x06003516 RID: 13590 RVA: 0x000FD8F0 File Offset: 0x000FBAF0
		internal virtual void WriteLong(long n)
		{
			this.Write(new byte[]
			{
				(byte)(n >> 56),
				(byte)(n >> 48),
				(byte)(n >> 40),
				(byte)(n >> 32),
				(byte)(n >> 24),
				(byte)(n >> 16),
				(byte)(n >> 8),
				(byte)n
			});
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x000FD945 File Offset: 0x000FBB45
		public void WritePacket(global::Org.BouncyCastle.Bcpg.ContainedPacket p)
		{
			p.Encode(this);
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x000FD94E File Offset: 0x000FBB4E
		internal void WritePacket(global::Org.BouncyCastle.Bcpg.PacketTag tag, byte[] body, bool oldFormat)
		{
			this.WriteHeader(tag, oldFormat, false, (long)body.Length);
			this.Write(body);
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x000FD964 File Offset: 0x000FBB64
		public void WriteObject(global::Org.BouncyCastle.Bcpg.BcpgObject bcpgObject)
		{
			bcpgObject.Encode(this);
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x000FD970 File Offset: 0x000FBB70
		public void WriteObjects(params global::Org.BouncyCastle.Bcpg.BcpgObject[] v)
		{
			for (int i = 0; i < v.Length; i++)
			{
				v[i].Encode(this);
			}
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x000FD996 File Offset: 0x000FBB96
		public override void Flush()
		{
			this.outStr.Flush();
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x000FD9A3 File Offset: 0x000FBBA3
		public void Finish()
		{
			if (this.partialBuffer != null)
			{
				this.PartialFlush(true);
				global::System.Array.Clear(this.partialBuffer, 0, this.partialBuffer.Length);
				this.partialBuffer = null;
			}
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x000FD9CF File Offset: 0x000FBBCF
		public override void Close()
		{
			this.Finish();
			this.outStr.Flush();
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.outStr);
			base.Close();
		}

		// Token: 0x040017BF RID: 6079
		private global::System.IO.Stream outStr;

		// Token: 0x040017C0 RID: 6080
		private byte[] partialBuffer;

		// Token: 0x040017C1 RID: 6081
		private int partialBufferLength;

		// Token: 0x040017C2 RID: 6082
		private int partialPower;

		// Token: 0x040017C3 RID: 6083
		private int partialOffset;

		// Token: 0x040017C4 RID: 6084
		private const int BufferSizePower = 16;
	}
}
