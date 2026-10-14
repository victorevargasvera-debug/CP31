using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.CryptoPro
{
	// Token: 0x02000720 RID: 1824
	public class ECGost3410ParamSetParameters : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004192 RID: 16786 RVA: 0x001291DD File Offset: 0x001273DD
		public static global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410ParamSetParameters GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410ParamSetParameters.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06004193 RID: 16787 RVA: 0x001291EB File Offset: 0x001273EB
		public static global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410ParamSetParameters GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410ParamSetParameters)
			{
				return (global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410ParamSetParameters)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.CryptoPro.ECGost3410ParamSetParameters((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid GOST3410Parameter: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x06004194 RID: 16788 RVA: 0x00129228 File Offset: 0x00127428
		public ECGost3410ParamSetParameters(global::Org.BouncyCastle.Math.BigInteger a, global::Org.BouncyCastle.Math.BigInteger b, global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, int x, global::Org.BouncyCastle.Math.BigInteger y)
		{
			this.a = new global::Org.BouncyCastle.Asn1.DerInteger(a);
			this.b = new global::Org.BouncyCastle.Asn1.DerInteger(b);
			this.p = new global::Org.BouncyCastle.Asn1.DerInteger(p);
			this.q = new global::Org.BouncyCastle.Asn1.DerInteger(q);
			this.x = new global::Org.BouncyCastle.Asn1.DerInteger(x);
			this.y = new global::Org.BouncyCastle.Asn1.DerInteger(y);
		}

		// Token: 0x06004195 RID: 16789 RVA: 0x00129288 File Offset: 0x00127488
		public ECGost3410ParamSetParameters(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 6)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.a = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
			this.b = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[1]);
			this.p = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[2]);
			this.q = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[3]);
			this.x = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[4]);
			this.y = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[5]);
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06004196 RID: 16790 RVA: 0x00129320 File Offset: 0x00127520
		public global::Org.BouncyCastle.Math.BigInteger P
		{
			get
			{
				return this.p.PositiveValue;
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06004197 RID: 16791 RVA: 0x0012932D File Offset: 0x0012752D
		public global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return this.q.PositiveValue;
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06004198 RID: 16792 RVA: 0x0012933A File Offset: 0x0012753A
		public global::Org.BouncyCastle.Math.BigInteger A
		{
			get
			{
				return this.a.PositiveValue;
			}
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x00129348 File Offset: 0x00127548
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.a,
				this.b,
				this.p,
				this.q,
				this.x,
				this.y
			});
		}

		// Token: 0x04001F89 RID: 8073
		internal readonly global::Org.BouncyCastle.Asn1.DerInteger p;

		// Token: 0x04001F8A RID: 8074
		internal readonly global::Org.BouncyCastle.Asn1.DerInteger q;

		// Token: 0x04001F8B RID: 8075
		internal readonly global::Org.BouncyCastle.Asn1.DerInteger a;

		// Token: 0x04001F8C RID: 8076
		internal readonly global::Org.BouncyCastle.Asn1.DerInteger b;

		// Token: 0x04001F8D RID: 8077
		internal readonly global::Org.BouncyCastle.Asn1.DerInteger x;

		// Token: 0x04001F8E RID: 8078
		internal readonly global::Org.BouncyCastle.Asn1.DerInteger y;
	}
}
