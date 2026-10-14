using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x0200074F RID: 1871
	public class KekIdentifier : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060042E7 RID: 17127 RVA: 0x0012CBCD File Offset: 0x0012ADCD
		public KekIdentifier(byte[] keyIdentifier, global::Org.BouncyCastle.Asn1.DerGeneralizedTime date, global::Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute other)
		{
			this.keyIdentifier = new global::Org.BouncyCastle.Asn1.DerOctetString(keyIdentifier);
			this.date = date;
			this.other = other;
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x0012CBF0 File Offset: 0x0012ADF0
		public KekIdentifier(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.keyIdentifier = (global::Org.BouncyCastle.Asn1.Asn1OctetString)seq[0];
			switch (seq.Count)
			{
			case 1:
				return;
			case 2:
				if (seq[1] is global::Org.BouncyCastle.Asn1.DerGeneralizedTime)
				{
					this.date = (global::Org.BouncyCastle.Asn1.DerGeneralizedTime)seq[1];
					return;
				}
				this.other = global::Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute.GetInstance(seq[2]);
				return;
			case 3:
				this.date = (global::Org.BouncyCastle.Asn1.DerGeneralizedTime)seq[1];
				this.other = global::Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute.GetInstance(seq[2]);
				return;
			default:
				throw new global::System.ArgumentException("Invalid KekIdentifier");
			}
		}

		// Token: 0x060042E9 RID: 17129 RVA: 0x0012CC96 File Offset: 0x0012AE96
		public static global::Org.BouncyCastle.Asn1.Cms.KekIdentifier GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Cms.KekIdentifier.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x060042EA RID: 17130 RVA: 0x0012CCA4 File Offset: 0x0012AEA4
		public static global::Org.BouncyCastle.Asn1.Cms.KekIdentifier GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.KekIdentifier)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.KekIdentifier)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.KekIdentifier((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid KekIdentifier: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x060042EB RID: 17131 RVA: 0x0012CCE1 File Offset: 0x0012AEE1
		public global::Org.BouncyCastle.Asn1.Asn1OctetString KeyIdentifier
		{
			get
			{
				return this.keyIdentifier;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x060042EC RID: 17132 RVA: 0x0012CCE9 File Offset: 0x0012AEE9
		public global::Org.BouncyCastle.Asn1.DerGeneralizedTime Date
		{
			get
			{
				return this.date;
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x060042ED RID: 17133 RVA: 0x0012CCF1 File Offset: 0x0012AEF1
		public global::Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute Other
		{
			get
			{
				return this.other;
			}
		}

		// Token: 0x060042EE RID: 17134 RVA: 0x0012CCFC File Offset: 0x0012AEFC
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.keyIdentifier
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.date,
				this.other
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04002040 RID: 8256
		private global::Org.BouncyCastle.Asn1.Asn1OctetString keyIdentifier;

		// Token: 0x04002041 RID: 8257
		private global::Org.BouncyCastle.Asn1.DerGeneralizedTime date;

		// Token: 0x04002042 RID: 8258
		private global::Org.BouncyCastle.Asn1.Cms.OtherKeyAttribute other;
	}
}
