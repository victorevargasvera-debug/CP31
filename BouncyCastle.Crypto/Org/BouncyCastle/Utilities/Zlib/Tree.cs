using System;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x02000045 RID: 69
	internal sealed class Tree
	{
		// Token: 0x0600030C RID: 780 RVA: 0x0001231F File Offset: 0x0001051F
		internal static int d_code(int dist)
		{
			if (dist >= 256)
			{
				return (int)global::Org.BouncyCastle.Utilities.Zlib.Tree._dist_code[256 + (dist >> 7)];
			}
			return (int)global::Org.BouncyCastle.Utilities.Zlib.Tree._dist_code[dist];
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00012340 File Offset: 0x00010540
		internal void gen_bitlen(global::Org.BouncyCastle.Utilities.Zlib.Deflate s)
		{
			short[] tree = this.dyn_tree;
			short[] stree = this.stat_desc.static_tree;
			int[] extra = this.stat_desc.extra_bits;
			int based = this.stat_desc.extra_base;
			int max_length = this.stat_desc.max_length;
			int overflow = 0;
			for (int bits = 0; bits <= 15; bits++)
			{
				s.bl_count[bits] = 0;
			}
			tree[s.heap[s.heap_max] * 2 + 1] = 0;
			int h;
			for (h = s.heap_max + 1; h < 573; h++)
			{
				int i = s.heap[h];
				int bits = (int)(tree[(int)(tree[i * 2 + 1] * 2 + 1)] + 1);
				if (bits > max_length)
				{
					bits = max_length;
					overflow++;
				}
				tree[i * 2 + 1] = (short)bits;
				if (i <= this.max_code)
				{
					short[] bl_count = s.bl_count;
					int num = bits;
					bl_count[num] += 1;
					int xbits = 0;
					if (i >= based)
					{
						xbits = extra[i - based];
					}
					short f = tree[i * 2];
					s.opt_len += (int)f * (bits + xbits);
					if (stree != null)
					{
						s.static_len += (int)f * ((int)stree[i * 2 + 1] + xbits);
					}
				}
			}
			if (overflow == 0)
			{
				return;
			}
			do
			{
				int bits = max_length - 1;
				while (s.bl_count[bits] == 0)
				{
					bits--;
				}
				short[] bl_count2 = s.bl_count;
				int num2 = bits;
				bl_count2[num2] -= 1;
				short[] bl_count3 = s.bl_count;
				int num3 = bits + 1;
				bl_count3[num3] += 2;
				short[] bl_count4 = s.bl_count;
				int num4 = max_length;
				bl_count4[num4] -= 1;
				overflow -= 2;
			}
			while (overflow > 0);
			for (int bits = max_length; bits != 0; bits--)
			{
				int i = (int)s.bl_count[bits];
				while (i != 0)
				{
					int j = s.heap[--h];
					if (j <= this.max_code)
					{
						if ((int)tree[j * 2 + 1] != bits)
						{
							s.opt_len += (int)(((long)bits - (long)tree[j * 2 + 1]) * (long)tree[j * 2]);
							tree[j * 2 + 1] = (short)bits;
						}
						i--;
					}
				}
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00012558 File Offset: 0x00010758
		internal void build_tree(global::Org.BouncyCastle.Utilities.Zlib.Deflate s)
		{
			short[] tree = this.dyn_tree;
			short[] stree = this.stat_desc.static_tree;
			int elems = this.stat_desc.elems;
			int max_code = -1;
			s.heap_len = 0;
			s.heap_max = 573;
			int num;
			for (int i = 0; i < elems; i++)
			{
				if (tree[i * 2] != 0)
				{
					int[] heap = s.heap;
					num = s.heap_len + 1;
					s.heap_len = num;
					max_code = (heap[num] = i);
					s.depth[i] = 0;
				}
				else
				{
					tree[i * 2 + 1] = 0;
				}
			}
			int node;
			while (s.heap_len < 2)
			{
				int[] heap2 = s.heap;
				num = s.heap_len + 1;
				s.heap_len = num;
				node = (heap2[num] = ((max_code < 2) ? (++max_code) : 0));
				tree[node * 2] = 1;
				s.depth[node] = 0;
				s.opt_len--;
				if (stree != null)
				{
					s.static_len -= (int)stree[node * 2 + 1];
				}
			}
			this.max_code = max_code;
			for (int i = s.heap_len / 2; i >= 1; i--)
			{
				s.pqdownheap(tree, i);
			}
			node = elems;
			do
			{
				int i = s.heap[1];
				int[] heap3 = s.heap;
				int num2 = 1;
				int[] heap4 = s.heap;
				num = s.heap_len;
				s.heap_len = num - 1;
				heap3[num2] = heap4[num];
				s.pqdownheap(tree, 1);
				int j = s.heap[1];
				int[] heap5 = s.heap;
				num = s.heap_max - 1;
				s.heap_max = num;
				heap5[num] = i;
				int[] heap6 = s.heap;
				num = s.heap_max - 1;
				s.heap_max = num;
				heap6[num] = j;
				tree[node * 2] = tree[i * 2] + tree[j * 2];
				s.depth[node] = global::System.Math.Max(s.depth[i], s.depth[j]) + 1;
				tree[i * 2 + 1] = (tree[j * 2 + 1] = (short)node);
				s.heap[1] = node++;
				s.pqdownheap(tree, 1);
			}
			while (s.heap_len >= 2);
			int[] heap7 = s.heap;
			num = s.heap_max - 1;
			s.heap_max = num;
			heap7[num] = s.heap[1];
			this.gen_bitlen(s);
			global::Org.BouncyCastle.Utilities.Zlib.Tree.gen_codes(tree, max_code, s.bl_count);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00012798 File Offset: 0x00010998
		internal static void gen_codes(short[] tree, int max_code, short[] bl_count)
		{
			short[] next_code = new short[16];
			short code = 0;
			for (int bits = 1; bits <= 15; bits++)
			{
				code = (next_code[bits] = (short)(code + bl_count[bits - 1] << 1));
			}
			for (int i = 0; i <= max_code; i++)
			{
				int len = (int)tree[i * 2 + 1];
				if (len != 0)
				{
					int num = i * 2;
					short[] array = next_code;
					int num2 = len;
					short num3 = array[num2];
					array[num2] = num3 + 1;
					tree[num] = (short)global::Org.BouncyCastle.Utilities.Zlib.Tree.bi_reverse((int)num3, len);
				}
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00012808 File Offset: 0x00010A08
		internal static int bi_reverse(int code, int len)
		{
			int res = 0;
			do
			{
				res |= (code & 1);
				code >>= 1;
				res <<= 1;
			}
			while (--len > 0);
			return res >> 1;
		}

		// Token: 0x04000220 RID: 544
		private const int MAX_BITS = 15;

		// Token: 0x04000221 RID: 545
		private const int BL_CODES = 19;

		// Token: 0x04000222 RID: 546
		private const int D_CODES = 30;

		// Token: 0x04000223 RID: 547
		private const int LITERALS = 256;

		// Token: 0x04000224 RID: 548
		private const int LENGTH_CODES = 29;

		// Token: 0x04000225 RID: 549
		private const int L_CODES = 286;

		// Token: 0x04000226 RID: 550
		private const int HEAP_SIZE = 573;

		// Token: 0x04000227 RID: 551
		internal const int MAX_BL_BITS = 7;

		// Token: 0x04000228 RID: 552
		internal const int END_BLOCK = 256;

		// Token: 0x04000229 RID: 553
		internal const int REP_3_6 = 16;

		// Token: 0x0400022A RID: 554
		internal const int REPZ_3_10 = 17;

		// Token: 0x0400022B RID: 555
		internal const int REPZ_11_138 = 18;

		// Token: 0x0400022C RID: 556
		internal static readonly int[] extra_lbits = new int[]
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

		// Token: 0x0400022D RID: 557
		internal static readonly int[] extra_dbits = new int[]
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

		// Token: 0x0400022E RID: 558
		internal static readonly int[] extra_blbits = new int[]
		{
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			2,
			3,
			7
		};

		// Token: 0x0400022F RID: 559
		internal static readonly byte[] bl_order = new byte[]
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

		// Token: 0x04000230 RID: 560
		internal const int Buf_size = 16;

		// Token: 0x04000231 RID: 561
		internal const int DIST_CODE_LEN = 512;

		// Token: 0x04000232 RID: 562
		internal static readonly byte[] _dist_code = new byte[]
		{
			0,
			1,
			2,
			3,
			4,
			4,
			5,
			5,
			6,
			6,
			6,
			6,
			7,
			7,
			7,
			7,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			8,
			9,
			9,
			9,
			9,
			9,
			9,
			9,
			9,
			10,
			10,
			10,
			10,
			10,
			10,
			10,
			10,
			10,
			10,
			10,
			10,
			10,
			10,
			10,
			10,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			11,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			12,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			13,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			14,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			15,
			0,
			0,
			16,
			17,
			18,
			18,
			19,
			19,
			20,
			20,
			20,
			20,
			21,
			21,
			21,
			21,
			22,
			22,
			22,
			22,
			22,
			22,
			22,
			22,
			23,
			23,
			23,
			23,
			23,
			23,
			23,
			23,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			28,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29,
			29
		};

		// Token: 0x04000233 RID: 563
		internal static readonly byte[] _length_code = new byte[]
		{
			0,
			1,
			2,
			3,
			4,
			5,
			6,
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
			12,
			12,
			13,
			13,
			13,
			13,
			14,
			14,
			14,
			14,
			15,
			15,
			15,
			15,
			16,
			16,
			16,
			16,
			16,
			16,
			16,
			16,
			17,
			17,
			17,
			17,
			17,
			17,
			17,
			17,
			18,
			18,
			18,
			18,
			18,
			18,
			18,
			18,
			19,
			19,
			19,
			19,
			19,
			19,
			19,
			19,
			20,
			20,
			20,
			20,
			20,
			20,
			20,
			20,
			20,
			20,
			20,
			20,
			20,
			20,
			20,
			20,
			21,
			21,
			21,
			21,
			21,
			21,
			21,
			21,
			21,
			21,
			21,
			21,
			21,
			21,
			21,
			21,
			22,
			22,
			22,
			22,
			22,
			22,
			22,
			22,
			22,
			22,
			22,
			22,
			22,
			22,
			22,
			22,
			23,
			23,
			23,
			23,
			23,
			23,
			23,
			23,
			23,
			23,
			23,
			23,
			23,
			23,
			23,
			23,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			24,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			25,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			26,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			27,
			28
		};

		// Token: 0x04000234 RID: 564
		internal static readonly int[] base_length = new int[]
		{
			0,
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			10,
			12,
			14,
			16,
			20,
			24,
			28,
			32,
			40,
			48,
			56,
			64,
			80,
			96,
			112,
			128,
			160,
			192,
			224,
			0
		};

		// Token: 0x04000235 RID: 565
		internal static readonly int[] base_dist = new int[]
		{
			0,
			1,
			2,
			3,
			4,
			6,
			8,
			12,
			16,
			24,
			32,
			48,
			64,
			96,
			128,
			192,
			256,
			384,
			512,
			768,
			1024,
			1536,
			2048,
			3072,
			4096,
			6144,
			8192,
			12288,
			16384,
			24576
		};

		// Token: 0x04000236 RID: 566
		internal short[] dyn_tree;

		// Token: 0x04000237 RID: 567
		internal int max_code;

		// Token: 0x04000238 RID: 568
		internal global::Org.BouncyCastle.Utilities.Zlib.StaticTree stat_desc;
	}
}
