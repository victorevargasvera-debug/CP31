using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x02000037 RID: 55
	public class DeflaterHuffman
	{
		// Token: 0x06000242 RID: 578 RVA: 0x0000BF90 File Offset: 0x0000A190
		static DeflaterHuffman()
		{
			int i = 0;
			while (i < 144)
			{
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLCodes[i] = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BitReverse(48 + i << 8);
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLLength[i++] = 8;
			}
			while (i < 256)
			{
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLCodes[i] = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BitReverse(256 + i << 7);
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLLength[i++] = 9;
			}
			while (i < 280)
			{
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLCodes[i] = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BitReverse(-256 + i << 9);
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLLength[i++] = 7;
			}
			while (i < 286)
			{
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLCodes[i] = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BitReverse(-88 + i << 8);
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLLength[i++] = 8;
			}
			global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticDCodes = new short[30];
			global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticDLength = new byte[30];
			for (i = 0; i < 30; i++)
			{
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticDCodes[i] = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BitReverse(i << 11);
				global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticDLength[i] = 5;
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000C0D0 File Offset: 0x0000A2D0
		public DeflaterHuffman(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending pending)
		{
			this.pending = pending;
			this.literalTree = new global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree(this, 286, 257, 15);
			this.distTree = new global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree(this, 30, 1, 15);
			this.blTree = new global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree(this, 19, 4, 7);
			this.d_buf = new short[16384];
			this.l_buf = new byte[16384];
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000C143 File Offset: 0x0000A343
		public void Reset()
		{
			this.last_lit = 0;
			this.extra_bits = 0;
			this.literalTree.Reset();
			this.distTree.Reset();
			this.blTree.Reset();
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000C174 File Offset: 0x0000A374
		public void SendAllTrees(int blTreeCodes)
		{
			this.blTree.BuildCodes();
			this.literalTree.BuildCodes();
			this.distTree.BuildCodes();
			this.pending.WriteBits(this.literalTree.numCodes - 257, 5);
			this.pending.WriteBits(this.distTree.numCodes - 1, 5);
			this.pending.WriteBits(blTreeCodes - 4, 4);
			for (int i = 0; i < blTreeCodes; i++)
			{
				this.pending.WriteBits((int)this.blTree.length[global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BL_ORDER[i]], 3);
			}
			this.literalTree.WriteTree(this.blTree);
			this.distTree.WriteTree(this.blTree);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000C234 File Offset: 0x0000A434
		public void CompressBlock()
		{
			for (int i = 0; i < this.last_lit; i++)
			{
				int num = (int)(this.l_buf[i] & byte.MaxValue);
				int num2 = (int)this.d_buf[i];
				if (num2-- != 0)
				{
					int num3 = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Lcode(num);
					this.literalTree.WriteSymbol(num3);
					int num4 = (num3 - 261) / 4;
					if (num4 > 0 && num4 <= 5)
					{
						this.pending.WriteBits(num & (1 << num4) - 1, num4);
					}
					int num5 = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Dcode(num2);
					this.distTree.WriteSymbol(num5);
					num4 = num5 / 2 - 1;
					if (num4 > 0)
					{
						this.pending.WriteBits(num2 & (1 << num4) - 1, num4);
					}
				}
				else
				{
					this.literalTree.WriteSymbol(num);
				}
			}
			this.literalTree.WriteSymbol(256);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000C310 File Offset: 0x0000A510
		public void FlushStoredBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
		{
			this.pending.WriteBits(lastBlock ? 1 : 0, 3);
			this.pending.AlignToByte();
			this.pending.WriteShort(storedLength);
			this.pending.WriteShort(~storedLength);
			this.pending.WriteBlock(stored, storedOffset, storedLength);
			this.Reset();
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000C36C File Offset: 0x0000A56C
		public void FlushBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock)
		{
			short[] freqs = this.literalTree.freqs;
			int num = 256;
			freqs[num] += 1;
			this.literalTree.BuildTree();
			this.distTree.BuildTree();
			this.literalTree.CalcBLFreq(this.blTree);
			this.distTree.CalcBLFreq(this.blTree);
			this.blTree.BuildTree();
			int num2 = 4;
			for (int i = 18; i > num2; i--)
			{
				if (this.blTree.length[global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BL_ORDER[i]] > 0)
				{
					num2 = i + 1;
				}
			}
			int num3 = 14 + num2 * 3 + this.blTree.GetEncodedLength() + this.literalTree.GetEncodedLength() + this.distTree.GetEncodedLength() + this.extra_bits;
			int num4 = this.extra_bits;
			for (int j = 0; j < 286; j++)
			{
				num4 += (int)(this.literalTree.freqs[j] * (short)global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLLength[j]);
			}
			for (int k = 0; k < 30; k++)
			{
				num4 += (int)(this.distTree.freqs[k] * (short)global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticDLength[k]);
			}
			if (num3 >= num4)
			{
				num3 = num4;
			}
			if (storedOffset >= 0 && storedLength + 4 < num3 >> 3)
			{
				this.FlushStoredBlock(stored, storedOffset, storedLength, lastBlock);
				return;
			}
			if (num3 == num4)
			{
				this.pending.WriteBits(2 + (lastBlock ? 1 : 0), 3);
				this.literalTree.SetStaticCodes(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLCodes, global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticLLength);
				this.distTree.SetStaticCodes(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticDCodes, global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.staticDLength);
				this.CompressBlock();
				this.Reset();
				return;
			}
			this.pending.WriteBits(4 + (lastBlock ? 1 : 0), 3);
			this.SendAllTrees(num2);
			this.CompressBlock();
			this.Reset();
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000C52A File Offset: 0x0000A72A
		public bool IsFull()
		{
			return this.last_lit >= 16384;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000C53C File Offset: 0x0000A73C
		public bool TallyLit(int literal)
		{
			this.d_buf[this.last_lit] = 0;
			byte[] array = this.l_buf;
			int num = this.last_lit;
			this.last_lit = num + 1;
			array[num] = (byte)literal;
			short[] freqs = this.literalTree.freqs;
			freqs[literal] += 1;
			return this.IsFull();
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000C590 File Offset: 0x0000A790
		public bool TallyDist(int distance, int length)
		{
			this.d_buf[this.last_lit] = (short)distance;
			byte[] array = this.l_buf;
			int num = this.last_lit;
			this.last_lit = num + 1;
			array[num] = (byte)(length - 3);
			int num2 = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Lcode(length - 3);
			short[] freqs = this.literalTree.freqs;
			int num3 = num2;
			freqs[num3] += 1;
			if (num2 >= 265 && num2 < 285)
			{
				this.extra_bits += (num2 - 261) / 4;
			}
			int num4 = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Dcode(distance - 1);
			short[] freqs2 = this.distTree.freqs;
			int num5 = num4;
			freqs2[num5] += 1;
			if (num4 >= 4)
			{
				this.extra_bits += num4 / 2 - 1;
			}
			return this.IsFull();
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000C64A File Offset: 0x0000A84A
		public static short BitReverse(int toReverse)
		{
			return (short)((int)global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.bit4Reverse[toReverse & 15] << 12 | (int)global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.bit4Reverse[toReverse >> 4 & 15] << 8 | (int)global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.bit4Reverse[toReverse >> 8 & 15] << 4 | (int)global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.bit4Reverse[toReverse >> 12]);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000C684 File Offset: 0x0000A884
		private static int Lcode(int length)
		{
			if (length == 255)
			{
				return 285;
			}
			int num = 257;
			while (length >= 8)
			{
				num += 4;
				length >>= 1;
			}
			return num + length;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000C6B8 File Offset: 0x0000A8B8
		private static int Dcode(int distance)
		{
			int num = 0;
			while (distance >= 4)
			{
				num += 2;
				distance >>= 1;
			}
			return num + distance;
		}

		// Token: 0x0400015A RID: 346
		private const int BUFSIZE = 16384;

		// Token: 0x0400015B RID: 347
		private const int LITERAL_NUM = 286;

		// Token: 0x0400015C RID: 348
		private const int DIST_NUM = 30;

		// Token: 0x0400015D RID: 349
		private const int BITLEN_NUM = 19;

		// Token: 0x0400015E RID: 350
		private const int REP_3_6 = 16;

		// Token: 0x0400015F RID: 351
		private const int REP_3_10 = 17;

		// Token: 0x04000160 RID: 352
		private const int REP_11_138 = 18;

		// Token: 0x04000161 RID: 353
		private const int EOF_SYMBOL = 256;

		// Token: 0x04000162 RID: 354
		private static readonly int[] BL_ORDER = new int[]
		{
			16,
			17,
			18,
			0,
			8,
			7,
			9,
			6,
			10,
			5,
			11,
			4,
			12,
			3,
			13,
			2,
			14,
			1,
			15
		};

		// Token: 0x04000163 RID: 355
		private static readonly byte[] bit4Reverse = new byte[]
		{
			0,
			8,
			4,
			12,
			2,
			10,
			6,
			14,
			1,
			9,
			5,
			13,
			3,
			11,
			7,
			15
		};

		// Token: 0x04000164 RID: 356
		private static short[] staticLCodes = new short[286];

		// Token: 0x04000165 RID: 357
		private static byte[] staticLLength = new byte[286];

		// Token: 0x04000166 RID: 358
		private static short[] staticDCodes;

		// Token: 0x04000167 RID: 359
		private static byte[] staticDLength;

		// Token: 0x04000168 RID: 360
		public global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterPending pending;

		// Token: 0x04000169 RID: 361
		private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree literalTree;

		// Token: 0x0400016A RID: 362
		private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree distTree;

		// Token: 0x0400016B RID: 363
		private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree blTree;

		// Token: 0x0400016C RID: 364
		private short[] d_buf;

		// Token: 0x0400016D RID: 365
		private byte[] l_buf;

		// Token: 0x0400016E RID: 366
		private int last_lit;

		// Token: 0x0400016F RID: 367
		private int extra_bits;

		// Token: 0x0200008B RID: 139
		private class Tree
		{
			// Token: 0x0600055D RID: 1373 RVA: 0x00018513 File Offset: 0x00016713
			public Tree(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman dh, int elems, int minCodes, int maxLength)
			{
				this.dh = dh;
				this.minNumCodes = minCodes;
				this.maxLength = maxLength;
				this.freqs = new short[elems];
				this.bl_counts = new int[maxLength];
			}

			// Token: 0x0600055E RID: 1374 RVA: 0x0001854C File Offset: 0x0001674C
			public void Reset()
			{
				for (int i = 0; i < this.freqs.Length; i++)
				{
					this.freqs[i] = 0;
				}
				this.codes = null;
				this.length = null;
			}

			// Token: 0x0600055F RID: 1375 RVA: 0x00018583 File Offset: 0x00016783
			public void WriteSymbol(int code)
			{
				this.dh.pending.WriteBits((int)this.codes[code] & 65535, (int)this.length[code]);
			}

			// Token: 0x06000560 RID: 1376 RVA: 0x000185AC File Offset: 0x000167AC
			public void CheckEmpty()
			{
				bool flag = true;
				for (int i = 0; i < this.freqs.Length; i++)
				{
					flag &= (this.freqs[i] == 0);
				}
				if (!flag)
				{
					throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("!Empty");
				}
			}

			// Token: 0x06000561 RID: 1377 RVA: 0x000185EA File Offset: 0x000167EA
			public void SetStaticCodes(short[] staticCodes, byte[] staticLengths)
			{
				this.codes = staticCodes;
				this.length = staticLengths;
			}

			// Token: 0x06000562 RID: 1378 RVA: 0x000185FC File Offset: 0x000167FC
			public void BuildCodes()
			{
				int num = this.freqs.Length;
				int[] array = new int[this.maxLength];
				int num2 = 0;
				this.codes = new short[this.freqs.Length];
				for (int i = 0; i < this.maxLength; i++)
				{
					array[i] = num2;
					num2 += this.bl_counts[i] << 15 - i;
				}
				for (int j = 0; j < this.numCodes; j++)
				{
					int num3 = (int)this.length[j];
					if (num3 > 0)
					{
						this.codes[j] = global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BitReverse(array[num3 - 1]);
						array[num3 - 1] += 1 << 16 - num3;
					}
				}
			}

			// Token: 0x06000563 RID: 1379 RVA: 0x000186A8 File Offset: 0x000168A8
			public void BuildTree()
			{
				int num = this.freqs.Length;
				int[] array = new int[num];
				int i = 0;
				int num2 = 0;
				for (int j = 0; j < num; j++)
				{
					int num3 = (int)this.freqs[j];
					if (num3 != 0)
					{
						int num4 = i++;
						int num5;
						while (num4 > 0 && (int)this.freqs[array[num5 = (num4 - 1) / 2]] > num3)
						{
							array[num4] = array[num5];
							num4 = num5;
						}
						array[num4] = j;
						num2 = j;
					}
				}
				while (i < 2)
				{
					int num6 = (num2 < 2) ? (++num2) : 0;
					array[i++] = num6;
				}
				this.numCodes = global::System.Math.Max(num2 + 1, this.minNumCodes);
				int num7 = i;
				int[] array2 = new int[4 * i - 2];
				int[] array3 = new int[2 * i - 1];
				int num8 = num7;
				for (int k = 0; k < i; k++)
				{
					int num9 = array[k];
					array2[2 * k] = num9;
					array2[2 * k + 1] = -1;
					array3[k] = (int)this.freqs[num9] << 8;
					array[k] = k;
				}
				do
				{
					int num10 = array[0];
					int num11 = array[--i];
					int num12 = 0;
					int l;
					for (l = 1; l < i; l = l * 2 + 1)
					{
						if (l + 1 < i && array3[array[l]] > array3[array[l + 1]])
						{
							l++;
						}
						array[num12] = array[l];
						num12 = l;
					}
					int num13 = array3[num11];
					while ((l = num12) > 0 && array3[array[num12 = (l - 1) / 2]] > num13)
					{
						array[l] = array[num12];
					}
					array[l] = num11;
					int num14 = array[0];
					num11 = num8++;
					array2[2 * num11] = num10;
					array2[2 * num11 + 1] = num14;
					int num15 = global::System.Math.Min(array3[num10] & 255, array3[num14] & 255);
					num13 = (array3[num11] = array3[num10] + array3[num14] - num15 + 1);
					num12 = 0;
					for (l = 1; l < i; l = num12 * 2 + 1)
					{
						if (l + 1 < i && array3[array[l]] > array3[array[l + 1]])
						{
							l++;
						}
						array[num12] = array[l];
						num12 = l;
					}
					while ((l = num12) > 0 && array3[array[num12 = (l - 1) / 2]] > num13)
					{
						array[l] = array[num12];
					}
					array[l] = num11;
				}
				while (i > 1);
				if (array[0] != array2.Length / 2 - 1)
				{
					throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Heap invariant violated");
				}
				this.BuildLength(array2);
			}

			// Token: 0x06000564 RID: 1380 RVA: 0x00018914 File Offset: 0x00016B14
			public int GetEncodedLength()
			{
				int num = 0;
				for (int i = 0; i < this.freqs.Length; i++)
				{
					num += (int)(this.freqs[i] * (short)this.length[i]);
				}
				return num;
			}

			// Token: 0x06000565 RID: 1381 RVA: 0x0001894C File Offset: 0x00016B4C
			public void CalcBLFreq(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree blTree)
			{
				int num = -1;
				int i = 0;
				while (i < this.numCodes)
				{
					int num2 = 1;
					int num3 = (int)this.length[i];
					int num4;
					int num5;
					if (num3 == 0)
					{
						num4 = 138;
						num5 = 3;
					}
					else
					{
						num4 = 6;
						num5 = 3;
						if (num != num3)
						{
							short[] array = blTree.freqs;
							int num6 = num3;
							array[num6] += 1;
							num2 = 0;
						}
					}
					num = num3;
					i++;
					while (i < this.numCodes && num == (int)this.length[i])
					{
						i++;
						if (++num2 >= num4)
						{
							break;
						}
					}
					if (num2 < num5)
					{
						short[] array2 = blTree.freqs;
						int num7 = num;
						array2[num7] += (short)num2;
					}
					else if (num != 0)
					{
						short[] array3 = blTree.freqs;
						int num8 = 16;
						array3[num8] += 1;
					}
					else if (num2 <= 10)
					{
						short[] array4 = blTree.freqs;
						int num9 = 17;
						array4[num9] += 1;
					}
					else
					{
						short[] array5 = blTree.freqs;
						int num10 = 18;
						array5[num10] += 1;
					}
				}
			}

			// Token: 0x06000566 RID: 1382 RVA: 0x00018A38 File Offset: 0x00016C38
			public void WriteTree(global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.Tree blTree)
			{
				int num = -1;
				int i = 0;
				while (i < this.numCodes)
				{
					int num2 = 1;
					int num3 = (int)this.length[i];
					int num4;
					int num5;
					if (num3 == 0)
					{
						num4 = 138;
						num5 = 3;
					}
					else
					{
						num4 = 6;
						num5 = 3;
						if (num != num3)
						{
							blTree.WriteSymbol(num3);
							num2 = 0;
						}
					}
					num = num3;
					i++;
					while (i < this.numCodes && num == (int)this.length[i])
					{
						i++;
						if (++num2 >= num4)
						{
							break;
						}
					}
					if (num2 < num5)
					{
						while (num2-- > 0)
						{
							blTree.WriteSymbol(num);
						}
					}
					else if (num != 0)
					{
						blTree.WriteSymbol(16);
						this.dh.pending.WriteBits(num2 - 3, 2);
					}
					else if (num2 <= 10)
					{
						blTree.WriteSymbol(17);
						this.dh.pending.WriteBits(num2 - 3, 3);
					}
					else
					{
						blTree.WriteSymbol(18);
						this.dh.pending.WriteBits(num2 - 11, 7);
					}
				}
			}

			// Token: 0x06000567 RID: 1383 RVA: 0x00018B34 File Offset: 0x00016D34
			private void BuildLength(int[] childs)
			{
				this.length = new byte[this.freqs.Length];
				int num = childs.Length / 2;
				int num2 = (num + 1) / 2;
				int num3 = 0;
				for (int i = 0; i < this.maxLength; i++)
				{
					this.bl_counts[i] = 0;
				}
				int[] array = new int[num];
				array[num - 1] = 0;
				for (int j = num - 1; j >= 0; j--)
				{
					if (childs[2 * j + 1] != -1)
					{
						int num4 = array[j] + 1;
						if (num4 > this.maxLength)
						{
							num4 = this.maxLength;
							num3++;
						}
						array[childs[2 * j]] = (array[childs[2 * j + 1]] = num4);
					}
					else
					{
						int num5 = array[j];
						this.bl_counts[num5 - 1]++;
						this.length[childs[2 * j]] = (byte)array[j];
					}
				}
				if (num3 == 0)
				{
					return;
				}
				int num6 = this.maxLength - 1;
				for (;;)
				{
					if (this.bl_counts[--num6] != 0)
					{
						do
						{
							this.bl_counts[num6]--;
							this.bl_counts[++num6]++;
							num3 -= 1 << this.maxLength - 1 - num6;
						}
						while (num3 > 0 && num6 < this.maxLength - 1);
						if (num3 <= 0)
						{
							break;
						}
					}
				}
				this.bl_counts[this.maxLength - 1] += num3;
				this.bl_counts[this.maxLength - 2] -= num3;
				int num7 = 2 * num2;
				for (int num8 = this.maxLength; num8 != 0; num8--)
				{
					int k = this.bl_counts[num8 - 1];
					while (k > 0)
					{
						int num9 = 2 * childs[num7++];
						if (childs[num9 + 1] == -1)
						{
							this.length[childs[num9]] = (byte)num8;
							k--;
						}
					}
				}
			}

			// Token: 0x0400035D RID: 861
			public short[] freqs;

			// Token: 0x0400035E RID: 862
			public byte[] length;

			// Token: 0x0400035F RID: 863
			public int minNumCodes;

			// Token: 0x04000360 RID: 864
			public int numCodes;

			// Token: 0x04000361 RID: 865
			private short[] codes;

			// Token: 0x04000362 RID: 866
			private readonly int[] bl_counts;

			// Token: 0x04000363 RID: 867
			private readonly int maxLength;

			// Token: 0x04000364 RID: 868
			private global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman dh;
		}
	}
}
