using System;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x0200078F RID: 1935
	public class RevRepContent : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060044C4 RID: 17604 RVA: 0x00131958 File Offset: 0x0012FB58
		private RevRepContent(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.status = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(seq[0]);
			for (int pos = 1; pos < seq.Count; pos++)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject tObj = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[pos]);
				if (tObj.TagNo == 0)
				{
					this.revCerts = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(tObj, true);
				}
				else
				{
					this.crls = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(tObj, true);
				}
			}
		}

		// Token: 0x060044C5 RID: 17605 RVA: 0x001319BF File Offset: 0x0012FBBF
		public static global::Org.BouncyCastle.Asn1.Cmp.RevRepContent GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.RevRepContent)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.RevRepContent)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.RevRepContent((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060044C6 RID: 17606 RVA: 0x00131A00 File Offset: 0x0012FC00
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo[] GetStatus()
		{
			global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo[] results = new global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo[this.status.Count];
			for (int i = 0; i != results.Length; i++)
			{
				results[i] = global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo.GetInstance(this.status[i]);
			}
			return results;
		}

		// Token: 0x060044C7 RID: 17607 RVA: 0x00131A44 File Offset: 0x0012FC44
		public virtual global::Org.BouncyCastle.Asn1.Crmf.CertId[] GetRevCerts()
		{
			if (this.revCerts == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Crmf.CertId[] results = new global::Org.BouncyCastle.Asn1.Crmf.CertId[this.revCerts.Count];
			for (int i = 0; i != results.Length; i++)
			{
				results[i] = global::Org.BouncyCastle.Asn1.Crmf.CertId.GetInstance(this.revCerts[i]);
			}
			return results;
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x00131A90 File Offset: 0x0012FC90
		public virtual global::Org.BouncyCastle.Asn1.X509.CertificateList[] GetCrls()
		{
			if (this.crls == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.X509.CertificateList[] results = new global::Org.BouncyCastle.Asn1.X509.CertificateList[this.crls.Count];
			for (int i = 0; i != results.Length; i++)
			{
				results[i] = global::Org.BouncyCastle.Asn1.X509.CertificateList.GetInstance(this.crls[i]);
			}
			return results;
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x00131ADB File Offset: 0x0012FCDB
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.status
			});
			asn1EncodableVector.AddOptionalTagged(true, 0, this.revCerts);
			asn1EncodableVector.AddOptionalTagged(true, 1, this.crls);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04002157 RID: 8535
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence status;

		// Token: 0x04002158 RID: 8536
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence revCerts;

		// Token: 0x04002159 RID: 8537
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence crls;
	}
}
