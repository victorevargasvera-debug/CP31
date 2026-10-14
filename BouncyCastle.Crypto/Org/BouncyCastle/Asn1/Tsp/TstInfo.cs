using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Tsp
{
	// Token: 0x0200069B RID: 1691
	public class TstInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003E2F RID: 15919 RVA: 0x0011BB61 File Offset: 0x00119D61
		public static global::Org.BouncyCastle.Asn1.Tsp.TstInfo GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Tsp.TstInfo)
			{
				return (global::Org.BouncyCastle.Asn1.Tsp.TstInfo)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.Tsp.TstInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x0011BB84 File Offset: 0x00119D84
		private TstInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			global::System.Collections.IEnumerator e = seq.GetEnumerator();
			e.MoveNext();
			this.version = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(e.Current);
			e.MoveNext();
			this.tsaPolicyId = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(e.Current);
			e.MoveNext();
			this.messageImprint = global::Org.BouncyCastle.Asn1.Tsp.MessageImprint.GetInstance(e.Current);
			e.MoveNext();
			this.serialNumber = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(e.Current);
			e.MoveNext();
			this.genTime = global::Org.BouncyCastle.Asn1.DerGeneralizedTime.GetInstance(e.Current);
			this.ordering = global::Org.BouncyCastle.Asn1.DerBoolean.False;
			while (e.MoveNext())
			{
				object obj = e.Current;
				global::Org.BouncyCastle.Asn1.Asn1Object o = (global::Org.BouncyCastle.Asn1.Asn1Object)obj;
				if (o is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
				{
					global::Org.BouncyCastle.Asn1.DerTaggedObject tagged = (global::Org.BouncyCastle.Asn1.DerTaggedObject)o;
					int tagNo = tagged.TagNo;
					if (tagNo != 0)
					{
						if (tagNo != 1)
						{
							throw new global::System.ArgumentException("Unknown tag value " + tagged.TagNo.ToString());
						}
						this.extensions = global::Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(tagged, false);
					}
					else
					{
						this.tsa = global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(tagged, true);
					}
				}
				if (o is global::Org.BouncyCastle.Asn1.DerSequence)
				{
					this.accuracy = global::Org.BouncyCastle.Asn1.Tsp.Accuracy.GetInstance(o);
				}
				if (o is global::Org.BouncyCastle.Asn1.DerBoolean)
				{
					this.ordering = global::Org.BouncyCastle.Asn1.DerBoolean.GetInstance(o);
				}
				if (o is global::Org.BouncyCastle.Asn1.DerInteger)
				{
					this.nonce = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(o);
				}
			}
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x0011BCD8 File Offset: 0x00119ED8
		public TstInfo(global::Org.BouncyCastle.Asn1.DerObjectIdentifier tsaPolicyId, global::Org.BouncyCastle.Asn1.Tsp.MessageImprint messageImprint, global::Org.BouncyCastle.Asn1.DerInteger serialNumber, global::Org.BouncyCastle.Asn1.DerGeneralizedTime genTime, global::Org.BouncyCastle.Asn1.Tsp.Accuracy accuracy, global::Org.BouncyCastle.Asn1.DerBoolean ordering, global::Org.BouncyCastle.Asn1.DerInteger nonce, global::Org.BouncyCastle.Asn1.X509.GeneralName tsa, global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			this.version = new global::Org.BouncyCastle.Asn1.DerInteger(1);
			this.tsaPolicyId = tsaPolicyId;
			this.messageImprint = messageImprint;
			this.serialNumber = serialNumber;
			this.genTime = genTime;
			this.accuracy = accuracy;
			this.ordering = ordering;
			this.nonce = nonce;
			this.tsa = tsa;
			this.extensions = extensions;
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06003E32 RID: 15922 RVA: 0x0011BD3C File Offset: 0x00119F3C
		public global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return this.version;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06003E33 RID: 15923 RVA: 0x0011BD44 File Offset: 0x00119F44
		public global::Org.BouncyCastle.Asn1.Tsp.MessageImprint MessageImprint
		{
			get
			{
				return this.messageImprint;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06003E34 RID: 15924 RVA: 0x0011BD4C File Offset: 0x00119F4C
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier Policy
		{
			get
			{
				return this.tsaPolicyId;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06003E35 RID: 15925 RVA: 0x0011BD54 File Offset: 0x00119F54
		public global::Org.BouncyCastle.Asn1.DerInteger SerialNumber
		{
			get
			{
				return this.serialNumber;
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06003E36 RID: 15926 RVA: 0x0011BD5C File Offset: 0x00119F5C
		public global::Org.BouncyCastle.Asn1.Tsp.Accuracy Accuracy
		{
			get
			{
				return this.accuracy;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06003E37 RID: 15927 RVA: 0x0011BD64 File Offset: 0x00119F64
		public global::Org.BouncyCastle.Asn1.DerGeneralizedTime GenTime
		{
			get
			{
				return this.genTime;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06003E38 RID: 15928 RVA: 0x0011BD6C File Offset: 0x00119F6C
		public global::Org.BouncyCastle.Asn1.DerBoolean Ordering
		{
			get
			{
				return this.ordering;
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06003E39 RID: 15929 RVA: 0x0011BD74 File Offset: 0x00119F74
		public global::Org.BouncyCastle.Asn1.DerInteger Nonce
		{
			get
			{
				return this.nonce;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06003E3A RID: 15930 RVA: 0x0011BD7C File Offset: 0x00119F7C
		public global::Org.BouncyCastle.Asn1.X509.GeneralName Tsa
		{
			get
			{
				return this.tsa;
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06003E3B RID: 15931 RVA: 0x0011BD84 File Offset: 0x00119F84
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions Extensions
		{
			get
			{
				return this.extensions;
			}
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x0011BD8C File Offset: 0x00119F8C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.version,
				this.tsaPolicyId,
				this.messageImprint,
				this.serialNumber,
				this.genTime
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.accuracy
			});
			if (this.ordering != null && this.ordering.IsTrue)
			{
				v.Add(this.ordering);
			}
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.nonce
			});
			v.AddOptionalTagged(true, 0, this.tsa);
			v.AddOptionalTagged(false, 1, this.extensions);
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001BE7 RID: 7143
		private readonly global::Org.BouncyCastle.Asn1.DerInteger version;

		// Token: 0x04001BE8 RID: 7144
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier tsaPolicyId;

		// Token: 0x04001BE9 RID: 7145
		private readonly global::Org.BouncyCastle.Asn1.Tsp.MessageImprint messageImprint;

		// Token: 0x04001BEA RID: 7146
		private readonly global::Org.BouncyCastle.Asn1.DerInteger serialNumber;

		// Token: 0x04001BEB RID: 7147
		private readonly global::Org.BouncyCastle.Asn1.DerGeneralizedTime genTime;

		// Token: 0x04001BEC RID: 7148
		private readonly global::Org.BouncyCastle.Asn1.Tsp.Accuracy accuracy;

		// Token: 0x04001BED RID: 7149
		private readonly global::Org.BouncyCastle.Asn1.DerBoolean ordering;

		// Token: 0x04001BEE RID: 7150
		private readonly global::Org.BouncyCastle.Asn1.DerInteger nonce;

		// Token: 0x04001BEF RID: 7151
		private readonly global::Org.BouncyCastle.Asn1.X509.GeneralName tsa;

		// Token: 0x04001BF0 RID: 7152
		private readonly global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions;
	}
}
