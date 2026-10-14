using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004DD RID: 1245
	public class Sha224Digest : global::Org.BouncyCastle.Crypto.Digests.GeneralDigest
	{
		// Token: 0x060030E0 RID: 12512 RVA: 0x000EACF7 File Offset: 0x000E8EF7
		public Sha224Digest()
		{
			this.Reset();
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x000EAD12 File Offset: 0x000E8F12
		public Sha224Digest(global::Org.BouncyCastle.Crypto.Digests.Sha224Digest t) : base(t)
		{
			this.CopyIn(t);
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x000EAD30 File Offset: 0x000E8F30
		private void CopyIn(global::Org.BouncyCastle.Crypto.Digests.Sha224Digest t)
		{
			base.CopyIn(t);
			this.H1 = t.H1;
			this.H2 = t.H2;
			this.H3 = t.H3;
			this.H4 = t.H4;
			this.H5 = t.H5;
			this.H6 = t.H6;
			this.H7 = t.H7;
			this.H8 = t.H8;
			global::System.Array.Copy(t.X, 0, this.X, 0, t.X.Length);
			this.xOff = t.xOff;
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x060030E3 RID: 12515 RVA: 0x000EADCB File Offset: 0x000E8FCB
		public override string AlgorithmName
		{
			get
			{
				return "SHA-224";
			}
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x000EADD2 File Offset: 0x000E8FD2
		public override int GetDigestSize()
		{
			return 28;
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x000EADD8 File Offset: 0x000E8FD8
		internal override void ProcessWord(byte[] input, int inOff)
		{
			this.X[this.xOff] = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(input, inOff);
			int num = this.xOff + 1;
			this.xOff = num;
			if (num == 16)
			{
				this.ProcessBlock();
			}
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x000EAE14 File Offset: 0x000E9014
		internal override void ProcessLength(long bitLength)
		{
			if (this.xOff > 14)
			{
				this.ProcessBlock();
			}
			this.X[14] = (uint)((ulong)bitLength >> 32);
			this.X[15] = (uint)bitLength;
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x000EAE40 File Offset: 0x000E9040
		public override int DoFinal(byte[] output, int outOff)
		{
			base.Finish();
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(this.H1, output, outOff);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(this.H2, output, outOff + 4);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(this.H3, output, outOff + 8);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(this.H4, output, outOff + 12);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(this.H5, output, outOff + 16);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(this.H6, output, outOff + 20);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(this.H7, output, outOff + 24);
			this.Reset();
			return 28;
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x000EAEC8 File Offset: 0x000E90C8
		public override void Reset()
		{
			base.Reset();
			this.H1 = 3238371032U;
			this.H2 = 914150663U;
			this.H3 = 812702999U;
			this.H4 = 4144912697U;
			this.H5 = 4290775857U;
			this.H6 = 1750603025U;
			this.H7 = 1694076839U;
			this.H8 = 3204075428U;
			this.xOff = 0;
			global::System.Array.Clear(this.X, 0, this.X.Length);
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x000EAF50 File Offset: 0x000E9150
		internal override void ProcessBlock()
		{
			for (int ti = 16; ti <= 63; ti++)
			{
				this.X[ti] = global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Theta1(this.X[ti - 2]) + this.X[ti - 7] + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Theta0(this.X[ti - 15]) + this.X[ti - 16];
			}
			uint a = this.H1;
			uint b = this.H2;
			uint c = this.H3;
			uint d = this.H4;
			uint e = this.H5;
			uint f = this.H6;
			uint g = this.H7;
			uint h = this.H8;
			int t = 0;
			for (int i = 0; i < 8; i++)
			{
				h += global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Sum1(e) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Ch(e, f, g) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.K[t] + this.X[t];
				d += h;
				h += global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Sum0(a) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Maj(a, b, c);
				t++;
				g += global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Sum1(d) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Ch(d, e, f) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.K[t] + this.X[t];
				c += g;
				g += global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Sum0(h) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Maj(h, a, b);
				t++;
				f += global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Sum1(c) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Ch(c, d, e) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.K[t] + this.X[t];
				b += f;
				f += global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Sum0(g) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Maj(g, h, a);
				t++;
				e += global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Sum1(b) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Ch(b, c, d) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.K[t] + this.X[t];
				a += e;
				e += global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Sum0(f) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Maj(f, g, h);
				t++;
				d += global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Sum1(a) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Ch(a, b, c) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.K[t] + this.X[t];
				h += d;
				d += global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Sum0(e) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Maj(e, f, g);
				t++;
				c += global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Sum1(h) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Ch(h, a, b) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.K[t] + this.X[t];
				g += c;
				c += global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Sum0(d) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Maj(d, e, f);
				t++;
				b += global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Sum1(g) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Ch(g, h, a) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.K[t] + this.X[t];
				f += b;
				b += global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Sum0(c) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Maj(c, d, e);
				t++;
				a += global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Sum1(f) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Ch(f, g, h) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.K[t] + this.X[t];
				e += a;
				a += global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Sum0(b) + global::Org.BouncyCastle.Crypto.Digests.Sha224Digest.Maj(b, c, d);
				t++;
			}
			this.H1 += a;
			this.H2 += b;
			this.H3 += c;
			this.H4 += d;
			this.H5 += e;
			this.H6 += f;
			this.H7 += g;
			this.H8 += h;
			this.xOff = 0;
			global::System.Array.Clear(this.X, 0, 16);
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x000EB2D5 File Offset: 0x000E94D5
		private static uint Ch(uint x, uint y, uint z)
		{
			return (x & y) ^ (~x & z);
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x000EB2DF File Offset: 0x000E94DF
		private static uint Maj(uint x, uint y, uint z)
		{
			return (x & y) ^ (x & z) ^ (y & z);
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x000EB2EC File Offset: 0x000E94EC
		private static uint Sum0(uint x)
		{
			return (x >> 2 | x << 30) ^ (x >> 13 | x << 19) ^ (x >> 22 | x << 10);
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x000EB30A File Offset: 0x000E950A
		private static uint Sum1(uint x)
		{
			return (x >> 6 | x << 26) ^ (x >> 11 | x << 21) ^ (x >> 25 | x << 7);
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x000EB327 File Offset: 0x000E9527
		private static uint Theta0(uint x)
		{
			return (x >> 7 | x << 25) ^ (x >> 18 | x << 14) ^ x >> 3;
		}

		// Token: 0x060030EF RID: 12527 RVA: 0x000EB33F File Offset: 0x000E953F
		private static uint Theta1(uint x)
		{
			return (x >> 17 | x << 15) ^ (x >> 19 | x << 13) ^ x >> 10;
		}

		// Token: 0x060030F0 RID: 12528 RVA: 0x000EB359 File Offset: 0x000E9559
		public override global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.Sha224Digest(this);
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x000EB364 File Offset: 0x000E9564
		public override void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.Sha224Digest d = (global::Org.BouncyCastle.Crypto.Digests.Sha224Digest)other;
			this.CopyIn(d);
		}

		// Token: 0x04001545 RID: 5445
		private const int DigestLength = 28;

		// Token: 0x04001546 RID: 5446
		private uint H1;

		// Token: 0x04001547 RID: 5447
		private uint H2;

		// Token: 0x04001548 RID: 5448
		private uint H3;

		// Token: 0x04001549 RID: 5449
		private uint H4;

		// Token: 0x0400154A RID: 5450
		private uint H5;

		// Token: 0x0400154B RID: 5451
		private uint H6;

		// Token: 0x0400154C RID: 5452
		private uint H7;

		// Token: 0x0400154D RID: 5453
		private uint H8;

		// Token: 0x0400154E RID: 5454
		private uint[] X = new uint[64];

		// Token: 0x0400154F RID: 5455
		private int xOff;

		// Token: 0x04001550 RID: 5456
		internal static readonly uint[] K = new uint[]
		{
			1116352408U,
			1899447441U,
			3049323471U,
			3921009573U,
			961987163U,
			1508970993U,
			2453635748U,
			2870763221U,
			3624381080U,
			310598401U,
			607225278U,
			1426881987U,
			1925078388U,
			2162078206U,
			2614888103U,
			3248222580U,
			3835390401U,
			4022224774U,
			264347078U,
			604807628U,
			770255983U,
			1249150122U,
			1555081692U,
			1996064986U,
			2554220882U,
			2821834349U,
			2952996808U,
			3210313671U,
			3336571891U,
			3584528711U,
			113926993U,
			338241895U,
			666307205U,
			773529912U,
			1294757372U,
			1396182291U,
			1695183700U,
			1986661051U,
			2177026350U,
			2456956037U,
			2730485921U,
			2820302411U,
			3259730800U,
			3345764771U,
			3516065817U,
			3600352804U,
			4094571909U,
			275423344U,
			430227734U,
			506948616U,
			659060556U,
			883997877U,
			958139571U,
			1322822218U,
			1537002063U,
			1747873779U,
			1955562222U,
			2024104815U,
			2227730452U,
			2361852424U,
			2428436474U,
			2756734187U,
			3204031479U,
			3329325298U
		};
	}
}
