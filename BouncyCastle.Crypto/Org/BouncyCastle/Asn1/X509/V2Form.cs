using System;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000677 RID: 1655
	public class V2Form : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003D07 RID: 15623 RVA: 0x00116470 File Offset: 0x00114670
		public static global::Org.BouncyCastle.Asn1.X509.V2Form GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.V2Form.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003D08 RID: 15624 RVA: 0x0011647E File Offset: 0x0011467E
		public static global::Org.BouncyCastle.Asn1.X509.V2Form GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.V2Form)
			{
				return (global::Org.BouncyCastle.Asn1.X509.V2Form)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.X509.V2Form(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x06003D09 RID: 15625 RVA: 0x0011649F File Offset: 0x0011469F
		public V2Form(global::Org.BouncyCastle.Asn1.X509.GeneralNames issuerName) : this(issuerName, null, null)
		{
		}

		// Token: 0x06003D0A RID: 15626 RVA: 0x001164AA File Offset: 0x001146AA
		public V2Form(global::Org.BouncyCastle.Asn1.X509.GeneralNames issuerName, global::Org.BouncyCastle.Asn1.X509.IssuerSerial baseCertificateID) : this(issuerName, baseCertificateID, null)
		{
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x001164B5 File Offset: 0x001146B5
		public V2Form(global::Org.BouncyCastle.Asn1.X509.GeneralNames issuerName, global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo objectDigestInfo) : this(issuerName, null, objectDigestInfo)
		{
		}

		// Token: 0x06003D0C RID: 15628 RVA: 0x001164C0 File Offset: 0x001146C0
		public V2Form(global::Org.BouncyCastle.Asn1.X509.GeneralNames issuerName, global::Org.BouncyCastle.Asn1.X509.IssuerSerial baseCertificateID, global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo objectDigestInfo)
		{
			this.issuerName = issuerName;
			this.baseCertificateID = baseCertificateID;
			this.objectDigestInfo = objectDigestInfo;
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x001164E0 File Offset: 0x001146E0
		private V2Form(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count > 3)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			int index = 0;
			if (!(seq[0] is global::Org.BouncyCastle.Asn1.Asn1TaggedObject))
			{
				index++;
				this.issuerName = global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(seq[0]);
			}
			for (int i = index; i != seq.Count; i++)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject o = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[i]);
				if (o.TagNo == 0)
				{
					this.baseCertificateID = global::Org.BouncyCastle.Asn1.X509.IssuerSerial.GetInstance(o, false);
				}
				else
				{
					if (o.TagNo != 1)
					{
						throw new global::System.ArgumentException("Bad tag number: " + o.TagNo.ToString());
					}
					this.objectDigestInfo = global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo.GetInstance(o, false);
				}
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06003D0E RID: 15630 RVA: 0x001165AB File Offset: 0x001147AB
		public global::Org.BouncyCastle.Asn1.X509.GeneralNames IssuerName
		{
			get
			{
				return this.issuerName;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06003D0F RID: 15631 RVA: 0x001165B3 File Offset: 0x001147B3
		public global::Org.BouncyCastle.Asn1.X509.IssuerSerial BaseCertificateID
		{
			get
			{
				return this.baseCertificateID;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06003D10 RID: 15632 RVA: 0x001165BB File Offset: 0x001147BB
		public global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo ObjectDigestInfo
		{
			get
			{
				return this.objectDigestInfo;
			}
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x001165C4 File Offset: 0x001147C4
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.issuerName
			});
			v.AddOptionalTagged(false, 0, this.baseCertificateID);
			v.AddOptionalTagged(false, 1, this.objectDigestInfo);
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001AF6 RID: 6902
		internal global::Org.BouncyCastle.Asn1.X509.GeneralNames issuerName;

		// Token: 0x04001AF7 RID: 6903
		internal global::Org.BouncyCastle.Asn1.X509.IssuerSerial baseCertificateID;

		// Token: 0x04001AF8 RID: 6904
		internal global::Org.BouncyCastle.Asn1.X509.ObjectDigestInfo objectDigestInfo;
	}
}
