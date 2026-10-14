using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004D1 RID: 1233
	public abstract class LongDigest : global::Org.BouncyCastle.Crypto.IDigest, global::Org.BouncyCastle.Utilities.IMemoable
	{
		// Token: 0x0600300D RID: 12301 RVA: 0x000E16C3 File Offset: 0x000DF8C3
		internal LongDigest()
		{
			this.xBuf = new byte[8];
			this.Reset();
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x000E16F5 File Offset: 0x000DF8F5
		internal LongDigest(global::Org.BouncyCastle.Crypto.Digests.LongDigest t)
		{
			this.xBuf = new byte[t.xBuf.Length];
			this.CopyIn(t);
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x000E1730 File Offset: 0x000DF930
		protected void CopyIn(global::Org.BouncyCastle.Crypto.Digests.LongDigest t)
		{
			global::System.Array.Copy(t.xBuf, 0, this.xBuf, 0, t.xBuf.Length);
			this.xBufOff = t.xBufOff;
			this.byteCount1 = t.byteCount1;
			this.byteCount2 = t.byteCount2;
			this.H1 = t.H1;
			this.H2 = t.H2;
			this.H3 = t.H3;
			this.H4 = t.H4;
			this.H5 = t.H5;
			this.H6 = t.H6;
			this.H7 = t.H7;
			this.H8 = t.H8;
			global::System.Array.Copy(t.W, 0, this.W, 0, t.W.Length);
			this.wOff = t.wOff;
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x000E1804 File Offset: 0x000DFA04
		public void Update(byte input)
		{
			byte[] array = this.xBuf;
			int num = this.xBufOff;
			this.xBufOff = num + 1;
			array[num] = input;
			if (this.xBufOff == this.xBuf.Length)
			{
				this.ProcessWord(this.xBuf, 0);
				this.xBufOff = 0;
			}
			this.byteCount1 += 1L;
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x000E1860 File Offset: 0x000DFA60
		public void BlockUpdate(byte[] input, int inOff, int length)
		{
			while (this.xBufOff != 0)
			{
				if (length <= 0)
				{
					break;
				}
				this.Update(input[inOff]);
				inOff++;
				length--;
			}
			while (length > this.xBuf.Length)
			{
				this.ProcessWord(input, inOff);
				inOff += this.xBuf.Length;
				length -= this.xBuf.Length;
				this.byteCount1 += (long)this.xBuf.Length;
			}
			while (length > 0)
			{
				this.Update(input[inOff]);
				inOff++;
				length--;
			}
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x000E18EC File Offset: 0x000DFAEC
		public void Finish()
		{
			this.AdjustByteCounts();
			long lowBitLength = this.byteCount1 << 3;
			long hiBitLength = this.byteCount2;
			this.Update(128);
			while (this.xBufOff != 0)
			{
				this.Update(0);
			}
			this.ProcessLength(lowBitLength, hiBitLength);
			this.ProcessBlock();
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x000E193C File Offset: 0x000DFB3C
		public virtual void Reset()
		{
			this.byteCount1 = 0L;
			this.byteCount2 = 0L;
			this.xBufOff = 0;
			for (int i = 0; i < this.xBuf.Length; i++)
			{
				this.xBuf[i] = 0;
			}
			this.wOff = 0;
			global::System.Array.Clear(this.W, 0, this.W.Length);
		}

		// Token: 0x06003014 RID: 12308 RVA: 0x000E1998 File Offset: 0x000DFB98
		internal void ProcessWord(byte[] input, int inOff)
		{
			this.W[this.wOff] = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt64(input, inOff);
			int num = this.wOff + 1;
			this.wOff = num;
			if (num == 16)
			{
				this.ProcessBlock();
			}
		}

		// Token: 0x06003015 RID: 12309 RVA: 0x000E19D4 File Offset: 0x000DFBD4
		private void AdjustByteCounts()
		{
			if (this.byteCount1 > 2305843009213693951L)
			{
				this.byteCount2 += (long)((ulong)this.byteCount1 >> 61);
				this.byteCount1 &= 2305843009213693951L;
			}
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x000E1A13 File Offset: 0x000DFC13
		internal void ProcessLength(long lowW, long hiW)
		{
			if (this.wOff > 14)
			{
				this.ProcessBlock();
			}
			this.W[14] = (ulong)hiW;
			this.W[15] = (ulong)lowW;
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x000E1A3C File Offset: 0x000DFC3C
		internal void ProcessBlock()
		{
			this.AdjustByteCounts();
			for (int ti = 16; ti <= 79; ti++)
			{
				this.W[ti] = global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sigma1(this.W[ti - 2]) + this.W[ti - 7] + global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sigma0(this.W[ti - 15]) + this.W[ti - 16];
			}
			ulong a = this.H1;
			ulong b = this.H2;
			ulong c = this.H3;
			ulong d = this.H4;
			ulong e = this.H5;
			ulong f = this.H6;
			ulong g = this.H7;
			ulong h = this.H8;
			int t = 0;
			for (int i = 0; i < 10; i++)
			{
				h += global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sum1(e) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.Ch(e, f, g) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.K[t] + this.W[t++];
				d += h;
				h += global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sum0(a) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.Maj(a, b, c);
				g += global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sum1(d) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.Ch(d, e, f) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.K[t] + this.W[t++];
				c += g;
				g += global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sum0(h) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.Maj(h, a, b);
				f += global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sum1(c) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.Ch(c, d, e) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.K[t] + this.W[t++];
				b += f;
				f += global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sum0(g) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.Maj(g, h, a);
				e += global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sum1(b) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.Ch(b, c, d) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.K[t] + this.W[t++];
				a += e;
				e += global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sum0(f) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.Maj(f, g, h);
				d += global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sum1(a) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.Ch(a, b, c) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.K[t] + this.W[t++];
				h += d;
				d += global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sum0(e) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.Maj(e, f, g);
				c += global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sum1(h) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.Ch(h, a, b) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.K[t] + this.W[t++];
				g += c;
				c += global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sum0(d) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.Maj(d, e, f);
				b += global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sum1(g) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.Ch(g, h, a) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.K[t] + this.W[t++];
				f += b;
				b += global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sum0(c) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.Maj(c, d, e);
				a += global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sum1(f) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.Ch(f, g, h) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.K[t] + this.W[t++];
				e += a;
				a += global::Org.BouncyCastle.Crypto.Digests.LongDigest.Sum0(b) + global::Org.BouncyCastle.Crypto.Digests.LongDigest.Maj(b, c, d);
			}
			this.H1 += a;
			this.H2 += b;
			this.H3 += c;
			this.H4 += d;
			this.H5 += e;
			this.H6 += f;
			this.H7 += g;
			this.H8 += h;
			this.wOff = 0;
			global::System.Array.Clear(this.W, 0, 16);
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x000E1DC0 File Offset: 0x000DFFC0
		private static ulong Ch(ulong x, ulong y, ulong z)
		{
			return (x & y) ^ (~x & z);
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x000E1DCA File Offset: 0x000DFFCA
		private static ulong Maj(ulong x, ulong y, ulong z)
		{
			return (x & y) ^ (x & z) ^ (y & z);
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x000E1DD7 File Offset: 0x000DFFD7
		private static ulong Sum0(ulong x)
		{
			return (x << 36 | x >> 28) ^ (x << 30 | x >> 34) ^ (x << 25 | x >> 39);
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x000E1DF6 File Offset: 0x000DFFF6
		private static ulong Sum1(ulong x)
		{
			return (x << 50 | x >> 14) ^ (x << 46 | x >> 18) ^ (x << 23 | x >> 41);
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x000E1E15 File Offset: 0x000E0015
		private static ulong Sigma0(ulong x)
		{
			return (x << 63 | x >> 1) ^ (x << 56 | x >> 8) ^ x >> 7;
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x000E1E2C File Offset: 0x000E002C
		private static ulong Sigma1(ulong x)
		{
			return (x << 45 | x >> 19) ^ (x << 3 | x >> 61) ^ x >> 6;
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x000E1E44 File Offset: 0x000E0044
		public int GetByteLength()
		{
			return this.MyByteLength;
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x0600301F RID: 12319
		public abstract string AlgorithmName { get; }

		// Token: 0x06003020 RID: 12320
		public abstract int GetDigestSize();

		// Token: 0x06003021 RID: 12321
		public abstract int DoFinal(byte[] output, int outOff);

		// Token: 0x06003022 RID: 12322
		public abstract global::Org.BouncyCastle.Utilities.IMemoable Copy();

		// Token: 0x06003023 RID: 12323
		public abstract void Reset(global::Org.BouncyCastle.Utilities.IMemoable t);

		// Token: 0x040014C2 RID: 5314
		private int MyByteLength = 128;

		// Token: 0x040014C3 RID: 5315
		private byte[] xBuf;

		// Token: 0x040014C4 RID: 5316
		private int xBufOff;

		// Token: 0x040014C5 RID: 5317
		private long byteCount1;

		// Token: 0x040014C6 RID: 5318
		private long byteCount2;

		// Token: 0x040014C7 RID: 5319
		internal ulong H1;

		// Token: 0x040014C8 RID: 5320
		internal ulong H2;

		// Token: 0x040014C9 RID: 5321
		internal ulong H3;

		// Token: 0x040014CA RID: 5322
		internal ulong H4;

		// Token: 0x040014CB RID: 5323
		internal ulong H5;

		// Token: 0x040014CC RID: 5324
		internal ulong H6;

		// Token: 0x040014CD RID: 5325
		internal ulong H7;

		// Token: 0x040014CE RID: 5326
		internal ulong H8;

		// Token: 0x040014CF RID: 5327
		private ulong[] W = new ulong[80];

		// Token: 0x040014D0 RID: 5328
		private int wOff;

		// Token: 0x040014D1 RID: 5329
		internal static readonly ulong[] K = new ulong[]
		{
			4794697086780616226UL,
			8158064640168781261UL,
			13096744586834688815UL,
			16840607885511220156UL,
			4131703408338449720UL,
			6480981068601479193UL,
			10538285296894168987UL,
			12329834152419229976UL,
			15566598209576043074UL,
			1334009975649890238UL,
			2608012711638119052UL,
			6128411473006802146UL,
			8268148722764581231UL,
			9286055187155687089UL,
			11230858885718282805UL,
			13951009754708518548UL,
			16472876342353939154UL,
			17275323862435702243UL,
			1135362057144423861UL,
			2597628984639134821UL,
			3308224258029322869UL,
			5365058923640841347UL,
			6679025012923562964UL,
			8573033837759648693UL,
			10970295158949994411UL,
			12119686244451234320UL,
			12683024718118986047UL,
			13788192230050041572UL,
			14330467153632333762UL,
			15395433587784984357UL,
			489312712824947311UL,
			1452737877330783856UL,
			2861767655752347644UL,
			3322285676063803686UL,
			5560940570517711597UL,
			5996557281743188959UL,
			7280758554555802590UL,
			8532644243296465576UL,
			9350256976987008742UL,
			10552545826968843579UL,
			11727347734174303076UL,
			12113106623233404929UL,
			14000437183269869457UL,
			14369950271660146224UL,
			15101387698204529176UL,
			15463397548674623760UL,
			17586052441742319658UL,
			1182934255886127544UL,
			1847814050463011016UL,
			2177327727835720531UL,
			2830643537854262169UL,
			3796741975233480872UL,
			4115178125766777443UL,
			5681478168544905931UL,
			6601373596472566643UL,
			7507060721942968483UL,
			8399075790359081724UL,
			8693463985226723168UL,
			9568029438360202098UL,
			10144078919501101548UL,
			10430055236837252648UL,
			11840083180663258601UL,
			13761210420658862357UL,
			14299343276471374635UL,
			14566680578165727644UL,
			15097957966210449927UL,
			16922976911328602910UL,
			17689382322260857208UL,
			500013540394364858UL,
			748580250866718886UL,
			1242879168328830382UL,
			1977374033974150939UL,
			2944078676154940804UL,
			3659926193048069267UL,
			4368137639120453308UL,
			4836135668995329356UL,
			5532061633213252278UL,
			6448918945643986474UL,
			6902733635092675308UL,
			7801388544844847127UL
		};
	}
}
