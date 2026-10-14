using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004DE RID: 1246
	public class Sha256Digest : global::Org.BouncyCastle.Crypto.Digests.GeneralDigest
	{
		// Token: 0x060030F3 RID: 12531 RVA: 0x000EB398 File Offset: 0x000E9598
		public Sha256Digest()
		{
			this.initHs();
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x000EB3B3 File Offset: 0x000E95B3
		public Sha256Digest(global::Org.BouncyCastle.Crypto.Digests.Sha256Digest t) : base(t)
		{
			this.CopyIn(t);
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x000EB3D0 File Offset: 0x000E95D0
		private void CopyIn(global::Org.BouncyCastle.Crypto.Digests.Sha256Digest t)
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

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x060030F6 RID: 12534 RVA: 0x000EB46B File Offset: 0x000E966B
		public override string AlgorithmName
		{
			get
			{
				return "SHA-256";
			}
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x000EB472 File Offset: 0x000E9672
		public override int GetDigestSize()
		{
			return 32;
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x000EB478 File Offset: 0x000E9678
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

		// Token: 0x060030F9 RID: 12537 RVA: 0x000EB4B4 File Offset: 0x000E96B4
		internal override void ProcessLength(long bitLength)
		{
			if (this.xOff > 14)
			{
				this.ProcessBlock();
			}
			this.X[14] = (uint)((ulong)bitLength >> 32);
			this.X[15] = (uint)bitLength;
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x000EB4E0 File Offset: 0x000E96E0
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
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(this.H8, output, outOff + 28);
			this.Reset();
			return 32;
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x000EB576 File Offset: 0x000E9776
		public override void Reset()
		{
			base.Reset();
			this.initHs();
			this.xOff = 0;
			global::System.Array.Clear(this.X, 0, this.X.Length);
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x000EB5A0 File Offset: 0x000E97A0
		private void initHs()
		{
			this.H1 = 1779033703U;
			this.H2 = 3144134277U;
			this.H3 = 1013904242U;
			this.H4 = 2773480762U;
			this.H5 = 1359893119U;
			this.H6 = 2600822924U;
			this.H7 = 528734635U;
			this.H8 = 1541459225U;
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x000EB608 File Offset: 0x000E9808
		internal override void ProcessBlock()
		{
			for (int ti = 16; ti <= 63; ti++)
			{
				this.X[ti] = global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Theta1(this.X[ti - 2]) + this.X[ti - 7] + global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Theta0(this.X[ti - 15]) + this.X[ti - 16];
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
				h += global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Sum1Ch(e, f, g) + global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.K[t] + this.X[t];
				d += h;
				h += global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Sum0Maj(a, b, c);
				t++;
				g += global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Sum1Ch(d, e, f) + global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.K[t] + this.X[t];
				c += g;
				g += global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Sum0Maj(h, a, b);
				t++;
				f += global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Sum1Ch(c, d, e) + global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.K[t] + this.X[t];
				b += f;
				f += global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Sum0Maj(g, h, a);
				t++;
				e += global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Sum1Ch(b, c, d) + global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.K[t] + this.X[t];
				a += e;
				e += global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Sum0Maj(f, g, h);
				t++;
				d += global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Sum1Ch(a, b, c) + global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.K[t] + this.X[t];
				h += d;
				d += global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Sum0Maj(e, f, g);
				t++;
				c += global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Sum1Ch(h, a, b) + global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.K[t] + this.X[t];
				g += c;
				c += global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Sum0Maj(d, e, f);
				t++;
				b += global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Sum1Ch(g, h, a) + global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.K[t] + this.X[t];
				f += b;
				b += global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Sum0Maj(c, d, e);
				t++;
				a += global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Sum1Ch(f, g, h) + global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.K[t] + this.X[t];
				e += a;
				a += global::Org.BouncyCastle.Crypto.Digests.Sha256Digest.Sum0Maj(b, c, d);
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

		// Token: 0x060030FE RID: 12542 RVA: 0x000EB915 File Offset: 0x000E9B15
		private static uint Sum1Ch(uint x, uint y, uint z)
		{
			return ((x >> 6 | x << 26) ^ (x >> 11 | x << 21) ^ (x >> 25 | x << 7)) + (z ^ (x & (y ^ z)));
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x000EB93A File Offset: 0x000E9B3A
		private static uint Sum0Maj(uint x, uint y, uint z)
		{
			return ((x >> 2 | x << 30) ^ (x >> 13 | x << 19) ^ (x >> 22 | x << 10)) + ((x & y) | (z & (x ^ y)));
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x000EB962 File Offset: 0x000E9B62
		private static uint Theta0(uint x)
		{
			return (x >> 7 | x << 25) ^ (x >> 18 | x << 14) ^ x >> 3;
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x000EB97A File Offset: 0x000E9B7A
		private static uint Theta1(uint x)
		{
			return (x >> 17 | x << 15) ^ (x >> 19 | x << 13) ^ x >> 10;
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x000EB994 File Offset: 0x000E9B94
		public override global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.Sha256Digest(this);
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x000EB99C File Offset: 0x000E9B9C
		public override void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.Sha256Digest d = (global::Org.BouncyCastle.Crypto.Digests.Sha256Digest)other;
			this.CopyIn(d);
		}

		// Token: 0x04001551 RID: 5457
		private const int DigestLength = 32;

		// Token: 0x04001552 RID: 5458
		private uint H1;

		// Token: 0x04001553 RID: 5459
		private uint H2;

		// Token: 0x04001554 RID: 5460
		private uint H3;

		// Token: 0x04001555 RID: 5461
		private uint H4;

		// Token: 0x04001556 RID: 5462
		private uint H5;

		// Token: 0x04001557 RID: 5463
		private uint H6;

		// Token: 0x04001558 RID: 5464
		private uint H7;

		// Token: 0x04001559 RID: 5465
		private uint H8;

		// Token: 0x0400155A RID: 5466
		private uint[] X = new uint[64];

		// Token: 0x0400155B RID: 5467
		private int xOff;

		// Token: 0x0400155C RID: 5468
		private static readonly uint[] K = new uint[]
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
