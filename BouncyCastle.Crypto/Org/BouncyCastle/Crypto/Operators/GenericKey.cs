using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x02000430 RID: 1072
	public class GenericKey
	{
		// Token: 0x0600293D RID: 10557 RVA: 0x000AEFDF File Offset: 0x000AD1DF
		public GenericKey(object representation)
		{
			this.algorithmIdentifier = null;
			this.representation = representation;
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x000AEFF5 File Offset: 0x000AD1F5
		public GenericKey(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithmIdentifier, byte[] representation)
		{
			this.algorithmIdentifier = algorithmIdentifier;
			this.representation = representation;
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x000AF00B File Offset: 0x000AD20B
		public GenericKey(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithmIdentifier, object representation)
		{
			this.algorithmIdentifier = algorithmIdentifier;
			this.representation = representation;
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x000AF021 File Offset: 0x000AD221
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier AlgorithmIdentifier
		{
			get
			{
				return this.algorithmIdentifier;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x000AF029 File Offset: 0x000AD229
		public object Representation
		{
			get
			{
				return this.representation;
			}
		}

		// Token: 0x040010B7 RID: 4279
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithmIdentifier;

		// Token: 0x040010B8 RID: 4280
		private readonly object representation;
	}
}
