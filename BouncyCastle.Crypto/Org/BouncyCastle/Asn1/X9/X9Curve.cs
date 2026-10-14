using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x02000635 RID: 1589
	public class X9Curve : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003AF8 RID: 15096 RVA: 0x001101E5 File Offset: 0x0010E3E5
		public X9Curve(global::Org.BouncyCastle.Math.EC.ECCurve curve) : this(curve, null)
		{
		}

		// Token: 0x06003AF9 RID: 15097 RVA: 0x001101F0 File Offset: 0x0010E3F0
		public X9Curve(global::Org.BouncyCastle.Math.EC.ECCurve curve, byte[] seed)
		{
			if (curve == null)
			{
				throw new global::System.ArgumentNullException("curve");
			}
			this.curve = curve;
			this.seed = global::Org.BouncyCastle.Utilities.Arrays.Clone(seed);
			if (global::Org.BouncyCastle.Math.EC.ECAlgorithms.IsFpCurve(curve))
			{
				this.fieldIdentifier = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeField;
				return;
			}
			if (global::Org.BouncyCastle.Math.EC.ECAlgorithms.IsF2mCurve(curve))
			{
				this.fieldIdentifier = global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CharacteristicTwoField;
				return;
			}
			throw new global::System.ArgumentException("This type of ECCurve is not implemented");
		}

		// Token: 0x06003AFA RID: 15098 RVA: 0x00110256 File Offset: 0x0010E456
		[global::System.Obsolete("Use constructor including order/cofactor")]
		public X9Curve(global::Org.BouncyCastle.Asn1.X9.X9FieldID fieldID, global::Org.BouncyCastle.Asn1.Asn1Sequence seq) : this(fieldID, null, null, seq)
		{
		}

		// Token: 0x06003AFB RID: 15099 RVA: 0x00110264 File Offset: 0x0010E464
		public X9Curve(global::Org.BouncyCastle.Asn1.X9.X9FieldID fieldID, global::Org.BouncyCastle.Math.BigInteger order, global::Org.BouncyCastle.Math.BigInteger cofactor, global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (fieldID == null)
			{
				throw new global::System.ArgumentNullException("fieldID");
			}
			if (seq == null)
			{
				throw new global::System.ArgumentNullException("seq");
			}
			this.fieldIdentifier = fieldID.Identifier;
			if (this.fieldIdentifier.Equals(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeField))
			{
				global::Org.BouncyCastle.Math.BigInteger p = ((global::Org.BouncyCastle.Asn1.DerInteger)fieldID.Parameters).Value;
				global::Org.BouncyCastle.Math.BigInteger A = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[0]).GetOctets());
				global::Org.BouncyCastle.Math.BigInteger B = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[1]).GetOctets());
				this.curve = new global::Org.BouncyCastle.Math.EC.FpCurve(p, A, B, order, cofactor);
			}
			else
			{
				if (!this.fieldIdentifier.Equals(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CharacteristicTwoField))
				{
					throw new global::System.ArgumentException("This type of ECCurve is not implemented");
				}
				global::Org.BouncyCastle.Asn1.DerSequence parameters = (global::Org.BouncyCastle.Asn1.DerSequence)fieldID.Parameters;
				int i = ((global::Org.BouncyCastle.Asn1.DerInteger)parameters[0]).IntValueExact;
				object obj = (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)parameters[1];
				int k2 = 0;
				int k3 = 0;
				int k4;
				if (obj.Equals(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.TPBasis))
				{
					k4 = ((global::Org.BouncyCastle.Asn1.DerInteger)parameters[2]).IntValueExact;
				}
				else
				{
					global::Org.BouncyCastle.Asn1.DerSequence derSequence = (global::Org.BouncyCastle.Asn1.DerSequence)parameters[2];
					k4 = ((global::Org.BouncyCastle.Asn1.DerInteger)derSequence[0]).IntValueExact;
					k2 = ((global::Org.BouncyCastle.Asn1.DerInteger)derSequence[1]).IntValueExact;
					k3 = ((global::Org.BouncyCastle.Asn1.DerInteger)derSequence[2]).IntValueExact;
				}
				global::Org.BouncyCastle.Math.BigInteger A2 = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[0]).GetOctets());
				global::Org.BouncyCastle.Math.BigInteger B2 = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[1]).GetOctets());
				this.curve = new global::Org.BouncyCastle.Math.EC.F2mCurve(i, k4, k2, k3, A2, B2, order, cofactor);
			}
			if (seq.Count == 3)
			{
				this.seed = ((global::Org.BouncyCastle.Asn1.DerBitString)seq[2]).GetBytes();
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x06003AFC RID: 15100 RVA: 0x00110434 File Offset: 0x0010E634
		public global::Org.BouncyCastle.Math.EC.ECCurve Curve
		{
			get
			{
				return this.curve;
			}
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x0011043C File Offset: 0x0010E63C
		public byte[] GetSeed()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.seed);
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x0011044C File Offset: 0x0010E64C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			if (this.fieldIdentifier.Equals(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.PrimeField) || this.fieldIdentifier.Equals(global::Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.CharacteristicTwoField))
			{
				v.Add(new global::Org.BouncyCastle.Asn1.X9.X9FieldElement(this.curve.A).ToAsn1Object());
				v.Add(new global::Org.BouncyCastle.Asn1.X9.X9FieldElement(this.curve.B).ToAsn1Object());
			}
			if (this.seed != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerBitString(this.seed));
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x040019CC RID: 6604
		private readonly global::Org.BouncyCastle.Math.EC.ECCurve curve;

		// Token: 0x040019CD RID: 6605
		private readonly byte[] seed;

		// Token: 0x040019CE RID: 6606
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier fieldIdentifier;
	}
}
