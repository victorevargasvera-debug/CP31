using System;
using System.Collections;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000761 RID: 1889
	public class SignedData : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600437E RID: 17278 RVA: 0x0012E11B File Offset: 0x0012C31B
		public static global::Org.BouncyCastle.Asn1.Cms.SignedData GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cms.SignedData)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.SignedData)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.Cms.SignedData(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x0012E13C File Offset: 0x0012C33C
		public SignedData(global::Org.BouncyCastle.Asn1.Asn1Set digestAlgorithms, global::Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo, global::Org.BouncyCastle.Asn1.Asn1Set certificates, global::Org.BouncyCastle.Asn1.Asn1Set crls, global::Org.BouncyCastle.Asn1.Asn1Set signerInfos)
		{
			this.version = this.CalculateVersion(contentInfo.ContentType, certificates, crls, signerInfos);
			this.digestAlgorithms = digestAlgorithms;
			this.contentInfo = contentInfo;
			this.certificates = certificates;
			this.crls = crls;
			this.signerInfos = signerInfos;
			this.crlsBer = (crls is global::Org.BouncyCastle.Asn1.BerSet);
			this.certsBer = (certificates is global::Org.BouncyCastle.Asn1.BerSet);
		}

		// Token: 0x06004380 RID: 17280 RVA: 0x0012E1AC File Offset: 0x0012C3AC
		private global::Org.BouncyCastle.Asn1.DerInteger CalculateVersion(global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentOid, global::Org.BouncyCastle.Asn1.Asn1Set certs, global::Org.BouncyCastle.Asn1.Asn1Set crls, global::Org.BouncyCastle.Asn1.Asn1Set signerInfs)
		{
			bool otherCert = false;
			bool otherCrl = false;
			bool attrCertV1Found = false;
			bool attrCertV2Found = false;
			if (certs != null)
			{
				foreach (object obj in certs)
				{
					if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
					{
						global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
						if (tagged.TagNo == 1)
						{
							attrCertV1Found = true;
						}
						else if (tagged.TagNo == 2)
						{
							attrCertV2Found = true;
						}
						else if (tagged.TagNo == 3)
						{
							otherCert = true;
							break;
						}
					}
				}
			}
			if (otherCert)
			{
				return global::Org.BouncyCastle.Asn1.Cms.SignedData.Version5;
			}
			if (crls != null)
			{
				using (global::System.Collections.IEnumerator enumerator = crls.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
						{
							otherCrl = true;
							break;
						}
					}
				}
			}
			if (otherCrl)
			{
				return global::Org.BouncyCastle.Asn1.Cms.SignedData.Version5;
			}
			if (attrCertV2Found)
			{
				return global::Org.BouncyCastle.Asn1.Cms.SignedData.Version4;
			}
			if (attrCertV1Found || !global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.Data.Equals(contentOid) || this.CheckForVersion3(signerInfs))
			{
				return global::Org.BouncyCastle.Asn1.Cms.SignedData.Version3;
			}
			return global::Org.BouncyCastle.Asn1.Cms.SignedData.Version1;
		}

		// Token: 0x06004381 RID: 17281 RVA: 0x0012E2D0 File Offset: 0x0012C4D0
		private bool CheckForVersion3(global::Org.BouncyCastle.Asn1.Asn1Set signerInfs)
		{
			using (global::System.Collections.IEnumerator enumerator = signerInfs.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (global::Org.BouncyCastle.Asn1.Cms.SignerInfo.GetInstance(enumerator.Current).Version.HasValue(3))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06004382 RID: 17282 RVA: 0x0012E330 File Offset: 0x0012C530
		private SignedData(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			global::System.Collections.IEnumerator e = seq.GetEnumerator();
			e.MoveNext();
			this.version = (global::Org.BouncyCastle.Asn1.DerInteger)e.Current;
			e.MoveNext();
			this.digestAlgorithms = (global::Org.BouncyCastle.Asn1.Asn1Set)e.Current;
			e.MoveNext();
			this.contentInfo = global::Org.BouncyCastle.Asn1.Cms.ContentInfo.GetInstance(e.Current);
			while (e.MoveNext())
			{
				object obj = e.Current;
				global::Org.BouncyCastle.Asn1.Asn1Object o = (global::Org.BouncyCastle.Asn1.Asn1Object)obj;
				if (o is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
				{
					global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)o;
					int tagNo = tagged.TagNo;
					if (tagNo != 0)
					{
						if (tagNo != 1)
						{
							throw new global::System.ArgumentException("unknown tag value " + tagged.TagNo.ToString());
						}
						this.crlsBer = (tagged is global::Org.BouncyCastle.Asn1.BerTaggedObject);
						this.crls = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(tagged, false);
					}
					else
					{
						this.certsBer = (tagged is global::Org.BouncyCastle.Asn1.BerTaggedObject);
						this.certificates = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(tagged, false);
					}
				}
				else
				{
					this.signerInfos = (global::Org.BouncyCastle.Asn1.Asn1Set)o;
				}
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06004383 RID: 17283 RVA: 0x0012E434 File Offset: 0x0012C634
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06004384 RID: 17284 RVA: 0x0012E43C File Offset: 0x0012C63C
		public global::Org.BouncyCastle.Asn1.Asn1Set DigestAlgorithms
		{
			get
			{
				return this.digestAlgorithms;
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06004385 RID: 17285 RVA: 0x0012E444 File Offset: 0x0012C644
		public global::Org.BouncyCastle.Asn1.Cms.ContentInfo EncapContentInfo
		{
			get
			{
				return this.contentInfo;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06004386 RID: 17286 RVA: 0x0012E44C File Offset: 0x0012C64C
		public global::Org.BouncyCastle.Asn1.Asn1Set Certificates
		{
			get
			{
				return this.certificates;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06004387 RID: 17287 RVA: 0x0012E454 File Offset: 0x0012C654
		public global::Org.BouncyCastle.Asn1.Asn1Set CRLs
		{
			get
			{
				return this.crls;
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06004388 RID: 17288 RVA: 0x0012E45C File Offset: 0x0012C65C
		public global::Org.BouncyCastle.Asn1.Asn1Set SignerInfos
		{
			get
			{
				return this.signerInfos;
			}
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x0012E464 File Offset: 0x0012C664
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version,
				this.digestAlgorithms,
				this.contentInfo
			});
			if (this.certificates != null)
			{
				if (this.certsBer)
				{
					v.Add(new global::Org.BouncyCastle.Asn1.BerTaggedObject(false, 0, this.certificates));
				}
				else
				{
					v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 0, this.certificates));
				}
			}
			if (this.crls != null)
			{
				if (this.crlsBer)
				{
					v.Add(new global::Org.BouncyCastle.Asn1.BerTaggedObject(false, 1, this.crls));
				}
				else
				{
					v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 1, this.crls));
				}
			}
			v.Add(this.signerInfos);
			return new global::Org.BouncyCastle.Asn1.BerSequence(v);
		}

		// Token: 0x0400206E RID: 8302
		private static readonly global::Org.BouncyCastle.Asn1.DerInteger Version1 = new global::Org.BouncyCastle.Asn1.DerInteger(1);

		// Token: 0x0400206F RID: 8303
		private static readonly global::Org.BouncyCastle.Asn1.DerInteger Version3 = new global::Org.BouncyCastle.Asn1.DerInteger(3);

		// Token: 0x04002070 RID: 8304
		private static readonly global::Org.BouncyCastle.Asn1.DerInteger Version4 = new global::Org.BouncyCastle.Asn1.DerInteger(4);

		// Token: 0x04002071 RID: 8305
		private static readonly global::Org.BouncyCastle.Asn1.DerInteger Version5 = new global::Org.BouncyCastle.Asn1.DerInteger(5);

		// Token: 0x04002072 RID: 8306
		private readonly global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04002073 RID: 8307
		private readonly global::Org.BouncyCastle.Asn1.Asn1Set digestAlgorithms;

		// Token: 0x04002074 RID: 8308
		private readonly global::Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo;

		// Token: 0x04002075 RID: 8309
		private readonly global::Org.BouncyCastle.Asn1.Asn1Set certificates;

		// Token: 0x04002076 RID: 8310
		private readonly global::Org.BouncyCastle.Asn1.Asn1Set crls;

		// Token: 0x04002077 RID: 8311
		private readonly global::Org.BouncyCastle.Asn1.Asn1Set signerInfos;

		// Token: 0x04002078 RID: 8312
		private readonly bool certsBer;

		// Token: 0x04002079 RID: 8313
		private readonly bool crlsBer;
	}
}
