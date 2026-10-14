using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000670 RID: 1648
	public class TbsCertificateStructure : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003CBF RID: 15551 RVA: 0x00115805 File Offset: 0x00113A05
		public static global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x00115813 File Offset: 0x00113A13
		public static global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure)
			{
				return (global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x00115834 File Offset: 0x00113A34
		internal TbsCertificateStructure(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			int seqStart = 0;
			this.seq = seq;
			if (seq[0] is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				this.version = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[0], true);
			}
			else
			{
				seqStart = -1;
				this.version = new global::Org.BouncyCastle.Asn1.DerInteger(0);
			}
			bool isV = false;
			bool isV2 = false;
			if (this.version.HasValue(0))
			{
				isV = true;
			}
			else if (this.version.HasValue(1))
			{
				isV2 = true;
			}
			else if (!this.version.HasValue(2))
			{
				throw new global::System.ArgumentException("version number not recognised");
			}
			this.serialNumber = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[seqStart + 1]);
			this.signature = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[seqStart + 2]);
			this.issuer = global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(seq[seqStart + 3]);
			global::Org.BouncyCastle.Asn1.Asn1Sequence dates = (global::Org.BouncyCastle.Asn1.Asn1Sequence)seq[seqStart + 4];
			this.startDate = global::Org.BouncyCastle.Asn1.X509.Time.GetInstance(dates[0]);
			this.endDate = global::Org.BouncyCastle.Asn1.X509.Time.GetInstance(dates[1]);
			this.subject = global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(seq[seqStart + 5]);
			this.subjectPublicKeyInfo = global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo.GetInstance(seq[seqStart + 6]);
			int extras = seq.Count - (seqStart + 6) - 1;
			if (extras != 0 && isV)
			{
				throw new global::System.ArgumentException("version 1 certificate contains extra data");
			}
			while (extras > 0)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject extra = global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(seq[seqStart + 6 + extras]);
				switch (extra.TagNo)
				{
				case 1:
					this.issuerUniqueID = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(extra, false);
					break;
				case 2:
					this.subjectUniqueID = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(extra, false);
					break;
				case 3:
					if (isV2)
					{
						throw new global::System.ArgumentException("version 2 certificate cannot contain extensions");
					}
					this.extensions = global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(extra, true));
					break;
				default:
					throw new global::System.ArgumentException("Unknown tag encountered in structure: " + extra.TagNo.ToString());
				}
				extras--;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06003CC2 RID: 15554 RVA: 0x00115A27 File Offset: 0x00113C27
		public int Version
		{
			get
			{
				return this.version.IntValueExact + 1;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06003CC3 RID: 15555 RVA: 0x00115A36 File Offset: 0x00113C36
		public global::Org.BouncyCastle.Asn1.DerInteger VersionNumber
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06003CC4 RID: 15556 RVA: 0x00115A3E File Offset: 0x00113C3E
		public global::Org.BouncyCastle.Asn1.DerInteger SerialNumber
		{
			get
			{
				return this.serialNumber;
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06003CC5 RID: 15557 RVA: 0x00115A46 File Offset: 0x00113C46
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Signature
		{
			get
			{
				return this.signature;
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06003CC6 RID: 15558 RVA: 0x00115A4E File Offset: 0x00113C4E
		public global::Org.BouncyCastle.Asn1.X509.X509Name Issuer
		{
			get
			{
				return this.issuer;
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06003CC7 RID: 15559 RVA: 0x00115A56 File Offset: 0x00113C56
		public global::Org.BouncyCastle.Asn1.X509.Time StartDate
		{
			get
			{
				return this.startDate;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06003CC8 RID: 15560 RVA: 0x00115A5E File Offset: 0x00113C5E
		public global::Org.BouncyCastle.Asn1.X509.Time EndDate
		{
			get
			{
				return this.endDate;
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06003CC9 RID: 15561 RVA: 0x00115A66 File Offset: 0x00113C66
		public global::Org.BouncyCastle.Asn1.X509.X509Name Subject
		{
			get
			{
				return this.subject;
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06003CCA RID: 15562 RVA: 0x00115A6E File Offset: 0x00113C6E
		public global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo SubjectPublicKeyInfo
		{
			get
			{
				return this.subjectPublicKeyInfo;
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06003CCB RID: 15563 RVA: 0x00115A76 File Offset: 0x00113C76
		public global::Org.BouncyCastle.Asn1.DerBitString IssuerUniqueID
		{
			get
			{
				return this.issuerUniqueID;
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06003CCC RID: 15564 RVA: 0x00115A7E File Offset: 0x00113C7E
		public global::Org.BouncyCastle.Asn1.DerBitString SubjectUniqueID
		{
			get
			{
				return this.subjectUniqueID;
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06003CCD RID: 15565 RVA: 0x00115A86 File Offset: 0x00113C86
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions Extensions
		{
			get
			{
				return this.extensions;
			}
		}

		// Token: 0x06003CCE RID: 15566 RVA: 0x00115A90 File Offset: 0x00113C90
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			string property = global::Org.BouncyCastle.Utilities.Platform.GetEnvironmentVariable("Org.BouncyCastle.X509.Allow_Non-DER_TBSCert");
			if (property == null || global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase("true", property))
			{
				return this.seq;
			}
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			if (!this.version.HasValue(0))
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 0, this.version));
			}
			v.Add(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.serialNumber,
				this.signature,
				this.issuer
			});
			v.Add(new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.startDate,
				this.endDate
			}));
			if (this.subject != null)
			{
				v.Add(this.subject);
			}
			else
			{
				v.Add(global::Org.BouncyCastle.Asn1.DerSequence.Empty);
			}
			v.Add(this.subjectPublicKeyInfo);
			v.AddOptionalTagged(false, 1, this.issuerUniqueID);
			v.AddOptionalTagged(false, 2, this.subjectUniqueID);
			v.AddOptionalTagged(true, 3, this.extensions);
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001AC9 RID: 6857
		internal global::Org.BouncyCastle.Asn1.Asn1Sequence seq;

		// Token: 0x04001ACA RID: 6858
		internal global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04001ACB RID: 6859
		internal global::Org.BouncyCastle.Asn1.DerInteger serialNumber;

		// Token: 0x04001ACC RID: 6860
		internal global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier signature;

		// Token: 0x04001ACD RID: 6861
		internal global::Org.BouncyCastle.Asn1.X509.X509Name issuer;

		// Token: 0x04001ACE RID: 6862
		internal global::Org.BouncyCastle.Asn1.X509.Time startDate;

		// Token: 0x04001ACF RID: 6863
		internal global::Org.BouncyCastle.Asn1.X509.Time endDate;

		// Token: 0x04001AD0 RID: 6864
		internal global::Org.BouncyCastle.Asn1.X509.X509Name subject;

		// Token: 0x04001AD1 RID: 6865
		internal global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo subjectPublicKeyInfo;

		// Token: 0x04001AD2 RID: 6866
		internal global::Org.BouncyCastle.Asn1.DerBitString issuerUniqueID;

		// Token: 0x04001AD3 RID: 6867
		internal global::Org.BouncyCastle.Asn1.DerBitString subjectUniqueID;

		// Token: 0x04001AD4 RID: 6868
		internal global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions;
	}
}
