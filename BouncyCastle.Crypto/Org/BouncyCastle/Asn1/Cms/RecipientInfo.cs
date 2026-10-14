using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x0200075E RID: 1886
	public class RecipientInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06004361 RID: 17249 RVA: 0x0012DC95 File Offset: 0x0012BE95
		public RecipientInfo(global::Org.BouncyCastle.Asn1.Cms.KeyTransRecipientInfo info)
		{
			this.info = info;
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x0012DCA4 File Offset: 0x0012BEA4
		public RecipientInfo(global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientInfo info)
		{
			this.info = new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 1, info);
		}

		// Token: 0x06004363 RID: 17251 RVA: 0x0012DCBA File Offset: 0x0012BEBA
		public RecipientInfo(global::Org.BouncyCastle.Asn1.Cms.KekRecipientInfo info)
		{
			this.info = new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 2, info);
		}

		// Token: 0x06004364 RID: 17252 RVA: 0x0012DCD0 File Offset: 0x0012BED0
		public RecipientInfo(global::Org.BouncyCastle.Asn1.Cms.PasswordRecipientInfo info)
		{
			this.info = new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 3, info);
		}

		// Token: 0x06004365 RID: 17253 RVA: 0x0012DCE6 File Offset: 0x0012BEE6
		public RecipientInfo(global::Org.BouncyCastle.Asn1.Cms.OtherRecipientInfo info)
		{
			this.info = new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 4, info);
		}

		// Token: 0x06004366 RID: 17254 RVA: 0x0012DCFC File Offset: 0x0012BEFC
		public RecipientInfo(global::Org.BouncyCastle.Asn1.Asn1Object info)
		{
			this.info = info;
		}

		// Token: 0x06004367 RID: 17255 RVA: 0x0012DD0C File Offset: 0x0012BF0C
		public static global::Org.BouncyCastle.Asn1.Cms.RecipientInfo GetInstance(object o)
		{
			if (o == null || o is global::Org.BouncyCastle.Asn1.Cms.RecipientInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.RecipientInfo)o;
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.RecipientInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)o);
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.RecipientInfo((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)o);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o));
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06004368 RID: 17256 RVA: 0x0012DD68 File Offset: 0x0012BF68
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				if (!(this.info is global::Org.BouncyCastle.Asn1.Asn1TaggedObject))
				{
					return global::Org.BouncyCastle.Asn1.Cms.KeyTransRecipientInfo.GetInstance(this.info).Version;
				}
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject o = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)this.info;
				switch (o.TagNo)
				{
				case 1:
					return global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientInfo.GetInstance(o, false).Version;
				case 2:
					return this.GetKekInfo(o).Version;
				case 3:
					return global::Org.BouncyCastle.Asn1.Cms.PasswordRecipientInfo.GetInstance(o, false).Version;
				case 4:
					return new global::Org.BouncyCastle.Asn1.DerInteger(0);
				default:
					throw new global::System.InvalidOperationException("unknown tag");
				}
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06004369 RID: 17257 RVA: 0x0012DDF8 File Offset: 0x0012BFF8
		public bool IsTagged
		{
			get
			{
				return this.info is global::Org.BouncyCastle.Asn1.Asn1TaggedObject;
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x0600436A RID: 17258 RVA: 0x0012DE08 File Offset: 0x0012C008
		public global::Org.BouncyCastle.Asn1.Asn1Encodable Info
		{
			get
			{
				if (!(this.info is global::Org.BouncyCastle.Asn1.Asn1TaggedObject))
				{
					return global::Org.BouncyCastle.Asn1.Cms.KeyTransRecipientInfo.GetInstance(this.info);
				}
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject o = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)this.info;
				switch (o.TagNo)
				{
				case 1:
					return global::Org.BouncyCastle.Asn1.Cms.KeyAgreeRecipientInfo.GetInstance(o, false);
				case 2:
					return this.GetKekInfo(o);
				case 3:
					return global::Org.BouncyCastle.Asn1.Cms.PasswordRecipientInfo.GetInstance(o, false);
				case 4:
					return global::Org.BouncyCastle.Asn1.Cms.OtherRecipientInfo.GetInstance(o, false);
				default:
					throw new global::System.InvalidOperationException("unknown tag");
				}
			}
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x0012DE85 File Offset: 0x0012C085
		private global::Org.BouncyCastle.Asn1.Cms.KekRecipientInfo GetKekInfo(global::Org.BouncyCastle.Asn1.Asn1TaggedObject o)
		{
			return global::Org.BouncyCastle.Asn1.Cms.KekRecipientInfo.GetInstance(o, o.IsExplicit());
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x0012DE93 File Offset: 0x0012C093
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.info.ToAsn1Object();
		}

		// Token: 0x04002068 RID: 8296
		internal global::Org.BouncyCastle.Asn1.Asn1Encodable info;
	}
}
