using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200026B RID: 619
	internal class SecP384R1FieldElement : global::Org.BouncyCastle.Math.EC.AbstractFpFieldElement
	{
		// Token: 0x060019DF RID: 6623 RVA: 0x0007A90A File Offset: 0x00078B0A
		public SecP384R1FieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.CompareTo(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement.Q) >= 0)
			{
				throw new global::System.ArgumentException("value invalid for SecP384R1FieldElement", "x");
			}
			this.x = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.FromBigInteger(x);
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x0007A948 File Offset: 0x00078B48
		public SecP384R1FieldElement()
		{
			this.x = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0007A95D File Offset: 0x00078B5D
		protected internal SecP384R1FieldElement(uint[] x)
		{
			this.x = x;
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x0007A96C File Offset: 0x00078B6C
		public override bool IsZero
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IsZero(12, this.x);
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x0007A97B File Offset: 0x00078B7B
		public override bool IsOne
		{
			get
			{
				return global::Org.BouncyCastle.Math.Raw.Nat.IsOne(12, this.x);
			}
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x0007A98A File Offset: 0x00078B8A
		public override bool TestBitZero()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat.GetBit(this.x, 0) == 1U;
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0007A99B File Offset: 0x00078B9B
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return global::Org.BouncyCastle.Math.Raw.Nat.ToBigInteger(12, this.x);
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x0007A9AA File Offset: 0x00078BAA
		public override string FieldName
		{
			get
			{
				return "SecP384R1Field";
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x0007A9B1 File Offset: 0x00078BB1
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement.Q.BitLength;
			}
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x0007A9C0 File Offset: 0x00078BC0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Add(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(z);
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x0007A9F4 File Offset: 0x00078BF4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.AddOne(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(z);
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x0007AA1C File Offset: 0x00078C1C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(z);
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x0007AA50 File Offset: 0x00078C50
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(this.x, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)b).x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(z);
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x0007AA84 File Offset: 0x00078C84
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Inv(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)b).x, z);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(z, this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(z);
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x0007AAC0 File Offset: 0x00078CC0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Negate(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(z);
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x0007AAE8 File Offset: 0x00078CE8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(z);
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x0007AB10 File Offset: 0x00078D10
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			uint[] z = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Inv(this.x, z);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(z);
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x0007AB38 File Offset: 0x00078D38
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			uint[] x = this.x;
			if (global::Org.BouncyCastle.Math.Raw.Nat.IsZero(12, x) || global::Org.BouncyCastle.Math.Raw.Nat.IsOne(12, x))
			{
				return this;
			}
			uint[] t = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			uint[] t2 = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			uint[] t3 = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			uint[] t4 = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(t, x, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(t, 2, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(t2, t, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(t2, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(t2, x, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(t2, 5, t3);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(t3, t2, t3);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(t3, 5, t4);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(t4, t2, t4);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(t4, 15, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(t2, t4, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(t2, 2, t3);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(t, t3, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(t3, 28, t3);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(t2, t3, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(t2, 60, t3);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(t3, t2, t3);
			uint[] r = t2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(t3, 120, r);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(r, t3, r);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(r, 15, r);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(r, t4, r);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(r, 33, r);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(r, t, r);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(r, 64, r);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(r, x, r);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.SquareN(r, 30, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(t, t2);
			if (!global::Org.BouncyCastle.Math.Raw.Nat.Eq(12, x, t2))
			{
				return null;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(t);
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x0007AC94 File Offset: 0x00078E94
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement);
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x0007ACA2 File Offset: 0x00078EA2
		public override bool Equals(global::Org.BouncyCastle.Math.EC.ECFieldElement other)
		{
			return this.Equals(other as global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement);
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x0007ACB0 File Offset: 0x00078EB0
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement other)
		{
			return this == other || (other != null && global::Org.BouncyCastle.Math.Raw.Nat.Eq(12, this.x, other.x));
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x0007ACD0 File Offset: 0x00078ED0
		public override int GetHashCode()
		{
			return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement.Q.GetHashCode() ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.x, 0, 12);
		}

		// Token: 0x04000A7C RID: 2684
		public static readonly global::Org.BouncyCastle.Math.BigInteger Q = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFF0000000000000000FFFFFFFF"));

		// Token: 0x04000A7D RID: 2685
		protected internal readonly uint[] x;
	}
}
