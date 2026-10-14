using System;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x0200070D RID: 1805
	public class OcspIdentifier : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004115 RID: 16661 RVA: 0x00126E04 File Offset: 0x00125004
		public static global::Org.BouncyCastle.Asn1.Esf.OcspIdentifier GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.OcspIdentifier)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.OcspIdentifier)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.OcspIdentifier((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in 'OcspIdentifier' factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x00126E54 File Offset: 0x00125054
		private OcspIdentifier(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			this.ocspResponderID = global::Org.BouncyCastle.Asn1.Ocsp.ResponderID.GetInstance(seq[0].ToAsn1Object());
			this.producedAt = (global::Org.BouncyCastle.Asn1.DerGeneralizedTime)seq[1].ToAsn1Object();
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x00126ECF File Offset: 0x001250CF
		public OcspIdentifier(global::Org.BouncyCastle.Asn1.Ocsp.ResponderID ocspResponderID, global::System.DateTime producedAt)
		{
			if (ocspResponderID == null)
			{
				throw new global::System.ArgumentNullException();
			}
			this.ocspResponderID = ocspResponderID;
			this.producedAt = new global::Org.BouncyCastle.Asn1.DerGeneralizedTime(producedAt);
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06004118 RID: 16664 RVA: 0x00126EF3 File Offset: 0x001250F3
		public global::Org.BouncyCastle.Asn1.Ocsp.ResponderID OcspResponderID
		{
			get
			{
				return this.ocspResponderID;
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06004119 RID: 16665 RVA: 0x00126EFB File Offset: 0x001250FB
		public global::System.DateTime ProducedAt
		{
			get
			{
				return this.producedAt.ToDateTime();
			}
		}

		// Token: 0x0600411A RID: 16666 RVA: 0x00126F08 File Offset: 0x00125108
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.ocspResponderID,
				this.producedAt
			});
		}

		// Token: 0x04001F35 RID: 7989
		private readonly global::Org.BouncyCastle.Asn1.Ocsp.ResponderID ocspResponderID;

		// Token: 0x04001F36 RID: 7990
		private readonly global::Org.BouncyCastle.Asn1.DerGeneralizedTime producedAt;
	}
}
