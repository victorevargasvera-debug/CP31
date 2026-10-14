using System;
using Org.BouncyCastle.Asn1;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x02000427 RID: 1063
	internal class RsaOaepWrapperProvider : global::Org.BouncyCastle.Crypto.Operators.WrapperProvider
	{
		// Token: 0x0600291A RID: 10522 RVA: 0x000AE407 File Offset: 0x000AC607
		internal RsaOaepWrapperProvider(global::Org.BouncyCastle.Asn1.DerObjectIdentifier digestOid)
		{
			this.digestOid = digestOid;
			this.mgfOid = digestOid;
		}

		// Token: 0x0600291B RID: 10523 RVA: 0x000AE41D File Offset: 0x000AC61D
		internal RsaOaepWrapperProvider(global::Org.BouncyCastle.Asn1.DerObjectIdentifier digestOid, global::Org.BouncyCastle.Asn1.DerObjectIdentifier mgfOid)
		{
			this.digestOid = digestOid;
			this.mgfOid = mgfOid;
		}

		// Token: 0x0600291C RID: 10524 RVA: 0x000AE433 File Offset: 0x000AC633
		object global::Org.BouncyCastle.Crypto.Operators.WrapperProvider.CreateWrapper(bool forWrapping, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			return new global::Org.BouncyCastle.Crypto.Operators.RsaOaepWrapper(forWrapping, parameters, this.digestOid, this.mgfOid);
		}

		// Token: 0x040010A6 RID: 4262
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier digestOid;

		// Token: 0x040010A7 RID: 4263
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier mgfOid;
	}
}
