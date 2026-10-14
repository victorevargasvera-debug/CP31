using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004DF RID: 1247
	public class Sha384Digest : global::Org.BouncyCastle.Crypto.Digests.LongDigest
	{
		// Token: 0x06003105 RID: 12549 RVA: 0x000EB9D0 File Offset: 0x000E9BD0
		public Sha384Digest()
		{
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x000EB9D8 File Offset: 0x000E9BD8
		public Sha384Digest(global::Org.BouncyCastle.Crypto.Digests.Sha384Digest t) : base(t)
		{
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x000EB9E1 File Offset: 0x000E9BE1
		public override string AlgorithmName
		{
			get
			{
				return "SHA-384";
			}
		}

		// Token: 0x06003108 RID: 12552 RVA: 0x000EB9E8 File Offset: 0x000E9BE8
		public override int GetDigestSize()
		{
			return 48;
		}

		// Token: 0x06003109 RID: 12553 RVA: 0x000EB9EC File Offset: 0x000E9BEC
		public override int DoFinal(byte[] output, int outOff)
		{
			base.Finish();
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(this.H1, output, outOff);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(this.H2, output, outOff + 8);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(this.H3, output, outOff + 16);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(this.H4, output, outOff + 24);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(this.H5, output, outOff + 32);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(this.H6, output, outOff + 40);
			this.Reset();
			return 48;
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x000EBA64 File Offset: 0x000E9C64
		public override void Reset()
		{
			base.Reset();
			this.H1 = 14680500436340154072UL;
			this.H2 = 7105036623409894663UL;
			this.H3 = 10473403895298186519UL;
			this.H4 = 1526699215303891257UL;
			this.H5 = 7436329637833083697UL;
			this.H6 = 10282925794625328401UL;
			this.H7 = 15784041429090275239UL;
			this.H8 = 5167115440072839076UL;
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x000EBAEF File Offset: 0x000E9CEF
		public override global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.Sha384Digest(this);
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x000EBAF8 File Offset: 0x000E9CF8
		public override void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.Sha384Digest d = (global::Org.BouncyCastle.Crypto.Digests.Sha384Digest)other;
			base.CopyIn(d);
		}

		// Token: 0x0400155D RID: 5469
		private const int DigestLength = 48;
	}
}
