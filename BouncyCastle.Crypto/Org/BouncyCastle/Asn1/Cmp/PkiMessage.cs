using System;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000783 RID: 1923
	public class PkiMessage : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600447B RID: 17531 RVA: 0x00130E98 File Offset: 0x0012F098
		private PkiMessage(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.header = global::Org.BouncyCastle.Asn1.Cmp.PkiHeader.GetInstance(seq[0]);
			this.body = global::Org.BouncyCastle.Asn1.Cmp.PkiBody.GetInstance(seq[1]);
			for (int pos = 2; pos < seq.Count; pos++)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject tObj = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[pos].ToAsn1Object();
				if (tObj.TagNo == 0)
				{
					this.protection = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(tObj, true);
				}
				else
				{
					this.extraCerts = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(tObj, true);
				}
			}
		}

		// Token: 0x0600447C RID: 17532 RVA: 0x00130F16 File Offset: 0x0012F116
		public static global::Org.BouncyCastle.Asn1.Cmp.PkiMessage GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.PkiMessage)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.PkiMessage)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.PkiMessage(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x0600447D RID: 17533 RVA: 0x00130F38 File Offset: 0x0012F138
		public PkiMessage(global::Org.BouncyCastle.Asn1.Cmp.PkiHeader header, global::Org.BouncyCastle.Asn1.Cmp.PkiBody body, global::Org.BouncyCastle.Asn1.DerBitString protection, global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate[] extraCerts)
		{
			this.header = header;
			this.body = body;
			this.protection = protection;
			if (extraCerts != null)
			{
				this.extraCerts = new global::Org.BouncyCastle.Asn1.DerSequence(extraCerts);
			}
		}

		// Token: 0x0600447E RID: 17534 RVA: 0x00130F73 File Offset: 0x0012F173
		public PkiMessage(global::Org.BouncyCastle.Asn1.Cmp.PkiHeader header, global::Org.BouncyCastle.Asn1.Cmp.PkiBody body, global::Org.BouncyCastle.Asn1.DerBitString protection) : this(header, body, protection, null)
		{
		}

		// Token: 0x0600447F RID: 17535 RVA: 0x00130F7F File Offset: 0x0012F17F
		public PkiMessage(global::Org.BouncyCastle.Asn1.Cmp.PkiHeader header, global::Org.BouncyCastle.Asn1.Cmp.PkiBody body) : this(header, body, null, null)
		{
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06004480 RID: 17536 RVA: 0x00130F8B File Offset: 0x0012F18B
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiHeader Header
		{
			get
			{
				return this.header;
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06004481 RID: 17537 RVA: 0x00130F93 File Offset: 0x0012F193
		public virtual global::Org.BouncyCastle.Asn1.Cmp.PkiBody Body
		{
			get
			{
				return this.body;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06004482 RID: 17538 RVA: 0x00130F9B File Offset: 0x0012F19B
		public virtual global::Org.BouncyCastle.Asn1.DerBitString Protection
		{
			get
			{
				return this.protection;
			}
		}

		// Token: 0x06004483 RID: 17539 RVA: 0x00130FA4 File Offset: 0x0012F1A4
		public virtual global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate[] GetExtraCerts()
		{
			if (this.extraCerts == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate[] results = new global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate[this.extraCerts.Count];
			for (int i = 0; i < results.Length; i++)
			{
				results[i] = global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate.GetInstance(this.extraCerts[i]);
			}
			return results;
		}

		// Token: 0x06004484 RID: 17540 RVA: 0x00130FEF File Offset: 0x0012F1EF
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.header,
				this.body
			});
			asn1EncodableVector.AddOptionalTagged(true, 0, this.protection);
			asn1EncodableVector.AddOptionalTagged(true, 1, this.extraCerts);
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x04002130 RID: 8496
		private readonly global::Org.BouncyCastle.Asn1.Cmp.PkiHeader header;

		// Token: 0x04002131 RID: 8497
		private readonly global::Org.BouncyCastle.Asn1.Cmp.PkiBody body;

		// Token: 0x04002132 RID: 8498
		private readonly global::Org.BouncyCastle.Asn1.DerBitString protection;

		// Token: 0x04002133 RID: 8499
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence extraCerts;
	}
}
