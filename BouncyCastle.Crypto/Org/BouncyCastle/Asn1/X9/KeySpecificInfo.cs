using System;
using System.Collections;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x02000631 RID: 1585
	public class KeySpecificInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003AD9 RID: 15065 RVA: 0x0010FC8F File Offset: 0x0010DE8F
		public KeySpecificInfo(global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm, global::Org.BouncyCastle.Asn1.Asn1OctetString counter)
		{
			this.algorithm = algorithm;
			this.counter = counter;
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x0010FCA8 File Offset: 0x0010DEA8
		public KeySpecificInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			global::System.Collections.IEnumerator e = seq.GetEnumerator();
			e.MoveNext();
			this.algorithm = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)e.Current;
			e.MoveNext();
			this.counter = (global::Org.BouncyCastle.Asn1.Asn1OctetString)e.Current;
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06003ADB RID: 15067 RVA: 0x0010FCF2 File Offset: 0x0010DEF2
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier Algorithm
		{
			get
			{
				return this.algorithm;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06003ADC RID: 15068 RVA: 0x0010FCFA File Offset: 0x0010DEFA
		public global::Org.BouncyCastle.Asn1.Asn1OctetString Counter
		{
			get
			{
				return this.counter;
			}
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x0010FD02 File Offset: 0x0010DF02
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.algorithm,
				this.counter
			});
		}

		// Token: 0x040019C3 RID: 6595
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithm;

		// Token: 0x040019C4 RID: 6596
		private global::Org.BouncyCastle.Asn1.Asn1OctetString counter;
	}
}
