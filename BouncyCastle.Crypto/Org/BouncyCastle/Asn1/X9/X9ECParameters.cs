using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Math.Field;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x02000636 RID: 1590
	public class X9ECParameters : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003AFF RID: 15103 RVA: 0x001104D8 File Offset: 0x0010E6D8
		public static global::Org.BouncyCastle.Asn1.X9.X9ECParameters GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.X9.X9ECParameters)
			{
				return (global::Org.BouncyCastle.Asn1.X9.X9ECParameters)obj;
			}
			if (obj != null)
			{
				return new global::Org.BouncyCastle.Asn1.X9.X9ECParameters(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
			}
			return null;
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x001104FC File Offset: 0x0010E6FC
		public X9ECParameters(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (!(seq[0] is global::Org.BouncyCastle.Asn1.DerInteger) || !((global::Org.BouncyCastle.Asn1.DerInteger)seq[0]).HasValue(1))
			{
				throw new global::System.ArgumentException("bad version in X9ECParameters");
			}
			this.n = ((global::Org.BouncyCastle.Asn1.DerInteger)seq[4]).Value;
			if (seq.Count == 6)
			{
				this.h = ((global::Org.BouncyCastle.Asn1.DerInteger)seq[5]).Value;
			}
			global::Org.BouncyCastle.Asn1.X9.X9Curve x9c = new global::Org.BouncyCastle.Asn1.X9.X9Curve(global::Org.BouncyCastle.Asn1.X9.X9FieldID.GetInstance(seq[1]), this.n, this.h, global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(seq[2]));
			this.curve = x9c.Curve;
			object p = seq[3];
			if (p is global::Org.BouncyCastle.Asn1.X9.X9ECPoint)
			{
				this.g = (global::Org.BouncyCastle.Asn1.X9.X9ECPoint)p;
			}
			else
			{
				this.g = new global::Org.BouncyCastle.Asn1.X9.X9ECPoint(this.curve, (global::Org.BouncyCastle.Asn1.Asn1OctetString)p);
			}
			this.seed = x9c.GetSeed();
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x001105EA File Offset: 0x0010E7EA
		public X9ECParameters(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECPoint g, global::Org.BouncyCastle.Math.BigInteger n) : this(curve, g, n, null, null)
		{
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x001105F7 File Offset: 0x0010E7F7
		public X9ECParameters(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Asn1.X9.X9ECPoint g, global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger h) : this(curve, g, n, h, null)
		{
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x00110605 File Offset: 0x0010E805
		public X9ECParameters(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECPoint g, global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger h) : this(curve, g, n, h, null)
		{
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x00110613 File Offset: 0x0010E813
		public X9ECParameters(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECPoint g, global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger h, byte[] seed) : this(curve, new global::Org.BouncyCastle.Asn1.X9.X9ECPoint(g), n, h, seed)
		{
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x00110628 File Offset: 0x0010E828
		public X9ECParameters(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Asn1.X9.X9ECPoint g, global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger h, byte[] seed)
		{
			this.curve = curve;
			this.g = g;
			this.n = n;
			this.h = h;
			this.seed = seed;
			if (global::Org.BouncyCastle.Math.EC.ECAlgorithms.IsFpCurve(curve))
			{
				this.fieldID = new global::Org.BouncyCastle.Asn1.X9.X9FieldID(curve.Field.Characteristic);
				return;
			}
			if (!global::Org.BouncyCastle.Math.EC.ECAlgorithms.IsF2mCurve(curve))
			{
				throw new global::System.ArgumentException("'curve' is of an unsupported type");
			}
			int[] exponents = ((global::Org.BouncyCastle.Math.Field.IPolynomialExtensionField)curve.Field).MinimalPolynomial.GetExponentsPresent();
			if (exponents.Length == 3)
			{
				this.fieldID = new global::Org.BouncyCastle.Asn1.X9.X9FieldID(exponents[2], exponents[1]);
				return;
			}
			if (exponents.Length == 5)
			{
				this.fieldID = new global::Org.BouncyCastle.Asn1.X9.X9FieldID(exponents[4], exponents[1], exponents[2], exponents[3]);
				return;
			}
			throw new global::System.ArgumentException("Only trinomial and pentomial curves are supported");
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06003B06 RID: 15110 RVA: 0x001106E8 File Offset: 0x0010E8E8
		public global::Org.BouncyCastle.Math.EC.ECCurve Curve
		{
			get
			{
				return this.curve;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06003B07 RID: 15111 RVA: 0x001106F0 File Offset: 0x0010E8F0
		public global::Org.BouncyCastle.Math.EC.ECPoint G
		{
			get
			{
				return this.g.Point;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06003B08 RID: 15112 RVA: 0x001106FD File Offset: 0x0010E8FD
		public global::Org.BouncyCastle.Math.BigInteger N
		{
			get
			{
				return this.n;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06003B09 RID: 15113 RVA: 0x00110705 File Offset: 0x0010E905
		public global::Org.BouncyCastle.Math.BigInteger H
		{
			get
			{
				return this.h;
			}
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x0011070D File Offset: 0x0010E90D
		public byte[] GetSeed()
		{
			return this.seed;
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06003B0B RID: 15115 RVA: 0x00110715 File Offset: 0x0010E915
		public global::Org.BouncyCastle.Asn1.X9.X9Curve CurveEntry
		{
			get
			{
				return new global::Org.BouncyCastle.Asn1.X9.X9Curve(this.curve, this.seed);
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06003B0C RID: 15116 RVA: 0x00110728 File Offset: 0x0010E928
		public global::Org.BouncyCastle.Asn1.X9.X9FieldID FieldIDEntry
		{
			get
			{
				return this.fieldID;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06003B0D RID: 15117 RVA: 0x00110730 File Offset: 0x0010E930
		public global::Org.BouncyCastle.Asn1.X9.X9ECPoint BaseEntry
		{
			get
			{
				return this.g;
			}
		}

		// Token: 0x06003B0E RID: 15118 RVA: 0x00110738 File Offset: 0x0010E938
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				new global::Org.BouncyCastle.Asn1.DerInteger(global::Org.BouncyCastle.Math.BigInteger.One),
				this.fieldID,
				new global::Org.BouncyCastle.Asn1.X9.X9Curve(this.curve, this.seed),
				this.g,
				new global::Org.BouncyCastle.Asn1.DerInteger(this.n)
			});
			if (this.h != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerInteger(this.h));
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x040019CF RID: 6607
		private global::Org.BouncyCastle.Asn1.X9.X9FieldID fieldID;

		// Token: 0x040019D0 RID: 6608
		private global::Org.BouncyCastle.Math.EC.ECCurve curve;

		// Token: 0x040019D1 RID: 6609
		private global::Org.BouncyCastle.Asn1.X9.X9ECPoint g;

		// Token: 0x040019D2 RID: 6610
		private global::Org.BouncyCastle.Math.BigInteger n;

		// Token: 0x040019D3 RID: 6611
		private global::Org.BouncyCastle.Math.BigInteger h;

		// Token: 0x040019D4 RID: 6612
		private byte[] seed;
	}
}
