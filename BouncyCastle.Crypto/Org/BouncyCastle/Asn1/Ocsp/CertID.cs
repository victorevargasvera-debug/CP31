using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x020006C6 RID: 1734
	public class CertID : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003F65 RID: 16229 RVA: 0x0012028E File Offset: 0x0011E48E
		public static global::Org.BouncyCastle.Asn1.Ocsp.CertID GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Ocsp.CertID.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x0012029C File Offset: 0x0011E49C
		public static global::Org.BouncyCastle.Asn1.Ocsp.CertID GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Ocsp.CertID)
			{
				return (global::Org.BouncyCastle.Asn1.Ocsp.CertID)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.CertID((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x001202E9 File Offset: 0x0011E4E9
		public CertID(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm, global::Org.BouncyCastle.Asn1.Asn1OctetString issuerNameHash, global::Org.BouncyCastle.Asn1.Asn1OctetString issuerKeyHash, global::Org.BouncyCastle.Asn1.DerInteger serialNumber)
		{
			this.hashAlgorithm = hashAlgorithm;
			this.issuerNameHash = issuerNameHash;
			this.issuerKeyHash = issuerKeyHash;
			this.serialNumber = serialNumber;
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x00120310 File Offset: 0x0011E510
		private CertID(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 4)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.hashAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[0]);
			this.issuerNameHash = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[1]);
			this.issuerKeyHash = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[2]);
			this.serialNumber = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[3]);
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06003F69 RID: 16233 RVA: 0x00120384 File Offset: 0x0011E584
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm
		{
			get
			{
				return this.hashAlgorithm;
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06003F6A RID: 16234 RVA: 0x0012038C File Offset: 0x0011E58C
		public global::Org.BouncyCastle.Asn1.Asn1OctetString IssuerNameHash
		{
			get
			{
				return this.issuerNameHash;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06003F6B RID: 16235 RVA: 0x00120394 File Offset: 0x0011E594
		public global::Org.BouncyCastle.Asn1.Asn1OctetString IssuerKeyHash
		{
			get
			{
				return this.issuerKeyHash;
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06003F6C RID: 16236 RVA: 0x0012039C File Offset: 0x0011E59C
		public global::Org.BouncyCastle.Asn1.DerInteger SerialNumber
		{
			get
			{
				return this.serialNumber;
			}
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x001203A4 File Offset: 0x0011E5A4
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.hashAlgorithm,
				this.issuerNameHash,
				this.issuerKeyHash,
				this.serialNumber
			});
		}

		// Token: 0x04001D59 RID: 7513
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm;

		// Token: 0x04001D5A RID: 7514
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString issuerNameHash;

		// Token: 0x04001D5B RID: 7515
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString issuerKeyHash;

		// Token: 0x04001D5C RID: 7516
		private readonly global::Org.BouncyCastle.Asn1.DerInteger serialNumber;
	}
}
