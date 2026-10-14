using System;
using System.IO;

namespace Ionic.Zip.Deflate64
{
	// Token: 0x0200005C RID: 92
	internal sealed class HuffmanTree
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x0001B034 File Offset: 0x00019234
		public static global::Ionic.Zip.Deflate64.HuffmanTree StaticLiteralLengthTree { get; } = new global::Ionic.Zip.Deflate64.HuffmanTree(global::Ionic.Zip.Deflate64.HuffmanTree.GetStaticLiteralTreeLength());

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0001B03B File Offset: 0x0001923B
		public static global::Ionic.Zip.Deflate64.HuffmanTree StaticDistanceTree { get; } = new global::Ionic.Zip.Deflate64.HuffmanTree(global::Ionic.Zip.Deflate64.HuffmanTree.GetStaticDistanceTreeLength());

		// Token: 0x06000492 RID: 1170 RVA: 0x0001B044 File Offset: 0x00019244
		public HuffmanTree(byte[] codeLengths)
		{
			this._codeLengthArray = codeLengths;
			if (this._codeLengthArray.Length == 288)
			{
				this._tableBits = 9;
			}
			else
			{
				this._tableBits = 7;
			}
			this._tableMask = (1 << this._tableBits) - 1;
			this._table = new short[1 << this._tableBits];
			this._left = new short[2 * this._codeLengthArray.Length];
			this._right = new short[2 * this._codeLengthArray.Length];
			this.CreateTable();
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0001B0D8 File Offset: 0x000192D8
		private static byte[] GetStaticLiteralTreeLength()
		{
			byte[] array = new byte[288];
			for (int i = 0; i <= 143; i++)
			{
				array[i] = 8;
			}
			for (int j = 144; j <= 255; j++)
			{
				array[j] = 9;
			}
			for (int k = 256; k <= 279; k++)
			{
				array[k] = 7;
			}
			for (int l = 280; l <= 287; l++)
			{
				array[l] = 8;
			}
			return array;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0001B154 File Offset: 0x00019354
		private static byte[] GetStaticDistanceTreeLength()
		{
			byte[] array = new byte[32];
			for (int i = 0; i < 32; i++)
			{
				array[i] = 5;
			}
			return array;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0001B17C File Offset: 0x0001937C
		private static uint BitReverse(uint code, int length)
		{
			uint num = 0U;
			do
			{
				num |= (code & 1U);
				num <<= 1;
				code >>= 1;
			}
			while (--length > 0);
			return num >> 1;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0001B1A8 File Offset: 0x000193A8
		private uint[] CalculateHuffmanCode()
		{
			uint[] array = new uint[17];
			foreach (int num in this._codeLengthArray)
			{
				array[num] += 1U;
			}
			array[0] = 0U;
			uint[] array2 = new uint[17];
			uint num2 = 0U;
			for (int j = 1; j <= 16; j++)
			{
				num2 = num2 + array[j - 1] << 1;
				array2[j] = num2;
			}
			uint[] array3 = new uint[288];
			for (int k = 0; k < this._codeLengthArray.Length; k++)
			{
				int num3 = (int)this._codeLengthArray[k];
				if (num3 > 0)
				{
					array3[k] = global::Ionic.Zip.Deflate64.HuffmanTree.BitReverse(array2[num3], num3);
					array2[num3] += 1U;
				}
			}
			return array3;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0001B26C File Offset: 0x0001946C
		private void CreateTable()
		{
			uint[] array = this.CalculateHuffmanCode();
			short num = (short)this._codeLengthArray.Length;
			for (int i = 0; i < this._codeLengthArray.Length; i++)
			{
				int num2 = (int)this._codeLengthArray[i];
				if (num2 > 0)
				{
					int num3 = (int)array[i];
					if (num2 > this._tableBits)
					{
						int num4 = num2 - this._tableBits;
						int num5 = 1 << this._tableBits;
						int num6 = num3 & (1 << this._tableBits) - 1;
						short[] array2 = this._table;
						do
						{
							short num7 = array2[num6];
							if (num7 == 0)
							{
								array2[num6] = -num;
								num7 = -num;
								num += 1;
							}
							if (num7 > 0)
							{
								goto Block_6;
							}
							if ((num3 & num5) == 0)
							{
								array2 = this._left;
							}
							else
							{
								array2 = this._right;
							}
							num6 = (int)(-(int)num7);
							num5 <<= 1;
							num4--;
						}
						while (num4 != 0);
						array2[num6] = (short)i;
						goto IL_119;
						Block_6:
						throw new global::System.IO.InvalidDataException("InvalidHuffmanData");
					}
					int num8 = 1 << num2;
					if (num3 >= num8)
					{
						throw new global::System.IO.InvalidDataException("InvalidHuffmanData");
					}
					int num9 = 1 << this._tableBits - num2;
					for (int j = 0; j < num9; j++)
					{
						this._table[num3] = (short)i;
						num3 += num8;
					}
				}
				IL_119:;
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0001B3A4 File Offset: 0x000195A4
		public int GetNextSymbol(global::Ionic.Zip.Deflate64.InputBuffer input)
		{
			uint num = input.TryLoad16Bits();
			if (input.AvailableBits == 0)
			{
				return -1;
			}
			int num2 = (int)this._table[(int)(checked((global::System.IntPtr)(unchecked((ulong)num & (ulong)((long)this._tableMask)))))];
			if (num2 < 0)
			{
				uint num3 = 1U << this._tableBits;
				do
				{
					num2 = -num2;
					if ((num & num3) == 0U)
					{
						num2 = (int)this._left[num2];
					}
					else
					{
						num2 = (int)this._right[num2];
					}
					num3 <<= 1;
				}
				while (num2 < 0);
			}
			int num4 = (int)this._codeLengthArray[num2];
			if (num4 <= 0)
			{
				throw new global::System.IO.InvalidDataException("InvalidHuffmanData");
			}
			if (num4 > input.AvailableBits)
			{
				return -1;
			}
			input.SkipBits(num4);
			return num2;
		}

		// Token: 0x040002F5 RID: 757
		internal const int MaxLiteralTreeElements = 288;

		// Token: 0x040002F6 RID: 758
		internal const int MaxDistTreeElements = 32;

		// Token: 0x040002F7 RID: 759
		internal const int EndOfBlockCode = 256;

		// Token: 0x040002F8 RID: 760
		internal const int NumberOfCodeLengthTreeElements = 19;

		// Token: 0x040002F9 RID: 761
		private readonly int _tableBits;

		// Token: 0x040002FA RID: 762
		private readonly short[] _table;

		// Token: 0x040002FB RID: 763
		private readonly short[] _left;

		// Token: 0x040002FC RID: 764
		private readonly short[] _right;

		// Token: 0x040002FD RID: 765
		private readonly byte[] _codeLengthArray;

		// Token: 0x040002FE RID: 766
		private readonly int _tableMask;
	}
}
