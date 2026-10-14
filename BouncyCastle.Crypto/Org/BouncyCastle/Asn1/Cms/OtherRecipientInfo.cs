using System;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000759 RID: 1881
	public class OtherRecipientInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600433B RID: 17211 RVA: 0x0012D7F9 File Offset: 0x0012B9F9
		public OtherRecipientInfo(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oriType, global::Org.BouncyCastle.Asn1.Asn1Encodable oriValue)
		{
			this.oriType = oriType;
			this.oriValue = oriValue;
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x0012D80F File Offset: 0x0012BA0F
		[global::System.Obsolete("Use GetInstance() instead")]
		public OtherRecipientInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.oriType = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[0]);
			this.oriValue = seq[1];
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x0012D836 File Offset: 0x0012BA36
		public static global::Org.BouncyCastle.Asn1.Cms.OtherRecipientInfo GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Cms.OtherRecipientInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x0012D844 File Offset: 0x0012BA44
		public static global::Org.BouncyCastle.Asn1.Cms.OtherRecipientInfo GetInstance(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Cms.OtherRecipientInfo existing = obj as global::Org.BouncyCastle.Asn1.Cms.OtherRecipientInfo;
			if (existing != null)
			{
				return existing;
			}
			return new global::Org.BouncyCastle.Asn1.Cms.OtherRecipientInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x0600433F RID: 17215 RVA: 0x0012D86D File Offset: 0x0012BA6D
		public virtual global::Org.BouncyCastle.Asn1.DerObjectIdentifier OriType
		{
			get
			{
				return this.oriType;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06004340 RID: 17216 RVA: 0x0012D875 File Offset: 0x0012BA75
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable OriValue
		{
			get
			{
				return this.oriValue;
			}
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x0012D87D File Offset: 0x0012BA7D
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.oriType,
				this.oriValue
			});
		}

		// Token: 0x0400205D RID: 8285
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier oriType;

		// Token: 0x0400205E RID: 8286
		private readonly global::Org.BouncyCastle.Asn1.Asn1Encodable oriValue;
	}
}
