using System;
using System.Collections;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x02000632 RID: 1586
	public class OtherInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003ADE RID: 15070 RVA: 0x0010FD21 File Offset: 0x0010DF21
		public OtherInfo(global::Org.BouncyCastle.Asn1.X9.KeySpecificInfo keyInfo, global::Org.BouncyCastle.Asn1.Asn1OctetString partyAInfo, global::Org.BouncyCastle.Asn1.Asn1OctetString suppPubInfo)
		{
			this.keyInfo = keyInfo;
			this.partyAInfo = partyAInfo;
			this.suppPubInfo = suppPubInfo;
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x0010FD40 File Offset: 0x0010DF40
		public OtherInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			global::System.Collections.IEnumerator e = seq.GetEnumerator();
			e.MoveNext();
			this.keyInfo = new global::Org.BouncyCastle.Asn1.X9.KeySpecificInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)e.Current);
			while (e.MoveNext())
			{
				object obj = e.Current;
				global::Org.BouncyCastle.Asn1.DerTaggedObject o = (global::Org.BouncyCastle.Asn1.DerTaggedObject)obj;
				if (o.TagNo == 0)
				{
					this.partyAInfo = (global::Org.BouncyCastle.Asn1.Asn1OctetString)o.GetObject();
				}
				else if (o.TagNo == 2)
				{
					this.suppPubInfo = (global::Org.BouncyCastle.Asn1.Asn1OctetString)o.GetObject();
				}
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06003AE0 RID: 15072 RVA: 0x0010FDC2 File Offset: 0x0010DFC2
		public global::Org.BouncyCastle.Asn1.X9.KeySpecificInfo KeyInfo
		{
			get
			{
				return this.keyInfo;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06003AE1 RID: 15073 RVA: 0x0010FDCA File Offset: 0x0010DFCA
		public global::Org.BouncyCastle.Asn1.Asn1OctetString PartyAInfo
		{
			get
			{
				return this.partyAInfo;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06003AE2 RID: 15074 RVA: 0x0010FDD2 File Offset: 0x0010DFD2
		public global::Org.BouncyCastle.Asn1.Asn1OctetString SuppPubInfo
		{
			get
			{
				return this.suppPubInfo;
			}
		}

		// Token: 0x06003AE3 RID: 15075 RVA: 0x0010FDDA File Offset: 0x0010DFDA
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector asn1EncodableVector = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.keyInfo
			});
			asn1EncodableVector.AddOptionalTagged(true, 0, this.partyAInfo);
			asn1EncodableVector.Add(new global::Org.BouncyCastle.Asn1.DerTaggedObject(2, this.suppPubInfo));
			return new global::Org.BouncyCastle.Asn1.DerSequence(asn1EncodableVector);
		}

		// Token: 0x040019C5 RID: 6597
		private global::Org.BouncyCastle.Asn1.X9.KeySpecificInfo keyInfo;

		// Token: 0x040019C6 RID: 6598
		private global::Org.BouncyCastle.Asn1.Asn1OctetString partyAInfo;

		// Token: 0x040019C7 RID: 6599
		private global::Org.BouncyCastle.Asn1.Asn1OctetString suppPubInfo;
	}
}
