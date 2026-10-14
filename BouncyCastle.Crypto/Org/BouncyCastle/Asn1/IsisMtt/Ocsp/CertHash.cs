using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.IsisMtt.Ocsp
{
	// Token: 0x020006EF RID: 1775
	public class CertHash : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600405D RID: 16477 RVA: 0x00124148 File Offset: 0x00122348
		public static global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.CertHash GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.CertHash)
			{
				return (global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.CertHash)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.IsisMtt.Ocsp.CertHash((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x00124198 File Offset: 0x00122398
		private CertHash(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			this.hashAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[0]);
			this.certificateHash = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[1]).GetOctets();
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x001241FB File Offset: 0x001223FB
		public CertHash(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm, byte[] certificateHash)
		{
			if (hashAlgorithm == null)
			{
				throw new global::System.ArgumentNullException("hashAlgorithm");
			}
			if (certificateHash == null)
			{
				throw new global::System.ArgumentNullException("certificateHash");
			}
			this.hashAlgorithm = hashAlgorithm;
			this.certificateHash = (byte[])certificateHash.Clone();
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06004060 RID: 16480 RVA: 0x00124237 File Offset: 0x00122437
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm
		{
			get
			{
				return this.hashAlgorithm;
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06004061 RID: 16481 RVA: 0x0012423F File Offset: 0x0012243F
		public byte[] CertificateHash
		{
			get
			{
				return (byte[])this.certificateHash.Clone();
			}
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x00124251 File Offset: 0x00122451
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.hashAlgorithm,
				new global::Org.BouncyCastle.Asn1.DerOctetString(this.certificateHash)
			});
		}

		// Token: 0x04001E84 RID: 7812
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm;

		// Token: 0x04001E85 RID: 7813
		private readonly byte[] certificateHash;
	}
}
