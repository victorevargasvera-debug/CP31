using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000664 RID: 1636
	public sealed class PolicyQualifierID : global::Org.BouncyCastle.Asn1.DerObjectIdentifier
	{
		// Token: 0x06003C71 RID: 15473 RVA: 0x00114B9C File Offset: 0x00112D9C
		private PolicyQualifierID(string id) : base(id)
		{
		}

		// Token: 0x04001AAD RID: 6829
		private const string IdQt = "1.3.6.1.5.5.7.2";

		// Token: 0x04001AAE RID: 6830
		public static readonly global::Org.BouncyCastle.Asn1.X509.PolicyQualifierID IdQtCps = new global::Org.BouncyCastle.Asn1.X509.PolicyQualifierID("1.3.6.1.5.5.7.2.1");

		// Token: 0x04001AAF RID: 6831
		public static readonly global::Org.BouncyCastle.Asn1.X509.PolicyQualifierID IdQtUnotice = new global::Org.BouncyCastle.Asn1.X509.PolicyQualifierID("1.3.6.1.5.5.7.2.2");
	}
}
