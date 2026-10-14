using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x0200075D RID: 1885
	public class RecipientIdentifier : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x0600435A RID: 17242 RVA: 0x0012DBA6 File Offset: 0x0012BDA6
		public RecipientIdentifier(global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber id)
		{
			this.id = id;
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x0012DBB5 File Offset: 0x0012BDB5
		public RecipientIdentifier(global::Org.BouncyCastle.Asn1.Asn1OctetString id)
		{
			this.id = new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 0, id);
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x0012DBCB File Offset: 0x0012BDCB
		public RecipientIdentifier(global::Org.BouncyCastle.Asn1.Asn1Object id)
		{
			this.id = id;
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x0012DBDC File Offset: 0x0012BDDC
		public static global::Org.BouncyCastle.Asn1.Cms.RecipientIdentifier GetInstance(object o)
		{
			if (o == null || o is global::Org.BouncyCastle.Asn1.Cms.RecipientIdentifier)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.RecipientIdentifier)o;
			}
			if (o is global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.RecipientIdentifier((global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber)o);
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1OctetString)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.RecipientIdentifier((global::Org.BouncyCastle.Asn1.Asn1OctetString)o);
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1Object)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.RecipientIdentifier((global::Org.BouncyCastle.Asn1.Asn1Object)o);
			}
			throw new global::System.ArgumentException("Illegal object in RecipientIdentifier: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o));
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x0600435E RID: 17246 RVA: 0x0012DC4C File Offset: 0x0012BE4C
		public bool IsTagged
		{
			get
			{
				return this.id is global::Org.BouncyCastle.Asn1.Asn1TaggedObject;
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x0600435F RID: 17247 RVA: 0x0012DC5C File Offset: 0x0012BE5C
		public global::Org.BouncyCastle.Asn1.Asn1Encodable ID
		{
			get
			{
				if (this.id is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
				{
					return global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)this.id, false);
				}
				return global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber.GetInstance(this.id);
			}
		}

		// Token: 0x06004360 RID: 17248 RVA: 0x0012DC88 File Offset: 0x0012BE88
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.id.ToAsn1Object();
		}

		// Token: 0x04002067 RID: 8295
		private global::Org.BouncyCastle.Asn1.Asn1Encodable id;
	}
}
