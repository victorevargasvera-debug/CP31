using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Lzw
{
	// Token: 0x0200004E RID: 78
	public class LzwInputStream : global::System.IO.Stream
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x000119C7 File Offset: 0x0000FBC7
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x000119CF File Offset: 0x0000FBCF
		public bool IsStreamOwner { get; set; } = true;

		// Token: 0x060003D2 RID: 978 RVA: 0x000119D8 File Offset: 0x0000FBD8
		public LzwInputStream(global::System.IO.Stream baseInputStream)
		{
			this.baseInputStream = baseInputStream;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00011A25 File Offset: 0x0000FC25
		public override int ReadByte()
		{
			if (this.Read(this.one, 0, 1) == 1)
			{
				return (int)(this.one[0] & byte.MaxValue);
			}
			return -1;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00011A48 File Offset: 0x0000FC48
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (!this.headerParsed)
			{
				this.ParseHeader();
			}
			if (this.eof)
			{
				return 0;
			}
			int num = offset;
			int[] array = this.tabPrefix;
			byte[] array2 = this.tabSuffix;
			byte[] array3 = this.stack;
			int num2 = this.nBits;
			int num3 = this.maxCode;
			int num4 = this.maxMaxCode;
			int num5 = this.bitMask;
			int num6 = this.oldCode;
			byte b = this.finChar;
			int num7 = this.stackP;
			int num8 = this.freeEnt;
			byte[] array4 = this.data;
			int i = this.bitPos;
			int num9 = array3.Length - num7;
			if (num9 > 0)
			{
				int num10 = (num9 >= count) ? count : num9;
				global::System.Array.Copy(array3, num7, buffer, offset, num10);
				offset += num10;
				count -= num10;
				num7 += num10;
			}
			if (count == 0)
			{
				this.stackP = num7;
				return offset - num;
			}
			int j;
			for (;;)
			{
				IL_C6:
				if (this.end < 64)
				{
					this.Fill();
				}
				int num11 = (this.got > 0) ? (this.end - this.end % num2 << 3) : ((this.end << 3) - (num2 - 1));
				while (i < num11)
				{
					if (count == 0)
					{
						goto Block_8;
					}
					if (num8 > num3)
					{
						int num12 = num2 << 3;
						i = i - 1 + num12 - (i - 1 + num12) % num12;
						num2++;
						num3 = ((num2 == this.maxBits) ? num4 : ((1 << num2) - 1));
						num5 = (1 << num2) - 1;
						i = this.ResetBuf(i);
						goto IL_C6;
					}
					int num13 = i >> 3;
					j = (((int)(array4[num13] & byte.MaxValue) | (int)(array4[num13 + 1] & byte.MaxValue) << 8 | (int)(array4[num13 + 2] & byte.MaxValue) << 16) >> (i & 7) & num5);
					i += num2;
					if (num6 == -1)
					{
						if (j >= 256)
						{
							goto Block_12;
						}
						b = (byte)(num6 = j);
						buffer[offset++] = b;
						count--;
					}
					else
					{
						if (j == 256 && this.blockMode)
						{
							global::System.Array.Copy(this.zeros, 0, array, 0, this.zeros.Length);
							num8 = 256;
							int num14 = num2 << 3;
							i = i - 1 + num14 - (i - 1 + num14) % num14;
							num2 = 9;
							num3 = (1 << num2) - 1;
							num5 = num3;
							i = this.ResetBuf(i);
							goto IL_C6;
						}
						int num15 = j;
						num7 = array3.Length;
						if (j >= num8)
						{
							if (j > num8)
							{
								goto Block_16;
							}
							array3[--num7] = b;
							j = num6;
						}
						while (j >= 256)
						{
							array3[--num7] = array2[j];
							j = array[j];
						}
						b = array2[j];
						buffer[offset++] = b;
						count--;
						num9 = array3.Length - num7;
						int num16 = (num9 >= count) ? count : num9;
						global::System.Array.Copy(array3, num7, buffer, offset, num16);
						offset += num16;
						count -= num16;
						num7 += num16;
						if (num8 < num4)
						{
							array[num8] = num6;
							array2[num8] = b;
							num8++;
						}
						num6 = num15;
						if (count == 0)
						{
							goto Block_20;
						}
					}
				}
				i = this.ResetBuf(i);
				if (this.got <= 0)
				{
					goto Block_22;
				}
			}
			Block_8:
			this.nBits = num2;
			this.maxCode = num3;
			this.maxMaxCode = num4;
			this.bitMask = num5;
			this.oldCode = num6;
			this.finChar = b;
			this.stackP = num7;
			this.freeEnt = num8;
			this.bitPos = i;
			return offset - num;
			Block_12:
			throw new global::ICSharpCode.SharpZipLib.Lzw.LzwException("corrupt input: " + j.ToString() + " > 255");
			Block_16:
			throw new global::ICSharpCode.SharpZipLib.Lzw.LzwException("corrupt input: code=" + j.ToString() + ", freeEnt=" + num8.ToString());
			Block_20:
			this.nBits = num2;
			this.maxCode = num3;
			this.bitMask = num5;
			this.oldCode = num6;
			this.finChar = b;
			this.stackP = num7;
			this.freeEnt = num8;
			this.bitPos = i;
			return offset - num;
			Block_22:
			this.nBits = num2;
			this.maxCode = num3;
			this.bitMask = num5;
			this.oldCode = num6;
			this.finChar = b;
			this.stackP = num7;
			this.freeEnt = num8;
			this.bitPos = i;
			this.eof = true;
			return offset - num;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00011E74 File Offset: 0x00010074
		private int ResetBuf(int bitPosition)
		{
			int num = bitPosition >> 3;
			global::System.Array.Copy(this.data, num, this.data, 0, this.end - num);
			this.end -= num;
			return 0;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00011EB0 File Offset: 0x000100B0
		private void Fill()
		{
			this.got = this.baseInputStream.Read(this.data, this.end, this.data.Length - 1 - this.end);
			if (this.got > 0)
			{
				this.end += this.got;
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00011F08 File Offset: 0x00010108
		private void ParseHeader()
		{
			this.headerParsed = true;
			byte[] array = new byte[3];
			if (this.baseInputStream.Read(array, 0, array.Length) < 0)
			{
				throw new global::ICSharpCode.SharpZipLib.Lzw.LzwException("Failed to read LZW header");
			}
			if (array[0] != 31 || array[1] != 157)
			{
				throw new global::ICSharpCode.SharpZipLib.Lzw.LzwException(string.Format("Wrong LZW header. Magic bytes don't match. 0x{0:x2} 0x{1:x2}", array[0], array[1]));
			}
			this.blockMode = ((array[2] & 128) > 0);
			this.maxBits = (int)(array[2] & 31);
			if (this.maxBits > 16)
			{
				throw new global::ICSharpCode.SharpZipLib.Lzw.LzwException(string.Concat(new string[]
				{
					"Stream compressed with ",
					this.maxBits.ToString(),
					" bits, but decompression can only handle ",
					16.ToString(),
					" bits."
				}));
			}
			if ((array[2] & 96) > 0)
			{
				throw new global::ICSharpCode.SharpZipLib.Lzw.LzwException("Unsupported bits set in the header.");
			}
			this.maxMaxCode = 1 << this.maxBits;
			this.nBits = 9;
			this.maxCode = (1 << this.nBits) - 1;
			this.bitMask = this.maxCode;
			this.oldCode = -1;
			this.finChar = 0;
			this.freeEnt = (this.blockMode ? 257 : 256);
			this.tabPrefix = new int[1 << this.maxBits];
			this.tabSuffix = new byte[1 << this.maxBits];
			this.stack = new byte[1 << this.maxBits];
			this.stackP = this.stack.Length;
			for (int i = 255; i >= 0; i--)
			{
				this.tabSuffix[i] = (byte)i;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x000120BC File Offset: 0x000102BC
		public override bool CanRead
		{
			get
			{
				return this.baseInputStream.CanRead;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x000120C9 File Offset: 0x000102C9
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003DA RID: 986 RVA: 0x000120CC File Offset: 0x000102CC
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003DB RID: 987 RVA: 0x000120CF File Offset: 0x000102CF
		public override long Length
		{
			get
			{
				return (long)this.got;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003DC RID: 988 RVA: 0x000120D8 File Offset: 0x000102D8
		// (set) Token: 0x060003DD RID: 989 RVA: 0x000120E5 File Offset: 0x000102E5
		public override long Position
		{
			get
			{
				return this.baseInputStream.Position;
			}
			set
			{
				throw new global::System.NotSupportedException("InflaterInputStream Position not supported");
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000120F1 File Offset: 0x000102F1
		public override void Flush()
		{
			this.baseInputStream.Flush();
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000120FE File Offset: 0x000102FE
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException("Seek not supported");
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0001210A File Offset: 0x0001030A
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException("InflaterInputStream SetLength not supported");
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00012116 File Offset: 0x00010316
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException("InflaterInputStream Write not supported");
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00012122 File Offset: 0x00010322
		public override void WriteByte(byte value)
		{
			throw new global::System.NotSupportedException("InflaterInputStream WriteByte not supported");
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0001212E File Offset: 0x0001032E
		protected override void Dispose(bool disposing)
		{
			if (!this.isClosed)
			{
				this.isClosed = true;
				if (this.IsStreamOwner)
				{
					this.baseInputStream.Dispose();
				}
			}
		}

		// Token: 0x04000248 RID: 584
		private global::System.IO.Stream baseInputStream;

		// Token: 0x04000249 RID: 585
		private bool isClosed;

		// Token: 0x0400024A RID: 586
		private readonly byte[] one = new byte[1];

		// Token: 0x0400024B RID: 587
		private bool headerParsed;

		// Token: 0x0400024C RID: 588
		private const int TBL_CLEAR = 256;

		// Token: 0x0400024D RID: 589
		private const int TBL_FIRST = 257;

		// Token: 0x0400024E RID: 590
		private int[] tabPrefix;

		// Token: 0x0400024F RID: 591
		private byte[] tabSuffix;

		// Token: 0x04000250 RID: 592
		private readonly int[] zeros = new int[256];

		// Token: 0x04000251 RID: 593
		private byte[] stack;

		// Token: 0x04000252 RID: 594
		private bool blockMode;

		// Token: 0x04000253 RID: 595
		private int nBits;

		// Token: 0x04000254 RID: 596
		private int maxBits;

		// Token: 0x04000255 RID: 597
		private int maxMaxCode;

		// Token: 0x04000256 RID: 598
		private int maxCode;

		// Token: 0x04000257 RID: 599
		private int bitMask;

		// Token: 0x04000258 RID: 600
		private int oldCode;

		// Token: 0x04000259 RID: 601
		private byte finChar;

		// Token: 0x0400025A RID: 602
		private int stackP;

		// Token: 0x0400025B RID: 603
		private int freeEnt;

		// Token: 0x0400025C RID: 604
		private readonly byte[] data = new byte[8192];

		// Token: 0x0400025D RID: 605
		private int bitPos;

		// Token: 0x0400025E RID: 606
		private int end;

		// Token: 0x0400025F RID: 607
		private int got;

		// Token: 0x04000260 RID: 608
		private bool eof;

		// Token: 0x04000261 RID: 609
		private const int EXTRA = 64;
	}
}
