using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cmp
{
	// Token: 0x0200055F RID: 1375
	public class CertificateConfirmationContentBuilder
	{
		// Token: 0x060034A2 RID: 13474 RVA: 0x000FB812 File Offset: 0x000F9A12
		public CertificateConfirmationContentBuilder() : this(new global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder())
		{
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x000FB81F File Offset: 0x000F9A1F
		public CertificateConfirmationContentBuilder(global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder digestAlgFinder)
		{
			this.digestAlgFinder = digestAlgFinder;
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x000FB844 File Offset: 0x000F9A44
		public global::Org.BouncyCastle.Cmp.CertificateConfirmationContentBuilder AddAcceptedCertificate(global::Org.BouncyCastle.X509.X509Certificate certHolder, global::Org.BouncyCastle.Math.BigInteger certReqId)
		{
			this.acceptedCerts.Add(certHolder);
			this.acceptedReqIds.Add(certReqId);
			return this;
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x000FB864 File Offset: 0x000F9A64
		public global::Org.BouncyCastle.Cmp.CertificateConfirmationContent Build()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			for (int i = 0; i != this.acceptedCerts.Count; i++)
			{
				global::Org.BouncyCastle.X509.X509Certificate cert = (global::Org.BouncyCastle.X509.X509Certificate)this.acceptedCerts[i];
				global::Org.BouncyCastle.Math.BigInteger reqId = (global::Org.BouncyCastle.Math.BigInteger)this.acceptedReqIds[i];
				global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithmIdentifier = global::Org.BouncyCastle.Cmp.CertificateConfirmationContentBuilder.sigAlgFinder.Find(cert.SigAlgName);
				global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digAlg = this.digestAlgFinder.find(algorithmIdentifier);
				if (digAlg == null)
				{
					throw new global::Org.BouncyCastle.Cmp.CmpException("cannot find algorithm for digest from signature");
				}
				byte[] digest = global::Org.BouncyCastle.Security.DigestUtilities.CalculateDigest(digAlg.Algorithm, cert.GetEncoded());
				v.Add(new global::Org.BouncyCastle.Asn1.Cmp.CertStatus(digest, reqId));
			}
			return new global::Org.BouncyCastle.Cmp.CertificateConfirmationContent(global::Org.BouncyCastle.Asn1.Cmp.CertConfirmContent.GetInstance(new global::Org.BouncyCastle.Asn1.DerSequence(v)), this.digestAlgFinder);
		}

		// Token: 0x0400178A RID: 6026
		private static readonly global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder sigAlgFinder = new global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder();

		// Token: 0x0400178B RID: 6027
		private readonly global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder digestAlgFinder;

		// Token: 0x0400178C RID: 6028
		private readonly global::System.Collections.IList acceptedCerts = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x0400178D RID: 6029
		private readonly global::System.Collections.IList acceptedReqIds = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
	}
}
