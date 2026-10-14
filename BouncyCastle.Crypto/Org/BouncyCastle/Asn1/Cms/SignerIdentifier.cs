using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000763 RID: 1891
	public class SignerIdentifier : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06004393 RID: 17299 RVA: 0x0012E720 File Offset: 0x0012C920
		public SignerIdentifier(global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber id)
		{
			this.id = id;
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x0012E72F File Offset: 0x0012C92F
		public SignerIdentifier(global::Org.BouncyCastle.Asn1.Asn1OctetString id)
		{
			this.id = new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 0, id);
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x0012E745 File Offset: 0x0012C945
		public SignerIdentifier(global::Org.BouncyCastle.Asn1.Asn1Object id)
		{
			this.id = id;
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x0012E754 File Offset: 0x0012C954
		public static global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier GetInstance(object o)
		{
			if (o == null || o is global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier)o;
			}
			if (o is global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier((global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber)o);
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1OctetString)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier((global::Org.BouncyCastle.Asn1.Asn1OctetString)o);
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1Object)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier((global::Org.BouncyCastle.Asn1.Asn1Object)o);
			}
			throw new global::System.ArgumentException("Illegal object in SignerIdentifier: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o));
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06004397 RID: 17303 RVA: 0x0012E7C4 File Offset: 0x0012C9C4
		public bool IsTagged
		{
			get
			{
				return this.id is global::Org.BouncyCastle.Asn1.Asn1TaggedObject;
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06004398 RID: 17304 RVA: 0x0012E7D4 File Offset: 0x0012C9D4
		public global::Org.BouncyCastle.Asn1.Asn1Encodable ID
		{
			get
			{
				if (this.id is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
				{
					return global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)this.id, false);
				}
				return this.id;
			}
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x0012E7FB File Offset: 0x0012C9FB
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.id.ToAsn1Object();
		}

		// Token: 0x0400207F RID: 8319
		private global::Org.BouncyCastle.Asn1.Asn1Encodable id;
	}
}
