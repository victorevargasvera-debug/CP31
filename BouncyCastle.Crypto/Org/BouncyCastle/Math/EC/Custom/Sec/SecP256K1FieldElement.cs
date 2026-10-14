using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000263 RID: 611
	internal class SecP256K1FieldElement : global::Org.BouncyCastle.Math.EC.AbstractFpFieldElement
	{
		// Token: 0x06001958 RID: 6488 RVA: 0x000785DD File Offset: 0x000767DD
		public SecP256K1FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.CompareTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement.Q) >= 0)
			{
				throw new global::System.ArgumentException("value invalid for SecP256K1FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.FromBigInteger(x);
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x0007861B File Offset: 0x0007681B
		public SecP256K1FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x0007862E File Offset: 0x0007682E
		protected internal SecP256K1FieldElement(uint[] x)
		{
			this.x = x;
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x0007863D File Offset: 0x0007683D
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat256.IsZero(this.x);
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x0007864A File Offset: 0x0007684A
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat256.IsOne(this.x);
			}
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x00078657 File Offset: 0x00076857
		public override bool TestBitZero()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat256.GetBit(this.x, 0) == 1U;
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x00078668 File Offset: 0x00076868
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat256.ToBigInteger(this.x);
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600195F RID: 6495 RVA: 0x00078675 File Offset: 0x00076875
		public override string FieldName
		{
			get
			{
				return "SecP256K1Field";
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x0007867C File Offset: 0x0007687C
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement.Q.BitLength;
			}
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00078688 File Offset: 0x00076888
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(z);
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x000786B8 File Offset: 0x000768B8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(z);
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x000786E0 File Offset: 0x000768E0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Subtract(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(z);
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x00078710 File Offset: 0x00076910
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(z);
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00078740 File Offset: 0x00076940
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Inv(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement)b).x, z);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(z, this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(z);
		}

		// Token: 0x06001966 RID: 6502 RVA: 0x00078778 File Offset: 0x00076978
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Negate(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(z);
		}

		// Token: 0x06001967 RID: 6503 RVA: 0x000787A0 File Offset: 0x000769A0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(z);
		}

		// Token: 0x06001968 RID: 6504 RVA: 0x000787C8 File Offset: 0x000769C8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Inv(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(z);
		}

		// Token: 0x06001969 RID: 6505 RVA: 0x000787F0 File Offset: 0x000769F0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			uint[] x = this.x;
			if (global::Org.BouncyCastle.Math.Raw.Nat256.IsZero(x) || global::Org.BouncyCastle.Math.Raw.Nat256.IsOne(x))
			{
				return this;
			}
			uint[] x2 = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Square(x, x2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(x2, x, x2);
			uint[] x3 = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Square(x2, x3);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(x3, x, x3);
			uint[] x4 = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.SquareN(x3, 3, x4);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(x4, x3, x4);
			uint[] x5 = x4;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.SquareN(x4, 3, x5);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(x5, x3, x5);
			uint[] x6 = x5;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.SquareN(x5, 2, x6);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(x6, x2, x6);
			uint[] x7 = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.SquareN(x6, 11, x7);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(x7, x6, x7);
			uint[] x8 = x6;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.SquareN(x7, 22, x8);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(x8, x7, x8);
			uint[] x9 = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.SquareN(x8, 44, x9);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(x9, x8, x9);
			uint[] x10 = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.SquareN(x9, 88, x10);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(x10, x9, x10);
			uint[] x11 = x9;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.SquareN(x10, 44, x11);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(x11, x8, x11);
			uint[] x12 = x8;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.SquareN(x11, 3, x12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(x12, x3, x12);
			uint[] t = x12;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.SquareN(t, 23, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(t, x7, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.SquareN(t, 6, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(t, x2, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.SquareN(t, 2, t);
			uint[] t2 = x2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Square(t, t2);
			if (!global::Org.BouncyCastle.Math.Raw.Nat256.Eq(x, t2))
			{
				return null;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(t);
		}

		// Token: 0x0600196A RID: 6506 RVA: 0x0007897E File Offset: 0x00076B7E
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement);
		}

		// Token: 0x0600196B RID: 6507 RVA: 0x0007898C File Offset: 0x00076B8C
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement);
		}

		// Token: 0x0600196C RID: 6508 RVA: 0x0007899A File Offset: 0x00076B9A
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat256.Eq(this.x, other.x));
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x000789B8 File Offset: 0x00076BB8
		public override int GetHashCode()
		{
			return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement.Q.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 8);
		}

		// Token: 0x04000A65 RID: 2661
		public static readonly global::Org.BouncyCastle.Math.BigInteger Q = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFC2F"));

		// Token: 0x04000A66 RID: 2662
		protected internal readonly uint[] x;
	}
}
