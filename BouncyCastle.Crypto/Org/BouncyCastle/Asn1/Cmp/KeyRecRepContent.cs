using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x0200077A RID: 1914
	public class KeyRecRepContent : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004428 RID: 17448 RVA: 0x0013014C File Offset: 0x0012E34C
		private KeyRecRepContent(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.status = global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo.GetInstance(seq[0]);
			for (int pos = 1; pos < seq.Count; pos++)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject tObj = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[pos]);
				switch (tObj.TagNo)
				{
				case 0:
					this.newSigCert = global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate.GetInstance(tObj.GetObject());
					break;
				case 1:
					this.caCerts = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(tObj.GetObject());
					break;
				case 2:
					this.keyPairHist = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(tObj.GetObject());
					break;
				default:
					throw new global::System.ArgumentException("unknown tag number: " + tObj.TagNo.ToString(), "seq");
				}
			}
		}

		// Token: 0x06004429 RID: 17449 RVA: 0x0013020C File Offset: 0x0012E40C
		public static global::Org.BouncyCastle.Asn1.Cmp.KeyRecRepContent GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.KeyRecRepContent)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.KeyRecRepContent)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.KeyRecRepContent((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x0600442A RID: 17450 RVA: 0x0013024B File Offset: 0x0012E44B
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo Status
		{
			get
			{
				return this.status;
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x0600442B RID: 17451 RVA: 0x00130253 File Offset: 0x0012E453
		public virtual global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate NewSigCert
		{
			get
			{
				return this.newSigCert;
			}
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x0013025C File Offset: 0x0012E45C
		public virtual global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate[] GetCACerts()
		{
			if (this.caCerts == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate[] results = new global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate[this.caCerts.Count];
			for (int i = 0; i != results.Length; i++)
			{
				results[i] = global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate.GetInstance(this.caCerts[i]);
			}
			return results;
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x001302A8 File Offset: 0x0012E4A8
		public virtual global::Org.BouncyCastle.Asn1.Cmp.CertifiedKeyPair[] GetKeyPairHist()
		{
			if (this.keyPairHist == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Cmp.CertifiedKeyPair[] results = new global::Org.BouncyCastle.Asn1.Cmp.CertifiedKeyPair[this.keyPairHist.Count];
			for (int i = 0; i != results.Length; i++)
			{
				results[i] = global::Org.BouncyCastle.Asn1.Cmp.CertifiedKeyPair.GetInstance(this.keyPairHist[i]);
			}
			return results;
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x001302F4 File Offset: 0x0012E4F4
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.status
			});
			asn1EncodableVector.AddOptionalTagged(true, 0, this.newSigCert);
			asn1EncodableVector.AddOptionalTagged(true, 1, this.caCerts);
			asn1EncodableVector.AddOptionalTagged(true, 2, this.keyPairHist);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x040020D1 RID: 8401
		private readonly global::Org.BouncyCastle.Asn1.Cmp.PkiStatusInfo status;

		// Token: 0x040020D2 RID: 8402
		private readonly global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate newSigCert;

		// Token: 0x040020D3 RID: 8403
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence caCerts;

		// Token: 0x040020D4 RID: 8404
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence keyPairHist;
	}
}
