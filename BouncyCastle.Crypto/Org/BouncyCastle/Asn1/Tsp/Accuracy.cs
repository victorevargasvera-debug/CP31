using System;

namespace Org.BouncyCastle.Asn1.Tsp
{
	// Token: 0x02000697 RID: 1687
	public class Accuracy : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003E12 RID: 15890 RVA: 0x0011B610 File Offset: 0x00119810
		public Accuracy(global::Org.BouncyCastle.Asn1.DerInteger seconds, global::Org.BouncyCastle.Asn1.DerInteger millis, global::Org.BouncyCastle.Asn1.DerInteger micros)
		{
			if (millis != null)
			{
				int millisValue = millis.IntValueExact;
				if (millisValue < 1 || millisValue > 999)
				{
					throw new global::System.ArgumentException("Invalid millis field : not in (1..999)");
				}
			}
			if (micros != null)
			{
				int microsValue = micros.IntValueExact;
				if (microsValue < 1 || microsValue > 999)
				{
					throw new global::System.ArgumentException("Invalid micros field : not in (1..999)");
				}
			}
			this.seconds = seconds;
			this.millis = millis;
			this.micros = micros;
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x0011B67C File Offset: 0x0011987C
		private Accuracy(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			for (int i = 0; i < seq.Count; i++)
			{
				if (seq[i] is global::Org.BouncyCastle.Asn1.DerInteger)
				{
					this.seconds = (global::Org.BouncyCastle.Asn1.DerInteger)seq[i];
				}
				else if (seq[i] is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
				{
					global::Org.BouncyCastle.Asn1.Asn1TaggedObject extra = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)seq[i];
					int tagNo = extra.TagNo;
					if (tagNo != 0)
					{
						if (tagNo != 1)
						{
							throw new global::System.ArgumentException("Invalid tag number");
						}
						this.micros = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(extra, false);
						int microsValue = this.micros.IntValueExact;
						if (microsValue < 1 || microsValue > 999)
						{
							throw new global::System.ArgumentException("Invalid micros field : not in (1..999)");
						}
					}
					else
					{
						this.millis = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(extra, false);
						int millisValue = this.millis.IntValueExact;
						if (millisValue < 1 || millisValue > 999)
						{
							throw new global::System.ArgumentException("Invalid millis field : not in (1..999)");
						}
					}
				}
			}
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x0011B767 File Offset: 0x00119967
		public static global::Org.BouncyCastle.Asn1.Tsp.Accuracy GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Tsp.Accuracy)
			{
				return (global::Org.BouncyCastle.Asn1.Tsp.Accuracy)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.Tsp.Accuracy(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06003E15 RID: 15893 RVA: 0x0011B788 File Offset: 0x00119988
		public global::Org.BouncyCastle.Asn1.DerInteger Seconds
		{
			get
			{
				return this.seconds;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06003E16 RID: 15894 RVA: 0x0011B790 File Offset: 0x00119990
		public global::Org.BouncyCastle.Asn1.DerInteger Millis
		{
			get
			{
				return this.millis;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06003E17 RID: 15895 RVA: 0x0011B798 File Offset: 0x00119998
		public global::Org.BouncyCastle.Asn1.DerInteger Micros
		{
			get
			{
				return this.micros;
			}
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x0011B7A0 File Offset: 0x001199A0
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.seconds
			});
			v.AddOptionalTagged(false, 0, this.millis);
			v.AddOptionalTagged(false, 1, this.micros);
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001BD6 RID: 7126
		private readonly global::Org.BouncyCastle.Asn1.DerInteger seconds;

		// Token: 0x04001BD7 RID: 7127
		private readonly global::Org.BouncyCastle.Asn1.DerInteger millis;

		// Token: 0x04001BD8 RID: 7128
		private readonly global::Org.BouncyCastle.Asn1.DerInteger micros;

		// Token: 0x04001BD9 RID: 7129
		protected const int MinMillis = 1;

		// Token: 0x04001BDA RID: 7130
		protected const int MaxMillis = 999;

		// Token: 0x04001BDB RID: 7131
		protected const int MinMicros = 1;

		// Token: 0x04001BDC RID: 7132
		protected const int MaxMicros = 999;
	}
}
