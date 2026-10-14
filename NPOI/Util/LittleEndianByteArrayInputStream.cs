using System;

namespace NPOI.Util
{
	// Token: 0x02000273 RID: 627
	public class LittleEndianByteArrayInputStream : global::NPOI.Util.ILittleEndianInput
	{
		// Token: 0x06001094 RID: 4244 RVA: 0x00032BF6 File Offset: 0x00030DF6
		public LittleEndianByteArrayInputStream(byte[] buf, int startOffset, int maxReadLen)
		{
			this._buf = buf;
			this._ReadIndex = startOffset;
			this._endIndex = startOffset + maxReadLen;
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00032C15 File Offset: 0x00030E15
		public LittleEndianByteArrayInputStream(byte[] buf, int startOffset) : this(buf, startOffset, buf.Length - startOffset)
		{
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00032C24 File Offset: 0x00030E24
		public LittleEndianByteArrayInputStream(byte[] buf) : this(buf, 0, buf.Length)
		{
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00032C31 File Offset: 0x00030E31
		public int Available()
		{
			return this._endIndex - this._ReadIndex;
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00032C40 File Offset: 0x00030E40
		private void CheckPosition(int i)
		{
			if (i > this._endIndex - this._ReadIndex)
			{
				throw new global::NPOI.Util.RuntimeException("Buffer overrun");
			}
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00032C5D File Offset: 0x00030E5D
		public int GetReadIndex()
		{
			return this._ReadIndex;
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00032C68 File Offset: 0x00030E68
		public int ReadByte()
		{
			this.CheckPosition(1);
			byte[] buf = this._buf;
			int readIndex = this._ReadIndex;
			this._ReadIndex = readIndex + 1;
			return buf[readIndex];
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x00032C94 File Offset: 0x00030E94
		public int ReadInt()
		{
			this.CheckPosition(4);
			int readIndex = this._ReadIndex;
			int num = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num2 = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num3 = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num4 = (int)(this._buf[readIndex++] & byte.MaxValue);
			this._ReadIndex = readIndex;
			return (num4 << 24) + (num3 << 16) + (num2 << 8) + num;
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00032D10 File Offset: 0x00030F10
		public long ReadLong()
		{
			this.CheckPosition(8);
			int readIndex = this._ReadIndex;
			int num = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num2 = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num3 = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num4 = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num5 = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num6 = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num7 = (int)(this._buf[readIndex++] & byte.MaxValue);
			long num8 = (long)(this._buf[readIndex++] & byte.MaxValue);
			this._ReadIndex = readIndex;
			return (num8 << 56) + ((long)num7 << 48) + ((long)num6 << 40) + ((long)num5 << 32) + ((long)num4 << 24) + (long)((long)num3 << 16) + (long)((long)num2 << 8) + (long)num;
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00032DFB File Offset: 0x00030FFB
		public short ReadShort()
		{
			return (short)this.ReadUShort();
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00032E04 File Offset: 0x00031004
		public int ReadUByte()
		{
			this.CheckPosition(1);
			byte[] buf = this._buf;
			int readIndex = this._ReadIndex;
			this._ReadIndex = readIndex + 1;
			return buf[readIndex] & 255;
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00032E38 File Offset: 0x00031038
		public int ReadUShort()
		{
			this.CheckPosition(2);
			int readIndex = this._ReadIndex;
			int num = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num2 = (int)(this._buf[readIndex++] & byte.MaxValue);
			this._ReadIndex = readIndex;
			return (num2 << 8) + num;
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00032E83 File Offset: 0x00031083
		public void ReadFully(byte[] buf, int off, int len)
		{
			this.CheckPosition(len);
			global::System.Array.Copy(this._buf, this._ReadIndex, buf, off, len);
			this._ReadIndex += len;
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x00032EAE File Offset: 0x000310AE
		public void ReadFully(byte[] buf)
		{
			this.ReadFully(buf, 0, buf.Length);
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00032EBB File Offset: 0x000310BB
		public double ReadDouble()
		{
			return global::System.BitConverter.Int64BitsToDouble(this.ReadLong());
		}

		// Token: 0x04000737 RID: 1847
		private byte[] _buf;

		// Token: 0x04000738 RID: 1848
		private int _endIndex;

		// Token: 0x04000739 RID: 1849
		private int _ReadIndex;
	}
}
