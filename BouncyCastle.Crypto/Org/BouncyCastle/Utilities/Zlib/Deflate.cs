using System;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x0200003E RID: 62
	public sealed class Deflate
	{
		// Token: 0x060002C2 RID: 706 RVA: 0x0000CD4C File Offset: 0x0000AF4C
		static Deflate()
		{
			global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table = new global::Org.BouncyCastle.Utilities.Zlib.Deflate.Config[10];
			global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[0] = new global::Org.BouncyCastle.Utilities.Zlib.Deflate.Config(0, 0, 0, 0, 0);
			global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[1] = new global::Org.BouncyCastle.Utilities.Zlib.Deflate.Config(4, 4, 8, 4, 1);
			global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[2] = new global::Org.BouncyCastle.Utilities.Zlib.Deflate.Config(4, 5, 16, 8, 1);
			global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[3] = new global::Org.BouncyCastle.Utilities.Zlib.Deflate.Config(4, 6, 32, 32, 1);
			global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[4] = new global::Org.BouncyCastle.Utilities.Zlib.Deflate.Config(4, 4, 16, 16, 2);
			global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[5] = new global::Org.BouncyCastle.Utilities.Zlib.Deflate.Config(8, 16, 32, 32, 2);
			global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[6] = new global::Org.BouncyCastle.Utilities.Zlib.Deflate.Config(8, 16, 128, 128, 2);
			global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[7] = new global::Org.BouncyCastle.Utilities.Zlib.Deflate.Config(8, 32, 128, 256, 2);
			global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[8] = new global::Org.BouncyCastle.Utilities.Zlib.Deflate.Config(32, 128, 258, 1024, 2);
			global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[9] = new global::Org.BouncyCastle.Utilities.Zlib.Deflate.Config(32, 258, 258, 4096, 2);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000CEA4 File Offset: 0x0000B0A4
		internal Deflate()
		{
			this.dyn_ltree = new short[1146];
			this.dyn_dtree = new short[122];
			this.bl_tree = new short[78];
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000CF30 File Offset: 0x0000B130
		internal void lm_init()
		{
			this.window_size = 2 * this.w_size;
			this.head[this.hash_size - 1] = 0;
			for (int i = 0; i < this.hash_size - 1; i++)
			{
				this.head[i] = 0;
			}
			this.max_lazy_match = global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[this.level].max_lazy;
			this.good_match = global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[this.level].good_length;
			this.nice_match = global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[this.level].nice_length;
			this.max_chain_length = global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[this.level].max_chain;
			this.strstart = 0;
			this.block_start = 0;
			this.lookahead = 0;
			this.match_length = (this.prev_length = 2);
			this.match_available = 0;
			this.ins_h = 0;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000D008 File Offset: 0x0000B208
		internal void tr_init()
		{
			this.l_desc.dyn_tree = this.dyn_ltree;
			this.l_desc.stat_desc = global::Org.BouncyCastle.Utilities.Zlib.StaticTree.static_l_desc;
			this.d_desc.dyn_tree = this.dyn_dtree;
			this.d_desc.stat_desc = global::Org.BouncyCastle.Utilities.Zlib.StaticTree.static_d_desc;
			this.bl_desc.dyn_tree = this.bl_tree;
			this.bl_desc.stat_desc = global::Org.BouncyCastle.Utilities.Zlib.StaticTree.static_bl_desc;
			this.bi_buf = 0U;
			this.bi_valid = 0;
			this.last_eob_len = 8;
			this.init_block();
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000D094 File Offset: 0x0000B294
		internal void init_block()
		{
			for (int i = 0; i < 286; i++)
			{
				this.dyn_ltree[i * 2] = 0;
			}
			for (int j = 0; j < 30; j++)
			{
				this.dyn_dtree[j * 2] = 0;
			}
			for (int k = 0; k < 19; k++)
			{
				this.bl_tree[k * 2] = 0;
			}
			this.dyn_ltree[512] = 1;
			this.opt_len = (this.static_len = 0);
			this.last_lit = (this.matches = 0);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000D11C File Offset: 0x0000B31C
		internal void pqdownheap(short[] tree, int k)
		{
			int v = this.heap[k];
			for (int i = k << 1; i <= this.heap_len; i <<= 1)
			{
				if (i < this.heap_len && global::Org.BouncyCastle.Utilities.Zlib.Deflate.smaller(tree, this.heap[i + 1], this.heap[i], this.depth))
				{
					i++;
				}
				if (global::Org.BouncyCastle.Utilities.Zlib.Deflate.smaller(tree, v, this.heap[i], this.depth))
				{
					break;
				}
				this.heap[k] = this.heap[i];
				k = i;
			}
			this.heap[k] = v;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000D1A8 File Offset: 0x0000B3A8
		internal static bool smaller(short[] tree, int n, int m, byte[] depth)
		{
			short tn2 = tree[n * 2];
			short tm2 = tree[m * 2];
			return tn2 < tm2 || (tn2 == tm2 && depth[n] <= depth[m]);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000D1D8 File Offset: 0x0000B3D8
		internal void scan_tree(short[] tree, int max_code)
		{
			int prevlen = -1;
			int nextlen = (int)tree[1];
			int count = 0;
			int max_count = 7;
			int min_count = 4;
			if (nextlen == 0)
			{
				max_count = 138;
				min_count = 3;
			}
			tree[(max_code + 1) * 2 + 1] = -1;
			for (int i = 0; i <= max_code; i++)
			{
				int curlen = nextlen;
				nextlen = (int)tree[(i + 1) * 2 + 1];
				if (++count >= max_count || curlen != nextlen)
				{
					if (count < min_count)
					{
						short[] array = this.bl_tree;
						int num = curlen * 2;
						array[num] += (short)count;
					}
					else if (curlen != 0)
					{
						if (curlen != prevlen)
						{
							short[] array2 = this.bl_tree;
							int num2 = curlen * 2;
							array2[num2] += 1;
						}
						short[] array3 = this.bl_tree;
						int num3 = 32;
						array3[num3] += 1;
					}
					else if (count <= 10)
					{
						short[] array4 = this.bl_tree;
						int num4 = 34;
						array4[num4] += 1;
					}
					else
					{
						short[] array5 = this.bl_tree;
						int num5 = 36;
						array5[num5] += 1;
					}
					count = 0;
					prevlen = curlen;
					if (nextlen == 0)
					{
						max_count = 138;
						min_count = 3;
					}
					else if (curlen == nextlen)
					{
						max_count = 6;
						min_count = 3;
					}
					else
					{
						max_count = 7;
						min_count = 4;
					}
				}
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000D2E0 File Offset: 0x0000B4E0
		internal int build_bl_tree()
		{
			this.scan_tree(this.dyn_ltree, this.l_desc.max_code);
			this.scan_tree(this.dyn_dtree, this.d_desc.max_code);
			this.bl_desc.build_tree(this);
			int max_blindex = 18;
			while (max_blindex >= 3 && this.bl_tree[(int)(global::Org.BouncyCastle.Utilities.Zlib.Tree.bl_order[max_blindex] * 2 + 1)] == 0)
			{
				max_blindex--;
			}
			this.opt_len += 3 * (max_blindex + 1) + 5 + 5 + 4;
			return max_blindex;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000D364 File Offset: 0x0000B564
		internal void send_all_trees(int lcodes, int dcodes, int blcodes)
		{
			this.send_bits(lcodes - 257, 5);
			this.send_bits(dcodes - 1, 5);
			this.send_bits(blcodes - 4, 4);
			for (int rank = 0; rank < blcodes; rank++)
			{
				this.send_bits((int)this.bl_tree[(int)(global::Org.BouncyCastle.Utilities.Zlib.Tree.bl_order[rank] * 2 + 1)], 3);
			}
			this.send_tree(this.dyn_ltree, lcodes - 1);
			this.send_tree(this.dyn_dtree, dcodes - 1);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000D3D8 File Offset: 0x0000B5D8
		internal void send_tree(short[] tree, int max_code)
		{
			int prevlen = -1;
			int nextlen = (int)tree[1];
			int count = 0;
			int max_count = 7;
			int min_count = 4;
			if (nextlen == 0)
			{
				max_count = 138;
				min_count = 3;
			}
			for (int i = 0; i <= max_code; i++)
			{
				int curlen = nextlen;
				nextlen = (int)tree[(i + 1) * 2 + 1];
				if (++count >= max_count || curlen != nextlen)
				{
					if (count < min_count)
					{
						do
						{
							this.send_code(curlen, this.bl_tree);
						}
						while (--count != 0);
					}
					else if (curlen != 0)
					{
						if (curlen != prevlen)
						{
							this.send_code(curlen, this.bl_tree);
							count--;
						}
						this.send_code(16, this.bl_tree);
						this.send_bits(count - 3, 2);
					}
					else if (count <= 10)
					{
						this.send_code(17, this.bl_tree);
						this.send_bits(count - 3, 3);
					}
					else
					{
						this.send_code(18, this.bl_tree);
						this.send_bits(count - 11, 7);
					}
					count = 0;
					prevlen = curlen;
					if (nextlen == 0)
					{
						max_count = 138;
						min_count = 3;
					}
					else if (curlen == nextlen)
					{
						max_count = 6;
						min_count = 3;
					}
					else
					{
						max_count = 7;
						min_count = 4;
					}
				}
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000D4E5 File Offset: 0x0000B6E5
		internal void put_byte(byte[] p, int start, int len)
		{
			global::System.Array.Copy(p, start, this.pending_buf, this.pending, len);
			this.pending += len;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000D50C File Offset: 0x0000B70C
		internal void put_byte(byte c)
		{
			byte[] array = this.pending_buf;
			int num = this.pending;
			this.pending = num + 1;
			array[num] = c;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000D534 File Offset: 0x0000B734
		internal void put_short(int w)
		{
			byte[] array = this.pending_buf;
			int num = this.pending;
			this.pending = num + 1;
			array[num] = (byte)w;
			byte[] array2 = this.pending_buf;
			num = this.pending;
			this.pending = num + 1;
			array2[num] = (byte)(w >> 8);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000D578 File Offset: 0x0000B778
		internal void putShortMSB(int b)
		{
			byte[] array = this.pending_buf;
			int num = this.pending;
			this.pending = num + 1;
			array[num] = (byte)(b >> 8);
			byte[] array2 = this.pending_buf;
			num = this.pending;
			this.pending = num + 1;
			array2[num] = (byte)b;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000D5BC File Offset: 0x0000B7BC
		internal void send_code(int c, short[] tree)
		{
			int c2 = c * 2;
			this.send_bits((int)tree[c2] & 65535, (int)tree[c2 + 1] & 65535);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000D5E8 File Offset: 0x0000B7E8
		internal void send_bits(int val, int length)
		{
			if (this.bi_valid > 16 - length)
			{
				this.bi_buf |= (uint)((uint)val << this.bi_valid);
				byte[] array = this.pending_buf;
				int num = this.pending;
				this.pending = num + 1;
				array[num] = (byte)this.bi_buf;
				byte[] array2 = this.pending_buf;
				num = this.pending;
				this.pending = num + 1;
				array2[num] = (byte)(this.bi_buf >> 8);
				this.bi_buf = (uint)val >> 16 - this.bi_valid;
				this.bi_valid += length - 16;
				return;
			}
			this.bi_buf |= (uint)((uint)val << this.bi_valid);
			this.bi_valid += length;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000D6A8 File Offset: 0x0000B8A8
		internal void _tr_align()
		{
			this.send_bits(2, 3);
			this.send_code(256, global::Org.BouncyCastle.Utilities.Zlib.StaticTree.static_ltree);
			this.bi_flush();
			if (1 + this.last_eob_len + 10 - this.bi_valid < 9)
			{
				this.send_bits(2, 3);
				this.send_code(256, global::Org.BouncyCastle.Utilities.Zlib.StaticTree.static_ltree);
				this.bi_flush();
			}
			this.last_eob_len = 7;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000D710 File Offset: 0x0000B910
		internal bool _tr_tally(int dist, int lc)
		{
			this.pending_buf[this.d_buf + this.last_lit * 2] = (byte)(dist >> 8);
			this.pending_buf[this.d_buf + this.last_lit * 2 + 1] = (byte)dist;
			this.pending_buf[this.l_buf + this.last_lit] = (byte)lc;
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
				int num2 = ((int)global::Org.BouncyCastle.Utilities.Zlib.Tree._length_code[lc] + 256 + 1) * 2;
				array2[num2] += 1;
				short[] array3 = this.dyn_dtree;
				int num3 = global::Org.BouncyCastle.Utilities.Zlib.Tree.d_code(dist) * 2;
				array3[num3] += 1;
			}
			if ((this.last_lit & 8191) == 0 && this.level > 2)
			{
				int out_length = this.last_lit * 8;
				int in_length = this.strstart - this.block_start;
				for (int dcode = 0; dcode < 30; dcode++)
				{
					out_length += (int)((long)this.dyn_dtree[dcode * 2] * (5L + (long)global::Org.BouncyCastle.Utilities.Zlib.Tree.extra_dbits[dcode]));
				}
				out_length >>= 3;
				if (this.matches < this.last_lit / 2 && out_length < in_length / 2)
				{
					return true;
				}
			}
			return this.last_lit == this.lit_bufsize - 1;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000D860 File Offset: 0x0000BA60
		internal void compress_block(short[] ltree, short[] dtree)
		{
			int lx = 0;
			if (this.last_lit != 0)
			{
				do
				{
					int dist = ((int)this.pending_buf[this.d_buf + lx * 2] << 8 & 65280) | (int)(this.pending_buf[this.d_buf + lx * 2 + 1] & byte.MaxValue);
					int lc = (int)(this.pending_buf[this.l_buf + lx] & byte.MaxValue);
					lx++;
					if (dist == 0)
					{
						this.send_code(lc, ltree);
					}
					else
					{
						int code = (int)global::Org.BouncyCastle.Utilities.Zlib.Tree._length_code[lc];
						this.send_code(code + 256 + 1, ltree);
						int extra = global::Org.BouncyCastle.Utilities.Zlib.Tree.extra_lbits[code];
						if (extra != 0)
						{
							lc -= global::Org.BouncyCastle.Utilities.Zlib.Tree.base_length[code];
							this.send_bits(lc, extra);
						}
						dist--;
						code = global::Org.BouncyCastle.Utilities.Zlib.Tree.d_code(dist);
						this.send_code(code, dtree);
						extra = global::Org.BouncyCastle.Utilities.Zlib.Tree.extra_dbits[code];
						if (extra != 0)
						{
							dist -= global::Org.BouncyCastle.Utilities.Zlib.Tree.base_dist[code];
							this.send_bits(dist, extra);
						}
					}
				}
				while (lx < this.last_lit);
			}
			this.send_code(256, ltree);
			this.last_eob_len = (int)ltree[513];
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000D968 File Offset: 0x0000BB68
		internal void set_data_type()
		{
			int i = 0;
			int ascii_freq = 0;
			int bin_freq = 0;
			while (i < 7)
			{
				bin_freq += (int)this.dyn_ltree[i * 2];
				i++;
			}
			while (i < 128)
			{
				ascii_freq += (int)this.dyn_ltree[i * 2];
				i++;
			}
			while (i < 256)
			{
				bin_freq += (int)this.dyn_ltree[i * 2];
				i++;
			}
			this.data_type = ((bin_freq > ascii_freq >> 2) ? 0 : 1);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000D9DC File Offset: 0x0000BBDC
		internal void bi_flush()
		{
			if (this.bi_valid == 16)
			{
				byte[] array = this.pending_buf;
				int num = this.pending;
				this.pending = num + 1;
				array[num] = (byte)this.bi_buf;
				byte[] array2 = this.pending_buf;
				num = this.pending;
				this.pending = num + 1;
				array2[num] = (byte)(this.bi_buf >> 8);
				this.bi_buf = 0U;
				this.bi_valid = 0;
				return;
			}
			if (this.bi_valid >= 8)
			{
				byte[] array3 = this.pending_buf;
				int num = this.pending;
				this.pending = num + 1;
				array3[num] = (byte)this.bi_buf;
				this.bi_buf >>= 8;
				this.bi_buf &= 255U;
				this.bi_valid -= 8;
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000DA98 File Offset: 0x0000BC98
		internal void bi_windup()
		{
			if (this.bi_valid > 8)
			{
				byte[] array = this.pending_buf;
				int num = this.pending;
				this.pending = num + 1;
				array[num] = (byte)this.bi_buf;
				byte[] array2 = this.pending_buf;
				num = this.pending;
				this.pending = num + 1;
				array2[num] = (byte)(this.bi_buf >> 8);
			}
			else if (this.bi_valid > 0)
			{
				byte[] array3 = this.pending_buf;
				int num = this.pending;
				this.pending = num + 1;
				array3[num] = (byte)this.bi_buf;
			}
			this.bi_buf = 0U;
			this.bi_valid = 0;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000DB26 File Offset: 0x0000BD26
		internal void copy_block(int buf, int len, bool header)
		{
			this.bi_windup();
			this.last_eob_len = 8;
			if (header)
			{
				this.put_short((int)((short)len));
				this.put_short((int)((short)(~(short)len)));
			}
			this.put_byte(this.window, buf, len);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000DB57 File Offset: 0x0000BD57
		internal void flush_block_only(bool eof)
		{
			this._tr_flush_block((this.block_start >= 0) ? this.block_start : -1, this.strstart - this.block_start, eof);
			this.block_start = this.strstart;
			this.strm.flush_pending();
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000DB98 File Offset: 0x0000BD98
		internal int deflate_stored(int flush)
		{
			int max_block_size = global::System.Math.Min(65535, this.pending_buf.Length - 5);
			for (;;)
			{
				if (this.lookahead <= 1)
				{
					this.fill_window();
					if (this.lookahead == 0 && flush == 0)
					{
						break;
					}
					if (this.lookahead == 0)
					{
						goto IL_D2;
					}
				}
				this.strstart += this.lookahead;
				this.lookahead = 0;
				int max_start = this.block_start + max_block_size;
				if (this.strstart == 0 || this.strstart >= max_start)
				{
					this.lookahead = this.strstart - max_start;
					this.strstart = max_start;
					this.flush_block_only(false);
					if (this.strm.avail_out == 0)
					{
						return 0;
					}
				}
				if (this.strstart - this.block_start >= this.w_size - 262)
				{
					this.flush_block_only(false);
					if (this.strm.avail_out == 0)
					{
						return 0;
					}
				}
			}
			return 0;
			IL_D2:
			this.flush_block_only(flush == 4);
			if (this.strm.avail_out == 0)
			{
				if (flush != 4)
				{
					return 0;
				}
				return 2;
			}
			else
			{
				if (flush != 4)
				{
					return 1;
				}
				return 3;
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000DC9D File Offset: 0x0000BE9D
		internal void _tr_stored_block(int buf, int stored_len, bool eof)
		{
			this.send_bits(eof ? 1 : 0, 3);
			this.copy_block(buf, stored_len, true);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000DCB8 File Offset: 0x0000BEB8
		internal void _tr_flush_block(int buf, int stored_len, bool eof)
		{
			int max_blindex = 0;
			int opt_lenb;
			int static_lenb;
			if (this.level > 0)
			{
				if (this.data_type == 2)
				{
					this.set_data_type();
				}
				this.l_desc.build_tree(this);
				this.d_desc.build_tree(this);
				max_blindex = this.build_bl_tree();
				opt_lenb = this.opt_len + 3 + 7 >> 3;
				static_lenb = this.static_len + 3 + 7 >> 3;
				if (static_lenb <= opt_lenb)
				{
					opt_lenb = static_lenb;
				}
			}
			else
			{
				static_lenb = (opt_lenb = stored_len + 5);
			}
			if (stored_len + 4 <= opt_lenb && buf != -1)
			{
				this._tr_stored_block(buf, stored_len, eof);
			}
			else if (static_lenb == opt_lenb)
			{
				this.send_bits(2 + (eof ? 1 : 0), 3);
				this.compress_block(global::Org.BouncyCastle.Utilities.Zlib.StaticTree.static_ltree, global::Org.BouncyCastle.Utilities.Zlib.StaticTree.static_dtree);
			}
			else
			{
				this.send_bits(4 + (eof ? 1 : 0), 3);
				this.send_all_trees(this.l_desc.max_code + 1, this.d_desc.max_code + 1, max_blindex + 1);
				this.compress_block(this.dyn_ltree, this.dyn_dtree);
			}
			this.init_block();
			if (eof)
			{
				this.bi_windup();
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		internal void fill_window()
		{
			for (;;)
			{
				int more = this.window_size - this.lookahead - this.strstart;
				int i;
				if (more == 0 && this.strstart == 0 && this.lookahead == 0)
				{
					more = this.w_size;
				}
				else if (more == -1)
				{
					more--;
				}
				else if (this.strstart >= this.w_size + this.w_size - 262)
				{
					global::System.Array.Copy(this.window, this.w_size, this.window, 0, this.w_size);
					this.match_start -= this.w_size;
					this.strstart -= this.w_size;
					this.block_start -= this.w_size;
					i = this.hash_size;
					int p = i;
					do
					{
						int j = (int)this.head[--p] & 65535;
						this.head[p] = (short)((j >= this.w_size) ? (j - this.w_size) : 0);
					}
					while (--i != 0);
					i = this.w_size;
					p = i;
					do
					{
						int j = (int)this.prev[--p] & 65535;
						this.prev[p] = (short)((j >= this.w_size) ? (j - this.w_size) : 0);
					}
					while (--i != 0);
					more += this.w_size;
				}
				if (this.strm.avail_in == 0)
				{
					break;
				}
				i = this.strm.read_buf(this.window, this.strstart + this.lookahead, more);
				this.lookahead += i;
				if (this.lookahead >= 3)
				{
					this.ins_h = (int)(this.window[this.strstart] & byte.MaxValue);
					this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[this.strstart + 1] & byte.MaxValue)) & this.hash_mask);
				}
				if (this.lookahead >= 262 || this.strm.avail_in == 0)
				{
					return;
				}
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000DFB4 File Offset: 0x0000C1B4
		internal int deflate_fast(int flush)
		{
			int hash_head = 0;
			for (;;)
			{
				if (this.lookahead < 262)
				{
					this.fill_window();
					if (this.lookahead < 262 && flush == 0)
					{
						break;
					}
					if (this.lookahead == 0)
					{
						goto IL_2C4;
					}
				}
				if (this.lookahead >= 3)
				{
					this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[this.strstart + 2] & byte.MaxValue)) & this.hash_mask);
					hash_head = ((int)this.head[this.ins_h] & 65535);
					this.prev[this.strstart & this.w_mask] = this.head[this.ins_h];
					this.head[this.ins_h] = (short)this.strstart;
				}
				if ((long)hash_head != 0L && (this.strstart - hash_head & 65535) <= this.w_size - 262 && this.strategy != 2)
				{
					this.match_length = this.longest_match(hash_head);
				}
				bool bflush;
				if (this.match_length >= 3)
				{
					bflush = this._tr_tally(this.strstart - this.match_start, this.match_length - 3);
					this.lookahead -= this.match_length;
					if (this.match_length <= this.max_lazy_match && this.lookahead >= 3)
					{
						this.match_length--;
						int num;
						do
						{
							this.strstart++;
							this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[this.strstart + 2] & byte.MaxValue)) & this.hash_mask);
							hash_head = ((int)this.head[this.ins_h] & 65535);
							this.prev[this.strstart & this.w_mask] = this.head[this.ins_h];
							this.head[this.ins_h] = (short)this.strstart;
							num = this.match_length - 1;
							this.match_length = num;
						}
						while (num != 0);
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
					bflush = this._tr_tally(0, (int)(this.window[this.strstart] & byte.MaxValue));
					this.lookahead--;
					this.strstart++;
				}
				if (bflush)
				{
					this.flush_block_only(false);
					if (this.strm.avail_out == 0)
					{
						return 0;
					}
				}
			}
			return 0;
			IL_2C4:
			this.flush_block_only(flush == 4);
			if (this.strm.avail_out == 0)
			{
				if (flush == 4)
				{
					return 2;
				}
				return 0;
			}
			else
			{
				if (flush != 4)
				{
					return 1;
				}
				return 3;
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000E2AC File Offset: 0x0000C4AC
		internal int deflate_slow(int flush)
		{
			int hash_head = 0;
			for (;;)
			{
				if (this.lookahead < 262)
				{
					this.fill_window();
					if (this.lookahead < 262 && flush == 0)
					{
						break;
					}
					if (this.lookahead == 0)
					{
						goto IL_323;
					}
				}
				if (this.lookahead >= 3)
				{
					this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[this.strstart + 2] & byte.MaxValue)) & this.hash_mask);
					hash_head = ((int)this.head[this.ins_h] & 65535);
					this.prev[this.strstart & this.w_mask] = this.head[this.ins_h];
					this.head[this.ins_h] = (short)this.strstart;
				}
				this.prev_length = this.match_length;
				this.prev_match = this.match_start;
				this.match_length = 2;
				if (hash_head != 0 && this.prev_length < this.max_lazy_match && (this.strstart - hash_head & 65535) <= this.w_size - 262)
				{
					if (this.strategy != 2)
					{
						this.match_length = this.longest_match(hash_head);
					}
					if (this.match_length <= 5 && (this.strategy == 1 || (this.match_length == 3 && this.strstart - this.match_start > 4096)))
					{
						this.match_length = 2;
					}
				}
				if (this.prev_length >= 3 && this.match_length <= this.prev_length)
				{
					int max_insert = this.strstart + this.lookahead - 3;
					bool bflush = this._tr_tally(this.strstart - 1 - this.prev_match, this.prev_length - 3);
					this.lookahead -= this.prev_length - 1;
					this.prev_length -= 2;
					int num;
					do
					{
						num = this.strstart + 1;
						this.strstart = num;
						if (num <= max_insert)
						{
							this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[this.strstart + 2] & byte.MaxValue)) & this.hash_mask);
							hash_head = ((int)this.head[this.ins_h] & 65535);
							this.prev[this.strstart & this.w_mask] = this.head[this.ins_h];
							this.head[this.ins_h] = (short)this.strstart;
						}
						num = this.prev_length - 1;
						this.prev_length = num;
					}
					while (num != 0);
					this.match_available = 0;
					this.match_length = 2;
					this.strstart++;
					if (bflush)
					{
						this.flush_block_only(false);
						if (this.strm.avail_out == 0)
						{
							return 0;
						}
					}
				}
				else if (this.match_available != 0)
				{
					bool bflush = this._tr_tally(0, (int)(this.window[this.strstart - 1] & byte.MaxValue));
					if (bflush)
					{
						this.flush_block_only(false);
					}
					this.strstart++;
					this.lookahead--;
					if (this.strm.avail_out == 0)
					{
						return 0;
					}
				}
				else
				{
					this.match_available = 1;
					this.strstart++;
					this.lookahead--;
				}
			}
			return 0;
			IL_323:
			if (this.match_available != 0)
			{
				bool bflush = this._tr_tally(0, (int)(this.window[this.strstart - 1] & byte.MaxValue));
				this.match_available = 0;
			}
			this.flush_block_only(flush == 4);
			if (this.strm.avail_out == 0)
			{
				if (flush == 4)
				{
					return 2;
				}
				return 0;
			}
			else
			{
				if (flush != 4)
				{
					return 1;
				}
				return 3;
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000E630 File Offset: 0x0000C830
		internal int longest_match(int cur_match)
		{
			int chain_length = this.max_chain_length;
			int scan = this.strstart;
			int best_len = this.prev_length;
			int limit = (this.strstart > this.w_size - 262) ? (this.strstart - (this.w_size - 262)) : 0;
			int nice_match = this.nice_match;
			int wmask = this.w_mask;
			int strend = this.strstart + 258;
			byte scan_end = this.window[scan + best_len - 1];
			byte scan_end2 = this.window[scan + best_len];
			if (this.prev_length >= this.good_match)
			{
				chain_length >>= 2;
			}
			if (nice_match > this.lookahead)
			{
				nice_match = this.lookahead;
			}
			do
			{
				int match = cur_match;
				if (this.window[match + best_len] == scan_end2 && this.window[match + best_len - 1] == scan_end && this.window[match] == this.window[scan] && this.window[++match] == this.window[scan + 1])
				{
					scan += 2;
					match++;
					while (this.window[++scan] == this.window[++match] && this.window[++scan] == this.window[++match] && this.window[++scan] == this.window[++match] && this.window[++scan] == this.window[++match] && this.window[++scan] == this.window[++match] && this.window[++scan] == this.window[++match] && this.window[++scan] == this.window[++match] && this.window[++scan] == this.window[++match] && scan < strend)
					{
					}
					int len = 258 - (strend - scan);
					scan = strend - 258;
					if (len > best_len)
					{
						this.match_start = cur_match;
						best_len = len;
						if (len >= nice_match)
						{
							break;
						}
						scan_end = this.window[scan + best_len - 1];
						scan_end2 = this.window[scan + best_len];
					}
				}
			}
			while ((cur_match = ((int)this.prev[cur_match & wmask] & 65535)) > limit && --chain_length != 0);
			if (best_len <= this.lookahead)
			{
				return best_len;
			}
			return this.lookahead;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000E897 File Offset: 0x0000CA97
		internal int deflateInit(global::Org.BouncyCastle.Utilities.Zlib.ZStream strm, int level, int bits)
		{
			return this.deflateInit2(strm, level, 8, bits, 8, 0);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000E8A5 File Offset: 0x0000CAA5
		internal int deflateInit(global::Org.BouncyCastle.Utilities.Zlib.ZStream strm, int level)
		{
			return this.deflateInit(strm, level, 15);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000E8B4 File Offset: 0x0000CAB4
		internal int deflateInit2(global::Org.BouncyCastle.Utilities.Zlib.ZStream strm, int level, int method, int windowBits, int memLevel, int strategy)
		{
			int noheader = 0;
			strm.msg = null;
			if (level == -1)
			{
				level = 6;
			}
			if (windowBits < 0)
			{
				noheader = 1;
				windowBits = -windowBits;
			}
			if (memLevel < 1 || memLevel > 9 || method != 8 || windowBits < 9 || windowBits > 15 || level < 0 || level > 9 || strategy < 0 || strategy > 2)
			{
				return -2;
			}
			strm.dstate = this;
			this.noheader = noheader;
			this.w_bits = windowBits;
			this.w_size = 1 << this.w_bits;
			this.w_mask = this.w_size - 1;
			this.hash_bits = memLevel + 7;
			this.hash_size = 1 << this.hash_bits;
			this.hash_mask = this.hash_size - 1;
			this.hash_shift = (this.hash_bits + 3 - 1) / 3;
			this.window = new byte[this.w_size * 2];
			this.prev = new short[this.w_size];
			this.head = new short[this.hash_size];
			this.lit_bufsize = 1 << memLevel + 6;
			this.pending_buf = new byte[this.lit_bufsize * 4];
			this.d_buf = this.lit_bufsize;
			this.l_buf = 3 * this.lit_bufsize;
			this.level = level;
			this.strategy = strategy;
			this.method = (byte)method;
			return this.deflateReset(strm);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000EA10 File Offset: 0x0000CC10
		internal int deflateReset(global::Org.BouncyCastle.Utilities.Zlib.ZStream strm)
		{
			strm.total_in = (strm.total_out = 0L);
			strm.msg = null;
			strm.data_type = 2;
			this.pending = 0;
			this.pending_out = 0;
			if (this.noheader < 0)
			{
				this.noheader = 0;
			}
			this.status = ((this.noheader != 0) ? 113 : 42);
			strm.adler = strm._adler.adler32(0L, null, 0, 0);
			this.last_flush = 0;
			this.tr_init();
			this.lm_init();
			return 0;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000EA98 File Offset: 0x0000CC98
		internal int deflateEnd()
		{
			if (this.status != 42 && this.status != 113 && this.status != 666)
			{
				return -2;
			}
			this.pending_buf = null;
			this.head = null;
			this.prev = null;
			this.window = null;
			if (this.status != 113)
			{
				return 0;
			}
			return -3;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000EAF4 File Offset: 0x0000CCF4
		internal int deflateParams(global::Org.BouncyCastle.Utilities.Zlib.ZStream strm, int _level, int _strategy)
		{
			int err = 0;
			if (_level == -1)
			{
				_level = 6;
			}
			if (_level < 0 || _level > 9 || _strategy < 0 || _strategy > 2)
			{
				return -2;
			}
			if (global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[this.level].func != global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[_level].func && strm.total_in != 0L)
			{
				err = strm.deflate(1);
			}
			if (this.level != _level)
			{
				this.level = _level;
				this.max_lazy_match = global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[this.level].max_lazy;
				this.good_match = global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[this.level].good_length;
				this.nice_match = global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[this.level].nice_length;
				this.max_chain_length = global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[this.level].max_chain;
			}
			this.strategy = _strategy;
			return err;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000EBC4 File Offset: 0x0000CDC4
		internal int deflateSetDictionary(global::Org.BouncyCastle.Utilities.Zlib.ZStream strm, byte[] dictionary, int dictLength)
		{
			int length = dictLength;
			int index = 0;
			if (dictionary == null || this.status != 42)
			{
				return -2;
			}
			strm.adler = strm._adler.adler32(strm.adler, dictionary, 0, dictLength);
			if (length < 3)
			{
				return 0;
			}
			if (length > this.w_size - 262)
			{
				length = this.w_size - 262;
				index = dictLength - length;
			}
			global::System.Array.Copy(dictionary, index, this.window, 0, length);
			this.strstart = length;
			this.block_start = length;
			this.ins_h = (int)(this.window[0] & byte.MaxValue);
			this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[1] & byte.MaxValue)) & this.hash_mask);
			for (int i = 0; i <= length - 3; i++)
			{
				this.ins_h = ((this.ins_h << this.hash_shift ^ (int)(this.window[i + 2] & byte.MaxValue)) & this.hash_mask);
				this.prev[i & this.w_mask] = this.head[this.ins_h];
				this.head[this.ins_h] = (short)i;
			}
			return 0;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000ECEC File Offset: 0x0000CEEC
		internal int deflate(global::Org.BouncyCastle.Utilities.Zlib.ZStream strm, int flush)
		{
			if (flush > 4 || flush < 0)
			{
				return -2;
			}
			if (strm.next_out == null || (strm.next_in == null && strm.avail_in != 0) || (this.status == 666 && flush != 4))
			{
				strm.msg = global::Org.BouncyCastle.Utilities.Zlib.Deflate.z_errmsg[4];
				return -2;
			}
			if (strm.avail_out == 0)
			{
				strm.msg = global::Org.BouncyCastle.Utilities.Zlib.Deflate.z_errmsg[7];
				return -5;
			}
			this.strm = strm;
			int old_flush = this.last_flush;
			this.last_flush = flush;
			if (this.status == 42)
			{
				int header = 8 + (this.w_bits - 8 << 4) << 8;
				int level_flags = (this.level - 1 & 255) >> 1;
				if (level_flags > 3)
				{
					level_flags = 3;
				}
				header |= level_flags << 6;
				if (this.strstart != 0)
				{
					header |= 32;
				}
				header += 31 - header % 31;
				this.status = 113;
				this.putShortMSB(header);
				if (this.strstart != 0)
				{
					this.putShortMSB((int)(strm.adler >> 16));
					this.putShortMSB((int)(strm.adler & 65535L));
				}
				strm.adler = strm._adler.adler32(0L, null, 0, 0);
			}
			if (this.pending != 0)
			{
				strm.flush_pending();
				if (strm.avail_out == 0)
				{
					this.last_flush = -1;
					return 0;
				}
			}
			else if (strm.avail_in == 0 && flush <= old_flush && flush != 4)
			{
				strm.msg = global::Org.BouncyCastle.Utilities.Zlib.Deflate.z_errmsg[7];
				return -5;
			}
			if (this.status == 666 && strm.avail_in != 0)
			{
				strm.msg = global::Org.BouncyCastle.Utilities.Zlib.Deflate.z_errmsg[7];
				return -5;
			}
			if (strm.avail_in != 0 || this.lookahead != 0 || (flush != 0 && this.status != 666))
			{
				int bstate = -1;
				switch (global::Org.BouncyCastle.Utilities.Zlib.Deflate.config_table[this.level].func)
				{
				case 0:
					bstate = this.deflate_stored(flush);
					break;
				case 1:
					bstate = this.deflate_fast(flush);
					break;
				case 2:
					bstate = this.deflate_slow(flush);
					break;
				}
				if (bstate == 2 || bstate == 3)
				{
					this.status = 666;
				}
				if (bstate == 0 || bstate == 2)
				{
					if (strm.avail_out == 0)
					{
						this.last_flush = -1;
					}
					return 0;
				}
				if (bstate == 1)
				{
					if (flush == 1)
					{
						this._tr_align();
					}
					else
					{
						this._tr_stored_block(0, 0, false);
						if (flush == 3)
						{
							for (int i = 0; i < this.hash_size; i++)
							{
								this.head[i] = 0;
							}
						}
					}
					strm.flush_pending();
					if (strm.avail_out == 0)
					{
						this.last_flush = -1;
						return 0;
					}
				}
			}
			if (flush != 4)
			{
				return 0;
			}
			if (this.noheader != 0)
			{
				return 1;
			}
			this.putShortMSB((int)(strm.adler >> 16));
			this.putShortMSB((int)(strm.adler & 65535L));
			strm.flush_pending();
			this.noheader = -1;
			if (this.pending == 0)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x040000FD RID: 253
		private const int MAX_MEM_LEVEL = 9;

		// Token: 0x040000FE RID: 254
		private const int Z_DEFAULT_COMPRESSION = -1;

		// Token: 0x040000FF RID: 255
		private const int MAX_WBITS = 15;

		// Token: 0x04000100 RID: 256
		private const int DEF_MEM_LEVEL = 8;

		// Token: 0x04000101 RID: 257
		private const int STORED = 0;

		// Token: 0x04000102 RID: 258
		private const int FAST = 1;

		// Token: 0x04000103 RID: 259
		private const int SLOW = 2;

		// Token: 0x04000104 RID: 260
		private static readonly global::Org.BouncyCastle.Utilities.Zlib.Deflate.Config[] config_table;

		// Token: 0x04000105 RID: 261
		private static readonly string[] z_errmsg = new string[]
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

		// Token: 0x04000106 RID: 262
		private const int NeedMore = 0;

		// Token: 0x04000107 RID: 263
		private const int BlockDone = 1;

		// Token: 0x04000108 RID: 264
		private const int FinishStarted = 2;

		// Token: 0x04000109 RID: 265
		private const int FinishDone = 3;

		// Token: 0x0400010A RID: 266
		private const int PRESET_DICT = 32;

		// Token: 0x0400010B RID: 267
		private const int Z_FILTERED = 1;

		// Token: 0x0400010C RID: 268
		private const int Z_HUFFMAN_ONLY = 2;

		// Token: 0x0400010D RID: 269
		private const int Z_DEFAULT_STRATEGY = 0;

		// Token: 0x0400010E RID: 270
		private const int Z_NO_FLUSH = 0;

		// Token: 0x0400010F RID: 271
		private const int Z_PARTIAL_FLUSH = 1;

		// Token: 0x04000110 RID: 272
		private const int Z_SYNC_FLUSH = 2;

		// Token: 0x04000111 RID: 273
		private const int Z_FULL_FLUSH = 3;

		// Token: 0x04000112 RID: 274
		private const int Z_FINISH = 4;

		// Token: 0x04000113 RID: 275
		private const int Z_OK = 0;

		// Token: 0x04000114 RID: 276
		private const int Z_STREAM_END = 1;

		// Token: 0x04000115 RID: 277
		private const int Z_NEED_DICT = 2;

		// Token: 0x04000116 RID: 278
		private const int Z_ERRNO = -1;

		// Token: 0x04000117 RID: 279
		private const int Z_STREAM_ERROR = -2;

		// Token: 0x04000118 RID: 280
		private const int Z_DATA_ERROR = -3;

		// Token: 0x04000119 RID: 281
		private const int Z_MEM_ERROR = -4;

		// Token: 0x0400011A RID: 282
		private const int Z_BUF_ERROR = -5;

		// Token: 0x0400011B RID: 283
		private const int Z_VERSION_ERROR = -6;

		// Token: 0x0400011C RID: 284
		private const int INIT_STATE = 42;

		// Token: 0x0400011D RID: 285
		private const int BUSY_STATE = 113;

		// Token: 0x0400011E RID: 286
		private const int FINISH_STATE = 666;

		// Token: 0x0400011F RID: 287
		private const int Z_DEFLATED = 8;

		// Token: 0x04000120 RID: 288
		private const int STORED_BLOCK = 0;

		// Token: 0x04000121 RID: 289
		private const int STATIC_TREES = 1;

		// Token: 0x04000122 RID: 290
		private const int DYN_TREES = 2;

		// Token: 0x04000123 RID: 291
		private const int Z_BINARY = 0;

		// Token: 0x04000124 RID: 292
		private const int Z_ASCII = 1;

		// Token: 0x04000125 RID: 293
		private const int Z_UNKNOWN = 2;

		// Token: 0x04000126 RID: 294
		private const int Buf_size = 16;

		// Token: 0x04000127 RID: 295
		private const int REP_3_6 = 16;

		// Token: 0x04000128 RID: 296
		private const int REPZ_3_10 = 17;

		// Token: 0x04000129 RID: 297
		private const int REPZ_11_138 = 18;

		// Token: 0x0400012A RID: 298
		private const int MIN_MATCH = 3;

		// Token: 0x0400012B RID: 299
		private const int MAX_MATCH = 258;

		// Token: 0x0400012C RID: 300
		private const int MIN_LOOKAHEAD = 262;

		// Token: 0x0400012D RID: 301
		private const int MAX_BITS = 15;

		// Token: 0x0400012E RID: 302
		private const int D_CODES = 30;

		// Token: 0x0400012F RID: 303
		private const int BL_CODES = 19;

		// Token: 0x04000130 RID: 304
		private const int LENGTH_CODES = 29;

		// Token: 0x04000131 RID: 305
		private const int LITERALS = 256;

		// Token: 0x04000132 RID: 306
		private const int L_CODES = 286;

		// Token: 0x04000133 RID: 307
		private const int HEAP_SIZE = 573;

		// Token: 0x04000134 RID: 308
		private const int END_BLOCK = 256;

		// Token: 0x04000135 RID: 309
		internal global::Org.BouncyCastle.Utilities.Zlib.ZStream strm;

		// Token: 0x04000136 RID: 310
		internal int status;

		// Token: 0x04000137 RID: 311
		internal byte[] pending_buf;

		// Token: 0x04000138 RID: 312
		internal int pending_out;

		// Token: 0x04000139 RID: 313
		internal int pending;

		// Token: 0x0400013A RID: 314
		internal int noheader;

		// Token: 0x0400013B RID: 315
		internal byte data_type;

		// Token: 0x0400013C RID: 316
		internal byte method;

		// Token: 0x0400013D RID: 317
		internal int last_flush;

		// Token: 0x0400013E RID: 318
		internal int w_size;

		// Token: 0x0400013F RID: 319
		internal int w_bits;

		// Token: 0x04000140 RID: 320
		internal int w_mask;

		// Token: 0x04000141 RID: 321
		internal byte[] window;

		// Token: 0x04000142 RID: 322
		internal int window_size;

		// Token: 0x04000143 RID: 323
		internal short[] prev;

		// Token: 0x04000144 RID: 324
		internal short[] head;

		// Token: 0x04000145 RID: 325
		internal int ins_h;

		// Token: 0x04000146 RID: 326
		internal int hash_size;

		// Token: 0x04000147 RID: 327
		internal int hash_bits;

		// Token: 0x04000148 RID: 328
		internal int hash_mask;

		// Token: 0x04000149 RID: 329
		internal int hash_shift;

		// Token: 0x0400014A RID: 330
		internal int block_start;

		// Token: 0x0400014B RID: 331
		internal int match_length;

		// Token: 0x0400014C RID: 332
		internal int prev_match;

		// Token: 0x0400014D RID: 333
		internal int match_available;

		// Token: 0x0400014E RID: 334
		internal int strstart;

		// Token: 0x0400014F RID: 335
		internal int match_start;

		// Token: 0x04000150 RID: 336
		internal int lookahead;

		// Token: 0x04000151 RID: 337
		internal int prev_length;

		// Token: 0x04000152 RID: 338
		internal int max_chain_length;

		// Token: 0x04000153 RID: 339
		internal int max_lazy_match;

		// Token: 0x04000154 RID: 340
		internal int level;

		// Token: 0x04000155 RID: 341
		internal int strategy;

		// Token: 0x04000156 RID: 342
		internal int good_match;

		// Token: 0x04000157 RID: 343
		internal int nice_match;

		// Token: 0x04000158 RID: 344
		internal short[] dyn_ltree;

		// Token: 0x04000159 RID: 345
		internal short[] dyn_dtree;

		// Token: 0x0400015A RID: 346
		internal short[] bl_tree;

		// Token: 0x0400015B RID: 347
		internal global::Org.BouncyCastle.Utilities.Zlib.Tree l_desc = new global::Org.BouncyCastle.Utilities.Zlib.Tree();

		// Token: 0x0400015C RID: 348
		internal global::Org.BouncyCastle.Utilities.Zlib.Tree d_desc = new global::Org.BouncyCastle.Utilities.Zlib.Tree();

		// Token: 0x0400015D RID: 349
		internal global::Org.BouncyCastle.Utilities.Zlib.Tree bl_desc = new global::Org.BouncyCastle.Utilities.Zlib.Tree();

		// Token: 0x0400015E RID: 350
		internal short[] bl_count = new short[16];

		// Token: 0x0400015F RID: 351
		internal int[] heap = new int[573];

		// Token: 0x04000160 RID: 352
		internal int heap_len;

		// Token: 0x04000161 RID: 353
		internal int heap_max;

		// Token: 0x04000162 RID: 354
		internal byte[] depth = new byte[573];

		// Token: 0x04000163 RID: 355
		internal int l_buf;

		// Token: 0x04000164 RID: 356
		internal int lit_bufsize;

		// Token: 0x04000165 RID: 357
		internal int last_lit;

		// Token: 0x04000166 RID: 358
		internal int d_buf;

		// Token: 0x04000167 RID: 359
		internal int opt_len;

		// Token: 0x04000168 RID: 360
		internal int static_len;

		// Token: 0x04000169 RID: 361
		internal int matches;

		// Token: 0x0400016A RID: 362
		internal int last_eob_len;

		// Token: 0x0400016B RID: 363
		internal uint bi_buf;

		// Token: 0x0400016C RID: 364
		internal int bi_valid;

		// Token: 0x0200079B RID: 1947
		internal class Config
		{
			// Token: 0x060044F6 RID: 17654 RVA: 0x001324C2 File Offset: 0x001306C2
			internal Config(int good_length, int max_lazy, int nice_length, int max_chain, int func)
			{
				this.good_length = good_length;
				this.max_lazy = max_lazy;
				this.nice_length = nice_length;
				this.max_chain = max_chain;
				this.func = func;
			}

			// Token: 0x040022E0 RID: 8928
			internal int good_length;

			// Token: 0x040022E1 RID: 8929
			internal int max_lazy;

			// Token: 0x040022E2 RID: 8930
			internal int nice_length;

			// Token: 0x040022E3 RID: 8931
			internal int max_chain;

			// Token: 0x040022E4 RID: 8932
			internal int func;
		}
	}
}
