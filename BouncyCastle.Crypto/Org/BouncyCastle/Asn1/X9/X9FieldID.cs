using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x0200063A RID: 1594
	public class X9FieldID : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003B1F RID: 15135 RVA: 0x0011096B File Offset: 0x0010EB6B
		public X9FieldID(global::Org.BouncyCastle.Math.BigInteger primeP)
		{
			this.id = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeField;
			this.parameters = new global::Org.BouncyCastle.Asn1.DerInteger(primeP);
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x0011098A File Offset: 0x0010EB8A
		public X9FieldID(int m, int k1) : this(m, k1, 0, 0)
		{
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x00110998 File Offset: 0x0010EB98
		public X9FieldID(int m, int k1, int k2, int k3)
		{
			this.id = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CharacteristicTwoField;
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector fieldIdParams = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				new global::Org.BouncyCastle.Asn1.DerInteger(m)
			});
			if (k2 == 0)
			{
				if (k3 != 0)
				{
					throw new global::System.ArgumentException("inconsistent k values");
				}
				fieldIdParams.Add(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
				{
					global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.TPBasis,
					new global::Org.BouncyCastle.Asn1.DerInteger(k1)
				});
			}
			else
			{
				if (k2 <= k1 || k3 <= k2)
				{
					throw new global::System.ArgumentException("inconsistent k values");
				}
				fieldIdParams.Add(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
				{
					global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PPBasis,
					new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
					{
						new global::Org.BouncyCastle.Asn1.DerInteger(k1),
						new global::Org.BouncyCastle.Asn1.DerInteger(k2),
						new global::Org.BouncyCastle.Asn1.DerInteger(k3)
					})
				});
			}
			this.parameters = new global::Org.BouncyCastle.Asn1.DerSequence(fieldIdParams);
		}

		// Token: 0x06003B22 RID: 15138 RVA: 0x00110A5A File Offset: 0x0010EC5A
		private X9FieldID(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.id = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(seq[0]);
			this.parameters = seq[1].ToAsn1Object();
		}

		// Token: 0x06003B23 RID: 15139 RVA: 0x00110A86 File Offset: 0x0010EC86
		public static global::Org.BouncyCastle.Asn1.X9.X9FieldID GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X9.X9FieldID)
			{
				return (global::Org.BouncyCastle.Asn1.X9.X9FieldID)obj;
			}
			if (obj == null)
			{
				return null;
			}
			return new global::Org.BouncyCastle.Asn1.X9.X9FieldID(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06003B24 RID: 15140 RVA: 0x00110AA7 File Offset: 0x0010ECA7
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier Identifier
		{
			get
			{
				return this.id;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06003B25 RID: 15141 RVA: 0x00110AAF File Offset: 0x0010ECAF
		public global::Org.BouncyCastle.Asn1.Asn1Object Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x06003B26 RID: 15142 RVA: 0x00110AB7 File Offset: 0x0010ECB7
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.id,
				this.parameters
			});
		}

		// Token: 0x040019DA RID: 6618
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier id;

		// Token: 0x040019DB RID: 6619
		private readonly global::Org.BouncyCastle.Asn1.Asn1Object parameters;
	}
}
