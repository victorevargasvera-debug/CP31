using System;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cmp
{
	// Token: 0x02000560 RID: 1376
	public class CertificateStatus
	{
		// Token: 0x060034A7 RID: 13479 RVA: 0x000FB928 File Offset: 0x000F9B28
		public CertificateStatus(global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder digestAlgFinder, global::Org.BouncyCastle.Asn1.Cmp.CertStatus certStatus)
		{
			this.digestAlgFinder = digestAlgFinder;
			this.certStatus = certStatus;
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x060034A8 RID: 13480 RVA: 0x000FB93E File Offset: 0x000F9B3E
		public global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo PkiStatusInfo
		{
			get
			{
				return this.certStatus.StatusInfo;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x060034A9 RID: 13481 RVA: 0x000FB94B File Offset: 0x000F9B4B
		public global::Org.BouncyCastle.Math.BigInteger CertRequestId
		{
			get
			{
				return this.certStatus.CertReqID.Value;
			}
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x000FB960 File Offset: 0x000F9B60
		public bool IsVerified(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digAlg = this.digestAlgFinder.find(global::Org.BouncyCastle.Cmp.CertificateStatus.sigAlgFinder.Find(cert.SigAlgName));
			if (digAlg == null)
			{
				throw new global::Org.BouncyCastle.Cmp.CmpException("cannot find algorithm for digest from signature " + cert.SigAlgName);
			}
			byte[] digest = global::Org.BouncyCastle.Security.DigestUtilities.CalculateDigest(digAlg.Algorithm, cert.GetEncoded());
			return global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(this.certStatus.CertHash.GetOctets(), digest);
		}

		// Token: 0x0400178E RID: 6030
		private static readonly global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder sigAlgFinder = new global::Org.BouncyCastle.Cms.DefaultSignatureAlgorithmIdentifierFinder();

		// Token: 0x0400178F RID: 6031
		private readonly global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder digestAlgFinder;

		// Token: 0x04001790 RID: 6032
		private readonly global::Org.BouncyCastle.Asn1.Cmp.CertStatus certStatus;
	}
}
