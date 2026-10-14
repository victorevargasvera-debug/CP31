using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006C2 RID: 1730
	public class SignerInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003F45 RID: 16197 RVA: 0x0011FD84 File Offset: 0x0011DF84
		public static global::Org.BouncyCastle.Asn1.Pkcs.SignerInfo GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Pkcs.SignerInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.SignerInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.SignerInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x0011FDC3 File Offset: 0x0011DFC3
		public SignerInfo(global::Org.BouncyCastle.Asn1.DerInteger version, global::Org.BouncyCastle.Asn1.Pkcs.IssuerAndSerialNumber issuerAndSerialNumber, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digAlgorithm, global::Org.BouncyCastle.Asn1.Asn1Set authenticatedAttributes, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digEncryptionAlgorithm, global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedDigest, global::Org.BouncyCastle.Asn1.Asn1Set unauthenticatedAttributes)
		{
			this.version = version;
			this.issuerAndSerialNumber = issuerAndSerialNumber;
			this.digAlgorithm = digAlgorithm;
			this.authenticatedAttributes = authenticatedAttributes;
			this.digEncryptionAlgorithm = digEncryptionAlgorithm;
			this.encryptedDigest = encryptedDigest;
			this.unauthenticatedAttributes = unauthenticatedAttributes;
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x0011FE00 File Offset: 0x0011E000
		public SignerInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			global::System.Collections.IEnumerator e = seq.GetEnumerator();
			e.MoveNext();
			this.version = (global::Org.BouncyCastle.Asn1.DerInteger)e.Current;
			e.MoveNext();
			this.issuerAndSerialNumber = global::Org.BouncyCastle.Asn1.Pkcs.IssuerAndSerialNumber.GetInstance(e.Current);
			e.MoveNext();
			this.digAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(e.Current);
			e.MoveNext();
			object obj = e.Current;
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				this.authenticatedAttributes = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj, false);
				e.MoveNext();
				this.digEncryptionAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(e.Current);
			}
			else
			{
				this.authenticatedAttributes = null;
				this.digEncryptionAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(obj);
			}
			e.MoveNext();
			this.encryptedDigest = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(e.Current);
			if (e.MoveNext())
			{
				this.unauthenticatedAttributes = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)e.Current, false);
				return;
			}
			this.unauthenticatedAttributes = null;
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06003F48 RID: 16200 RVA: 0x0011FEF6 File Offset: 0x0011E0F6
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06003F49 RID: 16201 RVA: 0x0011FEFE File Offset: 0x0011E0FE
		public global::Org.BouncyCastle.Asn1.Pkcs.IssuerAndSerialNumber IssuerAndSerialNumber
		{
			get
			{
				return this.issuerAndSerialNumber;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06003F4A RID: 16202 RVA: 0x0011FF06 File Offset: 0x0011E106
		public global::Org.BouncyCastle.Asn1.Asn1Set AuthenticatedAttributes
		{
			get
			{
				return this.authenticatedAttributes;
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06003F4B RID: 16203 RVA: 0x0011FF0E File Offset: 0x0011E10E
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DigestAlgorithm
		{
			get
			{
				return this.digAlgorithm;
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06003F4C RID: 16204 RVA: 0x0011FF16 File Offset: 0x0011E116
		public global::Org.BouncyCastle.Asn1.Asn1OctetString EncryptedDigest
		{
			get
			{
				return this.encryptedDigest;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06003F4D RID: 16205 RVA: 0x0011FF1E File Offset: 0x0011E11E
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DigestEncryptionAlgorithm
		{
			get
			{
				return this.digEncryptionAlgorithm;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06003F4E RID: 16206 RVA: 0x0011FF26 File Offset: 0x0011E126
		public global::Org.BouncyCastle.Asn1.Asn1Set UnauthenticatedAttributes
		{
			get
			{
				return this.unauthenticatedAttributes;
			}
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x0011FF30 File Offset: 0x0011E130
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version,
				this.issuerAndSerialNumber,
				this.digAlgorithm
			});
			v.AddOptionalTagged(false, 0, this.authenticatedAttributes);
			v.Add(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.digEncryptionAlgorithm,
				this.encryptedDigest
			});
			v.AddOptionalTagged(false, 1, this.unauthenticatedAttributes);
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001D40 RID: 7488
		private global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04001D41 RID: 7489
		private global::Org.BouncyCastle.Asn1.Pkcs.IssuerAndSerialNumber issuerAndSerialNumber;

		// Token: 0x04001D42 RID: 7490
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digAlgorithm;

		// Token: 0x04001D43 RID: 7491
		private global::Org.BouncyCastle.Asn1.Asn1Set authenticatedAttributes;

		// Token: 0x04001D44 RID: 7492
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digEncryptionAlgorithm;

		// Token: 0x04001D45 RID: 7493
		private global::Org.BouncyCastle.Asn1.Asn1OctetString encryptedDigest;

		// Token: 0x04001D46 RID: 7494
		private global::Org.BouncyCastle.Asn1.Asn1Set unauthenticatedAttributes;
	}
}
