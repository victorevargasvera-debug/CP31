using System;
using System.Collections;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x0200074B RID: 1867
	public class EnvelopedData : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060042C8 RID: 17096 RVA: 0x0012C688 File Offset: 0x0012A888
		public EnvelopedData(global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo originatorInfo, global::Org.BouncyCastle.Asn1.Asn1Set recipientInfos, global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo encryptedContentInfo, global::Org.BouncyCastle.Asn1.Asn1Set unprotectedAttrs)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(global::Org.BouncyCastle.Asn1.Cms.EnvelopedData.CalculateVersion(originatorInfo, recipientInfos, unprotectedAttrs));
			this.originatorInfo = originatorInfo;
			this.recipientInfos = recipientInfos;
			this.encryptedContentInfo = encryptedContentInfo;
			this.unprotectedAttrs = unprotectedAttrs;
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x0012C6C4 File Offset: 0x0012A8C4
		public EnvelopedData(global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo originatorInfo, global::Org.BouncyCastle.Asn1.Asn1Set recipientInfos, global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo encryptedContentInfo, global::Org.BouncyCastle.Asn1.Cms.Attributes unprotectedAttrs)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(global::Org.BouncyCastle.Asn1.Cms.EnvelopedData.CalculateVersion(originatorInfo, recipientInfos, global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(unprotectedAttrs)));
			this.originatorInfo = originatorInfo;
			this.recipientInfos = recipientInfos;
			this.encryptedContentInfo = encryptedContentInfo;
			this.unprotectedAttrs = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(unprotectedAttrs);
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x0012C714 File Offset: 0x0012A914
		[global::System.Obsolete("Use 'GetInstance' instead")]
		public EnvelopedData(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			int index = 0;
			this.version = (global::Org.BouncyCastle.Asn1.DerInteger)seq[index++];
			object tmp = seq[index++];
			if (tmp is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				this.originatorInfo = global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)tmp, false);
				tmp = seq[index++];
			}
			this.recipientInfos = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(tmp);
			this.encryptedContentInfo = global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo.GetInstance(seq[index++]);
			if (seq.Count > index)
			{
				this.unprotectedAttrs = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[index], false);
			}
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x0012C7B4 File Offset: 0x0012A9B4
		public static global::Org.BouncyCastle.Asn1.Cms.EnvelopedData GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Cms.EnvelopedData.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x0012C7C2 File Offset: 0x0012A9C2
		public static global::Org.BouncyCastle.Asn1.Cms.EnvelopedData GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cms.EnvelopedData)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.EnvelopedData)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.Cms.EnvelopedData(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x060042CD RID: 17101 RVA: 0x0012C7E3 File Offset: 0x0012A9E3
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x060042CE RID: 17102 RVA: 0x0012C7EB File Offset: 0x0012A9EB
		public global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo OriginatorInfo
		{
			get
			{
				return this.originatorInfo;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x060042CF RID: 17103 RVA: 0x0012C7F3 File Offset: 0x0012A9F3
		public global::Org.BouncyCastle.Asn1.Asn1Set RecipientInfos
		{
			get
			{
				return this.recipientInfos;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x060042D0 RID: 17104 RVA: 0x0012C7FB File Offset: 0x0012A9FB
		public global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo EncryptedContentInfo
		{
			get
			{
				return this.encryptedContentInfo;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x060042D1 RID: 17105 RVA: 0x0012C803 File Offset: 0x0012AA03
		public global::Org.BouncyCastle.Asn1.Asn1Set UnprotectedAttrs
		{
			get
			{
				return this.unprotectedAttrs;
			}
		}

		// Token: 0x060042D2 RID: 17106 RVA: 0x0012C80C File Offset: 0x0012AA0C
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
				this.encryptedContentInfo
			});
			v.AddOptionalTagged(false, 1, this.unprotectedAttrs);
			return new global::Org.BouncyCastle.Asn1.BerSequence(v);
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x0012C870 File Offset: 0x0012AA70
		public static int CalculateVersion(global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo originatorInfo, global::Org.BouncyCastle.Asn1.Asn1Set recipientInfos, global::Org.BouncyCastle.Asn1.Asn1Set unprotectedAttrs)
		{
			if (originatorInfo != null || unprotectedAttrs != null)
			{
				return 2;
			}
			using (global::System.Collections.IEnumerator enumerator = recipientInfos.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (!global::Org.BouncyCastle.Asn1.Cms.RecipientInfo.GetInstance(enumerator.Current).Version.HasValue(0))
					{
						return 2;
					}
				}
			}
			return 0;
		}

		// Token: 0x04002033 RID: 8243
		private global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04002034 RID: 8244
		private global::Org.BouncyCastle.Asn1.Cms.OriginatorInfo originatorInfo;

		// Token: 0x04002035 RID: 8245
		private global::Org.BouncyCastle.Asn1.Asn1Set recipientInfos;

		// Token: 0x04002036 RID: 8246
		private global::Org.BouncyCastle.Asn1.Cms.EncryptedContentInfo encryptedContentInfo;

		// Token: 0x04002037 RID: 8247
		private global::Org.BouncyCastle.Asn1.Asn1Set unprotectedAttrs;
	}
}
