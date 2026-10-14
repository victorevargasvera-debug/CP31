using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004CF RID: 1231
	public class Gost3411_2012_512Digest : global::Org.BouncyCastle.Crypto.Digests.Gost3411_2012Digest
	{
		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06002FEE RID: 12270 RVA: 0x000E0B6D File Offset: 0x000DED6D
		public override string AlgorithmName
		{
			get
			{
				return "GOST3411-2012-512";
			}
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x000E0B74 File Offset: 0x000DED74
		public Gost3411_2012_512Digest() : base(global::Org.BouncyCastle.Crypto.Digests.Gost3411_2012_512Digest.IV)
		{
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x000E0B81 File Offset: 0x000DED81
		public Gost3411_2012_512Digest(global::Org.BouncyCastle.Crypto.Digests.Gost3411_2012_512Digest other) : base(global::Org.BouncyCastle.Crypto.Digests.Gost3411_2012_512Digest.IV)
		{
			base.Reset(other);
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x000E0B95 File Offset: 0x000DED95
		public override int GetDigestSize()
		{
			return 64;
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x000E0B99 File Offset: 0x000DED99
		public override global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.Gost3411_2012_512Digest(this);
		}

		// Token: 0x040014BA RID: 5306
		private static readonly byte[] IV = new byte[64];
	}
}
