using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000541 RID: 1345
	internal class CounterSignatureDigestCalculator : global::Org.BouncyCastle.Cms.IDigestCalculator
	{
		// Token: 0x060033FE RID: 13310 RVA: 0x000F8D06 File Offset: 0x000F6F06
		internal CounterSignatureDigestCalculator(string alg, byte[] data)
		{
			this.alg = alg;
			this.data = data;
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x000F8D1C File Offset: 0x000F6F1C
		public byte[] GetDigest()
		{
			return global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(global::Org.BouncyCastle.Cms.CmsSignedHelper.Instance.GetDigestInstance(this.alg), this.data);
		}

		// Token: 0x04001744 RID: 5956
		private readonly string alg;

		// Token: 0x04001745 RID: 5957
		private readonly byte[] data;
	}
}
