using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000253 RID: 595
	internal class SecP192K1FieldElement : global::Org.BouncyCastle.Math.EC.AbstractFpFieldElement
	{
		// Token: 0x06001847 RID: 6215 RVA: 0x0007447C File Offset: 0x0007267C
		public SecP192K1FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.CompareTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement.Q) >= 0)
			{
				throw new global::System.ArgumentException("value invalid for SecP192K1FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.FromBigInteger(x);
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x000744BA File Offset: 0x000726BA
		public SecP192K1FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x000744CD File Offset: 0x000726CD
		protected internal SecP192K1FieldElement(uint[] x)
		{
			this.x = x;
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x000744DC File Offset: 0x000726DC
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat192.IsZero(this.x);
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x000744E9 File Offset: 0x000726E9
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat192.IsOne(this.x);
			}
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x000744F6 File Offset: 0x000726F6
		public override bool TestBitZero()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat192.GetBit(this.x, 0) == 1U;
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00074507 File Offset: 0x00072707
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat192.ToBigInteger(this.x);
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x00074514 File Offset: 0x00072714
		public override string FieldName
		{
			get
			{
				return "SecP192K1Field";
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x0007451B File Offset: 0x0007271B
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement.Q.BitLength;
			}
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00074528 File Offset: 0x00072728
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement(z);
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x00074558 File Offset: 0x00072758
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement(z);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x00074580 File Offset: 0x00072780
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Subtract(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement(z);
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x000745B0 File Offset: 0x000727B0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement(z);
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x000745E0 File Offset: 0x000727E0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Inv(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement)b).x, z);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Multiply(z, this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement(z);
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00074618 File Offset: 0x00072818
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Negate(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement(z);
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00074640 File Offset: 0x00072840
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement(z);
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00074668 File Offset: 0x00072868
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Inv(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement(z);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00074690 File Offset: 0x00072890
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			uint[] x = this.x;
			if (global::Org.BouncyCastle.Math.Raw.Nat192.IsZero(x) || global::Org.BouncyCastle.Math.Raw.Nat192.IsOne(x))
			{
				return this;
			}
			uint[] x2 = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Square(x, x2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Multiply(x2, x, x2);
			uint[] x3 = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Square(x2, x3);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Multiply(x3, x, x3);
			uint[] x4 = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.SquareN(x3, 3, x4);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Multiply(x4, x3, x4);
			uint[] x5 = x4;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.SquareN(x4, 2, x5);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Multiply(x5, x2, x5);
			uint[] x6 = x2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.SquareN(x5, 8, x6);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Multiply(x6, x5, x6);
			uint[] x7 = x5;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.SquareN(x6, 3, x7);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Multiply(x7, x3, x7);
			uint[] x8 = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.SquareN(x7, 16, x8);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Multiply(x8, x6, x8);
			uint[] x9 = x6;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.SquareN(x8, 35, x9);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Multiply(x9, x8, x9);
			uint[] x10 = x8;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.SquareN(x9, 70, x10);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Multiply(x10, x9, x10);
			uint[] x11 = x9;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.SquareN(x10, 19, x11);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Multiply(x11, x7, x11);
			uint[] t = x11;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.SquareN(t, 20, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Multiply(t, x7, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.SquareN(t, 4, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Multiply(t, x3, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.SquareN(t, 6, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Multiply(t, x3, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Square(t, t);
			uint[] t2 = x3;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Square(t, t2);
			if (!global::Org.BouncyCastle.Math.Raw.Nat192.Eq(x, t2))
			{
				return null;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement(t);
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00074811 File Offset: 0x00072A11
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement);
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x0007481F File Offset: 0x00072A1F
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement);
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0007482D File Offset: 0x00072A2D
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat192.Eq(this.x, other.x));
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x0007484B File Offset: 0x00072A4B
		public override int GetHashCode()
		{
			return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement.Q.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 6);
		}

		// Token: 0x04000A32 RID: 2610
		public static readonly global::Org.BouncyCastle.Math.BigInteger Q = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFEE37"));

		// Token: 0x04000A33 RID: 2611
		protected internal readonly uint[] x;
	}
}
