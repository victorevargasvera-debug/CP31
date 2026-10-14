using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200063D RID: 1597
	public class AccessDescription : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003B2D RID: 15149 RVA: 0x00111038 File Offset: 0x0010F238
		public static global::Org.BouncyCastle.Asn1.X509.AccessDescription GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X509.AccessDescription)
			{
				return (global::Org.BouncyCastle.Asn1.X509.AccessDescription)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.AccessDescription((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x00111077 File Offset: 0x0010F277
		private AccessDescription(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("wrong number of elements in sequence");
			}
			this.accessMethod = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[0]);
			this.accessLocation = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(seq[1]);
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x001110B7 File Offset: 0x0010F2B7
		public AccessDescription(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, global::Org.BouncyCastle.Asn1.X509.GeneralName location)
		{
			this.accessMethod = oid;
			this.accessLocation = location;
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06003B30 RID: 15152 RVA: 0x001110CD File Offset: 0x0010F2CD
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier AccessMethod
		{
			get
			{
				return this.accessMethod;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06003B31 RID: 15153 RVA: 0x001110D5 File Offset: 0x0010F2D5
		public global::Org.BouncyCastle.Asn1.X509.GeneralName AccessLocation
		{
			get
			{
				return this.accessLocation;
			}
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x001110DD File Offset: 0x0010F2DD
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.accessMethod,
				this.accessLocation
			});
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x001110FC File Offset: 0x0010F2FC
		public override string ToString()
		{
			return "AccessDescription: Oid(" + this.accessMethod.Id + ")";
		}

		// Token: 0x04001A1E RID: 6686
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdADCAIssuers = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7.48.2");

		// Token: 0x04001A1F RID: 6687
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier IdADOcsp = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("1.3.6.1.5.5.7.48.1");

		// Token: 0x04001A20 RID: 6688
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier accessMethod;

		// Token: 0x04001A21 RID: 6689
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName accessLocation;
	}
}
