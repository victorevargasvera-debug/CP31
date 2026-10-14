using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x0200070A RID: 1802
	public class CrlOcspRef : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004105 RID: 16645 RVA: 0x00126A38 File Offset: 0x00124C38
		public static global::Org.BouncyCastle.Asn1.Esf.CrlOcspRef GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.CrlOcspRef)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.CrlOcspRef)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.CrlOcspRef((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'CrlOcspRef' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x00126A88 File Offset: 0x00124C88
		private CrlOcspRef(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			foreach (object obj in seq)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject asn1TaggedObject = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
				global::Org.BouncyCastle.Asn1.Asn1Object asn1Obj = asn1TaggedObject.GetObject();
				switch (asn1TaggedObject.TagNo)
				{
				case 0:
					this.crlids = global::Org.BouncyCastle.Asn1.Esf.CrlListID.GetInstance(asn1Obj);
					break;
				case 1:
					this.ocspids = global::Org.BouncyCastle.Asn1.Esf.OcspListID.GetInstance(asn1Obj);
					break;
				case 2:
					this.otherRev = global::Org.BouncyCastle.Asn1.Esf.OtherRevRefs.GetInstance(asn1Obj);
					break;
				default:
					throw new global::System.ArgumentException("Illegal tag in CrlOcspRef", "seq");
				}
			}
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x00126B44 File Offset: 0x00124D44
		public CrlOcspRef(global::Org.BouncyCastle.Asn1.Esf.CrlListID crlids, global::Org.BouncyCastle.Asn1.Esf.OcspListID ocspids, global::Org.BouncyCastle.Asn1.Esf.OtherRevRefs otherRev)
		{
			this.crlids = crlids;
			this.ocspids = ocspids;
			this.otherRev = otherRev;
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06004108 RID: 16648 RVA: 0x00126B61 File Offset: 0x00124D61
		public global::Org.BouncyCastle.Asn1.Esf.CrlListID CrlIDs
		{
			get
			{
				return this.crlids;
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06004109 RID: 16649 RVA: 0x00126B69 File Offset: 0x00124D69
		public global::Org.BouncyCastle.Asn1.Esf.OcspListID OcspIDs
		{
			get
			{
				return this.ocspids;
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x0600410A RID: 16650 RVA: 0x00126B71 File Offset: 0x00124D71
		public global::Org.BouncyCastle.Asn1.Esf.OtherRevRefs OtherRev
		{
			get
			{
				return this.otherRev;
			}
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x00126B7C File Offset: 0x00124D7C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			if (this.crlids != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 0, this.crlids.ToAsn1Object()));
			}
			if (this.ocspids != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 1, this.ocspids.ToAsn1Object()));
			}
			if (this.otherRev != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 2, this.otherRev.ToAsn1Object()));
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001F22 RID: 7970
		private readonly global::Org.BouncyCastle.Asn1.Esf.CrlListID crlids;

		// Token: 0x04001F23 RID: 7971
		private readonly global::Org.BouncyCastle.Asn1.Esf.OcspListID ocspids;

		// Token: 0x04001F24 RID: 7972
		private readonly global::Org.BouncyCastle.Asn1.Esf.OtherRevRefs otherRev;
	}
}
