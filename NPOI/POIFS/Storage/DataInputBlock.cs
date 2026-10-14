using System;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002AA RID: 682
	public class DataInputBlock
	{
		// Token: 0x060012CD RID: 4813 RVA: 0x00038685 File Offset: 0x00036885
		internal DataInputBlock(byte[] data, int startOffset)
		{
			this._buf = data;
			this._readIndex = startOffset;
			this._maxIndex = this._buf.Length;
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x000386A9 File Offset: 0x000368A9
		public int Available()
		{
			return this._maxIndex - this._readIndex;
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x000386B8 File Offset: 0x000368B8
		public int ReadUByte()
		{
			byte[] buf = this._buf;
			int readIndex = this._readIndex;
			this._readIndex = readIndex + 1;
			return buf[readIndex] & 255;
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x000386E4 File Offset: 0x000368E4
		public int ReadUshortLE()
		{
			int readIndex = this._readIndex;
			int num = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num2 = (int)(this._buf[readIndex++] & byte.MaxValue);
			this._readIndex = readIndex;
			return (num2 << 8) + num;
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00038728 File Offset: 0x00036928
		public int ReadUshortLE(global::NPOI.POIFS.Storage.DataInputBlock prevBlock)
		{
			int num = prevBlock._buf.Length - 1;
			int num2 = (int)(prevBlock._buf[num] & byte.MaxValue);
			byte[] buf = this._buf;
			int readIndex = this._readIndex;
			this._readIndex = readIndex + 1;
			return ((buf[readIndex] & 255) << 8) + num2;
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00038774 File Offset: 0x00036974
		public int ReadIntLE()
		{
			int readIndex = this._readIndex;
			int num = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num2 = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num3 = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num4 = (int)(this._buf[readIndex++] & byte.MaxValue);
			this._readIndex = readIndex;
			return (num4 << 24) + (num3 << 16) + (num2 << 8) + num;
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x000387E8 File Offset: 0x000369E8
		public int ReadIntLE(global::NPOI.POIFS.Storage.DataInputBlock prevBlock, int prevBlockAvailable)
		{
			byte[] array = new byte[4];
			this.ReadSpanning(prevBlock, prevBlockAvailable, array);
			int num = (int)(array[0] & byte.MaxValue);
			int num2 = (int)(array[1] & byte.MaxValue);
			int num3 = (int)(array[2] & byte.MaxValue);
			return ((int)(array[3] & byte.MaxValue) << 24) + (num3 << 16) + (num2 << 8) + num;
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x0003883C File Offset: 0x00036A3C
		public long ReadLongLE()
		{
			int readIndex = this._readIndex;
			int num = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num2 = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num3 = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num4 = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num5 = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num6 = (int)(this._buf[readIndex++] & byte.MaxValue);
			int num7 = (int)(this._buf[readIndex++] & byte.MaxValue);
			long num8 = (long)(this._buf[readIndex++] & byte.MaxValue);
			this._readIndex = readIndex;
			return (num8 << 56) + ((long)num7 << 48) + ((long)num6 << 40) + ((long)num5 << 32) + ((long)num4 << 24) + (long)((long)num3 << 16) + (long)((long)num2 << 8) + (long)num;
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x00038920 File Offset: 0x00036B20
		public long ReadLongLE(global::NPOI.POIFS.Storage.DataInputBlock prevBlock, int prevBlockAvailable)
		{
			byte[] array = new byte[8];
			this.ReadSpanning(prevBlock, prevBlockAvailable, array);
			int num = (int)(array[0] & byte.MaxValue);
			int num2 = (int)(array[1] & byte.MaxValue);
			int num3 = (int)(array[2] & byte.MaxValue);
			int num4 = (int)(array[3] & byte.MaxValue);
			int num5 = (int)(array[4] & byte.MaxValue);
			int num6 = (int)(array[5] & byte.MaxValue);
			int num7 = (int)(array[6] & byte.MaxValue);
			return ((long)(array[7] & byte.MaxValue) << 56) + ((long)num7 << 48) + ((long)num6 << 40) + ((long)num5 << 32) + ((long)num4 << 24) + (long)((long)num3 << 16) + (long)((long)num2 << 8) + (long)num;
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x000389C0 File Offset: 0x00036BC0
		private void ReadSpanning(global::NPOI.POIFS.Storage.DataInputBlock prevBlock, int prevBlockAvailable, byte[] buf)
		{
			global::System.Array.Copy(prevBlock._buf, prevBlock._readIndex, buf, 0, prevBlockAvailable);
			int num = buf.Length - prevBlockAvailable;
			global::System.Array.Copy(this._buf, 0, buf, prevBlockAvailable, num);
			this._readIndex = num;
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x000389FD File Offset: 0x00036BFD
		public void ReadFully(byte[] buf, int off, int len)
		{
			global::System.Array.Copy(this._buf, this._readIndex, buf, off, len);
			this._readIndex += len;
		}

		// Token: 0x040007C6 RID: 1990
		private byte[] _buf;

		// Token: 0x040007C7 RID: 1991
		private int _readIndex;

		// Token: 0x040007C8 RID: 1992
		private int _maxIndex;
	}
}
