using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006AC RID: 1708
	public class CertificationRequestInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003E9C RID: 16028 RVA: 0x0011D8CF File Offset: 0x0011BACF
		public static global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequestInfo GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequestInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequestInfo)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequestInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x06003E9D RID: 16029 RVA: 0x0011D8F0 File Offset: 0x0011BAF0
		public CertificationRequestInfo(global::Org.BouncyCastle.Asn1.X509.X509Name subject, global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo pkInfo, global::Org.BouncyCastle.Asn1.Asn1Set attributes)
		{
			this.subject = subject;
			this.subjectPKInfo = pkInfo;
			this.attributes = attributes;
			global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequestInfo.ValidateAttributes(attributes);
			if (subject == null || this.version == null || this.subjectPKInfo == null)
			{
				throw new global::System.ArgumentException("Not all mandatory fields set in CertificationRequestInfo generator.");
			}
		}

		// Token: 0x06003E9E RID: 16030 RVA: 0x0011D948 File Offset: 0x0011BB48
		private CertificationRequestInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.version = (global::Org.BouncyCastle.Asn1.DerInteger)seq[0];
			this.subject = global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(seq[1]);
			this.subjectPKInfo = global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo.GetInstance(seq[2]);
			if (seq.Count > 3)
			{
				global::Org.BouncyCastle.Asn1.DerTaggedObject tagobj = (global::Org.BouncyCastle.Asn1.DerTaggedObject)seq[3];
				this.attributes = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(tagobj, false);
			}
			global::Org.BouncyCastle.Asn1.Pkcs.CertificationRequestInfo.ValidateAttributes(this.attributes);
			if (this.subject == null || this.version == null || this.subjectPKInfo == null)
			{
				throw new global::System.ArgumentException("Not all mandatory fields set in CertificationRequestInfo generator.");
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06003E9F RID: 16031 RVA: 0x0011D9EE File Offset: 0x0011BBEE
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06003EA0 RID: 16032 RVA: 0x0011D9F6 File Offset: 0x0011BBF6
		public global::Org.BouncyCastle.Asn1.X509.X509Name Subject
		{
			get
			{
				return this.subject;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06003EA1 RID: 16033 RVA: 0x0011D9FE File Offset: 0x0011BBFE
		public global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo SubjectPublicKeyInfo
		{
			get
			{
				return this.subjectPKInfo;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06003EA2 RID: 16034 RVA: 0x0011DA06 File Offset: 0x0011BC06
		public global::Org.BouncyCastle.Asn1.Asn1Set Attributes
		{
			get
			{
				return this.attributes;
			}
		}

		// Token: 0x06003EA3 RID: 16035 RVA: 0x0011DA0E File Offset: 0x0011BC0E
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version,
				this.subject,
				this.subjectPKInfo
			});
			asn1EncodableVector.AddOptionalTagged(false, 0, this.attributes);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x06003EA4 RID: 16036 RVA: 0x0011DA4C File Offset: 0x0011BC4C
		private static void ValidateAttributes(global::Org.BouncyCastle.Asn1.Asn1Set attributes)
		{
			if (attributes == null)
			{
				return;
			}
			foreach (object obj in attributes)
			{
				global::Org.BouncyCastle.Asn1.Pkcs.AttributePkcs attr = global::Org.BouncyCastle.Asn1.Pkcs.AttributePkcs.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj).ToAsn1Object());
				if (attr.AttrType.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Pkcs9AtChallengePassword) && attr.AttrValues.Count != 1)
				{
					throw new global::System.ArgumentException("challengePassword attribute must have one value");
				}
			}
		}

		// Token: 0x04001C6A RID: 7274
		internal global::Org.BouncyCastle.Asn1.DerInteger version = new global::Org.BouncyCastle.Asn1.DerInteger(0);

		// Token: 0x04001C6B RID: 7275
		internal global::Org.BouncyCastle.Asn1.X509.X509Name subject;

		// Token: 0x04001C6C RID: 7276
		internal global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo subjectPKInfo;

		// Token: 0x04001C6D RID: 7277
		internal global::Org.BouncyCastle.Asn1.Asn1Set attributes;
	}
}
