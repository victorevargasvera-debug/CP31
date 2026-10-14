using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000740 RID: 1856
	public class AuthEnvelopedData : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004287 RID: 17031 RVA: 0x0012BA68 File Offset: 0x00129C68
		public AuthEnvelopedData(global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo originatorInfo, global::Org.BouncyCastle.Asn1.Asn1Set recipientInfos, global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo authEncryptedContentInfo, global::Org.BouncyCastle.Asn1.Asn1Set authAttrs, global::Org.BouncyCastle.Asn1.Asn1OctetString mac, global::Org.BouncyCastle.Asn1.Asn1Set unauthAttrs)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(0);
			this.originatorInfo = originatorInfo;
			this.recipientInfos = recipientInfos;
			if (this.recipientInfos.Count < 1)
			{
				throw new global::System.ArgumentException("AuthEnvelopedData requires at least 1 RecipientInfo");
			}
			this.authEncryptedContentInfo = authEncryptedContentInfo;
			this.authAttrs = authAttrs;
			if (!authEncryptedContentInfo.ContentType.Equals(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.Data) && (authAttrs == null || authAttrs.Count < 1))
			{
				throw new global::System.ArgumentException("authAttrs must be present with non-data content");
			}
			this.mac = mac;
			this.unauthAttrs = unauthAttrs;
		}

		// Token: 0x06004288 RID: 17032 RVA: 0x0012BAF8 File Offset: 0x00129CF8
		private AuthEnvelopedData(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			int index = 0;
			global::Org.BouncyCastle.Asn1.Asn1Object tmp = seq[index++].ToAsn1Object();
			this.version = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(tmp);
			if (!this.version.HasValue(0))
			{
				throw new global::System.ArgumentException("AuthEnvelopedData version number must be 0");
			}
			tmp = seq[index++].ToAsn1Object();
			if (tmp is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				this.originatorInfo = global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)tmp, false);
				tmp = seq[index++].ToAsn1Object();
			}
			this.recipientInfos = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(tmp);
			if (this.recipientInfos.Count < 1)
			{
				throw new global::System.ArgumentException("AuthEnvelopedData requires at least 1 RecipientInfo");
			}
			tmp = seq[index++].ToAsn1Object();
			this.authEncryptedContentInfo = global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo.GetInstance(tmp);
			tmp = seq[index++].ToAsn1Object();
			if (tmp is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				this.authAttrs = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)tmp, false);
				tmp = seq[index++].ToAsn1Object();
			}
			else if (!this.authEncryptedContentInfo.ContentType.Equals(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.Data) && (this.authAttrs == null || this.authAttrs.Count < 1))
			{
				throw new global::System.ArgumentException("authAttrs must be present with non-data content");
			}
			this.mac = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(tmp);
			if (seq.Count > index)
			{
				tmp = seq[index++].ToAsn1Object();
				this.unauthAttrs = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)tmp, false);
			}
		}

		// Token: 0x06004289 RID: 17033 RVA: 0x0012BC6F File Offset: 0x00129E6F
		public static global::Org.BouncyCastle.Asn1.Cms.AuthEnvelopedData GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.Cms.AuthEnvelopedData.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x0600428A RID: 17034 RVA: 0x0012BC7D File Offset: 0x00129E7D
		public static global::Org.BouncyCastle.Asn1.Cms.AuthEnvelopedData GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.AuthEnvelopedData)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.AuthEnvelopedData)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.AuthEnvelopedData((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid AuthEnvelopedData: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x0600428B RID: 17035 RVA: 0x0012BCBA File Offset: 0x00129EBA
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x0600428C RID: 17036 RVA: 0x0012BCC2 File Offset: 0x00129EC2
		public global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo OriginatorInfo
		{
			get
			{
				return this.originatorInfo;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x0600428D RID: 17037 RVA: 0x0012BCCA File Offset: 0x00129ECA
		public global::Org.BouncyCastle.Asn1.Asn1Set RecipientInfos
		{
			get
			{
				return this.recipientInfos;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x0600428E RID: 17038 RVA: 0x0012BCD2 File Offset: 0x00129ED2
		public global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo AuthEncryptedContentInfo
		{
			get
			{
				return this.authEncryptedContentInfo;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x0600428F RID: 17039 RVA: 0x0012BCDA File Offset: 0x00129EDA
		public global::Org.BouncyCastle.Asn1.Asn1Set AuthAttrs
		{
			get
			{
				return this.authAttrs;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06004290 RID: 17040 RVA: 0x0012BCE2 File Offset: 0x00129EE2
		public global::Org.BouncyCastle.Asn1.Asn1OctetString Mac
		{
			get
			{
				return this.mac;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06004291 RID: 17041 RVA: 0x0012BCEA File Offset: 0x00129EEA
		public global::Org.BouncyCastle.Asn1.Asn1Set UnauthAttrs
		{
			get
			{
				return this.unauthAttrs;
			}
		}

		// Token: 0x06004292 RID: 17042 RVA: 0x0012BCF4 File Offset: 0x00129EF4
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version
			});
			v.AddOptionalTagged(false, 0, this.originatorInfo);
			v.Add(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.recipientInfos,
				this.authEncryptedContentInfo
			});
			v.AddOptionalTagged(false, 1, this.authAttrs);
			v.Add(this.mac);
			v.AddOptionalTagged(false, 2, this.unauthAttrs);
			return new global::Org.BouncyCastle.Asn1.BerSequence(v);
		}

		// Token: 0x04002002 RID: 8194
		private global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04002003 RID: 8195
		private global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo originatorInfo;

		// Token: 0x04002004 RID: 8196
		private global::Org.BouncyCastle.Asn1.Asn1Set recipientInfos;

		// Token: 0x04002005 RID: 8197
		private global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo authEncryptedContentInfo;

		// Token: 0x04002006 RID: 8198
		private global::Org.BouncyCastle.Asn1.Asn1Set authAttrs;

		// Token: 0x04002007 RID: 8199
		private global::Org.BouncyCastle.Asn1.Asn1OctetString mac;

		// Token: 0x04002008 RID: 8200
		private global::Org.BouncyCastle.Asn1.Asn1Set unauthAttrs;
	}
}
