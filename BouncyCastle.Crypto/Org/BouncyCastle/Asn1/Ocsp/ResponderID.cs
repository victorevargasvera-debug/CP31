using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Ocsp
{
	// Token: 0x020006CE RID: 1742
	public class ResponderID : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06003F94 RID: 16276 RVA: 0x00120A1C File Offset: 0x0011EC1C
		public static global::Org.BouncyCastle.Asn1.Ocsp.ResponderID GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Ocsp.ResponderID)
			{
				return (global::Org.BouncyCastle.Asn1.Ocsp.ResponderID)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.DerOctetString)
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.ResponderID((global::Org.BouncyCastle.Asn1.DerOctetString)obj);
			}
			if (!(obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject))
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.ResponderID(global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(obj));
			}
			global::Org.BouncyCastle.Asn1.Asn1TaggedObject o = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
			if (o.TagNo == 1)
			{
				return new global::Org.BouncyCastle.Asn1.Ocsp.ResponderID(global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(o, true));
			}
			return new global::Org.BouncyCastle.Asn1.Ocsp.ResponderID(global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(o, true));
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x00120A8C File Offset: 0x0011EC8C
		public ResponderID(global::Org.BouncyCastle.Asn1.Asn1OctetString id)
		{
			if (id == null)
			{
				throw new global::System.ArgumentNullException("id");
			}
			this.id = id;
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x00120AA9 File Offset: 0x0011ECA9
		public ResponderID(global::Org.BouncyCastle.Asn1.X509.X509Name id)
		{
			if (id == null)
			{
				throw new global::System.ArgumentNullException("id");
			}
			this.id = id;
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x00120AC6 File Offset: 0x0011ECC6
		public static global::Org.BouncyCastle.Asn1.Ocsp.ResponderID GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			return global::Org.BouncyCastle.Asn1.Ocsp.ResponderID.GetInstance(obj.GetObject());
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x00120AD3 File Offset: 0x0011ECD3
		public virtual byte[] GetKeyHash()
		{
			if (this.id is global::Org.BouncyCastle.Asn1.Asn1OctetString)
			{
				return ((global::Org.BouncyCastle.Asn1.Asn1OctetString)this.id).GetOctets();
			}
			return null;
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06003F99 RID: 16281 RVA: 0x00120AF4 File Offset: 0x0011ECF4
		public virtual global::Org.BouncyCastle.Asn1.X509.X509Name Name
		{
			get
			{
				if (this.id is global::Org.BouncyCastle.Asn1.Asn1OctetString)
				{
					return null;
				}
				return global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(this.id);
			}
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x00120B10 File Offset: 0x0011ED10
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			if (this.id is global::Org.BouncyCastle.Asn1.Asn1OctetString)
			{
				return new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 2, this.id);
			}
			return new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 1, this.id);
		}

		// Token: 0x04001D77 RID: 7543
		private readonly global::Org.BouncyCastle.Asn1.Asn1Encodable id;
	}
}
