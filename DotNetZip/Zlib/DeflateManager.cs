using System;

namespace Ionic.Zlib
{
	// Token: 0x02000010 RID: 16
	internal sealed class DeflateManager
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00003AA0 File Offset: 0x00001CA0
		internal DeflateManager()
		{
			this.dyn_ltree = new short[global::Ionic.Zlib.DeflateManager.HEAP_SIZE * 2];
			this.dyn_dtree = new short[(2 * global::Ionic.Zlib.InternalConstants.D_CODES + 1) * 2];
			this.bl_tree = new short[(2 * global::Ionic.Zlib.InternalConstants.BL_CODES + 1) * 2];
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003B54 File Offset: 0x00001D54
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

		// Token: 0x06000041 RID: 65 RVA: 0x00003BD4 File Offset: 0x00001DD4
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

		// Token: 0x06000042 RID: 66 RVA: 0x00003C60 File Offset: 0x00001E60
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

		// Token: 0x06000043 RID: 67 RVA: 0x00003CF0 File Offset: 0x00001EF0
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

		// Token: 0x06000044 RID: 68 RVA: 0x00003D7C File Offset: 0x00001F7C
		internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth)
		{
			short num = tree[n * 2];
			short num2 = tree[m * 2];
			return num < num2 || (num == num2 && depth[n] <= depth[m]);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003DAC File Offset: 0x00001FAC
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

		// Token: 0x06000046 RID: 70 RVA: 0x00003EC8 File Offset: 0x000020C8
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

		// Token: 0x06000047 RID: 71 RVA: 0x00003F50 File Offset: 0x00002150
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

		// Token: 0x06000048 RID: 72 RVA: 0x00003FC4 File Offset: 0x000021C4
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

		// Token: 0x06000049 RID: 73 RVA: 0x000040DA File Offset: 0x000022DA
		private void put_bytes(byte[] p, int start, int len)
		{
			global::System.Array.Copy(p, start, this.pending, this.pendingCount, len);
			this.pendingCount += len;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004100 File Offset: 0x00002300
		internal void send_code(int c, short[] tree)
		{
			int num = c * 2;
			this.send_bits((int)tree[num] & 65535, (int)tree[num + 1] & 65535);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000412C File Offset: 0x0000232C
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

		// Token: 0x0600004C RID: 76 RVA: 0x00004208 File Offset: 0x00002408
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

		// Token: 0x0600004D RID: 77 RVA: 0x0000427C File Offset: 0x0000247C
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

		// Token: 0x0600004E RID: 78 RVA: 0x000043E0 File Offset: 0x000025E0
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

		// Token: 0x0600004F RID: 79 RVA: 0x000044E8 File Offset: 0x000026E8
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

		// Token: 0x06000050 RID: 80 RVA: 0x00004564 File Offset: 0x00002764
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

		// Token: 0x06000051 RID: 81 RVA: 0x00004610 File Offset: 0x00002810
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

		// Token: 0x06000052 RID: 82 RVA: 0x000046A0 File Offset: 0x000028A0
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

		// Token: 0x06000053 RID: 83 RVA: 0x00004739 File Offset: 0x00002939
		internal void flush_block_only(bool eof)
		{
			this._tr_flush_block((this.block_start >= 0) ? this.block_start : -1, this.strstart - this.block_start, eof);
			this.block_start = this.strstart;
			this._codec.flush_pending();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004778 File Offset: 0x00002978
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
						goto IL_DB;
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
			IL_DB:
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

		// Token: 0x06000055 RID: 85 RVA: 0x00004886 File Offset: 0x00002A86
		internal void _tr_stored_block(int buf, int stored_len, bool eof)
		{
			this.send_bits((global::Ionic.Zlib.DeflateManager.STORED_BLOCK << 1) + (eof ? 1 : 0), 3);
			this.copy_block(buf, stored_len, true);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000048A8 File Offset: 0x00002AA8
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

		// Token: 0x06000057 RID: 87 RVA: 0x000049B8 File Offset: 0x00002BB8
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

		// Token: 0x06000058 RID: 88 RVA: 0x00004BB8 File Offset: 0x00002DB8
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
						goto IL_2E8;
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
			IL_2E8:
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

		// Token: 0x06000059 RID: 89 RVA: 0x00004ED4 File Offset: 0x000030D4
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
						goto IL_363;
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
			IL_363:
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

		// Token: 0x0600005A RID: 90 RVA: 0x00005298 File Offset: 0x00003498
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

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600005B RID: 91 RVA: 0x0000550E File Offset: 0x0000370E
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00005516 File Offset: 0x00003716
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

		// Token: 0x0600005D RID: 93 RVA: 0x0000551F File Offset: 0x0000371F
		internal int Initialize(global::Ionic.Zlib.ZlibCodec codec, global::Ionic.Zlib.CompressionLevel level)
		{
			return this.Initialize(codec, level, 15);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000552B File Offset: 0x0000372B
		internal int Initialize(global::Ionic.Zlib.ZlibCodec codec, global::Ionic.Zlib.CompressionLevel level, int bits)
		{
			return this.Initialize(codec, level, bits, global::Ionic.Zlib.DeflateManager.MEM_LEVEL_DEFAULT, global::Ionic.Zlib.CompressionStrategy.Default);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000553C File Offset: 0x0000373C
		internal int Initialize(global::Ionic.Zlib.ZlibCodec codec, global::Ionic.Zlib.CompressionLevel level, int bits, global::Ionic.Zlib.CompressionStrategy compressionStrategy)
		{
			return this.Initialize(codec, level, bits, global::Ionic.Zlib.DeflateManager.MEM_LEVEL_DEFAULT, compressionStrategy);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00005550 File Offset: 0x00003750
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

		// Token: 0x06000061 RID: 97 RVA: 0x000056AC File Offset: 0x000038AC
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

		// Token: 0x06000062 RID: 98 RVA: 0x00005738 File Offset: 0x00003938
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

		// Token: 0x06000063 RID: 99 RVA: 0x0000579C File Offset: 0x0000399C
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

		// Token: 0x06000064 RID: 100 RVA: 0x00005800 File Offset: 0x00003A00
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

		// Token: 0x06000065 RID: 101 RVA: 0x00005868 File Offset: 0x00003A68
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

		// Token: 0x06000066 RID: 102 RVA: 0x000059B4 File Offset: 0x00003BB4
		internal int Deflate(global::Ionic.Zlib.FlushType flush)
		{
			if (this._codec.OutputBuffer == null || (this._codec.InputBuffer == null && this._codec.AvailableBytesIn != 0) || (this.status == global::Ionic.Zlib.DeflateManager.FINISH_STATE && flush != global::Ionic.Zlib.FlushType.Finish))
			{
				this._codec.Message = global::Ionic.Zlib.DeflateManager._ErrorMessage[4];
				throw new global::Ionic.Zlib.ZlibException(string.Format("Something is fishy. [{0}]", this._codec.Message));
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
			else if (this._codec.AvailableBytesIn == 0 && flush <= (global::Ionic.Zlib.FlushType)num && flush != global::Ionic.Zlib.FlushType.Finish)
			{
				return 0;
			}
			if (this.status == global::Ionic.Zlib.DeflateManager.FINISH_STATE && this._codec.AvailableBytesIn != 0)
			{
				this._codec.Message = global::Ionic.Zlib.DeflateManager._ErrorMessage[7];
				throw new global::Ionic.Zlib.ZlibException("status == FINISH_STATE && _codec.AvailableBytesIn != 0");
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

		// Token: 0x0400002D RID: 45
		private static readonly int MEM_LEVEL_MAX = 9;

		// Token: 0x0400002E RID: 46
		private static readonly int MEM_LEVEL_DEFAULT = 8;

		// Token: 0x0400002F RID: 47
		private global::Ionic.Zlib.DeflateManager.CompressFunc DeflateFunction;

		// Token: 0x04000030 RID: 48
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

		// Token: 0x04000031 RID: 49
		private static readonly int PRESET_DICT = 32;

		// Token: 0x04000032 RID: 50
		private static readonly int INIT_STATE = 42;

		// Token: 0x04000033 RID: 51
		private static readonly int BUSY_STATE = 113;

		// Token: 0x04000034 RID: 52
		private static readonly int FINISH_STATE = 666;

		// Token: 0x04000035 RID: 53
		private static readonly int Z_DEFLATED = 8;

		// Token: 0x04000036 RID: 54
		private static readonly int STORED_BLOCK = 0;

		// Token: 0x04000037 RID: 55
		private static readonly int STATIC_TREES = 1;

		// Token: 0x04000038 RID: 56
		private static readonly int DYN_TREES = 2;

		// Token: 0x04000039 RID: 57
		private static readonly int Z_BINARY = 0;

		// Token: 0x0400003A RID: 58
		private static readonly int Z_ASCII = 1;

		// Token: 0x0400003B RID: 59
		private static readonly int Z_UNKNOWN = 2;

		// Token: 0x0400003C RID: 60
		private static readonly int Buf_size = 16;

		// Token: 0x0400003D RID: 61
		private static readonly int MIN_MATCH = 3;

		// Token: 0x0400003E RID: 62
		private static readonly int MAX_MATCH = 258;

		// Token: 0x0400003F RID: 63
		private static readonly int MIN_LOOKAHEAD = global::Ionic.Zlib.DeflateManager.MAX_MATCH + global::Ionic.Zlib.DeflateManager.MIN_MATCH + 1;

		// Token: 0x04000040 RID: 64
		private static readonly int HEAP_SIZE = 2 * global::Ionic.Zlib.InternalConstants.L_CODES + 1;

		// Token: 0x04000041 RID: 65
		private static readonly int END_BLOCK = 256;

		// Token: 0x04000042 RID: 66
		internal global::Ionic.Zlib.ZlibCodec _codec;

		// Token: 0x04000043 RID: 67
		internal int status;

		// Token: 0x04000044 RID: 68
		internal byte[] pending;

		// Token: 0x04000045 RID: 69
		internal int nextPending;

		// Token: 0x04000046 RID: 70
		internal int pendingCount;

		// Token: 0x04000047 RID: 71
		internal sbyte data_type;

		// Token: 0x04000048 RID: 72
		internal int last_flush;

		// Token: 0x04000049 RID: 73
		internal int w_size;

		// Token: 0x0400004A RID: 74
		internal int w_bits;

		// Token: 0x0400004B RID: 75
		internal int w_mask;

		// Token: 0x0400004C RID: 76
		internal byte[] window;

		// Token: 0x0400004D RID: 77
		internal int window_size;

		// Token: 0x0400004E RID: 78
		internal short[] prev;

		// Token: 0x0400004F RID: 79
		internal short[] head;

		// Token: 0x04000050 RID: 80
		internal int ins_h;

		// Token: 0x04000051 RID: 81
		internal int hash_size;

		// Token: 0x04000052 RID: 82
		internal int hash_bits;

		// Token: 0x04000053 RID: 83
		internal int hash_mask;

		// Token: 0x04000054 RID: 84
		internal int hash_shift;

		// Token: 0x04000055 RID: 85
		internal int block_start;

		// Token: 0x04000056 RID: 86
		private global::Ionic.Zlib.DeflateManager.Config config;

		// Token: 0x04000057 RID: 87
		internal int match_length;

		// Token: 0x04000058 RID: 88
		internal int prev_match;

		// Token: 0x04000059 RID: 89
		internal int match_available;

		// Token: 0x0400005A RID: 90
		internal int strstart;

		// Token: 0x0400005B RID: 91
		internal int match_start;

		// Token: 0x0400005C RID: 92
		internal int lookahead;

		// Token: 0x0400005D RID: 93
		internal int prev_length;

		// Token: 0x0400005E RID: 94
		internal global::Ionic.Zlib.CompressionLevel compressionLevel;

		// Token: 0x0400005F RID: 95
		internal global::Ionic.Zlib.CompressionStrategy compressionStrategy;

		// Token: 0x04000060 RID: 96
		internal short[] dyn_ltree;

		// Token: 0x04000061 RID: 97
		internal short[] dyn_dtree;

		// Token: 0x04000062 RID: 98
		internal short[] bl_tree;

		// Token: 0x04000063 RID: 99
		internal global::Ionic.Zlib.Tree treeLiterals = new global::Ionic.Zlib.Tree();

		// Token: 0x04000064 RID: 100
		internal global::Ionic.Zlib.Tree treeDistances = new global::Ionic.Zlib.Tree();

		// Token: 0x04000065 RID: 101
		internal global::Ionic.Zlib.Tree treeBitLengths = new global::Ionic.Zlib.Tree();

		// Token: 0x04000066 RID: 102
		internal short[] bl_count = new short[global::Ionic.Zlib.InternalConstants.MAX_BITS + 1];

		// Token: 0x04000067 RID: 103
		internal int[] heap = new int[2 * global::Ionic.Zlib.InternalConstants.L_CODES + 1];

		// Token: 0x04000068 RID: 104
		internal int heap_len;

		// Token: 0x04000069 RID: 105
		internal int heap_max;

		// Token: 0x0400006A RID: 106
		internal sbyte[] depth = new sbyte[2 * global::Ionic.Zlib.InternalConstants.L_CODES + 1];

		// Token: 0x0400006B RID: 107
		internal int _lengthOffset;

		// Token: 0x0400006C RID: 108
		internal int lit_bufsize;

		// Token: 0x0400006D RID: 109
		internal int last_lit;

		// Token: 0x0400006E RID: 110
		internal int _distanceOffset;

		// Token: 0x0400006F RID: 111
		internal int opt_len;

		// Token: 0x04000070 RID: 112
		internal int static_len;

		// Token: 0x04000071 RID: 113
		internal int matches;

		// Token: 0x04000072 RID: 114
		internal int last_eob_len;

		// Token: 0x04000073 RID: 115
		internal short bi_buf;

		// Token: 0x04000074 RID: 116
		internal int bi_valid;

		// Token: 0x04000075 RID: 117
		private bool Rfc1950BytesEmitted;

		// Token: 0x04000076 RID: 118
		private bool _WantRfc1950HeaderBytes = true;

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x06000547 RID: 1351
		internal delegate global::Ionic.Zlib.BlockState CompressFunc(global::Ionic.Zlib.FlushType flush);

		// Token: 0x0200006E RID: 110
		internal class Config
		{
			// Token: 0x0600054A RID: 1354 RVA: 0x0002080E File Offset: 0x0001EA0E
			private Config(int goodLength, int maxLazy, int niceLength, int maxChainLength, global::Ionic.Zlib.DeflateFlavor flavor)
			{
				this.GoodLength = goodLength;
				this.MaxLazy = maxLazy;
				this.NiceLength = niceLength;
				this.MaxChainLength = maxChainLength;
				this.Flavor = flavor;
			}

			// Token: 0x0600054B RID: 1355 RVA: 0x0002083B File Offset: 0x0001EA3B
			public static global::Ionic.Zlib.DeflateManager.Config Lookup(global::Ionic.Zlib.CompressionLevel level)
			{
				return global::Ionic.Zlib.DeflateManager.Config.Table[(int)level];
			}

			// Token: 0x040003D7 RID: 983
			internal int GoodLength;

			// Token: 0x040003D8 RID: 984
			internal int MaxLazy;

			// Token: 0x040003D9 RID: 985
			internal int NiceLength;

			// Token: 0x040003DA RID: 986
			internal int MaxChainLength;

			// Token: 0x040003DB RID: 987
			internal global::Ionic.Zlib.DeflateFlavor Flavor;

			// Token: 0x040003DC RID: 988
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
