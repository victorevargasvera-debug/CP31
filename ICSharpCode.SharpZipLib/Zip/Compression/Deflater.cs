using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x02000033 RID: 51
	public class Deflater
	{
		// Token: 0x06000218 RID: 536 RVA: 0x0000AA6D File Offset: 0x00008C6D
		public Deflater() : this(-1, false)
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000AA77 File Offset: 0x00008C77
		public Deflater(int level) : this(level, false)
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000AA84 File Offset: 0x00008C84
		public Deflater(int level, bool noZlibHeaderOrFooter)
		{
			if (level == -1)
			{
				level = 6;
			}
			else if (level < 0 || level > 9)
			{
				throw new global::System.ArgumentOutOfRangeException("level");
			}
			this.pending = new global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending();
			this.engine = new global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterEngine(this.pending, noZlibHeaderOrFooter);
			this.noZlibHeaderOrFooter = noZlibHeaderOrFooter;
			this.SetStrategy(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy.Default);
			this.SetLevel(level);
			this.Reset();
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000AAEC File Offset: 0x00008CEC
		public void Reset()
		{
			this.state = (this.noZlibHeaderOrFooter ? 16 : 0);
			this.totalOut = 0L;
			this.pending.Reset();
			this.engine.Reset();
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0000AB1F File Offset: 0x00008D1F
		public int Adler
		{
			get
			{
				return this.engine.Adler;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000AB2C File Offset: 0x00008D2C
		public long TotalIn
		{
			get
			{
				return this.engine.TotalIn;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0000AB39 File Offset: 0x00008D39
		public long TotalOut
		{
			get
			{
				return this.totalOut;
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000AB41 File Offset: 0x00008D41
		public void Flush()
		{
			this.state |= 4;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000AB51 File Offset: 0x00008D51
		public void Finish()
		{
			this.state |= 12;
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000AB62 File Offset: 0x00008D62
		public bool IsFinished
		{
			get
			{
				return this.state == 30 && this.pending.IsFlushed;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000AB7B File Offset: 0x00008D7B
		public bool IsNeedingInput
		{
			get
			{
				return this.engine.NeedsInput();
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000AB88 File Offset: 0x00008D88
		public void SetInput(byte[] input)
		{
			this.SetInput(input, 0, input.Length);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000AB95 File Offset: 0x00008D95
		public void SetInput(byte[] input, int offset, int count)
		{
			if ((this.state & 8) != 0)
			{
				throw new global::System.InvalidOperationException("Finish() already called");
			}
			this.engine.SetInput(input, offset, count);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000ABBA File Offset: 0x00008DBA
		public void SetLevel(int level)
		{
			if (level == -1)
			{
				level = 6;
			}
			else if (level < 0 || level > 9)
			{
				throw new global::System.ArgumentOutOfRangeException("level");
			}
			if (this.level != level)
			{
				this.level = level;
				this.engine.SetLevel(level);
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000ABF5 File Offset: 0x00008DF5
		public int GetLevel()
		{
			return this.level;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000ABFD File Offset: 0x00008DFD
		public void SetStrategy(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy strategy)
		{
			this.engine.Strategy = strategy;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000AC0B File Offset: 0x00008E0B
		public int Deflate(byte[] output)
		{
			return this.Deflate(output, 0, output.Length);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000AC18 File Offset: 0x00008E18
		public int Deflate(byte[] output, int offset, int length)
		{
			int num = length;
			if (this.state == 127)
			{
				throw new global::System.InvalidOperationException("Deflater closed");
			}
			if (this.state < 16)
			{
				int num2 = 30720;
				int num3 = this.level - 1 >> 1;
				if (num3 < 0 || num3 > 3)
				{
					num3 = 3;
				}
				num2 |= num3 << 6;
				if ((this.state & 1) != 0)
				{
					num2 |= 32;
				}
				num2 += 31 - num2 % 31;
				this.pending.WriteShortMSB(num2);
				if ((this.state & 1) != 0)
				{
					int adler = this.engine.Adler;
					this.engine.ResetAdler();
					this.pending.WriteShortMSB(adler >> 16);
					this.pending.WriteShortMSB(adler & 65535);
				}
				this.state = (16 | (this.state & 12));
			}
			for (;;)
			{
				int num4 = this.pending.Flush(output, offset, length);
				offset += num4;
				this.totalOut += (long)num4;
				length -= num4;
				if (length == 0 || this.state == 30)
				{
					goto IL_1D3;
				}
				if (!this.engine.Deflate((this.state & 4) != 0, (this.state & 8) != 0))
				{
					int num5 = this.state;
					if (num5 == 16)
					{
						break;
					}
					if (num5 != 20)
					{
						if (num5 == 28)
						{
							this.pending.AlignToByte();
							if (!this.noZlibHeaderOrFooter)
							{
								int adler2 = this.engine.Adler;
								this.pending.WriteShortMSB(adler2 >> 16);
								this.pending.WriteShortMSB(adler2 & 65535);
							}
							this.state = 30;
						}
					}
					else
					{
						if (this.level != 0)
						{
							for (int i = 8 + (-this.pending.BitCount & 7); i > 0; i -= 10)
							{
								this.pending.WriteBits(2, 10);
							}
						}
						this.state = 16;
					}
				}
			}
			return num - length;
			IL_1D3:
			return num - length;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000ADFB File Offset: 0x00008FFB
		public void SetDictionary(byte[] dictionary)
		{
			this.SetDictionary(dictionary, 0, dictionary.Length);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000AE08 File Offset: 0x00009008
		public void SetDictionary(byte[] dictionary, int index, int count)
		{
			if (this.state != 0)
			{
				throw new global::System.InvalidOperationException();
			}
			this.state = 1;
			this.engine.SetDictionary(dictionary, index, count);
		}

		// Token: 0x0400010E RID: 270
		public const int BEST_COMPRESSION = 9;

		// Token: 0x0400010F RID: 271
		public const int BEST_SPEED = 1;

		// Token: 0x04000110 RID: 272
		public const int DEFAULT_COMPRESSION = -1;

		// Token: 0x04000111 RID: 273
		public const int NO_COMPRESSION = 0;

		// Token: 0x04000112 RID: 274
		public const int DEFLATED = 8;

		// Token: 0x04000113 RID: 275
		private const int IS_SETDICT = 1;

		// Token: 0x04000114 RID: 276
		private const int IS_FLUSHING = 4;

		// Token: 0x04000115 RID: 277
		private const int IS_FINISHING = 8;

		// Token: 0x04000116 RID: 278
		private const int INIT_STATE = 0;

		// Token: 0x04000117 RID: 279
		private const int SETDICT_STATE = 1;

		// Token: 0x04000118 RID: 280
		private const int BUSY_STATE = 16;

		// Token: 0x04000119 RID: 281
		private const int FLUSHING_STATE = 20;

		// Token: 0x0400011A RID: 282
		private const int FINISHING_STATE = 28;

		// Token: 0x0400011B RID: 283
		private const int FINISHED_STATE = 30;

		// Token: 0x0400011C RID: 284
		private const int CLOSED_STATE = 127;

		// Token: 0x0400011D RID: 285
		private int level;

		// Token: 0x0400011E RID: 286
		private bool noZlibHeaderOrFooter;

		// Token: 0x0400011F RID: 287
		private int state;

		// Token: 0x04000120 RID: 288
		private long totalOut;

		// Token: 0x04000121 RID: 289
		private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending pending;

		// Token: 0x04000122 RID: 290
		private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterEngine engine;

		// Token: 0x0200008A RID: 138
		public enum CompressionLevel
		{
			// Token: 0x04000358 RID: 856
			BEST_COMPRESSION = 9,
			// Token: 0x04000359 RID: 857
			BEST_SPEED = 1,
			// Token: 0x0400035A RID: 858
			DEFAULT_COMPRESSION = -1,
			// Token: 0x0400035B RID: 859
			NO_COMPRESSION,
			// Token: 0x0400035C RID: 860
			DEFLATED = 8
		}
	}
}
