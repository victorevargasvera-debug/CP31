using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000518 RID: 1304
	internal class BaseDigestCalculator : global::Org.BouncyCastle.Cms.IDigestCalculator
	{
		// Token: 0x060032C2 RID: 12994 RVA: 0x000F2BB3 File Offset: 0x000F0DB3
		internal BaseDigestCalculator(byte[] digest)
		{
			this.digest = digest;
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x000F2BC2 File Offset: 0x000F0DC2
		public byte[] GetDigest()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.digest);
		}

		// Token: 0x04001691 RID: 5777
		private readonly byte[] digest;
	}
}
