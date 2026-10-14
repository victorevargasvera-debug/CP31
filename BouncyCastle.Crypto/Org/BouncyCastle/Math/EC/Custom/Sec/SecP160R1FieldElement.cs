using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200024B RID: 587
	internal class SecP160R1FieldElement : global::Org.BouncyCastle.Math.EC.AbstractFpFieldElement
	{
		// Token: 0x060017C3 RID: 6083 RVA: 0x00072638 File Offset: 0x00070838
		public SecP160R1FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.CompareTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement.Q) >= 0)
			{
				throw new global::System.ArgumentException("value invalid for SecP160R1FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.FromBigInteger(x);
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x00072676 File Offset: 0x00070876
		public SecP160R1FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x00072689 File Offset: 0x00070889
		protected internal SecP160R1FieldElement(uint[] x)
		{
			this.x = x;
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x00072698 File Offset: 0x00070898
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat160.IsZero(this.x);
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x000726A5 File Offset: 0x000708A5
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat160.IsOne(this.x);
			}
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x000726B2 File Offset: 0x000708B2
		public override bool TestBitZero()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat160.GetBit(this.x, 0) == 1U;
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x000726C3 File Offset: 0x000708C3
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat160.ToBigInteger(this.x);
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x000726D0 File Offset: 0x000708D0
		public override string FieldName
		{
			get
			{
				return "SecP160R1Field";
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x000726D7 File Offset: 0x000708D7
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement.Q.BitLength;
			}
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x000726E4 File Offset: 0x000708E4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement(z);
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x00072714 File Offset: 0x00070914
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement(z);
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x0007273C File Offset: 0x0007093C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Subtract(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement(z);
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x0007276C File Offset: 0x0007096C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement(z);
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x0007279C File Offset: 0x0007099C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Inv(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement)b).x, z);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Multiply(z, this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement(z);
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x000727D4 File Offset: 0x000709D4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Negate(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement(z);
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x000727FC File Offset: 0x000709FC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement(z);
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x00072824 File Offset: 0x00070A24
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Inv(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement(z);
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x0007284C File Offset: 0x00070A4C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			uint[] x = this.x;
			if (global::Org.BouncyCastle.Math.Raw.Nat160.IsZero(x) || global::Org.BouncyCastle.Math.Raw.Nat160.IsOne(x))
			{
				return this;
			}
			uint[] x2 = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Square(x, x2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Multiply(x2, x, x2);
			uint[] x3 = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.SquareN(x2, 2, x3);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Multiply(x3, x2, x3);
			uint[] x4 = x2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.SquareN(x3, 4, x4);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Multiply(x4, x3, x4);
			uint[] x5 = x3;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.SquareN(x4, 8, x5);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Multiply(x5, x4, x5);
			uint[] x6 = x4;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.SquareN(x5, 16, x6);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Multiply(x6, x5, x6);
			uint[] x7 = x5;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.SquareN(x6, 32, x7);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Multiply(x7, x6, x7);
			uint[] x8 = x6;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.SquareN(x7, 64, x8);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Multiply(x8, x7, x8);
			uint[] x9 = x7;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Square(x8, x9);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Multiply(x9, x, x9);
			uint[] t = x9;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.SquareN(t, 29, t);
			uint[] t2 = x8;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Square(t, t2);
			if (!global::Org.BouncyCastle.Math.Raw.Nat160.Eq(x, t2))
			{
				return null;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement(t);
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00072958 File Offset: 0x00070B58
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement);
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x00072966 File Offset: 0x00070B66
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement);
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x00072974 File Offset: 0x00070B74
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat160.Eq(this.x, other.x));
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00072992 File Offset: 0x00070B92
		public override int GetHashCode()
		{
			return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement.Q.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 5);
		}

		// Token: 0x04000A18 RID: 2584
		public static readonly global::Org.BouncyCastle.Math.BigInteger Q = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF7FFFFFFF"));

		// Token: 0x04000A19 RID: 2585
		protected internal readonly uint[] x;
	}
}
