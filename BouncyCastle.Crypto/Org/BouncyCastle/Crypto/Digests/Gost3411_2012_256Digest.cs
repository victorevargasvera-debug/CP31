using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004CE RID: 1230
	public class Gost3411_2012_256Digest : global::Org.BouncyCastle.Crypto.Digests.Gost3411_2012Digest
	{
		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06002FE7 RID: 12263 RVA: 0x000E0AF3 File Offset: 0x000DECF3
		public override string AlgorithmName
		{
			get
			{
				return "GOST3411-2012-256";
			}
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x000E0AFA File Offset: 0x000DECFA
		public Gost3411_2012_256Digest() : base(global::Org.BouncyCastle.Crypto.Digests.Gost3411_2012_256Digest.IV)
		{
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x000E0B07 File Offset: 0x000DED07
		public Gost3411_2012_256Digest(global::Org.BouncyCastle.Crypto.Digests.Gost3411_2012_256Digest other) : base(global::Org.BouncyCastle.Crypto.Digests.Gost3411_2012_256Digest.IV)
		{
			base.Reset(other);
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x000E0B1B File Offset: 0x000DED1B
		public override int GetDigestSize()
		{
			return 32;
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x000E0B20 File Offset: 0x000DED20
		public override int DoFinal(byte[] output, int outOff)
		{
			byte[] result = new byte[64];
			base.DoFinal(result, 0);
			global::System.Array.Copy(result, 32, output, outOff, 32);
			return 32;
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x000E0B4C File Offset: 0x000DED4C
		public override global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.Gost3411_2012_256Digest(this);
		}

		// Token: 0x040014B9 RID: 5305
		private static readonly byte[] IV = new byte[]
		{
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			1
		};
	}
}
