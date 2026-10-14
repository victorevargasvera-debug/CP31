using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000755 RID: 1877
	public class OriginatorIdentifierOrKey : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06004319 RID: 17177 RVA: 0x0012D378 File Offset: 0x0012B578
		public OriginatorIdentifierOrKey(global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber id)
		{
			this.id = id;
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x0012D387 File Offset: 0x0012B587
		[global::System.Obsolete("Use version taking a 'SubjectKeyIdentifier'")]
		public OriginatorIdentifierOrKey(global::Org.BouncyCastle.Asn1.Asn1OctetString id) : this(new global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier(id))
		{
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x0012D395 File Offset: 0x0012B595
		public OriginatorIdentifierOrKey(global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier id)
		{
			this.id = new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 0, id);
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x0012D3AB File Offset: 0x0012B5AB
		public OriginatorIdentifierOrKey(global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey id)
		{
			this.id = new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 1, id);
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x0012D3C1 File Offset: 0x0012B5C1
		[global::System.Obsolete("Use more specific version")]
		public OriginatorIdentifierOrKey(global::Org.BouncyCastle.Asn1.Asn1Object id)
		{
			this.id = id;
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x0012D3D0 File Offset: 0x0012B5D0
		private OriginatorIdentifierOrKey(global::Org.BouncyCastle.Asn1.Asn1TaggedObject id)
		{
			this.id = id;
		}

		// Token: 0x0600431F RID: 17183 RVA: 0x0012D3DF File Offset: 0x0012B5DF
		public static global::Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject o, bool explicitly)
		{
			if (!explicitly)
			{
				throw new global::System.ArgumentException("Can't implicitly tag OriginatorIdentifierOrKey");
			}
			return global::Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey.GetInstance(o.GetObject());
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x0012D3FC File Offset: 0x0012B5FC
		public static global::Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey GetInstance(object o)
		{
			if (o == null || o is global::Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey)o;
			}
			if (o is global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey((global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber)o);
			}
			if (o is global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey((global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier)o);
			}
			if (o is global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey((global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey)o);
			}
			if (o is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.OriginatorIdentifierOrKey((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)o);
			}
			throw new global::System.ArgumentException("Invalid OriginatorIdentifierOrKey: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o));
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06004321 RID: 17185 RVA: 0x0012D480 File Offset: 0x0012B680
		public global::Org.BouncyCastle.Asn1.Asn1Encodable ID
		{
			get
			{
				return this.id;
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06004322 RID: 17186 RVA: 0x0012D488 File Offset: 0x0012B688
		public global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber IssuerAndSerialNumber
		{
			get
			{
				if (this.id is global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber)
				{
					return (global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber)this.id;
				}
				return null;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06004323 RID: 17187 RVA: 0x0012D4A4 File Offset: 0x0012B6A4
		public global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier SubjectKeyIdentifier
		{
			get
			{
				if (this.id is global::Org.BouncyCastle.Asn1.Asn1TaggedObject && ((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)this.id).TagNo == 0)
				{
					return global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)this.id, false);
				}
				return null;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06004324 RID: 17188 RVA: 0x0012D4D8 File Offset: 0x0012B6D8
		[global::System.Obsolete("Use 'OriginatorPublicKey' property")]
		public global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey OriginatorKey
		{
			get
			{
				return this.OriginatorPublicKey;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06004325 RID: 17189 RVA: 0x0012D4E0 File Offset: 0x0012B6E0
		public global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey OriginatorPublicKey
		{
			get
			{
				if (this.id is global::Org.BouncyCastle.Asn1.Asn1TaggedObject && ((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)this.id).TagNo == 1)
				{
					return global::Org.BouncyCastle.Asn1.Cms.OriginatorPublicKey.GetInstance((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)this.id, false);
				}
				return null;
			}
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x0012D515 File Offset: 0x0012B715
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.id.ToAsn1Object();
		}

		// Token: 0x04002056 RID: 8278
		private global::Org.BouncyCastle.Asn1.Asn1Encodable id;
	}
}
