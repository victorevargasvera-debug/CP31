using System;
using System.IO;

namespace Ionic.BZip2
{
	// Token: 0x02000062 RID: 98
	internal class BitWriter
	{
		// Token: 0x060004BA RID: 1210 RVA: 0x0001C580 File Offset: 0x0001A780
		public BitWriter(global::System.IO.Stream s)
		{
			this.output = s;
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x0001C58F File Offset: 0x0001A78F
		public byte RemainingBits
		{
			get
			{
				return (byte)(this.accumulator >> 32 - this.nAccumulatedBits & 255U);
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x0001C5AB File Offset: 0x0001A7AB
		public int NumRemainingBits
		{
			get
			{
				return this.nAccumulatedBits;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0001C5B3 File Offset: 0x0001A7B3
		public int TotalBytesWrittenOut
		{
			get
			{
				return this.totalBytesWrittenOut;
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0001C5BB File Offset: 0x0001A7BB
		public void Reset()
		{
			this.accumulator = 0U;
			this.nAccumulatedBits = 0;
			this.totalBytesWrittenOut = 0;
			this.output.Seek(0L, global::System.IO.SeekOrigin.Begin);
			this.output.SetLength(0L);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0001C5F0 File Offset: 0x0001A7F0
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

		// Token: 0x060004C0 RID: 1216 RVA: 0x0001C659 File Offset: 0x0001A859
		public void WriteByte(byte b)
		{
			this.WriteBits(8, (uint)b);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0001C664 File Offset: 0x0001A864
		public void WriteInt(uint u)
		{
			this.WriteBits(8, u >> 24 & 255U);
			this.WriteBits(8, u >> 16 & 255U);
			this.WriteBits(8, u >> 8 & 255U);
			this.WriteBits(8, u & 255U);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0001C6B1 File Offset: 0x0001A8B1
		public void Flush()
		{
			this.WriteBits(0, 0U);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0001C6BC File Offset: 0x0001A8BC
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

		// Token: 0x04000346 RID: 838
		private uint accumulator;

		// Token: 0x04000347 RID: 839
		private int nAccumulatedBits;

		// Token: 0x04000348 RID: 840
		private global::System.IO.Stream output;

		// Token: 0x04000349 RID: 841
		private int totalBytesWrittenOut;
	}
}
