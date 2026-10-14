using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004E1 RID: 1249
	public class Sha512Digest : global::Org.BouncyCastle.Crypto.Digests.LongDigest
	{
		// Token: 0x06003115 RID: 12565 RVA: 0x000EBC1F File Offset: 0x000E9E1F
		public Sha512Digest()
		{
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x000EBC27 File Offset: 0x000E9E27
		public Sha512Digest(global::Org.BouncyCastle.Crypto.Digests.Sha512Digest t) : base(t)
		{
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06003117 RID: 12567 RVA: 0x000EBC30 File Offset: 0x000E9E30
		public override string AlgorithmName
		{
			get
			{
				return "SHA-512";
			}
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x000EBC37 File Offset: 0x000E9E37
		public override int GetDigestSize()
		{
			return 64;
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x000EBC3C File Offset: 0x000E9E3C
		public override int DoFinal(byte[] output, int outOff)
		{
			base.Finish();
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(this.H1, output, outOff);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(this.H2, output, outOff + 8);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(this.H3, output, outOff + 16);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(this.H4, output, outOff + 24);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(this.H5, output, outOff + 32);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(this.H6, output, outOff + 40);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(this.H7, output, outOff + 48);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(this.H8, output, outOff + 56);
			this.Reset();
			return 64;
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x000EBCD4 File Offset: 0x000E9ED4
		public override void Reset()
		{
			base.Reset();
			this.H1 = 7640891576956012808UL;
			this.H2 = 13503953896175478587UL;
			this.H3 = 4354685564936845355UL;
			this.H4 = 11912009170470909681UL;
			this.H5 = 5840696475078001361UL;
			this.H6 = 11170449401992604703UL;
			this.H7 = 2270897969802886507UL;
			this.H8 = 6620516959819538809UL;
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x000EBD5F File Offset: 0x000E9F5F
		public override global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.Sha512Digest(this);
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x000EBD68 File Offset: 0x000E9F68
		public override void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.Sha512Digest d = (global::Org.BouncyCastle.Crypto.Digests.Sha512Digest)other;
			base.CopyIn(d);
		}

		// Token: 0x0400155E RID: 5470
		private const int DigestLength = 64;
	}
}
