using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x020006D3 RID: 1747
	public class Signature : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003FBE RID: 16318 RVA: 0x00121071 File Offset: 0x0011F271
		public static global::Org.BouncyCastle.Asn1.Ocsp.Signature GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Ocsp.Signature.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x00121080 File Offset: 0x0011F280
		public static global::Org.BouncyCastle.Asn1.Ocsp.Signature GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Ocsp.Signature)
			{
				return (global::Org.BouncyCastle.Asn1.Ocsp.Signature)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.Signature((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x001210CD File Offset: 0x0011F2CD
		public Signature(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signatureAlgorithm, global::Org.BouncyCastle.Asn1.DerBitString signatureValue) : this(signatureAlgorithm, signatureValue, null)
		{
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x001210D8 File Offset: 0x0011F2D8
		public Signature(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signatureAlgorithm, global::Org.BouncyCastle.Asn1.DerBitString signatureValue, global::Org.BouncyCastle.Asn1.Asn1Sequence certs)
		{
			if (signatureAlgorithm == null)
			{
				throw new global::System.ArgumentException("signatureAlgorithm");
			}
			if (signatureValue == null)
			{
				throw new global::System.ArgumentException("signatureValue");
			}
			this.signatureAlgorithm = signatureAlgorithm;
			this.signatureValue = signatureValue;
			this.certs = certs;
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x00121114 File Offset: 0x0011F314
		private Signature(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.signatureAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[0]);
			this.signatureValue = (global::Org.BouncyCastle.Asn1.DerBitString)seq[1];
			if (seq.Count == 3)
			{
				this.certs = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[2], true);
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06003FC3 RID: 16323 RVA: 0x0012116C File Offset: 0x0011F36C
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier SignatureAlgorithm
		{
			get
			{
				return this.signatureAlgorithm;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06003FC4 RID: 16324 RVA: 0x00121174 File Offset: 0x0011F374
		public global::Org.BouncyCastle.Asn1.DerBitString SignatureValue
		{
			get
			{
				return this.signatureValue;
			}
		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x0012117C File Offset: 0x0011F37C
		public byte[] GetSignatureOctets()
		{
			return this.signatureValue.GetOctets();
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06003FC6 RID: 16326 RVA: 0x00121189 File Offset: 0x0011F389
		public global::Org.BouncyCastle.Asn1.Asn1Sequence Certs
		{
			get
			{
				return this.certs;
			}
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x00121191 File Offset: 0x0011F391
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.signatureAlgorithm,
				this.signatureValue
			});
			asn1EncodableVector.AddOptionalTagged(true, 0, this.certs);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04001D85 RID: 7557
		internal global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signatureAlgorithm;

		// Token: 0x04001D86 RID: 7558
		internal global::Org.BouncyCastle.Asn1.DerBitString signatureValue;

		// Token: 0x04001D87 RID: 7559
		internal global::Org.BouncyCastle.Asn1.Asn1Sequence certs;
	}
}
