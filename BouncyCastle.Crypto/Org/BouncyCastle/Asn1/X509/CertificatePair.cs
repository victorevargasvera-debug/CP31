using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000649 RID: 1609
	public class CertificatePair : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003B9F RID: 15263 RVA: 0x001120B8 File Offset: 0x001102B8
		public static global::Org.BouncyCastle.Asn1.X509.CertificatePair GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.CertificatePair)
			{
				return (global::Org.BouncyCastle.Asn1.X509.CertificatePair)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.CertificatePair((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x00112108 File Offset: 0x00110308
		private CertificatePair(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 1 && seq.Count != 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			foreach (object obj in seq)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject o = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(obj);
				if (o.TagNo == 0)
				{
					this.forward = global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(o, true);
				}
				else
				{
					if (o.TagNo != 1)
					{
						throw new global::System.ArgumentException("Bad tag number: " + o.TagNo.ToString());
					}
					this.reverse = global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(o, true);
				}
			}
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x001121E0 File Offset: 0x001103E0
		public CertificatePair(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure forward, global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure reverse)
		{
			this.forward = forward;
			this.reverse = reverse;
		}

		// Token: 0x06003BA2 RID: 15266 RVA: 0x001121F6 File Offset: 0x001103F6
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			asn1EncodableVector.AddOptionalTagged(true, 0, this.forward);
			asn1EncodableVector.AddOptionalTagged(true, 1, this.reverse);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06003BA3 RID: 15267 RVA: 0x0011221E File Offset: 0x0011041E
		public global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure Forward
		{
			get
			{
				return this.forward;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06003BA4 RID: 15268 RVA: 0x00112226 File Offset: 0x00110426
		public global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure Reverse
		{
			get
			{
				return this.reverse;
			}
		}

		// Token: 0x04001A40 RID: 6720
		private global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure forward;

		// Token: 0x04001A41 RID: 6721
		private global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure reverse;
	}
}
