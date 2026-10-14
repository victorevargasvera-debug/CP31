using System;
using ICSharpCode.SharpZipLib.Checksum;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x02000036 RID: 54
	public class DeflaterEngine
	{
		// Token: 0x0600022D RID: 557 RVA: 0x0000AEC4 File Offset: 0x000090C4
		public DeflaterEngine(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending pending) : this(pending, false)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000AED0 File Offset: 0x000090D0
		public DeflaterEngine(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending pending, bool noAdlerCalculation)
		{
			this.pending = pending;
			this.huffman = new global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman(pending);
			if (!noAdlerCalculation)
			{
				this.adler = new global::ICSharpCode.SharpZipLib.Checksum.Adler32();
			}
			this.window = new byte[65536];
			this.head = new short[32768];
			this.prev = new short[32768];
			this.blockStart = (this.strstart = 1);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000AF44 File Offset: 0x00009144
		public bool Deflate(bool flush, bool finish)
		{
			for (;;)
			{
				this.FillWindow();
				bool flush2 = flush && this.inputOff == this.inputEnd;
				bool flag;
				switch (this.compressionFunction)
				{
				case 0:
					flag = this.DeflateStored(flush2, finish);
					goto IL_62;
				case 1:
					flag = this.DeflateFast(flush2, finish);
					goto IL_62;
				case 2:
					flag = this.DeflateSlow(flush2, finish);
					goto IL_62;
				}
				break;
				IL_62:
				if (!this.pending.IsFlushed || !flag)
				{
					return flag;
				}
			}
			throw new global::System.InvalidOperationException("unknown compressionFunction");
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000AFC4 File Offset: 0x000091C4
		public void SetInput(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count");
			}
			if (this.inputOff < this.inputEnd)
			{
				throw new global::System.InvalidOperationException("Old input was not completely processed");
			}
			int num = offset + count;
			if (offset > num || num > buffer.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("count");
			}
			this.inputBuf = buffer;
			this.inputOff = offset;
			this.inputEnd = num;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000B044 File Offset: 0x00009244
		public bool NeedsInput()
		{
			return this.inputEnd == this.inputOff;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000B054 File Offset: 0x00009254
		public void SetDictionary(byte[] buffer, int offset, int length)
		{
			global::ICSharpCode.SharpZipLib.Checksum.Adler32 adler = this.adler;
			if (adler != null)
			{
				adler.Update(new global::System.ArraySegment<byte>(buffer, offset, length));
			}
			if (length < 3)
			{
				return;
			}
			if (length > 32506)
			{
				offset += length - 32506;
				length = 32506;
			}
			global::System.Array.Copy(buffer, offset, this.window, this.strstart, length);
			this.UpdateHash();
			length--;
			while (--length > 0)
			{
				this.InsertString();
				this.strstart++;
			}
			this.strstart += 2;
			this.blockStart = this.strstart;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000B0F4 File Offset: 0x000092F4
		public void Reset()
		{
			this.huffman.Reset();
			global::ICSharpCode.SharpZipLib.Checksum.Adler32 adler = this.adler;
			if (adler != null)
			{
				adler.Reset();
			}
			this.blockStart = (this.strstart = 1);
			this.lookahead = 0;
			this.totalIn = 0L;
			this.prevAvailable = false;
			this.matchLen = 2;
			for (int i = 0; i < 32768; i++)
			{
				this.head[i] = 0;
			}
			for (int j = 0; j < 32768; j++)
			{
				this.prev[j] = 0;
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000B17C File Offset: 0x0000937C
		public void ResetAdler()
		{
			global::ICSharpCode.SharpZipLib.Checksum.Adler32 adler = this.adler;
			if (adler == null)
			{
				return;
			}
			adler.Reset();
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000B18E File Offset: 0x0000938E
		public int Adler
		{
			get
			{
				if (this.adler == null)
				{
					return 0;
				}
				return (int)this.adler.Value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0000B1A6 File Offset: 0x000093A6
		public long TotalIn
		{
			get
			{
				return this.totalIn;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000B1AE File Offset: 0x000093AE
		// (set) Token: 0x06000238 RID: 568 RVA: 0x0000B1B6 File Offset: 0x000093B6
		public global::ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy Strategy
		{
			get
			{
				return this.strategy;
			}
			set
			{
				this.strategy = value;
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000B1C0 File Offset: 0x000093C0
		public void SetLevel(int level)
		{
			if (level < 0 || level > 9)
			{
				throw new global::System.ArgumentOutOfRangeException("level");
			}
			this.goodLength = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.GOOD_LENGTH[level];
			this.max_lazy = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.MAX_LAZY[level];
			this.niceLength = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.NICE_LENGTH[level];
			this.max_chain = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.MAX_CHAIN[level];
			if (global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.COMPR_FUNC[level] != this.compressionFunction)
			{
				switch (this.compressionFunction)
				{
				case 0:
					if (this.strstart > this.blockStart)
					{
						this.huffman.FlushStoredBlock(this.window, this.blockStart, this.strstart - this.blockStart, false);
						this.blockStart = this.strstart;
					}
					this.UpdateHash();
					break;
				case 1:
					if (this.strstart > this.blockStart)
					{
						this.huffman.FlushBlock(this.window, this.blockStart, this.strstart - this.blockStart, false);
						this.blockStart = this.strstart;
					}
					break;
				case 2:
					if (this.prevAvailable)
					{
						this.huffman.TallyLit((int)(this.window[this.strstart - 1] & byte.MaxValue));
					}
					if (this.strstart > this.blockStart)
					{
						this.huffman.FlushBlock(this.window, this.blockStart, this.strstart - this.blockStart, false);
						this.blockStart = this.strstart;
					}
					this.prevAvailable = false;
					this.matchLen = 2;
					break;
				}
				this.compressionFunction = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.COMPR_FUNC[level];
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000B358 File Offset: 0x00009558
		public void FillWindow()
		{
			if (this.strstart >= 65274)
			{
				this.SlideWindow();
			}
			if (this.lookahead < 262 && this.inputOff < this.inputEnd)
			{
				int num = 65536 - this.lookahead - this.strstart;
				if (num > this.inputEnd - this.inputOff)
				{
					num = this.inputEnd - this.inputOff;
				}
				global::System.Array.Copy(this.inputBuf, this.inputOff, this.window, this.strstart + this.lookahead, num);
				global::ICSharpCode.SharpZipLib.Checksum.Adler32 adler = this.adler;
				if (adler != null)
				{
					adler.Update(new global::System.ArraySegment<byte>(this.inputBuf, this.inputOff, num));
				}
				this.inputOff += num;
				this.totalIn += (long)num;
				this.lookahead += num;
			}
			if (this.lookahead >= 3)
			{
				this.UpdateHash();
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000B44D File Offset: 0x0000964D
		private void UpdateHash()
		{
			this.ins_h = ((int)this.window[this.strstart] << 5 ^ (int)this.window[this.strstart + 1]);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000B474 File Offset: 0x00009674
		private int InsertString()
		{
			int num = (this.ins_h << 5 ^ (int)this.window[this.strstart + 2]) & 32767;
			short num2 = this.prev[this.strstart & 32767] = this.head[num];
			this.head[num] = (short)this.strstart;
			this.ins_h = num;
			return (int)num2 & 65535;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000B4DC File Offset: 0x000096DC
		private void SlideWindow()
		{
			global::System.Array.Copy(this.window, 32768, this.window, 0, 32768);
			this.matchStart -= 32768;
			this.strstart -= 32768;
			this.blockStart -= 32768;
			for (int i = 0; i < 32768; i++)
			{
				int num = (int)this.head[i] & 65535;
				this.head[i] = (short)((num >= 32768) ? (num - 32768) : 0);
			}
			for (int j = 0; j < 32768; j++)
			{
				int num2 = (int)this.prev[j] & 65535;
				this.prev[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000B5B0 File Offset: 0x000097B0
		private bool FindLongestMatch(int curMatch)
		{
			int num = this.strstart;
			int num2 = num + global::System.Math.Min(258, this.lookahead) - 1;
			int num3 = global::System.Math.Max(num - 32506, 0);
			byte[] array = this.window;
			short[] array2 = this.prev;
			int num4 = this.max_chain;
			int num5 = global::System.Math.Min(this.niceLength, this.lookahead);
			this.matchLen = global::System.Math.Max(this.matchLen, 2);
			if (num + this.matchLen > num2)
			{
				return false;
			}
			byte b = array[num + this.matchLen - 1];
			byte b2 = array[num + this.matchLen];
			if (this.matchLen >= this.goodLength)
			{
				num4 >>= 2;
			}
			do
			{
				int num6 = curMatch;
				num = this.strstart;
				if (array[num6 + this.matchLen] == b2 && array[num6 + this.matchLen - 1] == b && array[num6] == array[num] && array[++num6] == array[++num])
				{
					switch ((num2 - num) % 8)
					{
					case 1:
						if (array[++num] == array[++num6])
						{
						}
						break;
					case 2:
						if (array[++num] == array[++num6] && array[++num] == array[++num6])
						{
						}
						break;
					case 3:
						if (array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6])
						{
						}
						break;
					case 4:
						if (array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6])
						{
						}
						break;
					case 5:
						if (array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6])
						{
						}
						break;
					case 6:
						if (array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6])
						{
						}
						break;
					case 7:
						if (array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6] && array[++num] == array[++num6])
						{
							byte b3 = array[++num];
							byte b4 = array[++num6];
						}
						break;
					}
					if (array[num] == array[num6])
					{
						while (num != num2)
						{
							if (array[++num] != array[++num6] || array[++num] != array[++num6] || array[++num] != array[++num6] || array[++num] != array[++num6] || array[++num] != array[++num6] || array[++num] != array[++num6] || array[++num] != array[++num6] || array[++num] != array[++num6])
							{
								goto IL_42C;
							}
						}
						num++;
						num6++;
					}
					IL_42C:
					if (num - this.strstart > this.matchLen)
					{
						this.matchStart = curMatch;
						this.matchLen = num - this.strstart;
						if (this.matchLen >= num5)
						{
							break;
						}
						b = array[num - 1];
						b2 = array[num];
					}
				}
			}
			while ((curMatch = ((int)array2[curMatch & 32767] & 65535)) > num3 && --num4 != 0);
			return this.matchLen >= 3;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000BA54 File Offset: 0x00009C54
		private bool DeflateStored(bool flush, bool finish)
		{
			if (!flush && this.lookahead == 0)
			{
				return false;
			}
			this.strstart += this.lookahead;
			this.lookahead = 0;
			int num = this.strstart - this.blockStart;
			if (num >= global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.MAX_BLOCK_SIZE || (this.blockStart < 32768 && num >= 32506) || flush)
			{
				bool flag = finish;
				if (num > global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.MAX_BLOCK_SIZE)
				{
					num = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterConstants.MAX_BLOCK_SIZE;
					flag = false;
				}
				this.huffman.FlushStoredBlock(this.window, this.blockStart, num, flag);
				this.blockStart += num;
				return !flag && num != 0;
			}
			return true;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000BB04 File Offset: 0x00009D04
		private bool DeflateFast(bool flush, bool finish)
		{
			if (this.lookahead < 262 && !flush)
			{
				return false;
			}
			while (this.lookahead >= 262 || flush)
			{
				if (this.lookahead == 0)
				{
					this.huffman.FlushBlock(this.window, this.blockStart, this.strstart - this.blockStart, finish);
					this.blockStart = this.strstart;
					return false;
				}
				if (this.strstart > 65274)
				{
					this.SlideWindow();
				}
				int num;
				if (this.lookahead >= 3 && (num = this.InsertString()) != 0 && this.strategy != global::ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy.HuffmanOnly && this.strstart - num <= 32506 && this.FindLongestMatch(num))
				{
					bool flag = this.huffman.TallyDist(this.strstart - this.matchStart, this.matchLen);
					this.lookahead -= this.matchLen;
					if (this.matchLen <= this.max_lazy && this.lookahead >= 3)
					{
						for (;;)
						{
							int num2 = this.matchLen - 1;
							this.matchLen = num2;
							if (num2 <= 0)
							{
								break;
							}
							this.strstart++;
							this.InsertString();
						}
						this.strstart++;
					}
					else
					{
						this.strstart += this.matchLen;
						if (this.lookahead >= 2)
						{
							this.UpdateHash();
						}
					}
					this.matchLen = 2;
					if (!flag)
					{
						continue;
					}
				}
				else
				{
					this.huffman.TallyLit((int)(this.window[this.strstart] & byte.MaxValue));
					this.strstart++;
					this.lookahead--;
				}
				if (this.huffman.IsFull())
				{
					bool flag2 = finish && this.lookahead == 0;
					this.huffman.FlushBlock(this.window, this.blockStart, this.strstart - this.blockStart, flag2);
					this.blockStart = this.strstart;
					return !flag2;
				}
			}
			return true;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000BD18 File Offset: 0x00009F18
		private bool DeflateSlow(bool flush, bool finish)
		{
			if (this.lookahead < 262 && !flush)
			{
				return false;
			}
			while (this.lookahead >= 262 || flush)
			{
				if (this.lookahead == 0)
				{
					if (this.prevAvailable)
					{
						this.huffman.TallyLit((int)(this.window[this.strstart - 1] & byte.MaxValue));
					}
					this.prevAvailable = false;
					this.huffman.FlushBlock(this.window, this.blockStart, this.strstart - this.blockStart, finish);
					this.blockStart = this.strstart;
					return false;
				}
				if (this.strstart >= 65274)
				{
					this.SlideWindow();
				}
				int num = this.matchStart;
				int num2 = this.matchLen;
				if (this.lookahead >= 3)
				{
					int num3 = this.InsertString();
					if (this.strategy != global::ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy.HuffmanOnly && num3 != 0 && this.strstart - num3 <= 32506 && this.FindLongestMatch(num3) && this.matchLen <= 5 && (this.strategy == global::ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy.Filtered || (this.matchLen == 3 && this.strstart - this.matchStart > 4096)))
					{
						this.matchLen = 2;
					}
				}
				if (num2 >= 3 && this.matchLen <= num2)
				{
					this.huffman.TallyDist(this.strstart - 1 - num, num2);
					num2 -= 2;
					do
					{
						this.strstart++;
						this.lookahead--;
						if (this.lookahead >= 3)
						{
							this.InsertString();
						}
					}
					while (--num2 > 0);
					this.strstart++;
					this.lookahead--;
					this.prevAvailable = false;
					this.matchLen = 2;
				}
				else
				{
					if (this.prevAvailable)
					{
						this.huffman.TallyLit((int)(this.window[this.strstart - 1] & byte.MaxValue));
					}
					this.prevAvailable = true;
					this.strstart++;
					this.lookahead--;
				}
				if (this.huffman.IsFull())
				{
					int num4 = this.strstart - this.blockStart;
					if (this.prevAvailable)
					{
						num4--;
					}
					bool flag = finish && this.lookahead == 0 && !this.prevAvailable;
					this.huffman.FlushBlock(this.window, this.blockStart, num4, flag);
					this.blockStart += num4;
					return !flag;
				}
			}
			return true;
		}

		// Token: 0x04000142 RID: 322
		private const int TooFar = 4096;

		// Token: 0x04000143 RID: 323
		private int ins_h;

		// Token: 0x04000144 RID: 324
		private short[] head;

		// Token: 0x04000145 RID: 325
		private short[] prev;

		// Token: 0x04000146 RID: 326
		private int matchStart;

		// Token: 0x04000147 RID: 327
		private int matchLen;

		// Token: 0x04000148 RID: 328
		private bool prevAvailable;

		// Token: 0x04000149 RID: 329
		private int blockStart;

		// Token: 0x0400014A RID: 330
		private int strstart;

		// Token: 0x0400014B RID: 331
		private int lookahead;

		// Token: 0x0400014C RID: 332
		private byte[] window;

		// Token: 0x0400014D RID: 333
		private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflateStrategy strategy;

		// Token: 0x0400014E RID: 334
		private int max_chain;

		// Token: 0x0400014F RID: 335
		private int max_lazy;

		// Token: 0x04000150 RID: 336
		private int niceLength;

		// Token: 0x04000151 RID: 337
		private int goodLength;

		// Token: 0x04000152 RID: 338
		private int compressionFunction;

		// Token: 0x04000153 RID: 339
		private byte[] inputBuf;

		// Token: 0x04000154 RID: 340
		private long totalIn;

		// Token: 0x04000155 RID: 341
		private int inputOff;

		// Token: 0x04000156 RID: 342
		private int inputEnd;

		// Token: 0x04000157 RID: 343
		private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending pending;

		// Token: 0x04000158 RID: 344
		private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman huffman;

		// Token: 0x04000159 RID: 345
		private global::ICSharpCode.SharpZipLib.Checksum.Adler32 adler;
	}
}
