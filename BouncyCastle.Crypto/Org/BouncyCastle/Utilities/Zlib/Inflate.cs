using System;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x02000041 RID: 65
	internal sealed class Inflate
	{
		// Token: 0x060002F8 RID: 760 RVA: 0x00011198 File Offset: 0x0000F398
		internal int inflateReset(global::Org.BouncyCastle.Utilities.Zlib.ZStream z)
		{
			if (z == null || z.istate == null)
			{
				return -2;
			}
			z.total_in = (z.total_out = 0L);
			z.msg = null;
			z.istate.mode = ((z.istate.nowrap != 0) ? 7 : 0);
			z.istate.blocks.reset(z, null);
			return 0;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x000111FA File Offset: 0x0000F3FA
		internal int inflateEnd(global::Org.BouncyCastle.Utilities.Zlib.ZStream z)
		{
			if (this.blocks != null)
			{
				this.blocks.free(z);
			}
			this.blocks = null;
			return 0;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00011218 File Offset: 0x0000F418
		internal int inflateInit(global::Org.BouncyCastle.Utilities.Zlib.ZStream z, int w)
		{
			z.msg = null;
			this.blocks = null;
			this.nowrap = 0;
			if (w < 0)
			{
				w = -w;
				this.nowrap = 1;
			}
			if (w < 8 || w > 15)
			{
				this.inflateEnd(z);
				return -2;
			}
			this.wbits = w;
			z.istate.blocks = new global::Org.BouncyCastle.Utilities.Zlib.InfBlocks(z, (z.istate.nowrap != 0) ? null : this, 1 << w);
			this.inflateReset(z);
			return 0;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00011298 File Offset: 0x0000F498
		internal int inflate(global::Org.BouncyCastle.Utilities.Zlib.ZStream z, int f)
		{
			if (z == null || z.istate == null || z.next_in == null)
			{
				return -2;
			}
			f = ((f == 4) ? -5 : 0);
			int r = -5;
			int next_in_index;
			for (;;)
			{
				switch (z.istate.mode)
				{
				case 0:
				{
					if (z.avail_in == 0)
					{
						return r;
					}
					r = f;
					z.avail_in--;
					z.total_in += 1L;
					global::Org.BouncyCastle.Utilities.Zlib.Inflate istate = z.istate;
					byte[] next_in = z.next_in;
					next_in_index = z.next_in_index;
					z.next_in_index = next_in_index + 1;
					if (((istate.method = next_in[next_in_index]) & 15) != 8)
					{
						z.istate.mode = 13;
						z.msg = "unknown compression method";
						z.istate.marker = 5;
						continue;
					}
					if ((z.istate.method >> 4) + 8 > z.istate.wbits)
					{
						z.istate.mode = 13;
						z.msg = "invalid window size";
						z.istate.marker = 5;
						continue;
					}
					z.istate.mode = 1;
					goto IL_142;
				}
				case 1:
					goto IL_142;
				case 2:
					goto IL_1EA;
				case 3:
					goto IL_253;
				case 4:
					goto IL_2C3;
				case 5:
					goto IL_332;
				case 6:
					goto IL_3AC;
				case 7:
					r = z.istate.blocks.proc(z, r);
					if (r == -3)
					{
						z.istate.mode = 13;
						z.istate.marker = 0;
						continue;
					}
					if (r == 0)
					{
						r = f;
					}
					if (r != 1)
					{
						return r;
					}
					r = f;
					z.istate.blocks.reset(z, z.istate.was);
					if (z.istate.nowrap != 0)
					{
						z.istate.mode = 12;
						continue;
					}
					z.istate.mode = 8;
					goto IL_45D;
				case 8:
					goto IL_45D;
				case 9:
					goto IL_4C7;
				case 10:
					goto IL_538;
				case 11:
					goto IL_5A8;
				case 12:
					return 1;
				case 13:
					return -3;
				}
				break;
				IL_142:
				if (z.avail_in == 0)
				{
					return r;
				}
				r = f;
				z.avail_in--;
				z.total_in += 1L;
				byte[] next_in2 = z.next_in;
				next_in_index = z.next_in_index;
				z.next_in_index = next_in_index + 1;
				int b = next_in2[next_in_index] & 255;
				if (((z.istate.method << 8) + b) % 31 != 0)
				{
					z.istate.mode = 13;
					z.msg = "incorrect header check";
					z.istate.marker = 5;
					continue;
				}
				if ((b & 32) == 0)
				{
					z.istate.mode = 7;
					continue;
				}
				goto IL_1DE;
				IL_5A8:
				if (z.avail_in == 0)
				{
					return r;
				}
				r = f;
				z.avail_in--;
				z.total_in += 1L;
				global::Org.BouncyCastle.Utilities.Zlib.Inflate istate2 = z.istate;
				long num = istate2.need;
				byte[] next_in3 = z.next_in;
				next_in_index = z.next_in_index;
				z.next_in_index = next_in_index + 1;
				istate2.need = num + (long)(next_in3[next_in_index] & 255UL);
				if ((int)z.istate.was[0] != (int)z.istate.need)
				{
					z.istate.mode = 13;
					z.msg = "incorrect data check";
					z.istate.marker = 5;
					continue;
				}
				goto IL_648;
				IL_538:
				if (z.avail_in == 0)
				{
					return r;
				}
				r = f;
				z.avail_in--;
				z.total_in += 1L;
				global::Org.BouncyCastle.Utilities.Zlib.Inflate istate3 = z.istate;
				long num2 = istate3.need;
				byte[] next_in4 = z.next_in;
				next_in_index = z.next_in_index;
				z.next_in_index = next_in_index + 1;
				istate3.need = num2 + ((next_in4[next_in_index] & 255L) << 8 & 65280L);
				z.istate.mode = 11;
				goto IL_5A8;
				IL_4C7:
				if (z.avail_in == 0)
				{
					return r;
				}
				r = f;
				z.avail_in--;
				z.total_in += 1L;
				global::Org.BouncyCastle.Utilities.Zlib.Inflate istate4 = z.istate;
				long num3 = istate4.need;
				byte[] next_in5 = z.next_in;
				next_in_index = z.next_in_index;
				z.next_in_index = next_in_index + 1;
				istate4.need = num3 + ((next_in5[next_in_index] & 255L) << 16 & 16711680L);
				z.istate.mode = 10;
				goto IL_538;
				IL_45D:
				if (z.avail_in == 0)
				{
					return r;
				}
				r = f;
				z.avail_in--;
				z.total_in += 1L;
				global::Org.BouncyCastle.Utilities.Zlib.Inflate istate5 = z.istate;
				byte[] next_in6 = z.next_in;
				next_in_index = z.next_in_index;
				z.next_in_index = next_in_index + 1;
				istate5.need = ((next_in6[next_in_index] & 255L) << 24 & (long)((ulong)-16777216));
				z.istate.mode = 9;
				goto IL_4C7;
			}
			return -2;
			IL_1DE:
			z.istate.mode = 2;
			IL_1EA:
			if (z.avail_in == 0)
			{
				return r;
			}
			r = f;
			z.avail_in--;
			z.total_in += 1L;
			global::Org.BouncyCastle.Utilities.Zlib.Inflate istate6 = z.istate;
			byte[] next_in7 = z.next_in;
			next_in_index = z.next_in_index;
			z.next_in_index = next_in_index + 1;
			istate6.need = ((next_in7[next_in_index] & 255L) << 24 & (long)((ulong)-16777216));
			z.istate.mode = 3;
			IL_253:
			if (z.avail_in == 0)
			{
				return r;
			}
			r = f;
			z.avail_in--;
			z.total_in += 1L;
			global::Org.BouncyCastle.Utilities.Zlib.Inflate istate7 = z.istate;
			long num4 = istate7.need;
			byte[] next_in8 = z.next_in;
			next_in_index = z.next_in_index;
			z.next_in_index = next_in_index + 1;
			istate7.need = num4 + ((next_in8[next_in_index] & 255L) << 16 & 16711680L);
			z.istate.mode = 4;
			IL_2C3:
			if (z.avail_in == 0)
			{
				return r;
			}
			r = f;
			z.avail_in--;
			z.total_in += 1L;
			global::Org.BouncyCastle.Utilities.Zlib.Inflate istate8 = z.istate;
			long num5 = istate8.need;
			byte[] next_in9 = z.next_in;
			next_in_index = z.next_in_index;
			z.next_in_index = next_in_index + 1;
			istate8.need = num5 + ((next_in9[next_in_index] & 255L) << 8 & 65280L);
			z.istate.mode = 5;
			IL_332:
			if (z.avail_in == 0)
			{
				return r;
			}
			z.avail_in--;
			z.total_in += 1L;
			global::Org.BouncyCastle.Utilities.Zlib.Inflate istate9 = z.istate;
			long num6 = istate9.need;
			byte[] next_in10 = z.next_in;
			next_in_index = z.next_in_index;
			z.next_in_index = next_in_index + 1;
			istate9.need = num6 + (long)(next_in10[next_in_index] & 255UL);
			z.adler = z.istate.need;
			z.istate.mode = 6;
			return 2;
			IL_3AC:
			z.istate.mode = 13;
			z.msg = "need dictionary";
			z.istate.marker = 0;
			return -2;
			IL_648:
			z.istate.mode = 12;
			return 1;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00011904 File Offset: 0x0000FB04
		internal int inflateSetDictionary(global::Org.BouncyCastle.Utilities.Zlib.ZStream z, byte[] dictionary, int dictLength)
		{
			int index = 0;
			int length = dictLength;
			if (z == null || z.istate == null || z.istate.mode != 6)
			{
				return -2;
			}
			if (z._adler.adler32(1L, dictionary, 0, dictLength) != z.adler)
			{
				return -3;
			}
			z.adler = z._adler.adler32(0L, null, 0, 0);
			if (length >= 1 << z.istate.wbits)
			{
				length = (1 << z.istate.wbits) - 1;
				index = dictLength - length;
			}
			z.istate.blocks.set_dictionary(dictionary, index, length);
			z.istate.mode = 7;
			return 0;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x000119AC File Offset: 0x0000FBAC
		internal int inflateSync(global::Org.BouncyCastle.Utilities.Zlib.ZStream z)
		{
			if (z == null || z.istate == null)
			{
				return -2;
			}
			if (z.istate.mode != 13)
			{
				z.istate.mode = 13;
				z.istate.marker = 0;
			}
			int i;
			if ((i = z.avail_in) == 0)
			{
				return -5;
			}
			int p = z.next_in_index;
			int j = z.istate.marker;
			while (i != 0 && j < 4)
			{
				if (z.next_in[p] == global::Org.BouncyCastle.Utilities.Zlib.Inflate.mark[j])
				{
					j++;
				}
				else if (z.next_in[p] != 0)
				{
					j = 0;
				}
				else
				{
					j = 4 - j;
				}
				p++;
				i--;
			}
			z.total_in += (long)(p - z.next_in_index);
			z.next_in_index = p;
			z.avail_in = i;
			z.istate.marker = j;
			if (j != 4)
			{
				return -3;
			}
			long r = z.total_in;
			long w = z.total_out;
			this.inflateReset(z);
			z.total_in = r;
			z.total_out = w;
			z.istate.mode = 7;
			return 0;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00011AB3 File Offset: 0x0000FCB3
		internal int inflateSyncPoint(global::Org.BouncyCastle.Utilities.Zlib.ZStream z)
		{
			if (z == null || z.istate == null || z.istate.blocks == null)
			{
				return -2;
			}
			return z.istate.blocks.sync_point();
		}

		// Token: 0x040001B8 RID: 440
		private const int MAX_WBITS = 15;

		// Token: 0x040001B9 RID: 441
		private const int PRESET_DICT = 32;

		// Token: 0x040001BA RID: 442
		internal const int Z_NO_FLUSH = 0;

		// Token: 0x040001BB RID: 443
		internal const int Z_PARTIAL_FLUSH = 1;

		// Token: 0x040001BC RID: 444
		internal const int Z_SYNC_FLUSH = 2;

		// Token: 0x040001BD RID: 445
		internal const int Z_FULL_FLUSH = 3;

		// Token: 0x040001BE RID: 446
		internal const int Z_FINISH = 4;

		// Token: 0x040001BF RID: 447
		private const int Z_DEFLATED = 8;

		// Token: 0x040001C0 RID: 448
		private const int Z_OK = 0;

		// Token: 0x040001C1 RID: 449
		private const int Z_STREAM_END = 1;

		// Token: 0x040001C2 RID: 450
		private const int Z_NEED_DICT = 2;

		// Token: 0x040001C3 RID: 451
		private const int Z_ERRNO = -1;

		// Token: 0x040001C4 RID: 452
		private const int Z_STREAM_ERROR = -2;

		// Token: 0x040001C5 RID: 453
		private const int Z_DATA_ERROR = -3;

		// Token: 0x040001C6 RID: 454
		private const int Z_MEM_ERROR = -4;

		// Token: 0x040001C7 RID: 455
		private const int Z_BUF_ERROR = -5;

		// Token: 0x040001C8 RID: 456
		private const int Z_VERSION_ERROR = -6;

		// Token: 0x040001C9 RID: 457
		private const int METHOD = 0;

		// Token: 0x040001CA RID: 458
		private const int FLAG = 1;

		// Token: 0x040001CB RID: 459
		private const int DICT4 = 2;

		// Token: 0x040001CC RID: 460
		private const int DICT3 = 3;

		// Token: 0x040001CD RID: 461
		private const int DICT2 = 4;

		// Token: 0x040001CE RID: 462
		private const int DICT1 = 5;

		// Token: 0x040001CF RID: 463
		private const int DICT0 = 6;

		// Token: 0x040001D0 RID: 464
		private const int BLOCKS = 7;

		// Token: 0x040001D1 RID: 465
		private const int CHECK4 = 8;

		// Token: 0x040001D2 RID: 466
		private const int CHECK3 = 9;

		// Token: 0x040001D3 RID: 467
		private const int CHECK2 = 10;

		// Token: 0x040001D4 RID: 468
		private const int CHECK1 = 11;

		// Token: 0x040001D5 RID: 469
		private const int DONE = 12;

		// Token: 0x040001D6 RID: 470
		private const int BAD = 13;

		// Token: 0x040001D7 RID: 471
		internal int mode;

		// Token: 0x040001D8 RID: 472
		internal int method;

		// Token: 0x040001D9 RID: 473
		internal long[] was = new long[1];

		// Token: 0x040001DA RID: 474
		internal long need;

		// Token: 0x040001DB RID: 475
		internal int marker;

		// Token: 0x040001DC RID: 476
		internal int nowrap;

		// Token: 0x040001DD RID: 477
		internal int wbits;

		// Token: 0x040001DE RID: 478
		internal global::Org.BouncyCastle.Utilities.Zlib.InfBlocks blocks;

		// Token: 0x040001DF RID: 479
		private static readonly byte[] mark = new byte[]
		{
			0,
			0,
			byte.MaxValue,
			byte.MaxValue
		};
	}
}
