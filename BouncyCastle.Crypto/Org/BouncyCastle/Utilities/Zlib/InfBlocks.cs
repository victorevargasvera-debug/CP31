using System;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x0200003F RID: 63
	internal sealed class InfBlocks
	{
		// Token: 0x060002EA RID: 746 RVA: 0x0000EFA8 File Offset: 0x0000D1A8
		internal InfBlocks(global::Org.BouncyCastle.Utilities.Zlib.ZStream z, object checkfn, int w)
		{
			this.hufts = new int[4320];
			this.window = new byte[w];
			this.end = w;
			this.checkfn = checkfn;
			this.mode = 0;
			this.reset(z, null);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000F024 File Offset: 0x0000D224
		internal void reset(global::Org.BouncyCastle.Utilities.Zlib.ZStream z, long[] c)
		{
			if (c != null)
			{
				c[0] = this.check;
			}
			if (this.mode != 4)
			{
				int num = this.mode;
			}
			if (this.mode == 6)
			{
				this.codes.free(z);
			}
			this.mode = 0;
			this.bitk = 0;
			this.bitb = 0;
			this.read = (this.write = 0);
			if (this.checkfn != null)
			{
				z.adler = (this.check = z._adler.adler32(0L, null, 0, 0));
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000F0B0 File Offset: 0x0000D2B0
		internal int proc(global::Org.BouncyCastle.Utilities.Zlib.ZStream z, int r)
		{
			int p = z.next_in_index;
			int i = z.avail_in;
			int b = this.bitb;
			int j = this.bitk;
			int q = this.write;
			int k = (q < this.read) ? (this.read - q - 1) : (this.end - q);
			int t;
			for (;;)
			{
				switch (this.mode)
				{
				case 0:
					while (j < 3)
					{
						if (i == 0)
						{
							goto IL_8C;
						}
						r = 0;
						i--;
						b |= (int)(z.next_in[p++] & byte.MaxValue) << j;
						j += 8;
					}
					t = (b & 7);
					this.last = (t & 1);
					switch (t >> 1)
					{
					case 0:
						b >>= 3;
						j -= 3;
						t = (j & 7);
						b >>= t;
						j -= t;
						this.mode = 1;
						continue;
					case 1:
					{
						int[] bl = new int[1];
						int[] bd = new int[1];
						int[][] tl = new int[1][];
						int[][] td = new int[1][];
						global::Org.BouncyCastle.Utilities.Zlib.InfTree.inflate_trees_fixed(bl, bd, tl, td, z);
						this.codes.init(bl[0], bd[0], tl[0], 0, td[0], 0, z);
						b >>= 3;
						j -= 3;
						this.mode = 6;
						continue;
					}
					case 2:
						b >>= 3;
						j -= 3;
						this.mode = 3;
						continue;
					case 3:
						goto IL_1BE;
					default:
						continue;
					}
					break;
				case 1:
					while (j < 32)
					{
						if (i == 0)
						{
							goto IL_22A;
						}
						r = 0;
						i--;
						b |= (int)(z.next_in[p++] & byte.MaxValue) << j;
						j += 8;
					}
					if ((~b >> 16 & 65535) != (b & 65535))
					{
						goto Block_8;
					}
					this.left = (b & 65535);
					j = (b = 0);
					this.mode = ((this.left != 0) ? 2 : ((this.last != 0) ? 7 : 0));
					continue;
				case 2:
					if (i == 0)
					{
						goto Block_11;
					}
					if (k == 0)
					{
						if (q == this.end && this.read != 0)
						{
							q = 0;
							k = ((q < this.read) ? (this.read - q - 1) : (this.end - q));
						}
						if (k == 0)
						{
							this.write = q;
							r = this.inflate_flush(z, r);
							q = this.write;
							k = ((q < this.read) ? (this.read - q - 1) : (this.end - q));
							if (q == this.end && this.read != 0)
							{
								q = 0;
								k = ((q < this.read) ? (this.read - q - 1) : (this.end - q));
							}
							if (k == 0)
							{
								goto Block_21;
							}
						}
					}
					r = 0;
					t = this.left;
					if (t > i)
					{
						t = i;
					}
					if (t > k)
					{
						t = k;
					}
					global::System.Array.Copy(z.next_in, p, this.window, q, t);
					p += t;
					i -= t;
					q += t;
					k -= t;
					if ((this.left -= t) == 0)
					{
						this.mode = ((this.last != 0) ? 7 : 0);
						continue;
					}
					continue;
				case 3:
					while (j < 14)
					{
						if (i == 0)
						{
							goto IL_4FE;
						}
						r = 0;
						i--;
						b |= (int)(z.next_in[p++] & byte.MaxValue) << j;
						j += 8;
					}
					t = (this.table = (b & 16383));
					if ((t & 31) > 29 || (t >> 5 & 31) > 29)
					{
						goto IL_58C;
					}
					t = 258 + (t & 31) + (t >> 5 & 31);
					if (this.blens == null || this.blens.Length < t)
					{
						this.blens = new int[t];
					}
					else
					{
						for (int l = 0; l < t; l++)
						{
							this.blens[l] = 0;
						}
					}
					b >>= 14;
					j -= 14;
					this.index = 0;
					this.mode = 4;
					goto IL_6F2;
				case 4:
					goto IL_6F2;
				case 5:
					goto IL_7CD;
				case 6:
					goto IL_B74;
				case 7:
					goto IL_C3D;
				case 8:
					goto IL_CD2;
				case 9:
					goto IL_D19;
				}
				break;
				IL_6F2:
				while (this.index < 4 + (this.table >> 10))
				{
					while (j < 3)
					{
						if (i == 0)
						{
							goto IL_65A;
						}
						r = 0;
						i--;
						b |= (int)(z.next_in[p++] & byte.MaxValue) << j;
						j += 8;
					}
					int[] array = this.blens;
					int[] array2 = global::Org.BouncyCastle.Utilities.Zlib.InfBlocks.border;
					int num = this.index;
					this.index = num + 1;
					array[array2[num]] = (b & 7);
					b >>= 3;
					j -= 3;
				}
				while (this.index < 19)
				{
					int[] array3 = this.blens;
					int[] array4 = global::Org.BouncyCastle.Utilities.Zlib.InfBlocks.border;
					int num = this.index;
					this.index = num + 1;
					array3[array4[num]] = 0;
				}
				this.bb[0] = 7;
				t = this.inftree.inflate_trees_bits(this.blens, this.bb, this.tb, this.hufts, z);
				if (t != 0)
				{
					goto Block_34;
				}
				this.index = 0;
				this.mode = 5;
				for (;;)
				{
					IL_7CD:
					t = this.table;
					if (this.index >= 258 + (t & 31) + (t >> 5 & 31))
					{
						break;
					}
					t = this.bb[0];
					while (j < t)
					{
						if (i == 0)
						{
							goto IL_804;
						}
						r = 0;
						i--;
						b |= (int)(z.next_in[p++] & byte.MaxValue) << j;
						j += 8;
					}
					int num2 = this.tb[0];
					t = this.hufts[(this.tb[0] + (b & global::Org.BouncyCastle.Utilities.Zlib.InfBlocks.inflate_mask[t])) * 3 + 1];
					int c = this.hufts[(this.tb[0] + (b & global::Org.BouncyCastle.Utilities.Zlib.InfBlocks.inflate_mask[t])) * 3 + 2];
					if (c < 16)
					{
						b >>= t;
						j -= t;
						int[] array5 = this.blens;
						int num = this.index;
						this.index = num + 1;
						array5[num] = c;
					}
					else
					{
						int m = (c == 18) ? 7 : (c - 14);
						int n = (c == 18) ? 11 : 3;
						while (j < t + m)
						{
							if (i == 0)
							{
								goto IL_913;
							}
							r = 0;
							i--;
							b |= (int)(z.next_in[p++] & byte.MaxValue) << j;
							j += 8;
						}
						b >>= t;
						j -= t;
						n += (b & global::Org.BouncyCastle.Utilities.Zlib.InfBlocks.inflate_mask[m]);
						b >>= m;
						j -= m;
						m = this.index;
						t = this.table;
						if (m + n > 258 + (t & 31) + (t >> 5 & 31) || (c == 16 && m < 1))
						{
							goto IL_9DB;
						}
						c = ((c == 16) ? this.blens[m - 1] : 0);
						do
						{
							this.blens[m++] = c;
						}
						while (--n != 0);
						this.index = m;
					}
				}
				this.tb[0] = -1;
				int[] bl2 = new int[1];
				int[] bd2 = new int[1];
				int[] tl2 = new int[1];
				int[] td2 = new int[1];
				bl2[0] = 9;
				bd2[0] = 6;
				t = this.table;
				t = this.inftree.inflate_trees_dynamic(257 + (t & 31), 1 + (t >> 5 & 31), this.blens, bl2, bd2, tl2, td2, this.hufts, z);
				if (t != 0)
				{
					goto Block_48;
				}
				this.codes.init(bl2[0], bd2[0], this.hufts, tl2[0], this.hufts, td2[0], z);
				this.mode = 6;
				IL_B74:
				this.bitb = b;
				this.bitk = j;
				z.avail_in = i;
				z.total_in += (long)(p - z.next_in_index);
				z.next_in_index = p;
				this.write = q;
				if ((r = this.codes.proc(this, z, r)) != 1)
				{
					goto Block_50;
				}
				r = 0;
				this.codes.free(z);
				p = z.next_in_index;
				i = z.avail_in;
				b = this.bitb;
				j = this.bitk;
				q = this.write;
				k = ((q < this.read) ? (this.read - q - 1) : (this.end - q));
				if (this.last != 0)
				{
					goto IL_C36;
				}
				this.mode = 0;
			}
			r = -2;
			this.bitb = b;
			this.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			this.write = q;
			return this.inflate_flush(z, r);
			IL_8C:
			this.bitb = b;
			this.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			this.write = q;
			return this.inflate_flush(z, r);
			IL_1BE:
			b >>= 3;
			j -= 3;
			this.mode = 9;
			z.msg = "invalid block type";
			r = -3;
			this.bitb = b;
			this.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			this.write = q;
			return this.inflate_flush(z, r);
			IL_22A:
			this.bitb = b;
			this.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			this.write = q;
			return this.inflate_flush(z, r);
			Block_8:
			this.mode = 9;
			z.msg = "invalid stored block lengths";
			r = -3;
			this.bitb = b;
			this.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			this.write = q;
			return this.inflate_flush(z, r);
			Block_11:
			this.bitb = b;
			this.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			this.write = q;
			return this.inflate_flush(z, r);
			Block_21:
			this.bitb = b;
			this.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			this.write = q;
			return this.inflate_flush(z, r);
			IL_4FE:
			this.bitb = b;
			this.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			this.write = q;
			return this.inflate_flush(z, r);
			IL_58C:
			this.mode = 9;
			z.msg = "too many length or distance symbols";
			r = -3;
			this.bitb = b;
			this.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			this.write = q;
			return this.inflate_flush(z, r);
			IL_65A:
			this.bitb = b;
			this.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			this.write = q;
			return this.inflate_flush(z, r);
			Block_34:
			r = t;
			if (r == -3)
			{
				this.blens = null;
				this.mode = 9;
			}
			this.bitb = b;
			this.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			this.write = q;
			return this.inflate_flush(z, r);
			IL_804:
			this.bitb = b;
			this.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			this.write = q;
			return this.inflate_flush(z, r);
			IL_913:
			this.bitb = b;
			this.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			this.write = q;
			return this.inflate_flush(z, r);
			IL_9DB:
			this.blens = null;
			this.mode = 9;
			z.msg = "invalid bit length repeat";
			r = -3;
			this.bitb = b;
			this.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			this.write = q;
			return this.inflate_flush(z, r);
			Block_48:
			if (t == -3)
			{
				this.blens = null;
				this.mode = 9;
			}
			r = t;
			this.bitb = b;
			this.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			this.write = q;
			return this.inflate_flush(z, r);
			Block_50:
			return this.inflate_flush(z, r);
			IL_C36:
			this.mode = 7;
			IL_C3D:
			this.write = q;
			r = this.inflate_flush(z, r);
			q = this.write;
			int num3 = (q < this.read) ? (this.read - q - 1) : (this.end - q);
			if (this.read != this.write)
			{
				this.bitb = b;
				this.bitk = j;
				z.avail_in = i;
				z.total_in += (long)(p - z.next_in_index);
				z.next_in_index = p;
				this.write = q;
				return this.inflate_flush(z, r);
			}
			this.mode = 8;
			IL_CD2:
			r = 1;
			this.bitb = b;
			this.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			this.write = q;
			return this.inflate_flush(z, r);
			IL_D19:
			r = -3;
			this.bitb = b;
			this.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			this.write = q;
			return this.inflate_flush(z, r);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000FE65 File Offset: 0x0000E065
		internal void free(global::Org.BouncyCastle.Utilities.Zlib.ZStream z)
		{
			this.reset(z, null);
			this.window = null;
			this.hufts = null;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000FE80 File Offset: 0x0000E080
		internal void set_dictionary(byte[] d, int start, int n)
		{
			global::System.Array.Copy(d, start, this.window, 0, n);
			this.write = n;
			this.read = n;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000FEAC File Offset: 0x0000E0AC
		internal int sync_point()
		{
			if (this.mode != 1)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000FEBC File Offset: 0x0000E0BC
		internal int inflate_flush(global::Org.BouncyCastle.Utilities.Zlib.ZStream z, int r)
		{
			int p = z.next_out_index;
			int q = this.read;
			int i = ((q <= this.write) ? this.write : this.end) - q;
			if (i > z.avail_out)
			{
				i = z.avail_out;
			}
			if (i != 0 && r == -5)
			{
				r = 0;
			}
			z.avail_out -= i;
			z.total_out += (long)i;
			if (this.checkfn != null)
			{
				z.adler = (this.check = z._adler.adler32(this.check, this.window, q, i));
			}
			global::System.Array.Copy(this.window, q, z.next_out, p, i);
			p += i;
			q += i;
			if (q == this.end)
			{
				q = 0;
				if (this.write == this.end)
				{
					this.write = 0;
				}
				i = this.write - q;
				if (i > z.avail_out)
				{
					i = z.avail_out;
				}
				if (i != 0 && r == -5)
				{
					r = 0;
				}
				z.avail_out -= i;
				z.total_out += (long)i;
				if (this.checkfn != null)
				{
					z.adler = (this.check = z._adler.adler32(this.check, this.window, q, i));
				}
				global::System.Array.Copy(this.window, q, z.next_out, p, i);
				p += i;
				q += i;
			}
			z.next_out_index = p;
			this.read = q;
			return r;
		}

		// Token: 0x0400016D RID: 365
		private const int MANY = 1440;

		// Token: 0x0400016E RID: 366
		private static readonly int[] inflate_mask = new int[]
		{
			0,
			1,
			3,
			7,
			15,
			31,
			63,
			127,
			255,
			511,
			1023,
			2047,
			4095,
			8191,
			16383,
			32767,
			65535
		};

		// Token: 0x0400016F RID: 367
		private static readonly int[] border = new int[]
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

		// Token: 0x04000170 RID: 368
		private const int Z_OK = 0;

		// Token: 0x04000171 RID: 369
		private const int Z_STREAM_END = 1;

		// Token: 0x04000172 RID: 370
		private const int Z_NEED_DICT = 2;

		// Token: 0x04000173 RID: 371
		private const int Z_ERRNO = -1;

		// Token: 0x04000174 RID: 372
		private const int Z_STREAM_ERROR = -2;

		// Token: 0x04000175 RID: 373
		private const int Z_DATA_ERROR = -3;

		// Token: 0x04000176 RID: 374
		private const int Z_MEM_ERROR = -4;

		// Token: 0x04000177 RID: 375
		private const int Z_BUF_ERROR = -5;

		// Token: 0x04000178 RID: 376
		private const int Z_VERSION_ERROR = -6;

		// Token: 0x04000179 RID: 377
		private const int TYPE = 0;

		// Token: 0x0400017A RID: 378
		private const int LENS = 1;

		// Token: 0x0400017B RID: 379
		private const int STORED = 2;

		// Token: 0x0400017C RID: 380
		private const int TABLE = 3;

		// Token: 0x0400017D RID: 381
		private const int BTREE = 4;

		// Token: 0x0400017E RID: 382
		private const int DTREE = 5;

		// Token: 0x0400017F RID: 383
		private const int CODES = 6;

		// Token: 0x04000180 RID: 384
		private const int DRY = 7;

		// Token: 0x04000181 RID: 385
		private const int DONE = 8;

		// Token: 0x04000182 RID: 386
		private const int BAD = 9;

		// Token: 0x04000183 RID: 387
		internal int mode;

		// Token: 0x04000184 RID: 388
		internal int left;

		// Token: 0x04000185 RID: 389
		internal int table;

		// Token: 0x04000186 RID: 390
		internal int index;

		// Token: 0x04000187 RID: 391
		internal int[] blens;

		// Token: 0x04000188 RID: 392
		internal int[] bb = new int[1];

		// Token: 0x04000189 RID: 393
		internal int[] tb = new int[1];

		// Token: 0x0400018A RID: 394
		internal global::Org.BouncyCastle.Utilities.Zlib.InfCodes codes = new global::Org.BouncyCastle.Utilities.Zlib.InfCodes();

		// Token: 0x0400018B RID: 395
		private int last;

		// Token: 0x0400018C RID: 396
		internal int bitk;

		// Token: 0x0400018D RID: 397
		internal int bitb;

		// Token: 0x0400018E RID: 398
		internal int[] hufts;

		// Token: 0x0400018F RID: 399
		internal byte[] window;

		// Token: 0x04000190 RID: 400
		internal int end;

		// Token: 0x04000191 RID: 401
		internal int read;

		// Token: 0x04000192 RID: 402
		internal int write;

		// Token: 0x04000193 RID: 403
		internal object checkfn;

		// Token: 0x04000194 RID: 404
		internal long check;

		// Token: 0x04000195 RID: 405
		internal global::Org.BouncyCastle.Utilities.Zlib.InfTree inftree = new global::Org.BouncyCastle.Utilities.Zlib.InfTree();
	}
}
