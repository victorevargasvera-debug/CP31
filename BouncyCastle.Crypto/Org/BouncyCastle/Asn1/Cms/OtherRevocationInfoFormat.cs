using System;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x0200075A RID: 1882
	public class OtherRevocationInfoFormat : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004342 RID: 17218 RVA: 0x0012D89C File Offset: 0x0012BA9C
		public OtherRevocationInfoFormat(global::Org.BouncyCastle.Asn1.DerObjectIdentifier otherRevInfoFormat, global::Org.BouncyCastle.Asn1.Asn1Encodable otherRevInfo)
		{
			this.otherRevInfoFormat = otherRevInfoFormat;
			this.otherRevInfo = otherRevInfo;
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x0012D8B2 File Offset: 0x0012BAB2
		private OtherRevocationInfoFormat(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.otherRevInfoFormat = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[0]);
			this.otherRevInfo = seq[1];
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x0012D8D9 File Offset: 0x0012BAD9
		public static global::Org.BouncyCastle.Asn1.Cms.OtherRevocationInfoFormat GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.Cms.OtherRevocationInfoFormat.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, isExplicit));
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x0012D8E7 File Offset: 0x0012BAE7
		public static global::Org.BouncyCastle.Asn1.Cms.OtherRevocationInfoFormat GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cms.OtherRevocationInfoFormat)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.OtherRevocationInfoFormat)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.OtherRevocationInfoFormat(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06004346 RID: 17222 RVA: 0x0012D908 File Offset: 0x0012BB08
		public virtual global::Org.BouncyCastle.Asn1.DerObjectIdentifier InfoFormat
		{
			get
			{
				return this.otherRevInfoFormat;
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06004347 RID: 17223 RVA: 0x0012D910 File Offset: 0x0012BB10
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable Info
		{
			get
			{
				return this.otherRevInfo;
			}
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x0012D918 File Offset: 0x0012BB18
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.otherRevInfoFormat,
				this.otherRevInfo
			});
		}

		// Token: 0x0400205F RID: 8287
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier otherRevInfoFormat;

		// Token: 0x04002060 RID: 8288
		private readonly global::Org.BouncyCastle.Asn1.Asn1Encodable otherRevInfo;
	}
}
