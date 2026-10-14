using System;
using ICSharpCode.SharpZipLib.Checksum;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x02000039 RID: 57
	public class Inflater
	{
		// Token: 0x06000250 RID: 592 RVA: 0x0000C6E6 File Offset: 0x0000A8E6
		public Inflater() : this(false)
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000C6EF File Offset: 0x0000A8EF
		public Inflater(bool noHeader)
		{
			this.noHeader = noHeader;
			if (!noHeader)
			{
				this.adler = new global::ICSharpCode.SharpZipLib.Checksum.Adler32();
			}
			this.input = new global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator();
			this.outputWindow = new global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.OutputWindow();
			this.mode = (noHeader ? 2 : 0);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000C730 File Offset: 0x0000A930
		public void Reset()
		{
			this.mode = (this.noHeader ? 2 : 0);
			this.totalIn = 0L;
			this.totalOut = 0L;
			this.input.Reset();
			this.outputWindow.Reset();
			this.dynHeader = null;
			this.litlenTree = null;
			this.distTree = null;
			this.isLastBlock = false;
			global::ICSharpCode.SharpZipLib.Checksum.Adler32 adler = this.adler;
			if (adler == null)
			{
				return;
			}
			adler.Reset();
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0000C7A4 File Offset: 0x0000A9A4
		private bool DecodeHeader()
		{
			int num = this.input.PeekBits(16);
			if (num < 0)
			{
				return false;
			}
			this.input.DropBits(16);
			num = ((num << 8 | num >> 8) & 65535);
			if (num % 31 != 0)
			{
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Header checksum illegal");
			}
			if ((num & 3840) != 2048)
			{
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Compression Method unknown");
			}
			if ((num & 32) == 0)
			{
				this.mode = 2;
			}
			else
			{
				this.mode = 1;
				this.neededBits = 32;
			}
			return true;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000C82C File Offset: 0x0000AA2C
		private bool DecodeDict()
		{
			while (this.neededBits > 0)
			{
				int num = this.input.PeekBits(8);
				if (num < 0)
				{
					return false;
				}
				this.input.DropBits(8);
				this.readAdler = (this.readAdler << 8 | num);
				this.neededBits -= 8;
			}
			return false;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000C884 File Offset: 0x0000AA84
		private bool DecodeHuffman()
		{
			int i = this.outputWindow.GetFreeSpace();
			while (i >= 258)
			{
				int symbol;
				switch (this.mode)
				{
				case 7:
					while (((symbol = this.litlenTree.GetSymbol(this.input)) & -256) == 0)
					{
						this.outputWindow.Write(symbol);
						if (--i < 258)
						{
							return true;
						}
					}
					if (symbol >= 257)
					{
						try
						{
							this.repLength = global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater.CPLENS[symbol - 257];
							this.neededBits = global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater.CPLEXT[symbol - 257];
						}
						catch (global::System.Exception)
						{
							throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Illegal rep length code");
						}
						goto IL_C4;
					}
					if (symbol < 0)
					{
						return false;
					}
					this.distTree = null;
					this.litlenTree = null;
					this.mode = 2;
					return true;
				case 8:
					goto IL_C4;
				case 9:
					goto IL_113;
				case 10:
					break;
				default:
					throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Inflater unknown mode");
				}
				IL_154:
				if (this.neededBits > 0)
				{
					this.mode = 10;
					int num = this.input.PeekBits(this.neededBits);
					if (num < 0)
					{
						return false;
					}
					this.input.DropBits(this.neededBits);
					this.repDist += num;
				}
				this.outputWindow.Repeat(this.repLength, this.repDist);
				i -= this.repLength;
				this.mode = 7;
				continue;
				IL_113:
				symbol = this.distTree.GetSymbol(this.input);
				if (symbol < 0)
				{
					return false;
				}
				try
				{
					this.repDist = global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater.CPDIST[symbol];
					this.neededBits = global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater.CPDEXT[symbol];
				}
				catch (global::System.Exception)
				{
					throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Illegal rep dist code");
				}
				goto IL_154;
				IL_C4:
				if (this.neededBits > 0)
				{
					this.mode = 8;
					int num2 = this.input.PeekBits(this.neededBits);
					if (num2 < 0)
					{
						return false;
					}
					this.input.DropBits(this.neededBits);
					this.repLength += num2;
				}
				this.mode = 9;
				goto IL_113;
			}
			return true;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000CA8C File Offset: 0x0000AC8C
		private bool DecodeChksum()
		{
			while (this.neededBits > 0)
			{
				int num = this.input.PeekBits(8);
				if (num < 0)
				{
					return false;
				}
				this.input.DropBits(8);
				this.readAdler = (this.readAdler << 8 | num);
				this.neededBits -= 8;
			}
			global::ICSharpCode.SharpZipLib.Checksum.Adler32 adler = this.adler;
			if ((int)((adler != null) ? new long?(adler.Value) : null).Value != this.readAdler)
			{
				string str = "Adler chksum doesn't match: ";
				global::ICSharpCode.SharpZipLib.Checksum.Adler32 adler2 = this.adler;
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException(str + ((int)((adler2 != null) ? new long?(adler2.Value) : null).Value).ToString() + " vs. " + this.readAdler.ToString());
			}
			this.mode = 12;
			return false;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000CB6C File Offset: 0x0000AD6C
		private bool Decode()
		{
			switch (this.mode)
			{
			case 0:
				return this.DecodeHeader();
			case 1:
				return this.DecodeDict();
			case 2:
				if (this.isLastBlock)
				{
					if (this.noHeader)
					{
						this.mode = 12;
						return false;
					}
					this.input.SkipToByteBoundary();
					this.neededBits = 32;
					this.mode = 11;
					return true;
				}
				else
				{
					int num = this.input.PeekBits(3);
					if (num < 0)
					{
						return false;
					}
					this.input.DropBits(3);
					this.isLastBlock |= ((num & 1) != 0);
					switch (num >> 1)
					{
					case 0:
						this.input.SkipToByteBoundary();
						this.mode = 3;
						break;
					case 1:
						this.litlenTree = global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree.defLitLenTree;
						this.distTree = global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree.defDistTree;
						this.mode = 7;
						break;
					case 2:
						this.dynHeader = new global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterDynHeader(this.input);
						this.mode = 6;
						break;
					default:
						throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Unknown block type " + num.ToString());
					}
					return true;
				}
				break;
			case 3:
				if ((this.uncomprLen = this.input.PeekBits(16)) < 0)
				{
					return false;
				}
				this.input.DropBits(16);
				this.mode = 4;
				break;
			case 4:
				break;
			case 5:
				goto IL_1B3;
			case 6:
				if (!this.dynHeader.AttemptRead())
				{
					return false;
				}
				this.litlenTree = this.dynHeader.LiteralLengthTree;
				this.distTree = this.dynHeader.DistanceTree;
				this.mode = 7;
				goto IL_233;
			case 7:
			case 8:
			case 9:
			case 10:
				goto IL_233;
			case 11:
				return this.DecodeChksum();
			case 12:
				return false;
			default:
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Inflater.Decode unknown mode");
			}
			int num2 = this.input.PeekBits(16);
			if (num2 < 0)
			{
				return false;
			}
			this.input.DropBits(16);
			if (num2 != (this.uncomprLen ^ 65535))
			{
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("broken uncompressed block");
			}
			this.mode = 5;
			IL_1B3:
			int num3 = this.outputWindow.CopyStored(this.input, this.uncomprLen);
			this.uncomprLen -= num3;
			if (this.uncomprLen == 0)
			{
				this.mode = 2;
				return true;
			}
			return !this.input.IsNeedingInput;
			IL_233:
			return this.DecodeHuffman();
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000CDBF File Offset: 0x0000AFBF
		public void SetDictionary(byte[] buffer)
		{
			this.SetDictionary(buffer, 0, buffer.Length);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0000CDCC File Offset: 0x0000AFCC
		public void SetDictionary(byte[] buffer, int index, int count)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (index < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("index");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count");
			}
			if (!this.IsNeedingDictionary)
			{
				throw new global::System.InvalidOperationException("Dictionary is not needed");
			}
			global::ICSharpCode.SharpZipLib.Checksum.Adler32 adler = this.adler;
			if (adler != null)
			{
				adler.Update(new global::System.ArraySegment<byte>(buffer, index, count));
			}
			if (this.adler != null && (int)this.adler.Value != this.readAdler)
			{
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Wrong adler checksum");
			}
			global::ICSharpCode.SharpZipLib.Checksum.Adler32 adler2 = this.adler;
			if (adler2 != null)
			{
				adler2.Reset();
			}
			this.outputWindow.CopyDict(buffer, index, count);
			this.mode = 2;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000CE7E File Offset: 0x0000B07E
		public void SetInput(byte[] buffer)
		{
			this.SetInput(buffer, 0, buffer.Length);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000CE8B File Offset: 0x0000B08B
		public void SetInput(byte[] buffer, int index, int count)
		{
			this.input.SetInput(buffer, index, count);
			this.totalIn += (long)count;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000CEAA File Offset: 0x0000B0AA
		public int Inflate(byte[] buffer)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			return this.Inflate(buffer, 0, buffer.Length);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000CEC8 File Offset: 0x0000B0C8
		public int Inflate(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count", "count cannot be negative");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "offset cannot be negative");
			}
			if (offset + count > buffer.Length)
			{
				throw new global::System.ArgumentException("count exceeds buffer bounds");
			}
			if (count == 0)
			{
				if (!this.IsFinished)
				{
					this.Decode();
				}
				return 0;
			}
			int num = 0;
			for (;;)
			{
				if (this.mode != 11)
				{
					int num2 = this.outputWindow.CopyOutput(buffer, offset, count);
					if (num2 > 0)
					{
						global::ICSharpCode.SharpZipLib.Checksum.Adler32 adler = this.adler;
						if (adler != null)
						{
							adler.Update(new global::System.ArraySegment<byte>(buffer, offset, num2));
						}
						offset += num2;
						num += num2;
						this.totalOut += (long)num2;
						count -= num2;
						if (count == 0)
						{
							break;
						}
					}
				}
				if (!this.Decode() && (this.outputWindow.GetAvailable() <= 0 || this.mode == 11))
				{
					return num;
				}
			}
			return num;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0000CFAD File Offset: 0x0000B1AD
		public bool IsNeedingInput
		{
			get
			{
				return this.input.IsNeedingInput;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0000CFBA File Offset: 0x0000B1BA
		public bool IsNeedingDictionary
		{
			get
			{
				return this.mode == 1 && this.neededBits == 0;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0000CFD0 File Offset: 0x0000B1D0
		public bool IsFinished
		{
			get
			{
				return this.mode == 12 && this.outputWindow.GetAvailable() == 0;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0000CFEC File Offset: 0x0000B1EC
		public int Adler
		{
			get
			{
				if (this.IsNeedingDictionary)
				{
					return this.readAdler;
				}
				if (this.adler != null)
				{
					return (int)this.adler.Value;
				}
				return 0;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0000D013 File Offset: 0x0000B213
		public long TotalOut
		{
			get
			{
				return this.totalOut;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0000D01B File Offset: 0x0000B21B
		public long TotalIn
		{
			get
			{
				return this.totalIn - (long)this.RemainingInput;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0000D02B File Offset: 0x0000B22B
		public int RemainingInput
		{
			get
			{
				return this.input.AvailableBytes;
			}
		}

		// Token: 0x04000170 RID: 368
		private static readonly int[] CPLENS = new int[]
		{
			3,
			4,
			5,
			6,
			7,
			8,
			9,
			10,
			11,
			13,
			15,
			17,
			19,
			23,
			27,
			31,
			35,
			43,
			51,
			59,
			67,
			83,
			99,
			115,
			131,
			163,
			195,
			227,
			258
		};

		// Token: 0x04000171 RID: 369
		private static readonly int[] CPLEXT = new int[]
		{
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			1,
			1,
			1,
			1,
			2,
			2,
			2,
			2,
			3,
			3,
			3,
			3,
			4,
			4,
			4,
			4,
			5,
			5,
			5,
			5,
			0
		};

		// Token: 0x04000172 RID: 370
		private static readonly int[] CPDIST = new int[]
		{
			1,
			2,
			3,
			4,
			5,
			7,
			9,
			13,
			17,
			25,
			33,
			49,
			65,
			97,
			129,
			193,
			257,
			385,
			513,
			769,
			1025,
			1537,
			2049,
			3073,
			4097,
			6145,
			8193,
			12289,
			16385,
			24577
		};

		// Token: 0x04000173 RID: 371
		private static readonly int[] CPDEXT = new int[]
		{
			0,
			0,
			0,
			0,
			1,
			1,
			2,
			2,
			3,
			3,
			4,
			4,
			5,
			5,
			6,
			6,
			7,
			7,
			8,
			8,
			9,
			9,
			10,
			10,
			11,
			11,
			12,
			12,
			13,
			13
		};

		// Token: 0x04000174 RID: 372
		private const int DECODE_HEADER = 0;

		// Token: 0x04000175 RID: 373
		private const int DECODE_DICT = 1;

		// Token: 0x04000176 RID: 374
		private const int DECODE_BLOCKS = 2;

		// Token: 0x04000177 RID: 375
		private const int DECODE_STORED_LEN1 = 3;

		// Token: 0x04000178 RID: 376
		private const int DECODE_STORED_LEN2 = 4;

		// Token: 0x04000179 RID: 377
		private const int DECODE_STORED = 5;

		// Token: 0x0400017A RID: 378
		private const int DECODE_DYN_HEADER = 6;

		// Token: 0x0400017B RID: 379
		private const int DECODE_HUFFMAN = 7;

		// Token: 0x0400017C RID: 380
		private const int DECODE_HUFFMAN_LENBITS = 8;

		// Token: 0x0400017D RID: 381
		private const int DECODE_HUFFMAN_DIST = 9;

		// Token: 0x0400017E RID: 382
		private const int DECODE_HUFFMAN_DISTBITS = 10;

		// Token: 0x0400017F RID: 383
		private const int DECODE_CHKSUM = 11;

		// Token: 0x04000180 RID: 384
		private const int FINISHED = 12;

		// Token: 0x04000181 RID: 385
		private int mode;

		// Token: 0x04000182 RID: 386
		private int readAdler;

		// Token: 0x04000183 RID: 387
		private int neededBits;

		// Token: 0x04000184 RID: 388
		private int repLength;

		// Token: 0x04000185 RID: 389
		private int repDist;

		// Token: 0x04000186 RID: 390
		private int uncomprLen;

		// Token: 0x04000187 RID: 391
		private bool isLastBlock;

		// Token: 0x04000188 RID: 392
		private long totalOut;

		// Token: 0x04000189 RID: 393
		private long totalIn;

		// Token: 0x0400018A RID: 394
		private bool noHeader;

		// Token: 0x0400018B RID: 395
		private readonly global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator input;

		// Token: 0x0400018C RID: 396
		private global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.OutputWindow outputWindow;

		// Token: 0x0400018D RID: 397
		private global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterDynHeader dynHeader;

		// Token: 0x0400018E RID: 398
		private global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree litlenTree;

		// Token: 0x0400018F RID: 399
		private global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree distTree;

		// Token: 0x04000190 RID: 400
		private global::ICSharpCode.SharpZipLib.Checksum.Adler32 adler;
	}
}
