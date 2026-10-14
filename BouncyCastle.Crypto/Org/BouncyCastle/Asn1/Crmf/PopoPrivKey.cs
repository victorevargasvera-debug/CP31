using System;
using Org.BouncyCastle.Asn1.Cms;

namespace Org.BouncyCastle.Asn1.Crmf
{
	// Token: 0x02000735 RID: 1845
	public class PopoPrivKey : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x0600422E RID: 16942 RVA: 0x0012A94C File Offset: 0x00128B4C
		private PopoPrivKey(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj)
		{
			this.tagNo = obj.TagNo;
			switch (this.tagNo)
			{
			case 0:
				this.obj = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(obj, false);
				return;
			case 1:
				this.obj = global::Org.BouncyCastle.Asn1.Crmf.SubsequentMessage.ValueOf(global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj, false).IntValueExact);
				return;
			case 2:
				this.obj = global::Org.BouncyCastle.Asn1.DerBitString.GetInstance(obj, false);
				return;
			case 3:
				this.obj = global::Org.BouncyCastle.Asn1.Crmf.PKMacValue.GetInstance(obj, false);
				return;
			case 4:
				this.obj = global::Org.BouncyCastle.Asn1.Cms.EnvelopedData.GetInstance(obj, false);
				return;
			default:
				throw new global::System.ArgumentException("unknown tag in PopoPrivKey", "obj");
			}
		}

		// Token: 0x0600422F RID: 16943 RVA: 0x0012A9ED File Offset: 0x00128BED
		public static global::Org.BouncyCastle.Asn1.Crmf.PopoPrivKey GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged, bool isExplicit)
		{
			return new global::Org.BouncyCastle.Asn1.Crmf.PopoPrivKey(global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(tagged, true));
		}

		// Token: 0x06004230 RID: 16944 RVA: 0x0012A9FB File Offset: 0x00128BFB
		public PopoPrivKey(global::Org.BouncyCastle.Asn1.Crmf.SubsequentMessage msg)
		{
			this.tagNo = 1;
			this.obj = msg;
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06004231 RID: 16945 RVA: 0x0012AA11 File Offset: 0x00128C11
		public virtual int Type
		{
			get
			{
				return this.tagNo;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06004232 RID: 16946 RVA: 0x0012AA19 File Offset: 0x00128C19
		public virtual global::Org.BouncyCastle.Asn1.Asn1Encodable Value
		{
			get
			{
				return this.obj;
			}
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x0012AA21 File Offset: 0x00128C21
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, this.tagNo, this.obj);
		}

		// Token: 0x04001FDA RID: 8154
		public const int thisMessage = 0;

		// Token: 0x04001FDB RID: 8155
		public const int subsequentMessage = 1;

		// Token: 0x04001FDC RID: 8156
		public const int dhMAC = 2;

		// Token: 0x04001FDD RID: 8157
		public const int agreeMAC = 3;

		// Token: 0x04001FDE RID: 8158
		public const int encryptedKey = 4;

		// Token: 0x04001FDF RID: 8159
		private readonly int tagNo;

		// Token: 0x04001FE0 RID: 8160
		private readonly global::Org.BouncyCastle.Asn1.Asn1Encodable obj;
	}
}
