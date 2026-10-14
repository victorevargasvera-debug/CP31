using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000155 RID: 341
	public class TlsSrpConfig
	{
		// Token: 0x06000D5F RID: 3423 RVA: 0x00032594 File Offset: 0x00030794
		public global::Org.BouncyCastle.Math.BigInteger[] GetExplicitNG()
		{
			return (global::Org.BouncyCastle.Math.BigInteger[])this.m_explicitNG.Clone();
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x000325A6 File Offset: 0x000307A6
		public void SetExplicitNG(global::Org.BouncyCastle.Math.BigInteger[] explicitNG)
		{
			this.m_explicitNG = (global::Org.BouncyCastle.Math.BigInteger[])explicitNG.Clone();
		}

		// Token: 0x040007D5 RID: 2005
		protected global::Org.BouncyCastle.Math.BigInteger[] m_explicitNG;
	}
}
