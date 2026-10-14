using System;
using System.IO;

namespace Ionic.BZip2
{
	// Token: 0x02000441 RID: 1089
	internal class BitWriter
	{
		// Token: 0x06002F16 RID: 12054 RVA: 0x000A50C4 File Offset: 0x000A32C4
		public BitWriter(global::System.IO.Stream s)
		{
			this.output = s;
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x06002F17 RID: 12055 RVA: 0x000A50D4 File Offset: 0x000A32D4
		public byte RemainingBits
		{
			get
			{
				return (byte)(this.accumulator >> 32 - this.nAccumulatedBits & 255U);
			}
		}

		// Token: 0x17000D98 RID: 3480
		// (get) Token: 0x06002F18 RID: 12056 RVA: 0x000A50F0 File Offset: 0x000A32F0
		public int NumRemainingBits
		{
			get
			{
				return this.nAccumulatedBits;
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06002F19 RID: 12057 RVA: 0x000A50F8 File Offset: 0x000A32F8
		public int TotalBytesWrittenOut
		{
			get
			{
				return this.totalBytesWrittenOut;
			}
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x000A5100 File Offset: 0x000A3300
		public void Reset()
		{
			this.accumulator = 0U;
			this.nAccumulatedBits = 0;
			this.totalBytesWrittenOut = 0;
			this.output.Seek(0L, global::System.IO.SeekOrigin.Begin);
			this.output.SetLength(0L);
		}

		// Token: 0x06002F1B RID: 12059 RVA: 0x000A5134 File Offset: 0x000A3334
		public void WriteBits(int nbits, uint value)
		{
			int i = this.nAccumulatedBits;
			uint num = this.accumulator;
			while (i >= 8)
			{
				this.output.WriteByte((byte)(num >> 24 & 255U));
				this.totalBytesWrittenOut++;
				num <<= 8;
				i -= 8;
			}
			this.accumulator = (num | value << 32 - i - nbits);
			this.nAccumulatedBits = i + nbits;
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x000A51A4 File Offset: 0x000A33A4
		public void WriteByte(byte b)
		{
			this.WriteBits(8, (uint)b);
		}

		// Token: 0x06002F1D RID: 12061 RVA: 0x000A51B0 File Offset: 0x000A33B0
		public void WriteInt(uint u)
		{
			this.WriteBits(8, u >> 24 & 255U);
			this.WriteBits(8, u >> 16 & 255U);
			this.WriteBits(8, u >> 8 & 255U);
			this.WriteBits(8, u & 255U);
		}

		// Token: 0x06002F1E RID: 12062 RVA: 0x000A5204 File Offset: 0x000A3404
		public void Flush()
		{
			this.WriteBits(0, 0U);
		}

		// Token: 0x06002F1F RID: 12063 RVA: 0x000A5210 File Offset: 0x000A3410
		public void FinishAndPad()
		{
			this.Flush();
			if (this.NumRemainingBits > 0)
			{
				byte value = (byte)(this.accumulator >> 24 & 255U);
				this.output.WriteByte(value);
				this.totalBytesWrittenOut++;
			}
		}

		// Token: 0x040010E2 RID: 4322
		private uint accumulator;

		// Token: 0x040010E3 RID: 4323
		private int nAccumulatedBits;

		// Token: 0x040010E4 RID: 4324
		private global::System.IO.Stream output;

		// Token: 0x040010E5 RID: 4325
		private int totalBytesWrittenOut;
	}
}
