using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200054E RID: 1358
	public class OriginatorInformation
	{
		// Token: 0x0600343B RID: 13371 RVA: 0x000F9EBD File Offset: 0x000F80BD
		internal OriginatorInformation(global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo originatorInfo)
		{
			this.originatorInfo = originatorInfo;
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x000F9ECC File Offset: 0x000F80CC
		public virtual global::Org.BouncyCastle.X509.Store.IX509Store GetCertificates()
		{
			global::Org.BouncyCastle.Asn1.Asn1Set certSet = this.originatorInfo.Certificates;
			if (certSet != null)
			{
				global::System.Collections.IList certList = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(certSet.Count);
				foreach (object obj2 in certSet)
				{
					global::Org.BouncyCastle.Asn1.Asn1Object obj = ((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj2).ToAsn1Object();
					if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
					{
						certList.Add(new global::Org.BouncyCastle.X509.X509Certificate(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(obj)));
					}
				}
				return global::Org.BouncyCastle.X509.Store.X509StoreFactory.Create("Certificate/Collection", new global::Org.BouncyCastle.X509.Store.X509CollectionStoreParameters(certList));
			}
			return global::Org.BouncyCastle.X509.Store.X509StoreFactory.Create("Certificate/Collection", new global::Org.BouncyCastle.X509.Store.X509CollectionStoreParameters(global::Org.BouncyCastle.Utilities.Platform.CreateArrayList()));
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x000F9F7C File Offset: 0x000F817C
		public virtual global::Org.BouncyCastle.X509.Store.IX509Store GetCrls()
		{
			global::Org.BouncyCastle.Asn1.Asn1Set crlSet = this.originatorInfo.Certificates;
			if (crlSet != null)
			{
				global::System.Collections.IList crlList = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(crlSet.Count);
				foreach (object obj2 in crlSet)
				{
					global::Org.BouncyCastle.Asn1.Asn1Object obj = ((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj2).ToAsn1Object();
					if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
					{
						crlList.Add(new global::Org.BouncyCastle.X509.X509Crl(global::Org.BouncyCastle.Asn1.X509.CertificateList.GetInstance(obj)));
					}
				}
				return global::Org.BouncyCastle.X509.Store.X509StoreFactory.Create("CRL/Collection", new global::Org.BouncyCastle.X509.Store.X509CollectionStoreParameters(crlList));
			}
			return global::Org.BouncyCastle.X509.Store.X509StoreFactory.Create("CRL/Collection", new global::Org.BouncyCastle.X509.Store.X509CollectionStoreParameters(global::Org.BouncyCastle.Utilities.Platform.CreateArrayList()));
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x000FA02C File Offset: 0x000F822C
		public virtual global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo ToAsn1Structure()
		{
			return this.originatorInfo;
		}

		// Token: 0x04001760 RID: 5984
		private readonly global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo originatorInfo;
	}
}
