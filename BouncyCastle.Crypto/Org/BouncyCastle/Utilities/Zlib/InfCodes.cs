using System;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x02000040 RID: 64
	internal sealed class InfCodes
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x00010064 File Offset: 0x0000E264
		internal InfCodes()
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0001006C File Offset: 0x0000E26C
		internal void init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, global::Org.BouncyCastle.Utilities.Zlib.ZStream z)
		{
			this.mode = 0;
			this.lbits = (byte)bl;
			this.dbits = (byte)bd;
			this.ltree = tl;
			this.ltree_index = tl_index;
			this.dtree = td;
			this.dtree_index = td_index;
			this.tree = null;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000100AC File Offset: 0x0000E2AC
		internal int proc(global::Org.BouncyCastle.Utilities.Zlib.InfBlocks s, global::Org.BouncyCastle.Utilities.Zlib.ZStream z, int r)
		{
			int p = z.next_in_index;
			int i = z.avail_in;
			int b = s.bitb;
			int j = s.bitk;
			int q = s.write;
			int k = (q < s.read) ? (s.read - q - 1) : (s.end - q);
			for (;;)
			{
				int l;
				switch (this.mode)
				{
				case 0:
					if (k >= 258 && i >= 10)
					{
						s.bitb = b;
						s.bitk = j;
						z.avail_in = i;
						z.total_in += (long)(p - z.next_in_index);
						z.next_in_index = p;
						s.write = q;
						r = this.inflate_fast((int)this.lbits, (int)this.dbits, this.ltree, this.ltree_index, this.dtree, this.dtree_index, s, z);
						p = z.next_in_index;
						i = z.avail_in;
						b = s.bitb;
						j = s.bitk;
						q = s.write;
						k = ((q < s.read) ? (s.read - q - 1) : (s.end - q));
						if (r != 0)
						{
							this.mode = ((r == 1) ? 7 : 9);
							continue;
						}
					}
					this.need = (int)this.lbits;
					this.tree = this.ltree;
					this.tree_index = this.ltree_index;
					this.mode = 1;
					goto IL_199;
				case 1:
					goto IL_199;
				case 2:
					l = this.get;
					while (j < l)
					{
						if (i == 0)
						{
							goto IL_34E;
						}
						r = 0;
						i--;
						b |= (int)(z.next_in[p++] & byte.MaxValue) << j;
						j += 8;
					}
					this.len += (b & global::Org.BouncyCastle.Utilities.Zlib.InfCodes.inflate_mask[l]);
					b >>= l;
					j -= l;
					this.need = (int)this.dbits;
					this.tree = this.dtree;
					this.tree_index = this.dtree_index;
					this.mode = 3;
					goto IL_411;
				case 3:
					goto IL_411;
				case 4:
					l = this.get;
					while (j < l)
					{
						if (i == 0)
						{
							goto IL_595;
						}
						r = 0;
						i--;
						b |= (int)(z.next_in[p++] & byte.MaxValue) << j;
						j += 8;
					}
					this.dist += (b & global::Org.BouncyCastle.Utilities.Zlib.InfCodes.inflate_mask[l]);
					b >>= l;
					j -= l;
					this.mode = 5;
					goto IL_634;
				case 5:
					goto IL_634;
				case 6:
					if (k == 0)
					{
						if (q == s.end && s.read != 0)
						{
							q = 0;
							k = ((q < s.read) ? (s.read - q - 1) : (s.end - q));
						}
						if (k == 0)
						{
							s.write = q;
							r = s.inflate_flush(z, r);
							q = s.write;
							k = ((q < s.read) ? (s.read - q - 1) : (s.end - q));
							if (q == s.end && s.read != 0)
							{
								q = 0;
								k = ((q < s.read) ? (s.read - q - 1) : (s.end - q));
							}
							if (k == 0)
							{
								goto Block_44;
							}
						}
					}
					r = 0;
					s.window[q++] = (byte)this.lit;
					k--;
					this.mode = 0;
					continue;
				case 7:
					goto IL_8DA;
				case 8:
					goto IL_989;
				case 9:
					goto IL_9D3;
				}
				break;
				IL_199:
				l = this.need;
				while (j < l)
				{
					if (i == 0)
					{
						goto IL_1AB;
					}
					r = 0;
					i--;
					b |= (int)(z.next_in[p++] & byte.MaxValue) << j;
					j += 8;
				}
				int tindex = (this.tree_index + (b & global::Org.BouncyCastle.Utilities.Zlib.InfCodes.inflate_mask[l])) * 3;
				b >>= this.tree[tindex + 1];
				j -= this.tree[tindex + 1];
				int e = this.tree[tindex];
				if (e == 0)
				{
					this.lit = this.tree[tindex + 2];
					this.mode = 6;
					continue;
				}
				if ((e & 16) != 0)
				{
					this.get = (e & 15);
					this.len = this.tree[tindex + 2];
					this.mode = 2;
					continue;
				}
				if ((e & 64) == 0)
				{
					this.need = e;
					this.tree_index = tindex / 3 + this.tree[tindex + 2];
					continue;
				}
				if ((e & 32) != 0)
				{
					this.mode = 7;
					continue;
				}
				goto IL_2DE;
				IL_411:
				l = this.need;
				while (j < l)
				{
					if (i == 0)
					{
						goto IL_423;
					}
					r = 0;
					i--;
					b |= (int)(z.next_in[p++] & byte.MaxValue) << j;
					j += 8;
				}
				tindex = (this.tree_index + (b & global::Org.BouncyCastle.Utilities.Zlib.InfCodes.inflate_mask[l])) * 3;
				b >>= this.tree[tindex + 1];
				j -= this.tree[tindex + 1];
				e = this.tree[tindex];
				if ((e & 16) != 0)
				{
					this.get = (e & 15);
					this.dist = this.tree[tindex + 2];
					this.mode = 4;
					continue;
				}
				if ((e & 64) == 0)
				{
					this.need = e;
					this.tree_index = tindex / 3 + this.tree[tindex + 2];
					continue;
				}
				goto IL_525;
				IL_634:
				int f;
				for (f = q - this.dist; f < 0; f += s.end)
				{
				}
				while (this.len != 0)
				{
					if (k == 0)
					{
						if (q == s.end && s.read != 0)
						{
							q = 0;
							k = ((q < s.read) ? (s.read - q - 1) : (s.end - q));
						}
						if (k == 0)
						{
							s.write = q;
							r = s.inflate_flush(z, r);
							q = s.write;
							k = ((q < s.read) ? (s.read - q - 1) : (s.end - q));
							if (q == s.end && s.read != 0)
							{
								q = 0;
								k = ((q < s.read) ? (s.read - q - 1) : (s.end - q));
							}
							if (k == 0)
							{
								goto Block_32;
							}
						}
					}
					s.window[q++] = s.window[f++];
					k--;
					if (f == s.end)
					{
						f = 0;
					}
					this.len--;
				}
				this.mode = 0;
			}
			r = -2;
			s.bitb = b;
			s.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			s.write = q;
			return s.inflate_flush(z, r);
			IL_1AB:
			s.bitb = b;
			s.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			s.write = q;
			return s.inflate_flush(z, r);
			IL_2DE:
			this.mode = 9;
			z.msg = "invalid literal/length code";
			r = -3;
			s.bitb = b;
			s.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			s.write = q;
			return s.inflate_flush(z, r);
			IL_34E:
			s.bitb = b;
			s.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			s.write = q;
			return s.inflate_flush(z, r);
			IL_423:
			s.bitb = b;
			s.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			s.write = q;
			return s.inflate_flush(z, r);
			IL_525:
			this.mode = 9;
			z.msg = "invalid distance code";
			r = -3;
			s.bitb = b;
			s.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			s.write = q;
			return s.inflate_flush(z, r);
			IL_595:
			s.bitb = b;
			s.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			s.write = q;
			return s.inflate_flush(z, r);
			Block_32:
			s.bitb = b;
			s.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			s.write = q;
			return s.inflate_flush(z, r);
			Block_44:
			s.bitb = b;
			s.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			s.write = q;
			return s.inflate_flush(z, r);
			IL_8DA:
			if (j > 7)
			{
				j -= 8;
				i++;
				p--;
			}
			s.write = q;
			r = s.inflate_flush(z, r);
			q = s.write;
			int num = (q < s.read) ? (s.read - q - 1) : (s.end - q);
			if (s.read != s.write)
			{
				s.bitb = b;
				s.bitk = j;
				z.avail_in = i;
				z.total_in += (long)(p - z.next_in_index);
				z.next_in_index = p;
				s.write = q;
				return s.inflate_flush(z, r);
			}
			this.mode = 8;
			IL_989:
			r = 1;
			s.bitb = b;
			s.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			s.write = q;
			return s.inflate_flush(z, r);
			IL_9D3:
			r = -3;
			s.bitb = b;
			s.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			s.write = q;
			return s.inflate_flush(z, r);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00010B21 File Offset: 0x0000ED21
		internal void free(global::Org.BouncyCastle.Utilities.Zlib.ZStream z)
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00010B24 File Offset: 0x0000ED24
		internal int inflate_fast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, global::Org.BouncyCastle.Utilities.Zlib.InfBlocks s, global::Org.BouncyCastle.Utilities.Zlib.ZStream z)
		{
			int p = z.next_in_index;
			int i = z.avail_in;
			int b = s.bitb;
			int j = s.bitk;
			int q = s.write;
			int k = (q < s.read) ? (s.read - q - 1) : (s.end - q);
			int ml = global::Org.BouncyCastle.Utilities.Zlib.InfCodes.inflate_mask[bl];
			int md = global::Org.BouncyCastle.Utilities.Zlib.InfCodes.inflate_mask[bd];
			int e;
			int c;
			for (;;)
			{
				if (j >= 20)
				{
					int t = b & ml;
					int tp_index_t_3 = (tl_index + t) * 3;
					if ((e = tl[tp_index_t_3]) == 0)
					{
						b >>= tl[tp_index_t_3 + 1];
						j -= tl[tp_index_t_3 + 1];
						s.window[q++] = (byte)tl[tp_index_t_3 + 2];
						k--;
					}
					else
					{
						for (;;)
						{
							b >>= tl[tp_index_t_3 + 1];
							j -= tl[tp_index_t_3 + 1];
							if ((e & 16) != 0)
							{
								break;
							}
							if ((e & 64) != 0)
							{
								goto IL_4B3;
							}
							t += tl[tp_index_t_3 + 2];
							t += (b & global::Org.BouncyCastle.Utilities.Zlib.InfCodes.inflate_mask[e]);
							tp_index_t_3 = (tl_index + t) * 3;
							if ((e = tl[tp_index_t_3]) == 0)
							{
								goto Block_20;
							}
						}
						e &= 15;
						c = tl[tp_index_t_3 + 2] + (b & global::Org.BouncyCastle.Utilities.Zlib.InfCodes.inflate_mask[e]);
						b >>= e;
						for (j -= e; j < 15; j += 8)
						{
							i--;
							b |= (int)(z.next_in[p++] & byte.MaxValue) << j;
						}
						t = (b & md);
						tp_index_t_3 = (td_index + t) * 3;
						e = td[tp_index_t_3];
						for (;;)
						{
							b >>= td[tp_index_t_3 + 1];
							j -= td[tp_index_t_3 + 1];
							if ((e & 16) != 0)
							{
								break;
							}
							if ((e & 64) != 0)
							{
								goto IL_3C1;
							}
							t += td[tp_index_t_3 + 2];
							t += (b & global::Org.BouncyCastle.Utilities.Zlib.InfCodes.inflate_mask[e]);
							tp_index_t_3 = (td_index + t) * 3;
							e = td[tp_index_t_3];
						}
						e &= 15;
						while (j < e)
						{
							i--;
							b |= (int)(z.next_in[p++] & byte.MaxValue) << j;
							j += 8;
						}
						int d = td[tp_index_t_3 + 2] + (b & global::Org.BouncyCastle.Utilities.Zlib.InfCodes.inflate_mask[e]);
						b >>= e;
						j -= e;
						k -= c;
						int r;
						if (q >= d)
						{
							r = q - d;
							if (q - r > 0 && 2 > q - r)
							{
								s.window[q++] = s.window[r++];
								s.window[q++] = s.window[r++];
								c -= 2;
							}
							else
							{
								global::System.Array.Copy(s.window, r, s.window, q, 2);
								q += 2;
								r += 2;
								c -= 2;
							}
						}
						else
						{
							r = q - d;
							do
							{
								r += s.end;
							}
							while (r < 0);
							e = s.end - r;
							if (c > e)
							{
								c -= e;
								if (q - r > 0 && e > q - r)
								{
									do
									{
										s.window[q++] = s.window[r++];
									}
									while (--e != 0);
								}
								else
								{
									global::System.Array.Copy(s.window, r, s.window, q, e);
									q += e;
									r += e;
								}
								r = 0;
							}
						}
						if (q - r > 0 && c > q - r)
						{
							do
							{
								s.window[q++] = s.window[r++];
							}
							while (--c != 0);
							goto IL_5C0;
						}
						global::System.Array.Copy(s.window, r, s.window, q, c);
						q += c;
						r += c;
						goto IL_5C0;
						Block_20:
						b >>= tl[tp_index_t_3 + 1];
						j -= tl[tp_index_t_3 + 1];
						s.window[q++] = (byte)tl[tp_index_t_3 + 2];
						k--;
					}
					IL_5C0:
					if (k < 258 || i < 10)
					{
						goto IL_5D2;
					}
				}
				else
				{
					i--;
					b |= (int)(z.next_in[p++] & byte.MaxValue) << j;
					j += 8;
				}
			}
			IL_3C1:
			z.msg = "invalid distance code";
			c = z.avail_in - i;
			c = ((j >> 3 < c) ? (j >> 3) : c);
			i += c;
			p -= c;
			j -= c << 3;
			s.bitb = b;
			s.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			s.write = q;
			return -3;
			IL_4B3:
			if ((e & 32) != 0)
			{
				c = z.avail_in - i;
				c = ((j >> 3 < c) ? (j >> 3) : c);
				i += c;
				p -= c;
				j -= c << 3;
				s.bitb = b;
				s.bitk = j;
				z.avail_in = i;
				z.total_in += (long)(p - z.next_in_index);
				z.next_in_index = p;
				s.write = q;
				return 1;
			}
			z.msg = "invalid literal/length code";
			c = z.avail_in - i;
			c = ((j >> 3 < c) ? (j >> 3) : c);
			i += c;
			p -= c;
			j -= c << 3;
			s.bitb = b;
			s.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			s.write = q;
			return -3;
			IL_5D2:
			c = z.avail_in - i;
			c = ((j >> 3 < c) ? (j >> 3) : c);
			i += c;
			p -= c;
			j -= c << 3;
			s.bitb = b;
			s.bitk = j;
			z.avail_in = i;
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			s.write = q;
			return 0;
		}

		// Token: 0x04000196 RID: 406
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

		// Token: 0x04000197 RID: 407
		private const int Z_OK = 0;

		// Token: 0x04000198 RID: 408
		private const int Z_STREAM_END = 1;

		// Token: 0x04000199 RID: 409
		private const int Z_NEED_DICT = 2;

		// Token: 0x0400019A RID: 410
		private const int Z_ERRNO = -1;

		// Token: 0x0400019B RID: 411
		private const int Z_STREAM_ERROR = -2;

		// Token: 0x0400019C RID: 412
		private const int Z_DATA_ERROR = -3;

		// Token: 0x0400019D RID: 413
		private const int Z_MEM_ERROR = -4;

		// Token: 0x0400019E RID: 414
		private const int Z_BUF_ERROR = -5;

		// Token: 0x0400019F RID: 415
		private const int Z_VERSION_ERROR = -6;

		// Token: 0x040001A0 RID: 416
		private const int START = 0;

		// Token: 0x040001A1 RID: 417
		private const int LEN = 1;

		// Token: 0x040001A2 RID: 418
		private const int LENEXT = 2;

		// Token: 0x040001A3 RID: 419
		private const int DIST = 3;

		// Token: 0x040001A4 RID: 420
		private const int DISTEXT = 4;

		// Token: 0x040001A5 RID: 421
		private const int COPY = 5;

		// Token: 0x040001A6 RID: 422
		private const int LIT = 6;

		// Token: 0x040001A7 RID: 423
		private const int WASH = 7;

		// Token: 0x040001A8 RID: 424
		private const int END = 8;

		// Token: 0x040001A9 RID: 425
		private const int BADCODE = 9;

		// Token: 0x040001AA RID: 426
		private int mode;

		// Token: 0x040001AB RID: 427
		private int len;

		// Token: 0x040001AC RID: 428
		private int[] tree;

		// Token: 0x040001AD RID: 429
		private int tree_index;

		// Token: 0x040001AE RID: 430
		private int need;

		// Token: 0x040001AF RID: 431
		private int lit;

		// Token: 0x040001B0 RID: 432
		private int get;

		// Token: 0x040001B1 RID: 433
		private int dist;

		// Token: 0x040001B2 RID: 434
		private byte lbits;

		// Token: 0x040001B3 RID: 435
		private byte dbits;

		// Token: 0x040001B4 RID: 436
		private int[] ltree;

		// Token: 0x040001B5 RID: 437
		private int ltree_index;

		// Token: 0x040001B6 RID: 438
		private int[] dtree;

		// Token: 0x040001B7 RID: 439
		private int dtree_index;
	}
}
