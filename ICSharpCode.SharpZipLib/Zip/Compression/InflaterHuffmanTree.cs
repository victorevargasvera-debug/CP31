using System;
using System.Collections.Generic;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x0200003B RID: 59
	public class InflaterHuffmanTree
	{
		// Token: 0x0600026C RID: 620 RVA: 0x0000D150 File Offset: 0x0000B350
		static InflaterHuffmanTree()
		{
			try
			{
				byte[] array = new byte[288];
				int i = 0;
				while (i < 144)
				{
					array[i++] = 8;
				}
				while (i < 256)
				{
					array[i++] = 9;
				}
				while (i < 280)
				{
					array[i++] = 7;
				}
				while (i < 288)
				{
					array[i++] = 8;
				}
				global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree.defLitLenTree = new global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree(array);
				array = new byte[32];
				i = 0;
				while (i < 32)
				{
					array[i++] = 5;
				}
				global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree.defDistTree = new global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree(array);
			}
			catch (global::System.Exception)
			{
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("InflaterHuffmanTree: static tree length illegal");
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000D200 File Offset: 0x0000B400
		public InflaterHuffmanTree(global::System.Collections.Generic.IList<byte> codeLengths)
		{
			this.BuildTree(codeLengths);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000D210 File Offset: 0x0000B410
		private void BuildTree(global::System.Collections.Generic.IList<byte> codeLengths)
		{
			int[] array = new int[16];
			int[] array2 = new int[16];
			for (int i = 0; i < codeLengths.Count; i++)
			{
				int num = (int)codeLengths[i];
				if (num > 0)
				{
					array[num]++;
				}
			}
			int num2 = 0;
			int num3 = 512;
			for (int j = 1; j <= 15; j++)
			{
				array2[j] = num2;
				num2 += array[j] << 16 - j;
				if (j >= 10)
				{
					int num4 = array2[j] & 130944;
					int num5 = num2 & 130944;
					num3 += num5 - num4 >> 16 - j;
				}
			}
			this.tree = new short[num3];
			int num6 = 512;
			for (int k = 15; k >= 10; k--)
			{
				int num7 = num2 & 130944;
				num2 -= array[k] << 16 - k;
				for (int l = num2 & 130944; l < num7; l += 128)
				{
					this.tree[(int)global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BitReverse(l)] = (short)(-num6 << 4 | k);
					num6 += 1 << k - 9;
				}
			}
			for (int m = 0; m < codeLengths.Count; m++)
			{
				int num8 = (int)codeLengths[m];
				if (num8 != 0)
				{
					num2 = array2[num8];
					int num9 = (int)global::ICSharpCode.SharpZipLib.Zip.Compression.DeflaterHuffman.BitReverse(num2);
					if (num8 <= 9)
					{
						do
						{
							this.tree[num9] = (short)(m << 4 | num8);
							num9 += 1 << num8;
						}
						while (num9 < 512);
					}
					else
					{
						int num10 = (int)this.tree[num9 & 511];
						int num11 = 1 << (num10 & 15);
						num10 = -(num10 >> 4);
						do
						{
							this.tree[num10 | num9 >> 9] = (short)(m << 4 | num8);
							num9 += 1 << num8;
						}
						while (num9 < num11);
					}
					array2[num8] = num2 + (1 << 16 - num8);
				}
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000D3FC File Offset: 0x0000B5FC
		public int GetSymbol(global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator input)
		{
			int num;
			if ((num = input.PeekBits(9)) >= 0)
			{
				int num2 = (int)this.tree[num];
				int num3 = num2 & 15;
				if (num2 >= 0)
				{
					if (num3 == 0)
					{
						throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Encountered invalid codelength 0");
					}
					input.DropBits(num3);
					return num2 >> 4;
				}
				else
				{
					int num4 = -(num2 >> 4);
					if ((num = input.PeekBits(num3)) >= 0)
					{
						num2 = (int)this.tree[num4 | num >> 9];
						input.DropBits(num2 & 15);
						return num2 >> 4;
					}
					int availableBits = input.AvailableBits;
					num = input.PeekBits(availableBits);
					num2 = (int)this.tree[num4 | num >> 9];
					if ((num2 & 15) <= availableBits)
					{
						input.DropBits(num2 & 15);
						return num2 >> 4;
					}
					return -1;
				}
			}
			else
			{
				int availableBits2 = input.AvailableBits;
				num = input.PeekBits(availableBits2);
				int num2 = (int)this.tree[num];
				if (num2 >= 0 && (num2 & 15) <= availableBits2)
				{
					input.DropBits(num2 & 15);
					return num2 >> 4;
				}
				return -1;
			}
		}

		// Token: 0x0400019F RID: 415
		private const int MAX_BITLEN = 15;

		// Token: 0x040001A0 RID: 416
		private short[] tree;

		// Token: 0x040001A1 RID: 417
		public static global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree defLitLenTree;

		// Token: 0x040001A2 RID: 418
		public static global::ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree defDistTree;
	}
}
