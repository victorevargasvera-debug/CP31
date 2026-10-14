using System;

namespace Ionic.Zlib
{
	// Token: 0x02000428 RID: 1064
	internal sealed class DeflateManager
	{
		// Token: 0x06002E0D RID: 11789 RVA: 0x0009B950 File Offset: 0x00099B50
		internal DeflateManager()
		{
			this.dyn_ltree = new short[global::Ionic.Zlib.DeflateManager.HEAP_SIZE * 2];
			this.dyn_dtree = new short[(2 * global::Ionic.Zlib.InternalConstants.D_CODES + 1) * 2];
			this.bl_tree = new short[(2 * global::Ionic.Zlib.InternalConstants.BL_CODES + 1) * 2];
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x0009BA08 File Offset: 0x00099C08
		private void _InitializeLazyMatch()
		{
			this.window_size = 2 * this.w_size;
			global::System.Array.Clear(this.head, 0, this.hash_size);
			this.config = global::Ionic.Zlib.DeflateManager.Config.Lookup(this.compressionLevel);
			this.SetDeflater();
			this.strstart = 0;
			this.block_start = 0;
			this.lookahead = 0;
			this.match_length = (this.prev_length = global::Ionic.Zlib.DeflateManager.MIN_MATCH - 1);
			this.match_available = 0;
			this.ins_h = 0;
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x0009BA8C File Offset: 0x00099C8C
		private void _InitializeTreeData()
		{
			this.treeLiterals.dyn_tree = this.dyn_ltree;
			this.treeLiterals.staticTree = global::Ionic.Zlib.StaticTree.Literals;
			this.treeDistances.dyn_tree = this.dyn_dtree;
			this.treeDistances.staticTree = global::Ionic.Zlib.StaticTree.Distances;
			this.treeBitLengths.dyn_tree = this.bl_tree;
			this.treeBitLengths.staticTree = global::Ionic.Zlib.StaticTree.BitLengths;
			this.bi_buf = 0;
			this.bi_valid = 0;
			this.last_eob_len = 8;
			this._InitializeBlocks();
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x0009BB1C File Offset: 0x00099D1C
		internal void _InitializeBlocks()
		{
			for (int i = 0; i < global::Ionic.Zlib.InternalConstants.L_CODES; i++)
			{
				this.dyn_ltree[i * 2] = 0;
			}
			for (int j = 0; j < global::Ionic.Zlib.InternalConstants.D_CODES; j++)
			{
				this.dyn_dtree[j * 2] = 0;
			}
			for (int k = 0; k < global::Ionic.Zlib.InternalConstants.BL_CODES; k++)
			{
				this.bl_tree[k * 2] = 0;
			}
			this.dyn_ltree[global::Ionic.Zlib.DeflateManager.END_BLOCK * 2] = 1;
			this.opt_len = (this.static_len = 0);
			this.last_lit = (this.matches = 0);
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x0009BBB8 File Offset: 0x00099DB8
		internal void pqdownheap(short[] tree, int k)
		{
			int num = this.heap[k];
			for (int i = k << 1; i <= this.heap_len; i <<= 1)
			{
				if (i < this.heap_len && global::Ionic.Zlib.DeflateManager._IsSmaller(tree, this.heap[i + 1], this.heap[i], this.depth))
				{
					i++;
				}
				if (global::Ionic.Zlib.DeflateManager._IsSmaller(tree, num, this.heap[i], this.depth))
				{
					break;
				}
				this.heap[k] = this.heap[i];
				k = i;
			}
			this.heap[k] = num;
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x0009BC54 File Offset: 0x00099E54
		internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth)
		{
			short num = tree[n * 2];
			short num2 = tree[m * 2];
			return num < num2 || (num == num2 && depth[n] <= depth[m]);
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x0009BC90 File Offset: 0x00099E90
		internal void scan_tree(short[] tree, int max_code)
		{
			int num = -1;
			int num2 = (int)tree[1];
			int num3 = 0;
			int num4 = 7;
			int num5 = 4;
			if (num2 == 0)
			{
				num4 = 138;
				num5 = 3;
			}
			tree[(max_code + 1) * 2 + 1] = short.MaxValue;
			for (int i = 0; i <= max_code; i++)
			{
				int num6 = num2;
				num2 = (int)tree[(i + 1) * 2 + 1];
				if (++num3 >= num4 || num6 != num2)
				{
					if (num3 < num5)
					{
						this.bl_tree[num6 * 2] = (short)((int)this.bl_tree[num6 * 2] + num3);
					}
					else if (num6 != 0)
					{
						if (num6 != num)
						{
							short[] array = this.bl_tree;
							int num7 = num6 * 2;
							array[num7] += 1;
						}
						short[] array2 = this.bl_tree;
						int num8 = global::Ionic.Zlib.InternalConstants.REP_3_6 * 2;
						array2[num8] += 1;
					}
					else if (num3 <= 10)
					{
						short[] array3 = this.bl_tree;
						int num9 = global::Ionic.Zlib.InternalConstants.REPZ_3_10 * 2;
						array3[num9] += 1;
					}
					else
					{
						short[] array4 = this.bl_tree;
						int num10 = global::Ionic.Zlib.InternalConstants.REPZ_11_138 * 2;
						array4[num10] += 1;
					}
					num3 = 0;
					num = num6;
					if (num2 == 0)
					{
						num4 = 138;
						num5 = 3;
					}
					else if (num6 == num2)
					{
						num4 = 6;
						num5 = 3;
					}
					else
					{
						num4 = 7;
						num5 = 4;
					}
				}
			}
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x0009BDD8 File Offset: 0x00099FD8
		internal int build_bl_tree()
		{
			this.scan_tree(this.dyn_ltree, this.treeLiterals.max_code);
			this.scan_tree(this.dyn_dtree, this.treeDistances.max_code);
			this.treeBitLengths.build_tree(this);
			int num = global::Ionic.Zlib.InternalConstants.BL_CODES - 1;
			while (num >= 3 && this.bl_tree[(int)(global::Ionic.Zlib.Tree.bl_order[num] * 2 + 1)] == 0)
			{
				num--;
			}
			this.opt_len += 3 * (num + 1) + 5 + 5 + 4;
			return num;
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x0009BE68 File Offset: 0x0009A068
		internal void send_all_trees(int lcodes, int dcodes, int blcodes)
		{
			this.send_bits(lcodes - 257, 5);
			this.send_bits(dcodes - 1, 5);
			this.send_bits(blcodes - 4, 4);
			for (int i = 0; i < blcodes; i++)
			{
				this.send_bits((int)this.bl_tree[(int)(global::Ionic.Zlib.Tree.bl_order[i] * 2 + 1)], 3);
			}
			this.send_tree(this.dyn_ltree, lcodes - 1);
			this.send_tree(this.dyn_dtree, dcodes - 1);
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x0009BEE4 File Offset: 0x0009A0E4
		internal void send_tree(short[] tree, int max_code)
		{
			int num = -1;
			int num2 = (int)tree[1];
			int num3 = 0;
			int num4 = 7;
			int num5 = 4;
			if (num2 == 0)
			{
				num4 = 138;
				num5 = 3;
			}
			for (int i = 0; i <= max_code; i++)
			{
				int num6 = num2;
				num2 = (int)tree[(i + 1) * 2 + 1];
				if (++num3 >= num4 || num6 != num2)
				{
					if (num3 < num5)
					{
						do
						{
							this.send_code(num6, this.bl_tree);
						}
						while (--num3 != 0);
					}
					else if (num6 != 0)
					{
						if (num6 != num)
						{
							this.send_code(num6, this.bl_tree);
							num3--;
						}
						this.send_code(global::Ionic.Zlib.InternalConstants.REP_3_6, this.bl_tree);
						this.send_bits(num3 - 3, 2);
					}
					else if (num3 <= 10)
					{
						this.send_code(global::Ionic.Zlib.InternalConstants.REPZ_3_10, this.bl_tree);
						this.send_bits(num3 - 3, 3);
					}
					else
					{
						this.send_code(global::Ionic.Zlib.InternalConstants.REPZ_11_138, this.bl_tree);
						this.send_bits(num3 - 11, 7);
					}
					num3 = 0;
					num = num6;
					if (num2 == 0)
					{
						num4 = 138;
						num5 = 3;
					}
					else if (num6 == num2)
					{
						num4 = 6;
						num5 = 3;
					}
					else
					{
						num4 = 7;
						num5 = 4;
					}
				}
			}
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x0009C020 File Offset: 0x0009A220
		private void put_bytes(byte[] p, int start, int len)
		{
			global::System.Array.Copy(p, start, this.pending, this.pendingCount, len);
			this.pendingCount += len;
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x0009C044 File Offset: 0x0009A244
		internal void send_code(int c, short[] tree)
		{
			int num = c * 2;
			this.send_bits((int)tree[num] & 65535, (int)tree[num + 1] & 65535);
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x0009C074 File Offset: 0x0009A274
		internal void send_bits(int value, int length)
		{
			if (this.bi_valid > global::Ionic.Zlib.DeflateManager.Buf_size - length)
			{
				this.bi_buf |= (short)(value << this.bi_valid & 65535);
				byte[] array = this.pending;
				int num = this.pendingCount;
				this.pendingCount = num + 1;
				array[num] = (byte)this.bi_buf;
				byte[] array2 = this.pending;
				num = this.pendingCount;
				this.pendingCount = num + 1;
				array2[num] = (byte)(this.bi_buf >> 8);
				this.bi_buf = (short)((uint)value >> global::Ionic.Zlib.DeflateManager.Buf_size - this.bi_valid);
				this.bi_valid += length - global::Ionic.Zlib.DeflateManager.Buf_size;
				return;
			}
			this.bi_buf |= (short)(value << this.bi_valid & 65535);
			this.bi_valid += length;
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x0009C154 File Offset: 0x0009A354
		internal void _tr_align()
		{
			this.send_bits(global::Ionic.Zlib.DeflateManager.STATIC_TREES << 1, 3);
			this.send_code(global::Ionic.Zlib.DeflateManager.END_BLOCK, global::Ionic.Zlib.StaticTree.lengthAndLiteralsTreeCodes);
			this.bi_flush();
			if (1 + this.last_eob_len + 10 - this.bi_valid < 9)
			{
				this.send_bits(global::Ionic.Zlib.DeflateManager.STATIC_TREES << 1, 3);
				this.send_code(global::Ionic.Zlib.DeflateManager.END_BLOCK, global::Ionic.Zlib.StaticTree.lengthAndLiteralsTreeCodes);
				this.bi_flush();
			}
			this.last_eob_len = 7;
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x0009C1D0 File Offset: 0x0009A3D0
		internal bool _tr_tally(int dist, int lc)
		{
			this.pending[this._distanceOffset + this.last_lit * 2] = (byte)((uint)dist >> 8);
			this.pending[this._distanceOffset + this.last_lit * 2 + 1] = (byte)dist;
			this.pending[this._lengthOffset + this.last_lit] = (byte)lc;
			this.last_lit++;
			if (dist == 0)
			{
				short[] array = this.dyn_ltree;
				int num = lc * 2;
				array[num] += 1;
			}
			else
			{
				this.matches++;
				dist--;
				short[] array2 = this.dyn_ltree;
				int num2 = ((int)global::Ionic.Zlib.Tree.LengthCode[lc] + global::Ionic.Zlib.InternalConstants.LITERALS + 1) * 2;
				array2[num2] += 1;
				short[] array3 = this.dyn_dtree;
				int num3 = global::Ionic.Zlib.Tree.DistanceCode(dist) * 2;
				array3[num3] += 1;
			}
			if ((this.last_lit & 8191) == 0 && this.compressionLevel > global::Ionic.Zlib.CompressionLevel.Level2)
			{
				int num4 = this.last_lit << 3;
				int num5 = this.strstart - this.block_start;
				for (int i = 0; i < global::Ionic.Zlib.InternalConstants.D_CODES; i++)
				{
					num4 = (int)((long)num4 + (long)this.dyn_dtree[i * 2] * (5L + (long)global::Ionic.Zlib.Tree.ExtraDistanceBits[i]));
				}
				num4 >>= 3;
				if (this.matches < this.last_lit / 2 && num4 < num5 / 2)
				{
					return true;
				}
			}
			return this.last_lit == this.lit_bufsize - 1 || this.last_lit == this.lit_bufsize;
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x0009C350 File Offset: 0x0009A550
		internal void send_compressed_block(short[] ltree, short[] dtree)
		{
			int num = 0;
			if (this.last_lit != 0)
			{
				do
				{
					int num2 = this._distanceOffset + num * 2;
					int num3 = ((int)this.pending[num2] << 8 & 65280) | (int)(this.pending[num2 + 1] & byte.MaxValue);
					int num4 = (int)(this.pending[this._lengthOffset + num] & byte.MaxValue);
					num++;
					if (num3 == 0)
					{
						this.send_code(num4, ltree);
					}
					else
					{
						int num5 = (int)global::Ionic.Zlib.Tree.LengthCode[num4];
						this.send_code(num5 + global::Ionic.Zlib.InternalConstants.LITERALS + 1, ltree);
						int num6 = global::Ionic.Zlib.Tree.ExtraLengthBits[num5];
						if (num6 != 0)
						{
							num4 -= global::Ionic.Zlib.Tree.LengthBase[num5];
							this.send_bits(num4, num6);
						}
						num3--;
						num5 = global::Ionic.Zlib.Tree.DistanceCode(num3);
						this.send_code(num5, dtree);
						num6 = global::Ionic.Zlib.Tree.ExtraDistanceBits[num5];
						if (num6 != 0)
						{
							num3 -= global::Ionic.Zlib.Tree.DistanceBase[num5];
							this.send_bits(num3, num6);
						}
					}
				}
				while (num < this.last_lit);
			}
			this.send_code(global::Ionic.Zlib.DeflateManager.END_BLOCK, ltree);
			this.last_eob_len = (int)ltree[global::Ionic.Zlib.DeflateManager.END_BLOCK * 2 + 1];
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x0009C46C File Offset: 0x0009A66C
		internal void set_data_type()
		{
			int i = 0;
			int num = 0;
			int num2 = 0;
			while (i < 7)
			{
				num2 += (int)this.dyn_ltree[i * 2];
				i++;
			}
			while (i < 128)
			{
				num += (int)this.dyn_ltree[i * 2];
				i++;
			}
			while (i < global::Ionic.Zlib.InternalConstants.LITERALS)
			{
				num2 += (int)this.dyn_ltree[i * 2];
				i++;
			}
			this.data_type = (sbyte)((num2 > num >> 2) ? global::Ionic.Zlib.DeflateManager.Z_BINARY : global::Ionic.Zlib.DeflateManager.Z_ASCII);
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x0009C4F8 File Offset: 0x0009A6F8
		internal void bi_flush()
		{
			if (this.bi_valid == 16)
			{
				byte[] array = this.pending;
				int num = this.pendingCount;
				this.pendingCount = num + 1;
				array[num] = (byte)this.bi_buf;
				byte[] array2 = this.pending;
				num = this.pendingCount;
				this.pendingCount = num + 1;
				array2[num] = (byte)(this.bi_buf >> 8);
				this.bi_buf = 0;
				this.bi_valid = 0;
				return;
			}
			if (this.bi_valid >= 8)
			{
				byte[] array3 = this.pending;
				int num = this.pendingCount;
				this.pendingCount = num + 1;
				array3[num] = (byte)this.bi_buf;
				this.bi_buf = (short)(this.bi_buf >> 8);
				this.bi_valid -= 8;
			}
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x0009C5B0 File Offset: 0x0009A7B0
		internal void bi_windup()
		{
			if (this.bi_valid > 8)
			{
				byte[] array = this.pending;
				int num = this.pendingCount;
				this.pendingCount = num + 1;
				array[num] = (byte)this.bi_buf;
				byte[] array2 = this.pending;
				num = this.pendingCount;
				this.pendingCount = num + 1;
				array2[num] = (byte)(this.bi_buf >> 8);
			}
			else if (this.bi_valid > 0)
			{
				byte[] array3 = this.pending;
				int num = this.pendingCount;
				this.pendingCount = num + 1;
				array3[num] = (byte)this.bi_buf;
			}
			this.bi_buf = 0;
			this.bi_valid = 0;
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x0009C64C File Offset: 0x0009A84C
		internal void copy_block(int buf, int len, bool header)
		{
			this.bi_windup();
			this.last_eob_len = 8;
			if (header)
			{
				byte[] array = this.pending;
				int num = this.pendingCount;
				this.pendingCount = num + 1;
				array[num] = (byte)len;
				byte[] array2 = this.pending;
				num = this.pendingCount;
				this.pendingCount = num + 1;
				array2[num] = (byte)(len >> 8);
				byte[] array3 = this.pending;
				num = this.pendingCount;
				this.pendingCount = num + 1;
				array3[num] = (byte)(~(byte)len);
				byte[] array4 = this.pending;
				num = this.pendingCount;
				this.pendingCount = num + 1;
				array4[num] = (byte)(~len >> 8);
			}
			this.put_bytes(this.window, buf, len);
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x0009C6EC File Offset: 0x0009A8EC
		internal void flush_block_only(bool eof)
		{
			this._tr_flush_block((this.block_start >= 0) ? this.block_start : -1, this.strstart - this.block_start, eof);
			this.block_start = this.strstart;
			this._codec.flush_pending();
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x0009C740 File Offset: 0x0009A940
		internal global::Ionic.Zlib.BlockState DeflateNone(global::Ionic.Zlib.FlushType flush)
		{
			int num = 65535;
			if (num > this.pending.Length - 5)
			{
				num = this.pending.Length - 5;
			}
			for (;;)
			{
				if (this.lookahead <= 1)
				{
					this._fillWindow();
					if (this.lookahead == 0 && flush == global::Ionic.Zlib.FlushType.None)
					{
						break;
					}
					if (this.lookahead == 0)
					{
						goto IL_F0;
					}
				}
				this.strstart += this.lookahead;
				this.lookahead = 0;
				int num2 = this.block_start + num;
				if (this.strstart == 0 || this.strstart >= num2)
				{
					this.lookahead = this.strstart - num2;
					this.strstart = num2;
					this.flush_block_only(false);
					if (this._codec.AvailableBytesOut == 0)
					{
						return global::Ionic.Zlib.BlockState.NeedMore;
					}
				}
				if (this.strstart - this.block_start >= this.w_size - global::Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD)
				{
					this.flush_block_only(false);
					if (this._codec.AvailableBytesOut == 0)
					{
						return global::Ionic.Zlib.BlockState.NeedMore;
					}
				}
			}
			return global::Ionic.Zlib.BlockState.NeedMore;
			IL_F0:
			this.flush_block_only(flush == global::Ionic.Zlib.FlushType.Finish);
			if (this._codec.AvailableBytesOut == 0)
			{
				if (flush != global::Ionic.Zlib.FlushType.Finish)
				{
					return global::Ionic.Zlib.BlockState.NeedMore;
				}
				return global::Ionic.Zlib.BlockState.FinishStarted;
			}
			else
			{
				if (flush != global::Ionic.Zlib.FlushType.Finish)
				{
					return global::Ionic.Zlib.BlockState.BlockDone;
				}
				return global::Ionic.Zlib.BlockState.FinishDone;
			}
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x0009C870 File Offset: 0x0009AA70
		internal void _tr_stored_block(int buf, int stored_len, bool eof)
		{
			this.send_bits((global::Ionic.Zlib.DeflateManager.STORED_BLOCK << 1) + (eof ? 1 : 0), 3);
			this.copy_block(buf, stored_len, true);
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x0009C898 File Offset: 0x0009AA98
		internal void _tr_flush_block(int buf, int stored_len, bool eof)
		{
			int num = 0;
			int num2;
			int num3;
			if (this.compressionLevel > global::Ionic.Zlib.CompressionLevel.None)
			{
				if ((int)this.data_type == global::Ionic.Zlib.DeflateManager.Z_UNKNOWN)
				{
					this.set_data_type();
				}
				this.treeLiterals.build_tree(this);
				this.treeDistances.build_tree(this);
				num = this.build_bl_tree();
				num2 = this.opt_len + 3 + 7 >> 3;
				num3 = this.static_len + 3 + 7 >> 3;
				if (num3 <= num2)
				{
					num2 = num3;
				}
			}
			else
			{
				num3 = (num2 = stored_len + 5);
			}
			if (stored_len + 4 <= num2 && buf != -1)
			{
				this._tr_stored_block(buf, stored_len, eof);
			}
			else if (num3 == num2)
			{
				this.send_bits((global::Ionic.Zlib.DeflateManager.STATIC_TREES << 1) + (eof ? 1 : 0), 3);
				this.send_compressed_block(global::Ionic.Zlib.StaticTree.lengthAndLiteralsTreeCodes, global::Ionic.Zlib.StaticTree.distTreeCodes);
			}
			else
			{
				this.send_bits((global::Ionic.Zlib.DeflateManager.DYN_TREES << 1) + (eof ? 1 : 0), 3);
				this.send_all_trees(this.treeLiterals.max_code + 1, this.treeDistances.max_code + 1, num + 1);
				this.send_compressed_block(this.dyn_ltree, this.dyn_dtree);
			}
			this._InitializeBlocks();
			if (eof)
			{
				this.bi_windup();
			}
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x0009C9D4 File Offset: 0x0009ABD4
		private void _fillWindow()
		{
			for (;;)
			{
				int num = this.window_size - this.lookahead - this.strstart;
				int num2;
				if (num == 0 && this.strstart == 0 && this.lookahead == 0)
				{
					num = this.w_size;
				}
				else if (num == -1)
				{
					num--;
				}
				else if (this.strstart >= this.w_size + this.w_size - global::Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD)
				{
					global::System.Array.Copy(this.window, this.w_size, this.window, 0, this.w_size);
					this.match_start -= this.w_size;
					this.strstart -= this.w_size;
					this.block_start -= this.w_size;
					num2 = this.hash_size;
					int num3 = num2;
					do
					{
						int num4 = (int)this.head[--num3] & 65535;
						this.head[num3] = (short)((num4 >= this.w_size) ? (num4 - this.w_size) : 0);
					}
					while (--num2 != 0);
					num2 = this.w_size;
					num3 = num2;
					do
					{
						int num4 = (int)this.prev[--num3] & 65535;
						this.prev[num3] = (short)((num4 >= this.w_size) ? (num4 - this.w_size) : 0);
					}
					while (--num2 != 0);
					num += this.w_size;
				}
				if (this._codec.AvailableBytesIn == 0)
				{
					break;
				}
				num2 = this._codec.read_buf(this.window, this.strstart + this.lookahead, num);
				this.lookahead += num2;
				if (this.lookahead >= global::Ionic.Zlib.DeflateManager.MIN_MATCH)
				{
					this.ins_h = (int)(this.window[this.strstart] & byte.MaxValue);
					this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[this.strstart + 1] & byte.MaxValue)) & this.hash_mask);
				}
				if (this.lookahead >= global::Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD || this._codec.AvailableBytesIn == 0)
				{
					return;
				}
			}
		}

		// Token: 0x06002E26 RID: 11814 RVA: 0x0009CBF8 File Offset: 0x0009ADF8
		internal global::Ionic.Zlib.BlockState DeflateFast(global::Ionic.Zlib.FlushType flush)
		{
			int num = 0;
			for (;;)
			{
				if (this.lookahead < global::Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD)
				{
					this._fillWindow();
					if (this.lookahead < global::Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD && flush == global::Ionic.Zlib.FlushType.None)
					{
						break;
					}
					if (this.lookahead == 0)
					{
						goto IL_2FD;
					}
				}
				if (this.lookahead >= global::Ionic.Zlib.DeflateManager.MIN_MATCH)
				{
					this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[this.strstart + (global::Ionic.Zlib.DeflateManager.MIN_MATCH - 1)] & byte.MaxValue)) & this.hash_mask);
					num = ((int)this.head[this.ins_h] & 65535);
					this.prev[this.strstart & this.w_mask] = this.head[this.ins_h];
					this.head[this.ins_h] = (short)this.strstart;
				}
				if ((long)num != 0L && (this.strstart - num & 65535) <= this.w_size - global::Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD && this.compressionStrategy != global::Ionic.Zlib.CompressionStrategy.HuffmanOnly)
				{
					this.match_length = this.longest_match(num);
				}
				bool flag;
				if (this.match_length >= global::Ionic.Zlib.DeflateManager.MIN_MATCH)
				{
					flag = this._tr_tally(this.strstart - this.match_start, this.match_length - global::Ionic.Zlib.DeflateManager.MIN_MATCH);
					this.lookahead -= this.match_length;
					if (this.match_length <= this.config.MaxLazy && this.lookahead >= global::Ionic.Zlib.DeflateManager.MIN_MATCH)
					{
						this.match_length--;
						int num2;
						do
						{
							this.strstart++;
							this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[this.strstart + (global::Ionic.Zlib.DeflateManager.MIN_MATCH - 1)] & byte.MaxValue)) & this.hash_mask);
							num = ((int)this.head[this.ins_h] & 65535);
							this.prev[this.strstart & this.w_mask] = this.head[this.ins_h];
							this.head[this.ins_h] = (short)this.strstart;
							num2 = this.match_length - 1;
							this.match_length = num2;
						}
						while (num2 != 0);
						this.strstart++;
					}
					else
					{
						this.strstart += this.match_length;
						this.match_length = 0;
						this.ins_h = (int)(this.window[this.strstart] & byte.MaxValue);
						this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[this.strstart + 1] & byte.MaxValue)) & this.hash_mask);
					}
				}
				else
				{
					flag = this._tr_tally(0, (int)(this.window[this.strstart] & byte.MaxValue));
					this.lookahead--;
					this.strstart++;
				}
				if (flag)
				{
					this.flush_block_only(false);
					if (this._codec.AvailableBytesOut == 0)
					{
						return global::Ionic.Zlib.BlockState.NeedMore;
					}
				}
			}
			return global::Ionic.Zlib.BlockState.NeedMore;
			IL_2FD:
			this.flush_block_only(flush == global::Ionic.Zlib.FlushType.Finish);
			if (this._codec.AvailableBytesOut == 0)
			{
				if (flush == global::Ionic.Zlib.FlushType.Finish)
				{
					return global::Ionic.Zlib.BlockState.FinishStarted;
				}
				return global::Ionic.Zlib.BlockState.NeedMore;
			}
			else
			{
				if (flush != global::Ionic.Zlib.FlushType.Finish)
				{
					return global::Ionic.Zlib.BlockState.BlockDone;
				}
				return global::Ionic.Zlib.BlockState.FinishDone;
			}
		}

		// Token: 0x06002E27 RID: 11815 RVA: 0x0009CF38 File Offset: 0x0009B138
		internal global::Ionic.Zlib.BlockState DeflateSlow(global::Ionic.Zlib.FlushType flush)
		{
			int num = 0;
			for (;;)
			{
				if (this.lookahead < global::Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD)
				{
					this._fillWindow();
					if (this.lookahead < global::Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD && flush == global::Ionic.Zlib.FlushType.None)
					{
						break;
					}
					if (this.lookahead == 0)
					{
						goto IL_387;
					}
				}
				if (this.lookahead >= global::Ionic.Zlib.DeflateManager.MIN_MATCH)
				{
					this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[this.strstart + (global::Ionic.Zlib.DeflateManager.MIN_MATCH - 1)] & byte.MaxValue)) & this.hash_mask);
					num = ((int)this.head[this.ins_h] & 65535);
					this.prev[this.strstart & this.w_mask] = this.head[this.ins_h];
					this.head[this.ins_h] = (short)this.strstart;
				}
				this.prev_length = this.match_length;
				this.prev_match = this.match_start;
				this.match_length = global::Ionic.Zlib.DeflateManager.MIN_MATCH - 1;
				if (num != 0 && this.prev_length < this.config.MaxLazy && (this.strstart - num & 65535) <= this.w_size - global::Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD)
				{
					if (this.compressionStrategy != global::Ionic.Zlib.CompressionStrategy.HuffmanOnly)
					{
						this.match_length = this.longest_match(num);
					}
					if (this.match_length <= 5 && (this.compressionStrategy == global::Ionic.Zlib.CompressionStrategy.Filtered || (this.match_length == global::Ionic.Zlib.DeflateManager.MIN_MATCH && this.strstart - this.match_start > 4096)))
					{
						this.match_length = global::Ionic.Zlib.DeflateManager.MIN_MATCH - 1;
					}
				}
				if (this.prev_length >= global::Ionic.Zlib.DeflateManager.MIN_MATCH && this.match_length <= this.prev_length)
				{
					int num2 = this.strstart + this.lookahead - global::Ionic.Zlib.DeflateManager.MIN_MATCH;
					bool flag = this._tr_tally(this.strstart - 1 - this.prev_match, this.prev_length - global::Ionic.Zlib.DeflateManager.MIN_MATCH);
					this.lookahead -= this.prev_length - 1;
					this.prev_length -= 2;
					int num3;
					do
					{
						num3 = this.strstart + 1;
						this.strstart = num3;
						if (num3 <= num2)
						{
							this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[this.strstart + (global::Ionic.Zlib.DeflateManager.MIN_MATCH - 1)] & byte.MaxValue)) & this.hash_mask);
							num = ((int)this.head[this.ins_h] & 65535);
							this.prev[this.strstart & this.w_mask] = this.head[this.ins_h];
							this.head[this.ins_h] = (short)this.strstart;
						}
						num3 = this.prev_length - 1;
						this.prev_length = num3;
					}
					while (num3 != 0);
					this.match_available = 0;
					this.match_length = global::Ionic.Zlib.DeflateManager.MIN_MATCH - 1;
					this.strstart++;
					if (flag)
					{
						this.flush_block_only(false);
						if (this._codec.AvailableBytesOut == 0)
						{
							return global::Ionic.Zlib.BlockState.NeedMore;
						}
					}
				}
				else if (this.match_available != 0)
				{
					bool flag = this._tr_tally(0, (int)(this.window[this.strstart - 1] & byte.MaxValue));
					if (flag)
					{
						this.flush_block_only(false);
					}
					this.strstart++;
					this.lookahead--;
					if (this._codec.AvailableBytesOut == 0)
					{
						return global::Ionic.Zlib.BlockState.NeedMore;
					}
				}
				else
				{
					this.match_available = 1;
					this.strstart++;
					this.lookahead--;
				}
			}
			return global::Ionic.Zlib.BlockState.NeedMore;
			IL_387:
			if (this.match_available != 0)
			{
				bool flag = this._tr_tally(0, (int)(this.window[this.strstart - 1] & byte.MaxValue));
				this.match_available = 0;
			}
			this.flush_block_only(flush == global::Ionic.Zlib.FlushType.Finish);
			if (this._codec.AvailableBytesOut == 0)
			{
				if (flush == global::Ionic.Zlib.FlushType.Finish)
				{
					return global::Ionic.Zlib.BlockState.FinishStarted;
				}
				return global::Ionic.Zlib.BlockState.NeedMore;
			}
			else
			{
				if (flush != global::Ionic.Zlib.FlushType.Finish)
				{
					return global::Ionic.Zlib.BlockState.BlockDone;
				}
				return global::Ionic.Zlib.BlockState.FinishDone;
			}
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x0009D330 File Offset: 0x0009B530
		internal int longest_match(int cur_match)
		{
			int num = this.config.MaxChainLength;
			int num2 = this.strstart;
			int num3 = this.prev_length;
			int num4 = (this.strstart > this.w_size - global::Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD) ? (this.strstart - (this.w_size - global::Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD)) : 0;
			int niceLength = this.config.NiceLength;
			int num5 = this.w_mask;
			int num6 = this.strstart + global::Ionic.Zlib.DeflateManager.MAX_MATCH;
			byte b = this.window[num2 + num3 - 1];
			byte b2 = this.window[num2 + num3];
			if (this.prev_length >= this.config.GoodLength)
			{
				num >>= 2;
			}
			if (niceLength > this.lookahead)
			{
				niceLength = this.lookahead;
			}
			do
			{
				int num7 = cur_match;
				if (this.window[num7 + num3] == b2 && this.window[num7 + num3 - 1] == b && this.window[num7] == this.window[num2] && this.window[++num7] == this.window[num2 + 1])
				{
					num2 += 2;
					num7++;
					while (this.window[++num2] == this.window[++num7] && this.window[++num2] == this.window[++num7] && this.window[++num2] == this.window[++num7] && this.window[++num2] == this.window[++num7] && this.window[++num2] == this.window[++num7] && this.window[++num2] == this.window[++num7] && this.window[++num2] == this.window[++num7] && this.window[++num2] == this.window[++num7] && num2 < num6)
					{
					}
					int num8 = global::Ionic.Zlib.DeflateManager.MAX_MATCH - (num6 - num2);
					num2 = num6 - global::Ionic.Zlib.DeflateManager.MAX_MATCH;
					if (num8 > num3)
					{
						this.match_start = cur_match;
						num3 = num8;
						if (num8 >= niceLength)
						{
							break;
						}
						b = this.window[num2 + num3 - 1];
						b2 = this.window[num2 + num3];
					}
				}
			}
			while ((cur_match = ((int)this.prev[cur_match & num5] & 65535)) > num4 && --num != 0);
			if (num3 <= this.lookahead)
			{
				return num3;
			}
			return this.lookahead;
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06002E29 RID: 11817 RVA: 0x0009D5E0 File Offset: 0x0009B7E0
		// (set) Token: 0x06002E2A RID: 11818 RVA: 0x0009D5E8 File Offset: 0x0009B7E8
		internal bool WantRfc1950HeaderBytes
		{
			get
			{
				return this._WantRfc1950HeaderBytes;
			}
			set
			{
				this._WantRfc1950HeaderBytes = value;
			}
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x0009D5F4 File Offset: 0x0009B7F4
		internal int Initialize(global::Ionic.Zlib.ZlibCodec codec, global::Ionic.Zlib.CompressionLevel level)
		{
			return this.Initialize(codec, level, 15);
		}

		// Token: 0x06002E2C RID: 11820 RVA: 0x0009D600 File Offset: 0x0009B800
		internal int Initialize(global::Ionic.Zlib.ZlibCodec codec, global::Ionic.Zlib.CompressionLevel level, int bits)
		{
			return this.Initialize(codec, level, bits, global::Ionic.Zlib.DeflateManager.MEM_LEVEL_DEFAULT, global::Ionic.Zlib.CompressionStrategy.Default);
		}

		// Token: 0x06002E2D RID: 11821 RVA: 0x0009D614 File Offset: 0x0009B814
		internal int Initialize(global::Ionic.Zlib.ZlibCodec codec, global::Ionic.Zlib.CompressionLevel level, int bits, global::Ionic.Zlib.CompressionStrategy compressionStrategy)
		{
			return this.Initialize(codec, level, bits, global::Ionic.Zlib.DeflateManager.MEM_LEVEL_DEFAULT, compressionStrategy);
		}

		// Token: 0x06002E2E RID: 11822 RVA: 0x0009D628 File Offset: 0x0009B828
		internal int Initialize(global::Ionic.Zlib.ZlibCodec codec, global::Ionic.Zlib.CompressionLevel level, int windowBits, int memLevel, global::Ionic.Zlib.CompressionStrategy strategy)
		{
			this._codec = codec;
			this._codec.Message = null;
			if (windowBits < 9 || windowBits > 15)
			{
				throw new global::Ionic.Zlib.ZlibException("windowBits must be in the range 9..15.");
			}
			if (memLevel < 1 || memLevel > global::Ionic.Zlib.DeflateManager.MEM_LEVEL_MAX)
			{
				throw new global::Ionic.Zlib.ZlibException(string.Format("memLevel must be in the range 1.. {0}", global::Ionic.Zlib.DeflateManager.MEM_LEVEL_MAX));
			}
			this._codec.dstate = this;
			this.w_bits = windowBits;
			this.w_size = 1 << this.w_bits;
			this.w_mask = this.w_size - 1;
			this.hash_bits = memLevel + 7;
			this.hash_size = 1 << this.hash_bits;
			this.hash_mask = this.hash_size - 1;
			this.hash_shift = (this.hash_bits + global::Ionic.Zlib.DeflateManager.MIN_MATCH - 1) / global::Ionic.Zlib.DeflateManager.MIN_MATCH;
			this.window = new byte[this.w_size * 2];
			this.prev = new short[this.w_size];
			this.head = new short[this.hash_size];
			this.lit_bufsize = 1 << memLevel + 6;
			this.pending = new byte[this.lit_bufsize * 4];
			this._distanceOffset = this.lit_bufsize;
			this._lengthOffset = 3 * this.lit_bufsize;
			this.compressionLevel = level;
			this.compressionStrategy = strategy;
			this.Reset();
			return 0;
		}

		// Token: 0x06002E2F RID: 11823 RVA: 0x0009D794 File Offset: 0x0009B994
		internal void Reset()
		{
			this._codec.TotalBytesIn = (this._codec.TotalBytesOut = 0L);
			this._codec.Message = null;
			this.pendingCount = 0;
			this.nextPending = 0;
			this.Rfc1950BytesEmitted = false;
			this.status = (this.WantRfc1950HeaderBytes ? global::Ionic.Zlib.DeflateManager.INIT_STATE : global::Ionic.Zlib.DeflateManager.BUSY_STATE);
			this._codec._Adler32 = global::Ionic.Zlib.Adler.Adler32(0U, null, 0, 0);
			this.last_flush = 0;
			this._InitializeTreeData();
			this._InitializeLazyMatch();
		}

		// Token: 0x06002E30 RID: 11824 RVA: 0x0009D828 File Offset: 0x0009BA28
		internal int End()
		{
			if (this.status != global::Ionic.Zlib.DeflateManager.INIT_STATE && this.status != global::Ionic.Zlib.DeflateManager.BUSY_STATE && this.status != global::Ionic.Zlib.DeflateManager.FINISH_STATE)
			{
				return -2;
			}
			this.pending = null;
			this.head = null;
			this.prev = null;
			this.window = null;
			if (this.status != global::Ionic.Zlib.DeflateManager.BUSY_STATE)
			{
				return 0;
			}
			return -3;
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x0009D89C File Offset: 0x0009BA9C
		private void SetDeflater()
		{
			switch (this.config.Flavor)
			{
			case global::Ionic.Zlib.DeflateFlavor.Store:
				this.DeflateFunction = new global::Ionic.Zlib.DeflateManager.CompressFunc(this.DeflateNone);
				return;
			case global::Ionic.Zlib.DeflateFlavor.Fast:
				this.DeflateFunction = new global::Ionic.Zlib.DeflateManager.CompressFunc(this.DeflateFast);
				return;
			case global::Ionic.Zlib.DeflateFlavor.Slow:
				this.DeflateFunction = new global::Ionic.Zlib.DeflateManager.CompressFunc(this.DeflateSlow);
				return;
			default:
				return;
			}
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x0009D904 File Offset: 0x0009BB04
		internal int SetParams(global::Ionic.Zlib.CompressionLevel level, global::Ionic.Zlib.CompressionStrategy strategy)
		{
			int result = 0;
			if (this.compressionLevel != level)
			{
				global::Ionic.Zlib.DeflateManager.Config config = global::Ionic.Zlib.DeflateManager.Config.Lookup(level);
				if (config.Flavor != this.config.Flavor && this._codec.TotalBytesIn != 0L)
				{
					result = this._codec.Deflate(global::Ionic.Zlib.FlushType.Partial);
				}
				this.compressionLevel = level;
				this.config = config;
				this.SetDeflater();
			}
			this.compressionStrategy = strategy;
			return result;
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x0009D97C File Offset: 0x0009BB7C
		internal int SetDictionary(byte[] dictionary)
		{
			int num = dictionary.Length;
			int sourceIndex = 0;
			if (dictionary == null || this.status != global::Ionic.Zlib.DeflateManager.INIT_STATE)
			{
				throw new global::Ionic.Zlib.ZlibException("Stream error.");
			}
			this._codec._Adler32 = global::Ionic.Zlib.Adler.Adler32(this._codec._Adler32, dictionary, 0, dictionary.Length);
			if (num < global::Ionic.Zlib.DeflateManager.MIN_MATCH)
			{
				return 0;
			}
			if (num > this.w_size - global::Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD)
			{
				num = this.w_size - global::Ionic.Zlib.DeflateManager.MIN_LOOKAHEAD;
				sourceIndex = dictionary.Length - num;
			}
			global::System.Array.Copy(dictionary, sourceIndex, this.window, 0, num);
			this.strstart = num;
			this.block_start = num;
			this.ins_h = (int)(this.window[0] & byte.MaxValue);
			this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[1] & byte.MaxValue)) & this.hash_mask);
			for (int i = 0; i <= num - global::Ionic.Zlib.DeflateManager.MIN_MATCH; i++)
			{
				this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[i + (global::Ionic.Zlib.DeflateManager.MIN_MATCH - 1)] & byte.MaxValue)) & this.hash_mask);
				this.prev[i & this.w_mask] = this.head[this.ins_h];
				this.head[this.ins_h] = (short)i;
			}
			return 0;
		}

		// Token: 0x06002E34 RID: 11828 RVA: 0x0009DAD8 File Offset: 0x0009BCD8
		internal int Deflate(global::Ionic.Zlib.FlushType flush)
		{
			if (this._codec.OutputBuffer == null || (this._codec.InputBuffer == null && this._codec.AvailableBytesIn != 0))
			{
				this._codec.Message = global::Ionic.Zlib.DeflateManager._ErrorMessage[4];
				throw new global::Ionic.Zlib.ZlibException(string.Format("Something is fishy. [{0}]", this._codec.Message));
			}
			if (this.status == global::Ionic.Zlib.DeflateManager.FINISH_STATE && flush != global::Ionic.Zlib.FlushType.Finish && flush != global::Ionic.Zlib.FlushType.Sync)
			{
				this._codec.Message = "Deflate called while status is in FINISH_STATE while FlushType parameter is neither Finish or Sync";
				throw new global::Ionic.Zlib.ZlibException(string.Format("Software defect detected. [{0}]", this._codec.Message));
			}
			if (this._codec.AvailableBytesOut == 0)
			{
				this._codec.Message = global::Ionic.Zlib.DeflateManager._ErrorMessage[7];
				throw new global::Ionic.Zlib.ZlibException("OutputBuffer is full (AvailableBytesOut == 0)");
			}
			int num = this.last_flush;
			this.last_flush = (int)flush;
			int num4;
			if (this.status == global::Ionic.Zlib.DeflateManager.INIT_STATE)
			{
				int num2 = global::Ionic.Zlib.DeflateManager.Z_DEFLATED + (this.w_bits - 8 << 4) << 8;
				int num3 = (this.compressionLevel - global::Ionic.Zlib.CompressionLevel.BestSpeed & 255) >> 1;
				if (num3 > 3)
				{
					num3 = 3;
				}
				num2 |= num3 << 6;
				if (this.strstart != 0)
				{
					num2 |= global::Ionic.Zlib.DeflateManager.PRESET_DICT;
				}
				num2 += 31 - num2 % 31;
				this.status = global::Ionic.Zlib.DeflateManager.BUSY_STATE;
				byte[] array = this.pending;
				num4 = this.pendingCount;
				this.pendingCount = num4 + 1;
				array[num4] = (byte)(num2 >> 8);
				byte[] array2 = this.pending;
				num4 = this.pendingCount;
				this.pendingCount = num4 + 1;
				array2[num4] = (byte)num2;
				if (this.strstart != 0)
				{
					byte[] array3 = this.pending;
					num4 = this.pendingCount;
					this.pendingCount = num4 + 1;
					array3[num4] = (byte)((this._codec._Adler32 & 4278190080U) >> 24);
					byte[] array4 = this.pending;
					num4 = this.pendingCount;
					this.pendingCount = num4 + 1;
					array4[num4] = (byte)((this._codec._Adler32 & 16711680U) >> 16);
					byte[] array5 = this.pending;
					num4 = this.pendingCount;
					this.pendingCount = num4 + 1;
					array5[num4] = (byte)((this._codec._Adler32 & 65280U) >> 8);
					byte[] array6 = this.pending;
					num4 = this.pendingCount;
					this.pendingCount = num4 + 1;
					array6[num4] = (byte)(this._codec._Adler32 & 255U);
				}
				this._codec._Adler32 = global::Ionic.Zlib.Adler.Adler32(0U, null, 0, 0);
			}
			if (this.pendingCount != 0)
			{
				this._codec.flush_pending();
				if (this._codec.AvailableBytesOut == 0)
				{
					this.last_flush = -1;
					return 0;
				}
			}
			else if (this._codec.AvailableBytesIn == 0 && flush != global::Ionic.Zlib.FlushType.Finish && flush != global::Ionic.Zlib.FlushType.Sync && (flush != global::Ionic.Zlib.FlushType.Sync || this.lookahead <= 0))
			{
				return 0;
			}
			if (this.status == global::Ionic.Zlib.DeflateManager.FINISH_STATE && this._codec.AvailableBytesIn != 0)
			{
				this._codec.Message = global::Ionic.Zlib.DeflateManager._ErrorMessage[7];
				throw new global::Ionic.Zlib.ZlibException("status == FINISH_STATE && _codec.AvailableBytesIn != 0");
			}
			if (flush == global::Ionic.Zlib.FlushType.Sync && this._codec.AvailableBytesIn == 0 && this.lookahead == 0)
			{
				return 0;
			}
			if (this._codec.AvailableBytesIn != 0 || this.lookahead != 0 || (flush != global::Ionic.Zlib.FlushType.None && this.status != global::Ionic.Zlib.DeflateManager.FINISH_STATE))
			{
				global::Ionic.Zlib.BlockState blockState = this.DeflateFunction(flush);
				if (blockState == global::Ionic.Zlib.BlockState.FinishStarted || blockState == global::Ionic.Zlib.BlockState.FinishDone)
				{
					this.status = global::Ionic.Zlib.DeflateManager.FINISH_STATE;
				}
				if (blockState == global::Ionic.Zlib.BlockState.NeedMore || blockState == global::Ionic.Zlib.BlockState.FinishStarted)
				{
					if (this._codec.AvailableBytesOut == 0)
					{
						this.last_flush = -1;
					}
					return 0;
				}
				if (blockState == global::Ionic.Zlib.BlockState.BlockDone)
				{
					if (flush == global::Ionic.Zlib.FlushType.Partial)
					{
						this._tr_align();
					}
					else
					{
						this._tr_stored_block(0, 0, false);
						if (flush == global::Ionic.Zlib.FlushType.Full)
						{
							for (int i = 0; i < this.hash_size; i++)
							{
								this.head[i] = 0;
							}
						}
					}
					this._codec.flush_pending();
					if (this._codec.AvailableBytesOut == 0)
					{
						this.last_flush = -1;
						return 0;
					}
				}
			}
			if (flush != global::Ionic.Zlib.FlushType.Finish)
			{
				return 0;
			}
			if (!this.WantRfc1950HeaderBytes || this.Rfc1950BytesEmitted)
			{
				return 1;
			}
			byte[] array7 = this.pending;
			num4 = this.pendingCount;
			this.pendingCount = num4 + 1;
			array7[num4] = (byte)((this._codec._Adler32 & 4278190080U) >> 24);
			byte[] array8 = this.pending;
			num4 = this.pendingCount;
			this.pendingCount = num4 + 1;
			array8[num4] = (byte)((this._codec._Adler32 & 16711680U) >> 16);
			byte[] array9 = this.pending;
			num4 = this.pendingCount;
			this.pendingCount = num4 + 1;
			array9[num4] = (byte)((this._codec._Adler32 & 65280U) >> 8);
			byte[] array10 = this.pending;
			num4 = this.pendingCount;
			this.pendingCount = num4 + 1;
			array10[num4] = (byte)(this._codec._Adler32 & 255U);
			this._codec.flush_pending();
			this.Rfc1950BytesEmitted = true;
			if (this.pendingCount == 0)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x04000FA3 RID: 4003
		private static readonly int MEM_LEVEL_MAX = 9;

		// Token: 0x04000FA4 RID: 4004
		private static readonly int MEM_LEVEL_DEFAULT = 8;

		// Token: 0x04000FA5 RID: 4005
		private global::Ionic.Zlib.DeflateManager.CompressFunc DeflateFunction;

		// Token: 0x04000FA6 RID: 4006
		private static readonly string[] _ErrorMessage = new string[]
		{
			"need dictionary",
			"stream end",
			"",
			"file error",
			"stream error",
			"data error",
			"insufficient memory",
			"buffer error",
			"incompatible version",
			""
		};

		// Token: 0x04000FA7 RID: 4007
		private static readonly int PRESET_DICT = 32;

		// Token: 0x04000FA8 RID: 4008
		private static readonly int INIT_STATE = 42;

		// Token: 0x04000FA9 RID: 4009
		private static readonly int BUSY_STATE = 113;

		// Token: 0x04000FAA RID: 4010
		private static readonly int FINISH_STATE = 666;

		// Token: 0x04000FAB RID: 4011
		private static readonly int Z_DEFLATED = 8;

		// Token: 0x04000FAC RID: 4012
		private static readonly int STORED_BLOCK = 0;

		// Token: 0x04000FAD RID: 4013
		private static readonly int STATIC_TREES = 1;

		// Token: 0x04000FAE RID: 4014
		private static readonly int DYN_TREES = 2;

		// Token: 0x04000FAF RID: 4015
		private static readonly int Z_BINARY = 0;

		// Token: 0x04000FB0 RID: 4016
		private static readonly int Z_ASCII = 1;

		// Token: 0x04000FB1 RID: 4017
		private static readonly int Z_UNKNOWN = 2;

		// Token: 0x04000FB2 RID: 4018
		private static readonly int Buf_size = 16;

		// Token: 0x04000FB3 RID: 4019
		private static readonly int MIN_MATCH = 3;

		// Token: 0x04000FB4 RID: 4020
		private static readonly int MAX_MATCH = 258;

		// Token: 0x04000FB5 RID: 4021
		private static readonly int MIN_LOOKAHEAD = global::Ionic.Zlib.DeflateManager.MAX_MATCH + global::Ionic.Zlib.DeflateManager.MIN_MATCH + 1;

		// Token: 0x04000FB6 RID: 4022
		private static readonly int HEAP_SIZE = 2 * global::Ionic.Zlib.InternalConstants.L_CODES + 1;

		// Token: 0x04000FB7 RID: 4023
		private static readonly int END_BLOCK = 256;

		// Token: 0x04000FB8 RID: 4024
		internal global::Ionic.Zlib.ZlibCodec _codec;

		// Token: 0x04000FB9 RID: 4025
		internal int status;

		// Token: 0x04000FBA RID: 4026
		internal byte[] pending;

		// Token: 0x04000FBB RID: 4027
		internal int nextPending;

		// Token: 0x04000FBC RID: 4028
		internal int pendingCount;

		// Token: 0x04000FBD RID: 4029
		internal sbyte data_type;

		// Token: 0x04000FBE RID: 4030
		internal int last_flush;

		// Token: 0x04000FBF RID: 4031
		internal int w_size;

		// Token: 0x04000FC0 RID: 4032
		internal int w_bits;

		// Token: 0x04000FC1 RID: 4033
		internal int w_mask;

		// Token: 0x04000FC2 RID: 4034
		internal byte[] window;

		// Token: 0x04000FC3 RID: 4035
		internal int window_size;

		// Token: 0x04000FC4 RID: 4036
		internal short[] prev;

		// Token: 0x04000FC5 RID: 4037
		internal short[] head;

		// Token: 0x04000FC6 RID: 4038
		internal int ins_h;

		// Token: 0x04000FC7 RID: 4039
		internal int hash_size;

		// Token: 0x04000FC8 RID: 4040
		internal int hash_bits;

		// Token: 0x04000FC9 RID: 4041
		internal int hash_mask;

		// Token: 0x04000FCA RID: 4042
		internal int hash_shift;

		// Token: 0x04000FCB RID: 4043
		internal int block_start;

		// Token: 0x04000FCC RID: 4044
		private global::Ionic.Zlib.DeflateManager.Config config;

		// Token: 0x04000FCD RID: 4045
		internal int match_length;

		// Token: 0x04000FCE RID: 4046
		internal int prev_match;

		// Token: 0x04000FCF RID: 4047
		internal int match_available;

		// Token: 0x04000FD0 RID: 4048
		internal int strstart;

		// Token: 0x04000FD1 RID: 4049
		internal int match_start;

		// Token: 0x04000FD2 RID: 4050
		internal int lookahead;

		// Token: 0x04000FD3 RID: 4051
		internal int prev_length;

		// Token: 0x04000FD4 RID: 4052
		internal global::Ionic.Zlib.CompressionLevel compressionLevel;

		// Token: 0x04000FD5 RID: 4053
		internal global::Ionic.Zlib.CompressionStrategy compressionStrategy;

		// Token: 0x04000FD6 RID: 4054
		internal short[] dyn_ltree;

		// Token: 0x04000FD7 RID: 4055
		internal short[] dyn_dtree;

		// Token: 0x04000FD8 RID: 4056
		internal short[] bl_tree;

		// Token: 0x04000FD9 RID: 4057
		internal global::Ionic.Zlib.Tree treeLiterals = new global::Ionic.Zlib.Tree();

		// Token: 0x04000FDA RID: 4058
		internal global::Ionic.Zlib.Tree treeDistances = new global::Ionic.Zlib.Tree();

		// Token: 0x04000FDB RID: 4059
		internal global::Ionic.Zlib.Tree treeBitLengths = new global::Ionic.Zlib.Tree();

		// Token: 0x04000FDC RID: 4060
		internal short[] bl_count = new short[global::Ionic.Zlib.InternalConstants.MAX_BITS + 1];

		// Token: 0x04000FDD RID: 4061
		internal int[] heap = new int[2 * global::Ionic.Zlib.InternalConstants.L_CODES + 1];

		// Token: 0x04000FDE RID: 4062
		internal int heap_len;

		// Token: 0x04000FDF RID: 4063
		internal int heap_max;

		// Token: 0x04000FE0 RID: 4064
		internal sbyte[] depth = new sbyte[2 * global::Ionic.Zlib.InternalConstants.L_CODES + 1];

		// Token: 0x04000FE1 RID: 4065
		internal int _lengthOffset;

		// Token: 0x04000FE2 RID: 4066
		internal int lit_bufsize;

		// Token: 0x04000FE3 RID: 4067
		internal int last_lit;

		// Token: 0x04000FE4 RID: 4068
		internal int _distanceOffset;

		// Token: 0x04000FE5 RID: 4069
		internal int opt_len;

		// Token: 0x04000FE6 RID: 4070
		internal int static_len;

		// Token: 0x04000FE7 RID: 4071
		internal int matches;

		// Token: 0x04000FE8 RID: 4072
		internal int last_eob_len;

		// Token: 0x04000FE9 RID: 4073
		internal short bi_buf;

		// Token: 0x04000FEA RID: 4074
		internal int bi_valid;

		// Token: 0x04000FEB RID: 4075
		private bool Rfc1950BytesEmitted;

		// Token: 0x04000FEC RID: 4076
		private bool _WantRfc1950HeaderBytes = true;

		// Token: 0x020004DB RID: 1243
		// (Invoke) Token: 0x06003476 RID: 13430
		internal delegate global::Ionic.Zlib.BlockState CompressFunc(global::Ionic.Zlib.FlushType flush);

		// Token: 0x020004DC RID: 1244
		internal class Config
		{
			// Token: 0x06003479 RID: 13433 RVA: 0x000BC938 File Offset: 0x000BAB38
			private Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, global::Ionic.Zlib.DeflateFlavor flavor)
			{
				this.GoodLength = goodLength;
				this.MaxLazy = maxLazy;
				this.NiceLength = niceLength;
				this.MaxChainLength = maxChainLength;
				this.Flavor = flavor;
			}

			// Token: 0x0600347A RID: 13434 RVA: 0x000BC968 File Offset: 0x000BAB68
			public static global::Ionic.Zlib.DeflateManager.Config Lookup(global::Ionic.Zlib.CompressionLevel level)
			{
				return global::Ionic.Zlib.DeflateManager.Config.Table[(int)level];
			}

			// Token: 0x040013EC RID: 5100
			internal int GoodLength;

			// Token: 0x040013ED RID: 5101
			internal int MaxLazy;

			// Token: 0x040013EE RID: 5102
			internal int NiceLength;

			// Token: 0x040013EF RID: 5103
			internal int MaxChainLength;

			// Token: 0x040013F0 RID: 5104
			internal global::Ionic.Zlib.DeflateFlavor Flavor;

			// Token: 0x040013F1 RID: 5105
			private static readonly global::Ionic.Zlib.DeflateManager.Config[] Table = new global::Ionic.Zlib.DeflateManager.Config[]
			{
				new global::Ionic.Zlib.DeflateManager.Config(0, 0, 0, 0, global::Ionic.Zlib.DeflateFlavor.Store),
				new global::Ionic.Zlib.DeflateManager.Config(4, 4, 8, 4, global::Ionic.Zlib.DeflateFlavor.Fast),
				new global::Ionic.Zlib.DeflateManager.Config(4, 5, 16, 8, global::Ionic.Zlib.DeflateFlavor.Fast),
				new global::Ionic.Zlib.DeflateManager.Config(4, 6, 32, 32, global::Ionic.Zlib.DeflateFlavor.Fast),
				new global::Ionic.Zlib.DeflateManager.Config(4, 4, 16, 16, global::Ionic.Zlib.DeflateFlavor.Slow),
				new global::Ionic.Zlib.DeflateManager.Config(8, 16, 32, 32, global::Ionic.Zlib.DeflateFlavor.Slow),
				new global::Ionic.Zlib.DeflateManager.Config(8, 16, 128, 128, global::Ionic.Zlib.DeflateFlavor.Slow),
				new global::Ionic.Zlib.DeflateManager.Config(8, 32, 128, 256, global::Ionic.Zlib.DeflateFlavor.Slow),
				new global::Ionic.Zlib.DeflateManager.Config(32, 128, 258, 1024, global::Ionic.Zlib.DeflateFlavor.Slow),
				new global::Ionic.Zlib.DeflateManager.Config(32, 258, 258, 4096, global::Ionic.Zlib.DeflateFlavor.Slow)
			};
		}
	}
}
