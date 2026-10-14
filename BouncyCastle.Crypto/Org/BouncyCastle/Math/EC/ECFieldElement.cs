using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x0200020B RID: 523
	public abstract class ECFieldElement
	{
		// Token: 0x060014AD RID: 5293
		public abstract global::Org.BouncyCastle.Math.BigInteger ToBigInteger();

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060014AE RID: 5294
		public abstract string FieldName { get; }

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060014AF RID: 5295
		public abstract int FieldSize { get; }

		// Token: 0x060014B0 RID: 5296
		public abstract global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b);

		// Token: 0x060014B1 RID: 5297
		public abstract global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne();

		// Token: 0x060014B2 RID: 5298
		public abstract global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b);

		// Token: 0x060014B3 RID: 5299
		public abstract global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b);

		// Token: 0x060014B4 RID: 5300
		public abstract global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b);

		// Token: 0x060014B5 RID: 5301
		public abstract global::Org.BouncyCastle.Math.EC.ECFieldElement Negate();

		// Token: 0x060014B6 RID: 5302
		public abstract global::Org.BouncyCastle.Math.EC.ECFieldElement Square();

		// Token: 0x060014B7 RID: 5303
		public abstract global::Org.BouncyCastle.Math.EC.ECFieldElement Invert();

		// Token: 0x060014B8 RID: 5304
		public abstract global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt();

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060014B9 RID: 5305 RVA: 0x00061429 File Offset: 0x0005F629
		public virtual int BitLength
		{
			get
			{
				return this.ToBigInteger().BitLength;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x00061436 File Offset: 0x0005F636
		public virtual bool IsOne
		{
			get
			{
				return this.BitLength == 1;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x00061441 File Offset: 0x0005F641
		public virtual bool IsZero
		{
			get
			{
				return this.ToBigInteger().SignValue == 0;
			}
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00061451 File Offset: 0x0005F651
		public virtual global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.Multiply(b).Subtract(x.Multiply(y));
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00061466 File Offset: 0x0005F666
		public virtual global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyPlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.Multiply(b).Add(x.Multiply(y));
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0006147B File Offset: 0x0005F67B
		public virtual global::Org.BouncyCastle.Math.EC.ECFieldElement SquareMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.Square().Subtract(x.Multiply(y));
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0006148F File Offset: 0x0005F68F
		public virtual global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.Square().Add(x.Multiply(y));
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x000614A4 File Offset: 0x0005F6A4
		public virtual global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePow(int pow)
		{
			global::Org.BouncyCastle.Math.EC.ECFieldElement r = this;
			for (int i = 0; i < pow; i++)
			{
				r = r.Square();
			}
			return r;
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x000614C7 File Offset: 0x0005F6C7
		public virtual bool TestBitZero()
		{
			return this.ToBigInteger().TestBit(0);
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x000614D5 File Offset: 0x0005F6D5
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.ECFieldElement);
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x000614E3 File Offset: 0x0005F6E3
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this == other || (other != null && this.ToBigInteger().Equals(other.ToBigInteger()));
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00061501 File Offset: 0x0005F701
		public override int GetHashCode()
		{
			return this.ToBigInteger().GetHashCode();
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x0006150E File Offset: 0x0005F70E
		public override string ToString()
		{
			return this.ToBigInteger().ToString(16);
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x0006151D File Offset: 0x0005F71D
		public virtual byte[] GetEncoded()
		{
			return global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray((this.FieldSize + 7) / 8, this.ToBigInteger());
		}
	}
}
