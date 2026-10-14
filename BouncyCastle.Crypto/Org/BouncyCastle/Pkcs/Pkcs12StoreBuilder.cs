using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;

namespace Org.BouncyCastle.Pkcs
{
	// Token: 0x020001AF RID: 431
	public class Pkcs12StoreBuilder
	{
		// Token: 0x06001067 RID: 4199 RVA: 0x000428C6 File Offset: 0x00040AC6
		public global::Org.BouncyCastle.Pkcs.Pkcs12Store Build()
		{
			return new global::Org.BouncyCastle.Pkcs.Pkcs12Store(this.keyAlgorithm, this.keyPrfAlgorithm, this.certAlgorithm, this.certPrfAlgorithm, this.useDerEncoding);
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x000428EB File Offset: 0x00040AEB
		public global::Org.BouncyCastle.Pkcs.Pkcs12StoreBuilder SetCertAlgorithm(global::Org.BouncyCastle.Asn1.DerObjectIdentifier certAlgorithm)
		{
			this.certAlgorithm = certAlgorithm;
			return this;
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x000428F5 File Offset: 0x00040AF5
		public global::Org.BouncyCastle.Pkcs.Pkcs12StoreBuilder SetKeyAlgorithm(global::Org.BouncyCastle.Asn1.DerObjectIdentifier keyAlgorithm)
		{
			this.keyAlgorithm = keyAlgorithm;
			return this;
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x000428FF File Offset: 0x00040AFF
		public global::Org.BouncyCastle.Pkcs.Pkcs12StoreBuilder SetKeyAlgorithm(global::Org.BouncyCastle.Asn1.DerObjectIdentifier keyAlgorithm, global::Org.BouncyCastle.Asn1.DerObjectIdentifier keyPrfAlgorithm)
		{
			this.keyAlgorithm = keyAlgorithm;
			this.keyPrfAlgorithm = keyPrfAlgorithm;
			return this;
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00042910 File Offset: 0x00040B10
		public global::Org.BouncyCastle.Pkcs.Pkcs12StoreBuilder SetUseDerEncoding(bool useDerEncoding)
		{
			this.useDerEncoding = useDerEncoding;
			return this;
		}

		// Token: 0x040008AF RID: 2223
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier keyAlgorithm = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbeWithShaAnd3KeyTripleDesCbc;

		// Token: 0x040008B0 RID: 2224
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier certAlgorithm = global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.PbewithShaAnd40BitRC2Cbc;

		// Token: 0x040008B1 RID: 2225
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier keyPrfAlgorithm;

		// Token: 0x040008B2 RID: 2226
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier certPrfAlgorithm;

		// Token: 0x040008B3 RID: 2227
		private bool useDerEncoding;
	}
}
