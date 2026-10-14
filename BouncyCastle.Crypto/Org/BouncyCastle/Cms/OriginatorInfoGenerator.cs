using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200054D RID: 1357
	public class OriginatorInfoGenerator
	{
		// Token: 0x06003437 RID: 13367 RVA: 0x000F9E28 File Offset: 0x000F8028
		public OriginatorInfoGenerator(global::Org.BouncyCastle.X509.X509Certificate origCert)
		{
			this.origCerts = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(1);
			this.origCrls = null;
			this.origCerts.Add(origCert.CertificateStructure);
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x000F9E55 File Offset: 0x000F8055
		public OriginatorInfoGenerator(global::Org.BouncyCastle.X509.Store.IX509Store origCerts) : this(origCerts, null)
		{
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x000F9E5F File Offset: 0x000F805F
		public OriginatorInfoGenerator(global::Org.BouncyCastle.X509.Store.IX509Store origCerts, global::Org.BouncyCastle.X509.Store.IX509Store origCrls)
		{
			this.origCerts = global::Org.BouncyCastle.Cms.CmsUtilities.GetCertificatesFromStore(origCerts);
			this.origCrls = ((origCrls == null) ? null : global::Org.BouncyCastle.Cms.CmsUtilities.GetCrlsFromStore(origCrls));
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x000F9E88 File Offset: 0x000F8088
		public virtual global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo Generate()
		{
			global::Org.BouncyCastle.Asn1.Asn1Set certs = global::Org.BouncyCastle.Cms.CmsUtilities.CreateDerSetFromList(this.origCerts);
			global::Org.BouncyCastle.Asn1.Asn1Set crlSet = (this.origCrls == null) ? null : global::Org.BouncyCastle.Cms.CmsUtilities.CreateDerSetFromList(this.origCrls);
			return new global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo(certs, crlSet);
		}

		// Token: 0x0400175E RID: 5982
		private readonly global::System.Collections.IList origCerts;

		// Token: 0x0400175F RID: 5983
		private readonly global::System.Collections.IList origCrls;
	}
}
