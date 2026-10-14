using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.CryptoPro
{
	// Token: 0x02000723 RID: 1827
	public class Gost3410ParamSetParameters : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060041A4 RID: 16804 RVA: 0x001295E5 File Offset: 0x001277E5
		public static global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x001295F3 File Offset: 0x001277F3
		public static global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters)
			{
				return (global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.CryptoPro.Gost3410ParamSetParameters((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid GOST3410Parameter: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x00129630 File Offset: 0x00127830
		public Gost3410ParamSetParameters(int keySize, global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger a)
		{
			this.keySize = keySize;
			this.p = new global::Org.BouncyCastle.Asn1.DerInteger(p);
			this.q = new global::Org.BouncyCastle.Asn1.DerInteger(q);
			this.a = new global::Org.BouncyCastle.Asn1.DerInteger(a);
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x00129664 File Offset: 0x00127864
		private Gost3410ParamSetParameters(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 4)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.keySize = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]).IntValueExact;
			this.p = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[1]);
			this.q = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[2]);
			this.a = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[3]);
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x060041A8 RID: 16808 RVA: 0x001296DD File Offset: 0x001278DD
		public int KeySize
		{
			get
			{
				return this.keySize;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x060041A9 RID: 16809 RVA: 0x001296E5 File Offset: 0x001278E5
		public global::Org.BouncyCastle.Math.BigInteger P
		{
			get
			{
				return this.p.PositiveValue;
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x060041AA RID: 16810 RVA: 0x001296F2 File Offset: 0x001278F2
		public global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return this.q.PositiveValue;
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060041AB RID: 16811 RVA: 0x001296FF File Offset: 0x001278FF
		public global::Org.BouncyCastle.Math.BigInteger A
		{
			get
			{
				return this.a.PositiveValue;
			}
		}

		// Token: 0x060041AC RID: 16812 RVA: 0x0012970C File Offset: 0x0012790C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				new global::Org.BouncyCastle.Asn1.DerInteger(this.keySize),
				this.p,
				this.q,
				this.a
			});
		}

		// Token: 0x04001F96 RID: 8086
		private readonly int keySize;

		// Token: 0x04001F97 RID: 8087
		private readonly global::Org.BouncyCastle.Asn1.DerInteger p;

		// Token: 0x04001F98 RID: 8088
		private readonly global::Org.BouncyCastle.Asn1.DerInteger q;

		// Token: 0x04001F99 RID: 8089
		private readonly global::Org.BouncyCastle.Asn1.DerInteger a;
	}
}
